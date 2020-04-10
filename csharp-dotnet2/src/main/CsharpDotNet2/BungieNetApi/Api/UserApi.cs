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
    public interface IUserApi
    {
        /// <summary>
        ///  Returns a list of all available user themes.
        /// </summary>
        /// <returns>InlineResponse2004</returns>
        InlineResponse2004 UserGetAvailableThemes ();
        /// <summary>
        ///  Loads a bungienet user by membership id.
        /// </summary>
        /// <param name="id">The requested Bungie.net membership id.</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 UserGetBungieNetUserById (long? id);
        /// <summary>
        ///  Returns a list of accounts associated with the supplied membership ID and membership type. This will include all linked accounts (even when hidden) if supplied credentials permit it.
        /// </summary>
        /// <param name="membershipId">The membership ID of the target user.</param>
        /// <param name="membershipType">Type of the supplied membership ID.</param>
        /// <returns>InlineResponse2005</returns>
        InlineResponse2005 UserGetMembershipDataById (long? membershipId, int? membershipType);
        /// <summary>
        ///  Returns a list of accounts associated with signed in user. This is useful for OAuth implementations that do not give you access to the token response.
        /// </summary>
        /// <returns>InlineResponse2005</returns>
        InlineResponse2005 UserGetMembershipDataForCurrentUser ();
        /// <summary>
        ///  Gets any hard linked membership given a credential. Only works for credentials that are public (just SteamID64 right now). Cross Save aware.
        /// </summary>
        /// <param name="credential">The credential to look up. Must be a valid SteamID64.</param>
        /// <param name="crType">The credential type. &#39;SteamId&#39; is the only valid value at present.</param>
        /// <returns>InlineResponse2006</returns>
        InlineResponse2006 UserGetMembershipFromHardLinkedCredential (string credential, int? crType);
        /// <summary>
        ///  Returns a list of possible users based on the search string
        /// </summary>
        /// <param name="q">The search string.</param>
        /// <returns>InlineResponse2003</returns>
        InlineResponse2003 UserSearchUsers (string q);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UserApi : IUserApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UserApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserApi(String basePath)
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
        ///  Returns a list of all available user themes.
        /// </summary>
        /// <returns>InlineResponse2004</returns>            
        public InlineResponse2004 UserGetAvailableThemes ()
        {
            
    
            var path = "/User/GetAvailableThemes/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UserGetAvailableThemes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserGetAvailableThemes: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2004) ApiClient.Deserialize(response.Content, typeof(InlineResponse2004), response.Headers);
        }
    
        /// <summary>
        ///  Loads a bungienet user by membership id.
        /// </summary>
        /// <param name="id">The requested Bungie.net membership id.</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 UserGetBungieNetUserById (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UserGetBungieNetUserById");
            
    
            var path = "/User/GetBungieNetUserById/{id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UserGetBungieNetUserById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserGetBungieNetUserById: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response.Content, typeof(InlineResponse2002), response.Headers);
        }
    
        /// <summary>
        ///  Returns a list of accounts associated with the supplied membership ID and membership type. This will include all linked accounts (even when hidden) if supplied credentials permit it.
        /// </summary>
        /// <param name="membershipId">The membership ID of the target user.</param> 
        /// <param name="membershipType">Type of the supplied membership ID.</param> 
        /// <returns>InlineResponse2005</returns>            
        public InlineResponse2005 UserGetMembershipDataById (long? membershipId, int? membershipType)
        {
            
            // verify the required parameter 'membershipId' is set
            if (membershipId == null) throw new ApiException(400, "Missing required parameter 'membershipId' when calling UserGetMembershipDataById");
            
            // verify the required parameter 'membershipType' is set
            if (membershipType == null) throw new ApiException(400, "Missing required parameter 'membershipType' when calling UserGetMembershipDataById");
            
    
            var path = "/User/GetMembershipsById/{membershipId}/{membershipType}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "membershipId" + "}", ApiClient.ParameterToString(membershipId));
path = path.Replace("{" + "membershipType" + "}", ApiClient.ParameterToString(membershipType));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UserGetMembershipDataById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserGetMembershipDataById: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2005) ApiClient.Deserialize(response.Content, typeof(InlineResponse2005), response.Headers);
        }
    
        /// <summary>
        ///  Returns a list of accounts associated with signed in user. This is useful for OAuth implementations that do not give you access to the token response.
        /// </summary>
        /// <returns>InlineResponse2005</returns>            
        public InlineResponse2005 UserGetMembershipDataForCurrentUser ()
        {
            
    
            var path = "/User/GetMembershipsForCurrentUser/";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling UserGetMembershipDataForCurrentUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserGetMembershipDataForCurrentUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2005) ApiClient.Deserialize(response.Content, typeof(InlineResponse2005), response.Headers);
        }
    
        /// <summary>
        ///  Gets any hard linked membership given a credential. Only works for credentials that are public (just SteamID64 right now). Cross Save aware.
        /// </summary>
        /// <param name="credential">The credential to look up. Must be a valid SteamID64.</param> 
        /// <param name="crType">The credential type. &#39;SteamId&#39; is the only valid value at present.</param> 
        /// <returns>InlineResponse2006</returns>            
        public InlineResponse2006 UserGetMembershipFromHardLinkedCredential (string credential, int? crType)
        {
            
            // verify the required parameter 'credential' is set
            if (credential == null) throw new ApiException(400, "Missing required parameter 'credential' when calling UserGetMembershipFromHardLinkedCredential");
            
            // verify the required parameter 'crType' is set
            if (crType == null) throw new ApiException(400, "Missing required parameter 'crType' when calling UserGetMembershipFromHardLinkedCredential");
            
    
            var path = "/User/GetMembershipFromHardLinkedCredential/{crType}/{credential}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "credential" + "}", ApiClient.ParameterToString(credential));
path = path.Replace("{" + "crType" + "}", ApiClient.ParameterToString(crType));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UserGetMembershipFromHardLinkedCredential: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserGetMembershipFromHardLinkedCredential: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2006) ApiClient.Deserialize(response.Content, typeof(InlineResponse2006), response.Headers);
        }
    
        /// <summary>
        ///  Returns a list of possible users based on the search string
        /// </summary>
        /// <param name="q">The search string.</param> 
        /// <returns>InlineResponse2003</returns>            
        public InlineResponse2003 UserSearchUsers (string q)
        {
            
    
            var path = "/User/SearchUsers/";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (q != null) queryParams.Add("q", ApiClient.ParameterToString(q)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UserSearchUsers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserSearchUsers: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2003) ApiClient.Deserialize(response.Content, typeof(InlineResponse2003), response.Headers);
        }
    
    }
}
