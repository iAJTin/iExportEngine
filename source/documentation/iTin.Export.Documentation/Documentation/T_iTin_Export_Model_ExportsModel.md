# ExportsModel Class
Additional header content 

Root element of <strong>iTin Export Engine</strong> configuration file that contains a list with export definition.


## Inheritance Hierarchy
System.Object<br />&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseModel_1">iTin.Export.Model.BaseModel</a>(ExportsModel)<br />&nbsp;&nbsp;&nbsp;&nbsp;iTin.Export.Model.ExportsModel<br />
**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
[SerializableAttribute]
public class ExportsModel : BaseModel<ExportsModel>
```

**VB**<br />
``` VB
<SerializableAttribute>
Public Class ExportsModel
	Inherits BaseModel(Of ExportsModel)
```

The ExportsModel type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_ExportsModel__ctor">ExportsModel</a></td><td>
Initializes a new instance of the ExportsModel class</td></tr></table>&nbsp;
<a href="#exportsmodel-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_ExportsModel_Items">Items</a></td><td>
Gets or sets collection of export configurations.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseModel_1_Properties">Properties</a></td><td>
Gets or sets a reference to user-defined property list for this element.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_ExportsModel_References">References</a></td><td>
Gets a reference to the assembly references.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_ExportsModel_Resources">Resources</a></td><td>
Gets or sets global resources.</td></tr></table>&nbsp;
<a href="#exportsmodel-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>Equals</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>Finalize</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_iTin_Export_Model_ExportsModel_GetDefaultPropertyValue__1">GetDefaultPropertyValue(T)</a></td><td>
Gets the default value for specified property.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetHashCode</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_iTin_Export_Model_ExportsModel_GetRelativeFilePathParsed">GetRelativeFilePathParsed</a></td><td>
Gets a valid full path from a relative path.</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_GetStaticBindingValue">GetStaticBindingValue</a></td><td>
Gets the static binding value by reflection.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetType</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_iTin_Export_Model_ExportsModel_GetXmlEnumAttributeFromItem">GetXmlEnumAttributeFromItem</a></td><td>
Gets a string containing the attribute value an element XmlEnumAttribute.</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>MemberwiseClone</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_SaveToFile">SaveToFile(String)</a></td><td>
Saves to file.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_SaveToFile_1">SaveToFile(String, Exception)</a></td><td>
Serializes current BaseModel object into file
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_Serialize">Serialize</a></td><td>
Serializes current BaseModel object into an Xml document.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_ExportsModel_ToString">ToString</a></td><td>
Returns a string that represents the current data type.
 (Overrides <a href="M_iTin_Export_Model_BaseModel_1_ToString">BaseModel(T).ToString()</a>.)</td></tr></table>&nbsp;
<a href="#exportsmodel-class">Back to Top</a>

## Remarks

Represents <strong>ITEE root</strong> element of a configuration file. 
**IEE Object Element Usage**<br />
``` XML
<?xml version="1.0" encoding="utf-8">
<Exports xmlns="http://schemas.iTin.com/export/engine/2013/configuration">
  <Export/>
  <Export/>
  ...
</Exports>
```


<strong>Attributes</strong>
&nbsp;<table><tr><th>Attribute</th><th>Description</th></tr><tr><td>xmlns</td><td>Namespace for the `iTin Export Engine (ITEE)` configuration file.<br /></td></tr></table>&nbsp;
&nbsp;<table><tr><th>![Note](media/AlertNote.png) Note</th></tr><tr><td>The xsd schema file that will be used to validate the document are located in the location <strong>VisualStudioInstallationFolder\Xml\Schemas</strong>, also gives us the intellisense to write quickly the document.</td></tr></table>&nbsp;
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
    <Table Name = "SCR3SFL"
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
        <Style Name= "PeriodValue">
          <Content Color="#B4C6E7">
            <Alignment Horizontal="Right"/>
            <DateTime Format= "Year-Month"/>
          </Content>
          <Font Name="Calibri" Size="11"/>
        </Style>
        <Style Name="EuropeValue">
          <Content Color="#B4C6E7">
            <Alignment Horizontal="Right"/>
            <Number Decimals="1" Separator="Yes"/>
          </Content>
          <Font Name="Calibri" Size="11"/>
        </Style >
        <Style Name="AfricaValue">
          <Content Color="#B4C6E7">
            <Alignment Horizontal= "Right"/>
            <Number Decimals="1" Separator="Yes"/>
          </Content >
          <Font Name="Calibri" Size="11"/>
        </Style>
        <Style Name= "AsiaValue">
          <Content Color= "#B4C6E7">
            <Alignment Horizontal="Right"/>
            <Number Decimals="1" Separator="Yes"/>
          </Content>
          <Font Name="Calibri" Size="11"/>
        </Style >
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
        <Field Name= "EUROPE" Alias="Europe">
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