﻿
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace iTin.Export.Writers
{
    using ComponentModel;
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

        /// <summary>
        /// Gets a reference to the model global resources.
        /// </summary>
        /// <value>
        /// Reference to the model global resources.
        /// </value>
        private GlobalResourcesModel Resources => Provider.Input.Resources;

        /// <summary>
        /// Gets a reference to the table.
        /// </summary>
        /// <value>
        /// Reference to the model table.
        /// </value>
        private TableModel Table => Provider.Input.Model.Table;

        #endregion

        #region protected override methods

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

            // get header styles
            var headerStyles = fields.Select(field => Resources.Styles.GetBy(field.Header.Style).Font.FontStyles).ToList();
            var valueStyles = fields.Select(field => Resources.Styles.GetBy(field.Value.Style).Font.FontStyles).ToList();
            var aggregateStyles = fields.Select(field => Resources.Styles.GetBy(field.Aggregate.Style).Font.FontStyles).ToList();

            // Block lines
            var blocklines = Provider.Input.Model.BlockLines;
            var hasBlockLines = blocklines.Any();
            if (hasBlockLines)
            {
                foreach (var blockline in blocklines)
                {
                    if (blockline.Show == YesNo.No)
                    {
                        continue;
                    }

                    var keyLines = blockline.Items.Keys;
                    foreach (var keyLine in keyLines)
                    {
                        var line = Resources.Lines.GetBy(keyLine);
                        if (line.Show == YesNo.No)
                        {
                            continue;
                        }

                        var times = line.Repeat == 0 ? 1 : line.Repeat;
                        for (var i = 1; i <= times; i++)
                        {
                            var lineType = line.LineType;
                            switch (lineType)
                            {
                                case KnownLineType.EmptyLine:
                                    var emptyLine = (EmptyLineModel) line;
                                    if (emptyLine.Show == YesNo.No)
                                    {
                                        continue;
                                    }

                                    _documentBuilder.AppendLine();
                                    break;

                                case KnownLineType.TextLine:
                                    var textLine = (TextLineModel)line;
                                    var items = textLine.Items;
                                    var values = new Collection<string>();
                                    foreach (var item in items)
                                    {
                                        if (item.Show == YesNo.No)
                                        {
                                            continue;
                                        }

                                        values.Add(item.Value);
                                    }

                                    _documentBuilder.Append($"### {string.Join("\t", values)}");
                                    _documentBuilder.AppendLine();
                                    break;
                            }
                        }
                    }
                }

                _documentBuilder.AppendLine();
            }

            // headers
            var idx = 0;
            _documentBuilder.Append("|");
            var headerValues = fields.Select(field => field.Header.Show == YesNo.No ? string.Empty : ParseField(field.Alias)).ToList();
            foreach (var fontStyle in headerStyles)
            {
                headerValues[idx] = string.Format(fontStyle.ToMarkdownStylePattern(), headerValues[idx]);
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
                    _documentBuilder.Append(alignment.ToMarkdownTextAlignment());
                    _documentBuilder.Append("|");
                }

                _documentBuilder.Append(Table.Output.NewLineDelimiter);
            }

            // data values
            if (Table.ShowDataValues == YesNo.Yes)
            {
                _documentBuilder.Append("|");
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

                    foreach (var fontStyle in valueStyles)         
                    {
                        values[idx] = string.Format(fontStyle.ToMarkdownStylePattern(), values[idx]);
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

            // add bottom aggregates
            var fieldsWithBottomAggregates = fields.GetRange(KnownAggregateLocation.Bottom).ToList();
            var hasBottomAggregates = fieldsWithBottomAggregates.Any();
            if (Table.ShowDataValues == YesNo.Yes)
            {
                if (hasBottomAggregates)
                {
                    _documentBuilder.Append("|");
                    idx = 0;
                    var values = new Collection<string>();
                    foreach (var field in fieldsWithBottomAggregates)
                    {
                        var aggregate = field.Aggregate;
                        var formula = new NonTabularFormulaResolver(aggregate)
                        {
                            Data = rows.Select(attr => attr.Attribute(BaseDataFieldModel.GetFieldNameFrom(field)).Value)
                        };

                        values.Add(formula.Resolve());
                    }

                    foreach (var fontStyle in aggregateStyles)
                    {
                        if (string.IsNullOrEmpty(values[idx]))
                        {
                            idx++;
                            continue;
                        }

                        values[idx] = string.Format(fontStyle.ToMarkdownStylePattern(), values[idx]);
                        idx++;
                    }

                    // add values.
                    _documentBuilder.Append(string.Join("|", values.ToArray()));

                    // new line defined in output tag.
                    _documentBuilder.Append(Table.Output.NewLineDelimiter);
                }
            }

            // end of file
            _documentBuilder.Append(Table.Output.EndOfFile);

            // add document to result list.
            Result.Add(Encoding.UTF8.GetBytes(_documentBuilder.ToString()));
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
