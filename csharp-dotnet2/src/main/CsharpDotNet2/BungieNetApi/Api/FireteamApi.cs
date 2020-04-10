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
    public interface IFireteamApi
    {
        /// <summary>
        ///  Gets a count of all active non-public fireteams for the specified clan. Maximum value returned is 25.
        /// </summary>
        /// <param name="groupId">The group id of the clan.</param>
        /// <returns>InlineResponse20022</returns>
        InlineResponse20022 FireteamGetActivePrivateClanFireteamCount (long? groupId);
        /// <summary>
        ///  Gets a listing of all of this clan&#39;s fireteams that are have available slots. Caller is not checked for join criteria so caching is maximized.
        /// </summary>
        /// <param name="activityType">The activity type to filter by.</param>
        /// <param name="dateRange">The date range to grab available fireteams.</param>
        /// <param name="groupId">The group id of the clan.</param>
        /// <param name="page">Zero based page</param>
        /// <param name="platform">The platform filter.</param>
        /// <param name="publicOnly">Determines public/private filtering.</param>
        /// <param name="slotFilter">Filters based on available slots</param>
        /// <param name="langFilter">An optional language filter.</param>
        /// <returns>InlineResponse20064</returns>
        InlineResponse20064 FireteamGetAvailableClanFireteams (int? activityType, int? dateRange, long? groupId, int? page, int? platform, int? publicOnly, int? slotFilter, string langFilter);
        /// <summary>
        ///  Gets a specific clan fireteam.
        /// </summary>
        /// <param name="fireteamId">The unique id of the fireteam.</param>
        /// <param name="groupId">The group id of the clan.</param>
        /// <returns>InlineResponse20066</returns>
        InlineResponse20066 FireteamGetClanFireteam (long? fireteamId, long? groupId);
        /// <summary>
        ///  Gets a listing of all clan fireteams that caller is an applicant, a member, or an alternate of.
        /// </summary>
        /// <param name="groupId">The group id of the clan. (This parameter is ignored unless the optional query parameter groupFilter is true).</param>
        /// <param name="includeClosed">If true, return fireteams that have been closed.</param>
        /// <param name="page">Deprecated parameter, ignored.</param>
        /// <param name="platform">The platform filter.</param>
        /// <param name="groupFilter">If true, filter by clan. Otherwise, ignore the clan and show all of the user&#39;s fireteams.</param>
        /// <param name="langFilter">An optional language filter.</param>
        /// <returns>InlineResponse20065</returns>
        InlineResponse20065 FireteamGetMyClanFireteams (long? groupId, bool? includeClosed, int? page, int? platform, bool? groupFilter, string langFilter);
        /// <summary>
        ///  Gets a listing of all public fireteams starting now with open slots. Caller is not checked for join criteria so caching is maximized.
        /// </summary>
        /// <param name="activityType">The activity type to filter by.</param>
        /// <param name="dateRange">The date range to grab available fireteams.</param>
        /// <param name="page">Zero based page</param>
        /// <param name="platform">The platform filter.</param>
        /// <param name="slotFilter">Filters based on available slots</param>
        /// <param name="langFilter">An optional language filter.</param>
        /// <returns>InlineResponse20064</returns>
        InlineResponse20064 FireteamSearchPublicAvailableClanFireteams (int? activityType, int? dateRange, int? page, int? platform, int? slotFilter, string langFilter);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class FireteamApi : IFireteamApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FireteamApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public FireteamApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FireteamApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FireteamApi(String basePath)
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
        ///  Gets a count of all active non-public fireteams for the specified clan. Maximum value returned is 25.
        /// </summary>
        /// <param name="groupId">The group id of the clan.</param> 
        /// <returns>InlineResponse20022</returns>            
        public InlineResponse20022 FireteamGetActivePrivateClanFireteamCount (long? groupId)
        {
            
            // verify the required parameter 'groupId' is set
            if (groupId == null) throw new ApiException(400, "Missing required parameter 'groupId' when calling FireteamGetActivePrivateClanFireteamCount");
            
    
            var path = "/Fireteam/Clan/{groupId}/ActiveCount/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "groupId" + "}", ApiClient.ParameterToString(groupId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling FireteamGetActivePrivateClanFireteamCount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling FireteamGetActivePrivateClanFireteamCount: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20022) ApiClient.Deserialize(response.Content, typeof(InlineResponse20022), response.Headers);
        }
    
        /// <summary>
        ///  Gets a listing of all of this clan&#39;s fireteams that are have available slots. Caller is not checked for join criteria so caching is maximized.
        /// </summary>
        /// <param name="activityType">The activity type to filter by.</param> 
        /// <param name="dateRange">The date range to grab available fireteams.</param> 
        /// <param name="groupId">The group id of the clan.</param> 
        /// <param name="page">Zero based page</param> 
        /// <param name="platform">The platform filter.</param> 
        /// <param name="publicOnly">Determines public/private filtering.</param> 
        /// <param name="slotFilter">Filters based on available slots</param> 
        /// <param name="langFilter">An optional language filter.</param> 
        /// <returns>InlineResponse20064</returns>            
        public InlineResponse20064 FireteamGetAvailableClanFireteams (int? activityType, int? dateRange, long? groupId, int? page, int? platform, int? publicOnly, int? slotFilter, string langFilter)
        {
            
            // verify the required parameter 'activityType' is set
            if (activityType == null) throw new ApiException(400, "Missing required parameter 'activityType' when calling FireteamGetAvailableClanFireteams");
            
            // verify the required parameter 'dateRange' is set
            if (dateRange == null) throw new ApiException(400, "Missing required parameter 'dateRange' when calling FireteamGetAvailableClanFireteams");
            
            // verify the required parameter 'groupId' is set
            if (groupId == null) throw new ApiException(400, "Missing required parameter 'groupId' when calling FireteamGetAvailableClanFireteams");
            
            // verify the required parameter 'page' is set
            if (page == null) throw new ApiException(400, "Missing required parameter 'page' when calling FireteamGetAvailableClanFireteams");
            
            // verify the required parameter 'platform' is set
            if (platform == null) throw new ApiException(400, "Missing required parameter 'platform' when calling FireteamGetAvailableClanFireteams");
            
            // verify the required parameter 'publicOnly' is set
            if (publicOnly == null) throw new ApiException(400, "Missing required parameter 'publicOnly' when calling FireteamGetAvailableClanFireteams");
            
            // verify the required parameter 'slotFilter' is set
            if (slotFilter == null) throw new ApiException(400, "Missing required parameter 'slotFilter' when calling FireteamGetAvailableClanFireteams");
            
    
            var path = "/Fireteam/Clan/{groupId}/Available/{platform}/{activityType}/{dateRange}/{slotFilter}/{publicOnly}/{page}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "activityType" + "}", ApiClient.ParameterToString(activityType));
path = path.Replace("{" + "dateRange" + "}", ApiClient.ParameterToString(dateRange));
path = path.Replace("{" + "groupId" + "}", ApiClient.ParameterToString(groupId));
path = path.Replace("{" + "page" + "}", ApiClient.ParameterToString(page));
path = path.Replace("{" + "platform" + "}", ApiClient.ParameterToString(platform));
path = path.Replace("{" + "publicOnly" + "}", ApiClient.ParameterToString(publicOnly));
path = path.Replace("{" + "slotFilter" + "}", ApiClient.ParameterToString(slotFilter));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (langFilter != null) queryParams.Add("langFilter", ApiClient.ParameterToString(langFilter)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling FireteamGetAvailableClanFireteams: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling FireteamGetAvailableClanFireteams: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20064) ApiClient.Deserialize(response.Content, typeof(InlineResponse20064), response.Headers);
        }
    
        /// <summary>
        ///  Gets a specific clan fireteam.
        /// </summary>
        /// <param name="fireteamId">The unique id of the fireteam.</param> 
        /// <param name="groupId">The group id of the clan.</param> 
        /// <returns>InlineResponse20066</returns>            
        public InlineResponse20066 FireteamGetClanFireteam (long? fireteamId, long? groupId)
        {
            
            // verify the required parameter 'fireteamId' is set
            if (fireteamId == null) throw new ApiException(400, "Missing required parameter 'fireteamId' when calling FireteamGetClanFireteam");
            
            // verify the required parameter 'groupId' is set
            if (groupId == null) throw new ApiException(400, "Missing required parameter 'groupId' when calling FireteamGetClanFireteam");
            
    
            var path = "/Fireteam/Clan/{groupId}/Summary/{fireteamId}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "fireteamId" + "}", ApiClient.ParameterToString(fireteamId));
path = path.Replace("{" + "groupId" + "}", ApiClient.ParameterToString(groupId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling FireteamGetClanFireteam: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling FireteamGetClanFireteam: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20066) ApiClient.Deserialize(response.Content, typeof(InlineResponse20066), response.Headers);
        }
    
        /// <summary>
        ///  Gets a listing of all clan fireteams that caller is an applicant, a member, or an alternate of.
        /// </summary>
        /// <param name="groupId">The group id of the clan. (This parameter is ignored unless the optional query parameter groupFilter is true).</param> 
        /// <param name="includeClosed">If true, return fireteams that have been closed.</param> 
        /// <param name="page">Deprecated parameter, ignored.</param> 
        /// <param name="platform">The platform filter.</param> 
        /// <param name="groupFilter">If true, filter by clan. Otherwise, ignore the clan and show all of the user&#39;s fireteams.</param> 
        /// <param name="langFilter">An optional language filter.</param> 
        /// <returns>InlineResponse20065</returns>            
        public InlineResponse20065 FireteamGetMyClanFireteams (long? groupId, bool? includeClosed, int? page, int? platform, bool? groupFilter, string langFilter)
        {
            
            // verify the required parameter 'groupId' is set
            if (groupId == null) throw new ApiException(400, "Missing required parameter 'groupId' when calling FireteamGetMyClanFireteams");
            
            // verify the required parameter 'includeClosed' is set
            if (includeClosed == null) throw new ApiException(400, "Missing required parameter 'includeClosed' when calling FireteamGetMyClanFireteams");
            
            // verify the required parameter 'page' is set
            if (page == null) throw new ApiException(400, "Missing required parameter 'page' when calling FireteamGetMyClanFireteams");
            
            // verify the required parameter 'platform' is set
            if (platform == null) throw new ApiException(400, "Missing required parameter 'platform' when calling FireteamGetMyClanFireteams");
            
    
            var path = "/Fireteam/Clan/{groupId}/My/{platform}/{includeClosed}/{page}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "groupId" + "}", ApiClient.ParameterToString(groupId));
path = path.Replace("{" + "includeClosed" + "}", ApiClient.ParameterToString(includeClosed));
path = path.Replace("{" + "page" + "}", ApiClient.ParameterToString(page));
path = path.Replace("{" + "platform" + "}", ApiClient.ParameterToString(platform));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (groupFilter != null) queryParams.Add("groupFilter", ApiClient.ParameterToString(groupFilter)); // query parameter
 if (langFilter != null) queryParams.Add("langFilter", ApiClient.ParameterToString(langFilter)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling FireteamGetMyClanFireteams: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling FireteamGetMyClanFireteams: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20065) ApiClient.Deserialize(response.Content, typeof(InlineResponse20065), response.Headers);
        }
    
        /// <summary>
        ///  Gets a listing of all public fireteams starting now with open slots. Caller is not checked for join criteria so caching is maximized.
        /// </summary>
        /// <param name="activityType">The activity type to filter by.</param> 
        /// <param name="dateRange">The date range to grab available fireteams.</param> 
        /// <param name="page">Zero based page</param> 
        /// <param name="platform">The platform filter.</param> 
        /// <param name="slotFilter">Filters based on available slots</param> 
        /// <param name="langFilter">An optional language filter.</param> 
        /// <returns>InlineResponse20064</returns>            
        public InlineResponse20064 FireteamSearchPublicAvailableClanFireteams (int? activityType, int? dateRange, int? page, int? platform, int? slotFilter, string langFilter)
        {
            
            // verify the required parameter 'activityType' is set
            if (activityType == null) throw new ApiException(400, "Missing required parameter 'activityType' when calling FireteamSearchPublicAvailableClanFireteams");
            
            // verify the required parameter 'dateRange' is set
            if (dateRange == null) throw new ApiException(400, "Missing required parameter 'dateRange' when calling FireteamSearchPublicAvailableClanFireteams");
            
            // verify the required parameter 'page' is set
            if (page == null) throw new ApiException(400, "Missing required parameter 'page' when calling FireteamSearchPublicAvailableClanFireteams");
            
            // verify the required parameter 'platform' is set
            if (platform == null) throw new ApiException(400, "Missing required parameter 'platform' when calling FireteamSearchPublicAvailableClanFireteams");
            
            // verify the required parameter 'slotFilter' is set
            if (slotFilter == null) throw new ApiException(400, "Missing required parameter 'slotFilter' when calling FireteamSearchPublicAvailableClanFireteams");
            
    
            var path = "/Fireteam/Search/Available/{platform}/{activityType}/{dateRange}/{slotFilter}/{page}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "activityType" + "}", ApiClient.ParameterToString(activityType));
path = path.Replace("{" + "dateRange" + "}", ApiClient.ParameterToString(dateRange));
path = path.Replace("{" + "page" + "}", ApiClient.ParameterToString(page));
path = path.Replace("{" + "platform" + "}", ApiClient.ParameterToString(platform));
path = path.Replace("{" + "slotFilter" + "}", ApiClient.ParameterToString(slotFilter));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (langFilter != null) queryParams.Add("langFilter", ApiClient.ParameterToString(langFilter)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling FireteamSearchPublicAvailableClanFireteams: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling FireteamSearchPublicAvailableClanFireteams: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20064) ApiClient.Deserialize(response.Content, typeof(InlineResponse20064), response.Headers);
        }
    
    }
}
