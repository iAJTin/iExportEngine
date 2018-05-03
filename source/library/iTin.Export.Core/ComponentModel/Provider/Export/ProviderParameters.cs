
namespace iTin.Export.ComponentModel.Provider
{
    using System.ComponentModel.Composition;

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
