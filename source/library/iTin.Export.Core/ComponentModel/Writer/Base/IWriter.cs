
namespace iTin.Export.ComponentModel.Writer
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    using AspNet.ComponentModel;
    using Provider;

    /// <summary>
    /// Declares a generic writer.
    /// </summary>
    public interface IWriter : IDisposable
    {
        /// <summary> 
        /// Gets a value indicating whether this writer generates a transformation file to be processed later.
        /// </summary>
        /// <value>
        /// <strong>true</strong> if generates transform file; otherwise, <strong>false</strong>.
        /// </value>
        bool IsTransformationFile { get; }

        /// <summary>
        /// Gets or sets a reference to provider to export.
        /// </summary>
        /// <value>
        /// Reference to <see cref="T:iTin.Export.ComponentModel.Provider.IProvider" /> to export.
        /// </value>
        IProvider Provider { get; set; }

        /// <summary>
        /// Gets a reference to an object <see cref="T:iTin.Export.AspNet.ComponentModel.HttpResponseEx" /> containing the <strong>MIME</strong> type of the output stream and response header for a <strong>ASP.NET</strong> operation.
        /// </summary>
        /// <value>
        /// A <see cref="T:iTin.Export.AspNet.ComponentModel.HttpResponseEx" /> containing the <strong>MIME</strong> type of the output stream and response header for a <strong>ASP.NET</strong> operation.
        /// </value>
        HttpResponseEx ResponseEx { get; }

        /// <summary>
        /// Gets a reference to writer's stream.
        /// </summary>
        /// <value>
        /// Writer's stream reference.
        /// </value>
        Stream Stream { get; }

        /// <summary>
        /// Gets the transform file extension.
        /// </summary>
        /// <value>
        /// The transform file extension.
        /// </value>
        string TransformFileExtension { get; }
   
        /// <summary>
        /// Gets a value than identifies the type of writer.
        /// </summary>
        /// <value>
        /// One of the <see cref="T:iTin.Export.ComponentModel.Writer.KnownWriterIdentifier" /> values which identifies the writer type.
        /// </value>
        KnownWriterIdentifier WriterIdentifier { get; }

        /// <summary>
        /// Gets a reference that contains extended information of this writer.
        /// </summary>
        /// <value>
        /// A <see cref="T:iTin.Export.ComponentModel.Writer.WriterOptionsMetadata"/> that contains the extended information about this writer.
        /// </value>
        WriterOptionsMetadata WriterMetadata { get; }

        /// <summary>
        /// Generates output in the format supported by each specialized class.
        /// </summary>
        /// <param name="settings">Export settings.</param>
        void Generate(ExportSettings settings);

        /// <summary>
        /// Returns the writer result file as a enumeration of byte array
        /// </summary>
        /// <returns>
        /// An enumeration of array of bytes than contains the writer result file content.
        /// </returns>
        IEnumerable<byte[]> GetAsByteArrayEnumerable();
    }
}
