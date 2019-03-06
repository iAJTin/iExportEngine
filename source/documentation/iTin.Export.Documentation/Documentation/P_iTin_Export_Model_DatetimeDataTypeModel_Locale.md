# DatetimeDataTypeModel.Locale Property 
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
<Datetime Locale="string" ...>
...
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