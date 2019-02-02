# ServerCredentialModel.Name Property 
Additional header content 

Gets or sets the identifier name of credential.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public string Name { get; set; }
```

**VB**<br />
``` VB
Public Property Name As String
	Get
	Set
```


#### Property Value
Type: String<br />The identifier name of credential.

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Credential Name="string" .../>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td align="center">X</td><td align="center">X</td><td align="center">X</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## Examples

**XML**<br />
``` XML
<Credential Name="firstcredential" UserName="address@gmail.com" password="pwd" Host="smtp.gmail.com"/>
```


## See Also


#### Reference
<a href="T_iTin_Export_Model_ServerCredentialModel">ServerCredentialModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />