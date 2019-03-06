# DocumentModel.Margins Property 
Additional header content 

Gets or sets a reference to configuration of margins, it allow define top margin, right margin, bottom margin and left margin of a document.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public MarginsModel Margins { get; set; }
```

**VB**<br />
``` VB
Public Property Margins As MarginsModel
	Get
	Set
```


#### Property Value
Type: <a href="T_iTin_Export_Model_MarginsModel">MarginsModel</a><br />Reference to configuration of margins, it allow define top margin, right margin, bottom margin and left margin of a document.

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Document>
  <Margins .../>
  ...
</Document>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br /><a href="T_iTin_Export_Writers_CsvWriter">CsvWriter</a></th><th>Tab-Separated Values<br /><a href="T_iTin_Export_Writers_TsvWriter">TsvWriter</a></th><th>SQL Script<br /><a href="T_iTin_Export_Writers_SqlScriptWriter">SqlScriptWriter</a></th><th>XML Spreadsheet 2003<br /><a href="T_iTin_Export_Writers_Spreadsheet2003TabularWriter">Spreadsheet2003TabularWriter</a></th></tr><tr><td align="center">X</td><td align="center">X</td><td align="center">X</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## See Also


#### Reference
<a href="T_iTin_Export_Model_DocumentModel">DocumentModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />