
namespace iTin.Export.Model
{
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    using Helpers;

    /// <summary>
    /// Represents the visual setting the values of a axis.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Belongs to: <strong><c>Category</c></strong>, or <strong><c>Values</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.AxisDefinitionModel" />.
    /// <code lang="xml" title="ITEE Object Element Usage">
    /// &lt;Values/&gt;
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
    ///       <td><see cref="P:iTin.Export.Model.AxisDefinitionValuesModel.Maximun" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>A <see cref="T:System.String" /> that contains the maximun value of axis. Accepts only numbers in floating point. The default is "<c>Autodetect</c>".</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.AxisDefinitionValuesModel.Minimun" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>A <see cref="T:System.String" /> that contains the minimun value of axis. Accepts only numbers in floating point. The default is "<c>Autodetect</c>".</td>
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
    public partial class AxisDefinitionValuesModel
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string DefaultMaximun = "Autodetect";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string DefaultMinimun = "Autodetect";
        #endregion
        
        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _maximun;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _minimun;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private AxisDefinitionModel _parent;
        #endregion

        #region constructor/s

        #region [public] AxisDefinitionValuesModel(): Initializes a new instance of this class
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.AxisDefinitionValuesModel" /> class.
        /// </summary>
        public AxisDefinitionValuesModel()
        {
            _maximun = DefaultMaximun;
            _minimun = DefaultMinimun;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (bool) HasMaximunValue: Gets a value that indicates whether the axis maximum value is the default value
        /// <summary>
        /// Gets a value that indicates whether the axis maximum value is the default value.
        /// </summary>
        /// <value>
        /// <strong>true</strong> if the axis maximum value is the default value; otherwise, <strong>false</strong>.
        /// </value>
        public bool HasMaximunValue => !Maximun.Equals(DefaultMaximun);
        #endregion

        #region [public] (bool) HasMinimunValue: Gets a value that indicates whether the axis minimun value is the default value
        /// <summary>
        /// Gets a value that indicates whether the axis minimun value is the default value.
        /// </summary>
        /// <value>
        /// <strong>true</strong> if the axis minimun value is the default value; otherwise, <strong>false</strong>.
        /// </value>
        public bool HasMinimunValue => !Minimun.Equals(DefaultMinimun);
        #endregion

        #region [public] (string) Maximun: Gets or sets maximun value of axis
        /// <summary>
        /// Gets or sets maximun value of axis.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String" /> that contains the maximun value of axis. Accepts only numbers in floating point. The default is <c>Autodetect</c>. 
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Marks Maximun="Autodetect|float" .../&gt;
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
        [DefaultValue(DefaultMaximun)]
        public string Maximun
        {
            get => _maximun;
            set
            {
                if (value.Equals(DefaultMaximun))
                {
                    return;
                }

                var parseOk = float.TryParse(value, out var result);
                SentinelHelper.IsFalse(parseOk, "Error value not valid");

                _maximun = value;
            }
        }
        #endregion

        #region [public] (string) Minimun: Gets or sets minimun value of axis
        /// <summary>
        /// Gets or sets maximun value of axis.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String" /> that contains the minimun value of axis. Accepts only numbers in floating point. The default is <c>Autodetect</c>. 
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Marks Minimun="Autodetect|float" .../&gt;
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
        [DefaultValue(DefaultMinimun)]
        public string Minimun
        {
            get => _minimun;
            set
            {
                if (value.Equals(DefaultMinimun))
                {
                    return;
                }

                var parseOk = float.TryParse(value, out var result);
                SentinelHelper.IsFalse(parseOk, "Error value not valid");

                _minimun = value;
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

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default
        /// <inheritdoc />
        /// <include file="..\..\iTin.Export.Documentation.Common.xml" path="Common/Model/Public/Overrides/Properties/Property[@name='IsDefault']/*" />
        public override bool IsDefault => Maximun.Equals(DefaultMaximun) &&
                                          Minimun.Equals(DefaultMinimun);
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
