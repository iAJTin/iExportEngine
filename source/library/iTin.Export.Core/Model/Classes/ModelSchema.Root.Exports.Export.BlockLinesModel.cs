
namespace iTin.Export.Model
{
    using Helpers;

    /// <inheritdoc />
    /// <include file="..\..\iTin.Export.Documentation.xml" path="Model/Table/Class[@name='info']/*" />
    public partial class BlockLinesModel
    {
        /// <inheritdoc />
        /// <summary>
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
