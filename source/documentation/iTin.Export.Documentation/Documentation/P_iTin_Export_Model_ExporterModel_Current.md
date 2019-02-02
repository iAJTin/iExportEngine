# ExporterModel.Current Property 
Additional header content 

Gets or sets a reference to the exporter to be used for export.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public Object Current { get; set; }
```

**VB**<br />
``` VB
Public Property Current As Object
	Get
	Set
```


#### Property Value
Type: Object<br />Reference to the exporter to be used for export.

## Remarks

The following table shows the different exporters types.
&nbsp;<table><tr><th>Exporter</th><th>Description</th></tr><tr><td><a href="T_iTin_Export_Model_TemplateModel">TemplateModel</a></td><td>Represents an exporter based on a template file.</td></tr><tr><td><a href="T_iTin_Export_Model_WriterModel">WriterModel</a></td><td>Represents an exporter based on a custom writer.</td></tr><tr><td><a href="T_iTin_Export_Model_XsltModel">XsltModel</a></td><td>Represents an exporter based on xslt transformation file.</td></tr></table>

## See Also


#### Reference
<a href="T_iTin_Export_Model_ExporterModel">ExporterModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />