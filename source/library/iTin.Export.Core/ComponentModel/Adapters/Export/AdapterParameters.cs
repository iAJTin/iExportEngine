
namespace iTin.Export.ComponentModel.Adapters
{
    using System.ComponentModel.Composition;

    /// <summary>
    /// Adapter parameters
    /// </summary>
    [Export]
    public class AdapterParameters
    {
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public object Data { get; set; }
    }
}
