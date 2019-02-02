# ContentModel.DataType Property 
Additional header content 

Gets or sets content data type.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public BaseDataTypeModel DataType { get; set; }
```

**VB**<br />
``` VB
Public Property DataType As BaseDataTypeModel
	Get
	Set
```


#### Property Value
Type: <a href="T_iTin_Export_Model_BaseDataTypeModel">BaseDataTypeModel</a><br />Reference to content data type.

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Content>
  <Number/> | <Currency/> | <Percentage/> | <Scientific/> | <Datetime/> | <Special/> | <Text/>
  ...
</Content>
```


<strong>Compatibility table with native writers.</strong>
&nbsp;<table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td>X</td><td>X</td><td>X</td><td>X</td></tr></table>&nbsp;
A <strong>`X`</strong> value indicates that the writer supports this element.


## Examples
In the following example shows how create a new text content. 
**XML**<br />
``` XML
<Content Color="DarkBlue">
  <Alignment Horizontal="Left"/>
  <Text/>
</Content>
```

**C#**<br />
``` C#
var content = new ContentModel
{
    Color = "DarkBlue",
    DataType = new TextDataTypeModel(),
    Alignment = new ContentAlignmentModel { Horizontal = KnownHorizontalAlignment.Left }
};
```

**VB**<br />
``` VB
Dim content = New ContentModel With
{
    .Color = "DarkBlue",
    .DataType = New TextDataTypeModel(),
    .Alignment = New ContentAlignmentModel With { .Horizontal = KnownHorizontalAlignment.Left }
}
```

In the following example shows how create a new currency content.

**XML**<br />
``` XML
<Content Color="Beige">
  <Alignment Vertical="Bottom" Horizontal="Right"/>
  <Currency Decimals="1" Locale="mk">
    <Negative Color="Red" Sign="Parenthesis"/>
  </Currency>
</Content>
```

**C#**<br />
``` C#
var content = new ContentModel
{
    Color = "Beige",
    Alignment = new ContentAlignmentModel 
    { 
        Horizontal = KnownHorizontalAlignment.Left, 
        Vertical = KnownVerticalAlignment.Bottom 
    },
    DataType = new CurrencyDataTypeModel
    { 
        Decimals = 1,
        Locale = KnownCulture.mk,
        Negative = new NegativeModel
        {
            Color = KnownBasicColor.Red,
            Sign = KnownNegativeSign.Parenthesis
        }
    }
};
```

**VB**<br />
``` VB
Dim content = New ContentModel With
{
    .Color = "Beige",
    .Alignment = New ContentAlignmentModel With
     { 
         .Horizontal = KnownHorizontalAlignment.Left, 
         .Vertical = KnownVerticalAlignment.Bottom 
     },
    .DataType = New CurrencyDataTypeModel With
     { 
         .Decimals = 1,
         .Locale = KnownCulture.mk,
         .Negative = New NegativeModel With
          {
              .Color = KnownBasicColor.Red,
              .Sign = KnownNegativeSign.Parenthesis
          }
     }
}
```


## See Also


#### Reference
<a href="T_iTin_Export_Model_ContentModel">ContentModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />