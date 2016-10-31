using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;

using iTin.Export.ComponentModel;
using iTin.Export.Model;

namespace iTin.Export.Writers.Native
{
    /// <summary>
    /// Represents custom writer for Comma-Seperated Values (csv format).    
    /// </summary>
    [Export(typeof(IWriter))]
    [WriterOptions(Name = "CsvWriter", Author = "iTin", Company = "iTin", Version = 1, Extension = "csv", Description = "Comma-Separed Values Writer")]
    public class CsvWriter : BaseWriterDirect
    {
        #region Field Constant Members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string DelimiterChar = ";";
        #endregion

        #region Field Static Members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static readonly char[] IllegalChars = { '"', DelimiterChar.ToCharArray()[0] };
        #endregion

        #region Field Members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private StringBuilder documentBuilder;
        #endregion

        #region Protected Override Methods

            #region [protected] {override} (void) Execute(): Generates output in MS Excel format.
            /// <summary>
            /// Generates output in <c>CSV</c> format.
            /// </summary>
            protected override void Execute()
            {
                // document result
                documentBuilder = new StringBuilder();

                // initialize
                var fields = Table.Fields;
                
                // get target data
                var rows = Adapter.ToXml().ToArray();

                // add field headers
                var fieldHeaderValues = fields.Select(field => field.Header.Show == YesNo.No ? string.Empty : ParseField(field.Alias)).ToList();
                documentBuilder.Append(string.Join(DelimiterChar.ToString(CultureInfo.InvariantCulture), fieldHeaderValues.ToArray()));
                documentBuilder.Append(Table.Output.NewLineDelimiter);
                
                // data values
                foreach (var row in rows)
                {
                    var values = new Collection<string>();
                    foreach (var field in fields)
                    {
                        field.DataSource = row;
                        var value = field.Value.GetValue(Adapter.SpecialChars);
                        var parsedValue = ParseField(value.FormattedValue);
                        values.Add(parsedValue);
                    }

                    // add values.
                    documentBuilder.Append(string.Join(DelimiterChar, values.ToArray()));

                    // new line defined in output tag.
                    documentBuilder.Append(Table.Output.NewLineDelimiter);
                }

                // end of file
                documentBuilder.Append(Table.Output.EndOfFile);

                // add document to result list.
                Result.Add(Encoding.UTF8.GetBytes(documentBuilder.ToString()));
            }
            #endregion

        #endregion

        #region Private Static Methods

            #region [private] {static} (string) ParseField(string): Gets parsed value.
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
                    result = string.Format(CultureInfo.InvariantCulture, "\"{0}\"", value.Replace("\"", "\"\""));                
                }

                return result;
            }
            #endregion
        
        #endregion
    }
}
