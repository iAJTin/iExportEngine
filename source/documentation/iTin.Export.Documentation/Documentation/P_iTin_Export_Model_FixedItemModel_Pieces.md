# FixedItemModel.Pieces Property 
Additional header content 

Gets or sets collection of smaller fields resulting from splitting a reference field.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
public PiecesModel Pieces { get; set; }
```

**VB**<br />
``` VB
Public Property Pieces As PiecesModel
	Get
	Set
```


#### Property Value
Type: <a href="T_iTin_Export_Model_PiecesModel">PiecesModel</a><br />Collection of smaller fields resulting from splitting a reference field. Each element is composed of a field name and initial position and final position into the reference field.

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Pieces>
  <Piece .../>
  <Piece .../>
  ...
<Pieces>
```


## See Also


#### Reference
<a href="T_iTin_Export_Model_FixedItemModel">FixedItemModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />