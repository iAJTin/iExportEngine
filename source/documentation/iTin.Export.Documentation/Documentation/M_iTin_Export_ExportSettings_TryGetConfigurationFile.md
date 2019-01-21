# ExportSettings.TryGetConfigurationFile Method 
Additional header content 

Try to get the configuration file from a <a href="T_iTin_Export_ExportSettings">ExportSettings</a> reference. Returns a value indicating if it was possible to obtain the configuration file.

**Namespace:**&nbsp;<a href="N_iTin_Export">iTin.Export</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public static bool TryGetConfigurationFile(
	ExportSettings settings,
	out Uri configuration
)
```

**VB**<br />
``` VB
Public Shared Function TryGetConfigurationFile ( 
	settings As ExportSettings,
	<OutAttribute> ByRef configuration As Uri
) As Boolean
```


#### Parameters
&nbsp;<dl><dt>settings</dt><dd>Type: <a href="T_iTin_Export_ExportSettings">iTin.Export.ExportSettings</a><br />Export settings reference.</dd><dt>configuration</dt><dd>Type: System.Uri<br />Configuration file.</dd></dl>

#### Return Value
Type: Boolean<br /><strong>true</strong> if it was possible to obtain the configuration file; otherwise <strong>false</strong>.

## Remarks
\[Missing <remarks> documentation for "M:iTin.Export.ExportSettings.TryGetConfigurationFile(iTin.Export.ExportSettings,System.Uri@)"\]

## See Also


#### Reference
<a href="T_iTin_Export_ExportSettings">ExportSettings Class</a><br /><a href="N_iTin_Export">iTin.Export Namespace</a><br />