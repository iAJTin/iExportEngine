
namespace iTin.Export.Model
{
    using System;
    using System.Diagnostics;

    /// <summary>
    /// A Specialization of <see cref="T:iTin.Export.Model.RealDataTypeModel" /> class.<br/>
    /// Displays a number in exponential notation, which replaces part of the number with E + n, where E (exponent) multiplies the preceding number by 10 to n.
    /// You can specify the number of decimal places you want to use.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Belongs to: <strong><c>Content</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.ContentModel" />.
    /// <code lang="xml" title="ITEE Object Element Usage">
    /// &lt;Scientific ...&gt;
    ///   &lt;Error/&gt;
    /// &lt;Scientific/&gt;
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
    ///       <td><see cref="P:iTin.Export.Model.RealDataTypeModel.Decimals" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Number of decimal places. The default is <c>2</c>.</td>
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
    ///     <term><see cref="P:iTin.Export.Model.ScientificDataTypeModel.Error" /></term> 
    ///     <description>Reference for scientific data type error settings.</description>
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
    /// <example>
    /// The following example indicate that the content should be scientific data type.
    /// <code lang="xml">
    /// &lt;Style Name="Scientific"&gt;
    ///   &lt;Content Color="White"&gt;
    ///     &lt;Scientific Decimals="3"&gt;
    ///       &lt;Error Value="-9999"&gt;
    ///         &lt;Comment Show="Yes"&gt;
    ///           &lt;Text>Wrong value:  &lt;/Text&gt;
    ///         &lt;/Comment&gt;
    ///       &lt;/Error&gt;           
    ///     &lt;/Scientific&gt;
    ///   &lt;/Content&gt;
    /// &lt;/Style&gt;
    /// </code>
    /// </example>
    public partial class ScientificDataTypeModel : ICloneable
    {
        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ScientificErrorModel _error;
        #endregion

        #region public properties

        #region [public] (ScientificErrorModel) Error: Error: Gets or sets a reference that contains scientific data type error settings
        /// <summary>
        /// Gets or sets a reference that contains scientific data type error settings.
        /// </summary>
        /// <value>
        /// Scientific data type error settings
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Scientific ...&gt;
        ///   &lt;Error/&gt;
        /// &lt;/Number&gt;
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
        /// <example>
        /// <code lang="xml">
        /// &lt;Style Name="Scientific"&gt;
        ///   &lt;Content Color="White"&gt;
        ///     &lt;Scientific Decimals="3"&gt;
        ///       &lt;Error Value="-9999"&gt;
        ///         &lt;Comment Show="Yes"&gt;
        ///           &lt;Text>Wrong value:  &lt;/Text&gt;
        ///         &lt;/Comment&gt;
        ///       &lt;/Error&gt;           
        ///     &lt;/Scientific&gt;
        ///   &lt;/Content&gt;
        /// &lt;/Style&gt;
        /// </code>
        /// </example>
        public ScientificErrorModel Error
        {
            get => _error ?? (_error = new ScientificErrorModel());
            set => _error = value;
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
        public override bool IsDefault => base.IsDefault && Error.IsDefault;
        #endregion

        #endregion

        #region public methods

        #region [public] {new} (ScientificDataTypeModel) Clone(): Clones this instance
        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public new ScientificDataTypeModel Clone()
        {
            var scientificyDataTypeCloned = (ScientificDataTypeModel)MemberwiseClone();
            scientificyDataTypeCloned.Error = Error.Clone();
            scientificyDataTypeCloned.Properties = Properties.Clone();

            return scientificyDataTypeCloned;
        }
        #endregion

        #region [public] (void) Combine(ScientificDataTypeModel): Combines this instance with reference parameter
        /// <summary>
        /// Combines this instance with reference parameter.
        /// </summary>
        public void Combine(ScientificDataTypeModel reference)
        {
            Error.Combine(reference.Error);

            base.Combine(reference);
        }
        #endregion

        #endregion

        #region private methods

        #region [private] (object) Clone(): Creates a new object that is a copy of the current instance
        /// <inheritdoc />
        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
        /// <returns>
        /// A new object that is a copy of this instance.
        /// </returns>
        object ICloneable.Clone()
        {
            return Clone();
        }
        #endregion

        #endregion
    }
}
