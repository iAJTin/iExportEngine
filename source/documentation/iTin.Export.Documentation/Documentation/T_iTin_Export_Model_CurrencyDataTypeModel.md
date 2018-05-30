# CurrencyDataTypeModel Class
Additional header content 

A Specialization of <a href="T_iTin_Export_Model_NumericDataTypeModel">NumericDataTypeModel</a> class.<br /> Represents currency format, the currency symbol appears right next to the first digit. You can specify the number of decimal places that you want to use and how you want to display negative numbers.


## Inheritance Hierarchy
System.Object<br />&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseModel_1">iTin.Export.Model.BaseModel</a>(<a href="T_iTin_Export_Model_BaseDataTypeModel">BaseDataTypeModel</a>)<br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseDataTypeModel">iTin.Export.Model.BaseDataTypeModel</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Model_RealDataTypeModel">iTin.Export.Model.RealDataTypeModel</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Model_NumericDataTypeModel">iTin.Export.Model.NumericDataTypeModel</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;iTin.Export.Model.CurrencyDataTypeModel<br />
**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
[SerializableAttribute]
public class CurrencyDataTypeModel : NumericDataTypeModel, 
	ICloneable
```

**VB**<br />
``` VB
<SerializableAttribute>
Public Class CurrencyDataTypeModel
	Inherits NumericDataTypeModel
	Implements ICloneable
```

The CurrencyDataTypeModel type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_CurrencyDataTypeModel__ctor">CurrencyDataTypeModel</a></td><td>
Initializes a new instance of the CurrencyDataTypeModel class.</td></tr></table>&nbsp;
<a href="#currencydatatypemodel-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_RealDataTypeModel_Decimals">Decimals</a></td><td>
Gets or sets number of decimal places.
 (Inherited from <a href="T_iTin_Export_Model_RealDataTypeModel">RealDataTypeModel</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_NumericDataTypeModel_Error">Error</a></td><td>
Gets or sets a reference that contains numeric data type error settings.
 (Inherited from <a href="T_iTin_Export_Model_NumericDataTypeModel">NumericDataTypeModel</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_CurrencyDataTypeModel_IsDefault">IsDefault</a></td><td>
Gets a value indicating whether this instance is default.
 (Overrides <a href="P_iTin_Export_Model_NumericDataTypeModel_IsDefault">NumericDataTypeModel.IsDefault</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_CurrencyDataTypeModel_Locale">Locale</a></td><td>
Gets or sets preferred output culture.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_NumericDataTypeModel_Negative">Negative</a></td><td>
Gets or sets a reference that contains the negative number format.
 (Inherited from <a href="T_iTin_Export_Model_NumericDataTypeModel">NumericDataTypeModel</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseModel_1_Properties">Properties</a></td><td>
Gets or sets a reference to user-defined property list for this element.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseDataTypeModel_Type">Type</a></td><td>
Gets a value indicating data type.
 (Inherited from <a href="T_iTin_Export_Model_BaseDataTypeModel">BaseDataTypeModel</a>.)</td></tr></table>&nbsp;
<a href="#currencydatatypemodel-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_CurrencyDataTypeModel_Clone">Clone</a></td><td>
Clones this instance.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseDataTypeModel_Combine">Combine(BaseDataTypeModel)</a></td><td>
Combines this instance with reference parameter.
 (Inherited from <a href="T_iTin_Export_Model_BaseDataTypeModel">BaseDataTypeModel</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_CurrencyDataTypeModel_Combine">Combine(CurrencyDataTypeModel)</a></td><td>
Combines this instance with reference parameter.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_NumericDataTypeModel_Combine">Combine(NumericDataTypeModel)</a></td><td>
Combines this instance with reference parameter.
 (Inherited from <a href="T_iTin_Export_Model_NumericDataTypeModel">NumericDataTypeModel</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_RealDataTypeModel_Combine">Combine(RealDataTypeModel)</a></td><td>
Combines this instance with reference parameter.
 (Inherited from <a href="T_iTin_Export_Model_RealDataTypeModel">RealDataTypeModel</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>Equals</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>Finalize</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseDataTypeModel_GetDataFormat">GetDataFormat</a></td><td>
Returns data format for a data type.
 (Inherited from <a href="T_iTin_Export_Model_BaseDataTypeModel">BaseDataTypeModel</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseDataTypeModel_GetFormattedDataValue">GetFormattedDataValue</a></td><td>
Returns data format for a data type.
 (Inherited from <a href="T_iTin_Export_Model_BaseDataTypeModel">BaseDataTypeModel</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetHashCode</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_GetStaticBindingValue">GetStaticBindingValue</a></td><td>
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
<a href="#currencydatatypemodel-class">Back to Top</a>

## Remarks

Belongs to: <strong>`Content`</strong>. For more information, please see <a href="T_iTin_Export_Model_ContentModel">ContentModel</a>. 
**ITEE Object Element Usage**<br />
``` XML
<Currency ...>
  <Negative/>
  <Error/>
<Currency/>
```


<strong>Attributes</strong><table><tr><th>Attribute</th><th>Optional</th><th>Description</th></tr><tr><td><a href="P_iTin_Export_Model_RealDataTypeModel_Decimals">Decimals</a></td><td align="center">Yes</td><td>Number of decimal places. The default is `2`.</td></tr><tr><td><a href="P_iTin_Export_Model_CurrencyDataTypeModel_Locale">Locale</a></td><td align="center">Yes</td><td>Use this attribute for select preferred output culture. The default is <a href="T_iTin_Export_Model_KnownCulture">Current</a>.</td></tr></table><strong>Elements</strong>
&nbsp;<table><tr><th>Element</th><th>Description</th></tr><tr><td><a href="P_iTin_Export_Model_NumericDataTypeModel_Error">Error</a></td><td>Reference for numeric data type error settings.</td></tr><tr><td><a href="P_iTin_Export_Model_NumericDataTypeModel_Negative">Negative</a></td><td>Reference for negative number format.</td></tr></table>&nbsp;
<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td align="center">X</td><td align="center">X</td><td align="center">X</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## Examples
The following example indicate that the content should be currency type. 
**XML**<br />
``` XML
<Style Name="AccountValue">
  <Content Color="Blue">
    <Currency Decimals="1" Locale="mk">
      <Negative Color="Red" Sign="Parenthesis">
    </Currency>
  </Content>
  <Font Size="8" Color="White"/>
</Style>
```


## See Also


#### Reference
<a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />