# TableModel.Output Property 
Additional header content 

Gets or sets a reference to output configuration model, it includes path and file name.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
public OutputModel Output { get; set; }
```

**VB**<br />
``` VB
Public Property Output As OutputModel
	Get
	Set
```


#### Property Value
Type: <a href="T_iTin_Export_Model_OutputModel">OutputModel</a><br />Reference to output configuration model, it includes path and file name.

## Remarks

**TEE Object Element Usage**<br />
``` XML
<Table>
<Output .../>
...
</Table>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td align="center">X</td><td align="center">X</td><td align="center">X</td><td align="center">X</td></tr></table><strong>`X`</strong>


## See Also


#### Reference
<a href="T_iTin_Export_Model_TableModel">TableModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />