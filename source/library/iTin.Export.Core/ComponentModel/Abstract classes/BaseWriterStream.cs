using System.IO;

namespace iTin.Export.ComponentModel
{
    /// <summary>
    /// A Specialization of <see cref="T:iTin.Export.ComponentModel.BaseWriter"/> Class, than implements interface <see cref="T:iTin.Export.ComponentModel.IWriterStream" />.
    /// Which acts as a base class for writers not based on markup languages​​, such as a writer for a binary file format.
    /// </summary>
    public abstract class BaseWriterStream : BaseWriter, IWriterStream
    {
        #region Public Override Properties

            #region [public] {override} (KnownWriterIdentifier) WriterIdentifier: Gets a value than identifies the type of writer.
            /// <summary>
            /// Gets a value than identifies the type of writer.
            /// </summary>
            /// <value>
            /// Always returns ​the <see cref="iTin.Export.ComponentModel.KnownWriterIdentifier.WriterStream" /> value.
            /// </value>
            public override KnownWriterIdentifier WriterIdentifier
            {
                get { return KnownWriterIdentifier.WriterStream; }
            }
            #endregion
       
        #endregion

        #region Public Methods

            #region [public] (void) CreateStream(): Creates a new non based writer for markup languages.
            /// <summary>
            /// Creates a new non based writer for markup languages.
            /// </summary>
            public void CreateStream()
            {
                Stream = new MemoryStream();
            }
            #endregion

        #endregion
    }
}
