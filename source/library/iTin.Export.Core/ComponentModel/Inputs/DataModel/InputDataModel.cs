
namespace iTin.Export.ComponentModel.Adapters
{
    using System.ComponentModel.Composition;

    using Model;

    /// <summary>
    /// Target data model
    /// </summary>
    [Export]
    public class InputDataModel
    {
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public ExportModel Model { get; set; }

        /// <summary>
        /// Gets or sets the references.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public ReferencesModel References { get; set; }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public GlobalResourcesModel Resources { get; set; }

        /// <summary>
        /// Gets the root.
        /// </summary>
        /// <returns>
        /// Root node
        /// </returns>
        public ExportsModel GetRoot()
        {
            return Model?.Owner;
        }
    }
}
