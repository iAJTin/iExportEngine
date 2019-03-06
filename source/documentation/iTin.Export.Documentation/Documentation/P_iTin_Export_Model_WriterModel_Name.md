# WriterModel.Name Property 
Additional header content 

Gets or sets the name of the writer.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public string Name { get; set; }
```

**VB**<br />
``` VB
Public Property Name As String
	Get
	Set
```


#### Property Value
Type: String<br />Name of the writer. Select from the list or create your own and use it.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td>ArgumentNullException</td><td>If *value* is <strong>null</strong>.</td></tr><tr><td><a href="T_iTin_Export_Model_InvalidIdentifierNameException">InvalidIdentifierNameException</a></td><td>If *value* not is a valid identifier.</td></tr></table>

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Writer Name="string">
...
</Writer>
```

The following table shows the different custom writers.
&nbsp;<table><tr><th>Writer</th><th>Description</th></tr><tr><td><a href="T_iTin_Export_Writers_CsvWriter">CsvWriter</a></td><td>CSV (comma-delimited) (*.csv). In iTin.Export assembly</td></tr><tr><td><a href="T_iTin_Export_Writers_TsvWriter">TsvWriter</a></td><td>Text (tab-delimited) (*.txt). In iTin.Export assembly</td></tr><tr><td><a href="T_iTin_Export_Writers_SqlScriptWriter">SqlScriptWriter</a></td><td>SQL Script (*.sql). In iTin.Export assembly</td></tr><tr><td><a href="T_iTin_Export_Writers_Spreadsheet2003TabularWriter">Spreadsheet2003TabularWriter</a></td><td>XML Spreadsheet 2003 (*.xml) in iTin.Export assembly</td></tr><tr><td>XlsTabularWriter</td><td>MS Excel Workbook (*.xls). Requires iTin.Export.Writers.Microsoft assembly</td></tr><tr><td>XlsxTabularWriter</td><td>MS Excel Workbook (*.xlsx). Requires iTin.Export.Writers.OpenXML assembly</td></tr><tr><td>DocxTabularWriter</td><td>MS Word Document (*.docx). Requires iTin.Export.Writers.OpenXML assembly</td></tr></table>&nbsp;
The following table shows the different template custom writers.
&nbsp;<table><tr><th>Template writer</th><th>Description</th></tr><tr><td>WordFreeTemplateWriter</td><td>MS Word Document (*.docx). Requires iTin.Export.Writers.OpenXML assembly.</td></tr></table>

## See Also


#### Reference
<a href="T_iTin_Export_Model_WriterModel">WriterModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />