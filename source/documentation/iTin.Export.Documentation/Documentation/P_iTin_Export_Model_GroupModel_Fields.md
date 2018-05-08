# GroupModel.Fields Property 
Additional header content 

Gets or sets collection of fields contained within the group.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
public List<GroupItemModel> Fields { get; set; }
```

**VB**<br />
``` VB
Public Property Fields As List(Of GroupItemModel)
	Get
	Set
```


#### Property Value
Type: List(<a href="T_iTin_Export_Model_GroupItemModel">GroupItemModel</a>)<br />Collection of fields contained within the group. Each element is composed of a field name and a field separator.

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Group>
  <Field .../>
  <Field .../>
  ...
<Group>
```


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