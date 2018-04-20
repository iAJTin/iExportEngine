
namespace iTin.Export.Model
{
    /// <summary>
    /// Specifies content data type.
    /// </summary>
    public enum KnownDataType
    {
        /// <summary>
        /// Numeric data type, please see <see cref="T:iTin.Export.Model.NumericDataTypeModel" /> for more information.
        /// </summary>
        Numeric,

        /// <summary>
        /// Text data type, please see <see cref="T:iTin.Export.Model.TextDataTypeModel" /> for more information.
        /// </summary>
        Text,

        /// <summary>
        /// Text data type, please see <see cref="T:iTin.Export.Model.PercentageDataTypeModel" /> for more information.
        /// </summary>
        Percentage,

        /// <summary>
        /// Scientific data type, please see <see cref="T:iTin.Export.Model.ScientificDataTypeModel" /> for more information.
        /// </summary>
        Scientific,

        /// <summary>
        /// Currency data type, please see <see cref="T:iTin.Export.Model.CurrencyDataTypeModel" /> for more information.
        /// </summary>
        Currency,

        /// <summary>
        /// Date time data type, please see <see cref="T:iTin.Export.Model.DatetimeDataTypeModel" /> for more information.
        /// </summary>
        Datetime,

        /// <summary>
        /// Special data type, please see <see cref="T:iTin.Export.Model.SpecialDataTypeModel" /> for more information.
        /// </summary>
        Special
    }
}
