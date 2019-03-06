# ChartPlotModel.Series Property 
Additional header content 

Gets or sets collection of series for a plot.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public ChartSeriesModel Series { get; set; }
```

**VB**<br />
``` VB
Public Property Series As ChartSeriesModel
	Get
	Set
```


#### Property Value
Type: <a href="T_iTin_Export_Model_ChartSeriesModel">ChartSeriesModel</a><br />Collection of data series for a plot. Each element represents a data serie of a plot.

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Plot ...>
  <Series/>
  ...
</Plot>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br /><a href="T_iTin_Export_Writers_CsvWriter">CsvWriter</a></th><th>Tab-Separated Values<br /><a href="T_iTin_Export_Writers_TsvWriter">TsvWriter</a></th><th>SQL Script<br /><a href="T_iTin_Export_Writers_SqlScriptWriter">SqlScriptWriter</a></th><th>XML Spreadsheet 2003<br /><a href="T_iTin_Export_Writers_Spreadsheet2003TabularWriter">Spreadsheet2003TabularWriter</a></th></tr><tr><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">No has effect</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## See Also


#### Reference
<a href="T_iTin_Export_Model_ChartPlotModel">ChartPlotModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />