
namespace iTin.Export.Model
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Globalization;
    using System.Linq;
    using System.Xml.Serialization;

    using ComponentModel;
    using Helpers;

    /// <summary>
    /// Base class for the different types of field conditions supported by <strong><c>iTin Export Engine</c></strong>.<br />
    /// Which acts as the base class for different conditions.
    /// </summary>
    /// <remarks>
    /// <para>The following table shows different conditions.</para>
    /// <list type="table">
    ///   <listheader>
    ///     <term>Class</term>
    ///     <description>Description</description>
    ///   </listheader>
    ///   <item>
    ///     <term><see cref="T:iTin.Export.Model.MaximumCondition" /></term>
    ///     <description>Evaluates the maximum condition over a data field.</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="T:iTin.Export.Model.MinimumCondition" /></term>
    ///     <description>Evaluates the minimum condition over a data field.</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="T:iTin.Export.Model.RemarksCondition" /></term>
    ///     <description>Evaluates custom logic condition over a data field.</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="T:iTin.Export.Model.WhenChangeCondition" /></term>
    ///     <description>Evaluates condition over a data field.</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="T:iTin.Export.Model.ZeroCondition" /></term>
    ///     <description>Evaluates condition over a data field.</description>
    ///   </item>
    /// </list>
    /// </remarks>
    public partial class BaseConditionModel : ICondition
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo ActiveDefault = YesNo.Yes;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo EntireRowDefault = YesNo.No;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const KnownCulture LocaleDefault = KnownCulture.Current;
        #endregion

        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _key;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private YesNo _active;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _field;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private YesNo _entrireRow;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private KnownCulture _locale;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ConditionsModel _owner;
        #endregion

        #region [protected] BaseConditionModel(): Initializes a new instance of this class
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.BaseConditionModel" /> class.
        /// </summary>
        protected BaseConditionModel()
        {
            _active = ActiveDefault;
            _locale = LocaleDefault;            
            _entrireRow = EntireRowDefault;
        }
        #endregion

        #region protected properties

        #region [protected] (ModelService) Service: Gets a reference to an object that contains information about the context
        /// <summary>
        /// Gets a reference to an object that contains information about the context.
        /// </summary>
        /// <value>
        /// A <see cref="ModelService"/> that contains information about the context.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected ModelService Service => ModelService.Instance;
        #endregion

        #endregion

        #region public readonly properties

        #region [public] (ConditionsModel) Owner: Gets the element that owns this condition
        /// <summary>
        /// Gets the element that owns this data field.
        /// </summary>
        /// <value>
        /// The <see cref="T:iTin.Export.Model.ConditionsModel" /> that owns this condition.
        /// </value>
        [XmlIgnore]
        [Browsable(false)]
        public ConditionsModel Owner => _owner;
        #endregion

        #endregion

        #region public properties

        #region [public] (YesNo) Active: Gets or sets a value that indicates if this condition is active
        /// <summary>
        /// Gets or sets a value that indicates if this condition is active. The default is <see cref="T:iTin.Export.Model.YesNo.Yes"/>.
        /// </summary>
        /// <value>
        /// <see cref="YesNo.Yes"/> if is active; otherwise, <see cref="YesNo.No"/>.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;MaximumCondition|MinimumCondition|RemarksCondition|WhenChangeCondition|ZeroCondition Active="Yes|No" ...&gt;
        ///   ...
        /// &lt;MaximumCondition|MinimumCondition|RemarksCondition|WhenChangeCondition|ZeroCondition&gt;
        /// </code>
        /// <para>
        /// <para><strong>Compatibility table with native writers.</strong></para>
        /// <table>
        ///   <thead>
        ///     <tr>
        ///       <th>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.CsvWriter"/></th>
        ///       <th>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.TsvWriter"/></th>
        ///       <th>SQL Script<br/><see cref="T:iTin.Export.Writers.SqlScriptWriter"/></th>
        ///       <th>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Spreadsheet2003TabularWriter"/></th>
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
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Global.Resources&gt;
        ///   &lt;Conditions&gt;
        ///     &lt;MaximumCondition Key="max" Active="Yes" Field="TOTAL" EntireRow="No" Style="maxTotalStyle"/&gt;
        ///     ...
        ///   &lt;/Conditions&gt;
        /// &lt;/Global.Resources&gt;
        /// </code>
        /// </example>
        [XmlAttribute]
        [DefaultValue(ActiveDefault)]
        public YesNo Active
        {
            get => GetStaticBindingValue(_active.ToString()).ToUpperInvariant() == "NO" ? YesNo.No : YesNo.Yes;
            set
            {
                SentinelHelper.IsEnumValid(value);

                _active = value;
            }
        }
        #endregion

        #region [public] (YesNo) EntireRow: Gets or sets a value that indicates if condition style applies over the row
        /// <summary>
        /// Gets or sets a value that indicates if condition style applies over the row. The default is <see cref="T:iTin.Export.Model.YesNo.No"/>.
        /// </summary>
        /// <value>
        /// <see cref="YesNo.Yes"/> if condition style applies over row; otherwise, <see cref="YesNo.No"/> if style condition only applies over field cell.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;MaximumCondition|MinimumCondition|RemarksCondition|WhenChangeCondition|ZeroCondition EntireRow="Yes|No" ...&gt;
        ///   ...
        /// &lt;MaximumCondition|MinimumCondition|RemarksCondition|WhenChangeCondition|ZeroCondition&gt;
        /// </code>
        /// <para>
        /// <para><strong>Compatibility table with native writers.</strong></para>
        /// <table>
        ///   <thead>
        ///     <tr>
        ///       <th>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.CsvWriter"/></th>
        ///       <th>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.TsvWriter"/></th>
        ///       <th>SQL Script<br/><see cref="T:iTin.Export.Writers.SqlScriptWriter"/></th>
        ///       <th>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Spreadsheet2003TabularWriter"/></th>
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
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Global.Resources&gt;
        ///   &lt;Conditions&gt;
        ///     &lt;MaximumCondition Key="max" Active="Yes" Field="TOTAL" EntireRow="No" Style="maxTotalStyle"/&gt;
        ///     ...
        ///   &lt;/Conditions&gt;
        /// &lt;/Global.Resources&gt;
        /// </code>
        /// </example>
        [XmlAttribute]
        [DefaultValue(EntireRowDefault)]
        public YesNo EntireRow
        {
            get => GetStaticBindingValue(_entrireRow.ToString()).ToUpperInvariant() == "NO" ? YesNo.No : YesNo.Yes;
            set
            {
                SentinelHelper.IsEnumValid(value);

                _entrireRow = value;
            }
        }
        #endregion

        #region [public] (string) Field: Gets or sets a value that represents the field on which the condition will be evaluated
        /// <summary>
        /// Gets or sets a value that represents the field on which the condition will be evaluated
        /// </summary>
        /// <value>
        /// A <see cref ="T:System.String"/> that represents the field on which the condition will be evaluated.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;MaximumCondition|MinimumCondition|RemarksCondition|WhenChangeCondition|ZeroCondition Field="string" ...&gt;
        ///   ...
        /// &lt;MaximumCondition|MinimumCondition|RemarksCondition|WhenChangeCondition|ZeroCondition&gt;
        /// </code>
        /// <para>
        /// <para><strong>Compatibility table with native writers.</strong></para>
        /// <table>
        ///   <thead>
        ///     <tr>
        ///       <th>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.CsvWriter"/></th>
        ///       <th>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.TsvWriter"/></th>
        ///       <th>SQL Script<br/><see cref="T:iTin.Export.Writers.SqlScriptWriter"/></th>
        ///       <th>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Spreadsheet2003TabularWriter"/></th>
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
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Global.Resources&gt;
        ///   &lt;Conditions&gt;
        ///     &lt;MaximumCondition Key="max" Active="Yes" Field="TOTAL" EntireRow="No" Style="maxTotalStyle"/&gt;
        ///     ...
        ///   &lt;/Conditions&gt;
        /// &lt;/Global.Resources&gt;
        /// </code>
        /// </example>
        [XmlAttribute]
        public string Field
        {
            get => GetStaticBindingValue(_field);
            set
            {
                SentinelHelper.ArgumentNull(value);
                SentinelHelper.IsFalse(RegularExpressionHelper.IsValidFieldName(value), new InvalidFieldIdentifierNameException(ErrorMessageHelper.FieldIdentifierNameErrorMessage(GetType().Name, "Field", value)));

                _field = value;
            }
        }
        #endregion

        #region [public] (string) Key: Gets or sets a value that contains an identifier for this condition
        /// <summary>
        /// Gets or sets a value that contains an identifier for this condition
        /// </summary>
        /// <value>
        /// A <see cref ="T:System.String"/> that represents the identifier for this condition.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;MaximumCondition|MinimumCondition|RemarksCondition|WhenChangeCondition|ZeroCondition Key="string" ...&gt;
        ///   ...
        /// &lt;MaximumCondition|MinimumCondition|RemarksCondition|WhenChangeCondition|ZeroCondition&gt;
        /// </code>
        /// <para>
        /// <para><strong>Compatibility table with native writers.</strong></para>
        /// <table>
        ///   <thead>
        ///     <tr>
        ///       <th>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.CsvWriter"/></th>
        ///       <th>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.TsvWriter"/></th>
        ///       <th>SQL Script<br/><see cref="T:iTin.Export.Writers.SqlScriptWriter"/></th>
        ///       <th>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Spreadsheet2003TabularWriter"/></th>
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
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Global.Resources&gt;
        ///   &lt;Conditions&gt;
        ///     &lt;MaximumCondition Key="max" Active="Yes" Field="TOTAL" EntireRow="No" Style="maxTotalStyle"/&gt;
        ///     ...
        ///   &lt;/Conditions&gt;
        /// &lt;/Global.Resources&gt;
        /// </code>
        /// </example>
        [XmlAttribute]
        public string Key
        {
            get => GetStaticBindingValue(_key);
            set
            {
                SentinelHelper.ArgumentNull(value);
                SentinelHelper.IsFalse(RegularExpressionHelper.IsValidIdentifier(value), new InvalidIdentifierNameException(ErrorMessageHelper.ModelIdentifierNameErrorMessage(GetType().Name, "Name", value)));

                _key = value;
            }
        }
        #endregion

        #region [public] (KnownCulture) Locale: Gets or sets the data field culture
        /// <summary>
        /// Gets or sets the data field culture. The default is <see cref="KnownCulture.Current" />.
        /// </summary>
        /// <value>
        /// One of the <see cref="T:iTin.Export.Model.KnownCulture" /> values. 
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;MaximumCondition|MinimumCondition|RemarksCondition|WhenChangeCondition|ZeroCondition Locale="Current|any culture" ...&gt;
        ///   ...
        /// &lt;MaximumCondition|MinimumCondition|RemarksCondition|WhenChangeCondition|ZeroCondition&gt;
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
        /// &lt;Global.Resources&gt;
        ///   &lt;Conditions&gt;
        ///     &lt;MaximumCondition Key="max" Active="Yes" Field="TOTAL" EntireRow="No" Style="maxTotalStyle" Locale="en-EN"/&gt;
        ///     ...
        ///   &lt;/Conditions&gt;
        /// &lt;/Global.Resources&gt;
        /// </code>
        /// </example>
        [XmlAttribute]
        [DefaultValue(LocaleDefault)]
        public KnownCulture Locale
        {
            get => _locale;
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
                    : LocaleDefault;
            }
        }
        #endregion

        #endregion

        #region public override readonly properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default
        /// <inheritdoc />
        /// <summary>
        /// Gets a value indicating whether this instance is default.
        /// </summary>
        /// <value>
        /// <strong>true</strong> if this instance contains the default; otherwise, <strong>false</strong>.
        /// </value>
        public override bool IsDefault => string.IsNullOrEmpty(Key) &&
                                          string.IsNullOrEmpty(Field);
        #endregion

        #endregion

        #region public methods

        #region [public] (ConditionResult) Evaluate(): Returns result of evaluates condition
        /// <inheritdoc />
        /// <summary>
        /// Returns result of evaluates condition.
        /// </summary>
        /// <returns>
        /// A <see cref="T:iTin.Export.Model.ConditionResult" /> object that contains evaluate result.
        /// </returns>
        public ConditionResult Evaluate()
        {
            var service = ModelService.Instance;

            return Evaluate(
                service.CurrentRow,
                service.CurrentCol);
        }
        #endregion

        #region [public] (ConditionResult) Evaluate(int, int): Returns result of evaluates condition
        /// <inheritdoc />
        /// <summary>
        /// Returns result of evaluates condition.
        /// </summary>
        /// <param name="row">Data row</param>
        /// <param name="col">Field column</param>
        /// <returns>
        /// A <see cref="T:iTin.Export.Model.ConditionResult" /> object that contains evaluate result.
        /// </returns>
        public ConditionResult Evaluate(int row, int col)
        {
            var normalizedField = Field.ToUpperInvariant();
            var normalizedFieldName = BaseDataFieldModel.GetFieldNameFrom(Service.CurrentField).ToUpperInvariant();

            return normalizedField != normalizedFieldName 
                ? ConditionResult.Default 
                : Evaluate(row, col, Service.CurrentField.Value.GetValue());
        }
        #endregion

        #region [public] (void) SetOwner(ConditionsModel): Sets a reference to the owner object that contains this instance
        /// <summary>
        /// Sets a reference to the owner object that contains this instance.
        /// </summary>
        /// <param name="reference">Owner reference.</param>
        public void SetOwner(ConditionsModel reference)
        {
            _owner = reference;
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
        /// This method <see cref="M:iTin.Export.Model.DataFieldModel.ToString" /> returns a string that includes field alias.
        /// </remarks>
        public override string ToString()
        {
            return $"Key=\"{Key}\", Field=\"{Field}\"";
        }
        #endregion

        #endregion

        #region public abstrtact methods

        #region [public] {abstract} (ConditionResult) Evaluate(int, int, FieldValueInformation): Returns result of evaluates condition
        /// <inheritdoc />
        /// <summary>
        /// Returns result of evaluates condition.
        /// </summary>
        /// <param name="row">Data row</param>
        /// <param name="col">Field column</param>
        /// <param name="target">Field data</param>
        /// <returns>
        /// A <see cref="T:iTin.Export.Model.ConditionResult" /> object that contains evaluate result.
        /// </returns>
        public abstract ConditionResult Evaluate(int row, int col, FieldValueInformation target);
        #endregion

        #endregion

        #region protected methods

        #region [protected] (IEnumerable<string>) GetFieldAttributeEnumerable(): Returns a list of field condition content
        /// <summary>
        /// Returns a list of field condition with raw content.
        /// </summary>
        /// <returns>
        /// A list of field condition with raw content.
        /// </returns>
        protected IEnumerable<string> GetFieldAttributeEnumerable()
        {
            var validRawData = new Collection<string>();
            foreach (var rawData in Service.RawDataFiltered)
            {
                var fieldAttr = rawData.Attribute(Field);
                if (fieldAttr == null)
                {
                    continue;
                }

                if (string.IsNullOrEmpty(fieldAttr.Value))
                {
                    continue;
                }

                validRawData.Add(fieldAttr.Value);
            }

            return validRawData;
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
