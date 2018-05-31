
namespace iTin.Export.Model
{
    using System.IO;
    using System.Text;

    using AspNet.Cloud;
    using AspNet.Cloud.Apis;
    using ComponentModel.Writer;
    using Helpers;

    /// <inheritdoc />
    /// <summary>
    /// A Specialization of <see cref="T:iTin.Export.Model.ToDropboxBehaviorModel" /> class.<br />
    /// Which represents a upload file behavior to Dropbox cloud service. Upload the result of export to Dropbox.
    /// </summary>
    /// <remarks>
    /// <para>Belongs to: <strong><c>Behaviors</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.BehaviorsModel" />.<br />
    /// <code lang="xml" title="ITEE Object Element Usage">
    /// &lt;ToDropbox/&gt;
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
    ///   &lt;ToDropbox/&gt;
    /// &lt;/Behaviors&gt;
    /// </code>
    /// </example>
    public partial class ToDropboxBehaviorModel
    {
        #region protected override methods

        #region [protected] {override} (void) ExecuteBehavior(IWriter, ExportSettings): Code for execute download behavior
        /// <summary>
        /// Code for execute download behavior.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="settings">Exporter settings.</param>
        protected override void ExecuteBehavior(IWriter writer, ExportSettings settings)
        {
            var filenameBuilder1 = new StringBuilder();
            filenameBuilder1.Append(FileHelper.TinExportTempDirectory);
            filenameBuilder1.Append(Path.DirectorySeparatorChar);
            filenameBuilder1.Append(writer.ResponseEx.ExtractFileName());

            var dropbox = DropboxRestApi.ClientFrom(AuthenticateMode.Desktop);
            dropbox.UploadFile("dropbox", writer.ResponseEx.ExtractFileName(), filenameBuilder1.ToString());
        }
        #endregion

        #endregion
    }
}
