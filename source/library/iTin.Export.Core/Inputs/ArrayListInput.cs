
using System.Collections;

namespace iTin.Export.Inputs
{
    using ComponentModel.Input;
    using Helpers;
    using Providers;

    /// <inheritdoc />
    /// <summary>
    /// Class than allows you to export an object of type <see cref="T:System.Collection" />.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [InputOptions(AdapterType = typeof(DataSetProvider))]
    public class ArrayListInput<T> : DataTableInput
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.ArrayListInput" /> class.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="name">The name.</param>
        public ArrayListInput(ArrayList data, string name)
            : base(SentinelHelper.PassThroughNonNull(data.ToDataTable<T>(name)))
        {
        }
    }
}
