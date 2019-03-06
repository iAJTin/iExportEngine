# iTin.Export.ComponentModel.Writer Namespace
Additional header content 

\[Missing <summary> documentation for "N:iTin.Export.ComponentModel.Writer"\]


## Classes
&nbsp;<table><tr><th></th><th>Class</th><th>Description</th></tr><tr><td>![Public class](media/pubclass.gif "Public class")</td><td><a href="T_iTin_Export_ComponentModel_Writer_BaseWriter">BaseWriter</a></td><td>
Implements interface IWriter. Which acts as the base class for future writers based and not based on markup languages​​.</td></tr><tr><td>![Public class](media/pubclass.gif "Public class")</td><td><a href="T_iTin_Export_ComponentModel_Writer_BaseWriterDirect">BaseWriterDirect</a></td><td>
A Specialization of <a href="T_iTin_Export_ComponentModel_Writer_BaseWriter">BaseWriter</a> Class, than implements interface <a href="T_iTin_Export_ComponentModel_Writer_IWriterDirect">IWriterDirect</a>. Which acts as a base class for writers based or not based on markup languages​​, but the writer is based in a 3rd party library that controls lifecycle of file, such as <a href="http://epplus.codeplex.com/">EPPlus library</a>.</td></tr><tr><td>![Public class](media/pubclass.gif "Public class")</td><td><a href="T_iTin_Export_ComponentModel_Writer_BaseWriterStream">BaseWriterStream</a></td><td>
A Specialization of <a href="T_iTin_Export_ComponentModel_Writer_BaseWriter">BaseWriter</a> Class, than implements interface <a href="T_iTin_Export_ComponentModel_Writer_IWriterStream">IWriterStream</a>. Which acts as a base class for writers not based on markup languages​​, such as a writer for a binary file format.</td></tr><tr><td>![Public class](media/pubclass.gif "Public class")</td><td><a href="T_iTin_Export_ComponentModel_Writer_BaseWriterXml">BaseWriterXml</a></td><td>
A Specialization of <a href="T_iTin_Export_ComponentModel_Writer_BaseWriter">BaseWriter</a> Class, than implements interface <a href="T_iTin_Export_ComponentModel_Writer_IWriterXml">IWriterXml</a>. Which acts as the base class for future writers-based in markup languages​​.</td></tr><tr><td>![Public class](media/pubclass.gif "Public class")</td><td><a href="T_iTin_Export_ComponentModel_Writer_WriterOptionsAttribute">WriterOptionsAttribute</a></td><td>
Declares extra metadata to a writer. All writers created by <strong>iTin Export Engine</strong> are based in <a href="http://msdn.microsoft.com/es-es/library/dd460648.aspx">Managed Extensibility Framework <strong>(MEF)</strong></a>.</td></tr></table>

## Structures
&nbsp;<table><tr><th></th><th>Structure</th><th>Description</th></tr><tr><td>![Public structure](media/pubstructure.gif "Public structure")</td><td><a href="T_iTin_Export_ComponentModel_Writer_WriterOptionsMetadata">WriterOptionsMetadata</a></td><td>
Defines a value that contains the detailed information of a <a href="T_iTin_Export_ComponentModel_Writer_IWriter">IWriter</a>.</td></tr></table>

## Interfaces
&nbsp;<table><tr><th></th><th>Interface</th><th>Description</th></tr><tr><td>![Public interface](media/pubinterface.gif "Public interface")</td><td><a href="T_iTin_Export_ComponentModel_Writer_IWriter">IWriter</a></td><td>
Declares a generic writer.</td></tr><tr><td>![Public interface](media/pubinterface.gif "Public interface")</td><td><a href="T_iTin_Export_ComponentModel_Writer_IWriterDirect">IWriterDirect</a></td><td>
Declares a direct writer.</td></tr><tr><td>![Public interface](media/pubinterface.gif "Public interface")</td><td><a href="T_iTin_Export_ComponentModel_Writer_IWriterOptions">IWriterOptions</a></td><td>
Attribute that allows you to add extra metadata to a writer.</td></tr><tr><td>![Public interface](media/pubinterface.gif "Public interface")</td><td><a href="T_iTin_Export_ComponentModel_Writer_IWriterStream">IWriterStream</a></td><td>
Declares a writer which is non-based in an markup language.</td></tr><tr><td>![Public interface](media/pubinterface.gif "Public interface")</td><td><a href="T_iTin_Export_ComponentModel_Writer_IWriterXml">IWriterXml</a></td><td>
Declares a writer which is based in an markup language.</td></tr></table>

## Enumerations
&nbsp;<table><tr><th></th><th>Enumeration</th><th>Description</th></tr><tr><td>![Public enumeration](media/pubenumeration.gif "Public enumeration")</td><td><a href="T_iTin_Export_ComponentModel_Writer_KnownWriterIdentifier">KnownWriterIdentifier</a></td><td>
Known writer types</td></tr></table>&nbsp;
