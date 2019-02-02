# ScientificErrorModel Class
Additional header content 

A Specialization of <a href="T_iTin_Export_Model_NumericErrorModel">NumericErrorModel</a> class. Represents the error structure for scientific data type. Allows us to set a default value and an additional comment.


## Inheritance Hierarchy
System.Object<br />&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseModel_1">iTin.Export.Model.BaseModel</a>(<a href="T_iTin_Export_Model_BaseErrorModel">BaseErrorModel</a>)<br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseErrorModel">iTin.Export.Model.BaseErrorModel</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Model_NumericErrorModel">iTin.Export.Model.NumericErrorModel</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;iTin.Export.Model.ScientificErrorModel<br />
**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
[SerializableAttribute]
public class ScientificErrorModel : NumericErrorModel, 
	ICloneable
```

**VB**<br />
``` VB
<SerializableAttribute>
Public Class ScientificErrorModel
	Inherits NumericErrorModel
	Implements ICloneable
```

The ScientificErrorModel type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_ScientificErrorModel__ctor">ScientificErrorModel</a></td><td>
Initializes a new instance of the ScientificErrorModel class</td></tr></table>&nbsp;
<a href="#scientificerrormodel-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_BaseErrorModel_Comment">Comment</a></td><td>
Gets or sets a reference that contains the error comment.
 (Inherited from <a href="T_iTin_Export_Model_BaseErrorModel">BaseErrorModel</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_NumericErrorModel_IsDefault">IsDefault</a></td><td>
Gets a value indicating whether this instance is default.
 (Inherited from <a href="T_iTin_Export_Model_NumericErrorModel">NumericErrorModel</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseModel_1_Properties">Properties</a></td><td>
Gets or sets a reference to user-defined property list for this element.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_NumericErrorModel_Value">Value</a></td><td>
Gets or sets preferred default value when occurs an error.
 (Inherited from <a href="T_iTin_Export_Model_NumericErrorModel">NumericErrorModel</a>.)</td></tr></table>&nbsp;
<a href="#scientificerrormodel-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_ScientificErrorModel_Clone">Clone</a></td><td>
Clones this instance.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseErrorModel_Combine">Combine(BaseErrorModel)</a></td><td>
Combines this instance with reference parameter.
 (Inherited from <a href="T_iTin_Export_Model_BaseErrorModel">BaseErrorModel</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_NumericErrorModel_Combine">Combine(NumericErrorModel)</a></td><td>
Combines this instance with reference parameter.
 (Inherited from <a href="T_iTin_Export_Model_NumericErrorModel">NumericErrorModel</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>Equals</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>Finalize</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetHashCode</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_GetStaticBindingValue">GetStaticBindingValue</a></td><td>
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
<a href="#scientificerrormodel-class">Back to Top</a>

## Remarks

Belongs to: <strong>`Scientific`</strong>. For more information, please see <a href="T_iTin_Export_Model_ScientificDataTypeModel">ScientificDataTypeModel</a>. 
**ITEE Object Element Usage**<br />
``` XML
<Error>
  <Comment/>
</Error>
```


<strong>Attributes</strong><table><tr><th>Attribute</th><th>Optional</th><th>Description</th></tr><tr><td><a href="P_iTin_Export_Model_NumericErrorModel_Value">Value</a></td><td align="center">Yes</td><td>Preferred default value when occurs an error. The default is `0.0`.</td></tr></table><strong>Elements</strong>
&nbsp;<table><tr><th>Element</th><th>Description</th></tr><tr><td><a href="P_iTin_Export_Model_BaseErrorModel_Comment">Comment</a></td><td>Reference for error comment. Includes comment text, format, including font face, size, and style attributes.</td></tr></table>&nbsp;
<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br />[!:iTin.Export.Writers.Native.CsvWriter]</th><th>Tab-Separated Values<br />[!:iTin.Export.Writers.Native.TsvWriter]</th><th>SQL Script<br />[!:iTin.Export.Writers.Native.SqlScriptWriter]</th><th>XML Spreadsheet 2003<br />[!:iTin.Export.Writers.Native.Spreadsheet2003TabularWriter]</th></tr><tr><td align="center">X</td><td align="center">X</td><td align="center">X</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## Examples
In the following example shows how create a new style with a scientific data type. 
**XML**<br />
``` XML
<Style Name="Scientific">
  <Content Color="White">
    <Scientific Decimals="3">
      <Error Value="-9999">
        <Comment Show="Yes">
          <Text>Wrong value: </Text>
        </Comment>
      </Error>           
    </Scientific>
  </Content>
</Style>
```


## See Also


#### Reference
<a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />