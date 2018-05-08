# FontModel Class
Additional header content 

Represents a font. Defines a particular format for text, including font face, size, and style attributes.


## Inheritance Hierarchy
System.Object<br />&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseModel_1">iTin.Export.Model.BaseModel</a>(FontModel)<br />&nbsp;&nbsp;&nbsp;&nbsp;iTin.Export.Model.FontModel<br />
**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
[SerializableAttribute]
public class FontModel : BaseModel<FontModel>, 
	ICloneable
```

**VB**<br />
``` VB
<SerializableAttribute>
Public Class FontModel
	Inherits BaseModel(Of FontModel)
	Implements ICloneable
```

The FontModel type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_FontModel__ctor">FontModel</a></td><td>
Initializes a new instance of the FontModel class.</td></tr></table>&nbsp;
<a href="#fontmodel-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_FontModel_Bold">Bold</a></td><td>
Gets or sets a value indicating whether bold style is applied for this font.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_FontModel_Color">Color</a></td><td>
Gets or sets preferred font color.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Static member](media/static.gif "Static member")</td><td><a href="P_iTin_Export_Model_FontModel_Default">Default</a></td><td>
Gets default font.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_FontModel_FontStyles">FontStyles</a></td><td>
Gets a value that represents the different styles defined for this font.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_FontModel_IsDefault">IsDefault</a></td><td>
Gets a value indicating whether this instance is default.
 (Overrides BaseModel.IsDefault.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_FontModel_Italic">Italic</a></td><td>
Gets or sets a value indicating whether italic style is applied for this font.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_FontModel_Name">Name</a></td><td>
Gets or sets preferred font name.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseModel_1_Properties">Properties</a></td><td>
Gets or sets a reference to user-defined property list for this element.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_FontModel_Size">Size</a></td><td>
Gets or sets preferred font size.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_FontModel_Underline">Underline</a></td><td>
Gets or sets a value indicating whether the underline style is applied for this font.</td></tr></table>&nbsp;
<a href="#fontmodel-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_FontModel_Clone">Clone</a></td><td>
Clones this instance.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_FontModel_Combine">Combine</a></td><td>
Combines this instance with reference parameter.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>Equals</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>Finalize</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_FontModel_GetColor">GetColor</a></td><td>
Gets a reference to the Color structure preferred for this font.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetHashCode</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_GetStaticBindingValue">GetStaticBindingValue</a></td><td>
Gets the static binding value by reflection.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetType</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>MemberwiseClone</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_SaveToFile">SaveToFile(String)</a></td><td>
Saves to file.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_SaveToFile_1">SaveToFile(String, Exception)</a></td><td>
Serializes current BaseModel object into file
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_Serialize">Serialize</a></td><td>
Serializes current BaseModel object into an Xml document.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_FontModel_ToFont">ToFont</a></td><td>
Gets a reference to native .NET font representing the font model</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_ToString">ToString</a></td><td>
Returns a string that represents the current object.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr></table>&nbsp;
<a href="#fontmodel-class">Back to Top</a>

## Remarks


**IEE Object Element Usage**<br />
``` XML
<Font...>
  <Properties/>
</Font>
```


<strong>Attributes</strong>
&nbsp;<table><tr><th>Attribute</th><th>Optional</th><th>Description</th><th>Default</th></tr><tr><td><a href="P_iTin_Export_Model_FontModel_Name">Name</a></td><td>Yes</td><td>Preferred font name.</td><td>The default is `Segoe UI`</td></tr><tr><td><a href="P_iTin_Export_Model_FontModel_Size">Size</a></td><td>Yes</td><td>Preferred font size.</td><td>The default is `10.0`</td></tr><tr><td><a href="P_iTin_Export_Model_FontModel_Color">Color</a></td><td>Yes</td><td>Preferred font color.</td><td>The default is `Black`</td></tr><tr><td><a href="P_iTin_Export_Model_FontModel_Bold">Bold</a></td><td>Yes</td><td>Determines whether bold style is applied for this font.</td><td>The default is `No`</td></tr><tr><td><a href="P_iTin_Export_Model_FontModel_Italic">Italic</a></td><td>Yes</td><td>Determines whether italic style is applied for this font.</td><td>The default is `No`</td></tr><tr><td><a href="P_iTin_Export_Model_FontModel_Underline">Underline</a></td><td>Yes</td><td>Determines whether the underline style is applied for this font.</td><td>The default is `No`</td></tr></table>&nbsp;
<strong>Elements</strong>
&nbsp;<table><tr><th>Element</th><th>Description</th></tr><tr><td>Properties</td><td>Reference to custom properties dictionary</td></tr></table>&nbsp;
<strong>Compatibility table with native writers.</strong>
&nbsp;<table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td>X</td><td>X</td><td>X</td><td>X</td></tr></table>&nbsp;
A `<b>X</b>` value indicates that the writer supports this element.


## See Also


#### Reference
<a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />