using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

using iTin.Export.Helper;

namespace iTin.Export.Model
{
    /// <summary>
    /// Represents margins of a document. Allow define top margin, right margin, bottom margin and left margin of a document. 
    /// All margins are measured in <c>mm</c>.
    /// </summary>
    /// <remarks>
    /// <para>
    /// <code lang="xml" title="AEE Object Element Usage">
    /// &lt;Margins .../&gt;
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
    ///       <td><see cref="P:iTin.Export.Model.MarginsModel.Units" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Preferred units of margins. The default is <see cref="iTin.Export.Model.KnownUnit.Inches" />.</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.MarginsModel.Top" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Preferred top margin of document measured in <c>mm</c>. The default is "<c>20</c>".</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.MarginsModel.Right" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Preferred right margin of document measured in <c>mm</c>. The default is "<c>20</c>".</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.MarginsModel.Bottom" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Preferred bottom margin of document measured in <c>mm</c>. The default is "<c>20</c>".</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.MarginsModel.Left" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Preferred left margin of document measured in <c>mm</c>. The default is "<c>20</c>".</td>
    ///     </tr>
    ///   </tbody>
    /// </table>
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
    public partial class MarginsModel
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const float DefaultTop = 20f;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const float DefaultLeft = 20f;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const float DefaultRight = 20f;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const float DefaultBottom = 20f;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const KnownUnit DefaultUnits = KnownUnit.Inches;
        #endregion

        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private float _top;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private float _right;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private float _bottom;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private float _left;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private KnownUnit _unit;
        #endregion

        #region constructor/s

            #region [public] MarginsModel(): Initializes a new instance of this class.
            /// <summary>
            /// Initializes a new instance of the <see cref="T:iTin.Export.Model.MarginsModel"/> class.
            /// </summary>
            public MarginsModel()
            {
                Top = DefaultTop;
                Left = DefaultLeft;
                Right = DefaultRight;
                Bottom = DefaultBottom;
                Units = DefaultUnits;
            }
            #endregion

        #endregion

        #region public static properties

            #region [public] {static} (MarginsModel) Default: Gets default margins.
            /// <summary>
            /// Gets default Margins.
            /// </summary>
            /// <value>
            /// Default Margins.
            /// </value>
            public static MarginsModel Default
            {
                get { return new MarginsModel(); }
            }
        #endregion

        #endregion

        #region public properties

            #region [public] (float) Bottom: Gets or sets the preferred bottom margin of document.
            /// <summary>
            /// Gets or sets the preferred bottom margin of document.
            /// </summary>
            /// <value>
            /// Preferred bottom margin of document. The default is <c>20</c>.
            /// </value>
            /// <remarks>
            /// <code lang="xml" title="AEE Object Element Usage">
            /// &lt;Margins Bottom="float".../&gt;
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
            /// In the following example shows how create a new margins object.
            /// <code lang="xml">
            /// &lt;Margins Top="23" Left="23" Right="23" Bottom="23"/&gt;
            /// </code>
            /// <code lang="cs">
            /// MarginsModel margins = new MarginsModel
            ///                            {
            ///                                Top = 23,
            ///                                Left = 23,
            ///                                Right = 23,
            ///                                Bottom = 23
            ///                            };
            /// </code>
            /// </example>
            [XmlAttribute]
            [DefaultValue(DefaultBottom)]
            public float Bottom
            {
                get
                {
                    return _bottom;
                }
                set
                {
                    SentinelHelper.IsTrue(value < 0, "El margen no puede ser menor que cero");

                    _bottom = value;
                }
            }
            #endregion

            #region [public] (float) Left: Gets or sets the preferred left margin of document.
            /// <summary>
            /// Gets or sets the preferred left margin of document.
            /// </summary>
            /// <value>
            /// Preferred left margin of document. The default is <c>20</c>.
            /// </value>
            /// <remarks>
            /// <code lang="xml" title="AEE Object Element Usage">
            /// &lt;Margins Left="float".../&gt;
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
            /// In the following example shows how create a new margins object.
            /// <code lang="xml">
            /// &lt;Margins Top="23" Left="23" Right="23" Bottom="23"/&gt;
            /// </code>
            /// <code lang="cs">
            /// MarginsModel margins = new MarginsModel
            ///                            {
            ///                                Top = 23,
            ///                                Left = 23,
            ///                                Right = 23,
            ///                                Bottom = 23
            ///                            };
            /// </code>
            /// </example>
            [XmlAttribute]
            [DefaultValue(DefaultLeft)]
            public float Left
            {
                get
                {
                    return _left;
                }
                set
                {
                    SentinelHelper.IsTrue(value < 0, "El margen no puede ser menor que cero");

                    _left = value;
                }
            }
        #endregion

            #region [public] (float) Right: Gets or sets the preferred right margin of document.
            /// <summary>
            /// Gets or sets the preferred right margin of document.
            /// </summary>
            /// <value>
            /// Preferred right margin of document. The default is <c>20</c>.
            /// </value>
            /// <remarks>
            /// <code lang="xml" title="AEE Object Element Usage">
            /// &lt;Margins Right="float".../&gt;
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
            /// In the following example shows how create a new margins object.
            /// <code lang="xml">
            /// &lt;Margins Top="23" Left="23" Right="23" Bottom="23"/&gt;
            /// </code>
            /// <code lang="cs">
            /// MarginsModel margins = new MarginsModel
            ///                            {
            ///                                Top = 23,
            ///                                Left = 23,
            ///                                Right = 23,
            ///                                Bottom = 23
            ///                            };
            /// </code>
            /// </example>
            [XmlAttribute]
            [DefaultValue(DefaultRight)]
            public float Right
            {
                get
                {
                    return _right;
                }
                set
                {
                    SentinelHelper.IsTrue(value < 0, "El margen no puede ser menor que cero");

                    _right = value;
                }
            }
        #endregion

            #region [public] (float) Top: Gets or sets the preferred top margin of document.
            /// <summary>
            /// Gets or sets the preferred top margin of document.
            /// </summary>
            /// <value>
            /// Preferred top margin of document. The default is <c>20</c>.
            /// </value>
            /// <remarks>
            /// <code lang="xml" title="AEE Object Element Usage">
            /// &lt;Margins Top="float".../&gt;
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
            /// In the following example shows how create a new margins object.
            /// <code lang="xml">
            /// &lt;Margins Top="23" Left="23" Right="23" Bottom="23"/&gt;
            /// </code>
            /// <code lang="cs">
            /// MarginsModel margins = new MarginsModel
            ///                            {
            ///                                Top = 23,
            ///                                Left = 23,
            ///                                Right = 23,
            ///                                Bottom = 23
            ///                            };
            /// </code>
            /// </example>
            [XmlAttribute]
            [DefaultValue(DefaultTop)]
            public float Top
            {
                get
                {
                    return _top;
                }
                set
                {
                    SentinelHelper.IsTrue(value < 0, "El margen no puede ser menor que cero");

                    _top = value;
                }
            }
            #endregion

            #region [public] (KnownUnit) Units: Gets or sets the preferred units of margins.
            /// <summary>
            /// Gets or sets the preferred units of margins. 
            /// </summary>
            /// <value>
            /// A value of the enumeration <see cref="T:iTin.Export.Model.KnownUnit" />. The default is <see cref="iTin.Export.Model.KnownUnit.Inches" />.
            /// </value>
            /// <remarks>
            /// <code lang="xml" title="AEE Object Element Usage">
            /// &lt;Margins Units="inches|milimeters" ...&gt;
            /// ...
            /// &lt;/Margins&gt;
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
            /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>
            [XmlAttribute]
            [DefaultValue(DefaultUnits)]
            public KnownUnit Units
            {
                get
                {
                    return _unit;
                }
                set
                {
                    SentinelHelper.IsEnumValid(value);

                    _unit = value;
                }
            }
            #endregion

        #endregion

        #region public override properties

            #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default.
            /// <summary>
            /// Gets a value indicating whether this instance is default.
            /// </summary>
            /// <value>
            /// <strong>true</strong> if this instance contains the default; otherwise, <strong>false</strong>.
            /// </value>
            public override bool IsDefault
            {
                get
                {
                    return
                        Top.Equals(DefaultTop) &&
                        Right.Equals(DefaultRight) &&
                        Left.Equals(DefaultLeft) &&
                        Bottom.Equals(DefaultBottom) &&
                        Units.Equals(DefaultUnits);
                }
            }
            #endregion

        #endregion     
    }
}
