
namespace iTin.Export
{
    using System.Collections.Generic;
    using System.Diagnostics;

    using Model;

    /// <summary>
    /// 
    /// </summary>
    public class ModelService 
    {
        #region private nested enumerations

        #region [private] (enum) KnownServiceName: Defines known node names
        /// <summary>
        /// Defines known node names.
        /// </summary>
        enum KnownServiceName
        {
            /// <summary>
            /// Root node
            /// </summary>
            Root = 0,

            /// <summary>
            /// Resources node
            /// </summary>
            Resources = 1
        }
        #endregion

        #endregion

        #region private static members
        // Static members are 'eagerly initialized', that is, 
        // immediately when class is loaded for the first time.
        // .NET guarantees thread safety for static initialization
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static readonly ModelService Default = new ModelService();
        #endregion

        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly Dictionary<KnownServiceName, object> _table;
        #endregion

        #region constructor/s

        #region [private] ModelService():

        private ModelService() => _table = new Dictionary<KnownServiceName, object>
        {
            {KnownServiceName.Root, null},
            {KnownServiceName.Resources, null},
        };

        #endregion

        #endregion

        #region public static properties

        #region [public] {static} (ModelService) Instance:
        /// <summary>
        /// 
        /// </summary>
        public static ModelService Instance => Default;
        #endregion

        #endregion

        #region public properties

        #region [public] (ExportsModel) Root:
        /// <summary>
        /// 
        /// </summary>
        public ExportsModel Root => (ExportsModel)_table[KnownServiceName.Root];
        #endregion

        #region [public] (ReferencesModel) References:
        /// <summary>
        /// 
        /// </summary>
        public ReferencesModel References => Root.References;
        #endregion

        #region [public] (GlobalResourcesModel) Resources:
        /// <summary>
        /// 
        /// </summary>
        public GlobalResourcesModel Resources => Root.Resources;
        #endregion

        #endregion

        #region internal methods:

        #region [internal] (void) Add<T>(T): 
        internal void Add<T>(T item)
        {
            var isRoot = item is ExportsModel;
            var isResources = item is GlobalResourcesModel;
            var isValidElement = isRoot || isResources;

            if (!isValidElement)
            {
                return;
            }

            if (isRoot)
            {
                _table[KnownServiceName.Root] = item as ExportsModel;              
            }
            else
            {
                _table[KnownServiceName.Resources] = item as GlobalResourcesModel;
            }
        }
        #endregion

        #endregion
    }
}
