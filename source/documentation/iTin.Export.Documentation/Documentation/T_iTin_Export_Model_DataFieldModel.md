# DataFieldModel Class
Additional header content 

A Specialization of <a href="T_iTin_Export_Model_BaseDataFieldModel">BaseDataFieldModel</a> class.<br /> Which acts as the base class for different data fields.<br /> Represents a data field.


## Inheritance Hierarchy
System.Object<br />&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseModel_1">iTin.Export.Model.BaseModel</a>(<a href="T_iTin_Export_Model_BaseDataFieldModel">BaseDataFieldModel</a>)<br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseDataFieldModel">iTin.Export.Model.BaseDataFieldModel</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;iTin.Export.Model.DataFieldModel<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Model_GroupFieldModel">iTin.Export.Model.GroupFieldModel</a><br />
**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
[SerializableAttribute]
public class DataFieldModel : BaseDataFieldModel
```

**VB**<br />
``` VB
<SerializableAttribute>
Public Class DataFieldModel
	Inherits BaseDataFieldModel
```

The DataFieldModel type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_DataFieldModel__ctor">DataFieldModel</a></td><td>
Initializes a new instance of the DataFieldModel class</td></tr></table>&nbsp;
<a href="#datafieldmodel-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_BaseDataFieldModel_Aggregate">Aggregate</a></td><td>
Gets or sets a reference that contains the visual setting of aggregate function of the data field.
 (Inherited from <a href="T_iTin_Export_Model_BaseDataFieldModel">BaseDataFieldModel</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_BaseDataFieldModel_Alias">Alias</a></td><td>
Gets or sets the alias of data field.
 (Inherited from <a href="T_iTin_Export_Model_BaseDataFieldModel">BaseDataFieldModel</a>.)</td></tr><tr><td>![Protected property](media/protproperty.gif "Protected property")</td><td><a href="P_iTin_Export_Model_BaseDataFieldModel_CanSetData">CanSetData</a></td><td>
When overridden in a derived class, gets a value indicating whether the current data field supports data.
 (Inherited from <a href="T_iTin_Export_Model_BaseDataFieldModel">BaseDataFieldModel</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseDataFieldModel_Condition">Condition</a></td><td> (Inherited from <a href="T_iTin_Export_Model_BaseDataFieldModel">BaseDataFieldModel</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseDataFieldModel_DataSource">DataSource</a></td><td>
Gets or sets a reference for pieces data.
 (Inherited from <a href="T_iTin_Export_Model_BaseDataFieldModel">BaseDataFieldModel</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_DataFieldModel_FieldType">FieldType</a></td><td>
Gets a value indicating data field type.
 (Overrides <a href="P_iTin_Export_Model_BaseDataFieldModel_FieldType">BaseDataFieldModel.FieldType</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_BaseDataFieldModel_Header">Header</a></td><td>
Gets or sets a reference that contains the visual setting of header the data field.
 (Inherited from <a href="T_iTin_Export_Model_BaseDataFieldModel">BaseDataFieldModel</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseDataFieldModel_IsDefault">IsDefault</a></td><td>
Gets a value indicating whether this instance contains the default.
 (Inherited from <a href="T_iTin_Export_Model_BaseDataFieldModel">BaseDataFieldModel</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_DataFieldModel_Name">Name</a></td><td>
Gets or sets the name of the field.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseModel_1_Properties">Properties</a></td><td>
Gets or sets a reference to user-defined property list for this element.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_BaseDataFieldModel_Value">Value</a></td><td>
Gets or sets a reference that contains the visual setting of value the data field.
 (Inherited from <a href="T_iTin_Export_Model_BaseDataFieldModel">BaseDataFieldModel</a>.)</td></tr></table>&nbsp;
<a href="#datafieldmodel-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>Equals</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>Finalize</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetHashCode</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_GetStaticBindingValue">GetStaticBindingValue</a></td><td>
Gets the static binding value by reflection.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetType</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>MemberwiseClone</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_SaveToFile">SaveToFile(String)</a></td><td>
Saves to file.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_SaveToFile_1">SaveToFile(String, Exception)</a></td><td>
Serializes current BaseModel object into file
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_Serialize">Serialize</a></td><td>
Serializes current BaseModel object into an Xml document.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseDataFieldModel_SetOwner">SetOwner</a></td><td>
Sets the element that owns this data field.
 (Inherited from <a href="T_iTin_Export_Model_BaseDataFieldModel">BaseDataFieldModel</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_DataFieldModel_ToString">ToString</a></td><td>
Returns a string that represents the current object.
 (Overrides <a href="M_iTin_Export_Model_BaseDataFieldModel_ToString">BaseDataFieldModel.ToString()</a>.)</td></tr></table>&nbsp;
<a href="#datafieldmodel-class">Back to Top</a>

## Remarks

The following table shows different data fields.
&nbsp;<table><tr><th>Class</th><th>Description</th></tr><tr><td><a href="T_iTin_Export_Model_GroupFieldModel">GroupFieldModel</a></td><td>Represents a field as union of several data field.</td></tr></table>&nbsp;
Belongs to: <strong>`Fields`</strong>. For more information, please see <a href="T_iTin_Export_Model_FieldsModel">FieldsModel</a>. 
**ITEE Object Element Usage**<br />
``` XML
<Field ...>
  <Header/>
  <Value/>
  <Aggregate/>
</Field>
```


<strong>Attributes</strong><table><tr><th>Attribute</th><th>Optional</th><th>Description</th></tr><tr><td><a href="P_iTin_Export_Model_DataFieldModel_Name">Name</a></td><td align="center">No</td><td>Name of the field.</td></tr><tr><td><a href="P_iTin_Export_Model_BaseDataFieldModel_Alias">Alias</a></td><td align="center">Yes</td><td>The alias of data field. This value is used as the column header.</td></tr></table><strong>Elements</strong>
&nbsp;<table><tr><th>Element</th><th>Description</th></tr><tr><td><a href="P_iTin_Export_Model_BaseDataFieldModel_Header">Header</a></td><td>Reference to visual setting of header of the data field.</td></tr><tr><td><a href="P_iTin_Export_Model_BaseDataFieldModel_Value">Value</a></td><td>Reference to visual setting of value of the data field.</td></tr><tr><td><a href="P_iTin_Export_Model_BaseDataFieldModel_Aggregate">Aggregate</a></td><td>Reference to visual setting of aggregate function of the data field.</td></tr></table>&nbsp;
<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td align="center">X</td><td align="center">X</td><td align="center">X</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## See Also


#### Reference
<a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />