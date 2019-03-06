# BaseConditionModel Class
Additional header content 

Base class for the different types of field conditions supported by <strong>`iTin Export Engine`</strong>.<br /> Which acts as the base class for different conditions.


## Inheritance Hierarchy
System.Object<br />&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseModel_1">iTin.Export.Model.BaseModel</a>(BaseConditionModel)<br />&nbsp;&nbsp;&nbsp;&nbsp;iTin.Export.Model.BaseConditionModel<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Model_MaximumCondition">iTin.Export.Model.MaximumCondition</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Model_MinimumCondition">iTin.Export.Model.MinimumCondition</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Model_RemarksCondition">iTin.Export.Model.RemarksCondition</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Model_WhenChangeConditionModel">iTin.Export.Model.WhenChangeConditionModel</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Model_ZeroCondition">iTin.Export.Model.ZeroCondition</a><br />
**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
[SerializableAttribute]
public abstract class BaseConditionModel : BaseModel<BaseConditionModel>, 
	ICondition
```

**VB**<br />
``` VB
<SerializableAttribute>
Public MustInherit Class BaseConditionModel
	Inherits BaseModel(Of BaseConditionModel)
	Implements ICondition
```

The BaseConditionModel type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_Model_BaseConditionModel__ctor">BaseConditionModel</a></td><td>
Initializes a new instance of the BaseConditionModel class.</td></tr></table>&nbsp;
<a href="#baseconditionmodel-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_BaseConditionModel_Active">Active</a></td><td>
Gets or sets a value that indicates if this condition is active. The default is Yes.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_BaseConditionModel_EntireRow">EntireRow</a></td><td>
Gets or sets a value that indicates if condition style applies over the row. The default is No.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_BaseConditionModel_Field">Field</a></td><td>
Gets or sets a value that represents the field on which the condition will be evaluated</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseConditionModel_IsDefault">IsDefault</a></td><td>
Gets a value indicating whether this instance is default.
 (Overrides BaseModel.IsDefault.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_BaseConditionModel_Key">Key</a></td><td>
Gets or sets a value that contains an identifier for this condition</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_BaseConditionModel_Locale">Locale</a></td><td>
Gets or sets the data field culture. The default is <a href="T_iTin_Export_Model_KnownCulture">Current</a>.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseModel_1_Properties">Properties</a></td><td>
Gets or sets a reference to user-defined property list for this element.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Protected property](media/protproperty.gif "Protected property")</td><td><a href="P_iTin_Export_Model_BaseConditionModel_Service">Service</a></td><td>
Gets a reference to an object that contains information about the context.</td></tr></table>&nbsp;
<a href="#baseconditionmodel-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>Equals</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseConditionModel_Evaluate">Evaluate()</a></td><td>
Returns result of evaluates condition.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseConditionModel_Evaluate_1">Evaluate(Int32, Int32)</a></td><td>
Returns result of evaluates condition.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseConditionModel_Evaluate_2">Evaluate(Int32, Int32, FieldValueInformation)</a></td><td>
Returns result of evaluates condition.</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>Finalize</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_Model_BaseConditionModel_GetFieldAttributeEnumerable">GetFieldAttributeEnumerable</a></td><td>
Returns a list of field condition with raw content.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetHashCode</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_GetStaticBindingValue">GetStaticBindingValue</a></td><td>
Gets the static binding value by reflection.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetType</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>MemberwiseClone</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_SaveToFile">SaveToFile(String)</a></td><td>
Saves to file.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_SaveToFile_1">SaveToFile(String, Exception)</a></td><td>
Serializes current BaseModel object into file
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_Serialize">Serialize</a></td><td>
Serializes current BaseModel object into an Xml document.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseConditionModel_SetOwner">SetOwner</a></td><td>
Sets a reference to the owner object that contains this instance.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseConditionModel_ToString">ToString</a></td><td>
Returns a string that represents the current object.
 (Overrides <a href="M_iTin_Export_Model_BaseModel_1_ToString">BaseModel(T).ToString()</a>.)</td></tr></table>&nbsp;
<a href="#baseconditionmodel-class">Back to Top</a>

## Remarks

The following table shows different conditions.
&nbsp;<table><tr><th>Class</th><th>Description</th></tr><tr><td><a href="T_iTin_Export_Model_MaximumCondition">MaximumCondition</a></td><td>Evaluates the maximum condition over a data field.</td></tr><tr><td><a href="T_iTin_Export_Model_MinimumCondition">MinimumCondition</a></td><td>Evaluates the minimum condition over a data field.</td></tr><tr><td><a href="T_iTin_Export_Model_RemarksCondition">RemarksCondition</a></td><td>Evaluates custom logic condition over a data field.</td></tr><tr><td>WhenChangeCondition</td><td>Evaluates condition over a data field.</td></tr><tr><td><a href="T_iTin_Export_Model_ZeroCondition">ZeroCondition</a></td><td>Evaluates condition over a data field.</td></tr></table>

## See Also


#### Reference
<a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />