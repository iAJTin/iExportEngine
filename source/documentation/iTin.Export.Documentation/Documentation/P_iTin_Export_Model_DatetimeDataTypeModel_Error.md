# DatetimeDataTypeModel.Error Property 
Additional header content 

Gets or sets a reference that contains datetime data type error settings.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public DatetimeErrorModel Error { get; set; }
```

**VB**<br />
``` VB
Public Property Error As DatetimeErrorModel
	Get
	Set
```


#### Property Value
Type: <a href="T_iTin_Export_Model_DatetimeErrorModel">DatetimeErrorModel</a><br />Datetime data type error settings

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Datetime ...>
  <Error/>
</Datetime>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br /><a href="T_iTin_Export_Writers_CsvWriter">CsvWriter</a></th><th>Tab-Separated Values<br /><a href="T_iTin_Export_Writers_TsvWriter">TsvWriter</a></th><th>SQL Script<br /><a href="T_iTin_Export_Writers_SqlScriptWriter">SqlScriptWriter</a></th><th>XML Spreadsheet 2003<br /><a href="T_iTin_Export_Writers_Spreadsheet2003TabularWriter">Spreadsheet2003TabularWriter</a></th></tr><tr><td align="center">X</td><td align="center">X</td><td align="center">X</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## Examples
The following example indicate that the content should be datetime data type. 
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
<a href="T_iTin_Export_Model_DatetimeDataTypeModel">DatetimeDataTypeModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />