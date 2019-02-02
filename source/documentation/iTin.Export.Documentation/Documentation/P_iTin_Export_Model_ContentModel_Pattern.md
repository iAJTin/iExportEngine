# ContentModel.Pattern Property 
Additional header content 

Gets or sets the fill pattern content.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public PatternModel Pattern { get; set; }
```

**VB**<br />
``` VB
Public Property Pattern As PatternModel
	Get
	Set
```


#### Property Value
Type: <a href="T_iTin_Export_Model_PatternModel">PatternModel</a><br />Fill pattern.

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Content>
  <Pattern.../>
</Content>
```


<strong>Compatibility table with native writers.</strong>
&nbsp;<table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td>No has effect</td><td>No has effect</td><td>No has effect</td><td>X</td></tr></table>&nbsp;
A <strong>`X`</strong> value indicates that the writer supports this element.


## Examples
In the following example shows how create a new content. 
**XML**<br />
``` XML
<Content AlternateColor="Red" Color="DarkBlue">
  <Alignment Horizontal="Left"/>
  <Text/>
</Content>
```

**C#**<br />
``` C#
var content = new ContentModel
{
    DataType = new TextDataTypeModel(),
    Pattern = new PatternModel { Color = "AliceBlue", PatternType = KnownPatternType.Gray75 },
    Alignment = new ContentAlignmentModel { Horizontal = KnownHorizontalAlignment.Left }
};
```

**VB**<br />
``` VB
Dim content = New ContentModel With
{
    .DataType = New TextDataTypeModel(),
    .Pattern = New PatternModel With { .Color = "AliceBlue", .PatternType = KnownPatternType.Gray75 },
    .Alignment = New ContentAlignmentModel With { .Horizontal = KnownHorizontalAlignment.Left }
}
```


## See Also


#### Reference
<a href="T_iTin_Export_Model_ContentModel">ContentModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />