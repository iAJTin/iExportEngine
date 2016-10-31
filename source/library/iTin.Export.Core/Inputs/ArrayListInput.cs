using System.Collections;

using iTin.Export.Adapters.Native;
using iTin.Export.ComponentModel;
using iTin.Export.Helper;

namespace iTin.Export.Inputs
{
    /// <summary>
    /// Class than allows you to export an object of type <see cref="T:System.Collection" />.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [InputOptions(AdapterType = typeof(DataSetAdapter))]
    public class ArrayListInput<T> : DataTableInput
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.DataRowInput" /> class.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="name">The name.</param>
        public ArrayListInput(ArrayList data, string name)
            : base(SentinelHelper.PassThroughNonNull(data.ToDataTable<T>(name)))
        {
        }
    }
}
