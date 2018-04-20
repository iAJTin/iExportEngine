
namespace iTin.Export.ComponentModel
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel.Composition;
    using System.ComponentModel.Composition.Hosting;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Reflection;

    using Helper;
    using Model;

    /// <summary>
    /// Represents a cache of writers available for the specified routes.
    /// </summary>
    /// <remarks>
    /// Based in Managed Extensibility Framework <string>(MEF)</string> specification.
    /// </remarks>
    internal sealed class WritersCache
    {
        #region static field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static readonly object SyncLock = new object();
        #endregion

        #region static volatile field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static volatile WritersCache _instance;
        #endregion

        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly CompositionContainer _container;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly List<FileSystemWatcher> _watchers;

        [ImportMany(AllowRecomposition = true)]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] 
        private List<Lazy<IWriter, IWriterOptions>> _writers;
        #endregion

        #region constructor/s

            #region [private] WritersCache(WritersCacheSettings): Initializes a new instance of the class.
            /// <summary>
            /// Initializes a new instance of the <see cref="T:iTin.Export.ComponentModel.WritersCache" /> class.
            /// </summary>
            /// <param name="settings">A reference to cache settings object.</param>
            private WritersCache(WritersCacheSettings settings)
            {
                SentinelHelper.ArgumentNull(settings);
                SentinelHelper.ArgumentNull(settings.Items);

                _watchers = new List<FileSystemWatcher>();
                _container = GetCompositionContainer(settings);
            }
            #endregion

        #endregion

        #region finalizer

            #region ~WritersCache(): Finalizes this instance.
            /// <summary>
            /// Finalizes an instance of the <see cref="T:iTin.Export.ComponentModel.WritersCache"/> class.
            /// </summary>
            ~WritersCache()
            {
                // Dispose managed resources.
                _writers.Clear();
                _writers = null;

                if (_watchers != null)
                {
                    foreach (var watcher in _watchers)
                    {
                        watcher.Dispose();
                    }
                }

                if (_container != null)
                {
                    _container.Dispose();
                }

                _instance = null;
            }
            #endregion

        #endregion

        #region public static methods

            #region [public] {static} (WritersCache) Instance(): Gets a reference to the cache of available writers.
            /// <summary>
            /// Gets a reference to the cache of available writers.
            /// </summary>
            /// <param name="settings">The settings.</param>
            /// <returns>
            /// A <see cref="T:iTin.Export.ComponentModel.WritersCache" /> object than represents the available writers-cache.
            /// </returns>
            public static WritersCache Instance(WritersCacheSettings settings)
            {
                SentinelHelper.ArgumentNull(settings);

                if (_instance == null)
                {
                    lock (SyncLock)
                    {
                        if (_instance == null)
                        {
                            _instance = new WritersCache(settings);
                        }
                    }
                }

                return _instance;
            }
            #endregion

            #region [public] {static} (WritersCacheSettings) CreateWriterSettingsFromModel(WriterModelBase): Creates the settings from specified model.
            /// <summary>
            /// Creates the settings from specified model.
            /// </summary>
            /// <param name="writer">Writer model.</param>
            /// <returns>
            /// A <see cref="T:iTin.Export.ComponentModel.WritersCacheSettings" /> object than represents the cache settings for this model.
            /// </returns>
            [SuppressMessage("Microsoft.Design", "CA1062:Validar argumentos de métodos públicos", MessageId = "0")]
            public static WritersCacheSettings CreateWriterSettingsFromModel(WriterModelBase writer)
            {
                SentinelHelper.ArgumentNull(writer);
                SentinelHelper.ArgumentNull(writer.Filter);

                var codeBase = Assembly.GetExecutingAssembly().CodeBase;
                var codeBaseUri = new Uri(codeBase);
                var uri = new UriBuilder(codeBaseUri);
                var path = Uri.UnescapeDataString(uri.Path);
                var defaultWriterPath = Path.GetDirectoryName(path);

                var itemsPath = new Collection<string> { defaultWriterPath, };

                Debug.Assert(defaultWriterPath != null, "defaultWriterPath != null");
                var writersDirectory = Path.Combine(defaultWriterPath, "Writers\\");
                if (Directory.Exists(writersDirectory))
                {
                    itemsPath.Add(writersDirectory);
                }

                var customWriterPath = writer.Filter.Path;
                var existCustomWriter = itemsPath.Contains(customWriterPath);
                if (!existCustomWriter)
                {
                    if (!string.IsNullOrEmpty(customWriterPath) &&  !customWriterPath.Equals("Default"))
                    {
                        if (Directory.Exists(customWriterPath))
                        {
                            itemsPath.Add(customWriterPath);
                        }
                    }
                }

                return new WritersCacheSettings { Items = itemsPath };
            }
            #endregion

        #endregion

        #region Public Methods

            #region [public] (IWriter) GetWriter(WriterModel): Gets the writer specified from cache.
            /// <summary>
            /// Gets the writer specified from cache.
            /// </summary>
            /// <param name="model">Writer model</param>
            /// <returns>
            /// Writer instance.
            /// </returns>
            [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
            public IWriter GetWriter(WriterModel model)
            {
                SentinelHelper.ArgumentNull(model);
                SentinelHelper.ArgumentNull(model.Filter);
 
                var lazy = from item in _writers
                           let metadata = item.Metadata
                           where (metadata.Name == model.Name)
                           select item;

                if ((model.Filter.WriterStyles & KnownWriterFilter.Version) == KnownWriterFilter.Version)
                {
                    lazy = from item in lazy
                           let metadata = item.Metadata
                           where (metadata.Version == int.Parse(model.Filter.Version, CultureInfo.InvariantCulture))
                           select item;
                }

                if ((model.Filter.WriterStyles & KnownWriterFilter.Author) == KnownWriterFilter.Author)
                {
                    lazy = from item in lazy
                           let metadata = item.Metadata
                           where (metadata.Author == model.Filter.Author)
                           select item;
                }

                if ((model.Filter.WriterStyles & KnownWriterFilter.Company) == KnownWriterFilter.Company)
                {
                    lazy = from item in lazy
                           let metadata = item.Metadata
                           where (metadata.Company == model.Filter.Company)
                           select item;
                }

                var writer = lazy.SingleOrDefault();
                if (writer != null)
                {
                    return writer.Value;
                }

                throw new InvalidOperationException(Resources.ErrorMessage.CacheWriterNotFound);
            }
            #endregion

        #endregion

        #region private event handles

            #region [private] (void) OnWriterWatcherChanged(object, FileSystemEventArgs): Called when writer watcher changed.
            /// <summary>
            /// Called when writer watcher changed.
            /// </summary>
            /// <param name="source">Source object</param>
            /// <param name="e">The <see cref="T:System.IO.FileSystemEventArgs" /> instance containing the event data.</param>
            private void OnWriterWatcherChanged(object source, FileSystemEventArgs e)
            {
                ((DirectoryCatalog)_container.Catalog).Refresh();
            }
            #endregion

        #endregion

        #region private methods

            #region [private] (CompositionContainer) GetCompositionContainer(WritersCacheSettings): Gets writer repository.
            /// <summary>
            /// Gets writer repository.
            /// </summary>
            /// <param name="settings">Writer cache settings.</param>
            /// <returns>
            /// Writer repository.
            /// </returns>
            private CompositionContainer GetCompositionContainer(WritersCacheSettings settings)
            {
                CompositionContainer exportContainer;

                using (var catalog = new AggregateCatalog())
                {
                    foreach (var path in settings.Items)
                    {
                        var item = new SafeDirectoryCatalog(path);
                        catalog.Catalogs.Add(item);
                        using (var writerWatcher = GetWriterWatcher(path))
                        {
                            var addWatcher = _watchers.All(watch => watch.Path != path);
                            if (addWatcher)
                            {
                                _watchers.Add(writerWatcher);
                            }
                        }
                    }

                    CompositionContainer tempContainer = null;
                    try
                    {
                        tempContainer = new CompositionContainer(catalog);
                        try
                        {
                            tempContainer.ComposeParts(this);
                            exportContainer = tempContainer;
                            tempContainer = null;
                        }
                        catch (CompositionException)
                        {
                            throw;
                        }
                    }
                    finally
                    {
                        if (tempContainer != null)
                        {
                            tempContainer.Dispose();
                        }
                    }
                }

                return exportContainer;
            }
            #endregion

            #region [private] (FileSystemWatcher) GetWriterWatcher(string): Gets watcher to the writer's path.
            /// <summary>
            /// Gets watcher to the writer's path.
            /// </summary>
            /// <param name="path">The path.</param>
            /// <returns>
            /// A <see cref="T:System.IO.FileSystemWatcher" /> object than represents the writer's path.
            /// </returns>
            private FileSystemWatcher GetWriterWatcher(string path)
            {
                FileSystemWatcher watcher;
                FileSystemWatcher tempWatcher = null;

                try
                {
                    tempWatcher = new FileSystemWatcher(path, "*.dll");
                    tempWatcher.Changed += OnWriterWatcherChanged;
                    tempWatcher.EnableRaisingEvents = true;

                    watcher = tempWatcher;
                    tempWatcher = null;
                }
                finally 
                {
                    if (tempWatcher != null)
                    {
                        tempWatcher.Dispose();
                    }                   
                }

                return watcher;
            }
            #endregion

        #endregion
    }
}
