
namespace iTin.Export.Model
{
    using System.Diagnostics;
    using System.Xml.Serialization;

    using Helpers;

    /// <inheritdoc />
    /// <summary>
    /// A Specialization of <see cref="T:iTin.Export.Model.BaseDataFieldModel" /> class.<br />
    /// Which acts as the base class for different data fields.<br />
    /// Represents a data field.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The following table shows different data fields.
    /// </para>
    /// <list type="table">
    ///   <listheader>
    ///     <term>Class</term>
    ///     <description>Description</description>
    ///   </listheader>
    ///   <item>
    ///     <term><see cref="T:iTin.Export.Model.GroupFieldModel" /></term>
    ///     <description>Represents a field as union of several data field.</description>
    ///   </item>
    /// </list>
    /// <para>
    /// Belongs to: <strong><c>Fields</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.FieldsModel" />.
    /// <code lang="xml" title="ITEE Object Element Usage">
    /// &lt;Field ...&gt;
    ///   &lt;Header/&gt;
    ///   &lt;Value/&gt;
    ///   &lt;Aggregate/&gt;
    /// &lt;/Field&gt;
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
    ///       <td><see cref="P:iTin.Export.Model.DataFieldModel.Name" /></td>
    ///       <td align="center">No</td>
    ///       <td>Name of the field.</td>
    ///     </tr>
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
    public partial class DataFieldModel
    {
        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _name;
        #endregion

        #region public properties

        #region [public] (string) Name: Gets or sets the name of the field
        /// <summary>
        /// Gets or sets the name of the field.
        /// </summary>
        /// <value>
        /// The name of the field.
        /// Are only allow strings made ​​up of letters, numbers and following special chars <strong>'<c>_ - # * @ % $</c>'</strong>.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Field Name="string" ...&gt;
        /// ...
        /// &lt;/Field&gt;
        /// </code>
        /// <para>
        /// <para><strong>Compatibility table with native writers.</strong></para>
        /// <table>
        ///   <thead>
        ///     <tr>
        ///       <th>Comma-Separated Values<br/><see cref="iTin.Export.Writers.Native.CsvWriter" /></th>
        ///       <th>Tab-Separated Values<br/><see cref="iTin.Export.Writers.Native.TsvWriter" /></th>
        ///       <th>SQL Script<br/><see cref="iTin.Export.Writers.Native.SqlScriptWriter" /></th>
        ///       <th>XML Spreadsheet 2003<br/><see cref="iTin.Export.Writers.Native.Spreadsheet2003TabularWriter" /></th>
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
        /// <exception cref="iTin.Export.Model.InvalidFieldIdentifierNameException">If <paramref name="value" /> not is a valid field identifier name.</exception>
        [XmlAttribute]
        public string Name
        {
            get => GetValueByReflection(Owner.Parent.Parent, _name);
            set
            {
                SentinelHelper.ArgumentNull(value);

                var linked = RegularExpressionHelper.IsBindableResource(value);
                if (!linked)
                {
                    SentinelHelper.IsFalse(RegularExpressionHelper.IsValidFieldName(value), new InvalidFieldIdentifierNameException(ErrorMessageHelper.FieldIdentifierNameErrorMessage("Field", "Name", value)));                        
                }
                
                _name = value;
            }
        }
        #endregion

        #endregion

        #region public override properties

        #region [public] {override} (KnownFieldType) FieldType: Gets a value indicating data field type
        /// <summary>
        /// Gets a value indicating data field type.
        /// </summary>
        /// <value>
        /// Always returns <see cref="iTin.Export.Model.KnownFieldType.Field" />.
        /// </value>
        public override KnownFieldType FieldType => KnownFieldType.Field;
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (string) ToString(): Returns a string that represents the current object
        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String" /> that represents the current object.
        /// </returns>
        /// <remarks>
        /// This method <see cref="DataFieldModel.ToString()"/> returns a string that includes field name and field alias.
        /// </remarks>
        public override string ToString()
        {
            return $"Name=\"{Name}\", {base.ToString()}";
        }
        #endregion

        #endregion
    }
}
