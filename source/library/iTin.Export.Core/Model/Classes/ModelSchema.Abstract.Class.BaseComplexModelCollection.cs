
namespace iTin.Export.Model
{
    using System;

    /// <inheritdoc />
    /// <summary>
    /// A Specialization of <see cref="T:iTin.Export.Model.BaseSimpleModelCollection{TItem, TParent}" /> class.<br />.
    /// Which acts as the base class for nodes of model which are of collection type
    /// </summary>
    /// <typeparam name="TItem">The type of elements in the list.</typeparam>
    /// <typeparam name="TParent">The owner type of list.</typeparam>
    /// <typeparam name="TSearch">The type of search element.</typeparam>
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
    ///       <term><see cref="T:iTin.Export.Model.HostsModel" /></term>
    ///       <description></description>
    ///     </item>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Model.ImagesModel" /></term>
    ///       <description></description>
    ///     </item>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Model.BlockLinesModel" /></term>
    ///       <description></description>
    ///     </item>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Model.FixedModel" /></term>
    ///       <description></description>
    ///     </item>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Model.ColumnHeadersModel" /></term>
    ///       <description></description>
    ///     </item>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Model.FieldsModel" /></term>
    ///       <description></description>
    ///     </item>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Model.GroupsModel" /></term>
    ///       <description></description>
    ///     </item>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Model.StylesModel" /></term>
    ///       <description></description>
    ///     </item>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Model.LinesModel" /></term>
    ///       <description></description>
    ///     </item>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Model.BordersModel" /></term>
    ///       <description></description>
    ///     </item>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Model.ChartPlotsModel" /></term>
    ///       <description></description>
    ///     </item>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Model.ServerCredentialsModel" /></term>
    ///       <description></description>
    ///     </item>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Model.PiecesModel" /></term>
    ///       <description></description>
    ///     </item>
    ///   </list>
    /// </remarks>
    [Serializable]
    public abstract class BaseComplexModelCollection<TItem, TParent, TSearch> : BaseSimpleModelCollection<TItem, TParent>
    {
        #region constructor/s

        #region [protected] BaseComplexModelCollection(TParent): Initializes a new instance of the class
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.BaseComplexModelCollection`3" /> class.
        /// </summary>
        /// <param name="parent">c.</param>
        protected BaseComplexModelCollection(TParent parent) : base(parent)
        {
        }
        #endregion

        #endregion

        #region public indexer

        #region [public] (TItem) this[TSearch]: Gets or sets the element specified parameter search
        /// <summary>
        /// Gets or sets the element specified by <paramref name="value" />.
        /// </summary>
        /// <value>
        /// Item
        /// </value>
        /// <param name="value">Zero-based index of the element to get or set.</param>
        /// <returns>
        /// The value.
        /// </returns>
        public TItem this[TSearch value] => GetBy(value);
        #endregion

        #endregion

        #region public methods

        #region [public] (void) Contains(TSearch): Determines whether an element is in the collection
        /// <summary>
        /// Determines whether an element is in the <see cref="BaseComplexModelCollection{TItem, TParent, TSearch}" />.
        /// </summary>
        /// <param name="value">The object to locate in the <see cref="BaseComplexModelCollection{TItem, TParent, TSearch}" />.</param>
        /// <returns>
        ///   <strong>true</strong> if <paramref name="value" /> is found in the <see cref="BaseComplexModelCollection{TItem, TParent, TSearch}" />; otherwise, <strong>false</strong>.
        /// </returns>
        public bool Contains(TSearch value)
        {
            return GetBy(value) != null;
        }
        #endregion

        #endregion

        #region public abstract methods

        #region [public] (void) GetBy(TSearch): Returns the element specified
        /// <summary>
        /// Returns the element specified.
        /// </summary>
        /// <param name="value">The object to locate in the <see cref="BaseSimpleModelCollection{TItem, TParent}" />.</param>
        /// <returns>
        ///   <strong>true</strong> if <paramref name="value" /> is found in the <see cref="BaseSimpleModelCollection{TItem, TParent}" />; otherwise, <strong>false</strong>.
        /// </returns>
        public abstract TItem GetBy(TSearch value);
        #endregion

        #endregion
    }
}
