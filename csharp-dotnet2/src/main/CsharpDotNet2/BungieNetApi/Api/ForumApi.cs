using System;
using System.Collections.Generic;
using RestSharp;
using Org.OpenAPITools.Client;
using BungieNetApi.Model;

namespace BungieNetApi.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IForumApi
    {
        /// <summary>
        ///  Gets a listing of all topics marked as part of the core group.
        /// </summary>
        /// <param name="categoryFilter">The category filter.</param>
        /// <param name="page">Zero base page</param>
        /// <param name="quickDate">The date filter.</param>
        /// <param name="sort">The sort mode.</param>
        /// <param name="locales">Comma seperated list of locales posts must match to return in the result list. Default &#39;en&#39;</param>
        /// <returns>InlineResponse20011</returns>
        InlineResponse20011 ForumGetCoreTopicsPaged (int? categoryFilter, int? page, int? quickDate, int? sort, string locales);
        /// <summary>
        ///  Gets tag suggestions based on partial text entry, matching them with other tags previously used in the forums.
        /// </summary>
        /// <param name="partialtag">The partial tag input to generate suggestions from.</param>
        /// <returns>InlineResponse20013</returns>
        InlineResponse20013 ForumGetForumTagSuggestions (string partialtag);
        /// <summary>
        ///  Gets the specified forum poll.
        /// </summary>
        /// <param name="topicId">The post id of the topic that has the poll.</param>
        /// <returns>InlineResponse20011</returns>
        InlineResponse20011 ForumGetPoll (long? topicId);
        /// <summary>
        ///  Returns the post specified and its immediate parent.
        /// </summary>
        /// <param name="childPostId"></param>
        /// <param name="showbanned">If this value is not null or empty, banned posts are requested to be returned</param>
        /// <returns>InlineResponse20011</returns>
        InlineResponse20011 ForumGetPostAndParent (long? childPostId, string showbanned);
        /// <summary>
        ///  Returns the post specified and its immediate parent of posts that are awaiting approval.
        /// </summary>
        /// <param name="childPostId"></param>
        /// <param name="showbanned">If this value is not null or empty, banned posts are requested to be returned</param>
        /// <returns>InlineResponse20011</returns>
        InlineResponse20011 ForumGetPostAndParentAwaitingApproval (long? childPostId, string showbanned);
        /// <summary>
        ///  Returns a thread of posts at the given parent, optionally returning replies to those posts as well as the original parent.
        /// </summary>
        /// <param name="getParentPost"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="parentPostId"></param>
        /// <param name="replySize"></param>
        /// <param name="rootThreadMode"></param>
        /// <param name="sortMode"></param>
        /// <param name="showbanned">If this value is not null or empty, banned posts are requested to be returned</param>
        /// <returns>InlineResponse20011</returns>
        InlineResponse20011 ForumGetPostsThreadedPaged (bool? getParentPost, int? page, int? pageSize, long? parentPostId, int? replySize, bool? rootThreadMode, int? sortMode, string showbanned);
        /// <summary>
        ///  Returns a thread of posts starting at the topicId of the input childPostId, optionally returning replies to those posts as well as the original parent.
        /// </summary>
        /// <param name="childPostId"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="replySize"></param>
        /// <param name="rootThreadMode"></param>
        /// <param name="sortMode"></param>
        /// <param name="showbanned">If this value is not null or empty, banned posts are requested to be returned</param>
        /// <returns>InlineResponse20011</returns>
        InlineResponse20011 ForumGetPostsThreadedPagedFromChild (long? childPostId, int? page, int? pageSize, int? replySize, bool? rootThreadMode, int? sortMode, string showbanned);
        /// <summary>
        ///  Allows the caller to get a list of to 25 recruitment thread summary information objects.
        /// </summary>
        /// <returns>InlineResponse20014</returns>
        InlineResponse20014 ForumGetRecruitmentThreadSummaries ();
        /// <summary>
        ///  Gets the post Id for the given content item&#39;s comments, if it exists.
        /// </summary>
        /// <param name="contentId"></param>
        /// <returns>InlineResponse20012</returns>
        InlineResponse20012 ForumGetTopicForContent (long? contentId);
        /// <summary>
        ///  Get topics from any forum.
        /// </summary>
        /// <param name="categoryFilter">A category filter</param>
        /// <param name="group">The group, if any.</param>
        /// <param name="page">Zero paged page number</param>
        /// <param name="pageSize">Unused</param>
        /// <param name="quickDate">A date filter.</param>
        /// <param name="sort">The sort mode.</param>
        /// <param name="locales">Comma seperated list of locales posts must match to return in the result list. Default &#39;en&#39;</param>
        /// <param name="tagstring">The tags to search, if any.</param>
        /// <returns>InlineResponse20011</returns>
        InlineResponse20011 ForumGetTopicsPaged (int? categoryFilter, long? group, int? page, int? pageSize, int? quickDate, int? sort, string locales, string tagstring);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ForumApi : IForumApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ForumApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ForumApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ForumApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ForumApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        ///  Gets a listing of all topics marked as part of the core group.
        /// </summary>
        /// <param name="categoryFilter">The category filter.</param> 
        /// <param name="page">Zero base page</param> 
        /// <param name="quickDate">The date filter.</param> 
        /// <param name="sort">The sort mode.</param> 
        /// <param name="locales">Comma seperated list of locales posts must match to return in the result list. Default &#39;en&#39;</param> 
        /// <returns>InlineResponse20011</returns>            
        public InlineResponse20011 ForumGetCoreTopicsPaged (int? categoryFilter, int? page, int? quickDate, int? sort, string locales)
        {
            
            // verify the required parameter 'categoryFilter' is set
            if (categoryFilter == null) throw new ApiException(400, "Missing required parameter 'categoryFilter' when calling ForumGetCoreTopicsPaged");
            
            // verify the required parameter 'page' is set
            if (page == null) throw new ApiException(400, "Missing required parameter 'page' when calling ForumGetCoreTopicsPaged");
            
            // verify the required parameter 'quickDate' is set
            if (quickDate == null) throw new ApiException(400, "Missing required parameter 'quickDate' when calling ForumGetCoreTopicsPaged");
            
            // verify the required parameter 'sort' is set
            if (sort == null) throw new ApiException(400, "Missing required parameter 'sort' when calling ForumGetCoreTopicsPaged");
            
    
            var path = "/Forum/GetCoreTopicsPaged/{page}/{sort}/{quickDate}/{categoryFilter}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "categoryFilter" + "}", ApiClient.ParameterToString(categoryFilter));
path = path.Replace("{" + "page" + "}", ApiClient.ParameterToString(page));
path = path.Replace("{" + "quickDate" + "}", ApiClient.ParameterToString(quickDate));
path = path.Replace("{" + "sort" + "}", ApiClient.ParameterToString(sort));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (locales != null) queryParams.Add("locales", ApiClient.ParameterToString(locales)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ForumGetCoreTopicsPaged: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ForumGetCoreTopicsPaged: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20011) ApiClient.Deserialize(response.Content, typeof(InlineResponse20011), response.Headers);
        }
    
        /// <summary>
        ///  Gets tag suggestions based on partial text entry, matching them with other tags previously used in the forums.
        /// </summary>
        /// <param name="partialtag">The partial tag input to generate suggestions from.</param> 
        /// <returns>InlineResponse20013</returns>            
        public InlineResponse20013 ForumGetForumTagSuggestions (string partialtag)
        {
            
    
            var path = "/Forum/GetForumTagSuggestions/";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (partialtag != null) queryParams.Add("partialtag", ApiClient.ParameterToString(partialtag)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ForumGetForumTagSuggestions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ForumGetForumTagSuggestions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20013) ApiClient.Deserialize(response.Content, typeof(InlineResponse20013), response.Headers);
        }
    
        /// <summary>
        ///  Gets the specified forum poll.
        /// </summary>
        /// <param name="topicId">The post id of the topic that has the poll.</param> 
        /// <returns>InlineResponse20011</returns>            
        public InlineResponse20011 ForumGetPoll (long? topicId)
        {
            
            // verify the required parameter 'topicId' is set
            if (topicId == null) throw new ApiException(400, "Missing required parameter 'topicId' when calling ForumGetPoll");
            
    
            var path = "/Forum/Poll/{topicId}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "topicId" + "}", ApiClient.ParameterToString(topicId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ForumGetPoll: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ForumGetPoll: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20011) ApiClient.Deserialize(response.Content, typeof(InlineResponse20011), response.Headers);
        }
    
        /// <summary>
        ///  Returns the post specified and its immediate parent.
        /// </summary>
        /// <param name="childPostId"></param> 
        /// <param name="showbanned">If this value is not null or empty, banned posts are requested to be returned</param> 
        /// <returns>InlineResponse20011</returns>            
        public InlineResponse20011 ForumGetPostAndParent (long? childPostId, string showbanned)
        {
            
            // verify the required parameter 'childPostId' is set
            if (childPostId == null) throw new ApiException(400, "Missing required parameter 'childPostId' when calling ForumGetPostAndParent");
            
    
            var path = "/Forum/GetPostAndParent/{childPostId}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "childPostId" + "}", ApiClient.ParameterToString(childPostId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (showbanned != null) queryParams.Add("showbanned", ApiClient.ParameterToString(showbanned)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ForumGetPostAndParent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ForumGetPostAndParent: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20011) ApiClient.Deserialize(response.Content, typeof(InlineResponse20011), response.Headers);
        }
    
        /// <summary>
        ///  Returns the post specified and its immediate parent of posts that are awaiting approval.
        /// </summary>
        /// <param name="childPostId"></param> 
        /// <param name="showbanned">If this value is not null or empty, banned posts are requested to be returned</param> 
        /// <returns>InlineResponse20011</returns>            
        public InlineResponse20011 ForumGetPostAndParentAwaitingApproval (long? childPostId, string showbanned)
        {
            
            // verify the required parameter 'childPostId' is set
            if (childPostId == null) throw new ApiException(400, "Missing required parameter 'childPostId' when calling ForumGetPostAndParentAwaitingApproval");
            
    
            var path = "/Forum/GetPostAndParentAwaitingApproval/{childPostId}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "childPostId" + "}", ApiClient.ParameterToString(childPostId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (showbanned != null) queryParams.Add("showbanned", ApiClient.ParameterToString(showbanned)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ForumGetPostAndParentAwaitingApproval: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ForumGetPostAndParentAwaitingApproval: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20011) ApiClient.Deserialize(response.Content, typeof(InlineResponse20011), response.Headers);
        }
    
        /// <summary>
        ///  Returns a thread of posts at the given parent, optionally returning replies to those posts as well as the original parent.
        /// </summary>
        /// <param name="getParentPost"></param> 
        /// <param name="page"></param> 
        /// <param name="pageSize"></param> 
        /// <param name="parentPostId"></param> 
        /// <param name="replySize"></param> 
        /// <param name="rootThreadMode"></param> 
        /// <param name="sortMode"></param> 
        /// <param name="showbanned">If this value is not null or empty, banned posts are requested to be returned</param> 
        /// <returns>InlineResponse20011</returns>            
        public InlineResponse20011 ForumGetPostsThreadedPaged (bool? getParentPost, int? page, int? pageSize, long? parentPostId, int? replySize, bool? rootThreadMode, int? sortMode, string showbanned)
        {
            
            // verify the required parameter 'getParentPost' is set
            if (getParentPost == null) throw new ApiException(400, "Missing required parameter 'getParentPost' when calling ForumGetPostsThreadedPaged");
            
            // verify the required parameter 'page' is set
            if (page == null) throw new ApiException(400, "Missing required parameter 'page' when calling ForumGetPostsThreadedPaged");
            
            // verify the required parameter 'pageSize' is set
            if (pageSize == null) throw new ApiException(400, "Missing required parameter 'pageSize' when calling ForumGetPostsThreadedPaged");
            
            // verify the required parameter 'parentPostId' is set
            if (parentPostId == null) throw new ApiException(400, "Missing required parameter 'parentPostId' when calling ForumGetPostsThreadedPaged");
            
            // verify the required parameter 'replySize' is set
            if (replySize == null) throw new ApiException(400, "Missing required parameter 'replySize' when calling ForumGetPostsThreadedPaged");
            
            // verify the required parameter 'rootThreadMode' is set
            if (rootThreadMode == null) throw new ApiException(400, "Missing required parameter 'rootThreadMode' when calling ForumGetPostsThreadedPaged");
            
            // verify the required parameter 'sortMode' is set
            if (sortMode == null) throw new ApiException(400, "Missing required parameter 'sortMode' when calling ForumGetPostsThreadedPaged");
            
    
            var path = "/Forum/GetPostsThreadedPaged/{parentPostId}/{page}/{pageSize}/{replySize}/{getParentPost}/{rootThreadMode}/{sortMode}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "getParentPost" + "}", ApiClient.ParameterToString(getParentPost));
