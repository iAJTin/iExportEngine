# PercentageDataTypeModel.Error Property 
Additional header content 

Gets or sets a reference that contains percentage data type error settings.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public PercentageErrorModel Error { get; set; }
```

**VB**<br />
``` VB
Public Property Error As PercentageErrorModel
	Get
	Set
```


#### Property Value
Type: <a href="T_iTin_Export_Model_PercentageErrorModel">PercentageErrorModel</a><br />Percentage data type error settings

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Percentage ...>
  <Error/>
</Percentage>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br /><a href="T_iTin_Export_Writers_CsvWriter">CsvWriter</a></th><th>Tab-Separated Values<br /><a href="T_iTin_Export_Writers_TsvWriter">TsvWriter</a></th><th>SQL Script<br /><a href="T_iTin_Export_Writers_SqlScriptWriter">SqlScriptWriter</a></th><th>XML Spreadsheet 2003<br /><a href="T_iTin_Export_Writers_Spreadsheet2003TabularWriter">Spreadsheet2003TabularWriter</a></th></tr><tr><td align="center">X</td><td align="center">X</td><td align="center">X</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## Examples
In the following example shows how create a new style with a percentage data type. 
**XML**<br />
``` XML
<Style Name="PercentValue">
  <Content Color="Blue">
    <Percentage Decimals="1">
      <Error Value="0">
        <Comment Show="Yes">
          <Font Name="Comic Sans MS" Size="16" Bold="Yes" Italic="Yes" Underline="Yes" Color="Navy"/>
        </Comment>
      </Error>
    </Percentage>
  </Content>
</Style>
```


## See Also


#### Reference
<a href="T_iTin_Export_Model_PercentageDataTypeModel">PercentageDataTypeModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />