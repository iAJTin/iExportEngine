# ChartModel.Axes Property 
Additional header content 

Gets or sets a reference that contains the visual setting of the chart axes.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public ChartAxesModel Axes { get; set; }
```

**VB**<br />
``` VB
Public Property Axes As ChartAxesModel
	Get
	Set
```


#### Property Value
Type: <a href="T_iTin_Export_Model_ChartAxesModel">ChartAxesModel</a><br />A <a href="T_iTin_Export_Model_ChartAxesModel">ChartAxesModel</a> reference that contains the visual setting of the chart axes.

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Chart ...>
  <Axes/>
  ...
</Chart>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">No has effect</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## See Also


#### Reference
<a href="T_iTin_Export_Model_ChartModel">ChartModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />