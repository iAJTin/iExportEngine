# BaseConditionModel.Key Property 
Additional header content 

Gets or sets a value that contains an identifier for this condition

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public string Key { get; set; }
```

**VB**<br />
``` VB
Public Property Key As String
	Get
	Set
```


#### Property Value
Type: String<br />A String that represents the identifier for this condition.

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<MaximumCondition|MinimumCondition|RemarksCondition|WhenChangeCondition|ZeroCondition Key="string" ...>
  ...
<MaximumCondition|MinimumCondition|RemarksCondition|WhenChangeCondition|ZeroCondition>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br /><a href="T_iTin_Export_Writers_CsvWriter">CsvWriter</a></th><th>Tab-Separated Values<br /><a href="T_iTin_Export_Writers_TsvWriter">TsvWriter</a></th><th>SQL Script<br /><a href="T_iTin_Export_Writers_SqlScriptWriter">SqlScriptWriter</a></th><th>XML Spreadsheet 2003<br /><a href="T_iTin_Export_Writers_Spreadsheet2003TabularWriter">Spreadsheet2003TabularWriter</a></th></tr><tr><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## Examples

**ITEE Object Element Usage**<br />
``` XML
<Global.Resources>
  <Conditions>
    <MaximumCondition Key="max" Active="Yes" Field="TOTAL" EntireRow="No" Style="maxTotalStyle"/>
    ...
  </Conditions>
</Global.Resources>
```


## See Also


#### Reference
<a href="T_iTin_Export_Model_BaseConditionModel">BaseConditionModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />