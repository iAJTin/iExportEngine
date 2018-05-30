
namespace iTin.Export.Model
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Xml.Serialization;

    using Drawing.Helper;
    using Helpers;

    /// <summary>
    /// Defines as shown the content of a field.
    /// </summary>
    /// <seealso cref="T:iTin.Export.Model.BaseModel{T:iTin.Export.Model.ContentModel}"/>
    /// <seealso cref="T:System.ICloneable" />
    /// <remarks>
    /// <para>
    /// Belongs to: <strong><c>Style</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.StyleModel"/>.
    /// <code lang="xml" title="IEE Object Element Usage">
    /// <![CDATA[
    /// <Content>
    ///   <Alignment/>
    ///   <Number/> | <Currency/> | <Percentage/> | <Scientific/> | <Datetime/> | <Special/> | <Text/>
    ///   <Properties/>
    /// </Content>
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
    ///     <term><see cref="P:iTin.Export.Model.ContentModel.AlternateColor"/></term>
    ///     <term>Yes</term>
    ///     <term>Alternative color preferred of content.</term>
    ///     <term>The default is <c>Transparent</c></term>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.ContentModel.Color"/></term>
    ///     <term>Yes</term>
    ///     <term>Preferred content color.</term>
    ///     <term>The default is <c>Transparent</c></term>
    ///   </item>
    /// </list>
    /// <para><strong>Elements</strong></para>
    /// <list type="table">
    ///   <listheader>
    ///     <term>Element</term>
    ///     <description>Description</description>
    ///   </listheader>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.ContentModel.Alignment"/></term>
    ///     <description>Reference to content distribution.</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.ContentModel.DataType"/></term>
    ///     <description>Reference to content data type.</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.ContentModel.Pattern"/></term>
    ///     <description>Reference to fill pattern.</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.ContentModel.Properties"/></term>
    ///     <description>Reference to custom properties dictionary</description>
    ///   </item>
    /// </list>
    /// <para>
    /// <para><strong>Compatibility table with native writers.</strong></para>
    /// <list type="table">
    ///   <listheader>
    ///     <term>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.CsvWriter"/></term>
    ///     <term>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.TsvWriter"/></term>
    ///     <term>SQL Script<br/><see cref="T:iTin.Export.Writers.Native.SqlScriptWriter"/></term>
    ///     <term>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Native.Spreadsheet2003TabularWriter"/></term>
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
    public partial class ContentModel : ICloneable
    {
        #region private constants
        /// <summary>
        /// The default color
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string DefaultColor = "Transparent";
        #endregion

        #region private members
        /// <summary>
        /// The color
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _color;

        /// <summary>
        /// The parent
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private StyleModel _parent;

        /// <summary>
        /// The pattern
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private PatternModel _pattern;

        /// <summary>
        /// The alternate color
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _alternateColor;

        /// <summary>
        /// The data type
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private BaseDataTypeModel _dataType;

        /// <summary>
        /// The alignment
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ContentAlignmentModel _alignment;
        #endregion

        #region constructor/s

        #region [public] ContentModel(): Initializes a new instance of this class
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.ContentModel" /> class.
        /// </summary>
        public ContentModel()
        {
            Color = DefaultColor;
        }
        #endregion

        #endregion

        #region public static properties

        #region [public] {static} (ContentModel) Default: Gets default content definition
        /// <summary>
        /// Gets default content definition
        /// </summary>
        /// <value>A <see cref="T:iTin.Export.Model.ContentModel" /> that contains default content definition.</value>
        public static ContentModel Default => new ContentModel();
        #endregion

        #endregion

        #region public properties

        #region [public] (string) AlternateColor: Gets or sets alternative color preferred of content
        /// <summary>
        /// Gets or sets alternative color preferred of content.
        /// </summary>
        /// <value>
        /// Alternate color preferred. The default is <c>Transparent</c>.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// <![CDATA[
        /// <Font AlternateColor="[colorName] | [#rrggbb] | [#rgb] | [sc#rrggbb] | [{StaticBinding:...}]".../>
        /// ]]>
        /// </code>
        /// <para>
        /// <para><strong>Compatibility table with native writers.</strong></para>
        /// <list type="table">
        ///   <listheader>
        ///     <term>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.CsvWriter"/></term>
        ///     <term>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.TsvWriter"/></term>
        ///     <term>SQL Script<br/><see cref="T:iTin.Export.Writers.Native.SqlScriptWriter"/></term>
        ///     <term>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Native.Spreadsheet2003TabularWriter"/></term>
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
        /// In the following example shows how create a new content.
        /// <code lang="xml">
        /// <![CDATA[
        /// <Content AlternateColor="Red" Color="DarkBlue">
        ///   <Alignment Horizontal="Left"/>
        ///   <Text/>
        /// </Content>
        /// ]]>
        /// </code>
        /// <code lang="C#">
        /// var content = new ContentModel
        /// {
        ///     AlternateColor = "Red",
        ///     Color = "DarkBlue",
        ///     DataType = new TextDataTypeModel(),
        ///     Alignment = new ContentAlignmentModel { Horizontal = KnownHorizontalAlignment.Left }
        /// };
        /// </code>
        /// <code lang="VB#">
        /// Dim content = New ContentModel With
        /// {
        ///     .AlternateColor = "Red",
        ///     .Color = "DarkBlue",
        ///     .DataType = New TextDataTypeModel(),
        ///     .Alignment = New ContentAlignmentModel With { .Horizontal = KnownHorizontalAlignment.Left }
        /// }
        /// </code>
        /// </example>
        [XmlAttribute]
        public string AlternateColor
        {
            get => Parent.Owner == null
                ? string.IsNullOrEmpty(_alternateColor)
                    ? _color
                    : _alternateColor
                : string.IsNullOrEmpty(GetStaticBindingValue(_alternateColor))
                    ? _color
                    : GetStaticBindingValue(_alternateColor);
            set
            {
                 SentinelHelper.ArgumentNull(value);

                _alternateColor = value;
            }
        }

        #endregion

        #region [public] (string) Color: Gets or sets color preferred of content
        /// <summary>
        /// Gets or sets color preferred of content.
        /// </summary>
        /// <value>Preferred content color. The default is <c>Transparent</c>.</value>
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
        ///     <term>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.CsvWriter"/></term>
        ///     <term>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.TsvWriter"/></term>
        ///     <term>SQL Script<br/><see cref="T:iTin.Export.Writers.Native.SqlScriptWriter"/></term>
        ///     <term>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Native.Spreadsheet2003TabularWriter"/></term>
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
        /// In the following example shows how create a new content.
        /// <code lang="xml">
        /// <![CDATA[
        /// <Content AlternateColor="Red" Color="DarkBlue">
        ///   <Alignment Horizontal="Left"/>
        ///   <Text/>
        /// </Content>
        /// ]]>
        /// </code>
        /// <code lang="C#">
        /// var content = new ContentModel
        /// {
        ///     AlternateColor = "Red",
        ///     Color = "DarkBlue",
        ///     DataType = new TextDataTypeModel(),
        ///     Alignment = new ContentAlignmentModel { Horizontal = KnownHorizontalAlignment.Left }
        /// };
        /// </code>
        /// <code lang="VB#">
        /// Dim content = New ContentModel With
        /// {
        ///     .AlternateColor = "Red",
        ///     .Color = "DarkBlue",
        ///     .DataType = New TextDataTypeModel(),
        ///     .Alignment = New ContentAlignmentModel With { .Horizontal = KnownHorizontalAlignment.Left }
        /// }
        /// </code>
        /// </example>
        [XmlAttribute]
        [DefaultValue(DefaultColor)]
        public string Color
        {
            get => Parent.Owner == null ? _color : GetStaticBindingValue(_color);
            set
            {
                SentinelHelper.ArgumentNull(value);

                _color = value;
            }
        }
        #endregion

        #region [public] (ContentAlignmentModel) Alignment: Gets or sets content distribution
        /// <summary>
        /// Gets or sets content distribution.
        /// </summary>
        /// <value>Reference for content distribution.</value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// <![CDATA[
        /// <Content>
        ///   <Alignment.../>
        /// </Content>
        /// ]]>
        /// </code>
        /// <para>
        /// <para><strong>Compatibility table with native writers.</strong></para>
        /// <list type="table">
        ///   <listheader>
        ///     <term>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.CsvWriter"/></term>
        ///     <term>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.TsvWriter"/></term>
        ///     <term>SQL Script<br/><see cref="T:iTin.Export.Writers.Native.SqlScriptWriter"/></term>
        ///     <term>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Native.Spreadsheet2003TabularWriter"/></term>
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
        /// In the following example shows how create a new content.
        /// <code lang="xml">
        /// <![CDATA[
        /// <Content AlternateColor="Red" Color="DarkBlue">
        ///   <Alignment Horizontal="Left"/>
        ///   <Text/>
        /// </Content>
        /// ]]>
        /// </code>
        /// <code lang="C#">
        /// var content = new ContentModel
        /// {
        ///     AlternateColor = "Red",
        ///     Color = "DarkBlue",
        ///     DataType = new TextDataTypeModel(),
        ///     Alignment = new ContentAlignmentModel { Horizontal = KnownHorizontalAlignment.Left }
        /// };
        /// </code>
        /// <code lang="VB#">
        /// Dim content = New ContentModel With
        /// {
        ///     .AlternateColor = "Red",
        ///     .Color = "DarkBlue",
        ///     .DataType = New TextDataTypeModel(),
        ///     .Alignment = New ContentAlignmentModel With { .Horizontal = KnownHorizontalAlignment.Left }
        /// }
        /// </code>
        /// </example>
        public ContentAlignmentModel Alignment
        {
            get => _alignment ?? (_alignment = ContentAlignmentModel.Default);
            set => _alignment = value;
        }
        #endregion

        #region [public] (PatternModel) Pattern: Gets or sets the fill pattern content
        /// <summary>
        /// Gets or sets the fill pattern content.
        /// </summary>
        /// <value>Fill pattern.</value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// <![CDATA[
        /// <Content>
        ///   <Pattern.../>
        /// </Content>
        /// ]]>
        /// </code>
        /// <para>
        /// <para><strong>Compatibility table with native writers.</strong></para>
        /// <list type="table">
        ///   <listheader>
        ///     <term>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.CsvWriter"/></term>
        ///     <term>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.TsvWriter"/></term>
        ///     <term>SQL Script<br/><see cref="T:iTin.Export.Writers.Native.SqlScriptWriter"/></term>
        ///     <term>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Native.Spreadsheet2003TabularWriter"/></term>
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
        /// In the following example shows how create a new content.
        /// <code lang="xml">
        /// <![CDATA[
        /// <Content AlternateColor="Red" Color="DarkBlue">
        ///   <Alignment Horizontal="Left"/>
        ///   <Text/>
        /// </Content>
        /// ]]>
        /// </code>
        /// <code lang="C#">
        /// var content = new ContentModel
        /// {
        ///     DataType = new TextDataTypeModel(),
        ///     Pattern = new PatternModel { Color = "AliceBlue", PatternType = KnownPatternType.Gray75 },
        ///     Alignment = new ContentAlignmentModel { Horizontal = KnownHorizontalAlignment.Left }
        /// };
        /// </code>
        /// <code lang="VB#">
        /// Dim content = New ContentModel With
        /// {
        ///     .DataType = New TextDataTypeModel(),
        ///     .Pattern = New PatternModel With { .Color = "AliceBlue", .PatternType = KnownPatternType.Gray75 },
        ///     .Alignment = New ContentAlignmentModel With { .Horizontal = KnownHorizontalAlignment.Left }
        /// }
        /// </code>
        /// </example>
        public PatternModel Pattern
        {
            get => _pattern ?? (_pattern = new PatternModel());
            set => _pattern = value;
        }
        #endregion

        #region [public] (BaseDataTypeModel) DataType: Gets or sets content data type
        /// <summary>
        /// Gets or sets content data type.
        /// </summary>
        /// <value>
        /// Reference to content data type.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// <![CDATA[
        /// <Content>
        ///   <Number/> | <Currency/> | <Percentage/> | <Scientific/> | <Datetime/> | <Special/> | <Text/>
        ///   ...
        /// </Content>
        /// ]]>
        /// </code>
        /// <para>
        /// <para><strong>Compatibility table with native writers.</strong></para>
        /// <list type="table">
        ///   <listheader>
        ///     <term>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.CsvWriter"/></term>
        ///     <term>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.TsvWriter"/></term>
        ///     <term>SQL Script<br/><see cref="T:iTin.Export.Writers.Native.SqlScriptWriter"/></term>
        ///     <term>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Native.Spreadsheet2003TabularWriter"/></term>
        ///   </listheader>
        ///   <item>
        ///     <term>X</term>
        ///     <term>X</term>
        ///     <term>X</term>
        ///     <term>X</term>
        ///   </item>
        /// </list>
        /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
        /// </para>
        /// </remarks>
        /// <example>
        /// In the following example shows how create a new text content.
        /// <code lang="xml">
        /// <![CDATA[
        /// <Content Color="DarkBlue">
        ///   <Alignment Horizontal="Left"/>
        ///   <Text/>
        /// </Content>
        /// ]]>
        /// </code>
        /// <code lang="C#">
        /// var content = new ContentModel
        /// {
        ///     Color = "DarkBlue",
        ///     DataType = new TextDataTypeModel(),
        ///     Alignment = new ContentAlignmentModel { Horizontal = KnownHorizontalAlignment.Left }
        /// };
        /// </code>
        /// <code lang="VB#">
        /// Dim content = New ContentModel With
        /// {
        ///     .Color = "DarkBlue",
        ///     .DataType = New TextDataTypeModel(),
        ///     .Alignment = New ContentAlignmentModel With { .Horizontal = KnownHorizontalAlignment.Left }
        /// }
        /// </code>
        /// <para>In the following example shows how create a new currency content.</para>
        /// <code lang="xml">
        /// <![CDATA[
        /// <Content Color="Beige">
        ///   <Alignment Vertical="Bottom" Horizontal="Right"/>
        ///   <Currency Decimals="1" Locale="mk">
        ///     <Negative Color="Red" Sign="Parenthesis"/>
        ///   </Currency>
        /// </Content>
        /// ]]>
        /// </code>
        /// <code lang="C#">
        /// var content = new ContentModel
        /// {
        ///     Color = "Beige",
        ///     Alignment = new ContentAlignmentModel 
        ///     { 
        ///         Horizontal = KnownHorizontalAlignment.Left, 
        ///         Vertical = KnownVerticalAlignment.Bottom 
        ///     },
        ///     DataType = new CurrencyDataTypeModel
        ///     { 
        ///         Decimals = 1,
        ///         Locale = KnownCulture.mk,
        ///         Negative = new NegativeModel
        ///         {
        ///             Color = KnownBasicColor.Red,
        ///             Sign = KnownNegativeSign.Parenthesis
        ///         }
        ///     }
        /// };
        /// </code>
        /// <code lang="VB#">
        /// Dim content = New ContentModel With
        /// {
        ///     .Color = "Beige",
        ///     .Alignment = New ContentAlignmentModel With
        ///      { 
        ///          .Horizontal = KnownHorizontalAlignment.Left, 
        ///          .Vertical = KnownVerticalAlignment.Bottom 
        ///      },
        ///     .DataType = New CurrencyDataTypeModel With
        ///      { 
        ///          .Decimals = 1,
        ///          .Locale = KnownCulture.mk,
        ///          .Negative = New NegativeModel With
        ///           {
        ///               .Color = KnownBasicColor.Red,
        ///               .Sign = KnownNegativeSign.Parenthesis
        ///           }
        ///      }
        /// }
        /// </code>
        /// </example>
        [XmlElement("Currency", typeof(CurrencyDataTypeModel))]
        [XmlElement("DateTime", typeof(DatetimeDataTypeModel))]
        [XmlElement("Number", typeof(NumberDataTypeModel))]
        [XmlElement("Percentage", typeof(PercentageDataTypeModel))]
        [XmlElement("Scientific", typeof(ScientificDataTypeModel))]
        [XmlElement("Text", typeof(TextDataTypeModel))]
        public BaseDataTypeModel DataType
        {
            get
            {
                if (_dataType != null)
                {
                    _dataType.SetParent(this);
                }
                else
                {
                    if (Parent.Inherits == null)
                    {
                        _dataType = new TextDataTypeModel();
                    }
                        
                }

                return _dataType;                    
            }
            set
            {
                if (value != null)
                {
                    _dataType = value;
                }
            }
        }
        #endregion

        #region [public] (StyleModel) Parent: Gets the parent element of the element
        /// <summary>
        /// Gets the parent element of the element.
        /// </summary>
        /// <value>The element that represents the container element of the element.</value>
        [XmlIgnore]
        [Browsable(false)]
        public StyleModel Parent => _parent;
        #endregion

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default
        /// <summary>
        /// Gets a value indicating whether this instance is default.
        /// </summary>
        /// <value><strong>true</strong> if this instance contains the default; otherwise, <strong>false</strong>.</value>
        /// <inheritdoc />
        public override bool IsDefault => Pattern.IsDefault &&
                                          Alignment.IsDefault &&
                                          AlternateColor.Equals(DefaultColor) &&
                                          Color.Equals(DefaultColor) &&
                                          DataType.GetType() == typeof(TextDataTypeModel);
        #endregion

        #endregion

        #region public methods

        #region [public] (ContentModel) Clone(): Clones this instance
        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public ContentModel Clone()
        {
            var contentCloned = (ContentModel)MemberwiseClone();
            contentCloned.Alignment = Alignment.Clone();
            contentCloned.Pattern = Pattern.Clone();
            contentCloned.DataType = DataType.Clone();
            contentCloned.Properties = Properties.Clone();

            return contentCloned;
        }
        #endregion

        #region [public] (void) Combine(ContentModel): Combines this instance with reference parameter
        /// <summary>
        /// Combines this instance with reference parameter.
        /// </summary>
        /// <param name="reference">The reference.</param>
        public void Combine(ContentModel reference)
        {
            if (AlternateColor.Equals(DefaultColor))
            {
                AlternateColor = reference.Color;
            }

            if (Color.Equals(DefaultColor))
            {
                Color = reference.Color;
            }

            var referenceDataType = reference.DataType;
            if (_dataType == null)
            {
                switch (referenceDataType.Type)
                {
                    case KnownDataType.Currency:
                        _dataType = new CurrencyDataTypeModel();
                        break;

                    case KnownDataType.Datetime:
                        _dataType = new DatetimeDataTypeModel();
                        break;

                    case KnownDataType.Numeric:
                        _dataType = new NumberDataTypeModel();
                        break;

                    case KnownDataType.Percentage:
                        _dataType = new PercentageDataTypeModel();
                        break;

                    case KnownDataType.Scientific:
                        _dataType = new ScientificDataTypeModel();
                        break;

                    default:
                        _dataType = new TextDataTypeModel();
                        break;
                }                  
            }

            if (_dataType.Type.Equals(referenceDataType.Type))
            {
                DataType.Combine(referenceDataType);
            }

            Pattern.Combine(reference.Pattern);
            Alignment.Combine(reference.Alignment);             
        }
        #endregion

        #region [public] (Color) GetColor(): Gets a reference to the color structure preferred for this content
        /// <summary>
        /// Gets a reference to the <see cref="T:System.Drawing.Color" /> structure preferred for this content.
        /// </summary>
        /// <returns><see cref="T:System.Drawing.Color" /> structure that represents a .NET color.</returns>
        public Color GetColor()
        {
            return ColorHelper.GetColorFromString(Color);
        }
        #endregion

        #region [public] (Color) GetAlternateColor(): Gets a reference to the alternate color structure preferred for this content
        /// <summary>
        /// Gets a reference to the alternate <see cref="T:System.Drawing.Color" /> structure preferred for this content.
        /// </summary>
        /// <returns><see cref="T:System.Drawing.Color" /> structure that represents a .NET color.</returns>
        public Color GetAlternateColor()
        {
            return ColorHelper.GetColorFromString(AlternateColor);
        }
        #endregion

        #endregion

        #region internal methods

        #region [internal] (void) SetParent(StyleModel): Sets the parent element of this element
        /// <summary>
        /// Sets the parent element of this element.
        /// </summary>
        /// <param name="reference">Reference to parent.</param>
        internal void SetParent(StyleModel reference)
        {
            _parent = reference;
        }
        #endregion

        #endregion

        #region private methods

        #region [private] (object) Clone(): Creates a new object that is a copy of the current instance
        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        /// <inheritdoc />
        object ICloneable.Clone()
        {
            return Clone();
        }
        #endregion

        #endregion
    }
}
