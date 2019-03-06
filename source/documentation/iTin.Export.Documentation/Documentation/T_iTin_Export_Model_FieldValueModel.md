# FieldValueModel Class
Additional header content 

Reference to visual setting of value of the data field.


## Inheritance Hierarchy
System.Object<br />&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseModel_1">iTin.Export.Model.BaseModel</a>(FieldValueModel)<br />&nbsp;&nbsp;&nbsp;&nbsp;iTin.Export.Model.FieldValueModel<br />
**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
[SerializableAttribute]
public class FieldValueModel : BaseModel<FieldValueModel>
```

**VB**<br />
``` VB
<SerializableAttribute>
Public Class FieldValueModel
	Inherits BaseModel(Of FieldValueModel)
```

The FieldValueModel type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_FieldValueModel__ctor">FieldValueModel</a></td><td>
Initializes a new instance of the FieldValueModel class.</td></tr></table>&nbsp;
<a href="#fieldvaluemodel-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_FieldValueModel_IsDefault">IsDefault</a></td><td>
Gets a value indicating whether this instance is default.
 (Overrides BaseModel.IsDefault.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseModel_1_Properties">Properties</a></td><td>
Gets or sets a reference to user-defined property list for this element.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_FieldValueModel_Show">Show</a></td><td>
Gets or sets a value that determines visibility of the element.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_FieldValueModel_Style">Style</a></td><td>
Gets or sets one of the styles defined in the element styles.</td></tr></table>&nbsp;
<a href="#fieldvaluemodel-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_FieldValueModel_CheckStyleName">CheckStyleName</a></td><td>
Performs a test for check if there this name of the style into the user-defined styles list.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>Equals</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>Finalize</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetHashCode</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_GetStaticBindingValue">GetStaticBindingValue</a></td><td>
Gets the static binding value by reflection.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetType</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_FieldValueModel_GetValue">GetValue()</a></td><td>
Gets the value.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_FieldValueModel_GetValue_1">GetValue(IEnumerable(Char))</a></td><td>
Gets the value.</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>MemberwiseClone</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_SaveToFile">SaveToFile(String)</a></td><td>
Saves to file.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_SaveToFile_1">SaveToFile(String, Exception)</a></td><td>
Serializes current BaseModel object into file
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_Serialize">Serialize</a></td><td>
Serializes current BaseModel object into an Xml document.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_ToString">ToString</a></td><td>
Returns a string that represents the current object.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_FieldValueModel_TryGetStyle">TryGetStyle</a></td><td>
Gets a reference to the <a href="T_iTin_Export_Model_StyleModel">StyleModel</a> from global resources.</td></tr></table>&nbsp;
<a href="#fieldvaluemodel-class">Back to Top</a>

## Remarks

Belongs to: <strong>`Field`</strong>, please see <a href="T_iTin_Export_Model_DataFieldModel">DataFieldModel</a><br /> - Or - <strong>`Fixed`</strong>, please see <a href="T_iTin_Export_Model_FixedFieldModel">FixedFieldModel</a><br /> - Or - <strong>`Gap`</strong>, please see <a href="T_iTin_Export_Model_GapFieldModel">GapFieldModel</a><br /> - Or - <strong>`Group`</strong>, please see <a href="T_iTin_Export_Model_GroupFieldModel">GroupFieldModel</a><br /> - Or - <strong>`Packet`</strong>, please see <a href="T_iTin_Export_Model_PacketFieldModel">PacketFieldModel</a><br />. 
**ITEE Object Element Usage**<br />
``` XML
<Value .../>
```


<strong>Attributes</strong><table><tr><th>Attribute</th><th>Optional</th><th>Description</th></tr><tr><td><a href="P_iTin_Export_Model_FieldAggregateModel_Style">Style</a></td><td align="center">No</td><td>Name of a style defined in the list of styles. The default is "`Default`".</td></tr><tr><td><a href="P_iTin_Export_Model_FieldAggregateModel_Show">Show</a></td><td align="center">Yes</td><td>Determines visibility of the element. The default is <a href="T_iTin_Export_Model_YesNo">No</a>.</td></tr></table><strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br /><a href="T_iTin_Export_Writers_CsvWriter">CsvWriter</a></th><th>Tab-Separated Values<br /><a href="T_iTin_Export_Writers_TsvWriter">TsvWriter</a></th><th>SQL Script<br /><a href="T_iTin_Export_Writers_SqlScriptWriter">SqlScriptWriter</a></th><th>XML Spreadsheet 2003<br /><a href="T_iTin_Export_Writers_Spreadsheet2003TabularWriter">Spreadsheet2003TabularWriter</a></th></tr><tr><td align="center">X</td><td align="center">X</td><td align="center">X</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## See Also


#### Reference
<a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />