
namespace iTin.Export.Inputs
{
    using System.Collections.Generic;
    using System.Data;

    using ComponentModel.Input;
    using Helpers;
    using Providers;

    /// <inheritdoc />
    /// <summary>
    /// Class than allows you to export an object of type <see cref="T:System.Data.DataRow" />.
    /// </summary>
    [InputOptions(AdapterType = typeof(DataSetProvider))]
    public class DataRowInput : DataSetInput
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Inputs.DataRowInput" /> class.
        /// </summary>
        /// <param name="rows">A <see cref="T:System.Data.DataRow" /> array object than contains the information.</param>
        /// <param name="name">The name.</param>
        protected DataRowInput(IEnumerable<DataRow> rows, string name)
            : base(SentinelHelper.PassThroughNonNull(CreateDataSetFrom(rows, name)))
        {
        }

        /// <summary>
        /// Creates the data set from.
        /// </summary>
        /// <param name="rows">The rows.</param>
        /// <param name="name">The name.</param>
        /// <returns>
        ///   <see cref="T:System.Data.DataSet" /> which contains the specified rows.
        /// </returns>
        private static DataSet CreateDataSetFrom(IEnumerable<DataRow> rows, string name)
        {
            DataSet ds;

            var dt = rows.CopyToDataTable();
            dt.TableName = name;

            using (var tempDs = new DataSet())
            {
                tempDs.Locale = dt.Locale;
                tempDs.Tables.Add(dt);

                ds = tempDs;                
            }

            return ds;
        }
    }
}
