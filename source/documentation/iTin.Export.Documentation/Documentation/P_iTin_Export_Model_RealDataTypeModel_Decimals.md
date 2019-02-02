# RealDataTypeModel.Decimals Property 
Additional header content 

Gets or sets number of decimal places.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public int Decimals { get; set; }
```

**VB**<br />
``` VB
Public Property Decimals As Integer
	Get
	Set
```


#### Property Value
Type: Int32<br />Number of decimal places. The default is `2`.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td>ArgumentOutOfRangeException</td><td>*value* is less than 0.</td></tr></table>

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Percentage|NumericDataType|Scientific Decimals="int" ...>
...
</Percentage|NumericDataType|Scientific>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td align="center">X</td><td align="center">X</td><td align="center">X</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## Examples
In the following example shows how create a new style with a currency data type (inherits <a href="T_iTin_Export_Model_NumericDataTypeModel">NumericDataTypeModel</a>). 
**XML**<br />
``` XML
<Style Name="AccountValue">
  <Content Color="Blue">
    <Currency Decimals="1" Locale="mk">
      <Negative Color="Red" Sign="Parenthesis">
    </Currency>
  </Content>
  <Font Size="8" Color="White"/>
</Style>
```

Another example for the percentage data type (inherits <a href="T_iTin_Export_Model_RealDataTypeModel">RealDataTypeModel</a>).

**XML**<br />
``` XML
<Style Name="PercentValue">
  <Content Color="DarkGray">
    <Alignment Horizontal="Right" />
    <Percentage Decimals="1" />
  </Content>
  <Font Size="10" Bold="Yes" />
</Style>
```


## See Also


#### Reference
<a href="T_iTin_Export_Model_RealDataTypeModel">RealDataTypeModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />