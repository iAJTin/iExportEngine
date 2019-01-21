# StyleModel Class
Additional header content 

Defines a single style, includes definition for a font type, type of content, such as the background color, the alignment type and the data type.


## Inheritance Hierarchy
System.Object<br />&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseModel_1">iTin.Export.Model.BaseModel</a>(StyleModel)<br />&nbsp;&nbsp;&nbsp;&nbsp;iTin.Export.Model.StyleModel<br />
**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
[SerializableAttribute]
public class StyleModel : BaseModel<StyleModel>, 
	ICloneable
```

**VB**<br />
``` VB
<SerializableAttribute>
Public Class StyleModel
	Inherits BaseModel(Of StyleModel)
	Implements ICloneable
```

The StyleModel type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_StyleModel__ctor">StyleModel</a></td><td>
Initializes a new instance of the StyleModel class</td></tr></table>&nbsp;
<a href="#stylemodel-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_StyleModel_Borders">Borders</a></td><td>
Gets or sets the collection of border properties.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_StyleModel_Content">Content</a></td><td>
Gets or sets a reference to the content model.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Static member](media/static.gif "Static member")</td><td><a href="P_iTin_Export_Model_StyleModel_Default">Default</a></td><td>
Gets a default style.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Static member](media/static.gif "Static member")</td><td><a href="P_iTin_Export_Model_StyleModel_Empty">Empty</a></td><td>
Gets an empty style.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_StyleModel_Font">Font</a></td><td>
Gets or sets the font model.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_StyleModel_Inherits">Inherits</a></td><td>
Gets or sets the name of parent style.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_StyleModel_IsDefault">IsDefault</a></td><td>
Gets a value indicating whether this instance is default.
 (Overrides BaseModel.IsDefault.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_StyleModel_IsEmpty">IsEmpty</a></td><td>
Gets a value indicating whether this style is an empty style.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_StyleModel_Name">Name</a></td><td>
Gets or sets the name of the style.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseModel_1_Properties">Properties</a></td><td>
Gets or sets a reference to user-defined property list for this element.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr></table>&nbsp;
<a href="#stylemodel-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_StyleModel_Clone">Clone</a></td><td>
Clones this instance.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_StyleModel_Combine">Combine(StyleModel)</a></td><td>
Combines this instance with reference parameter.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_StyleModel_Combine_1">Combine(StyleModel, Boolean)</a></td><td>
Combines this instance with reference parameter.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>Equals</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>Finalize</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetHashCode</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_GetStaticBindingValue">GetStaticBindingValue</a></td><td>
Gets the static binding value by reflection.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetType</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>MemberwiseClone</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_SaveToFile">SaveToFile(String)</a></td><td>
Saves to file.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_SaveToFile_1">SaveToFile(String, Exception)</a></td><td>
Serializes current BaseModel object into file
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_Serialize">Serialize</a></td><td>
Serializes current BaseModel object into an Xml document.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_ToString">ToString</a></td><td>
Returns a string that represents the current object.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_StyleModel_TryGetInheritStyle">TryGetInheritStyle</a></td><td>
Try gets a reference to inherit model.</td></tr></table>&nbsp;
<a href="#stylemodel-class">Back to Top</a>

## Fields
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_iTin_Export_Model_StyleModel_NameOfDefaultStyle">NameOfDefaultStyle</a></td><td>
The name of default style. Always is '_Default_'.</td></tr></table>&nbsp;
<a href="#stylemodel-class">Back to Top</a>

## Remarks

<strong>Type Information</strong>
&nbsp;<table><tr><td><strong>Namespace</strong></td><td>http://schemas.itin.com/export/engine/2014/configuration/v1.0</td></tr><tr><td><strong>Schema name</strong></td><td>iTin Export Configuration File</td></tr></table>&nbsp;
<strong>Parent Element</strong>
&nbsp;<table><tr><th>Element</th><th>Description</th></tr><tr><td><a href="T_iTin_Export_Model_StylesModel">StylesModel</a></td><td>Contains a collection of user-defined styles. Each element defines type of content, such as the background color, the alignment type, the data type and the font type.</td></tr></table>&nbsp;
<strong>Child Elements</strong>
&nbsp;<table><tr><th>Element</th><th>Description</th></tr><tr><td><a href="P_iTin_Export_Model_StyleModel_Borders">Borders</a></td><td>Defines the border properties to use.</td></tr><tr><td><a href="P_iTin_Export_Model_StyleModel_Content">Content</a></td><td>Defines as shown the content of a field.</td></tr><tr><td><a href="P_iTin_Export_Model_StyleModel_Font">Font</a></td><td>Represents a font. Defines a particular format for text, including font face, size, and style attributes.</td></tr></table>&nbsp;
<strong>Attributes</strong><table><tr><th>Attribute</th><th>Required</th><th>Description</th><th>Possible Values</th></tr><tr><td><a href="P_iTin_Export_Model_StyleModel_Name">Name</a></td><td align="center">Yes</td><td>Name of the style.</td><td>See <a href="P_iTin_Export_Model_StyleModel_Name">Name</a> property</td></tr></table><strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.

<strong>XML Usage</strong>


**ITEE Object Element Usage**<br />
``` XML
<Style>
  <Borders/>
  <Content>
    <Alignment/>
    <Numeric/> | <Currency/> | <Percentage/> | <Scientific/> | <Datetime/> | <Special/> <Text/>
  </Content>
  <Font/>
</Style>
```



## See Also


#### Reference
<a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />