# ScientificDataTypeModel.Error Property 
Additional header content 

Gets or sets a reference that contains scientific data type error settings.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public ScientificErrorModel Error { get; set; }
```

**VB**<br />
``` VB
Public Property Error As ScientificErrorModel
	Get
	Set
```


#### Property Value
Type: <a href="T_iTin_Export_Model_ScientificErrorModel">ScientificErrorModel</a><br />Scientific data type error settings

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Scientific ...>
  <Error/>
</Number>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br /><a href="T_iTin_Export_Writers_CsvWriter">CsvWriter</a></th><th>Tab-Separated Values<br /><a href="T_iTin_Export_Writers_TsvWriter">TsvWriter</a></th><th>SQL Script<br /><a href="T_iTin_Export_Writers_SqlScriptWriter">SqlScriptWriter</a></th><th>XML Spreadsheet 2003<br /><a href="T_iTin_Export_Writers_Spreadsheet2003TabularWriter">Spreadsheet2003TabularWriter</a></th></tr><tr><td align="center">X</td><td align="center">X</td><td align="center">X</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## Examples

**XML**<br />
``` XML
<Style Name="Scientific">
  <Content Color="White">
    <Scientific Decimals="3">
      <Error Value="-9999">
        <Comment Show="Yes">
          <Text>Wrong value:  </Text>
        </Comment>
      </Error>           
    </Scientific>
  </Content>
</Style>
```


## See Also


#### Reference
<a href="T_iTin_Export_Model_ScientificDataTypeModel">ScientificDataTypeModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />