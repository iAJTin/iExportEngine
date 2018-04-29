
namespace iTin.Export.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.IO;
    using System.Xml.Serialization;

    using Helpers;

    /// <inheritdoc />
    ///  <summary>
    ///  Root element of <strong>iTin Export Engine</strong> configuration file that contains a list with export definition.
    ///  </summary>
    ///  <remarks>
    ///  <para>Represents <strong>ITEE root</strong> element of a configuration file.
    ///  <code lang="xml" title="ITEE Object Element Usage">
    ///   &lt;?xml version="1.0" encoding="utf-8"?&gt;
    ///   &lt;Exports xmlns="http://schemas.iTin.com/export/engine/2013/configuration"&gt;
    ///     &lt;Export/&gt;
    ///     &lt;Export/&gt;
    ///     ...
    ///   &lt;/Exports&gt;
    ///  </code>
    ///  </para>
    ///  <para><strong>Attributes</strong></para>
    ///  <list type="table">
    ///    <listheader>
    ///      <term>Attribute</term>
    ///      <description>Description</description>
    ///    </listheader>
    ///    <item>
    ///      <term>xmlns</term> 
    ///      <description>Namespace for the <c>iTin Export Engine (AEE)</c> configuration file.<br /></description>
    ///    </item>
    ///  </list>
    ///  <note>
    ///  The xsd schema file that will be used to validate the document are located in the location 
    ///  <c>VisualStudioInstallationFolder\Xml\Schemas</c>, also gives us the intellisense to write quickly the document.    
    ///  </note>
    ///  <para><strong>Elements</strong></para>
    ///  <list type="table">
    ///    <listheader>
    ///      <term>Element</term>
    ///      <description>Description</description>
    ///    </listheader>
    ///    <item>
    ///      <term><see cref="P:iTin.Export.Model.ExportsModel.Items" /></term> 
    ///      <description>Collection of export configurations. Each element is composed of a description and a data table definition.</description>
    ///    </item>
    ///  </list>
    ///  </remarks>
    ///  <example>
    ///  The following example shows a full configuration file.
    ///  <code lang="xml">
    ///  &lt;?xml version="1.0" encoding="utf-8"?&gt;
    ///  &lt;Exports xmlns="http://schemas.iTin.com/export/engine/2013/configuration"&gt;
    ///    &lt;Export Name="iTin" Current="Yes"&gt;
    ///      &lt;Description&gt;Sample 1&lt;/Description&gt;
    ///      &lt;Table Name="SCR3SFL"
    ///             AutoFilter="Yes"
    ///             AutoFitColumns="Yes"
    ///             Alias="iTin Sample 1"&gt;
    ///        &lt;Exporter&gt;   
    ///          &lt;Writer Name="Spreadsheet2003TabularWriter"/&gt;
    ///          &lt;Behaviors&gt;
    ///            &lt;Download/&gt;
    ///            &lt;TransformFile Save="Yes"/&gt;
    ///          &lt;/Behaviors&gt;
    ///        &lt;/Exporter&gt;
    ///        &lt;Output&gt;
    ///          &lt;File&gt;ExampleI&lt;/File&gt;
    ///          &lt;Path&gt;~\Samples\Output\Writers\Demo\XML Spreadsheet&lt;/Path&gt;
    ///        &lt;/Output&gt;
    ///        &lt;Styles&gt;
    ///          &lt;Style Name="Header"&gt;
    ///            &lt;Content Color="#D9E1F2"&gt;
    ///              &lt;Alignment Horizontal="Left"/&gt;
    ///              &lt;Text/&gt;
    ///            &lt;/Content&gt;
    ///            &lt;Font Name="Calibri" Size="11" Bold="Yes"/&gt;
    ///          &lt;/Style&gt;
    ///          &lt;Style Name="PeriodValue"&gt;
    ///            &lt;Content Color="#B4C6E7"&gt;
    ///              &lt;Alignment Horizontal="Right"/&gt;
    ///              &lt;DateTime Format="Year-Month"/&gt;
    ///            &lt;/Content&gt;
    ///            &lt;Font Name="Calibri" Size="11"/&gt;
    ///          &lt;/Style&gt;
    ///          &lt;Style Name="EuropeValue"&gt;
    ///            &lt;Content Color="#B4C6E7"&gt;
    ///              &lt;Alignment Horizontal="Right"/&gt;
    ///              &lt;Number Decimals="1" Separator="Yes"/&gt;
    ///            &lt;/Content&gt;
    ///            &lt;Font Name="Calibri" Size="11"/&gt;
    ///          &lt;/Style&gt;
    ///          &lt;Style Name="AfricaValue"&gt;
    ///            &lt;Content Color="#B4C6E7"&gt;
    ///              &lt;Alignment Horizontal="Right"/&gt;
    ///              &lt;Number Decimals="1" Separator="Yes"/&gt;
    ///            &lt;/Content&gt;
    ///            &lt;Font Name="Calibri" Size="11"/&gt;
    ///          &lt;/Style&gt;
    ///          &lt;Style Name="AsiaValue"&gt;
    ///            &lt;Content Color="#B4C6E7"&gt;
    ///              &lt;Alignment Horizontal="Right"/&gt;
    ///              &lt;Number Decimals="1" Separator="Yes"/&gt;
    ///            &lt;/Content&gt;
    ///            &lt;Font Name="Calibri" Size="11"/&gt;
    ///          &lt;/Style&gt;
    ///          &lt;Style Name="NorthAmericaValue"&gt;
    ///            &lt;Content Color="#B4C6E7"&gt;
    ///              &lt;Alignment Horizontal="Right"/&gt;
    ///              &lt;Number Decimals="1" Separator="Yes"/&gt;
    ///            &lt;/Content&gt;
    ///            &lt;Font Name="Calibri" Size="11"/&gt;
    ///          &lt;/Style&gt;
    ///          &lt;Style Name="SouthAmericaValue"&gt;
    ///            &lt;Content Color="#B4C6E7"&gt;
    ///              &lt;Alignment Horizontal="Right"/&gt;
    ///              &lt;Number Decimals="1" Separator="Yes"/&gt;
    ///            &lt;/Content&gt;
    ///            &lt;Font Name="Calibri" Size="11"/&gt;
    ///          &lt;/Style&gt;
    ///          &lt;Style Name="AustraliaValue"&gt;
    ///            &lt;Content Color="#B4C6E7"&gt;
    ///              &lt;Alignment Horizontal="Right"/&gt;
    ///              &lt;Number Decimals="1" Separator="Yes"/&gt;
    ///            &lt;/Content&gt;
    ///            &lt;Font Name="Calibri" Size="11"/&gt;
    ///          &lt;/Style&gt;
    ///        &lt;/Styles&gt;
    ///        &lt;Fields&gt;
    ///          &lt;Field Name="PERIOD" Alias="Period"&gt;
    ///            &lt;Header Style="Header"/&gt;
    ///            &lt;Value Style="PeriodValue"/&gt;
    ///          &lt;/Field&gt;
    ///          &lt;Field Name="EUROPE" Alias="Europe"&gt;
    ///            &lt;Header Style="Header"/&gt;
    ///            &lt;Value Style="EuropeValue"/&gt;
    ///          &lt;/Field&gt;
    ///          &lt;Field Name="AFRICA" Alias="Africa"&gt;
    ///            &lt;Header Style="Header"/&gt;
    ///            &lt;Value Style="AfricaValue"/&gt;
    ///          &lt;/Field&gt;
    ///          &lt;Field Name="ASIA" Alias="Asia"&gt;
    ///            &lt;Header Style="Header"/&gt;
    ///            &lt;Value Style="AsiaValue"/&gt;
    ///          &lt;/Field&gt;
    ///          &lt;Field Name="NORTHAMERICA" Alias="North America"&gt;
    ///            &lt;Header Style="Header"/&gt;
    ///            &lt;Value Style="NorthAmericaValue"/&gt;
    ///          &lt;/Field&gt;
    ///          &lt;Field Name="SOUTHAMERICA" Alias="South America"&gt;
    ///            &lt;Header Style="Header"/&gt;
    ///            &lt;Value Style="SouthAmericaValue"/&gt;
    ///          &lt;/Field&gt;
    ///          &lt;Field Name="AUSTRALIA" Alias="Australia"&gt;
    ///            &lt;Header Style="Header"/&gt;
    ///            &lt;Value Style="AustraliaValue"/&gt;
    ///          &lt;/Field&gt;
    ///        &lt;/Fields&gt;
    ///      &lt;/Table&gt;
    ///    &lt;/Export&gt;
    ///  &lt;/Exports&gt;
    ///  </code>
    ///  </example>
    public partial class ExportsModel
    {
        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ExportModel> _export;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ReferencesModel _references;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GlobalResourcesModel _resources;
        #endregion

        #region public properties

        #region [public] (List<ExportModel>) Items: Gets or sets collection of export configurations
        /// <summary>
        ///  Gets or sets collection of export configurations.
        /// </summary>
        /// <value>
        /// Collection of export configurations. Each element is composed of a description and a data table definition.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        ///   &lt;Exports&gt;
        ///     &lt;Export .../&gt;
        ///     &lt;Export .../&gt;
        ///     ...
        ///   &lt;/Exports&gt;
        /// </code>
        /// </remarks>
        [XmlElement("Export")]
        public List<ExportModel> Items
        {
            get
            {
                var items = _export ?? (_export = new List<ExportModel>());
                foreach (var item in items)
                {
                    item.SetOwner(this);
                }

                return items;
            }
            set
            {
                foreach (var item in _export)
                {
                    item.SetOwner(this);
                }

                _export = value;
            }
        }
        #endregion

        #region [public] (ReferencesModel) References: Gets a reference to the assembly references
        /// <summary>
        /// Gets a reference to the assembly references.
        /// </summary>
        /// <value>
        /// A <see cref="T:iTin.Export.Model.ReferencesModel"/> reference which contains the assembly references.
        /// </value>
        [XmlArrayItem("Reference", typeof(ReferenceModel), IsNullable = false)]
        public ReferencesModel References
        {
            get
            {
                if (_references == null)
                {
                    _references = new ReferencesModel(this);
                }

                _references.SetParent(this);

                return _references;
            }
            set => _references = value;
        }
        #endregion

        #region [public] (GlobalResourcesModel) Resources: Gets or sets global resources
        /// <summary>
        ///  Gets or sets global resources.
        /// </summary>
        /// <value>
        /// The image file path.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Global.Resources&gt;
        ///   &lt;Images/&gt;
        /// &lt;/Global.Resources&gt;
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
        ///       <td align="center">No has effect</td>
        ///       <td align="center">No has effect</td>
        ///       <td align="center">No has effect</td>
        ///       <td align="center">No has effect</td>
        ///     </tr>
        ///   </tbody>
        /// </table>
        /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
        /// </para>
        /// </remarks>
        [XmlElement("Global.Resources")]
        public GlobalResourcesModel Resources
        {
            get
            {
                if (_resources == null)
                {
                    _resources = new GlobalResourcesModel();
                }

                _resources.SetParent(this);

                return _resources;
            }
            set => _resources = value;
        }
        #endregion

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance contains the default
        /// <inheritdoc />
        /// <summary>
        /// Gets a value indicating whether this instance contains the default.
        /// </summary>
        /// <value>
        /// <strong>true</strong> if this instance is default; otherwise, <strong>false</strong>.
        /// </value>
        /// <remarks>
        /// If it contains elements returns <strong>false</strong>.
        /// </remarks>
        [Browsable(false)]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public override bool IsDefault => Items.Count.Equals(0) &&
                                          Resources.IsDefault &&
                                          References.IsDefault;
        #endregion

        #endregion     

        #region public static methods

        #region [public] {static} (T) GetDefaultPropertyValue<T>(Type, string): Gets the default value for specified property.
        /// <summary>
        /// Gets the default value for specified property.
        /// </summary>
        /// <typeparam name="T">Property type</typeparam>
        /// <param name="type">Type containing the property to check.</param>
        /// <param name="property">Property name.</param>
        /// <returns>
        /// Property Default.
        /// </returns>
        [DebuggerStepThrough]
        public static T GetDefaultPropertyValue<T>(Type type, string property)
        {
            SentinelHelper.ArgumentNull(type);
            SentinelHelper.ArgumentNull(property);

            var pi = type.GetProperty(property);
            var da = (DefaultValueAttribute)pi.GetCustomAttributes(typeof(DefaultValueAttribute), false)[0];
            return (T)da.Value;
        }
        #endregion

        #region [public] {static} (string) GetRelativeFilePathParsed(ExportModel, KnownRelativeFilePath): Gets a valid full path from a relative path.
        /// <summary>
        /// Gets a valid full path from a relative path.
        /// </summary>
        /// <param name="model">Model in which search.</param>
        /// <param name="element">Element to recover.</param>
        /// <returns>
        /// Valid full path.
        /// </returns>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>
        [DebuggerStepThrough]
        public static string GetRelativeFilePathParsed(ExportModel model, KnownRelativeFilePath element)
        {
            SentinelHelper.ArgumentNull(model);
            SentinelHelper.IsEnumValid(element);

            var relativePath = model.Table.Output.Path;
            var relativeFilename = model.Table.Output.File;
            var exporter = model.Table.Exporter;
            var relativePathIsRooted = relativeFilename.StartsWith("~");

            switch (element)
            {
                case KnownRelativeFilePath.Output:
                    relativePath = Path.Combine(model.Table.Output.Path, model.Table.Output.File);
                    break;

                case KnownRelativeFilePath.Template:
                    relativePath = ((TemplateModel)exporter.Current).File;
                    break;

                case KnownRelativeFilePath.Transform:
                    relativePath = (string)exporter.Current;
                    break;

                case KnownRelativeFilePath.TransformFileBehaviorDir:
                    var behavior = exporter.Behaviors.Get<TransformFileBehaviorModel>();
                    var transformFilePath = behavior.Path;
                    var defaultTransformFilePath = GetDefaultPropertyValue<string>(typeof(TransformFileBehaviorModel), "Path");

                    relativePath = relativePath.Replace(relativeFilename, string.Empty);
                    if (!transformFilePath.Equals(defaultTransformFilePath, StringComparison.Ordinal) && !string.IsNullOrEmpty(transformFilePath))
                    {
                        relativePath = transformFilePath;
                    }

                    break;

                case KnownRelativeFilePath.WriterFilter:
                    relativePath = ((WriterModel)exporter.Current).Filter.Path;
                    break;
            }

            return PathHelper.GetRelativeFilePathParsed(relativePathIsRooted ? $"~{relativePath}" : relativePath, model);
        }
        #endregion

        #region [public] {static} (string) GetXmlEnumAttributeFromItem(Enum): Gets a string containing the attribute value an element XmlEnumAttribute.
        /// <summary>
        /// Gets a string containing the attribute value an element <see cref="T:System.Xml.Serialization.XmlEnumAttribute"/>.
        /// </summary>
        /// <param name="item">Element containing the attribute.</param>
        /// <returns>
        /// The attribute value of the element.
        /// </returns>
        [DebuggerStepThrough]
        public static string GetXmlEnumAttributeFromItem(Enum item)
        {
            SentinelHelper.ArgumentNull(item);

            var itemType = item.GetType();
            var itemName = Enum.GetName(itemType, item);
            var mi = itemType.GetMember(itemName);
            var xmlEnumAttribute = (XmlEnumAttribute)Attribute.GetCustomAttribute(mi[0], typeof(XmlEnumAttribute));
            var attributeValue = xmlEnumAttribute.Name;

            return attributeValue;
        }
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (string) ToString(): Returns a string that represents the current object
        /// <inheritdoc />
        /// <summary>
        /// Returns a string that represents the current data type.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String" /> that represents the current object.
        /// </returns>
        /// <remarks>
        /// This method <see cref="M:iTin.Export.Model.ExportsModel.ToString" /> returns a string that includes the number of exports defined.
        /// </remarks>
        public override string ToString()
        {
            return $"Count={Items.Count}";
        }
        #endregion

        #endregion
    }
}
