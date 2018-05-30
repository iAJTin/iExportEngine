# StyleModel.Content Property 
Additional header content 

Gets or sets a reference to the content model.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
public ContentModel Content { get; set; }
```

**VB**<br />
``` VB
Public Property Content As ContentModel
	Get
	Set
```


#### Property Value
Type: <a href="T_iTin_Export_Model_ContentModel">ContentModel</a><br />Reference that contains the definition of as shown the content of a field.

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Style>
  <Content>
</Style>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td align="center">X</td><td align="center">X</td><td align="center">X</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## See Also


#### Reference
<a href="T_iTin_Export_Model_StyleModel">StyleModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />