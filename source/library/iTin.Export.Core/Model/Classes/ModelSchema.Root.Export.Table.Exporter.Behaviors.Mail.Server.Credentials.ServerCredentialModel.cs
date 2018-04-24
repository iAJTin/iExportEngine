
namespace iTin.Export.Model
{
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    using Helper;

    /// <summary>
    /// Representing a server credential authentication.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Belongs to: <strong><c>Credentials</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.ServerCredentialsModel" />.
    /// <code lang="xml" title="ITEE Object Element Usage">
    /// &lt;Credential/&gt;
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
    ///       <td><see cref="P:iTin.Export.Model.ServerCredentialModel.Name" /></td>
    ///       <td align="center">No</td>
    ///       <td>The identifier name of credential.</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.ServerCredentialModel.SSL" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Determines whether uses Secure Sockets Layer (SSL) to encrypt the connection. The default is <see cref="iTin.Export.Model.YesNo.Yes" />.</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.ServerCredentialModel.Domain" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>The name of the domain associated with the credential. The default is an empty string ("").</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.ServerCredentialModel.Port" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Port used for SMTP transactions. The default value is 25.</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.ServerCredentialModel.UserName" /></td>
    ///       <td align="center">No</td>
    ///       <td>The user name associated with the credential.</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.ServerCredentialModel.Password" /></td>
    ///       <td align="center">No</td>
    ///       <td>The password associated with the credential.</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.ServerCredentialModel.Host" /></td>
    ///       <td align="center">No</td>
    ///       <td>The name or IP address of the host used for SMTP transactions.</td>
    ///     </tr>
    ///   </tbody>
    /// </table>
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
    public partial class ServerCredentialModel
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const int DefaultPort = 25;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const YesNo DefaultSSL = YesNo.Yes;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string DefaultDomain = "";
        #endregion

        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int _port;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private YesNo _ssl;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _host;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ServerCredentialsModel _owner;
        #endregion

        #region constructor/s

