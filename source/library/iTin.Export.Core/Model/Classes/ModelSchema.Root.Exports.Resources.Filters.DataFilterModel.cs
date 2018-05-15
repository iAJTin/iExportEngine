
using System.Xml.Linq;
using iTin.Export.ComponentModel.Patterns;

namespace iTin.Export.Model
{
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    using Helpers;

    public partial class DataFilterModel
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo DefaultActive = YesNo.Yes;
        #endregion

        #region public static properties

        #region [public] {static} (DataFilterModel) Empty: Gets an empty filter
        /// <summary>
        /// Gets an empty filter.
        /// </summary>
        /// <value>
        /// An empty condition.
        /// </value>
        public static DataFilterModel Empty => new DataFilterModel();
        #endregion

        #endregion

        #region private memebrs
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private YesNo _active;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private KnownOperator _criterial;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _field;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _key;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DataFiltersModel _owner;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _value;
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

        #region [public] (KnownOperator) Criterial: Gets or sets
        [XmlAttribute]
        public KnownOperator Criterial
        {
            get => _criterial; // GetStaticBindingValue(_criterial);
            set
            {
                SentinelHelper.IsEnumValid(value);

                _criterial = value;
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

                _key = value;
            }
        }
        #endregion

        #region [public] (DataFiltersModel) Owner: Gets the element that owns this
        /// <summary>
        /// Gets the element that owns this <see cref="T:iTin.Export.Model.DataFiltersModel" />.
        /// </summary>
        /// <value>
        /// The <see cref="T:iTin.Export.Model.HostsModel" /> that owns this <see cref="T:iTin.Export.Model.DataFiltersModel" />.
        /// </value>
        [XmlIgnore]
        [Browsable(false)]
        public DataFiltersModel Owner => _owner;
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

        #region [public] (void) SetOwner(DataFiltersModel): Sets the element that owns this
        /// <summary>
        /// Sets the element that owns this <see cref="T:iTin.Export.Model.DataFiltersModel" />.
        /// </summary>
        /// <param name="reference">Reference to owner.</param>
        public void SetOwner(DataFiltersModel reference)
        {
            _owner = reference;
        }
        #endregion

        #endregion

        public ExpressionSpecification<XElement> BuildExpression()
        {
            switch (Criterial)
            {
                case KnownOperator.EqualTo:
                    return new ExpressionSpecification<XElement>(o => o.Attribute(Field.ToUpperInvariant()).Value.ToUpperInvariant().Equals(Value.ToUpperInvariant()));
            }

            return null;
        }
    }
}
