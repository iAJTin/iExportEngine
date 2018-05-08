# LocationModel.Mode Property 
Additional header content 

Gets or sets a reference to the location mode used in the host.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
public Object Mode { get; set; }
```

**VB**<br />
``` VB
Public Property Mode As Object
	Get
	Set
```


#### Property Value
Type: Object<br />Reference to the positioning mode used in the host.

## Remarks

The following table shows the different location modes types.
&nbsp;<table><tr><th>Mode</th><th>Description</th></tr><tr><td><a href="T_iTin_Export_Model_CoordenatesModel">CoordenatesModel</a></td><td>Represents a location mode appropiate when a host has a tabular format such as for example Microsoft® Excel.</td></tr><tr><td><a href="T_iTin_Export_Model_AlignmentModel">AlignmentModel</a></td><td>Represents a location mode appropiate when a host hasn't a tabular format such as for example Microsoft® Word, Adobe® PDF.</td></tr></table>

## See Also


#### Reference
<a href="T_iTin_Export_Model_LocationModel">LocationModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />