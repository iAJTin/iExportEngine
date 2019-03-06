# BaseSimpleModelCollection(*TItem*, *TParent*).Find Method 
Additional header content 

Searches for an element that matches the conditions defined by the specified predicate, and returns the first occurrence within the entire <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent)</a>.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public TItem Find(
	Predicate<TItem> match
)
```

**VB**<br />
``` VB
Public Function Find ( 
	match As Predicate(Of TItem)
) As TItem
```


#### Parameters
&nbsp;<dl><dt>match</dt><dd>Type: System.Predicate(<a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">*TItem*</a>)<br />The Predicate(T) delegate that defines the conditions of the element to search for.</dd></dl>

#### Return Value
Type: <a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">*TItem*</a><br />The first element that matches the conditions defined by the specified predicate, if found; otherwise, the default value for type TItem.

## Remarks
\[Missing <remarks> documentation for "M:iTin.Export.Model.BaseSimpleModelCollection`2.Find(System.Predicate{`0})"\]

## See Also


#### Reference
<a href="T_iTin_Export_Model_BaseSimpleModelCollection_2">BaseSimpleModelCollection(TItem, TParent) Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />