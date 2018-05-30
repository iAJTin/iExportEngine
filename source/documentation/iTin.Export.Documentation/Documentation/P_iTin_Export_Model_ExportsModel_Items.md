# ExportsModel.Items Property 
Additional header content 

Gets or sets collection of export configurations.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
public List<ExportModel> Items { get; set; }
```

**VB**<br />
``` VB
Public Property Items As List(Of ExportModel)
	Get
	Set
```


#### Property Value
Type: List(<a href="T_iTin_Export_Model_ExportModel">ExportModel</a>)<br />Collection of export configurations. Each element is composed of a description and a data table definition.

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Exports>
  <Export .../>
  <Export .../>
  ...
</Exports>
```


## See Also


#### Reference
<a href="T_iTin_Export_Model_ExportsModel">ExportsModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />