
namespace iTin.Export.AspNet
{
    using System.IO;
    using System.Web;

    using Helpers;
    using ComponentModel;

    /// <summary>
    /// Static class than contains extension methods for objects of type <see cref="T:System.IO.Stream" />.
    /// </summary> 
    public static class StreamExtensions
    {
        #region public static methods

        /// <summary>
        /// Downloads the specified data with the name specified in <paramref name="fileName"/>.
        /// </summary>
        /// <param name="target">Data to download.</param>
        /// <param name="fileName">Name of the file to download.</param>
        /// <param name="response">The response to use.</param>
        public static void Download(this Stream target, string fileName, HttpResponse response)
        {
            SentinelHelper.ArgumentNull(target);
            SentinelHelper.ArgumentNull(fileName);
            //SentinelHelper.IsFalse(FileHelper.IsValidFileName(fileName), "Filename does not have a valid name");

            HttpResponseEx info = new HttpResponseEx
            {
                Response = response,
                ContentType = HttpResponseEx.GetMimeMapping(Path.GetExtension(fileName).Replace(".", string.Empty)),
                ContentDisposition = $"attachment; filename={fileName}"
            };

            target.DownloadImpl(info);
        }

        #endregion

        #region private static methods

        /// <summary>
        /// Downloads the specified file in <paramref name="info"/>.
        /// </summary>
        /// <param name="target">The target.</param>
        /// <param name="info">The extended response information.</param>
        private static void DownloadImpl(this Stream target, HttpResponseEx info)
        {
            target.Position = 0;

            info.Response.Clear();
            info.Response.ContentType = info.ContentType;
            info.Response.AddHeader("content-disposition", info.ContentDisposition);
            info.Response.BinaryWrite(target.AsByteArray());
            info.Response.Flush();
            info.Response.End();
        }

        #endregion
    }
}
