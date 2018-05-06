# BaseSimpleModelCollection(*TItem*, *TParent*) Class
Additional header content 

\[Missing <summary> documentation for "T:iTin.Export.Model.BaseSimpleModelCollection`2"\]


## Inheritance Hierarchy
System.Object<br />&nbsp;&nbsp;<a href="6632f561-4175-f1f2-939c-ac8b10159529">iTin.Export.Model.BaseModel</a>(BaseSimpleModelCollection(*TItem*, *TParent*))<br />&nbsp;&nbsp;&nbsp;&nbsp;iTin.Export.Model.BaseSimpleModelCollection(TItem, TParent)<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="#inheritance-hierarchy">More...</a>
**Namespace:**&nbsp;<a href="ef57ffcc-e95e-b212-5a46-9aa6f5a3511f">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
[SerializableAttribute]
public abstract class BaseSimpleModelCollection<TItem, TParent> : BaseModel<BaseSimpleModelCollection<TItem, TParent>>, 
	IList<TItem>, ICollection<TItem>, IEnumerable<TItem>, IEnumerable

```

**VB**<br />
``` VB
<SerializableAttribute>
Public MustInherit Class BaseSimpleModelCollection(Of TItem, TParent)
	Inherits BaseModel(Of BaseSimpleModelCollection(Of TItem, TParent))
	Implements IList(Of TItem), ICollection(Of TItem), 
	IEnumerable(Of TItem), IEnumerable
```


#### Type Parameters
&nbsp;<dl><dt>TItem</dt><dd>\[Missing <typeparam name="TItem"/> documentation for "T:iTin.Export.Model.BaseSimpleModelCollection`2"\]</dd><dt>TParent</dt><dd>\[Missing <typeparam name="TParent"/> documentation for "T:iTin.Export.Model.BaseSimpleModelCollection`2"\]</dd></dl>&nbsp;
The BaseSimpleModelCollection(TItem, TParent) type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="9d69bdf7-d51c-5d97-6799-1fe9f16acfe8">BaseSimpleModelCollection(TItem, TParent)</a></td><td>
Initializes a new instance of the BaseSimpleModelCollection(TItem, TParent) class</td></tr></table>&nbsp;
<a href="#basesimplemodelcollection(*titem*,-*tparent*)-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="7a6f572e-f4ae-0452-0539-e3bcbe7a9cfe">Count</a></td><td /></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="686d1ff7-8d7f-5376-0b19-65a98f12bfe2">IsDefault</a></td><td> (Overrides BaseModel.IsDefault.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="70fc32c9-da58-7a92-a923-5d478d38a9de">IsReadOnly</a></td><td /></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="b3e389af-21e0-0e26-8fd6-d59b8a31f18b">Item</a></td><td /></tr><tr><td>![Protected property](media/protproperty.gif "Protected property")</td><td><a href="c0ae863e-1d6b-9c90-d114-23cca2eda582">List</a></td><td /></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="4a51807c-8d1d-d6df-124e-1bd5301b1a59">Parent</a></td><td /></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="7e88785e-5670-4515-defa-d3f60ae16111">Properties</a></td><td> (Inherited from <a href="6632f561-4175-f1f2-939c-ac8b10159529">BaseModel(T)</a>.)</td></tr></table>&nbsp;
<a href="#basesimplemodelcollection(*titem*,-*tparent*)-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="4ed6daaa-faee-f11e-1b12-ba563e6d3971">Add</a></td><td /></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="76bb792f-bd32-5006-cc4d-4d4400bf1d92">Clear</a></td><td /></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="094f4ef0-80d2-e610-a775-07751cd4ec6d">Contains</a></td><td /></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="953d74be-70d0-385c-e21d-ab71991e68b9">CopyTo</a></td><td /></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>Equals</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>Finalize</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="99d3244c-f5b7-c75d-39e1-c7d9322e6382">Find</a></td><td /></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="2dc923f3-699f-504c-b9dd-4e2821238d7c">GetEnumerator</a></td><td /></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetHashCode</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="4253f171-71af-35d6-e1b1-47af647eb205">GetStaticBindingValue</a></td><td> (Inherited from <a href="6632f561-4175-f1f2-939c-ac8b10159529">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetType</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="89eb6b27-8b1e-39f2-a41b-e563c6fba11a">IndexOf</a></td><td /></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="17dc0b72-ba88-b43f-6354-42e25a04d0dc">Insert</a></td><td /></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>MemberwiseClone</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="b0f4c53d-f6de-de16-cda9-d369ae47a239">Remove</a></td><td /></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="b8d3bc5d-f312-1b52-8903-5e4502dca58b">RemoveAt</a></td><td /></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="60537b6c-f261-e08e-2eee-1007e9760316">SaveToFile(String)</a></td><td> (Inherited from <a href="6632f561-4175-f1f2-939c-ac8b10159529">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="81bbc161-83e1-ff91-7904-4b6a5260f76c">SaveToFile(String, Exception)</a></td><td> (Inherited from <a href="6632f561-4175-f1f2-939c-ac8b10159529">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="d84fa1d2-692a-9e10-e839-60da45d50f19">Serialize</a></td><td> (Inherited from <a href="6632f561-4175-f1f2-939c-ac8b10159529">BaseModel(T)</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="15d88ece-c829-d6c1-109c-f1288e60ece2">SetOwner</a></td><td /></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="79c32584-b2b0-b6ca-0ade-5f0708e1a9b7">ToString</a></td><td> (Inherited from <a href="6632f561-4175-f1f2-939c-ac8b10159529">BaseModel(T)</a>.)</td></tr></table>&nbsp;
<a href="#basesimplemodelcollection(*titem*,-*tparent*)-class">Back to Top</a>

## Remarks
\[Missing <remarks> documentation for "T:iTin.Export.Model.BaseSimpleModelCollection`2"\]

## See Also


#### Reference
<a href="ef57ffcc-e95e-b212-5a46-9aa6f5a3511f">iTin.Export.Model Namespace</a><br />

## Inheritance HierarchySystem.Object<br />&nbsp;&nbsp;<a href="6632f561-4175-f1f2-939c-ac8b10159529">iTin.Export.Model.BaseModel</a>(BaseSimpleModelCollection(*TItem*, *TParent*))<br />&nbsp;&nbsp;&nbsp;&nbsp;iTin.Export.Model.BaseSimpleModelCollection(TItem, TParent)<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="1602f533-6779-8fab-d93a-b17fbbec4147">iTin.Export.Model.BaseComplexModelCollection(TItem, TParent, TSearch)</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="4bf09dba-3674-ea6b-467f-293682fa837e">iTin.Export.Model.BehaviorsModel</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="126b6bb2-e0b0-85c9-a613-b58ef9d2a6c5">iTin.Export.Model.ChartSeriesModel</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="7182bed1-ea7a-4fb6-930b-ce41b0f9e1c0">iTin.Export.Model.ChartsModel</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="e2fa085d-a996-60d4-2884-55a3261aa6a9">iTin.Export.Model.MailMessageAttachmentsModel</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="7dd54d13-30d8-6912-4163-af42bf8ab42b">iTin.Export.Model.MailMessagesModel</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="726e130a-98bf-d973-03e2-b7f696d07b50">iTin.Export.Model.ReferencesModel</a><br />