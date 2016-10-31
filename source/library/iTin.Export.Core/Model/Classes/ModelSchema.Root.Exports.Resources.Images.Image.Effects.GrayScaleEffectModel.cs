using System.Drawing.Imaging;

using iTin.Export.Drawing.Helper;

namespace iTin.Export.Model
{
    /// <summary>
    /// A Specialization of <see cref="T:iTin.Export.Model.BaseEffectModel"/> class.<br/>
    /// Which represents gray-scale effect.
    /// </summary>
    /// <remarks>
    /// <para>Belongs to: <strong><c>Effects</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.ImageEffectsModel" />.<br/>
    /// <code lang="xml" title="AEE Object Element Usage">
    /// &lt;GrayScale/&gt;
    /// </code>
    /// </para>
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
    ///       <td align="center">No has effect</td>
    ///       <td align="center">No has effect</td>
    ///       <td align="center">No has effect</td>
    ///       <td align="center">No has effect</td>
    ///     </tr>
    ///   </tbody>
    /// </table>
    /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
    /// </para>
    /// </remarks>
    /// <example>
    /// <code lang="xml">
    /// &lt;Effects&gt;
    ///   &lt;GrayScale/&gt;
    /// &lt;/Effects&gt;
    /// </code>
    /// </example>
    public partial class GrayScaleEffectModel
    {
        public override ImageAttributes Apply()
        {
            return ImageHelper.GetImageAttributesFromEffect(KnownEffectType.GrayScale);
        }
    }
}
