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
    public interface IDefaultApi
    {
        /// <summary>
        ///  List of available localization cultures
        /// </summary>
        /// <returns>InlineResponse20015</returns>
        InlineResponse20015 GetAvailableLocales ();
        /// <summary>
        ///  Get the common settings used by the Bungie.Net environment.
        /// </summary>
        /// <returns>InlineResponse20067</returns>
        InlineResponse20067 GetCommonSettings ();
        /// <summary>
        ///  Gets any active global alert for display in the forum banners, help pages, etc. Usually used for DOC alerts.
        /// </summary>
        /// <param name="includestreaming">Determines whether Streaming Alerts are included in results</param>
        /// <returns>InlineResponse20068</returns>
        InlineResponse20068 GetGlobalAlerts (bool? includestreaming);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DefaultApi : IDefaultApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public DefaultApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DefaultApi(String basePath)
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
        ///  List of available localization cultures
        /// </summary>
        /// <returns>InlineResponse20015</returns>            
        public InlineResponse20015 GetAvailableLocales ()
        {
            
    
            var path = "/GetAvailableLocales/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetAvailableLocales: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAvailableLocales: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20015) ApiClient.Deserialize(response.Content, typeof(InlineResponse20015), response.Headers);
        }
    
        /// <summary>
        ///  Get the common settings used by the Bungie.Net environment.
        /// </summary>
        /// <returns>InlineResponse20067</returns>            
        public InlineResponse20067 GetCommonSettings ()
        {
            
    
            var path = "/Settings/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCommonSettings: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCommonSettings: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20067) ApiClient.Deserialize(response.Content, typeof(InlineResponse20067), response.Headers);
        }
    
        /// <summary>
        ///  Gets any active global alert for display in the forum banners, help pages, etc. Usually used for DOC alerts.
        /// </summary>
        /// <param name="includestreaming">Determines whether Streaming Alerts are included in results</param> 
        /// <returns>InlineResponse20068</returns>            
        public InlineResponse20068 GetGlobalAlerts (bool? includestreaming)
        {
            
    
            var path = "/GlobalAlerts/";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (includestreaming != null) queryParams.Add("includestreaming", ApiClient.ParameterToString(includestreaming)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGlobalAlerts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGlobalAlerts: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20068) ApiClient.Deserialize(response.Content, typeof(InlineResponse20068), response.Headers);
        }
    
    }
}
