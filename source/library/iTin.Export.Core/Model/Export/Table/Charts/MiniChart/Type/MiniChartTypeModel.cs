
namespace iTin.Export.Model
{
    using System.ComponentModel;
    using System.Diagnostics;

    public partial class MiniChartTypeModel
    {
        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private MiniChartColumnTypeModel _column;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private MiniChartLineTypeModel _line;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private MiniChartModel _parent;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private MiniChartWinLossTypeModel _winLoss;
        #endregion

        #region public properties

        #region [public] (MiniChartColumnTypeModel) Column: Gets or sets a reference that contains the visual setting of a column mini-chart
        public MiniChartColumnTypeModel Column
        {
            get
            {
                if (_column == null)
                {
                    _column = new MiniChartColumnTypeModel();
                }

                _column.SetParent(this);

                return _column;
            }
            set => _column = value;
        }
        #endregion

        #region [public] (MiniChartLineTypeModel) Line: Gets or sets a reference that contains the visual setting of a line mini-chart
        public MiniChartLineTypeModel Line
        {
            get
            {
                if (_line == null)
                {
                    _line = new MiniChartLineTypeModel();
                }

                _line.SetParent(this);

                return _line;
            }
            set => _line = value;
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

        #region [public] (MiniChartWinLossTypeModel) WinLoss: Gets or sets a reference that contains the visual setting of a win-loss mini-chart
        public MiniChartWinLossTypeModel WinLoss
        {
            get
            {
                if (_winLoss == null)
                {
                    _winLoss = new MiniChartWinLossTypeModel();
                }

                _winLoss.SetParent(this);

                return _winLoss;
            }
            set => _winLoss = value;
        }
        #endregion

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default
        public override bool IsDefault => base.IsDefault &&
                                          Column.IsDefault &&
                                          Line.IsDefault &&
                                          WinLoss.IsDefault;
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
