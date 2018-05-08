# FilterModel.Company Property 
Additional header content 

Gets or sets the company name of the writer.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
public string Company { get; set; }
```

**VB**<br />
``` VB
Public Property Company As String
	Get
	Set
```


#### Property Value
Type: String<br />Company name of the writer. Select * for any author. The default is "`*`".

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Filter Company="*|string" .../>
```


## See Also


#### Reference
<a href="T_iTin_Export_Model_FilterModel">FilterModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />