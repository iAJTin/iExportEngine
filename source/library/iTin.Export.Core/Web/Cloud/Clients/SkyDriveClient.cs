using System;
using System.Globalization;
using System.IO;
using System.Net;

using iTin.Export.Web.Cloud.Apis;

namespace iTin.Export.Web.Cloud.Clients
{
    /// <summary>
    /// Represents a basic client for access to cloud service on Microsoft SkyDrive.
    /// </summary>
    public class SkyDriveClient
    {
        #region Private Field Members
        private readonly string siteUrl;
        private readonly string clientId;
        private readonly string token;
        #endregion

        #region Constructor/s

            #region [public] SkyDriveClient(string, string, string): Initializes a new instance of the class.
            /// <summary>
            /// Initializes a new instance of the <see cref="SkyDriveClient" /> class.
            /// </summary>
            /// <param name="clientId">The client unique identifier.</param>
            /// <param name="site">The site URL.</param>
            /// <param name="token">The token.</param>
            public SkyDriveClient(string clientId, string site, string token)
            {
                this.token = token;
                siteUrl = site;
                this.clientId = clientId;
            }
            #endregion

        #endregion

        #region Public Methods

            #region [public] (bool) UploadFile(string, string): Uploads specified file to folder.
            /// <summary>
            /// Uploads specified file to folder.
            /// </summary>
            /// <param name="folderId">The folder unique identifier.</param>
            /// <param name="filePath">The file path.</param>
            /// <returns>
            /// <strong>true</strong> if file is upload; Otherwise, <strong>false</strong>.
            /// </returns>
            public bool UploadFile(string folderId, string filePath)
            {
                if (string.IsNullOrEmpty(this.token))
                {
                    return false;
                }

                var uploaded = false;

                try
                {
                    var uploadUri = string.Format(CultureInfo.InvariantCulture, SkyDriveRestApi.PreFormattedUploadUri, SkyDriveRestApi.BaseUri, folderId, Path.GetFileName(filePath), this.token);
                
                    var fileBytes = File.ReadAllBytes(filePath);
                    var request = (HttpWebRequest)WebRequest.Create(new Uri(uploadUri));
                    request.Method = "PUT";
                    request.ContentLength = fileBytes.Length;

                    using (var dataStream = request.GetRequestStream())
                    {
                        dataStream.Write(fileBytes, 0, fileBytes.Length);
                    }

                    var status = ((HttpWebResponse)request.GetResponse()).StatusDescription;
                    if (status.ToUpperInvariant().Equals("CREATED"))
                    {
                        uploaded = true;
                    }

                    return uploaded;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            #endregion

        #endregion
    }
}
