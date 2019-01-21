# TextLineModel Class
Additional header content 

\[Missing <summary> documentation for "T:iTin.Export.Model.TextLineModel"\]


## Inheritance Hierarchy
System.Object<br />&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseModel_1">iTin.Export.Model.BaseModel</a>(<a href="T_iTin_Export_Model_BaseLineModel">BaseLineModel</a>)<br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseLineModel">iTin.Export.Model.BaseLineModel</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;iTin.Export.Model.TextLineModel<br />
**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
[SerializableAttribute]
public class TextLineModel : BaseLineModel
```

**VB**<br />
``` VB
<SerializableAttribute>
Public Class TextLineModel
	Inherits BaseLineModel
```

The TextLineModel type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_TextLineModel__ctor">TextLineModel</a></td><td>
Initializes a new instance of the TextLineModel class</td></tr></table>&nbsp;
<a href="#textlinemodel-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseLineModel_IsDefault">IsDefault</a></td><td>
Gets a value indicating whether this instance is default.
 (Inherited from <a href="T_iTin_Export_Model_BaseLineModel">BaseLineModel</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_TextLineModel_Items">Items</a></td><td /></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseLineModel_Key">Key</a></td><td> (Inherited from <a href="T_iTin_Export_Model_BaseLineModel">BaseLineModel</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_TextLineModel_LineType">LineType</a></td><td>
Gets a value indicating line type.
 (Overrides <a href="P_iTin_Export_Model_BaseLineModel_LineType">BaseLineModel.LineType</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseModel_1_Properties">Properties</a></td><td>
Gets or sets a reference to user-defined property list for this element.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseLineModel_Repeat">Repeat</a></td><td> (Inherited from <a href="T_iTin_Export_Model_BaseLineModel">BaseLineModel</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseLineModel_Show">Show</a></td><td> (Inherited from <a href="T_iTin_Export_Model_BaseLineModel">BaseLineModel</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseLineModel_Style">Style</a></td><td> (Inherited from <a href="T_iTin_Export_Model_BaseLineModel">BaseLineModel</a>.)</td></tr></table>&nbsp;
<a href="#textlinemodel-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>Equals</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>Finalize</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetHashCode</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_GetStaticBindingValue">GetStaticBindingValue</a></td><td>
Gets the static binding value by reflection.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseLineModel_GetStyle">GetStyle</a></td><td>
Gets a reference to the <a href="T_iTin_Export_Model_StyleModel">StyleModel</a> from global resources.
 (Inherited from <a href="T_iTin_Export_Model_BaseLineModel">BaseLineModel</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetType</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>MemberwiseClone</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_SaveToFile">SaveToFile(String)</a></td><td>
Saves to file.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_SaveToFile_1">SaveToFile(String, Exception)</a></td><td>
Serializes current BaseModel object into file
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_Serialize">Serialize</a></td><td>
Serializes current BaseModel object into an Xml document.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseLineModel_SetOwner">SetOwner</a></td><td>
Sets the element that owns this data field.
 (Inherited from <a href="T_iTin_Export_Model_BaseLineModel">BaseLineModel</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseLineModel_ToString">ToString</a></td><td>
Returns a string that represents the current object.
 (Inherited from <a href="T_iTin_Export_Model_BaseLineModel">BaseLineModel</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseLineModel_TryGetResourceInformation">TryGetResourceInformation</a></td><td>
Gets a reference to the image resource information.
 (Inherited from <a href="T_iTin_Export_Model_BaseLineModel">BaseLineModel</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseLineModel_TryGetStyle">TryGetStyle</a></td><td>
Gets a reference to the <a href="T_iTin_Export_Model_StyleModel">StyleModel</a> from global resources.
 (Inherited from <a href="T_iTin_Export_Model_BaseLineModel">BaseLineModel</a>.)</td></tr></table>&nbsp;
<a href="#textlinemodel-class">Back to Top</a>

## Remarks

The following table shows different types of lines.
&nbsp;<table><tr><th>Class</th><th>Description</th></tr><tr><td><a href="T_iTin_Export_Model_EmptyLineModel">EmptyLineModel</a></td><td>Represents a data field.</td></tr><tr><td>TextLineModel</td><td>Represents a piece of a field fixed-width data.</td></tr></table>

## See Also


#### Reference
<a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />