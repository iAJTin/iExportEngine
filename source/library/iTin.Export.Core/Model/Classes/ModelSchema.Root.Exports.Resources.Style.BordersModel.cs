using System;
using System.Linq;
using iTin.Export.Helper;

namespace iTin.Export.Model
{
    public partial class BordersModel : ICloneable
    {
        public BordersModel(StyleModel parent) : base(parent)
        {
        }

        public override BorderModel GetBy(KnownBorderPosition value)
        {
            return Find(s => s.Position.Equals(value));
        }

        protected override void SetOwner(BorderModel item)
        {
            SentinelHelper.ArgumentNull(item);

            item.SetOwner(this);
        }

        #region public methods

            #region [public] (BordersModel) Clone(): Clones this instance.
            /// <summary>
            /// Clones this instance.
            /// </summary>
            /// <returns>A new object that is a copy of this instance.</returns>
            public BordersModel Clone()
            {
                var bordersCloned = new BordersModel(Parent)
                {
                    Properties = Properties.Clone()
                };

                foreach (var border in this)
                {
                    border.SetOwner(bordersCloned);
                    bordersCloned.Add(border.Clone()); 
                }

                return bordersCloned;
            }
            #endregion

            #region [public] (void) Combine(BordersModel): Combines this instance with reference parameter.
            /// <summary>
            /// Combines this instance with reference parameter.
            /// </summary>
            /// <param name="reference">The reference.</param>
            public void Combine(BordersModel reference)
                {
                    var hasElements = this.Any();
                    if (!hasElements)
                    {                    
                        foreach (var referenceBorder in reference)
                        {
                            var border = referenceBorder.Clone();
                            border.SetOwner(this);
                            Add(border);
                        }
                    }
                    else
                    {
                        foreach (var border in this)
                        {
                            var refborder = reference.GetBy(border.Position);
                            if (refborder != null)
                            {
                                border.Combine(refborder);
                            }
                        }

                        foreach (var referenceBorder in reference)
                        {
                            var border = GetBy(referenceBorder.Position);
                            if (border != null)
                            {
                                continue;
                            }

                            var newBorder = referenceBorder.Clone();
                            newBorder.SetOwner(this);
                            Add(newBorder);
                        }
                    }
                }
                #endregion

        #endregion

        #region private methods

            #region [private] (object) Clone(): Creates a new object that is a copy of the current instance.
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
