
namespace iTin.Export.Model
{
    /// <inheritdoc />
    /// <summary>
    /// A Specialization of <see cref="T:iTin.Export.Model.BaseDataFieldModel" /> class.<br />
    /// Represents an empty data field.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Belongs to: <strong><c>Fields</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.FieldsModel" />.
    /// <code lang="xml" title="ITEE Object Element Usage">
    /// &lt;Gap ...&gt;
    ///   &lt;Header/&gt;
    ///   &lt;Value/&gt;
    ///   &lt;Aggregate/&gt;
    /// &lt;/Gap&gt;
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
    ///       <td><see cref="P:iTin.Export.Model.BaseDataFieldModel.Alias" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>The alias of data field. This value is used as the column header.</td>
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
    ///     <term><see cref="P:iTin.Export.Model.BaseDataFieldModel.Header" /></term> 
    ///     <description>Reference to visual setting of header of the data field.</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.BaseDataFieldModel.Value" /></term> 
    ///     <description>Reference to visual setting of value of the data field.</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.BaseDataFieldModel.Aggregate" /></term> 
    ///     <description>Reference to visual setting of aggregate function of the data field.</description>
    ///   </item>
    /// </list>
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
    public partial class GapFieldModel
    {
        #region public override properties

        #region [public] {override} (KnownFieldType) FieldType: Gets a value indicating data field type
        /// <summary>
        /// Gets a value indicating data field type.
        /// </summary>
        /// <value>
        /// Always returns <see cref="iTin.Export.Model.KnownFieldType.Gap" />.
        /// </value>
        public override KnownFieldType FieldType => KnownFieldType.Gap;
        #endregion

        #endregion

        #region protected override properties

        #region [protected] {override} (bool) CanSetData: Gets a value indicating whether current data field supports data
        /// <summary>
        /// Gets a value indicating whether current data field supports data.
        /// </summary>
        /// <value>
        /// Always returns <strong>false</strong>".
        /// </value>
        protected override bool CanSetData => false;
        #endregion

        #endregion
    }
}
