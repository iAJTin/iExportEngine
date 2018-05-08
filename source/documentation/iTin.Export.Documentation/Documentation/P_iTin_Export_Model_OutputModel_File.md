# OutputModel.File Property 
Additional header content 

Gets or sets the output file name without extension.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
public string File { get; set; }
```

**VB**<br />
``` VB
Public Property File As String
	Get
	Set
```


#### Property Value
Type: String<br />The output file name without extension.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td>ArgumentNullException</td><td>If *value* is <strong>null</strong>.</td></tr><tr><td><a href="T_iTin_Export_Model_InvalidFileNameException">InvalidFileNameException</a></td><td>If *value* is an invalid file name.</td></tr></table>

## Remarks

**TEE Object Element Usage**<br />
``` XML
<Output ...>
  <File>string</File>
  ...
</Output>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td align="center">X</td><td align="center">X</td><td align="center">X</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## Examples
The following example show how to use this element. 
**XML**<br />
``` XML
<?xml version="1.0" encoding="utf-8"?>

<Exports xmlns="http://schemas.iTin.com/export/engine/2013/configuration">
  <Export Name="Test" Current="Yes">
    <Description>Sample Export</Description>
    <Table Name="R740D01"
          AutoFilter="Yes"
          AutoFitColumns="Yes"
          Alias="Table alias">

      <Location>
        <ByCoordenates Coordenates="1 3"/>
      </Location>

      <Exporter>
        <Writer Name="Spreadsheet2003TabularWriter"/>
        <Behaviors>
          <Download/>
          <TransformFile Save="Yes"/>
        </Behaviors>
      </Exporter>

      <Output>
        <File>SampleExport</File>
        <Path>~\Samples\Output\Writers</Path>
      </Output>
      ...
      ...
    </Table>
  </Export>
</Exports>
```


## See Also


#### Reference
<a href="T_iTin_Export_Model_OutputModel">OutputModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />