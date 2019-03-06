# BaseSimpleModelCollection(*TItem*, *TParent*).Insert Method 
Additional header content 

Inserts an item to the <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a> at the specified index.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public void Insert(
	int index,
	TItem item
)
```

**VB**<br />
``` VB
Public Sub Insert ( 
	index As Integer,
	item As TItem
)
```


#### Parameters
&nbsp;<dl><dt>index</dt><dd>Type: System.Int32<br />The zero-based index at which *item* should be inserted.</dd><dt>item</dt><dd>Type: <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">*TItem*</a><br />The object to insert. The value can be <strong>null</strong> for reference types.</dd></dl>

#### Implements
IList(T).Insert(Int32, T)<br />

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td>ArgumentOutOfRangeException</td><td>*index* is less than 0 - or - index is greater than <a href="P_iTin_Export_Model_BaseSimpleModelCollection_2_Count">Count</a>.</td></tr></table>

## Remarks
\[Missing <remarks> documentation for "M:iTin.Export.Model.BaseSimpleModelCollection`2.Insert(System.Int32,`0)"\]

## See Also


#### Reference
<a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent) Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />