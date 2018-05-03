
namespace iTin.Export.Model
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Globalization;
    using System.IO;
    using System.Text;
    using System.Web;
    using System.Xml.Serialization;

    using ComponentModel.Writer;
    using Helpers;

    /// <inheritdoc />
    /// <summary>
    /// A Specialization of <see cref="T:iTin.Export.Model.BaseBehaviorModel" /> class.<br />
    /// Which represents download behavior. Applies only in web mode.
    /// </summary>
    /// <remarks>
    /// <para>Belongs to: <strong><c>Behaviors</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.BehaviorsModel" />.<br />
    /// <code lang="xml" title="ITEE Object Element Usage">
    /// &lt;Download .../&gt;
    /// </code>
    /// </para>
    /// <para><strong>Attributes</strong></para>
    /// <table>
    ///   <thead>
    ///     <tr>
    ///       <th>Attribute</th>
    ///       <th>Optional</th>
    ///       <th>Description</th>
    ///       </tr>
    ///   </thead>
    ///   <tbody>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.BaseBehaviorModel.CanExecute" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Determines whether executes behavior. The default is <see cref="F:iTin.Export.Model.YesNo.Yes" />.</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.DownloadBehaviorModel.LocalCopy" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Determines whether saves local copy. The default is <see cref="F:iTin.Export.Model.YesNo.No" />.</td>
    ///     </tr>
    ///   </tbody>
    /// </table>
    /// <para>
    /// <para><strong>Compatibility table with native writers.</strong></para>
    /// <table>
    ///   <thead>
    ///     <tr>
    ///       <th>Comma-Separated Values<br /><see cref="T:iTin.Export.Writers.Native.CsvWriter" /></th>
    ///       <th>Tab-Separated Values<br /><see cref="T:iTin.Export.Writers.Native.TsvWriter" /></th>
    ///       <th>SQL Script<br /><see cref="T:iTin.Export.Writers.Native.SqlScriptWriter" /></th>
    ///       <th>XML Spreadsheet 2003<br /><see cref="T:iTin.Export.Writers.Native.Spreadsheet2003TabularWriter" /></th>
    ///     </tr>
    ///   </thead>
    ///   <tbody>
    ///     <tr>
    ///       <td align="center">X</td>
    ///       <td align="center">X</td>
    ///       <td align="center">X</td>
    ///       <td align="center">X</td>
    ///     </tr>
    ///   </tbody>
    /// </table>
    /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
    /// </para>
    /// </remarks>
    /// <example>
    /// <code lang="xml">
    /// &lt;Behaviors&gt;
    ///   &lt;Downdload LocalCopy="Yes"/&gt;
    ///   &lt;TransformFile Save="No"/&gt;
    /// &lt;/Behaviors&gt;
    /// </code>
    /// </example>
    public partial class DownloadBehaviorModel
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo DefaultLocalCopy = YesNo.No;
        #endregion
        
        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private YesNo _localCopy;
        #endregion

        #region constructor/s

        #region [public] DownloadBehaviorModel(): Initializes a new instance of this class
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.DownloadBehaviorModel" /> class.
        /// </summary>
        public DownloadBehaviorModel()
        {
            LocalCopy = DefaultLocalCopy;
        }
        #endregion

        #endregion

        #region public static properties

        #region [public] {static} (DownloadBehaviorModel) Default: Gets a reference to default behavior
        /// <summary>
        /// Gets a reference to default behavior.
        /// </summary>
        /// <value>
        /// Default behavior.
        /// </value>
        public static DownloadBehaviorModel Default => new DownloadBehaviorModel();
        #endregion

        #endregion

        #region public properties

        #region [public] (YesNo) LocalCopy: Gets or sets a value indicating whether saves local copy of this export
        /// <summary>
        /// Gets or sets a value indicating whether saves local copy of this export.
        /// </summary>
        /// <value>
        /// <see cref="iTin.Export.Model.YesNo.Yes" /> if saves local copy; otherwise <see cref="iTin.Export.Model.YesNo.No" />. The default is <see cref="iTin.Export.Model.YesNo.No" />.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Download LocalCopy="Yes|No" .../&gt;
        /// </code>
        /// <para>
        /// <para><strong>Compatibility table with native writers.</strong></para>
        /// <table>
        ///   <thead>
        ///     <tr>
        ///       <th>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.CsvWriter" /></th>
        ///       <th>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.TsvWriter" /></th>
        ///       <th>SQL Script<br/><see cref="T:iTin.Export.Writers.Native.SqlScriptWriter" /></th>
        ///       <th>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Native.Spreadsheet2003TabularWriter" /></th>
        ///     </tr>
        ///   </thead>
        ///   <tbody>
        ///     <tr>
        ///       <td align="center">X</td>
        ///       <td align="center">X</td>
        ///       <td align="center">X</td>
        ///       <td align="center">X</td>
        ///     </tr>
        ///   </tbody>
        /// </table>
        /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
        /// </para>
        /// </remarks>
        /// <example>
        /// <code lang="xml">
        /// &lt;Behaviors&gt;
        ///   &lt;Downdload LocalCopy="Yes"/&gt;
        ///   &lt;TransformFile Save="No"/&gt;
        /// &lt;/Behaviors&gt;
        /// </code>
        /// </example>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>
        [XmlAttribute]
        [DefaultValue(DefaultLocalCopy)]
        public YesNo LocalCopy
        {
            get => _localCopy;
            set
            {
                SentinelHelper.IsEnumValid(value);

                _localCopy = value;
            }
        }
        #endregion

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default
        /// <inheritdoc />
        /// <include file="..\..\iTin.Export.Documentation.Common.xml" path="Common/Model/Public/Overrides/Properties/Property[@name='IsDefault']/*" />
        public override bool IsDefault => base.IsDefault && LocalCopy.Equals(DefaultLocalCopy);
        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (void) ExecuteBehavior(IWriter, ExportSettings): Code for execute download behavior
        /// <inheritdoc />
        /// <summary>
        /// Code for execute download behavior.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="settings">Exporter settings.</param>
        protected override void ExecuteBehavior(IWriter writer, ExportSettings settings)
        {
            if (settings == null)
            {
                return;
            }

            var response = HttpContext.Current?.Response;
            if (response == null)
            {
                return;
            }

            var filename = writer.ResponseEx.ExtractFileName();
            if (LocalCopy == YesNo.No)
            {
                var root = writer.Provider.Input.Model;
                var outputFullPath = root.ParseRelativeFilePath(KnownRelativeFilePath.Output);
                var outputDirectory = Path.GetDirectoryName(outputFullPath);

                var filenameWithoutExtension = Path.GetFileNameWithoutExtension(filename);
                var files = Directory.GetFiles(outputDirectory, $"{filenameWithoutExtension}.*");
                foreach (var file in files)
                {
                    File.Delete(file);
                }
            }

            var filenameBuilder = new StringBuilder();
            filenameBuilder.Append(FileHelper.TinExportTempDirectory);
            filenameBuilder.Append(Path.DirectorySeparatorChar);
            filenameBuilder.Append(filename);

            var downloadFile = filenameBuilder.ToString();
            var existDownloadFile = File.Exists(downloadFile);
            if (!existDownloadFile)
            {
                downloadFile = CreateZipFile(writer);
            }

            DownloadFile(writer, response, StreamHelper.AsByteArrayFromFile(downloadFile));                
        }
        #endregion

        #endregion

        #region private static methods

        #region [private] {static} (string) CreateZipFile(IWriter): Creates zip file
        /// <summary>
        /// Creates zip file.
        /// </summary>
        /// <param name="writer">Writer reference.</param>
        /// <returns>
        /// Returns zip filename.
        /// </returns>
        private static string CreateZipFile(IWriter writer)
        {
            var exporterType = writer.Provider.Input.Model.Table.Exporter.ExporterType;
            if (exporterType != KnownExporter.Template)
            {
                if (!writer.IsTransformationFile)
                {
                    return string.Empty;
                }
            }

            var files = new Dictionary<string, byte[]>();
            var tempDirectory = FileHelper.TinExportTempDirectory;

            var extension = writer.IsTransformationFile ? "*" : writer.WriterMetadata.Extension;
            var pattern = string.Format(CultureInfo.InvariantCulture, "*.{0}", extension);
            var items = Directory.GetFiles(tempDirectory, pattern, SearchOption.TopDirectoryOnly);
            foreach (var item in items)
            {
                var filename = Path.GetFileName(item);
                files.Add(filename, StreamHelper.AsByteArrayFromFile(item));
            }

            return files.ToZip(writer);
        }
        #endregion

        #region [private] {static} (void) DownloadFile(IWriter, HttpResponse, byte[]): Downloads the specified data
        /// <summary>
        /// Downloads the specified data.
        /// </summary>
        /// <param name="writer">Writer reference.</param>
        /// <param name="response">Http response.</param>
        /// <param name="data">Data to download.</param>
        private static void DownloadFile(IWriter writer, HttpResponse response, byte[] data)
        {
            var info = writer.ResponseEx;
            response.Clear();
            response.ContentType = info.ContentType;
            response.AddHeader("content-disposition", info.ContentDisposition);
            response.BinaryWrite(data);
            response.Flush();
            response.End();
        }
        #endregion

        #endregion
    }
}
