# FontModel.Italic Property 
Additional header content 

Gets or sets a value indicating whether italic style is applied for this font.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public YesNo Italic { get; set; }
```

**VB**<br />
``` VB
Public Property Italic As YesNo
	Get
	Set
```


#### Property Value
Type: <a href="T_iTin_Export_Model_YesNo">YesNo</a><br />Yes if italic style is applied for this font; otherwise, No. The default is `No`.

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Font Italic="[Yes|No] | [{StaticBinding:...}]".../>
```


<strong>Compatibility table with native writers.</strong>
&nbsp;<table><tr><th>Comma-Separated Values<br /><a href="T_iTin_Export_Writers_CsvWriter">CsvWriter</a></th><th>Tab-Separated Values<br /><a href="T_iTin_Export_Writers_TsvWriter">TsvWriter</a></th><th>SQL Script<br /><a href="T_iTin_Export_Writers_SqlScriptWriter">SqlScriptWriter</a></th><th>XML Spreadsheet 2003<br /><a href="T_iTin_Export_Writers_Spreadsheet2003TabularWriter">Spreadsheet2003TabularWriter</a></th></tr><tr><td>No has effect</td><td>No has effect</td><td>No has effect</td><td>X</td></tr></table>&nbsp;
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