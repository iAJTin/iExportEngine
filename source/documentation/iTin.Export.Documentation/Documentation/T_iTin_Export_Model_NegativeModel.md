# NegativeModel Class
Additional header content 

Represents a negative number format. Contains the definition of negative number in a numeric data type.


## Inheritance Hierarchy
System.Object<br />&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseModel_1">iTin.Export.Model.BaseModel</a>(NegativeModel)<br />&nbsp;&nbsp;&nbsp;&nbsp;iTin.Export.Model.NegativeModel<br />
**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
[SerializableAttribute]
public class NegativeModel : BaseModel<NegativeModel>, 
	ICloneable
```

**VB**<br />
``` VB
<SerializableAttribute>
Public Class NegativeModel
	Inherits BaseModel(Of NegativeModel)
	Implements ICloneable
```

The NegativeModel type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_NegativeModel__ctor">NegativeModel</a></td><td>
Initializes a new instance of the NegativeModel class.</td></tr></table>&nbsp;
<a href="#negativemodel-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_NegativeModel_Color">Color</a></td><td>
Gets or sets preferred color for display a negative number.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_NegativeModel_IsDefault">IsDefault</a></td><td>
Gets a value indicating whether this instance is default.
 (Overrides BaseModel.IsDefault.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseModel_1_Properties">Properties</a></td><td>
Gets or sets a reference to user-defined property list for this element.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_NegativeModel_Sign">Sign</a></td><td>
Gets or sets visual format of negative value.</td></tr></table>&nbsp;
<a href="#negativemodel-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_NegativeModel_Clone">Clone</a></td><td>
Clones this instance.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_NegativeModel_Combine">Combine</a></td><td>
Combines this instance with reference parameter.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>Equals</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>Finalize</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_NegativeModel_GetColor">GetColor</a></td><td>
Gets a reference to the Color structure preferred for this negative format.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetHashCode</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_GetStaticBindingValue">GetStaticBindingValue</a></td><td>
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
<a href="#negativemodel-class">Back to Top</a>

## Remarks


**ITEE Object Element Usage**<br />
``` XML
<Negative .../>
```


<strong>Attributes</strong><table><tr><th>Attribute</th><th>Optional</th><th>Description</th></tr><tr><td><a href="P_iTin_Export_Model_NegativeModel_Color">Color</a></td><td align="center">Yes</td><td>Preferred color for display a negative number. The default is <a href="T_iTin_Export_Model_KnownBasicColor">Black</a>.</td></tr><tr><td><a href="P_iTin_Export_Model_NegativeModel_Sign">Sign</a></td><td align="center">Yes</td><td>Visual format of negative value. The default is <a href="T_iTin_Export_Model_KnownNegativeSign">Standard</a>.</td></tr></table><strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br /><a href="T_iTin_Export_Writers_CsvWriter">CsvWriter</a></th><th>Tab-Separated Values<br /><a href="T_iTin_Export_Writers_TsvWriter">TsvWriter</a></th><th>SQL Script<br /><a href="T_iTin_Export_Writers_SqlScriptWriter">SqlScriptWriter</a></th><th>XML Spreadsheet 2003<br /><a href="T_iTin_Export_Writers_Spreadsheet2003TabularWriter">Spreadsheet2003TabularWriter</a></th></tr><tr><td align="center">X</td><td align="center">X</td><td align="center">X</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## Examples
In the following example shows how create a new style. 
**XML**<br />
``` XML
<Style Name="TopAggregate">
  <Content Color="#C9C9C9">
    <Alignment Horizontal="Center"/>
    <Number Decimals="0" Separator="Yes">
      <Negative Color="Yellow" Sign="Brackets"/>
    </Number>
  </Content>
  <Font Name="Segoe UI" Size="12" Color="Navy" Bold="Yes"/>
</Style>
```

**C#**<br />
``` C#
StyleModel style = new StyleModel
                       {
                           Name = "TopAggregate",
                           Content = new ContentModel
                                         {
                                             Color = "#C9C9C9",
                                             Alignment = new ContentAlignmentModel
                                                             {
                                                                 Horizontal = KnownHorizontalAlignment.Center
                                                             },
                                             DataType = new NumberDataTypeModel
                                                            {
                                                                Decimals = 0,
                                                                Separator = YesNo.Yes,
                                                                Negative = new NegativeModel
                                                                               {
                                                                                   Color = KnownBasicColor.Yellow,
                                                                                   Sign = KnownNegativeSign.Brackets
                                                                               }
                                                            }
                                         }, 
                           Font = new FontModel
                                      {
                                          Color = "Navy",
                                          Bold = YesNo.Yes,
                                          Size = 12
                                      }
                       };
```


## See Also


#### Reference
<a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />