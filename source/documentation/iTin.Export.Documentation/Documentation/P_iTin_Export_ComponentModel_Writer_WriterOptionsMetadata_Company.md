# WriterOptionsMetadata.Company Property 
Additional header content 

Gets a value than represents the name of the company that created the writer.

**Namespace:**&nbsp;<a href="N_iTin_Export_ComponentModel_Writer">iTin.Export.ComponentModel.Writer</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
public string Company { get; }
```

**VB**<br />
``` VB
Public ReadOnly Property Company As String
	Get
```


#### Property Value
Type: String<br />A String than contains the writer company's

#### Implements
<a href="P_iTin_Export_ComponentModel_Writer_IWriterOptions_Company">IWriterOptions.Company</a><br />

## Remarks
This value is recovered using reflection the <a href="P_iTin_Export_ComponentModel_Writer_WriterOptionsAttribute_Company">Company</a> property of the <a href="T_iTin_Export_ComponentModel_Writer_WriterOptionsAttribute">WriterOptionsAttribute</a> attribute.

## See Also


#### Reference
<a href="T_iTin_Export_ComponentModel_Writer_WriterOptionsMetadata">WriterOptionsMetadata Structure</a><br /><a href="N_iTin_Export_ComponentModel_Writer">iTin.Export.ComponentModel.Writer Namespace</a><br />