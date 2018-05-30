# FieldsModel Class
Additional header content 

Collection of data fields. Each element defines a data field.


## Inheritance Hierarchy
System.Object<br />&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseModel_1">iTin.Export.Model.BaseModel</a>(<a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection</a>(<a href="T_iTin_Export_Model_BaseDataFieldModel">BaseDataFieldModel</a>, <a href="T_iTin_Export_Model_TableModel">TableModel</a>))<br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">iTin.Export.Model.BaseSimpleModelCollection</a>(<a href="T_iTin_Export_Model_BaseDataFieldModel">BaseDataFieldModel</a>, <a href="T_iTin_Export_Model_TableModel">TableModel</a>)<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseComplexModelCollection_3">iTin.Export.Model.BaseComplexModelCollection</a>(<a href="T_iTin_Export_Model_BaseDataFieldModel">BaseDataFieldModel</a>, <a href="T_iTin_Export_Model_TableModel">TableModel</a>, String)<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;iTin.Export.Model.FieldsModel<br />
**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
[SerializableAttribute]
public class FieldsModel : BaseComplexModelCollection<BaseDataFieldModel, TableModel, string>
```

**VB**<br />
``` VB
<SerializableAttribute>
Public Class FieldsModel
	Inherits BaseComplexModelCollection(Of BaseDataFieldModel, TableModel, String)
```

The FieldsModel type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_FieldsModel__ctor">FieldsModel</a></td><td>
Initializes a new instance of the FieldsModel class.</td></tr></table>&nbsp;
<a href="#fieldsmodel-class">Back to Top</a>

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
<a href="#fieldsmodel-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseSimpleModelCollection_2_Add">Add</a></td><td>
Adds an object to the end of the <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.
 (Inherited from <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseSimpleModelCollection_2_Clear">Clear</a></td><td>
Removes all elements from the <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.
 (Inherited from <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseComplexModelCollection_3_Contains">Contains(TSearch)</a></td><td>
Determines whether an element is in the <a href="T_iTin_Export_Model_BaseComplexModelCollection_3">BaseComplexModelCollection(TItem, TParent, TSearch)</a>.
 (Inherited from <a href="T_iTin_Export_Model_BaseComplexModelCollection_3">BaseComplexModelCollection(TItem, TParent, TSearch)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseSimpleModelCollection_2_Contains">Contains(TItem)</a></td><td>
Determines whether an element is in the <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.
 (Inherited from <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseSimpleModelCollection_2_CopyTo">CopyTo</a></td><td>
Copies the entire <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a> to a compatible one-dimensional array, starting at the specified index of the target array.
 (Inherited from <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>Equals</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>Finalize</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseSimpleModelCollection_2_Find">Find</a></td><td>
Searches for an element that matches the conditions defined by the specified predicate, and returns the first occurrence within the entire <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.
 (Inherited from <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_FieldsModel_GetBy">GetBy</a></td><td>
Returns specified field by identifier.
 (Overrides <a href="M_iTin_Export_Model_BaseComplexModelCollection_3_GetBy">BaseComplexModelCollection(TItem, TParent, TSearch).GetBy(TSearch)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseSimpleModelCollection_2_GetEnumerator">GetEnumerator</a></td><td>
Returns an enumerator that iterates through the <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.
 (Inherited from <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetHashCode</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_FieldsModel_GetRange">GetRange(KnownAggregateLocation)</a></td><td>
Gets an enumerator to a list of fields that meet the test of being added at the indicated position and this is visible.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_FieldsModel_GetRange_1">GetRange(KnownFieldType)</a></td><td>
Returns an enumerator to a field list containing only those who meet the condition of type.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_FieldsModel_GetRange_2">GetRange(YesNo)</a></td><td>
Gets an enumerator to a list of fields that has visible headers.</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_GetStaticBindingValue">GetStaticBindingValue</a></td><td>
Gets the static binding value by reflection.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetType</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_FieldsModel_HasVisibleAggregatesByLocation">HasVisibleAggregatesByLocation</a></td><td>
Gets a value indicating whether there is a field with a visible aggregate and at specified position.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_FieldsModel_HasVisibleHeaders">HasVisibleHeaders</a></td><td>
Gets a value indicating whether there are field with a visible header.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseSimpleModelCollection_2_IndexOf">IndexOf</a></td><td>
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
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_Model_FieldsModel_SetOwner">SetOwner</a></td><td>
Sets this collection as the owner of the specified item.
 (Overrides <a href="M_iTin_Export_Model_BaseSimpleModelCollection_2_SetOwner">BaseSimpleModelCollection(TItem, TParent).SetOwner(TItem)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_ToString">ToString</a></td><td>
Returns a string that represents the current object.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_FieldsModel_Validate">Validate</a></td><td>
Validates the field definition list and the definition of field styles.</td></tr></table>&nbsp;
<a href="#fieldsmodel-class">Back to Top</a>

## Remarks

Belongs to: <strong>`Table`</strong>. For more information, please see <a href="T_iTin_Export_Model_TableModel">TableModel</a>. 
**IEE Object Element Usage**<br />
``` XML
<Fields>
  <Field/> | <Fixed/> | <Gap/> | <Group/> | <Packet/>
</Fields>
```


<strong>Elements</strong>
&nbsp;<table><tr><th>Element</th><th>Description</th></tr><tr><td>Field</td><td>Represents a data field. For more information, please see DataFieldModel</td></tr><tr><td>Fixed</td><td>Represents a piece of a field fixed-width data. For more information, please see FixedFieldModel</td></tr><tr><td>Gap</td><td>Represents an empty data field. For more information, please see GapFieldModel</td></tr><tr><td>Packet</td><td>Represents a packet data field. For more information, please see PacketFieldModel</td></tr></table>&nbsp;
<strong>Compatibility table with native writers</strong>
&nbsp;<table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td>X</td><td>X</td><td>X</td><td>X</td></tr></table>&nbsp;
A `<b>X</b>` value indicates that the writer supports this element.


## See Also


#### Reference
<a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />