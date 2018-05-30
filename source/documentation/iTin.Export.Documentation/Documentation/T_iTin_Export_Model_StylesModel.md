# StylesModel Class
Additional header content 

Root element of <strong>iTin Export Engine</strong> configuration file that contains a list with export definition.


## Inheritance Hierarchy
System.Object<br />&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseModel_1">iTin.Export.Model.BaseModel</a>(<a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection</a>(<a href="T_iTin_Export_Model_StyleModel">StyleModel</a>, <a href="T_iTin_Export_Model_GlobalResourcesModel">GlobalResourcesModel</a>))<br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">iTin.Export.Model.BaseSimpleModelCollection</a>(<a href="T_iTin_Export_Model_StyleModel">StyleModel</a>, <a href="T_iTin_Export_Model_GlobalResourcesModel">GlobalResourcesModel</a>)<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseComplexModelCollection_3">iTin.Export.Model.BaseComplexModelCollection</a>(<a href="T_iTin_Export_Model_StyleModel">StyleModel</a>, <a href="T_iTin_Export_Model_GlobalResourcesModel">GlobalResourcesModel</a>, String)<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;iTin.Export.Model.StylesModel<br />
**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
[SerializableAttribute]
public class StylesModel : BaseComplexModelCollection<StyleModel, GlobalResourcesModel, string>, 
	ICloneable
```

**VB**<br />
``` VB
<SerializableAttribute>
Public Class StylesModel
	Inherits BaseComplexModelCollection(Of StyleModel, GlobalResourcesModel, String)
	Implements ICloneable
```

The StylesModel type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_StylesModel__ctor">StylesModel</a></td><td>
Initializes a new instance of the StylesModel class.</td></tr></table>&nbsp;
<a href="#stylesmodel-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseSimpleModelCollection_2_Count">Count</a></td><td>
Gets the number of elements contained in the <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.
 (Inherited from <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseSimpleModelCollection_2_IsDefault">IsDefault</a></td><td>
When overridden in a derived class, gets a value indicating whether this instance contains the default.
 (Inherited from <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseSimpleModelCollection_2_IsReadOnly">IsReadOnly</a></td><td>
Gets a value indicating whether the <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a> is read-only.
 (Inherited from <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseComplexModelCollection_3_Item">Item(TSearch)</a></td><td>
Gets or sets the element specified by *value*.
 (Inherited from <a href="T_iTin_Export_Model_BaseComplexModelCollection_3">BaseComplexModelCollection(TItem, TParent, TSearch)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseSimpleModelCollection_2_Item">Item(Int32)</a></td><td>
Gets or sets the element at the specified index.
 (Inherited from <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.)</td></tr><tr><td>![Protected property](media/protproperty.gif "Protected property")</td><td><a href="P_iTin_Export_Model_BaseSimpleModelCollection_2_List">List</a></td><td>
Gets a reference to the inner list.
 (Inherited from <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseSimpleModelCollection_2_Parent">Parent</a></td><td>
Gets a reference to the owner of the collection
 (Inherited from <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseModel_1_Properties">Properties</a></td><td>
Gets or sets a reference to user-defined property list for this element.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr></table>&nbsp;
<a href="#stylesmodel-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseSimpleModelCollection_2_Add">Add</a></td><td>
Adds an object to the end of the <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.
 (Inherited from <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseSimpleModelCollection_2_Clear">Clear</a></td><td>
Removes all elements from the <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.
 (Inherited from <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_StylesModel_Clone">Clone</a></td><td>
Clones this instance.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseComplexModelCollection_3_Contains">Contains(TSearch)</a></td><td>
Determines whether an element is in the <a href="T_iTin_Export_Model_BaseComplexModelCollection_3">BaseComplexModelCollection(TItem, TParent, TSearch)</a>.
 (Inherited from <a href="T_iTin_Export_Model_BaseComplexModelCollection_3">BaseComplexModelCollection(TItem, TParent, TSearch)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseSimpleModelCollection_2_Contains">Contains(TItem)</a></td><td>
Determines whether an element is in the <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.
 (Inherited from <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseSimpleModelCollection_2_CopyTo">CopyTo</a></td><td>
Copies the entire <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a> to a compatible one-dimensional array, starting at the specified index of the target array.
 (Inherited from <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>Equals</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>Finalize</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseSimpleModelCollection_2_Find">Find</a></td><td>
Searches for an element that matches the conditions defined by the specified predicate, and returns the first occurrence within the entire <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.
 (Inherited from <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_StylesModel_GetBy">GetBy</a></td><td>

 (Overrides <a href="M_iTin_Export_Model_BaseComplexModelCollection_3_GetBy">BaseComplexModelCollection(TItem, TParent, TSearch).GetBy(TSearch)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseSimpleModelCollection_2_GetEnumerator">GetEnumerator</a></td><td>
Returns an enumerator that iterates through the <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.
 (Inherited from <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetHashCode</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_GetStaticBindingValue">GetStaticBindingValue</a></td><td>
Gets the static binding value by reflection.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetType</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseSimpleModelCollection_2_IndexOf">IndexOf</a></td><td>
Searches for the specified object and returns the zero-based index of the first occurrence within the entire <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.
 (Inherited from <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseSimpleModelCollection_2_Insert">Insert</a></td><td>
Inserts an item to the <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a> at the specified index.
 (Inherited from <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>MemberwiseClone</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseSimpleModelCollection_2_Remove">Remove</a></td><td>
Removes the first occurrence of a specific object from the <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.
 (Inherited from <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseSimpleModelCollection_2_RemoveAt">RemoveAt</a></td><td>
Removes the element at the specified index of the <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.
 (Inherited from <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_SaveToFile">SaveToFile(String)</a></td><td>
Saves to file.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_SaveToFile_1">SaveToFile(String, Exception)</a></td><td>
Serializes current BaseModel object into file
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_Serialize">Serialize</a></td><td>
Serializes current BaseModel object into an Xml document.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_Model_StylesModel_SetOwner">SetOwner</a></td><td>

 (Overrides <a href="M_iTin_Export_Model_BaseSimpleModelCollection_2_SetOwner">BaseSimpleModelCollection(TItem, TParent).SetOwner(TItem)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_ToString">ToString</a></td><td>
Returns a string that represents the current object.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr></table>&nbsp;
<a href="#stylesmodel-class">Back to Top</a>

## Remarks

Represents <strong>`TEE` root</strong> element of a configuration file. 
**TEE Object Element Usage**<br />
``` XML
<?xml version="1.0" encoding="utf-8"?>

<Exports xmlns="http://schemas.iTin.com/export/engine/2013/configuration">
<Export/>
<Export/>
...
</Exports>
```


<strong>Attributes</strong>
&nbsp;<table><tr><th>Attribute</th><th>Description</th></tr><tr><td>xmlns</td><td>Namespace for the `iTin Export Engine (TEE)` configuration file.<br /></td></tr></table>&nbsp;
&nbsp;<table><tr><th>![Note](media/AlertNote.png) Note</th></tr><tr><td>The xsd schema file that will be used to validate the document are located in the location `VisualStudioInstallationFolder\Xml\Schemas`, also gives us the intellisense to write quickly the document.</td></tr></table>&nbsp;
<strong>Elements</strong>
&nbsp;<table><tr><th>Element</th><th>Description</th></tr><tr><td><a href="P_iTin_Export_Model_ExportsModel_Items">Items</a></td><td>Collection of export configurations. Each element is composed of a description and a data table definition.</td></tr></table>

## Examples
The following example shows a full configuration file. 
**XML**<br />
``` XML
<?xml version="1.0" encoding="utf-8"?>

<Exports xmlns="http://schemas.iTin.com/export/engine/2013/configuration">
<Export Name="iTin" Current="Yes">
<Description>Sample 1</Description>
<Table Name="SCR3SFL"
AutoFilter="Yes"
AutoFitColumns="Yes"
Alias="iTin Sample 1">
<Exporter>
<Writer Name="Spreadsheet2003TabularWriter"/>
<Behaviors>
<Download/>
<TransformFile Save="Yes"/>
</Behaviors>
</Exporter>
<Output>
<File>ExampleI</File>
<Path>~\Samples\Output\Writers\Demo\XML Spreadsheet</Path>
</Output>
<Styles>
<Style Name="Header">
<Content Color="#D9E1F2">
<Alignment Horizontal="Left"/>
<Text/>
</Content>
<Font Name="Calibri" Size="11" Bold="Yes"/>
</Style>
<Style Name="PeriodValue">
<Content Color="#B4C6E7">
<Alignment Horizontal="Right"/>
<DateTime Format="Year-Month"/>
</Content>
<Font Name="Calibri" Size="11"/>
</Style>
<Style Name="EuropeValue">
<Content Color="#B4C6E7">
<Alignment Horizontal="Right"/>
<Number Decimals="1" Separator="Yes"/>
</Content>
<Font Name="Calibri" Size="11"/>
</Style>
<Style Name="AfricaValue">
<Content Color="#B4C6E7">
<Alignment Horizontal="Right"/>
<Number Decimals="1" Separator="Yes"/>
</Content>
<Font Name="Calibri" Size="11"/>
</Style>
<Style Name="AsiaValue">
<Content Color="#B4C6E7">
<Alignment Horizontal="Right"/>
<Number Decimals="1" Separator="Yes"/>
</Content>
<Font Name="Calibri" Size="11"/>
</Style>
<Style Name="NorthAmericaValue">
<Content Color="#B4C6E7">
<Alignment Horizontal="Right"/>
<Number Decimals="1" Separator="Yes"/>
</Content>
<Font Name="Calibri" Size="11"/>
</Style>
<Style Name="SouthAmericaValue">
<Content Color="#B4C6E7">
<Alignment Horizontal="Right"/>
<Number Decimals="1" Separator="Yes"/>
</Content>
<Font Name="Calibri" Size="11"/>
</Style>
<Style Name="AustraliaValue">
<Content Color="#B4C6E7">
<Alignment Horizontal="Right"/>
<Number Decimals="1" Separator="Yes"/>
</Content>
<Font Name="Calibri" Size="11"/>
</Style>
</Styles>
<Fields>
<Field Name="PERIOD" Alias="Period">
<Header Style="Header"/>
<Value Style="PeriodValue"/>
</Field>
<Field Name="EUROPE" Alias="Europe">
<Header Style="Header"/>
<Value Style="EuropeValue"/>
</Field>
<Field Name="AFRICA" Alias="Africa">
<Header Style="Header"/>
<Value Style="AfricaValue"/>
</Field>
<Field Name="ASIA" Alias="Asia">
<Header Style="Header"/>
<Value Style="AsiaValue"/>
</Field>
<Field Name="NORTHAMERICA" Alias="North America">
<Header Style="Header"/>
<Value Style="NorthAmericaValue"/>
</Field>
<Field Name="SOUTHAMERICA" Alias="South America">
<Header Style="Header"/>
<Value Style="SouthAmericaValue"/>
</Field>
<Field Name="AUSTRALIA" Alias="Australia">
<Header Style="Header"/>
<Value Style="AustraliaValue"/>
</Field>
</Fields>
</Table>
</Export>
</Exports>
```


## See Also


#### Reference
<a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />