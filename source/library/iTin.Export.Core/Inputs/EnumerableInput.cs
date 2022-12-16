
using System.Collections.Generic;

namespace iTin.Export.Inputs
{
    using ComponentModel.Input;
    using Helpers;
    using Providers;

    /// <inheritdoc />
    /// <summary>
    /// Class than allows you to export an object of type <see cref="T:System.Data.DataRow" />.
    /// </summary>
    /// <typeparam name="T">Enumeration type</typeparam>
    [InputOptions(AdapterType = typeof(DataSetProvider))]
    public class EnumerableInput<T> : DataTableInput where T : class
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Inputs.EnumerableInput{T}" /> class.
        /// </summary>
        /// <param name="data">A <see cref="T:System.Data.DataRow" /> array object than contains the information.</param>
        /// <param name="name">The name.</param>
        public EnumerableInput(IEnumerable<T> data, string name)
            : base(SentinelHelper.PassThroughNonNull(data.ToDataTable<T>(name)))
        {
        }
     }
}
