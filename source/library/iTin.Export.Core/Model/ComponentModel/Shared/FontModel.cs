
namespace iTin.Export.Model
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Drawing.Text;
    using System.Linq;
    using System.Xml.Serialization;

    using Drawing.Helper;
    using Helpers;

    /// <summary>
    /// Represents a font. Defines a particular format for text, including font face, size, and style attributes.
    /// </summary>
    /// <remarks>
    /// <para>
    /// <code lang="xml" title="ITEE Object Element Usage">
    /// <![CDATA[
    /// <Font...>
    ///   <Properties/>
    /// </Font>
    /// ]]>
    /// </code>
    /// </para>
    /// <para><strong>Attributes</strong></para>
    /// <list type="table">
    ///   <listheader>
    ///     <term>Attribute</term>
    ///     <term>Optional</term>
    ///     <term>Description</term>
    ///     <term>Default</term>
    ///   </listheader>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.FontModel.Name"/></term>
    ///     <term>Yes</term>
    ///     <term>Preferred font name.</term>
    ///     <term>The default is <c>Segoe UI</c></term>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.FontModel.Size"/></term>
    ///     <term>Yes</term>
    ///     <term>Preferred font size.</term>
    ///     <term>The default is <c>10.0</c></term>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.FontModel.Color"/></term>
    ///     <term>Yes</term>
    ///     <term>Preferred font color.</term>
    ///     <term>The default is <c>Black</c></term>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.FontModel.Bold"/></term>
    ///     <term>Yes</term>
    ///     <term>Determines whether bold style is applied for this font.</term>
    ///     <term>The default is <c>No</c></term>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.FontModel.Italic"/></term>
    ///     <term>Yes</term>
    ///     <term>Determines whether italic style is applied for this font.</term>
    ///     <term>The default is <c>No</c></term>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.FontModel.Underline"/></term>
    ///     <term>Yes</term>
    ///     <term>Determines whether the underline style is applied for this font.</term>
    ///     <term>The default is <c>No</c></term>
    ///   </item>
    /// </list>
    /// <para><strong>Elements</strong></para>
    /// <list type="table">
    ///   <listheader>
    ///     <term>Element</term>
    ///     <description>Description</description>
    ///   </listheader>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.FontModel.Properties"/></term>
    ///     <description>Reference to custom properties dictionary</description>
    ///   </item>
    /// </list>
    /// <para>
    /// <para><strong>Compatibility table with native writers.</strong></para>
    /// <list type="table">
    ///   <listheader>
    ///     <term>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.CsvWriter"/></term>
    ///     <term>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.TsvWriter"/></term>
    ///     <term>SQL Script<br/><see cref="T:iTin.Export.Writers.SqlScriptWriter"/></term>
    ///     <term>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Spreadsheet2003TabularWriter"/></term>
    ///   </listheader>
    ///   <item>
    ///     <term>X</term>
    ///     <term>X</term>
    ///     <term>X</term>
    ///     <term>X</term>
    ///   </item>
    /// </list>
    /// A <c><b>X</b></c> value indicates that the writer supports this element.
    /// </para>
    /// </remarks>
    public partial class FontModel : ICloneable
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string DefaultFontName = "Segoe UI";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const float DefaultFontSize = 10.0f;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string DefaultFontColor = "Black";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo DefaultFontBold = YesNo.No;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo DefaultFontItalic = YesNo.No;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo DefaultFontUnderline = YesNo.No;
        #endregion

        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _color;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private float _size;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _name;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private YesNo _bold;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private YesNo _italic;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private YesNo _underline;
        #endregion

        #region constructor/s

        #region [public] FontModel(): Initializes a new instance of this class
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.FontModel"/> class.
        /// </summary>
        public FontModel()
        {
            Name = DefaultFontName;
            Size = DefaultFontSize;
            Color = DefaultFontColor;
            Bold = DefaultFontBold;
            Italic = DefaultFontItalic;
            Underline = DefaultFontUnderline;
        }
        #endregion

        #endregion

        #region public static properties

        #region [public] {static} (FontModel) Default: Gets default font
        /// <summary>
        /// Gets default font.
        /// </summary>
        /// <value>
        /// Default font
        /// </value>
        public static FontModel Default => new FontModel();
        #endregion

        #endregion

        #region public properties

        #region [public] (string) Name: Gets or sets preferred font name
        /// <summary>
        /// Gets or sets preferred font name.
        /// </summary>
        /// <value>
        /// Preferred font name. If specified a font name not existent be use the default font. The default is <c>Segoe UI</c>.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// <![CDATA[
        /// <Font Name="[string] | [{StaticBinding:...}]".../>
        /// ]]>
        /// </code>
        /// <para>
        /// <para><strong>Compatibility table with native writers.</strong></para>
        /// <list type="table">
        ///   <listheader>
        ///     <term>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.CsvWriter"/></term>
        ///     <term>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.TsvWriter"/></term>
        ///     <term>SQL Script<br/><see cref="T:iTin.Export.Writers.SqlScriptWriter"/></term>
        ///     <term>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Spreadsheet2003TabularWriter"/></term>
        ///   </listheader>
        ///   <item>
        ///     <term>No has effect</term>
        ///     <term>No has effect</term>
        ///     <term>No has effect</term>
        ///     <term>X</term>
        ///   </item>
        /// </list>
        /// A <c><b>X</b></c> value indicates that the writer supports this element.
        /// </para>
        /// </remarks>
        /// <example>
        /// In the following example shows how create a new font.
        /// <code lang="xml">
        /// <![CDATA[
        /// <Font Name="{StaticBinding:UseThisFontNameFromCode}" Size="8" Color="Navy" Bold="Yes" Italic="Yes" Underline="No"/>
        /// ]]>
        /// </code>
        /// <code lang="C#">
        /// var font = new FontModel
        /// {
        ///     Name = "{StaticBinding:UseThisFontNameFromCode}", // Call UseThisFontNameFromCode user-defined property when trying to get the value of font.Name
        ///     Color = "Navy",
        ///     Size = 8.0,
        ///     Bold = YesNo.Yes,
        ///     Italic = YesNo.Yes,
        ///     Underline = YesNo.No
        /// };
        /// </code>
        /// <code lang="VB#">
        /// Dim font = New FontModel With
        /// {
        ///     .Name = "{StaticBinding:UseThisFontNameFromCode}", ' Call UseThisFontNameFromCode user-defined property when trying to get the value of font.Name
        ///     .Color = "Navy",
        ///     .Size = 8.0,
        ///     .Bold = YesNo.Yes,
        ///     .Italic = YesNo.Yes,
        ///     .Underline = YesNo.No
        /// }
        /// </code>
        /// </example>
        [XmlAttribute]
        [DefaultValue(DefaultFontName)]
        public string Name
        {
            get => GetStaticBindingValue(_name);
            set
            {
                var isValidName = false;
                if (!string.IsNullOrEmpty(value))
                {
                    var isValidFont = IsValidFontName(value);
                    if (isValidFont)
                    {
                        isValidName = true;
                    }
                }

                _name = isValidName
                    ? value
                    : DefaultFontName;
            }
        }
        #endregion

        #region [public] (float) Size: Gets or sets preferred font size
        /// <summary>
        /// Gets or sets preferred font size.
        /// </summary>
        /// <value>
        /// Preferred font size. The default is <c>10.0</c>.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// <![CDATA[
        /// <Font Name="[float] | [{StaticBinding:...}]".../>
        /// ]]>
        /// </code>
        /// <para>
        /// <para><strong>Compatibility table with native writers.</strong></para>
        /// <list type="table">
        ///   <listheader>
        ///     <term>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.CsvWriter"/></term>
        ///     <term>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.TsvWriter"/></term>
        ///     <term>SQL Script<br/><see cref="T:iTin.Export.Writers.SqlScriptWriter"/></term>
        ///     <term>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Spreadsheet2003TabularWriter"/></term>
        ///   </listheader>
        ///   <item>
        ///     <term>No has effect</term>
        ///     <term>No has effect</term>
        ///     <term>No has effect</term>
        ///     <term>X</term>
        ///   </item>
        /// </list>
        /// A <strong><c>X</c></strong> value indicates that the writer this element.
        /// </para>
        /// </remarks>
        /// <example>
        /// In the following example shows how create a new font.
        /// <code lang="xml">
        /// <![CDATA[
        /// <Font Name="Tahoma" Size="8" Color="Navy" Bold="Yes" Italic="Yes" Underline="No"/>
        /// ]]>
        /// </code>
        /// <code lang="C#">
        /// var font = new FontModel
        /// {
        ///     Name = "Tahoma",
        ///     Color = "Navy",
        ///     Size = 8.0,
        ///     Bold = YesNo.Yes,
        ///     Italic = YesNo.Yes,
        ///     Underline = YesNo.No
        /// };
        /// </code>
        /// <code lang="VB#">
        /// Dim font = New FontModel With
        /// {
        ///     .Name = "Tahoma",
        ///     .Color = "Navy",
        ///     .Size = 8.0,
        ///     .Bold = YesNo.Yes,
        ///     .Italic = YesNo.Yes,
        ///     .Underline = YesNo.No
        /// }
        /// </code>
        /// </example>
        [XmlAttribute]
        [DefaultValue(DefaultFontSize)]
        public float Size
        {
            get => float.Parse(GetStaticBindingValue($"{_size}"));
            set
            {
                SentinelHelper.ArgumentLessThan("value", value, 0.0f);

                _size = value;
            }
        }
        #endregion

        #region [public] (string) Color: Gets or sets preferred font color
        /// <summary>
        /// Gets or sets preferred font color.
        /// </summary>
        /// <value>
        /// Preferred font color. The default is <c>Black</c>.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// <![CDATA[
        /// <Font Color="[colorName] | [#rrggbb] | [#rgb] | [sc#rrggbb] | [{StaticBinding:...}]".../>
        /// ]]>
        /// </code>
        /// <para>
        /// <para><strong>Compatibility table with native writers.</strong></para>
        /// <list type="table">
        ///   <listheader>
        ///     <term>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.CsvWriter"/></term>
        ///     <term>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.TsvWriter"/></term>
        ///     <term>SQL Script<br/><see cref="T:iTin.Export.Writers.SqlScriptWriter"/></term>
        ///     <term>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Spreadsheet2003TabularWriter"/></term>
        ///   </listheader>
        ///   <item>
        ///     <term>No has effect</term>
        ///     <term>No has effect</term>
        ///     <term>No has effect</term>
        ///     <term>X</term>
        ///   </item>
        /// </list>
        /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
        /// </para>
        /// </remarks>
        /// <example>
        /// In the following example shows how create a new font.
        /// <code lang="xml">
        /// <![CDATA[
        /// <Font Name="Tahoma" Size="8" Color="Navy" Bold="Yes" Italic="Yes" Underline="No"/>
        /// ]]>
        /// </code>
        /// <code lang="C#">
        /// var font = new FontModel
        /// {
        ///     Name = "Tahoma",
        ///     Color = "Navy",
        ///     Size = 8.0,
        ///     Bold = YesNo.Yes,
        ///     Italic = YesNo.Yes,
        ///     Underline = YesNo.No
        /// };
        /// </code>
        /// <code lang="VB#">
        /// Dim font = New FontModel With
        /// {
        ///     .Name = "Tahoma",
        ///     .Color = "Navy",
        ///     .Size = 8.0,
        ///     .Bold = YesNo.Yes,
        ///     .Italic = YesNo.Yes,
        ///     .Underline = YesNo.No
        /// }
        /// </code>
        /// </example>
        [XmlAttribute]
        [DefaultValue(DefaultFontColor)]
        public string Color
        {
            get => GetStaticBindingValue(_color);
            set
            {
                SentinelHelper.ArgumentNull(value);

                _color = value;
            }
        }
        #endregion

        #region [public] (YesNo) Bold: Gets or sets a value indicating whether bold style is applied for this font
        /// <summary>
        /// Gets or sets a value indicating whether bold style is applied for this font.
        /// </summary>
        /// <value>
        /// <see cref="T:iTin.Export.Model.YesNo.Yes" /> if bold style is applied for this font; otherwise, <see cref="T:iTin.Export.Model.YesNo.No" />. The default is <c>No</c>.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// <![CDATA[
        /// <Font Bold="[Yes|No] | [{StaticBinding:...}]".../>
        /// ]]>
        /// </code>
        /// <para>
        /// <para><strong>Compatibility table with native writers.</strong></para>
        /// <list type="table">
        ///   <listheader>
        ///     <term>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.CsvWriter"/></term>
        ///     <term>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.TsvWriter"/></term>
        ///     <term>SQL Script<br/><see cref="T:iTin.Export.Writers.SqlScriptWriter"/></term>
        ///     <term>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Spreadsheet2003TabularWriter"/></term>
        ///   </listheader>
        ///   <item>
        ///     <term>No has effect</term>
        ///     <term>No has effect</term>
        ///     <term>No has effect</term>
        ///     <term>X</term>
        ///   </item>
        /// </list>
        /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
        /// </para>
        /// </remarks>
        /// <example>
        /// In the following example shows how create a new font.
        /// <code lang="xml">
        /// <![CDATA[
        /// <Font Name="Tahoma" Size="8" Color="Navy" Bold="Yes" Italic="Yes" Underline="No"/>
        /// ]]>
        /// </code>
        /// <code lang="C#">
        /// var font = new FontModel
        /// {
        ///     Name = "Tahoma",
        ///     Color = "Navy",
        ///     Size = 8.0,
        ///     Bold = YesNo.Yes,
        ///     Italic = YesNo.Yes,
        ///     Underline = YesNo.No
        /// };
        /// </code>
        /// <code lang="VB#">
        /// Dim font = New FontModel With
        /// {
        ///     .Name = "Tahoma",
        ///     .Color = "Navy",
        ///     .Size = 8.0,
        ///     .Bold = YesNo.Yes,
        ///     .Italic = YesNo.Yes,
        ///     .Underline = YesNo.No
        /// }
        /// </code>
        /// </example>
        [XmlAttribute]
        [DefaultValue(DefaultFontBold)]
        public YesNo Bold
        {
            get => GetStaticBindingValue(_bold.ToString()).ToUpperInvariant() == "NO" ? YesNo.No : YesNo.Yes;
            set
            {
                SentinelHelper.IsEnumValid(value);

                _bold = value;
            }
        }
        #endregion

        #region [public] (YesNo) Italic: Gets or sets a value indicating whether italic style is applied for this font
        /// <summary>
        /// Gets or sets a value indicating whether italic style is applied for this font.
        /// </summary>
        /// <value>
        /// <see cref="T:iTin.Export.Model.YesNo.Yes" /> if italic style is applied for this font; otherwise, <see cref="T:iTin.Export.Model.YesNo.No" />. The default is <c>No</c>.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// <![CDATA[
        /// <Font Italic="[Yes|No] | [{StaticBinding:...}]".../>
        /// ]]>
        /// </code>
        /// <para>
        /// <para><strong>Compatibility table with native writers.</strong></para>
        /// <list type="table">
        ///   <listheader>
        ///     <term>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.CsvWriter"/></term>
        ///     <term>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.TsvWriter"/></term>
        ///     <term>SQL Script<br/><see cref="T:iTin.Export.Writers.SqlScriptWriter"/></term>
        ///     <term>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Spreadsheet2003TabularWriter"/></term>
        ///   </listheader>
        ///   <item>
        ///     <term>No has effect</term>
        ///     <term>No has effect</term>
        ///     <term>No has effect</term>
        ///     <term>X</term>
        ///   </item>
        /// </list>
        /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
        /// </para>
        /// </remarks>
        /// <example>
        /// In the following example shows how create a new font.
        /// <code lang="xml">
        /// <![CDATA[
        /// <Font Name="Tahoma" Size="8" Color="Navy" Bold="Yes" Italic="Yes" Underline="No"/>
        /// ]]>
        /// </code>
        /// <code lang="C#">
        /// var font = new FontModel
        /// {
        ///     Name = "Tahoma",
        ///     Color = "Navy",
        ///     Size = 8.0,
        ///     Bold = YesNo.Yes,
        ///     Italic = YesNo.Yes,
        ///     Underline = YesNo.No
        /// };
        /// </code>
        /// <code lang="VB#">
        /// Dim font = New FontModel With
        /// {
        ///     .Name = "Tahoma",
        ///     .Color = "Navy",
        ///     .Size = 8.0,
        ///     .Bold = YesNo.Yes,
        ///     .Italic = YesNo.Yes,
        ///     .Underline = YesNo.No
        /// }
        /// </code>
        /// </example>
        [XmlAttribute]
        [DefaultValue(DefaultFontItalic)]
        public YesNo Italic
        {
            get => GetStaticBindingValue(_italic.ToString()).ToUpperInvariant() == "NO" ? YesNo.No : YesNo.Yes;
            set
            {
                SentinelHelper.IsEnumValid(value);

                _italic = value;
            }
        }
        #endregion

        #region [public] (YesNo) Underline: Gets or sets a value indicating whether the underline style is applied for this font
        /// <summary>
        /// Gets or sets a value indicating whether the underline style is applied for this font.
        /// </summary>
        /// <value>
        /// <see cref="iTin.Export.Model.YesNo.Yes" /> if the underline style is applied for this font; otherwise, <see cref="iTin.Export.Model.YesNo.No" />. The default is <see cref="iTin.Export.Model.YesNo.No" />.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// <![CDATA[
        /// <Font Underline="[Yes|No] | [{StaticBinding:...}]".../>
        /// ]]>
        /// </code>
        /// <para>
        /// <para><strong>Compatibility table with native writers.</strong></para>
        /// <list type="table">
        ///   <listheader>
        ///     <term>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.CsvWriter"/></term>
        ///     <term>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.TsvWriter"/></term>
        ///     <term>SQL Script<br/><see cref="T:iTin.Export.Writers.SqlScriptWriter"/></term>
        ///     <term>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Spreadsheet2003TabularWriter"/></term>
        ///   </listheader>
        ///   <item>
        ///     <term>No has effect</term>
        ///     <term>No has effect</term>
        ///     <term>No has effect</term>
        ///     <term>X</term>
        ///   </item>
        /// </list>
        /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
        /// </para>
        /// </remarks>
        /// <example>
        /// In the following example shows how create a new font.
        /// <code lang="xml">
        /// <![CDATA[
        /// <Font Name="Tahoma" Size="8" Color="Navy" Bold="Yes" Italic="Yes" Underline="No"/>
        /// ]]>
        /// </code>
        /// <code lang="C#">
        /// var font = new FontModel
        /// {
        ///     Name = "Tahoma",
        ///     Color = "Navy",
        ///     Size = 8.0,
        ///     Bold = YesNo.Yes,
        ///     Italic = YesNo.Yes,
        ///     Underline = YesNo.No
        /// };
        /// </code>
        /// <code lang="VB#">
        /// Dim font = New FontModel With
        /// {
        ///     .Name = "Tahoma",
        ///     .Color = "Navy",
        ///     .Size = 8.0,
        ///     .Bold = YesNo.Yes,
        ///     .Italic = YesNo.Yes,
        ///     .Underline = YesNo.No
        /// }
        /// </code>
        /// </example>
        [XmlAttribute]
        [DefaultValue(DefaultFontUnderline)]
        public YesNo Underline
        {
            get => GetStaticBindingValue(_underline.ToString()).ToUpperInvariant() == "NO" ? YesNo.No : YesNo.Yes;
            set
            {
                SentinelHelper.IsEnumValid(value);

                _underline = value;
            }
        }
        #endregion

        #region [public] (FontStyle) FontStyle: Gets a value that represents the different styles defined for this font
        /// <summary>
        /// Gets a value that represents the different styles defined for this font.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.Drawing.FontStyle" /> value that represents the different styles defined for this font.
        /// </value>
        public FontStyle FontStyles
        {
            get
            {
                var fontStyles = FontStyle.Regular;
                if (Bold == YesNo.Yes)
                {
                    fontStyles = fontStyles | FontStyle.Bold;
                }

                if (Italic == YesNo.Yes)
                {
                    fontStyles = fontStyles | FontStyle.Italic;
                }

                if (Underline == YesNo.Yes)
                {
                    fontStyles = fontStyles | FontStyle.Underline;
                }

                return fontStyles;
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
        public override bool IsDefault => Name.Equals(DefaultFontName) &&
                                          Bold.Equals(DefaultFontBold) &&
                                          Size.Equals(DefaultFontSize) &&
                                          Color.Equals(DefaultFontColor) &&
                                          Italic.Equals(DefaultFontItalic) &&
                                          Underline.Equals(DefaultFontUnderline);
        #endregion

        #endregion

        #region public methods

        #region [public] (FontModel) Clone(): Clones this instance
        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public FontModel Clone()
        {
            var fontCloned = (FontModel)MemberwiseClone();
            fontCloned.Properties = Properties.Clone();

            return fontCloned;
        }
        #endregion

        #region [public] (void) Combine(FontModel): Combines this instance with reference parameter
        /// <summary>
        /// Combines this instance with reference parameter.
        /// </summary>
        public void Combine(FontModel reference)
        {
            if (Bold.Equals(DefaultFontBold))
            {
                Bold = reference.Bold;
            }

            if (Color.Equals(DefaultFontColor))
            {
                Color = reference.Color;
            }

            if (Italic.Equals(DefaultFontItalic))
            {
                Italic = reference.Italic;
            }

            if (Name.Equals(DefaultFontName))
            {
                Name = reference.Name;
            }

            if (Size.Equals(DefaultFontSize))
            {
                Size = reference.Size;
            }

            if (Underline.Equals(DefaultFontUnderline))
            {
                Underline = reference.Underline;
            }
        }
        #endregion

        #region [public] (Color) GetColor(): Gets a reference to the color structure preferred for this font
        /// <summary>
        /// Gets a reference to the <see cref="T:System.Drawing.Color" /> structure preferred for this font.
        /// </summary>
        /// <returns>
        /// <see cref="T:System.Drawing.Color"/> structure that represents a .NET color.
        /// </returns>
        public Color GetColor()
        {
            return ColorHelper.GetColorFromString(Color);
        }
        #endregion

        #region [public] (Font) ToFont(): Gets a reference to native .NET font representing the font model
        /// <summary>
        /// Gets a reference to native .NET font representing the font model
        /// </summary>
        /// <returns>
        /// Native .NET font representing the font model
        /// </returns>
        public Font ToFont()
        {
            return new Font(Name, Size, FontStyles, GraphicsUnit.Pixel);
        }
        #endregion

        #endregion

        #region private static methods

        #region [private] {static} (bool) IsValidFontName: Gets a value indicating whether the font is installed on this system
        /// <summary>
        /// Gets a value indicating whether the font is installed on this system.
        /// </summary>
        /// <param name="fontName">Font to check.</param>
        /// <returns>
        /// <strong>true</strong> if the font is installed on the system; otherwise, <strong>false</strong>.
        /// </returns>
        private static bool IsValidFontName(string fontName)
        {
            var ifc = new InstalledFontCollection();
            return ifc.Families.Any(font => font.Name.Equals(fontName, StringComparison.Ordinal));
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
