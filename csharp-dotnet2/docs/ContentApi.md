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
> InlineResponse2008 ContentGetContentById (long? id, string locale, bool? head)



Returns a content item referenced by id

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetApi.Api;
using Org.OpenAPITools.Client;
using BungieNetApi.Model;

namespace Example
{
    public class ContentGetContentByIdExample
    {
        public void main()
        {
            
            var apiInstance = new ContentApi();
            var id = 789;  // long? | 
            var locale = locale_example;  // string | 
            var head = true;  // bool? | false (optional) 

            try
            {
                InlineResponse2008 result = apiInstance.ContentGetContentById(id, locale, head);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentApi.ContentGetContentById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**|  | 
 **locale** | **string**|  | 
 **head** | **bool?**| false | [optional] 

### Return type

[**InlineResponse2008**](InlineResponse2008.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contentgetcontentbytagandtype"></a>
# **ContentGetContentByTagAndType**
> InlineResponse2008 ContentGetContentByTagAndType (string locale, string tag, string type, bool? head)



Returns the newest item that matches a given tag and Content Type.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetApi.Api;
using Org.OpenAPITools.Client;
using BungieNetApi.Model;

namespace Example
{
    public class ContentGetContentByTagAndTypeExample
    {
        public void main()
        {
            
            var apiInstance = new ContentApi();
            var locale = locale_example;  // string | 
            var tag = tag_example;  // string | 
            var type = type_example;  // string | 
            var head = true;  // bool? | Not used. (optional) 

            try
            {
                InlineResponse2008 result = apiInstance.ContentGetContentByTagAndType(locale, tag, type, head);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentApi.ContentGetContentByTagAndType: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contentgetcontenttype"></a>
# **ContentGetContentType**
> InlineResponse2007 ContentGetContentType (string type)



Gets an object describing a particular variant of content.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetApi.Api;
using Org.OpenAPITools.Client;
using BungieNetApi.Model;

namespace Example
{
    public class ContentGetContentTypeExample
    {
        public void main()
        {
            
            var apiInstance = new ContentApi();
            var type = type_example;  // string | 

            try
            {
                InlineResponse2007 result = apiInstance.ContentGetContentType(type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentApi.ContentGetContentType: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contentsearchcontentbytagandtype"></a>
# **ContentSearchContentByTagAndType**
> InlineResponse2009 ContentSearchContentByTagAndType (string locale, string tag, string type, int? currentpage, bool? head, int? itemsperpage)



Searches for Content Items that match the given Tag and Content Type.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetApi.Api;
using Org.OpenAPITools.Client;
using BungieNetApi.Model;

namespace Example
{
    public class ContentSearchContentByTagAndTypeExample
    {
        public void main()
        {
            
            var apiInstance = new ContentApi();
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
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentApi.ContentSearchContentByTagAndType: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contentsearchcontentwithtext"></a>
# **ContentSearchContentWithText**
> InlineResponse2009 ContentSearchContentWithText (string locale, string ctype, int? currentpage, bool? head, string searchtext, string source, string tag)



Gets content based on querystring information passed in. Provides basic search and text search capabilities.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetApi.Api;
using Org.OpenAPITools.Client;
using BungieNetApi.Model;

namespace Example
{
    public class ContentSearchContentWithTextExample
    {
        public void main()
        {
            
            var apiInstance = new ContentApi();
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
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentApi.ContentSearchContentWithText: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contentsearchhelparticles"></a>
# **ContentSearchHelpArticles**
> InlineResponse20010 ContentSearchHelpArticles (string searchtext, string size)



Search for Help Articles.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetApi.Api;
using Org.OpenAPITools.Client;
using BungieNetApi.Model;

namespace Example
{
    public class ContentSearchHelpArticlesExample
    {
        public void main()
        {
            
            var apiInstance = new ContentApi();
            var searchtext = searchtext_example;  // string | 
            var size = size_example;  // string | 

            try
            {
                InlineResponse20010 result = apiInstance.ContentSearchHelpArticles(searchtext, size);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentApi.ContentSearchHelpArticles: " + e.Message );
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

