
namespace iTin.Export.Model
{
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    /// <summary>
    /// Includes the description of export table.
    /// </summary>
    /// <remarks>
    /// <para>Belongs to: <strong><c>Export</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.ExportModel" />.<br/>
    /// <code lang="xml" title="ITEE Object Element Usage">
    ///   &lt;Host&gt;
    ///    &lt;Document .../&gt;
    ///  &lt;/Host&gt;
    /// </code>
    /// </para>
    /// <para><strong>Elements</strong></para>
    /// <list type="table">
    ///   <listheader>
    ///     <term>Element</term>
    ///     <description>Description</description>
    ///   </listheader>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.HostModel.Document"/></term> 
    ///     <description>Represents a document configuration, it allow define size, orientation and margins.Represents margins of a document. Allow define top margin, right margin, bottom margin and left margin of a document.</description>
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
    public partial class HostModel
    {
        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private HostsModel _owner;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ExportModel _parent;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DocumentModel _document;
        #endregion

        #region public properties

        [XmlAttribute]
        public string Key { get; set; }

        #region [public] (DocumentModel) Document: Gets or sets a reference to document configuration, it allow define size, orientation and margins
        /// <summary>
        /// Gets or sets a reference to document configuration, it allow define size, orientation and margins.
        /// </summary>
        /// <value>
        /// Reference to document configuration, it allow define size, orientation and margins.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Host&gt;
        ///   &lt;Document .../&gt;
        ///   ...
        /// &lt;/Host&gt;
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
        public DocumentModel Document
        {
            get
            {
                if (_document == null)
                {
                    _document = new DocumentModel();
                }

                _document.SetParent(this);

                return _document;
            }
            set => _document = value;
        }
        #endregion

        #region [public] (HostsModel) Owner: Gets the element that owns this
        /// <summary>
        /// Gets the element that owns this <see cref="T:iTin.Export.Model.HostModel" />.
        /// </summary>
        /// <value>
        /// The <see cref="T:iTin.Export.Model.HostsModel" /> that owns this <see cref="T:iTin.Export.Model.HostModel" />.
        /// </value>
        [XmlIgnore]
        [Browsable(false)]
        public HostsModel Owner => _owner;
        #endregion

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default
        /// <include file='..\..\iTin.Export.Documentation.Common.xml' path='Common/Model/Public/Overrides/Properties/Property[@name="IsDefault"]/*'/>
        public override bool IsDefault => Document.IsDefault;
        #endregion

        #endregion

        #region public methods

        #region [public] (void) SetOwner(HostsModel): Sets the element that owns this
        /// <summary>
        /// Sets the element that owns this <see cref="T:iTin.Export.Model.HostModel" />.
        /// </summary>
        /// <param name="reference">Reference to owner.</param>
        public void SetOwner(HostsModel reference)
        {
            _owner = reference;
        }
        #endregion

        #endregion
    }
}
