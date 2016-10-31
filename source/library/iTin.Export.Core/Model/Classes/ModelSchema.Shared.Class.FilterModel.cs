using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

using iTin.Export.Helper;

namespace iTin.Export.Model
{
    /// <summary>
    /// Reference to set of properties that allow you to specify a writer.
    /// </summary>
    /// <remarks>
    /// <para>
    /// <code lang="xml" title="AEE Object Element Usage">
    /// &lt;Filter .../&gt;
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
    ///       <td><see cref="P:iTin.Export.Model.FilterModel.Author" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Author of writer. Select * for any author. The default is "<c>*</c>".</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.FilterModel.Company" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Company name of the writer. Select * for any author. The default is "<c>*</c>".</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.FilterModel.Version" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Version of the writer, value greater than 0. Select * for any author. The default is "<c>*</c>".</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.FilterModel.Path" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Path where is located the writer. To specify a relative path use the character (~). The default is "<c>Default</c>".</td>
    ///     </tr>
    ///   </tbody>
    /// </table>
    /// </remarks>
    public partial class FilterModel
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string DefaultAuthor = "*";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string DefaultCompany = "*";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string DefaultVersion = "*";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string DefaultPath = "Default";
        #endregion
        
        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _path;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private WriterModelBase _parent;
        #endregion

        #region constructor/s

            #region [public] FilterModel(): Initializes a new instance of this class.
            /// <summary>
            /// Initializes a new instance of the <see cref="T:iTin.Export.Model.FilterModel"/> class.
            /// </summary>
            public FilterModel()
            {
                Path = DefaultPath;
                Author = DefaultAuthor;
                Company = DefaultCompany;
                Version = DefaultVersion;
            }
            #endregion

        #endregion

        #region public properties

            #region [public] (string) Author: Gets or sets the author of writer.
            /// <summary>
            /// Gets or sets the author of writer. Select * for any author.
            /// </summary>
            /// <value>
            /// Author of writer. Select * for any author. The default is "<c>*</c>".
            /// </value>
            /// <remarks>
            /// <code lang="xml" title="AEE Object Element Usage">
            /// &lt;Filter Author="*|string" .../&gt;
            /// </code>
            /// </remarks>
            [XmlAttribute]
            [DefaultValue(DefaultAuthor)]
            public string Author { get; set; }
            #endregion

            #region [public] (string) Company: Gets or sets the company name of the writer.
            /// <summary>
            /// Gets or sets the company name of the writer.
            /// </summary>
            /// <value>
            /// Company name of the writer. Select * for any author. The default is "<c>*</c>".
            /// </value>
            /// <remarks>
            /// <code lang="xml" title="AEE Object Element Usage">
            /// &lt;Filter Company="*|string" .../&gt;
            /// </code>
            /// </remarks>
            [XmlAttribute]
            [DefaultValue(DefaultCompany)]
            public string Company { get; set; }
            #endregion

            #region [public] (string) Version: Gets or sets the version of the writer.
            /// <summary>
            /// Gets or sets the version of the writer.
            /// </summary>
            /// <value>
            /// Version of the writer, value greater than 0. Select * for any author. The default is "<c>*</c>".
            /// </value>
            /// <remarks>
            /// <code lang="xml" title="AEE Object Element Usage">
            /// &lt;Filter Version="*|string" .../&gt;
            /// </code>
            /// </remarks>
            [XmlAttribute]
            [DefaultValue(DefaultVersion)]
            public string Version { get; set; }
            #endregion

            #region [public] (WriterModelBase) Parent: Gets the parent element of the element.
            /// <summary>
            /// Gets the parent element of the element.
            /// </summary>
            /// <value>
            /// The element that represents the container element of the element.
            /// </value>
            [XmlIgnore]
            [Browsable(false)]
            public WriterModelBase Parent
            {
                get { return _parent; }
            }
            #endregion

            #region [public] (string) Path: Gets or sets the path where is located the writer.
            /// <summary>
            /// Gets or sets the path where is located the writer.
            /// </summary>
            /// <value>
            /// Path where is located the writer. To specify a relative path use the character (~). The default is "<c>Default</c>".
            /// </value>
            /// <remarks>
            /// <code lang="xml" title="AEE Object Element Usage">
            /// &lt;Filter Path="Default|string" .../&gt;
            /// </code>
            /// </remarks>
            /// <exception cref="T:System.ArgumentNullException">If <paramref name="value" /> is <strong>null</strong>.</exception>
            /// <exception cref="T:iTin.Export.Model.InvalidPathNameException">If <paramref name="value" /> is an invalid path name.</exception>
            [XmlAttribute]
            [DefaultValue(DefaultPath)]
            public string Path
            {
                get
                {
                    return _path;
                }
                set
                {
                    SentinelHelper.ArgumentNull(value);
                    SentinelHelper.IsFalse(RegularExpressionHelper.IsValidPath(value), new InvalidPathNameException(ErrorMessageHelper.ModelPathErrorMessage("Path", value)));

                    _path = value;
                }
            }
            #endregion

            #region [public] (KnownWriterFilter) WriterStyles: Gets a value that represents the different attributes defined for a writer.
            /// <summary>
            ///  Gets a value that represents the different attributes defined for a writer.
            /// </summary>
            /// <value>
            /// Writer attributes.
            /// </value>
            public KnownWriterFilter WriterStyles
            {
                get
                {
                    var writerStyles = KnownWriterFilter.Name;
                    if (!Author.Equals(DefaultAuthor))
                    {
                        writerStyles = writerStyles | KnownWriterFilter.Author;
                    }

                    if (!Version.Equals(DefaultVersion))
                    {
                        writerStyles = writerStyles | KnownWriterFilter.Version;
                    }

                    if (!Company.Equals(DefaultCompany))
                    {
                        writerStyles = writerStyles | KnownWriterFilter.Company;
                    }

                    return writerStyles;
                }
            }
            #endregion

        #endregion

        #region public override properties

            #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default.
            /// <summary>
            /// Gets a value indicating whether this instance is default.
            /// </summary>
            /// <value>
            /// <strong>true</strong> if this instance contains the default; otherwise <strong>false</strong>.
            /// </value>
            public override bool IsDefault
            {
                get
                {
                    return Path.Equals(DefaultPath) &&
                           Author.Equals(DefaultAuthor) &&
                           Company.Equals(DefaultCompany) &&
                           Version.Equals(DefaultVersion);
                }
            }
            #endregion

        #endregion     

        #region internal methods

            #region [internal] (void) SetParent(WriterModelBase): Sets the parent element of the element.
            /// <summary>
            /// Sets the parent element of the element.
            /// </summary>
            /// <param name="reference">Reference to parent.</param>
            internal void SetParent(WriterModelBase reference)
            {
                _parent = reference;
            }
            #endregion

        #endregion
    }
}
