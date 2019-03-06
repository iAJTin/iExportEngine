# WriterOptionsMetadata.Version Property 
Additional header content 

Gets a value than represents the version of the writer.

**Namespace:**&nbsp;<a href="N_iTin_Export_ComponentModel_Writer">iTin.Export.ComponentModel.Writer</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public int Version { get; }
```

**VB**<br />
``` VB
Public ReadOnly Property Version As Integer
	Get
```


#### Property Value
Type: Int32<br />A Int32 than contains the writer's version.

#### Implements
<a href="P_iTin_Export_ComponentModel_Writer_IWriterOptions_Version">IWriterOptions.Version</a><br />

## Remarks
This value is recovered using reflection the <a href="P_iTin_Export_ComponentModel_Writer_WriterOptionsAttribute_Version">Version</a> property of the <a href="T_iTin_Export_ComponentModel_Writer_WriterOptionsAttribute">WriterOptionsAttribute</a> attribute.

## See Also


#### Reference
<a href="T_iTin_Export_ComponentModel_Writer_WriterOptionsMetadata">WriterOptionsMetadata Structure</a><br /><a href="N_iTin_Export_ComponentModel_Writer">iTin.Export.ComponentModel.Writer Namespace</a><br />