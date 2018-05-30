# Spreadsheet2003TabularWriter Class
Additional header content 

Represents a custom XML Spreadsheet 2003 tabular writer.


## Inheritance Hierarchy
System.Object<br />&nbsp;&nbsp;<a href="T_iTin_Export_ComponentModel_Writer_BaseWriter">iTin.Export.ComponentModel.Writer.BaseWriter</a><br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_iTin_Export_ComponentModel_Writer_BaseWriterXml">iTin.Export.ComponentModel.Writer.BaseWriterXml</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;iTin.Export.Writers.Spreadsheet2003TabularWriter<br />
**Namespace:**&nbsp;<a href="N_iTin_Export_Writers">iTin.Export.Writers</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
public class Spreadsheet2003TabularWriter : BaseWriterXml
```

**VB**<br />
``` VB
Public Class Spreadsheet2003TabularWriter
	Inherits BaseWriterXml
```

The Spreadsheet2003TabularWriter type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_Writers_Spreadsheet2003TabularWriter__ctor">Spreadsheet2003TabularWriter</a></td><td>
Initializes a new instance of the Spreadsheet2003TabularWriter class</td></tr></table>&nbsp;
<a href="#spreadsheet2003tabularwriter-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Writers_Spreadsheet2003TabularWriter_Host">Host</a></td><td>
Gets a reference to the current host model.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Writers_Spreadsheet2003TabularWriter_IsTransformationFile">IsTransformationFile</a></td><td>
Gets a value indicating that this writer generates a transformation file to be processed later.
 (Overrides <a href="P_iTin_Export_ComponentModel_Writer_BaseWriter_IsTransformationFile">BaseWriter.IsTransformationFile</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_ComponentModel_Writer_BaseWriter_Provider">Provider</a></td><td>
Gets or sets a reference to provider for export.
 (Inherited from <a href="T_iTin_Export_ComponentModel_Writer_BaseWriter">BaseWriter</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_Writers_Spreadsheet2003TabularWriter_ResponseEx">ResponseEx</a></td><td>
Gets a reference to an object HttpResponseEx than contains the <strong>MIME</strong> type of the output stream and response header for a <strong>ASP.NET</strong> operation.
 (Overrides <a href="P_iTin_Export_ComponentModel_Writer_BaseWriter_ResponseEx">BaseWriter.ResponseEx</a>.)</td></tr><tr><td>![Protected property](media/protproperty.gif "Protected property")</td><td><a href="P_iTin_Export_ComponentModel_Writer_BaseWriter_Result">Result</a></td><td>
Gets enumerable of byte array containing data info.
 (Inherited from <a href="T_iTin_Export_ComponentModel_Writer_BaseWriter">BaseWriter</a>.)</td></tr><tr><td>![Protected property](media/protproperty.gif "Protected property")</td><td><a href="P_iTin_Export_ComponentModel_Writer_BaseWriterXml_Service">Service</a></td><td>
Gets a reference to service render.
 (Inherited from <a href="T_iTin_Export_ComponentModel_Writer_BaseWriterXml">BaseWriterXml</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_ComponentModel_Writer_BaseWriter_Stream">Stream</a></td><td>
Gets a reference to writer's stream.
 (Inherited from <a href="T_iTin_Export_ComponentModel_Writer_BaseWriter">BaseWriter</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_ComponentModel_Writer_BaseWriter_TransformFileExtension">TransformFileExtension</a></td><td>
Gets the transform file extension.
 (Inherited from <a href="T_iTin_Export_ComponentModel_Writer_BaseWriter">BaseWriter</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_ComponentModel_Writer_BaseWriterXml_Writer">Writer</a></td><td>
Gets a reference to based writer for markup languages​​.
 (Inherited from <a href="T_iTin_Export_ComponentModel_Writer_BaseWriterXml">BaseWriterXml</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_ComponentModel_Writer_BaseWriterXml_WriterIdentifier">WriterIdentifier</a></td><td>
Gets a value than identifies the type of writer.
 (Inherited from <a href="T_iTin_Export_ComponentModel_Writer_BaseWriterXml">BaseWriterXml</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_ComponentModel_Writer_BaseWriter_WriterMetadata">WriterMetadata</a></td><td>
Gets a reference that contains the extended information about this writer.
 (Inherited from <a href="T_iTin_Export_ComponentModel_Writer_BaseWriter">BaseWriter</a>.)</td></tr></table>&nbsp;
<a href="#spreadsheet2003tabularwriter-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_ComponentModel_Writer_BaseWriterXml_CreateWriter">CreateWriter</a></td><td>
Creates a new writer for markup languages.
 (Inherited from <a href="T_iTin_Export_ComponentModel_Writer_BaseWriterXml">BaseWriterXml</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_ComponentModel_Writer_BaseWriter_Dispose">Dispose</a></td><td>
Implement IDisposable. Clean managed and unmanaged resources.
 (Inherited from <a href="T_iTin_Export_ComponentModel_Writer_BaseWriter">BaseWriter</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>Equals</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_Writers_Spreadsheet2003TabularWriter_Execute">Execute</a></td><td>
Generates output in MS Excel format.
 (Overrides <a href="M_iTin_Export_ComponentModel_Writer_BaseWriter_Execute">BaseWriter.Execute()</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>Finalize</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_ComponentModel_Writer_BaseWriter_Generate">Generate</a></td><td>
Generates writer output.
 (Inherited from <a href="T_iTin_Export_ComponentModel_Writer_BaseWriter">BaseWriter</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_ComponentModel_Writer_BaseWriterXml_GetAsByteArrayEnumerable">GetAsByteArrayEnumerable</a></td><td>
Returns the writer result file as a enumeration of byte array
 (Inherited from <a href="T_iTin_Export_ComponentModel_Writer_BaseWriterXml">BaseWriterXml</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetHashCode</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetType</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>MemberwiseClone</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_ComponentModel_Writer_BaseWriterXml_ReleaseManagedResources">ReleaseManagedResources</a></td><td>
Releasing managed resources.
 (Inherited from <a href="T_iTin_Export_ComponentModel_Writer_BaseWriterXml">BaseWriterXml</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_iTin_Export_ComponentModel_Writer_BaseWriter_ReleaseUnmanagedResources">ReleaseUnmanagedResources</a></td><td>
Releasing unmanaged resources.
 (Inherited from <a href="T_iTin_Export_ComponentModel_Writer_BaseWriter">BaseWriter</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>ToString</td><td> (Inherited from Object.)</td></tr></table>&nbsp;
<a href="#spreadsheet2003tabularwriter-class">Back to Top</a>

## Remarks
\[Missing <remarks> documentation for "T:iTin.Export.Writers.Spreadsheet2003TabularWriter"\]

## See Also


#### Reference
<a href="N_iTin_Export_Writers">iTin.Export.Writers Namespace</a><br />