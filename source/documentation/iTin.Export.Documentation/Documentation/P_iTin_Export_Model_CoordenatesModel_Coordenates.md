# CoordenatesModel.Coordenates Property 
Additional header content 

Gets or sets an array of integers that represent a point expressed in cartesian coordenates.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
public int[] Coordenates { get; set; }
```

**VB**<br />
``` VB
Public Property Coordenates As Integer()
	Get
	Set
```


#### Property Value
Type: Int32[]<br />An array of two positions of Int32, that represent the table location. The default is '1 1'.

## Remarks

**TEE Object Element Usage**<br />
``` XML
<ByCoordenates Coordenates="int int" ...>
  ...
</ByCoordenates>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## Examples
The following example show how to use this element. 
**XML**<br />
``` XML
<ByCoordenates Coordenates="2 2">
...
</ByCoordenates>
```

**C#**<br />
``` C#
...
CoordenatesModel coordenatesLocation = new CoordenatesModel 
                                           {
                                               Coordenates = new { 2, 2 } 
                                           };
TableModel table = new TableModel 
                       {
                           Name = "Sample name",
                           Alias = "Sample alias",
                           AutoFilter = YesNo.Yes,
                           Location = coordenatesLocation,
                           AutoFitColumns = YesNo.Yes,
                       } ;
 ...
```


## See Also


#### Reference
<a href="T_iTin_Export_Model_CoordenatesModel">CoordenatesModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />