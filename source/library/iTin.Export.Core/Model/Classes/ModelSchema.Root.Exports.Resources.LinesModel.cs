
namespace iTin.Export.Model
{
    using System;

    using Helpers;

    /// <inheritdoc />
    /// <summary>
    /// A set of lines. Before and after lines.
    /// </summary>
    public partial class LinesModel
    {
        #region constructor/s

        #region [public] LinesModel(GlobalResourcesModel): Initializes a new instance of this class
        /// <inheritdoc />
        /// <include file="..\..\iTin.Export.Documentation.xml" path="Model/Fields/Public/Constructors/Constructor[@name='ctor1']/*" />
        public LinesModel(GlobalResourcesModel parent)
            : base(parent)
        {
        }
        #endregion

        #endregion

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="item"></param>
        protected override void SetOwner(BaseLineModel item)
        {
            SentinelHelper.ArgumentNull(item);

            item.SetOwner(this);
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public override BaseLineModel GetBy(string value)
        {
            return Find(s => s.Key.Equals(value, StringComparison.Ordinal));
        }
    }
}
