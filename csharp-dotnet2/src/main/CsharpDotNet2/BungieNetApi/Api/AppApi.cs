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
    public interface IAppApi
    {
        /// <summary>
        ///  Get API usage by application for time frame specified. You can go as far back as 30 days ago, and can ask for up to a 48 hour window of time in a single request. You must be authenticated with at least the ReadUserData permission to access this endpoint.
        /// </summary>
        /// <param name="applicationId">ID of the application to get usage statistics.</param>
        /// <param name="end">End time for query. Goes to now if not specified.</param>
        /// <param name="start">Start time for query. Goes to 24 hours ago if not specified.</param>
        /// <returns>InlineResponse200</returns>
        InlineResponse200 AppGetApplicationApiUsage (int? applicationId, DateTime? end, DateTime? start);
        /// <summary>
        ///  Get list of applications created by Bungie.
        /// </summary>
        /// <returns>InlineResponse2001</returns>
        InlineResponse2001 AppGetBungieApplications ();
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AppApi : IAppApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AppApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AppApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AppApi(String basePath)
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
        ///  Get API usage by application for time frame specified. You can go as far back as 30 days ago, and can ask for up to a 48 hour window of time in a single request. You must be authenticated with at least the ReadUserData permission to access this endpoint.
        /// </summary>
        /// <param name="applicationId">ID of the application to get usage statistics.</param> 
        /// <param name="end">End time for query. Goes to now if not specified.</param> 
        /// <param name="start">Start time for query. Goes to 24 hours ago if not specified.</param> 
        /// <returns>InlineResponse200</returns>            
        public InlineResponse200 AppGetApplicationApiUsage (int? applicationId, DateTime? end, DateTime? start)
        {
            
            // verify the required parameter 'applicationId' is set
            if (applicationId == null) throw new ApiException(400, "Missing required parameter 'applicationId' when calling AppGetApplicationApiUsage");
            
    
            var path = "/App/ApiUsage/{applicationId}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "applicationId" + "}", ApiClient.ParameterToString(applicationId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (end != null) queryParams.Add("end", ApiClient.ParameterToString(end)); // query parameter
 if (start != null) queryParams.Add("start", ApiClient.ParameterToString(start)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AppGetApplicationApiUsage: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppGetApplicationApiUsage: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200) ApiClient.Deserialize(response.Content, typeof(InlineResponse200), response.Headers);
        }
    
        /// <summary>
        ///  Get list of applications created by Bungie.
        /// </summary>
        /// <returns>InlineResponse2001</returns>            
        public InlineResponse2001 AppGetBungieApplications ()
        {
            
    
            var path = "/App/FirstParty/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AppGetBungieApplications: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppGetBungieApplications: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2001) ApiClient.Deserialize(response.Content, typeof(InlineResponse2001), response.Headers);
        }
    
    }
}
