
namespace iTin.Export.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Linq;
    using System.Xml.Serialization;

    using Helpers;

    /// <inheritdoc />
    /// <summary>
    /// Contains a collection of field names. Each element is result of the union of a field list.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Belongs to: <strong><c>Groups</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.GroupsModel" />.
    /// <code lang="xml" title="ITEE Object Element Usage">
    /// &lt;Group ...&gt;
    ///   &lt;Field/&gt;
    ///   &lt;Field/&gt;
    ///   ... 
    /// &lt;/Group&gt;
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
    ///       <td><see cref="P:iTin.Export.Model.GroupModel.Name" /></td>
    ///       <td align="center">No</td>
    ///       <td>Name of the group.</td>
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
    ///     <term><see cref="P:iTin.Export.Model.GroupModel.Fields" /></term> 
    ///     <description>Collection of fields contained within the group. Each element is composed of a field name and origin a field separator.</description>
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
    public partial class GroupModel
    {
        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _name;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupsModel _owner;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<GroupItemModel> _groupItems;
        #endregion

        #region public properties

        #region [public] (List<GroupItemModel>) Fields: Gets or sets collection of fields contained within the group
        /// <summary>
        /// Gets or sets collection of fields contained within the group.
        /// </summary>
        /// <value>
        /// Collection of fields contained within the group. Each element is composed of a field name and a field separator.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Group&gt;
        ///   &lt;Field .../&gt;
        ///   &lt;Field .../&gt;
        ///   ...
        /// &lt;Group&gt;
        /// </code>
        /// </remarks>
        /// <example>
        /// The following example creates a new group called <c>AddressGroup</c> as a result of the union of three fields.
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
        ///                                     { 
        ///                                         Name = "AddressGroup",
        ///                                         Fields = new List&lt;GroupItemModel&gt;
        ///                                                         {
        ///                                                             new GroupItemModel { Name = "CMADR1", Separator = "Comma" },
        ///                                                             new GroupItemModel { Name = "CMCITY", Separator = "Comma" },
        ///                                                             new GroupItemModel { Name = "CMPSTAL" }
        ///                                                         }
        ///                                     };
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
        [XmlElement("Field")]
        public List<GroupItemModel> Fields
        {
            get
            {
                if (_groupItems == null)
                {
                    _groupItems = new List<GroupItemModel>();
                }

                foreach (var item in _groupItems)
                {
                    item.SetOwner(this);
                }

                return _groupItems;
            }
            set => _groupItems = value;
        }
        #endregion

        #region [public] (bool) MultiLine: Gets a value indicating whether this is a multiline field
        /// <summary>
        /// Gets a value indicating whether this is a multiline field. 
        /// </summary>
        /// <value>
        /// <strong>true</strong> if is a multiline field; otherwise, <strong>false</strong>.
        /// </value>
        public bool Multiline
        {
            get { return Fields.Any(field => field.Separator.Equals("New Line", StringComparison.OrdinalIgnoreCase)); }
        }
        #endregion

        #region [public] (string) Name: Gets or sets the name of the group
        /// <summary>
        /// Gets or sets the name of the group.
        /// </summary>
        /// <value>
        /// The name of the group.
        /// Are only allow strings made ​​up of letters, numbers and following special chars <strong>'<c>_ - # * @ % $</c>'</strong>.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        ///   &lt;Group Name="string"&gt;
        ///     ...
        ///   &lt;/Group&gt;
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
        /// The following example creates a new group called <c>AddressGroup</c> as a result of the union of three fields.
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
        ///                                     { 
        ///                                         Name = "AddressGroup",
        ///                                         Fields = new List&lt;GroupItemModel&gt;
        ///                                                         {
        ///                                                             new GroupItemModel { Name = "CMADR1", Separator = "Comma" },
        ///                                                             new GroupItemModel { Name = "CMCITY", Separator = "Comma" },
        ///                                                             new GroupItemModel { Name = "CMPSTAL" }
        ///                                                         }
        ///                                     };
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
        /// <exception cref="T:System.ArgumentNullException">If <paramref name="value" /> is <strong>null</strong>.</exception>
        /// <exception cref="T:iTin.Export.Model.InvalidFieldIdentifierNameException">If <paramref name="value" /> not is a valid field identifier name.</exception>
        [XmlAttribute]
        public string Name
        {
            get => _name;
            set
            {
                SentinelHelper.ArgumentNull(value);
                SentinelHelper.IsFalse(RegularExpressionHelper.IsValidFieldName(value), new InvalidFieldIdentifierNameException(ErrorMessageHelper.FieldIdentifierNameErrorMessage("Group", "Name", value)));

                _name = value;
            }
        }
        #endregion

        #region [public] (GroupsModel) Owner: Gets the element that owns this
        /// <summary>
        /// Gets the element that owns this <see cref="T:iTin.Export.Model.GroupModel" />.
        /// </summary>
        /// <value>
        /// The <see cref="T:iTin.Export.Model.GroupsModel" /> that owns this <see cref="T:iTin.Export.Model.GroupModel" />.
        /// </value>
        [XmlIgnore]
        [Browsable(false)]
        public GroupsModel Owner => _owner;
        #endregion

        #endregion

        #region public methods

        #region [public] (void) SetOwner(GroupsModel): Sets the element that owns this
        /// <summary>
        /// Sets the element that owns this <see cref="T:iTin.Export.Model.GroupModel" />.
        /// </summary>
        /// <param name="reference">Reference to owner.</param>
        public void SetOwner(GroupsModel reference)
        {
            _owner = reference;
        }
        #endregion

        #endregion
    }
}
