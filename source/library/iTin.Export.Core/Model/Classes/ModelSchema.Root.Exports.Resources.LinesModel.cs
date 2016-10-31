using System;

using iTin.Export.Helper;

namespace iTin.Export.Model
{
    /// <summary>
    /// A set of lines. Before and after lines.
    /// </summary>
    public partial class LinesModel
    {
        #region Constructor/s

            #region [public] LinesModel(GlobalResourcesModel): Initializes a new instance of this class.
            /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Fields/Public/Constructors/Constructor[@name="ctor1"]/*'/>
            public LinesModel(GlobalResourcesModel parent)
                : base(parent)
            {
            }
            #endregion

        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
            protected override void SetOwner(BaseLineModel item)
        {
            SentinelHelper.ArgumentNull(item);

            item.SetOwner(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
            public override BaseLineModel GetBy(string value)
        {
            return Find(s => s.Key.Equals(value, StringComparison.Ordinal));
        }
    }
}
