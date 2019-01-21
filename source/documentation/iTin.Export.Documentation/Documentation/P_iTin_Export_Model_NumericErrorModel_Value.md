# NumericErrorModel.Value Property 
Additional header content 

Gets or sets preferred default value when occurs an error.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public float Value { get; set; }
```

**VB**<br />
``` VB
Public Property Value As Single
	Get
	Set
```


#### Property Value
Type: Single<br />Preferred default value when occurs an error. The default is `0.0`.

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Error Value="float" ...>
  ...
</Error>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td align="center">X</td><td align="center">X</td><td align="center">X</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## Examples
In the following example shows how create a new style with a currency data type. 
**XML**<br />
``` XML
<Style Name="Account">
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
<a href="T_iTin_Export_Model_NumericErrorModel">NumericErrorModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />