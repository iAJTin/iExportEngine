using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;

using iTextSharp.text;
using iTextSharp.text.pdf;

using iTin.Export.ComponentModel;
using iTin.Export.Model;

namespace iTin.Export.Writers.Adobe
{
    /// <summary>
    /// Represents custom writer for Portable Document Format (pdf format).
    /// </summary>
    /// <remarks>
    ///   <para>This writer is based <c>iTextSharp</c> open source project</para>
    ///   <para>For more information please see <a href="http://sourceforge.net/projects/itextsharp/">http://sourceforge.net/projects/itextsharp//</a></para>
    /// </remarks>
    [Export(typeof(IWriter))]
    [WriterOptions(Name = "PdfTabularWriter", Author = "iTin", Company = "iTin", Version = 1, Extension = "pdf", Description = "Portable Document Format Writer")]
    public class PdfTabularWriter : BaseWriterDirect
    {
        /// <summary>
        /// Generates output in Portable Document Format [ pdf ].
        /// </summary>
        protected override void Execute()
        {
            using (var stream = new MemoryStream())
            {
                using (var document = new Document())
                {
                    #region initialize
                    var fields = Table.Fields;
                    #endregion

                    #region get target data
                    var rows = Adapter.ToXml().ToArray();
                    #endregion

                    #region add data
                    var cells = new Collection<PdfPCell>();
                    var fieldsTable = new Dictionary<BaseDataFieldModel, int>();
                    foreach (var row in rows)
                    {
                        foreach (var field in fields)
                        {
                            field.DataSource = row;
                            var value = field.Value.GetValue(Adapter.SpecialChars);
                            var valueLenght = value.FormattedValue.Length;

                            if (!fieldsTable.ContainsKey(field))
                            {
                                fieldsTable.Add(field, valueLenght);
                            }
                            else
                            {
                                var entry = fieldsTable[field];
                                if (valueLenght > entry)
                                {
                                    fieldsTable[field] = valueLenght;
                                }
                            }
                               
                            cells.Add(PdfHelper.CreateCell(value));
                        }
                    }
                    #endregion

                    #region create pdf document, sets document orientation and create an empty table
                    var writer = PdfWriter.GetInstance(document, stream);

                    var hostDocument = Host.Document;
                    var pageSize = hostDocument.Size.ToPageSize();
                    if (hostDocument.Orientation == KnownDocumentOrientation.Landscape)
                    {
                        pageSize = pageSize.Rotate();
                    }

                    document.SetPageSize(pageSize);
                    document.SetMarginsFromModel(hostDocument.Margins);

                    var table = new PdfPTable(fields.Count);
                    table.SetHorizontalLocationFrom(Table.Location);
                    #endregion

                    #region autofitcolumns?
                    table.AutoFitColumns(fieldsTable, this);
                    #endregion

                    #region assign class to handle document events
                    writer.PageEvent = new PdfPageEvent(this, table, rows);
                    #endregion

                    #region opens document
                    document.Open();
                    #endregion

                    #region add cells to table
                    table.AddCells(cells);
                    #endregion

                    #region add bottom aggregate
                    table.AddAggregateByLocation(Table, rows, Adapter.SpecialChars.ToArray(), KnownAggregateLocation.Bottom);
                    #endregion

                    #region add table to document
                    document.Add(table);
                    #endregion
                }

                #region save
                Result.Add(stream.ToArray());
                #endregion
            }
        }
    }
}
