
namespace iTin.Export.Model
{
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    using Helpers;

    public partial class BaseChartModel
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo DefaultShow = YesNo.Yes;
        #endregion

        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private YesNo _show;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ChartsModel _owner;
        #endregion

        #region constructor/s

        #region [protected] BaseChartModel(): Initializes a new instance of this class
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.BaseChartModel" /> class.
        /// </summary>
        protected BaseChartModel() => Show = DefaultShow;
        #endregion

        #endregion

        #region public abstract properties

        #region [public] {abstract} (KnownChartTypes) ChartType: Gets a value indicating chart type
        /// <summary>
        /// Gets a value indicating data chart type.
        /// </summary>
        /// <value>
        /// One of the <see cref="T:iTin.Export.Model.KnownChartTypes" /> values.
        /// </value>
        public abstract KnownChartTypes ChartType { get; }
        #endregion

        #endregion

        #region public properties

        #region [public] (ChartsModel) Owner: Gets the element that owns this
        /// <summary>
        /// Gets the element that owns this <see cref="T:iTin.Export.Model.ChartModel" />.
        /// </summary>
        /// <value>
        /// The <see cref="T:iTin.Export.Model.ChartsModel" /> that owns this <see cref="T:iTin.Export.Model.ChartModel" />.
        /// </value>
        [Browsable(false)]
        public ChartsModel Owner => _owner;
        #endregion

        #region [public] (YesNo) Show: Gets or sets a value that determines whether displays the chart or mini-chart
        [XmlAttribute]
        [DefaultValue(DefaultShow)]
        public YesNo Show
        {
            get => GetStaticBindingValue(_show.ToString()).ToUpperInvariant() == "NO" ? YesNo.No : YesNo.Yes;
            set
            {
                SentinelHelper.IsEnumValid(value);

                _show = value;
            }
        }
        #endregion

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default
        public override bool IsDefault => base.IsDefault && Show.Equals(DefaultShow);
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
            return $"Show={Show}";
        }
        #endregion

        #endregion

        #region public methods 

        #region [public] (void) SetOwner(ChartsModel): Sets the element that owns this
        /// <summary>
        /// Sets the element that owns this <see cref="T:iTin.Export.Model.ChartModel" />.
        /// </summary>
        /// <param name="reference">Reference to owner.</param>
        public void SetOwner(ChartsModel reference)
        {
            _owner = reference;
        }
        #endregion

        #endregion
    }
}
