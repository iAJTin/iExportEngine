# BaseDataFieldModel.Alias Property 
Additional header content 

Gets or sets the alias of data field.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
public string Alias { get; set; }
```

**VB**<br />
``` VB
Public Property Alias As String
	Get
	Set
```


#### Property Value
Type: String<br />The alias of data field. This value is used as the column header.

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Field|Fixed|Gap|Group Alias="string" ...>
  ...
</Field|Fixed|Gap|Group>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td align="center">X</td><td align="center">X</td><td align="center">X</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## Examples

**XML**<br />
``` XML
<Field Name="##LINE" Alias="Line">
...
</Field>
```

**C#**<br />
``` C#
DataFieldModel lineField = new DataFieldModel
                               {
                                   Name = "##LINE",
                                   Alias = "Line",
                                   Value = new FieldValueModel { Style = "LineValue" },
                                   Header = new FieldHeaderModel { Style = "CommonHeader", Show = YesNo.Yes },
                                   Aggregate = new FieldAggregateModel
                                                   {
                                                       Show = YesNo.Yes,
                                                       Style = "TopAggregate", 
                                                       Location = KnownAggregateLocation.Top,
                                                       AggregateType = KnownAggregateType.Count,
                                                   },
                               };
```


## See Also


#### Reference
<a href="T_iTin_Export_Model_BaseDataFieldModel">BaseDataFieldModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />