
namespace iTin.Export.Model
{
    using Helpers;

    /// <inheritdoc />
    ///  <summary>
    ///  Contains a collection of user-defined styles. Each element includes definition for a font type, type of content, such as the background color, the alignment type and the data type.
    ///  </summary>
    ///  <remarks>
    ///  <para>
    ///  Belongs to: <strong><c>Global.Resources</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.GlobalResourcesModel" />.
    ///  <code lang="xml" title="ITEE Object Element Usage">
    ///  &lt;Images&gt;
    ///    &lt;Image .../&gt;
    ///    &lt;Image .../&gt;
    ///    ...
    ///  &lt;/Images&gt;
    ///  </code>
    ///  </para>    
    ///  <para>Elements</para>
    ///  <list type="table">
    ///    <listheader>
    ///      <term>Element</term>
    ///      <description>Description</description>
    ///    </listheader>
    ///    <item>
    ///      <term><see cref="P:iTin.Export.Model.StylesModel.Items" /></term> 
    ///      <description>Collection of styles. Each element includes definition for a font type, type of content, such as the background color, the alignment type and the data type.</description>
    ///    </item>
    ///  </list>
    ///  <para>
    ///  <para><strong>Compatibility table with native writers.</strong></para>
    ///  <table>
    ///    <thead>
    ///      <tr>
    ///        <th>Comma-Separated Values<br /><see cref="T:iTin.Export.Writers.Native.CsvWriter" /></th>
    ///        <th>Tab-Separated Values<br /><see cref="T:iTin.Export.Writers.Native.TsvWriter" /></th>
    ///        <th>SQL Script<br /><see cref="T:iTin.Export.Writers.Native.SqlScriptWriter" /></th>
    ///        <th>XML Spreadsheet 2003<br /><see cref="T:iTin.Export.Writers.Native.Spreadsheet2003TabularWriter" /></th>
    ///      </tr>
    ///    </thead>
    ///    <tbody>
    ///      <tr>
    ///        <td align="center">X</td>
    ///        <td align="center">X</td>
    ///        <td align="center">X</td>
    ///        <td align="center">X</td>
    ///      </tr>
    ///    </tbody>
    ///  </table>
    ///  A <strong><c>X</c></strong> value indicates that the writer supports this element.
    ///  </para>
    ///  </remarks>
    ///  <example>
    ///  In the following example shows how to add various styles to the list of styles.
    ///  <code lang="xml">
    ///  &lt;?xml version="1.0" encoding="utf-8"?&gt;
    ///  &lt;Exports xmlns="http://schemas.iTin.com/export/engine/2013/configuration"&gt;
    ///    &lt;Global.Resources&gt;
    ///      &lt;Images&gt;
    ///        &lt;Image Key="logo"&gt;       
    ///          &lt;Path&gt;~\Samples\Configuration\Logos\ImageLogo.jpg&lt;/Path&gt;
    ///          &lt;Effects&gt;
    ///            &lt;Dark/&gt;
    ///            &lt;Opacity percent="30"/&gt;
    ///          &lt;/Effects&gt;
    ///        &lt;/Image&gt;
    ///      &lt;/Images&gt;
    ///    &lt;/Global.Resources&gt;
    ///    &lt;Export Name="Test" Current="Yes"&gt;
    ///      &lt;Description&gt;&lt;Sample Export&lt;/Description&gt;
    ///      &lt;Table Name="R740D01"
    ///             AutoFilter="Yes"
    ///             ShowGridLines="No"
    ///             AutoFitColumns="Yes"              
    ///             Alias="Table alias"&gt;
    ///        &lt;Location&gt;
    ///          &lt;ByCoordenates Coordenates="1 3"/&gt;
    ///        &lt;/Location&gt;
    ///        &lt;Logo&gt;
    ///          &lt;Location&gt;
    ///            &lt;ByCoordenates/&gt;
    ///          &lt;/Location&gt;
    ///          &lt;Image ResourceId="logo"/&gt;
    ///        &lt;/Logo&gt;
    ///        &lt;Exporter&gt;
    ///          &lt;Writer Name="XlsxTabularWriter"/&gt;
    ///          &lt;Behaviors&gt;
    ///            &lt;Download/&gt;
    ///          &lt;/Behaviors&gt;
    ///        &lt;/Exporter&gt;
    ///        &lt;Styles&gt;
    ///          &lt;Style Name="CommonHeader"&gt;
    ///            &lt;Content Color="#C9C9C9"&gt;
    ///              &lt;Alignment Horizontal="Center" Vertical="Center"/&gt;
    ///              &lt;Text/&gt;
    ///            &lt;/Content&gt;
    ///            &lt;Font Size="10" Color="Navy" Bold="Yes"/&gt;
    ///          &lt;/Style&gt;
    ///          &lt;Style Name="TopAggregate"&gt;
    ///            &lt;Content Color="#C9C9C9"&gt;
    ///              &lt;Alignment Horizontal="Center"/&gt;
    ///              &lt;Number Decimals="0" Separator="Yes"/&gt;
    ///                &lt;Negative Color="Yellow" Sign="Brackets"/&gt;
    ///              &lt;/Number&gt;
    ///            &lt;/Content&gt;
    ///            &lt;Font Size="10" Color="Navy" Bold="Yes"/&gt;
    ///          &lt;/Style&gt;
    ///          &lt;Style Name="AccountAggregate"&gt;
    ///            &lt;Content Color="Beige"&gt;
    ///              &lt;Alignment Vertical="Bottom" Horizontal="Right"/&gt;
    ///              &lt;Currency Locale="mk"&gt;
    ///                &lt;Negative Color="Red" Sign="Parenthesis"/&gt;
    ///              &lt;/Currency&gt;
    ///            &lt;/Content&gt;
    ///            &lt;Font Name="Arial" Size="12" Color="#C9C9C9" Bold="Yes" Italic="Yes" Underline="Yes"/&gt;
    ///          &lt;/Style&gt;
    ///          &lt;Style Name="NameAggregate"&gt;
    ///            &lt;Content Color="Beige"&gt;
    ///              &lt;Alignment Vertical="Top" Horizontal ="Center"/&gt;
    ///              &lt;Currency Locale="mk"&gt;
    ///                &lt;Negative Color="Red" Sign="Parenthesis"/&gt;
    ///              &lt;/Currency&gt;
    ///            &lt;/Content&gt;
    ///            &lt;Font Name="Arial" Size="26" Color="#C9C9C9" Bold="No" Italic="Yes" Underline="No"/&gt;
    ///          &lt;/Style&gt;
    ///        &lt;/Styles&gt;
    ///        ...
    ///        ...
    ///      &lt;/Table&gt;
    ///    &lt;/Export&gt;
    ///  &lt;/Exports&gt;
    ///  </code>
    ///  </example>
    public partial class ImagesModel
    {
        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="parent"></param>
        public ImagesModel(GlobalResourcesModel parent)
            : base(parent)
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="item"></param>
        protected override void SetOwner(ImageModel item)
        {
            SentinelHelper.ArgumentNull(item);

            item.SetOwner(this);
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public override ImageModel GetBy(string value)
        {
            return Find(s => s.Key.Equals(value));
        }
    }
}
