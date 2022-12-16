
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace iTin.Export.Writers
{
    using AspNet.ComponentModel;
    using ComponentModel.Writer;
    using Drawing.Helper;
    using Model;

    /// <inheritdoc />
    /// <summary>
    /// Represents a custom XML Spreadsheet 2003 tabular writer.
    /// </summary>
    [Export(typeof(IWriter))]
    [WriterOptions(Name = "Spreadsheet2003TabularWriter", Author = "iTin", Company = "iTin", Version = 1, Extension = "xml", Description = "XML Spreadsheet 2003 Writer")]
    public class Spreadsheet2003TabularWriter : BaseWriterXml
    {
        #region public override properties

        /// <inheritdoc />
        /// <summary>
        /// Gets a reference to an object <see cref="T:iTin.Export.AspNet.ComponentModel.HttpResponseEx" /> than contains the <strong>MIME</strong> type of the output stream and response header for a <strong>ASP.NET</strong> operation.
        /// </summary>
        /// <value>
        /// A <see cref="T:iTin.Export.AspNet.ComponentModel.HttpResponseEx" /> than contains the <strong>MIME</strong> type of the output stream and response header for a <strong>ASP.NET</strong> operation.
        /// </value>
        public override HttpResponseEx ResponseEx
        {          
            get
            {
                var parsedFilePath = Provider.Input.Model.ResolveRelativePath(KnownRelativeFilePath.Output);
                var filename = Path.GetFileName(parsedFilePath);
                var outputFileDir = parsedFilePath.Replace(filename, string.Empty);

                var behavior = Provider.Input.Model.Table.Exporter.Behaviors.Get<TransformFileBehaviorModel>() ?? TransformFileBehaviorModel.Default;
                var outputTransformDir = behavior.IsDefault
                    ? outputFileDir
                    : Provider.Input.Model.ResolveRelativePath(KnownRelativeFilePath.TransformFileBehaviorDir);

                var headerBuilder = new StringBuilder();
                headerBuilder.Append("attachment; filename=");
                headerBuilder.Append(
                    Result.Count > 1 ||
                    IsTransformationFile && 
                        behavior.Save.Equals(YesNo.Yes) && 
                        outputTransformDir.Equals(outputFileDir)
                            ? Path.ChangeExtension(filename, "zip") 
                            : Path.ChangeExtension(filename, WriterMetadata.Extension));

                return new HttpResponseEx
                {
                    ContentType = HttpResponseEx.GetMimeMapping(WriterMetadata.Extension), 
                    ContentDisposition = headerBuilder.ToString()
                };
            }
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Gets a value indicating that this writer generates a transformation file to be processed later.
        /// </summary>
        /// <value>
        /// Always returns <strong>true</strong> value.
        /// </value>
        public override bool IsTransformationFile => true;

        #endregion

        #region private properties

        /// <summary>
        /// Gets a reference to the resource fixed.
        /// </summary>
        /// <value>
        /// Reference to the resource fixed.
        /// </value>
        private FixedModel Fixed => Resources.Fixed;

        #region [private] (GroupsModel) Groups: Gets a reference to the resource groups
        /// <summary>
        /// Gets a reference to the resource groups.
        /// </summary>
        /// <value>
        /// Reference to the resource groups.
        /// </value>
        private GroupsModel Groups => Resources.Groups;
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

        #region [private] (Point) Location: Gets a reference to the location table
        /// <summary>
        /// Gets a reference to the location table.
        /// </summary>
        /// <value>
        /// Reference to the location table.
        /// </value>
        private Point Location
        {
            get
            {
                var location = Table.Location;
                return location.LocationType.Equals(KnownElementLocation.ByAlignment)
                    ? new Point(1, 1)
                    : ((CoordenatesModel) location.Mode).TableCoordenates;
            }
        }
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

        #region [private] (StylesModel) Styles: Gets a reference to the resource styles
        /// <summary>
        /// Gets a reference to the resource styles.
        /// </summary>
        /// <value>
        /// Reference to the resource styles.
        /// </value>
        private StylesModel Styles => Resources.Styles;
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

        #region [private] (string) QualifiedWorkSheetName: Gets the name of the sheet we are creating qualified
        /// <summary>
        /// Gets the name of the sheet we are creating qualified.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String" /> containing the qualified sheet name.
        /// </value>
        private string QualifiedWorkSheetName
        {
            get
            {
                var qualifiedName = new StringBuilder();
                qualifiedName.Append("'");
                qualifiedName.Append(WorkSheetName);
                qualifiedName.Append("'!");
                return qualifiedName.ToString();
            }
        }
        #endregion

        #region [private] (string) WorkSheetName: Gets the name of the sheet we are creating
        /// <summary>
        /// Gets the name of the sheet we are creating.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String"/> containing the name of the sheet.
        /// </value>
        private string WorkSheetName
        {
            get
            {
                var name = "NoName";
                if (!string.IsNullOrEmpty(Table.Alias))
                {
                    name = Table.Alias;
                }

                var lenghtName = name.Length;
                if (lenghtName > 31)
                {
                    name = name.Substring(0, 31);
                }

                return name;
            }
        }
        #endregion

        #endregion

        #region protected override methods

        /// <inheritdoc />
        /// <summary>
        /// Generates output in MS Excel format.
        /// </summary>
        protected override void Execute()
        {
            WriteBeginDocument();
                WriteExcelApplication();
                WriteVariableDeclaration();
                WriteStartWorkbook();
                    WriteOfficeDocumentSettings();
                    WriteStartStyles();
                        WriteStyles();
                    WriteEndStyles();
                    WriteStartWorksheet();
                        WriteNamedRanges();
                        WriteStartTable();
                            WriteTableContent();
                        WriteEndTable();
                        WriteWorkSheetOptions();
                        WriteAutoFilter();
                    WriteEndWorksheet();
                WriteEndWorkbook();
            WriteEndDocument();
        }

        #endregion

        #region private methods

        /// <summary>
        /// Top of the document.
        /// </summary>
        private void WriteBeginDocument()
        {
            Writer.WriteStartDocument();
        }

        /// <summary>
        /// Create the header of a MS Excel document.
        /// </summary>
        private void WriteExcelApplication()
        {
            Writer.WriteStartElement("xsl:stylesheet");
                Writer.WriteAttributeString("version", "1.0");
                Writer.WriteAttributeString("xmlns", "html", null, "http://www.w3.org/TR/REC-html40");
                Writer.WriteAttributeString("xmlns", "xsl", null, "http://www.w3.org/1999/XSL/Transform");
                Writer.WriteAttributeString("xmlns", string.Empty, null, "urn:schemas-microsoft-com:office:spreadsheet");
                Writer.WriteAttributeString("xmlns", "o", null, "urn:schemas-microsoft-com:office:office");
                Writer.WriteAttributeString("xmlns", "x", null, "urn:schemas-microsoft-com:office:excel");
                Writer.WriteAttributeString("xmlns", "ss", null, "urn:schemas-microsoft-com:office:spreadsheet");
                Writer.WriteAttributeString("xmlns", "ms", null, "urn:schemas-microsoft-com:xslt");
                Writer.WriteAttributeString("xmlns", "dt", null, "urn:schemas-microsoft-com:datatypes");

                Writer.WriteStartElement("xsl:output");
                    Writer.WriteAttributeString("indent", "yes");
                Writer.WriteEndElement();

                Writer.WriteStartElement("xsl:template");
                    Writer.WriteAttributeString("match", "/");

                    Writer.WriteStartElement("xsl:processing-instruction");
                        Writer.WriteAttributeString("name", "mso-application");
                        Writer.WriteString("progid=\"Excel.Sheet\"");
                    Writer.WriteEndElement();
        }

        /// <summary>
        /// Create global variables.
        /// </summary>
        private void WriteVariableDeclaration()
        {
            var hasTopAggregates = Table.Fields.HasVisibleAggregatesByLocation(KnownAggregateLocation.Top);
            var hasBottomAggregates = Table.Fields.HasVisibleAggregatesByLocation(KnownAggregateLocation.Bottom);

            Writer.WriteXsltStartVariable("__rows");
                Writer.WriteAttributeString("select", "count(*/" + Table.Name + ")");
            Writer.WriteXsltEndVariable();

            Writer.WriteXsltStartVariable("__EndTopAggregate");
                Writer.WriteAttributeString("select", "1 + $__rows");
            Writer.WriteEndElement();

            var printTitlesTopRow = Location.Y;
            Writer.WriteXsltStartVariable("__PrintTitlesTopRow");
                Writer.WriteAttributeString("select", printTitlesTopRow.ToString(CultureInfo.InvariantCulture));
            Writer.WriteXsltEndVariable();

            var printTitlesBottomRow = printTitlesTopRow;
            if (hasTopAggregates)
            {
                printTitlesBottomRow++;
            }

            Writer.WriteXsltStartVariable("__PrintTitlesBottomRow");
                Writer.WriteAttributeString("select", printTitlesBottomRow.ToString(CultureInfo.InvariantCulture));
            Writer.WriteXsltEndVariable();

            Writer.WriteXsltStartVariable("__TableRange_X1");
                Writer.WriteAttributeString("select", Location.X.ToString(CultureInfo.InvariantCulture));
            Writer.WriteEndElement();

            var y1 = Location.Y;
            if (hasTopAggregates)
            {
                y1++;
            }

            Writer.WriteXsltStartVariable("__TableRange_Y1");
                Writer.WriteAttributeString("select", y1.ToString(CultureInfo.InvariantCulture));
            Writer.WriteEndElement();

            var fields = Table.Fields.Count - 1;
            Writer.WriteXsltStartVariable("__TableRange_X2");
                Writer.WriteAttributeString("select", "$__TableRange_X1 + " + fields.ToString(CultureInfo.InvariantCulture));
            Writer.WriteEndElement();

            var y2 = y1;
            if (hasBottomAggregates)
            {
                y2++;
            }

            Writer.WriteXsltStartVariable("__TableRange_Y2");
                Writer.WriteAttributeString("select", "$__rows + " + y2.ToString(CultureInfo.InvariantCulture));
            Writer.WriteEndElement();                
        }

        /// <summary>
        /// Add a new book to MS Excel.
        /// </summary>
        /// <remarks>
        /// Create Workbook label. Path: \Workbook
        /// </remarks>
        private void WriteStartWorkbook()
        {
            Writer.WriteStartElement("Workbook");
        }

        /// <summary>
        /// Adds OfficeDocumentSettings element.
        /// </summary>
        /// <remarks>
        /// Create OfficeDocumentSettings label. Path: \Workbook\OfficeDocumentSettings
        /// </remarks>
        private void WriteOfficeDocumentSettings()
        {
            Writer.WriteStartElement("OfficeDocumentSettings");
                Writer.WriteAttributeString("xmlns", "urn:schemas-microsoft-com:office:office");
                Writer.WriteStartElement("AllowPNG");
                Writer.WriteEndElement();
            Writer.WriteEndElement();
        }

        /// <summary>
        /// Add MS Excel styles.
        /// </summary>
        /// <remarks>
        /// Create Styles label. Path: \Workbook\Styles
        /// </remarks>
        private void WriteStartStyles()
        {
            Writer.WriteStartElement("Styles");
        }

        /// <summary>
        /// Add user-defined styles.
        /// </summary>
        /// <remarks>
        /// Create all Style labels. Path: \Workbook\Styles\Style
        /// </remarks>
        private void WriteStyles()
        {                        
            WriteDefaultStyle();

            var styles = Styles;                
            foreach (var style in styles)
            {
                WriteUserDefinedStyle(style);
            }

            var groupNames = Groups.Where(grp => grp.Multiline).Select(grp => grp.Name).ToList();
            var groupFields = new List<GroupFieldModel>();
            foreach (var grp in groupNames)
            {
                groupFields = Table.Fields.Where(item => item.FieldType == KnownFieldType.Group).Cast<GroupFieldModel>().Where(item => item.Name == grp).ToList();
            }

            foreach (var groupField in groupFields)
            {
                var style = styles[groupField.Value.Style];
                WriteUserDefinedStyle(style, true);
            }
        }

        /// <summary>
        /// Add default style.
        /// </summary>
        /// <remarks>
        /// Create default Style. Path: \Workbook\Styles\Style
        /// </remarks>
        private void WriteDefaultStyle()
        {
            Writer.WriteStartElement("Style");
                Writer.WriteAttributeString("ss:ID", "Default");
                Writer.WriteAttributeString("ss:Name", "Normal");
                Writer.WriteStartElement("Alignment");
                    Writer.WriteAttributeString("ss:Vertical", "Bottom");
                Writer.WriteEndElement();

                Writer.WriteStartElement("Borders");
                Writer.WriteEndElement();

                Writer.WriteStartElement("Font");
                    Writer.WriteAttributeString("ss:FontName", "Calibri");
                    Writer.WriteAttributeString("x:Family", "Swiss");
                    Writer.WriteAttributeString("ss:Size", "11");
                    Writer.WriteAttributeString("ss:Color", "#000000");
                Writer.WriteEndElement();

                Writer.WriteStartElement("Interior");
                Writer.WriteEndElement();

                Writer.WriteStartElement("NumberFormat");
                Writer.WriteEndElement();

                Writer.WriteStartElement("Protection");
                Writer.WriteEndElement();
            Writer.WriteEndElement();
        }

        /// <summary>
        /// Add style to the collection of styles MS Excel. <paramref name="wrap" /> default is <strong>false</strong>.
        /// </summary>
        /// <param name="style">The style.</param>
        /// <param name="wrap">if set to <strong>true</strong> [wrap].</param>
        /// <remarks>
        /// Create style label. Path: \Workbook\Styles\Style
        /// </remarks>
        private void WriteUserDefinedStyle(StyleModel style, bool wrap = false)
        {
            var content = style.Content;
            Writer.WriteStartElement("Style");
                Writer.WriteAttributeString("ss:ID", wrap ? (style.Name + "_wrap") : style.Name);

                Writer.WriteStartElement("Alignment");
                    Writer.WriteAttributeString("ss:Horizontal", content.Alignment.Horizontal.ToString());
                    Writer.WriteAttributeString("ss:Vertical", content.Alignment.Vertical.ToString());

                    if (wrap)
                    {
                        Writer.WriteAttributeString("ss:WrapText", "1");
                    }

                Writer.WriteEndElement();

                Writer.WriteStartElement("Borders");
                    foreach (var border in style.Borders)
                    {
                        WriteBorder(border);
                    }
                Writer.WriteEndElement();

                var font = style.Font;
                Writer.WriteStartElement("Font");
                    Writer.WriteAttributeString("ss:FontName", font.Name);
                    Writer.WriteAttributeString("ss:Size", font.Size.ToString(CultureInfo.InvariantCulture));
                    Writer.WriteAttributeString("ss:Color", ColorHelper.ToHex(font.GetColor()));
                    if (font.Bold == YesNo.Yes)
                    {
                        Writer.WriteAttributeString("ss:Bold", "1");
                    }

                    if (font.Italic == YesNo.Yes)
                    {
                        Writer.WriteAttributeString("ss:Italic", "1");
                    }

                    if (font.Underline == YesNo.Yes)
                    {
                        Writer.WriteAttributeString("ss:Underline", "Single");
                    }

                Writer.WriteEndElement();

                var contentIsDefault = content.IsDefault;
                Writer.WriteStartElement("Interior");
                    if (!contentIsDefault)
                    {
                        Writer.WriteAttributeString("ss:Color", ColorHelper.ToHex(content.GetColor()));
                        Writer.WriteAttributeString("ss:Pattern", "Solid");
                    }

                Writer.WriteEndElement();

                var excelDataType = style.Content.DataType.GetDataFormat().ToSpreadsheetDataFormat(style.Content.DataType);
                Writer.WriteStartElement("NumberFormat");
                    Writer.WriteAttributeString("ss:Format", excelDataType);
                Writer.WriteEndElement();

                Writer.WriteStartElement("Protection");
                Writer.WriteEndElement();
            Writer.WriteEndElement();
        }

        /// <summary>
        /// Add border to the collection of borders MS Excel
        /// </summary>
        /// <param name="border">The border.</param>
        /// <remarks>
        /// Create style label. Path: \Workbook\Styles\Style\Borders\Border
        /// </remarks>
        private void WriteBorder(BorderModel border)
        {
            Writer.WriteStartElement("Border");
                Writer.WriteAttributeString("ss:Position", border.Position.ToString());
                Writer.WriteAttributeString("ss:Color", ColorHelper.ToHex(border.GetColor()));
                Writer.WriteAttributeString("ss:LineStyle", border.LineStyle.ToString());
                Writer.WriteAttributeString("ss:Weight", border.Weight.IndexOf().ToString(CultureInfo.InvariantCulture));
            Writer.WriteEndElement();
        }

        /// <summary>
        /// Ends the definition of styles.
        /// </summary>
        private void WriteEndStyles()
            {
            Writer.WriteEndElement();
        }

        /// <summary>
        /// Adds a new sheet to book.
        /// </summary>
        /// <remarks>
        /// Create Worksheet label. Path: \Workbook\Worksheet
        /// </remarks>
        private void WriteStartWorksheet()
        {
            Writer.WriteStartElement("Worksheet");
            Writer.WriteAttributeString("ss:Name", WorkSheetName);
        }

        /// <summary>
        /// Add named ranges to sheet.
        /// </summary>
        /// <remarks>
        /// Create NamedRange labels. Path: \Workbook\Worksheet\Names\NamedRange
        /// </remarks>
        private void WriteNamedRanges()
        {
            WriteStartNames();
                if (Table.AutoFilter == YesNo.Yes)
                {
                    WriteNamedRange(KnownSpreadsheetExpression.FilterNamedRange, KnownSpreadsheetExpression.TableRangePattern, true);
                }

                WriteNamedRange(KnownSpreadsheetExpression.PrintAreaNamedRange, KnownSpreadsheetExpression.TableRangePattern, false);
                WriteNamedRange(KnownSpreadsheetExpression.PrintTitlesNamedRange, KnownSpreadsheetExpression.PrintTitlesRangePattern, false);
            WriteEndNames();
        }

        /// <summary>
        /// Add start of named ranges.
        /// </summary>
        /// <remarks>
        /// Create Names label. Path: \Workbook\Worksheet\Names
        /// </remarks>
        private void WriteStartNames()
        {
            Writer.WriteStartElement("Names");
        }

        /// <summary>
        /// Add new named range to the collection.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="range">The range.</param>
        /// <param name="hidden">if set to <strong>true</strong> [hidden].</param>
        /// <remarks>
        /// Create NamedRange label. Path: \Workbook\Worksheet\Names\NamedRange
        /// </remarks>
        private void WriteNamedRange(string name, string range, bool hidden)
        {
            var newRange = new StringBuilder();
            newRange.Append(QualifiedWorkSheetName);
            newRange.Append(range);

            Writer.WriteStartElement("NamedRange");
                Writer.WriteAttributeString("ss:Name", name);
                Writer.WriteAttributeString("ss:RefersTo", "=" + newRange);

                if (hidden)
                {
                    Writer.WriteAttributeString("ss:Hidden", "1");
                }
            Writer.WriteEndElement();
        }

        /// <summary>
        /// Ends the definition of named ranges.
        /// </summary>
        private void WriteEndNames()
        {
            Writer.WriteEndElement();
        }

        /// <summary>
        /// Add a new table to sheet.
        /// For more information, please see <see cref="TableModel"/>.
        /// </summary>
        /// <remarks>
        /// Create Table label. Path: \Workbook\Worksheet\Table.
        /// </remarks>
        private void WriteStartTable()
        {
            Writer.WriteStartElement("Table");
        }

        /// <summary>
        /// Add headers, aggregates, and data.
        /// </summary>
        private void WriteTableContent()
        {
            if (Table.AutoFitColumns == YesNo.Yes)
            {
                WriteColumnWidths();
            }

            WriteTopAggregates();
            WriteHeader();
            WriteRowDetail();
            WriteBottomAggregates();
        }

        /// <summary>
        /// Add column sizes.
        /// </summary>
        private void WriteColumnWidths()
        {
            var columnDictionary = Table.GetHeaderColumnsSize(Provider);
            foreach (var entry in columnDictionary)
            {
                var x = Location.X;
                var sizeColumn = entry.Value;
                var offset = Table.Fields.IndexOf(entry.Key);
                Writer.WriteStartElement("Column");
                    Writer.WriteAttributeString("ss:Index", (x + offset).ToString(CultureInfo.InvariantCulture));
                    Writer.WriteAttributeString("ss:Width", sizeColumn.Width.ToString(CultureInfo.InvariantCulture));
                Writer.WriteEndElement();
            }
        }

        /// <summary>
        /// Add top aggregates.
        /// </summary>
        private void WriteTopAggregates()
        {
            var fields = Table.Fields.GetRange(KnownAggregateLocation.Top).ToList();
            if (!fields.Any())
            {
                return;
            }

            Writer.WriteStartElement("Row");
                var y = Location.Y;
                if (y > 0)
                {
                    Writer.WriteAttributeString("ss:Index", y.ToString(CultureInfo.InvariantCulture));
                }

                foreach (var field in fields)
                {
                    var offset = Table.Fields.IndexOf(field);
                    var x = Location.X;
                    Writer.WriteStartElement("Cell");
                        if (!offset.Equals(-1))
                        {
                            Writer.WriteAttributeString("ss:Index", (x + offset).ToString(CultureInfo.InvariantCulture));
                        }

                        Writer.WriteAttributeString("ss:StyleID", field.Aggregate.Style);

                        if (field.Aggregate.AggregateType == KnownAggregateType.Text)
                        {
                            Writer.WriteStartElement("Data");
                                Writer.WriteAttributeString("ss:Type", "String");
                                Writer.WriteAttributeString("disable-output-escaping", "yes");
                                Writer.WriteString(field.Aggregate.Text);
                            Writer.WriteEndElement();
                        }
                        else
                        {
                            var formula = field.Aggregate.ToSpreadsheet(Table.AutoFilter);
                            if (!string.IsNullOrEmpty(formula))
                            {
                                Writer.WriteAttributeString("ss:Formula", formula);
                            }
                        }

                    Writer.WriteEndElement();
                }

            Writer.WriteEndElement();
        }

        /// <summary>
        /// Add headers.
        /// </summary>
        private void WriteHeader()
        {
            Writer.WriteStartElement("Row");
            var hasTopAggregates = Table.Fields.HasVisibleAggregatesByLocation(KnownAggregateLocation.Top);
            if (!hasTopAggregates)
            {
                if (Location.Y > 0)
                {
                    Writer.WriteAttributeString("ss:Index", Location.Y.ToString(CultureInfo.InvariantCulture));
                }
            }

            var offset = 0;
            var x = Location.X;
            foreach (var field in Table.Fields)
            {
                Writer.WriteStartElement("Cell");
                    Writer.WriteAttributeString("ss:StyleID", field.Header.Style);
                    Writer.WriteAttributeString("ss:Index", (x + offset).ToString(CultureInfo.InvariantCulture));
                    Writer.WriteStartElement("Data");
                        Writer.WriteAttributeString("ss:Type", "String");
                        if (field.Header.Show == YesNo.Yes)
                        {
                            Writer.WriteString(field.Alias);
                        }

                    Writer.WriteEndElement();

                    if (Table.AutoFilter == YesNo.Yes)
                    {
                        Writer.WriteStartElement("NamedCell");
                        Writer.WriteAttributeString("ss:Name", KnownSpreadsheetExpression.FilterNamedRange);
                        Writer.WriteEndElement();
                    }

                Writer.WriteEndElement();
                offset++;
            }

            Writer.WriteEndElement();
        }

        /// <summary>
        /// Add row data.
        /// </summary>
        private void WriteRowDetail()
        {
            var offset = 0;
            var x = Location.X;
            var styles = Styles;

            Writer.WriteStartElement("xsl:for-each");
                Writer.WriteAttributeString("select", "*/" + Table.Name);
                Writer.WriteStartElement("Row");
                foreach (var field in Table.Fields)
                {
                    if (field.Value.Show == YesNo.No)
                    {
                        continue;
                    }

                    var value = string.Empty;
                    var styleName = field.Value.Style;
                    var style = styles[styleName];

                    // Write test
                    var fieldType = field.FieldType;
                    switch (fieldType)
                    {
                        #region FieldType: Field
                        case KnownFieldType.Field:
                            var dataField = (DataFieldModel)field;
                            value = Writer.WriteTestSpreadsheet2003Field(Provider.Parse(dataField.Name), style);
                            break;
                        #endregion

                        #region FieldType: Fixed
                        case KnownFieldType.Fixed:
                            var @fixed = (FixedFieldModel)field;
                            var fixedItem = Fixed[@fixed.Pieces];
                            value = Writer.WriteTestSpreadsheet2003Field(@fixed, fixedItem, style);
                            break;
                        #endregion

                        #region FieldType: Gap
                        case KnownFieldType.Gap:
                            break;
                        #endregion

                        #region FieldType: Group
                        case KnownFieldType.Group:
                            var groupfield = (GroupFieldModel)field;
                            var groupfieldName = groupfield.Name;
                            var group = Groups[groupfieldName];
                            if (group.Multiline)
                            {
                                styleName = string.Concat(field.Value.Style, "_wrap");
                            }

                            value = Writer.WriteTestSpreadsheet2003Field(groupfield, group, Table);
                            break;
                        #endregion
                    }

                    Writer.WriteStartElement("Cell");
                        Writer.WriteAttributeString("ss:StyleID", styleName);
                        Writer.WriteAttributeString("ss:Index", (x + offset).ToString(CultureInfo.InvariantCulture));

                        Writer.WriteStartElement("Data");
                            var type = fieldType == KnownFieldType.Gap ? "String" : style.Content.DataType.Type.ToSpreadsheetDataType();
                            Writer.WriteAttributeString("ss:Type", type);
                            if (!string.IsNullOrEmpty(value))
                            {
                                Writer.WriteStartElement("xsl:value-of");
                                    Writer.WriteAttributeString("select", value);
                                    Writer.WriteAttributeString("disable-output-escaping", "yes");
                                Writer.WriteEndElement();
                            }
                        Writer.WriteEndElement();

                        // Write error comment
                        switch (fieldType)
                        {
                            #region FieldType: Field
                            case KnownFieldType.Field:
                                var dataField = (DataFieldModel)field;
                                Writer.WriteDataFieldErrorComment(Provider.Parse(dataField.Name), style);
                                break;
                            #endregion

                            #region FieldType: Fixed
                            case KnownFieldType.Fixed:
                                var fixedfield = (FixedFieldModel)field;                                
                                Writer.WriteDataFieldErrorComment(fixedfield, style);
                                break;
                            #endregion

                            #region FieldType: Gap
                            case KnownFieldType.Gap:
                                break;
                            #endregion

                            #region FieldType: Group
                            case KnownFieldType.Group:
                                break;
                            #endregion
                        }

                        if (Table.AutoFilter == YesNo.Yes)
                        {
                            Writer.WriteStartElement("NamedCell");
                                Writer.WriteAttributeString("ss:Name", KnownSpreadsheetExpression.FilterNamedRange);
                            Writer.WriteEndElement();
                        }

                    Writer.WriteEndElement();
                    offset++;
                }

                Writer.WriteEndElement();
            Writer.WriteEndElement();
        }

        /// <summary>
        /// Add bottom aggregates.
        /// </summary>
        private void WriteBottomAggregates()
        {
            var fields = Table.Fields.GetRange(KnownAggregateLocation.Bottom).ToList();
            if (!fields.Any())
            {
                return;
            }

            Writer.WriteStartElement("Row");
                var x = Location.X;
                foreach (var field in fields)
                {
                    var offset = Table.Fields.IndexOf(field);
                    Writer.WriteStartElement("Cell");
                        if (!offset.Equals(-1))
                        {
                            Writer.WriteAttributeString("ss:Index", (x + offset).ToString(CultureInfo.InvariantCulture));
                        }

                        Writer.WriteAttributeString("ss:StyleID", field.Aggregate.Style);

                        if (field.Aggregate.AggregateType == KnownAggregateType.Text)
                        {
                            Writer.WriteStartElement("Data");
                                Writer.WriteAttributeString("ss:Type", "String");
                                Writer.WriteAttributeString("disable-output-escaping", "yes");
                                Writer.WriteString(field.Aggregate.Text); 
                            Writer.WriteEndElement();
                        }
                        else
                        {
                            var formula = field.Aggregate.ToSpreadsheet(Table.AutoFilter);
                            if (!string.IsNullOrEmpty(formula))
                            {
                                Writer.WriteAttributeString("ss:Formula", formula);
                            }    
                        }

                    Writer.WriteEndElement();
                }

            Writer.WriteEndElement();
        }

        /// <summary>
        /// Ends the definition of table.
        /// </summary>
        private void WriteEndTable()
        {
            Writer.WriteEndElement();
        }

        /// <summary>
        /// Ends the definition of table.
        /// </summary>
        private void WriteWorkSheetOptions()
        {
            Writer.WriteStartElement("WorksheetOptions");
                Writer.WriteAttributeString("xmlns", "urn:schemas-microsoft-com:office:excel");
                WriteWorkSheetOptionsPageSetup();
            Writer.WriteEndElement();
        }

        /// <summary>
        /// Ends the definition of table.
        /// </summary>
        private void WriteWorkSheetOptionsPageSetup()
        {
            var document = Host.Document;
                 
            Writer.WriteStartElement("PageSetup");
                Writer.WriteStartElement("Layout");
                    Writer.WriteAttributeString("x:Orientation", document.Orientation.ToString());
                Writer.WriteEndElement();

                var margins = document.Margins;
                var top  = margins.Top;
                var left = margins.Left;
                var right = margins.Right;
                var bottom = margins.Bottom;

                var units = margins.Units;
                if (units == KnownUnit.Millimeters)
                {
                    top = top / 10f / 2.54f;
                    left = left / 10f / 2.54f;
                    right = right / 10f / 2.54f;
                    bottom = bottom / 10f / 2.54f;
                }

                Writer.WriteStartElement("PageMargins");
                    Writer.WriteAttributeString("x:Bottom", bottom.ToString(CultureInfo.InvariantCulture));
                    Writer.WriteAttributeString("x:Left", left.ToString(CultureInfo.InvariantCulture));
                    Writer.WriteAttributeString("x:Right", right.ToString(CultureInfo.InvariantCulture));
                    Writer.WriteAttributeString("x:Top", top.ToString(CultureInfo.InvariantCulture));
                Writer.WriteEndElement();
            Writer.WriteEndElement();

            Writer.WriteStartElement("Print");

                Writer.WriteStartElement("ValidPrinterInfo");
                Writer.WriteEndElement();

                if (document.Size != KnownDocumentSize.Letter)
                {
                    Writer.WriteStartElement("PaperSizeIndex");
                        Writer.WriteValue(document.Size.ToSpreadsheetPaperSize());
                    Writer.WriteEndElement();
                }

                Writer.WriteStartElement("HorizontalResolution");
                    Writer.WriteValue(600);
                Writer.WriteEndElement();

                Writer.WriteStartElement("VerticalResolution");
                    Writer.WriteValue(600);
                Writer.WriteEndElement();

            Writer.WriteEndElement();

            if (Table.ShowGridLines == YesNo.Yes)
            {
                return;
            }

            Writer.WriteStartElement("DoNotDisplayGridlines");
            Writer.WriteEndElement();
        }

        /// <summary>
        /// Add filters.
        /// </summary>
        /// <remarks>
        /// Create AutoFilter labels. Path: \Workbook\Worksheet\Names\NamedRange
        /// </remarks>
        private void WriteAutoFilter()
        {
            if (Table.AutoFilter == YesNo.Yes)
            {
                WriteAutoFilterItem(KnownSpreadsheetExpression.TableRangePattern);
            }
        }

        /// <summary>
        /// Add a new filter.
        /// </summary>
        /// <param name="range">The range.</param>
        /// <remarks>
        /// Create AutoFilter label. Path: \Workbook\Worksheet\Names\AutoFilter
        /// </remarks>
        private void WriteAutoFilterItem(string range)
        {
            Writer.WriteStartElement("AutoFilter");
                Writer.WriteAttributeString("x:Range", range);
                Writer.WriteAttributeString("xmlns", "urn:schemas-microsoft-com:office:excel");
            Writer.WriteEndElement();
        }

        /// <summary>
        /// Ends the definition of sheet.
        /// </summary>
        private void WriteEndWorksheet()
        {
            Writer.WriteEndElement();
        }

        /// <summary>
        /// Ends the definition of book.
        /// </summary>
        private void WriteEndWorkbook()
        {
            Writer.WriteEndElement();
        }

        /// <summary>
        /// Ends MS Excel document.
        /// </summary>
        private void WriteEndDocument()
        {
            Writer.WriteEndElement();
            Writer.WriteEndElement();
            Writer.Flush();
        }

        #endregion
    }
}
