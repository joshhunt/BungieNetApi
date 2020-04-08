# BungieNetApi.Api.AppApi

All URIs are relative to *https://www.bungie.net/Platform*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AppGetApplicationApiUsage**](AppApi.md#appgetapplicationapiusage) | **GET** /App/ApiUsage/{applicationId}/ | 
[**AppGetBungieApplications**](AppApi.md#appgetbungieapplications) | **GET** /App/FirstParty/ | 



## AppGetApplicationApiUsage

> InlineResponse200 AppGetApplicationApiUsage (int applicationId, DateTime end = null, DateTime start = null)



Get API usage by application for time frame specified. You can go as far back as 30 days ago, and can ask for up to a 48 hour window of time in a single request. You must be authenticated with at least the ReadUserData permission to access this endpoint.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BungieNetApi.Api;
using BungieNetApi.Client;
using BungieNetApi.Model;

namespace Example
{
    public class AppGetApplicationApiUsageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://www.bungie.net/Platform";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppApi(Configuration.Default);
            var applicationId = 56;  // int | ID of the application to get usage statistics.
            var end = 2013-10-20T19:20:30+01:00;  // DateTime | End time for query. Goes to now if not specified. (optional) 
            var start = 2013-10-20T19:20:30+01:00;  // DateTime | Start time for query. Goes to 24 hours ago if not specified. (optional) 

            try
            {
                InlineResponse200 result = apiInstance.AppGetApplicationApiUsage(applicationId, end, start);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AppApi.AppGetApplicationApiUsage: " + e.Message );
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
 **applicationId** | **int**| ID of the application to get usage statistics. | 
 **end** | **DateTime**| End time for query. Goes to now if not specified. | [optional] 
 **start** | **DateTime**| Start time for query. Goes to 24 hours ago if not specified. | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

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


## AppGetBungieApplications

> InlineResponse2001 AppGetBungieApplications ()



Get list of applications created by Bungie.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BungieNetApi.Api;
using BungieNetApi.Client;
using BungieNetApi.Model;

namespace Example
{
    public class AppGetBungieApplicationsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new AppApi(Configuration.Default);

            try
            {
                InlineResponse2001 result = apiInstance.AppGetBungieApplications();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AppApi.AppGetBungieApplications: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

No authorization required

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

