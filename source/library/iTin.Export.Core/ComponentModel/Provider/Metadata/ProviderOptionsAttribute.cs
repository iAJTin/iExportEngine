
namespace iTin.Export.ComponentModel.Provider
{
    using System;
    using System.ComponentModel.Composition;

    /// <summary>
    /// Declares extra metadata to a provider.
    /// All providers created by <strong>iTin Export Engine</strong> are based in <a href="http://msdn.microsoft.com/es-es/library/dd460648.aspx">Managed Extensibility Framework <strong>(MEF)</strong></a>.
    /// </summary>
    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class ProviderOptionsAttribute : Attribute, IProviderOptions
    {
        /// <inheritdoc />
        /// <summary>
        /// Gets or sets a value that identify to creator of provider.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String" /> that contains the provider's author.
        /// </value>
        public string Author { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets a value that represents the name of the company that created the provider.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String" /> that contains the provider company's.
        /// </value>
        public string Company { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets a value that represents the description of the provider.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String" /> that contains the provider's description.
        /// </value>
        public string Description { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets a value that represents the name of the company that created the provider.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String" /> that contains the provider's name.
        /// </value>
        public string Name { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets a value that represents the version of the provider.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.Int32" /> that contains the provider's version.
        /// </value>
        public int Version { get; set; }
    }
}
