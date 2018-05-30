
namespace iTin.Export.Model
{
    using System;
    using System.Diagnostics;
    using System.Linq;
    using System.Xml.Serialization;

    using ComponentModel;
    using Helpers;

    public partial class RemarksCondition : ICloneable
    {
        #region public static properties

        #region [public] {static} (RemarksCondition) Empty: Gets an empty condition
        /// <summary>
        /// Gets an empty condition.
        /// </summary>
        /// <value>
        /// An empty condition.
        /// </value>
        public static RemarksCondition Empty => new RemarksCondition();
        #endregion

        #endregion

        #region private memebrs
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private KnownOperator _operator;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _style;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _value;
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
        public override bool IsDefault => base.IsDefault &&
                                          string.IsNullOrEmpty(Style);
        #endregion

        #endregion

        #region public properties

        #region [public] (string) Criterial: Gets or sets
        [XmlAttribute]
        public KnownOperator Criterial
        {
            get => _operator; // GetStaticBindingValue(_operator);
            set
            {
                SentinelHelper.IsEnumValid(value);

                _operator = value;
            }
        }
        #endregion

        #region [public] (bool) IsEmpty: Gets a value indicating whether this condition is an empty condition
        /// <summary>
        /// Gets a value indicating whether this condition is an empty condition.
        /// </summary>
        /// <value>
        /// <strong>true</strong> if is an empty condition; otherwise, <strong>false</strong>.
        /// </value>        
        public bool IsEmpty => IsDefault;
        #endregion

        #region [public] (string) Style: Gets or sets
        [XmlAttribute]
        public string Style
        {
            get => GetStaticBindingValue(_style);
            set
            {
                SentinelHelper.ArgumentNull(value);
                SentinelHelper.IsFalse(RegularExpressionHelper.IsValidIdentifier(value), new InvalidIdentifierNameException(ErrorMessageHelper.ModelIdentifierNameErrorMessage(this.GetType().Name, "Style", value)));

                _style = value;
            }
        }
        #endregion

        #region [public] (string) Value: Gets or sets
        [XmlAttribute]
        public string Value
        {
            get => GetStaticBindingValue(_value);
            set
            {
                SentinelHelper.ArgumentNull(value);

                _value = value;
            }
        }
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (string) Apply(int, int, FieldValueInformation): 
        public override string Apply(int row, int col, FieldValueInformation target)
        {
            return EntireRow == YesNo.No
                ? NonEntireRowApplyImpl(row, target)
                : EntireRowApplyImpl(row, target);
        }
        #endregion

        #endregion

        #region public methods

        #region [public] (LogicalConditionModel) Clone(): Clones this instance
        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public RemarksCondition Clone()
        {
            return (RemarksCondition)MemberwiseClone();
        }
        #endregion

        #endregion

        #region private static methods

        #region [private] {static} (bool) EvaluateCriterial(KnownOperator, string, string): 
        private static bool EvaluateCriterial(KnownOperator op, string dataValue, string testValue)
        {
            bool result = false;

            switch (op)
            {
                #region Criterial: Beetween
                case KnownOperator.Beetween:
                {
                    var values = testValue.Split(' ').ToList();
                    var totalValues = values.Count;
                    if (totalValues != 2)
                    {
                        throw new ArgumentOutOfRangeException();
                    }

                    var dataValueAsSpanishFormat = dataValue.Replace(".", ",");
                    var okValueDecimal = decimal.TryParse(dataValueAsSpanishFormat, out decimal dataValueAsDecimal);

                    var leftValueAsSpanishFormat = values[0].Replace(".", ",");
                    var okLeftValueDecimal = decimal.TryParse(leftValueAsSpanishFormat, out decimal leftValueAsDecimal);

                    var rightValueAsSpanishFormat = values[1].Replace(".", ",");
                    var okRightValueDecimal = decimal.TryParse(rightValueAsSpanishFormat, out decimal rightValueAsDecimal);

                    var canContinue = okValueDecimal && okLeftValueDecimal && okRightValueDecimal;
                    if (!canContinue)
                    {
                        break;
                    }

                    if (dataValueAsDecimal >= leftValueAsDecimal && dataValueAsDecimal >= rightValueAsDecimal)
                    {
                        result = true;
                    }
                    break;
                }
                #endregion

                #region Criterial: EqualTo
                case KnownOperator.EqualTo:
                    if (dataValue.Equals(testValue))
                    {
                        result = true;
                    }
                    break;
                #endregion

                #region Criterial: GreatherOrEqualsThan
                case KnownOperator.GreatherOrEqualsThan:
                {
                    var dataValueAsSpanishFormat = dataValue.Replace(".", ",");
                    var okValueDecimal = decimal.TryParse(dataValueAsSpanishFormat, out decimal dataValueAsDecimal);

                    var testValueAsSpanishFormat = testValue.Replace(".", ",");
                    var okTestValueDecimal = decimal.TryParse(testValueAsSpanishFormat, out decimal testValueAsDecimal);

                    var canContinue = okValueDecimal && okTestValueDecimal;
                    if (!canContinue)
                    {
                        break;
                    }

                    if (dataValueAsDecimal >= testValueAsDecimal)
                    {
                        result = true;
                    }
                    break;
                }
                #endregion

                #region Criterial: GreatherThan
                case KnownOperator.GreatherThan:
                {
                    var dataValueAsSpanishFormat = dataValue.Replace(".", ",");
                    var okValueDecimal = decimal.TryParse(dataValueAsSpanishFormat, out decimal dataValueAsDecimal);

                    var testValueAsSpanishFormat = testValue.Replace(".", ",");
                    var okTestValueDecimal = decimal.TryParse(testValueAsSpanishFormat, out decimal testValueAsDecimal);

                    var canContinue = okValueDecimal && okTestValueDecimal;
                    if (!canContinue)
                    {
                        break;
                    }

                    if (dataValueAsDecimal > testValueAsDecimal)
                    {
                        result = true;
                    }
                    break;
                }
                #endregion

                #region Criterial: In
                case KnownOperator.In:
                {
                    var inValues = testValue.Split(' ').ToList();
                    if (dataValue.In(inValues))
                    {
                        result = true;
                    }
                    break;
                }
                #endregion

                #region Criterial: LessOrEqualThan
                case KnownOperator.LessOrEqualThan:
                {
                    var dataValueAsSpanishFormat = dataValue.Replace(".", ",");
                    var okValueDecimal = decimal.TryParse(dataValueAsSpanishFormat, out decimal dataValueAsDecimal);

                    var testValueAsSpanishFormat = testValue.Replace(".", ",");
                    var okTestValueDecimal = decimal.TryParse(testValueAsSpanishFormat, out decimal testValueAsDecimal);

                    var canContinue = okValueDecimal && okTestValueDecimal;
                    if (!canContinue)
                    {
                        break;
                    }

                    if (dataValueAsDecimal <= testValueAsDecimal)
                    {
                        result = true;
                    }
                    break;
                }
                #endregion

                #region Criterial: LessThan
                case KnownOperator.LessThan:
                {
                    var dataValueAsSpanishFormat = dataValue.Replace(".", ",");
                    var okValueDecimal = decimal.TryParse(dataValueAsSpanishFormat, out decimal dataValueAsDecimal);

                    var testValueAsSpanishFormat = testValue.Replace(".", ",");
                    var okTestValueDecimal = decimal.TryParse(testValueAsSpanishFormat, out decimal testValueAsDecimal);

                    var canContinue = okValueDecimal && okTestValueDecimal;
                    if (!canContinue)
                    {
                        break;
                    }

                    if (dataValueAsDecimal < testValueAsDecimal)
                    {
                        result = true;
                    }
                    break;
                }
                #endregion

                #region Criterial: Like
                case KnownOperator.Like:
                    if (dataValue.Contains(testValue))
                    {
                        result = true;
                    }
                    break;
                #endregion

                #region Criterial: NotEqualTo
                case KnownOperator.NotEqualTo:
                    if (!dataValue.Equals(testValue))
                    {
                        result = true;
                    }
                    break;
                #endregion
            }

            return result;
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

        #region [private] (string) EntireRowApplyImpl(int, FieldValueInformation): 
        private string EntireRowApplyImpl(int row, FieldValueInformation target)
        {
            var rows = Service.RawDataFiltered;
            var rowData = rows[row];

            var normalizedField = Field.ToUpperInvariant();
            var fieldValue = rowData.Attribute(normalizedField).Value;

            string conditionStyle = null;
            var applyStyle = EvaluateCriterial(Criterial, fieldValue, Value);
            if (applyStyle)
            {
                conditionStyle = Style;
            }

            return conditionStyle ?? (row.IsOdd()
                       ? $"{target.Style.Name}_Alternate"
                       : target.Style.Name ?? StyleModel.NameOfDefaultStyle);
        }
        #endregion

        #region [private] (string) NonEntireRowApplyImpl(int, FieldValueInformation): 
        private string NonEntireRowApplyImpl(int row, FieldValueInformation target)
        {
            var normalizedField = Field.ToUpperInvariant();
            var normalizedFieldName = BaseDataFieldModel.GetFieldNameFrom(Service.CurrentField).ToUpperInvariant();
            if (normalizedField != normalizedFieldName)
            {
                return row.IsOdd()
                    ? $"{target.Style.Name}_Alternate"
                    : target.Style.Name ?? StyleModel.NameOfDefaultStyle;
            }

            var rows = Service.RawDataFiltered;
            var rowData = rows[row];
            var fieldValue = rowData.Attribute(normalizedField).Value;

            string conditionStyle = null;
            var applyStyle = EvaluateCriterial(Criterial, fieldValue, Value);
            if (applyStyle)
            {
                conditionStyle = Style;
            }

            return conditionStyle ?? (row.IsOdd()
                       ? $"{target.Style.Name}_Alternate"
                       : target.Style.Name ?? StyleModel.NameOfDefaultStyle);
        }
        #endregion

        #endregion
    }
}
