
namespace iTin.Export.Model
{
    using System;
    using System.Linq;

    using Helpers;

    public partial class ConditionsModel : ICloneable
    {
        #region constructor/s

        #region [public] ConditionsModel(GlobalResourcesModel): Initializes a new instance of the class
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionsModel"/> class.
        /// </summary>
        /// <param name="parent">c.</param>
        public ConditionsModel(GlobalResourcesModel parent) : base(parent)
        {
        }
        #endregion

        #endregion

        #region public methods

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

        #endregion

        #region protected override methods

        #region [protected] {override} (void) SetOwner(BaseConditionModel):
        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="item"></param>
        protected override void SetOwner(BaseConditionModel item)
        {
            SentinelHelper.ArgumentNull(item);

            item.SetOwner(this);
        }
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (BaseConditionModel) GetBy(string): Gets a specified condition by name
        /// <inheritdoc />
        /// <summary>
        /// Gets a specified condition by name
        /// </summary>
        /// <param name="name">Name of condition</param>
        /// <returns>
        /// The condition specified.
        /// </returns>
        public override BaseConditionModel GetBy(string name)
        {
            return this.FirstOrDefault(condition => condition.Name == name);
        }
        #endregion

        #endregion

        #region private methods

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

        #endregion
    }
}
