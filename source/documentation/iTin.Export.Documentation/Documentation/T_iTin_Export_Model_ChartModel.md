# ChartModel Class
Additional header content 

Represents a user-defined chart.


## Inheritance Hierarchy
System.Object<br />&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseModel_1">iTin.Export.Model.BaseModel</a>(<a href="T_iTin_Export_Model_BaseChartModel">BaseChartModel</a>)<br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseChartModel">iTin.Export.Model.BaseChartModel</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;iTin.Export.Model.ChartModel<br />
**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
[SerializableAttribute]
public class ChartModel : BaseChartModel
```

**VB**<br />
``` VB
<SerializableAttribute>
Public Class ChartModel
	Inherits BaseChartModel
```

The ChartModel type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_ChartModel__ctor">ChartModel</a></td><td>
Initializes a new instance of the ChartModel class.</td></tr></table>&nbsp;
<a href="#chartmodel-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_ChartModel_Axes">Axes</a></td><td>
Gets or sets a reference that contains the visual setting of the chart axes.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_ChartModel_BackColor">BackColor</a></td><td>
Gets or sets preferred back color for this chart.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_ChartModel_Border">Border</a></td><td>
Gets or sets a reference that contains the visual setting of chart border.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_ChartModel_ChartSize">ChartSize</a></td><td>
Gets the dimensions of chart.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_ChartModel_ChartType">ChartType</a></td><td>
Gets a value indicating chart type.
 (Overrides <a href="P_iTin_Export_Model_BaseChartModel_ChartType">BaseChartModel.ChartType</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_ChartModel_IsDefault">IsDefault</a></td><td>
Gets a value indicating whether this instance contains the default.
 (Overrides <a href="P_iTin_Export_Model_BaseChartModel_IsDefault">BaseChartModel.IsDefault</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_ChartModel_Legend">Legend</a></td><td>
Gets or sets a reference that contains the visual setting of chart legend.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_ChartModel_Location">Location</a></td><td>
Gets or sets a reference which contains the chart location on the host, this can be by coordinates or by type of alignment, depending whether the host has or not a tabular format. You can only choose one of the modes. If this tag does not define the defaults is by coordinates</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_ChartModel_Plots">Plots</a></td><td>
Gets or sets collection of plots for a chart.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseModel_1_Properties">Properties</a></td><td>
Gets or sets a reference to user-defined property list for this element.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseChartModel_Show">Show</a></td><td> (Inherited from <a href="T_iTin_Export_Model_BaseChartModel">BaseChartModel</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_ChartModel_Size">Size</a></td><td>
Gets or sets width and height of the graphic.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_ChartModel_Title">Title</a></td><td>
Gets or sets a reference that contains the visual setting of chart title.</td></tr></table>&nbsp;
<a href="#chartmodel-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>Equals</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>Finalize</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_ChartModel_GetBackColor">GetBackColor</a></td><td>
Gets a reference to the Color structure than represents back color for this chart.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetHashCode</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_GetStaticBindingValue">GetStaticBindingValue</a></td><td>
Gets the static binding value by reflection.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetType</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>MemberwiseClone</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_SaveToFile">SaveToFile(String)</a></td><td>
Saves to file.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_SaveToFile_1">SaveToFile(String, Exception)</a></td><td>
Serializes current BaseModel object into file
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_Serialize">Serialize</a></td><td>
Serializes current BaseModel object into an Xml document.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseChartModel_SetOwner">SetOwner</a></td><td>
Sets the element that owns this ChartModel.
 (Inherited from <a href="T_iTin_Export_Model_BaseChartModel">BaseChartModel</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_ChartModel_SizeToPoints">SizeToPoints</a></td><td>
Converts chart size value in pixels to points for the specified device.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_ChartModel_ToString">ToString</a></td><td>
Returns a string that represents the current object.
 (Overrides <a href="M_iTin_Export_Model_BaseChartModel_ToString">BaseChartModel.ToString()</a>.)</td></tr></table>&nbsp;
<a href="#chartmodel-class">Back to Top</a>

## Remarks

Belongs to: <strong>`Charts`</strong>. For more information, please see <a href="T_iTin_Export_Model_ChartsModel">ChartsModel</a>. 
**ITEE Object Element Usage**<br />
``` XML
<Chart>
  <Border/>
  <Title/>
  <Legend/>
  <Location/>
  <Axes/>
  <Plots/>
</Chart>
```


<strong>Attributes</strong><table><tr><th>Attribute</th><th>Optional</th><th>Description</th></tr><tr><td>Show</td><td align="center">Yes</td><td>Determines whether displays the chart. The default is <a href="T_iTin_Export_Model_YesNo">Yes</a>.</td></tr><tr><td><a href="P_iTin_Export_Model_ChartModel_BackColor">BackColor</a></td><td align="center">Yes</td><td>Preferred back color. The default is "`White`".</td></tr><tr><td><a href="P_iTin_Export_Model_ChartModel_Location">Location</a></td><td align="center">Yes</td><td>Preferred location of chart. The default is `1 1`.</td></tr><tr><td><a href="P_iTin_Export_Model_ChartModel_Size">Size</a></td><td align="center">Yes</td><td>Width and height of the graphic. The default is `150 150`.</td></tr></table><strong>Elements</strong>
&nbsp;<table><tr><th>Element</th><th>Description</th></tr><tr><td><a href="P_iTin_Export_Model_ChartModel_Border">Border</a></td><td>Reference that contains the visual setting of chart border. Includes visibility, shadow definition, line style, width and color.</td></tr><tr><td><a href="P_iTin_Export_Model_ChartModel_Title">Title</a></td><td>Reference that contains the visual setting of chart title. Includes a text, visibility, orientation, border and font.</td></tr><tr><td><a href="P_iTin_Export_Model_ChartModel_Legend">Legend</a></td><td>Reference that contains the visual setting of chart legend. Includes visibility, location, border and font.</td></tr><tr><td><a href="P_iTin_Export_Model_ChartModel_Location">Location</a></td><td>Determines the chart location on the host, this can be by coordinates or by type of alignment, depending whether the host has or not a tabular format. You can only choose one of the modes. If this tag does not define the defaults is by coordinates.</td></tr><tr><td><a href="P_iTin_Export_Model_ChartModel_Axes">Axes</a></td><td>Reference that contains the visual setting of the chart axes.</td></tr><tr><td><a href="P_iTin_Export_Model_ChartModel_Plots">Plots</a></td><td>Collection of plots for a chart. Each element represents a chart plot.</td></tr></table>&nbsp;
<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">No has effect</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## See Also


#### Reference
<a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />