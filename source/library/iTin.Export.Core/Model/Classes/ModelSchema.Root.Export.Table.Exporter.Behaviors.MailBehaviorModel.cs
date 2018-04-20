
namespace iTin.Export.Model
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Net.Mail;
    using System.Web;
    using System.Web.UI;
    using System.Xml.Serialization;

    using ComponentModel;
    using Helper;
    using Web;

    /// <inheritdoc />
    /// <summary>
    /// A Specialization of <see cref="T:iTin.Export.Model.BaseBehaviorModel" /> class.<br />
    /// Which Represents a email behavior.
    /// </summary>
    /// <remarks>
    /// <para>Belongs to: <strong><c>Behaviors</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.BehaviorsModel" />.<br />
    /// <code lang="xml" title="ITEE Object Element Usage">
    /// &lt;Mail .../&gt;
    ///   &lt;Server/&gt;
    ///   &lt;Messages/&gt;
    /// &lt;/Mail&gt;
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
    ///       <td><see cref="P:iTin.Export.Model.MailBehaviorModel.Async" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Determines whether to execute asynchronously the behavior. The default is <see cref="F:iTin.Export.Model.YesNo.Yes" />.</td>
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
    ///     <term><see cref="P:iTin.Export.Model.MailBehaviorModel.Server" /></term> 
    ///     <description>Mail server configuration.</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.MailBehaviorModel.Messages" /></term> 
    ///     <description>Collection of e-mail messages. Each element represents an e-mail message.</description>
    ///   </item>
    /// </list>
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
    ///   &lt;Mail Execute="Yes" Async="Yes" &gt;
    ///     &lt;Server&gt;
    ///       &lt;Credentials&gt;
    ///         &lt;Credential SSL="Yes" Name="one" UserName="address@gmail.com" password="pwd" Host="smtp.gmail.com"/&gt;
    ///       &lt;/Credentials&gt;
    ///     &lt;/Server&gt;
    ///     &lt;Messages&gt;
    ///       &lt;Message Credential="one" Send="Yes"&gt;
    ///         &lt;From Address="emailaddress-one@gmail.com"/&gt;
    ///         &lt;To Addresses="emailaddress-two@hotmail.com emailaddress-three@hotmail.com"/&gt;
    ///         &lt;CC Addresses="emailaddress-four@hotmail.com emailaddress-five@hotmail.com"/&gt;
    ///         &lt;Subject&gt;New report&lt;/Subject&gt;
    ///         &lt;Body&gt;Hello, this is your report, sending from iTin.Export&lt;/Body&gt;
    ///         &lt;Attachments&gt;
    ///           &lt;Attachment Path="C:\Users\somefile.txt"/&gt;
    ///           &lt;Attachment Path="C:\Users\Downloads\Photos Sample.zip"/&gt;
    ///         &lt;/Attachments&gt;
    ///       &lt;/Message&gt;
    ///     &lt;/Messages&gt;
    ///   &lt;/Mail&gt;
    /// &lt;/Behaviors&gt;
    /// </code>
    /// </example>
    public partial class MailBehaviorModel 
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo DefaultAsync = YesNo.Yes;
        #endregion
        
        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private YesNo _async;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private BehaviorsModel _parent;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private MailServerModel _server;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private MailMessagesModel _messages;
        #endregion

        #region constructor/s

        #region [public] MailBehaviorModel(): Initializes a new instance of this class
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.MailBehaviorModel" /> class.
        /// </summary>
        public MailBehaviorModel()
        {
            Async = DefaultAsync;
        }
        #endregion

        #endregion

        #region public static properties

        #region [public] {static} (MailBehaviorModel) Default: Gets a reference to default behavior
        /// <summary>
        /// Gets a reference to default behavior.
        /// </summary>
        /// <value>
        /// Default behavior.
        /// </value>
        public static MailBehaviorModel Default => new MailBehaviorModel();
        #endregion

        #endregion

        #region public properties

        #region [public] (YesNo) Async: Gets or sets a value indicating whether to execute asynchronously the behavior
        /// <summary>
        /// Gets or sets a value indicating whether to execute asynchronously the behavior.
        /// </summary>
        /// <value>
        /// <see cref="iTin.Export.Model.YesNo.Yes" /> if for execute asynchronously the behavior; otherwise, <see cref="iTin.Export.Model.YesNo.No" />. The default is <see cref="iTin.Export.Model.YesNo.Yes" />.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Mail Async="Yes|No" ...&gt;
        /// ...
        /// &lt;/Mail&gt;
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
        ///   &lt;Mail Execute="Yes" Async="Yes"&gt;
        ///     &lt;Server&gt;
        ///       &lt;Credentials&gt;
        ///         &lt;Credential SSL="Yes" Name="one" UserName="address@gmail.com" password="pwd" Host="smtp.gmail.com"/&gt;
        ///       &lt;/Credentials&gt;
        ///     &lt;/Server&gt;
        ///     &lt;Messages&gt;
        ///       &lt;Message Credential="one" Send="Yes"&gt;
        ///         &lt;From Address="emailaddress-one@gmail.com"/&gt;
        ///         &lt;To Addresses="emailaddress-two@hotmail.com emailaddress-three@hotmail.com"/&gt;
        ///         &lt;CC Addresses="emailaddress-four@hotmail.com emailaddress-five@hotmail.com"/&gt;
        ///         &lt;Subject&gt;New report&lt;/Subject&gt;
        ///         &lt;Body&gt;Hello, this is your report, sending from iTin.Export&lt;/Body&gt;
        ///         &lt;Attachments&gt;
        ///           &lt;Attachment Path="C:\Users\somefile.txt"/&gt;
        ///           &lt;Attachment Path="C:\Users\Downloads\Photos Sample.zip"/&gt;
        ///         &lt;/Attachments&gt;
        ///       &lt;/Message&gt;
        ///     &lt;/Messages&gt;
        ///   &lt;/Mail&gt;
        /// &lt;/Behaviors&gt;
        /// </code>
        /// </example>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>
        [XmlAttribute]
        [DefaultValue(DefaultAsync)]
        public YesNo Async
        {
            get => _async;
            set
            {
                SentinelHelper.IsEnumValid(value);

                _async = value;
            }
        }
        #endregion

        #region [public] (MailMessagesModel) Messages: Server: Gets or sets collection of mail messages
        /// <summary>
        /// Gets or sets collection of e-mail messages.
        /// </summary>
        /// <value>
        /// Collection of e-mail messages. Each element represents an e-mail message
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Mail ...&gt;
        ///   &lt;Messages/&gt;
        /// &lt;/Mail&gt;
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
        ///   &lt;Mail Execute="Yes" Async="Yes"&gt;
        ///     &lt;Server&gt;
        ///       &lt;Credentials&gt;
        ///         &lt;Credential SSL="Yes" Name="one" UserName="address@gmail.com" password="pwd" Host="smtp.gmail.com"/&gt;
        ///       &lt;/Credentials&gt;
        ///     &lt;/Server&gt;
        ///     &lt;Messages&gt;
        ///       &lt;Message Credential="one" Send="Yes"&gt;
        ///         &lt;From Address="emailaddress-one@gmail.com"/&gt;
        ///         &lt;To Addresses="emailaddress-two@hotmail.com emailaddress-three@hotmail.com"/&gt;
        ///         &lt;CC Addresses="emailaddress-four@hotmail.com emailaddress-five@hotmail.com"/&gt;
        ///         &lt;Subject&gt;New report&lt;/Subject&gt;
        ///         &lt;Body&gt;Hello, this is your report, sending from iTin.Export&lt;/Body&gt;
        ///         &lt;Attachments&gt;
        ///           &lt;Attachment Path="C:\Users\somefile.txt"/&gt;
        ///           &lt;Attachment Path="C:\Users\Downloads\Photos Sample.zip"/&gt;
        ///         &lt;/Attachments&gt;
        ///       &lt;/Message&gt;
        ///     &lt;/Messages&gt;
        ///   &lt;/Mail&gt;
        /// &lt;/Behaviors&gt;
        /// </code>
        /// </example>
        [XmlArrayItem("Message", typeof(MailMessageModel))]
        public MailMessagesModel Messages
        {
            get => _messages ?? (_messages = new MailMessagesModel(this));
            set => _messages = value;
        }
        #endregion

        #region [public] (BehaviorsModel) Parent: Gets the parent element of the element
        /// <summary>
        /// Gets the parent element of the element.
        /// </summary>
        /// <value>
        /// The element that represents the container element of the element.
        /// </value>
        [Browsable(false)]
        public BehaviorsModel Parent => _parent;
        #endregion

        #region [public] (MailServerModel) Server: Gets or sets a reference to mail server configuration
        /// <summary>
        /// Gets or sets a reference to mail server configuration.
        /// </summary>
        /// <value>
        /// Reference to mail server configuration, contains collection for mail server credentials.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Mail ...&gt;
        ///   &lt;Server/&gt;
        /// &lt;/Mail&gt;
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
        ///   &lt;Mail Execute="Yes" Async="Yes"&gt;
        ///     &lt;Server&gt;
        ///       &lt;Credentials&gt;
        ///         &lt;Credential SSL="Yes" Name="one" UserName="address@gmail.com" password="pwd" Host="smtp.gmail.com"/&gt;
        ///       &lt;/Credentials&gt;
        ///     &lt;/Server&gt;
        ///     &lt;Messages&gt;
        ///       &lt;Message Credential="one" Send="Yes"&gt;
        ///         &lt;From Address="emailaddress-one@gmail.com"/&gt;
        ///         &lt;To Addresses="emailaddress-two@hotmail.com emailaddress-three@hotmail.com"/&gt;
        ///         &lt;CC Addresses="emailaddress-four@hotmail.com emailaddress-five@hotmail.com"/&gt;
        ///         &lt;Subject&gt;New report&lt;/Subject&gt;
        ///         &lt;Body&gt;Hello, this is your report, sending from iTin.Export&lt;/Body&gt;
        ///         &lt;Attachments&gt;
        ///           &lt;Attachment Path="C:\Users\somefile.txt"/&gt;
        ///           &lt;Attachment Path="C:\Users\Downloads\Photos Sample.zip"/&gt;
        ///         &lt;/Attachments&gt;
        ///       &lt;/Message&gt;
        ///     &lt;/Messages&gt;
        ///   &lt;/Mail&gt;
        /// &lt;/Behaviors&gt;
        /// </code>
        /// </example>
        public MailServerModel Server
        {
            get
            {
                if (_server == null)
                {
                    _server = new MailServerModel();
                }

                _server.SetParent(this);

                return _server;
            }
            set => _server = value;
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
        public override bool IsDefault => Server.IsDefault &&
                                          Messages.IsDefault &&
                                          Async.Equals(DefaultAsync);
        #endregion

        #endregion

        #region internal methods

        #region [internal] (void) SetParent(BehaviorsModel): Sets the parent element of the element
        /// <summary>
        /// Sets the parent element of the element.
        /// </summary>
        /// <param name="reference">Reference to parent.</param>
        internal void SetParent(BehaviorsModel reference)
        {
            _parent = reference;
        }
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
        /// <exception cref="T:iTin.Export.Web.MissingPageAsyncAttributeException">Throw if web page not is async.</exception>
        protected override void ExecuteBehavior(IWriter writer, ExportSettings settings)
        {
            var isBehaviorAsync = Async == YesNo.Yes;

            var isWebContext = HttpContext.Current != null;
            if (isWebContext)
            {
                if (isBehaviorAsync)
                {
                    var page = (Page) HttpContext.Current.CurrentHandler;
                    var isPageAsync = page.IsAsync;
                    if (!isPageAsync)
                    {
                        throw new MissingPageAsyncAttributeException(page.AppRelativeVirtualPath);
                    }
                }
            }

            var messagesToSend = from message in Messages
                                 let canSend = message.Send
                                 where canSend == YesNo.Yes
                                 select message;

            foreach (var messageModel in messagesToSend)
            {
                var message = new MailMessage
                {
                    Body = messageModel.Body,
                    Subject = messageModel.Subject,
                    From = new MailAddress(messageModel.From.Address)
                };

                foreach (var to in messageModel.To.Addresses)
                {
                    message.To.Add(new MailAddress(to));
                }

                foreach (var cc in messageModel.CC.Addresses)
                {
                    message.CC.Add(new MailAddress(cc));
                }

                var filename = writer.ResponseInfo.ExtractFileName();
                var filenameFullPath = Path.Combine(FileHelper.TinExportTempDirectory, filename);
                var exporterAttach = filenameFullPath;
                var existFilename = File.Exists(filenameFullPath);
                if (!existFilename)
                {
                    exporterAttach = CreateZipFile(writer);
                }

                message.Attachments.Add(new Attachment(exporterAttach));
                var attachments = from attachment in messageModel.Attachments
                                  let exist = File.Exists(attachment.Path)
                                  where exist
                                  select attachment;
                foreach (var attachment in attachments)
                {
                    message.Attachments.Add(new Attachment(attachment.Path));
                }

                var mails = new Mail(Server);
                mails.SendMail(messageModel.Credential, message, isBehaviorAsync);
            }

            if (!isWebContext)
            {
                return;
            }

            HttpContext.Current.Response.Clear();
            HttpContext.Current.Response.Flush();
            HttpContext.Current.Response.End();
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
            var exporterType = writer.Adapter.DataModel.Data.Table.Exporter.ExporterType;
            if (exporterType != KnownExporter.Template)
            {
                if (!writer.IsTransformationFile)
                {
                    return string.Empty;
                }
            }

            var files = new Dictionary<string, byte[]>();
            var tempDirectory = FileHelper.TinExportTempDirectory;

            var extension = writer.IsTransformationFile ? "*" : writer.ExtendedInformation.Extension;
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

        #endregion
    }
}
