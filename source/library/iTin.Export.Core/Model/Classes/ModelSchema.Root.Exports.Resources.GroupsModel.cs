using iTin.Export.Helper;

namespace iTin.Export.Model
{
    /// <summary>
    /// Userdefined groups.
    /// </summary>
    public partial class GroupsModel
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="parent"></param>
        public GroupsModel(GlobalResourcesModel parent)
            : base(parent)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        protected override void SetOwner(GroupModel item)
        {
            SentinelHelper.ArgumentNull(item);

            item.SetOwner(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public override GroupModel GetBy(string value)
        {
            return Find(s => s.Name.Equals(value));
        }
    }
}
