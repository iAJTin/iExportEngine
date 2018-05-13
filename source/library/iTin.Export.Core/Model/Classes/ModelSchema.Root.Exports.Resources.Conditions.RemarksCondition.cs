
namespace iTin.Export.Model
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;

    using ComponentModel;
    using Helpers;

    public partial class RemarksCondition : ICloneable
    {
        #region public static properties

        #region [public] {static} (LogicalConditionModel) Empty: Gets an empty condition
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
            var fieldName = BaseDataFieldModel.GetFieldNameFrom(Service.CurrentField);
            if (Field != fieldName)
            {
                return row.IsOdd()
                    ? $"{target.Style.Name}_Alternate"
                    : target.Style.Name ?? StyleModel.NameOfDefaultStyle;
            }

            string conditionStyle = null;
            var rows = Service.RawData;
            var rowData = rows[row];
            var fieldValue = rowData.Attribute(Field).Value;

            switch (Criterial)
            {
                case KnownOperator.Beetween:
                    break;

                case KnownOperator.EqualTo:
                    if (Value.Equals(fieldValue))
                    {
                        conditionStyle = Style;
                    }
                    break;

                case KnownOperator.GreatherOrEqualsThan:
                    var okValueDecimal = decimal.TryParse(Value.Replace(".", ","), out decimal asValueDecimal);
                    var okFieldValueDecimal = decimal.TryParse(fieldValue.Replace(".", ","), out decimal asFieldDecimal);
                    if (!(okValueDecimal && okFieldValueDecimal))
                    {
                        break;
                    }

                    if (asFieldDecimal >= asValueDecimal)
                    {
                        conditionStyle = Style;                        
                    }
                    break;

                case KnownOperator.GreatherThan:
                    if (int.Parse(fieldValue) > int.Parse(Value))
                    {
                        conditionStyle = Style;
                    }
                    break;

                case KnownOperator.In:
                    break;

                case KnownOperator.LessOrEqualThan:
                    break;

                case KnownOperator.LessThan:
                    if (int.Parse(fieldValue) < int.Parse(Value))
                    {
                        conditionStyle = Style;
                    }
                    break;

                case KnownOperator.Like:
                    break;

                case KnownOperator.NotEqualTo:
                    if (!fieldValue.Equals(Value))
                    {
                        conditionStyle = Style;
                    }
                    break;
            }

            return conditionStyle ?? (row.IsOdd()
                       ? $"{target.Style.Name}_Alternate"
                       : target.Style.Name ?? StyleModel.NameOfDefaultStyle);
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
