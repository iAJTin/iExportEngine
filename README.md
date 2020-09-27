<p align="center">
  <img src="https://cdn.rawgit.com/iAJTin/iExportEngine/master/nuget/iTin.Export.png"  
       height="32">
</p>
<p align="center">
  <a href="https://github.com/iAJTin/iExportEngine">
    <img src="https://img.shields.io/badge/iTin-iExportEngine-green.svg?style=flat"/>
  </a>
</p>

***

# What is iExportEngine?

iTin Export Engine (ITEE) is a standalone engine for data export that allows developers use a modular system based in Managed Extensibility Framework (MEF).

You can export easily data from XML, DataSets, typed ArrayList, DataRow array inputs by native/custom writers to MSExcel, Comma-Separated Values (csv), Tab-Separated Values (txt), SQL Script (sql), XML Spreadsheet 2003 (xml), Portable Document Format (pdf), MS Excel (xlsx), MS Word (docx), using an XML configuration file.

# Install via NuGet

- From nuget gallery

<table>
  <tr>
    <td>
      <a href="https://github.com/iAJTin/iExportEngine/tree/master/source/library/iTin.Export.Core">
        <img src="https://img.shields.io/badge/-iTin.Export.Core-green.svg?style=flat"/>
      </a>
    </td>
    <td>
      <a href="https://www.nuget.org/packages/iTin.Export.Core/">
        <img alt="NuGet Version" 
             src="https://img.shields.io/nuget/v/iTin.Export.Core.svg" /> 
      </a>
    </td>  
  </tr>
  <tr>
    <td>
      <a href="https://github.com/iAJTin/iExportEngine/tree/master/source/library/iTin.Export.Writers.Adobe">
        <img src="https://img.shields.io/badge/-iTin.Export.Writers.Adobe-green.svg?style=flat" />
      </a>
    </td>
    <td>
      <a href="https://www.nuget.org/packages/iTin.Export.Writers.Adobe/">
        <img alt="NuGet Version" src="https://img.shields.io/nuget/v/iTin.Export.Writers.Adobe.svg" />
      </a>
    </td>
  </tr>
  <tr>
    <td>
      <a href="https://github.com/iAJTin/iExportEngine/tree/master/source/library/iTin.Export.Writers.OpenXml.Xlsx">
        <img src="https://img.shields.io/badge/-iTin.Export.Writers.OpenXml.Xlsx-green.svg?style=flat" />
      </a>
    </td>
    <td>
      <a href="https://www.nuget.org/packages/iTin.Export.Writers.OpenXml.Xlsx/">
        <img alt="NuGet Version" src="https://img.shields.io/nuget/v/iTin.Export.Writers.OpenXml.Xlsx.svg" />
      </a>
    </td>
  </tr>
  <tr>
    <td>
      <a href="https://github.com/iAJTin/iExportEngine/tree/master/source/library/iTin.Export.Writers.OpenXml.DocX">
        <img src="https://img.shields.io/badge/-iTin.Export.Writers.OpenXml.DocX-green.svg?style=flat" />
      </a>
    </td>
    <td>
      <a href="https://www.nuget.org/packages/iTin.Export.Writers.OpenXml.DocX/">
        <img alt="NuGet Version" src="https://img.shields.io/nuget/v/iTin.Export.Writers.OpenXml.DocX.svg" /> 
      </a>
    </td>
  </tr>
</table>

- From package manager console

```PM> Install-Package iTin.Export.Core```


```PM> Install-Package iTin.Export.Writers.Adobe```


```PM> Install-Package iTin.Export.Writers.OpenXml.Xlsx```


```PM> Install-Package iTin.Export.Writers.OpenXml.DocX```

# Samples Project (iTinExportEngineSamples)

## Writers samples

### 1. Comma-Separated Values [ csv ]

Using the native writer **CsvWriter**, allows you to create **.csv** files.

#### Sample1

Creates a simple inventory list.

 - Text View
![CSV sample 1 output][img0]

 - MS Excel View
![CSV sample 1 output][img1]

### 2. Markdown [ md ]

Currently the development is in progress..., a small example of fully functional use is shown.

Using the native writer **MarkdownWriter**, allows you to create **.md** files.

#### Sample1

Creates a simple inventory list.

![Markdown sample 1 output][img2]

#### Sample2

Creates a large customer list.

![Markdown sample 2 output][img3]

### 3. MS Excel [ xlsx ]

