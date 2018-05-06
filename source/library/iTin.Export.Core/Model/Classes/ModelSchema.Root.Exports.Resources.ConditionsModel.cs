
namespace iTin.Export.Model
{
    using System;

    using Helpers;

    public partial class ConditionsModel : ICloneable
    {
        public ConditionsModel(GlobalResourcesModel parent) : base(parent)
        {
        }

        #region [public] (ConditionsModel) Clone(): Clones this instance.
        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public ConditionsModel Clone()
        {
            return CopierHelper.DeepCopy(this);
        }
        #endregion

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public override ChangeConditionModel GetBy(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return ChangeConditionModel.Empty;
            }

            var condition = Find(s => s.Name.Equals(value));

            return condition ?? ChangeConditionModel.Empty;
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="item"></param>
        protected override void SetOwner(ChangeConditionModel item)
        {
            SentinelHelper.ArgumentNull(item);

            item.SetOwner(this);
        }

        #region [private] (object) Clone(): Creates a new object that is a copy of the current instance
        /// <inheritdoc />
        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
        /// <returns>
        /// A new object that is a copy of this instance.
        /// </returns>
        object ICloneable.Clone()
        {
            return Clone();
        }
        #endregion
    }
}
