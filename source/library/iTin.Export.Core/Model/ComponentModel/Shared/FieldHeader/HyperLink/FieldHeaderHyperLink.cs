
namespace iTin.Export.Model
{
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    using Helpers;

    public partial class FieldHeaderHyperLink
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo DefaultShow = YesNo.No;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string DefaultStyle = "Current";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string DefaultTooltip = "FieldAlias";
        #endregion

        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private YesNo _show;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _style;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _tooltip;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private FieldHeaderModel _parent;
        #endregion

        #region constructor/s

        #region [public] FieldHeaderHyperLink(): Initializes a new instance of this class
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.FieldHeaderHyperLink" /> class.
        /// </summary>
        public FieldHeaderHyperLink()
        {
            Show = DefaultShow;
            Style = DefaultStyle;
            Tooltip = DefaultTooltip;
        }
        #endregion

        #endregion

        #region public properties

        [XmlElement("Web", typeof(WebHyperLink))]
        //[XmlElement("File", typeof(WriterModel))]
        //[XmlElement("Location", typeof(XsltModel))]
        public object Current { get; set; }

        #region [public] (YesNo) Show: Gets or sets a value that determines whether displays hyperlink
        [XmlAttribute]
        [DefaultValue(DefaultTooltip)]
        public string Tooltip
        {
            get => _tooltip;
            set => _tooltip = value;
        }
        #endregion

        #region [public] (FieldHeaderModel) Parent: Gets the parent element of the element
        /// <summary>
        /// Gets the parent element of the element.
        /// </summary>
        /// <value>
        /// The element that represents the container element of the element.
        /// </value>
        [Browsable(false)]
        public FieldHeaderModel Parent => _parent;
        #endregion

        #region [public] (YesNo) Show: Gets or sets a value that determines whether displays hyperlink
        /// <summary>
        /// Gets or sets a value that determines whether displays hyperlink. The default is <see cref="YesNo.No"/>.
        /// </summary>
        /// <value>
        /// <see cref="iTin.Export.Model.YesNo.Yes" /> if the item is displayed; otherwise, <strong><see cref="iTin.Export.Model.YesNo.No"/></strong>. The default is <see cref="iTin.Export.Model.YesNo.No" />.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Hyperlink Show="Yes|No" ...&gt;
        /// ...
        /// &lt;/Header&gt;
        /// </code>
        /// <para>
        /// <para><strong>Compatibility table with native writers.</strong></para>
        /// <table>
        ///   <thead>
        ///     <tr>
        ///       <th>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.CsvWriter" /></th>
        ///       <th>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.TsvWriter" /></th>
        ///       <th>SQL Script<br/><see cref="T:iTin.Export.Writers.SqlScriptWriter" /></th>
        ///       <th>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Spreadsheet2003TabularWriter" /></th>
        ///     </tr>
        ///   </thead>
        ///   <tbody>
        ///     <tr>
        ///       <td align="center">X</td>
        ///       <td align="center">X</td>
        ///       <td align="center">X</td>
        ///       <td align="center">X</td>
        ///     </tr>
        ///   </tbody>
        /// </table>
        /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
        /// </para>
        /// </remarks>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>
        [XmlAttribute]
        [DefaultValue(DefaultShow)]
        public YesNo Show
        {
            get => GetStaticBindingValue(_show.ToString()).ToUpperInvariant() == "NO" ? YesNo.No : YesNo.Yes;
            set
            {
                SentinelHelper.IsEnumValid(value);

                _show = value;
            }
        }
        #endregion

        #region [public] (string) Style: Gets or sets one of the styles defined in the element styles
        /// <summary>
        /// Gets or sets one of the styles defined in the element styles.
        /// </summary>
        /// <value>
        /// Name of a style defined in the list of styles.
        /// Are only allow strings made ​​up of letters, numbers and following special chars <strong>'<c>_ - # @ % $</c>'</strong>.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Header Style="string" ...&gt;
        /// ...
        /// &lt;/Header&gt;
        /// </code>
        /// <para>
        /// <para><strong>Compatibility table with native writers.</strong></para>
        /// <table>
        ///   <thead>
        ///     <tr>
        ///       <th>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.CsvWriter" /></th>
        ///       <th>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.TsvWriter" /></th>
        ///       <th>SQL Script<br/><see cref="T:iTin.Export.Writers.SqlScriptWriter" /></th>
        ///       <th>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Spreadsheet2003TabularWriter" /></th>
        ///     </tr>
        ///   </thead>
        ///   <tbody>
        ///     <tr>
        ///       <td align="center">X</td>
        ///       <td align="center">X</td>
        ///       <td align="center">X</td>
        ///       <td align="center">X</td>
        ///     </tr>
        ///   </tbody>
        /// </table>
        /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
        /// </para>
        /// </remarks>
        /// <exception cref="T:System.ArgumentNullException">If <paramref name="value" /> is <strong>null</strong>.</exception>
        /// <exception cref="T:iTin.Export.Model.InvalidIdentifierNameException"><paramref name="value" /> not is a valid identifier name.</exception>
        [XmlAttribute]
        [DefaultValue(DefaultStyle)]
        public string Style
        {
            get => GetStaticBindingValue(_style);
            set
            {
                SentinelHelper.ArgumentNull(value);

                var isBinded = RegularExpressionHelper.IsStaticBindingResource(value);
                if (!isBinded)
                {
                    SentinelHelper.IsFalse(RegularExpressionHelper.IsValidIdentifier(value), new InvalidFieldIdentifierNameException(ErrorMessageHelper.ModelIdentifierNameErrorMessage("Header", "Style", value)));
                }

                _style = value;                    
            }
        }
        #endregion

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default
        /// <inheritdoc />
        /// <summary>
        /// Gets a value indicating whether this instance is default.
        /// </summary>
        /// <value>
        /// <strong>true</strong> if this instance contains the default; otherwise, <strong>false</strong>.
        /// </value>
        public override bool IsDefault => Show.Equals(DefaultShow) && Style.Equals(DefaultStyle);
        #endregion

        #endregion

        #region public methods

        #region [public] (bool) CheckStyleName(): Performs a test for check if there this name of the style into the user-defined styles list
        /// <summary>
        /// Performs a test for check if there this name of the style into the user-defined styles list.
        /// </summary>
        /// <returns>
        /// <strong>true</strong> if exist; otherwise, <strong>false</strong>.
        /// </returns>
        public bool CheckStyleName()
        {
            return Style.Equals(DefaultStyle) || Parent.Parent.Owner.Parent.Parent.Owner.Resources.Styles.Contains(Style);
        }
        #endregion

        #region [public] (StyleModel) GetStyle(): Gets a reference to the style
        /// <summary>
        /// Gets a reference to the <see cref="T:iTin.Export.Model.StyleModel" /> from global resources.
        /// </summary>
        /// <returns>
        /// <strong>true</strong> if returns the style from resource; otherwise, <strong>false</strong>.
        /// </returns>
        public StyleModel GetStyle()
        {
            var hasStyle = TryGetStyle(out var tempStyle);

            return hasStyle ? tempStyle : StyleModel.Default;
        }
        #endregion

        #region [public] (bool) TryGetResourceInformation(out StyleModel): Gets a reference to the image resource information
        /// <summary>
        /// Gets a reference to the image resource information.
        /// </summary>
        /// <param name="resource">Resource information.</param>
        /// <returns>
        /// <strong>true</strong> if exist available information about resource; otherwise, <strong>false</strong>.
        /// </returns>
        public bool TryGetResourceInformation(out StyleModel resource)
        {
            bool result;

            resource = StyleModel.Empty;
            if (string.IsNullOrEmpty(Style))
            {
                return false;
            }

            try
            {
                var field = Parent;
                var fields = field.Parent.Owner;
                var table = fields.Parent;
                var export = table.Parent;
                resource = export.Resources.GetStyleResourceByName(Style);

                result = true;
            }
            catch
            {
                result = false;
            }

            return result;
        }
        #endregion

        #region [public] (bool) TryGetStyle(out Style): Gets a reference to the style from resource
        /// <summary>
        /// Gets a reference to the <see cref="T:iTin.Export.Model.StyleModel" /> from global resources.
        /// </summary>
        /// <param name="style">A <see cref="T:iTin.Export.Model.StyleModel" /> resource.</param>
        /// <returns>
        /// <strong>true</strong> if returns the style from resource; otherwise, <strong>false</strong>.
        /// </returns>
        public bool TryGetStyle(out StyleModel style)
        {
            style = StyleModel.Empty;

            var foudResource = TryGetResourceInformation(out var resource);
            if (!foudResource)
            {
                return true;
            }

            ////var logo = this.parent;
            ////var table = logo.Parent;
            ////var export = table.Parent;
            style = resource;

            return true;
        }
        #endregion

        #endregion

        #region internal methods

        #region [internal] (void) SetParent(FieldHeaderModel): Sets the parent element of the element
        /// <summary>
        /// Sets the parent element of the element.
        /// </summary>
        /// <param name="reference">Reference to parent.</param>
        internal void SetParent(FieldHeaderModel reference)
        {
            _parent = reference;
        }
        #endregion

        #endregion
    }
}
