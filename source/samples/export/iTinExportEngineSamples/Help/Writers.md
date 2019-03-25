# Samples Project (iTinExportEngineSamples)

## Writers samples

### 1. Comma-Separated Values [ csv ]

Using the native writer **CsvWriter**, allows you to create **.csv** files.

#### Sample1

Creates a simple inventory list.

![CSV sample 1 output][img1]

### 2. Markdown [ md ]

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

Equals **Sample1** and A Piechart.

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

Using the writer **DocxTabularWriter**, this writer requires **iTin.Export.Writers.OpenXml.Docx**. Allow you to create **.docx** files.

![Docx sample 1 output][img27]

#### Sample1

Equals to **EPPlus sample1**

### 5. Portable Document Format [ pdf ]

Using the writer **PdfTabularWriter**, this writer requires **iTin.Export.Writers.Adobe**. Allow you to create **.pdf** files.

#### Sample1

Equals to **EPPlus sample1**

![Pdf sample 1 output][img28]

### 6. SQL Script [ sql ]

Using the native writer **SqlScriptWriter**, allows you to create **.sql** files.

#### Sample1

Equals to **EPPlus sample1**

![Sql sample 1 output][img29]

### 7. Tab-Separated Values [ txt ]

Using the native writer **TsvWriter**, allows you to create **.txt** files.

#### Sample1

Equals to **CSV sample1**

![Txt sample 1 output][img30]

### 8. XML Spreadsheet 2003 [ xml ]

Using the native writer **Spreadsheet2003TabularWriter**, allows you to create **.xml** files.

#### Sample1

Equals to **EPPlus sample1**

![Xml Spreadsheet 2003 sample 1 output][img31]

[img1]: ./assets/writers/CSV_Sample01.png "CSV sample1 output"
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
[img28]: ./assets/writers/pdf_sample01.png "Pdf sample1 output"
[img29]: ./assets/writers/sql_sample01.png "Sql sample1 output"
[img30]: ./assets/writers/txt_sample01.png "Txt sample1 output"
[img31]: ./assets/writers/xml_spreadsheet_2003_sample01.png "Xml Sql sample1 output"

