
namespace iTin.Export.Model
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Globalization;
    using System.Linq;
    using System.Xml.Serialization;

    /// <summary>
    /// A Specialization of <see cref="T:iTin.Export.Model.NumericDataTypeModel" /> class.<br/>
    /// Represents currency format, the currency symbol appears right next to the first digit.
    /// You can specify the number of decimal places that you want to use and how you want to display negative numbers.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Belongs to: <strong><c>Content</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.ContentModel" />.
    /// <code lang="xml" title="ITEE Object Element Usage">
    /// &lt;Currency ...&gt;
    ///   &lt;Negative/&gt;
    ///   &lt;Error/&gt;
    /// &lt;Currency/&gt;
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
    ///       <td><see cref="P:iTin.Export.Model.RealDataTypeModel.Decimals" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Number of decimal places. The default is <c>2</c>.</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.CurrencyDataTypeModel.Locale" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Use this attribute for select preferred output culture. The default is <see cref="KnownCulture.Current" />.</td>
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
    ///     <term><see cref="P:iTin.Export.Model.NumericDataTypeModel.Error" /></term> 
    ///     <description>Reference for numeric data type error settings.</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.NumericDataTypeModel.Negative" /></term> 
    ///     <description>Reference for negative number format.</description>
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
    /// <example>
    /// The following example indicate that the content should be currency type.
    /// <code lang="xml">
    /// &lt;Style Name="AccountValue"&gt;
    ///   &lt;Content Color="Blue"&gt;
    ///     &lt;Currency Decimals="1" Locale="mk"&gt;
    ///       &lt;Negative Color="Red" Sign="Parenthesis"&gt;
    ///     &lt;/Currency&gt;
    ///   &lt;/Content&gt;
    ///   &lt;Font Size="8" Color="White"/&gt;
    /// &lt;/Style&gt;
    /// </code>
    /// </example>
    public partial class CurrencyDataTypeModel : ICloneable
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const KnownCulture DefaultLocale = KnownCulture.Current;
        #endregion

        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private KnownCulture locale;
        #endregion

        #region constructor/s

        #region [public] CurrencyDataTypeModel(): Initializes a new instance of this class
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.CurrencyDataTypeModel" /> class.
        /// </summary>
        public CurrencyDataTypeModel()
        {
            locale = DefaultLocale;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (KnownCulture) Locale: Gets or sets preferred output culture
        /// <summary>
        /// Gets or sets preferred output culture.
        /// </summary>
        /// <value>
        /// One of the <see cref="T:iTin.Export.Model.KnownCulture" /> values. The default is <see cref="iTin.Export.Model.KnownCulture.Current" />.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Currency Locale="string" ...&gt;
        /// ...
        /// &lt;/Currency&gt;
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
        /// In the following example shows how create a new style.
        /// <code lang="xml">
        /// &lt;Style Name="AccountValue"&gt;
        ///   &lt;Content Color="Blue"&gt;
        ///     &lt;Currency Decimals="1" Locale="mk"&gt;
        ///       &lt;Negative Color="Red" Sign="Parenthesis"&gt;
        ///     &lt;/Currency&gt;
        ///   &lt;/Content&gt;
        ///   &lt;Font Size="8" Color="White"/&gt;
        /// &lt;/Style&gt;
        /// </code>
        /// </example>
        [XmlAttribute]
        [DefaultValue(DefaultLocale)]
        public KnownCulture Locale
        {
            get => locale;
            set
            {
                var isValidLocale = true;
                if (!value.Equals(KnownCulture.Current))
                {
                    var isValidCulture = IsValidCulture(value);
                    if (!isValidCulture)
                    {
                        isValidLocale = false;
                    }
                }

                locale = isValidLocale 
                    ? value 
                    : DefaultLocale;
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
        public override bool IsDefault => base.IsDefault && Locale.Equals(DefaultLocale);
        #endregion

        #endregion

        #region public methods

        #region [public] {new} (CurrencyDataTypeModel) Clone(): Clones this instance
        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public new CurrencyDataTypeModel Clone()
        {
            var currencyDataTypeCloned = (CurrencyDataTypeModel)MemberwiseClone();
            currencyDataTypeCloned.Error = Error.Clone();
            currencyDataTypeCloned.Negative = Negative.Clone();
            currencyDataTypeCloned.Properties = Properties.Clone();

            return currencyDataTypeCloned;
        }
        #endregion

        #region [public] (void) Combine(CurrencyDataTypeModel): Combines this instance with reference parameter
        /// <summary>
        /// Combines this instance with reference parameter.
        /// </summary>
        /// <param name="reference">The reference.</param>
        public void Combine(CurrencyDataTypeModel reference)
        {
            if (Locale.Equals(DefaultLocale))
            {
                Locale = reference.Locale;
            }

            base.Combine(reference);
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

        #region private static methods

        #region [private] {static} (bool) IsValidCulture: Gets a value indicating whether the specified culture is installed on this system
        /// <summary>
        /// Gets a value indicating whether the font is installed on this system.
        /// </summary>
        /// <param name="culture">Culture to check.</param>
        /// <returns>
        /// <strong>true</strong> if the specified culture is installed on the system; otherwise, <strong>false</strong>.
        /// </returns>
        private static bool IsValidCulture(KnownCulture culture)
        {
            var iw32C = CultureInfo.GetCultures(CultureTypes.InstalledWin32Cultures);
            return iw32C.Any(clt => clt.Name == ExportsModel.GetXmlEnumAttributeFromItem(culture));
        }
        #endregion

        #endregion 
    }
}
