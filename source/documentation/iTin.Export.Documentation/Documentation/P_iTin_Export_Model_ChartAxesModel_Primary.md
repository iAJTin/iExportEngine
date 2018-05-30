# ChartAxesModel.Primary Property 
Additional header content 

Gets or sets a reference to information of primary axes.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
public AxisModel Primary { get; set; }
```

**VB**<br />
``` VB
Public Property Primary As AxisModel
	Get
	Set
```


#### Property Value
Type: <a href="T_iTin_Export_Model_AxisModel">AxisModel</a><br />An <a href="T_iTin_Export_Model_AxisModel">AxisModel</a> reference that contains information of primary axes. Includes information for the category and value axes.

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Axes>
  <Primary/>
  ...
</Axes>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">No has effect</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## See Also


#### Reference
<a href="T_iTin_Export_Model_ChartAxesModel">ChartAxesModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />