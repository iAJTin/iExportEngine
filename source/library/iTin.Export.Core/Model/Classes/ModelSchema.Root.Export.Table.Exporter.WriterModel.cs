
namespace iTin.Export.Model
{
    using System.Diagnostics;
    using System.Xml.Serialization;

    using Helper;

    /// <summary>
    /// A Specialization of <see cref="T:iTin.Export.Model.WriterModelBase" /> class.<br/>
    /// Which acts as the base class for different writers.<br/>
    /// Represents an exporter based on a custom writer.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The following table shows different data fields.
    /// </para>
    /// <list type="table">
    ///   <listheader>
    ///     <term>Class</term>
    ///     <description>Description</description>
    ///   </listheader>
    ///   <item>
    ///     <term><see cref="T:iTin.Export.Model.TemplateWriterModel"/></term>
    ///     <description>Represents a template writer used by a exporter.</description>
    ///   </item>
    /// </list>
    /// <para>
    /// Belongs to: <strong><c>Exporter</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.ExporterModel" />.
    /// <code lang="xml" title="AEE Object Element Usage">
    /// &lt;Writer&gt;
    ///   &lt;Filter/&gt;
    /// &lt;/Writer&gt;
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
    ///       <td><see cref="P:iTin.Export.Model.WriterModel.Name" /></td>
    ///       <td align="center">No</td>
    ///       <td>Name of the writer. Select from the list or create your own and use it.</td>
    ///     </tr>
    ///   </tbody>
    /// </table>
    /// <para><strong>Elements</strong></para>
    /// <list type="table">
    ///   <listheader>
    ///     <term>Element</term>
    ///     <description>Description</description>
    ///   </listheader>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.WriterModelBase.Filter" /></term> 
    ///     <description>Reference to set of properties that allow you to specify a writer.</description>
    ///   </item>
    /// </list>
    /// </remarks>
    public partial class WriterModel 
    {
        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string name;
        #endregion

        #region public properties

        #region [public] (string) Name: Gets or sets the name of the writer.
        /// <summary>
        /// Gets or sets the name of the writer.
        /// </summary>
        /// <value>
        /// Name of the writer. Select from the list or create your own and use it.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="AEE Object Element Usage">
        /// &lt;Writer Name="string"&gt;
        /// ...
        /// &lt;/Writer&gt;
        /// </code>
        /// <para>The following table shows the different custom writers.</para>
        /// <list type="table">
        ///   <listheader>
        ///     <term>Writer</term>
        ///     <description>Description</description>
        ///   </listheader>
        ///   <item>
        ///     <term><see cref="T:iTin.Export.Writers.Native.CsvWriter" /></term>
        ///     <description>CSV (comma-delimited) (*.csv). In iTin.Export assembly</description>
        ///   </item>
        ///   <item>
        ///     <term><see cref="T:iTin.Export.Writers.Native.TsvWriter" /></term>
        ///     <description>Text (tab-delimited) (*.txt). In iTin.Export assembly</description>
        ///   </item>
        ///   <item>
        ///     <term><see cref="T:iTin.Export.Writers.Native.SqlScriptWriter" /></term>
        ///     <description>SQL Script (*.sql). In iTin.Export assembly</description>
        ///   </item>
        ///   <item>
        ///     <term><see cref="T:iTin.Export.Writers.Native.Spreadsheet2003TabularWriter" /></term>
        ///     <description>XML Spreadsheet 2003 (*.xml) in iTin.Export assembly</description>
        ///   </item>
        ///   <item>
        ///     <term>XlsTabularWriter</term>
        ///     <description>MS Excel Workbook (*.xls). Requires iTin.Export.Writers.Microsoft assembly</description>
        ///   </item>
        ///   <item>
        ///     <term>XlsxTabularWriter</term>
        ///     <description>MS Excel Workbook (*.xlsx). Requires iTin.Export.Writers.OpenXML assembly</description>
        ///   </item>
        ///   <item>
        ///     <term>DocxTabularWriter</term>
        ///     <description>MS Word Document (*.docx). Requires iTin.Export.Writers.OpenXML assembly</description>
        ///   </item>
        /// </list>
        /// <para>The following table shows the different template custom writers.</para>
        /// <list type="table">
        ///   <listheader>
        ///     <term>Template writer</term>
        ///     <description>Description</description>
        ///   </listheader>
        ///   <item>
        ///     <term>WordFreeTemplateWriter</term>
        ///     <description>MS Word Document (*.docx). Requires iTin.Export.Writers.OpenXML assembly.</description>
        ///   </item>
        /// </list>
        /// </remarks>
        /// <exception cref="System.ArgumentNullException">If <paramref name="value" /> is <strong>null</strong>.</exception>
        /// <exception cref="iTin.Export.Model.InvalidIdentifierNameException">If <paramref name="value" /> not is a valid identifier.</exception>
        [XmlAttribute]
        public string Name
        {
            get => name;
            set
            {
                SentinelHelper.ArgumentNull(value);
                SentinelHelper.IsFalse(RegularExpressionHelper.IsValidIdentifier(value), new InvalidIdentifierNameException(ErrorMessageHelper.ModelIdentifierNameErrorMessage("Writer", "Name", value)));

                name = value;
            }
        }
        #endregion

        #endregion
    }
}
