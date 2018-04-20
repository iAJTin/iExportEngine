
namespace iTin.Export.ComponentModel
{
    using System;
    using System.ComponentModel.Composition;

    /// <summary>
    /// Declares extra metadata to a adapter.
    /// All adapters created by <strong>iTin Export Engine</strong> are based in <a href="http://msdn.microsoft.com/es-es/library/dd460648.aspx">Managed Extensibility Framework <strong>(MEF)</strong></a>.
    /// </summary>
    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class AdapterOptionsAttribute : Attribute, IAdapterOptions
    {
        /// <inheritdoc />
        /// <summary>
        /// Gets or sets a value that identify to creator of adapter.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String" /> that contains the adapter's author.
        /// </value>
        public string Author { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets a value that represents the name of the company that created the adapter.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String" /> that contains the adapter company's.
        /// </value>
        public string Company { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets a value that represents the description of the adapter.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String" /> that contains the adapter's description.
        /// </value>
        public string Description { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets a value that represents the name of the company that created the adapter.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String" /> that contains the adapter's name.
        /// </value>
        public string Name { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets a value that represents the version of the adapter.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.Int32" /> that contains the adapter's version.
        /// </value>
        public int Version { get; set; }
    }
}
