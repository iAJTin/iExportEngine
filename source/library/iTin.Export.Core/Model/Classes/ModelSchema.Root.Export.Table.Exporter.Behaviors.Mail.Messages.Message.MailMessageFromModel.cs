
namespace iTin.Export.Model
{
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Xml.Serialization;

    using Helpers;

    /// <summary>
    /// Represents the from address for this e-mail message.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Belongs to: <strong><c>Message</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.MailMessageModel" />.
    /// <code lang="xml" title="ITEE Object Element Usage">
    /// &lt;From/&gt;
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
    ///       <td><see cref="P:iTin.Export.Model.MailMessageFromModel.Address" /></td>
    ///       <td align="center">No</td>
    ///       <td>A valid e-mail address.</td>
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
    public partial class MailMessageFromModel
    {
        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _address;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private MailMessageModel _parent;
        #endregion

        #region public properties

        #region [public] (string) Address: Gets or sets a e-mail address
        /// <summary>
        /// Gets or sets a e-mail address.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String"/> that contains a valid e-mail address.
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;From Address="string"/&gt;
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
        public string Address
        {
            get => _address;
            set
            {
                var isValidAddress = false;
                if (!string.IsNullOrEmpty(value))
                {
                    isValidAddress = RegularExpressionHelper.IsValidMailAddress(value);
                }

                _address = isValidAddress 
                    ? value 
                    : string.Empty;
            }
        }
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
        /// <include file="..\..\iTin.Export.Documentation.Common.xml" path="Common/Model/Public/Overrides/Properties/Property[@name='IsDefault']/*" />
        public override bool IsDefault => Address.Equals(string.Empty);
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
