
namespace iTin.Export.Model
{
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    using ComponentModel.Writer;
    using Helpers;

    /// <summary>
    /// Implements interface <see cref="T:iTin.Export.Model.IBehavior" />.
    /// Which acts as the base class for different behaviors of an exporter supported by <strong><c>iTin Export Engine</c></strong>.<br />
    /// </summary>
    /// <remarks>
    ///   <para>The following table shows the different behaviors.</para>
    ///   <list type="table">
    ///     <listheader>
    ///       <term>Class</term>
    ///       <description>Description</description>
    ///     </listheader>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Model.DownloadBehaviorModel" /></term>
    ///       <description>Represents download behavior. Applies only in web mode</description>
    ///     </item>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Model.MailBehaviorModel" /></term>
    ///       <description>Represents a email list behavior.</description>
    ///     </item>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Model.TransformFileBehaviorModel" /></term>
    ///       <description>
    ///       Represents a transform file behavior.
    ///       If the writer that we are using generates a Xml transform file, this element allows us to define their behavior. 
    ///       Allows indicate if you want save it, where and if Xml code generated will indented.
    ///       </description>
    ///     </item>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Model.ToDropboxBehaviorModel" /></term>
    ///       <description>
    ///       Represents a upload file behavior to Dropbox cloud service.
    ///       Upload the result of export to Dropbox.
    ///       </description>
    ///     </item>    
    ///     <item>
    ///       <term><see cref="T:iTin.Export.Model.ToSkyDriveBehaviorModel" /></term>
    ///       <description>
    ///       Represents a upload file behavior to Microsoft SkyDrive cloud service.
    ///       Upload the result of export to Microsoft SkyDrive.
    ///       </description>
    ///     </item>    
    ///   </list>
    ///   <note>
    ///     For developers, to create new behaviors;
    ///     <list type="number">
    ///       <item><description>Should be create new class that inherit from this class.</description></item>
    ///       <item><description>Add custom properties for your new behavior.</description></item>
    ///       <item><description>Implement the method <see cref="M:iTin.Export.Model.BaseBehaviorModel.ExecuteBehavior(iTin.Export.ComponentModel.IWriter,iTin.Export.ExportSettings)" />.</description></item>
    ///       <item><description>Create an instance of the new behavior.</description></item>
    ///       <item><description>Add instance to behavior collection.</description></item>
    ///       <item><description>Enjoy!!!.</description></item>
    ///     </list>
    ///   </note>
    /// </remarks>
    public partial class BaseBehaviorModel : IBehavior
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo DefaultExecute = YesNo.Yes;
        
        #endregion
        
        #region private fields
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private YesNo _canExecute;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private BehaviorsModel _owner;
        #endregion
        
        #region protected members

        #region [protected] BaseBehaviordModel(): Initializes a new instance of the class
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.BaseBehaviorModel"/> class.
        /// </summary>
        protected BaseBehaviorModel()
        {
            CanExecute = DefaultExecute;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (YesNo) CanExecute: Gets or sets a value indicating whether executes behavior
        /// <inheritdoc />
        /// <summary>
        /// Gets or sets a value indicating whether executes behavior.
        /// </summary>
        /// <value>
        /// <see cref="F:iTin.Export.Model.YesNo.Yes" /> if executes behavior; otherwise, <see cref="F:iTin.Export.Model.YesNo.No" />. The default is <see cref="F:iTin.Export.Model.YesNo.Yes" />.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Download Execute="Yes|No" .../&gt;
        /// </code>
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
        /// &lt;Exporter&gt;
        ///   &lt;Writer Name="Spreadsheet2003TabularWriter"/&gt;
        ///   &lt;Behaviors&gt;
        ///     &lt;Download Execute="No" LocalCopy="Yes"/&gt;
        ///   &lt;/Behaviors&gt;
        /// &lt;/Exporter&gt;
        /// </code>
        /// </example>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>
        [XmlAttribute("Execute")]
        [DefaultValue(DefaultExecute)]
        public YesNo CanExecute
        {
            get => GetStaticBindingValue(_canExecute.ToString()).ToLowerInvariant() == "no" ? YesNo.No : YesNo.Yes;
            set
            {
                SentinelHelper.IsEnumValid(value);

                _canExecute = value;
            }
        }
        #endregion

        #region [public] (BehaviorsModel) Owner: Gets the element that owns this.
        /// <summary>
        /// Gets the element that owns this data field.
        /// </summary>
        /// <value>
        /// The <see cref="T:iTin.Export.Model.BehaviorsModel" /> that owns this data field.
        /// </value>
        [XmlIgnore]
        [Browsable(false)]
        public BehaviorsModel Owner => _owner;
        #endregion

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default
        /// <inheritdoc />
        /// <include file="..\..\iTin.Export.Documentation.Common.xml" path="Common/Model/Public/Overrides/Properties/Property[@name='IsDefault']/*" />
        public override bool IsDefault => base.IsDefault && CanExecute.Equals(DefaultExecute);
        #endregion

        #endregion

        #region public methods

        #region [public] (void) Execute(IWriter): Execute behavior
        /// <inheritdoc />
        /// <summary>
        /// Execute behavior.
        /// </summary>
        /// <param name="writer">The writer.</param>
        public void Execute(IWriter writer)
        {
            if (CanExecute.Equals(YesNo.Yes))
            {
                ExecuteBehavior(writer, null);
            }
        }
        #endregion

        #region [public] (void) Execute(IWriter, ExportSettings): Execute behavior
        /// <inheritdoc />
        /// <summary>
        /// Execute behavior.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="settings">Exporter settings.</param>
        public void Execute(IWriter writer, ExportSettings settings)
        {
            if (CanExecute.Equals(YesNo.Yes))
            {
                ExecuteBehavior(writer, settings);
            }
        }
        #endregion

        #region [public] (void) SetOwner(BehaviorsModel): Sets a reference to the owner object that contains this instance
        /// <inheritdoc />
        /// <summary>
        /// Sets a reference to the owner object that contains this instance.
        /// </summary>
        /// <param name="reference">Owner reference.</param>
        public void SetOwner(BehaviorsModel reference)
        {
            _owner = reference;
        }
        #endregion

        #endregion

        #region public abstract methods

        #region [protected] {abstract} (void) ExecuteBehavior(IWriter, ExportSettings): Code for execute behavior
        /// <summary>
        /// Code for execute behavior
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="settings">Exporter settings.</param>
        protected abstract void ExecuteBehavior(IWriter writer, ExportSettings settings);
        #endregion

        #endregion
    }
}
