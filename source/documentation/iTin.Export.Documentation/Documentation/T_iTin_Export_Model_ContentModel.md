# ContentModel Class
Additional header content 

Defines as shown the content of a field.


## Inheritance Hierarchy
System.Object<br />&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseModel_1">iTin.Export.Model.BaseModel</a>(ContentModel)<br />&nbsp;&nbsp;&nbsp;&nbsp;iTin.Export.Model.ContentModel<br />
**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
[SerializableAttribute]
public class ContentModel : BaseModel<ContentModel>, 
	ICloneable
```

**VB**<br />
``` VB
<SerializableAttribute>
Public Class ContentModel
	Inherits BaseModel(Of ContentModel)
	Implements ICloneable
```

The ContentModel type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_ContentModel__ctor">ContentModel</a></td><td>
Initializes a new instance of the ContentModel class.</td></tr></table>&nbsp;
<a href="#contentmodel-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_ContentModel_Alignment">Alignment</a></td><td>
Gets or sets content distribution.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_ContentModel_AlternateColor">AlternateColor</a></td><td>
Gets or sets alternative color preferred of content.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_ContentModel_Color">Color</a></td><td>
Gets or sets color preferred of content.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_ContentModel_DataType">DataType</a></td><td>
Gets or sets content data type.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Static member](media/static.gif "Static member")</td><td><a href="P_iTin_Export_Model_ContentModel_Default">Default</a></td><td>
Gets default content definition</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_ContentModel_IsDefault">IsDefault</a></td><td>
Gets a value indicating whether this instance is default.
 (Overrides BaseModel.IsDefault.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_ContentModel_Pattern">Pattern</a></td><td>
Gets or sets the fill pattern content.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseModel_1_Properties">Properties</a></td><td>
Gets or sets a reference to user-defined property list for this element.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr></table>&nbsp;
<a href="#contentmodel-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_ContentModel_Clone">Clone</a></td><td>
Clones this instance.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_ContentModel_Combine">Combine</a></td><td>
Combines this instance with reference parameter.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>Equals</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>Finalize</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_ContentModel_GetAlternateColor">GetAlternateColor</a></td><td>
Gets a reference to the alternate Color structure preferred for this content.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_ContentModel_GetColor">GetColor</a></td><td>
Gets a reference to the Color structure preferred for this content.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetHashCode</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_GetStaticBindingValue">GetStaticBindingValue</a></td><td>
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
<a href="#contentmodel-class">Back to Top</a>

## Remarks

Belongs to: <strong>`Style`</strong>. For more information, please see <a href="T_iTin_Export_Model_StyleModel">StyleModel</a>. 
**IEE Object Element Usage**<br />
``` XML
<Content>
  <Alignment/>
  <Number/> | <Currency/> | <Percentage/> | <Scientific/> | <Datetime/> | <Special/> | <Text/>
  <Properties/>
</Content>
```


<strong>Attributes</strong>
&nbsp;<table><tr><th>Attribute</th><th>Optional</th><th>Description</th><th>Default</th></tr><tr><td><a href="P_iTin_Export_Model_ContentModel_AlternateColor">AlternateColor</a></td><td>Yes</td><td>Alternative color preferred of content.</td><td>The default is `Transparent`</td></tr><tr><td><a href="P_iTin_Export_Model_ContentModel_Color">Color</a></td><td>Yes</td><td>Preferred content color.</td><td>The default is `Transparent`</td></tr></table>&nbsp;
<strong>Elements</strong>
&nbsp;<table><tr><th>Element</th><th>Description</th></tr><tr><td><a href="P_iTin_Export_Model_ContentModel_Alignment">Alignment</a></td><td>Reference to content distribution.</td></tr><tr><td><a href="P_iTin_Export_Model_ContentModel_DataType">DataType</a></td><td>Reference to content data type.</td></tr><tr><td><a href="P_iTin_Export_Model_ContentModel_Pattern">Pattern</a></td><td>Reference to fill pattern.</td></tr><tr><td>Properties</td><td>Reference to custom properties dictionary</td></tr></table>&nbsp;
<strong>Compatibility table with native writers.</strong>
&nbsp;<table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td>X</td><td>X</td><td>X</td><td>X</td></tr></table>&nbsp;
A `<b>X</b>` value indicates that the writer supports this element.


## See Also


#### Reference
<a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />iTin.Export.Model.BaseModel()<br />System.ICloneable<br />