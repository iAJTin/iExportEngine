
namespace iTin.Export.Model
{
    using System.Collections.Generic;
    using System.Linq;

    using Helpers;

    public partial class MailMessagesModel
    {
        #region constructor/s

        #region [public] MailMessagesModel(MailBehaviorModel):
        /// <summary>
        /// Initializes a new instance of the <see cref="MailMessagesModel"/> class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        public MailMessagesModel(MailBehaviorModel parent)
            : base(parent)
        {
        }
        #endregion

        #endregion

        protected override void SetOwner(MailMessageModel item)
        {
            SentinelHelper.ArgumentNull(item);

            item.SetOwner(this);
        }

        #region [public] {static} (IEnumerable<MailMessageModel>) GetRange(IEnumerable<MailMessageModel>, string): Returns an enumerator to message list containing only those who meet the credential condition
        /// <summary>
        /// Returns an enumerator to message list containing only those who meet the credential condition.
        /// </summary>
        /// <param name="messages">Message List.</param>
        /// <param name="credential">Server credential.</param>
        /// <returns>
        /// Enumerator that contains message list that meet the condition.
        /// </returns>
        public static IEnumerable<MailMessageModel> GetRange(IEnumerable<MailMessageModel> messages, string credential)
        {
            SentinelHelper.IsTrue(string.IsNullOrEmpty(credential));

            return messages.Where(message => message.Credential.Equals(credential)).ToList();
        }
        #endregion

        #region [public] {static} (IEnumerable<MailMessageModel>) GetRange(IEnumerable<MailMessageModel>, YesNo): Returns an enumerator to message list containing only those who meet the condition
        /// <summary>
        /// Returns an enumerator to message list containing only those who meet the condition.
        /// </summary>
        /// <param name="messages">Message List.</param>
        /// <param name="send">Indicates if message will to send.</param>
        /// <returns>
        /// Enumerator that contains message list that meet the condition.
        /// </returns>
        public static IEnumerable<MailMessageModel> GetRange(IEnumerable<MailMessageModel> messages, YesNo send)
        {
            SentinelHelper.IsEnumValid(send);

            return messages.Where(message => message.Send.Equals(send)).ToList();
        }
        #endregion
    }
}
