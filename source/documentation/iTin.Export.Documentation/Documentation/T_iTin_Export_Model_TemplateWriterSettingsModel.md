# TemplateWriterSettingsModel Class
Additional header content 

Reference to the settings defined for this writer.


## Inheritance Hierarchy
System.Object<br />&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseModel_1">iTin.Export.Model.BaseModel</a>(TemplateWriterSettingsModel)<br />&nbsp;&nbsp;&nbsp;&nbsp;iTin.Export.Model.TemplateWriterSettingsModel<br />
**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
[SerializableAttribute]
public class TemplateWriterSettingsModel : BaseModel<TemplateWriterSettingsModel>
```

**VB**<br />
``` VB
<SerializableAttribute>
Public Class TemplateWriterSettingsModel
	Inherits BaseModel(Of TemplateWriterSettingsModel)
```

The TemplateWriterSettingsModel type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_TemplateWriterSettingsModel__ctor">TemplateWriterSettingsModel</a></td><td>
Initializes a new instance of the TemplateWriterSettingsModel class.</td></tr></table>&nbsp;
<a href="#templatewritersettingsmodel-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_TemplateWriterSettingsModel_FieldPrefix">FieldPrefix</a></td><td>
Gets or sets the preferred previous delimiter for field.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_TemplateWriterSettingsModel_FieldSufix">FieldSufix</a></td><td>
Gets or sets the preferred posterior delimiter for field.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_TemplateWriterSettingsModel_IsDefault">IsDefault</a></td><td>
Gets a value indicating whether this instance is default.
 (Overrides BaseModel.IsDefault.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseModel_1_Properties">Properties</a></td><td>
Gets or sets a reference to user-defined property list for this element.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_TemplateWriterSettingsModel_RecordsToShow">RecordsToShow</a></td><td>
Gets or sets number of affected records.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_TemplateWriterSettingsModel_TrimFields">TrimFields</a></td><td>
Gets or sets a value indicating whether to trim the blanks.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_TemplateWriterSettingsModel_TrimMode">TrimMode</a></td><td>
Gets or sets a value that determines trim mode for strings.</td></tr></table>&nbsp;
<a href="#templatewritersettingsmodel-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>Equals</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>Finalize</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetHashCode</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_GetStaticBindingValue">GetStaticBindingValue</a></td><td>
Gets the static binding value by reflection.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetType</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>MemberwiseClone</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_SaveToFile">SaveToFile(String)</a></td><td>
Saves to file.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_SaveToFile_1">SaveToFile(String, Exception)</a></td><td>
Serializes current BaseModel object into file
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_Serialize">Serialize</a></td><td>
Serializes current BaseModel object into an Xml document.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_ToString">ToString</a></td><td>
Returns a string that represents the current object.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr></table>&nbsp;
<a href="#templatewritersettingsmodel-class">Back to Top</a>

## Remarks

Belongs to: <strong>`Template`</strong>. For more information, please see <a href="T_iTin_Export_Model_TemplateModel">TemplateModel</a>. 
**ITEE Object Element Usage**<br />
``` XML
<Settings/>
```


<strong>Attributes</strong><table><tr><th>Attribute</th><th>Optional</th><th>Description</th></tr><tr><td><a href="P_iTin_Export_Model_TemplateWriterSettingsModel_FieldPrefix">FieldPrefix</a></td><td align="center">Yes</td><td>The preferred previous delimiter for field. The default is "`@@`".</td></tr><tr><td><a href="P_iTin_Export_Model_TemplateWriterSettingsModel_FieldSufix">FieldSufix</a></td><td align="center">Yes</td><td>The preferred posterior delimiter for field. The default is an empty string ("").</td></tr><tr><td><a href="P_iTin_Export_Model_TemplateWriterSettingsModel_RecordsToShow">RecordsToShow</a></td><td align="center">Yes</td><td>Number of affected records. The default is <a href="T_iTin_Export_Model_KnownRecordToShow">All</a>.</td></tr><tr><td><a href="P_iTin_Export_Model_TemplateWriterSettingsModel_TrimFields">TrimFields</a></td><td align="center">Yes</td><td>Determines whether to apply string trim mode. The default is <a href="T_iTin_Export_Model_YesNo">No</a></td></tr><tr><td><a href="P_iTin_Export_Model_TemplateWriterSettingsModel_TrimMode">TrimMode</a></td><td align="center">Yes</td><td>Use this attribute to specify trim mode for strings. The default is <a href="T_iTin_Export_Model_KnownTrimMode">All</a>.</td></tr></table>

## See Also


#### Reference
<a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />