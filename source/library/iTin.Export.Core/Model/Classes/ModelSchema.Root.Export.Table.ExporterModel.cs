
namespace iTin.Export.Model
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    /// <summary>
    /// Defines the type of exporter to use and their behavior.
    /// </summary>
    /// <remarks>
    /// <para>Belongs to: <strong><c>Table</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.TableModel" />.<br/>
    /// <code lang="xml" title="AEE Object Element Usage">
    /// &lt;Exporter&gt;
    ///   &lt;Template/&gt; | &lt;Writer/&gt; |  &lt;Xslt/&gt;
    ///   &lt;Behaviors/&gt;
    /// &lt;/Exporter&gt;
    /// </code>
    /// </para>
    /// <para>Elements</para>
    /// <list type="table">
    ///   <listheader>
    ///     <term>Element</term>
    ///     <description>Description</description>
    ///   </listheader>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.ExporterModel.Current" /></term>
    ///     <description>The type of exporter you will use the engine.</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.ExporterModel.Behaviors" /></term>
    ///     <description>Collection of writer behaviors. Each element is a writer behavior, it execute after export.</description>
    ///   </item>
    /// </list>
    /// <para>
    /// The following example defines an exporter of type <see cref="iTin.Export.Model.KnownExporter.Writer" /> that contains two behaviors.<br/>
    /// The <c>Download</c> behavior indicates to engine that begin download to the file if we are in a web environment.<br/>
    /// The <c>TransformFile</c> behavior indicates to the engine that we want to save the transform xslt file and the transformed file (in this case the excel sheet).
    /// </para>
    /// <code lang="xml">
    /// &lt;?xml version="1.0" encoding="utf-8"?&gt;
    /// 
    /// &lt;Exports xmlns="http://schemas.iTin.com/export/engine/2013/configuration"&gt;
    ///   &lt;Export Name="Test" Current="Yes"&gt;
    ///     &lt;Description&gt;&lt;Sample Export&lt;/Description&gt;
    ///     &lt;Table Name="R740D01"
    ///               Location="1 1"
    ///               AutoFilter="Yes"
    ///               AutoFitColumns="Yes"              
    ///               Alias="Table alias"&gt;
    ///       &lt;Exporter&gt;
    ///         &lt;Writer Name="Spreadsheet2003TabularWriter"/&gt;
    ///         &lt;Behaviors&gt;
    ///           &lt;Download/&gt;
    ///           &lt;TransformFile Save="Yes"/&gt;
    ///         &lt;/Behaviors&gt;
    ///       &lt;/Exporter&gt;
    ///        ...
    ///     &lt;/Table&gt;
    ///      ...
    ///   &lt;/Export&gt;
    /// &lt;/Exports&gt;
    /// </code>
    /// </remarks>
    public partial class ExporterModel
    {
        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TableModel parent;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private BehaviorsModel behavior;
        #endregion

        #region public properties

        #region [public] (object) Current: Gets or sets a reference to the exporter to be used for export
        /// <summary>
        /// Gets or sets a reference to the exporter to be used for export.
        /// </summary>
        /// <value>
        /// Reference to the exporter to be used for export.
        /// </value>
        /// <remarks>
        ///   <para>
        ///   The following table shows the different exporters types.
        ///   </para>
        ///   <list type="table">
        ///     <listheader>
        ///       <term>Exporter</term>
        ///       <description>Description</description>
        ///     </listheader>
        ///     <item>
        ///       <term><see cref="T:iTin.Export.Model.TemplateModel" /></term>
        ///       <description>Represents an exporter based on a template file.</description>
        ///     </item>
        ///     <item>
        ///       <term><see cref="T:iTin.Export.Model.WriterModel" /></term>
        ///       <description>Represents an exporter based on a custom writer.</description>
        ///     </item>
        ///     <item>
        ///       <term><see cref="T:iTin.Export.Model.XsltModel" /></term>
        ///       <description>Represents an exporter based on xslt transformation file.</description>
        ///     </item>
        ///   </list>
        /// </remarks>
        [XmlElement("Template", typeof(TemplateModel))]
        [XmlElement("Writer", typeof(WriterModel))]
        [XmlElement("Xslt", typeof(XsltModel))]
        public object Current { get; set; }
        #endregion

        #region [public] (BehaviorsModel) Behaviors: Gets or sets collection of writer behaviors
        /// <summary>
        /// Gets or sets collection of writer behaviors.
        /// </summary>
        /// <value>
        /// Collection of writer behaviors. Each element is a writer behavior, it execute after export.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="AEE Object Element Usage">
        /// &lt;Behaviors&gt;
        ///   &lt;Download .../&gt; | &lt;TransformFile .../&gt; | &lt;Mail .../&gt; | &lt;ToDropbox .../&gt; | &lt;ToSkydrive .../&gt;
        ///   ...
        /// &lt;/Behaviors&gt;
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
        /// The following example creates collection of behaviors.
        /// <code lang="xml">
        /// &lt;Behaviors&gt;
        ///   &lt;Downdload/&gt;
        ///   &lt;TransformFile Save="No"/&gt;
        /// &lt;/Behaviors&gt;
        /// </code>
        /// </example>
        [XmlArrayItem("Mail", typeof(MailBehaviorModel))]
        [XmlArrayItem("Download", typeof(DownloadBehaviorModel))]
        [XmlArrayItem("ToDropbox", typeof(ToDropboxBehaviorModel))]
        [XmlArrayItem("ToSkyDrive", typeof(ToSkyDriveBehaviorModel))]
        [XmlArrayItem("TransformFile", typeof(TransformFileBehaviorModel))]
        public BehaviorsModel Behaviors
        {
            get => behavior ?? (behavior = new BehaviorsModel(this));
            set => behavior = value;
        }
        #endregion

        #region [public] (KnownExporter) ExporterType: Gets a value indicating data field type
        /// <summary>
        /// Gets a value indicating data field type.
        /// </summary>
        /// <value>
        /// One of the <see cref="T:iTin.Export.Model.KnownExporter" /> values.
        /// </value>
        public KnownExporter ExporterType
        {
            get
            {
                var exporterTypeValue = Current.GetType().Name;

                switch (exporterTypeValue)
                {
                    case "WriterModel":
                        return KnownExporter.Writer;

                    case "XsltModel":
                        return KnownExporter.Xslt;

                    case "TemplateModel":
                        return KnownExporter.Template;

                    default:
                        throw new InvalidOperationException();
                }
            }
        }
        #endregion

        #region [public] (TableModel) Parent: Gets the parent container of the exporter
        /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Exporter/Public/Properties/Property[@name="Parent"]/*'/>
        [XmlIgnore]
        [Browsable(false)]
        public TableModel Parent => parent;
        #endregion

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default
        /// <include file='..\..\iTin.Export.Documentation.Common.xml' path='Common/Model/Public/Overrides/Properties/Property[@name="IsDefault"]/*'/>
        public override bool IsDefault => Behaviors.IsDefault;
        #endregion

        #endregion

        #region internal methods

        #region [internal] (void) SetParent(TableModel): Sets the parent element of the element
        /// <include file='..\..\iTin.Export.Documentation.Common.xml' path='Common/Model/Internal/Methods/Method[@name="SetParent"]/*'/>
        internal void SetParent(TableModel reference)
        {
            parent = reference;
        }
        #endregion

        #endregion
    }
}
