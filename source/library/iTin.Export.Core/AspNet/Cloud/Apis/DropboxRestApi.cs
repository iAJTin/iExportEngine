
namespace iTin.Export.AspNet.Cloud.Apis
{
    using System;
    using System.Threading;
    using System.Windows.Forms;

    using Clients;

    /// <summary>
    /// Static class that contains the Dropbox <strong><c>REST API</c></strong>.
    /// </summary>
    static class DropboxRestApi
    {
        #region Constants
        /// <summary>
        /// The key word that identifies <c>iTin Export Engine</c> application on Dropbox.
        /// </summary>
        public const string iTinExportKey = "bcbbcbbkke87qff";

        /// <summary>
        /// The secret word that identifies <c>iTin Export Engine</c> application on Dropbox.
        /// </summary>
        public const string iTinExportSecret = "synt11d332mjphu";

        /// <summary>
        /// <see cref="T:System.String" /> that represent the base uri for Dropbox services.
        /// </summary>
        public const string BaseUri = "https://api.dropbox.com/" + ApiVersion + "/";

        /// <summary>
        /// <see cref="T:System.String" /> that represent the Authorize base uri for Dropbox services.
        /// </summary>
        public const string AuthorizeBaseUri = "https://www.dropbox.com/" + ApiVersion + "/";

        /// <summary>
        /// <see cref="T:System.String" /> that represent the Dropbox API Content.
        /// </summary>
        public const string ApiContentServer = "https://api-content.dropbox.com/" + ApiVersion + "/";

        /// <summary>
        /// Default callback uri.
        /// </summary>
        public const string DefaultDropboxCallBackUri = "http://www.google.com";

        /// <summary>
        /// <see cref="T:System.String" /> that contains Dropbox API version.
        /// </summary>
        private const string ApiVersion = "1";
        #endregion

        #region Static Field Members
        private static Form signInDialog;
        #endregion

        #region Public Static Methods

            #region [public] (SkyDriveClient) ClientFrom(AuthenticateMode): Authenticate in Dropbox and returns a new client session.
            /// <summary>
            /// Authenticate in Dropbox.
            /// </summary>
            /// <param name="mode">Authentication mode.</param>
            /// <returns>
            /// A client session in Dropbox service.
            /// </returns>
            public static DropboxClient ClientFrom(AuthenticateMode mode)
            {
                var authorizedToken = AuthenticateFrom(mode);

                return new DropboxClient(iTinExportKey, iTinExportSecret, authorizedToken);
            }
            #endregion

        #endregion

        #region Private Static Methods

            #region [private] {static} (string) AuthenticateFrom(AuthenticateMode): Authenticate in Dropbox.
            /// <summary>
            /// Authenticate in Dropbox.
            /// </summary>
            /// <param name="mode">Authentication mode.</param>
            /// <returns>
            /// A valid token for a valid session.
            /// </returns>
            private static OAuthToken AuthenticateFrom(AuthenticateMode mode)
            {
                OAuthToken token = null;

                var oauth = new OAuth();
                switch (mode)
                {
                    case AuthenticateMode.Desktop:
                        var signInDialogThread = new Thread(LaunchSignInDialog);
                        signInDialogThread.SetApartmentState(ApartmentState.STA);
                        signInDialogThread.Start();
                        signInDialogThread.Join();

                        token = oauth.GetAccessToken(new Uri(BaseUri), iTinExportKey, iTinExportSecret, DropboxSignInDialog.RequestToken);
                        break;

                    case AuthenticateMode.Web:
                        var signInDialog1Thread = new Thread(LaunchSignInDialog);
                        signInDialog1Thread.SetApartmentState(ApartmentState.STA);
                        signInDialog1Thread.Start();
                        signInDialog1Thread.Join();

                        token = oauth.GetAccessToken(new Uri(BaseUri), iTinExportKey, iTinExportSecret, DropboxSignInDialog.RequestToken);
                        break;
                }

                return token;
            }
            #endregion

            #region [private] {static} (void) LaunchSignInDialog(): Launches the sign-in dialog.
            /// <summary>
            /// Launches the sign-in dialog.
            /// </summary>
            private static void LaunchSignInDialog()
            {
                using (signInDialog = new DropboxSignInDialog())
                {
                    signInDialog.Visible = false;
                    signInDialog.ShowDialog();
                }
            }
            #endregion

        #endregion
    }
}
