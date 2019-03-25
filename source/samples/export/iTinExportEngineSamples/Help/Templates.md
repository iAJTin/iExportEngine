# Samples Project (iTinExportEngineSamples)

## Template samples

### 1. DocxTemplateSample01

   This sample generates several documents in **MS Word** format (one for each entry in the reference table) from a **.docx** document that acts as a template.

   Below are the steps to follow:

- **Template** (Uses DocxFreeTemplateWriter, a builtin template writer)

  Any document in **docx** format, where each field that we want to appear will be prefixed / suffixed (optional) with the characters we consider appropriate.

  _Input template_

  ![TemplateOutputFolder.png][img1]

- **Data input** (For simplicity an **xml** file has been used as input)

~~~xml
<?xml version="1.0" encoding="utf-8"?>
<ARD740>
  <R740D01 PERCENT="23.62" CMCUST="0028539"    CMNAME="FIBER CORPORATION           " CMADR1="34570 RANDOM DRIVE            " CMCITY="NEW LONDON          " CMZIP="28127 " />
  <R740D01 PERCENT="22.10" CMCUST="0322292"    CMNAME="FIBERLOCK TECH              " CMADR1="150 DASCOMB ROAD              " CMCITY="ANDOVER             " CMZIP="01810 " />
  <R740D01 PERCENT="23.67" CMCUST="-0206947"   CMNAME="FIBERTAK &quot;INC          " CMADR1="1180 N MT SPRINGS PKWY        " CMCITY="SPRINGVILLE         " CMZIP="84663 " />
  <R740D01 PERCENT="10.0"  CMCUST="0209192"    CMNAME="FIDELITY CONTAINER          " CMADR1="4039 ROCK QUARRY RD #400      " CMCITY="DALLAS              " CMZIP="75211 " />
  <R740D01 PERCENT="10.0"  CMCUST="0035841"    CMNAME="CONTAINER                   " CMADR1="240 MAIN STREET               " CMCITY="MARSEILLES          " CMZIP="61341 " />
  <R740D01 PERCENT="10.0"  CMCUST="0034802"    CMNAME="FIELDALE                    " CMADR1="5282 GAINESVILLE HIGHWAY      " CMCITY="BALDWIN             " CMZIP="30511 " />
  <R740D01 PERCENT="10.0"  CMCUST="0028839"    CMNAME="FIESTA WAREHOUSE &amp; DIST." CMADR1="5050 STOUT DRIVE              " CMCITY="SAN ANTONIO         " CMZIP="78219 " />
  <R740D01 PERCENT="10.0"  CMCUST="0033511"    CMNAME="FILM SALVAGE                " CMADR1="3575 NORTH HIGHWAY 91         " CMCITY="MOUNTAIN CITY       " CMZIP="37683 " />
  <R740D01 PERCENT="10.0"  CMCUST="zzz0916610" CMNAME="FILMTECH INCORP.            " CMADR1="581 MCDONALD AVENUE           " CMCITY="BROOKLYN            " CMZIP="11218 " />
  <R740D01 PERCENT="10.0"  CMCUST="0369019"    CMNAME="FINA OIL &amp; CHEMICAL CO  " CMADR1="2970 PARROTT AVE              " CMCITY="ATLANTA             " CMZIP="30318 " />
</ARD740>
~~~

- **Configuration file**

   The configuration file we should highlight the following elements/properties when working with templates.

   |Element| Decription|
   |:-|:-|
   |Template| Root node|
   |File| Define the file that acts as a template|
   |Writer| Determines which writer will be used to generate the output (I remind you that these writer can creates it to suit their own needs)|
   |Settings| Defines the prefix and suffix characters, as well as additional context properties|

~~~xml
<?xml version="1.0" encoding="utf-8"?>
<Exports xmlns="http://schemas.itin.com/export/engine/2014/configuration/v1.0">

  <Global.Resources>  
    <Hosts>
      <Host Key="docx"/>
    </Hosts>
  </Global.Resources>

  <Export Name="Sample01" Current="Yes">
    <Description>Generate docx files from word template file</Description>
    <Table Host="docx"
           Name="R740D01"
           Alias="Template Sample Export">
      <Exporter>
        <Template>
          <File>~\resources\input\template\DocxSampleTemplate.docx</File>
          <Writer Name="DocxFreeTemplateWriter">
            <Settings FieldPrefix="@@" TrimFields="Yes"/>             
          </Writer>
        </Template>
      </Exporter>
      <Output>
        <Path>~\output\template\docx\</Path>
        <File>sample01-from-template-file</File>
      </Output>
    </Table>
  </Export>
  
</Exports>
~~~

- **Code**

~~~C#
    ...
    ...

    var inputDataFile = new Uri(Settings.Default.PacketXmlInput, UriKind.Relative);
    var input = new XmlInput(inputDataFile);

    var configuration = new Uri(Settings.Default.DocxTemplateSample01Configuration, UriKind.Relative);
    input.Export(ExportSettings.ImportFrom(configuration));

    ...
    ...
~~~

- **Output**

  In the folder specified in the configuration file, as many files as entry elements will be created. 
  The name of each created file will be the same as the one indicated in the configuration file plus a sequential number that starts at 0.

  _Output folder_

  ![TemplateOutputFolder.png][img2]

  _First output file (sample01-from-template-file0.docx)_

  ![TemplateOutputFolder.png][img3]

  _Last output file (sample01-from-template-file9.docx))_

  ![TemplateOutputFolder.png][img4]

[img1]: ./assets/templates/DocxSampleTemplate.png "Template file"
[img2]: ./assets/templates/TemplateOutputFolder.png "Output folder"
[img3]: ./assets/templates/sample01-from-template-file0.png "First file (sample01-from-template-file0.docx)"
[img4]: ./assets/templates/sample01-from-template-file9.png "First file (sample01-from-template-file9.docx)"
