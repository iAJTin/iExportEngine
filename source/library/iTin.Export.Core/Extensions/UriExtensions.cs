
namespace iTin.Export
{
    using System;
    using System.IO;
    using System.Xml.Xsl;

    using Helper;

    /// <summary>
    /// Static class than contains extension methods for objects of type <see cref="System.Uri" />.
    /// </summary>
    static class UriExtensions
    {
        /// <summary>
        /// Transforms the <strong>XML</strong> input information in another xml defined in the configuration.
        /// </summary>
        /// <param name="inputUri">Contains information to transform.</param>
        /// <param name="settings">Configuration data export.</param>
        /// <exception cref="T:System.IO.FileNotFoundException">Occurs if not found file path.</exception>
        public static void Transform(this Uri inputUri, ExportSettings settings)
        {
            SentinelHelper.ArgumentNull(inputUri);
            SentinelHelper.ArgumentNull(settings);
            SentinelHelper.ArgumentNull(settings.OutputFile, Resources.ErrorMessage.PathNotNull);
            SentinelHelper.ArgumentNull(settings.TransformFile, Resources.ErrorMessage.PathNotNull);

            var input = inputUri.OriginalString;
            var output = settings.OutputFile.OriginalString;
            var xslt = settings.TransformFile.OriginalString;

            var existInput = File.Exists(input);
            if (!existInput)
            {
                throw new FileNotFoundException(Resources.ErrorMessage.InputFileNotFound);
            }

            var existXslt = File.Exists(xslt);
            if (!existXslt)
            {
                throw new FileNotFoundException(Resources.ErrorMessage.TransformFileNotFound);
            }

            var transform = new XslCompiledTransform();
            transform.Load(xslt);
            transform.Transform(input, output);
        }
    }
}
