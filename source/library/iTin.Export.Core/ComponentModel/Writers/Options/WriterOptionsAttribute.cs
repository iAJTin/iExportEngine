
namespace iTin.Export.ComponentModel.Writers
{
    using System;
    using System.ComponentModel.Composition;

    /// <summary>
    /// Declares extra metadata to a writer.
    /// All writers created by <strong>iTin Export Engine</strong> are based in <a href="http://msdn.microsoft.com/es-es/library/dd460648.aspx">Managed Extensibility Framework <strong>(MEF)</strong></a>.
    /// </summary>
    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class WriterOptionsAttribute : Attribute, IWriterOptions
    {
        /// <inheritdoc />
        /// <summary>
        /// Gets or sets a value that identify to creator of writer.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String" /> that contains the writer's author.
        /// </value>
        public string Author { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets a value that represents the name of the company that created the writer.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String" /> that contains the writer company's.
        /// </value>
        public string Company { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets a value that represents the description of the writer.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String" /> that contains the writer's description.
        /// </value>
        public string Description { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets a value that represents extension output file created by writer.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String" /> that contains the writer's output file extension without dot.
        /// </value>
        public string Extension { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets a value that represents the name of the company that created the writer.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String" /> that contains the writer's name.
        /// </value>
        public string Name { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets a value that represents the version of the writer.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.Int32" /> that contains the writer's version.
        /// </value>
        public int Version { get; set; }
    }
}
