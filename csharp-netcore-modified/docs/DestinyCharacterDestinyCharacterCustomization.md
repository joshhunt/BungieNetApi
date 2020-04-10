# BungieNetApi.Model.DestinyCharacterDestinyCharacterCustomization
Raw data about the customization options chosen for a character's face and appearance.  You can look up the relevant class/race/gender combo in DestinyCharacterCustomizationOptionDefinition for the character, and then look up these values within the CustomizationOptions found to pull some data about their choices. Warning: not all of that data is meaningful. Some data has useful icons. Others have nothing, and are only meant for 3D rendering purposes (which we sadly do not expose yet)
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Personality** | **long** |  | [optional] 
**Face** | **long** |  | [optional] 
**SkinColor** | **long** |  | [optional] 
**LipColor** | **long** |  | [optional] 
**EyeColor** | **long** |  | [optional] 
**HairColors** | **List&lt;long&gt;** |  | [optional] 
**FeatureColors** | **List&lt;long&gt;** |  | [optional] 
**DecalColor** | **long** |  | [optional] 
**WearHelmet** | **bool** |  | [optional] 
**HairIndex** | **int** |  | [optional] 
**FeatureIndex** | **int** |  | [optional] 
**DecalIndex** | **int** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

