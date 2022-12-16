﻿
using System.Data;

namespace iTin.Export.Inputs
{
    using ComponentModel.Input;
    using Providers;

    /// <inheritdoc />
    /// <summary>
    /// Class than allows you to export an object of type <see cref="T:System.Data.DataSet" />.
    /// </summary>
    [InputOptions(AdapterType = typeof(DataSetProvider))]
    public class DataSetInput : BaseInput
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Inputs.DataSetInput" /> class.
        /// </summary>
        /// <param name="dataSet">A <see cref="T:System.Data.DataSet" /> object than contains the information.</param>
        public DataSetInput(DataSet dataSet) : base(dataSet)
        {
        }
    }
}
