
namespace iTin.Export.AspNet.Cloud.Clients
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Net;
    using System.Text;
    using System.Web;

    using Apis;

    /// <summary>
    /// Represents a basic client for access to cloud service on Dropbox.
    /// </summary>
    public class DropboxClient
    {
        #region Private Field Members
        private readonly string key;
        private readonly string secret;
        private readonly OAuthToken access;
        #endregion

        #region Constructor/s

            #region [public] DropboxClient(string, string, string): Initializes a new instance of the class.
            /// <summary>
            /// Initializes a new instance of the <see cref="DropboxClient" /> class.
            /// </summary>
            /// <param name="key">Key word.</param>
            /// <param name="secret">Secret word.</param>
            /// <param name="access">Access token.</param>
            public DropboxClient(string key, string secret, OAuthToken access)
            {
                this.key = key;
                this.secret = secret;
                this.access = access;
            }
            #endregion

        #endregion

        #region Public Methods

            #region [public] (bool) UploadFile(string, string, string): Uploads specified file to Dropbox folder.
            /// <summary>
            /// Uploads specified file to Dropbox folder.
            /// </summary>
            /// <param name="root">The root.</param>
            /// <param name="path">The path.</param>
            /// <param name="file">The file.</param>
            /// <returns>
            /// <strong>true</strong> if uploads the file; Otherwise, <strong>false</strong>.
            /// </returns>
            public bool UploadFile(string root, string path, string file)
            {
                if (access == null)
                {
                    return false;
                }

                var upload = false;
                var queryString = string.Format(CultureInfo.InvariantCulture, "files_put/{0}/{1}", root, UpperCaseUrlEncode(path));
                var uri = new Uri(new Uri(DropboxRestApi.ApiContentServer), new Uri(queryString, UriKind.Relative));

                var oauth = new OAuth();
                var requestUri = oauth.SignRequest(uri, key, secret, access, "PUT");

                try
                {
                    var request = (HttpWebRequest)WebRequest.Create(requestUri);
                    request.Method = WebRequestMethods.Http.Put;
                    request.KeepAlive = true;

                    var fileBytes = File.ReadAllBytes(file);
                    using (var dataStream = request.GetRequestStream())
                    {
                        dataStream.Write(fileBytes, 0, fileBytes.Length);
                    }

                    var status = ((HttpWebResponse)request.GetResponse()).StatusDescription;
                    if (status.ToUpperInvariant().Equals("OK"))
                    {
                        upload = true;
                    }
                }
                catch
                {
                    upload = false;
                }

                return upload;
            }
            #endregion

        #endregion

        #region Private Static Methods

            #region [private] {static} (string) UpperCaseUrlEncode(string): Uppers the case URL encode.
            /// <summary>
            /// Uppers the case URL encode.
            /// </summary>
            /// <param name="str">The arguments.</param>
            /// <returns>
            /// Encoded string.
            /// </returns>
            private static string UpperCaseUrlEncode(string str)
            {
                var temp = HttpUtility.UrlEncode(str).ToCharArray();
                for (var i = 0; i < temp.Length - 2; i++)
                {
                    if (temp[i] == '%')
                    {
                        temp[i + 1] = char.ToUpper(temp[i + 1], CultureInfo.InvariantCulture);
                        temp[i + 2] = char.ToUpper(temp[i + 2], CultureInfo.InvariantCulture);
                    }
                }

                var data = new StringBuilder(new string(temp));
                var values = new Dictionary<string, string>
                                 {
                                     { "+", "%20" },
                                     { "(", "%28" }, 
                                     { ")", "%29" }
                                 };
                foreach (var character in values.Keys)
                {
                    data.Replace(character, values[character]);
                }

                return data.ToString();
            }
            #endregion

        #endregion
    }
}
