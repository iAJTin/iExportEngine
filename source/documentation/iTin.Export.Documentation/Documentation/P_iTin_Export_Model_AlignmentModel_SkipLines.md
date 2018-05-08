# AlignmentModel.SkipLines Property 
Additional header content 

Gets or sets number of lines to skip.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
public int SkipLines { get; set; }
```

**VB**<br />
``` VB
Public Property SkipLines As Integer
	Get
	Set
```


#### Property Value
Type: Int32<br />Returns the number of lines to skip. The default is `0`.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td>InvalidOperationException</td><td>If specified value is less than 0.</td></tr></table>

## Remarks

**TEE Object Element Usage**<br />
``` XML
<ByAlignment SkipLines="non-negative integer" .../>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## See Also


#### Reference
<a href="T_iTin_Export_Model_AlignmentModel">AlignmentModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />