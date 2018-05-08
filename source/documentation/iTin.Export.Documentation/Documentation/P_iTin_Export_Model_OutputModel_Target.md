# OutputModel.Target Property 
Additional header content 

Gets or sets a value that determines target operating system.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
public KnownOutputTarget Target { get; set; }
```

**VB**<br />
``` VB
Public Property Target As KnownOutputTarget
	Get
	Set
```


#### Property Value
Type: <a href="T_iTin_Export_Model_KnownOutputTarget">KnownOutputTarget</a><br />One of the <a href="T_iTin_Export_Model_KnownOutputTarget">KnownOutputTarget</a> values. The default is <a href="T_iTin_Export_Model_KnownOutputTarget">Windows</a>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td>InvalidEnumArgumentException</td><td>If specified value is outside the range of valid values.</td></tr></table>

## Remarks

**TEE Object Element Usage**<br />
``` XML
<Output Target="Windows|DOS|MacOS">
  ...
</Output>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td align="center">X</td><td align="center">X</td><td align="center">X</td><td align="center">No has effect</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


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
        <Writer Name="CsvWriter"/>
        <Behaviors>
          <Download/>
        </Behaviors>
      </Exporter>

      <Output Target="Windows">
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