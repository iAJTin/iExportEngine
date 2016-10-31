using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

using iTin.Export.Helper;

namespace iTin.Export.Model
{
    /// <summary>
    /// Represents an e-mail message.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Belongs to: <strong><c>Messages</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.MailMessagesModel" />.
    /// <code lang="xml" title="AEE Object Element Usage">
    /// &lt;Message/&gt;
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
    ///       <td><see cref="P:iTin.Export.Model.MailMessageModel.Send" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Determines whether to send the e-mail. The default is <see cref="iTin.Export.Model.YesNo.Yes" />.</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.MailMessageModel.Credential" /></td>
    ///       <td align="center">No</td>
    ///       <td>The name of credential to use for this message.</td>
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
    ///     <term><see cref="P:iTin.Export.Model.MailMessageModel.Attachments" /></term> 
    ///     <description>The attachment collection used to store data attached to this e-mail message. Each element represents an attachment to an e-mail.</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.MailMessageModel.From" /></term> 
    ///     <description>The from address for this e-mail message.</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.MailMessageModel.To" /></term> 
    ///     <description>The address collection that contains the recipients of this e-mail message.</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.MailMessageModel.CC" /></term> 
    ///     <description>The address collection that contains the carbon copy (CC) recipients for this e-mail message.</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.MailMessageModel.Subject" /></term> 
    ///     <description>The subject line for this e-mail message.</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.MailMessageModel.Body" /></term> 
    ///     <description>The message body.</description>
    ///   </item>
    /// </list>
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
    ///   &lt;Mail Execute="Yes" Async="Yes" &gt;
    ///     &lt;Server&gt;
    ///       &lt;Credentials&gt;
    ///         &lt;Credential SSL="Yes" 
    ///                     Name="one" 
    ///                     UserName="address@gmail.com" 
    ///                     Password="pwd" 
    ///                     Host="smtp.gmail.com"/&gt;
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
    public partial class MailMessageModel
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo DefaultSend = YesNo.Yes;
        #endregion

        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private YesNo send;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private MailMessageToModel to;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private MailMessageCcModel copy;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private MailMessagesModel owner;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private MailMessageFromModel from;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private MailMessageAttachmentsModel attachments;
        #endregion

        #region constructor/s

            #region [public] MailMessageModel(): Initializes a new instance of this class.
            /// <summary>
            /// Initializes a new instance of the <see cref="T:iTin.Export.Model.MailMessageModel" /> class.
            /// </summary>
            public MailMessageModel()
            {
                Send = DefaultSend;
            }
            #endregion

        #endregion

        #region public properties

            #region [public] (MailAttachmentsModel) Attachments: Gets or sets the attachment collection used to store data attached to this e-mail message.
            /// <summary>
            /// Gets or sets the attachment collection used to store data attached to this e-mail message.
            /// </summary>
            /// <value>
            /// A <see cref="MailMessageAttachmentsModel" /> that contains the attachment list. Each element represents an attachment to an e-mail.
            /// </value>
            /// <remarks>
            /// <code lang="xml" title="AEE Object Element Usage">
            /// &lt;Message ...&gt;
            ///   &lt;Attachments/&gt;
            ///   ...
            /// &lt;/Message&gt;
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
            ///   &lt;Mail Execute="Yes" Async="Yes" &gt;
            ///     &lt;Server&gt;
            ///       &lt;Credentials&gt;
            ///         &lt;Credential SSL="Yes" 
            ///                     Name="one" 
            ///                     UserName="address@gmail.com" 
            ///                     Password="pwd" 
            ///                     Host="smtp.gmail.com"/&gt;
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
            [XmlArrayItem("Attachment", typeof(MailMessageAttachmentModel))]
            public MailMessageAttachmentsModel Attachments
            {
                get
                {
                    return attachments ?? (attachments = new MailMessageAttachmentsModel(this));
                }
                set
                {
                    attachments = value;
                }
            }
            #endregion

            #region [public] (string) Body: Gets or sets the message body.
            /// <summary>
            /// Gets or sets the message body.
            /// </summary>
            /// <value>
            /// The message body.
            /// </value>
            /// <remarks>
            /// <code lang="xml" title="AEE Object Element Usage">
            /// &lt;Message ...&gt;
            ///   &lt;Body&gt;string&lt;/&gt;
            ///   ...
            /// &lt;/Message&gt;
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
            ///   &lt;Mail Execute="Yes" Async="Yes" &gt;
            ///     &lt;Server&gt;
            ///       &lt;Credentials&gt;
            ///         &lt;Credential SSL="Yes" 
            ///                     Name="one" 
            ///                     UserName="address@gmail.com" 
            ///                     Password="pwd" 
            ///                     Host="smtp.gmail.com"/&gt;
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
            [XmlElement]
            public string Body { get; set; }
            #endregion

            #region [public] (MailMessageCcModel) CC: Gets or sets the address collection that contains the carbon copy (CC) recipients for this e-mail message.
            /// <summary>
            /// Gets or sets address collection that contains the carbon copy (CC) recipients for this e-mail message.
            /// </summary>
            /// <value>
            /// The address collection that contains the carbon copy (CC) recipients for this e-mail message.
            /// </value>
            /// <remarks>
            /// <code lang="xml" title="AEE Object Element Usage">
            /// &lt;Message ...&gt;
            ///   &lt;CC/&gt;
            ///   ...
            /// &lt;/Message&gt;
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
            ///   &lt;Mail Execute="Yes" Async="Yes" &gt;
            ///     &lt;Server&gt;
            ///       &lt;Credentials&gt;
            ///         &lt;Credential SSL="Yes" 
            ///                     Name="one" 
            ///                     UserName="address@gmail.com" 
            ///                     Password="pwd" 
            ///                     Host="smtp.gmail.com"/&gt;
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
            [XmlElement]
            public MailMessageCcModel CC
            {
                get
                {
                    if (copy == null)
                    {
                        copy = new MailMessageCcModel();
                    }

                    copy.SetParent(this);

                    return copy;
                }
                set
                {
                    copy = value;
                }
            }
            #endregion

            #region [public] (string) Credential: Gets or sets name of credential to use for this message.
            /// <summary>
            /// Gets or sets name of credential to use for this message.
            /// </summary>
            /// <value>
            /// The name of credential to use for this message.
            /// </value>
            /// <remarks>
            /// <code lang="xml" title="AEE Object Element Usage">
            /// &lt;Message Credential="string" ...&gt;
            /// ...
            /// &lt;/Message&gt;
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
            ///   &lt;Mail Execute="Yes" Async="Yes" &gt;
            ///     &lt;Server&gt;
            ///       &lt;Credentials&gt;
            ///         &lt;Credential SSL="Yes" 
            ///                     Name="one" 
            ///                     UserName="address@gmail.com" 
            ///                     Password="pwd" 
            ///                     Host="smtp.gmail.com"/&gt;
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
            [XmlAttribute]
            public string Credential { get; set; }
            #endregion

            #region [public] (MailMessageFromModel) From: Gets or sets the from address for this e-mail message.
            /// <summary>
            ///  Gets or sets the from address for this e-mail message.
            /// </summary>
            /// <value>
            /// A <see cref="T:iTin.Export.Model.MailMessageFromModel"/> that contains the from address information.
            /// </value>
            /// <remarks>
            /// <code lang="xml" title="AEE Object Element Usage">
            /// &lt;Message ...&gt;
            ///   &lt;From/&gt;
            ///   ...
            /// &lt;/Message&gt;
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
            ///   &lt;Mail Execute="Yes" Async="Yes" &gt;
            ///     &lt;Server&gt;
            ///       &lt;Credentials&gt;
            ///         &lt;Credential SSL="Yes" 
            ///                     Name="one" 
            ///                     UserName="address@gmail.com" 
            ///                     Password="pwd" 
            ///                     Host="smtp.gmail.com"/&gt;
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
            [XmlElement]
            public MailMessageFromModel From
            {
                get
                {
                    if (from == null)
                    {
                        from = new MailMessageFromModel();
                    }

                    from.SetParent(this);

                    return from;
                }
                set
                {
                    from = value;
                }
            }
            #endregion

            #region [public] (MailMessagesModel) Owner: Gets the element that owns this.
            /// <summary>
            /// Gets the element that owns this <see cref="T:iTin.Export.Model.MailMessageModel" />.
            /// </summary>
            /// <value>
            /// The <see cref="T:iTin.Export.Model.MailMessagesModel" /> that owns this <see cref="T:iTin.Export.Model.MailMessageModel" />.
            /// </value>
            [Browsable(false)]
            public MailMessagesModel Owner
            {
                get { return owner; }
            }
            #endregion

            #region [public] (YesNo) Send: Gets or sets a value that determines whether to send the message.
            /// <summary>
            /// Gets or sets a value that determines whether to send the message.
            /// </summary>
            /// <value>
            /// <see cref="iTin.Export.Model.YesNo.Yes" /> if sends the message; otherwise, <see cref="iTin.Export.Model.YesNo.No" />. The default is <see cref="iTin.Export.Model.YesNo.Yes" />.
            /// </value>
            /// <remarks>
            /// <code lang="xml" title="AEE Object Element Usage">
            /// &lt;Message Send="Yes|No" ...&gt;
            /// ...
            /// &lt;/Message&gt;
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
            ///   &lt;Mail Execute="Yes" Async="Yes" &gt;
            ///     &lt;Server&gt;
            ///       &lt;Credentials&gt;
            ///         &lt;Credential SSL="Yes" 
            ///                     Name="one" 
            ///                     UserName="address@gmail.com" 
            ///                     Password="pwd" 
            ///                     Host="smtp.gmail.com"/&gt;
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
            [DefaultValue(DefaultSend)]
            public YesNo Send
            {
                get
                {
                    return send;
                }
                set
                {
                    SentinelHelper.IsEnumValid(value);

                    send = value;
                }
            }
            #endregion

            #region [public] (string) Subject: Gets or sets the subject line for this e-mail message.
            /// <summary>
            /// Gets or sets the subject line for this e-mail message.
            /// </summary>
            /// <value>
            /// A <see cref="T:System.String"/> that contains the subject content.
            /// </value>
            /// <remarks>
            /// <code lang="xml" title="AEE Object Element Usage">
            /// &lt;Message ...&gt;
            ///   &lt;Subject&gt;string&lt;/&gt;
            ///   ...
            /// &lt;/Message&gt;
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
            ///   &lt;Mail Execute="Yes" Async="Yes" &gt;
            ///     &lt;Server&gt;
            ///       &lt;Credentials&gt;
            ///         &lt;Credential SSL="Yes" 
            ///                     Name="one" 
            ///                     UserName="address@gmail.com" 
            ///                     Password="pwd" 
            ///                     Host="smtp.gmail.com"/&gt;
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
            [XmlElement]
            public string Subject { get; set; }
            #endregion

            #region [public] (MailMessageToModel) To: Gets or sets the address collection that contains the recipients of this e-mail message.
            /// <summary>
            /// Gets or sets the address collection that contains the recipients of this e-mail message.
            /// </summary>
            /// <value>
            /// A <see cref="MailMessageToModel" /> that contains the recipients of this e-mail message.
            /// </value>
            /// <remarks>
            /// <code lang="xml" title="AEE Object Element Usage">
            /// &lt;Message ...&gt;
            ///   &lt;To/&gt;
            ///   ...
            /// &lt;/Message&gt;
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
            ///   &lt;Mail Execute="Yes" Async="Yes" &gt;
            ///     &lt;Server&gt;
            ///       &lt;Credentials&gt;
            ///         &lt;Credential SSL="Yes" 
            ///                     Name="one" 
            ///                     UserName="address@gmail.com" 
            ///                     Password="pwd" 
            ///                     Host="smtp.gmail.com"/&gt;
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
            [XmlElement]
            public MailMessageToModel To
            {
                get
                {
                    if (to == null)
                    {
                        to = new MailMessageToModel();
                    }

                    to.SetParent(this);

                    return to;
                }
                set
                {
                    to = value;
                }
            }
            #endregion

        #endregion

        #region public override properties

            #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default.
            /// <include file='..\..\iTin.Export.Documentation.Common.xml' path='Common/Model/Public/Overrides/Properties/Property[@name="IsDefault"]/*'/>
            public override bool IsDefault
            {
                get
                {
                    return                                                    
                        To.IsDefault && 
                        CC.IsDefault && 
                        From.IsDefault && 
                        Attachments.IsDefault &&
                        Send.Equals(DefaultSend);
                }
            }
            #endregion

        #endregion     

        #region public methods

            #region [public] (void) SetOwner(MailMessagesModel): Sets the element that owns this.
            /// <summary>
            /// Sets the element that owns this <see cref="T:iTin.Export.Model.MailMessageModel" />.
            /// </summary>
            /// <param name="reference">Reference to owner.</param>
            public void SetOwner(MailMessagesModel reference)
            {
                owner = reference;
            }
            #endregion

        #endregion
    }
}
