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
    public interface ICommunityContentApi
    {
        /// <summary>
        ///  Returns community content.
        /// </summary>
        /// <param name="mediaFilter">The type of media to get</param>
        /// <param name="page">Zero based page</param>
        /// <param name="sort">The sort mode.</param>
        /// <returns>InlineResponse20011</returns>
        InlineResponse20011 CommunityContentGetCommunityContent (int? mediaFilter, int? page, int? sort);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CommunityContentApi : ICommunityContentApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommunityContentApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CommunityContentApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CommunityContentApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CommunityContentApi(String basePath)
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
        ///  Returns community content.
        /// </summary>
        /// <param name="mediaFilter">The type of media to get</param> 
        /// <param name="page">Zero based page</param> 
        /// <param name="sort">The sort mode.</param> 
        /// <returns>InlineResponse20011</returns>            
        public InlineResponse20011 CommunityContentGetCommunityContent (int? mediaFilter, int? page, int? sort)
        {
            
            // verify the required parameter 'mediaFilter' is set
            if (mediaFilter == null) throw new ApiException(400, "Missing required parameter 'mediaFilter' when calling CommunityContentGetCommunityContent");
            
            // verify the required parameter 'page' is set
            if (page == null) throw new ApiException(400, "Missing required parameter 'page' when calling CommunityContentGetCommunityContent");
            
            // verify the required parameter 'sort' is set
            if (sort == null) throw new ApiException(400, "Missing required parameter 'sort' when calling CommunityContentGetCommunityContent");
            
    
            var path = "/CommunityContent/Get/{sort}/{mediaFilter}/{page}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "mediaFilter" + "}", ApiClient.ParameterToString(mediaFilter));
path = path.Replace("{" + "page" + "}", ApiClient.ParameterToString(page));
path = path.Replace("{" + "sort" + "}", ApiClient.ParameterToString(sort));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling CommunityContentGetCommunityContent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CommunityContentGetCommunityContent: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20011) ApiClient.Deserialize(response.Content, typeof(InlineResponse20011), response.Headers);
        }
    
    }
}
