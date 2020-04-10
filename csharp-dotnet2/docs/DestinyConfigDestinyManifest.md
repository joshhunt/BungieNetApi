# BungieNetApi.Model.DestinyConfigDestinyManifest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Version** | **string** |  | [optional] 
**MobileAssetContentPath** | **string** |  | [optional] 
**MobileGearAssetDataBases** | [**List<DestinyConfigGearAssetDataBaseDefinition>**](DestinyConfigGearAssetDataBaseDefinition.md) |  | [optional] 
**MobileWorldContentPaths** | **Dictionary<string, string>** |  | [optional] 
**JsonWorldContentPaths** | **Dictionary<string, string>** | This points to the generated JSON that contains all the Definitions. Each key is a locale. The value is a path to the aggregated world definitions (warning: large file!) | [optional] 
**JsonWorldComponentContentPaths** | **Dictionary<string, Dictionary<string, string>>** | This points to the generated JSON that contains all the Definitions. Each key is a locale. The value is a dictionary, where the key is a definition type by name, and the value is the path to the file for that definition. WARNING: This is unsafe and subject to change - do not depend on data in these files staying around long-term. | [optional] 
**MobileClanBannerDatabasePath** | **string** |  | [optional] 
**MobileGearCDN** | **Dictionary<string, string>** |  | [optional] 
**IconImagePyramidInfo** | [**List<DestinyConfigImagePyramidEntry>**](DestinyConfigImagePyramidEntry.md) | Information about the \&quot;Image Pyramid\&quot; for Destiny icons. Where possible, we create smaller versions of Destiny icons. These are found as subfolders under the location of the \&quot;original/full size\&quot; Destiny images, with the same file name and extension as the original image itself. (this lets us avoid sending largely redundant path info with every entity, at the expense of the smaller versions of the image being less discoverable) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

