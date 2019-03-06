# GroupModel.Name Property 
Additional header content 

Gets or sets the name of the group.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 2.0.0.0 (2.0.0.0)

## Syntax

**C#**<br />
``` C#
public string Name { get; set; }
```

**VB**<br />
``` VB
Public Property Name As String
	Get
	Set
```


#### Property Value
Type: String<br />The name of the group. Are only allow strings made ​​up of letters, numbers and following special chars <strong>'`_ - # * @ % $`'</strong>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td>ArgumentNullException</td><td>If *value* is <strong>null</strong>.</td></tr><tr><td><a href="T_iTin_Export_Model_InvalidFieldIdentifierNameException">InvalidFieldIdentifierNameException</a></td><td>If *value* not is a valid field identifier name.</td></tr></table>

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Group Name="string">
  ...
</Group>
```


<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br /><a href="T_iTin_Export_Writers_CsvWriter">CsvWriter</a></th><th>Tab-Separated Values<br /><a href="T_iTin_Export_Writers_TsvWriter">TsvWriter</a></th><th>SQL Script<br /><a href="T_iTin_Export_Writers_SqlScriptWriter">SqlScriptWriter</a></th><th>XML Spreadsheet 2003<br /><a href="T_iTin_Export_Writers_Spreadsheet2003TabularWriter">Spreadsheet2003TabularWriter</a></th></tr><tr><td align="center">X</td><td align="center">X</td><td align="center">X</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## Examples
The following example creates a new group called `AddressGroup` as a result of the union of three fields. 
**XML**<br />
``` XML
<Groups>     
  <Group Name="AddressGroup">
    <Field Name="CMADR1" Separator="Comma"/>
    <Field Name="CMCITY" Separator="Comma"/>
    <Field Name="CMPSTAL"/>
  </Group>
</Groups>
```

**C#**<br />
``` C#
public void CreateGroup()
{
    GroupsModel groups = new GroupsModel();

    GroupModel addressGroup = new GroupModel
                                    { 
                                        Name = "AddressGroup",
                                        Fields = new List<GroupItemModel>
                                                        {
                                                            new GroupItemModel { Name = "CMADR1", Separator = "Comma" },
                                                            new GroupItemModel { Name = "CMCITY", Separator = "Comma" },
                                                            new GroupItemModel { Name = "CMPSTAL" }
                                                        }
                                    };
    addressGroup.SetOwner(groups);
    groups.Items.Add(addressGroup);

    ExportModel export = new ExportModel 
                             {
                                 Table = 
                                     {
                                         Name = "Sample",
                                         Alias = "New table",
                                         Location = new[] { 2, 2}, 
                                         Groups = groups
                                     } 
                             };

    ExportsModel model = new ExportsModel();
    model.Items.Add(export);
}
```


## See Also


#### Reference
<a href="T_iTin_Export_Model_GroupModel">GroupModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />