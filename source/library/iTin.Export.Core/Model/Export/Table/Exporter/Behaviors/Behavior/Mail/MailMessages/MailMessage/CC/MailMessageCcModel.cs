
namespace iTin.Export.Model
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Linq;
    using System.Xml.Serialization;

    /// <summary>
    /// The address collection that contains the carbon copy (CC) recipients for this e-mail message.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Belongs to: <strong><c>Message</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.MailMessageModel" />.
    /// <code lang="xml" title="ITEE Object Element Usage">
    /// &lt;CC/&gt;
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
    ///       <td><see cref="P:iTin.Export.Model.MailMessageCcModel.Addresses" /></td>
    ///       <td align="center">No</td>
    ///       <td>Collection of e-mail addresses. Separate each e-mail with a blank.</td>
    ///     </tr>
    ///   </tbody>
    /// </table>
    /// <para>
    /// <para><strong>Compatibility table with native writers.</strong></para>
    /// <table>
    ///   <thead>
    ///     <tr>
    ///       <th>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.CsvWriter" /></th>
    ///       <th>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.TsvWriter" /></th>
    ///       <th>SQL Script<br/><see cref="T:iTin.Export.Writers.SqlScriptWriter" /></th>
    ///       <th>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Spreadsheet2003TabularWriter" /></th>
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
    public partial class MailMessageCcModel
    {
        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private MailMessageModel _parent;
        #endregion

        #region public properties

        #region [public] (List<string>) Addresses: Addresses: Gets or sets collection of e-mail addresses
        /// <summary>
        /// Gets or sets collection of e-mail addresses.
        /// </summary>
        /// <value>
        /// Collection of e-mail addresses. Separate each e-mail with a blank.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;CC Addresses="string string ..."/&gt;
        /// </code>
        /// <para>
        /// <para><strong>Compatibility table with native writers.</strong></para>
        /// <table>
        ///   <thead>
        ///     <tr>
        ///       <th>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.CsvWriter" /></th>
        ///       <th>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.TsvWriter" /></th>
        ///       <th>SQL Script<br/><see cref="T:iTin.Export.Writers.SqlScriptWriter" /></th>
        ///       <th>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Spreadsheet2003TabularWriter" /></th>
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
        public List<string> Addresses { get; set; }
        #endregion

        #region [public] (MailMessageModel) Parent: Gets the parent element of the element
        /// <summary>
        /// Gets the parent element of the element.
        /// </summary>
        /// <value>
        /// The element that represents the container element of the element.
        /// </value>
        [Browsable(false)]
        public MailMessageModel Parent => _parent;
        #endregion

        #endregion

        #region public override properties

        #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default
        /// <inheritdoc />
        /// <summary>
        /// Gets a value indicating whether this instance is default.
        /// </summary>
        /// <value>
        /// <strong>true</strong> if this instance contains the default; otherwise <strong>false</strong>.
        /// </value>
        public override bool IsDefault => !Addresses.Any();
        #endregion

        #endregion
            
        #region internal methods

        #region [internal] (void) SetParent(MailMessageModel): Sets the parent element of the element
        /// <summary>
        /// Sets the parent element of the element.
        /// </summary>
        /// <param name="reference">Reference to parent.</param>
        internal void SetParent(MailMessageModel reference)
        {
            _parent = reference;
        }
        #endregion

        #endregion
    }
}
