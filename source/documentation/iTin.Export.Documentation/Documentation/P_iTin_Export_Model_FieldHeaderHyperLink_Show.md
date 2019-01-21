# FieldHeaderHyperLink.Show Property 
Additional header content 

Gets or sets a value that determines whether displays hyperlink. The default is <a href="T_iTin_Export_Model_YesNo">No</a>.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public YesNo Show { get; set; }
```

**VB**<br />
``` VB
Public Property Show As YesNo
	Get
	Set
```


#### Property Value
Type: <a href="T_iTin_Export_Model_YesNo">YesNo</a><br /><a href="T_iTin_Export_Model_YesNo">Yes</a> if the item is displayed; otherwise, <strong><a href="T_iTin_Export_Model_YesNo">No</a></strong>. The default is <a href="T_iTin_Export_Model_YesNo">No</a>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td>InvalidEnumArgumentException</td><td>The value specified is outside the range of valid values.</td></tr></table>

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Hyperlink Show="Yes|No" ...>
...
</Header>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td align="center">X</td><td align="center">X</td><td align="center">X</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## See Also


#### Reference
<a href="T_iTin_Export_Model_FieldHeaderHyperLink">FieldHeaderHyperLink Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />