
namespace iTin.Export.Web
{
    using System;
    using System.IO;

    using Helper;

    /// <summary>
    /// Represents a <see cref="T:System.Web.HttpResponse" /> settings.
    /// </summary>
    public class HttpResponseInfo
    {
        #region public properties

        #region [public] (string) ContentType: Gets or sets the content type
        /// <summary>
        /// Gets or sets the content type.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String" /> than represent the content type.
        /// </value>
        public string ContentType { get; set; }
        #endregion

        #region [public] (string) Header: Gets or sets the header type
        /// <summary>
        /// Gets or sets the header type.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String" /> than represent the header type.
        /// </value>
        public string Header { get; set; }
        #endregion

        #endregion

        #region public static methods

        #region [public] {static} (string) GetMimeMapping(string): Gets the MIME mapping for a file extension
        /// <summary>
        /// Gets the <strong>MIME</strong> mapping for a file extension.
        /// </summary>
        /// <param name="extension">File extension.</param>
        /// <returns>
        /// A <see cref="T:System.String" /> that represents the <strong>MIME</strong> mapping.
        /// </returns>
        public static string GetMimeMapping(string extension)
        {
            return MimeMapping.GetMimeMapping(extension);
        }
        #endregion

        #endregion

        #region public methods

        #region [public] (string) ExtractFileName(): Gets the output file name from header
        /// <summary>
        /// Gets the output file name from header.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String" /> that represents the output file name.
        /// </returns>>
        public string ExtractFileName()
        {
            SentinelHelper.ArgumentNull(Header);

            var filePath = Header.Split(new[] { "filename=" }, StringSplitOptions.None)[1];
            var filename = Path.GetFileName(filePath);

            return filename;
        }
        #endregion

        #endregion
    }
}
