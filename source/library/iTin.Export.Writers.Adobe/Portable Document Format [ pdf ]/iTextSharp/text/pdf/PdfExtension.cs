
namespace iTextSharp.text.pdf
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Drawing;
    using System.Linq;
    using System.Xml.Linq;

    using iTin.Export.ComponentModel;
    using iTin.Export.Helpers;
    using iTin.Export.Model;
    using iTin.Export.Writers.Adobe;

    /// <summary>
    /// Static class than contains common extension methods for objects of the namespace <see cref="N:iTextSharp.text.pdf"/>.
    /// </summary>
    internal static class PdfExtension
    {
        #region public static methods

        #region [public] {static} (PdfPTable) AddAggregateByLocation(this PdfPTable, StyleModel): Adds aggregate to specified table from export model
        /// <summary>
        /// Adds aggregate to specified table from export model.
        /// </summary>
        /// <param name="table">Destination table for headers</param>
        /// <param name="model">Export table model</param>
        /// <param name="rows">Source data for calculate the aggregate</param>
        /// <param name="specialChars">The special chars</param>
        /// <param name="aggregateLocation">The aggregate location</param>
        /// <returns>
        /// table with
        /// </returns>
        public static PdfPTable AddAggregateByLocation(this PdfPTable table, TableModel model, XElement[] rows, char[] specialChars, KnownAggregateLocation aggregateLocation)
        {
            SentinelHelper.ArgumentNull(table);
            SentinelHelper.ArgumentNull(model);

            var hasAnyAggregate = model.Fields.Any(field => field.Aggregate.Show == YesNo.Yes && field.Aggregate.Location == aggregateLocation);
            if (!hasAnyAggregate)
            {
                return table;
            }

            var fix = model.Parent.Resources.Fixed;

            var rowsCount = rows.Count();
            var fields = model.Fields;
            var attributes = rows.Attributes().ToList();
            foreach (var field in fields)
            {
                var style = field.Aggregate.GetStyle();

                if (field.Aggregate.Show == YesNo.Yes &&
                    field.Aggregate.Location == aggregateLocation)
                {
                    var formula = new NonTabularFormulaResolver(field.Aggregate);

                    switch (field.FieldType)
                    {
                        #region Field: Field
                        case KnownFieldType.Field:
                            BaseDataFieldModel field1 = field;
                            formula.Data =
                                attributes.Where(
                                    attr =>
                                    attr.Name.LocalName.ToUpperInvariant()
                                        .Equals(
                                            BaseDataFieldModel.GetFieldNameFrom(field1).ToUpperInvariant()))
                                    .Select(n => n.Value);
                            break;
                        #endregion

                        #region Field: Fixed
                        case KnownFieldType.Fixed:
                            var fixedFieldModel = (FixedFieldModel)field;
                            var piecesModel = fix[fixedFieldModel.Pieces];

                            BaseDataFieldModel field2 = field;
                            var dataList =
                                rows.Select(row => piecesModel.DataSource = row)
                                    .Select(entries => piecesModel.ToDictionary())
                                    .Select(entry => entry[BaseDataFieldModel.GetFieldNameFrom(field2)]);

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
                            var groupFieldModel = (GroupFieldModel)field;

                            var groupDataList = new List<string>();
                            foreach (var row in rows)
                            {
                                groupFieldModel.DataSource = row;
                                var group = groupFieldModel.Value.GetValue(specialChars);
                                groupDataList.Add(@group.FormattedValue);
                            }

                            formula.Data = groupDataList;
                            break;
                        #endregion
                    }

                    table.AddCell(PdfHelper.CreateCell(style.Content.DataType.GetFormattedDataValue(formula.Resolve())));
                }
                else
                {
                    var emptyStyle = StyleModel.Empty;
                    emptyStyle.Content = style.Content;
                    emptyStyle.Content.DataType = new TextDataTypeModel();
                    ////emptyStyle.SetOwner(model.Styles);
                    table.AddCell(PdfHelper.CreateCell(style.Content.DataType.GetFormattedDataValue(string.Empty)));
                }
            }

            return table;
        }
        #endregion

        #region [public] {static} (PdfPTable) AddCells(this PdfPTable, Collection<PdfPCell>): Adds aggregate to specified table from export model
        /// <summary>
        /// Adds the cells.
        /// </summary>
        /// <param name="table">The Table.</param>
        /// <param name="cells">Cells to adds.</param>
        /// <returns>
        /// <see cref="T:iTextSharp.text.pdf.PdfPTable" /> which contains the range cells.
        /// </returns>
        public static PdfPTable AddCells(this PdfPTable table, Collection<PdfPCell> cells)
        {
            SentinelHelper.ArgumentNull(table);
            SentinelHelper.ArgumentNull(cells);

            foreach (var cell in cells)
            {
                table.AddCell(cell);
            }

            return table;
        }
        #endregion
            
        #region [public] {static} (PdfPTable) AddColumnHeaders(this PdfPTable, TableModel): Adds column headers to specified table from export model
        /// <summary>
        /// Adds column headers to specified table from export model.
        /// </summary>
        /// <param name="table">Destination table for headers</param>
        /// <param name="model">Export table model</param>
        /// <returns>
        /// table with columns headers.
        /// </returns>
        public static PdfPTable AddColumnHeaders(this PdfPTable table, TableModel model)
        {
            SentinelHelper.ArgumentNull(table);
            SentinelHelper.ArgumentNull(model);

            if (model.ShowColumnHeaders == YesNo.No)
            {
                return table;
            }

            var fields = model.Fields;
            var columnHeaders = model.Headers;
            foreach (var columnHeader in columnHeaders)
            {
                var fromField = fields[columnHeader.From];
                var toField = fields[columnHeader.To];

                var from = fields.IndexOf(fromField);
                var to = fields.IndexOf(toField);

                var text = columnHeader.Show == YesNo.Yes ? columnHeader.Text : string.Empty;
                var cell = PdfHelper.CreateCell(text, columnHeader.GetStyle());
                cell.Colspan = (to - from) + 1;
                table.AddCell(cell);
            }

            return table;
        }
        #endregion

        #region [public] {static} (PdfPTable) AddFieldHeaders(this PdfPTable, TableModel): Adds headers to specified table from export model
        /// <summary>
        /// Adds headers to specified table from export model.
        /// </summary>
        /// <param name="table">Destination table for headers</param>
        /// <param name="model">Export table model</param>
        /// <returns>
        /// table with
        /// </returns>
        public static PdfPTable AddFieldHeaders(this PdfPTable table, TableModel model)
        {
            SentinelHelper.ArgumentNull(table);
            SentinelHelper.ArgumentNull(model);

            var fields = model.Fields;
            foreach (var field in fields)
            {                
                var style = field.Header.GetStyle();

                table.AddCell(
                    field.Header.Show == YesNo.Yes
                        ? PdfHelper.CreateCell(style.Content.DataType.GetFormattedDataValue(field.Alias))
                        : PdfHelper.CreateCell(StyleModel.Empty.Content.DataType.GetFormattedDataValue(field.Alias)));
            }

            return table;
        }
        #endregion

        #region [public] {static} (PdfPTable) AutoFitColumns(this PdfPTable, IDictionary<BaseDataFieldModel, int>, IWriter): Automatics the fit group columns
        /// <summary>
        /// Automatics the fit group columns.
        /// </summary>
        /// <param name="table">The table.</param>
        /// <param name="dictionary">Group fields data.</param>
        /// <param name="writer">Current writer.</param>
        /// <returns>
        /// <see cref="T:iTextSharp.text.pdf.PdfPTable" /> which contains adjusted columns.
        /// </returns>
        public static PdfPTable AutoFitColumns(this PdfPTable table, IDictionary<BaseDataFieldModel, int> dictionary, IWriter writer)
        {
            SentinelHelper.ArgumentNull(table);
            SentinelHelper.ArgumentNull(dictionary);
            SentinelHelper.ArgumentNull(writer);

            var widthOfColumns = DefaultColumnWidths(writer.Table.Fields);

            table.LockedWidth = true;
            foreach (var entry in dictionary)
            {
                var index = writer.Table.Fields.IndexOf(entry.Key);
                var style = writer.DataModel.Resources.Styles[entry.Key.Value.Style];

                var maxColumnLenght = entry.Key.Alias.Length > entry.Value
                                            ? entry.Key.Alias.Length
                                            : entry.Value;
                using (var bitmap = new Bitmap(1, 1))
                {
                    using (var graphics = Graphics.FromImage(bitmap))
                    {
                        using (var font = style.Font.ToFont())
                        {
                            var singleCharWidth = graphics.MeasureString("0", font).Width;
                            var doubleCharWidth = graphics.MeasureString("00", font).Width;

                            var charWidth = doubleCharWidth - singleCharWidth;
                            var valueWidth = charWidth * (1.5f + maxColumnLenght + 1.5f);

                            widthOfColumns[index] = valueWidth;
                        }
                    }
                }
            }

            table.SetTotalWidth(widthOfColumns);
            return table;
        }
        #endregion

        #region [public] {static} (PdfPTable) SetHorizontalLocationFrom(this PdfPTable, LocationModel): Sets initial horizontal location of table
        /// <summary>
        /// Sets initial horizontal location of <see cref="T:iTextSharp.text.pdf.PdfPTable" />.
        /// </summary>
        /// <param name="table">Table which receives new position.</param>
        /// <param name="location">Location to apply.</param>
        /// <returns>
        /// A <see cref="T:iTextSharp.text.pdf.PdfPTable" /> object which contains specified position.
        /// </returns>
        /// <remarks>
        /// If value of <see cref="P:iTin.Export.Model.LocationModel.Mode"/> is <see cref="iTin.Export.Model.KnownElementLocation.ByCoordenates"/>
        /// uses the default configuration, the horizontal alignment is set to center and vertical alignment set to top.
        /// </remarks>
        public static PdfPTable SetHorizontalLocationFrom(this PdfPTable table, LocationModel location)
        {
            var locationType = location.LocationType;
            if (locationType.Equals(KnownElementLocation.ByCoordenates))
            {
                return table;
            }

            table.HorizontalAlignment = ((AlignmentModel)location.Mode).Horizontal.ToElementHorizontalAlignment();

            return table;
        }
        #endregion

        #region [public] {static} (PdfPCell) SetVisualStyle(this PdfPCell, StyleModel): Sets visual style for specified cell
        /// <summary>
        /// Sets visual style for specified cell.
        /// </summary>
        /// <param name="cell">Cell which receives visual style.</param>
        /// <param name="style">Style to apply.</param>
        /// <returns>
        /// A <see cref="T:iTextSharp.text.pdf.PdfPCell" /> object which contains specified visual style.
        /// </returns>
        public static PdfPCell SetVisualStyle(this PdfPCell cell, StyleModel style)
        {
            SentinelHelper.ArgumentNull(cell);
            SentinelHelper.ArgumentNull(style);

            cell.BackgroundColor = new BaseColor(style.Content.GetColor());
            cell.VerticalAlignment = style.Content.Alignment.Vertical.ToElementVerticalAlignment();
            cell.HorizontalAlignment = style.Content.Alignment.Horizontal.ToElementHorizontalAlignment();

            return cell;
        }
        #endregion

        #endregion

        #region private static methods

        #region [private] {static} (float[]) DefaultColumnWidths(IEnumerable<BaseDataFieldModel>): Returns an array containing defaults for width for columns of a Table
        /// <summary>
        /// Returns an array containing defaults for width for columns of a <see cref="T:iTextSharp.text.pdf.PdfPTable" />.
        /// </summary>
        /// <param name="fields">List of columns.</param>
        /// <returns>
        /// Returns defaults for width for columns of a <see cref="T:iTextSharp.text.pdf.PdfPTable" />.
        /// </returns>
        private static float[] DefaultColumnWidths(IEnumerable<BaseDataFieldModel> fields)
        {
            var elements = fields.Count();
            var widths = new float[elements];

            for (var i = 0; i < elements; i++)
            {
                widths[i] = 1f;
            }

            return widths;
        }
        #endregion

        #region [private] {static} (int) ToElementHorizontalAlignment(this KnownHorizontalAlignment): Converts the enumerated type KnownHorizontalAlignment to the appropriate value for the specified alignment
        /// <summary>
        /// Converts the enumerated type <see cref="T:iTin.Export.Model.KnownHorizontalAlignment"/> to the appropriate value for the specified alignment.
        /// </summary>
        /// <param name="alignment">Alignment to convert.</param>
        /// <returns>
        /// A <see cref="T:System.Int32" /> value that represents appropriate the value for the specified alignment.
        /// </returns>
        private static int ToElementHorizontalAlignment(this KnownHorizontalAlignment alignment)
        {
            var pdfAlignment = Element.ALIGN_LEFT;
            switch (alignment)
            {
                case KnownHorizontalAlignment.Center:
                    pdfAlignment = Element.ALIGN_CENTER;
                    break;

                case KnownHorizontalAlignment.Right:
                    pdfAlignment = Element.ALIGN_RIGHT;
                    break;
            }

            return pdfAlignment;
        }
        #endregion

        #region [private] {static} (int) ToElementVerticalAlignment(this KnownVerticalAlignment): Converts the enumerated type KnownVerticalAlignment to the appropriate value for the specified alignment
        /// <summary>
        /// Converts the enumerated type <see cref="T:iTin.Export.Model.KnownVerticalAlignment"/> to the appropriate value for the specified alignment.
        /// </summary>
        /// <param name="alignment">Alignment to convert.</param>
        /// <returns>
        /// A <see cref="T:System.Int32" /> value that represents appropriate the value for the specified alignment.
        /// </returns>
        private static int ToElementVerticalAlignment(this KnownVerticalAlignment alignment)
        {
            var pdfAlignment = Element.ALIGN_MIDDLE;
            switch (alignment)
            {
                case KnownVerticalAlignment.Bottom:
                    pdfAlignment = Element.ALIGN_BOTTOM;
                    break;

                case KnownVerticalAlignment.Top:
                    pdfAlignment = Element.ALIGN_TOP;
                    break;
            }

            return pdfAlignment;
        }
        #endregion

        #endregion
    }
}
