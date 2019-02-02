# WriterOptionsMetadata.Author Property 
Additional header content 

Gets a value than identify to creator of writer.

**Namespace:**&nbsp;<a href="N_iTin_Export_ComponentModel_Writer">iTin.Export.ComponentModel.Writer</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public string Author { get; }
```

**VB**<br />
``` VB
Public ReadOnly Property Author As String
	Get
```


#### Property Value
Type: String<br />A String than contains the writer's author.

#### Implements
<a href="P_iTin_Export_ComponentModel_Writer_IWriterOptions_Author">IWriterOptions.Author</a><br />

## Remarks
This value is recovered using reflection the <a href="P_iTin_Export_ComponentModel_Writer_WriterOptionsAttribute_Author">Author</a> property of the <a href="T_iTin_Export_ComponentModel_Writer_WriterOptionsAttribute">WriterOptionsAttribute</a> attribute.

## See Also


#### Reference
<a href="T_iTin_Export_ComponentModel_Writer_WriterOptionsMetadata">WriterOptionsMetadata Structure</a><br /><a href="N_iTin_Export_ComponentModel_Writer">iTin.Export.ComponentModel.Writer Namespace</a><br />