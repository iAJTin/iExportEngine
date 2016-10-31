using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

using iTin.Export.Helper;

namespace iTin.Export.Model
{
    /// <summary>
    /// Represents the visual setting of title. Includes a text, visibility, orientation, border and font.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Belongs to: <strong><c>Chart</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.ChartModel" />.
    /// <code lang="xml" title="AEE Object Element Usage">
    /// &lt;Title&gt;
    ///   &lt;Text/&gt;
    ///   &lt;Border/&gt;
    ///   &lt;Font/&gt;
    /// &lt;/Border&gt;
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
    ///       <td><see cref="P:iTin.Export.Model.ChartTitleModel.Show" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Determines whether displays the title. The default is <see cref="iTin.Export.Model.YesNo.Yes" />.</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.ChartTitleModel.Orientation" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Preferred orientation for the title. The default is <see cref="iTin.Export.Model.KnownAxisOrientation.Horizontal" />.</td>
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
    ///     <term><see cref="P:iTin.Export.Model.ChartTitleModel.Border" /></term> 
    ///     <description>Reference that contains the visual setting for border of title.</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.ChartTitleModel.Font" /></term> 
    ///     <description>Reference to font model defined for this title.</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.ChartTitleModel.Text" /></term> 
    ///     <description>The text of the title.</description>
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
    ///       <td align="center">No has effect</td>
    ///     </tr>
    ///   </tbody>
    /// </table>
    /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
    /// </para>
    /// </remarks>
    public partial class ChartTitleModel
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string DefaultText = "";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo DefaultShow = YesNo.Yes;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const KnownAxisOrientation DefaultOrientation = KnownAxisOrientation.Horizontal;
        #endregion

        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private YesNo show;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private FontModel font;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ChartModel parent;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ChartBorderModel border;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private KnownAxisOrientation orientation;
        #endregion
        
        #region constructor/s

            #region [public] ChartTitleModel(): Initializes a new instance of this class.
            /// <summary>
            /// Initializes a new instance of the <see cref="ChartTitleModel" /> class.
            /// </summary>
            public ChartTitleModel()
            {
                Show = DefaultShow;
                Text = DefaultText;
                Orientation = DefaultOrientation;
            }
            #endregion

        #endregion

        #region public properties

            #region [public] (ChartBorderModel) Border: Gets or sets a reference that contains the visual setting for border of title.
            /// <summary>
            /// Gets or sets a reference that contains the visual setting for border of title.
            /// </summary>
            /// <value>
            /// A <see cref="T:iTin.Export.Model.ChartBorderModel" /> reference that contains the visual setting for border of title.
            /// </value>
            /// <remarks>
            /// <code lang="xml" title="AEE Object Element Usage">
            /// &lt;Title ...&gt;
            ///   &lt;Border/&gt;
            ///   ...
            /// &lt;/Title&gt;
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
            ///       <td align="center">No has effect</td>
            ///     </tr>
            ///   </tbody>
            /// </table>
            /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
            /// </para>
            /// </remarks>
            public ChartBorderModel Border
            {
                get
                {
                    return border ?? (border = new ChartBorderModel());
                }
                set
                {
                    border = value;
                }
            }
            #endregion

            #region [public] (FontModel) Font: Gets or sets a reference to the font model defined for this title.
            /// <summary>
            /// Gets or sets a reference to the font model defined for this title.
            /// </summary>
            /// <value>
            /// Reference to the font model defined for this title.
            /// </value>
            /// <remarks>
            /// <code lang="xml" title="AEE Object Element Usage">
            /// &lt;Title ...&gt;
            ///   &lt;Font/&gt;
            ///   ...
            /// &lt;/Title&gt;
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
            ///       <td align="center">No has effect</td>
            ///     </tr>
            ///   </tbody>
            /// </table>
            /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
            /// </para>
            /// </remarks>
            public FontModel Font
            {
                get
                {
                    return font ?? (font = new FontModel());
                }
                set
                {
                    font = value;
                }
            }
            #endregion

            #region [public] (KnownAxisOrientation) Orientation: Gets or sets preferred orientation for the title.
            /// <summary>
            /// Gets or sets preferred orientation for the title.
            /// </summary>
            /// <value>
            /// Preferred orientation for the title. The default is <see cref="iTin.Export.Model.KnownAxisOrientation.Horizontal" />.
            /// </value>
            /// <remarks>
            /// <code lang="xml" title="AEE Object Element Usage">
            /// &lt;Title Orientation="Downward|Horizontal|Upward|Vertical" ...&gt;
            ///   ...
            /// &lt;/Title&gt;
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
            ///       <td align="center">No has effect</td>
            ///     </tr>
            ///   </tbody>
            /// </table>
            /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
            /// </para>
            /// </remarks>
            /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>
            [XmlAttribute]
            [DefaultValue(DefaultOrientation)]
            public KnownAxisOrientation Orientation
            {
                get
                {
                    return orientation;
                }
                set
                {
                    SentinelHelper.IsEnumValid(value);

                    orientation = value;
                }
            }
            #endregion

            #region [public] (ChartModel) Parent: Gets the parent element of the element.
            /// <summary>
            /// Gets the parent element of the element.
            /// </summary>
            /// <value>
            /// The element that represents the container element of the element.
            /// </value>
            [Browsable(false)]
            public ChartModel Parent
            {
                get { return parent; }
            }
            #endregion

            #region [public] (YesNo) Show: Gets or sets a value that determines whether displays the title.
            /// <summary>
            /// Gets or sets a value that determines whether displays the title.
            /// </summary>
            /// <value>
            /// <see cref="iTin.Export.Model.YesNo.Yes" /> if displays the title; otherwise, <see cref="iTin.Export.Model.YesNo.No" />. The default is <see cref="iTin.Export.Model.YesNo.Yes" />.
            /// </value>
            /// <remarks>
            /// <code lang="xml" title="AEE Object Element Usage">
            /// &lt;Title Show="Yes|No" ...&gt;
            ///   ...
            /// &lt;/Title&gt;
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
            ///       <td align="center">No has effect</td>
            ///     </tr>
            ///   </tbody>
            /// </table>
            /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
            /// </para>
            /// </remarks>
            /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>
            [XmlAttribute]
            [DefaultValue(DefaultShow)]
            public YesNo Show
            {
                get
                {
                    return show;
                }
                set
                {
                    SentinelHelper.IsEnumValid(value);

                    show = value;
                }
            }
            #endregion

            #region [public] (string) Text: Gets or sets text of title.
            /// <summary>
            /// Gets or sets text of title.
            /// </summary>
            /// <value>
            /// The text of title.
            /// </value>
            /// <remarks>
            /// <code lang="xml" title="AEE Object Element Usage">
            /// &lt;Title ...&gt;
            ///   &lt;Text&gt;string&lt;/Text&gt;
            ///   ...
            /// &lt;/Title&gt;
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
            ///       <td align="center">No has effect</td>
            ///     </tr>
            ///   </tbody>
            /// </table>
            /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
            /// </para>
            /// </remarks>
            public string Text { get; set; }
            #endregion

        #endregion

        #region public override properties

            #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default.
            /// <include file='..\..\iTin.Export.Documentation.Common.xml' path='Common/Model/Public/Overrides/Properties/Property[@name="IsDefault"]/*'/>
            public override bool IsDefault
            {
                get
                {
                    return 
                        Font.IsDefault &&
                        Border.IsDefault &&
                        Show.Equals(DefaultShow) &&
                        string.IsNullOrEmpty(Text) &&
                        Orientation.Equals(DefaultOrientation);
                }
            }
            #endregion

        #endregion

        #region internal methods

            #region [internal] (void) SetParent(ChartModel): Sets the parent element of the element.
            /// <summary>
            /// Sets the parent element of the element.
            /// </summary>
            /// <param name="reference">Reference to parent.</param>
            internal void SetParent(ChartModel reference)
            {
                parent = reference;
            }
            #endregion

        #endregion
    }
}
