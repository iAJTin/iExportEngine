# ChartTitleModel Class
Additional header content 

Represents the visual setting of title. Includes a text, visibility, orientation, border and font.


## Inheritance Hierarchy
System.Object<br />&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseModel_1">iTin.Export.Model.BaseModel</a>(ChartTitleModel)<br />&nbsp;&nbsp;&nbsp;&nbsp;iTin.Export.Model.ChartTitleModel<br />
**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
[SerializableAttribute]
public class ChartTitleModel : BaseModel<ChartTitleModel>
```

**VB**<br />
``` VB
<SerializableAttribute>
Public Class ChartTitleModel
	Inherits BaseModel(Of ChartTitleModel)
```

The ChartTitleModel type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_ChartTitleModel__ctor">ChartTitleModel</a></td><td>
Initializes a new instance of the ChartTitleModel class.</td></tr></table>&nbsp;
<a href="#charttitlemodel-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_ChartTitleModel_Border">Border</a></td><td>
Gets or sets a reference that contains the visual setting for border of title.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_ChartTitleModel_Font">Font</a></td><td>
Gets or sets a reference to the font model defined for this title.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_ChartTitleModel_IsDefault">IsDefault</a></td><td>
When overridden in a derived class, gets a value indicating whether this instance contains the default.
 (Overrides BaseModel.IsDefault.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_ChartTitleModel_Orientation">Orientation</a></td><td>
Gets or sets preferred orientation for the title.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseModel_1_Properties">Properties</a></td><td>
Gets or sets a reference to user-defined property list for this element.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_ChartTitleModel_Show">Show</a></td><td>
Gets or sets a value that determines whether displays the title.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_ChartTitleModel_Text">Text</a></td><td>
Gets or sets text of title.</td></tr></table>&nbsp;
<a href="#charttitlemodel-class">Back to Top</a>

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
<a href="#charttitlemodel-class">Back to Top</a>

## Remarks

Belongs to: <strong>`Chart`</strong>. For more information, please see <a href="T_iTin_Export_Model_ChartModel">ChartModel</a>. 
**ITEE Object Element Usage**<br />
``` XML
<Title>
  <Text/>
  <Border/>
  <Font/>
</Border>
```


<strong>Attributes</strong><table><tr><th>Attribute</th><th>Optional</th><th>Description</th></tr><tr><td><a href="P_iTin_Export_Model_ChartTitleModel_Show">Show</a></td><td align="center">Yes</td><td>Determines whether displays the title. The default is <a href="T_iTin_Export_Model_YesNo">Yes</a>.</td></tr><tr><td><a href="P_iTin_Export_Model_ChartTitleModel_Orientation">Orientation</a></td><td align="center">Yes</td><td>Preferred orientation for the title. The default is <a href="T_iTin_Export_Model_KnownAxisOrientation">Horizontal</a>.</td></tr></table><strong>Elements</strong>
&nbsp;<table><tr><th>Element</th><th>Description</th></tr><tr><td><a href="P_iTin_Export_Model_ChartTitleModel_Border">Border</a></td><td>Reference that contains the visual setting for border of title.</td></tr><tr><td><a href="P_iTin_Export_Model_ChartTitleModel_Font">Font</a></td><td>Reference to font model defined for this title.</td></tr><tr><td><a href="P_iTin_Export_Model_ChartTitleModel_Text">Text</a></td><td>The text of the title.</td></tr></table>&nbsp;
<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br /><a href="T_iTin_Export_Writers_CsvWriter">CsvWriter</a></th><th>Tab-Separated Values<br /><a href="T_iTin_Export_Writers_TsvWriter">TsvWriter</a></th><th>SQL Script<br /><a href="T_iTin_Export_Writers_SqlScriptWriter">SqlScriptWriter</a></th><th>XML Spreadsheet 2003<br /><a href="T_iTin_Export_Writers_Spreadsheet2003TabularWriter">Spreadsheet2003TabularWriter</a></th></tr><tr><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">No has effect</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## See Also


#### Reference
<a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />