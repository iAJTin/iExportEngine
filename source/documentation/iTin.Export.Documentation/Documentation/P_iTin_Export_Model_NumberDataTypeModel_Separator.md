# NumberDataTypeModel.Separator Property 
Additional header content 

Gets or sets a value indicating whether displays thousands separator.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public YesNo Separator { get; set; }
```

**VB**<br />
``` VB
Public Property Separator As YesNo
	Get
	Set
```


#### Property Value
Type: <a href="T_iTin_Export_Model_YesNo">YesNo</a><br /><a href="T_iTin_Export_Model_YesNo">Yes</a> if displays thousands separator; otherwise, <a href="T_iTin_Export_Model_YesNo">No</a>. The default is <a href="T_iTin_Export_Model_YesNo">No</a>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td>InvalidEnumArgumentException</td><td>The value specified is outside the range of valid values.</td></tr></table>

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Number Separator="Yes|No" ...>
...
</Number>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td align="center">X</td><td align="center">X</td><td align="center">X</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## Examples
In the following example shows how create a new style. 
**XML**<br />
``` XML
<Style Name="TopAggregate">
  <Content Color="#C9C9C9">
    <Alignment Horizontal="Center"/>
    <Number Decimals="0" Separator="Yes">
      <Negative Color="Yellow" Sign="Brackets"/>
      <Error Value="-9999">
        <Comment Show="Yes">
          <Text>Original value:  </Text>
          <Font Size="12" Color="Navy"/>
        </Comment>
      </Error>           
    </Number>
  </Content>
  <Font Name="Segoe UI" Size="12" Color="Navy" Bold="Yes"/>
</Style>
```


## See Also


#### Reference
<a href="T_iTin_Export_Model_NumberDataTypeModel">NumberDataTypeModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />