
namespace Novacode
{
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.IO;
    using System.Linq;
    using System.Text;

    using iTin.Export.ComponentModel;
    using iTin.Export.Helpers;
    using iTin.Export.Model;

    /// <summary>
    /// Static class than contains common extension methods for objects of the namespace <see cref="N:Novacode"/>.
    /// </summary>
    internal static class NovacodeExtension
    {
        #region public static methods

        #region [public] {static} (DocX) AppendLogoFromModel(this DocX, LogoModel): Adds the logo inside the document
        /// <summary>
        /// Adds the logo inside the document.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <param name="logo">Logo model.</param>
        /// <returns>
        /// Returns the <see cref="T:Novacode.DocX" /> which contains the logo inside.
        /// </returns>
        public static DocX AppendLogoFromModel(this DocX document, LogoModel logo)
        {
            SentinelHelper.ArgumentNull(logo);
            SentinelHelper.ArgumentNull(document);

            if (logo.IsDefault)
            {
                return document;
            }

            if (logo.Show == YesNo.No)
            {
                return document;
            }

            var found = logo.Image.TryGetImage(out var imageLogo);
            if (!found)
            {
                return document;
            }

            var root = logo.Parent.Parent;
            var imagePath = root.Resources.GetImageResourceByKey(logo.Image.Key).Path;
            var imageFileName = Path.GetFileNameWithoutExtension(root.ParseRelativeFilePath(imagePath));

            var modifiedImageFileNamePathBuilder = new StringBuilder();
            modifiedImageFileNamePathBuilder.Append(FileHelper.TinExportTempDirectory);
            modifiedImageFileNamePathBuilder.Append(imageFileName);
            modifiedImageFileNamePathBuilder.Append(".png");

            imageLogo.Save(modifiedImageFileNamePathBuilder.ToString(), ImageFormat.Png);

            var logoWidth = logo.LogoSize.Width == -1
                                ? imageLogo.Width
                                : logo.LogoSize.Width;

            var logoHeight = logo.LogoSize.Height == -1
                                    ? imageLogo.Height
                                    : logo.LogoSize.Height;

            var img = document.AddImage(modifiedImageFileNamePathBuilder.ToString());
            var picture = img.CreatePicture(logoHeight, logoWidth);
            picture.SetPictureShape(RectangleShapes.rect);

            document.SetVerticalLocationFrom(logo.Location);
            var paragraph = document.InsertParagraph(string.Empty, false);
            paragraph.InsertPicture(picture).SetHorizontalAlignmentFrom(logo.Location);

            return document;
        }
        #endregion

        #region [public] {static} (Cell) AppendText(this Cell, string): Add a string to the cell
        /// <summary>
        /// Add a string to the cell.
        /// </summary>
        /// <param name="cell">The cell.</param>
        /// <param name="text">The text.</param>
        /// <returns>
        /// A <see cref="T:Novacode.Cell" /> with text.
        /// </returns>
        public static Cell AppendText(this Cell cell, string text)
        {
            SentinelHelper.ArgumentNull(cell);
            SentinelHelper.ArgumentNull(text);

            cell.Paragraphs.First().Append(text);
            return cell;
        }
        #endregion

        #region [public] {static} (Cell) AppendText(this Cell, FieldValueInformation): Add a string to the cell
        /// <summary>
        /// Add a string to the cell.
        /// </summary>
        /// <param name="cell">Current cell.</param>
        /// <param name="value">Reference to <see cref="T:iTin.Export.ComponentModel.FieldValueInformation"/> that contains the information to add.</param>
        /// <returns>
        /// A <see cref="T:Novacode.Cell" /> with text.
        /// </returns>
        public static Cell AppendText(this Cell cell, FieldValueInformation value)
        {
            SentinelHelper.ArgumentNull(cell);

            var style = value.Style;
            var formattedValue = value.FormattedValue;

            var isNumeric = value.IsNumeric;
            if (isNumeric)
            {
                var isNegative = value.IsNegative;
                if (isNegative)
                {
                    cell.AppendText(formattedValue).AppendNegativeVisualStyle(style);
                }
                else
                {
                    cell.AppendText(formattedValue).AppendVisualStyle(style);
                }
            }
            else
            {
                cell.AppendText(formattedValue).AppendVisualStyle(style);
            }

            return cell;
        }
        #endregion

        #region [public] {static} (Paragraph) AppendNegativeVisualStyle(this Cell, StyleModel): Appends the negative visual style to this paragraph
        /// <summary>
        /// Appends the negative visual style to this paragraph.
        /// </summary>
        /// <param name="cell">The cell.</param>
        /// <param name="style">The style.</param>
        /// <returns>
        /// A <see cref="Novacode.Paragraph" /> with the style.
        /// </returns>
        public static Paragraph AppendNegativeVisualStyle(this Cell cell, StyleModel style)
        {
            SentinelHelper.ArgumentNull(cell);
            SentinelHelper.ArgumentNull(style);

            var color = Color.Transparent;
            var paragraph = cell.AppendCommonVisualStyle(style);

            var dataType = style.Content.DataType.Type;
            switch (dataType)
            {
                case KnownDataType.Numeric:
                case KnownDataType.Currency:
                    var numericType = (NumericDataTypeModel)style.Content.DataType;
                    color = numericType.Negative.GetColor();
                    break;
            }

            paragraph.Color(color);
            return paragraph;
        }
        #endregion

        #region [public] {static} (Paragraph) AppendVisualStyle(this Cell, StyleModel): Appends the visual style to this paragraph
        /// <summary>
        /// Appends the visual style to this paragraph.
        /// </summary>
        /// <param name="cell">The cell.</param>
        /// <param name="style">The style.</param>
        /// <returns>
        /// A <see cref="T:Novacode.Paragraph" /> with the style.
        /// </returns>
        public static Paragraph AppendVisualStyle(this Cell cell, StyleModel style)
        {
            SentinelHelper.ArgumentNull(cell);
            SentinelHelper.ArgumentNull(style);

            var paragraph = cell.AppendCommonVisualStyle(style);
            paragraph.Color(style.Font.GetColor());

            return paragraph;
        }
        #endregion

        #region [public] {static} (void) ClearEmptyParagraphs(this Row): Clear empty paragraphs for all cells on the row
        /// <summary>
        /// Clear empty paragraphs for all cells on the row.
        /// </summary>
        /// <param name="row">Row to clean.</param>
        public static void ClearEmptyParagraphs(this Row row)
        {
            SentinelHelper.ArgumentNull(row);

            var cells = row.Cells;
            foreach (var cell in cells)
            {
                var paragraphs = cell.Paragraphs;
                var emptyParagraphs = paragraphs.Where(paragraph => string.IsNullOrEmpty(paragraph.Text));
                foreach (var paragraph in emptyParagraphs)
                {
                    paragraph.Remove(false);
                }
            }
        }
        #endregion

        #region [public] {static} (Cell) GetRangeFromModel(this Table, int, ColumnHeaderModel): Returns a new range which represents the column header
        /// <summary>
        /// Returns a new range which represents the column header.
        /// </summary>
        /// <param name="table">The table.</param>
        /// <param name="row">The current row.</param>
        /// <param name="column">The column header definition.</param>
        /// <param name="offset">The offset.</param>
        /// <returns>
        /// Returns a new <see cref="T:Novacode.Cell" /> which contains de column header representation.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">The value specified is <c>null</c>.</exception>
        public static Cell GetRangeFromModel(this Table table, int row, ColumnHeaderModel column, int offset)
        {
            SentinelHelper.ArgumentNull(table);
            SentinelHelper.ArgumentNull(column);

            var fields = column.Owner.Parent.Fields;
            var fromField = fields[column.From];
            var toField = fields[column.To];

            var from = fields.IndexOf(fromField);
            var to = fields.IndexOf(toField);

            from = from - offset;
            to = to - offset;
                                
            var currentRow = table.Rows[row];
            currentRow.MergeCells(from, to);
            
            return table.Rows[row].Cells[from];            
        }
        #endregion

        #region [public] {static} (Paragraph) SetHorizontalAlignmentFrom(this Paragraph, LocationModel): Sets horizontal alignment of logo
        /// <summary>
        /// Sets horizontal alignment of logo.
        /// </summary>
        /// <param name="paragraph">The paragraph.</param>
        /// <param name="location">The logo location.</param>
        /// <returns>
        /// A <see cref="T:Novacode.Paragraph" /> with model alignment.
        /// </returns>
        public static Paragraph SetHorizontalAlignmentFrom(this Paragraph paragraph, LocationModel location)
        {
            SentinelHelper.ArgumentNull(paragraph);
            SentinelHelper.ArgumentNull(location);

            paragraph.Alignment = ((AlignmentModel)location.Mode).Horizontal.ToDocxHorizontalAlignment();

            return paragraph;
        }
        #endregion

        #region [public] {static} (Table) SetHorizontalLocationFrom(this Table, LocationModel): Sets initial horizontal location of table
        /// <summary>
        /// Sets initial horizontal location of <see cref="T:Novacode.Table" />.
        /// </summary>
        /// <param name="table">Table which receives new location.</param>
        /// <param name="location">Position to apply.</param>
        /// <returns>
        /// A <see cref="T:Novacode.Table" /> object which contains specified location.
        /// </returns>
        /// <remarks>
        /// If value of <see cref="P:iTin.Export.Model.LocationModel.Mode"/> is <see cref="iTin.Export.Model.KnownElementLocation.ByCoordenates"/>
        /// uses the default configuration, the horizontal alignment is set to center and vertical alignment set to top.
        /// </remarks>
        public static Table SetHorizontalLocationFrom(this Table table, LocationModel location)
        {
            var locationType = location.LocationType;
            if (locationType.Equals(KnownElementLocation.ByCoordenates))
            {
                return table;
            }

            table.Alignment = ((AlignmentModel)location.Mode).Horizontal.ToDocxHorizontalAlignment();

            return table;
        }
        #endregion

        #region [public] {static} (DocX) SetVerticalLocationFrom(this DocX, LocationModel): Sets initial vertical location of a table
        /// <summary>
        /// Sets initial vertical location of a <see cref="T:Novacode.Table" />.
        /// </summary>
        /// <param name="document">Document which receives new locationlocation.</param>
        /// <param name="location">Location to apply.</param>
        /// <returns>
        /// A <see cref="T:Novacode.DocX" /> object which contains specified location.
        /// </returns>
        /// <remarks>
        /// If value of <see cref="P:iTin.Export.Model.LocationModel.Mode"/> is <see cref="iTin.Export.Model.KnownElementLocation.ByCoordenates"/>
        /// uses the default configuration, the horizontal alignment is set to center and vertical alignment set to top.
        /// </remarks>
        public static DocX SetVerticalLocationFrom(this DocX document, LocationModel location)
        {
            var locationType = location.LocationType;
            if (locationType.Equals(KnownElementLocation.ByCoordenates))
            {
                return document;
            }

            var skipLines = ((AlignmentModel)location.Mode).SkipLines;
            for (var r = 1; r <= skipLines; r++)
            {
                document.InsertParagraph(string.Empty, false);
            }

            return document;
        }
        #endregion

        #endregion

        #region private static methods

        #region [private] {static} (Paragraph) AppendCommonVisualStyle(this Cell, StyleModel): Appends the common visual style to this cell
        /// <summary>
        /// Appends the common visual style to this cell.
        /// </summary>
        /// <param name="cell">The cell.</param>
        /// <param name="style">The style.</param>
        /// <returns>
        /// A <see cref="T:Novacode.Paragraph" /> with the common style.
        /// </returns>
        private static Paragraph AppendCommonVisualStyle(this Cell cell, StyleModel style)
        {
            cell.FillColor = style.Content.GetColor();
            cell.VerticalAlignment = style.Content.Alignment.Vertical.ToDocxVerticalAlignment();

            foreach (var borderModel in style.Borders)
            {
                var border = new Border
                {
                    Space = 0,
                    Color = borderModel.GetColor(),
                    Size = borderModel.Weight.ToDocxBorderSize(),
                    Tcbs = borderModel.LineStyle.ToDocxLineStyle()
                };

                switch (borderModel.Position)
                {
                    case KnownBorderPosition.Left:
                        cell.SetBorder(TableCellBorderType.Left, border);
                        break;

                    case KnownBorderPosition.Top:
                        cell.SetBorder(TableCellBorderType.Top, border);
                        break;

                    case KnownBorderPosition.Right:
                        cell.SetBorder(TableCellBorderType.Right, border);
                        break;

                    case KnownBorderPosition.Bottom:
                        cell.SetBorder(TableCellBorderType.Bottom, border);
                        break;

                    case KnownBorderPosition.DiagonalLeft:
                        cell.SetBorder(TableCellBorderType.TopRightToBottomLeft, border);
                        break;

                    case KnownBorderPosition.DiagonalRight:
                        cell.SetBorder(TableCellBorderType.TopLeftToBottomRight, border);
                        break;
                }
            }
              
            var paragraph = cell.Paragraphs.First();
            paragraph.Alignment = style.Content.Alignment.Horizontal.ToDocxHorizontalAlignment();
            paragraph.Font(style.Font.ToFont().FontFamily);
            paragraph.FontSize(style.Font.Size); // int.Parse(style.Font.Size, CultureInfo.InvariantCulture));

            if (style.Font.Bold == YesNo.Yes)
            {
                paragraph.Bold();
            }

            if (style.Font.Italic == YesNo.Yes)
            {
                paragraph.Italic();
            }

            if (style.Font.Underline == YesNo.Yes)
            {
                paragraph.UnderlineStyle(UnderlineStyle.singleLine);
            }

            return paragraph;
        }
        #endregion

        #region [private] {static} (BorderSize) ToDocxBorderSize(this KnownWidthLineStyle): Converter for KnownBorderLineStyle enumeration type to BorderSize
        /// <summary>
        /// Converter for <see cref="T:iTin.Export.Model.KnownWidthLineStyle"/> enumeration type to <see cref="T:Novacode.BorderSize"/>.
        /// </summary>
        /// <param name="width">The line width.</param>
        /// <returns>
        /// A <see cref="T:Novacode.BorderSize" /> value.
        /// </returns>
        private static BorderSize ToDocxBorderSize(this KnownWidthLineStyle width)
        {
            var size = BorderSize.two;
            switch (width)
            {
                case KnownWidthLineStyle.Hairline:
                    size = BorderSize.two;
                    break;

                case KnownWidthLineStyle.Thin:
                    size = BorderSize.two;
                    break;

                case KnownWidthLineStyle.Medium:
                    size = BorderSize.three;
                    break;

                case KnownWidthLineStyle.Thick:
                    size = BorderSize.four;
                    break;
            }

            return size;
        }
        #endregion

        #region [private] {static} (BorderStyle) ToDocxLineStyle(this LineStyle): Converter for KnownBorderLineStyle enumeration type to BorderStyle
        /// <summary>
        /// Converter for <see cref="T:iTin.Export.Model.KnownBorderLineStyle"/> enumeration type to <see cref="T:Novacode.BorderStyle"/>.
        /// </summary>
        /// <param name="lineStyle">The line style.</param>
        /// <returns>
        /// A <see cref="T:Novacode.BorderStyle" /> value.
        /// </returns>
        private static BorderStyle ToDocxLineStyle(this KnownBorderLineStyle lineStyle)
        {
            var style = BorderStyle.Tcbs_single;
            switch (lineStyle)
            {
                case KnownBorderLineStyle.Dash:
                    style = BorderStyle.Tcbs_dashed;
                    break;

                case KnownBorderLineStyle.DashDot:
                    style = BorderStyle.Tcbs_dotDash;
                    break;

                case KnownBorderLineStyle.DashDotDot:
                    style = BorderStyle.Tcbs_dotDotDash;
                    break;

                case KnownBorderLineStyle.Dot:
                    style = BorderStyle.Tcbs_dotted;
                    break;

                case KnownBorderLineStyle.None:
                    style = BorderStyle.Tcbs_none;
                    break;
            }


            return style;
        }
        #endregion

        #region [private] {static} (Alignment) ToDocxHorizontalAlignment(this KnownHorizontalAlignment): Converter for KnownHorizontalAlignment enumeration type to Novacode.Alignment
        /// <summary>
        /// Converter for <see cref="T:iTin.Export.Model.KnownHorizontalAlignment"/> enumeration type to <see cref="T:Novacode.Alignment"/>.
        /// </summary>
        /// <param name="alignment">The alignment.</param>
        /// <returns>
        /// A <see cref="T:Novacode.Alignment" /> value.
        /// </returns>
        private static Alignment ToDocxHorizontalAlignment(this KnownHorizontalAlignment alignment)
        {
            var align = Alignment.left;
            switch (alignment)
            {
                case KnownHorizontalAlignment.Center:
                    align = Alignment.center;
                    break;

                case KnownHorizontalAlignment.Right:
                    align = Alignment.right;
                    break;
            }

            return align;
        }
        #endregion

        #region [private] {static} (VerticalAlignment) ToDocxVerticalAlignment(this KnownVerticalAlignment): Converter for VerticalAlignment enumeration type to VerticalAlignment
        /// <summary>
        /// Converter for <see cref="T:iTin.Export.Model.KnownVerticalAlignment"/> enumeration type to <see cref="T:Novacode.VerticalAlignment"/>.
        /// </summary>
        /// <param name="alignment">The alignment.</param>
        /// <returns>
        /// A <see cref="T:Novacode.VerticalAlignment" /> value.
        /// </returns>
        private static VerticalAlignment ToDocxVerticalAlignment(this KnownVerticalAlignment alignment)
        {
            var align = VerticalAlignment.Center;
            switch (alignment)
            {
                case KnownVerticalAlignment.Bottom:
                    align = VerticalAlignment.Bottom;
                    break;

                case KnownVerticalAlignment.Top:
                    align = VerticalAlignment.Top;
                    break;
            }

            return align;
        }
        #endregion

        #endregion
    }
}
