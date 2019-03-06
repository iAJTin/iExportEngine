# GlobalResourcesModel Class
Additional header content 

Includes the description and data table definition to export.


## Inheritance Hierarchy
System.Object<br />&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseModel_1">iTin.Export.Model.BaseModel</a>(GlobalResourcesModel)<br />&nbsp;&nbsp;&nbsp;&nbsp;iTin.Export.Model.GlobalResourcesModel<br />
**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
[SerializableAttribute]
public class GlobalResourcesModel : BaseModel<GlobalResourcesModel>
```

**VB**<br />
``` VB
<SerializableAttribute>
Public Class GlobalResourcesModel
	Inherits BaseModel(Of GlobalResourcesModel)
```

The GlobalResourcesModel type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_GlobalResourcesModel__ctor">GlobalResourcesModel</a></td><td>
Initializes a new instance of the GlobalResourcesModel class</td></tr></table>&nbsp;
<a href="#globalresourcesmodel-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_GlobalResourcesModel_Conditions">Conditions</a></td><td>
Gets or sets the collection of user-defined conditions.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_GlobalResourcesModel_Filters">Filters</a></td><td>
Gets or sets the collection of user-defined filters.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_GlobalResourcesModel_Fixed">Fixed</a></td><td>
Gets or sets collection of user-defined pieces.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_GlobalResourcesModel_Groups">Groups</a></td><td>
Gets or sets collection of user-defined groups.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_GlobalResourcesModel_Hosts">Hosts</a></td><td>
Gets or sets collection of user-defined groups.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_GlobalResourcesModel_Images">Images</a></td><td>
Gets or sets the collection of user-defined styles.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_GlobalResourcesModel_IsDefault">IsDefault</a></td><td>
Gets a value indicating whether this instance is default.
 (Overrides BaseModel.IsDefault.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_GlobalResourcesModel_Lines">Lines</a></td><td /></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseModel_1_Properties">Properties</a></td><td>
Gets or sets a reference to user-defined property list for this element.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_GlobalResourcesModel_Styles">Styles</a></td><td>
Gets or sets the collection of user-defined styles.</td></tr></table>&nbsp;
<a href="#globalresourcesmodel-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>Equals</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>Finalize</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetHashCode</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_GlobalResourcesModel_GetImageResourceByKey">GetImageResourceByKey</a></td><td>
Gets specified image resource by key.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_GlobalResourcesModel_GetResourceByKey">GetResourceByKey</a></td><td>
Gets specified resource by key.</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_GetStaticBindingValue">GetStaticBindingValue</a></td><td>
Gets the static binding value by reflection.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_GlobalResourcesModel_GetStyleResourceByName">GetStyleResourceByName</a></td><td>
Gets specified style resource by name.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetType</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>MemberwiseClone</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_SaveToFile">SaveToFile(String)</a></td><td>
Saves to file.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_SaveToFile_1">SaveToFile(String, Exception)</a></td><td>
Serializes current BaseModel object into file
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_Serialize">Serialize</a></td><td>
Serializes current BaseModel object into an Xml document.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_ToString">ToString</a></td><td>
Returns a string that represents the current object.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr></table>&nbsp;
<a href="#globalresourcesmodel-class">Back to Top</a>

## Remarks

Belongs to: <strong>`Exports`</strong>. For more information, please see <a href="T_iTin_Export_Model_ExportsModel">ExportsModel</a>.<br />
**ITEE Object Element Usage**<br />
``` XML
<Global.Resources>
  <Fixed/>
  <Groups/>
  <Hosts/>
  <Images/>
  <Lines/>
  <Styles/>
  <Conditions/>
</Global.Resources>
```


<strong>Elements</strong>
&nbsp;<table><tr><th>Element</th><th>Description</th></tr><tr><td><a href="P_iTin_Export_Model_GlobalResourcesModel_Images">Images</a></td><td>Description of the export.</td></tr><tr><td><a href="P_iTin_Export_Model_GlobalResourcesModel_Fixed">Fixed</a></td><td>Collection of user-defined pieces. Each element is a collection of smaller pieces result of splitting the reference field.</td></tr><tr><td><a href="P_iTin_Export_Model_GlobalResourcesModel_Groups">Groups</a></td><td>Collection of user-defined groups. Each element is result from the union of several data field.</td></tr><tr><td><a href="P_iTin_Export_Model_GlobalResourcesModel_Lines">Lines</a></td><td>Collection of user-defined lines. Each element is result from the union of lines.</td></tr><tr><td><a href="P_iTin_Export_Model_GlobalResourcesModel_Styles">Styles</a></td><td>Collection of user-defined styles. Each element defines type of content, such as the background color, the alignment type, the data type and the font type.</td></tr><tr><td><a href="P_iTin_Export_Model_GlobalResourcesModel_Conditions">Conditions</a></td><td>Collection of user-defined conditions. Each element defines a condition.</td></tr></table>&nbsp;
<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br /><a href="T_iTin_Export_Writers_CsvWriter">CsvWriter</a></th><th>Tab-Separated Values<br /><a href="T_iTin_Export_Writers_TsvWriter">TsvWriter</a></th><th>SQL Script<br /><a href="T_iTin_Export_Writers_SqlScriptWriter">SqlScriptWriter</a></th><th>XML Spreadsheet 2003<br /><a href="T_iTin_Export_Writers_Spreadsheet2003TabularWriter">Spreadsheet2003TabularWriter</a></th></tr><tr><td align="center">X</td><td align="center">X</td><td align="center">X</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## See Also


#### Reference
<a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />