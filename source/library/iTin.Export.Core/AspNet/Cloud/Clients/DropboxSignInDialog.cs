
namespace iTin.Export.AspNet.Cloud.Clients
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    using Apis;

    /// <summary>
    /// Represents the Dropbox Sign-In dialog.
    /// </summary>
    partial class DropboxSignInDialog : Form
    {
        #region Constructor/s

            #region [public] DropboxSignInDialog(): Initializes a new instance of the class.
            /// <summary>
            /// Initializes a new instance of the <see cref="DropboxSignInDialog" /> class.
            /// </summary>
            public DropboxSignInDialog()
            {
                this.InitializeComponent();
                this.browser.DocumentCompleted += this.BrowserDocumentCompleted;

                // Step 1/3: Get request token
                var oauth = new OAuth();
                RequestToken = oauth.GetRequestToken(new Uri(DropboxRestApi.BaseUri), DropboxRestApi.iTinExportKey, DropboxRestApi.iTinExportSecret);
                
                // Step 2/3: Authorize application
                var authorizeUrl = OAuth.GetAuthorizeUri(new Uri(DropboxRestApi.AuthorizeBaseUri), RequestToken);
                this.browser.Navigate(authorizeUrl);
            }
            #endregion

        #endregion

        #region Public Static Properties

            #region [public] {static} (string) RequestToken: Gets the request token.
            /// <summary>
            /// Gets the request token.
            /// </summary>
            /// <value>
            /// The request token.
            /// </value>
            public static OAuthToken RequestToken
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
                if (!e.Url.AbsoluteUri.EndsWith("https://www.dropbox.com/1/oauth/authorize", StringComparison.OrdinalIgnoreCase) &&
                    !e.Url.AbsoluteUri.StartsWith("https://www.dropbox.com/1/oauth/authorize?oauth_token=", StringComparison.OrdinalIgnoreCase) && 
                    !e.Url.AbsoluteUri.Contains("javascript:false;"))
                {
                    return;
                }

                if (e.Url.AbsoluteUri.StartsWith("https://www.dropbox.com/1/oauth/authorize?oauth_token=", StringComparison.OrdinalIgnoreCase)) 
                {
                    this.cancelLinkLabel.Visible = false;
                    this.browser.Height = this.Height;
                    this.browser.Location = new Point(0, 0);
                }
                else
                {
                    if (e.Url.AbsoluteUri.Contains("javascript:false;"))
                    {
                        RequestToken = null;
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
                RequestToken = null;
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