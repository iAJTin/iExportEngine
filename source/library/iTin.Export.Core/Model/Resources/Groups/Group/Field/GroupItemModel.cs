
namespace iTin.Export.Model
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Linq;
    using System.Xml.Serialization;

    using Helpers;
    using Resources;

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
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.GroupItemModel.Trim" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Determines whether to apply string trim mode. The default <see cref="F:iTin.Export.Model.YesNo.No" />.</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.GroupItemModel.TrimMode" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Use this attribute to specify trim mode for strings. The default is <see cref="F:iTin.Export.Model.KnownTrimMode.All" />.</td>
    ///     </tr>
    ///   </tbody>
    /// </table>
    /// <para>
    /// <para><strong>Compatibility table with native writers.</strong></para>
    /// <table>
    ///   <thead>
    ///     <tr>
    ///       <th>Comma-Separated Values<br /><see cref="T:iTin.Export.Writers.CsvWriter" /></th>
    ///       <th>Tab-Separated Values<br /><see cref="T:iTin.Export.Writers.TsvWriter" /></th>
    ///       <th>SQL Script<br /><see cref="T:iTin.Export.Writers.SqlScriptWriter" /></th>
    ///       <th>XML Spreadsheet 2003<br /><see cref="T:iTin.Export.Writers.Spreadsheet2003TabularWriter" /></th>
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

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo DefaultTrim = YesNo.No;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const KnownTrimMode DefaultTrimMode = KnownTrimMode.All;
        #endregion

        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private YesNo _trim;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _name;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupModel _owner;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private KnownTrimMode _trimMode;
        #endregion

        #region constructor/s

        #region [public] GroupItemModel(): Initializes a new instance of this class
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.GroupItemModel" /> class.
        /// </summary>
        public GroupItemModel()
        {
            Trim = DefaultTrim;
            TrimMode = DefaultTrimMode;
            Separator = DefaultSeparator;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (XElement) DataSource: Gets or sets a reference to pieces data
        /// <summary>
        /// Gets or sets a reference to source data of group.
        /// </summary>
        /// <value>
        /// Source data of pieces.
        /// </value>
        public XElement DataSource { get; set; }
        #endregion

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
        ///       <th>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.CsvWriter" /></th>
        ///       <th>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.TsvWriter" /></th>
        ///       <th>SQL Script<br/><see cref="T:iTin.Export.Writers.SqlScriptWriter" /></th>
        ///       <th>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Spreadsheet2003TabularWriter" /></th>
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
        /// <c>ITEE</c> recognizes the following strings as valid separators:
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
        ///       <th>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.CsvWriter" /></th>
        ///       <th>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.TsvWriter" /></th>
        ///       <th>SQL Script<br/><see cref="T:iTin.Export.Writers.SqlScriptWriter" /></th>
        ///       <th>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Spreadsheet2003TabularWriter" /></th>
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
        /// <code lang="xml" title="ITEE Object Element Usage">
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
        ///                               { 
        ///                                   Name = "AddressGroup",
        ///                                   Fields = new List&lt;GroupItemModel&gt;
        ///                                            {
        ///                                                new GroupItemModel { Name = "CMADR1", Separator = "Comma" },
        ///                                                new GroupItemModel { Name = "CMCITY", Separator = "Comma" },
        ///                                                new GroupItemModel { Name = "CMPSTAL" }
        ///                                            }
        ///                               };
        ///     addressGroup.SetOwner(groups);
        ///     groups.Items.Add(addressGroup);
        ///
        ///     ExportModel export = new ExportModel 
        ///                          {
        ///                              Table = 
        ///                              {
        ///                                  Name = "Sample",
        ///                                  Alias = "New table",
        ///                                  Location = new[] { 2, 2}, 
        ///                                  Groups = groups
        ///                              } 
        ///                          };
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

        #region [public] (YesNo) Trim: Gets or sets a value indicating whether to trim the blanks in this group field
        /// <summary>
        /// Gets or sets a value indicating whether to trim the blanks in this group field.
        /// </summary>
        /// <value>
        /// <see cref="T:iTin.Export.Model.YesNo.Yes" /> to trim the blanks in this group field; otherwise, <see cref="T:iTin.Export.Model.YesNo.No" />. The default is <see cref="YesNo.No" />.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Field Trim="Yes|No" .../&gt;
        /// </code>
        /// <para>
        /// <para><strong>Compatibility table with native writers.</strong></para>
        /// <table>
        ///   <thead>
        ///     <tr>
        ///       <th>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.CsvWriter" /></th>
        ///       <th>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.TsvWriter" /></th>
        ///       <th>SQL Script<br/><see cref="T:iTin.Export.Writers.SqlScriptWriter" /></th>
        ///       <th>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Spreadsheet2003TabularWriter" /></th>
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
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>
        [XmlAttribute]
        [DefaultValue(DefaultTrim)]
        public YesNo Trim
        {
            get => GetStaticBindingValue(_trim.ToString()).ToUpperInvariant() == "NO" ? YesNo.No : YesNo.Yes;
            set
            {
                SentinelHelper.IsEnumValid(value);

                _trim = value;
            }
        }
        #endregion

        #region [public] (KnownTrimMode) TrimMode: Gets or sets a value that determines trim mode for strings
        /// <summary>
        /// Gets or sets a value that determines trim mode for strings.
        /// </summary>
        /// <value>
        /// One of the <see cref="T:iTin.Export.Model.KnownTrimMode" /> values. The default is <see cref="KnownTrimMode.All" />.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Field TrimMode="All|Start|End" .../&gt;
        /// </code>
        /// <para>
        /// <para><strong>Compatibility table with native writers.</strong></para>
        /// <table>
        ///   <thead>
        ///     <tr>
        ///       <th>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.CsvWriter" /></th>
        ///       <th>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.TsvWriter" /></th>
        ///       <th>SQL Script<br/><see cref="T:iTin.Export.Writers.SqlScriptWriter" /></th>
        ///       <th>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Spreadsheet2003TabularWriter" /></th>
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
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>
        [XmlAttribute]
        [DefaultValue(DefaultTrimMode)]
        public KnownTrimMode TrimMode
        {
            get => _trimMode;
            set
            {
                SentinelHelper.IsEnumValid(value);

                _trimMode = value;
            }
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
        public override bool IsDefault =>
            string.IsNullOrEmpty(Name) &&
            Separator.Equals(DefaultSeparator) &&
            Trim.Equals(DefaultTrim) &&
            TrimMode.Equals(DefaultTrimMode);
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

        #region [public] (string) GetValue(): Returns the value containing this piece
        /// <summary>
        /// Returns the value containing this piece.
        /// </summary>
        /// <returns>
        /// The piece value.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">Thrown if <see cref="P:iTin.Export.Model.FixedItemModel.DataSource" /> is <strong>null</strong> or <see cref="P:iTin.Export.Model.PiecesModel.Reference" /> not found.</exception>
        public string GetValue()
        {
            SentinelHelper.ArgumentNull(DataSource, ErrorMessage.DataSourceNotNull);

            var attribute = DataSource.Attribute(Name);
            if (attribute == null)
            {
                throw new ArgumentNullException(Name, "The specified field doesn't exist. Make sure that exist or is well written.");
            }

            var value = ParseValue(attribute.Value);

            return value;
        }
        #endregion

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

        #region private methods

        #region [private] (string) ParseValue(string): Parses input value and applies string trim mode
        /// <summary>
        /// Parses input value and applies string trim mode.
        /// </summary>
        /// <param name="value"><see cref="T:System.String"/> to parse.</param>
        /// <returns>
        /// The parsed value.
        /// </returns>
        private string ParseValue(string value)
        {
            if (Trim != YesNo.Yes)
            {
                return value;
            }

            var result = value;
            switch (TrimMode)
            {
                case KnownTrimMode.All:
                    result = value.Trim();
                    break;

                case KnownTrimMode.Start:
                    result = value.TrimStart();
                    break;

                case KnownTrimMode.End:
                    result = value.TrimEnd();
                    break;
            }

            return result;
        }
        #endregion

        #endregion
    }
}
