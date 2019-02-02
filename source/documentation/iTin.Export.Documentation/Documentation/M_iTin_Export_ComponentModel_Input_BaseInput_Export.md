# BaseInput.Export Method 
Additional header content 

Exports the input data using the specified configuration in xml configuration file.

**Namespace:**&nbsp;<a href="N_iTin_Export_ComponentModel_Input">iTin.Export.ComponentModel.Input</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public void Export(
	ExportSettings settings
)
```

**VB**<br />
``` VB
Public Sub Export ( 
	settings As ExportSettings
)
```


#### Parameters
&nbsp;<dl><dt>settings</dt><dd>Type: <a href="T_iTin_Export_ExportSettings">iTin.Export.ExportSettings</a><br />Export settings</dd></dl>

#### Implements
<a href="M_iTin_Export_ComponentModel_Input_IInput_Export">IInput.Export(ExportSettings)</a><br />

## Remarks
If <a href="P_iTin_Export_ExportSettings_From">From</a> is `null` or Empty, always use the first section with <a href="P_iTin_Export_Model_ExportModel_Current">Current</a> attribute sets to <a href="T_iTin_Export_Model_YesNo">Yes</a>.

## See Also


#### Reference
<a href="T_iTin_Export_ComponentModel_Input_BaseInput">BaseInput Class</a><br /><a href="N_iTin_Export_ComponentModel_Input">iTin.Export.ComponentModel.Input Namespace</a><br />