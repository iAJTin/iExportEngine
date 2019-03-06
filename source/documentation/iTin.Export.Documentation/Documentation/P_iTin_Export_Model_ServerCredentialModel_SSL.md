# ServerCredentialModel.SSL Property 
Additional header content 

Gets or sets a value indicating whether uses Secure Sockets Layer (SSL) to encrypt the connection.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public YesNo SSL { get; set; }
```

**VB**<br />
``` VB
Public Property SSL As YesNo
	Get
	Set
```


#### Property Value
Type: <a href="T_iTin_Export_Model_YesNo">YesNo</a><br /><a href="T_iTin_Export_Model_YesNo">Yes</a> uses Secure Sockets Layer (SSL) to encrypt the connection; otherwise, <a href="T_iTin_Export_Model_YesNo">No</a>. The default is <a href="T_iTin_Export_Model_YesNo">Yes</a>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td>InvalidEnumArgumentException</td><td>The value specified is outside the range of valid values.</td></tr></table>

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Credential SSL="Yes|No" .../>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br /><a href="T_iTin_Export_Writers_CsvWriter">CsvWriter</a></th><th>Tab-Separated Values<br /><a href="T_iTin_Export_Writers_TsvWriter">TsvWriter</a></th><th>SQL Script<br /><a href="T_iTin_Export_Writers_SqlScriptWriter">SqlScriptWriter</a></th><th>XML Spreadsheet 2003<br /><a href="T_iTin_Export_Writers_Spreadsheet2003TabularWriter">Spreadsheet2003TabularWriter</a></th></tr><tr><td align="center">X</td><td align="center">X</td><td align="center">X</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## Examples

**XML**<br />
``` XML
<Credential SSL="Yes" Name="firstcredential" UserName="address@gmail.com" password="pwd" Host="smtp.gmail.com"/>
```


## See Also


#### Reference
<a href="T_iTin_Export_Model_ServerCredentialModel">ServerCredentialModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />