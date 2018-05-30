# WriterOptionsMetadata.Extension Property 
Additional header content 

Gets a value than represents extension output file created by writer.

**Namespace:**&nbsp;<a href="N_iTin_Export_ComponentModel_Writer">iTin.Export.ComponentModel.Writer</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
public string Extension { get; }
```

**VB**<br />
``` VB
Public ReadOnly Property Extension As String
	Get
```


#### Property Value
Type: String<br />A String than contains the writer's output file extension without dot.

#### Implements
<a href="P_iTin_Export_ComponentModel_Writer_IWriterOptions_Extension">IWriterOptions.Extension</a><br />

## Remarks
This value is recovered using reflection the <a href="P_iTin_Export_ComponentModel_Writer_WriterOptionsAttribute_Extension">Extension</a> property of the <a href="T_iTin_Export_ComponentModel_Writer_WriterOptionsAttribute">WriterOptionsAttribute</a> attribute.

## See Also


#### Reference
<a href="T_iTin_Export_ComponentModel_Writer_WriterOptionsMetadata">WriterOptionsMetadata Structure</a><br /><a href="N_iTin_Export_ComponentModel_Writer">iTin.Export.ComponentModel.Writer Namespace</a><br />