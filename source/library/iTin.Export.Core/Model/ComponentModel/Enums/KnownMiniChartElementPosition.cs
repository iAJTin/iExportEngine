
namespace iTin.Export.Model
{
    /// <summary>
    /// Specifies the known minichart element location.
    /// </summary>
    public enum KnownMiniChartElementPosition
    {
        /// <summary>
        /// Defines minichart element location by coordenates system, please see <see cref="T:iTin.Export.Model.CoordenatesModel" /> for more information.
        /// </summary>
        ByCoordenates,

        /// <summary>
        /// Defines minichart element location by column, please see <see cref="T:iTin.Export.Model.ByColumnLocationModel" /> for more information.
        /// </summary>
        ByColumn,
    }
}
