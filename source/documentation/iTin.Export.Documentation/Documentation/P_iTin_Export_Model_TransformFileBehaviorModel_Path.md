# TransformFileBehaviorModel.Path Property 
Additional header content 

Gets or sets the path of transformation file, applies only in desktop mode.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
public string Path { get; set; }
```

**VB**<br />
``` VB
Public Property Path As String
	Get
	Set
```


#### Property Value
Type: String<br />Path of transformation file, if omitted used the same output element path. To specify a relative path use the character (~). The default is "`Default`".

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td>ArgumentNullException</td><td>If *value* is <strong>null</strong>.</td></tr><tr><td><a href="T_iTin_Export_Model_InvalidPathNameException">InvalidPathNameException</a></td><td>If *value* is an invalid path.</td></tr></table>

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<TransformFile Path="Default|string" .../>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td align="center">X</td><td align="center">X</td><td align="center">X</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## Examples

**XML**<br />
``` XML
<Behaviors>
  <Downdload LocalCopy="Yes"/>
  <TransformFile Execute="Yes" Indented="Yes" Save="Yes" Path="~\Output"/>
</Behaviors>
```


## See Also


#### Reference
<a href="T_iTin_Export_Model_TransformFileBehaviorModel">TransformFileBehaviorModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />