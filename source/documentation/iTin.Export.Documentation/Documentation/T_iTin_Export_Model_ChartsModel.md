# ChartsModel Class
Additional header content 

Collection of user-defined charts. Each element represents a user-defined chart.


## Inheritance Hierarchy
System.Object<br />&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseModel_1">iTin.Export.Model.BaseModel</a>(<a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection</a>(<a href="T_iTin_Export_Model_ChartModel">ChartModel</a>, <a href="T_iTin_Export_Model_TableModel">TableModel</a>))<br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">iTin.Export.Model.BaseSimpleModelCollection</a>(<a href="T_iTin_Export_Model_ChartModel">ChartModel</a>, <a href="T_iTin_Export_Model_TableModel">TableModel</a>)<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;iTin.Export.Model.ChartsModel<br />
**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
[SerializableAttribute]
public class ChartsModel : BaseSimpleModelCollection<ChartModel, TableModel>
```

**VB**<br />
``` VB
<SerializableAttribute>
Public Class ChartsModel
	Inherits BaseSimpleModelCollection(Of ChartModel, TableModel)
```

The ChartsModel type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_ChartsModel__ctor">ChartsModel</a></td><td>
Initializes a new instance of the ChartsModel class</td></tr></table>&nbsp;
<a href="#chartsmodel-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseSimpleModelCollection_2_Count">Count</a></td><td>
Gets the number of elements contained in the <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.
 (Inherited from <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseSimpleModelCollection_2_IsDefault">IsDefault</a></td><td>
When overridden in a derived class, gets a value indicating whether this instance contains the default.
 (Inherited from <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseSimpleModelCollection_2_IsReadOnly">IsReadOnly</a></td><td>
Gets a value indicating whether the <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a> is read-only.
 (Inherited from <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseSimpleModelCollection_2_Item">Item</a></td><td>
Gets or sets the element at the specified index.
 (Inherited from <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.)</td></tr><tr><td>![Protected property](media/protproperty.gif "Protected property")</td><td><a href="P_iTin_Export_Model_BaseSimpleModelCollection_2_List">List</a></td><td>
Gets a reference to the inner list.
 (Inherited from <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseSimpleModelCollection_2_Parent">Parent</a></td><td>
Gets a reference to the owner of the collection
 (Inherited from <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Model_BaseModel_1_Properties">Properties</a></td><td>
Gets or sets a reference to user-defined property list for this element.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr></table>&nbsp;
<a href="#chartsmodel-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseSimpleModelCollection_2_Add">Add</a></td><td>
Adds an object to the end of the <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.
 (Inherited from <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseSimpleModelCollection_2_Clear">Clear</a></td><td>
Removes all elements from the <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.
 (Inherited from <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseSimpleModelCollection_2_Contains">Contains</a></td><td>
Determines whether an element is in the <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.
 (Inherited from <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseSimpleModelCollection_2_CopyTo">CopyTo</a></td><td>
Copies the entire <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a> to a compatible one-dimensional array, starting at the specified index of the target array.
 (Inherited from <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>Equals</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>Finalize</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseSimpleModelCollection_2_Find">Find</a></td><td>
Searches for an element that matches the conditions defined by the specified predicate, and returns the first occurrence within the entire <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.
 (Inherited from <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseSimpleModelCollection_2_GetEnumerator">GetEnumerator</a></td><td>
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
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_Model_ChartsModel_SetOwner">SetOwner</a></td><td> (Overrides <a href="M_iTin_Export_Model_BaseSimpleModelCollection_2_SetOwner">BaseSimpleModelCollection(TItem, TParent).SetOwner(TItem)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_BaseModel_1_ToString">ToString</a></td><td>
Returns a string that represents the current object.
 (Inherited from <a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Model_ChartsModel_Validate">Validate</a></td><td>
Validates chart definition list.</td></tr></table>&nbsp;
<a href="#chartsmodel-class">Back to Top</a>

## Remarks

Belongs to: <strong>`Table`</strong>. For more information, please see <a href="T_iTin_Export_Model_TableModel">TableModel</a>. 
**ITEE Object Element Usage**<br />
``` XML
<Charts>
  <Chart/>
  <Chart/>
  ...
</Charts>
```



<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">No has effect</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## Examples

**XML**<br />
``` XML
<Charts>
  <Chart Location="1 2" Size="500 100" BackColor="LightGray">
    <Border Show="Yes" Color="Gray" Width="Medium">            
      <Shadow Show="Yes" Transparency="0.5"/>
    </Border>
    <Legend Show="Yes">            
      <Font Name="Calibri" />          
    </Legend>
    <Title>
      <Text>Sample Report</Text>
      <Font Name="Calibri" Color="Navy" Size="22" Bold="Yes"/>
    </Title>
    <Axes>
      <Primary>
        <Category>
          <Title>
            <Text>Category</Text>
            <Font Name="Calibri" Bold="Yes"/>                  
          </Title>
          <Labels Orientation="Downward" Position="Low" Alignment="Left">                  
            <Font Name="Calibri" Size="8" Color="Red"/>                  
          </Labels>
        </Category>
        <Values>
          <Title Show="Yes" Orientation="Vertical">
            <Text>Value</Text>
            <Font Name="Calibri" Bold="Yes" Color="Green"/>
          </Title>
          <Labels Orientation="Downward" Position="Low" Alignment="Left">
            <Font Name="Calibri" Size="8" Color="Green"/>                
          </Labels>
        </Values>
      </Primary>
    </Axes>
   <Plots>            
      <Plot Name="Plot1">
        <Series>
          <Serie Field="CMCUST" Axis="CMCUST" Type="Area3D" Legend="Account" Color="Green"/>                  
          <Serie Field="##LINE" Axis="CMCUST" Type="Area3D" Legend="Line" Color="AntiqueWhite"/>
          <Serie Field="NOCOL" Axis="CMCUST" Type="Area3D" Legend="No/Col" Color="Red"/>            
        </Series>         
      </Plot>
    </Plots>
  </Chart>       
</Charts>
```


## See Also


#### Reference
<a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />