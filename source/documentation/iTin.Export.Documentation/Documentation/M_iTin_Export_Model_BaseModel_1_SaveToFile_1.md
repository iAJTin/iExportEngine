# BaseModel(*T*).SaveToFile Method (String, Exception)
Additional header content 

Serializes current BaseModel object into file

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public virtual bool SaveToFile(
	string fileName,
	out Exception exception
)
```

**VB**<br />
``` VB
Public Overridable Function SaveToFile ( 
	fileName As String,
	<OutAttribute> ByRef exception As Exception
) As Boolean
```


#### Parameters
&nbsp;<dl><dt>fileName</dt><dd>Type: System.String<br />Full path of output Xml file</dd><dt>exception</dt><dd>Type: System.Exception<br />Output Exception value if failed</dd></dl>

#### Return Value
Type: Boolean<br /><strong>true</strong> if can serialize and save into file; otherwise, <strong>false</strong>.

## Remarks
\[Missing <remarks> documentation for "M:iTin.Export.Model.BaseModel`1.SaveToFile(System.String,System.Exception@)"\]

## See Also


#### Reference
<a href="T_iTin_Export_Model_BaseModel_1">BaseModel(T) Class</a><br /><a href="Overload_iTin_Export_Model_BaseModel_1_SaveToFile">SaveToFile Overload</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />