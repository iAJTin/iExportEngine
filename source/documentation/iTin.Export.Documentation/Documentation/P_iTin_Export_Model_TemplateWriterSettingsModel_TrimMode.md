# TemplateWriterSettingsModel.TrimMode Property 
Additional header content 

Gets or sets a value that determines trim mode for strings.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public KnownTrimMode TrimMode { get; set; }
```

**VB**<br />
``` VB
Public Property TrimMode As KnownTrimMode
	Get
	Set
```


#### Property Value
Type: <a href="T_iTin_Export_Model_KnownTrimMode">KnownTrimMode</a><br />One of the <a href="T_iTin_Export_Model_KnownTrimMode">KnownTrimMode</a> values. The default is <a href="T_iTin_Export_Model_KnownTrimMode">All</a>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td>InvalidEnumArgumentException</td><td>The value specified is outside the range of valid values.</td></tr></table>

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Settings TrimMode="All|Start|End" .../>
```


## See Also


#### Reference
<a href="T_iTin_Export_Model_TemplateWriterSettingsModel">TemplateWriterSettingsModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />