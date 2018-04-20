
namespace iTin.Export.Model
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    using Helper;

    /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Properties/Class[@name="info"]/*'/>
    public partial class PropertiesModel : IList<PropertyModel>, ICloneable
    {
        #region member fields
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly List<PropertyModel> _list;
        #endregion

        #region constructor/s

        #region [public] PropertiesModel(): Initializes a new instance of this class
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.PropertiesModel"/> class.
        /// </summary>
        public PropertiesModel()
        {
            _list = new List<PropertyModel>();
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (int) Count:
        /// <summary>
        /// Gets the number of elements contained in the <see cref="T:System.Collections.Generic.ICollection`1" />.
        /// </summary>
        /// <returns>The number of elements contained in the <see cref="T:System.Collections.Generic.ICollection`1" />.</returns>
        public int Count => _list.Count;
        #endregion

        #region [public] (bool) IsReadOnly:
        /// <inheritdoc />
        /// <summary>
        /// Gets a value indicating whether the <see cref="T:System.Collections.Generic.ICollection`1" /> is read-only.
        /// </summary>
        /// <returns>true if the <see cref="T:System.Collections.Generic.ICollection`1" /> is read-only; otherwise, false.</returns>
        public bool IsReadOnly => false;
        #endregion

        #endregion

        #region public overrides properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance contains the default
        /// <inheritdoc />
        /// <include file="..\..\iTin.Export.Documentation.Common.xml" path="Common/Model/Public/Overrides/Properties/Property[@name=&quot;IsDefault.Collection&quot;]/*" />
        public override bool IsDefault => !this.Any();
        #endregion

        #endregion

        #region public indexers

        public PropertyModel this[int index]
        {
            get => _list[index];
            set => _list[index] = value;
        }

        public PropertyModel this[string name] => GetByName(name);

        #endregion

        #region public methods

        #region [public] (void) Add(PropertyModel):
        public void Add(PropertyModel item)
        {
            SentinelHelper.ArgumentNull(item);

            item.SetOwner(this);
            _list.Add(item);
        }
        #endregion

        #region [public] (void) Clear():
        public void Clear()
        {
            _list.Clear();
        }
        #endregion

        #region [public] (PropertiesModel) Clone(): Clones this instance
        /// <summary> 
        /// Clones this instance.
        /// </summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public PropertiesModel Clone()
        {
            var propertiesCloned = new PropertiesModel();

            foreach (var property in this)
            {
                property.SetOwner(propertiesCloned);
                propertiesCloned.Add(property.Clone());
            }

            return propertiesCloned;
        }
        #endregion

        #region [public] (bool) Contains(PropertyModel): Returns a value indicating whether the style exist
        public bool Contains(PropertyModel item)
        {
            return _list.Contains(item);
        }
        #endregion

        #region [public] (bool) Contains(string): Returns a value indicating whether the style exist
        public bool Contains(string name)
        {
            return GetByName(name) != null;
        }
        #endregion

        public int IndexOf(PropertyModel item)
        {
            return _list.IndexOf(item);
        }

        public void Insert(int index, PropertyModel item)
        {
            _list.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            _list.RemoveAt(index);
        }

        public void CopyTo(PropertyModel[] array, int arrayIndex)
        {
            _list.CopyTo(array, arrayIndex);
        }

        public bool Remove(PropertyModel item)
        {
            return _list.Remove(item);
        }

        public IEnumerator<PropertyModel> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _list.GetEnumerator();
        }

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

        #region [private] (PropertyModel) GetByName(string): Returns a reference to the specified style
        private PropertyModel GetByName(string name)
        {
            return _list.Find(s => s.Name.Equals(name));
        }
        #endregion

        #endregion
    }
}
