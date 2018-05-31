
namespace iTin.Export.Model
{
    using System.ComponentModel;
    using System.Diagnostics;

    public partial class MiniChartAxesModel
    {
        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private MiniChartHorizontalAxisModel _horizontalAxis;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private MiniChartModel _parent;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private MiniChartVerticalAxisModel _verticalAxis;
        #endregion

        #region public properties

        #region [public] (MiniChartHorizontalAxisModel) Horizontal: Gets or sets a reference that contains the visual setting of horizontal axis
        public MiniChartHorizontalAxisModel Horizontal
        {
            get
            {
                if (_horizontalAxis == null)
                {
                    _horizontalAxis = new MiniChartHorizontalAxisModel();
                }

                _horizontalAxis.SetParent(this);

                return _horizontalAxis;
            }
            set => _horizontalAxis = value;
        }
        #endregion

        #region [public] (MiniChartModel) Parent: Gets the parent element of the element
        /// <summary>
        /// Gets the parent element of the element.
        /// </summary>
        /// <value>
        /// The element that represents the container element of the element.
        /// </value>
        [Browsable(false)]
        public MiniChartModel Parent => _parent;
        #endregion

        #region [public] (MiniChartVerticalAxisModel) Vertical: Gets or sets a reference that contains the visual setting of vertical axis
        public MiniChartVerticalAxisModel Vertical
        {
            get
            {
                if (_verticalAxis == null)
                {
                    _verticalAxis = new MiniChartVerticalAxisModel();
                }

                _verticalAxis.SetParent(this);

                return _verticalAxis;
            }
            set => _verticalAxis = value;
        }
        #endregion

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default
        public override bool IsDefault => 
            base.IsDefault && 
            Horizontal.IsDefault && 
            Vertical.IsDefault;
        #endregion

        #endregion

        #region internal methods

        #region [internal] (void) SetParent(MiniChartModel): Sets the parent element of the element
        /// <summary>
        /// Sets the parent element of the element.
        /// </summary>
        /// <param name="reference">Reference to parent.</param>
        internal void SetParent(MiniChartModel reference)
        {
            _parent = reference;
        }
        #endregion

        #endregion
    }
}
