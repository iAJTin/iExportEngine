# MarginsModel.Right Property 
Additional header content 

Gets or sets the preferred right margin of document.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public float Right { get; set; }
```

**VB**<br />
``` VB
Public Property Right As Single
	Get
	Set
```


#### Property Value
Type: Single<br />Preferred right margin of document. The default is `20`.

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Margins Right="float".../>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## Examples
In the following example shows how create a new margins object. 
**XML**<br />
``` XML
<Margins Top="23" Left="23" Right="23" Bottom="23"/>
```

**C#**<br />
``` C#
MarginsModel margins = new MarginsModel
                           {
                               Top = 23,
                               Left = 23,
                               Right = 23,
                               Bottom = 23
                           };
```


## See Also


#### Reference
<a href="T_iTin_Export_Model_MarginsModel">MarginsModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />