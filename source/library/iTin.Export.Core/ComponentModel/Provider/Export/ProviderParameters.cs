
using System.ComponentModel.Composition;

namespace iTin.Export.ComponentModel.Provider
{
    /// <summary>
    /// Provider parameters
    /// </summary>
    [Export]
    public class ProviderParameters
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
