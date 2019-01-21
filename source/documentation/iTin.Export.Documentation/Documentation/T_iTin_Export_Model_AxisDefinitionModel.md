# AxisDefinitionModel Class
Additional header content 

Represents the visual setting of a axis.


## Inheritance Hierarchy
System.Object<br />&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseModel_1">iTin.Export.Model.BaseModel</a>(AxisDefinitionModel)<br />&nbsp;&nbsp;&nbsp;&nbsp;iTin.Export.Model.AxisDefinitionModel<br />
**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
[SerializableAttribute]
public class AxisDefinitionModel : BaseModel<AxisDefinitionModel>
```

**VB**<br />
``` VB
<SerializableAttribute>
Public Class AxisDefinitionModel
	Inherits BaseModel(Of AxisDefinitionModel)
```

The AxisDefinitionModel type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_AxisDefinitionModel__ctor">AxisDefinitionModel</a></td><td>
Initializes a new instance of the AxisDefinitionModel class.</td></tr></table>&nbsp;
<a href="#axisdefinitionmodel-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_AxisDefinitionModel_GridLines">GridLines</a></td><td>
Gets or sets preferred grid lines for axis.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_AxisDefinitionModel_IsDefault">IsDefault</a></td><td> (Overrides BaseModel.IsDefault.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_AxisDefinitionModel_Labels">Labels</a></td><td>
Gets or sets a reference that contains the visual setting of labels axis.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_AxisDefinitionModel_Marks">Marks</a></td><td>
Gets or sets a reference that contains the visual setting of mark axis.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseModel_1_Properties">Properties</a></td><td>
Gets or sets a reference to user-defined property list for this element.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_AxisDefinitionModel_Show">Show</a></td><td>
Gets or sets a value that determines whether displays the axis.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_AxisDefinitionModel_Title">Title</a></td><td>
Gets or sets a reference that contains the visual setting of axis title.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_AxisDefinitionModel_Values">Values</a></td><td>
Gets or sets a reference that contains the visual setting of values axis.</td></tr></table>&nbsp;
<a href="#axisdefinitionmodel-class">Back to Top</a>

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
<a href="#axisdefinitionmodel-class">Back to Top</a>

## Remarks

Belongs to: <strong>`Primary`</strong>, or <strong>`Secondary`</strong>. For more information, please see <a href="T_iTin_Export_Model_AxisModel">AxisModel</a>. 
**ITEE Object Element Usage**<br />
``` XML
<Category>
  <Labels/>
  <Marks/>
  <Title/>
  <Values/>
</Category>
```

- Or -

**ITEE Object Element Usage**<br />
``` XML
<Values>
  <Labels/>
  <Marks/>
  <Title/>
  <Values/>
</Values>
```


<strong>Attributes</strong><table><tr><th>Attribute</th><th>Optional</th><th>Description</th></tr><tr><td><a href="P_iTin_Export_Model_AxisDefinitionModel_GridLines">GridLines</a></td><td align="center">Yes</td><td>Preferred grid lines for axis. The default is <a href="T_iTin_Export_Model_KnownPlotGridLine">None</a>.</td></tr><tr><td><a href="P_iTin_Export_Model_AxisDefinitionModel_Show">Show</a></td><td align="center">Yes</td><td>Determines whether displays the axis. The default is <a href="T_iTin_Export_Model_YesNo">Yes</a>.</td></tr></table><strong>Elements</strong>
&nbsp;<table><tr><th>Element</th><th>Description</th></tr><tr><td><a href="P_iTin_Export_Model_AxisDefinitionModel_Labels">Labels</a></td><td>Reference that contains the visual setting of labels axis.</td></tr><tr><td><a href="P_iTin_Export_Model_AxisDefinitionModel_Marks">Marks</a></td><td>Reference that contains the visual setting of mark axis.</td></tr><tr><td><a href="P_iTin_Export_Model_AxisDefinitionModel_Title">Title</a></td><td>Reference that contains the visual setting of axis title. Includes a text, visibility, orientation, border and font.</td></tr><tr><td><a href="P_iTin_Export_Model_AxisDefinitionModel_Values">Values</a></td><td>Reference that contains the visual setting of values axis.</td></tr></table>&nbsp;
<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">No has effect</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## See Also


#### Reference
<a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />