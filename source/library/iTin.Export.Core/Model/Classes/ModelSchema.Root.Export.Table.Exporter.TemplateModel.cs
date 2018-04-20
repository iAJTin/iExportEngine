
namespace iTin.Export.Model
{
    using System.Diagnostics;

    using Helper;

    /// <summary>
    /// Represents an exporter based on a template file.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Belongs to: <strong><c>Exporter</c></strong>. For more information, please see <see cref="iTin.Export.Model.ExporterModel" />.
    /// <code lang="xml" title="ITEE Object Element Usage">
    /// &lt;Template&gt;
    ///   &lt;File/&gt;
    ///   &lt;Writer/&gt;
    /// &lt;/Template&gt;
    /// </code>
    /// </para>    
    /// <para><strong>Elements</strong></para>
    /// <list type="table">
    ///   <listheader>
    ///     <term>Element</term>
    ///     <description>Description</description>
    ///   </listheader>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.TemplateModel.File" /></term> 
    ///     <description>The template file name.</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.TemplateModel.Writer" /></term> 
    ///     <description>The template writer used by the exporter.</description>
    ///   </item>
    /// </list>
    /// </remarks>
    public partial class TemplateModel 
    {               
        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string file;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TemplateWriterModel writer;
        #endregion
     
        #region public properties

        #region [public] (string) File: Gets or sets template file name. To specify a relative path use the character (~)
        /// <summary>
        /// Gets or sets template file name. To specify a relative path use the character (~).
        /// </summary>
        /// <value>
        /// The template file name. To specify a relative path use the character (~).
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Template&gt;
        ///   &lt;File&gt;string&lt;/Path&gt;
        /// &lt;/Template&gt;
        /// </code>
        /// </remarks>
        /// <example>
        /// The following example shows how to use this element.
        /// <code lang="xml">
        /// &lt;?xml version="1.0" encoding="utf-8"?&gt;
        /// 
        /// &lt;Exports xmlns="http://schemas.iTin.com/export/engine/2013/configuration"&gt;
        ///   &lt;Export Name="Test" Current="Yes"&gt;
        ///     &lt;Description&gt;Sample Export&lt;/Description&gt;
        ///     &lt;Table Name="R740D01"&gt;
        ///       &lt;Exporter&gt;
        ///         &lt;Template&gt;
        ///           &lt;File&gt;~\Samples\Input\Doc Templates\DocxSampleTemplate.docx&lt;/File&gt;
        ///           &lt;Writer Name="DocxFreeTemplateWriter"&gt;
        ///             &lt;Settings FieldPrefix="@@" TrimFields="Yes"/&gt;
        ///           &lt;/Writer&gt;
        ///         &lt;/Template&gt;
        ///         &lt;Behaviors&gt;
        ///           &lt;Download/&gt;
        ///         &lt;/Behaviors&gt;
        ///       &lt;/Exporter&gt;
        ///       &lt;Output&gt;
        ///         &lt;File&gt;SampleTemplate&lt;/File&gt;
        ///         &lt;Path&gt;~\Samples\Output\Templates&lt;/Path&gt;
        ///       &lt;/Output&gt;
        ///     &lt;/Table&gt;
        ///   &lt;/Export&gt;
        /// &lt;/Exports&gt;
        /// </code>
        /// </example>
        /// <exception cref="System.ArgumentNullException">If <paramref name="value" /> is <strong>null</strong>.</exception>
        /// <exception cref="iTin.Export.Model.InvalidPathNameException">If <paramref name="value" /> is an invalid path.</exception>
        public string File
        {
            get => file;
            set
            {
                SentinelHelper.ArgumentNull(value);
                SentinelHelper.IsFalse(RegularExpressionHelper.IsValidPath(value), new InvalidPathNameException(ErrorMessageHelper.ModelPathErrorMessage("File", value)));

                file = value;
            }
        }
        #endregion

        #region [public] (TemplateWriterModel) Writer: Gets or sets the template writer used by the exporter
        /// <summary>
        /// Gets or sets the template writer used by the exporter.
        /// </summary>
        /// <value>
        /// The template writer used by the exporter.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Template&gt;
        ///   &lt;Writer&gt;
        ///   ...
        ///   &lt;/Writer&gt;
        /// &lt;/Template&gt;
        /// </code>
        /// </remarks>
        /// <example>
        /// The following example shows how to use this element.
        /// <code lang="xml">
        /// &lt;?xml version="1.0" encoding="utf-8"?&gt;
        /// 
        /// &lt;Exports xmlns="http://schemas.iTin.com/export/engine/2013/configuration"&gt;
        ///   &lt;Export Name="Test" Current="Yes"&gt;
        ///     &lt;Description&gt;Sample Export&lt;/Description&gt;
        ///     &lt;Table Name="R740D01"&gt;
        ///       &lt;Exporter&gt;
        ///         &lt;Template&gt;
        ///           &lt;File&gt;~\Samples\Input\Doc Templates\DocxSampleTemplate.docx&lt;/File&gt;
        ///           &lt;Writer Name="DocxFreeTemplateWriter"&gt;
        ///             &lt;Settings FieldPrefix="@@" TrimFields="Yes"/&gt;
        ///           &lt;/Writer&gt;
        ///         &lt;/Template&gt;
        ///         &lt;Behaviors&gt;
        ///           &lt;Download/&gt;
        ///         &lt;/Behaviors&gt;
        ///       &lt;/Exporter&gt;
        ///       &lt;Output&gt;
        ///         &lt;File&gt;SampleTemplate&lt;/File&gt;
        ///         &lt;Path&gt;~\Samples\Output\Templates&lt;/Path&gt;
        ///       &lt;/Output&gt;
        ///     &lt;/Table&gt;
        ///   &lt;/Export&gt;
        /// &lt;/Exports&gt;
        /// </code>
        /// </example>
        public TemplateWriterModel Writer
        {
            get
            {
                if (writer == null)
                {
                    writer = new TemplateWriterModel();
                }

                writer.SetParent(this);

                return writer;
            }
            set => writer = value;
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
        public override bool IsDefault => Writer.IsDefault;
        #endregion

        #endregion
    }
}
