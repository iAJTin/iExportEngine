# PieceModel Class
Additional header content 

Represents a new field composed of a field name and initial position and final position into the reference field.


## Inheritance Hierarchy
System.Object<br />&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseModel_1">iTin.Export.Model.BaseModel</a>(PieceModel)<br />&nbsp;&nbsp;&nbsp;&nbsp;iTin.Export.Model.PieceModel<br />
**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
[SerializableAttribute]
public class PieceModel : BaseModel<PieceModel>
```

**VB**<br />
``` VB
<SerializableAttribute>
Public Class PieceModel
	Inherits BaseModel(Of PieceModel)
```

The PieceModel type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_PieceModel__ctor">PieceModel</a></td><td>
Initializes a new instance of the PieceModel class.</td></tr></table>&nbsp;
<a href="#piecemodel-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_PieceModel_From">From</a></td><td>
Gets or sets the initial character of the piece into field reference.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_PieceModel_IsDefault">IsDefault</a></td><td>
Gets a value indicating whether this instance is default.
 (Overrides BaseModel.IsDefault.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_PieceModel_Lenght">Lenght</a></td><td>
Gets or sets the length in characters of the piece.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_PieceModel_Name">Name</a></td><td>
Gets or sets the name of the piece.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseModel_1_Properties">Properties</a></td><td>
Gets or sets a reference to user-defined property list for this element.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_PieceModel_Trim">Trim</a></td><td>
Gets or sets a value indicating whether to trim the blanks in this piece.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_iTin_Export_Model_PieceModel_TrimMode">TrimMode</a></td><td>
Gets or sets a value that determines trim mode for strings.</td></tr></table>&nbsp;
<a href="#piecemodel-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>Equals</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>Finalize</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetHashCode</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_GetStaticBindingValue">GetStaticBindingValue</a></td><td>
Gets the static binding value by reflection.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetType</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_PieceModel_GetValue">GetValue</a></td><td>
Returns the value containing this piece.</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>MemberwiseClone</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_SaveToFile">SaveToFile(String)</a></td><td>
Saves to file.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_SaveToFile_1">SaveToFile(String, Exception)</a></td><td>
Serializes current BaseModel object into file
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_Serialize">Serialize</a></td><td>
Serializes current BaseModel object into an Xml document.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_PieceModel_SetOwner">SetOwner</a></td><td>
Sets the element that owns this <a href="T_iTin_Export_Model_PiecesModel">PiecesModel</a>.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_PieceModel_ToString">ToString</a></td><td>
Returns a string that represents the current object.
 (Overrides <a href="M_iTin_Export_Model_BaseModel_1_ToString">BaseModel(T).ToString()</a>.)</td></tr></table>&nbsp;
<a href="#piecemodel-class">Back to Top</a>

## Remarks

Belongs to: <strong>`Pieces`</strong>. For more information, please see <a href="T_iTin_Export_Model_PiecesModel">PiecesModel</a>. 
**ITEE Object Element Usage**<br />
``` XML
<Piece .../>
```


<strong>Attributes</strong><table><tr><th>Attribute</th><th>Optional</th><th>Description</th></tr><tr><td><a href="P_iTin_Export_Model_PieceModel_Name">Name</a></td><td align="center">No</td><td>Name of the piece.</td></tr><tr><td><a href="P_iTin_Export_Model_PieceModel_From">From</a></td><td align="center">No</td><td>Initial character of the piece into field reference.</td></tr><tr><td><a href="P_iTin_Export_Model_PieceModel_Lenght">Lenght</a></td><td align="center">No</td><td>Length in characters of the piece.</td></tr><tr><td><a href="P_iTin_Export_Model_PieceModel_Trim">Trim</a></td><td align="center">Yes</td><td>Determines whether to apply string trim mode. The default <a href="T_iTin_Export_Model_YesNo">No</a>.</td></tr><tr><td><a href="P_iTin_Export_Model_PieceModel_TrimMode">TrimMode</a></td><td align="center">Yes</td><td>Use this attribute to specify trim mode for strings. The default is <a href="T_iTin_Export_Model_KnownTrimMode">All</a>.</td></tr></table><strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td align="center">X</td><td align="center">X</td><td align="center">X</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## See Also


#### Reference
<a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />