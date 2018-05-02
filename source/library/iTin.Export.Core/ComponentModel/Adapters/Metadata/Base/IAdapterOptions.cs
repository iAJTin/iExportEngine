
namespace iTin.Export.ComponentModel.Adapters
{
    /// <summary>
    /// Attribute that allows you to add extra metadata to a adapter.
    /// </summary>
    public interface IAdapterOptions
    {
        /// <summary>
        /// Gets a value than identify to creator of adapter.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String" /> than contains the adapter's author.
        /// </value>
        string Author { get; }

        /// <summary>
        /// Gets a value than represents the name of the company that created the adapter.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String" /> than contains the adapter company's.
        /// </value>
        string Company { get; }

        /// <summary>
        /// Gets a value than represents the description of the adapter.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String" /> than contains the adapter's description.
        /// </value>
        string Description { get; }

        /// <summary>
        /// Gets a value than represents the name of the company that created the adapter.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String" /> than contains the adapter's name.
        /// </value>
        string Name { get; }

        /// <summary>
        /// Gets a value than represents the version of the adapter.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.Int32" /> than contains the adapter's version.
        /// </value>
        int Version { get; }
    }
}
