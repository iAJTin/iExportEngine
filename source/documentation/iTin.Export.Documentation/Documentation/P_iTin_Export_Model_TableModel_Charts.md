# TableModel.Charts Property 
Additional header content 

Gets or sets collection of user-defined charts.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
public ChartsModel Charts { get; set; }
```

**VB**<br />
``` VB
Public Property Charts As ChartsModel
	Get
	Set
```


#### Property Value
Type: <a href="T_iTin_Export_Model_ChartsModel">ChartsModel</a><br />Collection of user-defined charts. Each element represents a user-defined chart.

## Remarks

**TEE Object Element Usage**<br />
``` XML
<Table>
<Charts .../>
...
</Table>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">No has effect</td></tr></table><strong>`X`</strong>


## See Also


#### Reference
<a href="T_iTin_Export_Model_TableModel">TableModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />