
namespace iTin.Export.Model
{
    using System;

    /// <summary>
    /// A Specialization of <see cref="NumericErrorModel" /> class.
    /// Represents the error structure for scientific data type. Allows us to set a default value and an additional comment.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Belongs to: <strong><c>Scientific</c></strong>. For more information, please see <see cref="iTin.Export.Model.ScientificDataTypeModel" />.
    /// <code lang="xml" title="ITEE Object Element Usage">
    /// &lt;Error&gt;
    ///   &lt;Comment/&gt;
    /// &lt;/Error&gt;
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
    ///       <td><see cref="P:iTin.Export.Model.NumericErrorModel.Value" /></td>
    ///       <td align="center">Yes</td>
    ///       <td>Preferred default value when occurs an error. The default is <c>0.0</c>.</td>
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
    ///     <term><see cref="P:iTin.Export.Model.BaseErrorModel.Comment" /></term> 
    ///     <description>Reference for error comment. Includes comment text, format, including font face, size, and style attributes.</description>
    ///   </item>
    /// </list>
    /// <para>
    /// <para><strong>Compatibility table with native writers.</strong></para>
    /// <table>
    ///   <thead>
    ///     <tr>
    ///       <th>Comma-Separated Values<br/><see cref="iTin.Export.Writers.Native.CsvWriter" /></th>
    ///       <th>Tab-Separated Values<br/><see cref="iTin.Export.Writers.Native.TsvWriter" /></th>
    ///       <th>SQL Script<br/><see cref="iTin.Export.Writers.Native.SqlScriptWriter" /></th>
    ///       <th>XML Spreadsheet 2003<br/><see cref="iTin.Export.Writers.Native.Spreadsheet2003TabularWriter" /></th>
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
    /// In the following example shows how create a new style with a scientific data type.
    /// <code lang="xml">
    /// &lt;Style Name="Scientific"&gt;
    ///   &lt;Content Color="White"&gt;
    ///     &lt;Scientific Decimals="3"&gt;
    ///       &lt;Error Value="-9999"&gt;
    ///         &lt;Comment Show="Yes"&gt;
    ///           &lt;Text>Wrong value: &lt;/Text&gt;
    ///         &lt;/Comment&gt;
    ///       &lt;/Error&gt;           
    ///     &lt;/Scientific&gt;
    ///   &lt;/Content&gt;
    /// &lt;/Style&gt;
    /// </code>
    /// </example>
    public partial class ScientificErrorModel : ICloneable
    {
        #region public methods

        #region [public] {new} (ScientificErrorModel) Clone(): Clones this instance
        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public new ScientificErrorModel Clone()
        {
            var scientificErrorCloned = (ScientificErrorModel)MemberwiseClone();
            scientificErrorCloned.Comment = Comment.Clone();
            scientificErrorCloned.Properties = Properties.Clone();

            return scientificErrorCloned;
        }
        #endregion

        #endregion

        #region private methods

        #region [private] (object) Clone(): Creates a new object that is a copy of the current instance
        /// <inheritdoc />
        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
        /// <returns>
        /// A new object that is a copy of this instance.
        /// </returns>
        object ICloneable.Clone()
        {
            return Clone();
        }
        #endregion

        #endregion
    }
}
