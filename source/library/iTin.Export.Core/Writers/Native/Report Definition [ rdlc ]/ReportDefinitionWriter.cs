
namespace iTin.Export.Writers.Native
{
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.Drawing;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;

    using ComponentModel;
    using Drawing.Helper;
    using Model;
    using Web;

    /// <inheritdoc />
    /// <summary>
    /// Represents a custom Report definition writer.
    /// </summary>
    [Export(typeof(IWriter))]
    [WriterOptions(Name = "ReportDefinitionWriter", Author = "iTin", Company = "iTin", Version = 1, Extension = "rdlc", Description = "Report Definition Writer")]
    public class ReportDefinitionWriter : BaseWriterXml
    {
        #region public override properties

        #region [public] {override} (HttpResponseInfo) ResponseInfo: Gets a reference to an object HttpResponseInfo containing the MIME type of the output stream and response header for a ASP.NET operation.
        /// <inheritdoc />
        /// <summary>
        /// Gets a reference to an object <see cref="T:iTin.Export.Web.HttpResponseInfo" /> than contains the <strong>MIME</strong> type of the output stream and response header for a <strong>ASP.NET</strong> operation.
        /// </summary>
        /// <value>
        /// A <see cref="T:iTin.Export.Web.HttpResponseInfo" /> than contains the <strong>MIME</strong> type of the output stream and response header for a <strong>ASP.NET</strong> operation.
        /// </value>
        public override HttpResponseInfo ResponseInfo
        {          
            get
            {
                var parsedFilePath = Adapter.DataModel.Data.ParseRelativeFilePath(KnownRelativeFilePath.Output);
                var filename = Path.GetFileName(parsedFilePath);
                var outputFileDir = parsedFilePath.Replace(filename, string.Empty);

                var behavior = Table.Exporter.Behaviors.Get<TransformFileBehaviorModel>() ?? TransformFileBehaviorModel.Default;
                var outputTransformDir = behavior.IsDefault
                    ? outputFileDir
                    : Adapter.DataModel.Data.ParseRelativeFilePath(KnownRelativeFilePath.TransformFileBehaviorDir);

                var headerBuilder = new StringBuilder();
                headerBuilder.Append("attachment; filename=");
                headerBuilder.Append(
                    Result.Count > 1 ||
                    IsTransformationFile && 
                        behavior.Save.Equals(YesNo.Yes) && 
                        outputTransformDir.Equals(outputFileDir)
                            ? Path.ChangeExtension(filename, "zip") 
                            : Path.ChangeExtension(filename, ExtendedInformation.Extension));

                return new HttpResponseInfo
                {
                    ContentType = HttpResponseInfo.GetMimeMapping(ExtendedInformation.Extension), 
                    Header = headerBuilder.ToString()
                };
            }
        }
        #endregion
        
        #endregion

        #region private properties

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

        #region [private] (FixedModel) Fixed: Gets a reference to the resource fixed
        /// <summary>
        /// Gets a reference to the resource fixed.
        /// </summary>
        /// <value>
        /// Reference to the resource fixed.
        /// </value>
        private FixedModel Fixed => ModelResources.Fixed;
        #endregion

        #region [private] (GroupsModel) Groups: Gets a reference to the resource groups
        /// <summary>
        /// Gets a reference to the resource groups.
        /// </summary>
        /// <value>
        /// Reference to the resource groups.
        /// </value>
        private GroupsModel Groups => ModelResources.Groups;
        #endregion

        #region [private] (StylesModel) Styles: Gets a reference to the resource styles
        /// <summary>
        /// Gets a reference to the resource styles.
        /// </summary>
        /// <value>
        /// Reference to the resource styles.
        /// </value>
        private StylesModel Styles => ModelResources.Styles;
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

        #region [protected] {override} (void) Execute(): Generates output in MS Excel format
        /// <inheritdoc />
        /// <summary>
        /// Generates output in MS Excel format.
        /// </summary>
        protected override void Execute()
        {
            WriteBeginDocument();
                WriteBeginReport();
                    WriteBeginBody();
                        WriteBeginReportItems();
                        WriteEndReportItems();
                        WriteBeginHeight();
                        WriteEndHeight();
                        WriteBeginStyle();
                        WriteEndStyle();
                    WriteEndBody();
                    WriteBeginWidth();
                    WriteEndWidth();
                    WriteBeginPage();
                        WriteBeginPageHeight();
                        WriteEndPageHeight();
                        WriteBeginPageWidth();
                        WriteEndPageWidth();
                        WriteBeginLeftMargin();
                        WriteEndLeftMargin();
                        WriteBeginRightMargin();
                        WriteEndRightMargin();
                        WriteBeginTopMargin();
                        WriteEndTopMargin();
                        WriteBeginBottomMargin();
                        WriteEndBottomMargin();
                        WriteBeginColumnSpacing();
                        WriteEndColumnSpacing();
                        WriteBeginStyle();
                        WriteEndStyle();
                    WriteEndPage();
                    WriteBeginAutoRefresh();
                    WriteEndAutoRefresh();
                    WriteBeginDataSources();
                    WriteEndDataSources();
                    WriteBeginDataSets();
                    WriteEndDataSets();
                    WriteBeginReportParameters();
                    WriteEndReportParameters();
                    WriteBeginCode();
                    WriteEndCode();
                    WriteEndReport();
            WriteEndDocument();
        }
        #endregion

        #endregion

        #region private methods

        #region [private] (void) WriteBeginDocument(): Top of the document
        /// <summary>
        /// Top of the document.
        /// </summary>
        private void WriteBeginDocument()
        {
            Writer.WriteStartDocument();
        }
        #endregion

        #region [private] (void) WriteBeginReport(): Add report element to this document
        /// <summary>
        /// Add report element to this document.
        /// </summary>
        private void WriteBeginReport()
        {
            Writer.WriteStartElement("Report");
                Writer.WriteAttributeString("xmlns", string.Empty, null, "http://schemas.microsoft.com/sqlserver/reporting/2008/01/reportdefinition");
                Writer.WriteAttributeString("xmlns", "rd", null, "http://schemas.microsoft.com/SQLServer/reporting/reportdesigner");
        }
        #endregion

        #region [private] (void) WriteBeginBody(): Add body element to this document
        /// <summary>
        /// Add body element to this document.
        /// </summary>
        private void WriteBeginBody()
        {
            Writer.WriteStartElement("Body");
        }
        #endregion

        #region [private] (void) WriteBeginReportItems(): Add reportitems element to this document
        /// <summary>
        /// Add reportitems element to this document.
        /// </summary>
        private void WriteBeginReportItems()
        {
            Writer.WriteStartElement("ReportItems");
        }
        #endregion

        #region [private] (void) WriteBeginHeight(): Add height element to this document
        /// <summary>
        /// Add height element to this document.
        /// </summary>
        private void WriteBeginHeight()
        {
            Writer.WriteStartElement("Height");
        }
        #endregion

        #region [private] (void) WriteBeginStyle(): Add style element to this document
        /// <summary>
        /// Add style element to this document.
        /// </summary>
        private void WriteBeginStyle()
        {
            Writer.WriteStartElement("Style");
        }
        #endregion

        
        #region [private] (void) WriteEndStyle(): Ends style element
        /// <summary>
        /// Ends reportitems element.
        /// </summary>
        private void WriteEndStyle()
        {
            Writer.WriteEndElement();
        }
        #endregion

        #region [private] (void) WriteEndHeight(): Ends height element
        /// <summary>
        /// Ends reportitems element.
        /// </summary>
        private void WriteEndHeight()
        {
            Writer.WriteEndElement();
        }
        #endregion

        #region [private] (void) WriteEndReportItems(): Ends reportitems element
        /// <summary>
        /// Ends reportitems element.
        /// </summary>
        private void WriteEndReportItems()
        {
            Writer.WriteEndElement();
        }
        #endregion

        #region [private] (void) WriteEndBody(): Ends body element
        /// <summary>
        /// Ends body element.
        /// </summary>
        private void WriteEndBody()
        {
            Writer.WriteEndElement();
        }
        #endregion


        #region [private] (void) WriteBeginWidth(): Add width element to this document
        /// <summary>
        /// Add width element to this document.
        /// </summary>
        private void WriteBeginWidth()
        {
            Writer.WriteStartElement("Width");
        }
        #endregion

        #region [private] (void) WriteEndWidth(): Ends width element
        /// <summary>
        /// Ends width element.
        /// </summary>
        private void WriteEndWidth()
        {
            Writer.WriteEndElement();
        }
        #endregion

        #region [private] (void) WriteBeginPage(): Add page element to this document
        /// <summary>
        /// Add page element to this document.
        /// </summary>
        private void WriteBeginPage()
        {
            Writer.WriteStartElement("Page");
        }
        #endregion

        #region [private] (void) WriteBeginPageHeight(): Add pageheight element to this document
        /// <summary>
        /// Add pageheight element to this document.
        /// </summary>
        private void WriteBeginPageHeight()
        {
            Writer.WriteStartElement("PageHeight");
        }
        #endregion

        #region [private] (void) WriteEndPageHeight(): Ends pageheight element
        /// <summary>
        /// Ends pagepageheight element.
        /// </summary>
        private void WriteEndPageHeight()
        {
            Writer.WriteEndElement();
        }
        #endregion

        #region [private] (void) WriteBeginPageWidth(): Add pagewidth element to this document
        /// <summary>
        /// Add pagewidth element to this document.
        /// </summary>
        private void WriteBeginPageWidth()
        {
            Writer.WriteStartElement("PageWidth");
        }
        #endregion

        #region [private] (void) WriteEndPageWidth(): Ends pagewidth element
        /// <summary>
        /// Ends pagewidth element.
        /// </summary>
        private void WriteEndPageWidth()
        {
            Writer.WriteEndElement();
        }
        #endregion

        #region [private] (void) WriteBeginLeftMargin(): Add LeftMargin element to this document
        /// <summary>
        /// Add LeftMargin element to this document.
        /// </summary>
        private void WriteBeginLeftMargin()
        {
            Writer.WriteStartElement("LeftMargin");
        }
        #endregion

        #region [private] (void) WriteEndLeftMargin(): Ends LeftMargin element
        /// <summary>
        /// Ends LeftMargin element.
        /// </summary>
        private void WriteEndLeftMargin()
        {
            Writer.WriteEndElement();
        }
        #endregion

        #region [private] (void) WriteBeginRightMargin(): Add RightMargin element to this document
        /// <summary>
        /// Add RightMargin element to this document.
        /// </summary>
        private void WriteBeginRightMargin()
        {
            Writer.WriteStartElement("RightMargin");
        }
        #endregion

        #region [private] (void) WriteEndRightMargin(): Ends RightMargin element
        /// <summary>
        /// Ends RightMargin element.
        /// </summary>
        private void WriteEndRightMargin()
        {
            Writer.WriteEndElement();
        }
        #endregion

        #region [private] (void) WriteBeginTopMargin(): Add TopMargin element to this document
        /// <summary>
        /// Add TopMargin element to this document.
        /// </summary>
        private void WriteBeginTopMargin()
        {
            Writer.WriteStartElement("TopMargin");
        }
        #endregion

        #region [private] (void) WriteEndTopMargin(): Ends TopMargin element
        /// <summary>
        /// Ends TopMargin element.
        /// </summary>
        private void WriteEndTopMargin()
        {
            Writer.WriteEndElement();
        }
        #endregion

        #region [private] (void) WriteBeginBottomMargin(): Add BottomMargin element to this document
        /// <summary>
        /// Add BottomMargin element to this document.
        /// </summary>
        private void WriteBeginBottomMargin()
        {
            Writer.WriteStartElement("BottomMargin");
        }
        #endregion

