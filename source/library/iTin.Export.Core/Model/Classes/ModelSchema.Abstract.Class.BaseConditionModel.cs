
using iTin.Export.Helpers;

namespace iTin.Export.Model
{
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    public partial class BaseConditionModel 
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo DefaultExecute = YesNo.Yes;
        #endregion

        #region private fields
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _field;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _name;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ConditionsModel _owner;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _style;
        #endregion

        #region protected members

        #region [protected] BaseConditionModel(): Initializes a new instance of the class
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.BaseConditionModel"/> class.
        /// </summary>
        protected BaseConditionModel() 
        {
        }
        #endregion

        #endregion

        #region public properties

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

        #region [public] (string) Name: Gets or sets
        [XmlAttribute]
        public string Name
        {
            get => GetStaticBindingValue(_name);
            set
            {
                SentinelHelper.ArgumentNull(value);
                SentinelHelper.IsFalse(RegularExpressionHelper.IsValidIdentifier(value), new InvalidIdentifierNameException(ErrorMessageHelper.ModelIdentifierNameErrorMessage(this.GetType().Name, "Name", value)));

                _name = value;
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

        #endregion

        #region public methods

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
            return $"Name=\"{Name}\", Field=\"{Field}\"";
        }
        #endregion

        #endregion
    }
}
