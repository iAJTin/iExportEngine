﻿
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;

namespace iTin.Export.Writers
{
    using ComponentModel.Writer;
    using Model;

    /// <inheritdoc />
    /// <summary>
    /// Represents custom writer for Comma-Seperated Values (csv format).    
    /// </summary>
    [Export(typeof(IWriter))]
    [WriterOptions(Name = "CsvWriter", Author = "iTin", Company = "iTin", Version = 1, Extension = "csv", Description = "Comma-Separed Values Writer")]
    public class CsvWriter : BaseWriterDirect
    {
        #region private constant members

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string DelimiterChar = ";";

        #endregion

        #region private field static members

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static readonly char[] IllegalChars = { '"', DelimiterChar.ToCharArray()[0] };

        #endregion

        #region private field members

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private StringBuilder _documentBuilder;

        #endregion

        #region protected override methods

        /// <inheritdoc />
        /// <summary>
        /// Generates output in <c>CSV</c> format.
        /// </summary>
        protected override void Execute()
        {
            // document result
            _documentBuilder = new StringBuilder();

            // initialize
            var table = Provider.Input.Model.Table;
            var fields = table.Fields;
                
            // get target data
            var rows = Service.RawDataFiltered;

            // add field headers
            var fieldHeaderValues = fields.Select(field => field.Header.Show == YesNo.No ? string.Empty : ParseField(field.Alias)).ToList();
            _documentBuilder.Append(string.Join(DelimiterChar.ToString(CultureInfo.InvariantCulture), fieldHeaderValues.ToArray()));
            _documentBuilder.Append(table.Output.NewLineDelimiter);
                
            // data values
            foreach (var row in rows)
            {
                var values = new Collection<string>();
                foreach (var field in fields)
                {
                    field.DataSource = row;
                    var value = field.Value.GetValue(Provider.SpecialChars);
                    var parsedValue = ParseField(value.FormattedValue);
                    values.Add(parsedValue);
                }

                // add values.
                _documentBuilder.Append(string.Join(DelimiterChar, values.ToArray()));

                // new line defined in output tag.
                _documentBuilder.Append(table.Output.NewLineDelimiter);
            }

            // end of file
            _documentBuilder.Append(table.Output.EndOfFile);

            // add document to result list.
            Result.Add(Encoding.Unicode.GetBytes(_documentBuilder.ToString()));
        }

        #endregion

        #region private static methods

        /// <summary>
        /// Gets parsed value.
        /// </summary>
        /// <param name="value">Value to check.</param>
        /// <returns>
        /// Parsed value.
        /// </returns>
        private static string ParseField(string value)
        {
            var result = value;

            if (value.IndexOfAny(IllegalChars) != -1)
            {
                result = $"\"{value.Replace("\"", "\"\"")}\"";                
            }

            return result;
        }
        
        #endregion
    }
}
