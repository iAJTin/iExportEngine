
namespace iTin.Export.Model
{
    using Helpers;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    public partial class ServerCredentialsModel
    {
        #region constructor/s

        #region [public] ServerCredentialsModel(MailServerModel):
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.ServerCredentialsModel" /> class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        public ServerCredentialsModel(MailServerModel parent)
            : base(parent)
        {
        }    
        #endregion

        #endregion

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="item"></param>
        protected override void SetOwner(ServerCredentialModel item)
        {
            SentinelHelper.ArgumentNull(item);

            item.SetOwner(this);
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public override ServerCredentialModel GetBy(string value)
        {
            return Find(s => s.Name.Equals(value));
        }
    }
}
