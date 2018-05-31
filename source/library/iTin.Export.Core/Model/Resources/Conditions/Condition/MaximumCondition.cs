
namespace iTin.Export.Model
{
    using System;
    using System.Diagnostics;
    using System.Linq;
    using System.Xml.Serialization;

    using ComponentModel;
    using Helpers;

    public partial class MaximumCondition : ICloneable
    {
        #region public static properties

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

        #region private memebrs
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _style;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _maxValue;
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
                SentinelHelper.IsFalse(RegularExpressionHelper.IsValidIdentifier(value), new InvalidIdentifierNameException(ErrorMessageHelper.ModelIdentifierNameErrorMessage(GetType().Name, "Style", value)));

                _style = value;
            }
        }
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (string) Apply(int, int, FieldValueInformation): 
        public override string Apply(int row, int col, FieldValueInformation target)
        {
            var field = BaseDataFieldModel.GetFieldNameFrom(ModelService.Instance.CurrentField);
            if (field != Field)
            {
                return row.IsOdd()
                    ? $"{target.Style.Name}_Alternate"
                    : target.Style.Name ?? StyleModel.NameOfDefaultStyle;
            }

            if (_maxValue == null)
            {
                _maxValue = ModelService.Instance.RawDataFiltered.Select(i => i.Attribute(Field).Value).Max();               
            }

            return new RemarksCondition
            {
                Active = Active,
                Criterial = KnownOperator.EqualTo,
                Field = Field,
                EntireRow = EntireRow,
                Style = Style,
                Value = _maxValue
            }.Apply(row, col, target);
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
