
namespace iTin.Export.Model
{
    using System;

    /// <summary>
    /// A Specialization of <see cref="T:iTin.Export.Model.BaseDataTypeModel" /> class.<br />
    /// Treats the content as text and displays the content exactly as written, even when numbers are typed.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Belongs to: <strong><c>Content</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.ContentModel" />.
    /// <code lang="xml" title="ITEE Object Element Usage">
    /// &lt;Text/&gt;
    /// </code>
    /// </para>
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
    /// The following example indicate that the content should be text type.
    /// <code lang="xml">
    /// &lt;Style Name="PurchaseOrderValue"&gt;
    ///   &lt;Content Color="White"&gt;
    ///     &lt;Text/&gt;
    ///   &lt;/Content&gt;
    ///   &lt;Font Size="10"/&gt;
    /// &lt;/Style&gt;
    /// </code>
    /// </example>
    public partial class TextDataTypeModel : ICloneable
    {
        #region public methods

        #region [public] {new} (TextDataTypeModel) Clone(): Clones this instance
        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public new TextDataTypeModel Clone()
        {
            var textDataTypeCloned = (TextDataTypeModel)MemberwiseClone();
            textDataTypeCloned.Properties = Properties.Clone();

            return textDataTypeCloned;
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
