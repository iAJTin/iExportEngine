# IInput.Export Method 
Additional header content 

Export to xml

**Namespace:**&nbsp;<a href="N_iTin_Export_ComponentModel_Input">iTin.Export.ComponentModel.Input</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
void Export(
	ExportSettings settings
)
```

**VB**<br />
``` VB
Sub Export ( 
	settings As ExportSettings
)
```


#### Parameters
&nbsp;<dl><dt>settings</dt><dd>Type: <a href="T_iTin_Export_ExportSettings">iTin.Export.ExportSettings</a><br />Export Settings</dd></dl>

## Remarks
If <a href="P_iTin_Export_ExportSettings_From">From</a> is `null` or Empty, always use the first section with <a href="P_iTin_Export_Model_ExportModel_Current">Current</a> attribute sets to <a href="T_iTin_Export_Model_YesNo">Yes</a>.

## See Also


#### Reference
<a href="T_iTin_Export_ComponentModel_Input_IInput">IInput Interface</a><br /><a href="N_iTin_Export_ComponentModel_Input">iTin.Export.ComponentModel.Input Namespace</a><br />