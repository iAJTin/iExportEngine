# BaseProvider.Parse Method (String, IEnumerable(Char))
Additional header content 

Parse an String and replace the special chars defined in *specialChars* by a hexadecimal pattern.

**Namespace:**&nbsp;<a href="N_iTin_Export_ComponentModel_Provider">iTin.Export.ComponentModel.Provider</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
public static string Parse(
	string value,
	IEnumerable<char> specialChars
)
```

**VB**<br />
``` VB
Public Shared Function Parse ( 
	value As String,
	specialChars As IEnumerable(Of Char)
) As String
```


#### Parameters
&nbsp;<dl><dt>value</dt><dd>Type: System.String<br />String to parse</dd><dt>specialChars</dt><dd>Type: System.Collections.Generic.IEnumerable(Char)<br />Special chars to replace</dd></dl>

#### Return Value
Type: String<br />The parsed string.

## Remarks
Analyzes the argument *value*, replacing *specialChars* by the pattern '_x####_', where: ####: Represents ASCII char code in Hexadecimal format If the argument *value* does not contain any special characters returns the argument unchanged.

## See Also


#### Reference
<a href="T_iTin_Export_ComponentModel_Provider_BaseProvider">BaseProvider Class</a><br /><a href="Overload_iTin_Export_ComponentModel_Provider_BaseProvider_Parse">Parse Overload</a><br /><a href="N_iTin_Export_ComponentModel_Provider">iTin.Export.ComponentModel.Provider Namespace</a><br />