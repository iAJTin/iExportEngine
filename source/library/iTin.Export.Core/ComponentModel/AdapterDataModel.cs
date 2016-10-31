using System.ComponentModel.Composition;

using iTin.Export.Model;

namespace iTin.Export.ComponentModel
{
    /// <summary>
    /// Target data model
    /// </summary>
    [Export]
    public class AdapterDataModel
    {
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public ExportModel Data { get; set; }

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
            if (Data == null)
            {
                return null;
            }

            return Data.Owner;
        }
    }
}
