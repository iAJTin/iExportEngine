using iTin.Export.Helper;

namespace iTin.Export.Model
{
    public partial class MailMessageAttachmentsModel
    {
        #region constructor/s

            #region [public] MailMessageAttachmentsModel(MailMessageModel):
            /// <summary>
            /// Initializes a new instance of the <see cref="MailMessageAttachmentsModel"/> class.
            /// </summary>
            /// <param name="parent">The parent.</param>
            public MailMessageAttachmentsModel(MailMessageModel parent)
                : base(parent)
            {
            }
            #endregion

        #endregion

        protected override void SetOwner(MailMessageAttachmentModel item)
        {
            SentinelHelper.ArgumentNull(item);

            item.SetOwner(this);
        }
    }
}
