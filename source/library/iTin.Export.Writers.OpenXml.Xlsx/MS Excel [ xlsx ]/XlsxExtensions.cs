using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text;

using iTin.Export.Helper;
using iTin.Export.Model;

using OfficeOpenXml;
using OfficeOpenXml.Drawing;
using OfficeOpenXml.Drawing.Chart;

namespace iTin.Export.Writers.OpenXml.Office
{
    /// <summary>
    /// Contains common extensions for data model objects.
    /// </summary>
    static class XlsxExtensions
    {
        #region [public] {static} (float) ToAngle(this KnownAxisOrientation): Converter for KnownAxisOrientation enumeration type to angle degree.
        /// <summary>
        /// Converter for <see cref="T:iTin.Export.Model.KnownAxisOrientation"/> enumeration type to angle degree.
        /// </summary>
        /// <param name="orientation">Orientation style from model.</param>
        /// <returns>
        /// Orientation as angle in degrees.
        /// </returns>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>
        public static float ToAngle(this KnownAxisOrientation orientation)
        {
            SentinelHelper.IsEnumValid(orientation);

            switch (orientation)
            {
                case KnownAxisOrientation.Upward:
                    return 270;

                case KnownAxisOrientation.Horizontal:
                    return 0;

                case KnownAxisOrientation.Vertical:
                    return 0;

                default:
                    return 90;
            }
        }
        #endregion

        #region [public] {static} (float) ToAngle(this KnownLabelOrientation): Converter for KnownLabelOrientation enumeration type to angle degree.
        /// <summary>
        /// Converter for <see cref="T:iTin.Export.Model.KnownLabelOrientation"/> enumeration type to angle degree.
        /// </summary>
        /// <param name="orientation">Orientation style from model.</param>
        /// <returns>
        /// Orientation as angle in degrees.
        /// </returns>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>
        public static float ToAngle(this KnownLabelOrientation orientation)
        {
            SentinelHelper.IsEnumValid(orientation);

            switch (orientation)
            {
                case KnownLabelOrientation.Upward:
                    return -5400000;

                case KnownLabelOrientation.Downward:
                    return 5400000;

                case KnownLabelOrientation.Vertical:
                    return 0;

                case KnownLabelOrientation.Horizontal:
                    return 0;

                default:
                    return 0;
            }
        }
        #endregion

        #region [public] {static} (int) ToEppBorderWidth(this KnownWidthLineStyle): Converter for KnownWidthLineStyle enumeration type to integer value.
        /// <summary>
        /// Converter for <see cref="T:iTin.Export.Model.KnownWidthLineStyle"/> enumeration type to integer value.
        /// </summary>
        /// <param name="borderWeight">Width line style from model.</param>
        /// <returns>
        /// An integer value than represents border width.
        /// </returns>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>
        public static int ToEppBorderWidth(this KnownWidthLineStyle borderWeight)
        {
            SentinelHelper.IsEnumValid(borderWeight);

            switch (borderWeight)
            {
                case KnownWidthLineStyle.Medium:
                    return 2;

                case KnownWidthLineStyle.Thick:
                    return 4;

                default:
                    return 1;
            }
        }
        #endregion

        #region [public] {static} (OfficeOpenXml.Drawing.Chart.eChartType) ToEppChartType(this KnownChartType): Converter for KnownChartType enumeration type to eChartType.
        /// <summary>
        /// Converter for <see cref="T:iTin.Export.Model.KnownChartType"/> enumeration type to <see cref="OfficeOpenXml.Drawing.Chart.eChartType"/>.
        /// </summary>
        /// <param name="chartType">Chart type.</param>
        /// <returns>
        /// A <see cref="T:OfficeOpenXml.Drawing.Chart.eChartType" /> value.
        /// </returns>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        public static eChartType ToEppChartType(this KnownChartType chartType)
        {
            SentinelHelper.IsEnumValid(chartType);

            switch (chartType)
            {
                case KnownChartType.XYScatter:
                    return eChartType.XYScatter;

                case KnownChartType.Radar:
                    return eChartType.Radar;

                case KnownChartType.Doughnut:
                    return eChartType.Doughnut;

                case KnownChartType.Pie3D:
                    return eChartType.Pie3D;

                case KnownChartType.Line3D:
                    return eChartType.Line3D;

                case KnownChartType.Column3D:
                    return eChartType.Column3D;

                case KnownChartType.Area3D:
                    return eChartType.Area3D;

                case KnownChartType.Area:
                    return eChartType.Area;

                case KnownChartType.Line:
                    return eChartType.Line;

                case KnownChartType.Pie:
                    return eChartType.Pie;

                case KnownChartType.Bubble:
                    return eChartType.Bubble;

                case KnownChartType.ColumnClustered:
                    return eChartType.ColumnClustered;

                case KnownChartType.ColumnStacked:
                    return eChartType.ColumnStacked;

                case KnownChartType.ColumnStacked100:
                    return eChartType.ColumnStacked100;

                case KnownChartType.ColumnClustered3D:
                    return eChartType.ColumnClustered3D;

                case KnownChartType.ColumnStacked3D:
                    return eChartType.ColumnStacked3D;

                case KnownChartType.ColumnStacked1003D:
                    return eChartType.ColumnStacked1003D;

                case KnownChartType.BarClustered:
                    return eChartType.BarClustered;

                case KnownChartType.BarStacked:
                    return eChartType.BarStacked;

                case KnownChartType.BarStacked100:
                    return eChartType.BarStacked100;

                case KnownChartType.BarClustered3D:
                    return eChartType.BarClustered3D;

                case KnownChartType.BarStacked3D:
                    return eChartType.BarStacked3D;

                case KnownChartType.BarStacked1003D:
                    return eChartType.BarStacked1003D;

                case KnownChartType.LineStacked:
                    return eChartType.LineStacked;

                case KnownChartType.LineStacked100:
                    return eChartType.LineStacked100;

                case KnownChartType.LineMarkers:
                    return eChartType.LineMarkers;

                case KnownChartType.LineMarkersStacked:
                    return eChartType.LineMarkersStacked;

                case KnownChartType.LineMarkersStacked100:
                    return eChartType.LineMarkersStacked100;

                case KnownChartType.PieOfPie:
                    return eChartType.PieOfPie;

                case KnownChartType.PieExploded:
                    return eChartType.PieExploded;

                case KnownChartType.PieExploded3D:
                    return eChartType.PieExploded3D;

                case KnownChartType.BarOfPie:
                    return eChartType.BarOfPie;

                case KnownChartType.XYScatterSmooth:
                    return eChartType.XYScatterSmooth;

                case KnownChartType.XYScatterSmoothNoMarkers:
                    return eChartType.XYScatterSmoothNoMarkers;

                case KnownChartType.XYScatterLines:
                    return eChartType.XYScatterSmoothNoMarkers;

                case KnownChartType.XYScatterLinesNoMarkers:
                    return eChartType.XYScatterSmoothNoMarkers;

                case KnownChartType.AreaStacked:
                    return eChartType.AreaStacked;

                case KnownChartType.AreaStacked100:
                    return eChartType.AreaStacked100;

                case KnownChartType.AreaStacked3D:
                    return eChartType.AreaStacked3D;

                case KnownChartType.AreaStacked1003D:
                    return eChartType.AreaStacked1003D;

                case KnownChartType.DoughnutExploded:
                    return eChartType.DoughnutExploded;

                case KnownChartType.RadarMarkers:
                    return eChartType.RadarMarkers;

                case KnownChartType.RadarFilled:
                    return eChartType.RadarFilled;

                case KnownChartType.Surface:
                    return eChartType.Surface;

                case KnownChartType.SurfaceWireframe:
                    return eChartType.SurfaceWireframe;

                case KnownChartType.SurfaceTopView:
                    return eChartType.SurfaceTopView;

                case KnownChartType.SurfaceTopViewWireframe:
                    return eChartType.SurfaceTopViewWireframe;

                case KnownChartType.Bubble3DEffect:
                    return eChartType.Bubble3DEffect;

                case KnownChartType.StockHLC:
                    return eChartType.StockHLC;

                case KnownChartType.StockOHLC:
                    return eChartType.StockOHLC;

                case KnownChartType.StockVHLC:
                    return eChartType.StockVHLC;

                case KnownChartType.StockVOHLC:
                    return eChartType.StockVOHLC;

                case KnownChartType.CylinderColClustered:
                    return eChartType.CylinderColClustered;

                case KnownChartType.CylinderColStacked:
                    return eChartType.CylinderColStacked;

                case KnownChartType.CylinderColStacked100:
                    return eChartType.CylinderColStacked100;

                case KnownChartType.CylinderBarClustered:
                    return eChartType.CylinderBarClustered;

                case KnownChartType.CylinderBarStacked:
                    return eChartType.CylinderBarStacked;

                case KnownChartType.CylinderBarStacked100:
                    return eChartType.CylinderBarStacked100;

                case KnownChartType.CylinderCol:
                    return eChartType.CylinderCol;

                case KnownChartType.ConeColClustered:
                    return eChartType.ConeColClustered;

                case KnownChartType.ConeColStacked:
                    return eChartType.ConeColStacked;

                case KnownChartType.ConeColStacked100:
                    return eChartType.ConeColStacked100;

                case KnownChartType.ConeBarClustered:
                    return eChartType.ConeBarClustered;

                case KnownChartType.ConeBarStacked:
                    return eChartType.ConeBarStacked;

                case KnownChartType.ConeBarStacked100:
                    return eChartType.ConeBarStacked100;

                case KnownChartType.ConeCol:
                    return eChartType.ConeCol;

                case KnownChartType.PyramidColClustered:
                    return eChartType.PyramidColClustered;

                case KnownChartType.PyramidColStacked:
                    return eChartType.PyramidColStacked;

                case KnownChartType.PyramidColStacked100:
                    return eChartType.PyramidColStacked100;

                case KnownChartType.PyramidBarClustered:
                    return eChartType.PyramidBarClustered;

                case KnownChartType.PyramidBarStacked:
                    return eChartType.PyramidBarStacked;

                case KnownChartType.PyramidBarStacked100:
                    return eChartType.PyramidBarStacked100;

                case KnownChartType.PyramidCol:
                    return eChartType.PyramidCol;

                default:
                    return eChartType.Line;
            }
        }
        #endregion

        #region [public] {static} (string) ToEppDataFormat(this string, BaseDataTypeModel): Gets data format from model.
        /// <summary>
        /// Gets data format from model.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="modelDataType">Data model.</param>
        /// <returns>
        /// A <see cref="T:System.String" /> containing the data format.
        /// </returns>
        public static string ToEppDataFormat(this string format, BaseDataTypeModel modelDataType)
        {
            SentinelHelper.ArgumentNull(modelDataType);

            var formatBuilder = new StringBuilder();
            var culture = CultureInfo.CurrentCulture;
            var formatPatternsArray = format.Split(';');

            var dataFormat = modelDataType.Type;
            switch (dataFormat)
            {
                #region Type: Numeric
                case KnownDataType.Numeric:
                    var number = (NumberDataTypeModel)modelDataType;

                    var numberPositivePattern = formatPatternsArray[0];
                    var numberNegativePattern = formatPatternsArray[1];

                    var numberNegativeColor = number.Negative.GetColor().ToString().Split(' ')[1];
                    formatBuilder.Append(numberPositivePattern);
                    formatBuilder.Append(";");
                    formatBuilder.Append(numberNegativeColor);
                    formatBuilder.Append("\\");
                    formatBuilder.Append(numberNegativePattern);
                    return formatBuilder.ToString();
                #endregion

                #region Type: Currency
                case KnownDataType.Currency:
                    var currency = (CurrencyDataTypeModel)modelDataType;
                    var currencyPositivePattern = formatPatternsArray[0];

                    var lcidBuilder = new StringBuilder();
                    if (currency.Locale != KnownCulture.Current)
                    {
                        culture = CultureInfo.GetCultureInfo(ExportsModel.GetXmlEnumAttributeFromItem(currency.Locale));
                        lcidBuilder.Append("[$-");
                        lcidBuilder.Append(culture.LCID.ToString("X", CultureInfo.InvariantCulture));
                        lcidBuilder.Append("]");
                    }

                    lcidBuilder.Append(currencyPositivePattern);

                    var currencyPositiveFormatPattern = lcidBuilder.ToString().Replace(culture.NumberFormat.CurrencySymbol, culture.NumberFormat.CurrencySymbol);
                    formatBuilder.Append(currencyPositiveFormatPattern);

                    var color = currency.Negative.GetColor().ToString().Split(' ')[1];
                    formatBuilder.Append(";");
                    formatBuilder.Append(color);

                    switch (currency.Negative.Sign)
                    {
                        case KnownNegativeSign.None:
                            formatBuilder.Append(currencyPositiveFormatPattern);
                            break;

                        case KnownNegativeSign.Standard:
                            formatBuilder.Append("-");
                            formatBuilder.Append(currencyPositiveFormatPattern);
                            break;

                        case KnownNegativeSign.Parenthesis:
                            formatBuilder.Append(@"\");
                            formatBuilder.Append("(");
                            formatBuilder.Append(currencyPositiveFormatPattern);
                            formatBuilder.Append(@"\");
                            formatBuilder.Append(")");
                            break;

                        case KnownNegativeSign.Brackets:
                            formatBuilder.Append(@"\");
                            formatBuilder.Append("[");
                            formatBuilder.Append(currencyPositiveFormatPattern);
                            formatBuilder.Append(@"\");
                            formatBuilder.Append("]");
                            break;
                    }

                    return formatBuilder.ToString();
                #endregion

                #region Type: Percentage
                case KnownDataType.Percentage:
                    var percent = (PercentageDataTypeModel)modelDataType;

                    formatBuilder.Append("###0");
                    var percentDecimals = percent.Decimals;
                    if (percentDecimals > 0)
                    {
                        var digits = new string('0', percentDecimals);
                        formatBuilder.Append(".");
                        formatBuilder.Append(digits);
                    }

                    formatBuilder.Append("%");

                    return formatBuilder.ToString();
                #endregion

                #region Type: Scientific
                case KnownDataType.Scientific:
                    var scientific = (ScientificDataTypeModel)modelDataType;

                    formatBuilder.Append("0");
                    var scientificDecimals = scientific.Decimals;
                    if (scientificDecimals > 0)
                    {
                        var digits = new string('0', scientificDecimals);
                        formatBuilder.Append(".");
                        formatBuilder.Append(digits);
                    }

                    formatBuilder.Append("E+00");

                    return formatBuilder.ToString();
                #endregion

                #region Type: DateTime
                case KnownDataType.Datetime:
                    var datetime = (DatetimeDataTypeModel)modelDataType;

                    if (datetime.Locale != KnownCulture.Current)
                    {
                        culture = CultureInfo.GetCultureInfo(ExportsModel.GetXmlEnumAttributeFromItem(datetime.Locale));
                        formatBuilder.Append("[$-");
                        formatBuilder.Append(culture.LCID.ToString("X", CultureInfo.InvariantCulture));
                        formatBuilder.Append("]");
                    }

                    formatBuilder.Append(format);
                    return formatBuilder.ToString();
                #endregion

                #region Type: Text
                default:
                    return format;
                #endregion
            }
        }
        #endregion

        #region [public] {static} (OfficeOpenXml.Drawing.Chart.eTickLabelPosition) ToEppLabelPosition(this KnownLabelPosition): Converter for KnownLabelPosition enumeration type to eTickLabelPosition.
        /// <summary>
        /// Converter for <see cref="T:iTin.Export.Model.KnownLabelPosition" /> enumeration type to <see cref="T:OfficeOpenXml.Drawing.Chart.eTickLabelPosition" />.
        /// </summary>
        /// <param name="orientation">Position style from model.</param>
        /// <returns>
        /// A <see cref="T:OfficeOpenXml.Drawing.Chart.eTickLabelPosition" /> value.
        /// </returns>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>
        public static eTickLabelPosition ToEppLabelPosition(this KnownLabelPosition orientation)
        {
            SentinelHelper.IsEnumValid(orientation);

            switch (orientation)
            {
                case KnownLabelPosition.None:
                    return eTickLabelPosition.None;

                case KnownLabelPosition.High:
                    return eTickLabelPosition.High;

                case KnownLabelPosition.NextToAxis:
                    return eTickLabelPosition.NextTo;

                default:
                    return eTickLabelPosition.Low;
            }
        }
        #endregion

        #region [public] {static} (OfficeOpenXml.Drawing.Chart.eLegendPosition) ToEppLegendPosition(this KnownLegendLocation): Converter for KnownChartType enumeration type to eLegendPosition.
        /// <summary>
        /// Converter for <see cref="T:iTin.Export.Model.KnownLegendLocation"/> enumeration type to <see cref="T:OfficeOpenXml.Drawing.Chart.eLegendPosition"/>.
        /// </summary>
        /// <param name="location">Chart legend location</param>
        /// <returns>
        /// A <see cref="OfficeOpenXml.Drawing.Chart.eLegendPosition" /> value.
        /// </returns>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>
        public static eLegendPosition ToEppLegendPosition(this KnownLegendLocation location)
        {
            SentinelHelper.IsEnumValid(location);

            switch (location)
            {
                case KnownLegendLocation.Top:
                    return eLegendPosition.Bottom;

                case KnownLegendLocation.Bottom:
                    return eLegendPosition.Bottom;

                case KnownLegendLocation.Left:
                    return eLegendPosition.Left;

                default:
                    return eLegendPosition.Right;
            }
        }
        #endregion

        #region [public] {static} (OfficeOpenXml.Drawing.eLineStyle) ToEppLineStyle(this KnownLineStyle): Converter for KnownLineStyle enumeration type to eLineStyle.
        /// <summary>
        /// Converter for <see cref="T:iTin.Export.Model.KnownLineStyle"/> enumeration type to <see cref="T:OfficeOpenXml.Drawing.eLineStyle"/>.
        /// </summary>
        /// <param name="style">Line style from model.</param>
        /// <returns>
        /// A <see cref="T:OfficeOpenXml.Drawing.eLineStyle" /> value.
        /// </returns>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>
        public static eLineStyle ToEppLineStyle(this KnownLineStyle style)
        {
            SentinelHelper.IsEnumValid(style);

            switch (style)
            {
                case KnownLineStyle.Dash:
                    return eLineStyle.Dash;

                case KnownLineStyle.DashDot:
                    return eLineStyle.DashDot;

                case KnownLineStyle.DashDotDot:
                    return eLineStyle.SystemDashDotDot;

                case KnownLineStyle.Dot:
                    return eLineStyle.Dot;

                default:
                    return eLineStyle.Solid;
            }
        }
        #endregion

        #region [public] {static} (OfficeOpenXml.Drawing.Chart.eAxisTickMark) ToEppTickMark(this KnownTickMarkStyle): Converter for KnownTickMarkStyle enumeration type to eAxisTickMark.
        /// <summary>
        /// Converter for <see cref="T:iTin.Export.Model.KnownTickMarkStyle"/> enumeration type to <see cref="T:OfficeOpenXml.Drawing.Chart.eAxisTickMark" />.
        /// </summary>
        /// <param name="style">Mark style from model.</param>
        /// <returns>
        /// A <see cref="T:OfficeOpenXml.Drawing.Chart.eAxisTickMark" /> value.
        /// </returns>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>
        public static eAxisTickMark ToEppTickMark(this KnownTickMarkStyle style)
        {
            SentinelHelper.IsEnumValid(style);

            switch (style)
            {
                case KnownTickMarkStyle.None:
                    return eAxisTickMark.None;

                case KnownTickMarkStyle.Inside:
                    return eAxisTickMark.In;

                case KnownTickMarkStyle.Outside:
                    return eAxisTickMark.Out;

                default:
                    return eAxisTickMark.Cross;
            }
        }
        #endregion

        #region [public] {static} (string) ToEppLabelAlignmentString(this KnownHorizontalAlignment): Converter for KnownHorizontalAlignment enumeration type to string representation.
        /// <summary>
        /// Converter for <see cref="KnownHorizontalAlignment" /> enumeration type to string representation.
        /// </summary>
        /// <param name="alignment">Alignment from model.</param>
        /// <returns>
        /// Alignment as string.
        /// </returns>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>
        public static string ToEppLabelAlignmentString(this KnownHorizontalAlignment alignment)
        {
            SentinelHelper.IsEnumValid(alignment);

            switch (alignment)
            {
                case KnownHorizontalAlignment.Left:
                    return "l";

                case KnownHorizontalAlignment.Right:
                    return "r";

                default:
                    return "ctr";
            }
        }
        #endregion

        #region [public] {static} (OfficeOpenXml.eOrientation) ToEppOrientation(this KnownDocumentOrientation): Converter for KnownDocumentOrientation enumeration type to OfficeOpenXml.eOrientation.
        /// <summary>
        /// Converter for <see cref="T:iTin.Export.Model.KnownDocumentOrientation"/> enumeration type to <see cref="T:OfficeOpenXml.eOrientation"/>.
        /// </summary>
        /// <param name="orientation">Orientation value from model.</param>
        /// <returns>
        /// A <see cref="T:OfficeOpenXml.eOrientation" /> value.
        /// </returns>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>
        public static eOrientation ToEppOrientation(this KnownDocumentOrientation orientation)
        {
            SentinelHelper.IsEnumValid(orientation);

            return orientation == KnownDocumentOrientation.Portrait ? eOrientation.Portrait : eOrientation.Landscape;
        }
        #endregion

        #region [public] {static} (OfficeOpenXml.ePaperSize) ToEppPaperSize(this KnownDocumentSize): Converter for KnownDocumentSize enumeration type to OfficeOpenXml.ePaperSize.
        /// <summary>
        /// Converter for <see cref="T:iTin.Export.Model.KnownDocumentSize"/> enumeration type to <see cref="T:OfficeOpenXml.ePaperSize"/>.
        /// </summary>
        /// <param name="paper">Paper size value from model.</param>
        /// <returns>
        /// A <see cref="T:OfficeOpenXml.ePaperSize" /> value.
        /// </returns>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>
        public static ePaperSize ToEppPaperSize(this KnownDocumentSize paper)
        {
            SentinelHelper.IsEnumValid(paper);

            var paperSize = ePaperSize.A4; 
            switch (paper)
            {
                case KnownDocumentSize.A0:
                    break;

                case KnownDocumentSize.A1:
                    break;

                case KnownDocumentSize.A2:
                    paperSize = ePaperSize.A2;
                    break;

                case KnownDocumentSize.A3:
                    paperSize = ePaperSize.A3;
                    break;

                case KnownDocumentSize.A5:
                    paperSize = ePaperSize.A5;
                    break;

                case KnownDocumentSize.A6:
                    break;

                case KnownDocumentSize.A7:
                    break;

                case KnownDocumentSize.A8:
                    break;

                case KnownDocumentSize.A9:
                    break;

                case KnownDocumentSize.A10:
                    break;

                case KnownDocumentSize.Executive:
                    break;

                case KnownDocumentSize.HalfLetter:
                    break;

                case KnownDocumentSize.Letter:
                    paperSize = ePaperSize.Letter;
                    break;

                case KnownDocumentSize.Note:
                    paperSize = ePaperSize.Note;
                    break;

                case KnownDocumentSize.PostCard:
                    break;
            }

            return paperSize;
        }
        #endregion
    }
}
