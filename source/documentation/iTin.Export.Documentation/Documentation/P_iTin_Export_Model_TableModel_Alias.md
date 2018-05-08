# TableModel.Alias Property 
Additional header content 

Gets or sets the alias of the table.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
public string Alias { get; set; }
```

**VB**<br />
``` VB
Public Property Alias As String
	Get
	Set
```


#### Property Value
Type: String<br />The alias of the table. The default is an empty string ("").

## Remarks

**TEE Object Element Usage**<br />
``` XML
<Table Alias="string" ...>
...
</Table>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">X</td></tr></table><strong>`X`</strong>


## Examples

**XML**<br />
``` XML
<Table Alias="Sample alias">
...
</Table>
```

**C#**<br />
``` C#
...
TableModel table = new TableModel
{
Name = "Sample name",
Alias = "Sample alias",
AutoFilter = YesNo.Yes,
Location = new[] { 2, 2 },
AutoFitColumns = YesNo.Yes,
} ;
...
```


## See Also


#### Reference
<a href="T_iTin_Export_Model_TableModel">TableModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />