
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Diagnostics;
using System.Linq;

namespace iTin.Export.ComponentModel.Provider
{
    using Helpers;
    using Input;
    using Resources;

    /// <summary>
    /// Represents a cache of providers available for the specified routes.
    /// </summary>
    /// <remarks>
    /// Based in Managed Extensibility Framework <string>(MEF)</string> specification.
    /// </remarks>
    internal sealed class ProvidersCache
    {
        #region private readonly members

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly CompositionContainer _container;

        #endregion

        #region private members

        [ImportMany(AllowRecomposition = true)]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] 
        private List<Lazy<IProvider, IProviderOptions>> _providers;

        #endregion

        #region private constructor/s

        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.ComponentModel.Provider.ProvidersCache" /> class.
        /// </summary>
        /// <param name="input">The input.</param>
        private ProvidersCache(IInput input)
        {
            _container = GetCompositionContainer(input);
        }

        #endregion

        #region public static methods

        /// <summary>
        /// Gets a reference to the cache of available providers.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>
        /// A <see cref="ProvidersCache" /> object than represents the available providers targets-cache.
        /// </returns>
        public static ProvidersCache Instance(IInput input)
        {
            return new ProvidersCache(input);
        }

        #endregion

        #region public methods

        /// <summary>
        /// Gets the provider specified from cache.
        /// </summary>
        /// <param name="info">Input metadata information</param>
        /// <returns>
        /// Provider instance.
        /// </returns>
        public IProvider GetProvider(InputOptionsMetadata info)
        { 
            var lazy = from item in _providers
                       let metadata = item.Metadata
                       where metadata.Name == info.AdapterType.Name
                       select item;

            var provider = lazy.SingleOrDefault();
            if (provider != null)
            {
                return provider.Value;
            }

            throw new InvalidOperationException(ErrorMessage.CacheWriterNotFound);
        }

        #endregion

        #region private methods

        /// <summary>
        /// Gets provider repository.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>
        /// Provider repository.
        /// </returns>
        private CompositionContainer GetCompositionContainer(IInput input)
        {
            CompositionContainer container;

            using (var catalog = new AggregateCatalog())
            {
                var adaptersDirectory = AssemblyHelper.GetExecutingAssemblyDirectory();
                var item = new SafeDirectoryCatalog(adaptersDirectory); 
                catalog.Catalogs.Add(item);

                CompositionContainer tempContainer = null;
                try
                {
                    tempContainer = new CompositionContainer(catalog);
                    var ctorAdapterParameters = new ProviderParameters {Data = input.Data};
                    tempContainer.ComposeExportedValue(ctorAdapterParameters);
                    tempContainer.ComposeParts(this);
                    container = tempContainer;
                    tempContainer = null;
                }
                finally
                {
                    tempContainer?.Dispose();
                }
            }

            return container;
        }

        #endregion
    }
}
