# TemplateWriterModel.Settings Property 
Additional header content 

Gets or sets a reference to the settings defined for this writer.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public TemplateWriterSettingsModel Settings { get; set; }
```

**VB**<br />
``` VB
Public Property Settings As TemplateWriterSettingsModel
	Get
	Set
```


#### Property Value
Type: <a href="T_iTin_Export_Model_TemplateWriterSettingsModel">TemplateWriterSettingsModel</a><br />Reference to the settings defined for this writer.

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Writer>
  <Settings/>
<Writer/>
```


## Examples
The following example shows how to use this element. 
**XML**<br />
``` XML
<?xml version="1.0" encoding="utf-8"?>

<Exports xmlns="http://schemas.iTin.com/export/engine/2013/configuration">
  <Export Name="Test" Current="Yes">
    <Description>Sample Export</Description>
    <Table Name="R740D01">
      <Exporter>
        <Template>
          <File>~\Samples\Input\Doc Templates\DocxSampleTemplate.docx</File>
          <Writer Name="DocxFreeTemplateWriter">
            <Settings FieldPrefix="@@" TrimFields="Yes"/>
          </Writer>
        </Template>
        <Behaviors>
          <Download/>
        </Behaviors>
      </Exporter>
      <Output>
        <File>SampleTemplate</File>
        <Path>~\Samples\Output\Templates</Path>
      </Output>
    </Table>
  </Export>
</Exports>
```


## See Also


#### Reference
<a href="T_iTin_Export_Model_TemplateWriterModel">TemplateWriterModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />