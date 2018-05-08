# ExportsModel.GetRelativeFilePathParsed Method 
Additional header content 

Gets a valid full path from a relative path.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
public static string GetRelativeFilePathParsed(
	ExportModel model,
	KnownRelativeFilePath element
)
```

**VB**<br />
``` VB
Public Shared Function GetRelativeFilePathParsed ( 
	model As ExportModel,
	element As KnownRelativeFilePath
) As String
```


#### Parameters
&nbsp;<dl><dt>model</dt><dd>Type: <a href="T_iTin_Export_Model_ExportModel">iTin.Export.Model.ExportModel</a><br />Model in which search.</dd><dt>element</dt><dd>Type: <a href="T_iTin_Export_Model_KnownRelativeFilePath">iTin.Export.Model.KnownRelativeFilePath</a><br />Element to recover.</dd></dl>

#### Return Value
Type: String<br />Valid full path.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td>InvalidEnumArgumentException</td><td>The value specified is outside the range of valid values.</td></tr></table>

## Remarks
\[Missing <remarks> documentation for "M:iTin.Export.Model.ExportsModel.GetRelativeFilePathParsed(iTin.Export.Model.ExportModel,iTin.Export.Model.KnownRelativeFilePath)"\]

## See Also


#### Reference
<a href="T_iTin_Export_Model_ExportsModel">ExportsModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />