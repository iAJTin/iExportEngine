# FontModel.Name Property 
Additional header content 

Gets or sets preferred font name.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
public string Name { get; set; }
```

**VB**<br />
``` VB
Public Property Name As String
	Get
	Set
```


#### Property Value
Type: String<br />Preferred font name. If specified a font name not existent be use the default font. The default is `Segoe UI`.

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Font Name="[string] | [{StaticBinding:...}]".../>
```


<strong>Compatibility table with native writers.</strong>
&nbsp;<table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td>No has effect</td><td>No has effect</td><td>No has effect</td><td>X</td></tr></table>&nbsp;
A `<b>X</b>` value indicates that the writer supports this element.


## Examples
In the following example shows how create a new font. 
**XML**<br />
``` XML
<Font Name="{StaticBinding:UseThisFontNameFromCode}" Size="8" Color="Navy" Bold="Yes" Italic="Yes" Underline="No"/>
```

**C#**<br />
``` C#
var font = new FontModel
{
    Name = "{StaticBinding:UseThisFontNameFromCode}", // Call UseThisFontNameFromCode user-defined property when trying to get the value of font.Name
    Color = "Navy",
    Size = 8.0,
    Bold = YesNo.Yes,
    Italic = YesNo.Yes,
    Underline = YesNo.No
};
```

**VB**<br />
``` VB
Dim font = New FontModel With
{
    .Name = "{StaticBinding:UseThisFontNameFromCode}", ' Call UseThisFontNameFromCode user-defined property when trying to get the value of font.Name
    .Color = "Navy",
    .Size = 8.0,
    .Bold = YesNo.Yes,
    .Italic = YesNo.Yes,
    .Underline = YesNo.No
}
```


## See Also


#### Reference
<a href="T_iTin_Export_Model_FontModel">FontModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />