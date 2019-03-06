# NegativeModel.Sign Property 
Additional header content 

Gets or sets visual format of negative value.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public KnownNegativeSign Sign { get; set; }
```

**VB**<br />
``` VB
Public Property Sign As KnownNegativeSign
	Get
	Set
```


#### Property Value
Type: <a href="T_iTin_Export_Model_KnownNegativeSign">KnownNegativeSign</a><br />Visual format of negative value. The default is <a href="T_iTin_Export_Model_KnownNegativeSign">Standard</a>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td>InvalidEnumArgumentException</td><td>The value specified is outside the range of valid values.</td></tr></table>

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Negative Sign="Standard|None|Parenthesis|Brackets" .../>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br /><a href="T_iTin_Export_Writers_CsvWriter">CsvWriter</a></th><th>Tab-Separated Values<br /><a href="T_iTin_Export_Writers_TsvWriter">TsvWriter</a></th><th>SQL Script<br /><a href="T_iTin_Export_Writers_SqlScriptWriter">SqlScriptWriter</a></th><th>XML Spreadsheet 2003<br /><a href="T_iTin_Export_Writers_Spreadsheet2003TabularWriter">Spreadsheet2003TabularWriter</a></th></tr><tr><td align="center">X</td><td align="center">X</td><td align="center">X</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## Examples
In the following example shows how create a new style. 
**XML**<br />
``` XML
<Style Name="TopAggregate">
  <Content Color="#C9C9C9">
    <Alignment Horizontal="Center"/>
    <Number Decimals="0" Separator="Yes">
      <Negative Color="Yellow" Sign="Brackets"/>
    </Number>
  </Content>
  <Font Name="Segoe UI" Size="12" Color="Navy" Bold="Yes"/>
</Style>
```

**C#**<br />
``` C#
StyleModel style = new StyleModel
                       {
                           Name = "TopAggregate",
                           Content = new ContentModel
                                         {
                                             Color = "#C9C9C9",
                                             Alignment = new ContentAlignmentModel
                                                             {
                                                                 Horizontal = KnownHorizontalAlignment.Center
                                                             },
                                             DataType = new NumberDataTypeModel
                                                            {
                                                                Decimals = 0,
                                                                Separator = YesNo.Yes,
                                                                Negative = new NegativeModel
                                                                               {
                                                                                   Color = KnownBasicColor.Yellow,
                                                                                   Sign = KnownNegativeSign.Brackets
                                                                               }
                                                            }
                                         }, 
                           Font = new FontModel
                                      {
                                          Color = "Navy",
                                          Bold = YesNo.Yes,
                                          Size = 12
                                      }
                       };
```


## See Also


#### Reference
<a href="T_iTin_Export_Model_NegativeModel">NegativeModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />