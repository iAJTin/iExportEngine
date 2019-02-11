
namespace iTin.Export.Model
{
    using System;
    using System.Diagnostics;
    using System.Globalization;
    using System.Linq;
    using System.Xml.Serialization;

    using ComponentModel;
    using Helpers;

    /// <summary>
    /// Represents a field condition. Defines the style that will be applied to the field when its value is the maximum.
    /// </summary>
    public partial class MaximumCondition : ICloneable
    {
        #region private memebrs
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _style;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private object _maxValue;
        #endregion

        #region constructor/s

        #region [public] MaximumCondition(): Initializes a new instance of this class
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.MaximumCondition" /> class.
        /// </summary>
        public MaximumCondition()
        {
            _maxValue = null;
        }
        #endregion

        #endregion

        #region public static readonly properties

        #region [public] {static} (MaximumCondition) Empty: Gets an empty condition
        /// <summary>
        /// Gets an empty condition.
        /// </summary>
        /// <value>
        /// An empty condition.
        /// </value>
        public static MaximumCondition Empty => new MaximumCondition();
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
        public override bool IsDefault => base.IsDefault &&
                                          string.IsNullOrEmpty(Style);
        #endregion

        #endregion

        #region public readonly properties

        #region [public] (bool) IsEmpty: Gets a value indicating whether this condition is an empty condition
        /// <summary>
        /// Gets a value indicating whether this condition is an empty condition.
        /// </summary>
        /// <value>
        /// <strong>true</strong> if is an empty condition; otherwise, <strong>false</strong>.
        /// </value>        
        public bool IsEmpty => IsDefault;
        #endregion

        #endregion

        #region public properties

        #region [public] (string) Style: Gets or sets a value that represents the style that is applied when the condition is met
        /// <summary>
        /// Gets or sets a value that represents the style that is applied when the condition is met.
        /// </summary>
        /// <value>
        /// A <see cref ="T:System.String"/> that represents the style that is applied when the condition is met.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;MaximumValue Style="string" .../&gt;
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
        ///     &lt;MaximumValue Key="max" Active="Yes" Field="TOTAL" EntireRow="No" Style="maxTotalStyle"/&gt;
        ///     ...
        ///   &lt;/Conditions&gt;
        /// &lt;/Global.Resources&gt;
        /// </code>
        /// </example>
        [XmlAttribute]
        public string Style
        {
            get => GetStaticBindingValue(_style);
            set
            {
                SentinelHelper.ArgumentNull(value);
                SentinelHelper.IsFalse(RegularExpressionHelper.IsValidIdentifier(value), new InvalidIdentifierNameException(ErrorMessageHelper.ModelIdentifierNameErrorMessage(GetType().Name, "Style", value)));

                _style = value;
            }
        }
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (ConditionResult) Evaluate(int, int, FieldValueInformation): Returns result of evaluates condition
        /// <summary>
        /// Returns result of evaluates condition.
        /// </summary>
        /// <param name="row">Data row</param>
        /// <param name="col">Field column</param>
        /// <param name="target">Field data</param>
        /// <returns>
        /// A <see cref="T:iTin.Export.Model.ConditionResult"/> object that contains evaluate result.
        /// </returns>
        public override ConditionResult Evaluate(int row, int col, FieldValueInformation target)
        {
            if (target.IsText)
            {
                return ConditionResult.Default;
            }

            if (_maxValue == null)
            {
                var culture = Locale == KnownCulture.Current
                    ? CultureInfo.CurrentUICulture
                    : new CultureInfo(Locale.ToString());

                if (target.IsNumeric)
                {
                    _maxValue = CalculateNumericMaxValue(culture);
                }

                if (target.IsDateTime)
                {
                    _maxValue = CalculateDateTimeMaxValue(culture);
                }
            }

            var remarks = new RemarksCondition
            {
                Active = Active,
                Criterial = KnownOperator.EqualTo,
                EntireRow = EntireRow,
                Field = Field,
                Locale = Locale,
                Style = Style,
                Value = _maxValue.ToString()
            };

            return remarks.Evaluate(row, col, target);
        }
        #endregion

        #endregion

        #region public methods

        #region [public] (MaximumCondition) Clone(): Clones this instance
        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public MaximumCondition Clone()
        {
            return (MaximumCondition)MemberwiseClone();
        }
        #endregion

        #endregion

        #region private methods

        #region [private] (DateTime) CalculateDateTimeMaxValue(IFormatProvider): Returns max datetime value
        private DateTime CalculateDateTimeMaxValue(IFormatProvider culture)
        {
            var data = GetFieldAttributeEnumerable();
            var result = data.Select(value => DateTime.Parse(value, culture));

            return result.Max();
        }
        #endregion

        #region [private] (decimal) CalculateNumericMaxValue(IFormatProvider): Returns max decimal value
        private decimal CalculateNumericMaxValue(IFormatProvider culture)
        {
            var data = GetFieldAttributeEnumerable();
            var result = data.Select(value => decimal.Parse(value, culture));

            return result.Max();
        }
        #endregion

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
