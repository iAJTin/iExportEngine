
namespace iTin.Export.ComponentModel
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    using Helper;
    using Model;
    using Web;

    /// <inheritdoc />
    /// <summary>
    /// Implements interface <see cref="T:iTin.Export.ComponentModel.IWriter" />.
    /// Which acts as the base class for future writers based and not based on markup languages​​.
    /// </summary>
    public abstract class BaseWriter : IWriter
    {
        #region private constants
        private const string TransformFileExtensionConst = "xslt";
        #endregion

        #region private field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly Collection<byte[]> _result;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly WriterExtendedInformation _extendedInformation;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool _disposed;
        #endregion

        #region constructor/s

        #region [protected] BaseWriter(): Initializes a new instance of the class
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseWriter" /> class.
        /// </summary>
        protected BaseWriter()
        {
            _result = new Collection<byte[]>();
            _extendedInformation = new WriterExtendedInformation(this);
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (TargetDataModel) DataModel: Gets a reference to the current data model
        /// <inheritdoc />
        /// <summary>
        /// Gets a reference to the current data model.
        /// </summary>
        /// <value>
        /// Reference to the current data model.
        /// </value>
        public AdapterDataModel DataModel => Adapter.DataModel;
        #endregion

        #region [public] (WriterExtendedInformation) ExtendedInformation: Gets a reference that contains the extended information about this writer
        /// <inheritdoc />
        /// <summary>
        /// Gets a reference that contains the extended information about this writer.
        /// </summary>
        /// <value>
        /// A <see cref="T:iTin.Export.ComponentModel.WriterExtendedInformation" /> that contains the extended information about this writer.
        /// </value>
        public WriterExtendedInformation ExtendedInformation => _extendedInformation;
        #endregion

        #region [public] (HostModel) Host: Gets a reference to the current host model
        /// <summary>
        /// Gets a reference to the current host model.
        /// </summary>
        /// <value>
        /// Reference to the current host model.
        /// </value>
        public HostModel Host => ModelResources.Hosts[Table.Host];
        #endregion

        #region [public] (GlobalResourcesModel) ModelResources: Gets a reference to the resources for current data model
        /// <inheritdoc />
        /// <summary>
        /// Gets a reference to the resources for current data model.
        /// </summary>
        /// <value>
        /// Reference to the resources for current data model.
        /// </value>
        public GlobalResourcesModel ModelResources => DataModel.Resources;
        #endregion

        #region [public] (Stream) Stream: Gets a reference to writer's stream
        /// <inheritdoc />
        /// <summary>
        /// Gets a reference to writer's stream.
        /// </summary>
        /// <value>
        /// Writer's stream reference.
        /// </value>
        public Stream Stream { get; internal set; }
        #endregion

        #region [public] (TableModel) Table: Gets a reference to the current model table
        /// <inheritdoc />
        /// <summary>
        /// Gets a reference to the current model table.
        /// </summary>
        /// <value>
        /// Reference to the current model table.
        /// </value>
        public TableModel Table => DataModel.Data.Table;
        #endregion

        #region [public] (IAdapter) Adapter: Gets or sets a reference to adapter for export
        /// <inheritdoc />
        /// <summary>
        /// Gets or sets a reference to adapter for export.
        /// </summary>
        /// <value>
        /// Reference to adpter to export.
        /// </value>
        public IAdapter Adapter { get; set; }
        #endregion

        #region [public] (string) TransformFileExtension: Gets the transform file extension
        /// <inheritdoc />
        /// <summary>
        /// Gets the transform file extension.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String" /> that contains the transform file extension.
        /// </value>
        public string TransformFileExtension => TransformFileExtensionConst;
        #endregion

        #endregion
        
        #region public virtual properties

        #region [public] {virtual} (HttpResponseInfo) ResponseInfo: Gets a reference to an object HttpResponseInfo than contains the MIME type of the output stream and response header for a ASP.NET operation
        /// <inheritdoc />
        /// <summary>
        /// Gets a reference to an object <see cref="T:iTin.Export.Web.HttpResponseInfo" /> than contains the <strong>MIME</strong> type of the output stream and response header for a <strong>ASP.NET</strong> operation.
        /// </summary>
        /// <value>
        /// A <see cref="T:iTin.Export.Web.HttpResponseInfo" /> than contains the <strong>MIME</strong> type of the output stream and response header for a <strong>ASP.NET</strong> operation.
        /// </value>
        public virtual HttpResponseInfo ResponseInfo
        {
            get
            {
                var filename = Adapter.DataModel.Data.Table.Output.File;

                var headerBuilder = new StringBuilder();
                headerBuilder.Append("attachment; filename=");
                headerBuilder.Append(
                    Result.Count > 1
                        ? Path.ChangeExtension(filename, "zip")
                        : Path.ChangeExtension(filename, ExtendedInformation.Extension));

                return new HttpResponseInfo
                {
                    ContentType = HttpResponseInfo.GetMimeMapping(ExtendedInformation.Extension),
                    Header = headerBuilder.ToString()
                };
            }
        }
        #endregion

        #region [public] {virtual} (bool) IsTransformationFile: Gets a value indicating whether this writer generates a transformation file to be processed later
        /// <inheritdoc />
        /// <summary>
        /// Gets a value indicating whether this writer generates a transformation file to be processed later.
        /// </summary>
        /// <value>
        /// <strong>true</strong> if generated transform file; otherwise, <strong>false</strong>.
        /// </value>
        public virtual bool IsTransformationFile => false;
        #endregion

        #endregion

        #region public abstract properties

        #region [public] {abstract} (KnownWriterIdentifier) WriterIdentifier: Gets a value than identifies the type of writer
        /// <inheritdoc />
        /// <summary>
        /// Gets a value than identifies the type of writer.
        /// </summary>
        /// <value>
        /// One of the <see cref="T:iTin.Export.ComponentModel.KnownWriterIdentifier" /> values which identifies the writer type.
        /// </value>
        public abstract KnownWriterIdentifier WriterIdentifier { get; }
        #endregion

        #endregion

        #region protected properties

        #region [protected] (Collection<byte[]>) Result: Gets enumerable of byte array containing data info
        /// <summary>
        /// Gets enumerable of byte array containing data info.
        /// </summary>
        /// <value>
        /// Result of export.
        /// </value>
        protected Collection<byte[]> Result => _result;
        #endregion

        #endregion

        #region public static properties

        /// <summary>
        /// Gets the get current date time.
        /// </summary>
        /// <value>
        /// The get current date time.
        /// </value>
        public static DateTime GetCurrentDatetime => DateTime.Now;

        /// <summary>
        /// Gets the get timespan.
        /// </summary>
        /// <value>
        /// The get timespan.
        /// </value>
        public static TimeSpan GetCurrentTimeSpan => DateTime.Now.TimeOfDay;

        #endregion

        #region public methods

        #region [public] (void) Dispose(): Implement IDisposable. Clean managed and unmanaged resources
        /// <inheritdoc />
        /// <summary>
        /// Implement IDisposable. Clean managed and unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
                            
            // Take this object off the finalization queue
            // and prevent finalization code for this object
            // from executing a second time.
            GC.SuppressFinalize(this);
        }
        #endregion

        #region [public] (void) Generate(ExportSettings): Generates writer output
        /// <inheritdoc />
        /// <summary>
        /// Generates writer output.
        /// </summary>
        /// <param name="settings">Export settings.</param>
        public void Generate(ExportSettings settings)
        {
            if (!Table.HasFields)
            {
                return;
            }

            Result.Clear();
            Execute();
            CleanOrCreateTemporaryDirectory();
            GenerateTemporaryOutputFiles();
            CopyResultsToOutputDirectory();
            ProcessTransformFileBehavior();
            Adapter.DataModel.Data.Table.Exporter.Behaviors.Execute(this, settings);
        }
        #endregion

        #endregion

        #region public virtual methods

        #region [public] {virtual} (IEnumerable<byte[]>) GetAsByteArrayEnumerable(): Returns the result file as a enumeration of byte array
        /// <inheritdoc />
        /// <summary>
        /// Returns the writer result file as a enumeration of byte array
        /// </summary>
        /// <returns>
        /// A enumeration of array of bytes than contains the writer result file content.
        /// </returns>
        public virtual IEnumerable<byte[]> GetAsByteArrayEnumerable()
        {
            return Result;
        }
        #endregion

        #endregion

        #region protected abstract methods

        #region [protected] {abstract} (void) Execute(): Generates output in the format supported by each specialized class
        /// <summary>
        /// Generates output in the format supported by each specialized class.
        /// </summary>
        protected abstract void Execute();
    #endregion

        #endregion

        #region Protected Virtual Methods

        #region [protected] {virtual} (object) GetValueByReflection(string):
        /// <summary>
        /// Gets the value by reflection.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// A <see cref="T:System.String"/> that contains property, method or raw value.
        /// </returns>
        protected virtual object GetValueByReflection(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return string.Empty;
            }

            var isValidStaticResource = RegularExpressionHelper.IsValidStaticResource(value);
            if (!isValidStaticResource)
            {
                return value;
            }

            var assemblies = new List<Assembly> { GetType().Assembly };
            var references = DataModel.References;
            foreach (var reference in references)
            {
                var assemblyName = reference.Assembly.ToUpperInvariant();
                var hasExtension = assemblyName.EndsWith(".DLL");
                if (!hasExtension)
                {
                    assemblyName = string.Concat(assemblyName, ".DLL");
                }

                var assemblyRelativePath = reference.Path;
                var qualifiedAssemblyPath = string.Concat(assemblyRelativePath, assemblyName);
                var qualifiedAssemblyPathParsed = DataModel.Data.ParseRelativeFilePath(qualifiedAssemblyPath);
                var assembly = Assembly.LoadFile(qualifiedAssemblyPathParsed);
                assemblies.Add(assembly);
            }

            object returnValue;
            var targetValue = value.Replace("{", string.Empty).Replace("}", string.Empty).Trim();
            var bindParts = targetValue.Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
            var qualifiedFunctionName = bindParts[1].Trim();

            string functionName;
            var classType = GetType();
            var qualifiedFunctionParts = qualifiedFunctionName.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            if (qualifiedFunctionParts.Count() == 1)
            {
                functionName = qualifiedFunctionParts[0].Trim();
            }
            else
            {
                var className = qualifiedFunctionParts[0].Trim();
                functionName = qualifiedFunctionParts[1].Trim();
                var casm = assemblies.Count == 1 ? assemblies.First() : assemblies.Last();
                var assemblyTypes = casm.GetExportedTypes();
                classType = assemblyTypes.FirstOrDefault(cls => cls.Name == className);
            }

            var instanceMethodInfo = classType.GetMethod(functionName, BindingFlags.Public | BindingFlags.Instance);
            if (instanceMethodInfo != null)
            {
                returnValue = instanceMethodInfo.Invoke(this, null);
            }
            else
            {
                var staticMethodInfo = classType.GetMethod(functionName, BindingFlags.Public | BindingFlags.Static);
                if (staticMethodInfo != null)
                {
                    returnValue = staticMethodInfo.Invoke(null, null);
                }
                else
                {
                    var instancePropertyInfo = classType.GetProperty(functionName, BindingFlags.Public | BindingFlags.GetProperty | BindingFlags.Instance);
                    if (instancePropertyInfo != null)
                    {
                        var instancePropertyGetMethod = instancePropertyInfo.GetGetMethod(true);
                        returnValue = instancePropertyGetMethod.Invoke(this, null);
                    }
                    else
                    {
                        var staticPropertyInfo = classType.GetProperty(functionName, BindingFlags.Public | BindingFlags.GetProperty | BindingFlags.Static | BindingFlags.FlattenHierarchy);
                        var staticPropertyGetMethod = staticPropertyInfo.GetGetMethod(true);
                        returnValue = staticPropertyGetMethod.Invoke(null, null);
                    }
                }
            }

            return returnValue; //.ToString();
        }
        #endregion

        #region [protected] {virtual} (void) ReleaseManagedResources(): Releasing managed resources
        /// <summary>
        /// Releasing managed resources.
        /// </summary>
        protected virtual void ReleaseManagedResources()
        {
            if (Stream != null)
            {
                Stream.Dispose();
            }

            DeleteTemporaryOutputFiles();
        }    
        #endregion

        #region [protected] {virtual} (void) ReleaseUnmanagedResources(): Releasing unmanaged resources
        /// <summary>
        /// Releasing unmanaged resources.
        /// </summary>
        protected virtual void ReleaseUnmanagedResources()
        {
        }
        #endregion

        #endregion

        #region private static methods

        #region [private] {static} (void) CleanOrCreateTemporaryDirectory(): Clean or create temporary work directory and returns it
        /// <summary>
        /// Clean or create temporary work directory and returns it.
        /// </summary>
        private static void CleanOrCreateTemporaryDirectory()
        {
            var tempDirectory = FileHelper.TinExportTempDirectory;
            var existTempDirectory = Directory.Exists(tempDirectory);
            if (existTempDirectory)
            {
                try
                {
                    Array.ForEach(Directory.GetFiles(tempDirectory), File.Delete);
                }
                catch (IOException)
                {
                }
            }
            else
            {
                Directory.CreateDirectory(tempDirectory);
            }
        }
        #endregion

        #region [private] {static} (void) DeleteTemporaryOutputFiles(): Removes the directory and intermediates files
        /// <summary>
        /// Removes the directory and intermediates files.
        /// </summary>
        private static void DeleteTemporaryOutputFiles()
        {
            var tempDirectory = FileHelper.TinExportTempDirectory;

            var existTempDirectory = Directory.Exists(tempDirectory);
            if (!existTempDirectory)
            {
                return;
            }

            try
            {
                Array.ForEach(Directory.GetFiles(tempDirectory), File.Delete);
                Directory.Delete(tempDirectory);                    
            }
            catch (IOException)
            {
            }
        }
        #endregion

        #endregion

        #region private methods

        #region [private] (void) CopyResultsToOutputDirectory(): Copies the results to output directory
        /// <summary>
        /// Copies the results to output directory.
        /// </summary>
        private void CopyResultsToOutputDirectory()
        {
            var root = Adapter.DataModel.Data;
            var outputFullPath = root.ParseRelativeFilePath(KnownRelativeFilePath.Output);
            var outputDirectory = Path.GetDirectoryName(outputFullPath);

            var searchPattern = string.Format(CultureInfo.InvariantCulture, "*.{0}", ExtendedInformation.Extension);
            FileHelper.CopyFiles(FileHelper.TinExportTempDirectory, outputDirectory, searchPattern, true);
        }
        #endregion

        #region [private] (void) Dispose(bool): Releasing managed and unmanaged resources
        /// <summary>
        /// Releasing managed and unmanaged resources.
        /// </summary>
        /// <param name="disposing">
        ///   <strong>true</strong> to release both managed and unmanaged resources; 
        ///   <strong>false</strong> to release only unmanaged resources.
        /// </param>
        /// <remarks>
        ///   <para>
        ///     If disposing equals <strong>true</strong>, the method has been called directly
        ///     or indirectly by a user's code. Managed and unmanaged resources
        ///     can be disposed.
        ///   </para>
        ///   <para>
        ///     If disposing equals <strong>false</strong>, the method has been called by the
        ///     runtime from inside the finalize and you should not reference
        ///     other objects. Only unmanaged resources can be disposed.
        ///   </para>
        /// </remarks>
        private void Dispose(bool disposing)
        {
            // Check to see if Dispose has already been called.
            if (_disposed)
            {
                return;
            }

            // If disposing equals true, dispose all managed and unmanaged resources.
            if (disposing)
            {
                // Dispose managed resources.
                ReleaseManagedResources();
            }

            // Call the appropriate methods to clean up unmanaged resources here.
            // If disposing is false, only the following code is executed.
            ReleaseUnmanagedResources();

            // Note disposing has been done.
            _disposed = true;
        }
        #endregion

        #region [private] (void) GenerateTemporaryOutputFiles(): Generates temporary output files
        /// <summary>
        /// Generates temporary output files.
        /// </summary>
        /// <exception cref="System.InvalidOperationException">If can't create writer file.</exception>
        private void GenerateTemporaryOutputFiles()
        {                
            var outputFullPath = Adapter.DataModel.Data.ParseRelativeFilePath(KnownRelativeFilePath.Output);
            var outputFileName = Path.GetFileName(outputFullPath);

            var isTransformationFile = IsTransformationFile;
            var writerOutputFilename = Path.ChangeExtension(outputFileName, isTransformationFile ? TransformFileExtension : ExtendedInformation.Extension);

            var exportTempDirectory = FileHelper.TinExportTempDirectory;
            var baseFilenameFullPath = Path.Combine(exportTempDirectory, writerOutputFilename);
            var filenameBuilder = new StringBuilder(baseFilenameFullPath);

            var current = 0;
            var items = GetAsByteArrayEnumerable().ToList();
            var itemsCount = items.Count();
            foreach (var item in items)
            {
                if (itemsCount > 1)
                {
                    var elementInfo = new FileInfo(baseFilenameFullPath);
                    var elementWithoutExtension = elementInfo.Name;
                    if (!string.IsNullOrEmpty(elementInfo.Extension))
                    {
                        elementWithoutExtension = elementInfo.Name.Replace(elementInfo.Extension, string.Empty);
                    }

                    filenameBuilder.Clear();
                    filenameBuilder.Append(elementInfo.DirectoryName);
                    filenameBuilder.Append(Path.DirectorySeparatorChar);
                    filenameBuilder.Append(elementWithoutExtension);
                    filenameBuilder.Append(current);
                    filenameBuilder.Append(".");
                    filenameBuilder.Append(ExtendedInformation.Extension);
                }

                item.SaveToFile(filenameBuilder.ToString());
                current++;
            }

            if (!isTransformationFile)
            {
                return;
            }

            var resultFilename = Path.ChangeExtension(outputFileName, ExtendedInformation.Extension);
            var resultFilenameFullPath = Path.Combine(exportTempDirectory, resultFilename);

            var tempSettings = new ExportSettings
            {
                OutputFile = new Uri(resultFilenameFullPath),
                TransformFile = new Uri(baseFilenameFullPath)
            };

            try
            {
                Adapter.CreateInputXml();
                Adapter.InputUri.Transform(tempSettings);
            }
            catch (IOException)
            {
                throw new InvalidOperationException(Resources.ErrorMessage.TransformOperationError);
            }
        }
        #endregion

        #region [private] (void) ProcessTransformFileBehavior(): Processes the transform file behavior
        /// <summary>
        /// Processes the transform file behavior.
        /// </summary>
        private void ProcessTransformFileBehavior()
        {
            var transformBehavior = Adapter.DataModel.Data.Table.Exporter.Behaviors.Get<TransformFileBehaviorModel>();
            if (transformBehavior != null)
            {
                transformBehavior.Execute(this);
            }
        }
        #endregion

        #endregion
    }
}
