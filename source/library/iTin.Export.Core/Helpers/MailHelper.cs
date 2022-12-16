
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;

namespace iTin.Export.Helpers
{
    using Model;

    /// <summary>
    /// Static class that encapsules the behavior of send mail.
    /// </summary>
    class MailHelper
    {
        #region private members

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly MailServerModel server;

        #endregion

        #region constructor/s

        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Helper.Mail" /> class.
        /// </summary>
        /// <param name="server">Server model.</param>
        public MailHelper(MailServerModel server)
        {
            SentinelHelper.ArgumentNull(server);

            this.server = server;
        }

        #endregion

        #region public methods

        /// <summary>
        /// Sends mail with specified credential synchronously.
        /// </summary>
        /// <param name="credential">Credential name.</param>
        /// <param name="message">Message to send.</param>
        public void SendMail(string credential, MailMessage message)
        {
            SentinelHelper.ArgumentNull(message);
            SentinelHelper.IsTrue(string.IsNullOrEmpty(credential));
                                              
            SendMail(credential, message, false);                
        }

        /// <summary>
        /// Sends mail with specified credential synchronously or asynchronously.
        /// </summary>
        /// <param name="credential">The name of credential.</param>
        /// <param name="message">Message to send.</param>
        /// <param name="asAsync">if is <strong>true</strong> send mail asynchronously.</param>
        public void SendMail(string credential, MailMessage message, bool asAsync)
        {
            SentinelHelper.ArgumentNull(message);
            SentinelHelper.IsTrue(string.IsNullOrEmpty(credential));

            var model = server.Credentials[credential];

            if (asAsync)
            {
                var client = new SmtpClient(model.Host, model.Port)
                    {
                        EnableSsl = model.SSL == YesNo.Yes,
                        Credentials = new NetworkCredential(model.UserName, model.Password, model.Domain),
                        DeliveryMethod = SmtpDeliveryMethod.Network
                    };
                    
                client.SendCompleted += SendCompletedCallback;
                client.SendAsync(message, message);
            }
            else
            {
                var client = new SmtpClient(model.Host, model.Port)
                {
                    EnableSsl = true,
                    Credentials = new NetworkCredential(model.UserName, model.Password, model.Domain),
                    DeliveryMethod = SmtpDeliveryMethod.Network
                };

                client.Send(message);               
            }
        }

        #endregion

        #region private static methods

        /// <summary>
        /// Sends the completed callback.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="AsyncCompletedEventArgs"/> instance containing the event data.</param>
        private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            var message = (MailMessage)e.UserState;

            if (e.Cancelled)
            {
            }

            if (e.Error != null)
            {
            } 
            else
            {
                message.Dispose();
            }                
        }

        #endregion
    }
}
