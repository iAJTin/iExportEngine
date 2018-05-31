
namespace iTin.Export.Model
{
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    /// <summary>
    /// Collection of mail server credentials authentication. Each element defines a server credential authentication.
    /// </summary>
    /// <remarks>
    /// <para>Belongs to: <strong><c>Mail</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.MailBehaviorModel" />.<br/>
    /// <code lang="xml" title="ITEE Object Element Usage">
    /// &lt;Server/&gt;
    /// </code>
    /// </para>
    /// <para><strong>Elements</strong></para>
    /// <list type="table">
    ///   <listheader>
    ///     <term>Element</term>
    ///     <description>Description</description>
    ///   </listheader>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.MailServerModel.Credentials" /></term> 
    ///     <description>Collection of mail server credentials authentication. Each element defines a server credential authentication.</description>
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
    public partial class MailServerModel
    {
        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private MailBehaviorModel _parent;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ServerCredentialsModel _credentials;
        #endregion

        #region public static properties

        #region [public] {static} (MailServerModel) Default: Gets a reference to default behavior
        /// <summary>
        /// Gets a reference to default behavior.
        /// </summary>
        /// <value>
        /// Default behavior.
        /// </value>
        public static MailServerModel Default => new MailServerModel();
        #endregion

        #endregion

        #region public properties

        #region [public] (ServerCredentialsModel) Credentials: Gets or sets collection of mail server credentials authentication
        /// <summary>
        /// Gets or sets collection of mail server credentials authentication.
        /// </summary>
        /// <value>
        /// Collection of mail server credentials authentication. Each element defines a server credential authentication.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Server&gt;
        ///   &lt;Credentials .../&gt;
        /// &lt;/Server&gt;
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
        [XmlArrayItem("Credential", typeof(ServerCredentialModel))]
        public ServerCredentialsModel Credentials
        {
            get => _credentials ?? (_credentials = new ServerCredentialsModel(this));
            set => _credentials = value;
        }
        #endregion

        #region [public] (MailBehaviorModel) Parent: Gets the parent element of the element
        /// <summary>
        /// Gets the parent element of the element.
        /// </summary>
        /// <value>
        /// The element that represents the container element of the element.
        /// </value>
        [Browsable(false)]
        public MailBehaviorModel Parent => _parent;
        #endregion

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default
        /// <include file='..\..\iTin.Export.Documentation.Common.xml' path='Common/Model/Public/Overrides/Properties/Property[@name="IsDefault"]/*'/>
        public override bool IsDefault => Credentials.IsDefault;
        #endregion

        #endregion     

        #region internal methods

        #region [internal] (void) SetParent(MailBehaviorModel): Sets the parent element of the element
        /// <summary>
        /// Sets the parent element of the element.
        /// </summary>
        /// <param name="reference">Reference to parent.</param>
        internal void SetParent(MailBehaviorModel reference)
        {
            _parent = reference;
        }
        #endregion

        #endregion
    }
}