path = path.Replace("{" + "page" + "}", ApiClient.ParameterToString(page));
path = path.Replace("{" + "pageSize" + "}", ApiClient.ParameterToString(pageSize));
path = path.Replace("{" + "parentPostId" + "}", ApiClient.ParameterToString(parentPostId));
path = path.Replace("{" + "replySize" + "}", ApiClient.ParameterToString(replySize));
path = path.Replace("{" + "rootThreadMode" + "}", ApiClient.ParameterToString(rootThreadMode));
path = path.Replace("{" + "sortMode" + "}", ApiClient.ParameterToString(sortMode));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (showbanned != null) queryParams.Add("showbanned", ApiClient.ParameterToString(showbanned)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ForumGetPostsThreadedPaged: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ForumGetPostsThreadedPaged: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20011) ApiClient.Deserialize(response.Content, typeof(InlineResponse20011), response.Headers);
        }
    
        /// <summary>
        ///  Returns a thread of posts starting at the topicId of the input childPostId, optionally returning replies to those posts as well as the original parent.
        /// </summary>
        /// <param name="childPostId"></param> 
        /// <param name="page"></param> 
        /// <param name="pageSize"></param> 
        /// <param name="replySize"></param> 
        /// <param name="rootThreadMode"></param> 
        /// <param name="sortMode"></param> 
        /// <param name="showbanned">If this value is not null or empty, banned posts are requested to be returned</param> 
        /// <returns>InlineResponse20011</returns>            
        public InlineResponse20011 ForumGetPostsThreadedPagedFromChild (long? childPostId, int? page, int? pageSize, int? replySize, bool? rootThreadMode, int? sortMode, string showbanned)
        {
            
            // verify the required parameter 'childPostId' is set
            if (childPostId == null) throw new ApiException(400, "Missing required parameter 'childPostId' when calling ForumGetPostsThreadedPagedFromChild");
            
            // verify the required parameter 'page' is set
            if (page == null) throw new ApiException(400, "Missing required parameter 'page' when calling ForumGetPostsThreadedPagedFromChild");
            
            // verify the required parameter 'pageSize' is set
            if (pageSize == null) throw new ApiException(400, "Missing required parameter 'pageSize' when calling ForumGetPostsThreadedPagedFromChild");
            
            // verify the required parameter 'replySize' is set
            if (replySize == null) throw new ApiException(400, "Missing required parameter 'replySize' when calling ForumGetPostsThreadedPagedFromChild");
            
            // verify the required parameter 'rootThreadMode' is set
            if (rootThreadMode == null) throw new ApiException(400, "Missing required parameter 'rootThreadMode' when calling ForumGetPostsThreadedPagedFromChild");
            
            // verify the required parameter 'sortMode' is set
            if (sortMode == null) throw new ApiException(400, "Missing required parameter 'sortMode' when calling ForumGetPostsThreadedPagedFromChild");
            
    
            var path = "/Forum/GetPostsThreadedPagedFromChild/{childPostId}/{page}/{pageSize}/{replySize}/{rootThreadMode}/{sortMode}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "childPostId" + "}", ApiClient.ParameterToString(childPostId));
path = path.Replace("{" + "page" + "}", ApiClient.ParameterToString(page));
path = path.Replace("{" + "pageSize" + "}", ApiClient.ParameterToString(pageSize));
path = path.Replace("{" + "replySize" + "}", ApiClient.ParameterToString(replySize));
path = path.Replace("{" + "rootThreadMode" + "}", ApiClient.ParameterToString(rootThreadMode));
path = path.Replace("{" + "sortMode" + "}", ApiClient.ParameterToString(sortMode));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (showbanned != null) queryParams.Add("showbanned", ApiClient.ParameterToString(showbanned)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ForumGetPostsThreadedPagedFromChild: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ForumGetPostsThreadedPagedFromChild: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20011) ApiClient.Deserialize(response.Content, typeof(InlineResponse20011), response.Headers);
        }
    
        /// <summary>
        ///  Allows the caller to get a list of to 25 recruitment thread summary information objects.
        /// </summary>
        /// <returns>InlineResponse20014</returns>            
        public InlineResponse20014 ForumGetRecruitmentThreadSummaries ()
        {
            
    
            var path = "/Forum/Recruit/Summaries/";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ForumGetRecruitmentThreadSummaries: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ForumGetRecruitmentThreadSummaries: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20014) ApiClient.Deserialize(response.Content, typeof(InlineResponse20014), response.Headers);
        }
    
        /// <summary>
        ///  Gets the post Id for the given content item&#39;s comments, if it exists.
        /// </summary>
        /// <param name="contentId"></param> 
        /// <returns>InlineResponse20012</returns>            
        public InlineResponse20012 ForumGetTopicForContent (long? contentId)
        {
            
            // verify the required parameter 'contentId' is set
            if (contentId == null) throw new ApiException(400, "Missing required parameter 'contentId' when calling ForumGetTopicForContent");
            
    
            var path = "/Forum/GetTopicForContent/{contentId}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "contentId" + "}", ApiClient.ParameterToString(contentId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ForumGetTopicForContent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ForumGetTopicForContent: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20012) ApiClient.Deserialize(response.Content, typeof(InlineResponse20012), response.Headers);
        }
    
        /// <summary>
        ///  Get topics from any forum.
        /// </summary>
        /// <param name="categoryFilter">A category filter</param> 
        /// <param name="group">The group, if any.</param> 
        /// <param name="page">Zero paged page number</param> 
        /// <param name="pageSize">Unused</param> 
        /// <param name="quickDate">A date filter.</param> 
        /// <param name="sort">The sort mode.</param> 
        /// <param name="locales">Comma seperated list of locales posts must match to return in the result list. Default &#39;en&#39;</param> 
        /// <param name="tagstring">The tags to search, if any.</param> 
        /// <returns>InlineResponse20011</returns>            
        public InlineResponse20011 ForumGetTopicsPaged (int? categoryFilter, long? group, int? page, int? pageSize, int? quickDate, int? sort, string locales, string tagstring)
        {
            
            // verify the required parameter 'categoryFilter' is set
            if (categoryFilter == null) throw new ApiException(400, "Missing required parameter 'categoryFilter' when calling ForumGetTopicsPaged");
            
            // verify the required parameter 'group' is set
            if (group == null) throw new ApiException(400, "Missing required parameter 'group' when calling ForumGetTopicsPaged");
            
            // verify the required parameter 'page' is set
            if (page == null) throw new ApiException(400, "Missing required parameter 'page' when calling ForumGetTopicsPaged");
            
            // verify the required parameter 'pageSize' is set
            if (pageSize == null) throw new ApiException(400, "Missing required parameter 'pageSize' when calling ForumGetTopicsPaged");
            
            // verify the required parameter 'quickDate' is set
            if (quickDate == null) throw new ApiException(400, "Missing required parameter 'quickDate' when calling ForumGetTopicsPaged");
            
            // verify the required parameter 'sort' is set
            if (sort == null) throw new ApiException(400, "Missing required parameter 'sort' when calling ForumGetTopicsPaged");
            
    
            var path = "/Forum/GetTopicsPaged/{page}/{pageSize}/{group}/{sort}/{quickDate}/{categoryFilter}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "categoryFilter" + "}", ApiClient.ParameterToString(categoryFilter));
path = path.Replace("{" + "group" + "}", ApiClient.ParameterToString(group));
path = path.Replace("{" + "page" + "}", ApiClient.ParameterToString(page));
path = path.Replace("{" + "pageSize" + "}", ApiClient.ParameterToString(pageSize));
path = path.Replace("{" + "quickDate" + "}", ApiClient.ParameterToString(quickDate));
path = path.Replace("{" + "sort" + "}", ApiClient.ParameterToString(sort));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (locales != null) queryParams.Add("locales", ApiClient.ParameterToString(locales)); // query parameter
 if (tagstring != null) queryParams.Add("tagstring", ApiClient.ParameterToString(tagstring)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ForumGetTopicsPaged: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ForumGetTopicsPaged: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20011) ApiClient.Deserialize(response.Content, typeof(InlineResponse20011), response.Headers);
        }
    
    }
}
