# DataFiltersModel Class
Additional header content 

\[Missing <summary> documentation for "T:iTin.Export.Model.DataFiltersModel"\]


## Inheritance Hierarchy
System.Object<br />&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseModel_1">iTin.Export.Model.BaseModel</a>(<a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection</a>(<a href="T_iTin_Export_Model_DataFilterModel">DataFilterModel</a>, <a href="T_iTin_Export_Model_GlobalResourcesModel">GlobalResourcesModel</a>))<br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">iTin.Export.Model.BaseSimpleModelCollection</a>(<a href="T_iTin_Export_Model_DataFilterModel">DataFilterModel</a>, <a href="T_iTin_Export_Model_GlobalResourcesModel">GlobalResourcesModel</a>)<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseComplexModelCollection_3">iTin.Export.Model.BaseComplexModelCollection</a>(<a href="T_iTin_Export_Model_DataFilterModel">DataFilterModel</a>, <a href="T_iTin_Export_Model_GlobalResourcesModel">GlobalResourcesModel</a>, String)<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;iTin.Export.Model.DataFiltersModel<br />
**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
[SerializableAttribute]
public class DataFiltersModel : BaseComplexModelCollection<DataFilterModel, GlobalResourcesModel, string>, 
	ICloneable
```

**VB**<br />
``` VB
<SerializableAttribute>
Public Class DataFiltersModel
	Inherits BaseComplexModelCollection(Of DataFilterModel, GlobalResourcesModel, String)
	Implements ICloneable
```

The DataFiltersModel type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_DataFiltersModel__ctor">DataFiltersModel</a></td><td>
Initializes a new instance of the DataFiltersModel class.</td></tr></table>&nbsp;
<a href="#datafiltersmodel-class">Back to Top</a>

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
<a href="#datafiltersmodel-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseSimpleModelCollection_2_Add">Add</a></td><td>
Adds an object to the end of the <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.
 (Inherited from <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseSimpleModelCollection_2_Clear">Clear</a></td><td>
Removes all elements from the <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.
 (Inherited from <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_DataFiltersModel_Clone">Clone</a></td><td>
Clones this instance.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseComplexModelCollection_3_Contains">Contains(TSearch)</a></td><td>
Determines whether an element is in the <a href="T_iTin_Export_Model_BaseComplexModelCollection_3">BaseComplexModelCollection(TItem, TParent, TSearch)</a>.
 (Inherited from <a href="T_iTin_Export_Model_BaseComplexModelCollection_3">BaseComplexModelCollection(TItem, TParent, TSearch)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseSimpleModelCollection_2_Contains">Contains(TItem)</a></td><td>
Determines whether an element is in the <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.
 (Inherited from <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseSimpleModelCollection_2_CopyTo">CopyTo</a></td><td>
Copies the entire <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a> to a compatible one-dimensional array, starting at the specified index of the target array.
 (Inherited from <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>Equals</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>Finalize</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseSimpleModelCollection_2_Find">Find</a></td><td>
Searches for an element that matches the conditions defined by the specified predicate, and returns the first occurrence within the entire <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.
 (Inherited from <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_DataFiltersModel_GetBy">GetBy</a></td><td>
Gets a specified condition by name
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
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_Model_DataFiltersModel_SetOwner">SetOwner</a></td><td>

 (Overrides <a href="M_iTin_Export_Model_BaseSimpleModelCollection_2_SetOwner">BaseSimpleModelCollection(TItem, TParent).SetOwner(TItem)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_ToString">ToString</a></td><td>
Returns a string that represents the current object.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr></table>&nbsp;
<a href="#datafiltersmodel-class">Back to Top</a>

## Remarks
\[Missing <remarks> documentation for "T:iTin.Export.Model.DataFiltersModel"\]

## See Also


#### Reference
<a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />