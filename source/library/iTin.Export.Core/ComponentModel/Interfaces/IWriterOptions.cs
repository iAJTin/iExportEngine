
namespace iTin.Export.ComponentModel
{
    /// <summary>
    /// Attribute that allows you to add extra metadata to a writer.
    /// </summary>
    public interface IWriterOptions
    {
        /// <summary>
        /// Gets a value than identify to creator of writer.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String" /> than contains the writer's author.
        /// </value>
        string Author { get; }

        /// <summary>
        /// Gets a value than represents the name of the company that created the writer.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String" /> than contains the writer company's.
        /// </value>
        string Company { get; }

        /// <summary>
        /// Gets a value than represents the description of the writer.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String" /> than contains the writer's description.
        /// </value>
        string Description { get; }

        /// <summary>
        /// Gets a value than represents extension output file created by writer.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String" /> than contains the writer's output file extension without dot.
        /// </value>
        string Extension { get; }

        /// <summary>
        /// Gets a value than represents the name of the company that created the writer.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String" /> than contains the writer's name.
        /// </value>
        string Name { get; }

        /// <summary>
        /// Gets a value than represents the version of the writer.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.Int32" /> than contains the writer's version.
        /// </value>
        int Version { get; }
    }
}
