# ServerCredentialModel.Domain Property 
Additional header content 

Gets or sets the domain or computer name that verifies the credential.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public string Domain { get; set; }
```

**VB**<br />
``` VB
Public Property Domain As String
	Get
	Set
```


#### Property Value
Type: String<br />The name of the domain associated with the credential. The default is an empty string ("").

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Credential Domain="string" .../>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br /><a href="T_iTin_Export_Writers_CsvWriter">CsvWriter</a></th><th>Tab-Separated Values<br /><a href="T_iTin_Export_Writers_TsvWriter">TsvWriter</a></th><th>SQL Script<br /><a href="T_iTin_Export_Writers_SqlScriptWriter">SqlScriptWriter</a></th><th>XML Spreadsheet 2003<br /><a href="T_iTin_Export_Writers_Spreadsheet2003TabularWriter">Spreadsheet2003TabularWriter</a></th></tr><tr><td align="center">X</td><td align="center">X</td><td align="center">X</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## Examples

**XML**<br />
``` XML
<Credential Name="firstcredential" UserName="address@gmail.com" password="pwd" Host="smtp.gmail.com"/>
```


## See Also


#### Reference
<a href="T_iTin_Export_Model_ServerCredentialModel">ServerCredentialModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />