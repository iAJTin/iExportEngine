# XsltModel.File Property 
Additional header content 

Gets or sets the xslt file. To specify a relative path use the character (~).

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

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
Type: String<br />The xslt file. To specify a relative path use the character (~).

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td>ArgumentNullException</td><td>If *value* is <strong>null</strong>.</td></tr><tr><td><a href="T_iTin_Export_Model_InvalidPathNameException">InvalidPathNameException</a></td><td>If *value* is an invalid path name.</td></tr></table>

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Xslt>
  <File>string</Path>
</Xslt>
```


## Examples
The following example show how to use this element. 
**XML**<br />
``` XML
<?xml version="1.0" encoding="utf-8"?>

<Exports xmlns="http://schemas.iTin.com/export/engine/2013/configuration">
  <Export Name="Test" Current="Yes">
    <Description>Sample Export</Description>
    <Table Name="R740D01">
      <Exporter>
        <Xslt/>
          <File>~\Templates\TransformFile.xslt</File>
        </Xslt>
      </Exporter>

      <Output>
        <File>SampleExport</File>
        <Path>~\Samples\Output\Writers</Path>
      </Output>
    </Table>
  </Export>
</Exports>
```


## See Also


#### Reference
<a href="T_iTin_Export_Model_XsltModel">XsltModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />