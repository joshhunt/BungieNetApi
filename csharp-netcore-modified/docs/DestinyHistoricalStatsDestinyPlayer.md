# BungieNetApi.Model.DestinyHistoricalStatsDestinyPlayer
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DestinyUserInfo** | [**UserUserInfoCard**](UserUserInfoCard.md) | Details about the player as they are known in game (platform display name, Destiny emblem) | [optional] 
**CharacterClass** | **string** | Class of the character if applicable and available. | [optional] 
**ClassHash** | **long** |  | [optional] 
**RaceHash** | **long** |  | [optional] 
**GenderHash** | **long** |  | [optional] 
**CharacterLevel** | **int** | Level of the character if available. Zero if it is not available. | [optional] 
**LightLevel** | **int** | Light Level of the character if available. Zero if it is not available. | [optional] 
**BungieNetUserInfo** | [**UserUserInfoCard**](UserUserInfoCard.md) | Details about the player as they are known on BungieNet. This will be undefined if the player has marked their credential private, or does not have a BungieNet account. | [optional] 
**ClanName** | **string** | Current clan name for the player. This value may be null or an empty string if the user does not have a clan. | [optional] 
**ClanTag** | **string** | Current clan tag for the player. This value may be null or an empty string if the user does not have a clan. | [optional] 
**EmblemHash** | **long** | If we know the emblem&#39;s hash, this can be used to look up the player&#39;s emblem at the time of a match when receiving PGCR data, or otherwise their currently equipped emblem (if we are able to obtain it). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

