# ServerCredentialModel Class
Additional header content 

Representing a server credential authentication.


## Inheritance Hierarchy
System.Object<br />&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseModel_1">iTin.Export.Model.BaseModel</a>(ServerCredentialModel)<br />&nbsp;&nbsp;&nbsp;&nbsp;iTin.Export.Model.ServerCredentialModel<br />
**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
[SerializableAttribute]
public class ServerCredentialModel : BaseModel<ServerCredentialModel>
```

**VB**<br />
``` VB
<SerializableAttribute>
Public Class ServerCredentialModel
	Inherits BaseModel(Of ServerCredentialModel)
```

The ServerCredentialModel type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_ServerCredentialModel__ctor">ServerCredentialModel</a></td><td>
Initializes a new instance of the ServerCredentialModel class.</td></tr></table>&nbsp;
<a href="#servercredentialmodel-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_ServerCredentialModel_Domain">Domain</a></td><td>
Gets or sets the domain or computer name that verifies the credential.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_ServerCredentialModel_Host">Host</a></td><td>
Gets or sets the name or IP address of the host used for SMTP transactions.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_ServerCredentialModel_IsDefault">IsDefault</a></td><td>
Gets a value indicating whether this instance is default.
 (Overrides BaseModel.IsDefault.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_ServerCredentialModel_Name">Name</a></td><td>
Gets or sets the identifier name of credential.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_ServerCredentialModel_Password">Password</a></td><td>
Gets or sets the password for the user name associated with the credential.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_ServerCredentialModel_Port">Port</a></td><td>
Gets or sets the port used for SMTP transactions.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseModel_1_Properties">Properties</a></td><td>
Gets or sets a reference to user-defined property list for this element.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_ServerCredentialModel_SSL">SSL</a></td><td>
Gets or sets a value indicating whether uses Secure Sockets Layer (SSL) to encrypt the connection.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_ServerCredentialModel_UserName">UserName</a></td><td>
Gets or sets the user name associated with the credential.</td></tr></table>&nbsp;
<a href="#servercredentialmodel-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>Equals</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>Finalize</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetHashCode</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_GetStaticBindingValue">GetStaticBindingValue</a></td><td>
Gets the static binding value by reflection.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetType</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>MemberwiseClone</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_SaveToFile">SaveToFile(String)</a></td><td>
Saves to file.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_SaveToFile_1">SaveToFile(String, Exception)</a></td><td>
Serializes current BaseModel object into file
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_Serialize">Serialize</a></td><td>
Serializes current BaseModel object into an Xml document.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_ServerCredentialModel_SetOwner">SetOwner</a></td><td>
Sets the element that owns this ServerCredentialModel.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_ToString">ToString</a></td><td>
Returns a string that represents the current object.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr></table>&nbsp;
<a href="#servercredentialmodel-class">Back to Top</a>

## Remarks

Belongs to: <strong>`Credentials`</strong>. For more information, please see <a href="T_iTin_Export_Model_ServerCredentialsModel">ServerCredentialsModel</a>. 
**ITEE Object Element Usage**<br />
``` XML
<Credential/>
```


<strong>Attributes</strong><table><tr><th>Attribute</th><th>Optional</th><th>Description</th></tr><tr><td><a href="P_iTin_Export_Model_ServerCredentialModel_Name">Name</a></td><td align="center">No</td><td>The identifier name of credential.</td></tr><tr><td><a href="P_iTin_Export_Model_ServerCredentialModel_SSL">SSL</a></td><td align="center">Yes</td><td>Determines whether uses Secure Sockets Layer (SSL) to encrypt the connection. The default is <a href="T_iTin_Export_Model_YesNo">Yes</a>.</td></tr><tr><td><a href="P_iTin_Export_Model_ServerCredentialModel_Domain">Domain</a></td><td align="center">Yes</td><td>The name of the domain associated with the credential. The default is an empty string ("").</td></tr><tr><td><a href="P_iTin_Export_Model_ServerCredentialModel_Port">Port</a></td><td align="center">Yes</td><td>Port used for SMTP transactions. The default value is 25.</td></tr><tr><td><a href="P_iTin_Export_Model_ServerCredentialModel_UserName">UserName</a></td><td align="center">No</td><td>The user name associated with the credential.</td></tr><tr><td><a href="P_iTin_Export_Model_ServerCredentialModel_Password">Password</a></td><td align="center">No</td><td>The password associated with the credential.</td></tr><tr><td><a href="P_iTin_Export_Model_ServerCredentialModel_Host">Host</a></td><td align="center">No</td><td>The name or IP address of the host used for SMTP transactions.</td></tr></table><strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td align="center">X</td><td align="center">X</td><td align="center">X</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## Examples

**XML**<br />
``` XML
<Behaviors>
  <Downdload LocalCopy="Yes"/>
  <TransformFile Execute="Yes" Indented="Yes" Save="Yes" Path="~\Output"/>
  <Mail Execute="Yes" Async="Yes" >
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
<a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />