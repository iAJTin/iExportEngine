
namespace OfficeOpenXml.Style
{
    using iTin.Export.Helper;
    using iTin.Export.Model;
    using iTin.Export.Writers.OpenXml.Office;

    /// <summary>
    /// Static class than contains common extension methods for objects of the namespace <see cref="N:OfficeOpenXml.Style"/>.
    /// </summary>
    static class StyleExtensions
    {
        #region public static methods

        #region [public] {static} (void) CreateFromModel(this OfficeOpenXml.Style.Border, BorderModel): Fills a Border object with model data
        /// <summary>
        /// Fills a <see cref="OfficeOpenXml.Style.Border" /> object with model data.
        /// </summary>
        /// <param name="border"><see cref="OfficeOpenXml.Style.Border" /> object.</param>
        /// <param name="model">Border model definition.</param>
        private static void CreateFromModel(this Border border, BorderModel model)
        {
            if (model == null)
            {
                return;                               
            }

            switch (model.Position)
            {
                case KnownBorderPosition.Left:
                    border.Left.Style = model.ToEppBorderStyle();
                    border.Left.Color.SetColor(model.GetColor());
                    break;

                case KnownBorderPosition.Top:
                    border.Top.Style = model.ToEppBorderStyle();
                    border.Top.Color.SetColor(model.GetColor());
                    break;

                case KnownBorderPosition.Right:
                    border.Right.Style = model.ToEppBorderStyle();
                    border.Right.Color.SetColor(model.GetColor());
                    break;

                case KnownBorderPosition.Bottom:
                    border.Bottom.Style = model.ToEppBorderStyle();
                    border.Bottom.Color.SetColor(model.GetColor());
                    break;

                case KnownBorderPosition.DiagonalLeft:
                    border.DiagonalDown = true;
                    border.Diagonal.Style = model.ToEppBorderStyle();
                    border.Diagonal.Color.SetColor(model.GetColor());
                    break;

                case KnownBorderPosition.DiagonalRight:
                    border.DiagonalUp = true;
                    border.Diagonal.Style = model.ToEppBorderStyle();
                    border.Diagonal.Color.SetColor(model.GetColor());
                    break;
            }
        }
        #endregion

        #region [public] {static} (void) FormatFromModel(this OfficeOpenXml.Style.ExcelStyle, StyleModel): Fills a ExcelStyle object with model data
        /// <summary>
        /// Fills a <see cref="OfficeOpenXml.Style.ExcelStyle" /> object with model data.
        /// </summary>
        /// <param name="style"><see cref="OfficeOpenXml.Style.ExcelStyle" /> object.</param>
        /// <param name="model">Style model definition.</param>
        /// <exception cref="System.ArgumentNullException">If <paramref name="style" /> is <c>null</c>.</exception>
        /// <exception cref="System.ArgumentNullException">If <paramref name="model" /> is <c>null</c>.</exception>
        public static void FormatFromModel(this ExcelStyle style, StyleModel model)
        {
            SentinelHelper.ArgumentNull(style);
            SentinelHelper.ArgumentNull(model);

            var hasInheritStyle = !string.IsNullOrEmpty(model.Inherits);
            if (hasInheritStyle)
            {
                var inheritStyle = model.TryGetInheritStyle();
                model.Combine(inheritStyle);
            }

            style.Font.SetFromFont(model.Font.ToFont());
            style.Font.Color.SetColor(model.Font.GetColor());

            var content = model.Content;
            style.VerticalAlignment = content.Alignment.Vertical.ToEppVerticalAlignment();
            style.HorizontalAlignment = content.Alignment.Horizontal.ToEppHorizontalAlignment();

            style.Fill.PatternType = content.Pattern.PatternType.ToEppPatternFillStyle();
            if (style.Fill.PatternType != ExcelFillStyle.None)
            {
                style.Fill.BackgroundColor.SetColor(content.GetColor());
                style.Fill.PatternColor.SetColor(content.Pattern.GetColor());
            }

            style.Numberformat.Format = content.DataType.GetDataFormat().ToEppDataFormat(content.DataType);

            foreach (var border in model.Borders)
            {
                style.Border.CreateFromModel(border);
            }
        }
        #endregion

        #endregion

        #region private static methods

        #region [private] {static} (OfficeOpenXml.Style.ExcelBorderStyle) ToEppBorderStyle(this BorderModel): Converter from border model to ExcelBorderStyle
        /// <summary>
        /// Converter for <see cref="iTin.Export.Model.BorderModel" /> enumeration type to <see cref="OfficeOpenXml.Style.ExcelBorderStyle" />.
        /// </summary>
        /// <param name="model">Border model definition.</param>
        /// <returns>
        /// A <see cref="OfficeOpenXml.Style.ExcelBorderStyle" /> value.
        /// </returns>
        private static ExcelBorderStyle ToEppBorderStyle(this BorderModel model)
        {
            ExcelBorderStyle excelStyle = ExcelBorderStyle.Thin;

            var style = model.LineStyle;
            var weight = model.Weight;
            switch (weight)
            {
                case KnownWidthLineStyle.Hairline:
                    switch (style)
                    {
                        case KnownBorderLineStyle.Continuous:
                            excelStyle = ExcelBorderStyle.Hair;
                            break;

                        case KnownBorderLineStyle.None:
                            excelStyle = ExcelBorderStyle.None;
                            break;
                    }

                    break;

                case KnownWidthLineStyle.Thick:
                case KnownWidthLineStyle.Medium:
                    switch (style)
                    {
                        case KnownBorderLineStyle.Dash:
                            excelStyle = ExcelBorderStyle.MediumDashed;
                            break;

                        case KnownBorderLineStyle.DashDot:
                            excelStyle = ExcelBorderStyle.MediumDashDot;
                            break;

                        case KnownBorderLineStyle.DashDotDot:
                            excelStyle = ExcelBorderStyle.MediumDashDotDot;
                            break;

                        case KnownBorderLineStyle.Dot:
                            excelStyle = ExcelBorderStyle.Medium;
                            break;

                        case KnownBorderLineStyle.None:
                            excelStyle = ExcelBorderStyle.None;
                            break;
                    }

                    break;

                case KnownWidthLineStyle.Thin:
                    switch (style)
                    {                
                        case KnownBorderLineStyle.Dash:
                            excelStyle = ExcelBorderStyle.Dashed;
                            break;

                        case KnownBorderLineStyle.DashDot:
                            excelStyle = ExcelBorderStyle.DashDot;
                            break;

                        case KnownBorderLineStyle.DashDotDot:
                            excelStyle = ExcelBorderStyle.DashDotDot;
                            break;

                        case KnownBorderLineStyle.Dot:
                            excelStyle = ExcelBorderStyle.Dotted;
                            break;

                        case KnownBorderLineStyle.None:
                            excelStyle = ExcelBorderStyle.None;
                            break;

                        default:
                            excelStyle = ExcelBorderStyle.Thin;
                            break;
                    }

                    break;
            }

            return excelStyle;
        }
        #endregion

        #region [private] {static} (OfficeOpenXml.Style.ExcelHorizontalAlignment) ToEppHorizontalAlignment(this KnownHorizontalAlignment): Converter for KnownHorizontalAlignment enumeration type to ExcelHorizontalAlignment
        /// <summary>
        /// Converter for <see cref="KnownHorizontalAlignment" /> enumeration type to <see cref="OfficeOpenXml.Style.ExcelHorizontalAlignment" />.
        /// </summary>
        /// <param name="alignment">The alignment.</param>
        /// <returns>
        /// A <see cref="OfficeOpenXml.Style.ExcelHorizontalAlignment" /> value.
        /// </returns>
        private static ExcelHorizontalAlignment ToEppHorizontalAlignment(this KnownHorizontalAlignment alignment)
        {
            switch (alignment)
            {
                case KnownHorizontalAlignment.Center:
                    return ExcelHorizontalAlignment.Center;

                case KnownHorizontalAlignment.Right:
                    return ExcelHorizontalAlignment.Right;

                default:
                    return ExcelHorizontalAlignment.Left;
            }
        }
        #endregion

        #region [private] {static} (OfficeOpenXml.Style.ExcelFillStyle) ToEppPatternFillStyle(this KnownPatternType): Converter for KnownPatternType enumeration type to ExcelFillStyle
        /// <summary>
        /// Converter for <see cref="KnownPatternType" /> enumeration type to <see cref="OfficeOpenXml.Style.ExcelFillStyle" />.
        /// </summary>
        /// <param name="patternType">The pattern style.</param>
        /// <returns>
        /// A <see cref="OfficeOpenXml.Style.ExcelFillStyle" /> value.
        /// </returns>
        private static ExcelFillStyle ToEppPatternFillStyle(this KnownPatternType patternType)
        {
            switch (patternType)
            {
                case KnownPatternType.Solid:
                    return ExcelFillStyle.Solid;

                case KnownPatternType.Gray75:
                    return ExcelFillStyle.DarkGray;

                case KnownPatternType.Gray50:
                    return ExcelFillStyle.MediumGray;

                case KnownPatternType.Gray25:
                    return ExcelFillStyle.LightGray;

                case KnownPatternType.Gray125:
                    return ExcelFillStyle.Gray125;

                case KnownPatternType.Gray625:
                    return ExcelFillStyle.Gray0625;

                case KnownPatternType.HorzStripe:
                    return ExcelFillStyle.DarkHorizontal;

                case KnownPatternType.VertStripe:
                    return ExcelFillStyle.DarkVertical;

                case KnownPatternType.ReverseDiagStripe:
                    return ExcelFillStyle.DarkDown;

                case KnownPatternType.DiagStripe:
                    return ExcelFillStyle.DarkUp;

                case KnownPatternType.DiagCross:
                    return ExcelFillStyle.DarkGrid;

                case KnownPatternType.ThickDiagCross:
                    return ExcelFillStyle.DarkTrellis;

                case KnownPatternType.ThinDiagCross:
                    return ExcelFillStyle.LightTrellis;

                case KnownPatternType.ThinDiagStripe:
                    return ExcelFillStyle.LightUp;

                case KnownPatternType.ThinHorzCross:
                    return ExcelFillStyle.LightGrid;

                case KnownPatternType.ThinHorzStripe:
                    return ExcelFillStyle.LightHorizontal;

                case KnownPatternType.ThinReverseDiagStripe:
                    return ExcelFillStyle.LightDown;

                case KnownPatternType.ThinVertStripe:
                    return ExcelFillStyle.LightVertical;

                default:
                    return ExcelFillStyle.None;
            }
        }
        #endregion

        #region [private] {static} (OfficeOpenXml.Style.ExcelVerticalAlignment) ToEppVerticalAlignment(this KnownVerticalAlignment): Converter for KnownVerticalAlignment enumeration type to ExcelVerticalAlignment
        /// <summary>
        /// Converter for <see cref="KnownVerticalAlignment" /> enumeration type to <see cref="OfficeOpenXml.Style.ExcelVerticalAlignment" />.
        /// </summary>
        /// <param name="alignment">The alignment.</param>
        /// <returns>
        /// A <see cref="OfficeOpenXml.Style.ExcelVerticalAlignment" /> value.
        /// </returns>
        private static ExcelVerticalAlignment ToEppVerticalAlignment(this KnownVerticalAlignment alignment)
        {
            switch (alignment)
            {
                case KnownVerticalAlignment.Bottom:
                    return ExcelVerticalAlignment.Bottom;

                case KnownVerticalAlignment.Top:
                    return ExcelVerticalAlignment.Top;

                default:
                    return ExcelVerticalAlignment.Center;
            }
        }
        #endregion

        #endregion
    }
}
