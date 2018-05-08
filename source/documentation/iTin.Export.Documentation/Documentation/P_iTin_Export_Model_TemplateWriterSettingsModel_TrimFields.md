# TemplateWriterSettingsModel.TrimFields Property 
Additional header content 

Gets or sets a value indicating whether to trim the blanks.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
public YesNo TrimFields { get; set; }
```

**VB**<br />
``` VB
Public Property TrimFields As YesNo
	Get
	Set
```


#### Property Value
Type: <a href="T_iTin_Export_Model_YesNo">YesNo</a><br /><a href="T_iTin_Export_Model_YesNo">Yes</a> to trim the blanks; otherwise, <a href="T_iTin_Export_Model_YesNo">No</a>. The default is <a href="T_iTin_Export_Model_YesNo">No</a>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td>InvalidEnumArgumentException</td><td>The value specified is outside the range of valid values.</td></tr></table>

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Settings TrimFields="Yes|No" .../>
```


## See Also


#### Reference
<a href="T_iTin_Export_Model_TemplateWriterSettingsModel">TemplateWriterSettingsModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />