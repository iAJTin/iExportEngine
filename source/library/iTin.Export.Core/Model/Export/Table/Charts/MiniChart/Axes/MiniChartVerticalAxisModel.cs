
namespace iTin.Export.Model
{
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    using Helpers;

    public partial class MiniChartVerticalAxisModel
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string DefaultMaxValue = "Automatic";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string DefaultMinValue = "Automatic";
        #endregion

        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _maxValue;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _minValue;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private MiniChartAxesModel _parent;
        #endregion

        #region constructor/s

        #region [public] MiniChartVerticalAxisModel(): Initializes a new instance of this class
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.MiniChartVerticalAxisModel" /> class.
        /// </summary>
        public MiniChartVerticalAxisModel()
        {
            Max = DefaultMaxValue;
            Min = DefaultMinValue;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (string) Max: Gets or sets preferred maximun value for the axis
        [XmlAttribute]
        [DefaultValue(DefaultMaxValue)]
        public string Max
        {
            get => GetStaticBindingValue(_maxValue);
            set
            {
                SentinelHelper.ArgumentNull(value);

                _maxValue = value;
            }
        }
        #endregion

        #region [public] (string) Min: Gets or sets preferred minimun value for the axis
        [XmlAttribute]
        [DefaultValue(DefaultMinValue)]
        public string Min
        {
            get => GetStaticBindingValue(_minValue);
            set
            {
                SentinelHelper.ArgumentNull(value);

                _minValue = value;
            }
        }
        #endregion

        #region [public] (MiniChartAxesModel) Parent: Gets the parent element of the element
        /// <summary>
        /// Gets the parent element of the element.
        /// </summary>
        /// <value>
        /// The element that represents the container element of the element.
        /// </value>
        [Browsable(false)]
        public MiniChartAxesModel Parent => _parent;
        #endregion

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default
        public override bool IsDefault =>
            base.IsDefault &&
            Max == DefaultMaxValue &&
            Min == DefaultMinValue;
        #endregion

        #endregion

        #region internal methods

        #region [internal] (void) SetParent(MiniChartAxesModel): Sets the parent element of the element
        /// <summary>
        /// Sets the parent element of the element.
        /// </summary>
        /// <param name="reference">Reference to parent.</param>
        internal void SetParent(MiniChartAxesModel reference)
        {
            _parent = reference;
        }
        #endregion

        #endregion
    }
}
