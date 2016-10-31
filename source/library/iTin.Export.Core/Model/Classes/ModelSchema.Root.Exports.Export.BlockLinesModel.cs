using iTin.Export.Helper;

namespace iTin.Export.Model
{
    /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Table/Class[@name="info"]/*'/>
    public partial class BlockLinesModel
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="parent"></param>
        public BlockLinesModel(ExportModel parent)
            : base(parent)
        {
        }

        protected override void SetOwner(BlockLineModel item)
        {
            SentinelHelper.ArgumentNull(item);

            //item.SetOwner(this);
        }

        public override BlockLineModel GetBy(string value)
        {
            return Find(s => s.Key.Equals(value));
        }
    }
}
