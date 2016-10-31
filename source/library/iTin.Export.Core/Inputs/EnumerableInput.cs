using System.Collections.Generic;

using iTin.Export.Adapters.Native;
using iTin.Export.ComponentModel;
using iTin.Export.Helper;

namespace iTin.Export.Inputs
{
    /// <summary>
    /// Class than allows you to export an object of type <see cref="T:System.Data.DataRow" />.
    /// </summary>
    /// <typeparam name="T">Enumeration type</typeparam>
    [InputOptions(AdapterType = typeof(DataSetAdapter))]
    public class EnumerableInput<T> : DataTableInput where T : class
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.EnumerableInput{T}" /> class.
        /// </summary>
        /// <param name="data">A <see cref="T:System.Data.DataRow" /> array object than contains the information.</param>
        /// <param name="name">The name.</param>
        public EnumerableInput(IEnumerable<T> data, string name)
            : base(SentinelHelper.PassThroughNonNull(data.ToDataTable<T>(name)))
        {
        }
     }
}
