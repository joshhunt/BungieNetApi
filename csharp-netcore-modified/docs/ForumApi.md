# BungieNetApi.Api.ForumApi

All URIs are relative to *https://www.bungie.net/Platform*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ForumGetCoreTopicsPaged**](ForumApi.md#forumgetcoretopicspaged) | **GET** /Forum/GetCoreTopicsPaged/{page}/{sort}/{quickDate}/{categoryFilter}/ | 
[**ForumGetForumTagSuggestions**](ForumApi.md#forumgetforumtagsuggestions) | **GET** /Forum/GetForumTagSuggestions/ | 
[**ForumGetPoll**](ForumApi.md#forumgetpoll) | **GET** /Forum/Poll/{topicId}/ | 
[**ForumGetPostAndParent**](ForumApi.md#forumgetpostandparent) | **GET** /Forum/GetPostAndParent/{childPostId}/ | 
[**ForumGetPostAndParentAwaitingApproval**](ForumApi.md#forumgetpostandparentawaitingapproval) | **GET** /Forum/GetPostAndParentAwaitingApproval/{childPostId}/ | 
[**ForumGetPostsThreadedPaged**](ForumApi.md#forumgetpoststhreadedpaged) | **GET** /Forum/GetPostsThreadedPaged/{parentPostId}/{page}/{pageSize}/{replySize}/{getParentPost}/{rootThreadMode}/{sortMode}/ | 
[**ForumGetPostsThreadedPagedFromChild**](ForumApi.md#forumgetpoststhreadedpagedfromchild) | **GET** /Forum/GetPostsThreadedPagedFromChild/{childPostId}/{page}/{pageSize}/{replySize}/{rootThreadMode}/{sortMode}/ | 
[**ForumGetRecruitmentThreadSummaries**](ForumApi.md#forumgetrecruitmentthreadsummaries) | **POST** /Forum/Recruit/Summaries/ | 
[**ForumGetTopicForContent**](ForumApi.md#forumgettopicforcontent) | **GET** /Forum/GetTopicForContent/{contentId}/ | 
[**ForumGetTopicsPaged**](ForumApi.md#forumgettopicspaged) | **GET** /Forum/GetTopicsPaged/{page}/{pageSize}/{group}/{sort}/{quickDate}/{categoryFilter}/ | 


<a name="forumgetcoretopicspaged"></a>
# **ForumGetCoreTopicsPaged**
> InlineResponse20011 ForumGetCoreTopicsPaged (int categoryFilter, int page, int quickDate, int sort, string locales = null)



Gets a listing of all topics marked as part of the core group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BungieNetApi.Api;
using BungieNetApi.Client;
using BungieNetApi.Model;

namespace Example
{
    public class ForumGetCoreTopicsPagedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new ForumApi(config);
            var categoryFilter = 56;  // int | The category filter.
            var page = 56;  // int | Zero base page
            var quickDate = 56;  // int | The date filter.
            var sort = 56;  // int | The sort mode.
            var locales = locales_example;  // string | Comma seperated list of locales posts must match to return in the result list. Default 'en' (optional) 

            try
            {
                InlineResponse20011 result = apiInstance.ForumGetCoreTopicsPaged(categoryFilter, page, quickDate, sort, locales);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.ForumGetCoreTopicsPaged: " + e.Message );
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
 **categoryFilter** | **int**| The category filter. | 
 **page** | **int**| Zero base page | 
 **quickDate** | **int**| The date filter. | 
 **sort** | **int**| The sort mode. | 
 **locales** | **string**| Comma seperated list of locales posts must match to return in the result list. Default &#39;en&#39; | [optional] 

### Return type

[**InlineResponse20011**](InlineResponse20011.md)

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

<a name="forumgetforumtagsuggestions"></a>
# **ForumGetForumTagSuggestions**
> InlineResponse20013 ForumGetForumTagSuggestions (string partialtag = null)



Gets tag suggestions based on partial text entry, matching them with other tags previously used in the forums.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BungieNetApi.Api;
using BungieNetApi.Client;
using BungieNetApi.Model;

namespace Example
{
    public class ForumGetForumTagSuggestionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new ForumApi(config);
            var partialtag = partialtag_example;  // string | The partial tag input to generate suggestions from. (optional) 

            try
            {
                InlineResponse20013 result = apiInstance.ForumGetForumTagSuggestions(partialtag);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.ForumGetForumTagSuggestions: " + e.Message );
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
 **partialtag** | **string**| The partial tag input to generate suggestions from. | [optional] 

### Return type

[**InlineResponse20013**](InlineResponse20013.md)

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

<a name="forumgetpoll"></a>
# **ForumGetPoll**
> InlineResponse20011 ForumGetPoll (long topicId)



Gets the specified forum poll.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BungieNetApi.Api;
using BungieNetApi.Client;
using BungieNetApi.Model;

namespace Example
{
    public class ForumGetPollExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new ForumApi(config);
            var topicId = 789;  // long | The post id of the topic that has the poll.

            try
            {
                InlineResponse20011 result = apiInstance.ForumGetPoll(topicId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.ForumGetPoll: " + e.Message );
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
 **topicId** | **long**| The post id of the topic that has the poll. | 

### Return type

[**InlineResponse20011**](InlineResponse20011.md)

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

<a name="forumgetpostandparent"></a>
# **ForumGetPostAndParent**
> InlineResponse20011 ForumGetPostAndParent (long childPostId, string showbanned = null)



Returns the post specified and its immediate parent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BungieNetApi.Api;
using BungieNetApi.Client;
using BungieNetApi.Model;

namespace Example
{
    public class ForumGetPostAndParentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new ForumApi(config);
            var childPostId = 789;  // long | 
            var showbanned = showbanned_example;  // string | If this value is not null or empty, banned posts are requested to be returned (optional) 

            try
            {
                InlineResponse20011 result = apiInstance.ForumGetPostAndParent(childPostId, showbanned);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.ForumGetPostAndParent: " + e.Message );
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
 **childPostId** | **long**|  | 
 **showbanned** | **string**| If this value is not null or empty, banned posts are requested to be returned | [optional] 

### Return type

[**InlineResponse20011**](InlineResponse20011.md)

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

<a name="forumgetpostandparentawaitingapproval"></a>
# **ForumGetPostAndParentAwaitingApproval**
> InlineResponse20011 ForumGetPostAndParentAwaitingApproval (long childPostId, string showbanned = null)



Returns the post specified and its immediate parent of posts that are awaiting approval.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BungieNetApi.Api;
using BungieNetApi.Client;
using BungieNetApi.Model;

namespace Example
{
    public class ForumGetPostAndParentAwaitingApprovalExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new ForumApi(config);
            var childPostId = 789;  // long | 
            var showbanned = showbanned_example;  // string | If this value is not null or empty, banned posts are requested to be returned (optional) 

            try
            {
                InlineResponse20011 result = apiInstance.ForumGetPostAndParentAwaitingApproval(childPostId, showbanned);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.ForumGetPostAndParentAwaitingApproval: " + e.Message );
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
 **childPostId** | **long**|  | 
 **showbanned** | **string**| If this value is not null or empty, banned posts are requested to be returned | [optional] 

### Return type

[**InlineResponse20011**](InlineResponse20011.md)

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

<a name="forumgetpoststhreadedpaged"></a>
# **ForumGetPostsThreadedPaged**
> InlineResponse20011 ForumGetPostsThreadedPaged (bool getParentPost, int page, int pageSize, long parentPostId, int replySize, bool rootThreadMode, int sortMode, string showbanned = null)



Returns a thread of posts at the given parent, optionally returning replies to those posts as well as the original parent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BungieNetApi.Api;
using BungieNetApi.Client;
using BungieNetApi.Model;

namespace Example
{
    public class ForumGetPostsThreadedPagedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new ForumApi(config);
            var getParentPost = true;  // bool | 
            var page = 56;  // int | 
            var pageSize = 56;  // int | 
            var parentPostId = 789;  // long | 
            var replySize = 56;  // int | 
            var rootThreadMode = true;  // bool | 
            var sortMode = 56;  // int | 
            var showbanned = showbanned_example;  // string | If this value is not null or empty, banned posts are requested to be returned (optional) 

            try
            {
                InlineResponse20011 result = apiInstance.ForumGetPostsThreadedPaged(getParentPost, page, pageSize, parentPostId, replySize, rootThreadMode, sortMode, showbanned);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.ForumGetPostsThreadedPaged: " + e.Message );
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
 **getParentPost** | **bool**|  | 
 **page** | **int**|  | 
 **pageSize** | **int**|  | 
 **parentPostId** | **long**|  | 
 **replySize** | **int**|  | 
 **rootThreadMode** | **bool**|  | 
 **sortMode** | **int**|  | 
 **showbanned** | **string**| If this value is not null or empty, banned posts are requested to be returned | [optional] 

### Return type

[**InlineResponse20011**](InlineResponse20011.md)

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

<a name="forumgetpoststhreadedpagedfromchild"></a>
# **ForumGetPostsThreadedPagedFromChild**
> InlineResponse20011 ForumGetPostsThreadedPagedFromChild (long childPostId, int page, int pageSize, int replySize, bool rootThreadMode, int sortMode, string showbanned = null)



Returns a thread of posts starting at the topicId of the input childPostId, optionally returning replies to those posts as well as the original parent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BungieNetApi.Api;
using BungieNetApi.Client;
using BungieNetApi.Model;

namespace Example
{
    public class ForumGetPostsThreadedPagedFromChildExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new ForumApi(config);
            var childPostId = 789;  // long | 
            var page = 56;  // int | 
            var pageSize = 56;  // int | 
            var replySize = 56;  // int | 
            var rootThreadMode = true;  // bool | 
            var sortMode = 56;  // int | 
            var showbanned = showbanned_example;  // string | If this value is not null or empty, banned posts are requested to be returned (optional) 

            try
            {
                InlineResponse20011 result = apiInstance.ForumGetPostsThreadedPagedFromChild(childPostId, page, pageSize, replySize, rootThreadMode, sortMode, showbanned);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.ForumGetPostsThreadedPagedFromChild: " + e.Message );
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
 **childPostId** | **long**|  | 
 **page** | **int**|  | 
 **pageSize** | **int**|  | 
 **replySize** | **int**|  | 
 **rootThreadMode** | **bool**|  | 
 **sortMode** | **int**|  | 
 **showbanned** | **string**| If this value is not null or empty, banned posts are requested to be returned | [optional] 

### Return type

[**InlineResponse20011**](InlineResponse20011.md)

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

<a name="forumgetrecruitmentthreadsummaries"></a>
# **ForumGetRecruitmentThreadSummaries**
> InlineResponse20014 ForumGetRecruitmentThreadSummaries ()



Allows the caller to get a list of to 25 recruitment thread summary information objects.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BungieNetApi.Api;
using BungieNetApi.Client;
using BungieNetApi.Model;

namespace Example
{
    public class ForumGetRecruitmentThreadSummariesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new ForumApi(config);

            try
            {
                InlineResponse20014 result = apiInstance.ForumGetRecruitmentThreadSummaries();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.ForumGetRecruitmentThreadSummaries: " + e.Message );
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

[**InlineResponse20014**](InlineResponse20014.md)

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

<a name="forumgettopicforcontent"></a>
# **ForumGetTopicForContent**
> InlineResponse20012 ForumGetTopicForContent (long contentId)



Gets the post Id for the given content item's comments, if it exists.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BungieNetApi.Api;
using BungieNetApi.Client;
using BungieNetApi.Model;

namespace Example
{
    public class ForumGetTopicForContentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new ForumApi(config);
            var contentId = 789;  // long | 

            try
            {
                InlineResponse20012 result = apiInstance.ForumGetTopicForContent(contentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.ForumGetTopicForContent: " + e.Message );
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
 **contentId** | **long**|  | 

### Return type

[**InlineResponse20012**](InlineResponse20012.md)

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

<a name="forumgettopicspaged"></a>
# **ForumGetTopicsPaged**
> InlineResponse20011 ForumGetTopicsPaged (int categoryFilter, long group, int page, int pageSize, int quickDate, int sort, string locales = null, string tagstring = null)



Get topics from any forum.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BungieNetApi.Api;
using BungieNetApi.Client;
using BungieNetApi.Model;

namespace Example
{
    public class ForumGetTopicsPagedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.bungie.net/Platform";
            var apiInstance = new ForumApi(config);
            var categoryFilter = 56;  // int | A category filter
            var group = 789;  // long | The group, if any.
            var page = 56;  // int | Zero paged page number
            var pageSize = 56;  // int | Unused
            var quickDate = 56;  // int | A date filter.
            var sort = 56;  // int | The sort mode.
            var locales = locales_example;  // string | Comma seperated list of locales posts must match to return in the result list. Default 'en' (optional) 
            var tagstring = tagstring_example;  // string | The tags to search, if any. (optional) 

            try
            {
                InlineResponse20011 result = apiInstance.ForumGetTopicsPaged(categoryFilter, group, page, pageSize, quickDate, sort, locales, tagstring);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.ForumGetTopicsPaged: " + e.Message );
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
 **categoryFilter** | **int**| A category filter | 
 **group** | **long**| The group, if any. | 
 **page** | **int**| Zero paged page number | 
 **pageSize** | **int**| Unused | 
 **quickDate** | **int**| A date filter. | 
 **sort** | **int**| The sort mode. | 
 **locales** | **string**| Comma seperated list of locales posts must match to return in the result list. Default &#39;en&#39; | [optional] 
 **tagstring** | **string**| The tags to search, if any. | [optional] 

### Return type

[**InlineResponse20011**](InlineResponse20011.md)

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

