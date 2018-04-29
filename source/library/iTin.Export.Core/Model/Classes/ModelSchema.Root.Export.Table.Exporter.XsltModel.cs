
namespace iTin.Export.Model
{
    using System.Diagnostics;

    using Helpers;

    /// <inheritdoc />
    /// <summary>
    /// Represents an exporter based on xslt transformation file.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Belongs to: <strong><c>Exporter</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.ExporterModel" />.
    /// <code lang="xml" title="ITEE Object Element Usage">
    /// &lt;Xslt&gt;
    ///   &lt;File/&gt;
    /// &lt;/Group&gt;
    /// </code>
    /// </para>    
    /// <para><strong>Elements</strong></para>
    /// <list type="table">
    ///   <listheader>
    ///     <term>Element</term>
    ///     <description>Description</description>
    ///   </listheader>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.XsltModel.File" /></term> 
    ///     <description>The xslt file name.</description>
    ///   </item>
    /// </list>
    /// </remarks>
    public partial class XsltModel
    {
        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _file;
        #endregion

        #region public properties

        #region [public] (string) File: Gets or sets the xslt file. To specify a relative path use the character (~)
        /// <summary>
        /// Gets or sets the xslt file. To specify a relative path use the character (~).
        /// </summary>
        /// <value>
        /// The xslt file. To specify a relative path use the character (~).
        /// </value>
        /// <remarks>
        /// <code lang="xml" title="ITEE Object Element Usage">
        /// &lt;Xslt&gt;
        ///   &lt;File&gt;string&lt;/Path&gt;
        /// &lt;/Xslt&gt;
        /// </code>
        /// </remarks>
        /// <example>
        /// The following example show how to use this element.
        /// <code lang="xml">
        /// &lt;?xml version="1.0" encoding="utf-8"?&gt;
        /// 
        /// &lt;Exports xmlns="http://schemas.iTin.com/export/engine/2013/configuration"&gt;
        ///   &lt;Export Name="Test" Current="Yes"&gt;
        ///     &lt;Description&gt;Sample Export&lt;/Description&gt;
        ///     &lt;Table Name="R740D01"&gt;
        ///       &lt;Exporter&gt;
        ///         &lt;Xslt/&gt;
        ///           &lt;File&gt;~\Templates\TransformFile.xslt&lt;/File&gt;
        ///         &lt;/Xslt&gt;
        ///       &lt;/Exporter&gt;
        ///   
        ///       &lt;Output&gt;
        ///         &lt;File&gt;SampleExport&lt;/File&gt;
        ///         &lt;Path&gt;~\Samples\Output\Writers&lt;/Path&gt;
        ///       &lt;/Output&gt;
        ///     &lt;/Table&gt;
        ///   &lt;/Export&gt;
        /// &lt;/Exports&gt;
        /// </code>
        /// </example>
        /// <exception cref="System.ArgumentNullException">If <paramref name="value" /> is <strong>null</strong>.</exception>
        /// <exception cref="iTin.Export.Model.InvalidPathNameException">If <paramref name="value" /> is an invalid path name.</exception>
        public string File
        {
            get => _file;
            set
            {
                SentinelHelper.ArgumentNull(value);
                SentinelHelper.IsFalse(RegularExpressionHelper.IsValidPath(value), new InvalidPathNameException(ErrorMessageHelper.ModelPathErrorMessage("File", value)));

                _file = value;
            }
        }
        #endregion

        #endregion
    }
}
