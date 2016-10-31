using System;

using iTin.Export.Helper;

namespace iTin.Export.Model
{
    /// <summary>
    /// A Specialization of <see cref="T:iTin.Export.Model.BaseComplexModelCollection{TItem, TParent, TSearch}" /> class.<br/>.
    /// Which acts as the base class for nodes of model which are of collection type
    /// </summary>
    public partial class HostsModel
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="parent"></param>
        public HostsModel(GlobalResourcesModel parent) : base(parent)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public override HostModel GetBy(string value)
        {
            return Find(s => s.Key.Equals(value, StringComparison.Ordinal));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        protected override void SetOwner(HostModel item)
        {
            SentinelHelper.ArgumentNull(item);

            item.SetOwner(this);
        }
    }
}
