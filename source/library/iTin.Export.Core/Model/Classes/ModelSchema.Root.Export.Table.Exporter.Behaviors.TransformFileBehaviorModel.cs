
namespace iTin.Export.Model
{
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Globalization;
    using System.IO;
    using System.Xml.Serialization;

    using ComponentModel;
    using Helper;

    /// <inheritdoc />
    /// <summary>
    /// A Specialization of <see cref="T:iTin.Export.Model.BaseBehaviorModel" /> class.<br />
    /// Which represents a transform file behavior. If the writer that we are using generates a Xml transform file, 
    /// this element allows us to define their behavior. Allows indicate if you want save it, where and if Xml code generated will indented.
    /// </summary>
    /// <remarks>
    /// <para>Belongs to: <strong><c>Behaviors</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.BehaviorsModel" />.<br />
    /// <code lang="xml" title="ITEE Object Element Usage">
    /// &lt;TransformFile .../&gt;
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
    ///       <td><see cref="P:iTin.Export.Model.TransformFileBehaviorModel.Indented" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Determines whether transform the file is saved indented. The default is <see cref="F:iTin.Export.Model.YesNo.Yes" />.</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.TransformFileBehaviorModel.Save" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>If the writer has been designed to generate transform files, set this attribute to <see cref="F:iTin.Export.Model.YesNo.Yes" /> for get a copy of the file. The default is <see cref="F:iTin.Export.Model.YesNo.No" />.</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.TransformFileBehaviorModel.Path" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>
    ///       Sets the file path of transformation, if omitted used the same output element path. To specify a relative path use the character (~). The default is "<c>Default</c>". /&gt;.<br />
    ///       Applies only in desktop mode. 
    ///       </td>
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
    ///   &lt;TransformFile Execute="Yes" Indented="Yes" Save="Yes" Path="~\Output"/&gt;
    /// &lt;/Behaviors&gt;
    /// </code>
    /// </example>
    public partial class TransformFileBehaviorModel
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo DefaultSave = YesNo.No;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string DefaultPath = "Default";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo DefaultIndented = YesNo.Yes;
        #endregion
        
        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private YesNo _save;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _path;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private YesNo _indented;
        #endregion

        #region constructor/s

        #region [public] TransformFileBehaviorModel(): Initializes a new instance of this class
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.TransformFileBehaviorModel" /> class.
        /// </summary>
        public TransformFileBehaviorModel()
        {
            Save = DefaultSave;
            Path = DefaultPath;
            Indented = DefaultIndented;
        }
        #endregion

        #endregion

        #region public static properties

        #region [public] {static} (TransformFileBehaviorModel) Default: Gets a reference to default behavior
        /// <summary>
        /// Gets a reference to default behavior.
        /// </summary>
        /// <value>
        /// Default behavior.
        /// </value>
        public static TransformFileBehaviorModel Default => new TransformFileBehaviorModel();
        #endregion

        #endregion

        #region public properties

        #region [public] (YesNo) Indented: Gets or sets a value that determines whether transform file is saved indented
        /// <summary>
        /// Gets or sets a value that determines whether transform file is saved indented.
        /// </summary>
        /// <value>
        /// <see cref="iTin.Export.Model.YesNo.Yes" /> if transform the file is saved indented; otherwise <see cref="iTin.Export.Model.YesNo.No" />. The default is <see cref="iTin.Export.Model.YesNo.Yes" />.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;TransformFile Indented="Yes|No" .../&gt;
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
        ///   &lt;TransformFile Execute="Yes" Indented="Yes" Save="Yes" Path="~\Output"/&gt;
        /// &lt;/Behaviors&gt;
        /// </code>
        /// </example>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>
        [XmlAttribute]
        [DefaultValue(DefaultIndented)]
        public YesNo Indented
        {
            get => _indented;
            set
            {
                SentinelHelper.IsEnumValid(value);

                _indented = value;
            }
        }
        #endregion

        #region [public] (string) Path: Gets or sets the path of transformation file, applies only in desktop mode
        /// <summary>
        /// Gets or sets the path of transformation file, applies only in desktop mode.    
        /// </summary>
        /// <value>
        /// Path of transformation file, if omitted used the same output element path. To specify a relative path use the character (~). The default is "<c>Default</c>".
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;TransformFile Path="Default|string" .../&gt;
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
        ///   &lt;TransformFile Execute="Yes" Indented="Yes" Save="Yes" Path="~\Output"/&gt;
        /// &lt;/Behaviors&gt;
        /// </code>
        /// </example>
        /// <exception cref="T:System.ArgumentNullException">If <paramref name="value" /> is <strong>null</strong>.</exception>
        /// <exception cref="T:iTin.Export.Model.InvalidPathNameException">If <paramref name="value" /> is an invalid path.</exception>
        [XmlAttribute]
        [DefaultValue(DefaultPath)]
        public string Path
        {
            get => _path;
            set
            {
                SentinelHelper.ArgumentNull(value);
                SentinelHelper.IsFalse(RegularExpressionHelper.IsValidPath(value), new InvalidPathNameException(ErrorMessageHelper.ModelPathErrorMessage("Path", value)));

                _path = value;
            }
        }
        #endregion

        #region [public] (YesNo) Save: Gets or sets a value that determines whether to save the transform file
        /// <summary>
        /// Gets or sets a value that determines whether to save the transform file.
        /// If the writer has been designed to generate transform files, set this attribute to <see cref="iTin.Export.Model.YesNo.Yes" /> for get a copy of the file.
        /// </summary>
        /// <value>
        /// <see cref="iTin.Export.Model.YesNo.Yes" /> if save the transform file; otherwise <see cref="iTin.Export.Model.YesNo.No" />. The default is <see cref="iTin.Export.Model.YesNo.No" />.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;TransformFile Indented="Yes|No" .../&gt;
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
        ///   &lt;TransformFile Execute="Yes" Indented="Yes" Save="Yes" Path="~\Output"/&gt;
        /// &lt;/Behaviors&gt;
        /// </code>
        /// </example>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>
        [XmlAttribute]
        [DefaultValue(DefaultSave)]
        public YesNo Save
        {
            get => _save;
            set
            {
                SentinelHelper.IsEnumValid(value);

                _save = value;
            }
        }
        #endregion

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default
        /// <inheritdoc />
        /// <summary>
        /// Gets a value indicating whether this instance is default.
        /// </summary>
        /// <value>
        /// <strong>true</strong> if this instance contains the default; otherwise, <strong>false</strong>.
        /// </value>
        public override bool IsDefault => base.IsDefault &&
                                          Path.Equals(DefaultPath) &&
                                          Save.Equals(DefaultSave) &&
                                          Indented.Equals(DefaultIndented);
        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (void) ExecuteBehavior(IWriter, ExportSettings): Code for execute download behavior
        /// <summary>
        /// Code for execute download behavior.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="settings">Exporter settings.</param>
        protected override void ExecuteBehavior(IWriter writer, ExportSettings settings)
        {
            var isTransformFile = writer.IsTransformationFile;
            if (!isTransformFile)
            {
                return;
            }

            if (Save.Equals(YesNo.No))
            {
                return;
            }

            CopyToTransformOutputDirectory(writer);
        }
        #endregion

        #endregion

        #region private static methods

        #region [private] {static} (void) CopyToTransformOutputDirectory(IWriter): Copy transform file to specified destination
        /// <summary>
        /// Copy transform file to specified destination.
        /// </summary>
        /// <param name="writer">The writer.</param>
        private static void CopyToTransformOutputDirectory(IWriter writer)
        {
            var root = writer.Adapter.DataModel.Data;
            var outputDirectory = root.ParseRelativeFilePath(KnownRelativeFilePath.TransformFileBehaviorDir);
            
            var existOutputDirectory = Directory.Exists(outputDirectory);
            if (!existOutputDirectory)
            {
                Directory.CreateDirectory(outputDirectory);
            }

            var searchPattern = string.Format(CultureInfo.InvariantCulture, "*.{0}", writer.TransformFileExtension);
            FileHelper.CopyFiles(FileHelper.TinExportTempDirectory, outputDirectory, searchPattern, true);
        }
        #endregion

        #endregion
    }
}
