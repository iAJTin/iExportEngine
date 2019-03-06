# BaseDataTypeModel Class
Additional header content 

Base class for different data types supported by <strong>`iTin Export Engine`</strong>.<br /> Which acts as the base class for different data types.


## Inheritance Hierarchy
System.Object<br />&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseModel_1">iTin.Export.Model.BaseModel</a>(BaseDataTypeModel)<br />&nbsp;&nbsp;&nbsp;&nbsp;iTin.Export.Model.BaseDataTypeModel<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Model_DatetimeDataTypeModel">iTin.Export.Model.DatetimeDataTypeModel</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Model_RealDataTypeModel">iTin.Export.Model.RealDataTypeModel</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Model_TextDataTypeModel">iTin.Export.Model.TextDataTypeModel</a><br />
**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
[SerializableAttribute]
public abstract class BaseDataTypeModel : BaseModel<BaseDataTypeModel>, 
	ICloneable
```

**VB**<br />
``` VB
<SerializableAttribute>
Public MustInherit Class BaseDataTypeModel
	Inherits BaseModel(Of BaseDataTypeModel)
	Implements ICloneable
```

The BaseDataTypeModel type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_Model_BaseDataTypeModel__ctor">BaseDataTypeModel</a></td><td>
Initializes a new instance of the BaseDataTypeModel class</td></tr></table>&nbsp;
<a href="#basedatatypemodel-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseModel_1_Properties">Properties</a></td><td>
Gets or sets a reference to user-defined property list for this element.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseDataTypeModel_Type">Type</a></td><td>
Gets a value indicating data type.</td></tr></table>&nbsp;
<a href="#basedatatypemodel-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseDataTypeModel_Clone">Clone</a></td><td>
Clones this instance.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseDataTypeModel_Combine">Combine</a></td><td>
Combines this instance with reference parameter.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>Equals</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>Finalize</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseDataTypeModel_GetDataFormat">GetDataFormat</a></td><td>
Returns data format for a data type.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseDataTypeModel_GetFormattedDataValue">GetFormattedDataValue</a></td><td>
Returns data format for a data type.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetHashCode</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_GetStaticBindingValue">GetStaticBindingValue</a></td><td>
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
<a href="#basedatatypemodel-class">Back to Top</a>

## Remarks

The following table shows different data types.
&nbsp;<table><tr><th>Class</th><th>Description</th></tr><tr><td><a href="T_iTin_Export_Model_CurrencyDataTypeModel">CurrencyDataTypeModel</a></td><td>Represents currency data type. The currency symbol appears right next to the first digit. You can specify the number of decimal places that you want to use and how you want to display negative numbers.</td></tr><tr><td><a href="T_iTin_Export_Model_DatetimeDataTypeModel">DatetimeDataTypeModel</a></td><td>Represents date time data field. Displays data field as datetime format. You can specify the output culture.</td></tr><tr><td><a href="T_iTin_Export_Model_NumberDataTypeModel">NumberDataTypeModel</a></td><td>Represents numeric data type. You can specify the number of decimal places that you want to use, whether you want to use a thousands separator, and how you want to display negative numbers.</td></tr><tr><td><a href="T_iTin_Export_Model_PercentageDataTypeModel">PercentageDataTypeModel</a></td><td>Represents percentage data type. Displays the result with a percent sign (%). You can specify the number of decimal places to use.</td></tr><tr><td><a href="T_iTin_Export_Model_ScientificDataTypeModel">ScientificDataTypeModel</a></td><td>Represents scientific data type. Displays a number in exponential notation, which replaces part of the number with E + n, where E (exponent) multiplies the preceding number by 10 to n. You can specify the number of decimal places you want to use.</td></tr><tr><td>SpecialDataTypeModel</td><td>Represents special data type. Displays a number as a short date or as a long date.</td></tr><tr><td><a href="T_iTin_Export_Model_TextDataTypeModel">TextDataTypeModel</a></td><td>Represents text data type. Treats the content as text and displays the content exactly as written, even when numbers are typed.</td></tr></table>

## See Also


#### Reference
<a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />