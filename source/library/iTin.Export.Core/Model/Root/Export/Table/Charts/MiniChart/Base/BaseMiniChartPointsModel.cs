
namespace iTin.Export.Model
{
    using System.Diagnostics;

    public partial class BaseMiniChartPointsModel
    {
        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private MiniChartFirstPointModel _first;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private MiniChartHighPointModel _high;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private MiniChartLastPointModel _last;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private MiniChartLowPointModel _low;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private MiniChartNegativePointModel _negative;
        #endregion

        #region public properties

        #region [public] (MiniChartFirstPointModel) First: 
        public MiniChartFirstPointModel First
        {
            get => _first ?? (_first = new MiniChartFirstPointModel());
            set => _first = value;
        }
        #endregion

        #region [public] (MiniChartHighPointModel) High: 
        public MiniChartHighPointModel High
        {
            get => _high ?? (_high = new MiniChartHighPointModel());
            set => _high = value;
        }
        #endregion

        #region [public] (MiniChartLastPointModel) Last: 
        public MiniChartLastPointModel Last
        {
            get => _last ?? (_last = new MiniChartLastPointModel());
            set => _last = value;
        }
        #endregion

        #region [public] (MiniChartLowPointModel) Low: 
        public MiniChartLowPointModel Low
        {
            get => _low ?? (_low = new MiniChartLowPointModel());
            set => _low = value;
        }
        #endregion

        #region [public] (MiniChartNegativePointModel) Negative: 
        public MiniChartNegativePointModel Negative
        {
            get => _negative ?? (_negative = new MiniChartNegativePointModel());
            set => _negative = value;
        }
        #endregion

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default
        public override bool IsDefault => base.IsDefault &&
                                          First.IsDefault &&
                                          High.IsDefault &&
                                          Last.IsDefault &&
                                          Low.IsDefault &&
                                          Negative.IsDefault;
        #endregion

        #endregion
    }
}
