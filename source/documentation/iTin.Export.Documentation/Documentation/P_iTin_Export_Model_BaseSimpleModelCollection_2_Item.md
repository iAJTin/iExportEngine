# BaseSimpleModelCollection(*TItem*, *TParent*).Item Property 
Additional header content 

Gets or sets the element at the specified index.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public TItem this[
	int index
] { get; set; }
```

**VB**<br />
``` VB
Public Default Property Item ( 
	index As Integer
) As TItem
	Get
	Set
```


#### Parameters
&nbsp;<dl><dt>index</dt><dd>Type: System.Int32<br />Zero-based index of the element to get or set.</dd></dl>

#### Property Value
Type: <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">*TItem*</a><br />Item at the specified index.

#### Return Value
Type: <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">*TItem*</a><br />the value

#### Implements
IList(T).Item(Int32)<br />

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td>ArgumentOutOfRangeException</td><td>*index* is not a valid index for <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.</td></tr><tr><td>NotSupportedException</td><td>The property is set and <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a> is readonly.</td></tr></table>

## Remarks
\[Missing <remarks> documentation for "P:iTin.Export.Model.BaseSimpleModelCollection`2.Item(System.Int32)"\]

## See Also


#### Reference
<a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent) Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />