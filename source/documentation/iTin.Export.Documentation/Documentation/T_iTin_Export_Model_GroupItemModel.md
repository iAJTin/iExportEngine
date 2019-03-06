# GroupItemModel Class
Additional header content 

Defines field name and a field separator of a group item.


## Inheritance Hierarchy
System.Object<br />&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseModel_1">iTin.Export.Model.BaseModel</a>(GroupItemModel)<br />&nbsp;&nbsp;&nbsp;&nbsp;iTin.Export.Model.GroupItemModel<br />
**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
[SerializableAttribute]
public class GroupItemModel : BaseModel<GroupItemModel>
```

**VB**<br />
``` VB
<SerializableAttribute>
Public Class GroupItemModel
	Inherits BaseModel(Of GroupItemModel)
```

The GroupItemModel type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_GroupItemModel__ctor">GroupItemModel</a></td><td>
Initializes a new instance of the GroupItemModel class.</td></tr></table>&nbsp;
<a href="#groupitemmodel-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_GroupItemModel_DataSource">DataSource</a></td><td>
Gets or sets a reference to source data of group.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_GroupItemModel_IsDefault">IsDefault</a></td><td>
Gets a value indicating whether this instance is default.
 (Overrides BaseModel.IsDefault.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_GroupItemModel_Name">Name</a></td><td>
Gets or sets the name of the field.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseModel_1_Properties">Properties</a></td><td>
Gets or sets a reference to user-defined property list for this element.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_GroupItemModel_Separator">Separator</a></td><td>
Gets or sets the field separator.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_GroupItemModel_Trim">Trim</a></td><td>
Gets or sets a value indicating whether to trim the blanks in this group field.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_GroupItemModel_TrimMode">TrimMode</a></td><td>
Gets or sets a value that determines trim mode for strings.</td></tr></table>&nbsp;
<a href="#groupitemmodel-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>Equals</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>Finalize</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetHashCode</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_GetStaticBindingValue">GetStaticBindingValue</a></td><td>
Gets the static binding value by reflection.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetType</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_GroupItemModel_GetValue">GetValue</a></td><td>
Returns the value containing this piece.</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>MemberwiseClone</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_SaveToFile">SaveToFile(String)</a></td><td>
Saves to file.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_SaveToFile_1">SaveToFile(String, Exception)</a></td><td>
Serializes current BaseModel object into file
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_Serialize">Serialize</a></td><td>
Serializes current BaseModel object into an Xml document.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_GroupItemModel_SetOwner">SetOwner</a></td><td>
Sets the element that owns this GroupItemModel.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_GroupItemModel_ToString">ToString</a></td><td>
Returns a string that represents the current object.
 (Overrides <a href="M_iTin_Export_Model_BaseModel_1_ToString">BaseModel(T).ToString()</a>.)</td></tr></table>&nbsp;
<a href="#groupitemmodel-class">Back to Top</a>

## Remarks

Belongs to: <strong>`Group`</strong>. For more information, please see <a href="T_iTin_Export_Model_GroupModel">GroupModel</a>. 
**ITEE Object Element Usage**<br />
``` XML
<Field .../>
```


<strong>Attributes</strong><table><tr><th>Attribute</th><th>Optional</th><th>Description</th></tr><tr><td><a href="P_iTin_Export_Model_GroupItemModel_Name">Name</a></td><td align="center">No</td><td>Name of the field.</td></tr><tr><td><a href="P_iTin_Export_Model_GroupItemModel_Separator">Separator</a></td><td align="center">Yes</td><td>Field separator. The default is "`None`".</td></tr><tr><td><a href="P_iTin_Export_Model_GroupItemModel_Trim">Trim</a></td><td align="center">Yes</td><td>Determines whether to apply string trim mode. The default <a href="T_iTin_Export_Model_YesNo">No</a>.</td></tr><tr><td><a href="P_iTin_Export_Model_GroupItemModel_TrimMode">TrimMode</a></td><td align="center">Yes</td><td>Use this attribute to specify trim mode for strings. The default is <a href="T_iTin_Export_Model_KnownTrimMode">All</a>.</td></tr></table><strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br /><a href="T_iTin_Export_Writers_CsvWriter">CsvWriter</a></th><th>Tab-Separated Values<br /><a href="T_iTin_Export_Writers_TsvWriter">TsvWriter</a></th><th>SQL Script<br /><a href="T_iTin_Export_Writers_SqlScriptWriter">SqlScriptWriter</a></th><th>XML Spreadsheet 2003<br /><a href="T_iTin_Export_Writers_Spreadsheet2003TabularWriter">Spreadsheet2003TabularWriter</a></th></tr><tr><td align="center">X</td><td align="center">X</td><td align="center">X</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## See Also


#### Reference
<a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />