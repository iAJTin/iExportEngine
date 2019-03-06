# BaseDataFieldModel Class
Additional header content 

Base class for the different types of data fields supported by <strong>`iTin Export Engine`</strong>.<br /> Which acts as the base class for different data fields.


## Inheritance Hierarchy
System.Object<br />&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseModel_1">iTin.Export.Model.BaseModel</a>(BaseDataFieldModel)<br />&nbsp;&nbsp;&nbsp;&nbsp;iTin.Export.Model.BaseDataFieldModel<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Model_DataFieldModel">iTin.Export.Model.DataFieldModel</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Model_FixedFieldModel">iTin.Export.Model.FixedFieldModel</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Model_GapFieldModel">iTin.Export.Model.GapFieldModel</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Model_PacketFieldModel">iTin.Export.Model.PacketFieldModel</a><br />
**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
[SerializableAttribute]
public abstract class BaseDataFieldModel : BaseModel<BaseDataFieldModel>
```

**VB**<br />
``` VB
<SerializableAttribute>
Public MustInherit Class BaseDataFieldModel
	Inherits BaseModel(Of BaseDataFieldModel)
```

The BaseDataFieldModel type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_Model_BaseDataFieldModel__ctor">BaseDataFieldModel</a></td><td>
Initializes a new instance of the BaseDataFieldModel class.</td></tr></table>&nbsp;
<a href="#basedatafieldmodel-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_BaseDataFieldModel_Aggregate">Aggregate</a></td><td>
Gets or sets a reference that contains the visual setting of aggregate function of the data field.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_BaseDataFieldModel_Alias">Alias</a></td><td>
Gets or sets the alias of data field.</td></tr><tr><td>![Protected property](media/protproperty.gif "Protected property")</td><td><a href="P_iTin_Export_Model_BaseDataFieldModel_CanSetData">CanSetData</a></td><td>
When overridden in a derived class, gets a value indicating whether the current data field supports data.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseDataFieldModel_DataSource">DataSource</a></td><td>
Gets or sets a reference for pieces data.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseDataFieldModel_FieldType">FieldType</a></td><td>
Gets a value indicating data field type.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_BaseDataFieldModel_Header">Header</a></td><td>
Gets or sets a reference that contains the visual setting of header the data field.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseDataFieldModel_IsDefault">IsDefault</a></td><td>
Gets a value indicating whether this instance contains the default.
 (Overrides BaseModel.IsDefault.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseModel_1_Properties">Properties</a></td><td>
Gets or sets a reference to user-defined property list for this element.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_BaseDataFieldModel_Value">Value</a></td><td>
Gets or sets a reference that contains the visual setting of value the data field.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_BaseDataFieldModel_Width">Width</a></td><td>
Gets or sets the preferred width of field, indicate a size as multiply of 100 (ex. 9.3 => 930). The default is 'Default'.</td></tr></table>&nbsp;
<a href="#basedatafieldmodel-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseDataFieldModel_CalculateWidthValue">CalculateWidthValue</a></td><td>
Calculates field width from Width property measured in points.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>Equals</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>Finalize</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_iTin_Export_Model_BaseDataFieldModel_GetFieldNameFrom">GetFieldNameFrom</a></td><td>
Gets the name of field.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetHashCode</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_GetStaticBindingValue">GetStaticBindingValue</a></td><td>
Gets the static binding value by reflection.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetType</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>MemberwiseClone</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_SaveToFile">SaveToFile(String)</a></td><td>
Saves to file.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_SaveToFile_1">SaveToFile(String, Exception)</a></td><td>
Serializes current BaseModel object into file
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_Serialize">Serialize</a></td><td>
Serializes current BaseModel object into an Xml document.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseDataFieldModel_SetOwner">SetOwner</a></td><td>
Sets the element that owns this data field.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseDataFieldModel_ToString">ToString</a></td><td>
Returns a string that represents the current object.
 (Overrides <a href="M_iTin_Export_Model_BaseModel_1_ToString">BaseModel(T).ToString()</a>.)</td></tr></table>&nbsp;
<a href="#basedatafieldmodel-class">Back to Top</a>

## Remarks

The following table shows different data fields.
&nbsp;<table><tr><th>Class</th><th>Description</th></tr><tr><td><a href="T_iTin_Export_Model_DataFieldModel">DataFieldModel</a></td><td>Represents a data field.</td></tr><tr><td><a href="T_iTin_Export_Model_FixedFieldModel">FixedFieldModel</a></td><td>Represents a piece of a field fixed-width data.</td></tr><tr><td><a href="T_iTin_Export_Model_GapFieldModel">GapFieldModel</a></td><td>Represents an empty data field.</td></tr><tr><td><a href="T_iTin_Export_Model_GroupFieldModel">GroupFieldModel</a> (inherits of <a href="T_iTin_Export_Model_DataFieldModel">DataFieldModel</a>)</td><td>Represents a field as union of several data field.</td></tr></table>

## See Also


#### Reference
<a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />