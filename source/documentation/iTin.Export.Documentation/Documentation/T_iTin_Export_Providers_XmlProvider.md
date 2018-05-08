# XmlProvider Class
Additional header content 

A Specialization of BaseAdapter than represents a source object based on the `Xml`.


## Inheritance Hierarchy
System.Object<br />&nbsp;&nbsp;<a href="T_iTin_Export_ComponentModel_Provider_BaseProvider">iTin.Export.ComponentModel.Provider.BaseProvider</a><br />&nbsp;&nbsp;&nbsp;&nbsp;iTin.Export.Providers.XmlProvider<br />
**Namespace:**&nbsp;<a href="N_iTin_Export_Providers">iTin.Export.Providers</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
public class XmlProvider : BaseProvider
```

**VB**<br />
``` VB
Public Class XmlProvider
	Inherits BaseProvider
```

The XmlProvider type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Providers_XmlProvider__ctor_1">XmlProvider(Uri)</a></td><td>
Initializes a new instance of the XmlProvider class.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Providers_XmlProvider__ctor">XmlProvider(ProviderParameters)</a></td><td>
Initializes a new instance of the XmlProvider class.</td></tr></table>&nbsp;
<a href="#xmlprovider-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_ComponentModel_Provider_BaseProvider_CanCreateInputXml">CanCreateInputXml</a></td><td>
Gets a value indicating whether you can create an <strong>Xml</strong> file from the current instance of the object.
 (Inherited from <a href="T_iTin_Export_ComponentModel_Provider_BaseProvider">BaseProvider</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_ComponentModel_Provider_BaseProvider_CanGetDataTable">CanGetDataTable</a></td><td>
Gets a value indicating whether this instance can get data table.
 (Inherited from <a href="T_iTin_Export_ComponentModel_Provider_BaseProvider">BaseProvider</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_ComponentModel_Provider_BaseProvider_Input">Input</a></td><td>
Gets a reference to the data model.
 (Inherited from <a href="T_iTin_Export_ComponentModel_Provider_BaseProvider">BaseProvider</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_ComponentModel_Provider_BaseProvider_InputUri">InputUri</a></td><td>
Gets a reference to input file.
 (Inherited from <a href="T_iTin_Export_ComponentModel_Provider_BaseProvider">BaseProvider</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_ComponentModel_Provider_BaseProvider_ProviderMetadata">ProviderMetadata</a></td><td>
Gets a reference that contains the metadata information about this provider.
 (Inherited from <a href="T_iTin_Export_ComponentModel_Provider_BaseProvider">BaseProvider</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_ComponentModel_Provider_BaseProvider_SpecialChars">SpecialChars</a></td><td>
Gets or sets an special char array.
 (Inherited from <a href="T_iTin_Export_ComponentModel_Provider_BaseProvider">BaseProvider</a>.)</td></tr></table>&nbsp;
<a href="#xmlprovider-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_ComponentModel_Provider_BaseProvider_CreateInputXml">CreateInputXml</a></td><td>
Creates the `Xml` source file from.
 (Inherited from <a href="T_iTin_Export_ComponentModel_Provider_BaseProvider">BaseProvider</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>Equals</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_ComponentModel_Provider_BaseProvider_Export">Export</a></td><td>
Export specified input data model with this provider by applying the specified writer in configuration file.
 (Inherited from <a href="T_iTin_Export_ComponentModel_Provider_BaseProvider">BaseProvider</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>Finalize</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetHashCode</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetType</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>MemberwiseClone</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_ComponentModel_Provider_BaseProvider_OnCreateInputXml">OnCreateInputXml</a></td><td>
Concrete implementation by object type.
 (Inherited from <a href="T_iTin_Export_ComponentModel_Provider_BaseProvider">BaseProvider</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_ComponentModel_Provider_BaseProvider_OnGetDataTable">OnGetDataTable</a></td><td>
Concrete implementation by object type.
 (Inherited from <a href="T_iTin_Export_ComponentModel_Provider_BaseProvider">BaseProvider</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_ComponentModel_Provider_BaseProvider_Parse">Parse(String)</a></td><td>
Parse an String and replace the special chars defined in SpecialChars by a hexadecimal pattern.
 (Inherited from <a href="T_iTin_Export_ComponentModel_Provider_BaseProvider">BaseProvider</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_ComponentModel_Provider_BaseProvider_SetInputDataModel">SetInputDataModel</a></td><td>
Add a data model to this provider.
 (Inherited from <a href="T_iTin_Export_ComponentModel_Provider_BaseProvider">BaseProvider</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_ComponentModel_Provider_BaseProvider_SetSpecialChars">SetSpecialChars</a></td><td>
Sets an special char array to this provider.
 (Inherited from <a href="T_iTin_Export_ComponentModel_Provider_BaseProvider">BaseProvider</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_ComponentModel_Provider_BaseProvider_ToDataTable">ToDataTable</a></td><td>
Gets a reference to the DataTable object that contains the data this instance.
 (Inherited from <a href="T_iTin_Export_ComponentModel_Provider_BaseProvider">BaseProvider</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_ComponentModel_Provider_BaseProvider_ToString">ToString</a></td><td>
Returns a string that represents the current data type.
 (Inherited from <a href="T_iTin_Export_ComponentModel_Provider_BaseProvider">BaseProvider</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_ComponentModel_Provider_BaseProvider_ToXml">ToXml</a></td><td>
Gets a reference to the IEnumerable(T) object that contains the data this instance.
 (Inherited from <a href="T_iTin_Export_ComponentModel_Provider_BaseProvider">BaseProvider</a>.)</td></tr></table>&nbsp;
<a href="#xmlprovider-class">Back to Top</a>

## Remarks

The following table shows the different provider types.
&nbsp;<table><tr><th>Class</th><th>Description</th></tr><tr><td>DataSetProvider</td><td>Represents a custom provider for DataSet inputs. For more information please see DataSetProvider</td></tr><tr><td>XmlProvider</td><td>Represents a custom provider for `Xml` types. For more information please see XmlProvider</td></tr></table>

## See Also


#### Reference
<a href="N_iTin_Export_Providers">iTin.Export.Providers Namespace</a><br />