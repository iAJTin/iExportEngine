# ExporterModel.Behaviors Property 
Additional header content 

Gets or sets collection of writer behaviors.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public BehaviorsModel Behaviors { get; set; }
```

**VB**<br />
``` VB
Public Property Behaviors As BehaviorsModel
	Get
	Set
```


#### Property Value
Type: <a href="T_iTin_Export_Model_BehaviorsModel">BehaviorsModel</a><br />Collection of writer behaviors. Each element is a writer behavior, it execute after export.

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Behaviors>
  <Download .../> | <TransformFile .../> | <Mail .../> | <ToDropbox .../> | <ToSkydrive .../>
  ...
</Behaviors>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td align="center">X</td><td align="center">X</td><td align="center">X</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## Examples
The following example creates collection of behaviors. 
**XML**<br />
``` XML
<Behaviors>
  <Downdload/>
  <TransformFile Save="No"/>
</Behaviors>
```


## See Also


#### Reference
<a href="T_iTin_Export_Model_ExporterModel">ExporterModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />