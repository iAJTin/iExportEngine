# DocumentModel Class
Additional header content 

Includes the description of export table.


## Inheritance Hierarchy
System.Object<br />&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseModel_1">iTin.Export.Model.BaseModel</a>(DocumentModel)<br />&nbsp;&nbsp;&nbsp;&nbsp;iTin.Export.Model.DocumentModel<br />
**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
[SerializableAttribute]
public class DocumentModel : BaseModel<DocumentModel>
```

**VB**<br />
``` VB
<SerializableAttribute>
Public Class DocumentModel
	Inherits BaseModel(Of DocumentModel)
```

The DocumentModel type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_DocumentModel__ctor">DocumentModel</a></td><td>
Initializes a new instance of the DocumentModel class.</td></tr></table>&nbsp;
<a href="#documentmodel-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_DocumentModel_Footer">Footer</a></td><td>
Gets or sets a reference to footer document configuration, it allow define margin and data.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_DocumentModel_Header">Header</a></td><td>
Gets or sets a reference to header document configuration, it allow define margin and data.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_DocumentModel_IsDefault">IsDefault</a></td><td>
Gets a value indicating whether this instance contains the default.
 (Overrides BaseModel.IsDefault.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_DocumentModel_Margins">Margins</a></td><td>
Gets or sets a reference to configuration of margins, it allow define top margin, right margin, bottom margin and left margin of a document.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_DocumentModel_Orientation">Orientation</a></td><td>
Gets or sets the preferred orientation of document.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseModel_1_Properties">Properties</a></td><td>
Gets or sets a reference to user-defined property list for this element.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_DocumentModel_Size">Size</a></td><td>
Gets or sets the preferred size of document.</td></tr></table>&nbsp;
<a href="#documentmodel-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>Equals</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>Finalize</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetHashCode</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_GetStaticBindingValue">GetStaticBindingValue</a></td><td>
Gets the static binding value by reflection.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetType</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>MemberwiseClone</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_SaveToFile">SaveToFile(String)</a></td><td>
Saves to file.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_SaveToFile_1">SaveToFile(String, Exception)</a></td><td>
Serializes current BaseModel object into file
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_Serialize">Serialize</a></td><td>
Serializes current BaseModel object into an Xml document.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_DocumentModel_ToString">ToString</a></td><td>
Returns a string that represents the current data type.
 (Overrides <a href="M_iTin_Export_Model_BaseModel_1_ToString">BaseModel(T).ToString()</a>.)</td></tr></table>&nbsp;
<a href="#documentmodel-class">Back to Top</a>

## Remarks

Belongs to: <strong>`Host`</strong>. For more information, please see <a href="T_iTin_Export_Model_HostModel">HostModel</a>.<br />
**ITEE Object Element Usage**<br />
``` XML
 <Document ...>
  <Header/>
  <Footer/>
  <Margins/>
</Document>
```


<strong>Attributes</strong><table><tr><th>Attribute</th><th>Optional</th><th>Description</th></tr><tr><td><a href="P_iTin_Export_Model_DocumentModel_Size">Size</a></td><td align="center">Yes</td><td>Preferred size of document. The default is <a href="T_iTin_Export_Model_KnownDocumentSize">A4</a>.</td></tr><tr><td><a href="P_iTin_Export_Model_DocumentModel_Orientation">Orientation</a></td><td align="center">Yes</td><td>Preferred orientation of document. The default is <a href="T_iTin_Export_Model_KnownDocumentOrientation">Portrait</a>.</td></tr></table><strong>Elements</strong>
&nbsp;<table><tr><th>Element</th><th>Description</th></tr><tr><td><a href="P_iTin_Export_Model_DocumentModel_Header">Header</a></td><td>Represents header properties of a document. Allow define margin and data.</td></tr><tr><td><a href="P_iTin_Export_Model_DocumentModel_Footer">Footer</a></td><td>Represents footer properties of a document. Allow define margin and data.</td></tr><tr><td><a href="P_iTin_Export_Model_DocumentModel_Margins">Margins</a></td><td>Represents margins of a document. Allow define top margin, right margin, bottom margin and left margin of a document.</td></tr></table>&nbsp;
<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## See Also


#### Reference
<a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />