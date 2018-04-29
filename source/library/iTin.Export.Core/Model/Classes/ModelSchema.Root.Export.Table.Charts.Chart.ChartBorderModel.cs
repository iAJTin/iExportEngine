
namespace iTin.Export.Model
{
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Xml.Serialization;

    using Drawing.Helper;
    using Helpers;
    
    /// <summary>
    /// Represents the visual setting of chart border. Includes visibility, shadow definition, line style, width and color.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Belongs to: <strong><c>Chart</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.ChartModel" />.
    /// <code lang="xml" title="ITEE Object Element Usage">
    /// &lt;Border&gt;
    ///   &lt;Shadow/&gt;
    /// &lt;/Border&gt;
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
    ///       <td><see cref="P:iTin.Export.Model.ChartBorderModel.Show" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Determines whether displays the border. The default is <see cref="iTin.Export.Model.YesNo.No" />.</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.ChartBorderModel.Color" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Preferred border color. The default is "<c>Black</c>".</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.ChartBorderModel.Width" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Preferred style for width of the border line. The default is <see cref="iTin.Export.Model.KnownWidthLineStyle.Thin" />.</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.ChartBorderModel.Style" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Preferred border line style. The default is <see cref="iTin.Export.Model.KnownLineStyle.Continuous" />.</td>
    ///     </tr>
    ///   </tbody>
    /// </table>
    /// <para><strong>Elements</strong></para>
    /// <list type="table">
    ///   <listheader>
    ///     <term>Element</term>
    ///     <description>Description</description>
    ///   </listheader>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.ChartBorderModel.Shadow" /></term> 
    ///     <description>Represents the visual setting of shadow-border. Includes shadow visibility and transparency.</description>
    ///   </item>
    /// </list>
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
    ///       <td align="center">No has effect</td>
    ///       <td align="center">No has effect</td>
    ///       <td align="center">No has effect</td>
    ///       <td align="center">No has effect</td>
    ///     </tr>
    ///   </tbody>
    /// </table>
    /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
    /// </para>
    /// </remarks>
    public partial class ChartBorderModel
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string DefaultColor = "Black";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo DefaultShow = YesNo.No;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const KnownLineStyle DefaultLineStyle = KnownLineStyle.Continuous;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const KnownWidthLineStyle DefaultWidth = KnownWidthLineStyle.Thin;
        #endregion

        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private YesNo _show;
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ShadowModel _shadow;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private KnownLineStyle _style;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private KnownWidthLineStyle _lineWidth;
        #endregion
        
        #region constructor/s

        #region [public] ChartBorderModel(): Initializes a new instance of this class
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.ChartBorderModel" /> class.
        /// </summary>
        public ChartBorderModel()
        {
            Show = DefaultShow;
            Color = DefaultColor;
            Width = DefaultWidth;
            Style = DefaultLineStyle;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (string) Color: Gets or sets preferred border color
        /// <summary>
        /// Gets or sets preferred border color.
        /// </summary>
        /// <value>
        /// Preferred border color. The default is "<c>Black</c>".
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Border Color="string" ...&gt;
        ///   ...
        /// &lt;/Border&gt;
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
        ///       <td align="center">No has effect</td>
        ///       <td align="center">No has effect</td>
        ///       <td align="center">No has effect</td>
        ///       <td align="center">No has effect</td>
        ///     </tr>
        ///   </tbody>
        /// </table>
        /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
        /// </para>
        /// </remarks>
        [XmlAttribute]
        [DefaultValue(DefaultColor)]
        public string Color { get; set; }
        #endregion

        #region [public] (ShadowModel) Shadow: Gets or sets a reference that contains the visual setting of shadow-border
        /// <summary>
        /// Gets or sets a reference that contains the visual setting of shadow-border.
        /// </summary>
        /// <value>
        /// A <para><see cref="T:iTin.Export.Model.ShadowModel" /> reference that contains the visual setting of shadow-border.</para>
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Border ...&gt;
        ///   &lt;Shadow/&gt;
        ///   ...
        /// &lt;/Border&gt;
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
        ///       <td align="center">No has effect</td>
        ///       <td align="center">No has effect</td>
        ///       <td align="center">No has effect</td>
        ///       <td align="center">No has effect</td>
        ///     </tr>
        ///   </tbody>
        /// </table>
        /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
        /// </para>
        /// </remarks>
        public ShadowModel Shadow
        {
            get => _shadow ?? (_shadow = new ShadowModel());
            set => _shadow = value;
        }
        #endregion

        #region [public] (YesNo) Show: Gets or sets a value that determines whether to display the border
        /// <summary>
        /// Gets or sets a value that determines whether to display the border.
        /// </summary>
        /// <value>
        /// <see cref="iTin.Export.Model.YesNo.Yes" /> if display the border; otherwise, <see cref="iTin.Export.Model.YesNo.No" />. The default is <see cref="iTin.Export.Model.YesNo.No" />.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Border Show="Yes|No" ...&gt;
        ///   ...
        /// &lt;/Border&gt;
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
        ///       <td align="center">No has effect</td>
        ///       <td align="center">No has effect</td>
        ///       <td align="center">No has effect</td>
        ///       <td align="center">No has effect</td>
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

        #region [public] (KnownLineStyle) Style: Gets or sets preferred border line style
        /// <summary>
        /// Gets or sets preferred border line style.
        /// </summary>
        /// <value>
        /// Preferred border line style. The default is <see cref="iTin.Export.Model.KnownLineStyle.Continuous" />
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Border Style="Continuous|Dash|DashDot|DashDotDot|Dot" ...&gt;
        ///   ...
        /// &lt;/Border&gt;
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
        ///       <td align="center">No has effect</td>
        ///       <td align="center">No has effect</td>
        ///       <td align="center">No has effect</td>
        ///       <td align="center">No has effect</td>
        ///     </tr>
        ///   </tbody>
        /// </table>
        /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
        /// </para>
        /// </remarks>
        [XmlAttribute]
        [DefaultValue(DefaultLineStyle)]
        public KnownLineStyle Style
        {
            get => _style;
            set
            {
                SentinelHelper.IsEnumValid(value);

                _style = value;
            }
        }
        #endregion

        #region [public] (KnownWidthLineStyle) Width: Gets or sets a value indicating width border line style
        /// <summary>
        /// Gets or sets preferred style for width of the border line.
        /// </summary>
        /// <value>
        /// Preferred style for width of the border line. The default is <see cref="iTin.Export.Model.KnownWidthLineStyle.Thin" />.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Border Width="Thin|Medium|Thick" ...&gt;
        ///   ...
        /// &lt;/Border&gt;
        /// </code>
        /// <para>Examples</para>
        /// <table>
        ///   <tbody>
        ///     <tr>
        ///       <td align="center"><img src="Images\Border-Thin.png" alt="&lt;Border Width='Thin' .../&gt;" /></td>
        ///       <td align="center"><img src="Images\Border-Medium.png" alt="&lt;Border Width='Medium' .../&gt;" /></td>
        ///       <td align="center"><img src="Images\Border-Thick.png" alt="&lt;Border Width='Thick' .../&gt;" /></td>
        ///     </tr>
        ///   </tbody>
        /// </table>
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
        ///       <td align="center">No has effect</td>
        ///       <td align="center">No has effect</td>
        ///       <td align="center">No has effect</td>
        ///       <td align="center">No has effect</td>
        ///     </tr>
        ///   </tbody>
        /// </table>
        /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
        /// </para>
        /// </remarks>
        [XmlAttribute]
        [DefaultValue(DefaultWidth)]
        public KnownWidthLineStyle Width
        {
            get => _lineWidth;
            set
            {
                SentinelHelper.IsEnumValid(value);

                _lineWidth = value;
            }
        }
        #endregion

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default
        /// <inheritdoc />
        /// <include file="..\..\iTin.Export.Documentation.Common.xml" path="Common/Model/Public/Overrides/Properties/Property[@name='IsDefault']/*" />
        public override bool IsDefault => Shadow.IsDefault &&
                                          Show.Equals(DefaultShow) &&
                                          Color.Equals(DefaultColor) &&
                                          Style.Equals(DefaultLineStyle) &&
                                          Width.Equals(DefaultWidth);
        #endregion

        #endregion

        #region public methods

        #region [public] (Color) GetColor(): Gets a reference to the Color structure that represents color for this border
        /// <summary>
        /// Gets a reference to the <see cref="T:System.Drawing.Color" /> structure that represents color for this border.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Drawing.Color"/> structure that represents color for this border.
        /// </returns> 
        public Color GetColor()
        {
            return ColorHelper.GetColorFromString(Color);
        }
        #endregion

        #endregion
    }
}
