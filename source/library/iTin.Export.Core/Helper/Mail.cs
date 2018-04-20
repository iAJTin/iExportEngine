
namespace iTin.Export.Helper
{
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Net;
    using System.Net.Mail;

    using Model;

    /// <summary>
    /// Static class that encapsules the behavior of send mail.
    /// </summary>
    class Mail
    {
        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly MailServerModel server;
        #endregion

        #region constructor/s

        #region [public] Mail(MailServerModel): Initializes a new instance of this class
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Helper.Mail" /> class.
        /// </summary>
        /// <param name="server">Server model.</param>
        public Mail(MailServerModel server)
        {
            SentinelHelper.ArgumentNull(server);

            this.server = server;
        }
        #endregion

        #endregion

        #region public methods

        #region [public] (void) SendMail(string, MailMessage): Sends mail with specified credential synchronously
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
        #endregion

        #region [public] (void) SendMail(string, MailMessage, bool): Sends mail with specified credential synchronously or asynchronously
        /// <summary>
        /// Sends mail with specified credential synchronously or asynchronously.
        /// </summary>
        /// <param name="credential">The name of credential.</param>
        /// <param name="message">Message to send.</param>
        /// <param name="asAsync">if is <strong>true</strong> send mail asynchronously.</param>
        [SuppressMessage("Microsoft.Reliability", "CA2000:Eliminar (Dispose) objetos antes de perder el ámbito")]
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

        #endregion

        #region private static methods

        #region [private] {static} (void) SendCompletedCallback(object, AsyncCompletedEventArgs): Sends the completed callback
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

        #endregion
    }
}
