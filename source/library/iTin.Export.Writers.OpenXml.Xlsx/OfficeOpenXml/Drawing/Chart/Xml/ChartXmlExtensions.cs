
namespace OfficeOpenXml.Drawing.Chart.Xml
{
    using System.Drawing;
    using System.Globalization;
    using System.Xml;

    using iTin.Export.Drawing.Helper;
    using iTin.Export.Helpers;
    using iTin.Export.Model;
    using iTin.Export.Writers.OpenXml.Office;

    using Utils.iTin;

    /// <summary>
    ///   <para>Static class than contains extension methods for objects of type <see cref="System.Xml.XmlNode" />.</para>
    ///   <para>This class adds new <c>XML</c> functionality using extension methods directly in chart xml tree of EPPlus library.</para>
    ///   <para>For example:</para>
    ///   <list type="bullet">
    ///     <item>
    ///       <description>Add alignment, orientation, font type and color to an axis labels.</description>
    ///     </item>
    ///     <item>
    ///       <description>Add shadows to some shape.</description>
    ///     </item>
    ///     <item>
    ///       <description>Known axis type for a specified node.</description>
    ///     </item>
    ///   </list>
    /// </summary>
    /// <remarks>
    ///   <para>For more information please see <a href="http://epplus.codeplex.com/">http://epplus.codeplex.com/</a>, </para>
    ///   <para><a href="http://www.ecma-international.org/publications/standards/Ecma-376.htm">http://www.ecma-international.org/publications/standards/Ecma-376.htm</a>.</para>
    /// </remarks>
    static class ChartXmlExtensions
    {
        #region public static methods

        #region [public] {static} (void) AddAxisGridLinesMode(this XmlNode, KnownPlotGridLine): Adds major, minor or both grid lines to the specified axis. Not supported in EPPlus library
        /// <summary>
        /// Adds major, minor or both grid lines to the specified axis. Not supported in <c>EPPlus</c> library.
        /// </summary>
        /// <param name="axis"><c>Xml</c> node than represent an axis definition.</param>
        /// <param name="model">A <see cref="KnownPlotGridLine" /> value from model.</param>
        /// <exception cref="T:System.ArgumentNullException">If <paramref name="axis" /> is <c>null</c>.</exception>
        /// <exception cref="T:System.InvalidOperationException">If <paramref name="axis" /> is not an axis.</exception>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>
        public static void AddAxisGridLinesMode(this XmlNode axis, KnownPlotGridLine model)
        {
            SentinelHelper.ArgumentNull(axis);
            SentinelHelper.IsEnumValid(model);
            SentinelHelper.IsFalse(axis.Name.Contains("catAx") || axis.Name.Contains("valAx") || axis.Name.Contains("dateAx"), "Imposible extraer tipo. el nodo no es de tipo eje");

            var existMajorGridLinesNode = ChartXmlHelper.TryGetElementFrom(axis, "c:majorGridlines", out var majorGridLinesElement);
            if (existMajorGridLinesNode)
            {
                var parent = majorGridLinesElement.ParentNode;
                parent.RemoveChild(majorGridLinesElement);
            }

            var existMinorGridLinesNode = ChartXmlHelper.TryGetElementFrom(axis, "c:minorGridlines", out var minorGridLinesElement);
            if (existMinorGridLinesNode)
            {
                var parent = minorGridLinesElement.ParentNode;
                parent.RemoveChild(minorGridLinesElement);
            }

            switch (model)
            {
                case KnownPlotGridLine.None:
                    break;

                case KnownPlotGridLine.Major:
                    axis.AppendChild(majorGridLinesElement);
                    break;

                case KnownPlotGridLine.Minor:
                    axis.AppendChild(minorGridLinesElement);
                    break;

                case KnownPlotGridLine.Both:
                    axis.AppendChild(majorGridLinesElement);
                    axis.AppendChild(minorGridLinesElement);
                    break;
            }
        }
        #endregion

        #region [public] {static} (void) AddAxisLabelAlignment(this XmlNode, KnownHorizontalAlignment): Adds the label alignment to the specified axis. Not supported in EPPlus library
        /// <summary>
        /// Adds the label alignment to the specified axis. Not supported in <c>EPPlus</c> library.
        /// </summary>
        /// <param name="axis"><c>Xml</c> node than represent an axis definition.</param>
        /// <param name="model">A <see cref="KnownHorizontalAlignment" /> value from model.</param>
        /// <exception cref="T:System.ArgumentNullException">If <paramref name="axis" /> is <c>null</c>.</exception>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>
        /// <exception cref="T:System.InvalidOperationException">If <paramref name="axis" /> is not an axis.</exception>
        public static void AddAxisLabelAlignment(this XmlNode axis, KnownHorizontalAlignment model)
        {
            SentinelHelper.ArgumentNull(axis);
            SentinelHelper.IsEnumValid(model);
            SentinelHelper.IsFalse(axis.Name.Contains("catAx") || axis.Name.Contains("valAx") || axis.Name.Contains("dateAx"), "Imposible extraer tipo. el nodo no es de tipo eje");

            var axisType = axis.ExtractAxisType();
            switch (axisType)
            {
                case KnownAxisType.PrimaryCategoryAxis:
                case KnownAxisType.SecondaryCategoryAxis:

                    var valAttr = ChartXmlHelper.CreateAttribute("val");
                    valAttr.Value = model.ToEppLabelAlignmentString();

                    var lblAlignXmlNode = ChartXmlHelper.CreateOrDefaultAndAppendElementToNode(axis, "c:lblAlgn");
                    lblAlignXmlNode.Attributes.Append(valAttr);
                    break;

                case KnownAxisType.PrimaryValueAxis:
                case KnownAxisType.SecondaryValueAxis:
                    break;
            }
        }
        #endregion

        #region [public] {static} (void) AddAxisLabelProperties(this XmlNode, AxisDefinitionLabelsModel): Adds label properties (orientation, alignment, color and font) to the specified axis. Not supported in EPPlus library
        /// <summary>
        /// Adds label properties (orientation, alignment, color and font) to the specified axis. Not supported in <c>EPPlus</c> library.
        /// </summary>
        /// <param name="axis"><c>Xml</c> node than represent an axis definition.</param>
        /// <param name="model">Axis from model.</param>
        /// <exception cref="T:System.ArgumentNullException">If <paramref name="axis" /> is <c>null</c>.</exception>
        /// <exception cref="T:System.ArgumentNullException">If <paramref name="model" /> is <c>null</c>.</exception>
        /// <exception cref="T:System.InvalidOperationException">If <paramref name="axis" /> is not an axis.</exception>
        public static void AddAxisLabelProperties(this XmlNode axis, AxisDefinitionLabelsModel model)
        {
            SentinelHelper.ArgumentNull(axis);
            SentinelHelper.ArgumentNull(model);
            SentinelHelper.IsFalse(axis.Name.Contains("catAx") || axis.Name.Contains("valAx") || axis.Name.Contains("dateAx"), "Imposible extraer tipo. el nodo no es de tipo eje");

            axis.AddTextPropertiesNode(model);
        }
        #endregion

        #region [public] {static} (void) AddEffectContainerNode(this XmlNode, ShadowModel): Adds an effectLst node (Effect Container) to the node of type spPr (Shape properties) specified. Not supported in EPPlus library
        /// <summary>
        /// Adds an <c>effectLst</c> node (Effect Container) to the node of type <c>spPr</c> (Shape properties) specified. Not supported in <c>EPPlus</c> library.
        /// </summary>
        /// <param name="node"><c>spPr</c> node (Shape properties).</param>
        /// <param name="model">Shadow from model.</param>
        /// <remarks>
        /// For more information please see <a href="http://www.schemacentral.com/sc/ooxml/e-a_effectLst-1.html">http://www.schemacentral.com/sc/ooxml/e-a_effectLst-1.html</a>
        /// </remarks>
        /// <exception cref="T:System.ArgumentNullException">If <paramref name="node" /> is <c>null</c>.</exception>
        /// <exception cref="T:System.ArgumentNullException">If <paramref name="model" /> is <c>null</c>.</exception>
        public static void AddEffectContainerNode(this XmlNode node, ShadowModel model)
        {
            SentinelHelper.ArgumentNull(node);
            SentinelHelper.ArgumentNull(model);

            var effectContainerNode = ChartXmlHelper.CreateOrDefaultAndAppendElementToNode(node, "a", "effectLst");
            effectContainerNode.AddOuterShadowNode(model);
        }
        #endregion

