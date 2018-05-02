
namespace iTin.Export.ComponentModel.Adapters
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.ComponentModel.Composition.Hosting;
    using System.Diagnostics;
    using System.Linq;

    using Helpers;
    using Inputs;
    using Resources;

    /// <summary>
    /// Represents a cache of adapters available for the specified routes.
    /// </summary>
    /// <remarks>
    /// Based in Managed Extensibility Framework <string>(MEF)</string> specification.
    /// </remarks>
    internal sealed class AdaptersCache
    {
        #region private readonly members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly CompositionContainer _container;
        #endregion

        #region private members
        [ImportMany(AllowRecomposition = true)]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] 
        private List<Lazy<IAdapter, IAdapterOptions>> _adapters;
        #endregion

        #region private constructor/s

        #region [private] AdaptersCache(IInput): Initializes a new instance of the class.
        /// <summary>
        /// Initializes a new instance of the <see cref="AdaptersCache" /> class.
        /// </summary>
        /// <param name="input">The input.</param>
        private AdaptersCache(IInput input)
        {
            _container = GetCompositionContainer(input);
        }
        #endregion

        #endregion

        #region public static methods

        #region [public] {static} (AdaptersCache) Instance(IInput): Gets a reference to the cache of available adapters.
        /// <summary>
        /// Gets a reference to the cache of available adapters.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>
        /// A <see cref="AdaptersCache" /> object than represents the available targets-cache.
        /// </returns>
        public static AdaptersCache Instance(IInput input)
        {
            return new AdaptersCache(input);
        }
        #endregion

        #endregion

        #region public methods

        #region [public] (IAdapter) GetAdapter(InputOptionsMetadata): Gets the adapter specified from cache.
        /// <summary>
        /// Gets the adapter specified from cache.
        /// </summary>
        /// <param name="info">Input metadata information</param>
        /// <returns>
        /// Target instance.
        /// </returns>
        public IAdapter GetAdapter(InputOptionsMetadata info)
        { 
            var lazy = from item in _adapters
                       let metadata = item.Metadata
                       where metadata.Name == info.AdapterType.Name
                       select item;

            var adapter = lazy.SingleOrDefault();
            if (adapter != null)
            {
                return adapter.Value;
            }

            throw new InvalidOperationException(ErrorMessage.CacheWriterNotFound);
        }
        #endregion

        #endregion

        #region private methods

        #region [private] (CompositionContainer) GetCompositionContainer(IInput): Gets adapter repository
        /// <summary>
        /// Gets adapter repository.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>
        /// Adapter repository.
        /// </returns>
        private CompositionContainer GetCompositionContainer(IInput input)
        {
            CompositionContainer exportContainer;

            using (var catalog = new AggregateCatalog())
            {
                var adaptersDirectory = AssemblyHelper.GetExecutingAssemblyDirectory();
                var item = new SafeDirectoryCatalog(adaptersDirectory); 
                catalog.Catalogs.Add(item);

                CompositionContainer tempContainer = null;
                try
                {
                    tempContainer = new CompositionContainer(catalog);
                    var ctorAdapterParameters = new AdapterParameters {Data = input.Data};
                    tempContainer.ComposeExportedValue(ctorAdapterParameters);
                    tempContainer.ComposeParts(this);
                    exportContainer = tempContainer;
                    tempContainer = null;
                }
                catch
                {
                    throw;
                }
                finally
                {
                    tempContainer?.Dispose();
                }
            }

            return exportContainer;
        }
        #endregion

        #endregion
    }
}
