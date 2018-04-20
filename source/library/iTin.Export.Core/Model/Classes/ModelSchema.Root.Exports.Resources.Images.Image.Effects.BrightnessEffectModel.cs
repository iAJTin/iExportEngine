
namespace iTin.Export.Model
{
    using System.Drawing.Imaging;

    using iTin.Export.Drawing.Helper;

    /// <summary>
    /// A Specialization of <see cref="T:iTin.Export.Model.BaseEffectModel"/> class.<br/>
    /// Which represents brightness effect.
    /// </summary>
    /// <remarks>
    /// <para>Belongs to: <strong><c>Effects</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.ImageEffectsModel" />.<br/>
    /// <code lang="xml" title="AEE Object Element Usage">
    /// &lt;Brightness/&gt;
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
    ///   &lt;Brightness/&gt;
    /// &lt;/Effects&gt;
    /// </code>
    /// </example>
    public partial class BrightnessEffectModel
    {
        public override ImageAttributes Apply()
        {
            return ImageHelper.GetImageAttributesFromEffect(KnownEffectType.Dark);
        }
    }
}