        #region [public] {static} (void) AddShapePropertiesNode(this XmlNode, ChartSerieModel): Adds a spPr node (Shape properties) to the node of type ser (Area Chart Series) specified. Not supported in EPPlus library
        /// <summary>
        /// Adds a <c>spPr</c> node (Shape properties) to the node of type <c>ser</c> (Area Chart Series) specified. Not supported in <c>EPPlus</c> library.
        /// </summary>
        /// <param name="node"><c>ser</c> node (Area Chart Series).</param>
        /// <param name="model">Serie from model.</param>
        /// <remarks>
        /// For more information please see <a href="http://www.schemacentral.com/sc/ooxml/e-draw-chart_spPr-1.html">http://www.schemacentral.com/sc/ooxml/e-draw-chart_spPr-1.html</a>
        /// </remarks>
        /// <exception cref="T:System.ArgumentNullException">If <paramref name="node" /> is <c>null</c>.</exception>
        /// <exception cref="T:System.ArgumentNullException">If <paramref name="model" /> is <c>null</c>.</exception>
        public static void AddShapePropertiesNode(this XmlNode node, ChartSerieModel model)
        {
            SentinelHelper.ArgumentNull(node);
            SentinelHelper.ArgumentNull(model);

            var shapePropertiesNode = ChartXmlHelper.CreateOrDefaultAndAppendElementToNode(node, "c:spPr");
            shapePropertiesNode.AddSolidFillNode(model.GetColor());

        }
        #endregion

        #region [public] {static} (KnownAxisType) ExtractAxisType(this XmlNode): Returns the type of axis than represents specified node. Not supported in EPPlus library
        /// <summary>
        /// Returns the type of axis than represents specified node. Not supported in <c>EPPlus</c> library.
        /// </summary>
        /// <param name="axis"><c>Xml</c> node than represent an axis definition.</param>
        /// <returns>
        ///   <para>Type: <see cref="KnownAxisType" /></para>
        ///   <para>A <see cref="KnownAxisType" /> value.</para>
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">If <paramref name="axis" /> is <c>null</c>.</exception>
        /// <exception cref="T:System.InvalidOperationException">If <paramref name="axis" /> is not an axis.</exception>
        public static KnownAxisType ExtractAxisType(this XmlNode axis)
        {
            SentinelHelper.ArgumentNull(axis);
            SentinelHelper.IsFalse(axis.Name.Contains("catAx") || axis.Name.Contains("valAx") || axis.Name.Contains("dateAx"), "Imposible extraer tipo. el nodo no es de tipo eje");

            var idElement = ChartXmlHelper.GetXmlNode(axis, "c:axId");
            var valueAttr = idElement.Attributes["val"];

            var value = valueAttr.Value;
            switch (value)
            {
                case "2":
                    return KnownAxisType.PrimaryValueAxis;

                case "3":
                    return KnownAxisType.SecondaryCategoryAxis;

                case "4":
                    return KnownAxisType.SecondaryValueAxis;

                default:
                    return KnownAxisType.PrimaryCategoryAxis;
            }
        }
        #endregion

        #region [public] {static} (void) ModifyAxisCrosses(this XmlNode): Modifies crosses for the specified axis. Supported in EPPlus library but fails
        /// <summary>
        /// Modifies crosses for the specified axis. Supported in <c>EPPlus</c> library but fails.
        /// </summary>
        /// <param name="axis"><c>Xml</c> node than represent an axis definition.</param>
        /// <exception cref="T:System.ArgumentNullException">If <paramref name="axis" /> is <c>null</c>.</exception>
        /// <exception cref="T:System.InvalidOperationException">If <paramref name="axis" /> is not an axis.</exception>
        public static void ModifyAxisCrosses(this XmlNode axis)
        {
            SentinelHelper.ArgumentNull(axis);
            SentinelHelper.IsFalse(axis.Name.Contains("catAx") || axis.Name.Contains("valAx") || axis.Name.Contains("dateAx"), "Imposible extraer tipo. el nodo no es de tipo eje");

            var axisType = axis.ExtractAxisType();
            if (axisType != KnownAxisType.SecondaryCategoryAxis)
            {
                return;
            }

            var valAttr = ChartXmlHelper.CreateAttribute("val");
            valAttr.Value = "max";

            var crossesXmlNode = ChartXmlHelper.CreateOrDefaultAndAppendElementToNode(axis, "c:crosses");                    
            crossesXmlNode.Attributes.Append(valAttr);
        }
        #endregion

        #endregion

        #region private static methods

        #region [private] {static} (void) AddTextPropertiesNode(this XmlNode, AxisDefinitionLabelsModel): Adds a 'txPr' node (Text properties) to the node of type 'valAx' (Value Axis), 'catAx' (Category Axis Data), 'dateAx' (Date Axis), 'serAx' (Series Axis) specified. Not supported in EPPlus library
        /// <summary>
        /// Adds a <c>txPr</c> node (Text properties) to the node of type <c>valAx</c> (Value Axis), <c>catAx</c> (Category Axis Data), <c>dateAx</c> (Date Axis), <c>serAx</c> (Series Axis) specified. Not supported in <c>EPPlus</c> library.
        /// </summary>
        /// <param name="node">Node of type <c>valAx</c> (Value Axis), <c>catAx</c> (Category Axis Data), <c>dateAx</c> (Date Axis), <c>serAx</c> (Series Axis).</param>
        /// <param name="model">Axis from model.</param>
        /// <remarks>
        /// For more information please see <a href="http://www.schemacentral.com/sc/ooxml/e-draw-chart_txPr-1.html">http://www.schemacentral.com/sc/ooxml/e-draw-chart_txPr-1.html</a>
        /// </remarks>
        private static void AddTextPropertiesNode(this XmlNode node, AxisDefinitionLabelsModel model)
        {
            var textPropertiesNode = ChartXmlHelper.CreateOrDefaultAndAppendElementToNode(node, "c", "txPr");

            textPropertiesNode.AddBodyPropertiesNode(model.Orientation);
            textPropertiesNode.AddTextListStylesNode();
            textPropertiesNode.AddTextParagraphsNode(model.Font);
        }
        #endregion

        #region [private] {static} (void) AddBodyPropertiesNode(this XmlNode, KnownLabelOrientation): Adds a 'bodyPr' node (Body Properties) to the node of type 'txPr' (Text properties) specified. Not supported in EPPlus library
        /// <summary>
        /// Adds a <c>bodyPr</c> node (Body Properties) to the node of type <c>txPr</c> (Text properties) specified. Not supported in <c>EPPlus</c> library.
        /// </summary>
        /// <param name="textPropertiesNode"><c>txPr</c> node (Text properties).</param>
        /// <param name="orientation">A <see cref="KnownLabelOrientation" /> value from model.</param>
        /// <remarks>
        /// For more information please see <a href="http://www.schemacentral.com/sc/ooxml/e-a_bodyPr-2.html">http://www.schemacentral.com/sc/ooxml/e-a_bodyPr-2.html</a>
        /// </remarks>
        private static void AddBodyPropertiesNode(this XmlNode textPropertiesNode, KnownLabelOrientation orientation)
        {
            var rotAttr = ChartXmlHelper.CreateAttribute("rot");
            rotAttr.Value = orientation.ToAngle().ToString(CultureInfo.InvariantCulture);

            var vertAttr = ChartXmlHelper.CreateAttribute("vert");
            vertAttr.Value = orientation == KnownLabelOrientation.Vertical ? "wordArtVert" : "horz";

            var bodyPropertiesNode = ChartXmlHelper.CreateOrDefaultAndAppendElementToNode(textPropertiesNode, "a", "bodyPr");
            bodyPropertiesNode.Attributes.Append(rotAttr);
            bodyPropertiesNode.Attributes.Append(vertAttr);
        }
        #endregion

        #region [private] {static} (void) AddTextListStylesNode(this XmlNode): Adds a 'lstStyle' node (Text List Styles) to the node of type 'txPr' (Text properties) specified. Not supported in EPPlus library
        /// <summary>
        /// Adds a <c>lstStyle</c> node (Text List Styles) to the node of type <c>txPr</c> (Text properties) specified. Not supported in <c>EPPlus</c> library.
        /// </summary>
        /// <param name="textPropertiesNode"><c>txPr</c> node (Text properties).</param>
        /// <remarks>
        /// For more information please see <a href="http://www.schemacentral.com/sc/ooxml/e-a_lstStyle-2.html">http://www.schemacentral.com/sc/ooxml/e-a_lstStyle-2.html</a>
        /// </remarks>
        private static void AddTextListStylesNode(this XmlNode textPropertiesNode)
        {
            ChartXmlHelper.CreateOrDefaultAndAppendElementToNode(textPropertiesNode, "a", "lstStyle");
        }
        #endregion

        #region [private] {static} (void) AddTextParagraphsNode(this XmlNode, FontModel): Adds a 'p' node (Text Paragraphs) to the node of type 'txPr' (Text properties) specified. Not supported in EPPlus library
        /// <summary>
        /// Adds a <c>p</c> node (Text Paragraphs) to the node of type <c>txPr</c> (Text properties) specified. Not supported in <c>EPPlus</c> library.
        /// </summary>
        /// <param name="textPropertiesNode"><c>txPr</c> node (Text properties).</param>
        /// <param name="model">Font from model.</param>
        /// <remarks>
        /// For more information please see <a href="http://www.schemacentral.com/sc/ooxml/e-a_p-1.html">http://www.schemacentral.com/sc/ooxml/e-a_p-1.html</a>
        /// </remarks>
        private static void AddTextParagraphsNode(this XmlNode textPropertiesNode, FontModel model)
        {
            var textParagraphsNode = ChartXmlHelper.CreateOrDefaultAndAppendElementToNode(textPropertiesNode, "a", "p");

            textParagraphsNode.AddTextParagraphPropertiesNode(model);
            textParagraphsNode.AddEndParagraphRunPropertiesNode();
        }
        #endregion

        #region [private] {static} (void) AddTextParagraphPropertiesNode(this XmlNode, FontModel): Adds a 'pPr' node (Text Paragraph Properties) to the node of type 'p' (Text Paragraphs) specified. Not supported in EPPlus library
        /// <summary>
        /// Adds a <c>pPr</c> node (Text Paragraph Properties) to the node of type <c>p</c> (Text Paragraphs) specified. Not supported in <c>EPPlus</c> library.
        /// </summary>
        /// <param name="node"><c>p</c> node (Text Paragraphs).</param>
        /// <param name="model">Font from model.</param>
        /// <remarks>
        /// For more information please see <a href="http://www.schemacentral.com/sc/ooxml/e-a_pPr-1.html">http://www.schemacentral.com/sc/ooxml/e-a_pPr-1.html</a>
        /// </remarks>
        private static void AddTextParagraphPropertiesNode(this XmlNode node, FontModel model)
        {
            var textParagraphPropertiesNode = ChartXmlHelper.CreateOrDefaultAndAppendElementToNode(node, "a", "pPr");
            textParagraphPropertiesNode.AddDefaultTextRunPropertiesNode(model);
        }
        #endregion

        #region [private] {static} (void) AddDefaultTextRunPropertiesNode(this XmlNode, FontModel): Adds a 'defRPr' node (Default Text Run Properties) to the node of type 'pPr' (Text Paragraph Properties) specified. Not supported in EPPlus library
        /// <summary>
        /// Adds a <c>defRPr</c> node (Default Text Run Properties) to the node of type <c>pPr</c> (Text Paragraph Properties) specified. Not supported in <c>EPPlus</c> library.
        /// </summary>
        /// <param name="node"><c>pPr</c> node (Text Paragraph Properties).</param>
        /// <param name="model">Font from model.</param>
        /// <remarks>
        /// For more information please see <a href="http://www.schemacentral.com/sc/ooxml/e-a_defRPr-1.html">http://www.schemacentral.com/sc/ooxml/e-a_defRPr-1.html</a>
        /// </remarks>
        private static void AddDefaultTextRunPropertiesNode(this XmlNode node, FontModel model)
        {
            var sizeAttr = ChartXmlHelper.CreateAttribute("sz");
            sizeAttr.Value = (model.Size * 100).ToString(CultureInfo.InvariantCulture);

            var boldAttr = ChartXmlHelper.CreateAttribute("b");
            boldAttr.Value = model.Bold == YesNo.Yes ? "1" : "0";

            var italicAttr = ChartXmlHelper.CreateAttribute("i");
            italicAttr.Value = model.Italic == YesNo.Yes ? "1" : "0";

            var underlineAttr = ChartXmlHelper.CreateAttribute("u");
            underlineAttr.Value = model.Underline == YesNo.Yes ? "sng" : "none";

            var defaultTextRunPropertiesNode = ChartXmlHelper.CreateOrDefaultAndAppendElementToNode(node, "a", "defRPr");
            defaultTextRunPropertiesNode.Attributes.Append(boldAttr);
            defaultTextRunPropertiesNode.Attributes.Append(sizeAttr);
            defaultTextRunPropertiesNode.Attributes.Append(italicAttr);
            defaultTextRunPropertiesNode.Attributes.Append(underlineAttr);

            defaultTextRunPropertiesNode.AddSolidFillNode(model.GetColor());
            defaultTextRunPropertiesNode.AddLatinFontNode(model.Name);
            defaultTextRunPropertiesNode.AddEastAsianFontNode(model.Name);
            defaultTextRunPropertiesNode.AddComplexScriptFontNode(model.Name);
        }
        #endregion

        #region [private] {static} (void) AddSolidFillNode(this XmlNode, Color): Adds a 'solidFill' node (Solid Fill Properties) to the node of type 'spPr' (Shape properties) specified. Not supported in EPPlus library
        /// <summary>
        /// Adds a <c>solidFill</c> node (Solid Fill Properties) to the node of type <c>spPr</c> (Shape properties) specified. Not supported in <c>EPPlus</c> library.
        /// </summary>
        /// <param name="shapePropertiesNode"><c>spPr</c> node (Shape Properties).</param>
        /// <param name="color">Fill color.</param>
        /// <remarks>
        /// For more information please see <a href="http://www.schemacentral.com/sc/ooxml/e-a_solidFill-1.html">http://www.schemacentral.com/sc/ooxml/e-a_solidFill-1.html</a>
        /// </remarks>
        private static void AddSolidFillNode(this XmlNode shapePropertiesNode, Color color)
        {
            var solidFillNode = ChartXmlHelper.CreateOrDefaultAndAppendElementToNode(shapePropertiesNode, "a", "solidFill");

            var valAttr = ChartXmlHelper.CreateAttribute("val");
            valAttr.Value = ColorHelper.ToHex(color).Replace("#", string.Empty);

            var srgbClrNode = ChartXmlHelper.CreateOrDefaultAndAppendElementToNode(solidFillNode, "a", "srgbClr");
            srgbClrNode.Attributes.Append(valAttr);
        }
        #endregion

        #region [private] {static} (void) AddLatinFontNode(this XmlNode, string): Adds a 'latin' node (Latin Font) to the node of type 'defRPr' (Default Text Run Properties) specified. Not supported in EPPlus library
        /// <summary>
        /// Adds a <c>latin</c> node (Latin Font) to the node of type <c>defRPr</c> (Default Text Run Properties) specified. Not supported in <c>EPPlus</c> library.
        /// </summary>
        /// <param name="node"><c>defRPr</c> node (Shape Properties).</param>
        /// <param name="fontname">Font name.</param>
        /// <remarks>
        /// For more information please see <a href="http://www.schemacentral.com/sc/ooxml/e-a_latin-1.html">http://www.schemacentral.com/sc/ooxml/e-a_latin-1.html</a>
        /// </remarks>
        private static void AddLatinFontNode(this XmlNode node, string fontname)
        {
            var typefaceAttr = ChartXmlHelper.CreateAttribute("typeface");
            typefaceAttr.Value = fontname;

            var latinFontNode = ChartXmlHelper.CreateOrDefaultAndAppendElementToNode(node, "a", "latin");
            latinFontNode.Attributes.Append(typefaceAttr);
        }
        #endregion

