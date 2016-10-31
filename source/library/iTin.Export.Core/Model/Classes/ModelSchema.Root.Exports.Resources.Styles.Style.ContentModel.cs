using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Xml.Serialization;

using iTin.Export.Drawing.Helper;

namespace iTin.Export.Model
{
    /// <summary>
    /// Defines as shown the content of a field.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Belongs to: <strong><c>Style</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.StyleModel" />.
    /// <code lang="xml" title="AEE Object Element Usage">
    /// &lt;Content&gt;
    ///   &lt;Alignment/&gt;
    ///   &lt;Number/&gt; | &lt;Currency/&gt; | &lt;Percentage/&gt; | &lt;Scientific/&gt; | &lt;Datetime/&gt; | &lt;Special/&gt; | &lt;Text/&gt;
    /// &lt;/Content&gt;
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
    ///       <td><see cref="P:iTin.Export.Model.ContentModel.Color" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Preferred of content color. The default is "<c>Transparent</c>".</td>
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
    ///     <term><see cref="P:iTin.Export.Model.ContentModel.Alignment" /></term> 
    ///     <description>Reference for content distribution.</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.ContentModel.DataType" /></term> 
    ///     <description>Reference for content data type.</description>
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
    public partial class ContentModel : ICloneable
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string DefaultColor = "Transparent";
        #endregion

        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private StyleModel parent;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private PatternModel pattern;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private BaseDataTypeModel dataType;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ContentAlignmentModel alignment;
        #endregion

        #region constructor/s

            #region [public] ContentModel(): Initializes a new instance of this class.
            /// <summary>
            /// Initializes a new instance of the <see cref="T:iTin.Export.Model.ContentModel"/> class.
            /// </summary>
            public ContentModel()
            {
                Color = DefaultColor;
            }
            #endregion

        #endregion

        #region public properties

            #region [public] (string) Color: Gets or sets preferred of content color.
            /// <summary>
            /// Gets or sets preferred of content color.
            /// </summary>
            /// <value>
            /// Preferred of content color. The default is "<c>Transparent</c>".
            /// </value>
            /// <remarks>
            /// <code lang="xml" title="AEE Object Element Usage">
            /// &lt;Content Color="string"&gt;
            /// ...
            /// ...
            /// &lt;/Content&gt;
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
            /// In the following example shows how create a new content.
            /// <code lang="xml">
            /// &lt;Content Color="DarkBlue"&gt;
            ///   &lt;Alignment Horizontal="Left"/&gt;
            ///   &lt;Text/&gt;
            /// &lt;/Content&gt;
            /// </code>
            /// <code lang="cs">
            /// ContentModel content = new ContentModel
            ///                            {
            ///                                Color = "DarkBlue",
            ///                                DataType = new TextDataTypeModel(),
            ///                                Alignment = new ContentAlignmentModel { Horizontal = KnownHorizontalAlignment.Left }
            ///                            };
            /// </code>
            /// </example>
            [XmlAttribute]
            [DefaultValue(DefaultColor)]
            public string Color { get; set; }
            #endregion

            #region [public] (ContentAlignmentModel) Alignment: Gets or sets content distribution.
            /// <summary>
            /// Gets or sets content distribution.
            /// </summary>
            /// <value>
            /// Reference for content distribution.
            /// </value>
            /// <remarks>
            /// <code lang="xml" title="AEE Object Element Usage">
            /// &lt;Content ...&gt;
            ///   &lt;Alignment .../&gt;
            ///   ...
            /// &lt;/Content&gt;
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
            /// In the following example shows how create a new content.
            /// <code lang="xml">
            /// &lt;Content Color="DarkBlue"&gt;
            ///   &lt;Alignment Horizontal="Left"/&gt;
            ///   &lt;Text/&gt;
            /// &lt;/Content&gt;
            /// </code>
            /// <code lang="cs">
            /// ContentModel content = new ContentModel
            ///                            {
            ///                                Color = "DarkBlue",
            ///                                DataType = new TextDataTypeModel(),
            ///                                Alignment = new ContentAlignmentModel { Horizontal = KnownHorizontalAlignment.Left }
            ///                            };
            /// </code>
            /// </example>
            public ContentAlignmentModel Alignment
            {
                get
                {
                    return alignment ?? (alignment = new ContentAlignmentModel());
                }
                set
                {
                    alignment = value;
                }
            }
            #endregion

            #region [public] (PatternModel) Pattern: Gets or sets pattern content.
            public PatternModel Pattern
            {
                get
                {
                    return pattern ?? (pattern = new PatternModel());
                }
                set
                {
                    pattern = value;
                }
            }
            #endregion

