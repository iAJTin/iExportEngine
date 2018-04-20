
namespace iTin.Export.Model
{
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    using Helper;

    /// <summary>
    /// Reference to the settings defined for this writer.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Belongs to: <strong><c>Template</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.TemplateModel" />.
    /// <code lang="xml" title="ITEE Object Element Usage">
    /// &lt;Settings/&gt; 
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
    ///       <td><see cref="P:iTin.Export.Model.TemplateWriterSettingsModel.FieldPrefix" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>The preferred previous delimiter for field. The default is "<c>@@</c>".</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.TemplateWriterSettingsModel.FieldSufix" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>The preferred posterior delimiter for field. The default is an empty string ("").</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.TemplateWriterSettingsModel.RecordsToShow" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Number of affected records. The default is <see cref="KnownRecordToShow.All"/>.</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.TemplateWriterSettingsModel.TrimFields" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Determines whether to apply string trim mode. The default is <see cref="iTin.Export.Model.YesNo.No"/></td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.TemplateWriterSettingsModel.TrimMode" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Use this attribute to specify trim mode for strings. The default is <see cref="iTin.Export.Model.KnownTrimMode.All"/>.</td>
    ///     </tr>
    ///   </tbody>
    /// </table>
    /// </remarks>
    public partial class TemplateWriterSettingsModel 
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string DefaultFieldSufix = "";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo DefaultTrimFields = YesNo.No;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string DefaultFieldPrefix = "@@";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const KnownTrimMode DefaultTrimMode = KnownTrimMode.All;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const KnownRecordToShow DefaultRecordsToShow = KnownRecordToShow.All;
        #endregion
        
        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private YesNo trim;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private KnownTrimMode trimMode;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private WriterModelBase parent;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private KnownRecordToShow recordsToShow;
        #endregion

        #region constructor/s

        #region [public] TemplateWriterSettingsModel(): Initializes a new instance of this class
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.TemplateWriterSettingsModel" /> class.
        /// </summary>
        public TemplateWriterSettingsModel()
        {
            TrimMode = DefaultTrimMode;
            TrimFields = DefaultTrimFields;
            FieldSufix = DefaultFieldSufix;
            FieldPrefix = DefaultFieldPrefix;
            RecordsToShow = DefaultRecordsToShow;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (string) FieldPrefix: Gets or sets the preferred previous delimiter for field
        /// <summary>
        /// Gets or sets the preferred previous delimiter for field.
        /// </summary>
        /// <value>
        /// The preferred previous delimiter for field. The default is "<c>@@</c>".
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Settings FieldPrefix="string" .../&gt;
        /// </code>
        /// </remarks>
        [XmlAttribute]
        [DefaultValue(DefaultFieldPrefix)]
        public string FieldPrefix { get; set; }
        #endregion

        #region [public] (string) FieldSufix: Gets or sets the preferred posterior delimiter for field
        /// <summary>
        /// Gets or sets the preferred posterior delimiter for field.
        /// </summary>
        /// <value>
        /// The preferred posterior delimiter for field. The default is an empty string ("").
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Settings FieldSufix="string" .../&gt;
        /// </code>
        /// </remarks>
        [XmlAttribute]
        [DefaultValue(DefaultFieldSufix)]
        public string FieldSufix { get; set; }
        #endregion

        #region [public] (WriterModelBase) Parent: Gets the parent element of the element
        /// <summary>
        /// Gets the parent element of the element.
        /// </summary>
        /// <value>
        /// The element that represents the container element of the element.
        /// </value>
        [Browsable(false)]
        public WriterModelBase Parent => parent;
        #endregion

        #region [public] (KnownRecordToShow) RecordsToShow: Gets or sets number of affected records
        /// <summary>
        /// Gets or sets number of affected records.
        /// </summary>
        /// <value>
        /// Number of affected records. The default is <see cref="iTin.Export.Model.KnownRecordToShow.All"/>.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Settings RecordsToShow="All|First|Last|Random" .../&gt;
        /// </code>
        /// </remarks>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>
        [XmlAttribute]
        [DefaultValue(DefaultRecordsToShow)]
        public KnownRecordToShow RecordsToShow
        {
            get => recordsToShow;
            set
            {
                SentinelHelper.IsEnumValid(value);

                recordsToShow = value;
            }
        }
        #endregion

        #region [public] (YesNo) TrimFields: Gets or sets a value indicating whether to trim the blanks
        /// <summary>
        /// Gets or sets a value indicating whether to trim the blanks.
        /// </summary>
        /// <value>
        /// <see cref="iTin.Export.Model.YesNo.Yes" /> to trim the blanks; otherwise, <see cref="iTin.Export.Model.YesNo.No" />. The default is <see cref="iTin.Export.Model.YesNo.No" />.
        /// </value>
         /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Settings TrimFields="Yes|No" .../&gt;
        /// </code>
        /// </remarks>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>
        [XmlAttribute]
        [DefaultValue(DefaultTrimFields)]
        public YesNo TrimFields
        {
            get => trim;
            set
            {
                SentinelHelper.IsEnumValid(value);

                trim = value;
            }
        }
        #endregion

        #region [public] (KnownTrimMode) TrimMode: Gets or sets a value that determines trim mode for strings
        /// <summary>
        /// Gets or sets a value that determines trim mode for strings.
        /// </summary>
        /// <value>
        /// One of the <see cref="T:iTin.Export.Model.KnownTrimMode" /> values. The default is <see cref="iTin.Export.Model.KnownTrimMode.All" />.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Settings TrimMode="All|Start|End" .../&gt;
        /// </code>
        /// </remarks>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>
        [XmlAttribute]
        [DefaultValue(DefaultTrimMode)]
        public KnownTrimMode TrimMode
        {
            get => trimMode;
            set
            {
                SentinelHelper.IsEnumValid(value);

                trimMode = value;
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
        public override bool IsDefault => TrimMode.Equals(DefaultTrimMode) &&
                                          TrimFields.Equals(DefaultTrimFields) &&
                                          FieldSufix.Equals(DefaultFieldSufix) &&
                                          FieldPrefix.Equals(DefaultFieldPrefix) &&
                                          RecordsToShow.Equals(DefaultRecordsToShow);
        #endregion

        #endregion

        #region internal methods

        #region [internal] (void) SetParent(WriterModelBase): Sets the parent element of the element
        /// <summary>
        /// Sets the parent element of the element.
        /// </summary>
        /// <param name="reference">Reference to parent.</param>
        internal void SetParent(WriterModelBase reference)
        {
            parent = reference;
        }
        #endregion

        #endregion
    }
}
