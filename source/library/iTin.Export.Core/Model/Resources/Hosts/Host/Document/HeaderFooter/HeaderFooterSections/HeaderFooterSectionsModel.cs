
namespace iTin.Export.Model
{
    using System;
    using System.Linq;

    using Helpers;

    public partial class HeaderFooterSectionsModel : ICloneable
    {
        #region constructor/s

        #region [public] HeaderFooterSectionsModel(DocumentHeaderFooterModel): Initializes a new instance of the class
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.HeaderFooterSectionsModel"/> class.
        /// </summary>
        /// <param name="parent">c.</param>
        public HeaderFooterSectionsModel(DocumentHeaderFooterModel parent) : base(parent)
        {
        }
        #endregion

        #endregion

        #region public methods

        #region [public] (HeaderFooterSectionsModel) Clone(): Clones this instance.
        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public HeaderFooterSectionsModel Clone()
        {
            return CopierHelper.DeepCopy(this);
        }
        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (void) SetOwner(HeaderFooterSectionModel):
        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="item"></param>
        protected override void SetOwner(HeaderFooterSectionModel item)
        {
            SentinelHelper.ArgumentNull(item);

            item.SetOwner(this);
        }
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (HeaderFooterSectionModel) GetBy(string): Gets a specified condition by name
        /// <inheritdoc />
        /// <summary>
        /// Gets a specified condition by name
        /// </summary>
        /// <param name="name">Name of condition</param>
        /// <returns>
        /// The condition specified.
        /// </returns>
        public override HeaderFooterSectionModel GetBy(string name)
        {
            return null; //this.FirstOrDefault(condition => condition.Key == name);
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
