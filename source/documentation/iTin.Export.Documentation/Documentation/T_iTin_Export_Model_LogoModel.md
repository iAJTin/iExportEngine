# LogoModel Class
Additional header content 

Represents a logo.


## Inheritance Hierarchy
System.Object<br />&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseModel_1">iTin.Export.Model.BaseModel</a>(LogoModel)<br />&nbsp;&nbsp;&nbsp;&nbsp;iTin.Export.Model.LogoModel<br />
**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
[SerializableAttribute]
public class LogoModel : BaseModel<LogoModel>
```

**VB**<br />
``` VB
<SerializableAttribute>
Public Class LogoModel
	Inherits BaseModel(Of LogoModel)
```

The LogoModel type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_LogoModel__ctor">LogoModel</a></td><td>
Initializes a new instance of the LogoModel class</td></tr></table>&nbsp;
<a href="#logomodel-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_LogoModel_Image">Image</a></td><td>
Gets or sets the logo image file path.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_LogoModel_IsDefault">IsDefault</a></td><td>
When overridden in a derived class, gets a value indicating whether this instance contains the default.
 (Overrides BaseModel.IsDefault.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_LogoModel_Location">Location</a></td><td>
Gets or sets a reference which contains the location of the logo in the host, this can be by coordinates or by type of alignment, depending whether the host has or not a tabular format. You can only choose one of the modes. If this tag does not define the defaults is by coordinates</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_LogoModel_LogoSize">LogoSize</a></td><td>
Gets the dimensions of logo.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseModel_1_Properties">Properties</a></td><td>
Gets or sets a reference to user-defined property list for this element.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_LogoModel_Show">Show</a></td><td>
Gets or sets a value that determines whether displays the logo.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_LogoModel_Size">Size</a></td><td>
Gets or sets width and height of the logo.</td></tr></table>&nbsp;
<a href="#logomodel-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>Equals</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>Finalize</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetHashCode</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_GetStaticBindingValue">GetStaticBindingValue</a></td><td>
Gets the static binding value by reflection.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetType</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>MemberwiseClone</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_SaveToFile">SaveToFile(String)</a></td><td>
Saves to file.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_SaveToFile_1">SaveToFile(String, Exception)</a></td><td>
Serializes current BaseModel object into file
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_Serialize">Serialize</a></td><td>
Serializes current BaseModel object into an Xml document.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_LogoModel_SizeToPoints">SizeToPoints</a></td><td>
Converts chart size value in pixels to points for the specified device.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_ToString">ToString</a></td><td>
Returns a string that represents the current object.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr></table>&nbsp;
<a href="#logomodel-class">Back to Top</a>

## Remarks

Belongs to: <strong>`Table`</strong>. For more information, please see <a href="T_iTin_Export_Model_TableModel">TableModel</a>. 
**ITEE Object Element Usage**<br />
``` XML
<Logo>
  <Image/>
  <Location/>
</Logo>
```


<strong>Attributes</strong><table><tr><th>Attribute</th><th>Optional</th><th>Description</th></tr><tr><td><a href="P_iTin_Export_Model_LogoModel_Size">Size</a></td><td align="center">Yes</td><td>Preferred size of the logo. The default is `-1 -1`, indicates original size of logo.</td></tr><tr><td><a href="P_iTin_Export_Model_LogoModel_Show">Show</a></td><td align="center">Yes</td><td>Determines whether displays the logo. The default is <a href="T_iTin_Export_Model_YesNo">Yes</a>.</td></tr></table><strong>Elements</strong>
&nbsp;<table><tr><th>Element</th><th>Description</th></tr><tr><td><a href="P_iTin_Export_Model_LogoModel_Image">Image</a></td><td>The image file path. To specify a relative path use the character (~).</td></tr><tr><td><a href="P_iTin_Export_Model_LogoModel_Location">Location</a></td><td>Defines the location of logo in the host, this can be by coordinates or by type of alignment, depending whether the host has or not a tabular format. You can only choose one of the modes. If this tag does not define the defaults is by coordinates.</td></tr></table>&nbsp;
<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br /><a href="T_iTin_Export_Writers_CsvWriter">CsvWriter</a></th><th>Tab-Separated Values<br /><a href="T_iTin_Export_Writers_TsvWriter">TsvWriter</a></th><th>SQL Script<br /><a href="T_iTin_Export_Writers_SqlScriptWriter">SqlScriptWriter</a></th><th>XML Spreadsheet 2003<br /><a href="T_iTin_Export_Writers_Spreadsheet2003TabularWriter">Spreadsheet2003TabularWriter</a></th></tr><tr><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">No has effect</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## See Also


#### Reference
<a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />