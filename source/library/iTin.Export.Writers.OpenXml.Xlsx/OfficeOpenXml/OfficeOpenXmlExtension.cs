
namespace OfficeOpenXml
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Globalization;
    using System.Text;

    using iTin.Export.ComponentModel;
    using iTin.Export.Helpers;
    using iTin.Export.Model;

    using Style;

    /// <summary>
    /// Static class than contains common extension methods for objects of the namespace <see cref="N:OfficeOpenXml"/>.
    /// </summary>
    static class OfficeOpenXmlExtension
    {
        #region [public] {static} (void) AddErrorComment(this OfficeOpenXml.ExcelRangeBase, FieldValueInformation): Writes a error comment for specified cell
        /// <summary>
        /// Writes a error comment for specified cell.
        /// </summary>
        /// <param name="cell">Cell to try apply specified comment.</param>
        /// <param name="value">Reference to value information.</param>
        public static void AddErrorComment(this ExcelRangeBase cell, FieldValueInformation value)
        {
            SentinelHelper.ArgumentNull(cell);
            SentinelHelper.ArgumentNull(value);

            var comment = value.Comment;
            if (comment == null)
            {
                return;
            }

            var showComment = comment.Show == YesNo.Yes;
            if (!showComment)
            {
                return;
            }

            var font = comment.Font;
            var text = string.Format(CultureInfo.InvariantCulture, "{0} {1}", comment.Text, value.Value);
            var autorComment = string.Format(CultureInfo.InvariantCulture, "{0}\\{1}", Environment.MachineName, Environment.UserName);

            var cellComment = cell.AddComment(text, autorComment);
            cellComment.Font.Size = font.Size;
            cellComment.Font.FontName = font.Name;
            cellComment.Font.Color = font.GetColor();
            cellComment.Font.Bold = font.Bold == YesNo.Yes;
            cellComment.Font.Italic = font.Italic == YesNo.Yes;
            cellComment.Font.UnderLine = font.Underline == YesNo.Yes;
        }
        #endregion

        #region [public] {static} (void) AppendLogo(this OfficeOpenXml.ExcelWorksheet, LogoModel): Appends the logo to specified worksheet
        /// <summary>
        /// Appends the logo to specified worksheet.
        /// </summary>
        /// <param name="worksheet">The worksheet.</param>
        /// <param name="model">Logo model.</param>
        public static void AppendLogo(this ExcelWorksheet worksheet, LogoModel model)
        {
            SentinelHelper.ArgumentNull(model);
            SentinelHelper.ArgumentNull(worksheet);

            if (model.IsDefault)
            {
                return;
            }

            if (model.Show == YesNo.No)
            {
                return;
            }

            var logoPosition = model.Location;
            var positionType = logoPosition.LocationType;
            if (positionType == KnownElementLocation.ByAlignment)
            {
                return;
            }

            Image image;
            var found = model.Image.TryGetImage(out image);
            if (!found)
            {
                return;
            }

            var logoWidth = model.LogoSize.Width == -1
                                    ? image.Width
                                    : model.LogoSize.Width;

            var logoHeight = model.LogoSize.Height == -1
                                    ? image.Height
                                    : model.LogoSize.Height;

            var logoNameBuilder = new StringBuilder();
            var coordenates = (CoordenatesModel)logoPosition.Mode;

            logoNameBuilder.Append("logo");
            logoNameBuilder.Append(coordenates.TableCoordenates.X);
            logoNameBuilder.Append(coordenates.TableCoordenates.Y);

            worksheet.Row(coordenates.TableCoordenates.Y).Height = (image.Height - 1) * 0.75d;

            var logo = worksheet.Drawings.AddPicture(logoNameBuilder.ToString(), image);
            logo.Locked = true;
            logo.SetSize(logoWidth, logoHeight);
            logo.SetPosition(coordenates.TableCoordenates.Y - 1, 0, coordenates.TableCoordenates.X - 1, 0);
        }
        #endregion

        #region [public] {static} (void) AutoFitGroupColumns(this OfficeOpenXml.ExcelWorksheet, IDictionary<BaseDataFieldModel, int>, IWriter): Automatics the fit group columns
        /// <summary>
        /// Automatics the fit group columns.
        /// </summary>
        /// <param name="worksheet">The worksheet.</param>
        /// <param name="dictionary">Group fields data.</param>
        /// <param name="writer">Current writer.</param>
        [SuppressMessage("Microsoft.Globalization", "CA1303:No pasar cadenas literal como parámetros localizados", MessageId = "System.Drawing.Graphics.MeasureString(System.String,System.Drawing.Font)")]
        public static void AutoFitGroupColumns(this ExcelWorksheet worksheet, IDictionary<BaseDataFieldModel, int> dictionary, IWriter writer)
        {
            SentinelHelper.ArgumentNull(worksheet);
            SentinelHelper.ArgumentNull(dictionary);
            SentinelHelper.ArgumentNull(writer);

            foreach (var entry in dictionary)
            {
                if (entry.Key.FieldType == KnownFieldType.Group)
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
                                using (var fontInPoints = new Font(font.Name, font.Size, font.Style, GraphicsUnit.Point))
                                {
                                    var singleCharWidth = graphics.MeasureString("0", fontInPoints).Width;
                                    var doubleCharWidth = graphics.MeasureString("00", fontInPoints).Width;

                                    var charWidth = doubleCharWidth - singleCharWidth;
                                    var valueWidth = charWidth * (maxColumnLenght + 1);
                                    var excelwidth = (valueWidth - 12) / 7;

                                    worksheet.Column(index + 1).Width = excelwidth;
                                }
                            }
                        }
                    }
                }
            }
        }
        #endregion

        #region [public] {static} (void) CreateFromModel(OfficeOpenXml.ExcelStyles, StylesModel): Creates list of styles
        /// <summary>
        /// Creates list of styles.
        /// </summary>
        /// <param name="styles">The styles.</param>
        /// <param name="model">The model.</param>
        public static void CreateFromModel(this ExcelStyles styles, StylesModel model)
        {
            SentinelHelper.ArgumentNull(styles);
            SentinelHelper.ArgumentNull(model);

            var defaultStyle = StyleModel.Default;

            var xlsxStyle = styles.CreateNamedStyle(defaultStyle.Name);
            xlsxStyle.Style.FormatFromModel(defaultStyle);

            var modelStyles = model;
            foreach (var style in modelStyles)
            {
                xlsxStyle = styles.CreateNamedStyle(style.Name);
                xlsxStyle.Style.FormatFromModel(style);

                var alternateStyleName = $"{style.Name}_Alternate";
                xlsxStyle = styles.CreateNamedStyle(alternateStyleName);
                xlsxStyle.Style.FormatFromModel(style, true);
            }
        }
        #endregion

        #region [public] {static} (float) GetRangeFromModel(this ExcelWorksheet, int, ColumnHeaderModel): Returns a new range which represents the column header
        /// <summary>
        /// Returns a new range which represents the column header.
        /// </summary>
        /// <param name="worksheet">The worksheet.</param>
        /// <param name="row">The current row.</param>
        /// <param name="column">The column header definition.</param>
        /// <returns>
        /// Returns a new <see cref="T:OfficeOpenXml.ExcelRange" /> which contains de column header representation.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">The value specified is <c>null</c>.</exception>
        public static ExcelRange GetRangeFromModel(this ExcelWorksheet worksheet, int row, ColumnHeaderModel column)
        {
            SentinelHelper.ArgumentNull(worksheet);
            SentinelHelper.ArgumentNull(column);

            var fields = column.Owner.Parent.Fields;
            var fromField = fields[column.From];
            var toField = fields[column.To];

            var from = fields.IndexOf(fromField) + 1;
            var to = fields.IndexOf(toField) + 1;

            var range = ExcelCellBase.GetAddress(row, from, row, to);
            var cell = worksheet.Cells[range];

            return cell;
        }
        #endregion

        #region [public] {static} (double) PixelsToColumnWidth(this OfficeOpenXml.ExcelWorksheet, int): Returns pixels convert to excel column width
        /// <summary>
        ///  Returns pixels convert to excel column width.
        /// </summary>
        /// <param name="worksheet">The worksheet.</param>
        /// <param name="pixels">The pixels.</param>
        /// <returns>
        /// A <see cref="T:System.Double" /> which contains specified pixels convert into excel column width.
        /// </returns>
        public static double PixelsToColumnWidth(this ExcelWorksheet worksheet, int pixels)
        {
            // The correct method to convert pixel to width is:
            // 1. use the formula =Truncate(({pixels}-5)/{Maximum Digit Width} * 100+0.5)/100 
            //    to convert pixel to character number.
            // 2. use the formula width = Truncate([{Number of Characters} * {Maximum Digit Width} + {5 pixel padding}]/{Maximum Digit Width}*256)/256 
            //    to convert the character number to width.

            // Get the maximum digit width
            decimal mdw = worksheet.Workbook.MaxFontWidth;

            // Convert pixel to character number
            var numChars = decimal.Truncate(decimal.Add((pixels - 5) / mdw * 100, (decimal)0.5)) / 100;

            // Convert the character number to width
            var excelColumnWidth = decimal.Truncate((decimal.Add(numChars * mdw, 5)) / mdw * 256) / 256;

            return Convert.ToDouble(excelColumnWidth);
        }
        #endregion

        #region [public] {static} (ExcelPrinterSettings) SetMarginsFromModel(this OfficeOpenXml.ExcelPrinterSettings, MarginsModel): Sets the margins of document from model
        /// <summary>
        /// Sets the margins of document from model.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="margins">The margins.</param>
        /// <returns>
        /// An <see cref="T:OfficeOpenXml.ExcelPrinterSettings"/> reference which contains the margins values.
        /// </returns>
        public static ExcelPrinterSettings SetMarginsFromModel(this ExcelPrinterSettings settings, MarginsModel margins)
        {
            SentinelHelper.ArgumentNull(settings);
            SentinelHelper.ArgumentNull(margins);

            var units = margins.Units;
            if (units == KnownUnit.Millimeters)
            {
                settings.TopMargin = (decimal)(margins.Top / 10f / 2.54f);
                settings.LeftMargin = (decimal)(margins.Left / 10f / 2.54f);
                settings.RightMargin = (decimal)(margins.Right / 10f / 2.54f);
                settings.BottomMargin = (decimal)(margins.Bottom / 10f / 2.54f);
            }
            else
            {
                settings.TopMargin = (decimal)margins.Top;
                settings.LeftMargin = (decimal)margins.Left;
                settings.RightMargin = (decimal)margins.Right;
                settings.BottomMargin = (decimal)margins.Bottom;
            }

            return settings;
        }
        #endregion
    }
}
