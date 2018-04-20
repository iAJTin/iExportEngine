
namespace iTin.Export.ComponentModel
{
    using System.IO;

    /// <summary>
    /// Declares a writer which is non-based in an markup language.
    /// </summary>
    public interface IWriterStream
    {
        /// <summary>
        /// Gets a reference to non based writer for markup languages​​ 
        /// </summary>
        /// <value>
        /// Reference to writer.
        /// </value>
        Stream Stream { get; }

        /// <summary>
        /// Creates a new non based writer for markup languages.
        /// </summary>
        void CreateStream();
    }
}
