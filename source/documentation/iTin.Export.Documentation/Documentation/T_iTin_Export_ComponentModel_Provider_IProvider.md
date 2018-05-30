# IProvider Interface
Additional header content 

Declares a generic provider.

**Namespace:**&nbsp;<a href="N_iTin_Export_ComponentModel_Provider">iTin.Export.ComponentModel.Provider</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
public interface IProvider
```

**VB**<br />
``` VB
Public Interface IProvider
```

The IProvider type exposes the following members.


## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_ComponentModel_Provider_IProvider_CanCreateInputXml">CanCreateInputXml</a></td><td>
Gets a value indicating whether you can create an <strong>Xml</strong> file from the current instance of the object.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_ComponentModel_Provider_IProvider_CanGetDataTable">CanGetDataTable</a></td><td>
Gets a value indicating whether this instance can get data table.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_ComponentModel_Provider_IProvider_Input">Input</a></td><td>
Gets a reference to the input data model.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_ComponentModel_Provider_IProvider_InputUri">InputUri</a></td><td>
Gets the input Uri.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_ComponentModel_Provider_IProvider_ProviderMetadata">ProviderMetadata</a></td><td>
Gets a reference that contains the metadata information of this provider.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_ComponentModel_Provider_IProvider_SpecialChars">SpecialChars</a></td><td>
Gets an special char array.</td></tr></table>&nbsp;
<a href="#iprovider-interface">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_ComponentModel_Provider_IProvider_CreateInputXml">CreateInputXml</a></td><td>
Creates the <b>Xml</b> source file from.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_ComponentModel_Provider_IProvider_Export">Export</a></td><td>
Export this target by applying the specified configuration.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_ComponentModel_Provider_IProvider_Parse">Parse</a></td><td>
Parse special chars of argument.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_ComponentModel_Provider_IProvider_SetInputDataModel">SetInputDataModel</a></td><td>
Add an input data model to this adapter.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_ComponentModel_Provider_IProvider_SetSpecialChars">SetSpecialChars</a></td><td>
Sets an special char array to this provider.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_ComponentModel_Provider_IProvider_ToDataTable">ToDataTable</a></td><td>
Gets a reference to the DataTable object than contains the data this instance.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_ComponentModel_Provider_IProvider_ToXml">ToXml</a></td><td>
Gets a reference to the IEnumerable(T) object than contains the data this instance.</td></tr></table>&nbsp;
<a href="#iprovider-interface">Back to Top</a>

## Remarks
\[Missing <remarks> documentation for "T:iTin.Export.ComponentModel.Provider.IProvider"\]

## See Also


#### Reference
<a href="N_iTin_Export_ComponentModel_Provider">iTin.Export.ComponentModel.Provider Namespace</a><br />