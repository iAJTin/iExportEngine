# BaseEffectModel Class
Additional header content 

Base class for different effects compatible with <strong>`iTin Export Engine`</strong>.<br /> Which acts as the base class for different image effects.


## Inheritance Hierarchy
System.Object<br />&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseModel_1">iTin.Export.Model.BaseModel</a>(BaseEffectModel)<br />&nbsp;&nbsp;&nbsp;&nbsp;iTin.Export.Model.BaseEffectModel<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="#inheritance-hierarchy">More...</a>
**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
[SerializableAttribute]
public abstract class BaseEffectModel : BaseModel<BaseEffectModel>
```

**VB**<br />
``` VB
<SerializableAttribute>
Public MustInherit Class BaseEffectModel
	Inherits BaseModel(Of BaseEffectModel)
```

The BaseEffectModel type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_Model_BaseEffectModel__ctor">BaseEffectModel</a></td><td>
Initializes a new instance of the BaseEffectModel class</td></tr></table>&nbsp;
<a href="#baseeffectmodel-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseModel_1_Properties">Properties</a></td><td>
Gets or sets a reference to user-defined property list for this element.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr></table>&nbsp;
<a href="#baseeffectmodel-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseEffectModel_Apply">Apply</a></td><td>
Gets the manipulation of the colors in an image to an effect.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>Equals</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>Finalize</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetHashCode</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_GetStaticBindingValue">GetStaticBindingValue</a></td><td>
Gets the static binding value by reflection.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetType</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>MemberwiseClone</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_SaveToFile">SaveToFile(String)</a></td><td>
Saves to file.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_SaveToFile_1">SaveToFile(String, Exception)</a></td><td>
Serializes current BaseModel object into file
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_Serialize">Serialize</a></td><td>
Serializes current BaseModel object into an Xml document.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseEffectModel_SetOwner">SetOwner</a></td><td>
Sets the element that owns this effect.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_ToString">ToString</a></td><td>
Returns a string that represents the current object.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr></table>&nbsp;
<a href="#baseeffectmodel-class">Back to Top</a>

## Remarks

The following table shows the different effects.
&nbsp;<table><tr><th>Class</th><th>Description</th></tr><tr><td><a href="T_iTin_Export_Model_DisabledEffectModel">DisabledEffectModel</a></td><td>Represents disabled effect.</td></tr><tr><td><a href="T_iTin_Export_Model_GrayScaleEffectModel">GrayScaleEffectModel</a></td><td>Represents gray-scale effect.</td></tr><tr><td><a href="T_iTin_Export_Model_GrayScaleRedEffectModel">GrayScaleRedEffectModel</a></td><td>Represents gray-scale red effect.</td></tr><tr><td><a href="T_iTin_Export_Model_GrayScaleGreenEffectModel">GrayScaleGreenEffectModel</a></td><td>Represents gray-scale green effect.</td></tr><tr><td><a href="T_iTin_Export_Model_GrayScaleBlueEffectModel">GrayScaleBlueEffectModel</a></td><td>Represents gray-scale blue effect.</td></tr><tr><td><a href="T_iTin_Export_Model_BrightnessEffectModel">BrightnessEffectModel</a></td><td>Represents brightness effect.</td></tr><tr><td><a href="T_iTin_Export_Model_MoreBrightnessEffectModel">MoreBrightnessEffectModel</a></td><td>Represents more brightness effect.</td></tr><tr><td><a href="T_iTin_Export_Model_DarkEffectModel">DarkEffectModel</a></td><td>Represents brightness effect.</td></tr><tr><td><a href="T_iTin_Export_Model_MoreDarkEffectModel">MoreDarkEffectModel</a></td><td>Represents more brightness effect.</td></tr><tr><td><a href="T_iTin_Export_Model_OpacityEffectModel">OpacityEffectModel</a></td><td>Represents opacity effect.</td></tr></table>

## See Also


#### Reference
<a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />

## Inheritance HierarchySystem.Object<br />&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseModel_1">iTin.Export.Model.BaseModel</a>(BaseEffectModel)<br />&nbsp;&nbsp;&nbsp;&nbsp;iTin.Export.Model.BaseEffectModel<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Model_BrightnessEffectModel">iTin.Export.Model.BrightnessEffectModel</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Model_DarkEffectModel">iTin.Export.Model.DarkEffectModel</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Model_DisabledEffectModel">iTin.Export.Model.DisabledEffectModel</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Model_GrayScaleBlueEffectModel">iTin.Export.Model.GrayScaleBlueEffectModel</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Model_GrayScaleEffectModel">iTin.Export.Model.GrayScaleEffectModel</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Model_GrayScaleGreenEffectModel">iTin.Export.Model.GrayScaleGreenEffectModel</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Model_GrayScaleRedEffectModel">iTin.Export.Model.GrayScaleRedEffectModel</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Model_MoreBrightnessEffectModel">iTin.Export.Model.MoreBrightnessEffectModel</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Model_MoreDarkEffectModel">iTin.Export.Model.MoreDarkEffectModel</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Model_OpacityEffectModel">iTin.Export.Model.OpacityEffectModel</a><br />