# ExporterModel Class
Additional header content 

Defines the type of exporter to use and their behavior.


## Inheritance Hierarchy
System.Object<br />&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseModel_1">iTin.Export.Model.BaseModel</a>(ExporterModel)<br />&nbsp;&nbsp;&nbsp;&nbsp;iTin.Export.Model.ExporterModel<br />
**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
[SerializableAttribute]
public class ExporterModel : BaseModel<ExporterModel>
```

**VB**<br />
``` VB
<SerializableAttribute>
Public Class ExporterModel
	Inherits BaseModel(Of ExporterModel)
```

The ExporterModel type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_ExporterModel__ctor">ExporterModel</a></td><td>
Initializes a new instance of the ExporterModel class</td></tr></table>&nbsp;
<a href="#exportermodel-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_ExporterModel_Behaviors">Behaviors</a></td><td>
Gets or sets collection of writer behaviors.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_ExporterModel_Current">Current</a></td><td>
Gets or sets a reference to the exporter to be used for export.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_ExporterModel_ExporterType">ExporterType</a></td><td>
Gets a value indicating data field type.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_ExporterModel_IsDefault">IsDefault</a></td><td> (Overrides BaseModel.IsDefault.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseModel_1_Properties">Properties</a></td><td>
Gets or sets a reference to user-defined property list for this element.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr></table>&nbsp;
<a href="#exportermodel-class">Back to Top</a>

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
<a href="#exportermodel-class">Back to Top</a>

## Remarks

Belongs to: <strong>`Table`</strong>. For more information, please see <a href="T_iTin_Export_Model_TableModel">TableModel</a>.<br />
**ITEE Object Element Usage**<br />
``` XML
<Exporter>
  <Template/> | <Writer/> |  <Xslt/>
  <Behaviors/>
</Exporter>
```


Elements
&nbsp;<table><tr><th>Element</th><th>Description</th></tr><tr><td><a href="P_iTin_Export_Model_ExporterModel_Current">Current</a></td><td>The type of exporter you will use the engine.</td></tr><tr><td><a href="P_iTin_Export_Model_ExporterModel_Behaviors">Behaviors</a></td><td>Collection of writer behaviors. Each element is a writer behavior, it execute after export.</td></tr></table>&nbsp;
The following example defines an exporter of type <a href="T_iTin_Export_Model_KnownExporter">Writer</a> that contains two behaviors.<br /> The `Download` behavior indicates to engine that begin download to the file if we are in a web environment.<br /> The `TransformFile` behavior indicates to the engine that we want to save the transform xslt file and the transformed file (in this case the excel sheet).

**XML**<br />
``` XML
<?xml version="1.0" encoding="utf-8"?>

<Exports xmlns="http://schemas.iTin.com/export/engine/2013/configuration">
  <Export Name="Test" Current="Yes">
    <Description><Sample Export</Description>
    <Table Name="R740D01"
              Location="1 1"
              AutoFilter="Yes"
              AutoFitColumns="Yes"              
              Alias="Table alias">
      <Exporter>
        <Writer Name="Spreadsheet2003TabularWriter"/>
        <Behaviors>
          <Download/>
          <TransformFile Save="Yes"/>
        </Behaviors>
      </Exporter>
       ...
    </Table>
     ...
  </Export>
</Exports>
```


## See Also


#### Reference
<a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />