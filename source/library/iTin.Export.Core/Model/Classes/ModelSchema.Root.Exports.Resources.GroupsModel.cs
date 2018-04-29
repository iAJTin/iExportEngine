
namespace iTin.Export.Model
{
    using Helpers;

    /// <inheritdoc />
    /// <summary>
    /// Userdefined groups.
    /// </summary>
    public partial class GroupsModel
    {
        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="parent"></param>
        public GroupsModel(GlobalResourcesModel parent)
            : base(parent)
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="item"></param>
        protected override void SetOwner(GroupModel item)
        {
            SentinelHelper.ArgumentNull(item);

            item.SetOwner(this);
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public override GroupModel GetBy(string value)
        {
            return Find(s => s.Name.Equals(value));
        }
    }
}
