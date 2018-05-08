# BaseSimpleModelCollection(*TItem*, *TParent*).RemoveAt Method 
Additional header content 

Removes the element at the specified index of the <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
public void RemoveAt(
	int index
)
```

**VB**<br />
``` VB
Public Sub RemoveAt ( 
	index As Integer
)
```


#### Parameters
&nbsp;<dl><dt>index</dt><dd>Type: System.Int32<br />The zero-based index of the element to remove.</dd></dl>

#### Implements
IList(T).RemoveAt(Int32)<br />

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td>ArgumentOutOfRangeException</td><td>*index* is less than 0 - or - index is greater than <a href="P_iTin_Export_Model_BaseSimpleModelCollection_2_Count">Count</a>.</td></tr></table>

## Remarks
\[Missing <remarks> documentation for "M:iTin.Export.Model.BaseSimpleModelCollection`2.RemoveAt(System.Int32)"\]

## See Also


#### Reference
<a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent) Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />