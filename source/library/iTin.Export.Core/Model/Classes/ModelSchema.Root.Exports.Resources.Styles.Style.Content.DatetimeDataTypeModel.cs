using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Xml.Serialization;

using iTin.Export.Helper;

namespace iTin.Export.Model
{
    /// <summary>
    /// A Specialization of <see cref="T:iTin.Export.Model.BaseDataTypeModel" /> class.<br/>
    /// Displays data field as datetime format. You can specify the output culture.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Belongs to: <strong><c>Content</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.ContentModel" />.
    /// <code lang="xml" title="AEE Object Element Usage">
    /// &lt;Datetime ...&gt;
    ///   &lt;Error/&gt;
    /// &lt;Datetime/&gt;
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
    ///       <td><see cref="P:iTin.Export.Model.DatetimeDataTypeModel.Format" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Preferred output date time format. The default is <see cref="iTin.Export.Model.KnownDatetimeFormat.ShortDatePattern" />.</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.DatetimeDataTypeModel.Locale" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Use this attribute for select preferred output culture. The default is <see cref="iTin.Export.Model.KnownCulture.Current" />.</td>
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
    ///     <term><see cref="P:iTin.Export.Model.DatetimeDataTypeModel.Error" /></term> 
    ///     <description>Reference for datetime data type error settings.</description>
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
    /// The following example indicate that the content should be datetime data type.
    /// <code lang="xml">
    /// &lt;Style Name="DateValue"&gt;
    ///   &lt;Content Color="sc# 0.15 0.15 0.15"&gt;
    ///     &lt;Alignment Horizontal="Center"/&gt;
    ///     &lt;DateTime Format="Year-Month" Locale="en-US"&gt;
    ///       &lt;Error Value="Today"&gt;
    ///         &lt;Comment Show="Yes"&gt;
    ///           &lt;Font Name="Comic Sans MS" Size="16" Bold="Yes" Italic="Yes" Underline="Yes"/&gt;
    ///         &lt;/Comment&gt;
    ///       &lt;/Error&gt;
    ///     &lt;/DateTime&gt;
    ///   &lt;/Content&gt;
    /// &lt;/Style&gt;
    /// </code>
    /// </example>
    public partial class DatetimeDataTypeModel : ICloneable
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const KnownCulture DefaultLocale = KnownCulture.Current;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const KnownDatetimeFormat DefaultFormat = KnownDatetimeFormat.ShortDatePattern;
        #endregion

        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private KnownCulture _locale;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DatetimeErrorModel _error;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private KnownDatetimeFormat _format;
        #endregion

        #region Constructor/s

            #region [public] DatetimeDataTypeModel(): Initializes a new instance of this class.
            /// <summary>
            /// Initializes a new instance of the <see cref="T:iTin.Export.Model.DatetimeDataTypeModel" /> class.
            /// </summary>
            public DatetimeDataTypeModel()
            {
                Locale = DefaultLocale;
                Format = DefaultFormat;
            }
            #endregion

        #endregion

        #region public properties

            #region [public] (DatetimeErrorModel) Error: Gets or sets a reference that contains datetime data type error settings.
            /// <summary>
            /// Gets or sets a reference that contains datetime data type error settings.
            /// </summary>
            /// <value>
            /// Datetime data type error settings
            /// </value>
            /// <remarks>
            /// <code lang="xml" title="AEE Object Element Usage">
            /// &lt;Datetime ...&gt;
            ///   &lt;Error/&gt;
            /// &lt;/Datetime&gt;
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
            /// The following example indicate that the content should be datetime data type.
            /// <code lang="xml">
            /// &lt;Style Name="DateValue"&gt;
            ///   &lt;Content Color="sc# 0.15 0.15 0.15"&gt;
            ///     &lt;Alignment Horizontal="Center"/&gt;
            ///     &lt;DateTime Format="Year-Month" Locale="en-US"&gt;
            ///       &lt;Error Value="Today"&gt;
            ///         &lt;Comment Show="Yes"&gt;
            ///           &lt;Font Name="Comic Sans MS" Size="16" Bold="Yes" Italic="Yes" Underline="Yes"/&gt;
            ///         &lt;/Comment&gt;
            ///       &lt;/Error&gt;
            ///     &lt;/DateTime&gt;
            ///   &lt;/Content&gt;
            /// &lt;/Style&gt;
            /// </code>
            /// </example>
            public DatetimeErrorModel Error
            {
                get
                {
                    return _error ?? (_error = new DatetimeErrorModel());
                }
                set
                {
                    _error = value;
                }
            }
            #endregion

            #region [public] (KnownDatetimeFormat) Format: Gets or sets preferred output date time format.
            /// <summary>
            /// Gets or sets preferred output date time format.
            /// </summary>
            /// <value>
            /// One of the <see cref="T:iTin.Export.Model.KnownDatetimeFormat" /> values. The default is <see cref="iTin.Export.Model.KnownDatetimeFormat.ShortDatePattern"/>.
            /// </value>
            /// <remarks>
            /// <code lang="xml" title="AEE Object Element Usage">
            /// &lt;Datetime Format="GeneralDatePattern|ShortDatePattern|MediumDatePattern|LongDatePattern|FullDatePattern|RFC1123Pattern|ShortTimePattern|LongTimePattern|MonthDayPattern|YearMonthPattern" ...&gt;
            /// ...
            /// &lt;/Datetime&gt;
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
            /// The following example indicate that the content should be datetime data type.
            /// <code lang="xml">
            /// &lt;Style Name="DateValue"&gt;
            ///   &lt;Content Color="sc# 0.15 0.15 0.15"&gt;
            ///     &lt;Alignment Horizontal="Center"/&gt;
            ///     &lt;DateTime Format="Year-Month" Locale="en-US"&gt;
            ///       &lt;Error Value="Today"&gt;
            ///         &lt;Comment Show="Yes"&gt;
            ///           &lt;Font Name="Comic Sans MS" Size="16" Bold="Yes" Italic="Yes" Underline="Yes"/&gt;
            ///         &lt;/Comment&gt;
            ///       &lt;/Error&gt;
            ///     &lt;/DateTime&gt;
            ///   &lt;/Content&gt;
            /// &lt;/Style&gt;
            /// </code>
            /// </example>
            /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>
            [XmlAttribute]
            [DefaultValue(DefaultFormat)]
            public KnownDatetimeFormat Format
            {
                get
                {
                    return _format;
                }
                set
                {
                    SentinelHelper.IsEnumValid(value);
                    _format = value;
                }
            }
            #endregion

            #region [public] (KnownCulture) Locale: Gets or sets preferred output culture.
            /// <summary>
            /// Gets or sets preferred output culture.
            /// </summary>
            /// <value>
            /// One of the <see cref="T:iTin.Export.Model.KnownCulture" /> values. The default is <see cref="iTin.Export.Model.KnownCulture.Current" />.
            /// </value>
            /// <remarks>
            /// <code lang="xml" title="AEE Object Element Usage">
            /// &lt;Datetime Locale="string" ...&gt;
            /// ...
            /// &lt;/Datetime&gt;
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
            /// The following example indicate that the content should be datetime data type.
            /// <code lang="xml">
            /// &lt;Style Name="DateValue"&gt;
            ///   &lt;Content Color="sc# 0.15 0.15 0.15"&gt;
            ///     &lt;Alignment Horizontal="Center"/&gt;
            ///     &lt;DateTime Format="Year-Month" Locale="en-US"&gt;
            ///       &lt;Error Value="Today"&gt;
            ///         &lt;Comment Show="Yes"&gt;
            ///           &lt;Font Name="Comic Sans MS" Size="16" Bold="Yes" Italic="Yes" Underline="Yes"/&gt;
            ///         &lt;/Comment&gt;
            ///       &lt;/Error&gt;
            ///     &lt;/DateTime&gt;
            ///   &lt;/Content&gt;
            /// &lt;/Style&gt;
            /// </code>
            /// </example>
            [XmlAttribute]
            [DefaultValue(DefaultLocale)]
            public KnownCulture Locale
            {
                get
                {
                    return _locale;
                }
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

                    _locale = isValidLocale
                                      ? value
                                      : DefaultLocale;
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
                    return base.IsDefault && 
                           Error.IsDefault && 
                           Format.Equals(DefaultFormat) && 
                           Locale.Equals(DefaultLocale);
                }
            }
        #endregion

        #endregion

        #region public methods

            #region [public] {new} (DatetimeDataTypeModel) Clone(): Clones this instance.
            /// <summary>
            /// Clones this instance.
            /// </summary>
            /// <returns>A new object that is a copy of this instance.</returns>
            public new DatetimeDataTypeModel Clone()
            {
                var datetimeCloned = (DatetimeDataTypeModel)MemberwiseClone();
                datetimeCloned.Error = Error.Clone();
                datetimeCloned.Properties = Properties.Clone();

                return datetimeCloned;
            }
            #endregion

            #region [public] (void) Combine(DatetimeDataTypeModel): Combines this instance with reference parameter.
            /// <summary>
            /// Combines this instance with reference parameter.
            /// </summary>
            public void Combine(DatetimeDataTypeModel reference)
            {
                if (Locale.Equals(DefaultLocale))
                {
                    Locale = reference.Locale;
                }

                if (Format.Equals(DefaultFormat))
                {
                    Format = reference.Format;
                }

                Error.Combine(reference.Error);
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

        #region private static methods

            #region [private] {static} (bool) IsValidCulture: Gets a value indicating whether specified culture is installed on this system.
            /// <summary>
            /// Gets a value indicating whether specified culture is installed on this system.
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
