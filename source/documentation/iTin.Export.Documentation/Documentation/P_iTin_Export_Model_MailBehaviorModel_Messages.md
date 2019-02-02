# MailBehaviorModel.Messages Property 
Additional header content 

Gets or sets collection of e-mail messages.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public MailMessagesModel Messages { get; set; }
```

**VB**<br />
``` VB
Public Property Messages As MailMessagesModel
	Get
	Set
```


#### Property Value
Type: <a href="T_iTin_Export_Model_MailMessagesModel">MailMessagesModel</a><br />Collection of e-mail messages. Each element represents an e-mail message

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Mail ...>
  <Messages/>
</Mail>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td align="center">X</td><td align="center">X</td><td align="center">X</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## Examples

**XML**<br />
``` XML
<Behaviors>
  <Downdload LocalCopy="Yes"/>
  <TransformFile Execute="Yes" Indented="Yes" Save="Yes" Path="~\Output"/>
  <Mail Execute="Yes" Async="Yes">
    <Server>
      <Credentials>
        <Credential SSL="Yes" Name="one" UserName="address@gmail.com" password="pwd" Host="smtp.gmail.com"/>
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
<a href="T_iTin_Export_Model_MailBehaviorModel">MailBehaviorModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />