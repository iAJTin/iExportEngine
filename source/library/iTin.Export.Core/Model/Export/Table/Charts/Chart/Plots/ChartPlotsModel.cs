
namespace iTin.Export.Model
{
    using System;
    using System.Diagnostics;

    using Helpers;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    public partial class ChartPlotsModel
    {
        #region private fields
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ChartBorderModel _border;
        #endregion

        #region constructor/s

        #region [public] ChartPlotsModel(ChartModel):
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.ChartPlotsModel" /> class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        public ChartPlotsModel(ChartModel parent)
            : base(parent)
        {
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (ChartBorderModel) Border: Gets or sets a reference that contains the visual setting for common border of plots
        /// <summary>
        /// Gets or sets a reference that contains the visual setting for common border of plots.
        /// </summary>
        /// <value>
        /// A <see cref="T:iTin.Export.Model.ChartBorderModel" /> reference that contains the visual setting for border of plots.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Plots ...&gt;
        ///   &lt;Border/&gt;
        ///   ...
        /// &lt;/Plots&gt;
        /// </code>
        /// <para>
        /// <para><strong>Compatibility table with native writers.</strong></para>
        /// <table>
        ///   <thead>
        ///     <tr>
        ///       <th>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.CsvWriter" /></th>
        ///       <th>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.TsvWriter" /></th>
        ///       <th>SQL Script<br/><see cref="T:iTin.Export.Writers.Native.SqlScriptWriter" /></th>
        ///       <th>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Native.Spreadsheet2003TabularWriter" /></th>
        ///     </tr>
        ///   </thead>
        ///   <tbody>
        ///     <tr>
        ///       <td align="center">No has effect</td>
        ///       <td align="center">No has effect</td>
        ///       <td align="center">No has effect</td>
        ///       <td align="center">No has effect</td>
        ///     </tr>
        ///   </tbody>
        /// </table>
        /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
        /// </para>
        /// </remarks>
        public ChartBorderModel Border
        {
            get => _border ?? (_border = new ChartBorderModel());
            set => _border = value;
        }
        #endregion

        #endregion

        #region public overrides properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance contains the default
        /// <inheritdoc />
        /// <include file="..\..\iTin.Export.Documentation.Common.xml" path="Common/Model/Public/Overrides/Properties/Property[@name='IsDefault']/*" />
        public override bool IsDefault => base.IsDefault && Border.IsDefault;
        #endregion

        #endregion

        /// <summary>
        /// Validates chart definition list.
        /// </summary>
        public void Validate()
        {
            foreach (var plot in this)
            {
                plot.Series.Validate();
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="item"></param>
        protected override void SetOwner(ChartPlotModel item)
        {
            SentinelHelper.ArgumentNull(item);

            item.SetOwner(this);
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public override ChartPlotModel GetBy(string value)
        {
            return Find(s => s.Name.Equals(value, StringComparison.Ordinal));
        }
    }
}
