
namespace iTin.Export.Model
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    using Helper;
    using Resources;

    /// <inheritdoc />
    /// <summary>
    /// Represents a new field composed of a field name and initial position and final position into the reference field.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Belongs to: <strong><c>Pieces</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.PiecesModel" />.
    /// <code lang="xml" title="ITEE Object Element Usage">
    /// &lt;Piece .../&gt;
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
    ///       <td><see cref="P:iTin.Export.Model.PieceModel.Name" /></td>
    ///       <td align="center">No</td>
    ///       <td>Name of the piece.</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.PieceModel.From" /></td>
    ///       <td align="center">No</td>
    ///       <td>Initial character of the piece into field reference.</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.PieceModel.Lenght" /></td>
    ///       <td align="center">No</td>
    ///       <td>Length in characters of the piece.</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.PieceModel.Trim" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Determines whether to apply string trim mode. The default <see cref="F:iTin.Export.Model.YesNo.No" />.</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.PieceModel.TrimMode" /></td>
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
    public partial class PieceModel
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo DefaultTrim = YesNo.No;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const KnownTrimMode DefaultTrimMode = KnownTrimMode.All;
        #endregion
        
        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int _from;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private YesNo _trim;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int _lenght;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _name;
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private PiecesModel _owner;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private KnownTrimMode _trimMode;
        #endregion

        #region constructor/s

        #region [public] PieceModel(): Initializes a new instance of this class
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.PieceModel" /> class.
        /// </summary>
        public PieceModel()
        {
            Trim = DefaultTrim;
            TrimMode = DefaultTrimMode;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (int) From: Gets or sets the initial character of the piece into field reference
        /// <summary>
        /// Gets or sets the initial character of the piece into field reference.
        /// </summary>
        /// <value>
        /// The zero-based initial character position of a piece.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Piece From="int" .../&gt;
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
        /// Suppose we have the following input data:
        /// <code lang="xml">
        /// &lt;?xml version="1.0" encoding="utf-8"?&gt;
        /// &lt;ARD740>
        ///   &lt;R740D01 _x0023_LINE="10" SFLDTA="4 60027           27        55        75        13   20/02/13 " ... /&gt;
        ///   &lt;R740D01 _x0023_LINE="20" SFLDTA="4 61535            3                   2             08/03/13 " ... /&gt;
        ///   ...
        ///   ...
        /// &lt;/ARD740&gt;
        /// </code>
        /// <para>Now we create the collection of pieces:</para>
        /// <code lang="xml">
        /// &lt;Pieces Name="SFLDTA_Pieces" Reference="SFLDTA"&gt;
        ///   &lt;Piece Name="DCALL" From="0" Lenght="2"/&gt;
        ///   &lt;Piece Name="NOCOL" From="2" Lenght="16" Trim="Yes" TrimMode="All"/&gt;
        ///   &lt;Piece Name="SHOP" From="18" Lenght="10"/&gt;
        ///   &lt;Piece Name="SIT" From="28" Lenght="10"/&gt;
        ///   &lt;Piece Name="PIK" From="38" Lenght="5"/&gt;
        ///   &lt;Piece Name="PKG" From="48" Lenght="5"/&gt;
        ///   &lt;Piece Name="DUEDATE" From="53" Lenght="9" Trim="Yes" TrimMode="All"/&gt;
        /// &lt;/Pieces&gt;
        /// </code>
        /// </example>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <c>value</c> is less than zero <br/>
        /// - or - <br/>
        /// <c>value</c> is greater than length of <see cref="P:iTin.Export.Model.PiecesModel.Reference"/> property.
        /// </exception>
        [XmlAttribute]
        public int From
        {
            get => _from;
            set
            {
                if (_owner != null)
                {
                    SentinelHelper.ArgumentOutOfRange("From", value, 0, Owner.Parent.Reference.Length, ErrorMessage.PieceArgumentOutOfRange);
                }
                else
                {
                    SentinelHelper.ArgumentLessThan("From", value, 0);
                }
                                    
                _from = value;
            }
        }
        #endregion

        #region [public] (int) Lenght: Gets or sets the length in characters of the piece
        /// <summary>
        /// Gets or sets the length in characters of the piece.
        /// </summary>
        /// <value>
        /// Length in characters of the piece.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Piece Lenght="int" .../&gt;
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
        /// Suppose we have the following input data:
        /// <code lang="xml">
        /// &lt;?xml version="1.0" encoding="utf-8"?&gt;
        /// &lt;ARD740>
        ///   &lt;R740D01 _x0023_LINE="10" SFLDTA="4 60027           27        55        75        13   20/02/13 " ... /&gt;
        ///   &lt;R740D01 _x0023_LINE="20" SFLDTA="4 61535            3                   2             08/03/13 " ... /&gt;
        ///   ...
        ///   ...
        /// &lt;/ARD740&gt;
        /// </code>
        /// <para>Now we create the collection of pieces:</para>
        /// <code lang="xml">
        /// &lt;Pieces Name="SFLDTA_Pieces" Reference="SFLDTA"&gt;
        ///   &lt;Piece Name="DCALL" From="0" Lenght="2"/&gt;
        ///   &lt;Piece Name="NOCOL" From="2" Lenght="16" Trim="Yes" TrimMode="All"/&gt;
        ///   &lt;Piece Name="SHOP" From="18" Lenght="10"/&gt;
        ///   &lt;Piece Name="SIT" From="28" Lenght="10"/&gt;
        ///   &lt;Piece Name="PIK" From="38" Lenght="5"/&gt;
        ///   &lt;Piece Name="PKG" From="48" Lenght="5"/&gt;
        ///   &lt;Piece Name="DUEDATE" From="53" Lenght="9" Trim="Yes" TrimMode="All"/&gt;
        /// &lt;/Pieces&gt;
        /// </code>
        /// </example>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <c>value</c> is less than zero <br/>
        /// - or - <br/>
        /// <c>value</c> is greater than lenght of <see cref="P:iTin.Export.Model.PiecesModel.Reference"/> property minus property value <see cref="iTin.Export.Model.PieceModel.From"/>. 
        /// </exception>
        [XmlAttribute]
        public int Lenght
        {
            get => _lenght;
            set
            {
                if (_owner != null)
                {
                    SentinelHelper.ArgumentOutOfRange("Lenght", value, 0, Owner.Parent.Reference.Length - From, ErrorMessage.PieceArgumentOutOfRange);
                }
                else
                {
                    SentinelHelper.ArgumentLessThan("Lenght", value, 1);
                }

                _lenght = value;
            }
        }
        #endregion

        #region [public] (string) Name: Gets or sets name of the piece
        /// <summary>
        /// Gets or sets the name of the piece.
        /// </summary>
        /// <value>
        /// Name of the piece.
        /// Are only allow strings made ​​up of letters, numbers and following special chars <strong>'<c>_ - # * @ % $</c>'</strong>.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Piece Name="string" .../&gt;
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
        /// Suppose we have the following input data:
        /// <code lang="xml">
        /// &lt;?xml version="1.0" encoding="utf-8"?&gt;
        /// &lt;ARD740>
        ///   &lt;R740D01 _x0023_LINE="10" SFLDTA="4 60027           27        55        75        13   20/02/13 " ... /&gt;
        ///   &lt;R740D01 _x0023_LINE="20" SFLDTA="4 61535            3                   2             08/03/13 " ... /&gt;
        ///   ...
        ///   ...
        /// &lt;/ARD740&gt;
        /// </code>
        /// <para>Now we create the collection of pieces:</para>
        /// <code lang="xml">
        /// &lt;Pieces Name="SFLDTA_Pieces" Reference="SFLDTA"&gt;
        ///   &lt;Piece Name="DCALL" From="0" Lenght="2"/&gt;
        ///   &lt;Piece Name="NOCOL" From="2" Lenght="16" Trim="Yes" TrimMode="All"/&gt;
        ///   &lt;Piece Name="SHOP" From="18" Lenght="10"/&gt;
        ///   &lt;Piece Name="SIT" From="28" Lenght="10"/&gt;
        ///   &lt;Piece Name="PIK" From="38" Lenght="5"/&gt;
        ///   &lt;Piece Name="PKG" From="48" Lenght="5"/&gt;
        ///   &lt;Piece Name="DUEDATE" From="53" Lenght="9" Trim="Yes" TrimMode="All"/&gt;
        /// &lt;/Pieces&gt;
        /// </code>
        /// </example>
        /// <exception cref="System.ArgumentNullException">If <paramref name="value" /> is <strong>null</strong>.</exception>
        /// <exception cref="iTin.Export.Model.InvalidIdentifierNameException">If <paramref name="value" /> not is a valid identifier name.</exception>
        [XmlAttribute]
        public string Name
        {
            get => _name;
            set
            {
                SentinelHelper.ArgumentNull(value);
                SentinelHelper.IsFalse(RegularExpressionHelper.IsValidIdentifier(value), new InvalidIdentifierNameException(ErrorMessageHelper.ModelIdentifierNameErrorMessage("Piece", "Name", value)));

                _name = value;
            }
        }
        #endregion

        #region [public] (PiecesModel) Owner: Gets the element that owns this
        /// <summary>
        /// Gets the element that owns this <see cref="T:iTin.Export.Model.PieceModel" />.
        /// </summary>
        /// <value>
        /// The <see cref="T:iTin.Export.Model.PiecesModel" /> that owns this <see cref="T:iTin.Export.Model.PieceModel" />.
        /// </value>
        [XmlIgnore]
        [Browsable(false)]
        public PiecesModel Owner => _owner;
        #endregion

        #region [public] (YesNo) Trim: Gets or sets a value indicating whether to trim the blanks in this piece
        /// <summary>
        /// Gets or sets a value indicating whether to trim the blanks in this piece.
        /// </summary>
        /// <value>
        /// <see cref="iTin.Export.Model.YesNo.Yes" /> to trim the blanks in this piece; otherwise, <see cref="iTin.Export.Model.YesNo.No" />. The default is <see cref="iTin.Export.Model.YesNo.No" />.
        /// </value>
         /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Piece Trim="Yes|No" .../&gt;
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
        /// Suppose we have the following input data:
        /// <code lang="xml">
        /// &lt;?xml version="1.0" encoding="utf-8"?&gt;
        /// &lt;ARD740>
        ///   &lt;R740D01 _x0023_LINE="10" SFLDTA="4 60027           27        55        75        13   20/02/13 " ... /&gt;
        ///   &lt;R740D01 _x0023_LINE="20" SFLDTA="4 61535            3                   2             08/03/13 " ... /&gt;
        ///   ...
        ///   ...
        /// &lt;/ARD740&gt;
        /// </code>
        /// <para>Now we create the collection of pieces:</para>
        /// <code lang="xml">
        /// &lt;Pieces Name="SFLDTA_Pieces" Reference="SFLDTA"&gt;
        ///   &lt;Piece Name="DCALL" From="0" Lenght="2"/&gt;
        ///   &lt;Piece Name="NOCOL" From="2" Lenght="16" Trim="Yes" TrimMode="All"/&gt;
        ///   &lt;Piece Name="SHOP" From="18" Lenght="10"/&gt;
        ///   &lt;Piece Name="SIT" From="28" Lenght="10"/&gt;
        ///   &lt;Piece Name="PIK" From="38" Lenght="5"/&gt;
        ///   &lt;Piece Name="PKG" From="48" Lenght="5"/&gt;
        ///   &lt;Piece Name="DUEDATE" From="53" Lenght="9" Trim="Yes" TrimMode="All"/&gt;
        /// &lt;/Pieces&gt;
        /// </code>
        /// </example>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>
        [XmlAttribute]
        [DefaultValue(DefaultTrim)]
        public YesNo Trim
        {
            get => _trim;
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
        /// One of the <see cref="T:iTin.Export.Model.KnownTrimMode" /> values. The default is <see cref="iTin.Export.Model.KnownTrimMode.All" />.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Piece TrimMode="All|Start|End" .../&gt;
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
        /// Suppose we have the following input data:
        /// <code lang="xml">
        /// &lt;?xml version="1.0" encoding="utf-8"?&gt;
        /// &lt;ARD740>
        ///   &lt;R740D01 _x0023_LINE="10" SFLDTA="4 60027           27        55        75        13   20/02/13 " ... /&gt;
        ///   &lt;R740D01 _x0023_LINE="20" SFLDTA="4 61535            3                   2             08/03/13 " ... /&gt;
        ///   ...
        ///   ...
        /// &lt;/ARD740&gt;
        /// </code>
        /// <para>Now we create the collection of pieces:</para>
        /// <code lang="xml">
        /// &lt;Pieces Name="SFLDTA_Pieces" Reference="SFLDTA"&gt;
        ///   &lt;Piece Name="DCALL" From="0" Lenght="2"/&gt;
        ///   &lt;Piece Name="NOCOL" From="2" Lenght="16" Trim="Yes" TrimMode="All"/&gt;
        ///   &lt;Piece Name="SHOP" From="18" Lenght="10"/&gt;
        ///   &lt;Piece Name="SIT" From="28" Lenght="10"/&gt;
        ///   &lt;Piece Name="PIK" From="38" Lenght="5"/&gt;
        ///   &lt;Piece Name="PKG" From="48" Lenght="5"/&gt;
        ///   &lt;Piece Name="DUEDATE" From="53" Lenght="9" Trim="Yes" TrimMode="All"/&gt;
        /// &lt;/Pieces&gt;
        /// </code>
        /// </example>
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
        public override bool IsDefault => Trim.Equals(DefaultTrim) && TrimMode.Equals(DefaultTrimMode);
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
            SentinelHelper.ArgumentNull(_owner.Parent.DataSource, ErrorMessage.DataSourceNotNull);

            var attribute = Owner.Parent.DataSource.Attribute(Owner.Parent.Reference);
            if (attribute == null)
            {
                throw new ArgumentNullException(Owner.Parent.Reference, ErrorMessage.PiecesReferenceNull);
            }

            var originalValue = attribute.Value.Substring(From, Lenght);
            var value = ParseValue(originalValue);

            return value;
        }
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
        /// This method <see cref="M:iTin.Export.Model.PieceModel.ToString" /> returns a string that includes name, initial position and lenght.
        /// </remarks>
        public override string ToString()
        {
            return $"Name=\"{Name}\", From={From}, Lenght={Lenght}";
        }
        #endregion

        #endregion

        #region public methods

        #region [public] (void) SetOwner(PiecesModel): Sets the element that owns this
        /// <summary>
        /// Sets the element that owns this <see cref="T:iTin.Export.Model.PiecesModel" />.
        /// </summary>
        /// <param name="reference">Reference to owner.</param>
        public void SetOwner(PiecesModel reference)
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
