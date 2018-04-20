
namespace iTin.Export.Model
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using System.Xml.Serialization;

    using ComponentModel;
    using Helper;

    /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Table/Class[@name="info"]/*'/>
    public partial class TableModel
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string DefaultAlias = "";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string DefaultHost = "";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo DefaultAutoFilter = YesNo.No;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo DefaultShowGridLines = YesNo.Yes;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo DefaultAutoFitColumns = YesNo.No;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo DefaultShowColumnHeaders = YesNo.Yes;
        #endregion

        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private YesNo autoFilter;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private LocationModel location;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ColumnHeadersModel headers;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private YesNo showGridLines;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private YesNo showColumnHeaders;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string name;
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private LogoModel logo;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ExportModel parent;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private YesNo autoFitColumns;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ChartsModel charts;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private FieldsModel fields;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private OutputModel output;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ExporterModel exporter;
        #endregion

        #region constructor/s

        #region [public] TableModel(): Initializes a new instance of this class
        /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Table/Public/Constructors/Constructor[@name="ctor1"]/*'/>
        public TableModel()
        {
            Host = DefaultHost;
            Alias = DefaultAlias;
            AutoFilter = DefaultAutoFilter;
            ShowGridLines = DefaultShowGridLines;
            AutoFitColumns = DefaultAutoFitColumns;
            ShowColumnHeaders = DefaultShowColumnHeaders;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (string) Alias: Gets or sets the alias of the table
        /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Table/Public/Properties/Property[@name="Alias"]/*'/>
        [XmlAttribute]
        [DefaultValue(DefaultAlias)]
        public string Alias { get; set; }
        #endregion

        #region [public] (YesNo) AutoFilter: Gets or sets a value indicating whether displays the autofilter
        /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Table/Public/Properties/Property[@name="AutoFilter"]/*'/>
        [XmlAttribute]
        [DefaultValue(DefaultAutoFilter)]
        public YesNo AutoFilter
        {
            get => autoFilter;
            set
            {
                SentinelHelper.IsEnumValid(value);

                autoFilter = value;
            }
        }
        #endregion

        #region [public] (YesNo) AutoFitColumns: Gets or sets a value indicating whether adjusts column width automatically
        /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Table/Public/Properties/Property[@name="AutoFitColumns"]/*'/>
        [XmlAttribute]
        [DefaultValue(DefaultAutoFitColumns)]
        public YesNo AutoFitColumns
        {
            get => autoFitColumns;
            set
            {
                SentinelHelper.IsEnumValid(value);

                autoFitColumns = value;
            }
        }
        #endregion

        #region [public] (string) Host: Gets or sets the host of the table
        /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Table/Public/Properties/Property[@name="Alias"]/*'/>
        [XmlAttribute]
        [DefaultValue(DefaultHost)]
        public string Host { get; set; }
        #endregion

        #region [public] (string) Name: Gets or sets name of the table
        /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Table/Public/Properties/Property[@name="Name"]/*'/>
        [XmlAttribute]
        public string Name
        {
            get => name;
            set
            {
                SentinelHelper.ArgumentNull(value);
                SentinelHelper.IsFalse(RegularExpressionHelper.IsValidIdentifier(value), new InvalidFieldIdentifierNameException(ErrorMessageHelper.ModelIdentifierNameErrorMessage("Table", "Name", value)));

                name = value;
            }
        }
        #endregion

        #region [public] (YesNo) ShowGridLines: Gets or sets a value indicating whether show grid lines
        /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Table/Public/Properties/Property[@name="ShowGridLines"]/*'/>
        [XmlAttribute]
        [DefaultValue(DefaultShowGridLines)]
        public YesNo ShowGridLines
        {
            get => showGridLines;
            set
            {
                SentinelHelper.IsEnumValid(value);

                showGridLines = value;
            }
        }
        #endregion

        #region [public] (YesNo) ShowColumnHeaders: Gets or sets a value indicating whether show column headers
        /// <summary>
        /// Gets or sets the show column headers.
        /// </summary>
        /// <value>
        /// The show column headers.
        /// </value>
        [XmlAttribute]
        [DefaultValue(DefaultShowColumnHeaders)]
        public YesNo ShowColumnHeaders
        {
            get => showColumnHeaders;
            set
            {
                SentinelHelper.IsEnumValid(value);

                showColumnHeaders = value;
            }
        }
        #endregion

        #region [public] (bool) HasFields: Gets a value indicating whether there are fields defined
        /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Table/Public/Properties/Property[@name="HasFields"]/*'/>
        public bool HasFields => Fields.Any();
        #endregion

        #region [public] (OutputModel) Output: Gets or sets a reference to output configuration model, it includes path and file name
        /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Table/Public/Properties/Property[@name="Output"]/*'/>
        public OutputModel Output
        {
            get
            {
                if (output == null)
                {
                    output = new OutputModel();
                }

                output.SetParent(this);

                return output;
            }
            set => output = value;
        }
        #endregion

        #region [public] (LocationModel) Location: Gets or sets a reference which contains the location of the table in the host
        /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Table/Public/Properties/Property[@name="Location"]/*'/>
        public LocationModel Location
        {
            get => location ?? (location = new LocationModel());
            set => location = value;
        }
        #endregion

        #region [public] (LogoModel) Logo: Gets or sets a reference to the logo model defined for this table
        /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Table/Public/Properties/Property[@name="Logo"]/*'/>
        public LogoModel Logo
        {
            get
            {
                if (logo == null)
                {
                    logo = new LogoModel();
                }

                logo.SetParent(this);

                return logo;
            }
            set => logo = value;
        }
        #endregion

        #region [public] (ExporterModel) Exporter: Gets or sets a reference to the exporter model defined for this table
        /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Table/Public/Properties/Property[@name="Exporter"]/*'/>
        public ExporterModel Exporter
        {
            get
            {
                if (exporter == null)
                {
                    exporter = new ExporterModel();
                }

                exporter.SetParent(this);

                return exporter;
            }
            set => exporter = value;
        }
        #endregion

        #region [public] (ColumnHeadersModel) Headers: Gets or sets collection of column headers
        /// <summary>
        /// Gets or sets the headers.
        /// </summary>
        /// <value>
        /// The headers.
        /// </value>
        [XmlArrayItem("Header", typeof(ColumnHeaderModel))]
        public ColumnHeadersModel Headers
        {
            get => headers ?? (headers = new ColumnHeadersModel(this));
            set => headers = value;
        }
        #endregion

        #region [public] (FieldsModel) Fields: Gets or sets collection of data fields
        /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Table/Public/Properties/Property[@name="Fields"]/*'/>
        [XmlArrayItem("Field", typeof(DataFieldModel))]
        [XmlArrayItem("Fixed", typeof(FixedFieldModel))]
        [XmlArrayItem("Gap", typeof(GapFieldModel))]
        [XmlArrayItem("Group", typeof(GroupFieldModel))]
        [XmlArrayItem("Packet", typeof(PacketFieldModel))]
        public FieldsModel Fields
        {
            get => fields ?? (fields = new FieldsModel(this));
            set => fields = value;
        }
        #endregion

        #region [public] (ChartsModel) Charts: Gets or sets collection of user-defined charts
        /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Table/Public/Properties/Property[@name="Charts"]/*'/>
        [XmlArrayItem("Chart", typeof(ChartModel))]
        public ChartsModel Charts
        {
            get => charts ?? (charts = new ChartsModel(this));
            set => charts = value;
        }
        #endregion

        #region [public] (ExportModel) Parent: Gets the parent container of the table
        /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Table/Public/Properties/Property[@name="Parent"]/*'/>
        [Browsable(false)]
        public ExportModel Parent => parent;
        #endregion

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance contains the default
        /// <inheritdoc />
        /// <include file="..\..\iTin.Export.Documentation.Common.xml" path="Common/Model/Public/Overrides/Properties/Property[@name=&quot;IsDefault&quot;]/*" />
        [Browsable(false)]
        public override bool IsDefault => Fields.IsDefault &&
                                          Output.IsDefault &&
                                          Headers.IsDefault &&
                                          Exporter.IsDefault &&
                                          Location.IsDefault &&
                                          Host.Equals(DefaultHost) &&
                                          Alias.Equals(DefaultAlias) &&
                                          AutoFilter.Equals(DefaultAutoFilter) &&
                                          ShowGridLines.Equals(DefaultShowGridLines) &&
                                          AutoFitColumns.Equals(DefaultAutoFitColumns) &&
                                          ShowColumnHeaders.Equals(DefaultShowColumnHeaders);
        //Logo.IsDefault &&
        //Charts.IsDefault &&
        #endregion

        #endregion

        #region public methods

        #region [public] (IEnumerable<KeyValuePair<BaseDataFieldModel, Size>>) GetHeaderColumnsSize(IAdapter): Gets a dictionary containing the pair of header column number / size in pixels of the same
        /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Table/Public/Methods/Method[@name="GetHeaderColumnsSize"]/*'/>
        public IEnumerable<KeyValuePair<BaseDataFieldModel, Size>> GetHeaderColumnsSize(IAdapter adapter)
        {
            SentinelHelper.ArgumentNull(adapter);

            ////var data = target.ToXml().ToList();
            var columns = new Dictionary<BaseDataFieldModel, Size>();
            var flds = Fields.GetRange(KnownFieldType.Field);
            foreach (var baseDataFieldModel in flds)
            {
                var fld = (DataFieldModel) baseDataFieldModel;
                var header = fld.Header;
                var headerText = fld.Alias;

                ////var style = this.Styles[header.Style];
                var style = Parent.Owner.Resources.Styles[header.Style];
                using (var font = style.Font.ToFont())
                {
                    //var longestValue = data.Select(d => d.Attributes(target.Parse(fld.Name)).First().Value).OrderByDescending(item => item.Trim().Length).FirstOrDefault().Trim();
                    //if (longestValue.Length > headerText.Length)
                    //{
                    //    headerText = longestValue;
                    //}

                    if (AutoFilter == YesNo.Yes)
                    {
                        if (headerText.Equals(fld.Alias))
                        {
                            headerText = string.Concat(headerText, "    ");
                        }
                    }

                    var textSize = TextRenderer.MeasureText(headerText, font);
                    columns.Add(fld, textSize);
                }
            }

            return columns;
        }
        #endregion
        
        #endregion

        #region public override methods

        #region [public] {override} (string) ToString(): Returns a string that represents the current object
        /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Table/Public/Overrides/Methods/Method[@name="ToString"]/*'/>
        public override string ToString()
        {
            return $"Name=\"{Name}\", Type={Exporter.ExporterType}";
        }
        #endregion

        #endregion

        #region internal methods

        #region [internal] (void) SetParent(ExportModel): Sets the parent element of the element
        /// <include file='..\..\iTin.Export.Documentation.Common.xml' path='Common/Model/Internal/Methods/Method[@name="SetParent"]/*'/>
        internal void SetParent(ExportModel reference)
        {
            parent = reference;
        }
        #endregion

        #endregion
    }
}