            #region [public] (BaseDataTypeModel) DataType: Gets or sets content data type.
            /// <summary>
            /// Gets or sets content data type.
            /// </summary>
            /// <value>
            /// Reference for content data type.
            /// </value>
            /// <remarks>
            /// <code lang="xml" title="AEE Object Element Usage">
            /// &lt;Content ...&gt;
            ///   &lt;Number/&gt; | &lt;Currency/&gt; | &lt;Percentage/&gt; | &lt;Scientific/&gt; | &lt;Datetime/&gt; | &lt;Special/&gt; | &lt;Text/&gt;
            ///   ...
            /// &lt;/Content&gt;
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
            /// In the following example shows how create a new text content.
            /// <code lang="xml">
            /// &lt;Content Color="DarkBlue"&gt;
            ///   &lt;Alignment Horizontal="Left"/&gt;
            ///   &lt;Text/&gt;
            /// &lt;/Content&gt;
            /// </code>
            /// <code lang="cs">
            /// ContentModel content = new ContentModel
            ///                            {
            ///                                Color = "DarkBlue",
            ///                                DataType = new TextDataTypeModel(),
            ///                                Alignment = new ContentAlignmentModel { Horizontal = KnownHorizontalAlignment.Left }
            ///                            };
            /// </code>
            /// <para>In the following example shows how create a new currency content.</para>
            /// <code lang="xml">
            /// &lt;Content Color="Beige">
            ///   &lt;Alignment Vertical="Bottom" Horizontal="Right"/&gt;
            ///   &lt;Currency Decimals="1" Locale="mk"&gt;
            ///     &lt;Negative Color="Red" Sign="Parenthesis"/&gt;
            ///   &lt;/Currency&gt;
            /// &lt;/Content&gt;
            /// </code>
            /// <code lang="cs">
            /// ContentModel content = new ContentModel
            ///                            {
            ///                                Color = "Beige",
            ///                                Alignment = new ContentAlignmentModel
            ///                                                { 
            ///                                                    Horizontal = KnownHorizontalAlignment.Right,
            ///                                                    Vertical = KnownVerticalAlignment.Bottom
            ///                                                },
            ///                                DataType = new CurrencyDataTypeModel
            ///                                               {
            ///                                                   Decimals = 1,
            ///                                                   Locale = KnownCulture.mk,
            ///                                                   Negative = new NegativeModel
            ///                                                                  {
            ///                                                                      Color = KnownBasicColor.Red, 
            ///                                                                      Sign = KnownNegativeSign.Parenthesis
            ///                                                                  }
            ///                                               }
            ///                            };
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
                    if (dataType != null)
                    {
                        dataType.SetParent(this);
                    }
                    else
                    {
                        if (Parent.Inherits == null)
                        {
                            dataType = new TextDataTypeModel();
                        }
                        
                    }

                    return dataType;                    
                }
                set
                {
                    if (value != null)
                    {
                        dataType = value;
                    }
                }
            }
            #endregion

            #region [public] (StyleModel) Parent: Gets the parent element of the element.
            /// <summary>
            /// Gets the parent element of the element.
            /// </summary>
            /// <value>
            /// The element that represents the container element of the element.
            /// </value>
            [XmlIgnore]
            [Browsable(false)]
            public StyleModel Parent
            {
                get { return parent; }
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
                        Pattern.IsDefault &&
                        Alignment.IsDefault &&
                        Color.Equals(DefaultColor) &&
                        DataType.GetType() == typeof(TextDataTypeModel);
                }
            }
            #endregion

        #endregion

        #region public methods

            #region [public] (ContentModel) Clone(): Clones this instance.
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

            #region [public] (void) Combine(ContentModel): Combines this instance with reference parameter.
            /// <summary>
            /// Combines this instance with reference parameter.
            /// </summary>
            public void Combine(ContentModel reference)
            {
                if (Color.Equals(DefaultColor))
                {
                    Color = reference.Color;
                }

                var referenceDataType = reference.DataType;
                if (dataType == null)
                {
                    switch (referenceDataType.Type)
                    {
                        case KnownDataType.Currency:
                            dataType = new CurrencyDataTypeModel();
                            break;

                        case KnownDataType.Datetime:
                            dataType = new DatetimeDataTypeModel();
                            break;

                        case KnownDataType.Numeric:
                            dataType = new NumberDataTypeModel();
                            break;

                        case KnownDataType.Percentage:
                            dataType = new PercentageDataTypeModel();
                            break;

                        case KnownDataType.Scientific:
                            dataType = new ScientificDataTypeModel();
                            break;

                        default:
                            dataType = new TextDataTypeModel();
                            break;
                    }                  
                }

                if (dataType.Type.Equals(referenceDataType.Type))
                {
                    DataType.Combine(referenceDataType);
                }

                Pattern.Combine(reference.Pattern);
                Alignment.Combine(reference.Alignment);             
            }
            #endregion

            #region [public] (Color) GetColor(): Gets a reference to the color structure preferred for this content.
            /// <summary>
            /// Gets a reference to the <see cref="T:System.Drawing.Color" /> structure preferred for this content.
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

        #region private methods

            #region [private] (object) Clone(): Creates a new object that is a copy of the current instance.
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

        #region internal methods

            #region [internal] (void) SetParent(StyleModel): Sets the parent element of the element.
            /// <summary>
            /// Sets the parent element of the element.
            /// </summary>
            /// <param name="reference">Reference to parent.</param>
            internal void SetParent(StyleModel reference)
            {
                parent = reference;
            }
            #endregion

        #endregion
    }
}
