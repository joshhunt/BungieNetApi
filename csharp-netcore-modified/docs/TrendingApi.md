# BungieNetApi.Api.TrendingApi

All URIs are relative to *https://www.bungie.net/Platform*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TrendingGetTrendingCategories**](TrendingApi.md#trendinggettrendingcategories) | **GET** /Trending/Categories/ | 
[**TrendingGetTrendingCategory**](TrendingApi.md#trendinggettrendingcategory) | **GET** /Trending/Categories/{categoryId}/{pageNumber}/ | 
[**TrendingGetTrendingEntryDetail**](TrendingApi.md#trendinggettrendingentrydetail) | **GET** /Trending/Details/{trendingEntryType}/{identifier}/ | 


<a name="trendinggettrendingcategories"></a>
# **TrendingGetTrendingCategories**
> InlineResponse20061 TrendingGetTrendingCategories ()



Returns trending items for Bungie.net, collapsed into the first page of items per category. For pagination within a category, call GetTrendingCategory.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BungieNetApi.Api;
using BungieNetApi.Client;
using BungieNetApi.Model;

namespace Example
{
    public class TrendingGetTrendingCategoriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new TrendingApi(config);

            try
            {
                InlineResponse20061 result = apiInstance.TrendingGetTrendingCategories();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TrendingApi.TrendingGetTrendingCategories: " + e.Message );
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

[**InlineResponse20061**](InlineResponse20061.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Look at the Response property for more information about the nature of this response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="trendinggettrendingcategory"></a>
# **TrendingGetTrendingCategory**
> InlineResponse20062 TrendingGetTrendingCategory (string categoryId, int pageNumber)



Returns paginated lists of trending items for a category.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BungieNetApi.Api;
using BungieNetApi.Client;
using BungieNetApi.Model;

namespace Example
{
    public class TrendingGetTrendingCategoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new TrendingApi(config);
            var categoryId = categoryId_example;  // string | The ID of the category for whom you want additional results.
            var pageNumber = 56;  // int | The page # of results to return.

            try
            {
                InlineResponse20062 result = apiInstance.TrendingGetTrendingCategory(categoryId, pageNumber);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TrendingApi.TrendingGetTrendingCategory: " + e.Message );
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
 **categoryId** | **string**| The ID of the category for whom you want additional results. | 
 **pageNumber** | **int**| The page # of results to return. | 

### Return type

[**InlineResponse20062**](InlineResponse20062.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Look at the Response property for more information about the nature of this response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="trendinggettrendingentrydetail"></a>
# **TrendingGetTrendingEntryDetail**
> InlineResponse20063 TrendingGetTrendingEntryDetail (string identifier, int trendingEntryType)



Returns the detailed results for a specific trending entry. Note that trending entries are uniquely identified by a combination of *both* the TrendingEntryType *and* the identifier: the identifier alone is not guaranteed to be globally unique.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BungieNetApi.Api;
using BungieNetApi.Client;
using BungieNetApi.Model;

namespace Example
{
    public class TrendingGetTrendingEntryDetailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new TrendingApi(config);
            var identifier = identifier_example;  // string | The identifier for the entity to be returned.
            var trendingEntryType = 56;  // int | The type of entity to be returned.

            try
            {
                InlineResponse20063 result = apiInstance.TrendingGetTrendingEntryDetail(identifier, trendingEntryType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TrendingApi.TrendingGetTrendingEntryDetail: " + e.Message );
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
 **identifier** | **string**| The identifier for the entity to be returned. | 
 **trendingEntryType** | **int**| The type of entity to be returned. | 

### Return type

[**InlineResponse20063**](InlineResponse20063.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Look at the Response property for more information about the nature of this response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

