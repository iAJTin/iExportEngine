
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace iTin.Export.ComponentModel.Writer
{
    using AspNet.ComponentModel;
    using Helpers;
    using Model;
    using Provider;

    /// <inheritdoc />
    /// <summary>
    /// Implements interface <see cref="T:iTin.Export.ComponentModel.IWriter" />.
    /// Which acts as the base class for future writers based and not based on markup languages​​.
    /// </summary>
    public abstract class BaseWriter : IWriter
    {
        #region protected constants

        /// <summary>
        /// Preferred alternate style name sufix.
        /// </summary>
        protected const string AlternateStyleNameSufix = "_Alternate";

        #endregion

        #region private constants

        private const string TransformFileExtensionConst = "xslt";

        #endregion

        #region private field members

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly Collection<byte[]> _result;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly WriterOptionsMetadata _optionsMetadataInformation;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool _disposed;

        #endregion

        #region constructor/s

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseWriter" /> class.
        /// </summary>
        protected BaseWriter()
        {
            _result = new Collection<byte[]>();
            _optionsMetadataInformation = new WriterOptionsMetadata(this);
        }

        #endregion

        #region public properties

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets a reference to provider for export.
        /// </summary>
        /// <value>
        /// Reference to provider to export.
        /// </value>
        public IProvider Provider { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets a reference to writer's stream.
        /// </summary>
        /// <value>
        /// Writer's stream reference.
        /// </value>
        public Stream Stream { get; internal set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets the transform file extension.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String" /> that contains the transform file extension.
        /// </value>
        public string TransformFileExtension => TransformFileExtensionConst;

        /// <inheritdoc />
        /// <summary>
        /// Gets a reference that contains the extended information about this writer.
        /// </summary>
        /// <value>
        /// A <see cref="T:iTin.Export.ComponentModel.Writer.WriterOptionsMetadata" /> that contains the extended information about this writer.
        /// </value>
        public WriterOptionsMetadata WriterMetadata => _optionsMetadataInformation;

        #endregion

        #region public virtual properties

        /// <inheritdoc />
        /// <summary>
        /// Gets a reference to an object <see cref="T:iTin.Export.AspNet.ComponentModel.HttpResponseEx" /> than contains the <strong>MIME</strong> type of the output stream and response header for a <strong>ASP.NET</strong> operation.
        /// </summary>
        /// <value>
        /// A <see cref="T:iTin.Export.Web.HttpResponseInfo" /> than contains the <strong>MIME</strong> type of the output stream and response header for a <strong>ASP.NET</strong> operation.
        /// </value>
        public virtual HttpResponseEx ResponseEx
        {
            get
            {
                var filename = Provider.Input.Model.Table.Output.File;

                var headerBuilder = new StringBuilder();
                headerBuilder.Append("attachment; filename=");
                headerBuilder.Append(
                    Result.Count > 1
                        ? Path.ChangeExtension(filename, "zip")
                        : Path.ChangeExtension(filename, WriterMetadata.Extension));

                return new HttpResponseEx
                {
                    ContentType = HttpResponseEx.GetMimeMapping(WriterMetadata.Extension),
                    ContentDisposition = headerBuilder.ToString()
                };
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets a value indicating whether this writer generates a transformation file to be processed later.
        /// </summary>
        /// <value>
        /// <strong>true</strong> if generated transform file; otherwise, <strong>false</strong>.
        /// </value>
        public virtual bool IsTransformationFile => false;

        #endregion

        #region public abstract properties

        /// <inheritdoc />
        /// <summary>
        /// Gets a value than identifies the type of writer.
        /// </summary>
        /// <value>
        /// One of the <see cref="T:iTin.Export.ComponentModel.Writer.KnownWriterIdentifier" /> values which identifies the writer type.
        /// </value>
        public abstract KnownWriterIdentifier WriterIdentifier { get; }

        #endregion

        #region protected properties

        /// <summary>
        /// Gets enumerable of byte array containing data info.
        /// </summary>
        /// <value>
        /// Result of export.
        /// </value>
        protected Collection<byte[]> Result => _result;

        #endregion

        #region public methods

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

        /// <inheritdoc />
        /// <summary>
        /// Generates writer output.
        /// </summary>
        /// <param name="settings">Export settings.</param>
        public void Generate(ExportSettings settings)
        {
            var currentExporterType = Provider.Input.Model.Table.Exporter.ExporterType;
            if (currentExporterType != KnownExporter.Template)
            {
                var hasFields = Provider.Input.Model.Table.HasFields;
                if (!hasFields)
                {
                    return;
                }
            }

            ModelService.Instance.SetWriter(this);

            Result.Clear();
            Execute();
            CleanOrCreateTemporaryDirectory();
            GenerateTemporaryOutputFiles();
            CopyResultsToOutputDirectory();
            ProcessTransformFileBehavior();
            Provider.Input.Model.Table.Exporter.Behaviors.Execute(this, settings);
        }

        #endregion

        #region public virtual methods

        /// <inheritdoc />
        /// <summary>
        /// Returns the writer result file as a enumeration of byte array
        /// </summary>
        /// <returns>
        /// A enumeration of array of bytes than contains the writer result file content.
        /// </returns>
        public virtual IEnumerable<byte[]> GetAsByteArrayEnumerable() => Result;

        #endregion

        #region protected abstract methods

        /// <summary>
        /// Generates output in the format supported by each specialized class.
        /// </summary>
        protected abstract void Execute();

        #endregion

        #region protected virtual methods

        /// <summary>
        /// Releasing managed resources.
        /// </summary>
        protected virtual void ReleaseManagedResources()
        {
            Stream?.Dispose();

            DeleteTemporaryOutputFiles();
        }    

        /// <summary>
        /// Releasing unmanaged resources.
        /// </summary>
        protected virtual void ReleaseUnmanagedResources()
        {
        }

        #endregion

        #region private static methods

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

        #region private methods

        /// <summary>
        /// Copies the results to output directory.
        /// </summary>
        private void CopyResultsToOutputDirectory()
        {
            var root = Provider.Input.Model;
            var outputFullPath = root.ResolveRelativePath(KnownRelativeFilePath.Output);
            var outputDirectory = Path.GetDirectoryName(outputFullPath);

            var tryCreateDirectory = root.Table.Output.Create;
            if (tryCreateDirectory == YesNo.Yes)
            {
                var exist = Directory.Exists(outputDirectory);
                if (!exist)
                {
                    Directory.CreateDirectory(outputDirectory);
                }
            }
            
            var searchPattern = $"*.{WriterMetadata.Extension}";
            FileHelper.CopyFiles(FileHelper.TinExportTempDirectory, outputDirectory, searchPattern, true);
        }

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

        /// <summary>
        /// Generates temporary output files.
        /// </summary>
        /// <exception cref="System.InvalidOperationException">If can't create writer file.</exception>
        private void GenerateTemporaryOutputFiles()
        {                
            var outputFullPath = Provider.Input.Model.ResolveRelativePath(KnownRelativeFilePath.Output);
            var outputFileName = Path.GetFileName(outputFullPath);

            var isTransformationFile = IsTransformationFile;
            var writerOutputFilename = Path.ChangeExtension(outputFileName, isTransformationFile ? TransformFileExtension : WriterMetadata.Extension);

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
                    filenameBuilder.Append(WriterMetadata.Extension);
                }

                item.SaveToFile(filenameBuilder.ToString());
                current++;
            }

            if (!isTransformationFile)
            {
                return;
            }

            var resultFilename = Path.ChangeExtension(outputFileName, WriterMetadata.Extension);
            var resultFilenameFullPath = Path.Combine(exportTempDirectory, resultFilename);

            var tempSettings = new ExportSettings
            {
                OutputFile = new Uri(resultFilenameFullPath),
                TransformFile = new Uri(baseFilenameFullPath)
            };

            try
            {
                Provider.CreateInputXml();
                Provider.InputUri.Transform(tempSettings);
            }
            catch (IOException)
            {
                throw new InvalidOperationException(Resources.ErrorMessage.TransformOperationError);
            }
        }

        /// <summary>
        /// Processes the transform file behavior.
        /// </summary>
        private void ProcessTransformFileBehavior()
        {
            var transformBehavior = Provider.Input.Model.Table.Exporter.Behaviors.Get<TransformFileBehaviorModel>();
            transformBehavior?.Execute(this);
        }

        #endregion
    }
}

//#region [protected] {virtual} (object) GetStaticValue(string):
///// <summary>
///// Gets the static value by reflection.
///// </summary>
///// <param name="value">The value.</param>
///// <returns>
///// A <see cref="T:System.String"/> that contains property, method or raw value.
///// </returns>
//protected virtual object GetStaticValue(string value)
//{
//    if (string.IsNullOrEmpty(value))
//    {
//        return string.Empty;
//    }

//    var linked = RegularExpressionHelper.IsStaticBindingResource(value);
//    if (!linked)
//    {
//        return value;
//    }

//    var assemblies = new List<Assembly> { GetType().Assembly };
//    var references = Provider.Input.References;
//    foreach (var reference in references)
//    {
//        var assemblyName = reference.Assembly.ToUpperInvariant();
//        var hasExtension = assemblyName.EndsWith(".DLL");
//        if (!hasExtension)
//        {
//            assemblyName = string.Concat(assemblyName, ".DLL");
//        }

//        var assemblyRelativePath = reference.Path;
//        var qualifiedAssemblyPath = string.Concat(assemblyRelativePath, assemblyName);
//        var qualifiedAssemblyPathParsed = Provider.Input.Model.ParseRelativeFilePath(qualifiedAssemblyPath);
//        var assembly = Assembly.LoadFile(qualifiedAssemblyPathParsed);
//        assemblies.Add(assembly);
//    }

//    object returnValue;
//    var targetValue = value.Replace("{", string.Empty).Replace("}", string.Empty).Trim();
//    var bindParts = targetValue.Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
//    var qualifiedFunctionName = bindParts[1].Trim();

//    string functionName;
//    var classType = GetType();
//    var qualifiedFunctionParts = qualifiedFunctionName.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
//    if (qualifiedFunctionParts.Count() == 1)
//    {
//        functionName = qualifiedFunctionParts[0].Trim();
//    }
//    else
//    {
//        var className = qualifiedFunctionParts[0].Trim();
//        functionName = qualifiedFunctionParts[1].Trim();
//        var casm = assemblies.Count == 1 ? assemblies.First() : assemblies.Last();
//        var assemblyTypes = casm.GetExportedTypes();
//        classType = assemblyTypes.FirstOrDefault(cls => cls.Name == className);
//    }

//    var instanceMethodInfo = classType.GetMethod(functionName, BindingFlags.Public | BindingFlags.Instance);
//    if (instanceMethodInfo != null)
//    {
//        returnValue = instanceMethodInfo.Invoke(this, null);
//    }
//    else
//    {
//        var staticMethodInfo = classType.GetMethod(functionName, BindingFlags.Public | BindingFlags.Static);
//        if (staticMethodInfo != null)
//        {
//            returnValue = staticMethodInfo.Invoke(null, null);
//        }
//        else
//        {
//            var instancePropertyInfo = classType.GetProperty(functionName, BindingFlags.Public | BindingFlags.GetProperty | BindingFlags.Instance);
//            if (instancePropertyInfo != null)
//            {
//                var instancePropertyGetMethod = instancePropertyInfo.GetGetMethod(true);
//                returnValue = instancePropertyGetMethod.Invoke(this, null);
//            }
//            else
//            {
//                var staticPropertyInfo = classType.GetProperty(functionName, BindingFlags.Public | BindingFlags.GetProperty | BindingFlags.Static | BindingFlags.FlattenHierarchy);
//                var staticPropertyGetMethod = staticPropertyInfo.GetGetMethod(true);
//                returnValue = staticPropertyGetMethod.Invoke(null, null);
//            }
//        }
//    }

//    return returnValue; //.ToString();
//}
//#endregion
