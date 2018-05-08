# GroupItemModel.Separator Property 
Additional header content 

Gets or sets the field separator.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
public string Separator { get; set; }
```

**VB**<br />
``` VB
Public Property Separator As String
	Get
	Set
```


#### Property Value
Type: String<br />The field separator. The default is "`None`".<br />

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Field Separator="None|Space|Slash|Backslash|Dash|Dot|Comma|Colon|Semi Colon|New Line|string" .../>
```

`AEE` recognizes the following strings as valid separators:
&nbsp;<table><tr><th>Value</th><th>Description</th></tr><tr><td>None</td><td>An empty string</td></tr><tr><td>Space</td><td>A whitespace</td></tr><tr><td>Dash</td><td>-</td></tr><tr><td>Dot</td><td>.</td></tr><tr><td>Comma</td><td>,</td></tr><tr><td>Colon</td><td>:</td></tr><tr><td>Semi Colon</td><td>;</td></tr><tr><td>New Line</td><td>A new line</td></tr><tr><td>Other value</td><td>Defined by user</td></tr></table>&nbsp;
&nbsp;<table><tr><th>![Note](media/AlertNote.png) Note</th></tr><tr><td>`AEE` provides the <a href="T_iTin_Export_Model_KnownItemGroupSeparator">KnownItemGroupSeparator</a> static class, it contains list of constants with the known elements, can be used for compare values if necessary for new writers.</td></tr></table>&nbsp;
<strong>Compatibility table with native writers.</strong><table><tr><th>Comma-Separated Values<br />CsvWriter</th><th>Tab-Separated Values<br />TsvWriter</th><th>SQL Script<br />SqlScriptWriter</th><th>XML Spreadsheet 2003<br />Spreadsheet2003TabularWriter</th></tr><tr><td align="center">X</td><td align="center">X</td><td align="center">X</td><td align="center">X</td></tr></table> A <strong>`X`</strong> value indicates that the writer supports this element.


## Examples
The following example shows the use of the property. The new group consists of three fields separated by commas. 
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
<a href="T_iTin_Export_Model_GroupItemModel">GroupItemModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />