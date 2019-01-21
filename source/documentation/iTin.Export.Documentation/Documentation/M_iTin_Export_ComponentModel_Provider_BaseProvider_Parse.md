# BaseProvider.Parse Method (String)
Additional header content 

Parse an String and replace the special chars defined in SpecialChars by a hexadecimal pattern.

**Namespace:**&nbsp;<a href="N_iTin_Export_ComponentModel_Provider">iTin.Export.ComponentModel.Provider</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public string Parse(
	string value
)
```

**VB**<br />
``` VB
Public Function Parse ( 
	value As String
) As String
```


#### Parameters
&nbsp;<dl><dt>value</dt><dd>Type: System.String<br />String to parse</dd></dl>

#### Return Value
Type: String<br />Parsed String.

#### Implements
<a href="M_iTin_Export_ComponentModel_Provider_IProvider_Parse">IProvider.Parse(String)</a><br />

## Remarks
Analyzes the argument *value*, replacing SpecialChars by the pattern '_x####_', where: ####: Represents ASCII char code in Hexadecimal format If the argument *value* does not contain any SpecialChars returns the argument unchanged.

## See Also


#### Reference
<a href="T_iTin_Export_ComponentModel_Provider_BaseProvider">BaseProvider Class</a><br /><a href="Overload_iTin_Export_ComponentModel_Provider_BaseProvider_Parse">Parse Overload</a><br /><a href="N_iTin_Export_ComponentModel_Provider">iTin.Export.ComponentModel.Provider Namespace</a><br />