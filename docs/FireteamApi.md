# BungieNetApi.Api.FireteamApi

All URIs are relative to *https://www.bungie.net/Platform*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FireteamGetActivePrivateClanFireteamCount**](FireteamApi.md#fireteamgetactiveprivateclanfireteamcount) | **GET** /Fireteam/Clan/{groupId}/ActiveCount/ | 
[**FireteamGetAvailableClanFireteams**](FireteamApi.md#fireteamgetavailableclanfireteams) | **GET** /Fireteam/Clan/{groupId}/Available/{platform}/{activityType}/{dateRange}/{slotFilter}/{publicOnly}/{page}/ | 
[**FireteamGetClanFireteam**](FireteamApi.md#fireteamgetclanfireteam) | **GET** /Fireteam/Clan/{groupId}/Summary/{fireteamId}/ | 
[**FireteamGetMyClanFireteams**](FireteamApi.md#fireteamgetmyclanfireteams) | **GET** /Fireteam/Clan/{groupId}/My/{platform}/{includeClosed}/{page}/ | 
[**FireteamSearchPublicAvailableClanFireteams**](FireteamApi.md#fireteamsearchpublicavailableclanfireteams) | **GET** /Fireteam/Search/Available/{platform}/{activityType}/{dateRange}/{slotFilter}/{page}/ | 



## FireteamGetActivePrivateClanFireteamCount

> InlineResponse20022 FireteamGetActivePrivateClanFireteamCount (long groupId)



Gets a count of all active non-public fireteams for the specified clan. Maximum value returned is 25.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BungieNetApi.Api;
using BungieNetApi.Client;
using BungieNetApi.Model;

namespace Example
{
    public class FireteamGetActivePrivateClanFireteamCountExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FireteamApi(Configuration.Default);
            var groupId = 789;  // long | The group id of the clan.

            try
            {
                InlineResponse20022 result = apiInstance.FireteamGetActivePrivateClanFireteamCount(groupId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FireteamApi.FireteamGetActivePrivateClanFireteamCount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **long**| The group id of the clan. | 

### Return type

[**InlineResponse20022**](InlineResponse20022.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: */*

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Look at the Response property for more information about the nature of this response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## FireteamGetAvailableClanFireteams

> InlineResponse20064 FireteamGetAvailableClanFireteams (int activityType, int dateRange, long groupId, int page, int platform, int publicOnly, int slotFilter, string langFilter = null)



Gets a listing of all of this clan's fireteams that are have available slots. Caller is not checked for join criteria so caching is maximized.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BungieNetApi.Api;
using BungieNetApi.Client;
using BungieNetApi.Model;

namespace Example
{
    public class FireteamGetAvailableClanFireteamsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FireteamApi(Configuration.Default);
            var activityType = 56;  // int | The activity type to filter by.
            var dateRange = 56;  // int | The date range to grab available fireteams.
            var groupId = 789;  // long | The group id of the clan.
            var page = 56;  // int | Zero based page
            var platform = 56;  // int | The platform filter.
            var publicOnly = 56;  // int | Determines public/private filtering.
            var slotFilter = 56;  // int | Filters based on available slots
            var langFilter = langFilter_example;  // string | An optional language filter. (optional) 

            try
            {
                InlineResponse20064 result = apiInstance.FireteamGetAvailableClanFireteams(activityType, dateRange, groupId, page, platform, publicOnly, slotFilter, langFilter);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FireteamApi.FireteamGetAvailableClanFireteams: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **activityType** | **int**| The activity type to filter by. | 
 **dateRange** | **int**| The date range to grab available fireteams. | 
 **groupId** | **long**| The group id of the clan. | 
 **page** | **int**| Zero based page | 
 **platform** | **int**| The platform filter. | 
 **publicOnly** | **int**| Determines public/private filtering. | 
 **slotFilter** | **int**| Filters based on available slots | 
 **langFilter** | **string**| An optional language filter. | [optional] 

### Return type

[**InlineResponse20064**](InlineResponse20064.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: */*

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Look at the Response property for more information about the nature of this response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## FireteamGetClanFireteam

> InlineResponse20066 FireteamGetClanFireteam (long fireteamId, long groupId)



Gets a specific clan fireteam.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BungieNetApi.Api;
using BungieNetApi.Client;
using BungieNetApi.Model;

namespace Example
{
    public class FireteamGetClanFireteamExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FireteamApi(Configuration.Default);
            var fireteamId = 789;  // long | The unique id of the fireteam.
            var groupId = 789;  // long | The group id of the clan.

            try
            {
                InlineResponse20066 result = apiInstance.FireteamGetClanFireteam(fireteamId, groupId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FireteamApi.FireteamGetClanFireteam: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fireteamId** | **long**| The unique id of the fireteam. | 
 **groupId** | **long**| The group id of the clan. | 

### Return type

[**InlineResponse20066**](InlineResponse20066.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: */*

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Look at the Response property for more information about the nature of this response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## FireteamGetMyClanFireteams

> InlineResponse20065 FireteamGetMyClanFireteams (long groupId, bool includeClosed, int page, int platform, bool groupFilter = null, string langFilter = null)



Gets a listing of all clan fireteams that caller is an applicant, a member, or an alternate of.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BungieNetApi.Api;
using BungieNetApi.Client;
using BungieNetApi.Model;

namespace Example
{
    public class FireteamGetMyClanFireteamsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FireteamApi(Configuration.Default);
            var groupId = 789;  // long | The group id of the clan. (This parameter is ignored unless the optional query parameter groupFilter is true).
            var includeClosed = true;  // bool | If true, return fireteams that have been closed.
            var page = 56;  // int | Deprecated parameter, ignored.
            var platform = 56;  // int | The platform filter.
            var groupFilter = true;  // bool | If true, filter by clan. Otherwise, ignore the clan and show all of the user's fireteams. (optional) 
            var langFilter = langFilter_example;  // string | An optional language filter. (optional) 

            try
            {
                InlineResponse20065 result = apiInstance.FireteamGetMyClanFireteams(groupId, includeClosed, page, platform, groupFilter, langFilter);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FireteamApi.FireteamGetMyClanFireteams: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **long**| The group id of the clan. (This parameter is ignored unless the optional query parameter groupFilter is true). | 
 **includeClosed** | **bool**| If true, return fireteams that have been closed. | 
 **page** | **int**| Deprecated parameter, ignored. | 
 **platform** | **int**| The platform filter. | 
 **groupFilter** | **bool**| If true, filter by clan. Otherwise, ignore the clan and show all of the user&#39;s fireteams. | [optional] 
 **langFilter** | **string**| An optional language filter. | [optional] 

### Return type

[**InlineResponse20065**](InlineResponse20065.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: */*

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Look at the Response property for more information about the nature of this response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## FireteamSearchPublicAvailableClanFireteams

> InlineResponse20064 FireteamSearchPublicAvailableClanFireteams (int activityType, int dateRange, int page, int platform, int slotFilter, string langFilter = null)



Gets a listing of all public fireteams starting now with open slots. Caller is not checked for join criteria so caching is maximized.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BungieNetApi.Api;
using BungieNetApi.Client;
using BungieNetApi.Model;

namespace Example
{
    public class FireteamSearchPublicAvailableClanFireteamsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FireteamApi(Configuration.Default);
            var activityType = 56;  // int | The activity type to filter by.
            var dateRange = 56;  // int | The date range to grab available fireteams.
            var page = 56;  // int | Zero based page
            var platform = 56;  // int | The platform filter.
            var slotFilter = 56;  // int | Filters based on available slots
            var langFilter = langFilter_example;  // string | An optional language filter. (optional) 

            try
            {
                InlineResponse20064 result = apiInstance.FireteamSearchPublicAvailableClanFireteams(activityType, dateRange, page, platform, slotFilter, langFilter);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FireteamApi.FireteamSearchPublicAvailableClanFireteams: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **activityType** | **int**| The activity type to filter by. | 
 **dateRange** | **int**| The date range to grab available fireteams. | 
 **page** | **int**| Zero based page | 
 **platform** | **int**| The platform filter. | 
 **slotFilter** | **int**| Filters based on available slots | 
 **langFilter** | **string**| An optional language filter. | [optional] 

### Return type

[**InlineResponse20064**](InlineResponse20064.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: */*

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Look at the Response property for more information about the nature of this response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

