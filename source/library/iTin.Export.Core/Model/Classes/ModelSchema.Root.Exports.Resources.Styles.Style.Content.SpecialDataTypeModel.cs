using System.Xml.Serialization;

namespace iTin.Export.Model
{
    /// <summary>
    /// A Specialization of <see cref="T:iTin.Export.Model.BaseDataTypeModel" /> class.<br/>
    /// Displays a number as a short date or as a long date.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Belongs to: <strong><c>Content</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.ContentModel" />.
    /// <code lang="xml" title="AEE Object Element Usage">
    /// &lt;Special .../&gt;
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
    ///       <td><see cref="P:iTin.Export.Model.SpecialDataTypeModel.Format" /></td>
    ///       <td align="center">No</td>
    ///       <td>Use this attribute for indicates a special format.</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.SpecialDataTypeModel.StartsWithYear" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Determines whether starts with the year. The default is <see cref="iTin.Export.Model.YesNo.No" />.</td>
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
    /// The following example indicate that the content should be special type.
    /// <code lang="xml">
    /// &lt;Style Name="DueDateValue"&gt;
    ///   &lt;Content Color="White"&gt;
    ///     &lt;Special Format="ShortDateFormat" StartWithYear="No"/&gt;
    ///   &lt;/Content&gt;
    ///   &lt;Font Size="10"/&gt;
    /// &lt;/Style&gt;
    /// </code>
    /// </example>
    public partial class SpecialDataTypeModel
    {
        #region public properties

            #region [public] (string) Format: Gets or sets a value that indicates the special format.
            /// <summary>
            /// Gets or sets a value that indicates the special format.
            /// </summary>
            /// <value>
            /// One of the <see cref="T:iTin.Export.Model.KnownSpecialFormat" /> values.
            /// </value>
            /// <remarks>
            /// <code lang="xml" title="AEE Object Element Usage">
            /// &lt;Special Format="FullDateFormat|ShortDateFormat|LongDateFormat"/&gt;
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
            ///       <td align="center">No has effect</td>
            ///     </tr>
            ///   </tbody>
            /// </table>
            /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
            /// </para>
            /// </remarks>
            /// <example>
            /// The following example indicate that the content should be special type.
            /// <code lang="xml">
            /// &lt;Style Name="DueDateValue"&gt;
            ///   &lt;Content Color="White"&gt;
            ///     &lt;Special Format="ShortDateFormat"/&gt;
            ///   &lt;/Content&gt;
            ///   &lt;Font Size="10"/&gt;
            /// &lt;/Style&gt;
            /// </code>
            /// </example>
            /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value specified is outside the range of valid values.</exception>  
            [XmlAttribute]
            public string Format { get; set; }
            #endregion

        #endregion
    }
}