        #region [private] {static} (void) AddEastAsianFontNode(this XmlNode, string): Adds a 'ea' node (East Asian Font) to the node of type 'defRPr' (Default Text Run Properties) specified. Not supported in EPPlus library
        /// <summary>
        /// Adds a <c>ea</c> node (East Asian Font) to the node of type <c>defRPr</c> (Default Text Run Properties) specified. Not supported in <c>EPPlus</c> library.
        /// </summary>
        /// <param name="node"><c>defRPr</c> node (Shape Properties).</param>
        /// <param name="fontname">Font name.</param>
        /// <remarks>
        /// For more information please see <a href="http://www.schemacentral.com/sc/ooxml/e-a_ea-1.html">http://www.schemacentral.com/sc/ooxml/e-a_ea-1.html</a>
        /// </remarks>
        private static void AddEastAsianFontNode(this XmlNode node, string fontname)
        {
            var typefaceAttr = ChartXmlHelper.CreateAttribute("typeface");
            typefaceAttr.Value = fontname;

            var eastAsianFontNode = ChartXmlHelper.CreateOrDefaultAndAppendElementToNode(node, "a", "ea");
            eastAsianFontNode.Attributes.Append(typefaceAttr);
        }
        #endregion

        #region [private] {static} (void) AddComplexScriptFontNode(this XmlNode, string): Adds a 'cs' node (Complex Script Font) to the node of type 'defRPr' (Default Text Run Properties) specified. Not supported in EPPlus library
        /// <summary>
        /// Adds a <c>cs</c> node (Complex Script Font) to the node of type <c>defRPr</c> (Default Text Run Properties) specified. Not supported in <c>EPPlus</c> library.
        /// </summary>
        /// <param name="node"><c>defRPr</c> node (Shape Properties).</param>
        /// <param name="fontname">Font name.</param>
        /// <remarks>
        /// For more information please see <a href="http://www.schemacentral.com/sc/ooxml/e-a_cs-1.html">http://www.schemacentral.com/sc/ooxml/e-a_cs-1.html</a>
        /// </remarks>
        private static void AddComplexScriptFontNode(this XmlNode node, string fontname)
        {
            var typefaceAttr = ChartXmlHelper.CreateAttribute("typeface");
            typefaceAttr.Value = fontname;

            var complexScriptFontNode = ChartXmlHelper.CreateOrDefaultAndAppendElementToNode(node, "a", "cs");
            complexScriptFontNode.Attributes.Append(typefaceAttr);
        }
        #endregion

        #region [private] {static} (void) AddEndParagraphRunPropertiesNode(this XmlNode, XmlDocument): Adds a 'endParaRPr' node (End Paragraph Run Properties) to the node of type 'p' (Text Paragraphs) specified. Not supported in EPPlus library
        /// <summary>
        /// Adds a <c>endParaRPr</c> node (End Paragraph Run Properties) to the node of type <c>p</c> (Text Paragraphs) specified. Not supported in <c>EPPlus</c> library.
        /// </summary>
        /// <param name="textParagraphsNode"><c>p</c> node (Text Paragraphs).</param>
        /// <remarks>
        /// For more information please see <a href="http://www.schemacentral.com/sc/ooxml/e-a_endParaRPr-1.html">http://www.schemacentral.com/sc/ooxml/e-a_endParaRPr-1.html</a>
        /// </remarks>
        private static void AddEndParagraphRunPropertiesNode(this XmlNode textParagraphsNode)
        {
            var langAttr = ChartXmlHelper.CreateAttribute("lang");
            langAttr.Value = CultureInfo.CurrentCulture.Name;

            var endParagraphRunPropertiesNode = ChartXmlHelper.CreateOrDefaultAndAppendElementToNode(textParagraphsNode, "a", "endParaRPr");
            endParagraphRunPropertiesNode.Attributes.Append(langAttr);
        }
        #endregion

