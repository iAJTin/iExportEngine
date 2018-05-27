

namespace iTin.Export.Model
{
    using System.ComponentModel;
    using System.Diagnostics;

    public partial class MiniChartColumnSerieModel
    {
        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private MiniChartColumnTypeModel _parent;
        #endregion

        #region public properties

        #region [public] (MiniChartColumnTypeModel) Parent: Gets the parent element of the element
        /// <summary>
        /// Gets the parent element of the element.
        /// </summary>
        /// <value>
        /// The element that represents the container element of the element.
        /// </value>
        [Browsable(false)]
        public MiniChartColumnTypeModel Parent => _parent;
        #endregion

        #endregion

        #region internal methods

        #region [internal] (void) SetParent(MiniChartColumnTypeModel): Sets the parent element of the element
        /// <summary>
        /// Sets the parent element of the element.
        /// </summary>
        /// <param name="reference">Reference to parent.</param>
        internal void SetParent(MiniChartColumnTypeModel reference)
        {
            _parent = reference;
        }
        #endregion

        #endregion
    }
}
