# FilterModel.Path Property 
Additional header content 

Gets or sets the path where is located the writer.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

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
Type: String<br />Path where is located the writer. To specify a relative path use the character (~). The default is "`Default`".

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td>ArgumentNullException</td><td>If *value* is <strong>null</strong>.</td></tr><tr><td><a href="T_iTin_Export_Model_InvalidPathNameException">InvalidPathNameException</a></td><td>If *value* is an invalid path name.</td></tr></table>

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Filter Path="Default|string" .../>
```


## See Also


#### Reference
<a href="T_iTin_Export_Model_FilterModel">FilterModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />