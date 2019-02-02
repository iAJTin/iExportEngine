# BorderModel.Weight Property 
Additional header content 

Gets or sets preferred border weight.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public KnownWidthLineStyle Weight { get; set; }
```

**VB**<br />
``` VB
Public Property Weight As KnownWidthLineStyle
	Get
	Set
```


#### Property Value
Type: <a href="T_iTin_Export_Model_KnownWidthLineStyle">KnownWidthLineStyle</a><br />Preferred border weight. The default is Hairline.

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Border Weight="Hairline|Thin|Medium|Thick" .../>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## Examples
In the following example shows how create a new border. 
**XML**<br />
``` XML
<Border Position="Bottom" Color="Navy" LineStyle="Dash" Weight="Thick"/>
```

**C#**<br />
``` C#
BorderModel border = new BorderModel
                         {
                             Position = KnownBorderPosition.Bottom,
                             Color = "Navy",
                             Weight = KnownWidthLineStyle.Thick,
                             LineStyle = KnownBorderLineStyle.Dash
                         };
```


## See Also


#### Reference
<a href="T_iTin_Export_Model_BorderModel">BorderModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />