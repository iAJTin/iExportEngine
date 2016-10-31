using iTin.Export.Helper;

namespace iTin.Export.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ServerCredentialsModel
    {
        #region constructor/s

            #region [public] ServerCredentialsModel(MailServerModel):
            /// <summary>
            /// Initializes a new instance of the <see cref="ServerCredentialsModel"/> class.
            /// </summary>
            /// <param name="parent">The parent.</param>
            public ServerCredentialsModel(MailServerModel parent)
                : base(parent)
            {
            }    
            #endregion

        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        protected override void SetOwner(ServerCredentialModel item)
        {
            SentinelHelper.ArgumentNull(item);

            item.SetOwner(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public override ServerCredentialModel GetBy(string value)
        {
            return Find(s => s.Name.Equals(value));
        }
    }
}
