
namespace iTin.Export.Model
{
    using Helper;

    /// <inheritdoc />
    /// <summary>
    /// Contains a collection of pieces. Each element is a new collection of smaller fields resulting from splitting a reference field.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Belongs to: <strong><c>Fixed</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.FixedModel" />.
    /// <code lang="xml" title="ITEE Object Element Usage">
    /// &lt;Pieces ...&gt;
    ///   &lt;Piece/&gt;
    ///   &lt;Piece/&gt;
    ///   ... 
    /// &lt;/Pieces&gt;
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
    ///       <td><see cref="P:iTin.Export.Model.PiecesModel.Name" /></td>
    ///       <td align="center">No</td>
    ///       <td>Name of the collection of pieces.</td>
    ///     </tr>
    ///     <tr>
    ///       <td><see cref="P:iTin.Export.Model.PiecesModel.Reference" /></td>
    ///       <td align="center">No</td>
    ///       <td>Data field name reference.</td>
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
    ///     <term><see cref="P:iTin.Export.Model.PiecesModel.Pieces" /></term> 
    ///     <description>Collection of smaller fields resulting from splitting a reference field. Each element is composed of a field name and initial position and final position into the reference field.</description>
    ///   </item>
    /// </list>
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
    public partial class PiecesModel
    {
        #region constructor/s

        #region [public] PiecesModel(FixedItemModel):
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Export.Model.PiecesModel" /> class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        public PiecesModel(FixedItemModel parent)
            : base(parent)
        {
        }
        #endregion

        #endregion

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="item"></param>
        protected override void SetOwner(PieceModel item)
        {
            SentinelHelper.ArgumentNull(item);

            item.SetOwner(this);
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public override PieceModel GetBy(string value)
        {
            return string.IsNullOrEmpty(value)
                ? null
                : Find(s => s.Name.Equals(value));
        }
    }
}
