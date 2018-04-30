
namespace iTin.Export.Model
{
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    using Helpers;

    /// <inheritdoc />
    /// <summary>
    /// Reference to visual setting of header of the data field.
    /// </summary>
    /// <remarks>
    /// <para>Belongs to: <strong><c>Field</c></strong>, please see <see cref="T:iTin.Export.Model.DataFieldModel" /><br />
    /// - Or - <strong><c>Fixed</c></strong>, please see <see cref="T:iTin.Export.Model.FixedFieldModel" /><br />
    /// - Or - <strong><c>Gap</c></strong>, please see <see cref="T:iTin.Export.Model.GapFieldModel" /><br /> 
    /// - Or - <strong><c>Group</c></strong>, please see <see cref="T:iTin.Export.Model.GroupFieldModel" /><br />.
    /// <code lang="xml" title="ITEE Object Element Usage">
    /// &lt;Header .../&gt;
    /// </code>
    /// </para>
    /// <para><strong>Attributes</strong></para>
    /// <table>
    ///   <thead>
    ///     <tr>
    ///       <th>Attribute</th>
    ///       <th>Optional</th>
    ///       <th>Description</th>
    ///       </tr>
    ///   </thead>
    ///   <tbody>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.FieldAggregateModel.Style" /></td>
    ///       <td align="center">No</td>
    ///       <td>Name of a style defined in the list of styles. The default is "<c>Default</c>".</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.FieldAggregateModel.Show" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Determines visibility of the element. The default is <see cref="F:iTin.Export.Model.YesNo.No" />.</td>
    ///     </tr>
    ///   </tbody>
    /// </table>
    /// <para>
    /// <para><strong>Compatibility table with native writers.</strong></para>
    /// <table>
    ///   <thead>
    ///     <tr>
    ///       <th>Comma-Separated Values<br /><see cref="T:iTin.Export.Writers.Native.CsvWriter" /></th>
    ///       <th>Tab-Separated Values<br /><see cref="T:iTin.Export.Writers.Native.TsvWriter" /></th>
    ///       <th>SQL Script<br /><see cref="T:iTin.Export.Writers.Native.SqlScriptWriter" /></th>
    ///       <th>XML Spreadsheet 2003<br /><see cref="T:iTin.Export.Writers.Native.Spreadsheet2003TabularWriter" /></th>
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
    public partial class FieldHeaderModel
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo DefaultShow = YesNo.Yes;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string DefaultStyle = "Default";
        #endregion

        #region field member
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private YesNo _show;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _style;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private BaseDataFieldModel _parent;
        #endregion

        #region constructor/s

        #region [public] FieldHeaderModel(): Initializes a new instance of this class
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.FieldHeaderModel" /> class.
        /// </summary>
        public FieldHeaderModel()
        {
            Show = DefaultShow;
            Style = DefaultStyle;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (YesNo) Show: Gets or sets a value that determines whether the visibility of the element
        /// <summary>
        /// Gets or sets a value that determines visibility of the element
        /// </summary>
        /// <value>
        /// <see cref="iTin.Export.Model.YesNo.Yes" /> if the item is displayed; otherwise, <strong><see cref="iTin.Export.Model.YesNo.No"/></strong>. The default is <see cref="iTin.Export.Model.YesNo.No" />.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Header Show="Yes|No" ...&gt;
        /// ...
        /// &lt;/Header&gt;
        /// </code>
        /// <para>
        /// <para><strong>Compatibility table with native writers.</strong></para>
        /// <table>
        ///   <thead>
        ///     <tr>
        ///       <th>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.CsvWriter" /></th>
        ///       <th>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.TsvWriter" /></th>
        ///       <th>SQL Script<br/><see cref="T:iTin.Export.Writers.Native.SqlScriptWriter" /></th>
        ///       <th>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Native.Spreadsheet2003TabularWriter" /></th>
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
            get => _show;
            set
            {
                SentinelHelper.IsEnumValid(value);

                _show = value;
            }
        }
        #endregion

        #region [public] (BaseDataFieldModel) Parent: Gets the parent element of the element
        /// <summary>
        /// Gets the parent element of the element.
        /// </summary>
        /// <value>
        /// The element that represents the container element of the element.
        /// </value>
        [Browsable(false)]
        public BaseDataFieldModel Parent => _parent;
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
        ///       <th>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.CsvWriter" /></th>
        ///       <th>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.TsvWriter" /></th>
        ///       <th>SQL Script<br/><see cref="T:iTin.Export.Writers.Native.SqlScriptWriter" /></th>
        ///       <th>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Native.Spreadsheet2003TabularWriter" /></th>
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
            get => GetValueByReflection(Parent.Owner.Parent.Parent, _style);
            set
            {
                SentinelHelper.ArgumentNull(value);

                var linked = RegularExpressionHelper.IsBindableResource(value);
                if (!linked)
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
            return Style.Equals(DefaultStyle) || Parent.Owner.Parent.Parent.Owner.Resources.Styles.Contains(Style);
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
                var fields = field.Owner;
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

        #region [internal] (void) SetParent(BaseDataFieldModel): Sets the parent element of the element
        /// <summary>
        /// Sets the parent element of the element.
        /// </summary>
        /// <param name="reference">Reference to parent.</param>
        internal void SetParent(BaseDataFieldModel reference)
        {
            _parent = reference;
        }
        #endregion

        #endregion
    }
}
