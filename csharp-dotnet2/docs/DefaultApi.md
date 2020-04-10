# BungieNetApi.Api.DefaultApi

All URIs are relative to *https://www.bungie.net/Platform*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAvailableLocales**](DefaultApi.md#getavailablelocales) | **GET** /GetAvailableLocales/ | 
[**GetCommonSettings**](DefaultApi.md#getcommonsettings) | **GET** /Settings/ | 
[**GetGlobalAlerts**](DefaultApi.md#getglobalalerts) | **GET** /GlobalAlerts/ | 


<a name="getavailablelocales"></a>
# **GetAvailableLocales**
> InlineResponse20015 GetAvailableLocales ()



List of available localization cultures

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetApi.Api;
using Org.OpenAPITools.Client;
using BungieNetApi.Model;

namespace Example
{
    public class GetAvailableLocalesExample
    {
        public void main()
        {
            
            var apiInstance = new DefaultApi();

            try
            {
                InlineResponse20015 result = apiInstance.GetAvailableLocales();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetAvailableLocales: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20015**](InlineResponse20015.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcommonsettings"></a>
# **GetCommonSettings**
> InlineResponse20067 GetCommonSettings ()



Get the common settings used by the Bungie.Net environment.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetApi.Api;
using Org.OpenAPITools.Client;
using BungieNetApi.Model;

namespace Example
{
    public class GetCommonSettingsExample
    {
        public void main()
        {
            
            var apiInstance = new DefaultApi();

            try
            {
                InlineResponse20067 result = apiInstance.GetCommonSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetCommonSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20067**](InlineResponse20067.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getglobalalerts"></a>
# **GetGlobalAlerts**
> InlineResponse20068 GetGlobalAlerts (bool? includestreaming)



Gets any active global alert for display in the forum banners, help pages, etc. Usually used for DOC alerts.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetApi.Api;
using Org.OpenAPITools.Client;
using BungieNetApi.Model;

namespace Example
{
    public class GetGlobalAlertsExample
    {
        public void main()
        {
            
            var apiInstance = new DefaultApi();
            var includestreaming = true;  // bool? | Determines whether Streaming Alerts are included in results (optional) 

            try
            {
                InlineResponse20068 result = apiInstance.GetGlobalAlerts(includestreaming);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetGlobalAlerts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **includestreaming** | **bool?**| Determines whether Streaming Alerts are included in results | [optional] 

### Return type

[**InlineResponse20068**](InlineResponse20068.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

