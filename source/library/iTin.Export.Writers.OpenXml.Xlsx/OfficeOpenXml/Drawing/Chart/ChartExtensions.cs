using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Xml;

using iTin.Export.Helper;
using iTin.Export.Model;
using iTin.Export.Writers.OpenXml.Office;

using OfficeOpenXml.Drawing.Chart.Xml;
using OfficeOpenXml.Utils.iTin;

namespace OfficeOpenXml.Drawing.Chart
{
    /// <summary>
    /// Static class than contains common extension methods for objects of the namespace <see cref="N:OfficeOpenXml.Drawing.Chart"/>.
    /// </summary>
    static class ChartExtensions
    {
        #region Public Static Methods

            #region [public] {static} (void) FormatFromModel(this OfficeOpenXml.Drawing.Chart.ExcelChart, ChartModel): Fills a ExcelChart object with model data.
            /// <summary>
            /// Fills a <see cref="OfficeOpenXml.Drawing.Chart.ExcelChart"/> object with model data. 
            /// </summary>
            /// <param name="chart"><see cref="OfficeOpenXml.Drawing.Chart.ExcelChart"/> object.</param>
            /// <param name="model">Chart model definition.</param>
            /// <exception cref="System.ArgumentNullException">If <paramref name="chart" /> is <c>null</c>.</exception>
            /// <exception cref="System.ArgumentNullException">If <paramref name="model" /> is <c>null</c>.</exception>
            public static void FormatFromModel(this ExcelChart chart, ChartModel model)
            {
                SentinelHelper.ArgumentNull(chart);
                SentinelHelper.ArgumentNull(model);

                ChartXmlHelper.ChartXml = chart.ChartXml;

                chart.SetSize(model.ChartSize.Width, model.ChartSize.Height);
                chart.FormatFromModel(model.Location);
                chart.Fill.Color = model.GetBackColor();

                chart.Border.FormatFromModel(KnownChartElement.Self, model.Border);
                chart.Title.FormatFromModel(KnownChartElement.ChartTitle, model.Title);
                chart.Legend.FormatFromModel(model.Legend);
                chart.PlotArea.FormatFromModel(model.Plots);                
                chart.Axis.FormatFromModel(model.Axes);
            }
            #endregion

        #endregion

        #region Private Static Methods

            #region [private] {static} (void) FormatFromModel(this OfficeOpenXml.Drawing.Chart.ExcelChartAxis, XmlNode, AxisDefinitionModel): Fills a ExcelChartAxis object with model data.
            /// <summary>
            /// Fills a <see cref="OfficeOpenXml.Drawing.Chart.ExcelChartAxis"/> object with model data. 
            /// </summary>
            /// <param name="axis"><see cref="OfficeOpenXml.Drawing.Chart.ExcelChartAxis" /> object.</param>
            /// <param name="axisNodeAsXml"><c>Xml</c> node than represent an axis definition.</param>
            /// <param name="model">Axis model definition.</param>
            private static void FormatFromModel(this ExcelChartAxis axis, XmlNode axisNodeAsXml, AxisDefinitionModel model)
            {
                if (model.Values.HasMaximunValue)
                {
                    axis.MaxValue = double.Parse(model.Values.Maximun, CultureInfo.InvariantCulture);
                }

                if (model.Values.HasMinimunValue)
                {
                    axis.MinValue = double.Parse(model.Values.Minimun, CultureInfo.InvariantCulture);
                }
                                
                axis.MajorTickMark = model.Marks.Major.ToEppTickMark();
                axis.MinorTickMark = model.Marks.Minor.ToEppTickMark();                
                axis.LabelPosition = model.Labels.Position.ToEppLabelPosition();
                axis.TickLabelPosition = model.Labels.Position.ToEppLabelPosition();
                               
                axisNodeAsXml.AddAxisGridLinesMode(model.GridLines);
                axisNodeAsXml.AddAxisLabelProperties(model.Labels);
                axisNodeAsXml.AddAxisLabelAlignment(model.Labels.Alignment);
                axisNodeAsXml.ModifyAxisCrosses();

                var axisType = axisNodeAsXml.ExtractAxisType();
                axis.Title.FormatFromModel(axisType.ToKnownChartElement(), model.Title);
            }
            #endregion
       
            #region [private] {static} (void) FormatFromModel(this OfficeOpenXml.Drawing.Chart.ExcelChartLegend, ChartLegendModel): Fills a legend object with model data.
            /// <summary>
            /// Fills a <see cref="OfficeOpenXml.Drawing.Chart.ExcelChartLegend"/> object with model data. 
            /// </summary>
            /// <param name="legend"><see cref="OfficeOpenXml.Drawing.Chart.ExcelChartLegend"/> object.</param>
            /// <param name="model">Legend model definition.</param>
            private static void FormatFromModel(this ExcelChartLegend legend, ChartLegendModel model)
            {
                if (model.Show == YesNo.No)
                {
                    return;
                }

                legend.Font.SetFromFont(model.Font.ToFont());
                legend.Font.Color = model.Font.GetColor();
                legend.Position = model.Location.ToEppLegendPosition();
                legend.Border.FormatFromModel(KnownChartElement.Legend, model.Border);
            }
            #endregion

            #region [private] {static} (void) FormatFromModel(this OfficeOpenXml.Drawing.Chart.ExcelChartTitle, KnownBorderParent, ChartTitleModel): Fills a chart title object with model data.
            /// <summary>
            /// Fills a <see cref="OfficeOpenXml.Drawing.Chart.ExcelChartTitle"/> object with model data. 
            /// </summary>
            /// <param name="title"><see cref="OfficeOpenXml.Drawing.Chart.ExcelChartTitle"/> object.</param>
            /// <param name="element">A <see cref="KnownChartElement" /> value.</param>
            /// <param name="model">Chart title model definition.</param>
            private static void FormatFromModel(this ExcelChartTitle title, KnownChartElement element, ChartTitleModel model)
            {
                if (model.Show == YesNo.No)
                {
                    return;
                }

                if (!string.IsNullOrEmpty(model.Text))
                {
                    title.Text = model.Text;                    
                    title.Font.SetFromFont(model.Font.ToFont());
                    title.Font.Color = model.Font.GetColor();

                    title.Rotation = model.Orientation.ToAngle();
                    title.TextVertical = model.Orientation == KnownAxisOrientation.Vertical ? eTextVerticalType.WordArtVertical : eTextVerticalType.Horizontal;
                }

                title.Border.FormatFromModel(element, model.Border);
            }
            #endregion

            #region [private] {static} (void) FormatFromModel(this OfficeOpenXml.Drawing.Chart.ExcelChartPlotArea, ChartPlotsModel): Fills a plot area object with model data.
            /// <summary>
            /// Fills a <see cref="OfficeOpenXml.Drawing.Chart.ExcelChartPlotArea"/> object with model data. 
            /// </summary>
            /// <param name="plotArea"><see cref="OfficeOpenXml.Drawing.Chart.ExcelChartAxis"/> object.</param>
            /// <param name="model">Plots model definition.</param>
            private static void FormatFromModel(this ExcelChartPlotArea plotArea, ChartPlotsModel model)
            {
                plotArea.Fill.Color = model.Parent.GetBackColor();
                plotArea.Border.FormatFromModel(KnownChartElement.PlotArea, model.Border);

                var series = model.SelectMany(plot => plot.Series);
                foreach (var serie in series)
                {
                    ChartHelper.AddSerieColor(serie);
                }
            }
            #endregion

            #region [private] {static} (void) FormatFromModel(this OfficeOpenXml.Drawing.ExcelDrawing, LocationModel): Sets the chart location on the host.
            /// <summary>
            /// Sets the <see cref="OfficeOpenXml.Drawing.Chart.ExcelChart" /> location on the host.
            /// </summary>
            /// <param name="chart"><see cref="OfficeOpenXml.Drawing.Chart.ExcelChart" /> object.</param>
            /// <param name="location">Location model definition.</param>
            private static void FormatFromModel(this ExcelDrawing chart, LocationModel location)
            {
                var coordenates = location.LocationType.Equals(KnownElementLocation.ByAlignment)
                                      ? new Point(1, 1)
                                      : ((CoordenatesModel)location.Mode).TableCoordenates;
                chart.SetPosition(coordenates.Y - 1, 0, coordenates.X - 1, 0);
            }
            #endregion

            #region [private] {static} (void) FormatFromModel(this IEnumerable<OfficeOpenXml.Drawing.Chart.ExcelChartAxis>, ChartAxesModel): Fills the ExcelChartAxis objects from model data.
            /// <summary>
            /// Fills the <see cref="OfficeOpenXml.Drawing.Chart.ExcelChartAxis" /> objects from model data.
            /// </summary>
            /// <param name="axes"><see cref="System.Array"/> of <see cref="OfficeOpenXml.Drawing.Chart.ExcelChartAxis" /> objects.</param>
            /// <param name="model">Axes model definition.</param>
            private static void FormatFromModel(this IEnumerable<ExcelChartAxis> axes, ChartAxesModel model)
            {
                var axesList = axes.ToList();
                var axesListAsXml = ChartHelper.ToAxisXmlFrom(axesList).ToList();

                // Primary axis.
                axesList[0].FormatFromModel(axesListAsXml[0], model.Primary.Category);
                axesList[1].FormatFromModel(axesListAsXml[1], model.Primary.Values);

                // Secondary axis.
                if (axesList.Count <= 2)
                {
                    return;
                }

                axesList[2].FormatFromModel(axesListAsXml[2], model.Secondary.Category);
                axesList[3].FormatFromModel(axesListAsXml[3], model.Secondary.Values);
            }
            #endregion

        #endregion
    }
}
