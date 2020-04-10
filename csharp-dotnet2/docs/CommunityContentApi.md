# BungieNetApi.Api.CommunityContentApi

All URIs are relative to *https://www.bungie.net/Platform*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CommunityContentGetCommunityContent**](CommunityContentApi.md#communitycontentgetcommunitycontent) | **GET** /CommunityContent/Get/{sort}/{mediaFilter}/{page}/ | 


<a name="communitycontentgetcommunitycontent"></a>
# **CommunityContentGetCommunityContent**
> InlineResponse20011 CommunityContentGetCommunityContent (int? mediaFilter, int? page, int? sort)



Returns community content.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetApi.Api;
using Org.OpenAPITools.Client;
using BungieNetApi.Model;

namespace Example
{
    public class CommunityContentGetCommunityContentExample
    {
        public void main()
        {
            
            var apiInstance = new CommunityContentApi();
            var mediaFilter = 56;  // int? | The type of media to get
            var page = 56;  // int? | Zero based page
            var sort = 56;  // int? | The sort mode.

            try
            {
                InlineResponse20011 result = apiInstance.CommunityContentGetCommunityContent(mediaFilter, page, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommunityContentApi.CommunityContentGetCommunityContent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mediaFilter** | **int?**| The type of media to get | 
 **page** | **int?**| Zero based page | 
 **sort** | **int?**| The sort mode. | 

### Return type

[**InlineResponse20011**](InlineResponse20011.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

