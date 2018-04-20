
namespace iTin.Export.Model
{
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    using Helper;

    /// <summary>
    /// Represents the visual setting  the marks of a axis.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Belongs to: <strong><c>Category</c></strong>, or <strong><c>Values</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.AxisDefinitionModel" />.
    /// <code lang="xml" title="ITEE Object Element Usage">
    /// &lt;Marks/&gt;
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
    ///       <td><see cref="P:iTin.Export.Model.AxisDefinitionMarksModel.Major" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Preferred position of major tick marks for an axis. The default is <see cref="iTin.Export.Model.KnownTickMarkStyle.Cross" />.</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.AxisDefinitionMarksModel.Minor" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Preferred position of minor tick marks for an axis. The default is <see cref="iTin.Export.Model.KnownTickMarkStyle.Cross" />.</td>
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
    public partial class AxisDefinitionMarksModel
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const KnownTickMarkStyle DefaultMajor = KnownTickMarkStyle.Cross;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const KnownTickMarkStyle DefaultMinor = KnownTickMarkStyle.Cross;
        #endregion
        
        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private KnownTickMarkStyle major;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private KnownTickMarkStyle minor;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private AxisDefinitionModel parent;
        #endregion

        #region constructor/s

        #region [public] AxisDefinitionMarksModel(): Initializes a new instance of this class
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.AxisDefinitionMarksModel" /> class.
        /// </summary>
        public AxisDefinitionMarksModel()
        {
            Major = DefaultMajor;
            Minor = DefaultMinor;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (KnownTickMarkStyle) Major: Gets or sets a value indicating the position of major tick marks for an axis
        /// <summary>
        /// Gets or sets a value indicating the position of major tick marks for an axis.
        /// </summary>
        /// <value>
        /// Position of major tick marks for an axis. The default is <see cref="iTin.Export.Model.KnownTickMarkStyle.Cross" />.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Marks Major="None|Cross|Inside|Outside" .../&gt;
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
        [DefaultValue(DefaultMajor)]
        public KnownTickMarkStyle Major
        {
            get => major;
            set
            {
                SentinelHelper.IsEnumValid(value);

                major = value;
            }
        }
        #endregion

        #region [public] (KnownTickMarkStyle) Minor: Gets or sets a value indicating the position of minor tick marks for an axis
        /// <summary>
        /// Gets or sets a value indicating the position of minor tick marks for an axis.
        /// </summary>
        /// <value>
        /// Position of minor tick marks for an axis. The default is <see cref="iTin.Export.Model.KnownTickMarkStyle.Cross" />.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Marks Minor="None|Cross|Inside|Outside" .../&gt;
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
        [DefaultValue(DefaultMinor)]
        public KnownTickMarkStyle Minor
        {
            get => minor;
            set
            {
                SentinelHelper.IsEnumValid(value);

                minor = value;
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
        public AxisDefinitionModel Parent => parent;
        #endregion

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default
        /// <inheritdoc />
        /// <include file="..\..\iTin.Export.Documentation.Common.xml" path="Common/Model/Public/Overrides/Properties/Property[@name=&quot;IsDefault&quot;]/*" />
        public override bool IsDefault => Major.Equals(DefaultMajor) &&
                                          Minor.Equals(DefaultMinor);
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
            parent = reference;
        }
        #endregion

        #endregion
    }
}
