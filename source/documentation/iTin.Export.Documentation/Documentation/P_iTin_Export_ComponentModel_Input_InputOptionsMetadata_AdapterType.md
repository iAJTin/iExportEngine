# InputOptionsMetadata.AdapterType Property 
Additional header content 

Gets a value that contains which adapter will be used to export this input.

**Namespace:**&nbsp;<a href="N_iTin_Export_ComponentModel_Input">iTin.Export.ComponentModel.Input</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public Type AdapterType { get; }
```

**VB**<br />
``` VB
Public ReadOnly Property AdapterType As Type
	Get
```


#### Property Value
Type: Type<br />A String that contains the adapter will be used to export this input.

## Remarks
This value is recovered using reflection the AdapterName property of the InputOptionsAttribute attribute.

## See Also


#### Reference
<a href="T_iTin_Export_ComponentModel_Input_InputOptionsMetadata">InputOptionsMetadata Structure</a><br /><a href="N_iTin_Export_ComponentModel_Input">iTin.Export.ComponentModel.Input Namespace</a><br />