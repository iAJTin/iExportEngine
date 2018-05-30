# IProvider.Parse Method 
Additional header content 

Parse special chars of argument.

**Namespace:**&nbsp;<a href="N_iTin_Export_ComponentModel_Provider">iTin.Export.ComponentModel.Provider</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
string Parse(
	string value
)
```

**VB**<br />
``` VB
Function Parse ( 
	value As String
) As String
```


#### Parameters
&nbsp;<dl><dt>value</dt><dd>Type: System.String<br />String for parse.</dd></dl>

#### Return Value
Type: String<br />Parsed string.

## Remarks
Analyzes the argument *value*, replacing special characters by the pattern '_x####_', where: ####: Represents ASCII char code in Hexadecimal format.

## See Also


#### Reference
<a href="T_iTin_Export_ComponentModel_Provider_IProvider">IProvider Interface</a><br /><a href="N_iTin_Export_ComponentModel_Provider">iTin.Export.ComponentModel.Provider Namespace</a><br />