        #region [public] ServerCredentialModel(): Initializes a new instance of this class
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.ServerCredentialModel" /> class.
        /// </summary>
        public ServerCredentialModel()
        {
            SSL = DefaultSSL;
            Port = DefaultPort;
            Domain = DefaultDomain;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (string) Domain: Gets or sets the domain or computer name that verifies the credential
        /// <summary>
        /// Gets or sets the domain or computer name that verifies the credential.
        /// </summary>
        /// <value>
        /// The name of the domain associated with the credential. The default is an empty string ("").
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Credential Domain="string" .../&gt;
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
        /// &lt;Credential Name="firstcredential" UserName="address@gmail.com" password="pwd" Host="smtp.gmail.com"/&gt;
        /// </code>
        /// </example>
        [XmlAttribute]
        [DefaultValue(DefaultDomain)]
        public string Domain { get; set; }
        #endregion

        #region [public] (string) Host: Gets or sets the name or IP address of the host used for SMTP transactions
        /// <summary>
        /// Gets or sets the name or IP address of the host used for SMTP transactions.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String" /> that contains the name or IP address of the computer to use for SMTP transactions.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Credential Host="string" .../&gt;
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
        /// &lt;Credential Name="firstcredential" UserName="address@gmail.com" password="pwd" Host="smtp.gmail.com"/&gt;
        /// </code>
        /// </example>
        [XmlAttribute]
        public string Host
        {
            get => _host;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _host = value;
                }
                else
                {
                    if (!char.IsDigit(value[0]))
                    {
                        _host = value;
                    }
                    else
                    {                        
                        var isValidIpAddress = false;
                        if (!string.IsNullOrEmpty(value))
                        {
                            isValidIpAddress = RegularExpressionHelper.IsValidIpAddress(value);
                        }

                        _host = isValidIpAddress 
                                        ? value 
                                        : string.Empty;
                    }                        
                }
            }
        }
        #endregion

        #region [public] (string) Name: Gets or sets the identifier name of credential
        /// <summary>
        /// Gets or sets the identifier name of credential.
        /// </summary>
        /// <value>
        /// The identifier name of credential.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Credential Name="string" .../&gt;
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
        /// &lt;Credential Name="firstcredential" UserName="address@gmail.com" password="pwd" Host="smtp.gmail.com"/&gt;
        /// </code>
        /// </example>
        [XmlAttribute]
        public string Name { get; set; }
        #endregion

        #region [public] (ServerCredentialsModel) Owner: Gets the element that owns this
        /// <summary>
        /// Gets the element that owns this <see cref="T:iTin.Export.Model.ServerCredentialModel" />.
        /// </summary>
        /// <value>
        /// The <see cref="T:iTin.Export.Model.ServerCredentialsModel" /> that owns this <see cref="T:iTin.Export.Model.ServerCredentialModel" />.
        /// </value>
        [Browsable(false)]
        public ServerCredentialsModel Owner => _owner;
        #endregion

        #region [public] (string) Password: Gets or sets the password for the user name associated with the credential
        /// <summary>
        /// Gets or sets the password for the user name associated with the credential.
        /// </summary>
        /// <value>
        /// The password associated with the credential.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Credential Password="string" .../&gt;
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
        /// &lt;Credential Name="firstcredential" UserName="address@gmail.com" password="pwd" Host="smtp.gmail.com"/&gt;
        /// </code>
        /// </example>
        [XmlAttribute]
        public string Password { get; set; }
        #endregion

        #region [public] (int) Port: Gets or sets the port used for SMTP transactions
        /// <summary>
        /// Gets or sets the port used for SMTP transactions.
        /// </summary>
        /// <value>
        /// An <see cref="T:System.Int32"/> that contains the port number on the SMTP host. The default value is 25.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Credential Port="int" .../&gt;
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
        /// &lt;Credential Name="firstcredential" UserName="address@gmail.com" password="pwd" Port="25" Host="smtp.gmail.com"/&gt;
        /// </code>
        /// </example>
        [XmlAttribute]
        [DefaultValue(DefaultPort)]
        public int Port
        {
            get => _port;
            set
            {
                SentinelHelper.IsTrue(value <= 0, "El valor no puede ser menor o igual a 0");

                _port = value;
            }
        }
        #endregion

        #region [public] (YesNo) SSL: Gets or sets a value that determines whether uses Secure Sockets Layer (SSL) to encrypt the connection
        /// <summary>
        /// Gets or sets a value indicating whether uses Secure Sockets Layer (SSL) to encrypt the connection.
        /// </summary>
        /// <value>
        /// <see cref="iTin.Export.Model.YesNo.Yes" /> uses Secure Sockets Layer (SSL) to encrypt the connection; otherwise, <see cref="iTin.Export.Model.YesNo.No" />. The default is <see cref="iTin.Export.Model.YesNo.Yes" />.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Credential SSL="Yes|No" .../&gt;
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
        /// &lt;Credential SSL="Yes" Name="firstcredential" UserName="address@gmail.com" password="pwd" Host="smtp.gmail.com"/&gt;
        /// </code>
        /// </example>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>
        [XmlAttribute]
        [DefaultValue(DefaultSSL)]
        public YesNo SSL
        {
            get => _ssl;
            set
            {
                SentinelHelper.IsEnumValid(value);

                _ssl = value;
            }
        }
        #endregion

        #region [public] (string) UserName: Gets or sets the user name associated with the credential
        /// <summary>
        /// Gets or sets the user name associated with the credential.
        /// </summary>
        /// <value>
        /// The user name associated with the credential.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Credential UserName="string" .../&gt;
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
        /// &lt;Credential SSL="Yes" Name="firstcredential" UserName="address@gmail.com" password="pwd" Host="smtp.gmail.com"/&gt;
        /// </code>
        /// </example>
        [XmlAttribute]
        public string UserName { get; set; }
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
        public override bool IsDefault => SSL.Equals(DefaultSSL) &&
                                          Port.Equals(DefaultPort) &&
                                          Domain.Equals(DefaultDomain);
        #endregion

        #endregion

        #region public methods

        #region [public] (void) SetOwner(ServerCredentialsModel): Sets the element that owns this
        /// <summary>
        /// Sets the element that owns this <see cref="T:iTin.Export.Model.ServerCredentialModel" />.
        /// </summary>
        /// <param name="reference">Reference to owner.</param>
        public void SetOwner(ServerCredentialsModel reference)
        {
            _owner = reference;
        }
        #endregion

        #endregion
    }
}