        #region [private] (void) WriteEndBottomMargin(): Ends BottomMargin element
        /// <summary>
        /// Ends TopMargin element.
        /// </summary>
        private void WriteEndBottomMargin()
        {
            Writer.WriteEndElement();
        }
        #endregion

        #region [private] (void) WriteBeginColumnSpacing(): Add ColumnSpacing element to this document
        /// <summary>
        /// Add ColumnSpacing element to this document.
        /// </summary>
        private void WriteBeginColumnSpacing()
        {
            Writer.WriteStartElement("ColumnSpacing");
        }
        #endregion

        #region [private] (void) WriteEndColumnSpacing(): Ends ColumnSpacing element
        /// <summary>
        /// Ends ColumnSpacing element.
        /// </summary>
        private void WriteEndColumnSpacing()
        {
            Writer.WriteEndElement();
        }
        #endregion

        #region [private] (void) WriteEndPage(): Ends page element
        /// <summary>
        /// Ends page element.
        /// </summary>
        private void WriteEndPage()
        {
            Writer.WriteEndElement();
        }
        #endregion

        #region [private] (void) WriteBeginAutoRefresh(): Add AutoRefresh element to this document
        /// <summary>
        /// Add AutoRefresh element to this document.
        /// </summary>
        private void WriteBeginAutoRefresh()
        {
            Writer.WriteStartElement("AutoRefresh");
        }
        #endregion

        #region [private] (void) WriteEndAutoRefresh(): Ends AutoRefresh element
        /// <summary>
        /// Ends AutoRefresh element.
        /// </summary>
        private void WriteEndAutoRefresh()
        {
            Writer.WriteEndElement();
        }
        #endregion

        #region [private] (void) WriteBeginDataSources(): Add DataSources element to this document
        /// <summary>
        /// Add AutoRefresh element to this document.
        /// </summary>
        private void WriteBeginDataSources()
        {
            Writer.WriteStartElement("DataSources");
        }
        #endregion

        #region [private] (void) WriteEndDataSources(): Ends DataSources element
        /// <summary>
        /// Ends DataSources element.
        /// </summary>
        private void WriteEndDataSources()
        {
            Writer.WriteEndElement();
        }
        #endregion

        #region [private] (void) WriteBeginDataSets(): Add DataSets element to this document
        /// <summary>
        /// Add DataSets element to this document.
        /// </summary>
        private void WriteBeginDataSets()
        {
            Writer.WriteStartElement("DataSets");
        }
        #endregion

        #region [private] (void) WriteEndDataSources(): Ends DataSets element
        /// <summary>
        /// Ends DataSets element.
        /// </summary>
        private void WriteEndDataSets()
        {
            Writer.WriteEndElement();
        }
        #endregion

        #region [private] (void) WriteBeginReportParameters(): Add ReportParameters element to this document
        /// <summary>
        /// Add ReportParameters element to this document.
        /// </summary>
        private void WriteBeginReportParameters()
        {
            Writer.WriteStartElement("ReportParameters");
        }
        #endregion

        #region [private] (void) WriteEndReportParameters(): Ends ReportParameters element
        /// <summary>
        /// Ends ReportParameters element.
        /// </summary>
        private void WriteEndReportParameters()
        {
            Writer.WriteEndElement();
        }
        #endregion

        #region [private] (void) WriteBeginCode(): Add Code element to this document
        /// <summary>
        /// Add Code element to this document.
        /// </summary>
        private void WriteBeginCode()
        {
            Writer.WriteStartElement("Code");
        }
        #endregion

        #region [private] (void) WriteEndCode(): Ends Code element
        /// <summary>
        /// Ends Code element.
        /// </summary>
        private void WriteEndCode()
        {
            Writer.WriteEndElement();
        }
        #endregion

        #region [private] (void) WriteEndReport(): Ends report element
        /// <summary>
        /// Ends report element.
        /// </summary>
        private void WriteEndReport()
        {
            Writer.WriteEndElement();
        }
        #endregion

        #region [private] (void) WriteEndDocument(): Ends MS Excel document
        /// <summary>
        /// Ends MS Excel document.
        /// </summary>
        private void WriteEndDocument()
        {
            Writer.Flush();
        }
        #endregion


