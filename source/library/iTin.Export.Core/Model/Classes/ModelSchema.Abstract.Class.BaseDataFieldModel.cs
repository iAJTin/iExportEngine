
namespace iTin.Export.Model
{
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Linq;
    using System.Xml.Serialization;

    /// <summary>
    /// Base class for the different types of data fields supported by <strong><c>iTin Export Engine</c></strong>.<br/>
    /// Which acts as the base class for different data fields.
    /// </summary>
    /// <remarks>
    ///   <para>
    ///   The following table shows different data fields.
    ///   </para>
    ///   <list type="table">
    ///     <listheader>
    ///       <term>Class</term>
    ///       <description>Description</description>
    ///     </listheader>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Model.DataFieldModel"/></term>
    ///       <description>Represents a data field.</description>
    ///     </item>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Model.FixedFieldModel"/></term>
    ///       <description>Represents a piece of a field fixed-width data.</description>
    ///     </item>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Model.GapFieldModel"/></term>
    ///       <description>Represents an empty data field.</description>
    ///     </item>
    ///   <item>
    ///     <term><see cref="T:iTin.Export.Model.GroupFieldModel"/> (inherits of <see cref="T:iTin.Export.Model.DataFieldModel"/>)</term>
    ///     <description>Represents a field as union of several data field.</description>
    ///   </item>
    ///   </list>
    /// </remarks>
    public partial class BaseDataFieldModel
    {
        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _alias;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private FieldsModel _owner;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private XElement _dataSource;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private FieldValueModel _value;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private FieldHeaderModel _header;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private FieldAggregateModel _aggregate;
        #endregion

        #region public abstract properties

        #region [public] {override} (KnownFieldType) FieldType: Gets a value indicating data field type
        /// <summary>
        /// Gets a value indicating data field type.
        /// </summary>
        /// <value>
        /// One of the <see cref="T:iTin.Export.Model.KnownFieldType" /> values.
        /// </value>
        public abstract KnownFieldType FieldType { get; }
        #endregion

        #endregion

        #region public properties

        #region [public] (FieldAggregateModel) Aggregate: Gets or sets a reference that contains the visual setting of aggregate function of the data field
        /// <summary>
        /// Gets or sets a reference that contains the visual setting of aggregate function of the data field.
        /// </summary>
        /// <value>
        /// Visual setting of aggregate function of the data field.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Field|Fixed|Gap|Group ...&gt;
        ///   &lt;Aggregate .../&gt;
        ///   ...
        /// &lt;/Field|Fixed|Gap|Group&gt;
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
        ///       <td align="center">X</td>
        ///     </tr>
        ///   </tbody>
        /// </table>
        /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
        /// </para>
        /// </remarks>
        /// <example>
        /// In the following example shows how create a data field.
        /// <code lang="xml">
        ///   &lt;Field Name="##LINE" Alias="Line"&gt;
        ///     &lt;Header Style="CommonHeader" Show="Yes"/&gt;
        ///     &lt;Value Style="LineValue"/&gt;
        ///     &lt;Aggregate Style="TopAggregate" Type="Count" Location="Top" Show="Yes"/&gt;
        ///   &lt;/Field&gt;
        /// </code>
        /// <code lang="cs">
        /// DataFieldModel lineField = new DataFieldModel
        ///                                {
        ///                                    Name = "##LINE",
        ///                                    Alias = "Line",
        ///                                    Value = new FieldValueModel { Style = "LineValue" },
        ///                                    Header = new FieldHeaderModel { Style = "CommonHeader", Show = YesNo.Yes },
        ///                                    Aggregate = new FieldAggregateModel
        ///                                                    {
        ///                                                        Show = YesNo.Yes,
        ///                                                        Style = "TopAggregate", 
        ///                                                        Location = KnownAggregateLocation.Top,
        ///                                                        AggregateType = KnownAggregateType.Count,
        ///                                                    },
        ///                                };
        /// </code>
        /// </example>
        public FieldAggregateModel Aggregate
        {
            get
            {
                if (_aggregate == null)
                {
                    _aggregate = new FieldAggregateModel();
                }

                _aggregate.SetParent(this);

                return _aggregate;
            }
            set => _aggregate = value;
        }
        #endregion

        #region [public] (string) Alias: Gets or sets the alias of data field.
        /// <summary>
        /// Gets or sets the alias of data field.
        /// </summary>
        /// <value>
        /// The alias of data field. This value is used as the column header.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Field|Fixed|Gap|Group Alias="string" ...&gt;
        ///   ...
        /// &lt;/Field|Fixed|Gap|Group&gt;
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
        /// &lt;Field Name="##LINE" Alias="Line"&gt;
        /// ...
        /// &lt;/Field&gt;
        /// </code>
        /// <code lang="cs">
        /// DataFieldModel lineField = new DataFieldModel
        ///                                {
        ///                                    Name = "##LINE",
        ///                                    Alias = "Line",
        ///                                    Value = new FieldValueModel { Style = "LineValue" },
        ///                                    Header = new FieldHeaderModel { Style = "CommonHeader", Show = YesNo.Yes },
        ///                                    Aggregate = new FieldAggregateModel
        ///                                                    {
        ///                                                        Show = YesNo.Yes,
        ///                                                        Style = "TopAggregate", 
        ///                                                        Location = KnownAggregateLocation.Top,
        ///                                                        AggregateType = KnownAggregateType.Count,
        ///                                                    },
        ///                                };
        /// </code>
        /// </example>
        [XmlAttribute]
        public string Alias
        {
            get
            {
                return GetValueByReflection(Owner.Parent.Parent, _alias);
            }
            set
            {
                _alias = value;
            }
        }

        #endregion

        #region [public] (XElement) DataSource: Gets or sets a reference for pieces data.
        /// <summary>
        /// Gets or sets a reference for pieces data.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.Xml.Linq.XElement" /> that contains the pieces data.
        /// </value>
        /// <exception cref="T:System.InvalidOperationException">If not supported for this data field.</exception>
        public XElement DataSource
        {
            get
            {
                return _dataSource;
            }
            set
            {
                if (CanSetData)
                {
                    _dataSource = value;
                }
                ////else
                ////{
                ////    throw new InvalidOperationException("InvalidOperation_DataSourceNotSupported");
                ////}
            }
        }
        #endregion

        #region [public] (FieldHeaderModel) Header: Gets or sets a reference that contains the visual setting of header the data field.
        /// <summary>
        /// Gets or sets a reference that contains the visual setting of header the data field.
        /// </summary>
        /// <value>
        /// Visual setting of header the data field.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Field|Fixed|Gap|Group ...&gt;
        ///    &lt;Header .../&gt;
        ///   ...
        /// &lt;/Field|Fixed|Gap|Group&gt;
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
        ///       <td align="center">X</td>
        ///     </tr>
        ///   </tbody>
        /// </table>
        /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
        /// </para>
        /// </remarks>
        /// <example>
        /// In the following example shows how create a data field.
        /// <code lang="xml">
        ///   &lt;Field Name="##LINE" Alias="Line"&gt;
        ///     &lt;Header Style="CommonHeader" Show="Yes"/&gt;
        ///     &lt;Value Style="LineValue"/&gt;
        ///     &lt;Aggregate Style="TopAggregate" Type="Count" Location="Top" Show="Yes"/&gt;
        ///   &lt;/Field&gt;
        /// </code>
        /// <code lang="cs">
        /// DataFieldModel lineField = new DataFieldModel
        ///                                {
        ///                                    Name = "##LINE",
        ///                                    Alias = "Line",
        ///                                    Value = new FieldValueModel { Style = "LineValue" },
        ///                                    Header = new FieldHeaderModel { Style = "CommonHeader", Show = YesNo.Yes },
        ///                                    Aggregate = new FieldAggregateModel
        ///                                                    {
        ///                                                        Show = YesNo.Yes,
        ///                                                        Style = "TopAggregate", 
        ///                                                        Location = KnownAggregateLocation.Top,
        ///                                                        AggregateType = KnownAggregateType.Count,
        ///                                                    },
        ///                                };
        /// </code>
        /// </example>
        public FieldHeaderModel Header
        {
            get
            {
                if (_header == null)
                {
                    _header = new FieldHeaderModel();
                }

                _header.SetParent(this);

                return _header;
            }
            set
            {
                _header = value;
            }
        }
        #endregion

        #region [public] (FieldsModel) Owner: Gets the element that owns this.
        /// <summary>
        /// Gets the element that owns this data field.
        /// </summary>
        /// <value>
        /// The <see cref="T:iTin.Export.Model.FieldsModel" /> that owns this data field.
        /// </value>
        [XmlIgnore]
        [Browsable(false)]
        public FieldsModel Owner
        {
            get { return _owner; }
        }
        #endregion

        #region [public] (FieldValueModel) Value: Gets or sets a reference that contains the visual setting of value the data field.
        /// <summary>
        /// Gets or sets a reference that contains the visual setting of value the data field.
        /// </summary>
        /// <value>
        /// Visual setting of value the data field.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Field|Fixed|Gap|Group ...&gt;
        ///   &lt;Value .../&gt;
        ///   ...
        /// &lt;/Field|Fixed|Gap|Group&gt;
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
        ///       <td align="center">X</td>
        ///     </tr>
        ///   </tbody>
        /// </table>
        /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
        /// </para>
        /// </remarks>
        /// <example>
        /// In the following example shows how create a data field.
        /// <code lang="xml">
        ///   &lt;Field Name="##LINE" Alias="Line"&gt;
        ///     &lt;Header Style="CommonHeader" Show="Yes"/&gt;
        ///     &lt;Value Style="LineValue"/&gt;
        ///     &lt;Aggregate Style="TopAggregate" Type="Count" Location="Top" Show="Yes"/&gt;
        ///   &lt;/Field&gt;
        /// </code>
        /// <code lang="cs">
        /// DataFieldModel lineField = new DataFieldModel
        ///                                {
        ///                                    Name = "##LINE",
        ///                                    Alias = "Line",
        ///                                    Value = new FieldValueModel { Style = "LineValue" },
        ///                                    Header = new FieldHeaderModel { Style = "CommonHeader", Show = YesNo.Yes },
        ///                                    Aggregate = new FieldAggregateModel
        ///                                                    {
        ///                                                        Show = YesNo.Yes,
        ///                                                        Style = "TopAggregate", 
        ///                                                        Location = KnownAggregateLocation.Top,
        ///                                                        AggregateType = KnownAggregateType.Count,
        ///                                                    },
        ///                                };
        /// </code>
        /// </example>
        public FieldValueModel Value
        {
            get
            {
                if (_value == null)
                {
                    _value = new FieldValueModel();
                }

                _value.SetParent(this);

                return _value;
            }
            set
            {
                _value = value;
            }
        }
        #endregion

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance contains the default
        /// <inheritdoc />
        /// <summary>
        /// Gets a value indicating whether this instance contains the default.
        /// </summary>
        /// <value>
        /// <strong>true</strong> if this instance contains the default; otherwise, <strong>false</strong>.
        /// </value>
        public override bool IsDefault => Value.IsDefault &&
                                          Header.IsDefault && 
                                          Aggregate.IsDefault;
        #endregion

        #endregion

        #region protected virtual properties

        #region [protected] {virtual} (bool) CanSetData: When overridden in a derived class, gets a value indicating whether the current data field supports data
        /// <summary>
        /// When overridden in a derived class, gets a value indicating whether the current data field supports data.
        /// </summary>
        /// <value>
        /// <strong>true</strong> if the data field supports data; otherwise, <strong>false</strong>.
        /// </value>
        protected virtual bool CanSetData => true;
        #endregion

        #endregion

        #region public static methods

        #region [public] {static} (string) GetFieldNameFrom(BaseDataFieldModel): Gets the name of field
        /// <summary>
        /// Gets the name of field.
        /// </summary>
        /// <param name="field">The field.</param>
        /// <returns>
        /// Returns name of specified field.
        /// </returns>
        public static string GetFieldNameFrom(BaseDataFieldModel field)
        {
            var fieldName = string.Empty;

            switch (field.FieldType)
            {
                case KnownFieldType.Field:
                    var dataField = (DataFieldModel)field;
                    fieldName = dataField.Name;
                    break;

                case KnownFieldType.Group:
                    var groupField = (GroupFieldModel)field;
                    fieldName = groupField.Name;
                    break;

                case KnownFieldType.Fixed:
                    var fixedField = (FixedFieldModel)field;
                    fieldName = fixedField.Piece;
                    break;

                case KnownFieldType.Packet:
                    var packetField = (PacketFieldModel)field;
                    fieldName = packetField.Name;
                    break;
            }

            return fieldName;
        }
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
        /// This method <see cref="DataFieldModel.ToString()"/> returns a string that includes field alias.
        /// </remarks>
        public override string ToString()
        {
            return $"Alias=\"{Alias}\"";
        }
        #endregion

        #endregion

        #region public methods

        #region [public] (void) SetOwner(FieldsModel): Sets the element that owns this
        /// <summary>
        /// Sets the element that owns this data field.
        /// </summary>
        /// <param name="reference">Reference to owner.</param>
        public void SetOwner(FieldsModel reference)
        {
            _owner = reference;
        }
        #endregion

        #endregion    
    }
}
