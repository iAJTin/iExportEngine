
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace iTin.Export.ComponentModel.Writer
{
    using Model;

    /// <summary>
    /// A Specialization of <see cref="T:iTin.Export.ComponentModel.Writer.BaseWriter" /> Class, than implements interface <see cref="T:iTin.Export.ComponentModel.Writer.IWriterXml" />.
    /// Which acts as the base class for future writers-based in markup languages​​.
    /// </summary>
    public abstract class BaseWriterXml : BaseWriter, IWriterXml
    {
        #region public override properties

        /// <inheritdoc />
        /// <summary>
        /// Gets a value than identifies the type of writer.
        /// </summary>
        /// <value>
        /// Always returns ​the <see cref="F:iTin.Export.ComponentModel.Writer.KnownWriterIdentifier.WriterXml" /> value.
        /// </value>
        public override KnownWriterIdentifier WriterIdentifier => KnownWriterIdentifier.WriterXml;

        #endregion

        #region public properties

        /// <inheritdoc />
        /// <summary>
        /// Gets a reference to based writer for markup languages​​.
        /// </summary>
        /// <value>
        /// Reference to writer.
        /// </value>
        public XmlWriter Writer { get; private set; }

        #endregion

        #region public methods

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

        #region public override methods

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

        #region protected properties

        /// <summary>
        /// Gets a reference to service render.
        /// </summary>
        /// <value>The service.</value>
        protected ModelService Service => ModelService.Instance;

        #endregion

        #region protected override methods

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

        #region private methods

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
    }
}