Using the writer **XlsxTabularWriter**, this writer requires **iTin.Export.Writers.OpenXml.Xlsx**. Allow you to create **.xlsx** files.

#### - EPPlus

#### Sample1

Simply Creates A New Workbook From Scratch. The Workbook Contains One Worksheet With A Simple Invertory List.

![EPPlus sample 1 output][img4]

#### Sample1 (From code)

Same as **Sample1** but by code.

![EPPlus sample 1 from code output][img5]

#### Sample2

Equals **Sample1** and a Piechart.

![EPPlus sample 2 output][img6]

#### Sample3

Use Stacked Charts.

![EPPlus sample 3 output][img7]

#### Sample4

Use charts with more than one chart type and secondary axis.

![EPPlus sample 4 output][img8]

#### Sample5

Use Pivot Tables (comming soon...)

#### Sample6

Use Mini Charts.

![EPPlus sample 6 output][img10]

#### Sample7

Creates a new workbook from custom enumerated data type (5000 rows).

![EPPlus sample 7 output][img11]

#### Sample8

Create a spreadsheet but where only the headers are shown.

![EPPlus sample 8 output][img12]

#### Sample9

Create a spreadsheet where the value of a field is not displayed.

![EPPlus sample 9 output][img13]

### - ExportEngine

#### Sample1

Equals to **EPPlus sample1** with an image banner with effects and custom data table location.

![ExportEngine sample 1 output][img14]

#### Sample2

How to use group fields, Creates a new customer field.

![ExportEngine sample 2 output][img15]

#### Sample3

How to creates a column header fields.

![ExportEngine sample 3 output][img16]

#### Sample4

Sample with groups, headers, banner and aggregate's functions.

![ExportEngine sample 4 output][img17]

#### Sample5

How to use simple filters.

![ExportEngine sample 5 output][img18]

#### Sample6

How to use conditions.

![ExportEngine sample 6 output][img19]

#### Sample7

How to add block lines.

![ExportEngine sample 7 output][img20]

#### Sample8

How to use gap field type.

![ExportEngine sample 8 output][img21]

#### Sample9

How to use fixed width field type.

![ExportEngine sample 9 output][img22]

#### Sample10

How to use binded functions.

![ExportEngine sample 10 output][img23]

#### Sample11

Custom output filename.

![ExportEngine sample 11 output][img24]

#### Sample12

Custom output filename from binding.

![ExportEngine sample 12 output][img25]

#### Sample13

How to change the width of the fields.

![ExportEngine sample 13 output][img26]

### 4. MS Word [ docx ]

Currently the development is in progress..., a small example of fully functional use is shown.

Using the writer **DocxTabularWriter**, this writer requires **iTin.Export.Writers.OpenXml.Docx**. Allow you to create **.docx** files.

![Docx sample 1 output][img27]

#### Sample1

Equals to **EPPlus sample1**

### 5. Portable Document Format [ pdf ]

Currently the development is in progress..., a small example of fully functional use is shown.

Using the writer **PdfTabularWriter**, this writer requires **iTin.Export.Writers.Adobe**. Allow you to create **.pdf** files.

#### Sample1

Equals to **EPPlus sample1**

![Pdf sample 1 output][img28]

### 6. SQL Script [ sql ]

Currently the development is in progress..., a small example of fully functional use is shown.

Using the native writer **SqlScriptWriter**, allows you to create **.sql** files.

#### Sample1

Equals to **EPPlus sample1**

![Sql sample 1 output][img29]

### 7. Tab-Separated Values [ txt ]

Using the native writer **TsvWriter**, allows you to create **.txt** files.

#### Sample1

Equals to **CSV sample1**

- Text View
![Txt sample 1 output][img30]

- MS Excel View
![Txt sample 1 output][img31]

### 8. XML Spreadsheet 2003 [ xml ]

Currently the development is in progress..., a small example of fully functional use is shown.

Using the native writer **Spreadsheet2003TabularWriter**, allows you to create **.xml** files.

#### Sample1

Equals to **EPPlus sample1**

![Xml Spreadsheet 2003 sample 1 output][img32]


## Template samples

### 1. DocxTemplateSample01

   This sample generates several documents in **MS Word** format (one for each entry in the reference table) from a **.docx** document that acts as a template.

   Below are the steps to follow:

- **Template** (Uses DocxFreeTemplateWriter, a builtin template writer)

  Any document in **docx** format, where each field that we want to appear will be prefixed / suffixed (optional) with the characters we consider appropriate.

  _Input template_

  ![TemplateOutputFolder.png][img50]

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

  ![TemplateOutputFolder.png][img51]

  _First output file (sample01-from-template-file0.docx)_

  ![TemplateOutputFolder.png][img52]

  _Last output file (sample01-from-template-file9.docx))_

  ![TemplateOutputFolder.png][img53]

# How can I send feedback!!!

If you have found **iExportEngine** useful at work or in a personal project, I would love to hear about it. If you have decided not to use **iExportEngine**, please send me and email stating why this is so. I will use this feedback to improve **iExportEngine** in future releases.

My email address is 

![email.png][email] 

[img0]: ./assets/writers/csv_sample01.png "csv sample1 output"
[img1]: ./assets/writers/csv_excel_view_sample01.png "MS Excel view sample1 output"
[img2]: ./assets/writers/md_Sample01.png "Markdown sample1 output"
[img3]: ./assets/writers/md_Sample02.png "Markdown sample2 output"
[img4]: ./assets/writers/xlsx_epplus_Sample01.png "EPPlus sample1 output"
[img5]: ./assets/writers/xlsx_epplus_Sample01_Code.png "EPPlus sample1 from code output"
[img6]: ./assets/writers/xlsx_epplus_Sample02.png "EPPlus sample2 output"
[img7]: ./assets/writers/xlsx_epplus_Sample03.png "EPPlus sample3 output"
[img8]: ./assets/writers/xlsx_epplus_Sample04.png "EPPlus sample4 output"
[img9]: ./assets/writers/xlsx_epplus_Sample05.png "EPPlus sample5 output"
[img10]: ./assets/writers/xlsx_epplus_Sample06.png "EPPlus sample6 output"
[img11]: ./assets/writers/xlsx_epplus_Sample07.png "EPPlus sample7 output"
[img12]: ./assets/writers/xlsx_epplus_Sample08.png "EPPlus sample8 output"
[img13]: ./assets/writers/xlsx_epplus_Sample09.png "EPPlus sample9 output"
[img14]: ./assets/writers/xlsx_exportengine_sample01.png "ExportEngine sample1 output"
[img15]: ./assets/writers/xlsx_exportengine_sample02.png "ExportEngine sample2 output"
[img16]: ./assets/writers/xlsx_exportengine_sample03.png "ExportEngine sample3 output"
[img17]: ./assets/writers/xlsx_exportengine_sample04.png "ExportEngine sample4 output"
[img18]: ./assets/writers/xlsx_exportengine_sample05.png "ExportEngine sample5 output"
[img19]: ./assets/writers/xlsx_exportengine_sample06.png "ExportEngine sample6 output"
[img20]: ./assets/writers/xlsx_exportengine_sample07.png "ExportEngine sample7 output"
[img21]: ./assets/writers/xlsx_exportengine_sample08.png "ExportEngine sample8 output"
[img22]: ./assets/writers/xlsx_exportengine_sample09.png "ExportEngine sample9 output"
[img23]: ./assets/writers/xlsx_exportengine_sample10.png "ExportEngine sample10 output"
[img24]: ./assets/writers/xlsx_exportengine_sample11.png "ExportEngine sample11 output"
[img25]: ./assets/writers/xlsx_exportengine_sample12.png "ExportEngine sample12 output"
[img26]: ./assets/writers/xlsx_exportengine_sample13.png "ExportEngine sample13 output"
[img27]: ./assets/writers/docx_sample01.png "Docx sample1 output"
[img28]: ./assets/writers/pdf_sample01.png "pdf sample1 output"
[img29]: ./assets/writers/sql_sample01.png "sql sample1 output"
[img30]: ./assets/writers/txt_sample01.png "txt sample1 output"
[img31]: ./assets/writers/txt_excel_view_sample01.png "MS Excel view sample1 output"
[img32]: ./assets/writers/xml_spreadsheet_2003_sample01.png "xml sample1 output"
[img50]: ./assets/templates/DocxSampleTemplate.png "Input template file"
[img51]: ./assets/templates/TemplateOutputFolder.png "Output folder"
[img52]: ./assets/templates/sample01-from-template-file0.png "First file (sample01-from-template-file0.docx)"
[img53]: ./assets/templates/sample01-from-template-file9.png "First file (sample01-from-template-file9.docx)"

[email]: ./assets/email.png "email"
