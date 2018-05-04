# DownloadBehaviorModel Class
Additional header content _**\[This is preliminary documentation and is subject to change.\]**_

\[Missing <summary> documentation for "T:iTin.Export.Model.DownloadBehaviorModel"\]


## Inheritance Hierarchy
System.Object<br />&nbsp;&nbsp;<a href="6632f561-4175-f1f2-939c-ac8b10159529">iTin.Export.Model.BaseModel</a>(<a href="f9334797-bdc1-1e81-7c19-cea545d52cb6">BaseBehaviorModel</a>)<br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="f9334797-bdc1-1e81-7c19-cea545d52cb6">iTin.Export.Model.BaseBehaviorModel</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;iTin.Export.Model.DownloadBehaviorModel<br />
**Namespace:**&nbsp;<a href="ef57ffcc-e95e-b212-5a46-9aa6f5a3511f">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
[SerializableAttribute]
public class DownloadBehaviorModel : BaseBehaviorModel
```

**VB**<br />
``` VB
<SerializableAttribute>
Public Class DownloadBehaviorModel
	Inherits BaseBehaviorModel
```

The DownloadBehaviorModel type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="c70b6eae-8102-6018-04e0-6e013ceb69af">DownloadBehaviorModel</a></td><td>
Initializes a new instance of the DownloadBehaviorModel class</td></tr></table>&nbsp;
<a href="#downloadbehaviormodel-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="490e87df-0a70-b7d6-1020-b72adfc5e3ed">CanExecute</a></td><td> (Inherited from <a href="f9334797-bdc1-1e81-7c19-cea545d52cb6">BaseBehaviorModel</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Static member](media/static.gif "Static member")</td><td><a href="0480ffca-16db-6aa5-b8db-89a633fe926f">Default</a></td><td /></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="37368182-eb5d-4f8a-f529-d5c4baf9b7a3">IsDefault</a></td><td> (Overrides <a href="97ded36f-00a1-970b-ac0d-96f90390a5ff">BaseBehaviorModel.IsDefault</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="e27fb04d-1448-5e47-3958-e437ee82f6fd">LocalCopy</a></td><td /></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="7e88785e-5670-4515-defa-d3f60ae16111">Properties</a></td><td> (Inherited from <a href="6632f561-4175-f1f2-939c-ac8b10159529">BaseModel(T)</a>.)</td></tr></table>&nbsp;
<a href="#downloadbehaviormodel-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>Equals</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="8f146636-5f9c-1a5f-1b11-939b55e93949">Execute(IWriter)</a></td><td> (Inherited from <a href="f9334797-bdc1-1e81-7c19-cea545d52cb6">BaseBehaviorModel</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="9d56305d-a549-328a-5c31-3836b28cd954">Execute(IWriter, ExportSettings)</a></td><td> (Inherited from <a href="f9334797-bdc1-1e81-7c19-cea545d52cb6">BaseBehaviorModel</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="eeca5700-0c45-3491-a558-ad380c62211f">ExecuteBehavior</a></td><td> (Overrides <a href="dec66c90-2a13-0a1d-5726-d99c2160fc54">BaseBehaviorModel.ExecuteBehavior(IWriter, ExportSettings)</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>Finalize</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetHashCode</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="4253f171-71af-35d6-e1b1-47af647eb205">GetStaticBindingValue</a></td><td> (Inherited from <a href="6632f561-4175-f1f2-939c-ac8b10159529">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetType</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>MemberwiseClone</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="60537b6c-f261-e08e-2eee-1007e9760316">SaveToFile(String)</a></td><td> (Inherited from <a href="6632f561-4175-f1f2-939c-ac8b10159529">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="81bbc161-83e1-ff91-7904-4b6a5260f76c">SaveToFile(String, Exception)</a></td><td> (Inherited from <a href="6632f561-4175-f1f2-939c-ac8b10159529">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="d84fa1d2-692a-9e10-e839-60da45d50f19">Serialize</a></td><td> (Inherited from <a href="6632f561-4175-f1f2-939c-ac8b10159529">BaseModel(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="7fdeb058-2ed4-0e45-bd15-7609902b3e88">SetOwner</a></td><td> (Inherited from <a href="f9334797-bdc1-1e81-7c19-cea545d52cb6">BaseBehaviorModel</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="79c32584-b2b0-b6ca-0ade-5f0708e1a9b7">ToString</a></td><td> (Inherited from <a href="6632f561-4175-f1f2-939c-ac8b10159529">BaseModel(T)</a>.)</td></tr></table>&nbsp;
<a href="#downloadbehaviormodel-class">Back to Top</a>

## Remarks
\[Missing <remarks> documentation for "T:iTin.Export.Model.DownloadBehaviorModel"\]

## See Also


#### Reference
<a href="ef57ffcc-e95e-b212-5a46-9aa6f5a3511f">iTin.Export.Model Namespace</a><br />