        #region [private] {static} (void) AddOuterShadowNode(this XmlNode): Adds a 'outerShdw' node (Outer Shadow) to the node of type 'effectLst' (Effect Container) specified. Not supported in EPPlus library
        /// <summary>
        /// Adds a <c>outerShdw</c> node (Outer Shadow) to the node of type <c>effectLst</c> (Effect Container) specified. Not supported in <c>EPPlus</c> library.
        /// </summary>
        /// <param name="effectContainerNode"><c>effectLst</c> node (Effect Container).</param>
        /// <param name="model">Shadow from model.</param>
        /// <remarks>
        /// For more information please see <a href="http://www.schemacentral.com/sc/ooxml/e-a_outerShdw-2.html">http://www.schemacentral.com/sc/ooxml/e-a_outerShdw-2.html</a>
        /// </remarks>
        private static void AddOuterShadowNode(this XmlNode effectContainerNode, ShadowModel model)
        {
            var blurRadAttr = ChartXmlHelper.CreateAttribute("blurRad");
            blurRadAttr.Value = "63500";

            var distAttr = ChartXmlHelper.CreateAttribute("dist");
            distAttr.Value = "71842";

            var dirAttr = ChartXmlHelper.CreateAttribute("dir");
            dirAttr.Value = "2700013";

            var rotWithShapeAttr = ChartXmlHelper.CreateAttribute("rotWithShape");
            rotWithShapeAttr.Value = "0";

            var outerShadowNode = ChartXmlHelper.CreateOrDefaultAndAppendElementToNode(effectContainerNode, "a", "outerShdw");
            outerShadowNode.Attributes.Append(blurRadAttr);
            outerShadowNode.Attributes.Append(distAttr);
            outerShadowNode.Attributes.Append(dirAttr);
            outerShadowNode.Attributes.Append(rotWithShapeAttr);

            outerShadowNode.AddRgbColorModelPercentageVariantNode(model);
        }
        #endregion

        #region [private] {static} (void) AddRgbColorModelPercentageVariantNode(this XmlNode): Adds a 'scrgbClr' node (Rgb Color Model Percentage Variant) to the node of type 'outerShdw' (Outer Shadow) specified. Not supported in EPPlus library
        /// <summary>
        /// Adds a <c>scrgbClr</c> node (Rgb Color Model Percentage Variant) to the node of type <c>outerShdw</c> (Outer Shadow) specified. Not supported in <c>EPPlus</c> library.
        /// </summary>
        /// <param name="outerShadowNode"><c>outerShdw</c> node (Outer Shadow).</param>
        /// <param name="model">Shadow from model.</param>
        /// <remarks>
        /// For more information please see <a href="http://www.schemacentral.com/sc/ooxml/e-a_scrgbClr-1.html">http://www.schemacentral.com/sc/ooxml/e-a_scrgbClr-1.html</a>
        /// </remarks>
        private static void AddRgbColorModelPercentageVariantNode(this XmlNode outerShadowNode, ShadowModel model)
        {
            var redRadAttr = ChartXmlHelper.CreateAttribute("r");
            redRadAttr.Value = "0";

            var greenAttr = ChartXmlHelper.CreateAttribute("g");
            greenAttr.Value = "0";

            var blueAttr = ChartXmlHelper.CreateAttribute("b");
            blueAttr.Value = "0";

            var rgbColorModelPercentageVariantNode = ChartXmlHelper.CreateOrDefaultAndAppendElementToNode(outerShadowNode, "a", "scrgbClr");
            rgbColorModelPercentageVariantNode.Attributes.Append(redRadAttr);
            rgbColorModelPercentageVariantNode.Attributes.Append(greenAttr);
            rgbColorModelPercentageVariantNode.Attributes.Append(blueAttr);

            var valAttr = ChartXmlHelper.CreateAttribute("val");
            valAttr.Value = (model.Transparency * 100000).ToString(CultureInfo.InvariantCulture);

            var alphaNode = ChartXmlHelper.CreateOrDefaultAndAppendElementToNode(rgbColorModelPercentageVariantNode, "a", "alpha");
            alphaNode.Attributes.Append(valAttr);
        }
        #endregion

        #endregion
    }
}
