# BungieNetApi.Api.ContentApi

All URIs are relative to *https://www.bungie.net/Platform*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ContentGetContentById**](ContentApi.md#contentgetcontentbyid) | **GET** /Content/GetContentById/{id}/{locale}/ | 
[**ContentGetContentByTagAndType**](ContentApi.md#contentgetcontentbytagandtype) | **GET** /Content/GetContentByTagAndType/{tag}/{type}/{locale}/ | 
[**ContentGetContentType**](ContentApi.md#contentgetcontenttype) | **GET** /Content/GetContentType/{type}/ | 
[**ContentSearchContentByTagAndType**](ContentApi.md#contentsearchcontentbytagandtype) | **GET** /Content/SearchContentByTagAndType/{tag}/{type}/{locale}/ | 
[**ContentSearchContentWithText**](ContentApi.md#contentsearchcontentwithtext) | **GET** /Content/Search/{locale}/ | 
[**ContentSearchHelpArticles**](ContentApi.md#contentsearchhelparticles) | **GET** /Content/SearchHelpArticles/{searchtext}/{size}/ | 


<a name="contentgetcontentbyid"></a>
# **ContentGetContentById**
> InlineResponse2008 ContentGetContentById (long id, string locale, bool? head = null)



Returns a content item referenced by id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BungieNetApi.Api;
using BungieNetApi.Client;
using BungieNetApi.Model;

namespace Example
{
    public class ContentGetContentByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new ContentApi(config);
            var id = 789;  // long | 
            var locale = locale_example;  // string | 
            var head = true;  // bool? | false (optional) 

            try
            {
                InlineResponse2008 result = apiInstance.ContentGetContentById(id, locale, head);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentApi.ContentGetContentById: " + e.Message );
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
 **id** | **long**|  | 
 **locale** | **string**|  | 
 **head** | **bool?**| false | [optional] 

### Return type

[**InlineResponse2008**](InlineResponse2008.md)

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

<a name="contentgetcontentbytagandtype"></a>
# **ContentGetContentByTagAndType**
> InlineResponse2008 ContentGetContentByTagAndType (string locale, string tag, string type, bool? head = null)



Returns the newest item that matches a given tag and Content Type.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BungieNetApi.Api;
using BungieNetApi.Client;
using BungieNetApi.Model;

namespace Example
{
    public class ContentGetContentByTagAndTypeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new ContentApi(config);
            var locale = locale_example;  // string | 
            var tag = tag_example;  // string | 
            var type = type_example;  // string | 
            var head = true;  // bool? | Not used. (optional) 

            try
            {
                InlineResponse2008 result = apiInstance.ContentGetContentByTagAndType(locale, tag, type, head);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentApi.ContentGetContentByTagAndType: " + e.Message );
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
 **locale** | **string**|  | 
 **tag** | **string**|  | 
 **type** | **string**|  | 
 **head** | **bool?**| Not used. | [optional] 

### Return type

[**InlineResponse2008**](InlineResponse2008.md)

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

<a name="contentgetcontenttype"></a>
# **ContentGetContentType**
> InlineResponse2007 ContentGetContentType (string type)



Gets an object describing a particular variant of content.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BungieNetApi.Api;
using BungieNetApi.Client;
using BungieNetApi.Model;

namespace Example
{
    public class ContentGetContentTypeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new ContentApi(config);
            var type = type_example;  // string | 

            try
            {
                InlineResponse2007 result = apiInstance.ContentGetContentType(type);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentApi.ContentGetContentType: " + e.Message );
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
 **type** | **string**|  | 

### Return type

[**InlineResponse2007**](InlineResponse2007.md)

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

<a name="contentsearchcontentbytagandtype"></a>
# **ContentSearchContentByTagAndType**
> InlineResponse2009 ContentSearchContentByTagAndType (string locale, string tag, string type, int? currentpage = null, bool? head = null, int? itemsperpage = null)



Searches for Content Items that match the given Tag and Content Type.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BungieNetApi.Api;
using BungieNetApi.Client;
using BungieNetApi.Model;

namespace Example
{
    public class ContentSearchContentByTagAndTypeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new ContentApi(config);
            var locale = locale_example;  // string | 
            var tag = tag_example;  // string | 
            var type = type_example;  // string | 
            var currentpage = 56;  // int? | Page number for the search results starting with page 1. (optional) 
            var head = true;  // bool? | Not used. (optional) 
            var itemsperpage = 56;  // int? | Not used. (optional) 

            try
            {
                InlineResponse2009 result = apiInstance.ContentSearchContentByTagAndType(locale, tag, type, currentpage, head, itemsperpage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentApi.ContentSearchContentByTagAndType: " + e.Message );
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
 **locale** | **string**|  | 
 **tag** | **string**|  | 
 **type** | **string**|  | 
 **currentpage** | **int?**| Page number for the search results starting with page 1. | [optional] 
 **head** | **bool?**| Not used. | [optional] 
 **itemsperpage** | **int?**| Not used. | [optional] 

### Return type

[**InlineResponse2009**](InlineResponse2009.md)

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

<a name="contentsearchcontentwithtext"></a>
# **ContentSearchContentWithText**
> InlineResponse2009 ContentSearchContentWithText (string locale, string ctype = null, int? currentpage = null, bool? head = null, string searchtext = null, string source = null, string tag = null)



Gets content based on querystring information passed in. Provides basic search and text search capabilities.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BungieNetApi.Api;
using BungieNetApi.Client;
using BungieNetApi.Model;

namespace Example
{
    public class ContentSearchContentWithTextExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new ContentApi(config);
            var locale = locale_example;  // string | 
            var ctype = ctype_example;  // string | Content type tag: Help, News, etc. Supply multiple ctypes separated by space. (optional) 
            var currentpage = 56;  // int? | Page number for the search results, starting with page 1. (optional) 
            var head = true;  // bool? | Not used. (optional) 
            var searchtext = searchtext_example;  // string | Word or phrase for the search. (optional) 
            var source = source_example;  // string | For analytics, hint at the part of the app that triggered the search. Optional. (optional) 
            var tag = tag_example;  // string | Tag used on the content to be searched. (optional) 

            try
            {
                InlineResponse2009 result = apiInstance.ContentSearchContentWithText(locale, ctype, currentpage, head, searchtext, source, tag);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentApi.ContentSearchContentWithText: " + e.Message );
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
 **locale** | **string**|  | 
 **ctype** | **string**| Content type tag: Help, News, etc. Supply multiple ctypes separated by space. | [optional] 
 **currentpage** | **int?**| Page number for the search results, starting with page 1. | [optional] 
 **head** | **bool?**| Not used. | [optional] 
 **searchtext** | **string**| Word or phrase for the search. | [optional] 
 **source** | **string**| For analytics, hint at the part of the app that triggered the search. Optional. | [optional] 
 **tag** | **string**| Tag used on the content to be searched. | [optional] 

### Return type

[**InlineResponse2009**](InlineResponse2009.md)

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

<a name="contentsearchhelparticles"></a>
# **ContentSearchHelpArticles**
> InlineResponse20010 ContentSearchHelpArticles (string searchtext, string size)



Search for Help Articles.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BungieNetApi.Api;
using BungieNetApi.Client;
using BungieNetApi.Model;

namespace Example
{
    public class ContentSearchHelpArticlesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new ContentApi(config);
            var searchtext = searchtext_example;  // string | 
            var size = size_example;  // string | 

            try
            {
                InlineResponse20010 result = apiInstance.ContentSearchHelpArticles(searchtext, size);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContentApi.ContentSearchHelpArticles: " + e.Message );
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
 **searchtext** | **string**|  | 
 **size** | **string**|  | 

### Return type

[**InlineResponse20010**](InlineResponse20010.md)

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

