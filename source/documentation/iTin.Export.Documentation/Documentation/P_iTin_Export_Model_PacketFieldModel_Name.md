# PacketFieldModel.Name Property 
Additional header content 

Gets or sets the name of the field.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

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
Type: String<br />The name of the field. Are only allow strings made ​​up of letters, numbers and following special chars <strong>'`_ - # * @ % $`'</strong>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td>ArgumentNullException</td><td>If *value* is <strong>null</strong>.</td></tr><tr><td><a href="T_iTin_Export_Model_InvalidFieldIdentifierNameException">InvalidFieldIdentifierNameException</a></td><td>If *value* not is a valid field identifier name.</td></tr></table>

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Field Name="string" ...>
...
</Field>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br />[!:iTin.Export.Writers.Native.CsvWriter]</th><th>Tab-Separated Values<br />[!:iTin.Export.Writers.Native.TsvWriter]</th><th>SQL Script<br />[!:iTin.Export.Writers.Native.SqlScriptWriter]</th><th>XML Spreadsheet 2003<br />[!:iTin.Export.Writers.Native.Spreadsheet2003TabularWriter]</th></tr><tr><td align="center">X</td><td align="center">X</td><td align="center">X</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## See Also


#### Reference
<a href="T_iTin_Export_Model_PacketFieldModel">PacketFieldModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />