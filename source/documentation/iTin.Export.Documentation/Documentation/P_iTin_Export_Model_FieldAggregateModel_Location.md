# FieldAggregateModel.Location Property 
Additional header content 

Gets or sets preferred location in which to add the aggregate.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public KnownAggregateLocation Location { get; set; }
```

**VB**<br />
``` VB
Public Property Location As KnownAggregateLocation
	Get
	Set
```


#### Property Value
Type: <a href="T_iTin_Export_Model_KnownAggregateLocation">KnownAggregateLocation</a><br />One <a href="T_iTin_Export_Model_KnownAggregateLocation">KnownAggregateLocation</a> value. Preferred location in which to add the aggregate. The default is <a href="T_iTin_Export_Model_KnownAggregateLocation">Top</a>

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td>InvalidEnumArgumentException</td><td>The value specified is outside the range of valid values.</td></tr></table>

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Aggregate Location="Top|Bottom" ...>
...
</Aggregate>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br /><a href="T_iTin_Export_Writers_CsvWriter">CsvWriter</a></th><th>Tab-Separated Values<br /><a href="T_iTin_Export_Writers_TsvWriter">TsvWriter</a></th><th>SQL Script<br /><a href="T_iTin_Export_Writers_SqlScriptWriter">SqlScriptWriter</a></th><th>XML Spreadsheet 2003<br /><a href="T_iTin_Export_Writers_Spreadsheet2003TabularWriter">Spreadsheet2003TabularWriter</a></th></tr><tr><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## See Also


#### Reference
<a href="T_iTin_Export_Model_FieldAggregateModel">FieldAggregateModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />