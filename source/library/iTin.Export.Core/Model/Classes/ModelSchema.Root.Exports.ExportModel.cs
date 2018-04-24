
namespace iTin.Export.Model
{
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    using Helper;

    /// <inheritdoc />
    /// <summary>
    /// Includes the description and data table definition to export. 
    /// </summary>
    /// <remarks>
    /// <para>Belongs to: <strong><c>Exports</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.ExportsModel" />.<br />
    /// <code lang="xml" title="ITEE Object Element Usage">
    /// &lt;Export ...&gt;
    ///   &lt;Description/&gt;
    ///   &lt;BlockLines/&gt;
    ///   &lt;Table/&gt;
    /// &lt;/Export&gt;
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
    ///       <td><see cref="P:iTin.Export.Model.ExportModel.Name" /></td>
    ///       <td align="center">No</td>
    ///       <td>Name of the export.</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.ExportModel.Current" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Determines if is the current export. The default is <see cref="F:iTin.Export.Model.YesNo.No" />.</td>
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
    ///     <term><see cref="P:iTin.Export.Model.ExportModel.Description" /></term> 
    ///     <description>Description of the export.</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.ExportModel.Host" /></term> 
    ///     <description>Represents a destination host of export, Allow define document properties.</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.ExportModel.Table" /></term> 
    ///     <description>Includes the description of export data table.</description>
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
    public partial class ExportModel
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo DefaultCurrent = YesNo.No;
        #endregion

        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _name;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private YesNo _current;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private BlockLinesModel _lines;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TableModel _table;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ExportsModel _owner;
        #endregion

        #region constructor/s

        #region [public] ExportModel(): Initializes a new instance of this class.
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.ExportModel" /> class.
        /// </summary>
        public ExportModel()
        {
            Current = DefaultCurrent;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (YesNo) Current: Gets or sets a value indicating whether this definition is used
        /// <summary>
        /// Gets or sets a value indicating whether this definition is used.
        /// </summary>
        /// <value>
        /// <see cref="iTin.Export.Model.YesNo.Yes" /> if this definition is used; otherwise, <see cref="iTin.Export.Model.YesNo.No" />. The default is <see cref="iTin.Export.Model.YesNo.No" />.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Export Current="Yes|No" ...&gt;
        /// ...
        /// &lt;/Export&gt;
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
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>
        [XmlAttribute]
        [DefaultValue(DefaultCurrent)]
        public YesNo Current
        {
            get => _current;
            set
            {
                SentinelHelper.IsEnumValid(value);

                //if (Owner != null && owner.Items.Any())
                //{
                //    foreach (var model in Owner.Items)
                //    {
                //        if (model.current == YesNo.Yes)
                //        {
                //            model.Current = YesNo.No;
                //        }
                //    }
                //}

                _current = value;  
            }
        }
        #endregion

        #region [public] (string) Description: Gets or sets the description of the export
        /// <summary>
        /// Gets or sets the description of the export.
        /// </summary>
        /// <value>
        /// The description of the export.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Export ...&gt;
        ///   &lt;Description&gt;string&lt;/Description&gt;
        ///   ...
        /// &lt;/Export&gt;
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
        public string Description { get; set; }
        #endregion

        #region [public] (string) Name: Gets or sets name of the export
        /// <summary>
        /// Gets or sets name of the export.
        /// </summary>
        /// <value>
        /// The name of the export.
        /// Are only allow strings made ​​up of letters, numbers and following special chars <strong>'<c>_ - # @ % $</c>'</strong>.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Export Name="string" ...&gt;
        /// ...
        /// &lt;/Export&gt;
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
        /// <exception cref="T:iTin.Export.Model.InvalidIdentifierNameException">If <paramref name="value" /> not is a valid field identifier name.</exception>
        [XmlAttribute]
        public string Name
        {
            get => GetValueByReflection(this, _name);
            set
            {
                SentinelHelper.ArgumentNull(value);

                var isBindField = RegularExpressionHelper.IsValidStaticResource(value);
                if (!isBindField)
                {
                    SentinelHelper.IsFalse(RegularExpressionHelper.IsValidIdentifier(value), new InvalidFieldIdentifierNameException(ErrorMessageHelper.ModelIdentifierNameErrorMessage("Export", "Name", value)));
                }

                _name = value;
            }
        }
        #endregion

        #region [public] (ExportsModel) Owner: Gets the element that owns this
        /// <summary>
        /// Gets the element that owns this <see cref="T:iTin.Export.Model.ExportModel" />.
        /// </summary>
        /// <value>
        /// The <see cref="T:iTin.Export.Model.ExportsModel" /> that owns this <see cref="T:iTin.Export.Model.ExportModel" />.
        /// </value>
        [Browsable(false)]
        public ExportsModel Owner => _owner;
        #endregion

        #region [public] (GlobalResourcesModel) Resources: Gets a reference to the global resources
        /// <summary>
        /// Gets a reference to the global resources.
        /// </summary>
        /// <value>
        /// A <see cref="T:iTin.Export.Model.GlobalResourcesModel"/> reference which contains the global resources.
        /// </value>
        public GlobalResourcesModel Resources => Owner.Resources;
        #endregion

        #region [public] (BlockLinesModel) Lines: Gets or sets collection of user-defined lines
        /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Export/Public/Properties/Property[@name="BlockLines"]/*'/>
        [XmlArrayItem("Block", typeof(BlockLineModel))]
        public BlockLinesModel BlockLines
        {
            get => _lines ?? (_lines = new BlockLinesModel(this));
            set => _lines = value;
        }
        #endregion

        #region [public] (TableModel) Table: Gets or sets a reference to the definition of the table to export
        /// <summary>
        /// Gets or sets a reference to the definition of the table to export.
        /// </summary>
        /// <value>
        /// Reference to definition of table.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="IEE Object Element Usage">
        /// &lt;Export ...&gt;
        ///   &lt;Table .../&gt;
        ///   ...
        /// &lt;/Export&gt;
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
        public TableModel Table
        {
            get
            {
                if (_table == null)
                {
                    _table = new TableModel();
                }

                _table.SetParent(this);

                return _table;                    
            }
            set => _table = value;
        }
        #endregion

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default.
        /// <inheritdoc />
        /// <summary>
        /// Gets a value indicating whether this instance is default.
        /// </summary>
        /// <value>
        /// <strong>true</strong> if this instance contains the default; otherwise, <strong>false</strong>.
        /// </value>
        public override bool IsDefault => Table.IsDefault && Current.Equals(DefaultCurrent);
        #endregion

        #endregion

        #region public methods

        #region [public] (string) ParseRelativeFilePath(KnownRelativeFilePath): Gets a valid full path from a relative path
        /// <summary>
        /// Gets a valid full path from a relative path.
        /// </summary>
        /// <param name="element">The element.</param>
        /// <returns>
        /// The valid full path.
        /// </returns>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>
        public string ParseRelativeFilePath(KnownRelativeFilePath element)
        {
            SentinelHelper.IsEnumValid(element);

            return ExportsModel.GetRelativeFilePathParsed(this, element);
        }
        #endregion

        #region [public] (string) ParseRelativeFilePath(string): Gets a valid full path from a relative path
        /// <summary>
        /// Gets a valid full path from a relative path.
        /// </summary>
        /// <param name="relativePath">The relative path to parsed.</param>
        /// <returns>
        /// The valid full path.
        /// </returns>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>
        public string ParseRelativeFilePath(string relativePath)
        {
            return ExportsModel.GetRelativeFilePathParsed(this, relativePath);
        }
        #endregion

        #region [public] (void) SetOwner(ExportsModel): Sets the element that owns this
        /// <summary>
        /// Sets the element that owns this <see cref="T:iTin.Export.Model.ExportModel" />.
        /// </summary>
        /// <param name="reference">Reference to owner.</param>
        internal void SetOwner(ExportsModel reference)
        {
            _owner = reference;
        }
        #endregion

        #endregion
    }
}

//#region [public] (string) CallingAssemblyPath: Gets or sets the calling assembly path.
///// <summary>
///// Gets or sets the calling assembly path.
///// </summary>
///// <value>
///// The calling assembly path.
///// </value>
//[XmlIgnore]
//public string CallingAssemblyPath { get; set; }
//#endregion
