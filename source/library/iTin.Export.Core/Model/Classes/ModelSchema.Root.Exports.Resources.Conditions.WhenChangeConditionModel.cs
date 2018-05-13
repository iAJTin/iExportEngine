
using System.Linq;

namespace iTin.Export.Model
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;

    using ComponentModel;
    using Helpers;

    public partial class WhenChangeConditionModel : ICloneable
    {
        #region public static properties

        #region [public] {static} (ChangeConditionModel) Empty: Gets an empty condition
        /// <summary>
        /// Gets an empty condition.
        /// </summary>
        /// <value>
        /// An empty condition.
        /// </value>
        public static WhenChangeConditionModel Empty => new WhenChangeConditionModel();
        #endregion

        #endregion

        #region private fields
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _fisrtSwapStyle;

        //[DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _lastStyle;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _secondSwapStyle;
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

        #region [public] (string) FirstSwapStyle: Gets or sets
        [XmlAttribute]
        public string FirstSwapStyle
        {
            get => GetStaticBindingValue(_fisrtSwapStyle);
            set
            {
                SentinelHelper.ArgumentNull(value);
                SentinelHelper.IsFalse(RegularExpressionHelper.IsValidIdentifier(value), new InvalidIdentifierNameException(ErrorMessageHelper.ModelIdentifierNameErrorMessage(this.GetType().Name, "FirstSwapStyle", value)));

                _fisrtSwapStyle = value;
            }
        }
        #endregion

        #region [public] (string) SecondSwapStyle: Gets or sets
        [XmlAttribute]
        public string SecondSwapStyle
        {
            get => GetStaticBindingValue(_secondSwapStyle);
            set
            {
                SentinelHelper.ArgumentNull(value);
                SentinelHelper.IsFalse(RegularExpressionHelper.IsValidIdentifier(value), new InvalidIdentifierNameException(ErrorMessageHelper.ModelIdentifierNameErrorMessage(this.GetType().Name, "SecondSwapStyle", value)));

                _secondSwapStyle = value;
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
        public override bool IsDefault => base.IsDefault &&
                                          string.IsNullOrEmpty(FirstSwapStyle) &&
                                          string.IsNullOrEmpty(SecondSwapStyle);
        #endregion

        #endregion

        #region public methods

        #region [public] (ChangeConditionModel) Clone(): Clones this instance
        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public WhenChangeConditionModel Clone()
        {
            return (WhenChangeConditionModel)MemberwiseClone();
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

        #region public override methods

        #region [public] {override} (string) Apply(int, int, FieldValueInformation, string): 
        public override string Apply(int row, int col, FieldValueInformation target, string referenceStyle)
        {
            var rows = Service.RawData;

            string previousValue = null;
            if (row > 0)
            {
                var rowPreviousData = rows[row - 1];
                previousValue = rowPreviousData.Attribute(Field)?.Value;
            }

            var rowData = rows[row];
            var currentValue = rowData.Attribute(Field)?.Value;
            var fieldName = BaseDataFieldModel.GetFieldNameFrom(Service.CurrentField);
            if (EntireRow == YesNo.No)
            {
                if (previousValue == null)
                {
                    if (Field != fieldName)
                    {
                        return row.IsOdd()
                            ? $"{target.Style.Name}_Alternate"
                            : target.Style.Name ?? StyleModel.NameOfDefaultStyle;
                    }

                    _lastStyle = FirstSwapStyle;
                    return _lastStyle;
                }

                if (Field != fieldName)
                {
                    return row.IsOdd()
                        ? $"{target.Style.Name}_Alternate"
                        : target.Style.Name ?? StyleModel.NameOfDefaultStyle;
                }

                if (currentValue == previousValue)
                {
                    return _lastStyle;
                }

                if (string.IsNullOrEmpty(SecondSwapStyle))
                {
                    return _lastStyle;
                }

                _lastStyle = _lastStyle == FirstSwapStyle
                    ? SecondSwapStyle
                    : FirstSwapStyle;

                return _lastStyle;
            }

            if (previousValue == null)
            {
                _lastStyle = FirstSwapStyle;
                return _lastStyle;
            }

            int fieldCol = rowData.Attributes().IndexOfAttribute(Field);
            if (fieldCol == 0)
            {
                if (currentValue == previousValue)
                {
                    return _lastStyle;
                }

                if (Field == fieldName)
                {
                    _lastStyle = _lastStyle == FirstSwapStyle
                        ? SecondSwapStyle
                        : FirstSwapStyle;
                }

                return _lastStyle;
            }

            if (currentValue == previousValue)
            {
                return _lastStyle;
            }

            var fieldsCount = Service.CurrentModel.Table.Fields.Count - 1;
            if (col != fieldsCount)
            {
                return _lastStyle == FirstSwapStyle
                    ? SecondSwapStyle
                    : FirstSwapStyle;
                
            }

            _lastStyle = _lastStyle == FirstSwapStyle
                ? SecondSwapStyle
                : FirstSwapStyle;

            return _lastStyle;
        }
        #endregion

        #endregion
    }
}
