namespace iTin.Export.ComponentModel
{
    /// <summary>
    /// A Specialization of <see cref="BaseWriter" /> Class, than implements interface <see cref="T:iTin.Export.ComponentModel.IWriterDirect" />.
    /// Which acts as a base class for writers based or not based on markup languages​​, but the writer is based in a 3rd party library that controls lifecycle of file, such as <a href="http://epplus.codeplex.com/">EPPlus library</a>.
    /// </summary>
    public abstract class BaseWriterDirect : BaseWriter, IWriterDirect
    {
        /// <summary>
        /// Gets a value than identifies the type of writer.
        /// </summary>
        /// <value>
        /// Always returns ​the <see cref="iTin.Export.ComponentModel.KnownWriterIdentifier.WriterDirect" /> value.
        /// </value>
        public override KnownWriterIdentifier WriterIdentifier
        {
            get
            {
                return KnownWriterIdentifier.WriterDirect;
            }
        }
    }
}
