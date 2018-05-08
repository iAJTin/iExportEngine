# BaseSimpleModelCollection(*TItem*, *TParent*).Contains Method 
Additional header content 

Determines whether an element is in the <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
public bool Contains(
	TItem item
)
```

**VB**<br />
``` VB
Public Function Contains ( 
	item As TItem
) As Boolean
```


#### Parameters
&nbsp;<dl><dt>item</dt><dd>Type: <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">*TItem*</a><br />The object to locate in the <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>. The value can be <strong>null</strong> for reference types.</dd></dl>

#### Return Value
Type: Boolean<br /><strong>true</strong> if *item* is found in the <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>; otherwise, <strong>false</strong>.

#### Implements
ICollection(T).Contains(T)<br />

## Remarks
This method determines equality by using the default equality comparer, as defined by the object's implementation of the Equals() method for TItem (the type of values in the list).

## See Also


#### Reference
<a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent) Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />