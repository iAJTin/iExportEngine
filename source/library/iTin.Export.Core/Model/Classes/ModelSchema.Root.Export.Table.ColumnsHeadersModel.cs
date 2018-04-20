
namespace iTin.Export.Model
{
    using Helper;

    /// <summary>
    /// 
    /// </summary>
    public partial class ColumnHeadersModel
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="parent"></param>
        public ColumnHeadersModel(TableModel parent)
            : base(parent)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        protected override void SetOwner(ColumnHeaderModel item)
        {
            SentinelHelper.ArgumentNull(item);

            item.SetOwner(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public override ColumnHeaderModel GetBy(string value)
        {
            return null; ////this.Find(s => s.Key.Equals(name));
        }
    }
}
