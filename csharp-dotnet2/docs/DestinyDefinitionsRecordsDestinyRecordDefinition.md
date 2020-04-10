# BungieNetApi.Model.DestinyDefinitionsRecordsDestinyRecordDefinition
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayProperties** | [**DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition**](DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition.md) |  | [optional] 
**Scope** | **int?** | Indicates whether this Record&#39;s state is determined on a per-character or on an account-wide basis. | [optional] 
**PresentationInfo** | [**DestinyDefinitionsPresentationDestinyPresentationChildBlock**](DestinyDefinitionsPresentationDestinyPresentationChildBlock.md) |  | [optional] 
**LoreHash** | **int?** |  | [optional] 
**ObjectiveHashes** | **List<int?>** |  | [optional] 
**RecordValueStyle** | **int?** |  | [optional] 
**TitleInfo** | [**DestinyDefinitionsRecordsDestinyRecordTitleBlock**](DestinyDefinitionsRecordsDestinyRecordTitleBlock.md) |  | [optional] 
**CompletionInfo** | [**DestinyDefinitionsRecordsDestinyRecordCompletionBlock**](DestinyDefinitionsRecordsDestinyRecordCompletionBlock.md) |  | [optional] 
**StateInfo** | [**DestinyDefinitionsRecordsSchemaRecordStateBlock**](DestinyDefinitionsRecordsSchemaRecordStateBlock.md) |  | [optional] 
**Requirements** | [**DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock**](DestinyDefinitionsPresentationDestinyPresentationNodeRequirementsBlock.md) |  | [optional] 
**ExpirationInfo** | [**DestinyDefinitionsRecordsDestinyRecordExpirationBlock**](DestinyDefinitionsRecordsDestinyRecordExpirationBlock.md) |  | [optional] 
**IntervalInfo** | [**DestinyDefinitionsRecordsDestinyRecordIntervalBlock**](DestinyDefinitionsRecordsDestinyRecordIntervalBlock.md) | Some records have multiple &#39;interval&#39; objectives, and the record may be claimed at each completed interval | [optional] 
**RewardItems** | [**List<DestinyDestinyItemQuantity>**](DestinyDestinyItemQuantity.md) | If there is any publicly available information about rewards earned for achieving this record, this is the list of those items.   However, note that some records intentionally have \&quot;hidden\&quot; rewards. These will not be returned in this list. | [optional] 
**PresentationNodeType** | **int?** |  | [optional] 
**TraitIds** | **List<string>** |  | [optional] 
**TraitHashes** | **List<int?>** |  | [optional] 
**ParentNodeHashes** | **List<int?>** | A quick reference to presentation nodes that have this node as a child. Presentation nodes can be parented under multiple parents. | [optional] 
**Hash** | **int?** | The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to. | [optional] 
**Index** | **int?** | The index of the entity as it was found in the investment tables. | [optional] 
**Redacted** | **bool?** | If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry! | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

