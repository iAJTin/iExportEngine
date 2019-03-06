# BaseConditionModel.Locale Property 
Additional header content 

Gets or sets the data field culture. The default is <a href="T_iTin_Export_Model_KnownCulture">Current</a>.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public KnownCulture Locale { get; set; }
```

**VB**<br />
``` VB
Public Property Locale As KnownCulture
	Get
	Set
```


#### Property Value
Type: <a href="T_iTin_Export_Model_KnownCulture">KnownCulture</a><br />One of the <a href="T_iTin_Export_Model_KnownCulture">KnownCulture</a> values.

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<MaximumCondition|MinimumCondition|RemarksCondition|WhenChangeCondition|ZeroCondition Locale="Current|any culture" ...>
  ...
<MaximumCondition|MinimumCondition|RemarksCondition|WhenChangeCondition|ZeroCondition>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br /><a href="T_iTin_Export_Writers_CsvWriter">CsvWriter</a></th><th>Tab-Separated Values<br /><a href="T_iTin_Export_Writers_TsvWriter">TsvWriter</a></th><th>SQL Script<br /><a href="T_iTin_Export_Writers_SqlScriptWriter">SqlScriptWriter</a></th><th>XML Spreadsheet 2003<br /><a href="T_iTin_Export_Writers_Spreadsheet2003TabularWriter">Spreadsheet2003TabularWriter</a></th></tr><tr><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## Examples
In the following example shows how create a new style. 
**XML**<br />
``` XML
<Global.Resources>
  <Conditions>
    <MaximumCondition Key="max" Active="Yes" Field="TOTAL" EntireRow="No" Style="maxTotalStyle" Locale="en-EN"/>
    ...
  </Conditions>
</Global.Resources>
```


## See Also


#### Reference
<a href="T_iTin_Export_Model_BaseConditionModel">BaseConditionModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />