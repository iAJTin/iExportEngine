# CurrencyDataTypeModel.Locale Property 
Additional header content 

Gets or sets preferred output culture.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public KnownCulture Locale { get; set; }
```

**VB**<br />
``` VB
Public Property Locale As KnownCulture
	Get
	Set
```


#### Property Value
Type: <a href="T_iTin_Export_Model_KnownCulture">KnownCulture</a><br />One of the <a href="T_iTin_Export_Model_KnownCulture">KnownCulture</a> values. The default is <a href="T_iTin_Export_Model_KnownCulture">Current</a>.

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Currency Locale="string" ...>
...
</Currency>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td align="center">X</td><td align="center">X</td><td align="center">X</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## Examples
In the following example shows how create a new style. 
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


## See Also


#### Reference
<a href="T_iTin_Export_Model_CurrencyDataTypeModel">CurrencyDataTypeModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />