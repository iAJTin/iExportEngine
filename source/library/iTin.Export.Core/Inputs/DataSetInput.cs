using System.Data;

using iTin.Export.Adapters.Native;
using iTin.Export.ComponentModel;

namespace iTin.Export.Inputs
{
    /// <summary>
    /// Class than allows you to export an object of type <see cref="T:System.Data.DataSet" />.
    /// </summary>
    [InputOptions(AdapterType = typeof(DataSetAdapter))]
    public class DataSetInput : BaseInput
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.DataSetInput" /> class.
        /// </summary>
        /// <param name="dataSet">A <see cref="T:System.Data.DataSet" /> object than contains the information.</param>
        public DataSetInput(DataSet dataSet) : base(dataSet)
        {
        }
    }
}
