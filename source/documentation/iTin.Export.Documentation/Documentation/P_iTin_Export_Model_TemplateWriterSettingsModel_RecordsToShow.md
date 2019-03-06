# TemplateWriterSettingsModel.RecordsToShow Property 
Additional header content 

Gets or sets number of affected records.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public KnownRecordToShow RecordsToShow { get; set; }
```

**VB**<br />
``` VB
Public Property RecordsToShow As KnownRecordToShow
	Get
	Set
```


#### Property Value
Type: <a href="T_iTin_Export_Model_KnownRecordToShow">KnownRecordToShow</a><br />Number of affected records. The default is <a href="T_iTin_Export_Model_KnownRecordToShow">All</a>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td>InvalidEnumArgumentException</td><td>The value specified is outside the range of valid values.</td></tr></table>

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Settings RecordsToShow="All|First|Last|Random" .../>
```


## See Also


#### Reference
<a href="T_iTin_Export_Model_TemplateWriterSettingsModel">TemplateWriterSettingsModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />