
namespace iTin.Export.Model
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Xml.Serialization;

    /// <summary>
    /// Represents a strongly typed list of model objects that can be accessed by index, allow defines type of parent.
    /// Provides methods to search, sort, and manipulate lists.
    /// </summary>
    /// <typeparam name="TItem">The type of elements in the list.</typeparam>
    /// <typeparam name="TParent">The owner type of list.</typeparam>
    /// <remarks>
    ///   <para>
    ///   The following table shows the different nodes of model which are of collection type.
    ///   </para>
    ///   <list type="table">
    ///     <listheader>
    ///       <term>Class</term>
    ///       <description>Description</description>
    ///     </listheader>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Model.BehaviorsModel" /></term>
    ///       <description></description>
    ///     </item>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Model.ChartsModel" /></term>
    ///       <description></description>
    ///     </item>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Model.ChartSeriesModel" /></term>
    ///       <description></description>
    ///     </item>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Model.MailMessagesModel" /></term>
    ///       <description></description>
    ///     </item>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Model.MailMessageAttachmentsModel" /></term>
    ///       <description></description>
    ///     </item>
    ///   </list>
    /// </remarks>
    [Serializable]
    public abstract class BaseSimpleModelCollection<TItem, TParent> : BaseModel<BaseSimpleModelCollection<TItem, TParent>>, IList<TItem>
    {
        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly List<TItem> list;
        #endregion

        #region constructor/s

        #region [protected] BaseSimpleModelCollection(TParent): Initializes a new instance of the class
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseSimpleModelCollection{TItem, TParent}"/> class.
        /// </summary>
        /// <param name="parent">Parent type.</param>
        protected BaseSimpleModelCollection(TParent parent)
        {
            list = new List<TItem>();
            Parent = parent;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (int) Count: Gets the number of elements contained in the collection
        /// <inheritdoc />
        /// <summary>
        /// Gets the number of elements contained in the <see cref="T:iTin.Export.Model.BaseSimpleModelCollection`2" />.
        /// </summary>
        /// <value>
        /// The number of elements contained in the <see cref="T:iTin.Export.Model.BaseSimpleModelCollection`2" />.
        /// </value>
        public int Count => List.Count;
        #endregion

        #region [public] (bool) IsReadOnly: Gets a value indicating whether the collection is read-only
        /// <inheritdoc />
        /// <summary>
        /// Gets a value indicating whether the <see cref="T:iTin.Export.Model.BaseSimpleModelCollection`2" /> is read-only.
        /// </summary>
        /// <value>
        /// Always is <strong>false</strong>
        /// </value>
        public bool IsReadOnly => false;
        #endregion

        #region [public] (TParent) Parent: Gets a reference to the owner of the collection
        /// <summary>
        /// Gets a reference to the owner of the collection
        /// </summary>
        /// <value>
        /// Owner collection
        /// </value>
        [XmlIgnore]
        public TParent Parent
        {
            get;
        }
        #endregion

        #endregion

        #region public override properties

        #region [public] {override} (bool) IsDefault: When overridden in a derived class, gets a value indicating whether this instance contains the default
        /// <inheritdoc />
        /// <summary>
        /// When overridden in a derived class, gets a value indicating whether this instance contains the default.
        /// </summary>
        /// <value>
        /// <strong>true</strong> if this instance contains the default; otherwise, <strong>false</strong>.
        /// </value>
        public override bool IsDefault => !this.Any();
        #endregion

        #endregion

        #region protected properties

        #region [protected] (List<TItem>) List: Gets a reference to the inner list
        /// <summary>
        /// Gets a reference to the inner list.
        /// </summary>
        /// <value>
        /// The inner list.
        /// </value>
        protected List<TItem> List => list;
        #endregion

        #endregion

        #region public indexer

        #region [public] (TItem) this[int]: Gets or sets the element at the specified index
        /// <summary>
        /// Gets or sets the element at the specified index.
        /// </summary>
        /// <value>
        /// Item at the specified index.
        /// </value>
        /// <param name="index">Zero-based index of the element to get or set.</param>
        /// <returns>
        /// the value
        /// </returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is not a valid index for <see cref="BaseSimpleModelCollection{TItem, TParent}" />.</exception>
        /// <exception cref="T:System.NotSupportedException">The property is set and <see cref="BaseSimpleModelCollection{TItem, TParent}" /> is readonly.</exception>
        public TItem this[int index]
        {
            get => List[index];
            set => List[index] = value;
        }
        #endregion

        #endregion

        #region public methods

        #region [public] (void) Add(TItem): Adds an object to the end of the collection
        /// <inheritdoc />
        /// <summary>
        /// Adds an object to the end of the <see cref="T:iTin.Export.Model.BaseSimpleModelCollection`2" />.
        /// </summary>
        /// <param name="item">The object to be added to the end of the <see cref="T:iTin.Export.Model.BaseSimpleModelCollection`2" />.</param>
        public void Add(TItem item)
        {
            SetOwner(item);
            List.Add(item);
        }
        #endregion

        #region [public] (void) Clear(): Removes all elements from the collection
        /// <inheritdoc />
        /// <summary>
        /// Removes all elements from the <see cref="T:iTin.Export.Model.BaseSimpleModelCollection`2" />.
        /// </summary>
        /// <remarks>
        /// <see cref="P:iTin.Export.Model.BaseSimpleModelCollection`2.Count" /> is set to 0, and references to other objects from elements of the collection are also released.
        /// </remarks>
        public void Clear()
        {
            List.Clear();
        }
        #endregion

        #region [public] (void) Contains(TItem): Determines whether an element is in the collection
        /// <inheritdoc />
        /// <summary>
        /// Determines whether an element is in the <see cref="T:iTin.Export.Model.BaseSimpleModelCollection`2" />.
        /// </summary>
        /// <param name="item">The object to locate in the <see cref="T:iTin.Export.Model.BaseSimpleModelCollection`2" />. The value can be <strong>null</strong> for reference types.</param>
        /// <returns>
        ///   <strong>true</strong> if <paramref name="item" /> is found in the <see cref="T:iTin.Export.Model.BaseSimpleModelCollection`2" />; otherwise, <strong>false</strong>.
        /// </returns>
        /// <remarks>
        /// This method determines equality by using the default equality comparer, as defined by the object's implementation of the <see cref="M:IEquatable{TItem}.Equals" /> method for TItem (the type of values in the list).
        /// </remarks>
        public bool Contains(TItem item)
        {
            return List.Contains(item);
        }
        #endregion

        #region [public] (void) CopyTo(TItem[], int): Copies the entire BaseSimpleModelCollection to a compatible one-dimensional array, starting at the specified index of the target array
        /// <inheritdoc />
        /// <summary>
        /// Copies the entire <see cref="T:iTin.Export.Model.BaseSimpleModelCollection`2" /> to a compatible one-dimensional array, starting at the specified index of the target array.
        /// </summary>
        /// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from <see cref="T:iTin.Export.Model.BaseSimpleModelCollection`2" />. The <see cref="T:System.Array" /> must have zero-based indexing.</param>
        /// <param name="arrayIndex">The zero-based index in <paramref name="array" /> at which copying begins.</param>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="array" /> is <strong>null</strong>.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="arrayIndex" /> is less than 0.</exception>
        /// <exception cref="T:System.ArgumentException">The number of elements in the source <see cref="T:iTin.Export.Model.BaseSimpleModelCollection`2" /> is greater than the available space from <paramref name="arrayIndex" /> to the end of the destination array.</exception>
        public void CopyTo(TItem[] array, int arrayIndex)
        {
            List.CopyTo(array, arrayIndex);
        }
        #endregion

        #region [public] (TItem) Find(Predicate<TItem>): Searches for an element that matches the conditions defined by the specified predicate, and returns the first occurrence within the entire BaseSimpleModelCollection
        /// <summary>
        /// Searches for an element that matches the conditions defined by the specified predicate, and returns the first occurrence within the entire <see cref="BaseSimpleModelCollection{TItem, TParent}" />.
        /// </summary>
        /// <param name="match">The <see cref="Predicate{TItem}" /> delegate that defines the conditions of the element to search for.</param>
        /// <returns>
        /// The first element that matches the conditions defined by the specified predicate, if found; otherwise, the default value for type TItem.
        /// </returns>
        public TItem Find(Predicate<TItem> match)
        {
            return List.Find(match);
        }
        #endregion

        #region [public] (IEnumerator<TItem>) GetEnumerator(): Returns an enumerator that iterates through the BaseSimpleModelCollection
        /// <inheritdoc />
        /// <summary>
        /// Returns an enumerator that iterates through the <see cref="T:iTin.Export.Model.BaseSimpleModelCollection`2" />.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Collections.Generic.IEnumerator{TItem}.Enumerator" /> for the <see cref="T:iTin.Export.Model.BaseSimpleModelCollection`2" />.
        /// </returns>
        public IEnumerator<TItem> GetEnumerator()
        {
            return List.GetEnumerator();
        }
        #endregion
        
        #region (IEnumerator) IEnumerable.GetEnumerator(): Returns an enumerator that iterates through a collection
        /// <inheritdoc />
        /// <summary>
        /// Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>
        /// An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the collection.
        /// </returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return List.GetEnumerator();
        }
        #endregion

        #region [public] (int) IndexOf(TItem): Searches for the specified object and returns the zero-based index of the first occurrence within the entire BaseSimpleModelCollection
        /// <inheritdoc />
        /// <summary>
        /// Searches for the specified object and returns the zero-based index of the first occurrence within the entire <see cref="T:iTin.Export.Model.BaseSimpleModelCollection`2" />.
        /// </summary>
        /// <param name="item">The object to locate in the <see cref="T:iTin.Export.Model.BaseSimpleModelCollection`2" />. The value can be <strong>null</strong> for reference types.</param>
        /// <returns>
        /// The zero-based index of the first occurrence of item within the entire <see cref="T:iTin.Export.Model.BaseSimpleModelCollection`2" />, if found; otherwise, –1.
        /// </returns>
        public int IndexOf(TItem item)
        {
            return List.IndexOf(item);
        }
        #endregion

        #region [public] (void) Insert(int, TItem): Inserts an element into the BaseSimpleModelCollection at the specified index
        /// <inheritdoc />
        /// <summary>
        /// Inserts an item to the <see cref="T:iTin.Export.Model.BaseSimpleModelCollection`2" /> at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index at which <paramref name="item" /> should be inserted.</param>
        /// <param name="item">The object to insert.  The value can be <strong>null</strong> for reference types.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than 0 - or - index is greater than <see cref="P:iTin.Export.Model.BaseSimpleModelCollection`2.Count" />.</exception>
        public void Insert(int index, TItem item)
        {
            List.Insert(index, item);
        }
        #endregion

        #region [public] (bool) Remove(TItem): Removes the first occurrence of a specific object from the BaseSimpleModelCollection
        /// <inheritdoc />
        /// <summary>
        /// Removes the first occurrence of a specific object from the <see cref="T:iTin.Export.Model.BaseSimpleModelCollection`2" />.
        /// </summary>
        /// <param name="item">The object to remove from the <see cref="T:iTin.Export.Model.BaseSimpleModelCollection`2" />. The value can be <strong>null</strong> for reference types.</param>
        /// <returns>
        ///   <strong>true</strong> if item is successfully removed; otherwise, <strong>false</strong>. This method also returns <strong>false</strong> if item was not found in the <see cref="T:iTin.Export.Model.BaseSimpleModelCollection`2" />.
        /// </returns>
        public bool Remove(TItem item)
        {
            return List.Remove(item);
        }
        #endregion

        #region [public] (void) RemoveAt(int): Removes the element at the specified index of the BaseSimpleModelCollection
        /// <inheritdoc />
        /// <summary>
        /// Removes the element at the specified index of the <see cref="T:iTin.Export.Model.BaseSimpleModelCollection`2" />.
        /// </summary>
        /// <param name="index">The zero-based index of the element to remove.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than 0 - or - index is greater than <see cref="P:iTin.Export.Model.BaseSimpleModelCollection`2.Count" />.</exception>
        public void RemoveAt(int index)
        {
            List.RemoveAt(index);
        }
        #endregion

        #endregion

        #region protected abstract methods

        #region [protected] {abstract} (void) SetOwner(TItem): Sets the owner of this collection
        /// <summary>
        /// Sets the owner of this collection.
        /// </summary>
        /// <param name="item">The item.</param>
        protected abstract void SetOwner(TItem item);
        #endregion

        #endregion
    }
}
