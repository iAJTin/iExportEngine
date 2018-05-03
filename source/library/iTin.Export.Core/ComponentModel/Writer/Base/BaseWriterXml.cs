
namespace iTin.Export.ComponentModel.Writer
{
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using System.Xml;

    using Model;

    /// <summary>
    /// A Specialization of <see cref="T:iTin.Export.ComponentModel.Writer.BaseWriter" /> Class, than implements interface <see cref="T:iTin.Export.ComponentModel.Writer.IWriterXml" />.
    /// Which acts as the base class for future writers-based in markup languages​​.
    /// </summary>
    public abstract class BaseWriterXml : BaseWriter, IWriterXml
    {
        #region public override properties

        #region [public] {override} (KnownWriterIdentifier) WriterIdentifier: Gets a value than identifies the type of writer
        /// <inheritdoc />
        /// <summary>
        /// Gets a value than identifies the type of writer.
        /// </summary>
        /// <value>
        /// Always returns ​the <see cref="F:iTin.Export.ComponentModel.Writer.KnownWriterIdentifier.WriterXml" /> value.
        /// </value>
        public override KnownWriterIdentifier WriterIdentifier => KnownWriterIdentifier.WriterXml;
        #endregion

        #endregion

        #region public properties

        #region [public] (XmlWriter) Writer: Gets a reference to based writer for markup languages
        /// <inheritdoc />
        /// <summary>
        /// Gets a reference to based writer for markup languages​​.
        /// </summary>
        /// <value>
        /// Reference to writer.
        /// </value>
        public XmlWriter Writer { get; private set; }
        #endregion

        #endregion

        #region public methods

        #region [public] (void) CreateWriter(): Creates a new writer for markup languages
        /// <inheritdoc />
        /// <summary>
        /// Creates a new writer for markup languages.
        /// </summary>
        public void CreateWriter()
        {
            Stream = new MemoryStream();
            CreateWriter(Stream);
        }
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (IEnumerable<byte[]>) GetAsByteArrayEnumerable(): Returns the result file as a enumeration of byte array
        /// <inheritdoc />
        /// <summary>
        /// Returns the writer result file as a enumeration of byte array
        /// </summary>
        /// <returns>
        /// An enumeration of array of bytes than contains the writer result file content.
        /// </returns>
        public override IEnumerable<byte[]> GetAsByteArrayEnumerable()
        {
            Result.Add(Stream.AsByteArray());

            return Result;
        }
        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (void) ReleaseManagedResources(): Releasing managed resources
        /// <inheritdoc />
        /// <summary>
        /// Releasing managed resources.
        /// </summary>
        protected override void ReleaseManagedResources()
        {
            base.ReleaseManagedResources();

            Writer?.Close();
        }
        #endregion

    #endregion

        #region private methods

        #region [private] (void) CreateWriter(stream): Creates a new writer for markup languages with specified stream
        /// <summary>
        /// Creates a new writer for markup languages with specified stream.
        /// </summary>
        /// <param name="stream">input stream.</param>
        private void CreateWriter(Stream stream)
        {
            XmlTextWriter tempWriter = null;
            try
            {
                tempWriter = new XmlTextWriter(stream, Encoding.UTF8);

                YesNo indented;
                var behaviors = Provider.Input.Model.Table.Exporter.Behaviors;
                var transformFileBehavior = behaviors.Get<TransformFileBehaviorModel>();
                if (transformFileBehavior == null)
                {
                    var transformBehavior = new TransformFileBehaviorModel();
                    indented = transformBehavior.Indented;
                }
                else
                {
                    indented = transformFileBehavior.Indented;
                }
            
                if (indented == YesNo.Yes)
                {
                    tempWriter.Formatting = Formatting.Indented;
                }

                Writer = tempWriter;
                tempWriter = null;
            }
            finally
            {
                tempWriter?.Close();
            }
        }
        #endregion

        #endregion
    }
}
