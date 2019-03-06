# BaseErrorModel.Comment Property 
Additional header content 

Gets or sets a reference that contains the error comment.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public CommentModel Comment { get; set; }
```

**VB**<br />
``` VB
Public Property Comment As CommentModel
	Get
	Set
```


#### Property Value
Type: <a href="T_iTin_Export_Model_CommentModel">CommentModel</a><br />The error comment.

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Comment>
  <Text/>
  <Font/>
</Comment>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br /><a href="T_iTin_Export_Writers_CsvWriter">CsvWriter</a></th><th>Tab-Separated Values<br /><a href="T_iTin_Export_Writers_TsvWriter">TsvWriter</a></th><th>SQL Script<br /><a href="T_iTin_Export_Writers_SqlScriptWriter">SqlScriptWriter</a></th><th>XML Spreadsheet 2003<br /><a href="T_iTin_Export_Writers_Spreadsheet2003TabularWriter">Spreadsheet2003TabularWriter</a></th></tr><tr><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">No has effect</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


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
<a href="T_iTin_Export_Model_BaseErrorModel">BaseErrorModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />