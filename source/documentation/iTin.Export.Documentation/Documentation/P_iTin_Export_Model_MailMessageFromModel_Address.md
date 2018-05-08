# MailMessageFromModel.Address Property 
Additional header content 

Gets or sets a e-mail address.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
public string Address { get; set; }
```

**VB**<br />
``` VB
Public Property Address As String
	Get
	Set
```


#### Property Value
Type: String<br />A String that contains a valid e-mail address.

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<From Address="string"/>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td align="center">X</td><td align="center">X</td><td align="center">X</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## Examples

**XML**<br />
``` XML
<Behaviors>
  <Downdload LocalCopy="Yes"/>
  <TransformFile Execute="Yes" Indented="Yes" Save="Yes" Path="~\Output"/>
  <Mail Execute="Yes" Async="Yes" >
    <Server>
      <Credentials>
        <Credential SSL="Yes" 
                    Name="one" 
                    UserName="address@gmail.com" 
                    Password="pwd" 
                    Host="smtp.gmail.com"/>
      </Credentials>
    </Server>
    <Messages>
      <Message Credential="one" Send="Yes">
        <From Address="emailaddress-one@gmail.com"/>
        <To Addresses="emailaddress-two@hotmail.com emailaddress-three@hotmail.com"/>
        <CC Addresses="emailaddress-four@hotmail.com emailaddress-five@hotmail.com"/>
        <Subject>New report</Subject>
        <Body>Hello, this is your report, sending from iTin.Export</Body>
        <Attachments>
          <Attachment Path="C:\Users\somefile.txt"/>
          <Attachment Path="C:\Users\Downloads\Photos Sample.zip"/>
        </Attachments>
      </Message>
    </Messages>
  </Mail>
</Behaviors>
```


## See Also


#### Reference
<a href="T_iTin_Export_Model_MailMessageFromModel">MailMessageFromModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />