# ExportSettings.ImportFrom Method (Uri)
Additional header content 

Returns a export settings object reference from a configuration file.

**Namespace:**&nbsp;<a href="N_iTin_Export">iTin.Export</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public static ExportSettings ImportFrom(
	Uri configuration
)
```

**VB**<br />
``` VB
Public Shared Function ImportFrom ( 
	configuration As Uri
) As ExportSettings
```


#### Parameters
&nbsp;<dl><dt>configuration</dt><dd>Type: System.Uri<br />Configuration file path.</dd></dl>

#### Return Value
Type: <a href="T_iTin_Export_ExportSettings">ExportSettings</a><br />A <a href="T_iTin_Export_ExportSettings">ExportSettings</a> object that represents export settings.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td>FileNotFoundException</td><td>File exception</td></tr></table>

## Remarks
\[Missing <remarks> documentation for "M:iTin.Export.ExportSettings.ImportFrom(System.Uri)"\]

## See Also


#### Reference
<a href="T_iTin_Export_ExportSettings">ExportSettings Class</a><br /><a href="Overload_iTin_Export_ExportSettings_ImportFrom">ImportFrom Overload</a><br /><a href="N_iTin_Export">iTin.Export Namespace</a><br />