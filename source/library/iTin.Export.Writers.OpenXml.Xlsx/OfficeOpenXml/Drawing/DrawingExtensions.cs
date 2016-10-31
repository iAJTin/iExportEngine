using System.Xml;

using iTin.Export.Helper;
using iTin.Export.Model;
using iTin.Export.Writers.OpenXml.Office;

using OfficeOpenXml.Drawing.Chart;
using OfficeOpenXml.Drawing.Chart.Xml;
using OfficeOpenXml.Utils.iTin;

namespace OfficeOpenXml.Drawing
{
    /// <summary>
    /// Static class than contains common extension methods for objects of the namespace <see cref="OfficeOpenXml.Drawing"/>.
    /// </summary>
    static class DrawingExtensions
    {
        /// <summary>
        /// Fills a <see cref="OfficeOpenXml.Drawing.ExcelDrawingBorder"/> object with model data. 
        /// </summary>
        /// <param name="border"><see cref="OfficeOpenXml.Drawing.ExcelDrawingBorder"/> object.</param>
        /// <param name="element">Chart element.</param>
        /// <param name="model">Chart border model definition.</param>
        /// <exception cref="T:System.ArgumentNullException">If <paramref name="border" /> is <c>null</c>.</exception>
        /// <exception cref="T:System.ArgumentNullException">If <paramref name="model" /> is <c>null</c>.</exception>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>
        public static void FormatFromModel(this ExcelDrawingBorder border, KnownChartElement element, ChartBorderModel model)
        {
            SentinelHelper.IsEnumValid(element);
            SentinelHelper.ArgumentNull(model);
            SentinelHelper.ArgumentNull(border);

            if (model.Show == YesNo.Yes)
            {
                border.Fill.Color = model.GetColor();
                border.Width = model.Width.ToEppBorderWidth();
                border.LineStyle = model.Style.ToEppLineStyle();
            }

            if (model.Shadow.Show == YesNo.No)
            {
                return;
            }

            XmlNode shapePropertiesNode;
            var root = ChartXmlHelper.FromKnownChartElement(element);
            var exist = ChartXmlHelper.TryGetElementFrom(root, "c:spPr", out shapePropertiesNode);
            shapePropertiesNode.AddEffectContainerNode(model.Shadow);

            if (!exist)
            {
                root.AppendChild(shapePropertiesNode);
            }
        }
    }
}
