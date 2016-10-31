using System.Threading;
using System.Windows.Forms;

using iTin.Export.Web.Cloud.Clients;

namespace iTin.Export.Web.Cloud.Apis
{
    /// <summary>
    /// Static class that contains the SkyDrive <strong><c>REST API</c></strong>.
    /// </summary>
    static class SkyDriveRestApi
    {
        #region Constants
        /// <summary>
        /// The unique identifier that identifies <c>iTin Export Engine</c> application on SkyDrive.
        /// </summary>
        public const string iTinExportEngineId = "0000000044105F02";

        /// <summary>
        /// <see cref="T:System.String" /> that represent the '<c>wl.skydrive_update</c>' scope.
        /// </summary>
        public const string SkyDriveUpdateScope = "wl.skydrive_update";

        /// <summary>
        /// <see cref="T:System.String" /> that represent the base uri for live.net services.
        /// </summary>
        public const string BaseUri = "https://apis.live.net/v5.0/";

        /// <summary>
        /// <see cref="T:System.String" /> that represent the pre-formatted uri for upload to SkyDrive.
        /// </summary>
        public const string PreFormattedUploadUri = @"{0}{1}/files/{2}?access_token={3}";

        /// <summary>
        /// <see cref="T:System.String" /> that represent the pre-formatted uri for sign-in SkyDrive.
        /// </summary>
        public const string PreFormattedSignInUri = @"https://login.live.com/oauth20_authorize.srf?client_id={0}&redirect_uri=https://login.live.com/oauth20_desktop.srf&response_type=token&scope={1}";
        #endregion

        #region Static Field Members
        private static Form signInDialog;
        #endregion

        #region Public Static Methods

            #region [public] (SkyDriveClient) ClientFrom(AuthenticateMode): Authenticate in skydrive and returns a new client session.
            /// <summary>
            /// Authenticate in skydrive.
            /// </summary>
            /// <param name="mode">Authentication mode.</param>
            /// <returns>
            /// A client session in SkyDrive service.
            /// </returns>
            public static SkyDriveClient ClientFrom(AuthenticateMode mode)
            {
                var authorizedToken = AuthenticateFrom(mode);

                return new SkyDriveClient(iTinExportEngineId, string.Empty, authorizedToken);
            }
            #endregion

        #endregion

        #region Private Static Methods

            #region [private] {static} (string) AuthenticateFrom(AuthenticateMode): Authenticate in SkyDrive.
            /// <summary>
            /// Authenticate in SkyDrive.
            /// </summary>
            /// <param name="mode">Authentication mode.</param>
            /// <returns>
            /// A valid token for a valid session.
            /// </returns>
            private static string AuthenticateFrom(AuthenticateMode mode)
            {
                string token = null;

                switch (mode)
                {
                    case AuthenticateMode.Desktop:
                        var signInDialogThread = new Thread(LaunchSignInDialog);
                        signInDialogThread.SetApartmentState(ApartmentState.STA);
                        signInDialogThread.Start();
                        signInDialogThread.Join();

                        token = SkyDriveSignInDialog.AccessToken;
                        break;

                    case AuthenticateMode.Web:
                        var signInDialog1Thread = new Thread(LaunchSignInDialog);
                        signInDialog1Thread.SetApartmentState(ApartmentState.STA);
                        signInDialog1Thread.Start();
                        signInDialog1Thread.Join();

                        token = SkyDriveSignInDialog.AccessToken;
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
                using (signInDialog = new SkyDriveSignInDialog())
                {
                    signInDialog.Visible = false;
                    signInDialog.ShowDialog();
                }
            }
            #endregion

        #endregion
    }
}
