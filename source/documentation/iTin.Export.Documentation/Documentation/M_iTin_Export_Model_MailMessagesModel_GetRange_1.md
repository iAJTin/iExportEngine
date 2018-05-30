# MailMessagesModel.GetRange Method (IEnumerable(MailMessageModel), String)
Additional header content 

Returns an enumerator to message list containing only those who meet the credential condition.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
public static IEnumerable<MailMessageModel> GetRange(
	IEnumerable<MailMessageModel> messages,
	string credential
)
```

**VB**<br />
``` VB
Public Shared Function GetRange ( 
	messages As IEnumerable(Of MailMessageModel),
	credential As String
) As IEnumerable(Of MailMessageModel)
```


#### Parameters
&nbsp;<dl><dt>messages</dt><dd>Type: System.Collections.Generic.IEnumerable(<a href="T_iTin_Export_Model_MailMessageModel">MailMessageModel</a>)<br />Message List.</dd><dt>credential</dt><dd>Type: System.String<br />Server credential.</dd></dl>

#### Return Value
Type: IEnumerable(<a href="T_iTin_Export_Model_MailMessageModel">MailMessageModel</a>)<br />Enumerator that contains message list that meet the condition.

## Remarks
\[Missing <remarks> documentation for "M:iTin.Export.Model.MailMessagesModel.GetRange(System.Collections.Generic.IEnumerable{iTin.Export.Model.MailMessageModel},System.String)"\]

## See Also


#### Reference
<a href="T_iTin_Export_Model_MailMessagesModel">MailMessagesModel Class</a><br /><a href="Overload_iTin_Export_Model_MailMessagesModel_GetRange">GetRange Overload</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />