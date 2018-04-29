
using iTin.Export.Helpers;

namespace OfficeOpenXml.Utils.iTin
{
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Xml;

    using Drawing.Chart;

    /// <summary>
    /// Static class that contains methods for manipulating <see cref="OfficeOpenXml.Drawing.Chart"/> as XML document.
    /// </summary>
    static class ChartXmlHelper
    {
        #region public constants
        /// <summary>
        /// A <see cref="System.String"/> than represents path to root element of list of charts.
        /// </summary>
        public const string ChartSpaceRootNode = "c:chartSpace";

        /// <summary>
        /// A <see cref="System.String"/> than represents path to root element of Chart.
        /// </summary>
        public const string ChartRootNode = "c:chartSpace/c:chart";

        /// <summary>
        /// A <see cref="System.String"/> than represents path to chart legend element of Chart.
        /// </summary>
        public const string ChartLegendRootNode = "c:chartSpace/c:chart/c:legend";

        /// <summary>
        /// A <see cref="System.String"/> than represents path to chart title element of Chart.
        /// </summary>
        public const string ChartTitleRootNode = "c:chartSpace/c:chart/c:title";
        
        /// <summary>
        /// A <see cref="System.String"/> than represents path to plot chart element of Chart.
        /// </summary>
        public const string ChartPlotAreaRootNode = "c:chartSpace/c:chart/c:plotArea";
        
        /// <summary>
        /// A <see cref="System.String"/> than represents path to area chart element of Chart.
        /// </summary>
        public const string ChartPlotAreaChartAreaRootNode = "c:chartSpace/c:chart/c:plotArea/c:areaChart";
        
        /// <summary>
        /// A <see cref="System.String"/> than represents main namespace.
        /// </summary>
        public const string MainDrawingmlNamespace = "http://schemas.openxmlformats.org/drawingml/2006/main";
        
        /// <summary>
        /// A <see cref="System.String"/> than represents chart namespace.
        /// </summary>
        public const string ChartDrawingmlNamespace = "http://schemas.openxmlformats.org/drawingml/2006/chart";
        #endregion

        #region private static fields
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static XmlNamespaceManager _manager;
        #endregion

        #region public static properties

        #region [public] {static} (XmlDocument) ChartXml: Gets or sets the chart XML from an EPPlus document
        /// <summary>
        /// Gets or sets the chart XML from an <c>EPPlus</c> document.
        /// </summary>
        /// <value>
        /// <see cref="System.Xml.XmlDocument" /> reference that contains the chart branch <c>Xml</c> of a EPPlus document.
        /// </value>
        public static XmlDocument ChartXml { private get; set; }
        #endregion

        #endregion

        #region private static properties

        #region [private] {static} (XmlNamespaceManager) NamespaceManager: Gets a reference to the namespace manager for this <c>Xml</c> document
        /// <summary>
        /// Gets a reference to the namespace manager for this <c>Xml</c> document.
        /// </summary>
        /// <value>
        /// <see cref="System.Xml.XmlNamespaceManager" /> reference that contains the namespace list.
        /// </value>
        private static XmlNamespaceManager NamespaceManager
        {
            get
            {
                if (_manager != null)
                {
                    return _manager;
                }

                _manager = new XmlNamespaceManager(ChartXml.NameTable);
                _manager.AddNamespace("a", MainDrawingmlNamespace);
                _manager.AddNamespace("c", ChartDrawingmlNamespace);

                return _manager;
            }
        }
        #endregion

        #endregion

        #region public static methods

        #region [public] {static} (XmlAttribute) CreateAttribute(string): Create a new attribute for this document
        /// <summary>
        /// Create a new attribute for this document.
        /// </summary>
        /// <param name="name">Attribute name.</param>
        /// <returns>
        /// <see cref="System.Xml.XmlAttribute" /> reference that contains a new attribute.
        /// </returns>
        public static XmlAttribute CreateAttribute(string name)
        {
            return ChartXml.CreateAttribute(name);
        }
        #endregion

        #region [public] {static} (XmlElement) CreateElement(string, string): Creates an element with the specified Prefix, and LocalName
        /// <summary>
        /// Creates an element with the specified Prefix, and LocalName.
        /// </summary>
        /// <param name="prefix">The prefix of the new element.</param>
        /// <param name="localName">The local name of the new element.</param>
        /// <returns>
        /// The new <see cref="System.Xml.XmlElement" />.
        /// </returns>
        public static XmlElement CreateElement(string prefix, string localName)
        {
            return CreateElement(prefix, localName, NamespaceManager.LookupNamespace(prefix));
        }
        #endregion

        #region [public] {static} (XmlElement) CreateElement(string, string, string): Creates an element with the specified Prefix, LocalName, and NamespaceURI
        /// <summary>
        /// Creates an element with the specified Prefix, LocalName, and NamespaceURI.
        /// </summary>
        /// <param name="prefix">The prefix of the new element.</param>
        /// <param name="localName">The local name of the new element.</param>
        /// <param name="namespaceUri">The namespace URI of the new element.</param>
        /// <returns>
        /// The new <see cref="System.Xml.XmlElement" />.
        /// </returns>
        /// <exception cref="T:System.InvalidOperationException">If <paramref name="prefix" /> is empty.</exception>
        /// <exception cref="T:System.InvalidOperationException">If <paramref name="prefix" /> length is less than 1.</exception>
        /// <exception cref="T:System.InvalidOperationException">If <paramref name="localName" /> is empty.</exception>
        /// <exception cref="T:System.InvalidOperationException">If <paramref name="localName" /> length is less than 1.</exception>
        /// <exception cref="T:System.InvalidOperationException">If <paramref name="namespaceUri" /> is empty.</exception>
        /// <exception cref="T:System.InvalidOperationException">If <paramref name="namespaceUri" /> length is less than 1.</exception>
        public static XmlElement CreateElement(string prefix, string localName, string namespaceUri)
        {
            SentinelHelper.IsTrue(string.IsNullOrEmpty(prefix), "No puede estar vacio");
            SentinelHelper.IsTrue(prefix.Length < 1, "La longitud minima ha de ser 1");

            SentinelHelper.IsTrue(string.IsNullOrEmpty(localName), "No puede estar vacio");
            SentinelHelper.IsTrue(localName.Length < 1, "La longitud minima ha de ser 1");

            SentinelHelper.IsTrue(string.IsNullOrEmpty(namespaceUri), "No puede estar vacio");
            SentinelHelper.IsTrue(namespaceUri.Length < 1, "La longitud minima ha de ser 1");

            return ChartXml.CreateElement(prefix, localName, namespaceUri);
        }
        #endregion

        #region [public] {static} (XmlNode) CreateOrDefaultAndAppendElementToNode(string): Create or return an element with the specified name, and adds it to the document root node
        /// <summary>
        /// Create or return an element with the specified name, and adds it to the document root node.
        /// </summary>
        /// <param name="name">The name of the new element.</param>
        /// <returns>
        /// Return if it already exists, else it is created and added to the root node.
        /// </returns>
        /// <exception cref="T:System.InvalidOperationException">If <paramref name="name" /> is empty.</exception>
        /// <exception cref="T:System.InvalidOperationException">If <paramref name="name" /> length is less than 1.</exception>
        public static XmlNode CreateOrDefaultAndAppendElementToNode(string name)
        {
            return CreateOrDefaultAndAppendElementToNode((XmlNode)null, name);
        }
        #endregion

        #region [public] {static} (XmlNode) CreateOrDefaultAndAppendElementToNode(string, string): Create or return an element with the specified Prefix and LocalName, and adds it to the document root node
        /// <summary>
        /// Create or return an element with the specified Prefix and LocalName, and adds it to the document root node.
        /// </summary>
        /// <param name="prefix">The prefix of the new element.</param>
        /// <param name="localName">The local name of the new element.</param>
        /// <returns>
        /// Return if it already exists, else it is created and added to the root node.
        /// </returns>
        public static XmlNode CreateOrDefaultAndAppendElementToNode(string prefix, string localName)
        {                
            return CreateOrDefaultAndAppendElementToNode(prefix, localName, NamespaceManager.LookupNamespace(prefix));
        }
        #endregion

        #region [public] {static} (XmlNode) CreateOrDefaultAndAppendElementToNode(string, string, string): Create or return an element with the specified Prefix, LocalName and NamespaceUri, and adds it to the document root node
        /// <summary>
        /// Create or return an element with the specified Prefix, LocalName and NamespaceUri, and adds it to the document root node.
        /// </summary>
        /// <param name="prefix">The prefix of the new element.</param>
        /// <param name="localName">The local name of the new element.</param>
        /// <param name="namespaceUri">The namespace URI of the new element.</param>
        /// <returns>
        /// The new <see cref="System.Xml.XmlNode" />.
        /// </returns>
        public static XmlNode CreateOrDefaultAndAppendElementToNode(string prefix, string localName, string namespaceUri)
        {
            return CreateOrDefaultAndAppendElementToNode(null, prefix, localName, namespaceUri);
        }
        #endregion

        #region [public] {static} (XmlNode) CreateOrDefaultAndAppendElementToNode(XmlNode, string): Create or return an element with the specified name, and adds it to the document in the specified node
        /// <summary>
        /// Create or return an element with the specified name, and adds it to the document in the specified node.
        /// </summary>
        /// <param name="root">The root node of new element.</param>
        /// <param name="name">The name of the new element.</param>
        /// <returns>
        /// Return if it already exists, else it is created and added to the specified node.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">If <paramref name="root" /> is <c>null</c>.</exception>
        /// <exception cref="T:System.InvalidOperationException">If <paramref name="name" /> is empty.</exception>
        /// <exception cref="T:System.InvalidOperationException">If <paramref name="name" /> length is less than 3.</exception>
        /// <exception cref="T:System.InvalidOperationException">If <paramref name="name" /> contains white spaces.</exception>
        /// <exception cref="T:System.InvalidOperationException">If <paramref name="name" /> has not correct format.</exception>
        public static XmlNode CreateOrDefaultAndAppendElementToNode(XmlNode root, string name)
        {
            SentinelHelper.ArgumentNull(root);
            SentinelHelper.IsTrue(name.Length <= 3, "El parametro element debe contener al menos tres caracteres");
            SentinelHelper.IsTrue(string.IsNullOrEmpty(name), "El parametro element no puede estar en blanco");
            SentinelHelper.IsFalse(name.Contains(":"), "El formato no es correcto. Se esperaba prefijo:localname");
            SentinelHelper.IsTrue(name.Contains(" "), "El formato no es correcto. No se permiten espacios en el elemento");

            var piece = name.Split(':');
            var prefix = piece[0];
            var localName = piece[1];

            return CreateOrDefaultAndAppendElementToNode(root, prefix, localName, NamespaceManager.LookupNamespace(prefix));
        }
        #endregion

        #region [public] {static} (XmlNode) CreateOrDefaultAndAppendElementToNode(XmlNode, string, string): Create or return an element with the specified Prefix and LocalName, and adds it to the document in the specified node
        /// <summary>
        /// Create or return an element with the specified Prefix and LocalName, and adds it to the document in the specified node.
        /// </summary>
        /// <param name="root">The root node of new element.</param>
        /// <param name="prefix">The prefix of the new element.</param>
        /// <param name="localName">The local name of the new element.</param>
        /// <returns>
        /// Return if it already exists, else it is created and added to the specified node.
        /// </returns>
        public static XmlNode CreateOrDefaultAndAppendElementToNode(XmlNode root, string prefix, string localName)
        {
            return CreateOrDefaultAndAppendElementToNode(root, prefix, localName, NamespaceManager.LookupNamespace(prefix));
        }
        #endregion

        #region [public] {static} (XmlNode) CreateOrDefaultAndAppendElementToNode(XmlNode, string, string, string): Create or return an element with the specified Prefix, LocalName and NamespaceUri, and adds it to the document in the specified node
        /// <summary>
        /// Create or return an element with the specified Prefix, LocalName and NamespaceUri, and adds it to the document in the specified node.
        /// </summary>
        /// <param name="root">The root node of new element.</param>
        /// <param name="prefix">The prefix of the new element.</param>
        /// <param name="localName">The local name of the new element.</param>
        /// <param name="namespaceUri">The namespace URI of the new element.</param>
        /// <returns>
        /// The new <see cref="System.Xml.XmlNode" />.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">If <paramref name="root" /> is <c>null</c>.</exception>
        /// <exception cref="T:System.InvalidOperationException">If <paramref name="prefix" /> is empty.</exception>
        /// <exception cref="T:System.InvalidOperationException">If <paramref name="prefix" /> length is less than 1.</exception>
        /// <exception cref="T:System.InvalidOperationException">If <paramref name="localName" /> is empty.</exception>
        /// <exception cref="T:System.InvalidOperationException">If <paramref name="localName" /> length is less than 1.</exception>
        /// <exception cref="T:System.InvalidOperationException">If <paramref name="namespaceUri" /> is empty.</exception>
        /// <exception cref="T:System.InvalidOperationException">If <paramref name="namespaceUri" /> length is less than 1.</exception>
        public static XmlNode CreateOrDefaultAndAppendElementToNode(XmlNode root, string prefix, string localName, string namespaceUri)
        {
            SentinelHelper.ArgumentNull(root);

            SentinelHelper.IsTrue(string.IsNullOrEmpty(prefix), "No puede estar vacio");
            SentinelHelper.IsTrue(prefix.Length < 1, "La longitud minima ha de ser 1");

            SentinelHelper.IsTrue(string.IsNullOrEmpty(localName), "No puede estar vacio");
            SentinelHelper.IsTrue(localName.Length < 1, "La longitud minima ha de ser 1");

            SentinelHelper.IsTrue(string.IsNullOrEmpty(namespaceUri), "No puede estar vacio");
            SentinelHelper.IsTrue(namespaceUri.Length < 1, "La longitud minima ha de ser 1");

            var element = new StringBuilder();
            element.Append(prefix);
            element.Append(":");
            element.Append(localName);

            var exist = HasElement(root, element.ToString());
            var tempNode = exist ? 
                GetXmlNode(root, element.ToString()) : 
                CreateElement(prefix, localName, namespaceUri);

            if (root == null)
            {
                ChartXml.AppendChild(tempNode);
            }
            else
            {
                root.AppendChild(tempNode);
            }

            return tempNode;
        }
        #endregion

        #region [public] {static} (XmlNode) FromKnownChartElement(KnownChartElement): Returns a value than represents a known node
        /// <summary>
        /// Returns a value than represents a known node.
        /// </summary>
        /// <param name="element">A <see cref="KnownChartElement" /> value.</param>
        /// <returns>
        /// <see cref="System.Xml.XmlNode" /> reference that contains <c>Xml</c> node.
        /// </returns>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>
        public static XmlNode FromKnownChartElement(KnownChartElement element)
        {
            SentinelHelper.IsEnumValid(element);

            XmlNode knownRootNode = null;
            switch (element)
            {
                case KnownChartElement.Self:
                    knownRootNode = GetXmlNode(ChartSpaceRootNode);
                    break;

                case KnownChartElement.Legend:
                    knownRootNode = GetXmlNode(ChartLegendRootNode);
                    break;

                case KnownChartElement.PlotArea:
                    knownRootNode = GetXmlNode(ChartPlotAreaRootNode);
                    break;

                case KnownChartElement.ChartTitle:
                    knownRootNode = GetXmlNode(ChartTitleRootNode);
                    break;

                case KnownChartElement.PrimaryCategoryAxis:
                    knownRootNode = GetElementsByTagName("c:catAx").ToList()[0];
                    break;

                case KnownChartElement.PrimaryValueAxis:
                    knownRootNode = GetElementsByTagName("c:valAx").ToList()[0];
                    break;

                case KnownChartElement.SecondaryCategoryAxis:
                    var catAxisXmlList = GetElementsByTagName("c:catAx").ToList();

                    SentinelHelper.IsTrue(catAxisXmlList.Count <= 1, "Error no hay eje secundario");
                    knownRootNode = catAxisXmlList[1];
                    break;

                case KnownChartElement.SecondaryValueAxis:
                    var valAxisXmlList = GetElementsByTagName("c:valAx").ToList();

                    SentinelHelper.IsTrue(valAxisXmlList.Count <= 1, "Error no hay eje secundario");
                    knownRootNode = valAxisXmlList[1];
                    break;

                case KnownChartElement.PrimaryCategoryAxisTitle:
                    knownRootNode = GetXmlNode(GetElementsByTagName("c:catAx").ToList()[0], "c:title");
                    break;

                case KnownChartElement.PrimaryValueAxisTitle:
                    knownRootNode = GetXmlNode(GetElementsByTagName("c:valAx").ToList()[0], "c:title");
                    break;

                case KnownChartElement.SecondaryCategoryAxisTitle:
                    var catAxisXmlList1 = GetElementsByTagName("c:catAx").ToList();

                    SentinelHelper.IsTrue(catAxisXmlList1.Count <= 1, "Error no hay eje secundario");
                    knownRootNode = GetXmlNode(catAxisXmlList1[1], "c:title");
                    break;

                case KnownChartElement.SecondaryValueAxisTitle:
                    var valAxisXmlList2 = GetElementsByTagName("c:valAx").ToList();

                    SentinelHelper.IsTrue(valAxisXmlList2.Count <= 1, "Error no hay eje secundario");
                    knownRootNode = GetXmlNode(valAxisXmlList2[1], "c:title");
                    break;
            }

            return knownRootNode;
        }
        #endregion

        #region [public] {static} (IEnumerable<XmlNode>) GetElementsByTagName(string): Returns an reference than containing a list of all descendant elements that match the specified name
        /// <summary>
        /// Returns an reference than containing a list of all descendant elements that match the specified name.
        /// </summary>
        /// <param name="name">The qualified name to match. It is matched against the <c>Name</c> property of the matching node. The special value "*" matches all tags.</param>
        /// <returns>
        /// A list of all matching nodes. If no nodes match name, the returned collection will be empty.
        /// </returns>
        public static IEnumerable<XmlNode> GetElementsByTagName(string name)
        {
            return ChartXml.GetElementsByTagName(name).Cast<XmlNode>().ToList();
        }
        #endregion

        #region [public] {static} (XmlNode) GetXmlNode(string): Selects the first XmlNode that matches the XPath expression in root node
        /// <summary>
        /// Selects the first <see cref="T:System.Xml.XmlNode"/> that matches the XPath expression in root node.
        /// </summary>
        /// <param name="path">XPath expression.</param>
        /// <returns>
        /// The first <see cref="T:System.Xml.XmlNode"/> that matches the XPath query or <c>null</c> if no matching node is found.
        /// </returns>
        public static XmlNode GetXmlNode(string path)
        {
            return GetXmlNode(null, path);
        }
        #endregion

        #region [public] {static} (XmlNode) GetXmlNode(XmlNode, string): Selects the first XmlNode that matches the XPath expression in the specified node
        /// <summary>
        /// Selects the first <see cref="T:System.Xml.XmlNode"/> that matches the XPath expression in the specified node.
        /// </summary>
        /// <param name="root">The root node.</param>
        /// <param name="path">XPath expression.</param>
        /// <returns>
        /// The first <see cref="T:System.Xml.XmlNode"/> that matches the XPath query or <c>null</c> if no matching node is found.
        /// </returns>
        public static XmlNode GetXmlNode(XmlNode root, string path)
        {
            return root == null ? 
                ChartXml.SelectSingleNode(path, NamespaceManager) : 
                root.SelectSingleNode(path, NamespaceManager);
        }
        #endregion

        #region [public] {static} (bool) HasElement(string): Determines whether the specified element exist in the root node
        /// <summary>
        /// Determines whether the specified element exist in the root node.
        /// </summary>
        /// <param name="name">The element name.</param>
        /// <returns>
        /// <c>true</c> if exist; otherwise, <c>false</c>.
        /// </returns>
        public static bool HasElement(string name)
        {
            return HasElement(null, name);
        }
        #endregion

        #region [public] {static} (bool) HasElement(XmlNode, string): Determines whether the specified element exist in the specified node
        /// <summary>
        /// Determines whether the specified element exist in the specified node.
        /// </summary>
        /// <param name="root">The root node.</param>
        /// <param name="name">The element name.</param>
        /// <returns>
        /// <c>true</c> if exist; otherwise, <c>false</c>.
        /// </returns>
        public static bool HasElement(XmlNode root, string name)
        {
            var xmlNodeTemp = root == null ?
                GetXmlNode(ChartXml, name) :
                GetXmlNode(root, name);

            return xmlNodeTemp != null;
        }
        #endregion

        #region [public] {static} (bool) TryGetElementFrom(XmlNode, string, out XmlNode): Try to get the item in the specified node if exist is returned in the parameter node, otherwise will contain null, if the operation is performed returns true
        /// <summary>
        /// Try to get the item in the specified node if exist is returned in the parameter <paramref name="node"/>, otherwise will contain <c>null</c>, if the operation is performed returns <c>true</c>.
        /// </summary>
        /// <param name="root">The root node of new element.</param>
        /// <param name="name">The element name.</param>
        /// <param name="node">The output node.</param>
        /// <returns>
        /// <c>true</c> if exist; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">If <paramref name="root" /> is <c>null</c>.</exception>
        /// <exception cref="T:System.InvalidOperationException">If <paramref name="name" /> is empty.</exception>
        /// <exception cref="T:System.InvalidOperationException">If <paramref name="name" /> length is less than 3.</exception>
        /// <exception cref="T:System.InvalidOperationException">If <paramref name="name" /> contains white spaces.</exception>
        /// <exception cref="T:System.InvalidOperationException">If <paramref name="name" /> has not correct format.</exception>
        public static bool TryGetElementFrom(XmlNode root, string name, out XmlNode node)
        {
            SentinelHelper.ArgumentNull(root);
            SentinelHelper.IsTrue(name.Length <= 3, "El parametro element debe contener al menos tres caracteres");
            SentinelHelper.IsTrue(string.IsNullOrEmpty(name), "El parametro element no puede estar en blanco");
            SentinelHelper.IsFalse(name.Contains(":"), "El formato no es correcto. Se esperaba prefijo:localname");
            SentinelHelper.IsTrue(name.Contains(" "), "El formato no es correcto. No se permiten espacios en el elemento");

            var exist = HasElement(root, name);
            if (exist)
            {
                node = GetXmlNode(root, name);
            }
            else
            {
                var piece = name.Split(':');
                var prefix = piece[0];
                var localName = piece[1];

                node = CreateElement(prefix, localName);
            }

            return exist;
        }
        #endregion

        #endregion
    }
}
