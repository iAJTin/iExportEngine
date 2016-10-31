using System.Linq;
using System.Xml.Linq;

using iTextSharp.text;
using iTextSharp.text.pdf;

using iTin.Export.Model;

namespace iTin.Export.Writers.Adobe
{
    /// <summary>
    /// A Specialization of <see cref="T:iTextSharp.text.pdf.PdfPageEventHelper" /> class.<br/>.
    /// Which handles page events of pdf document.
    /// </summary>
    class PdfPageEvent : PdfPageEventHelper
    {
        #region Constructor/s

            #region [public] PdfPageEvent(PdfTabularWriter, PdfPTable, XElement[]): Initializes a new instance of the class.
            /// <summary>
            /// Initializes a new instance of the <see cref="T:iTin.Export.Writers.Adobe.PdfPageEvent" /> class.
            /// </summary>
            /// <param name="model">Reference to writer.</param>
            /// <param name="table">Current table.</param>
            /// <param name="rawData">Raw data.</param>
            public PdfPageEvent(PdfTabularWriter model, PdfPTable table, XElement[] rawData)
            {
                PdfTable = table;
                RawData = rawData;
                TabularWriter = model;
            }
            #endregion

        #endregion

        #region Public Properties

            #region [public] (PdfPTable) PdfTable: Gets current pdf table.
            /// <summary>
            /// Gets current pdf table.
            /// </summary>
            /// <value>
            /// The PDF table.
            /// </value>
            public PdfPTable PdfTable { get; private set; }
            #endregion

            #region [public] (XElement[]) RawData: Gets raw data of export.
            /// <summary>
            ///  Gets raw data of export.
            /// </summary>
            /// <value>
            /// Raw data of export.
            /// </value>
            public XElement[] RawData { get; private set; }
            #endregion

            #region [public] (PdfTabularWriter) TabularWriter: Gets a reference to used writer.
            /// <summary>
            /// Gets a reference to used writer.
            /// </summary>
            /// <value>
            /// A reference to used <see cref="T:iTin.Export.Writers.Adobe.PdfTabularWriter"/> for generate this pdf report.
            /// </value>
            public PdfTabularWriter TabularWriter { get; private set; }
            #endregion

        #endregion

        #region Public Override Methods

            #region [public] {override} (void) OnEndPage(iTextSharp.text.pdf.PdfWriter, iTextSharp.text.Document): Called when a page is finished, just before being written to the document.
            /// <summary>
            /// Called when a page is finished, just before being written to the document.
            /// </summary>
            /// <param name="writer">Writer the <see cref="iTextSharp.text.pdf.PdfWriter"/> for this document</param>
            /// <param name="document">Current document</param>
            public override void OnEndPage(PdfWriter writer, Document document)
            {
                base.OnEndPage(writer, document);

                var footer = new PdfPTable(new[] { 1f })
                                 {
                                     TotalWidth = 300f
                                 };

                var footerText = string.Concat("- ", writer.PageNumber, " -");
                var phrase = new Phrase(footerText, PdfHelper.CreateFont(FontModel.Default));
                var cell = new PdfPCell(phrase)
                               {
                                   HorizontalAlignment = Element.ALIGN_CENTER,
                                   BorderWidth = 0
                               };

                footer.AddCell(cell);
                footer.WriteSelectedRows(
                    0,
                    -1,
                    (document.PageSize.Width - footer.TotalWidth) / 2,
                    document.Bottom,
                    writer.DirectContent);
            }
            #endregion

            #region [public] {override} (void) OnStartPage(iTextSharp.text.pdf.PdfWriter, iTextSharp.text.Document): Called when a page is started.
            /// <summary>
            /// Called when a page is started.
            /// </summary>
            /// <param name="writer">Writer the <see cref="iTextSharp.text.pdf.PdfWriter"/> for this document</param>
            /// <param name="document">Current document</param>
            public override void OnStartPage(PdfWriter writer, Document document)
            {
                base.OnStartPage(writer, document);

                #region initialize
                var table = TabularWriter.Table;
                var target = TabularWriter.Adapter;
                #endregion

                #region add logo
                document.AddLogo(table.Logo);
                #endregion

                #region sets vertical table position
                document.SetVerticalLocationFrom(table.Location);
                #endregion   
           
                #region add top aggregates
                var tempTable = new PdfPTable(PdfTable.NumberOfColumns);
                tempTable.SetTotalWidth(PdfTable.AbsoluteWidths);
                tempTable.HorizontalAlignment = PdfTable.HorizontalAlignment;
                tempTable.LockedWidth = table.AutoFitColumns == YesNo.Yes;

                if (writer.PageNumber == 1)
                {
                    tempTable.AddAggregateByLocation(
                        table,
                        RawData,
                        target.SpecialChars.ToArray(),
                        KnownAggregateLocation.Top);
                }
                #endregion

                #region add column headers
                tempTable.AddColumnHeaders(table);
                #endregion

                #region add field headers
                tempTable.AddFieldHeaders(table);
                #endregion

                #region add table to this document
                document.Add(tempTable);
                #endregion
            }
            #endregion

        #endregion
    }
}
