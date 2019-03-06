# BaseProvider.LoadXmlFromFile Method 
Additional header content 

Retrieves `Xml` content of specified *table* in a file.

**Namespace:**&nbsp;<a href="N_iTin_Export_ComponentModel_Provider">iTin.Export.ComponentModel.Provider</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
protected static IEnumerable<XElement> LoadXmlFromFile(
	string fileName,
	string table
)
```

**VB**<br />
``` VB
Protected Shared Function LoadXmlFromFile ( 
	fileName As String,
	table As String
) As IEnumerable(Of XElement)
```


#### Parameters
&nbsp;<dl><dt>fileName</dt><dd>Type: System.String<br />Target filename</dd><dt>table</dt><dd>Type: System.String<br />Table to retrieve</dd></dl>

#### Return Value
Type: IEnumerable(XElement)<br />A collection of XElement that contains the table content as <strong>XML</strong>.

## Remarks
\[Missing <remarks> documentation for "M:iTin.Export.ComponentModel.Provider.BaseProvider.LoadXmlFromFile(System.String,System.String)"\]

## See Also


#### Reference
<a href="T_iTin_Export_ComponentModel_Provider_BaseProvider">BaseProvider Class</a><br /><a href="N_iTin_Export_ComponentModel_Provider">iTin.Export.ComponentModel.Provider Namespace</a><br />