# TableModel Class
Additional header content 

Includes the description of export table.


## Inheritance Hierarchy
System.Object<br />&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseModel_1">iTin.Export.Model.BaseModel</a>(TableModel)<br />&nbsp;&nbsp;&nbsp;&nbsp;iTin.Export.Model.TableModel<br />
**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
[SerializableAttribute]
public class TableModel : BaseModel<TableModel>
```

**VB**<br />
``` VB
<SerializableAttribute>
Public Class TableModel
	Inherits BaseModel(Of TableModel)
```

The TableModel type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_TableModel__ctor">TableModel</a></td><td>
Initializes a new instance of the TableModel class.</td></tr></table>&nbsp;
<a href="#tablemodel-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_TableModel_Alias">Alias</a></td><td>
Gets or sets the alias of the table.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_TableModel_AutoFilter">AutoFilter</a></td><td>
Gets or sets a value indicating whether displays the autofilter.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_TableModel_AutoFitColumns">AutoFitColumns</a></td><td>
Gets or sets a value indicating whether adjusts column width automatically.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_TableModel_Charts">Charts</a></td><td>
Gets or sets collection of user-defined charts.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_TableModel_Conditions">Conditions</a></td><td /></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_TableModel_Exporter">Exporter</a></td><td>
Gets or sets a reference to the exporter model defined for this table</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_TableModel_Fields">Fields</a></td><td>
Gets or sets collection of data fields.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_TableModel_HasFields">HasFields</a></td><td>
Gets a value indicating whether there are fields defined.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_TableModel_Headers">Headers</a></td><td>
Gets or sets the headers.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_TableModel_Host">Host</a></td><td>
Gets or sets the alias of the table.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_TableModel_Location">Location</a></td><td>
Gets or sets a reference which contains the location of the table in the host, this can be by coordinates or by type of alignment, depending whether the host has or not a tabular format. You can only choose one of the modes. If this tag does not define the defaults is by coordinates</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_TableModel_Logo">Logo</a></td><td>
Gets or sets a reference to the logo model defined for this table.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_TableModel_Name">Name</a></td><td>
Gets or sets name of the table.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_TableModel_Output">Output</a></td><td>
Gets or sets a reference to output configuration model, it includes path and file name.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseModel_1_Properties">Properties</a></td><td>
Gets or sets a reference to user-defined property list for this element.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_TableModel_ShowColumnHeaders">ShowColumnHeaders</a></td><td>
Gets or sets the show column headers.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_TableModel_ShowGridLines">ShowGridLines</a></td><td>
Gets or sets a value indicating whether show grid lines.</td></tr></table>&nbsp;
<a href="#tablemodel-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>Equals</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>Finalize</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetHashCode</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_TableModel_GetHeaderColumnsSize">GetHeaderColumnsSize</a></td><td>
Gets a dictionary containing the pair of header column number / size in pixels of the same.</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_GetStaticBindingValue">GetStaticBindingValue</a></td><td>
Gets the static binding value by reflection.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetType</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>MemberwiseClone</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_SaveToFile">SaveToFile(String)</a></td><td>
Saves to file.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_SaveToFile_1">SaveToFile(String, Exception)</a></td><td>
Serializes current BaseModel object into file
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_Serialize">Serialize</a></td><td>
Serializes current BaseModel object into an Xml document.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_TableModel_ToString">ToString</a></td><td>
Returns a string that represents the current data type.
 (Overrides <a href="M_iTin_Export_Model_BaseModel_1_ToString">BaseModel(T).ToString()</a>.)</td></tr></table>&nbsp;
<a href="#tablemodel-class">Back to Top</a>

## Remarks

Belongs to: <strong>`Export`</strong>. For more information, please see <a href="T_iTin_Export_Model_ExportModel">ExportModel</a>.<br />
**TEE Object Element Usage**<br />
``` XML
<Table ...>
<Logo/>
<Exporter/>
<Output/>
<Location/>
<Styles/>
<Fixed/>
<Groups/>
<Fields/>
<Charts/>
</Table>
```


<strong>Attributes</strong><table><tr><th>Attribute</th><th>Optional</th><th>Description</th></tr><tr><td><a href="P_iTin_Export_Model_TableModel_Name">Name</a></td><td align="center">No</td><td>Name of the table.</td></tr><tr><td><a href="P_iTin_Export_Model_TableModel_Alias">Alias</a></td><td align="center">Yes</td><td>Alias of the table. The default is an empty string ("").</td></tr><tr><td><a href="P_iTin_Export_Model_TableModel_AutoFilter">AutoFilter</a></td><td align="center">Yes</td><td>Determines whether displays the AutoFilter. The default is <a href="T_iTin_Export_Model_YesNo">No</a>.</td></tr><tr><td><a href="P_iTin_Export_Model_TableModel_AutoFitColumns">AutoFitColumns</a></td><td align="center">Yes</td><td>Determines whether adjusts column width automatically. The default is <a href="T_iTin_Export_Model_YesNo">No</a>.</td></tr><tr><td><a href="P_iTin_Export_Model_TableModel_ShowGridLines">ShowGridLines</a></td><td align="center">Yes</td><td>Determines whether shows grid lines. The default is <a href="T_iTin_Export_Model_YesNo">Yes</a>.</td></tr></table><strong>Elements</strong>
&nbsp;<table><tr><th>Element</th><th>Description</th></tr><tr><td><a href="P_iTin_Export_Model_TableModel_Logo">Logo</a></td><td>Defines logo configuration, includes image file path, size, location, effects and visibility.</td></tr><tr><td><a href="P_iTin_Export_Model_TableModel_Exporter">Exporter</a></td><td>Defines the type of exporter to use and their behavior.</td></tr><tr><td><a href="P_iTin_Export_Model_TableModel_Output">Output</a></td><td>Defines output configuration, includes path, file name and optionaly the adapter operating system.</td></tr><tr><td><a href="P_iTin_Export_Model_TableModel_Location">Location</a></td><td>Defines the location of the table in the host, this can be by coordinates or by type of alignment, depending whether the host has or not a tabular format. You can only choose one of the modes. If this tag does not define the defaults is by coordinates.</td></tr><tr><td>Styles</td><td>Collection of user-defined styles. Each element defines type of content, such as the background color, the alignment type, the data type and the font type.</td></tr><tr><td>Groups</td><td>Collection of user-defined groups. Each element is result from the union of several data field.</td></tr><tr><td>Fixed</td><td>Collection of user-defined pieces. Each element is a collection of smaller pieces result of splitting the reference field.</td></tr><tr><td><a href="P_iTin_Export_Model_TableModel_Fields">Fields</a></td><td>Collection of data fields. Each element is a data field.</td></tr><tr><td><a href="P_iTin_Export_Model_TableModel_Charts">Charts</a></td><td>Collection of user-defined charts. Each element represents a user-defined chart.</td></tr></table>&nbsp;
<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td align="center">X</td><td align="center">X</td><td align="center">X</td><td align="center">X</td></tr></table><strong>`X`</strong>


## See Also


#### Reference
<a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />