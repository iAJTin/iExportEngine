
namespace iTin.Export.AspNet.Cloud.Clients
{
    using System;
    using System.Drawing;
    using System.Globalization;
    using System.Windows.Forms;

    using Apis;

    /// <summary>
    /// Represents the SkyDrive Sign In dialog.
    /// </summary>
    partial class SkyDriveSignInDialog : Form
    {
        #region Constructor/s

            #region [public] SignInDialog(): Initializes a new instance of the class.
            /// <summary>
            /// Initializes a new instance of the <see cref="SkyDriveSignInDialog" /> class.
            /// </summary>
            public SkyDriveSignInDialog()
            {
                this.InitializeComponent();
                this.browser.DocumentCompleted += this.BrowserDocumentCompleted;
                this.browser.Navigate(string.Format(CultureInfo.InvariantCulture, SkyDriveRestApi.PreFormattedSignInUri, SkyDriveRestApi.iTinExportEngineId, SkyDriveRestApi.SkyDriveUpdateScope));
            }
            #endregion

        #endregion

        #region Public Static Properties

            #region [public] {static} (string) AccessToken: Gets the access token for this session.
            /// <summary>
            /// Gets the access token for this session.
            /// </summary>
            /// <value>
            /// A <see cref="T:System.String" /> that contains the access token. Is required for all operations for this session.
            /// </value>
            public static string AccessToken
            {
                get; private set;
            }
            #endregion

        #endregion

        #region Private Methods

            #region [private] (void) BrowserDocumentCompleted(object, WebBrowserDocumentCompletedEventArgs): Browsers the document completed.
            /// <summary>
            /// Browsers the document completed.
            /// </summary>
            /// <param name="sender">The sender.</param>
            /// <param name="e">The <see cref="WebBrowserDocumentCompletedEventArgs" /> instance containing the event data.</param>
            private void BrowserDocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
            {
                if (!e.Url.AbsoluteUri.Contains("#access_token=") && 
                    !e.Url.AbsoluteUri.Contains("#error=access_denied") &&
                    !e.Url.AbsoluteUri.Contains("/ppsecure/post.srf?client_id="))
                {
                    return;
                }

                if (e.Url.AbsoluteUri.Contains("/ppsecure/post.srf?client_id="))
                {
                    this.cancelLinkLabel.Visible = false;
                    this.browser.Height = this.Height;
                    this.browser.Location = new Point(0, 0);
                }
                else
                {
                    if (e.Url.AbsoluteUri.Contains("#access_token="))
                    {
                        var uriItems = e.Url.AbsoluteUri.Split(new[] { "#access_token" }, StringSplitOptions.RemoveEmptyEntries);
                        AccessToken = uriItems[1].Split(new[] { '&' })[0];
                    }
                    else
                    {
                        AccessToken = string.Empty;
                    }

                    this.ExitDialog();
                }
            }
            #endregion

            #region [private] (void) CancelLinkLabelLinkClicked(object, LinkLabelLinkClickedEventArgs): Handles link label click event.
            /// <summary>
            /// Handles link label click event.
            /// </summary>
            /// <param name="sender">The sender.</param>
            /// <param name="e">The <see cref="FormClosedEventArgs"/> instance containing the event data.</param>
            private void CancelLinkLabelLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                AccessToken = string.Empty;
                this.ExitDialog();
            }
            #endregion

            #region [private] (void) ExitDialog(): Exit dialog.
            /// <summary>
            /// Exit dialog.
            /// </summary>
            private void ExitDialog()
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            #endregion

        #endregion
    }
}