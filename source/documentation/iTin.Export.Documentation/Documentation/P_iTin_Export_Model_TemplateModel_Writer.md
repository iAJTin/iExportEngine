# TemplateModel.Writer Property 
Additional header content 

Gets or sets the template writer used by the exporter.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public TemplateWriterModel Writer { get; set; }
```

**VB**<br />
``` VB
Public Property Writer As TemplateWriterModel
	Get
	Set
```


#### Property Value
Type: <a href="T_iTin_Export_Model_TemplateWriterModel">TemplateWriterModel</a><br />The template writer used by the exporter.

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Template>
  <Writer>
  ...
  </Writer>
</Template>
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
<a href="T_iTin_Export_Model_TemplateModel">TemplateModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />