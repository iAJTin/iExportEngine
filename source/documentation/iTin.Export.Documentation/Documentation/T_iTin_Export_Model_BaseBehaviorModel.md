# BaseBehaviorModel Class
Additional header content 

Implements interface <a href="T_iTin_Export_Model_IBehavior">IBehavior</a>. Which acts as the base class for different behaviors of an exporter supported by <strong>`iTin Export Engine`</strong>.<br />


## Inheritance Hierarchy
System.Object<br />&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseModel_1">iTin.Export.Model.BaseModel</a>(BaseBehaviorModel)<br />&nbsp;&nbsp;&nbsp;&nbsp;iTin.Export.Model.BaseBehaviorModel<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Model_DownloadBehaviorModel">iTin.Export.Model.DownloadBehaviorModel</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Model_MailBehaviorModel">iTin.Export.Model.MailBehaviorModel</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Model_ToDropboxBehaviorModel">iTin.Export.Model.ToDropboxBehaviorModel</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Model_ToSkyDriveBehaviorModel">iTin.Export.Model.ToSkyDriveBehaviorModel</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Model_TransformFileBehaviorModel">iTin.Export.Model.TransformFileBehaviorModel</a><br />
**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
[SerializableAttribute]
public abstract class BaseBehaviorModel : BaseModel<BaseBehaviorModel>, 
	IBehavior
```

**VB**<br />
``` VB
<SerializableAttribute>
Public MustInherit Class BaseBehaviorModel
	Inherits BaseModel(Of BaseBehaviorModel)
	Implements IBehavior
```

The BaseBehaviorModel type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_Model_BaseBehaviorModel__ctor">BaseBehaviorModel</a></td><td>
Initializes a new instance of the BaseBehaviorModel class.</td></tr></table>&nbsp;
<a href="#basebehaviormodel-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_BaseBehaviorModel_CanExecute">CanExecute</a></td><td>
Gets or sets a value indicating whether executes behavior.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseBehaviorModel_IsDefault">IsDefault</a></td><td>
Gets a value indicating whether this instance contains the default.
 (Overrides BaseModel.IsDefault.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseModel_1_Properties">Properties</a></td><td>
Gets or sets a reference to user-defined property list for this element.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr></table>&nbsp;
<a href="#basebehaviormodel-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>Equals</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseBehaviorModel_Execute">Execute(IWriter)</a></td><td>
Execute behavior.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseBehaviorModel_Execute_1">Execute(IWriter, ExportSettings)</a></td><td>
Execute behavior.</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_Model_BaseBehaviorModel_ExecuteBehavior">ExecuteBehavior</a></td><td>
Code for execute behavior</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>Finalize</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetHashCode</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_GetStaticBindingValue">GetStaticBindingValue</a></td><td>
Gets the static binding value by reflection.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetType</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>MemberwiseClone</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_SaveToFile">SaveToFile(String)</a></td><td>
Saves to file.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_SaveToFile_1">SaveToFile(String, Exception)</a></td><td>
Serializes current BaseModel object into file
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_Serialize">Serialize</a></td><td>
Serializes current BaseModel object into an Xml document.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseBehaviorModel_SetOwner">SetOwner</a></td><td>
Sets a reference to the owner object that contains this instance.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_ToString">ToString</a></td><td>
Returns a string that represents the current object.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr></table>&nbsp;
<a href="#basebehaviormodel-class">Back to Top</a>

## Remarks

The following table shows the different behaviors.
&nbsp;<table><tr><th>Class</th><th>Description</th></tr><tr><td><a href="T_iTin_Export_Model_DownloadBehaviorModel">DownloadBehaviorModel</a></td><td>Represents download behavior. Applies only in web mode</td></tr><tr><td><a href="T_iTin_Export_Model_MailBehaviorModel">MailBehaviorModel</a></td><td>Represents a email list behavior.</td></tr><tr><td><a href="T_iTin_Export_Model_TransformFileBehaviorModel">TransformFileBehaviorModel</a></td><td>Represents a transform file behavior. If the writer that we are using generates a Xml transform file, this element allows us to define their behavior. Allows indicate if you want save it, where and if Xml code generated will indented.</td></tr><tr><td><a href="T_iTin_Export_Model_ToDropboxBehaviorModel">ToDropboxBehaviorModel</a></td><td>Represents a upload file behavior to Dropbox cloud service. Upload the result of export to Dropbox.</td></tr><tr><td><a href="T_iTin_Export_Model_ToSkyDriveBehaviorModel">ToSkyDriveBehaviorModel</a></td><td>Represents a upload file behavior to Microsoft SkyDrive cloud service. Upload the result of export to Microsoft SkyDrive.</td></tr></table>&nbsp;
&nbsp;<table><tr><th>![Note](media/AlertNote.png) Note</th></tr><tr><td>For developers, to create new behaviors;
&nbsp;<ol><li>Should be create new class that inherit from this class.</li><li>Add custom properties for your new behavior.</li><li>Implement the method ExecuteBehavior(IWriter, ExportSettings).</li><li>Create an instance of the new behavior.</li><li>Add instance to behavior collection.</li><li>Enjoy!!!.</li></ol></td></tr></table>

## See Also


#### Reference
<a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />