# FontModel.Underline Property 
Additional header content 

Gets or sets a value indicating whether the underline style is applied for this font.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
public YesNo Underline { get; set; }
```

**VB**<br />
``` VB
Public Property Underline As YesNo
	Get
	Set
```


#### Property Value
Type: <a href="T_iTin_Export_Model_YesNo">YesNo</a><br /><a href="T_iTin_Export_Model_YesNo">Yes</a> if the underline style is applied for this font; otherwise, <a href="T_iTin_Export_Model_YesNo">No</a>. The default is <a href="T_iTin_Export_Model_YesNo">No</a>.

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Font Underline="[Yes|No] | [{StaticBinding:...}]".../>
```


<strong>Compatibility table with native writers.</strong>
&nbsp;<table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td>No has effect</td><td>No has effect</td><td>No has effect</td><td>X</td></tr></table>&nbsp;
A <strong>`X`</strong> value indicates that the writer supports this element.


## Examples
In the following example shows how create a new font. 
**XML**<br />
``` XML
<Font Name="Tahoma" Size="8" Color="Navy" Bold="Yes" Italic="Yes" Underline="No"/>
```

**C#**<br />
``` C#
var font = new FontModel
{
    Name = "Tahoma",
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
    .Name = "Tahoma",
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