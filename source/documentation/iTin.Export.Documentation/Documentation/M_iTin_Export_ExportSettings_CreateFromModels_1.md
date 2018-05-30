# ExportSettings.CreateFromModels Method (ExportsModel, String)
Additional header content 

Returns a reference which contains specified export data model from the specified data model.

**Namespace:**&nbsp;<a href="N_iTin_Export">iTin.Export</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
public static ExportSettings CreateFromModels(
	ExportsModel model,
	string from
)
```

**VB**<br />
``` VB
Public Shared Function CreateFromModels ( 
	model As ExportsModel,
	from As String
) As ExportSettings
```


#### Parameters
&nbsp;<dl><dt>model</dt><dd>Type: <a href="T_iTin_Export_Model_ExportsModel">iTin.Export.Model.ExportsModel</a><br />The model.</dd><dt>from</dt><dd>Type: System.String<br />Name of the data model to use.</dd></dl>

#### Return Value
Type: <a href="T_iTin_Export_ExportSettings">ExportSettings</a><br />A <a href="T_iTin_Export_ExportSettings">ExportSettings</a> object that represents export settings.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td>FileNotFoundException</td><td>File exception</td></tr></table>

## Remarks
\[Missing <remarks> documentation for "M:iTin.Export.ExportSettings.CreateFromModels(iTin.Export.Model.ExportsModel,System.String)"\]

## See Also


#### Reference
<a href="T_iTin_Export_ExportSettings">ExportSettings Class</a><br /><a href="Overload_iTin_Export_ExportSettings_CreateFromModels">CreateFromModels Overload</a><br /><a href="N_iTin_Export">iTin.Export Namespace</a><br />