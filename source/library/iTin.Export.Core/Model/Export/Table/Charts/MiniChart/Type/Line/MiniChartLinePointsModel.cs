
namespace iTin.Export.Model
{
    using System.ComponentModel;
    using System.Diagnostics;

    public partial class MiniChartLinePointsModel
    {
        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private MiniChartMarkersPointModel _markers;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private BaseMiniChartPointsModel _parent;
        #endregion

        #region public properties

        #region [public] (MiniChartMarkersPointModel) Markers: 
        public MiniChartMarkersPointModel Markers
        {
            get => _markers ?? (_markers = new MiniChartMarkersPointModel());
            set => _markers = value;
        }
        #endregion

        #region [public] (BaseMiniChartPointsModel) Parent: Gets the parent element of the element
        /// <summary>
        /// Gets the parent element of the element.
        /// </summary>
        /// <value>
        /// The element that represents the container element of the element.
        /// </value>
        [Browsable(false)]
        public BaseMiniChartPointsModel Parent => _parent;
        #endregion

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default
        public override bool IsDefault => base.IsDefault &&
                                          Markers.IsDefault;
        #endregion

        #endregion

        #region internal methods

        #region [internal] (void) SetParent(BaseMiniChartPointsModel): Sets the parent element of the element
        /// <summary>
        /// Sets the parent element of the element.
        /// </summary>
        /// <param name="reference">Reference to parent.</param>
        internal void SetParent(BaseMiniChartPointsModel reference)
        {
            _parent = reference;
        }
        #endregion

        #endregion
    }
}
