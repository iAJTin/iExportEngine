
namespace iTin.Export.Writers
{
    using System.Collections.ObjectModel;
    using System.ComponentModel.Composition;
    using System.Diagnostics;
    using System.Globalization;
    using System.Linq;
    using System.Text;

    using ComponentModel.Writer;
    using Model;

    /// <inheritdoc />
    /// <summary>
    /// Represents custom writer for tab delimited text (txt format).
    /// </summary>
    [Export(typeof(IWriter))]
    [WriterOptions(Name = "TsvWriter", Author = "iTin", Company = "iTin", Version = 1, Extension = "txt", Description = "Tab-Separated Values Writer")]
    public class TsvWriter : BaseWriterDirect
    {
        #region private constant members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string DelimiterChar = "\t";
        #endregion

        #region private static readonly members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static readonly char[] IllegalChars = { '"', ';', DelimiterChar.ToCharArray()[0] };
        #endregion

        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private StringBuilder _documentBuilder;
        #endregion

        #region private properties

        #region [private] (TableModel) Table: Gets a reference to the table
        /// <summary>
        /// Gets a reference to the table.
        /// </summary>
        /// <value>
        /// Reference to the model table.
        /// </value>
        private TableModel Table => Provider.Input.Model.Table;
        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (void) Execute(): Generates the output in tab-separated values ​​format
        /// <inheritdoc />
        /// <summary>
        /// Generates the output in tab-separated values ​​format.
        /// </summary>
        protected override void Execute()
        {
            // document result
            _documentBuilder = new StringBuilder();

            // initialize
            var fields = Table.Fields;
                
            // get target data
            var rows = Provider.ToXml().ToArray();

            // headers
            var headerValues = fields.Select(field => field.Header.Show == YesNo.No ? string.Empty : ParseField(field.Alias)).ToList();
            _documentBuilder.Append(string.Join(DelimiterChar.ToString(CultureInfo.InvariantCulture), headerValues.ToArray()));
            _documentBuilder.Append(Table.Output.NewLineDelimiter);

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
                _documentBuilder.Append(Table.Output.NewLineDelimiter);
            }

            // end of file
            _documentBuilder.Append(Table.Output.EndOfFile);

            // add document to result list.
            Result.Add(Encoding.UTF8.GetBytes(_documentBuilder.ToString()));
        }
        #endregion

        #endregion

        #region private static methods

        #region [private] {static} (string) ParseField(string): Gets parsed value
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
        
        #endregion
    }
}
