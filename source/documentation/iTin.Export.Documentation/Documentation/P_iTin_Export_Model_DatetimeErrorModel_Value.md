# DatetimeErrorModel.Value Property 
Additional header content 

Gets or sets preferred default value when occurs an error.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public string Value { get; set; }
```

**VB**<br />
``` VB
Public Property Value As String
	Get
	Set
```


#### Property Value
Type: String<br />Preferred default value when occurs an error. The default is "`MinValue`".

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Error Value="string" ...>
  ...
</Error>
```

`AEE` recognizes the following strings as valid values:
&nbsp;<table><tr><th>Value</th><th>Description</th></tr><tr><td>MinValue</td><td>Represents date '01/01/1900'.</td></tr><tr><td>MaxValue</td><td>Represents maximun system date.</td></tr><tr><td>Today</td><td>Represents today date.</td></tr><tr><td>Other value</td><td>Defined by user. If the value is not correct will used `MinValue`.</td></tr></table>&nbsp;
<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td align="center">X</td><td align="center">X</td><td align="center">X</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## Examples
In the following example shows how create a new style with a currency data type. 
**XML**<br />
``` XML
<Style Name="DateValue">
  <Content Color="sc# 0.15 0.15 0.15">
    <Alignment Horizontal="Center"/>
    <DateTime Format="Year-Month" Locale="en-US">
      <Error Value="Today">
        <Comment Show="Yes">
          <Font Name="Comic Sans MS" Size="16" Bold="Yes" Italic="Yes" Underline="Yes"/>
        </Comment>
      </Error>
    </DateTime>
  </Content>
</Style>
```


## See Also


#### Reference
<a href="T_iTin_Export_Model_DatetimeErrorModel">DatetimeErrorModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />