
namespace iTin.Export.ComponentModel.Provider
{
    /// <summary>
    /// Attribute that allows you to add extra metadata to a provider.
    /// </summary>
    public interface IProviderOptions
    {
        /// <summary>
        /// Gets a value than identify to creator of adapter.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String" /> than contains the provider's author.
        /// </value>
        string Author { get; }

        /// <summary>
        /// Gets a value than represents the name of the company that created the provider.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String" /> than contains the provider company's.
        /// </value>
        string Company { get; }

        /// <summary>
        /// Gets a value than represents the description of the provider.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String" /> than contains the provider's description.
        /// </value>
        string Description { get; }

        /// <summary>
        /// Gets a value than represents the name of the company that created the provider.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String" /> than contains the provider's name.
        /// </value>
        string Name { get; }

        /// <summary>
        /// Gets a value than represents the version of the provider.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.Int32" /> than contains the provider's version.
        /// </value>
        int Version { get; }
    }
}