        #region [private] (void) WriteVariableDeclaration(): Create global variables
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
        #endregion

        #region [private] (void) WriteStartWorkbook(): Add a new book to MS Excel
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
        #endregion

        #region [private] (void) WriteOfficeDocumentSettings(): Adds OfficeDocumentSettings element
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
        #endregion

        #region [private] (void) WriteStartStyles(): Add MS Excel styles
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
        #endregion

        #region [private] (void) WriteStyles(): Add user-defined styles
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
        #endregion

        #region [private] (void) WriteDefaultStyle(): Add default style
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
        #endregion

        #region [private] (void) WriteUserDefinedStyle(StyleModel, [bool wrap]): Add style to the collection of styles MS Excel
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
        #endregion

        #region [private] (void) WriteBorder(BorderModel): Add border to the collection of borders MS Excel
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
        #endregion

        #region [private] (void) WriteEndStyles(): Ends the definition of styles
        /// <summary>
        /// Ends the definition of styles.
        /// </summary>
        private void WriteEndStyles()
            {
            Writer.WriteEndElement();
        }
        #endregion

        #region [private] (void) WriteStartWorksheet(): Adds a new sheet to book
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
        #endregion

        #region [private] (void) WriteNamedRanges(): Add named ranges to sheet
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
        #endregion

        #region [private] (void) WriteStartNames(): Add start of named ranges
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
        #endregion

        #region [private] (void) WriteNamedRange(string, string, bool, bool): Add new named range to the collection
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
        #endregion

        #region [private] (void) WriteEndNames(): Ends the definition of named ranges
        /// <summary>
        /// Ends the definition of named ranges.
        /// </summary>
        private void WriteEndNames()
        {
            Writer.WriteEndElement();
        }
        #endregion

        #region [private] (void) WriteStartTable(): Add a new table to sheet
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
        #endregion

        #region [private] (void) WriteTableContent(): Add headers, aggregates, and data
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
        #endregion

        #region [private] (void) WriteColumnWidths(): Add column sizes
        /// <summary>
        /// Add column sizes.
        /// </summary>
        private void WriteColumnWidths()
        {
            var columnDictionary = Table.GetHeaderColumnsSize(Adapter);
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
        #endregion

        #region [private] (void) WriteTopAggregates(): Add top aggregates
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
        #endregion

        #region [private] (void) WriteHeader(): Add headers
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
        #endregion

        #region [private] (void) WriteRowDetail(): Add row data
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
                            value = Writer.WriteTestSpreadsheet2003Field(Adapter.Parse(dataField.Name), style);
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
                                Writer.WriteDataFieldErrorComment(Adapter.Parse(dataField.Name), style);
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
        #endregion

        #region [private] (void) WriteBottomAggregates(): Add bottom aggregates
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
        #endregion

        #region [private] (void) WriteEndTable(): Ends the definition of table
        /// <summary>
        /// Ends the definition of table.
        /// </summary>
        private void WriteEndTable()
        {
            Writer.WriteEndElement();
        }
        #endregion

        #region [private] (void) WriteWorkSheetOptions(): Ends the definition of table
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
        #endregion

        #region [private] (void) WriteWorkSheetOptionsPageSetup():
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
        #endregion

        #region [private] (void) WriteAutoFilter(): Add filters
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
        #endregion

        #region [private] (void) WriteAutoFilterItem(string): Add a new filter
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
        #endregion

        #region [private] (void) WriteEndWorksheet(): Ends the definition of sheet
        /// <summary>
        /// Ends the definition of sheet.
        /// </summary>
        private void WriteEndWorksheet()
        {
            Writer.WriteEndElement();
        }
        #endregion

        #region [private] (void) WriteEndWorkbook(): Ends the definition of book
        /// <summary>
        /// Ends the definition of book.
        /// </summary>
        private void WriteEndWorkbook()
        {
            Writer.WriteEndElement();
        }
        #endregion

        #endregion
    }
}
