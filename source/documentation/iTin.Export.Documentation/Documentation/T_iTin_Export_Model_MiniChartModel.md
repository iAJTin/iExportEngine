# MiniChartModel Class
Additional header content 

Represents a user-defined mini-chart.


## Inheritance Hierarchy
System.Object<br />&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseModel_1">iTin.Export.Model.BaseModel</a>(<a href="T_iTin_Export_Model_BaseChartModel">BaseChartModel</a>)<br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseChartModel">iTin.Export.Model.BaseChartModel</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;iTin.Export.Model.MiniChartModel<br />
**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
[SerializableAttribute]
public class MiniChartModel : BaseChartModel
```

**VB**<br />
``` VB
<SerializableAttribute>
Public Class MiniChartModel
	Inherits BaseChartModel
```

The MiniChartModel type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_MiniChartModel__ctor">MiniChartModel</a></td><td>
Initializes a new instance of the MiniChartModel class.</td></tr></table>&nbsp;
<a href="#minichartmodel-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_MiniChartModel_Axes">Axes</a></td><td /></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_MiniChartModel_ChartType">ChartType</a></td><td>
Gets a value indicating chart type.
 (Overrides <a href="P_iTin_Export_Model_BaseChartModel_ChartType">BaseChartModel.ChartType</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_MiniChartModel_DisplayHidden">DisplayHidden</a></td><td /></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_MiniChartModel_EmptyValueAs">EmptyValueAs</a></td><td /></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_MiniChartModel_Field">Field</a></td><td /></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_MiniChartModel_IsDefault">IsDefault</a></td><td> (Overrides <a href="P_iTin_Export_Model_BaseChartModel_IsDefault">BaseChartModel.IsDefault</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseModel_1_Properties">Properties</a></td><td>
Gets or sets a reference to user-defined property list for this element.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseChartModel_Show">Show</a></td><td> (Inherited from <a href="T_iTin_Export_Model_BaseChartModel">BaseChartModel</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_MiniChartModel_Type">Type</a></td><td /></tr></table>&nbsp;
<a href="#minichartmodel-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>Equals</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>Finalize</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetHashCode</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_GetStaticBindingValue">GetStaticBindingValue</a></td><td>
Gets the static binding value by reflection.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetType</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>MemberwiseClone</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_SaveToFile">SaveToFile(String)</a></td><td>
Saves to file.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_SaveToFile_1">SaveToFile(String, Exception)</a></td><td>
Serializes current BaseModel object into file
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_Serialize">Serialize</a></td><td>
Serializes current BaseModel object into an Xml document.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseChartModel_SetOwner">SetOwner</a></td><td>
Sets the element that owns this <a href="T_iTin_Export_Model_ChartModel">ChartModel</a>.
 (Inherited from <a href="T_iTin_Export_Model_BaseChartModel">BaseChartModel</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_MiniChartModel_ToString">ToString</a></td><td>
Returns a string that represents the current object.
 (Overrides <a href="M_iTin_Export_Model_BaseChartModel_ToString">BaseChartModel.ToString()</a>.)</td></tr></table>&nbsp;
<a href="#minichartmodel-class">Back to Top</a>

## Remarks

Belongs to: <strong>`Charts`</strong>. For more information, please see <a href="T_iTin_Export_Model_ChartsModel">ChartsModel</a>. 
**ITEE Object Element Usage**<br />
``` XML
<MiniChart...>
  <Location/>
  <Axes/>
  <Type/>
  <Properties/>
</Font>
```


<strong>Attributes</strong>
&nbsp;<table><tr><th>Attribute</th><th>Optional</th><th>Description</th><th>Default</th></tr><tr><td><a href="P_iTin_Export_Model_MiniChartModel_Field">Field</a></td><td>No</td><td>Name of field that contains data.</td><td /></tr><tr><td>EmptyValuesAs</td><td>Yes</td><td>Preferred action when the field does not contain information.</td><td>The default is `Gap`</td></tr><tr><td>Show</td><td>Yes</td><td>Determines whether displays the mini-chart.</td><td>The default is `Yes`</td></tr></table>&nbsp;
<strong>Elements</strong>
&nbsp;<table><tr><th>Element</th><th>Description</th></tr><tr><td>MiniChartLocationModel</td><td>Defines the mini-chart location on the host, this can be by coordinates or by column or by row. You can only choose one of them. If this tag does not define the defaults is by column</td></tr><tr><td>MiniChartAxesModel</td><td>Defines the mini-chart axes configuration.</td></tr><tr><td>MiniChartTypeModel</td><td>Defines the mini-chart type configuration.</td></tr><tr><td>Properties</td><td>Reference to custom properties dictionary</td></tr></table>&nbsp;
<strong>Compatibility table with native writers.</strong>
&nbsp;<table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td /><td /><td /><td /></tr></table>&nbsp;
A `<b>X</b>` value indicates that the writer supports this element.


## See Also


#### Reference
<a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />