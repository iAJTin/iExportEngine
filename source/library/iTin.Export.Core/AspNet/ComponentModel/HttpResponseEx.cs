
namespace iTin.Export.AspNet.ComponentModel
{
    using System;
    using System.IO;
    using System.Web;

    using Helpers;

    /// <summary>
    /// Represents a <see cref="T:System.Web.HttpResponse" /> extended information.
    /// </summary>
    public class HttpResponseEx
    {
        #region public properties

        #region [public] (string) ContentType: Gets or sets the content type
        /// <summary>
        /// Gets or sets the content type.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String" /> that represents the content type.
        /// </value>
        public string ContentType { get; set; }
        #endregion

        #region [public] (string) ContentDisposition: Gets or sets the content-disposition header entry
        /// <summary>
        /// Gets or sets the content-disposition header entry.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String" /> that represents the header type.
        /// </value>
        public string ContentDisposition { get; set; }
        #endregion

        #region [public] (HttpResponse) Response: Gets or sets the http response
        /// <summary>
        /// Gets or sets the http response.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.Web.HttpResponse" /> that represents the http response.
        /// </value>
        public HttpResponse Response { get; set; }
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
            SentinelHelper.ArgumentNull(ContentDisposition);

            string filePath = ContentDisposition.Split(new[] { "filename=" }, StringSplitOptions.None)[1];
            string filename = Path.GetFileName(filePath);

            return filename;
        }
        #endregion

        #endregion
    }
}
