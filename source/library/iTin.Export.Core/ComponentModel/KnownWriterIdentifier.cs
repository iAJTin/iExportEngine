
namespace iTin.Export.ComponentModel
{
    /// <summary>
    /// Known writer types 
    /// </summary>
    public enum KnownWriterIdentifier
    {
        /// <summary>
        /// Direct writer, for more information please see <see cref="T:iTin.Export.ComponentModel.BaseWriterDirect" />.       
        /// </summary>
        WriterDirect,

        /// <summary>
        /// Stream writer, for more information please see <see cref="T:iTin.Export.ComponentModel.BaseWriterStream" />.       
        /// </summary>
        WriterStream,

        /// <summary>
        /// XML writer, for more information please see <see cref="T:iTin.Export.ComponentModel.BaseWriterXml" />.       
        /// </summary>
        WriterXml
    }
}
