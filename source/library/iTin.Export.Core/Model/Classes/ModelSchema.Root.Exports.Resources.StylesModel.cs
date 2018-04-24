
namespace iTin.Export.Model
{
    using System;

    using Helper;

    /// <include file="..\..\iTin.Export.Documentation.xml" path="Model/Styles/Class[@name='info']/*" />
    public partial class StylesModel : ICloneable
    {
        /// <inheritdoc />
        /// <include file="..\..\iTin.Export.Documentation.xml" path="Model/Styles/Public/Constructors/Constructor[@name='ctor1']/*" />
        public StylesModel(GlobalResourcesModel parent) : base(parent)
        {
        }

        #region [public] (StylesModel) Clone(): Clones this instance.
        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public StylesModel Clone()
        {
            return CopierHelper.DeepCopy(this);
        }
        #endregion

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public override StyleModel GetBy(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return StyleModel.Default;
            }

            var style = Find(s => s.Name.Equals(value));

            return style ?? StyleModel.Default;
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="item"></param>
        protected override void SetOwner(StyleModel item)
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
