
namespace iTin.Export.Model
{
    using System.ComponentModel;
    using System.Diagnostics;

    /// <summary>
    /// A Specialization of <see cref="T:iTin.Export.Model.WriterModel" /> class.<br/>
    /// Represents a template writer used by a exporter.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Belongs to: <strong><c>Template</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.TemplateModel" />.
    /// <code lang="xml" title="AEE Object Element Usage">
    /// &lt;Writer ...&gt;
    ///   &lt;Filter/&gt; 
    ///   &lt;Settings/&gt; 
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
    ///       <td>Name of the template writer. Select from the list or create your own and use it.</td>
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
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.TemplateWriterModel.Settings" /></term> 
    ///     <description>Reference to the settings defined for this writer.</description>
    ///   </item>
    /// </list>
    /// </remarks>
    public partial class TemplateWriterModel 
    {
        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TemplateModel parent;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TemplateWriterSettingsModel settings;
        #endregion

        #region public properties

        #region [public] (TemplateModel) Parent: Gets the parent element of the element
        /// <summary>
        /// Gets the parent element of the element.
        /// </summary>
        /// <value>
        /// The element that represents the container element of the element.
        /// </value>
        [Browsable(false)]
        public TemplateModel Parent => parent;
        #endregion

        #region [public] (TemplateWriterSettingsModel) Settings: Gets or sets a reference to the settings defined for this writer
        /// <summary>
        /// Gets or sets a reference to the settings defined for this writer.
        /// </summary>
        /// <value>
        /// Reference to the settings defined for this writer.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="AEE Object Element Usage">
        /// &lt;Writer&gt;
        ///   &lt;Settings/&gt;
        /// &lt;Writer/&gt;
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
        public TemplateWriterSettingsModel Settings
        {
            get
            {
                if (settings == null)
                {
                    settings = new TemplateWriterSettingsModel();
                }

                settings.SetParent(this);

                return settings;
            }
            set => settings = value;
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
        public override bool IsDefault => Settings.IsDefault;
        #endregion

        #endregion

        #region internal methods

        #region [internal] (void) SetParent(TemplateModel): Sets the parent element of the element
        /// <summary>
        /// Sets the parent element of the element.
        /// </summary>
        /// <param name="reference">Reference to parent.</param>
        internal void SetParent(TemplateModel reference)
        {
            parent = reference;
        }
        #endregion

        #endregion
    }
}
