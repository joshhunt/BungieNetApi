# BungieNetApi.Model.ForumPostSearchResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RelatedPosts** | [**List<ForumPostResponse>**](ForumPostResponse.md) |  | [optional] 
**Authors** | [**List<UserGeneralUser>**](UserGeneralUser.md) |  | [optional] 
**Groups** | [**List<GroupsV2GroupResponse>**](GroupsV2GroupResponse.md) |  | [optional] 
**SearchedTags** | [**List<TagsModelsContractsTagResponse>**](TagsModelsContractsTagResponse.md) |  | [optional] 
**Polls** | [**List<ForumPollResponse>**](ForumPollResponse.md) |  | [optional] 
**RecruitmentDetails** | [**List<ForumForumRecruitmentDetail>**](ForumForumRecruitmentDetail.md) |  | [optional] 
**AvailablePages** | **int?** |  | [optional] 
**Results** | [**List<ForumPostResponse>**](ForumPostResponse.md) |  | [optional] 
**TotalResults** | **int?** |  | [optional] 
**HasMore** | **bool?** |  | [optional] 
**Query** | [**QueriesPagedQuery**](QueriesPagedQuery.md) |  | [optional] 
**ReplacementContinuationToken** | **string** |  | [optional] 
**UseTotalResults** | **bool?** | If useTotalResults is true, then totalResults represents an accurate count.  If False, it does not, and may be estimated/only the size of the current page.  Either way, you should probably always only trust hasMore.  This is a long-held historical throwback to when we used to do paging with known total results. Those queries toasted our database, and we were left to hastily alter our endpoints and create backward- compatible shims, of which useTotalResults is one. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

