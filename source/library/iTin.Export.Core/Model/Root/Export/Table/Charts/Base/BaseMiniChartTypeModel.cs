
namespace iTin.Export.Model
{
    using System.ComponentModel;
    using System.Diagnostics;

    public partial class BaseMiniChartTypeModel
    {
        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private MiniChartTypeModel _parent;
        #endregion

        #region public properties

        #region [public] (BaseMiniChartSerieModel) Serie: Gets or sets a reference that contains definition of the data series to draw
        public abstract BaseMiniChartSerieModel Serie { get; set; }
        #endregion

        #region [public] (MiniChartTypeModel) Parent: Gets the parent element of the element
        /// <summary>
        /// Gets the parent element of the element.
        /// </summary>
        /// <value>
        /// The element that represents the container element of the element.
        /// </value>
        [Browsable(false)]
        public MiniChartTypeModel Parent => _parent;
        #endregion

        #region [public] (BaseMiniChartPointsModel) Points: Gets or sets a reference that contains the definition of the significant points of the drawn series
        public abstract BaseMiniChartPointsModel Points { get; set; }
        #endregion

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default
        public override bool IsDefault => base.IsDefault &&
                                          Serie.IsDefault &&
                                          Points.IsDefault;
        #endregion

        #endregion

        #region internal methods

        #region [internal] (void) SetParent(MiniChartModel): Sets the parent element of the element
        /// <summary>
        /// Sets the parent element of the element.
        /// </summary>
        /// <param name="reference">Reference to parent.</param>
        internal void SetParent(MiniChartTypeModel reference)
        {
            _parent = reference;
        }
        #endregion

        #endregion
    }
}
