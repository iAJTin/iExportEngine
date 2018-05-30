# BaseSimpleModelCollection(*TItem*, *TParent*).CopyTo Method 
Additional header content 

Copies the entire <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a> to a compatible one-dimensional array, starting at the specified index of the target array.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
public void CopyTo(
	TItem[] array,
	int arrayIndex
)
```

**VB**<br />
``` VB
Public Sub CopyTo ( 
	array As TItem(),
	arrayIndex As Integer
)
```


#### Parameters
&nbsp;<dl><dt>array</dt><dd>Type: <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">*TItem*</a>[]<br />The one-dimensional Array that is the destination of the elements copied from <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>. The Array must have zero-based indexing.</dd><dt>arrayIndex</dt><dd>Type: System.Int32<br />The zero-based index in *array* at which copying begins.</dd></dl>

#### Implements
ICollection(T).CopyTo(T[], Int32)<br />

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td>ArgumentNullException</td><td>*array* is <strong>null</strong>.</td></tr><tr><td>ArgumentOutOfRangeException</td><td>*arrayIndex* is less than 0.</td></tr><tr><td>ArgumentException</td><td>The number of elements in the source <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a> is greater than the available space from *arrayIndex* to the end of the destination array.</td></tr></table>

## Remarks
\[Missing <remarks> documentation for "M:iTin.Export.Model.BaseSimpleModelCollection`2.CopyTo(`0[],System.Int32)"\]

## See Also


#### Reference
<a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent) Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />