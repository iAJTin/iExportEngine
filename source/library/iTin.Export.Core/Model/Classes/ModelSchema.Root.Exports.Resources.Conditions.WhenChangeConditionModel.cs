
namespace iTin.Export.Model
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;

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

        //#region [public] (ConditionsModel) Owner: Gets the element that owns this
        ///// <summary>
        ///// Gets the element that owns this <see cref="T:iTin.Export.Model.StyleModel" />.
        ///// </summary>
        ///// <value>
        ///// The <see cref="T:iTin.Export.Model.StylesModel" /> that owns this <see cref="T:iTin.Export.Model.StyleModel" />.
        ///// </value>
        //[XmlIgnore]
        //[Browsable(false)]
        //public ConditionsModel Owner => _owner;
        //#endregion

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
    }
}
