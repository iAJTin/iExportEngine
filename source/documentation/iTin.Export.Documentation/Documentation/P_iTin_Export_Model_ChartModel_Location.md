# ChartModel.Location Property 
Additional header content 

Gets or sets a reference which contains the chart location on the host, this can be by coordinates or by type of alignment, depending whether the host has or not a tabular format. You can only choose one of the modes. If this tag does not define the defaults is by coordinates

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public LocationModel Location { get; set; }
```

**VB**<br />
``` VB
Public Property Location As LocationModel
	Get
	Set
```


#### Property Value
Type: <a href="T_iTin_Export_Model_LocationModel">LocationModel</a><br />A <a href="T_iTin_Export_Model_LocationModel">LocationModel</a> reference that contains the chart location.

## Remarks

**TEE Object Element Usage**<br />
``` XML
<Chart ...>
  <Location/>
  ...
</Chart>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">No has effect</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## See Also


#### Reference
<a href="T_iTin_Export_Model_ChartModel">ChartModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />