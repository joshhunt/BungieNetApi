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
    public interface ITrendingApi
    {
        /// <summary>
        ///  Returns trending items for Bungie.net, collapsed into the first page of items per category. For pagination within a category, call GetTrendingCategory.
        /// </summary>
        /// <returns>InlineResponse20061</returns>
        InlineResponse20061 TrendingGetTrendingCategories ();
        /// <summary>
        ///  Returns paginated lists of trending items for a category.
        /// </summary>
        /// <param name="categoryId">The ID of the category for whom you want additional results.</param>
        /// <param name="pageNumber">The page # of results to return.</param>
        /// <returns>InlineResponse20062</returns>
        InlineResponse20062 TrendingGetTrendingCategory (string categoryId, int? pageNumber);
        /// <summary>
        ///  Returns the detailed results for a specific trending entry. Note that trending entries are uniquely identified by a combination of *both* the TrendingEntryType *and* the identifier: the identifier alone is not guaranteed to be globally unique.
        /// </summary>
        /// <param name="identifier">The identifier for the entity to be returned.</param>
        /// <param name="trendingEntryType">The type of entity to be returned.</param>
        /// <returns>InlineResponse20063</returns>
        InlineResponse20063 TrendingGetTrendingEntryDetail (string identifier, int? trendingEntryType);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TrendingApi : ITrendingApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrendingApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public TrendingApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TrendingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TrendingApi(String basePath)
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
        ///  Returns trending items for Bungie.net, collapsed into the first page of items per category. For pagination within a category, call GetTrendingCategory.
        /// </summary>
        /// <returns>InlineResponse20061</returns>            
        public InlineResponse20061 TrendingGetTrendingCategories ()
        {
            
    
            var path = "/Trending/Categories/";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling TrendingGetTrendingCategories: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TrendingGetTrendingCategories: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20061) ApiClient.Deserialize(response.Content, typeof(InlineResponse20061), response.Headers);
        }
    
        /// <summary>
        ///  Returns paginated lists of trending items for a category.
        /// </summary>
        /// <param name="categoryId">The ID of the category for whom you want additional results.</param> 
        /// <param name="pageNumber">The page # of results to return.</param> 
        /// <returns>InlineResponse20062</returns>            
        public InlineResponse20062 TrendingGetTrendingCategory (string categoryId, int? pageNumber)
        {
            
            // verify the required parameter 'categoryId' is set
            if (categoryId == null) throw new ApiException(400, "Missing required parameter 'categoryId' when calling TrendingGetTrendingCategory");
            
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null) throw new ApiException(400, "Missing required parameter 'pageNumber' when calling TrendingGetTrendingCategory");
            
    
            var path = "/Trending/Categories/{categoryId}/{pageNumber}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "categoryId" + "}", ApiClient.ParameterToString(categoryId));
path = path.Replace("{" + "pageNumber" + "}", ApiClient.ParameterToString(pageNumber));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling TrendingGetTrendingCategory: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TrendingGetTrendingCategory: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20062) ApiClient.Deserialize(response.Content, typeof(InlineResponse20062), response.Headers);
        }
    
        /// <summary>
        ///  Returns the detailed results for a specific trending entry. Note that trending entries are uniquely identified by a combination of *both* the TrendingEntryType *and* the identifier: the identifier alone is not guaranteed to be globally unique.
        /// </summary>
        /// <param name="identifier">The identifier for the entity to be returned.</param> 
        /// <param name="trendingEntryType">The type of entity to be returned.</param> 
        /// <returns>InlineResponse20063</returns>            
        public InlineResponse20063 TrendingGetTrendingEntryDetail (string identifier, int? trendingEntryType)
        {
            
            // verify the required parameter 'identifier' is set
            if (identifier == null) throw new ApiException(400, "Missing required parameter 'identifier' when calling TrendingGetTrendingEntryDetail");
            
            // verify the required parameter 'trendingEntryType' is set
            if (trendingEntryType == null) throw new ApiException(400, "Missing required parameter 'trendingEntryType' when calling TrendingGetTrendingEntryDetail");
            
    
            var path = "/Trending/Details/{trendingEntryType}/{identifier}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "identifier" + "}", ApiClient.ParameterToString(identifier));
path = path.Replace("{" + "trendingEntryType" + "}", ApiClient.ParameterToString(trendingEntryType));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling TrendingGetTrendingEntryDetail: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TrendingGetTrendingEntryDetail: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20063) ApiClient.Deserialize(response.Content, typeof(InlineResponse20063), response.Headers);
        }
    
    }
}
