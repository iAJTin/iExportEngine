
namespace iTin.Export.Model
{
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Xml.Serialization;

    using Drawing.Helper;
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
        private const YesNo DefaultShow = YesNo.No;
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
            get => GetStaticBindingValue(_rightToLeft.ToString()).ToUpperInvariant() == "NO" ? YesNo.No : YesNo.Yes;
            set
            {
                SentinelHelper.IsEnumValid(value);

                _rightToLeft = value;
            }
        }
        #endregion

        #region [public] (YesNo) Show: Gets or sets a value that determines whether this axis is shown
        [XmlAttribute("Show")]
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

        #region [public] (string) Type: Gets or sets preferred axis type
        [XmlAttribute]
        [DefaultValue(DefaultAxisType)]
        public string Type
        {
            get => GetStaticBindingValue(_axisType).ToUpperInvariant();
            set
            {
                SentinelHelper.ArgumentNull(value);

                _axisType = value;
            }
        }
        #endregion

        #region [public] (bool) IsDateAxis: Gets or sets 
        public bool IsDateAxis
        {
            get
            {
                if (Type.Equals(DefaultAxisType.ToUpperInvariant()))
                {
                    return false;
                }

                var fields = Parent.Parent.Owner.Parent.Fields;
                var field = fields[Type];
                var canContinue = field.Value.TryGetStyle(out var style);
                if (!canContinue)
                {
                    return false;
                }

                bool isDateTime = style.Content.DataType is DatetimeDataTypeModel;
                if (!isDateTime)
                {
                    return false;
                }

                return true;
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

        #region public methods

        #region [public] (Color) GetColor(): Gets a reference to the color structure preferred for this axis
        /// <summary>
        /// Gets a reference to the <see cref="T:System.Drawing.Color" /> structure preferred for this axis.
        /// </summary>
        /// <returns>
        /// <see cref="T:System.Drawing.Color"/> structure that represents a .NET color.
        /// </returns>
        public Color GetColor()
        {
            return Color.Equals(DefaultAxisColor) 
                ? System.Drawing.Color.Black 
                : ColorHelper.GetColorFromString(Color);
        }
        #endregion

        #region [public] (BaseDataFieldModel) GetAxisField(): Gets a reference to the field which acts as date axis field
        public BaseDataFieldModel GetAxisField()
        {
            if (Type.Equals(DefaultAxisType))
            {
                return null;
            }

            var fields = Parent.Parent.Owner.Parent.Fields;
            return fields[Type];
        }
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
