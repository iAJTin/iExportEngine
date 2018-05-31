
namespace iTin.Export.Model
{
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    using Helpers;

    /// <inheritdoc />
    /// <summary>
    /// Defines field name and a field separator of a group item.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Belongs to: <strong><c>Group</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.GroupModel" />.
    /// <code lang="xml" title="ITEE Object Element Usage">
    /// &lt;Field .../&gt;
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
    ///       <td><see cref="P:iTin.Export.Model.GroupItemModel.Name" /></td>
    ///       <td align="center">No</td>
    ///       <td>Name of the field.</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.GroupItemModel.Separator" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Field separator. The default is "<c>None</c>".</td>
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
    public partial class GroupItemModel
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string DefaultSeparator = "None";
        #endregion

        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _name;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupModel _owner;
        #endregion

        #region constructor/s

        #region [public] GroupItemModel(): Initializes a new instance of this class
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.GroupItemModel" /> class.
        /// </summary>
        public GroupItemModel()
        {
            Separator = DefaultSeparator;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (string) Name: Name: Gets or sets the name of the field
        /// <summary>
        /// Gets or sets the name of the field.
        /// </summary>
        /// <value>
        /// The name of the field.
        /// Are only allow strings made ​​up of letters, numbers and following special chars <strong>'<c>_ - # * @ % $</c>'</strong>.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Field Name="string" .../&gt;
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
        /// <exception cref="T:iTin.Export.Model.InvalidFieldIdentifierNameException">If <paramref name="value" /> not is a valid field identifier name.</exception>
        [XmlAttribute]
        public string Name
        {
            get => _name;
            set
            {
                SentinelHelper.ArgumentNull(value);
                SentinelHelper.IsFalse(RegularExpressionHelper.IsValidFieldName(value), new InvalidFieldIdentifierNameException(ErrorMessageHelper.FieldIdentifierNameErrorMessage("Field", "Name", value)));

                _name = value;
            }
        }
        #endregion

        #region [public] (GroupModel) Owner: Owner: Gets the element that owns this
        /// <summary>
        /// Gets the element that owns this <see cref="T:iTin.Export.Model.GroupItemModel" />.
        /// </summary>
        /// <value>
        /// The <see cref="T:iTin.Export.Model.GroupModel" /> that owns this <see cref="T:iTin.Export.Model.GroupItemModel" />.
        /// </value>
        [XmlIgnore]
        [Browsable(false)]
        public GroupModel Owner => _owner;
        #endregion

        #region [public] (string) Separator: Gets or sets the field separator
        /// <summary>
        /// Gets or sets the field separator.
        /// </summary>
        /// <value>
        /// The field separator. The default is "<c>None</c>".<br/>
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Field Separator="None|Space|Slash|Backslash|Dash|Dot|Comma|Colon|Semi Colon|New Line|string" .../&gt;
        /// </code>
        /// <para>
        /// <c>AEE</c> recognizes the following strings as valid separators:
        /// <list type="table">
        ///   <listheader>
        ///     <term>Value</term>
        ///     <description>Description</description>
        ///   </listheader>
        ///   <item>
        ///     <term>None</term> 
        ///     <description>An empty string</description>
        ///   </item>
        ///   <item>
        ///     <term>Space</term> 
        ///     <description>A whitespace</description>
        ///   </item>
        ///   <item>
        ///     <term>Dash</term> 
        ///     <description>-</description>
        ///   </item>
        ///   <item>
        ///     <term>Dot</term> 
        ///     <description>.</description>
        ///   </item>
        ///   <item>
        ///     <term>Comma</term> 
        ///     <description>,</description>
        ///   </item>
        ///   <item>
        ///     <term>Colon</term> 
        ///     <description>:</description>
        ///   </item>
        ///   <item>
        ///     <term>Semi Colon</term> 
        ///     <description>;</description>
        ///   </item>
        ///   <item>
        ///     <term>New Line</term> 
        ///     <description>A new line</description>
        ///   </item>
        ///   <item>
        ///     <term>Other value</term> 
        ///     <description>Defined by user</description>
        ///   </item>
        /// </list>
        /// </para>
        /// <note>
        /// <c>AEE</c> provides the <see cref="T:iTin.Export.Model.KnownItemGroupSeparator"/> static class, 
        /// it contains list of constants with the known elements, can be used for compare values if necessary for new writers.
        /// </note>
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
        /// The following example shows the use of the property. The new group consists of three fields separated by commas.
        /// <code lang="xml">
        /// &lt;Groups&gt;     
        ///   &lt;Group Name="AddressGroup"&gt;
        ///     &lt;Field Name="CMADR1" Separator="Comma"/&gt;
        ///     &lt;Field Name="CMCITY" Separator="Comma"/&gt;
        ///     &lt;Field Name="CMPSTAL"/&gt;
        ///   &lt;/Group&gt;
        /// &lt;/Groups&gt;
        /// </code>
        /// <code lang="cs">
        /// public void CreateGroup()
        /// {
        ///     GroupsModel groups = new GroupsModel();
        ///
        ///     GroupModel addressGroup = new GroupModel
        ///                                   { 
        ///                                       Name = "AddressGroup",
        ///                                       Fields = new List&lt;GroupItemModel&gt;
        ///                                                    {
        ///                                                        new GroupItemModel { Name = "CMADR1", Separator = "Comma" },
        ///                                                        new GroupItemModel { Name = "CMCITY", Separator = "Comma" },
        ///                                                        new GroupItemModel { Name = "CMPSTAL" }
        ///                                                    }
        ///                                   };
        ///     addressGroup.SetOwner(groups);
        ///     groups.Items.Add(addressGroup);
        ///
        ///     ExportModel export = new ExportModel 
        ///                              {
        ///                                  Table = 
        ///                                      {
        ///                                          Name = "Sample",
        ///                                          Alias = "New table",
        ///                                          Location = new[] { 2, 2}, 
        ///                                          Groups = groups
        ///                                      } 
        ///                              };
        ///
        ///     ExportsModel model = new ExportsModel();
        ///     model.Items.Add(export);
        /// }
        /// </code>
        /// </example>
        [XmlAttribute]
        [DefaultValue(DefaultSeparator)]
        public string Separator { get; set; }
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
        public override bool IsDefault => string.IsNullOrEmpty(Name) && Separator.Equals(DefaultSeparator);
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (string) ToString(): Returns a string that represents the current object
        /// <inheritdoc />
        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String" /> that represents the current object.
        /// </returns>
        /// <remarks>
        /// This method <see cref="M:iTin.Export.Model.GroupItemModel.ToString" /> returns a string that includes name and separator for this field.
        /// </remarks>
        public override string ToString()
        {
            return $"Name=\"{Name}\", Separator=\"{Separator}\"";
        }
        #endregion

        #endregion

        #region public methods

        #region [public] (void) SetOwner(GroupModel): Sets the element that owns this
        /// <summary>
        /// Sets the element that owns this <see cref="T:iTin.Export.Model.GroupItemModel" />.
        /// </summary>
        /// <param name="reference">Reference to owner.</param>
        public void SetOwner(GroupModel reference)
        {
            _owner = reference;
        }
        #endregion

        #endregion
    }
}
