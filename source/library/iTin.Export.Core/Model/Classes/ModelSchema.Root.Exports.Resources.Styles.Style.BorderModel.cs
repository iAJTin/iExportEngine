
namespace iTin.Export.Model
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Xml.Serialization;

    using Drawing.Helper;

    /// <summary>
    /// Includes definition for a font type, type of content, such as the background color, the alignment type and the data type.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Belongs to: <strong><c>Styles</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.StylesModel" />.
    /// <code lang="xml" title="AEE Object Element Usage">
    /// &lt;Style&gt;
    ///   &lt;Content&gt;
    ///     &lt;Alignment/&gt;
    ///     &lt;Numeric/&gt; | &lt;Currency/&gt; | &lt;Percentage/&gt; | &lt;Scientific/&gt; | &lt;Datetime/&gt; | &lt;Special/&gt; &lt;Text/&gt;
    ///   &lt;/Content&gt;
    ///   &lt;Font/&gt;
    /// &lt;/Style&gt;
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
    ///       <td><see cref="P:iTin.Export.Model.StyleModel.Name" /></td>
    ///       <td align="center">No</td>
    ///       <td>Name of the style.</td>
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
    ///     <term><see cref="P:iTin.Export.Model.StyleModel.Content" /></term>
    ///     <description>Defines as shown the content of a field.</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.StyleModel.Font" /></term>
    ///     <description>Represents a font. Defines a particular format for text, including font face, size, and style attributes.</description>
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
    public partial class BorderModel : ICloneable
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string DefaultColor = "Transparent";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const KnownBorderLineStyle DefaultLineStyle = KnownBorderLineStyle.None;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const KnownWidthLineStyle DefaultWidthLineStyle = KnownWidthLineStyle.Hairline;
        #endregion

        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private BordersModel _owner;
        #endregion

        #region public static properties

        #region [public] {static} (BorderModel) Default: Gets a default border
        /// <summary>
        /// Gets a default border.
        /// </summary>
        /// <value>
        /// A default border.
        /// </value>
        public static BorderModel Default => Empty;
        #endregion

        #region [public] {static} (BorderModel) Empty: Gets an empty border
        /// <summary>
        /// Gets an empty border.
        /// </summary>
        /// <value>
        /// An empty border.
        /// </value>
        public static BorderModel Empty => new BorderModel();
        #endregion

        #endregion

        #region constructor/s

        #region [public] BorderModel(): Initializes a new instance of this class
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.BorderModel"/> class.
        /// </summary>
        public BorderModel()
        {
            Color = DefaultColor;
            LineStyle = DefaultLineStyle;
            Weight = DefaultWidthLineStyle;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (string) Color: Gets or sets preferred border color
        /// <summary>
        /// Gets or sets preferred border color.
        /// </summary>
        /// <value>
        /// Preferred border color. The default is "<c>Transparent</c>".
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="AEE Object Element Usage">
        /// &lt;Border Color="string" .../&gt;
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
        /// In the following example shows how create a new border.
        /// <code lang="xml">
        /// &lt;Border Position="Bottom" Color="Navy"/&gt;
        /// </code>
        /// <code lang="cs">
        /// BorderModel border = new BorderModel
        ///                          {
        ///                              Position = KnownBorderPosition.Bottom,
        ///                              Color = "Navy"
        ///                          };
        /// </code>
        /// </example>
        [XmlAttribute]
        [DefaultValue(DefaultColor)]
        public string Color { get; set; }
        #endregion

        #region [public] (bool) IsEmpty: Gets a value indicating whether this style is an empty style
        /// <summary>
        /// Gets a value indicating whether this style is an empty style.
        /// </summary>
        /// <value>
        /// <strong>true</strong> if is an empty style; otherwise, <strong>false</strong>.
        /// </value>
        public bool IsEmpty => IsDefault;
        #endregion

        #region [public] (KnownBorderLineStyle) LineStyle: Gets or sets preferred border line style
        /// <summary>
        /// Gets or sets preferred border line style.
        /// </summary>
        /// <value>
        /// Preferred border line style. The default is <see cref="P:iTin.Export.Model.KnownBorderLineStyle.None"/>.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="AEE Object Element Usage">
        /// &lt;Border LineStyle="None|Continuous|Dash|Dot|DashDot|DashDotDot|SlantDashDot|Double" .../&gt;
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
        /// In the following example shows how create a new border.
        /// <code lang="xml">
        /// &lt;Border Position="Bottom" Color="Navy" LineStyle="Dash"/&gt;
        /// </code>
        /// <code lang="cs">
        /// BorderModel border = new BorderModel
        ///                          {
        ///                              Position = KnownBorderPosition.Bottom,
        ///                              Color = "Navy",
        ///                              LineStyle = KnownBorderLineStyle.Dash
        ///                          };
        /// </code>
        /// </example>
        [XmlAttribute]
        [DefaultValue(DefaultLineStyle)]
        public KnownBorderLineStyle LineStyle { get; set; }
        #endregion

        #region [public] (KnownBorderPosition) Position: Gets or sets preferred border position
        /// <summary>
        /// Gets or sets preferred border position.
        /// </summary>
        /// <value>
        /// Preferred border position.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="AEE Object Element Usage">
        /// &lt;Border Position="Left|Top|Right|Bottom|DiagonalLeft|DiagonalRight" .../&gt;
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
        /// In the following example shows how create a new border.
        /// <code lang="xml">
        /// &lt;Border Position="Bottom" Color="Navy"/&gt;
        /// </code>
        /// <code lang="cs">
        /// BorderModel border = new BorderModel
        ///                          {
        ///                              Position = KnownBorderPosition.Bottom,
        ///                              Color = "Navy"
        ///                          };
        /// </code>
        /// </example>
        [XmlAttribute]
        public KnownBorderPosition Position { get; set; }
        #endregion

        #region [public] (BordersModel) Owner: Gets the element that owns this
        /// <summary>
        /// Gets the element that owns this <see cref="T:iTin.Export.Model.BorderModel" />.
        /// </summary>
        /// <value>
        /// The <see cref="T:iTin.Export.Model.BordersModel" /> that owns this <see cref="T:iTin.Export.Model.BorderModel" />.
        /// </value>
        [XmlIgnore]
        [Browsable(false)]
        public BordersModel Owner => _owner;
        #endregion

        #region [public] (KnownWidthLineStyle) Weight: Gets or sets preferred border weight
        /// <summary>
        /// Gets or sets preferred border weight.
        /// </summary>
        /// <value>
        /// Preferred border weight. The default is <see cref="P:iTin.Export.Model.KnownWidthLineStyle.Hairline"/>.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="AEE Object Element Usage">
        /// &lt;Border Weight="Hairline|Thin|Medium|Thick" .../&gt;
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
        /// In the following example shows how create a new border.
        /// <code lang="xml">
        /// &lt;Border Position="Bottom" Color="Navy" LineStyle="Dash" Weight="Thick"/&gt;
        /// </code>
        /// <code lang="cs">
        /// BorderModel border = new BorderModel
        ///                          {
        ///                              Position = KnownBorderPosition.Bottom,
        ///                              Color = "Navy",
        ///                              Weight = KnownWidthLineStyle.Thick,
        ///                              LineStyle = KnownBorderLineStyle.Dash
        ///                          };
        /// </code>
        /// </example>
        [XmlAttribute]
        [DefaultValue(DefaultWidthLineStyle)]
        public KnownWidthLineStyle Weight { get; set; }
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
        public override bool IsDefault => Color.Equals(DefaultColor) &&
                                          Weight.Equals(DefaultWidthLineStyle) &&
                                          LineStyle.Equals(DefaultLineStyle);
        #endregion

        #endregion

        #region public methods

        #region [public] (BorderModel) Clone(): Clones this instance
        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public BorderModel Clone()
        {
            var borderCloned = (BorderModel)MemberwiseClone();
            borderCloned.Properties = Properties.Clone();

            return borderCloned;
        }
        #endregion

        #region [public] (void) Combine(BorderModel): Combines this instance with reference parameter
        /// <summary>
        /// Combines this instance with reference parameter.
        /// </summary>
        public void Combine(BorderModel reference)
        {
            if (Color.Equals(DefaultColor))
            {
                Color = reference.Color;
            }

            if (LineStyle.Equals(DefaultLineStyle))
            {
                LineStyle = reference.LineStyle;
            }

            if (Weight.Equals(DefaultWidthLineStyle))
            {
                Weight = reference.Weight;
            }
        }
        #endregion

        #region [public] (Color) GetColor(): Gets a reference to the color structure preferred for this border
        /// <summary>
        /// Gets a reference to the <see cref="T:System.Drawing.Color" /> structure preferred for this border.
        /// </summary>
        /// <returns>
        /// <see cref="T:System.Drawing.Color"/> structure that represents a .NET color.
        /// </returns> 
        public Color GetColor()
        {
            return ColorHelper.GetColorFromString(Color);
        }
        #endregion

        #endregion

        #region intrenal methods

        #region [public] (void) SetOwner(BordersModel): Sets the element that owns this
        /// <summary>
        /// Sets the element that owns this <see cref="T:iTin.Export.Model.BorderModel" />.
        /// </summary>
        /// <param name="reference">Reference to owner.</param>
        internal void SetOwner(BordersModel reference)
        {
            _owner = reference;
        }
        #endregion

        #endregion

        #region private methods

        #region [private] (object) Clone(): Creates a new object that is a copy of the current instance
        /// <inheritdoc />
        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
        /// <returns>
        /// A new object that is a copy of this instance.
        /// </returns>
        object ICloneable.Clone()
        {
            return Clone();
        }
        #endregion

        #endregion
    }
}
