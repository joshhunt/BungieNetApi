# BungieNetApi.Api.PreviewApi

All URIs are relative to *https://www.bungie.net/Platform*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Destiny2GetClanAggregateStats**](PreviewApi.md#destiny2getclanaggregatestats) | **GET** /Destiny2/Stats/AggregateClanStats/{groupId}/ | 
[**Destiny2GetClanLeaderboards**](PreviewApi.md#destiny2getclanleaderboards) | **GET** /Destiny2/Stats/Leaderboards/Clans/{groupId}/ | 
[**Destiny2GetLeaderboards**](PreviewApi.md#destiny2getleaderboards) | **GET** /Destiny2/{membershipType}/Account/{destinyMembershipId}/Stats/Leaderboards/ | 
[**Destiny2GetLeaderboardsForCharacter**](PreviewApi.md#destiny2getleaderboardsforcharacter) | **GET** /Destiny2/Stats/Leaderboards/{membershipType}/{destinyMembershipId}/{characterId}/ | 
[**Destiny2GetPublicVendors**](PreviewApi.md#destiny2getpublicvendors) | **GET** /Destiny2//Vendors/ | 
[**Destiny2InsertSocketPlug**](PreviewApi.md#destiny2insertsocketplug) | **POST** /Destiny2/Actions/Items/InsertSocketPlug/ | 


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
            
            var apiInstance = new PreviewApi();
            var groupId = 789;  // long? | Group ID of the clan whose leaderboards you wish to fetch.
            var modes = modes_example;  // string | List of game modes for which to get leaderboards. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited. (optional) 

            try
            {
                InlineResponse20050 result = apiInstance.Destiny2GetClanAggregateStats(groupId, modes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PreviewApi.Destiny2GetClanAggregateStats: " + e.Message );
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
            
            var apiInstance = new PreviewApi();
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
                Debug.Print("Exception when calling PreviewApi.Destiny2GetClanLeaderboards: " + e.Message );
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
            
            var apiInstance = new PreviewApi();
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
                Debug.Print("Exception when calling PreviewApi.Destiny2GetLeaderboards: " + e.Message );
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
            
            var apiInstance = new PreviewApi();
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
                Debug.Print("Exception when calling PreviewApi.Destiny2GetLeaderboardsForCharacter: " + e.Message );
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
            
            var apiInstance = new PreviewApi();
            var components = new List<int?>(); // List<int?> | A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results. (optional) 

            try
            {
                InlineResponse20043 result = apiInstance.Destiny2GetPublicVendors(components);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PreviewApi.Destiny2GetPublicVendors: " + e.Message );
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

            var apiInstance = new PreviewApi();

            try
            {
                InlineResponse20046 result = apiInstance.Destiny2InsertSocketPlug();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PreviewApi.Destiny2InsertSocketPlug: " + e.Message );
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

