
namespace iTin.Export.Model
{
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    using ComponentModel;
    using Helpers;

    public partial class BaseConditionModel : ICondition
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo DefaultActive = YesNo.Yes;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo DefaultEntireRow = YesNo.No;
        #endregion

        #region private fields
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private YesNo _active;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private YesNo _entrireRow;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _field;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _key;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ConditionsModel _owner;
        #endregion

        #region protected properties

        #region [protected] (ModelService) Service: 
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected ModelService Service => ModelService.Instance;
        #endregion

        #endregion

        #region public properties

        #region [public] (YesNo) Active: Gets or sets
        [XmlAttribute]
        [DefaultValue(DefaultActive)]
        public YesNo Active
        {
            get => GetStaticBindingValue(_active.ToString()).ToLowerInvariant() == "no" ? YesNo.No : YesNo.Yes;
            set
            {
                SentinelHelper.IsEnumValid(value);

                _active = value;
            }
        }
        #endregion

        #region [public] (YesNo) EntireRow: Gets or sets
        [XmlAttribute]
        [DefaultValue(DefaultEntireRow)]
        public YesNo EntireRow
        {
            get => GetStaticBindingValue(_entrireRow.ToString()).ToLowerInvariant() == "no" ? YesNo.No : YesNo.Yes;
            set
            {
                SentinelHelper.IsEnumValid(value);

                _entrireRow = value;
            }
        }
        #endregion

        #region [public] (string) Field: Gets or sets
        [XmlAttribute]
        public string Field
        {
            get => GetStaticBindingValue(_field);
            set
            {
                SentinelHelper.ArgumentNull(value);
                SentinelHelper.IsFalse(RegularExpressionHelper.IsValidFieldName(value), new InvalidFieldIdentifierNameException(ErrorMessageHelper.FieldIdentifierNameErrorMessage(this.GetType().Name, "Field", value)));

                _field = value;
            }
        }
        #endregion

        #region [public] (string) Key: Gets or sets
        [XmlAttribute]
        public string Key
        {
            get => GetStaticBindingValue(_key);
            set
            {
                SentinelHelper.ArgumentNull(value);
                SentinelHelper.IsFalse(RegularExpressionHelper.IsValidIdentifier(value), new InvalidIdentifierNameException(ErrorMessageHelper.ModelIdentifierNameErrorMessage(this.GetType().Name, "Name", value)));

                _key = value;
            }
        }
        #endregion

        #region [public] (ConditionsModel) Owner: Gets the element that owns this condition.
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

        #region public override properties

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

        #region [public] (string) Apply(): 
        /// <summary>
        /// Evaluates the specified row.
        /// </summary>
        /// <returns>
        /// System.String.
        /// </returns>
        public string Apply()
        {
            var service = ModelService.Instance;

            return Apply(
                service.CurrentRow,
                service.CurrentCol);
        }
        #endregion

        #region [public] (string) Apply(int, int): 
        /// <summary>
        /// Evaluates the specified row.
        /// </summary>
        /// <param name="row">The row.</param>
        /// <param name="col">The col.</param>
        /// <returns>
        /// System.String.
        /// </returns>
        public string Apply(int row, int col)
        {
            var service = ModelService.Instance;

            return Apply(
                service.CurrentRow,
                service.CurrentCol,
                service.CurrentField.Value.GetValue());
        }
        #endregion

        #region [public] (void) SetOwner(ConditionsModel): Sets a reference to the owner object that contains this instance
        /// <inheritdoc />
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

        #region [public] {abstract} (string) Apply(int, int, FieldValueInformation): 
        /// <summary>
        /// Evaluates the specified row.
        /// </summary>
        /// <param name="row">The row.</param>
        /// <param name="col">The col.</param>
        /// <param name="target">The target.</param>
        /// <returns>System.String.</returns>
        public abstract string Apply(int row, int col, FieldValueInformation target);
        #endregion

        #endregion
    }
}
