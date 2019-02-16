
using System;
using System.Drawing;

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
    [WriterOptions(Name = "MarkdownWriter", Author = "iTin", Company = "iTin", Version = 1, Extension = "md", Description = "Markdown tabular Writer")]
    public class MarkdownWriter : BaseWriterDirect
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

        #region [private] (GlobalResourcesModel) Resources: Gets a reference to the model global resources
        /// <summary>
        /// Gets a reference to the model global resources.
        /// </summary>
        /// <value>
        /// Reference to the model global resources.
        /// </value>
        private GlobalResourcesModel Resources => Provider.Input.Resources;
        #endregion

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
            var rows = Service.RawDataFiltered;

            // headers
            var idx = 0;
            _documentBuilder.Append("|");
            var headerValues = fields.Select(field => field.Header.Show == YesNo.No ? string.Empty : ParseField(field.Alias)).ToList();
            var fontStyles = fields.Select(field => Resources.Styles.GetBy(field.Header.Style).Font.FontStyles);
            foreach (var fontStyle in fontStyles)
            {
                if (fontStyle == FontStyle.Bold)
                {
                    headerValues[idx] = $"**{headerValues[idx]}**";
                }
                else if (fontStyle == FontStyle.Italic)
                {
                    headerValues[idx] = $"*{headerValues[idx]}*";
                }
                else if (fontStyle == FontStyle.Underline)
                {
                    headerValues[idx] = $"<u>{headerValues[idx]}</u>";
                }
                else if (fontStyle == FontStyle.Strikeout)
                {
                    headerValues[idx] = $"~~{headerValues[idx]}~~";
                }
                else if ((fontStyle & FontStyle.Bold) == FontStyle.Bold && (fontStyle & FontStyle.Italic) == FontStyle.Italic)
                {
                    headerValues[idx] = $"***{headerValues[idx]}***";
                }
                else if ((fontStyle & FontStyle.Bold) == FontStyle.Bold && (fontStyle & FontStyle.Italic) == FontStyle.Italic && (fontStyle & FontStyle.Underline) == FontStyle.Underline)
                {
                    headerValues[idx] = $"***<u>{headerValues[idx]}</u>***";
                }
                else if ((fontStyle & FontStyle.Bold) == FontStyle.Bold && (fontStyle & FontStyle.Italic) == FontStyle.Italic && (fontStyle & FontStyle.Underline) == FontStyle.Underline && (fontStyle & FontStyle.Strikeout) == FontStyle.Strikeout)
                {
                    headerValues[idx] = $"~~***<u>{headerValues[idx]}</u>***~~";
                }

                idx++;
            }

            _documentBuilder.Append(string.Join("|", headerValues.ToArray()));
            _documentBuilder.Append("|");
            _documentBuilder.Append(Table.Output.NewLineDelimiter);


            // data styles
            if (Table.ShowDataValues == YesNo.Yes)
            {
                _documentBuilder.Append("|");
                var alignments = fields.Select(field => Resources.Styles.GetBy(field.Value.Style).Content.Alignment.Horizontal);
                foreach (var alignment in alignments)
                {

                    switch (alignment)
                    {
                        case KnownHorizontalAlignment.Center:
                            _documentBuilder.Append(" :----: ");
                            break;

                        case KnownHorizontalAlignment.Left:
                            _documentBuilder.Append(" :---- ");
                            break;

                        case KnownHorizontalAlignment.Right:
                            _documentBuilder.Append(" ----: ");
                            break;

                        default:
                            throw new ArgumentOutOfRangeException();
                    }

                    _documentBuilder.Append("|");
                }

                _documentBuilder.Append(Table.Output.NewLineDelimiter);
            }

            // data values
            if (Table.ShowDataValues == YesNo.Yes)
            {
                _documentBuilder.Append("|");
                var valueFontStyles = fields.Select(field => Resources.Styles.GetBy(field.Value.Style).Font.FontStyles).ToList();
                foreach (var row in rows)
                {
                    idx = 0;
                    var values = new Collection<string>();
                    foreach (var field in fields)
                    {                        
                        field.DataSource = row;
                        var value = field.Value.GetValue(Provider.SpecialChars);
                        var parsedValue = ParseField(value.FormattedValue);
                        values.Add(parsedValue);
                    }

                    foreach (var fontStyle in valueFontStyles)
                    {
                        if (fontStyle == FontStyle.Bold)
                        {
                            values[idx] = $"**{values[idx]}**";
                        }
                        else if (fontStyle == FontStyle.Italic)
                        {
                            values[idx] = $"*{values[idx]}*";
                        }
                        else if (fontStyle == FontStyle.Underline)
                        {
                            values[idx] = $"<u>{values[idx]}</u>";
                        }
                        else if (fontStyle == FontStyle.Strikeout)
                        {
                            values[idx] = $"~~{values[idx]}~~";
                        }
                        else if ((fontStyle & FontStyle.Bold) == FontStyle.Bold && (fontStyle & FontStyle.Italic) == FontStyle.Italic)
                        {
                            values[idx] = $"***{values[idx]}***";
                        }
                        else if ((fontStyle & FontStyle.Bold) == FontStyle.Bold && (fontStyle & FontStyle.Italic) == FontStyle.Italic && (fontStyle & FontStyle.Underline) == FontStyle.Underline)
                        {
                            values[idx] = $"***<u>{values[idx]}</u>***";
                        }
                        else if ((fontStyle & FontStyle.Bold) == FontStyle.Bold && (fontStyle & FontStyle.Italic) == FontStyle.Italic && (fontStyle & FontStyle.Underline) == FontStyle.Underline && (fontStyle & FontStyle.Strikeout) == FontStyle.Strikeout)
                        {
                            values[idx] = $"~~***<u>{values[idx]}</u>***~~";
                        }
                    
                        idx++;
                    }

                    // add values.
                    _documentBuilder.Append(string.Join("|", values.ToArray()));

                    // new line defined in output tag.
                    _documentBuilder.Append(Table.Output.NewLineDelimiter);
                }
            }
            else
            {
                _documentBuilder.Append("|");
                _documentBuilder.Append(string.Join("|", fields.Select(field => "---")));                   
                _documentBuilder.AppendLine("|");
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
