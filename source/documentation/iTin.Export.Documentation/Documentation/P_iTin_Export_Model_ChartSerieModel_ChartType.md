# ChartSerieModel.ChartType Property 
Additional header content 

Gets or sets preferred chart type.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
public KnownChartType ChartType { get; set; }
```

**VB**<br />
``` VB
Public Property ChartType As KnownChartType
	Get
	Set
```


#### Property Value
Type: <a href="T_iTin_Export_Model_KnownChartType">KnownChartType</a><br />One of <a href="T_iTin_Export_Model_KnownChartType">KnownChartType</a> values.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td>InvalidEnumArgumentException</td><td>The value specified is outside the range of valid values.</td></tr></table>

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Serie ChartType="string" .../>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">No has effect</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## See Also


#### Reference
<a href="T_iTin_Export_Model_ChartSerieModel">ChartSerieModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />