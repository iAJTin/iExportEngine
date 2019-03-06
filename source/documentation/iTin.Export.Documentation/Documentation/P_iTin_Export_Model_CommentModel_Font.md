# CommentModel.Font Property 
Additional header content 

Gets or sets the font model.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public FontModel Font { get; set; }
```

**VB**<br />
``` VB
Public Property Font As FontModel
	Get
	Set
```


#### Property Value
Type: <a href="T_iTin_Export_Model_FontModel">FontModel</a><br />Reference that contains the definition of a font.

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Comment>
  <Font/>
</Comment>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br /><a href="T_iTin_Export_Writers_CsvWriter">CsvWriter</a></th><th>Tab-Separated Values<br /><a href="T_iTin_Export_Writers_TsvWriter">TsvWriter</a></th><th>SQL Script<br /><a href="T_iTin_Export_Writers_SqlScriptWriter">SqlScriptWriter</a></th><th>XML Spreadsheet 2003<br /><a href="T_iTin_Export_Writers_Spreadsheet2003TabularWriter">Spreadsheet2003TabularWriter</a></th></tr><tr><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## See Also


#### Reference
<a href="T_iTin_Export_Model_CommentModel">CommentModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />