using System.Collections.Generic;
using System.Linq;
using System.Xml;

using iTin.Export.Helper;
using iTin.Export.Model;

using OfficeOpenXml.Drawing.Chart.Xml;
using OfficeOpenXml.Utils.iTin;

namespace OfficeOpenXml.Drawing.Chart
{
    /// <summary>
    /// Static class that contains methods for manipulating objects from <see cref="OfficeOpenXml.Drawing.Chart"/> namespace.
    /// </summary>
    static class ChartHelper
    {
        #region [public] {static} (void) AddSerieColor(ChartSerieModel): Adds a color to the specified serie. Not supported in EPPlus library.
        /// <summary>
        /// Adds a color to the specified serie. Not supported in <c>EPPlus</c> library.
        /// </summary>
        /// <param name="model">Serie from model.</param>
        /// <exception cref="System.ArgumentNullException">If <paramref name="model" /> is <c>null</c>.</exception>
        public static void AddSerieColor(ChartSerieModel model)
        {
            SentinelHelper.ArgumentNull(model);

            var xmlSerieList = ChartXmlHelper.GetElementsByTagName("c:v");
            var textNode = xmlSerieList.FirstOrDefault(n => n.ParentNode.ParentNode.Name.Equals("ser") && n.InnerText.Equals(model.Legend));
            if (textNode == null)
            {
                return;
            }

            var areaChartSeriesNode = textNode.ParentNode.ParentNode;
            areaChartSeriesNode.AddShapePropertiesNode(model);
        }
        #endregion

        #region [public] {static} (KnownChartElement) ToKnownChartElement(KnownAxisType): Converter for KnownAxisType enumeration type to KnownChartElement enumeration.
        /// <summary>
        /// Converter for <see cref="KnownAxisType"/> enumeration type to <see cref="KnownChartElement"/> enumeration.
        /// </summary>
        /// <param name="type">Axis type to converter.</param>
        /// <returns>
        /// A enumeration value than represents axis type.
        /// </returns>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>
        public static KnownChartElement ToKnownChartElement(this KnownAxisType type)
        {
            SentinelHelper.IsEnumValid(type);

            switch (type)
            {
                case KnownAxisType.PrimaryValueAxis:
                    return KnownChartElement.PrimaryValueAxisTitle;

                case KnownAxisType.SecondaryCategoryAxis:
                    return KnownChartElement.SecondaryCategoryAxisTitle;
                
                case KnownAxisType.SecondaryValueAxis:
                    return KnownChartElement.SecondaryValueAxisTitle;

                default:
                    return KnownChartElement.PrimaryCategoryAxisTitle;
            }
        }
        #endregion

        #region [public] {static} (IEnumerable<XmlNode>) ToAxisXmlFrom(IEnumerable<OfficeOpenXml.Drawing.Chart.ExcelChartAxis>): Converts a ExcelChartAxis objects to Array elements of type XmlNode.
        /// <summary>
        /// Converts a <see cref="OfficeOpenXml.Drawing.Chart.ExcelChartAxis"/> objects to <see cref="System.Array"/> elements of type <see cref="System.Xml.XmlNode"/>.
        /// </summary>
        /// <param name="axes"><see cref="OfficeOpenXml.Drawing.Chart.ExcelChartAxis"/> objects.</param>
        /// <returns>
        /// List of nodes equivalent a <see cref="OfficeOpenXml.Drawing.Chart.ExcelChartAxis"/> objects.
        /// </returns>
        /// <exception cref="System.ComponentModel.InvalidEnumArgumentException">If <paramref name="axes" /> not belong to enumeration.</exception>
        public static IEnumerable<XmlNode> ToAxisXmlFrom(IEnumerable<ExcelChartAxis> axes)
        {
            SentinelHelper.ArgumentNull(axes);

            var xmlAxisNodeList = new List<XmlNode>
                                      {
                                          ChartXmlHelper.FromKnownChartElement(KnownChartElement.PrimaryCategoryAxis),
                                          ChartXmlHelper.FromKnownChartElement(KnownChartElement.PrimaryValueAxis),
                                      };

            var catAxisXmlNodes = ChartXmlHelper.GetElementsByTagName("c:catAx");
            if (catAxisXmlNodes.Count() <= 1)
            {
                return xmlAxisNodeList;
            }

            xmlAxisNodeList.Add(ChartXmlHelper.FromKnownChartElement(KnownChartElement.SecondaryCategoryAxis));
            xmlAxisNodeList.Add(ChartXmlHelper.FromKnownChartElement(KnownChartElement.SecondaryValueAxis));

            return xmlAxisNodeList;
        }
        #endregion
    }
}
