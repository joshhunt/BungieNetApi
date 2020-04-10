# BungieNetApi.Api.Destiny2Api

All URIs are relative to *https://www.bungie.net/Platform*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Destiny2AwaGetActionToken**](Destiny2Api.md#destiny2awagetactiontoken) | **GET** /Destiny2/Awa/GetActionToken/{correlationId}/ | 
[**Destiny2AwaInitializeRequest**](Destiny2Api.md#destiny2awainitializerequest) | **POST** /Destiny2/Awa/Initialize/ | 
[**Destiny2AwaProvideAuthorizationResult**](Destiny2Api.md#destiny2awaprovideauthorizationresult) | **POST** /Destiny2/Awa/AwaProvideAuthorizationResult/ | 
[**Destiny2EquipItem**](Destiny2Api.md#destiny2equipitem) | **POST** /Destiny2/Actions/Items/EquipItem/ | 
[**Destiny2EquipItems**](Destiny2Api.md#destiny2equipitems) | **POST** /Destiny2/Actions/Items/EquipItems/ | 
[**Destiny2GetActivityHistory**](Destiny2Api.md#destiny2getactivityhistory) | **GET** /Destiny2/{membershipType}/Account/{destinyMembershipId}/Character/{characterId}/Stats/Activities/ | 
[**Destiny2GetCharacter**](Destiny2Api.md#destiny2getcharacter) | **GET** /Destiny2/{membershipType}/Profile/{destinyMembershipId}/Character/{characterId}/ | 
[**Destiny2GetClanAggregateStats**](Destiny2Api.md#destiny2getclanaggregatestats) | **GET** /Destiny2/Stats/AggregateClanStats/{groupId}/ | 
[**Destiny2GetClanLeaderboards**](Destiny2Api.md#destiny2getclanleaderboards) | **GET** /Destiny2/Stats/Leaderboards/Clans/{groupId}/ | 
[**Destiny2GetClanWeeklyRewardState**](Destiny2Api.md#destiny2getclanweeklyrewardstate) | **GET** /Destiny2/Clan/{groupId}/WeeklyRewardState/ | 
[**Destiny2GetCollectibleNodeDetails**](Destiny2Api.md#destiny2getcollectiblenodedetails) | **GET** /Destiny2/{membershipType}/Profile/{destinyMembershipId}/Character/{characterId}/Collectibles/{collectiblePresentationNodeHash}/ | 
[**Destiny2GetDestinyAggregateActivityStats**](Destiny2Api.md#destiny2getdestinyaggregateactivitystats) | **GET** /Destiny2/{membershipType}/Account/{destinyMembershipId}/Character/{characterId}/Stats/AggregateActivityStats/ | 
[**Destiny2GetDestinyEntityDefinition**](Destiny2Api.md#destiny2getdestinyentitydefinition) | **GET** /Destiny2/Manifest/{entityType}/{hashIdentifier}/ | 
[**Destiny2GetDestinyManifest**](Destiny2Api.md#destiny2getdestinymanifest) | **GET** /Destiny2/Manifest/ | 
[**Destiny2GetHistoricalStats**](Destiny2Api.md#destiny2gethistoricalstats) | **GET** /Destiny2/{membershipType}/Account/{destinyMembershipId}/Character/{characterId}/Stats/ | 
[**Destiny2GetHistoricalStatsDefinition**](Destiny2Api.md#destiny2gethistoricalstatsdefinition) | **GET** /Destiny2/Stats/Definition/ | 
[**Destiny2GetHistoricalStatsForAccount**](Destiny2Api.md#destiny2gethistoricalstatsforaccount) | **GET** /Destiny2/{membershipType}/Account/{destinyMembershipId}/Stats/ | 
[**Destiny2GetItem**](Destiny2Api.md#destiny2getitem) | **GET** /Destiny2/{membershipType}/Profile/{destinyMembershipId}/Item/{itemInstanceId}/ | 
[**Destiny2GetLeaderboards**](Destiny2Api.md#destiny2getleaderboards) | **GET** /Destiny2/{membershipType}/Account/{destinyMembershipId}/Stats/Leaderboards/ | 
[**Destiny2GetLeaderboardsForCharacter**](Destiny2Api.md#destiny2getleaderboardsforcharacter) | **GET** /Destiny2/Stats/Leaderboards/{membershipType}/{destinyMembershipId}/{characterId}/ | 
[**Destiny2GetLinkedProfiles**](Destiny2Api.md#destiny2getlinkedprofiles) | **GET** /Destiny2/{membershipType}/Profile/{membershipId}/LinkedProfiles/ | 
[**Destiny2GetPostGameCarnageReport**](Destiny2Api.md#destiny2getpostgamecarnagereport) | **GET** /Destiny2/Stats/PostGameCarnageReport/{activityId}/ | 
[**Destiny2GetProfile**](Destiny2Api.md#destiny2getprofile) | **GET** /Destiny2/{membershipType}/Profile/{destinyMembershipId}/ | 
[**Destiny2GetPublicMilestoneContent**](Destiny2Api.md#destiny2getpublicmilestonecontent) | **GET** /Destiny2/Milestones/{milestoneHash}/Content/ | 
[**Destiny2GetPublicMilestones**](Destiny2Api.md#destiny2getpublicmilestones) | **GET** /Destiny2/Milestones/ | 
[**Destiny2GetPublicVendors**](Destiny2Api.md#destiny2getpublicvendors) | **GET** /Destiny2//Vendors/ | 
[**Destiny2GetUniqueWeaponHistory**](Destiny2Api.md#destiny2getuniqueweaponhistory) | **GET** /Destiny2/{membershipType}/Account/{destinyMembershipId}/Character/{characterId}/Stats/UniqueWeapons/ | 
[**Destiny2GetVendor**](Destiny2Api.md#destiny2getvendor) | **GET** /Destiny2/{membershipType}/Profile/{destinyMembershipId}/Character/{characterId}/Vendors/{vendorHash}/ | 
[**Destiny2GetVendors**](Destiny2Api.md#destiny2getvendors) | **GET** /Destiny2/{membershipType}/Profile/{destinyMembershipId}/Character/{characterId}/Vendors/ | 
[**Destiny2InsertSocketPlug**](Destiny2Api.md#destiny2insertsocketplug) | **POST** /Destiny2/Actions/Items/InsertSocketPlug/ | 
[**Destiny2PullFromPostmaster**](Destiny2Api.md#destiny2pullfrompostmaster) | **POST** /Destiny2/Actions/Items/PullFromPostmaster/ | 
[**Destiny2ReportOffensivePostGameCarnageReportPlayer**](Destiny2Api.md#destiny2reportoffensivepostgamecarnagereportplayer) | **POST** /Destiny2/Stats/PostGameCarnageReport/{activityId}/Report/ | 
[**Destiny2SearchDestinyEntities**](Destiny2Api.md#destiny2searchdestinyentities) | **GET** /Destiny2/Armory/Search/{type}/{searchTerm}/ | 
[**Destiny2SearchDestinyPlayer**](Destiny2Api.md#destiny2searchdestinyplayer) | **GET** /Destiny2/SearchDestinyPlayer/{membershipType}/{displayName}/ | 
[**Destiny2SetItemLockState**](Destiny2Api.md#destiny2setitemlockstate) | **POST** /Destiny2/Actions/Items/SetLockState/ | 
[**Destiny2TransferItem**](Destiny2Api.md#destiny2transferitem) | **POST** /Destiny2/Actions/Items/TransferItem/ | 


<a name="destiny2awagetactiontoken"></a>
# **Destiny2AwaGetActionToken**
> InlineResponse20060 Destiny2AwaGetActionToken (string correlationId)



Returns the action token if user approves the request.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetApi.Api;
using Org.OpenAPITools.Client;
using BungieNetApi.Model;

namespace Example
{
    public class Destiny2AwaGetActionTokenExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Destiny2Api();
            var correlationId = correlationId_example;  // string | The identifier for the advanced write action request.

            try
            {
                InlineResponse20060 result = apiInstance.Destiny2AwaGetActionToken(correlationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2AwaGetActionToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **correlationId** | **string**| The identifier for the advanced write action request. | 

### Return type

[**InlineResponse20060**](InlineResponse20060.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2awainitializerequest"></a>
# **Destiny2AwaInitializeRequest**
> InlineResponse20059 Destiny2AwaInitializeRequest ()



Initialize a request to perform an advanced write action.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetApi.Api;
using Org.OpenAPITools.Client;
using BungieNetApi.Model;

namespace Example
{
    public class Destiny2AwaInitializeRequestExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Destiny2Api();

            try
            {
                InlineResponse20059 result = apiInstance.Destiny2AwaInitializeRequest();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2AwaInitializeRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20059**](InlineResponse20059.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2awaprovideauthorizationresult"></a>
# **Destiny2AwaProvideAuthorizationResult**
> InlineResponse20022 Destiny2AwaProvideAuthorizationResult ()



Provide the result of the user interaction. Called by the Bungie Destiny App to approve or reject a request.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetApi.Api;
using Org.OpenAPITools.Client;
using BungieNetApi.Model;

namespace Example
{
    public class Destiny2AwaProvideAuthorizationResultExample
    {
        public void main()
        {
            
            var apiInstance = new Destiny2Api();

            try
            {
                InlineResponse20022 result = apiInstance.Destiny2AwaProvideAuthorizationResult();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2AwaProvideAuthorizationResult: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20022**](InlineResponse20022.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2equipitem"></a>
# **Destiny2EquipItem**
> InlineResponse20022 Destiny2EquipItem ()



Equip an item. You must have a valid Destiny Account, and either be in a social space, in orbit, or offline.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetApi.Api;
using Org.OpenAPITools.Client;
using BungieNetApi.Model;

namespace Example
{
    public class Destiny2EquipItemExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Destiny2Api();

            try
            {
                InlineResponse20022 result = apiInstance.Destiny2EquipItem();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2EquipItem: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20022**](InlineResponse20022.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2equipitems"></a>
# **Destiny2EquipItems**
> InlineResponse20045 Destiny2EquipItems ()



Equip a list of items by itemInstanceIds. You must have a valid Destiny Account, and either be in a social space, in orbit, or offline. Any items not found on your character will be ignored.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetApi.Api;
using Org.OpenAPITools.Client;
using BungieNetApi.Model;

namespace Example
{
    public class Destiny2EquipItemsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Destiny2Api();

            try
            {
                InlineResponse20045 result = apiInstance.Destiny2EquipItems();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2EquipItems: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20045**](InlineResponse20045.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2getactivityhistory"></a>
# **Destiny2GetActivityHistory**
> InlineResponse20054 Destiny2GetActivityHistory (long? characterId, long? destinyMembershipId, int? membershipType, int? count, int? mode, int? page)



Gets activity history stats for indicated character.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetApi.Api;
using Org.OpenAPITools.Client;
using BungieNetApi.Model;

namespace Example
{
    public class Destiny2GetActivityHistoryExample
    {
        public void main()
        {
            
            var apiInstance = new Destiny2Api();
            var characterId = 789;  // long? | The id of the character to retrieve.
            var destinyMembershipId = 789;  // long? | The Destiny membershipId of the user to retrieve.
            var membershipType = 56;  // int? | A valid non-BungieNet membership type.
            var count = 56;  // int? | Number of rows to return (optional) 
            var mode = 56;  // int? | A filter for the activity mode to be returned. None returns all activities. See the documentation for DestinyActivityModeType for valid values, and pass in string representation. (optional) 
            var page = 56;  // int? | Page number to return, starting with 0. (optional) 

            try
            {
                InlineResponse20054 result = apiInstance.Destiny2GetActivityHistory(characterId, destinyMembershipId, membershipType, count, mode, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetActivityHistory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **long?**| The id of the character to retrieve. | 
 **destinyMembershipId** | **long?**| The Destiny membershipId of the user to retrieve. | 
 **membershipType** | **int?**| A valid non-BungieNet membership type. | 
 **count** | **int?**| Number of rows to return | [optional] 
 **mode** | **int?**| A filter for the activity mode to be returned. None returns all activities. See the documentation for DestinyActivityModeType for valid values, and pass in string representation. | [optional] 
 **page** | **int?**| Page number to return, starting with 0. | [optional] 

### Return type

[**InlineResponse20054**](InlineResponse20054.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2getcharacter"></a>
# **Destiny2GetCharacter**
> InlineResponse20038 Destiny2GetCharacter (long? characterId, long? destinyMembershipId, int? membershipType, List<int?> components)



Returns character information for the supplied character.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetApi.Api;
using Org.OpenAPITools.Client;
using BungieNetApi.Model;

namespace Example
{
    public class Destiny2GetCharacterExample
    {
        public void main()
        {
            
            var apiInstance = new Destiny2Api();
            var characterId = 789;  // long? | ID of the character.
            var destinyMembershipId = 789;  // long? | Destiny membership ID.
            var membershipType = 56;  // int? | A valid non-BungieNet membership type.
            var components = new List<int?>(); // List<int?> | A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results. (optional) 

            try
            {
                InlineResponse20038 result = apiInstance.Destiny2GetCharacter(characterId, destinyMembershipId, membershipType, components);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetCharacter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **long?**| ID of the character. | 
 **destinyMembershipId** | **long?**| Destiny membership ID. | 
 **membershipType** | **int?**| A valid non-BungieNet membership type. | 
 **components** | [**List<int?>**](int?.md)| A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results. | [optional] 

### Return type

[**InlineResponse20038**](InlineResponse20038.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2getclanaggregatestats"></a>
# **Destiny2GetClanAggregateStats**
> InlineResponse20050 Destiny2GetClanAggregateStats (long? groupId, string modes)



Gets aggregated stats for a clan using the same categories as the clan leaderboards. PREVIEW: This endpoint is still in beta, and may experience rough edges. The schema is in final form, but there may be bugs that prevent desirable operation.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetApi.Api;
using Org.OpenAPITools.Client;
using BungieNetApi.Model;

namespace Example
{
    public class Destiny2GetClanAggregateStatsExample
    {
        public void main()
        {
            
            var apiInstance = new Destiny2Api();
            var groupId = 789;  // long? | Group ID of the clan whose leaderboards you wish to fetch.
            var modes = modes_example;  // string | List of game modes for which to get leaderboards. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited. (optional) 

            try
            {
                InlineResponse20050 result = apiInstance.Destiny2GetClanAggregateStats(groupId, modes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetClanAggregateStats: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **long?**| Group ID of the clan whose leaderboards you wish to fetch. | 
 **modes** | **string**| List of game modes for which to get leaderboards. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited. | [optional] 

### Return type

[**InlineResponse20050**](InlineResponse20050.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2getclanleaderboards"></a>
# **Destiny2GetClanLeaderboards**
> InlineResponse20049 Destiny2GetClanLeaderboards (long? groupId, int? maxtop, string modes, string statid)



Gets leaderboards with the signed in user's friends and the supplied destinyMembershipId as the focus. PREVIEW: This endpoint is still in beta, and may experience rough edges. The schema is in final form, but there may be bugs that prevent desirable operation.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetApi.Api;
using Org.OpenAPITools.Client;
using BungieNetApi.Model;

namespace Example
{
    public class Destiny2GetClanLeaderboardsExample
    {
        public void main()
        {
            
            var apiInstance = new Destiny2Api();
            var groupId = 789;  // long? | Group ID of the clan whose leaderboards you wish to fetch.
            var maxtop = 56;  // int? | Maximum number of top players to return. Use a large number to get entire leaderboard. (optional) 
            var modes = modes_example;  // string | List of game modes for which to get leaderboards. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited. (optional) 
            var statid = statid_example;  // string | ID of stat to return rather than returning all Leaderboard stats. (optional) 

            try
            {
                InlineResponse20049 result = apiInstance.Destiny2GetClanLeaderboards(groupId, maxtop, modes, statid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetClanLeaderboards: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **long?**| Group ID of the clan whose leaderboards you wish to fetch. | 
 **maxtop** | **int?**| Maximum number of top players to return. Use a large number to get entire leaderboard. | [optional] 
 **modes** | **string**| List of game modes for which to get leaderboards. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited. | [optional] 
 **statid** | **string**| ID of stat to return rather than returning all Leaderboard stats. | [optional] 

### Return type

[**InlineResponse20049**](InlineResponse20049.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2getclanweeklyrewardstate"></a>
# **Destiny2GetClanWeeklyRewardState**
> InlineResponse20039 Destiny2GetClanWeeklyRewardState (long? groupId)



Returns information on the weekly clan rewards and if the clan has earned them or not. Note that this will always report rewards as not redeemed.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetApi.Api;
using Org.OpenAPITools.Client;
using BungieNetApi.Model;

namespace Example
{
    public class Destiny2GetClanWeeklyRewardStateExample
    {
        public void main()
        {
            
            var apiInstance = new Destiny2Api();
            var groupId = 789;  // long? | A valid group id of clan.

            try
            {
                InlineResponse20039 result = apiInstance.Destiny2GetClanWeeklyRewardState(groupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetClanWeeklyRewardState: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **long?**| A valid group id of clan. | 

### Return type

[**InlineResponse20039**](InlineResponse20039.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2getcollectiblenodedetails"></a>
# **Destiny2GetCollectibleNodeDetails**
> InlineResponse20044 Destiny2GetCollectibleNodeDetails (long? characterId, int? collectiblePresentationNodeHash, long? destinyMembershipId, int? membershipType, List<int?> components)



Given a Presentation Node that has Collectibles as direct descendants, this will return item details about those descendants in the context of the requesting character.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetApi.Api;
using Org.OpenAPITools.Client;
using BungieNetApi.Model;

namespace Example
{
    public class Destiny2GetCollectibleNodeDetailsExample
    {
        public void main()
        {
            
            var apiInstance = new Destiny2Api();
            var characterId = 789;  // long? | The Destiny Character ID of the character for whom we're getting collectible detail info.
            var collectiblePresentationNodeHash = 56;  // int? | The hash identifier of the Presentation Node for whom we should return collectible details. Details will only be returned for collectibles that are direct descendants of this node.
            var destinyMembershipId = 789;  // long? | Destiny membership ID of another user. You may be denied.
            var membershipType = 56;  // int? | A valid non-BungieNet membership type.
            var components = new List<int?>(); // List<int?> | A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results. (optional) 

            try
            {
                InlineResponse20044 result = apiInstance.Destiny2GetCollectibleNodeDetails(characterId, collectiblePresentationNodeHash, destinyMembershipId, membershipType, components);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetCollectibleNodeDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **long?**| The Destiny Character ID of the character for whom we&#39;re getting collectible detail info. | 
 **collectiblePresentationNodeHash** | **int?**| The hash identifier of the Presentation Node for whom we should return collectible details. Details will only be returned for collectibles that are direct descendants of this node. | 
 **destinyMembershipId** | **long?**| Destiny membership ID of another user. You may be denied. | 
 **membershipType** | **int?**| A valid non-BungieNet membership type. | 
 **components** | [**List<int?>**](int?.md)| A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results. | [optional] 

### Return type

[**InlineResponse20044**](InlineResponse20044.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2getdestinyaggregateactivitystats"></a>
# **Destiny2GetDestinyAggregateActivityStats**
> InlineResponse20056 Destiny2GetDestinyAggregateActivityStats (long? characterId, long? destinyMembershipId, int? membershipType)



Gets all activities the character has participated in together with aggregate statistics for those activities.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetApi.Api;
using Org.OpenAPITools.Client;
using BungieNetApi.Model;

namespace Example
{
    public class Destiny2GetDestinyAggregateActivityStatsExample
    {
        public void main()
        {
            
            var apiInstance = new Destiny2Api();
            var characterId = 789;  // long? | The specific character whose activities should be returned.
            var destinyMembershipId = 789;  // long? | The Destiny membershipId of the user to retrieve.
            var membershipType = 56;  // int? | A valid non-BungieNet membership type.

            try
            {
                InlineResponse20056 result = apiInstance.Destiny2GetDestinyAggregateActivityStats(characterId, destinyMembershipId, membershipType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetDestinyAggregateActivityStats: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **long?**| The specific character whose activities should be returned. | 
 **destinyMembershipId** | **long?**| The Destiny membershipId of the user to retrieve. | 
 **membershipType** | **int?**| A valid non-BungieNet membership type. | 

### Return type

[**InlineResponse20056**](InlineResponse20056.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2getdestinyentitydefinition"></a>
# **Destiny2GetDestinyEntityDefinition**
> InlineResponse20034 Destiny2GetDestinyEntityDefinition (string entityType, int? hashIdentifier)



Returns the static definition of an entity of the given Type and hash identifier. Examine the API Documentation for the Type Names of entities that have their own definitions. Note that the return type will always *inherit from* DestinyDefinition, but the specific type returned will be the requested entity type if it can be found. Please don't use this as a chatty alternative to the Manifest database if you require large sets of data, but for simple and one-off accesses this should be handy.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetApi.Api;
using Org.OpenAPITools.Client;
using BungieNetApi.Model;

namespace Example
{
    public class Destiny2GetDestinyEntityDefinitionExample
    {
        public void main()
        {
            
            var apiInstance = new Destiny2Api();
            var entityType = entityType_example;  // string | The type of entity for whom you would like results. These correspond to the entity's definition contract name. For instance, if you are looking for items, this property should be 'DestinyInventoryItemDefinition'. PREVIEW: This endpoint is still in beta, and may experience rough edges. The schema is tentatively in final form, but there may be bugs that prevent desirable operation.
            var hashIdentifier = 56;  // int? | The hash identifier for the specific Entity you want returned.

            try
            {
                InlineResponse20034 result = apiInstance.Destiny2GetDestinyEntityDefinition(entityType, hashIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetDestinyEntityDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **entityType** | **string**| The type of entity for whom you would like results. These correspond to the entity&#39;s definition contract name. For instance, if you are looking for items, this property should be &#39;DestinyInventoryItemDefinition&#39;. PREVIEW: This endpoint is still in beta, and may experience rough edges. The schema is tentatively in final form, but there may be bugs that prevent desirable operation. | 
 **hashIdentifier** | **int?**| The hash identifier for the specific Entity you want returned. | 

### Return type

[**InlineResponse20034**](InlineResponse20034.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2getdestinymanifest"></a>
# **Destiny2GetDestinyManifest**
> InlineResponse20033 Destiny2GetDestinyManifest ()



Returns the current version of the manifest as a json object.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetApi.Api;
using Org.OpenAPITools.Client;
using BungieNetApi.Model;

namespace Example
{
    public class Destiny2GetDestinyManifestExample
    {
        public void main()
        {
            
            var apiInstance = new Destiny2Api();

            try
            {
                InlineResponse20033 result = apiInstance.Destiny2GetDestinyManifest();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetDestinyManifest: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20033**](InlineResponse20033.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2gethistoricalstats"></a>
# **Destiny2GetHistoricalStats**
> InlineResponse20052 Destiny2GetHistoricalStats (long? characterId, long? destinyMembershipId, int? membershipType, DateTime? dayend, DateTime? daystart, List<int?> groups, List<int?> modes, int? periodType)



Gets historical stats for indicated character.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetApi.Api;
using Org.OpenAPITools.Client;
using BungieNetApi.Model;

namespace Example
{
    public class Destiny2GetHistoricalStatsExample
    {
        public void main()
        {
            
            var apiInstance = new Destiny2Api();
            var characterId = 789;  // long? | The id of the character to retrieve. You can omit this character ID or set it to 0 to get aggregate stats across all characters.
            var destinyMembershipId = 789;  // long? | The Destiny membershipId of the user to retrieve.
            var membershipType = 56;  // int? | A valid non-BungieNet membership type.
            var dayend = 2013-10-20T19:20:30+01:00;  // DateTime? | Last day to return when daily stats are requested. Use the format YYYY-MM-DD. Currently, we cannot allow more than 31 days of daily data to be requested in a single request. (optional) 
            var daystart = 2013-10-20T19:20:30+01:00;  // DateTime? | First day to return when daily stats are requested. Use the format YYYY-MM-DD. Currently, we cannot allow more than 31 days of daily data to be requested in a single request. (optional) 
            var groups = new List<int?>(); // List<int?> | Group of stats to include, otherwise only general stats are returned. Comma separated list is allowed. Values: General, Weapons, Medals (optional) 
            var modes = new List<int?>(); // List<int?> | Game modes to return. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited. (optional) 
            var periodType = 56;  // int? | Indicates a specific period type to return. Optional. May be: Daily, AllTime, or Activity (optional) 

            try
            {
                InlineResponse20052 result = apiInstance.Destiny2GetHistoricalStats(characterId, destinyMembershipId, membershipType, dayend, daystart, groups, modes, periodType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetHistoricalStats: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **long?**| The id of the character to retrieve. You can omit this character ID or set it to 0 to get aggregate stats across all characters. | 
 **destinyMembershipId** | **long?**| The Destiny membershipId of the user to retrieve. | 
 **membershipType** | **int?**| A valid non-BungieNet membership type. | 
 **dayend** | **DateTime?**| Last day to return when daily stats are requested. Use the format YYYY-MM-DD. Currently, we cannot allow more than 31 days of daily data to be requested in a single request. | [optional] 
 **daystart** | **DateTime?**| First day to return when daily stats are requested. Use the format YYYY-MM-DD. Currently, we cannot allow more than 31 days of daily data to be requested in a single request. | [optional] 
 **groups** | [**List<int?>**](int?.md)| Group of stats to include, otherwise only general stats are returned. Comma separated list is allowed. Values: General, Weapons, Medals | [optional] 
 **modes** | [**List<int?>**](int?.md)| Game modes to return. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited. | [optional] 
 **periodType** | **int?**| Indicates a specific period type to return. Optional. May be: Daily, AllTime, or Activity | [optional] 

### Return type

[**InlineResponse20052**](InlineResponse20052.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2gethistoricalstatsdefinition"></a>
# **Destiny2GetHistoricalStatsDefinition**
> InlineResponse20048 Destiny2GetHistoricalStatsDefinition ()



Gets historical stats definitions.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetApi.Api;
using Org.OpenAPITools.Client;
using BungieNetApi.Model;

namespace Example
{
    public class Destiny2GetHistoricalStatsDefinitionExample
    {
        public void main()
        {
            
            var apiInstance = new Destiny2Api();

            try
            {
                InlineResponse20048 result = apiInstance.Destiny2GetHistoricalStatsDefinition();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetHistoricalStatsDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20048**](InlineResponse20048.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2gethistoricalstatsforaccount"></a>
# **Destiny2GetHistoricalStatsForAccount**
> InlineResponse20053 Destiny2GetHistoricalStatsForAccount (long? destinyMembershipId, int? membershipType, List<int?> groups)



Gets aggregate historical stats organized around each character for a given account.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetApi.Api;
using Org.OpenAPITools.Client;
using BungieNetApi.Model;

namespace Example
{
    public class Destiny2GetHistoricalStatsForAccountExample
    {
        public void main()
        {
            
            var apiInstance = new Destiny2Api();
            var destinyMembershipId = 789;  // long? | The Destiny membershipId of the user to retrieve.
            var membershipType = 56;  // int? | A valid non-BungieNet membership type.
            var groups = new List<int?>(); // List<int?> | Groups of stats to include, otherwise only general stats are returned. Comma separated list is allowed. Values: General, Weapons, Medals. (optional) 

            try
            {
                InlineResponse20053 result = apiInstance.Destiny2GetHistoricalStatsForAccount(destinyMembershipId, membershipType, groups);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetHistoricalStatsForAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **destinyMembershipId** | **long?**| The Destiny membershipId of the user to retrieve. | 
 **membershipType** | **int?**| A valid non-BungieNet membership type. | 
 **groups** | [**List<int?>**](int?.md)| Groups of stats to include, otherwise only general stats are returned. Comma separated list is allowed. Values: General, Weapons, Medals. | [optional] 

### Return type

[**InlineResponse20053**](InlineResponse20053.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2getitem"></a>
# **Destiny2GetItem**
> InlineResponse20040 Destiny2GetItem (long? destinyMembershipId, long? itemInstanceId, int? membershipType, List<int?> components)



Retrieve the details of an instanced Destiny Item. An instanced Destiny item is one with an ItemInstanceId. Non-instanced items, such as materials, have no useful instance-specific details and thus are not queryable here.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetApi.Api;
using Org.OpenAPITools.Client;
using BungieNetApi.Model;

namespace Example
{
    public class Destiny2GetItemExample
    {
        public void main()
        {
            
            var apiInstance = new Destiny2Api();
            var destinyMembershipId = 789;  // long? | The membership ID of the destiny profile.
            var itemInstanceId = 789;  // long? | The Instance ID of the destiny item.
            var membershipType = 56;  // int? | A valid non-BungieNet membership type.
            var components = new List<int?>(); // List<int?> | A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results. (optional) 

            try
            {
                InlineResponse20040 result = apiInstance.Destiny2GetItem(destinyMembershipId, itemInstanceId, membershipType, components);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **destinyMembershipId** | **long?**| The membership ID of the destiny profile. | 
 **itemInstanceId** | **long?**| The Instance ID of the destiny item. | 
 **membershipType** | **int?**| A valid non-BungieNet membership type. | 
 **components** | [**List<int?>**](int?.md)| A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results. | [optional] 

### Return type

[**InlineResponse20040**](InlineResponse20040.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2getleaderboards"></a>
# **Destiny2GetLeaderboards**
> InlineResponse20049 Destiny2GetLeaderboards (long? destinyMembershipId, int? membershipType, int? maxtop, string modes, string statid)



Gets leaderboards with the signed in user's friends and the supplied destinyMembershipId as the focus. PREVIEW: This endpoint has not yet been implemented. It is being returned for a preview of future functionality, and for public comment/suggestion/preparation.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetApi.Api;
using Org.OpenAPITools.Client;
using BungieNetApi.Model;

namespace Example
{
    public class Destiny2GetLeaderboardsExample
    {
        public void main()
        {
            
            var apiInstance = new Destiny2Api();
            var destinyMembershipId = 789;  // long? | The Destiny membershipId of the user to retrieve.
            var membershipType = 56;  // int? | A valid non-BungieNet membership type.
            var maxtop = 56;  // int? | Maximum number of top players to return. Use a large number to get entire leaderboard. (optional) 
            var modes = modes_example;  // string | List of game modes for which to get leaderboards. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited. (optional) 
            var statid = statid_example;  // string | ID of stat to return rather than returning all Leaderboard stats. (optional) 

            try
            {
                InlineResponse20049 result = apiInstance.Destiny2GetLeaderboards(destinyMembershipId, membershipType, maxtop, modes, statid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetLeaderboards: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **destinyMembershipId** | **long?**| The Destiny membershipId of the user to retrieve. | 
 **membershipType** | **int?**| A valid non-BungieNet membership type. | 
 **maxtop** | **int?**| Maximum number of top players to return. Use a large number to get entire leaderboard. | [optional] 
 **modes** | **string**| List of game modes for which to get leaderboards. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited. | [optional] 
 **statid** | **string**| ID of stat to return rather than returning all Leaderboard stats. | [optional] 

### Return type

[**InlineResponse20049**](InlineResponse20049.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2getleaderboardsforcharacter"></a>
# **Destiny2GetLeaderboardsForCharacter**
> InlineResponse20049 Destiny2GetLeaderboardsForCharacter (long? characterId, long? destinyMembershipId, int? membershipType, int? maxtop, string modes, string statid)



Gets leaderboards with the signed in user's friends and the supplied destinyMembershipId as the focus. PREVIEW: This endpoint is still in beta, and may experience rough edges. The schema is in final form, but there may be bugs that prevent desirable operation.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetApi.Api;
using Org.OpenAPITools.Client;
using BungieNetApi.Model;

namespace Example
{
    public class Destiny2GetLeaderboardsForCharacterExample
    {
        public void main()
        {
            
            var apiInstance = new Destiny2Api();
            var characterId = 789;  // long? | The specific character to build the leaderboard around for the provided Destiny Membership.
            var destinyMembershipId = 789;  // long? | The Destiny membershipId of the user to retrieve.
            var membershipType = 56;  // int? | A valid non-BungieNet membership type.
            var maxtop = 56;  // int? | Maximum number of top players to return. Use a large number to get entire leaderboard. (optional) 
            var modes = modes_example;  // string | List of game modes for which to get leaderboards. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited. (optional) 
            var statid = statid_example;  // string | ID of stat to return rather than returning all Leaderboard stats. (optional) 

            try
            {
                InlineResponse20049 result = apiInstance.Destiny2GetLeaderboardsForCharacter(characterId, destinyMembershipId, membershipType, maxtop, modes, statid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetLeaderboardsForCharacter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **long?**| The specific character to build the leaderboard around for the provided Destiny Membership. | 
 **destinyMembershipId** | **long?**| The Destiny membershipId of the user to retrieve. | 
 **membershipType** | **int?**| A valid non-BungieNet membership type. | 
 **maxtop** | **int?**| Maximum number of top players to return. Use a large number to get entire leaderboard. | [optional] 
 **modes** | **string**| List of game modes for which to get leaderboards. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited. | [optional] 
 **statid** | **string**| ID of stat to return rather than returning all Leaderboard stats. | [optional] 

### Return type

[**InlineResponse20049**](InlineResponse20049.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2getlinkedprofiles"></a>
# **Destiny2GetLinkedProfiles**
> InlineResponse20036 Destiny2GetLinkedProfiles (long? membershipId, int? membershipType, bool? getAllMemberships)



Returns a summary information about all profiles linked to the requesting membership type/membership ID that have valid Destiny information. The passed-in Membership Type/Membership ID may be a Bungie.Net membership or a Destiny membership. It only returns the minimal amount of data to begin making more substantive requests, but will hopefully serve as a useful alternative to UserServices for people who just care about Destiny data. Note that it will only return linked accounts whose linkages you are allowed to view.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetApi.Api;
using Org.OpenAPITools.Client;
using BungieNetApi.Model;

namespace Example
{
    public class Destiny2GetLinkedProfilesExample
    {
        public void main()
        {
            
            var apiInstance = new Destiny2Api();
            var membershipId = 789;  // long? | The ID of the membership whose linked Destiny accounts you want returned. Make sure your membership ID matches its Membership Type: don't pass us a PSN membership ID and the XBox membership type, it's not going to work!
            var membershipType = 56;  // int? | The type for the membership whose linked Destiny accounts you want returned.
            var getAllMemberships = true;  // bool? | (optional) if set to 'true', all memberships regardless of whether they're obscured by overrides will be returned. Normal privacy restrictions on account linking will still apply no matter what. (optional) 

            try
            {
                InlineResponse20036 result = apiInstance.Destiny2GetLinkedProfiles(membershipId, membershipType, getAllMemberships);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetLinkedProfiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **membershipId** | **long?**| The ID of the membership whose linked Destiny accounts you want returned. Make sure your membership ID matches its Membership Type: don&#39;t pass us a PSN membership ID and the XBox membership type, it&#39;s not going to work! | 
 **membershipType** | **int?**| The type for the membership whose linked Destiny accounts you want returned. | 
 **getAllMemberships** | **bool?**| (optional) if set to &#39;true&#39;, all memberships regardless of whether they&#39;re obscured by overrides will be returned. Normal privacy restrictions on account linking will still apply no matter what. | [optional] 

### Return type

[**InlineResponse20036**](InlineResponse20036.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2getpostgamecarnagereport"></a>
# **Destiny2GetPostGameCarnageReport**
> InlineResponse20047 Destiny2GetPostGameCarnageReport (long? activityId)



Gets the available post game carnage report for the activity ID.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetApi.Api;
using Org.OpenAPITools.Client;
using BungieNetApi.Model;

namespace Example
{
    public class Destiny2GetPostGameCarnageReportExample
    {
        public void main()
        {
            
            var apiInstance = new Destiny2Api();
            var activityId = 789;  // long? | The ID of the activity whose PGCR is requested.

            try
            {
                InlineResponse20047 result = apiInstance.Destiny2GetPostGameCarnageReport(activityId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetPostGameCarnageReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **activityId** | **long?**| The ID of the activity whose PGCR is requested. | 

### Return type

[**InlineResponse20047**](InlineResponse20047.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2getprofile"></a>
# **Destiny2GetProfile**
> InlineResponse20037 Destiny2GetProfile (long? destinyMembershipId, int? membershipType, List<int?> components)



Returns Destiny Profile information for the supplied membership.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetApi.Api;
using Org.OpenAPITools.Client;
using BungieNetApi.Model;

namespace Example
{
    public class Destiny2GetProfileExample
    {
        public void main()
        {
            
            var apiInstance = new Destiny2Api();
            var destinyMembershipId = 789;  // long? | Destiny membership ID.
            var membershipType = 56;  // int? | A valid non-BungieNet membership type.
            var components = new List<int?>(); // List<int?> | A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results. (optional) 

            try
            {
                InlineResponse20037 result = apiInstance.Destiny2GetProfile(destinyMembershipId, membershipType, components);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetProfile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **destinyMembershipId** | **long?**| Destiny membership ID. | 
 **membershipType** | **int?**| A valid non-BungieNet membership type. | 
 **components** | [**List<int?>**](int?.md)| A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results. | [optional] 

### Return type

[**InlineResponse20037**](InlineResponse20037.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2getpublicmilestonecontent"></a>
# **Destiny2GetPublicMilestoneContent**
> InlineResponse20057 Destiny2GetPublicMilestoneContent (int? milestoneHash)



Gets custom localized content for the milestone of the given hash, if it exists.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetApi.Api;
using Org.OpenAPITools.Client;
using BungieNetApi.Model;

namespace Example
{
    public class Destiny2GetPublicMilestoneContentExample
    {
        public void main()
        {
            
            var apiInstance = new Destiny2Api();
            var milestoneHash = 56;  // int? | The identifier for the milestone to be returned.

            try
            {
                InlineResponse20057 result = apiInstance.Destiny2GetPublicMilestoneContent(milestoneHash);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetPublicMilestoneContent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **milestoneHash** | **int?**| The identifier for the milestone to be returned. | 

### Return type

[**InlineResponse20057**](InlineResponse20057.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2getpublicmilestones"></a>
# **Destiny2GetPublicMilestones**
> InlineResponse20058 Destiny2GetPublicMilestones ()



Gets public information about currently available Milestones.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetApi.Api;
using Org.OpenAPITools.Client;
using BungieNetApi.Model;

namespace Example
{
    public class Destiny2GetPublicMilestonesExample
    {
        public void main()
        {
            
            var apiInstance = new Destiny2Api();

            try
            {
                InlineResponse20058 result = apiInstance.Destiny2GetPublicMilestones();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetPublicMilestones: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20058**](InlineResponse20058.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2getpublicvendors"></a>
# **Destiny2GetPublicVendors**
> InlineResponse20043 Destiny2GetPublicVendors (List<int?> components)



Get items available from vendors where the vendors have items for sale that are common for everyone. If any portion of the Vendor's available inventory is character or account specific, we will be unable to return their data from this endpoint due to the way that available inventory is computed. As I am often guilty of saying: 'It's a long story...'

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetApi.Api;
using Org.OpenAPITools.Client;
using BungieNetApi.Model;

namespace Example
{
    public class Destiny2GetPublicVendorsExample
    {
        public void main()
        {
            
            var apiInstance = new Destiny2Api();
            var components = new List<int?>(); // List<int?> | A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results. (optional) 

            try
            {
                InlineResponse20043 result = apiInstance.Destiny2GetPublicVendors(components);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetPublicVendors: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **components** | [**List<int?>**](int?.md)| A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results. | [optional] 

### Return type

[**InlineResponse20043**](InlineResponse20043.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2getuniqueweaponhistory"></a>
# **Destiny2GetUniqueWeaponHistory**
> InlineResponse20055 Destiny2GetUniqueWeaponHistory (long? characterId, long? destinyMembershipId, int? membershipType)



Gets details about unique weapon usage, including all exotic weapons.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetApi.Api;
using Org.OpenAPITools.Client;
using BungieNetApi.Model;

namespace Example
{
    public class Destiny2GetUniqueWeaponHistoryExample
    {
        public void main()
        {
            
            var apiInstance = new Destiny2Api();
            var characterId = 789;  // long? | The id of the character to retrieve.
            var destinyMembershipId = 789;  // long? | The Destiny membershipId of the user to retrieve.
            var membershipType = 56;  // int? | A valid non-BungieNet membership type.

            try
            {
                InlineResponse20055 result = apiInstance.Destiny2GetUniqueWeaponHistory(characterId, destinyMembershipId, membershipType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetUniqueWeaponHistory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **long?**| The id of the character to retrieve. | 
 **destinyMembershipId** | **long?**| The Destiny membershipId of the user to retrieve. | 
 **membershipType** | **int?**| A valid non-BungieNet membership type. | 

### Return type

[**InlineResponse20055**](InlineResponse20055.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2getvendor"></a>
# **Destiny2GetVendor**
> InlineResponse20042 Destiny2GetVendor (long? characterId, long? destinyMembershipId, int? membershipType, int? vendorHash, List<int?> components)



Get the details of a specific Vendor.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetApi.Api;
using Org.OpenAPITools.Client;
using BungieNetApi.Model;

namespace Example
{
    public class Destiny2GetVendorExample
    {
        public void main()
        {
            
            var apiInstance = new Destiny2Api();
            var characterId = 789;  // long? | The Destiny Character ID of the character for whom we're getting vendor info.
            var destinyMembershipId = 789;  // long? | Destiny membership ID of another user. You may be denied.
            var membershipType = 56;  // int? | A valid non-BungieNet membership type.
            var vendorHash = 56;  // int? | The Hash identifier of the Vendor to be returned.
            var components = new List<int?>(); // List<int?> | A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results. (optional) 

            try
            {
                InlineResponse20042 result = apiInstance.Destiny2GetVendor(characterId, destinyMembershipId, membershipType, vendorHash, components);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetVendor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **long?**| The Destiny Character ID of the character for whom we&#39;re getting vendor info. | 
 **destinyMembershipId** | **long?**| Destiny membership ID of another user. You may be denied. | 
 **membershipType** | **int?**| A valid non-BungieNet membership type. | 
 **vendorHash** | **int?**| The Hash identifier of the Vendor to be returned. | 
 **components** | [**List<int?>**](int?.md)| A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results. | [optional] 

### Return type

[**InlineResponse20042**](InlineResponse20042.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2getvendors"></a>
# **Destiny2GetVendors**
> InlineResponse20041 Destiny2GetVendors (long? characterId, long? destinyMembershipId, int? membershipType, List<int?> components)



Get currently available vendors from the list of vendors that can possibly have rotating inventory. Note that this does not include things like preview vendors and vendors-as-kiosks, neither of whom have rotating/dynamic inventories. Use their definitions as-is for those.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetApi.Api;
using Org.OpenAPITools.Client;
using BungieNetApi.Model;

namespace Example
{
    public class Destiny2GetVendorsExample
    {
        public void main()
        {
            
            var apiInstance = new Destiny2Api();
            var characterId = 789;  // long? | The Destiny Character ID of the character for whom we're getting vendor info.
            var destinyMembershipId = 789;  // long? | Destiny membership ID of another user. You may be denied.
            var membershipType = 56;  // int? | A valid non-BungieNet membership type.
            var components = new List<int?>(); // List<int?> | A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results. (optional) 

            try
            {
                InlineResponse20041 result = apiInstance.Destiny2GetVendors(characterId, destinyMembershipId, membershipType, components);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetVendors: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **long?**| The Destiny Character ID of the character for whom we&#39;re getting vendor info. | 
 **destinyMembershipId** | **long?**| Destiny membership ID of another user. You may be denied. | 
 **membershipType** | **int?**| A valid non-BungieNet membership type. | 
 **components** | [**List<int?>**](int?.md)| A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results. | [optional] 

### Return type

[**InlineResponse20041**](InlineResponse20041.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2insertsocketplug"></a>
# **Destiny2InsertSocketPlug**
> InlineResponse20046 Destiny2InsertSocketPlug ()



Insert a plug into a socketed item. I know how it sounds, but I assure you it's much more G-rated than you might be guessing. We haven't decided yet whether this will be able to insert plugs that have side effects, but if we do it will require special scope permission for an application attempting to do so. You must have a valid Destiny Account, and either be in a social space, in orbit, or offline. Request must include proof of permission for 'InsertPlugs' from the account owner.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetApi.Api;
using Org.OpenAPITools.Client;
using BungieNetApi.Model;

namespace Example
{
    public class Destiny2InsertSocketPlugExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Destiny2Api();

            try
            {
                InlineResponse20046 result = apiInstance.Destiny2InsertSocketPlug();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2InsertSocketPlug: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20046**](InlineResponse20046.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2pullfrompostmaster"></a>
# **Destiny2PullFromPostmaster**
> InlineResponse20022 Destiny2PullFromPostmaster ()



Extract an item from the Postmaster, with whatever implications that may entail. You must have a valid Destiny account. You must also pass BOTH a reference AND an instance ID if it's an instanced item.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetApi.Api;
using Org.OpenAPITools.Client;
using BungieNetApi.Model;

namespace Example
{
    public class Destiny2PullFromPostmasterExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Destiny2Api();

            try
            {
                InlineResponse20022 result = apiInstance.Destiny2PullFromPostmaster();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2PullFromPostmaster: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20022**](InlineResponse20022.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2reportoffensivepostgamecarnagereportplayer"></a>
# **Destiny2ReportOffensivePostGameCarnageReportPlayer**
> InlineResponse20022 Destiny2ReportOffensivePostGameCarnageReportPlayer (long? activityId)



Report a player that you met in an activity that was engaging in ToS-violating activities. Both you and the offending player must have played in the activityId passed in. Please use this judiciously and only when you have strong suspicions of violation, pretty please.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetApi.Api;
using Org.OpenAPITools.Client;
using BungieNetApi.Model;

namespace Example
{
    public class Destiny2ReportOffensivePostGameCarnageReportPlayerExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Destiny2Api();
            var activityId = 789;  // long? | The ID of the activity where you ran into the brigand that you're reporting.

            try
            {
                InlineResponse20022 result = apiInstance.Destiny2ReportOffensivePostGameCarnageReportPlayer(activityId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2ReportOffensivePostGameCarnageReportPlayer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **activityId** | **long?**| The ID of the activity where you ran into the brigand that you&#39;re reporting. | 

### Return type

[**InlineResponse20022**](InlineResponse20022.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2searchdestinyentities"></a>
# **Destiny2SearchDestinyEntities**
> InlineResponse20051 Destiny2SearchDestinyEntities (string searchTerm, string type, int? page)



Gets a page list of Destiny items.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetApi.Api;
using Org.OpenAPITools.Client;
using BungieNetApi.Model;

namespace Example
{
    public class Destiny2SearchDestinyEntitiesExample
    {
        public void main()
        {
            
            var apiInstance = new Destiny2Api();
            var searchTerm = searchTerm_example;  // string | The string to use when searching for Destiny entities.
            var type = type_example;  // string | The type of entity for whom you would like results. These correspond to the entity's definition contract name. For instance, if you are looking for items, this property should be 'DestinyInventoryItemDefinition'.
            var page = 56;  // int? | Page number to return, starting with 0. (optional) 

            try
            {
                InlineResponse20051 result = apiInstance.Destiny2SearchDestinyEntities(searchTerm, type, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2SearchDestinyEntities: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchTerm** | **string**| The string to use when searching for Destiny entities. | 
 **type** | **string**| The type of entity for whom you would like results. These correspond to the entity&#39;s definition contract name. For instance, if you are looking for items, this property should be &#39;DestinyInventoryItemDefinition&#39;. | 
 **page** | **int?**| Page number to return, starting with 0. | [optional] 

### Return type

[**InlineResponse20051**](InlineResponse20051.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2searchdestinyplayer"></a>
# **Destiny2SearchDestinyPlayer**
> InlineResponse20035 Destiny2SearchDestinyPlayer (string displayName, int? membershipType, bool? returnOriginalProfile)



Returns a list of Destiny memberships given a full Gamertag or PSN ID. Unless you pass returnOriginalProfile=true, this will return membership information for the users' Primary Cross Save Profile if they are engaged in cross save rather than any original Destiny profile that is now being overridden.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetApi.Api;
using Org.OpenAPITools.Client;
using BungieNetApi.Model;

namespace Example
{
    public class Destiny2SearchDestinyPlayerExample
    {
        public void main()
        {
            
            var apiInstance = new Destiny2Api();
            var displayName = displayName_example;  // string | The full gamertag or PSN id of the player. Spaces and case are ignored.
            var membershipType = 56;  // int? | A valid non-BungieNet membership type, or All.
            var returnOriginalProfile = true;  // bool? | (optional) If passed in and set to true, we will return the original Destiny Profile(s) linked to that gamertag, and not their currently active Destiny Profile. (optional) 

            try
            {
                InlineResponse20035 result = apiInstance.Destiny2SearchDestinyPlayer(displayName, membershipType, returnOriginalProfile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2SearchDestinyPlayer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **displayName** | **string**| The full gamertag or PSN id of the player. Spaces and case are ignored. | 
 **membershipType** | **int?**| A valid non-BungieNet membership type, or All. | 
 **returnOriginalProfile** | **bool?**| (optional) If passed in and set to true, we will return the original Destiny Profile(s) linked to that gamertag, and not their currently active Destiny Profile. | [optional] 

### Return type

[**InlineResponse20035**](InlineResponse20035.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2setitemlockstate"></a>
# **Destiny2SetItemLockState**
> InlineResponse20022 Destiny2SetItemLockState ()



Set the Lock State for an instanced item. You must have a valid Destiny Account.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetApi.Api;
using Org.OpenAPITools.Client;
using BungieNetApi.Model;

namespace Example
{
    public class Destiny2SetItemLockStateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Destiny2Api();

            try
            {
                InlineResponse20022 result = apiInstance.Destiny2SetItemLockState();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2SetItemLockState: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20022**](InlineResponse20022.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2transferitem"></a>
# **Destiny2TransferItem**
> InlineResponse20022 Destiny2TransferItem ()



Transfer an item to/from your vault. You must have a valid Destiny account. You must also pass BOTH a reference AND an instance ID if it's an instanced item. itshappening.gif

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetApi.Api;
using Org.OpenAPITools.Client;
using BungieNetApi.Model;

namespace Example
{
    public class Destiny2TransferItemExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Destiny2Api();

            try
            {
                InlineResponse20022 result = apiInstance.Destiny2TransferItem();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2TransferItem: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20022**](InlineResponse20022.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

