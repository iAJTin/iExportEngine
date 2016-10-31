using System.Xml;

namespace iTin.Export.ComponentModel
{
    /// <summary>
    /// Declares a writer which is based in an markup language.
    /// </summary>
    public interface IWriterXml
    {        
        /// <summary>
        /// Gets a writer, based in an markup language.
        /// </summary>
        /// <value>
        /// Reference to writer.
        /// </value>
        XmlWriter Writer { get; }

        /// <summary>
        /// Creates a new writer for markup languages.
        /// </summary>
        void CreateWriter();
    }
}
