
namespace iTin.Export.Model
{
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    using Helper;

    /// <summary>
    /// Represents the visual setting of chart legend. Includes visibility, location, border and font.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Belongs to: <strong><c>Chart</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.ChartModel" />.
    /// <code lang="xml" title="ITEE Object Element Usage">
    /// &lt;Legend&gt;
    ///   &lt;Border/&gt;
    ///   &lt;Font/gt;
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
    ///       <td><see cref="P:iTin.Export.Model.ChartLegendModel.Show" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Determines whether displays the chart legend. The default is <see cref="iTin.Export.Model.YesNo.No" />.</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.ChartLegendModel.Location" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Preferred location for chart legend. The default is <see cref="iTin.Export.Model.KnownLegendLocation.Right" />.</td>
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
    ///     <term><see cref="P:iTin.Export.Model.ChartLegendModel.Border" /></term> 
    ///     <description>Reference that contains the visual setting of legend border.</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.ChartLegendModel.Font" /></term> 
    ///     <description>Reference for font model defined for this legend.</description>
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
    public partial class ChartLegendModel
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo DefaultShow = YesNo.No;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const KnownLegendLocation DefaultLocation = KnownLegendLocation.Right;
        #endregion

        #region field member
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private YesNo show;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private FontModel font;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ChartModel parent;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ChartBorderModel border;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private KnownLegendLocation location;
        #endregion

        #region constructor/s

        #region [public] ChartLegendModel(): Initializes a new instance of this class
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.ChartLegendModel" /> class.
        /// </summary>
        public ChartLegendModel()
        {
            Show = DefaultShow;
            Location = DefaultLocation;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (ChartBorderModel) Border: Gets or sets a reference that contains the visual setting of legend border
        /// <summary>
        /// Gets or sets a reference that contains the visual setting of legend border.
        /// </summary>
        /// <value>
        /// A <see cref="ChartBorderModel" /> reference that contains the visual setting of legend border.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Legend ...&gt;
        ///   &lt;Border/&gt;
        ///   ...
        /// &lt;/Legend&gt;
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
        public ChartBorderModel Border
        {
            get => border ?? (border = new ChartBorderModel());
            set => border = value;
        }
        #endregion

        #region [public] (FontModel) Font: Gets or sets a reference for font model defined for this legend
        /// <summary>
        /// Gets or sets a reference for font model defined for this legend.
        /// </summary>
        /// <value>
        /// Reference for font model defined for this legend.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Legend ...&gt;
        ///   &lt;Font/&gt;
        ///   ...
        /// &lt;/Legend&gt;
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
        public FontModel Font
        {
            get => font ?? (font = new FontModel());
            set => font = value;
        }
        #endregion

        #region [public] (KnownLegendLocation) Location: Gets or sets preferred location for chart legend
        /// <summary>
        /// Gets or sets preferred location for chart legend.
        /// </summary>
        /// <value>
        /// Preferred location for chart legend. The default is <see cref="iTin.Export.Model.KnownLegendLocation.Right"/>.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Legend Location="Top|Right|Bottom|Left" ...&gt;
        ///   ...
        /// &lt;/Legend&gt;
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
        [DefaultValue(DefaultLocation)]
        public KnownLegendLocation Location
        {
            get => location;
            set
            {
                SentinelHelper.IsEnumValid(value);

                location = value;
            }
        }
        #endregion

        #region [public] (ChartModel) Parent: Gets the parent element of the element
        /// <summary>
        /// Gets the parent element of the element.
        /// </summary>
        /// <value>
        /// The element that represents the container element of the element.
        /// </value>
        [Browsable(false)]
        public ChartModel Parent => parent;
        #endregion

        #region [public] (YesNo) Show: Gets or sets a value that determines whether displays the chart legend
        /// <summary>
        /// Gets or sets a value that determines whether displays the chart legend.
        /// </summary>
        /// <value>
        /// <see cref="iTin.Export.Model.YesNo.Yes" /> if display the chart legend; otherwise, <see cref="iTin.Export.Model.YesNo.No" />. The default is <see cref="iTin.Export.Model.YesNo.No" />.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Legend Show="Yes|No" ...&gt;
        ///   ...
        /// &lt;/Legend&gt;
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
            get => show;
            set
            {
                SentinelHelper.IsEnumValid(value);

                show = value;
            }
        }
        #endregion

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default
        /// <include file='..\..\iTin.Export.Documentation.Common.xml' path='Common/Model/Public/Overrides/Properties/Property[@name="IsDefault"]/*'/>
        public override bool IsDefault => Font.IsDefault &&
                                          Border.IsDefault &&
                                          Show.Equals(DefaultShow) &&
                                          Location.Equals(DefaultLocation);
        #endregion

        #endregion

        #region internal methods

        #region [internal] (void) SetParent(ChartModel): Sets the parent element of the element
        /// <summary>
        /// Sets the parent element of the element.
        /// </summary>
        /// <param name="reference">Reference to parent.</param>
        internal void SetParent(ChartModel reference)
        {
            parent = reference;
        }
        #endregion

        #endregion
    }
}
