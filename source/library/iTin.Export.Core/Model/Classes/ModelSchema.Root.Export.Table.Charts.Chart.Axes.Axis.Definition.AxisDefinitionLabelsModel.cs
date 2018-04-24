
namespace iTin.Export.Model
{
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    using Helper;

    /// <summary>
    /// Represents the visual setting the labels of a axis.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Belongs to: <strong><c>Category</c></strong>, or <strong><c>Values</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.AxisDefinitionModel" />.
    /// <code lang="xml" title="ITEE Object Element Usage">
    /// &lt;Labels&gt;
    ///   &lt;Font/&gt;
    /// &lt;Labels&gt;
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
    ///       <td><see cref="P:iTin.Export.Model.AxisDefinitionLabelsModel.Orientation" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Preferred orientation for axis labels. The default is <see cref="iTin.Export.Model.KnownLabelOrientation.Automatic" />.</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.AxisDefinitionLabelsModel.Position" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Preferred position for axis labels. The default is <see cref="iTin.Export.Model.KnownLabelPosition.Low" />.</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.AxisDefinitionLabelsModel.Alignment" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Preferred alignment for axis label. The default is <see cref="iTin.Export.Model.KnownHorizontalAlignment.Center" />.</td>
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
    ///     <term><see cref="P:iTin.Export.Model.AxisDefinitionLabelsModel.Font" /></term> 
    ///     <description>Reference to font model defined for axis labels.</description>
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
    public partial class AxisDefinitionLabelsModel
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const KnownLabelPosition DefaultPosition = KnownLabelPosition.Low;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const KnownHorizontalAlignment DefaultAlignment = KnownHorizontalAlignment.Center;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const KnownLabelOrientation DefaultOrientation = KnownLabelOrientation.Automatic;
        #endregion

        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private FontModel _font;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private AxisDefinitionModel _parent;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private KnownLabelPosition _position;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private KnownLabelOrientation _orientation;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private KnownHorizontalAlignment _alignment;
        #endregion
        
        #region constructor/s

        #region [public] AxisDefinitionLabelsModel(): Initializes a new instance of this class
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.AxisDefinitionLabelsModel" /> class.
        /// </summary>
        public AxisDefinitionLabelsModel()
        {
            Position = DefaultPosition;
            Alignment = DefaultAlignment;
            Orientation = DefaultOrientation;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (KnownHorizontalAlignment) Alignment: Gets or sets preferred alignment for axis labels
        /// <summary>
        /// Gets or sets preferred alignment for axis labels.
        /// </summary>
        /// <value>
        /// Preferred alignment for axis labels. The default is <see cref="iTin.Export.Model.KnownHorizontalAlignment.Center" />.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Labels Alignment="Left|Center|Right" .../&gt;
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
        [DefaultValue(DefaultAlignment)]
        public KnownHorizontalAlignment Alignment
        {
            get => _alignment;
            set
            {
                SentinelHelper.IsEnumValid(value);

                _alignment = value;
            }
        }
        #endregion

        #region [public] (FontModel) Font: Gets or sets a reference to the font model defined for this title
        /// <summary>
        /// Gets or sets a reference to the font model defined for this title.
        /// </summary>
        /// <value>
        ///   <para>Type: <see cref="FontModel"/></para>
        ///   <para>Reference to the font model defined for this title.</para>
        /// </value>
        public FontModel Font
        {
            get => _font ?? (_font = new FontModel());
            set => _font = value;
        }
        #endregion

        #region [public] (KnownLabelOrientation) Orientation: Gets or sets preferred orientation for axis labels
        /// <summary>
        /// Gets or sets preferred orientation for axis labels.
        /// </summary>
        /// <value>
        /// Preferred orientation for axis labels. The default is <see cref="iTin.Export.Model.KnownLabelOrientation.Automatic" />.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Labels Orientation="Automatic|Downward|Horizontal|Upward|Vertical" .../&gt;
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
        [DefaultValue(DefaultOrientation)]
        public KnownLabelOrientation Orientation
        {
            get => _orientation;
            set
            {
                SentinelHelper.IsEnumValid(value);

                _orientation = value;
            }
        }
        #endregion

        #region [public] (AxisDefinitionModel) Parent: Gets the parent element of the element
        /// <summary>
        /// Gets the parent element of the element.
        /// </summary>
        /// <value>
        /// The element that represents the container element of the element.
        /// </value>
        [Browsable(false)]
        public AxisDefinitionModel Parent => _parent;
        #endregion

        #region [public] (KnownLabelPosition) Position: Gets or sets preferred position for axis labels
        /// <summary>
        /// Gets or sets preferred position for axis labels.
        /// </summary>
        /// <value>
        /// Preferred position for axis labels. The default is <see cref="iTin.Export.Model.KnownLabelPosition.Low" />.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Labels Position="None|High|Low|NextToAxis" .../&gt;
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
        [DefaultValue(DefaultPosition)]
        public KnownLabelPosition Position
        {
            get => _position;
            set
            {
                SentinelHelper.IsEnumValid(value);

                _position = value;
            }
        }
        #endregion

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default
        /// <include file='..\..\iTin.Export.Documentation.Common.xml' path='Common/Model/Public/Overrides/Properties/Property[@name="IsDefault"]/*'/>
        public override bool IsDefault => Font.IsDefault &&
                                          Position.Equals(DefaultPosition) &&
                                          Alignment.Equals(DefaultAlignment) &&
                                          Orientation.Equals(DefaultOrientation);
        #endregion

        #endregion

        #region internal methods

        #region [internal] (void) SetParent(AxisDefinitionModel): Sets the parent element of the element
        /// <summary>
        /// Sets the parent element of the element.
        /// </summary>
        /// <param name="reference">Reference to parent.</param>
        internal void SetParent(AxisDefinitionModel reference)
        {
            _parent = reference;
        }
        #endregion

        #endregion
    }
}
