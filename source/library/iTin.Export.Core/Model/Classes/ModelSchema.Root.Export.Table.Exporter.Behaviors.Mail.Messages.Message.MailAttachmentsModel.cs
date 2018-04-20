
namespace iTin.Export.Model
{
    using Helper;

    public partial class MailMessageAttachmentsModel
    {
        #region constructor/s

        #region [public] MailMessageAttachmentsModel(MailMessageModel):
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.MailMessageAttachmentsModel" /> class.
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
