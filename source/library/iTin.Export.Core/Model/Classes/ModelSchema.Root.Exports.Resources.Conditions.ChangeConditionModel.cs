
namespace iTin.Export.Model
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    using Helpers;

    public partial class ChangeConditionModel : ICloneable
    {
        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _name;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _field;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _style;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ConditionsModel _owner;
        #endregion

        #region public static properties

        #region [public] {static} (ChangeConditionModel) Empty: Gets an empty condition
        /// <summary>
        /// Gets an empty condition.
        /// </summary>
        /// <value>
        /// An empty condition.
        /// </value>
        public static ChangeConditionModel Empty => new ChangeConditionModel();
        #endregion

        #endregion

        #region public properties

        #region [public] (string) Name: Gets or sets the name of this condition
        [XmlAttribute]
        public string Name
        {
            get => _name;
            set
            {
                SentinelHelper.ArgumentNull(value);
                SentinelHelper.IsFalse(RegularExpressionHelper.IsValidIdentifier(value), new InvalidIdentifierNameException(ErrorMessageHelper.ModelIdentifierNameErrorMessage("Style", "Name", value)));

                _name = value;
            }
        }
        #endregion

        #region [public] (string) Field: Gets or sets the name of field
        /// <summary>
        /// Gets or sets the name of field.
        /// </summary>
        /// <value>
        /// The name of target field.
        /// </value>
        [XmlAttribute]
        [DefaultValue("")]
        public string Field
        {
            get => _field;
            set
            {
                SentinelHelper.ArgumentNull(value);
                SentinelHelper.IsFalse(RegularExpressionHelper.IsValidFieldName(value), new InvalidFieldIdentifierNameException(ErrorMessageHelper.FieldIdentifierNameErrorMessage("ChangeCondition", "Field", value)));

                _field = value;
            }
        }
        #endregion

        #region [public] (string) Style: Gets or sets the name of style
        /// <summary>
        /// Gets or sets the name of style.
        /// </summary>
        /// <value>
        /// The name of style.
        /// </value>
        [XmlAttribute]
        [DefaultValue("")]
        public string Style
        {
            get => _style;
            set
            {
                SentinelHelper.ArgumentNull(value);

                _style = value;
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

        #region [public] (ConditionsModel) Owner: Gets the element that owns this
        /// <summary>
        /// Gets the element that owns this <see cref="T:iTin.Export.Model.StyleModel" />.
        /// </summary>
        /// <value>
        /// The <see cref="T:iTin.Export.Model.StylesModel" /> that owns this <see cref="T:iTin.Export.Model.StyleModel" />.
        /// </value>
        [XmlIgnore]
        [Browsable(false)]
        public ConditionsModel Owner => _owner;
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
        public override bool IsDefault => string.IsNullOrEmpty(Name) &&
                                          string.IsNullOrEmpty(Field) &&
                                          string.IsNullOrEmpty(Style);
        #endregion

        #endregion

        #region public methods

        #region [public] (ChangeConditionModel) Clone(): Clones this instance
        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public ChangeConditionModel Clone()
        {
            return (ChangeConditionModel)MemberwiseClone();
        }
        #endregion

        #endregion

        #region internal methods

        #region [public] (void) SetOwner(ConditionsModel): Sets the element that owns this
        /// <summary>
        /// Sets the element that owns this <see cref="T:iTin.Export.Model.ConditionsModel" />.
        /// </summary>
        /// <param name="reference">Reference to owner.</param>
        internal void SetOwner(ConditionsModel reference)
        {
            _owner = reference;
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
