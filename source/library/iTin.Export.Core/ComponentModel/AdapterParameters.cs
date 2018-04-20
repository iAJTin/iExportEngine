
namespace iTin.Export.ComponentModel
{
    using System.ComponentModel.Composition;

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
