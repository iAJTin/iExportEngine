
namespace iTin.Export.ComponentModel.Writer
{
    /// <summary>
    /// A Specialization of <see cref="T:iTin.Export.ComponentModel.Writer.BaseWriter" /> Class, than implements interface <see cref="T:iTin.Export.ComponentModel.Writer.IWriterDirect" />.
    /// Which acts as a base class for writers based or not based on markup languages​​, but the writer is based in a 3rd party library that controls lifecycle of file, such as <a href="http://epplus.codeplex.com/">EPPlus library</a>.
    /// </summary>
    public abstract class BaseWriterDirect : BaseWriter, IWriterDirect
    {
        /// <inheritdoc />
        /// <summary>
        /// Gets a value than identifies the type of writer.
        /// </summary>
        /// <value>
        /// Always returns ​the <see cref="F:iTin.Export.ComponentModel.Writer.KnownWriterIdentifier.WriterDirect" /> value.
        /// </value>
        public override KnownWriterIdentifier WriterIdentifier => KnownWriterIdentifier.WriterDirect;
    }
}
