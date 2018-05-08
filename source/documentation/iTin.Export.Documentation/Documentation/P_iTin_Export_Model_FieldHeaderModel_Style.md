# FieldHeaderModel.Style Property 
Additional header content 

Gets or sets one of the styles defined in the element styles.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
public string Style { get; set; }
```

**VB**<br />
``` VB
Public Property Style As String
	Get
	Set
```


#### Property Value
Type: String<br />Name of a style defined in the list of styles. Are only allow strings made ​​up of letters, numbers and following special chars <strong>'`_ - # @ % $`'</strong>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td>ArgumentNullException</td><td>If *value* is <strong>null</strong>.</td></tr><tr><td><a href="T_iTin_Export_Model_InvalidIdentifierNameException">InvalidIdentifierNameException</a></td><td>*value* not is a valid identifier name.</td></tr></table>

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Header Style="string" ...>
...
</Header>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td align="center">X</td><td align="center">X</td><td align="center">X</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## See Also


#### Reference
<a href="T_iTin_Export_Model_FieldHeaderModel">FieldHeaderModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />