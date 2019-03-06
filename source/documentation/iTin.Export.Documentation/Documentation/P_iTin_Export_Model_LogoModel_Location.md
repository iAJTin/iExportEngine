# LogoModel.Location Property 
Additional header content 

Gets or sets a reference which contains the location of the logo in the host, this can be by coordinates or by type of alignment, depending whether the host has or not a tabular format. You can only choose one of the modes. If this tag does not define the defaults is by coordinates

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
Type: <a href="T_iTin_Export_Model_LocationModel">LocationModel</a><br />Reference to location of the logo in the host.

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Logo>
  <Location .../>
  ...
</Logo>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br /><a href="T_iTin_Export_Writers_CsvWriter">CsvWriter</a></th><th>Tab-Separated Values<br /><a href="T_iTin_Export_Writers_TsvWriter">TsvWriter</a></th><th>SQL Script<br /><a href="T_iTin_Export_Writers_SqlScriptWriter">SqlScriptWriter</a></th><th>XML Spreadsheet 2003<br /><a href="T_iTin_Export_Writers_Spreadsheet2003TabularWriter">Spreadsheet2003TabularWriter</a></th></tr><tr><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## See Also


#### Reference
<a href="T_iTin_Export_Model_LogoModel">LogoModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />