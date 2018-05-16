
namespace iTin.Export.Writers.OpenXml.Office
{
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.IO;
    using System.Linq;
    using System.Xml.Linq;

    using ComponentModel;
    using ComponentModel.Writer;
    using Model;

    using Novacode;

    /// <inheritdoc />
    /// <summary>
    /// Represents custom writer for Office Open XML (docx format).
    /// </summary>
    /// <remarks>
    ///   <para>This writer is based <c>DocX</c> open source Project</para>
    ///   <para>For more information please see <a href="http://docx.codeplex.com/">http://docx.codeplex.com/</a></para>
    /// </remarks>
    [Export(typeof(IWriter))]
    [WriterOptions(Name = "DocxTabularWriter", Author = "iTin", Company = "iTin", Version = 1, Extension = "docx", Description = "Word Office Open XML Writer")]
    public class DocxTabularWriter : BaseWriterDirect
    {
        #region private properties

        #region [private] (FixedModel) Fixed: Gets a reference to the current fixed model
        /// <summary>
        /// Gets a reference to the current fixed model.
        /// </summary>
        /// <value>
        /// Reference to the current fixed model.
        /// </value>
        private FixedModel Fixed => Resources.Fixed;
        #endregion

        #region [public] (HostModel) Host: Gets a reference to the current host model
        /// <summary>
        /// Gets a reference to the current host model.
        /// </summary>
        /// <value>
        /// Reference to the current host model.
        /// </value>
        public HostModel Host => Resources.Hosts[Table.Host];
        #endregion

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
        /// Reference to the location table.
        /// </value>
        private TableModel Table => Provider.Input.Model.Table;
        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (void) Execute(): Generates output in Word Document Office Open Xml
        /// <inheritdoc />
        /// <summary>
        /// Generates output in Word Document Office Open XML.
        /// </summary>
        protected override void Execute()
        {
            MemoryStream stream = null;
            try
            {
                stream = new MemoryStream();
                using (var document = DocX.Create(stream))
                {      
                    #region initialize
                    var y = 0;
                    var items = Table.Fields;
                    #endregion

                    #region get target data
                    var rows = Service.RawDataFiltered;
                    var rowsCount = rows.Length;
                    #endregion
                        
                    #region sets page orientation
                    document.PageLayout.Orientation = Host.Document.Orientation.ToDocxOrientation();
                    #endregion

                    #region add header and footers to this document
                    // Add Header and footers.
                    ////document.AddHeaders();
                    document.AddFooters();

                    // Force the first page to have a different Header and Footer.
                    document.DifferentFirstPage = true;

                    // Force odd & even pages to have different Headers and Footers.
                    document.DifferentOddAndEvenPages = true;

                    // Get the first, odd and even Headers for this document.
                    ////var firstHeader = document.Headers.first;
                    ////var oddHeader = document.Headers.odd;
                    ////var evenHeader = document.Headers.even;

                    // Insert a Paragraph into the odd Header.
                    ////var p1 = oddHeader.InsertParagraph();
                    ////p1.Alignment = Alignment.right;
                    ////p1.Append(Table.Alias).Bold();

                    // Insert a Paragraph into the even Header.
                    ////var p2 = evenHeader.InsertParagraph();
                    ////p2.Alignment = Alignment.right;
                    ////p2.Append(Table.Alias).Bold();

                    // Get the first, odd and even Footer for this document.
                    var firstFooter = document.Footers.first;
                    var oddFooter = document.Footers.odd;
                    var evenFooter = document.Footers.even;

                    // Insert a Paragraph into the first Footer.
                    var p3 = firstFooter.InsertParagraph();
                    p3.Alignment = Alignment.center;
                    p3.AppendPageNumber(PageNumberFormat.normal);

                    // Insert a Paragraph into the odd Footer.
                    var p4 = oddFooter.InsertParagraph();
                    p4.Alignment = Alignment.center;
                    p4.AppendPageNumber(PageNumberFormat.normal);

                    // Insert a Paragraph into the even Header.
                    var p5 = evenFooter.InsertParagraph();
                    p5.Alignment = Alignment.center;
                    p5.AppendPageNumber(PageNumberFormat.normal);
                    #endregion

                    #region create table and specify some properties for this Table
                    var tableRows = rowsCount;
                    var topAggregates = items.GetRange(KnownAggregateLocation.Top).ToList();
                    var hasTopAggregates = topAggregates.Any();
                    if (hasTopAggregates)
                    {
                        tableRows++;
                    }

                    var columnHeaders = Table.Headers;
                    var hasColumnheaders = columnHeaders.Any();
                    if (hasColumnheaders)
                    {
                        tableRows++;
                    }

                    var fieldHeaders = items.GetRange(YesNo.Yes).ToList();
                    var hasFieldHeaders = fieldHeaders.Any();
                    if (hasFieldHeaders)
                    {
                        tableRows++;
                    }

                    var bottomAggregates = items.GetRange(KnownAggregateLocation.Bottom).ToList();
                    var hasBottomAggregates = bottomAggregates.Any();
                    if (hasBottomAggregates)
                    {
                        tableRows++;
                    }

                    var table = document.AddTable(tableRows, items.Count);                        
                    table.SetHorizontalLocationFrom(Table.Location);
                    #endregion

                    #region has logo?
                    document.AppendLogoFromModel(Table.Logo);
                    #endregion

                    #region sets vertical table position
                    document.SetVerticalLocationFrom(Table.Location);
                    #endregion

                    #region add top aggregates?
                    foreach (var field in topAggregates)
                    {
                        var column = items.IndexOf(field);
                        var cell = table.Rows[y].Cells[column];

                        var style = field.Aggregate.GetStyle();
                        var formula = GetFormula(field, rows);
                        cell.AppendText(formula.Resolve()).AppendVisualStyle(style);
                    }
                    #endregion

                    #region add column headers
                    if (Table.ShowColumnHeaders == YesNo.Yes)
                    {
                        if (hasTopAggregates)
                        {
                            y++;
                        }

                        var offset = 0;
                        foreach (var columnHeader in columnHeaders)
                        {
                            var cell = table.GetRangeFromModel(y, columnHeader, offset);
                            if (columnHeader.Show == YesNo.Yes)
                            {
                                cell.AppendText(columnHeader.Text).AppendVisualStyle(columnHeader.GetStyle());
                            }
                            else
                            {
                                cell.AppendText(string.Empty).AppendVisualStyle(columnHeader.GetStyle());                                 
                            }

                            offset = table.Rows[y + 1].ColumnCount - table.Rows[y].Cells.Count;
                        }

                        table.Rows[y].ClearEmptyParagraphs();
                    }
                    #endregion

                    #region add headers?
                    if (hasColumnheaders)
                    {
                        y++;
                    }

                    foreach (var field in fieldHeaders)
                    {
                        var column = items.IndexOf(field);
                        var cell = table.Rows[y].Cells[column];
                        var style = field.Header.GetStyle();
                        cell.AppendText(field.Alias).AppendVisualStyle(style);
                    }
                    #endregion

                    #region add data
                    if (hasFieldHeaders)
                    {
                        y++;
                    }

                    for (var row = 0; row < rowsCount; row++)
                    {
                        var rowData = rows[row];
                        for (var col = 0; col < items.Count; col++)
                        {
                            var field = items[col];
                            field.DataSource = rowData;

                            var cell = table.Rows[y + row].Cells[col];
                            var value = field.Value.GetValue(Provider.SpecialChars);
                            cell.AppendText(value);
                        }
                    }
                    #endregion

                    #region add bottom aggregates?
                    y += rowsCount;
                    foreach (var field in bottomAggregates)
                    {
                        var column = items.IndexOf(field);
                        var cell = table.Rows[y].Cells[column];

                        var style = field.Aggregate.GetStyle();
                        var formula = GetFormula(field, rows);
                        cell.AppendText(formula.Resolve()).AppendVisualStyle(style);
                    }
                    #endregion

                    #region autofitcolumns?
                    if (Table.AutoFitColumns == YesNo.Yes)
                    {
                        table.AutoFit = AutoFit.Contents;
                    }
                    #endregion

                    #region append table into the document
                    document.InsertTable(table);
                    #endregion

                    #region save
                    document.Save();
                    #endregion

                    #region add document to result list
                    Result.Add(stream.ToArray());
                    #endregion

                    #region destroy stream
                    stream = null;
                    #endregion
                }
            }
            finally
            {
                stream?.Dispose();
            }
        }
        #endregion

        #endregion

        #region private methods

        #region [private] (NonTabularFormulaResolver) GetFormula(BaseDataFieldModel, XElement[]): Returns a reference to object which allow resolve the field aggregate.
        /// <summary>
        /// Returns a reference to object which allow resolve the field aggregate.
        /// </summary>
        /// <param name="field">The field.</param>
        /// <param name="rows">The rows.</param>
        /// <returns>
        /// A <see cref="T:iTin.Export.ComponentModel.NonTabularFormulaResolver"/> reference which allow resolve the field aggregate.
        /// </returns>
        private NonTabularFormulaResolver GetFormula(BaseDataFieldModel field, XElement[] rows)
        {
            var rowsCount = rows.Length;
            var attributes = rows.ToList().Attributes();

            var aggregate = field.Aggregate;
            var formula = new NonTabularFormulaResolver(aggregate);
            var name = BaseDataFieldModel.GetFieldNameFrom(field);

            switch (field.FieldType)
            {
                #region Field: Field
                case KnownFieldType.Field:
                    formula.Data = attributes.Where(attr => attr.Name.LocalName.ToUpperInvariant().Equals(name.ToUpperInvariant())).Select(n => n.Value);
                    break;
                #endregion

                #region Field: Fixed
                case KnownFieldType.Fixed:
                    var @fixed = (FixedFieldModel)field;
                    var fixedItem = Fixed[@fixed.Pieces];

                    var dataList =
                        rows.Select(row => fixedItem.DataSource = row)
                            .Select(entries => fixedItem.ToDictionary())
                            .Select(entry => entry[name]);

                    formula.Data = dataList;
                    break;
                #endregion

                #region Field: Gap
                case KnownFieldType.Gap:
                    var datalist = new List<string>();
                    for (var i = 0; i <= rowsCount - 1; i++)
                    {
                        datalist.Add(" ");
                    }

                    formula.Data = datalist;
                    break;
                #endregion

                #region Field: Group
                case KnownFieldType.Group:
                    var group = (GroupFieldModel)field;

                    var values = new List<string>();
                    foreach (var row in rows)
                    {
                        group.DataSource = row;
                        var value = group.Value.GetValue(Provider.SpecialChars);
                        values.Add(value.FormattedValue);
                    }

                    formula.Data = values;
                    break;
                #endregion
            }

            return formula;
        }
        #endregion

        #endregion
    }
}
