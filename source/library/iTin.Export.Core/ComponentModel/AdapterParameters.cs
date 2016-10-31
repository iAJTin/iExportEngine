using System.ComponentModel.Composition;

namespace iTin.Export.ComponentModel
{
    /// <summary>
    /// Target parameters
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
