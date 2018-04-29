
namespace iTin.Export.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Globalization;
    using System.Linq;
    using System.Xml.Linq;
    using System.Xml.Serialization;

    using Helpers;
    using Resources;

    /// <inheritdoc />
    /// <summary>
    /// Contains a collection of pieces. Each element is a new collection of smaller fields resulting from splitting a reference field.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Belongs to: <strong><c>Fixed</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.FixedModel" />.
    /// <code lang="xml" title="ITEE Object Element Usage">
    /// &lt;Pieces ...&gt;
    ///   &lt;Piece/&gt;
    ///   &lt;Piece/&gt;
    ///   ... 
    /// &lt;/Pieces&gt;
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
    ///       <td><see cref="P:iTin.Export.Model.PiecesModel.Name" /></td>
    ///       <td align="center">No</td>
    ///       <td>Name of the collection of pieces.</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.PiecesModel.Reference" /></td>
    ///       <td align="center">No</td>
    ///       <td>Data field name reference.</td>
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
    ///     <term><see cref="P:iTin.Export.Model.PiecesModel.Pieces" /></term> 
    ///     <description>Collection of smaller fields resulting from splitting a reference field. Each element is composed of a field name and initial position and final position into the reference field.</description>
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
    public partial class FixedItemModel
    {
        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _name;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _reference;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private FixedModel _owner;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private PiecesModel _pieces;
        #endregion

        #region public properties

        #region [public] (XElement) DataSource: Gets or sets a reference to pieces data
        /// <summary>
        /// Gets or sets a reference to source data of pieces.
        /// </summary>
        /// <value>
        /// Source data of pieces.
        /// </value>
        public XElement DataSource { get; set; }
        #endregion

        #region [public] (FixedModel) Owner: Gets the element that owns this
        /// <summary>
        /// Gets the element that owns this <see cref="iTin.Export.Model.PiecesModel" />.
        /// </summary>
        /// <value>
        /// The <see cref="iTin.Export.Model.FixedModel" /> that owns this <see cref="iTin.Export.Model.PiecesModel" />.
        /// </value>
        [XmlIgnore]
        [Browsable(false)]
        public FixedModel Owner => _owner;
        #endregion

        #region [public] (string) Name: Gets or sets the name of the pieces
        /// <summary>
        /// Gets or sets the name of the pieces.
        /// </summary>
        /// <value>
        /// Name of the collection of pieces.
        /// Are only allow strings made ​​up of letters, numbers and following special chars <strong>'<c>_ - # * @ % $</c>'</strong>.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        ///   &lt;Pieces Name="string" ...&gt;
        ///     ...
        ///   &lt;/Pieces&gt;
        /// </code>
        /// <para>
        /// <para><strong>Compatibility table with native writers.</strong></para>
        /// <table>
        ///   <thead>
        ///     <tr>
        ///       <th>Comma-Separated Values<br/><see cref="iTin.Export.Writers.Native.CsvWriter"/></th>
        ///       <th>Tab-Separated Values<br/><see cref="iTin.Export.Writers.Native.TsvWriter"/></th>
        ///       <th>SQL Script<br/><see cref="iTin.Export.Writers.Native.SqlScriptWriter"/></th>
        ///       <th>XML Spreadsheet 2003<br/><see cref="iTin.Export.Writers.Native.Spreadsheet2003TabularWriter"/></th>
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
        /// <exception cref="System.ArgumentNullException">If <paramref name="value" /> is <strong>null</strong>.</exception>
        /// <exception cref="iTin.Export.Model.InvalidIdentifierNameException">If <paramref name="value" /> not is a valid identifier.</exception>
        [XmlAttribute]
        public string Name
        {
            get => _name;
            set
            {
                SentinelHelper.ArgumentNull(value);
                SentinelHelper.IsFalse(RegularExpressionHelper.IsValidIdentifier(value), new InvalidIdentifierNameException(ErrorMessageHelper.ModelIdentifierNameErrorMessage("Pieces", "Name", value)));

                _name = value;
            }
        }
        #endregion

        #region [public] (PiecesModel) Pieces: Gets or sets collection of smaller fields resulting from splitting a reference field
        /// <summary>
        /// Gets or sets collection of smaller fields resulting from splitting a reference field.
        /// </summary>
        /// <value>
        /// Collection of smaller fields resulting from splitting a reference field. Each element is composed of a field name and initial position and final position into the reference field.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Pieces&gt;
        ///   &lt;Piece .../&gt;
        ///   &lt;Piece .../&gt;
        ///   ...
        /// &lt;Pieces&gt;
        /// </code>
        /// </remarks>
        [XmlElement("Piece")]
        public PiecesModel Pieces
        {
            get => _pieces ?? (_pieces = new PiecesModel(this));
            set => _pieces = value;
        }
        #endregion

        #region [public] (string) Reference: Gets or sets the name of the reference field
        /// <summary>
        /// Gets or sets the name of the reference field.
        /// </summary>
        /// <value>
        /// Name of the reference field. Are only allow strings made ​​up of letters, numbers and following special chars <strong>'<c>_ - # * @ % $</c>'</strong>.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        ///   &lt;Pieces Reference="string" ...&gt;
        ///     ...
        ///   &lt;/Pieces&gt;
        /// </code>
        /// <para>
        /// <para><strong>Compatibility table with native writers.</strong></para>
        /// <table>
        ///   <thead>
        ///     <tr>
        ///       <th>Comma-Separated Values<br/><see cref="iTin.Export.Writers.Native.CsvWriter"/></th>
        ///       <th>Tab-Separated Values<br/><see cref="iTin.Export.Writers.Native.TsvWriter"/></th>
        ///       <th>SQL Script<br/><see cref="iTin.Export.Writers.Native.SqlScriptWriter"/></th>
        ///       <th>XML Spreadsheet 2003<br/><see cref="iTin.Export.Writers.Native.Spreadsheet2003TabularWriter"/></th>
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
        /// <exception cref="System.ArgumentNullException">If <paramref name="value" /> is <strong>null</strong>.</exception>
        /// <exception cref="iTin.Export.Model.InvalidFieldIdentifierNameException">If <paramref name="value" /> not is a valid field identifier.</exception>
        [XmlAttribute]
        public string Reference
        {
            get => _reference;
            set
            {
                SentinelHelper.ArgumentNull(value);
                SentinelHelper.IsFalse(RegularExpressionHelper.IsValidFieldName(value), new InvalidFieldIdentifierNameException(ErrorMessageHelper.FieldIdentifierNameErrorMessage("Pieces", "Reference", value)));

                _reference = value;
            }
        }
        #endregion

        #endregion

        #region public methods

        #region [public] (Dictionary<string, string>) ToDictionary(): Returns a dictionary of string/string pairs containing the name of the piece and its value
        /// <summary>
        /// Returns a dictionary of <see cref="T:System.String" />/<see cref="T:System.String" /> pairs containing the name of the piece and its value.
        /// </summary>
        /// <returns>
        /// A dictionary of <see cref="T:System.String" />/<see cref="T:System.String" /> pairs containing the name of the piece and its value.
        /// </returns>
        /// <exception cref="ArgumentNullException">Thrown if <see cref="DataSource" /> property is <strong>null</strong>.</exception>
        public Dictionary<string, string> ToDictionary()
        {
            SentinelHelper.ArgumentNull(DataSource, ErrorMessage.DataSourceNotNull);

            return Pieces.ToDictionary(piece => piece.Name, piece => piece.GetValue());
        }
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (string) ToString(): Returns a string that represents the current object
        /// <inheritdoc />
        /// <summary>
        /// Returns a string that represents the current data type.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String" /> that represents the current object.
        /// </returns>
        /// <remarks>
        /// This method <see cref="M:iTin.Export.Model.BaseModel`1.ToString" /> returns a string that includes the number of pieces defined.
        /// </remarks>
        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "Count={0}", Pieces.Count);
        }
        #endregion

        #endregion

        #region public methods

        #region [public] (void) SetOwner(FixedModel): Sets the element that owns this
        /// <summary>
        /// Sets the element that owns this <see cref="iTin.Export.Model.FixedModel" />.
        /// </summary>
        /// <param name="own">Reference to owner.</param>
        public void SetOwner(FixedModel own)
        {
            _owner = own;
        }
        #endregion

        #endregion
    }
}
