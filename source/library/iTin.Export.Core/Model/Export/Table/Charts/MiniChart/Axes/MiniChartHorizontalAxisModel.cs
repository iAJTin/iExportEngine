
namespace iTin.Export.Model
{
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    using Helpers;

    public partial class MiniChartHorizontalAxisModel
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string DefaultAxisColor = "Automatic";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string DefaultAxisType = "General";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo DefaultRightToLeft = YesNo.No;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo DefaultShow = YesNo.Yes;
        #endregion

        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _axisColor;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _axisType;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private MiniChartAxesModel _parent;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private YesNo _rightToLeft;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private YesNo _show;
        #endregion

        #region constructor/s

        #region [public] MiniChartHorizontalAxisModel(): Initializes a new instance of this class
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.MiniChartHorizontalAxisModel" /> class.
        /// </summary>
        public MiniChartHorizontalAxisModel()
        {
            Color = DefaultAxisColor;
            RightToLeft = DefaultRightToLeft;
            Show = DefaultShow;
            Type = DefaultAxisType;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (string) Color: Gets or sets preferred axis color
        [XmlAttribute]
        [DefaultValue(DefaultAxisColor)]
        public string Color
        {
            get => GetStaticBindingValue(_axisColor);
            set
            {
                SentinelHelper.ArgumentNull(value);

                _axisColor = value;
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

        #region [public] (YesNo) RightToLeft: Gets or sets a value indicating whether the data are drawn from right to left
        [XmlAttribute]
        [DefaultValue(DefaultRightToLeft)]
        public YesNo RightToLeft
        {
            get => GetStaticBindingValue(_rightToLeft.ToString()).ToLowerInvariant() == "no" ? YesNo.No : YesNo.Yes;
            set
            {
                SentinelHelper.IsEnumValid(value);

                _rightToLeft = value;
            }
        }
        #endregion

        #region [public] (YesNo) Show: Gets or sets a value that determines whether this axis is shown
        [XmlAttribute]
        [DefaultValue(DefaultShow)]
        public YesNo Show
        {
            get => GetStaticBindingValue(_show.ToString()).ToLowerInvariant() == "no" ? YesNo.No : YesNo.Yes;
            set
            {
                SentinelHelper.IsEnumValid(value);

                _show = value;
            }
        }
        #endregion

        #region [public] (string) Type: Gets or sets preferred axis type
        [XmlAttribute]
        [DefaultValue(DefaultAxisType)]
        public string Type
        {
            get => GetStaticBindingValue(_axisType);
            set
            {
                SentinelHelper.ArgumentNull(value);

                _axisType = value;
            }
        }
        #endregion

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default
        public override bool IsDefault =>
            base.IsDefault && 
            Color == DefaultAxisColor && 
            RightToLeft == DefaultRightToLeft && 
            Show == DefaultShow && 
            Type == DefaultAxisType;
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
