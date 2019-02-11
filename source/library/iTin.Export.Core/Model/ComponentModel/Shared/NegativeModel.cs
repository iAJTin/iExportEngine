
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
    /// Represents a negative number format. Contains the definition of negative number in a numeric data type.
    /// </summary>
    /// <remarks>
    /// <para>
    /// <code lang="xml" title="ITEE Object Element Usage">
    /// &lt;Negative .../&gt;
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
    ///       <td><see cref="P:iTin.Export.Model.NegativeModel.Color" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Preferred color for display a negative number. The default is <see cref="KnownBasicColor.Black" />.</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.NegativeModel.Sign" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Visual format of negative value. The default is <see cref="KnownNegativeSign.Standard" />.</td>
    ///     </tr>
    ///   </tbody>
    /// </table>
    /// <para>
    /// <para><strong>Compatibility table with native writers.</strong></para>
    /// <table>
    ///   <thead>
    ///     <tr>
    ///       <th>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.CsvWriter" /></th>
    ///       <th>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.TsvWriter" /></th>
    ///       <th>SQL Script<br/><see cref="T:iTin.Export.Writers.SqlScriptWriter" /></th>
    ///       <th>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Spreadsheet2003TabularWriter" /></th>
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
    /// In the following example shows how create a new style.
    /// <code lang="xml">
    /// &lt;Style Name="TopAggregate"&gt;
    ///   &lt;Content Color="#C9C9C9"&gt;
    ///     &lt;Alignment Horizontal="Center"/&gt;
    ///     &lt;Number Decimals="0" Separator="Yes"&gt;
    ///       &lt;Negative Color="Yellow" Sign="Brackets"/&gt;
    ///     &lt;/Number&gt;
    ///   &lt;/Content&gt;
    ///   &lt;Font Name="Segoe UI" Size="12" Color="Navy" Bold="Yes"/&gt;
    /// &lt;/Style&gt;
    /// </code>
    /// <code lang="cs">
    /// StyleModel style = new StyleModel
    ///                        {
    ///                            Name = "TopAggregate",
    ///                            Content = new ContentModel
    ///                                          {
    ///                                              Color = "#C9C9C9",
    ///                                              Alignment = new ContentAlignmentModel
    ///                                                              {
    ///                                                                  Horizontal = KnownHorizontalAlignment.Center
    ///                                                              },
    ///                                              DataType = new NumberDataTypeModel
    ///                                                             {
    ///                                                                 Decimals = 0,
    ///                                                                 Separator = YesNo.Yes,
    ///                                                                 Negative = new NegativeModel
    ///                                                                                {
    ///                                                                                    Color = KnownBasicColor.Yellow,
    ///                                                                                    Sign = KnownNegativeSign.Brackets
    ///                                                                                }
    ///                                                             }
    ///                                          }, 
    ///                            Font = new FontModel
    ///                                       {
    ///                                           Color = "Navy",
    ///                                           Bold = YesNo.Yes,
    ///                                           Size = 12
    ///                                       }
    ///                        };
    /// </code>
    /// </example>
    public partial class NegativeModel : ICloneable
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const KnownBasicColor DefaultColor = KnownBasicColor.Black;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const KnownNegativeSign DefaultSign = KnownNegativeSign.Standard;
        #endregion
        
        #region field member
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private KnownBasicColor _color;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private KnownNegativeSign _sign;
        #endregion

        #region constructor/s

        #region [public] NegativeModel(): Initializes a new instance of this class
        /// <summary>
        /// Initializes a new instance of the <see cref="iTin.Export.Model.NegativeModel" /> class.
        /// </summary>
        public NegativeModel()
        {
            Sign = DefaultSign;
            Color = DefaultColor;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (KnownBasicColor) Color: Gets or sets preferred color for display a negative number
        /// <summary>
        /// Gets or sets preferred color for display a negative number.
        /// </summary>
        /// <value>
        /// Preferred color for display a negative number. The default is <see cref="iTin.Export.Model.KnownBasicColor.Black" />.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Negative Color="Black|Blue|Cyan|Green|Magenta|Red|Yellow|White" .../&gt;
        /// </code>
        /// <para>
        /// <para><strong>Compatibility table with native writers.</strong></para>
        /// <table>
        ///   <thead>
        ///     <tr>
        ///       <th>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.CsvWriter" /></th>
        ///       <th>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.TsvWriter" /></th>
        ///       <th>SQL Script<br/><see cref="T:iTin.Export.Writers.SqlScriptWriter" /></th>
        ///       <th>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Spreadsheet2003TabularWriter" /></th>
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
        /// In the following example shows how create a new style.
        /// <code lang="xml">
        /// &lt;Style Name="TopAggregate"&gt;
        ///   &lt;Content Color="#C9C9C9"&gt;
        ///     &lt;Alignment Horizontal="Center"/&gt;
        ///     &lt;Number Decimals="0" Separator="Yes"&gt;
        ///       &lt;Negative Color="Yellow" Sign="Brackets"/&gt;
        ///     &lt;/Number&gt;
        ///   &lt;/Content&gt;
        ///   &lt;Font Name="Segoe UI" Size="12" Color="Navy" Bold="Yes"/&gt;
        /// &lt;/Style&gt;
        /// </code>
        /// <code lang="cs">
        /// StyleModel style = new StyleModel
        ///                        {
        ///                            Name = "TopAggregate",
        ///                            Content = new ContentModel
        ///                                          {
        ///                                              Color = "#C9C9C9",
        ///                                              Alignment = new ContentAlignmentModel
        ///                                                              {
        ///                                                                  Horizontal = KnownHorizontalAlignment.Center
        ///                                                              },
        ///                                              DataType = new NumberDataTypeModel
        ///                                                             {
        ///                                                                 Decimals = 0,
        ///                                                                 Separator = YesNo.Yes,
        ///                                                                 Negative = new NegativeModel
        ///                                                                                {
        ///                                                                                    Color = KnownBasicColor.Yellow,
        ///                                                                                    Sign = KnownNegativeSign.Brackets
        ///                                                                                }
        ///                                                             }
        ///                                          }, 
        ///                            Font = new FontModel
        ///                                       {
        ///                                           Color = "Navy",
        ///                                           Bold = YesNo.Yes,
        ///                                           Size = 12
        ///                                       }
        ///                        };
        /// </code>
        /// </example>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>
        [XmlAttribute]
        [DefaultValue(DefaultColor)]
        public KnownBasicColor Color
        {
            get => _color;
            set
            {
                SentinelHelper.IsEnumValid(value);

                _color = value;
            }
        }
        #endregion

        #region [public] (KnownNegativeSign) Sign: Gets or sets visual format of negative value
        /// <summary>
        /// Gets or sets visual format of negative value.
        /// </summary>
        /// <value>
        /// Visual format of negative value. The default is <see cref="iTin.Export.Model.KnownNegativeSign.Standard" />.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Negative Sign="Standard|None|Parenthesis|Brackets" .../&gt;
        /// </code>
        /// <para>
        /// <para><strong>Compatibility table with native writers.</strong></para>
        /// <table>
        ///   <thead>
        ///     <tr>
        ///       <th>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.CsvWriter" /></th>
        ///       <th>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.TsvWriter" /></th>
        ///       <th>SQL Script<br/><see cref="T:iTin.Export.Writers.SqlScriptWriter" /></th>
        ///       <th>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Spreadsheet2003TabularWriter" /></th>
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
        /// In the following example shows how create a new style.
        /// <code lang="xml">
        /// &lt;Style Name="TopAggregate"&gt;
        ///   &lt;Content Color="#C9C9C9"&gt;
        ///     &lt;Alignment Horizontal="Center"/&gt;
        ///     &lt;Number Decimals="0" Separator="Yes"&gt;
        ///       &lt;Negative Color="Yellow" Sign="Brackets"/&gt;
        ///     &lt;/Number&gt;
        ///   &lt;/Content&gt;
        ///   &lt;Font Name="Segoe UI" Size="12" Color="Navy" Bold="Yes"/&gt;
        /// &lt;/Style&gt;
        /// </code>
        /// <code lang="cs">
        /// StyleModel style = new StyleModel
        ///                        {
        ///                            Name = "TopAggregate",
        ///                            Content = new ContentModel
        ///                                          {
        ///                                              Color = "#C9C9C9",
        ///                                              Alignment = new ContentAlignmentModel
        ///                                                              {
        ///                                                                  Horizontal = KnownHorizontalAlignment.Center
        ///                                                              },
        ///                                              DataType = new NumberDataTypeModel
        ///                                                             {
        ///                                                                 Decimals = 0,
        ///                                                                 Separator = YesNo.Yes,
        ///                                                                 Negative = new NegativeModel
        ///                                                                                {
        ///                                                                                    Color = KnownBasicColor.Yellow,
        ///                                                                                    Sign = KnownNegativeSign.Brackets
        ///                                                                                }
        ///                                                             }
        ///                                          }, 
        ///                            Font = new FontModel
        ///                                       {
        ///                                           Color = "Navy",
        ///                                           Bold = YesNo.Yes,
        ///                                           Size = 12
        ///                                       }
        ///                        };
        /// </code>
        /// </example>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>
        [XmlAttribute]
        [DefaultValue(DefaultSign)]
        public KnownNegativeSign Sign
        {
            get => _sign;
            set
            {
                SentinelHelper.IsEnumValid(value);

                _sign = value;
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
        public override bool IsDefault => Sign.Equals(DefaultSign) && Color.Equals(DefaultColor);
        #endregion

        #endregion

        #region public methods

        #region [public] (NegativeModel) Clone(): Clones this instance
        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public NegativeModel Clone()
        {
            var negativeCloned =(NegativeModel)MemberwiseClone();
            negativeCloned.Properties = Properties.Clone();

            return negativeCloned;
        }
        #endregion

        #region [public] (void) Combine(NegativeModel): Combines this instance with reference parameter
        /// <summary>
        /// Combines this instance with reference parameter.
        /// </summary>
        public void Combine(NegativeModel reference)
        {
            if (Color.Equals(DefaultColor))
            {
                Color = reference.Color;
            }

            if (Sign.Equals(DefaultSign))
            {
                Sign = reference.Sign;
            }
        }
        #endregion

        #region [public] (Color) GetColor(): Gets a reference to the color structure preferred for this negative format
        /// <summary>
        /// Gets a reference to the <see cref="T:System.Drawing.Color" /> structure preferred for this negative format.
        /// </summary>
        /// <returns>
        /// <see cref="T:System.Drawing.Color"/> structure that represents a .NET color.
        /// </returns> 
        public Color GetColor()
        {
            var basiccolor = System.Drawing.Color.FromName(Color.ToString()).Name;
            return ColorHelper.GetColorFromString(basiccolor);
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
