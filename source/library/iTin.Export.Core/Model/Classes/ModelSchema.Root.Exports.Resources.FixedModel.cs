
namespace iTin.Export.Model
{
    using Helpers;

    /// <inheritdoc />
    /// <summary>
    /// Collection of user-defined pieces. Each element is a collection of smaller pieces result of splitting the reference field.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Belongs to: <strong><c>Table</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.TableModel" />.
    /// <code lang="xml" title="ITEE Object Element Usage">
    /// &lt;Fixed&gt;
    ///   &lt;Pieces/&gt;
    ///   &lt;Pieces/&gt;
    ///   ...
    /// &lt;/Fixed&gt;
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
    public partial class FixedModel
    {
        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="parent"></param>
        public FixedModel(GlobalResourcesModel parent)
            : base(parent)
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="item"></param>
        protected override void SetOwner(FixedItemModel item)
        {
            SentinelHelper.ArgumentNull(item);

            item.SetOwner(this);
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public override FixedItemModel GetBy(string value)
        {
            return string.IsNullOrEmpty(value)
                ? null
                : Find(s => s.Name.Equals(value));
        }
    }
}
