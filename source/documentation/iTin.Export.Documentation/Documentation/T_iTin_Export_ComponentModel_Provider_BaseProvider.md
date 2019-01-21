# BaseProvider Class
Additional header content 

Implements interface IProvider. Which acts as the base class for future providers.


## Inheritance Hierarchy
System.Object<br />&nbsp;&nbsp;iTin.Export.ComponentModel.Provider.BaseProvider<br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Providers_DataSetProvider">iTin.Export.Providers.DataSetProvider</a><br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_Providers_XmlProvider">iTin.Export.Providers.XmlProvider</a><br />
**Namespace:**&nbsp;<a href="N_iTin_Export_ComponentModel_Provider">iTin.Export.ComponentModel.Provider</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public abstract class BaseProvider : IProvider
```

**VB**<br />
``` VB
Public MustInherit Class BaseProvider
	Implements IProvider
```

The BaseProvider type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_ComponentModel_Provider_BaseProvider__ctor">BaseProvider</a></td><td>
Initializes a new instance of the BaseProvider class.</td></tr></table>&nbsp;
<a href="#baseprovider-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_ComponentModel_Provider_BaseProvider_CanCreateInputXml">CanCreateInputXml</a></td><td>
Gets a value indicating whether you can create an <strong>Xml</strong> file from the current instance of the object.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_ComponentModel_Provider_BaseProvider_CanGetDataTable">CanGetDataTable</a></td><td>
Gets a value indicating whether this instance can get data table.</td></tr><tr><td>![Protected property](media/protproperty.gif "Protected property")![Static member](media/static.gif "Static member")</td><td><a href="P_iTin_Export_ComponentModel_Provider_BaseProvider_EmptySpecialChars">EmptySpecialChars</a></td><td>
Gets the empty special chars.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_ComponentModel_Provider_BaseProvider_Input">Input</a></td><td>
Gets a reference to the data model.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_ComponentModel_Provider_BaseProvider_InputUri">InputUri</a></td><td>
Gets a reference to input file.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_ComponentModel_Provider_BaseProvider_ProviderMetadata">ProviderMetadata</a></td><td>
Gets a reference that contains the metadata information about this provider.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_ComponentModel_Provider_BaseProvider_SpecialChars">SpecialChars</a></td><td>
Gets or sets an special char array.</td></tr></table>&nbsp;
<a href="#baseprovider-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_ComponentModel_Provider_BaseProvider_CreateInputXml">CreateInputXml</a></td><td>
Creates the `Xml` source file from.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>Equals</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_ComponentModel_Provider_BaseProvider_Export">Export</a></td><td>
Export specified input data model with this provider by applying the specified writer in configuration file.</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>Finalize</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetHashCode</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetType</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")![Static member](media/static.gif "Static member")</td><td><a href="M_iTin_Export_ComponentModel_Provider_BaseProvider_LoadXmlFromFile">LoadXmlFromFile</a></td><td>
Retrieves `Xml` content of specified *table* in a file.</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>MemberwiseClone</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_ComponentModel_Provider_BaseProvider_OnCreateInputXml">OnCreateInputXml</a></td><td>
Concrete implementation by object type.</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_ComponentModel_Provider_BaseProvider_OnGetDataTable">OnGetDataTable</a></td><td>
Concrete implementation by object type.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_ComponentModel_Provider_BaseProvider_Parse">Parse(String)</a></td><td>
Parse an String and replace the special chars defined in SpecialChars by a hexadecimal pattern.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_iTin_Export_ComponentModel_Provider_BaseProvider_Parse_1">Parse(String, IEnumerable(Char))</a></td><td>
Parse an String and replace the special chars defined in *specialChars* by a hexadecimal pattern.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_ComponentModel_Provider_BaseProvider_SetInputDataModel">SetInputDataModel</a></td><td>
Add a data model to this provider.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_ComponentModel_Provider_BaseProvider_SetSpecialChars">SetSpecialChars</a></td><td>
Sets an special char array to this provider.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_ComponentModel_Provider_BaseProvider_ToDataTable">ToDataTable</a></td><td>
Gets a reference to the DataTable object that contains the data this instance.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_ComponentModel_Provider_BaseProvider_ToString">ToString</a></td><td>
Returns a string that represents the current data type.
 (Overrides Object.ToString().)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_ComponentModel_Provider_BaseProvider_ToXml">ToXml</a></td><td>
Gets a reference to the IEnumerable(T) object that contains the data this instance.</td></tr></table>&nbsp;
<a href="#baseprovider-class">Back to Top</a>

## Remarks

The following table shows the different provider types.
&nbsp;<table><tr><th>Class</th><th>Description</th></tr><tr><td>DataSetProvider</td><td>Represents a custom provider for DataSet inputs. For more information please see DataSetProvider</td></tr><tr><td>XmlProvider</td><td>Represents a custom provider for `Xml` types. For more information please see XmlProvider</td></tr></table>

## See Also


#### Reference
<a href="N_iTin_Export_ComponentModel_Provider">iTin.Export.ComponentModel.Provider Namespace</a><br />