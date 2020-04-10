# BungieNetApi.Model.DestinyComponentsPresentationDestinyPresentationNodeComponent
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**State** | **int** |  | [optional] 
**Objective** | [**DestinyQuestsDestinyObjectiveProgress**](DestinyQuestsDestinyObjectiveProgress.md) | An optional property: presentation nodes MAY have objectives, which can be used to infer more human readable data about the progress. However, progressValue and completionValue ought to be considered the canonical values for progress on Progression Nodes. | [optional] 
**ProgressValue** | **int** | How much of the presentation node is considered to be completed so far by the given character/profile. | [optional] 
**CompletionValue** | **int** | The value at which the presentation node is considered to be completed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

