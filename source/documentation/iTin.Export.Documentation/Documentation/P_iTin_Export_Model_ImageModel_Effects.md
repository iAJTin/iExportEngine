# ImageModel.Effects Property 
Additional header content 

Gets or sets collection of image effects.

**Namespace:**&nbsp;<a href="N_iTin_Export_Model">iTin.Export.Model</a><br />**Assembly:**&nbsp;iTin.Export.Core (in iTin.Export.Core.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
public List<BaseEffectModel> Effects { get; set; }
```

**VB**<br />
``` VB
Public Property Effects As List(Of BaseEffectModel)
	Get
	Set
```


#### Property Value
Type: List(<a href="T_iTin_Export_Model_BaseEffectModel">BaseEffectModel</a>)<br />Collection of image effects. Each element is an image effect.

## Remarks

**ITEE Object Element Usage**<br />
``` XML
<Effects>
  <Disabled/> | 
  <GrayScale/> | 
  <GrayScaleRed/> | 
  <GrayScaleGreen/> | 
  <GrayScaleBlue/> | 
  <Brightness/> | 
  <MoreBrightness/> | 
  <Dark/> | 
  <MoreDark/> | 
  <Opacity .../>
</Effects>
```


## See Also


#### Reference
<a href="T_iTin_Export_Model_ImageModel">ImageModel Class</a><br /><a href="N_iTin_Export_Model">iTin.Export.Model Namespace</a><br />