# NumericDataTypeModel.Error Property 
Additional header content 

Gets or sets a reference that contains numeric data type error settings.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
public NumericErrorModel Error { get; set; }
```

**VB**<br />
``` VB
Public Property Error As NumericErrorModel
	Get
	Set
```


#### Property Value
Type: <a href="T_iTin_Export_Model_NumericErrorModel">NumericErrorModel</a><br />Numeric data type error settings

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Number ...>
  <Error/>
  ...
</Number>
```

- Or -

**ITEE Object Element Usage**<br />
``` XML
<Currency ...>
  <Error/>
  ...
</Currency>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td align="center">X</td><td align="center">X</td><td align="center">X</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## Examples
In the following example shows how create a new style with a currency data type. 
**XML**<br />
``` XML
<Style Name="AccountValue">
  <Content Color="Blue">
    <Currency Decimals="1" Locale="mk">
      <Negative Color="Red" Sign="Parenthesis">
      <Error Value="-1000">
        <Comment Show="Yes">
          <Text>Database value: </Text>
          <Font Size="12" Color="Navy"/>
        </Comment>
      </Error>
    </Currency>
  </Content>
  <Font Size="8" Color="White"/>
</Style>
```

Another example for the number data type.

**XML**<br />
``` XML
<Style Name="AccountValue">
  <Content Color="Blue">
    <Number Decimals="1">
      <Negative Color="Red" Sign="Parenthesis">
      <Error Value="99">
        <Comment Show="Yes">
          <Text>Wrong value: </Text>
        </Comment>
      </Error>
    </Currency>
  </Content>
  <Font Size="8" Color="White"/>
</Style>
```


## See Also


#### Reference
<a href="T_iTin_Export_Model_NumericDataTypeModel">NumericDataTypeModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />