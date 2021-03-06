# ProviderOptionsMetadata.Company Property 
Additional header content 

Gets a value than represents the name of the company that created of this provider.

**Namespace:**&nbsp;<a href="N_iTin_Export_ComponentModel_Provider">iTin.Export.ComponentModel.Provider</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public string Company { get; }
```

**VB**<br />
``` VB
Public ReadOnly Property Company As String
	Get
```


#### Property Value
Type: String<br />A String than contains the provider's company

#### Implements
<a href="P_iTin_Export_ComponentModel_Provider_IProviderOptions_Company">IProviderOptions.Company</a><br />

## Remarks
This value is recovered using reflection the <a href="P_iTin_Export_ComponentModel_Provider_ProviderOptionsAttribute_Company">Company</a> property of the <a href="T_iTin_Export_ComponentModel_Provider_ProviderOptionsAttribute">ProviderOptionsAttribute</a> attribute.

## See Also


#### Reference
<a href="T_iTin_Export_ComponentModel_Provider_ProviderOptionsMetadata">ProviderOptionsMetadata Structure</a><br /><a href="N_iTin_Export_ComponentModel_Provider">iTin.Export.ComponentModel.Provider Namespace</a><br />