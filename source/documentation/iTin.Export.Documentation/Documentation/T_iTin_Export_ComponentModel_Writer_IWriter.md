# IWriter Interface
Additional header content 

Declares a generic writer.

**Namespace:**&nbsp;<a href="N_iTin_Export_ComponentModel_Writer">iTin.Export.ComponentModel.Writer</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
public interface IWriter : IDisposable
```

**VB**<br />
``` VB
Public Interface IWriter
	Inherits IDisposable
```

The IWriter type exposes the following members.


## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_ComponentModel_Writer_IWriter_IsTransformationFile">IsTransformationFile</a></td><td>
Gets a value indicating whether this writer generates a transformation file to be processed later.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_ComponentModel_Writer_IWriter_Provider">Provider</a></td><td>
Gets or sets a reference to provider to export.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_ComponentModel_Writer_IWriter_ResponseEx">ResponseEx</a></td><td>
Gets a reference to an object HttpResponseEx containing the <strong>MIME</strong> type of the output stream and response header for a <strong>ASP.NET</strong> operation.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_ComponentModel_Writer_IWriter_Stream">Stream</a></td><td>
Gets a reference to writer's stream.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_ComponentModel_Writer_IWriter_TransformFileExtension">TransformFileExtension</a></td><td>
Gets the transform file extension.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_ComponentModel_Writer_IWriter_WriterIdentifier">WriterIdentifier</a></td><td>
Gets a value than identifies the type of writer.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_iTin_Export_ComponentModel_Writer_IWriter_WriterMetadata">WriterMetadata</a></td><td>
Gets a reference that contains extended information of this writer.</td></tr></table>&nbsp;
<a href="#iwriter-interface">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>Dispose</td><td> (Inherited from IDisposable.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_ComponentModel_Writer_IWriter_Generate">Generate</a></td><td>
Generates output in the format supported by each specialized class.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_iTin_Export_ComponentModel_Writer_IWriter_GetAsByteArrayEnumerable">GetAsByteArrayEnumerable</a></td><td>
Returns the writer result file as a enumeration of byte array</td></tr></table>&nbsp;
<a href="#iwriter-interface">Back to Top</a>

## Remarks
\[Missing <remarks> documentation for "T:iTin.Export.ComponentModel.Writer.IWriter"\]

## See Also


#### Reference
<a href="N_iTin_Export_ComponentModel_Writer">iTin.Export.ComponentModel.Writer Namespace</a><br />