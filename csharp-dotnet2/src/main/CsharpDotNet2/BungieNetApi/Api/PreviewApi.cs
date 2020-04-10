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
    public interface IPreviewApi
    {
        /// <summary>
        ///  Gets aggregated stats for a clan using the same categories as the clan leaderboards. PREVIEW: This endpoint is still in beta, and may experience rough edges. The schema is in final form, but there may be bugs that prevent desirable operation.
        /// </summary>
        /// <param name="groupId">Group ID of the clan whose leaderboards you wish to fetch.</param>
        /// <param name="modes">List of game modes for which to get leaderboards. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited.</param>
        /// <returns>InlineResponse20050</returns>
        InlineResponse20050 Destiny2GetClanAggregateStats (long? groupId, string modes);
        /// <summary>
        ///  Gets leaderboards with the signed in user&#39;s friends and the supplied destinyMembershipId as the focus. PREVIEW: This endpoint is still in beta, and may experience rough edges. The schema is in final form, but there may be bugs that prevent desirable operation.
        /// </summary>
        /// <param name="groupId">Group ID of the clan whose leaderboards you wish to fetch.</param>
        /// <param name="maxtop">Maximum number of top players to return. Use a large number to get entire leaderboard.</param>
        /// <param name="modes">List of game modes for which to get leaderboards. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited.</param>
        /// <param name="statid">ID of stat to return rather than returning all Leaderboard stats.</param>
        /// <returns>InlineResponse20049</returns>
        InlineResponse20049 Destiny2GetClanLeaderboards (long? groupId, int? maxtop, string modes, string statid);
        /// <summary>
        ///  Gets leaderboards with the signed in user&#39;s friends and the supplied destinyMembershipId as the focus. PREVIEW: This endpoint has not yet been implemented. It is being returned for a preview of future functionality, and for public comment/suggestion/preparation.
        /// </summary>
        /// <param name="destinyMembershipId">The Destiny membershipId of the user to retrieve.</param>
        /// <param name="membershipType">A valid non-BungieNet membership type.</param>
        /// <param name="maxtop">Maximum number of top players to return. Use a large number to get entire leaderboard.</param>
        /// <param name="modes">List of game modes for which to get leaderboards. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited.</param>
        /// <param name="statid">ID of stat to return rather than returning all Leaderboard stats.</param>
        /// <returns>InlineResponse20049</returns>
        InlineResponse20049 Destiny2GetLeaderboards (long? destinyMembershipId, int? membershipType, int? maxtop, string modes, string statid);
        /// <summary>
        ///  Gets leaderboards with the signed in user&#39;s friends and the supplied destinyMembershipId as the focus. PREVIEW: This endpoint is still in beta, and may experience rough edges. The schema is in final form, but there may be bugs that prevent desirable operation.
        /// </summary>
        /// <param name="characterId">The specific character to build the leaderboard around for the provided Destiny Membership.</param>
        /// <param name="destinyMembershipId">The Destiny membershipId of the user to retrieve.</param>
        /// <param name="membershipType">A valid non-BungieNet membership type.</param>
        /// <param name="maxtop">Maximum number of top players to return. Use a large number to get entire leaderboard.</param>
        /// <param name="modes">List of game modes for which to get leaderboards. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited.</param>
        /// <param name="statid">ID of stat to return rather than returning all Leaderboard stats.</param>
        /// <returns>InlineResponse20049</returns>
        InlineResponse20049 Destiny2GetLeaderboardsForCharacter (long? characterId, long? destinyMembershipId, int? membershipType, int? maxtop, string modes, string statid);
        /// <summary>
        ///  Get items available from vendors where the vendors have items for sale that are common for everyone. If any portion of the Vendor&#39;s available inventory is character or account specific, we will be unable to return their data from this endpoint due to the way that available inventory is computed. As I am often guilty of saying: &#39;It&#39;s a long story...&#39;
        /// </summary>
        /// <param name="components">A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results.</param>
        /// <returns>InlineResponse20043</returns>
        InlineResponse20043 Destiny2GetPublicVendors (List<int?> components);
        /// <summary>
        ///  Insert a plug into a socketed item. I know how it sounds, but I assure you it&#39;s much more G-rated than you might be guessing. We haven&#39;t decided yet whether this will be able to insert plugs that have side effects, but if we do it will require special scope permission for an application attempting to do so. You must have a valid Destiny Account, and either be in a social space, in orbit, or offline. Request must include proof of permission for &#39;InsertPlugs&#39; from the account owner.
        /// </summary>
        /// <returns>InlineResponse20046</returns>
        InlineResponse20046 Destiny2InsertSocketPlug ();
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PreviewApi : IPreviewApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public PreviewApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PreviewApi(String basePath)
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
        ///  Gets aggregated stats for a clan using the same categories as the clan leaderboards. PREVIEW: This endpoint is still in beta, and may experience rough edges. The schema is in final form, but there may be bugs that prevent desirable operation.
        /// </summary>
        /// <param name="groupId">Group ID of the clan whose leaderboards you wish to fetch.</param> 
        /// <param name="modes">List of game modes for which to get leaderboards. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited.</param> 
        /// <returns>InlineResponse20050</returns>            
        public InlineResponse20050 Destiny2GetClanAggregateStats (long? groupId, string modes)
        {
            
            // verify the required parameter 'groupId' is set
            if (groupId == null) throw new ApiException(400, "Missing required parameter 'groupId' when calling Destiny2GetClanAggregateStats");
            
    
            var path = "/Destiny2/Stats/AggregateClanStats/{groupId}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "groupId" + "}", ApiClient.ParameterToString(groupId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (modes != null) queryParams.Add("modes", ApiClient.ParameterToString(modes)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2GetClanAggregateStats: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2GetClanAggregateStats: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20050) ApiClient.Deserialize(response.Content, typeof(InlineResponse20050), response.Headers);
        }
    
        /// <summary>
        ///  Gets leaderboards with the signed in user&#39;s friends and the supplied destinyMembershipId as the focus. PREVIEW: This endpoint is still in beta, and may experience rough edges. The schema is in final form, but there may be bugs that prevent desirable operation.
        /// </summary>
        /// <param name="groupId">Group ID of the clan whose leaderboards you wish to fetch.</param> 
        /// <param name="maxtop">Maximum number of top players to return. Use a large number to get entire leaderboard.</param> 
        /// <param name="modes">List of game modes for which to get leaderboards. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited.</param> 
        /// <param name="statid">ID of stat to return rather than returning all Leaderboard stats.</param> 
        /// <returns>InlineResponse20049</returns>            
        public InlineResponse20049 Destiny2GetClanLeaderboards (long? groupId, int? maxtop, string modes, string statid)
        {
            
            // verify the required parameter 'groupId' is set
            if (groupId == null) throw new ApiException(400, "Missing required parameter 'groupId' when calling Destiny2GetClanLeaderboards");
            
    
            var path = "/Destiny2/Stats/Leaderboards/Clans/{groupId}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "groupId" + "}", ApiClient.ParameterToString(groupId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (maxtop != null) queryParams.Add("maxtop", ApiClient.ParameterToString(maxtop)); // query parameter
 if (modes != null) queryParams.Add("modes", ApiClient.ParameterToString(modes)); // query parameter
 if (statid != null) queryParams.Add("statid", ApiClient.ParameterToString(statid)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2GetClanLeaderboards: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2GetClanLeaderboards: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20049) ApiClient.Deserialize(response.Content, typeof(InlineResponse20049), response.Headers);
        }
    
        /// <summary>
        ///  Gets leaderboards with the signed in user&#39;s friends and the supplied destinyMembershipId as the focus. PREVIEW: This endpoint has not yet been implemented. It is being returned for a preview of future functionality, and for public comment/suggestion/preparation.
        /// </summary>
        /// <param name="destinyMembershipId">The Destiny membershipId of the user to retrieve.</param> 
        /// <param name="membershipType">A valid non-BungieNet membership type.</param> 
        /// <param name="maxtop">Maximum number of top players to return. Use a large number to get entire leaderboard.</param> 
        /// <param name="modes">List of game modes for which to get leaderboards. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited.</param> 
        /// <param name="statid">ID of stat to return rather than returning all Leaderboard stats.</param> 
        /// <returns>InlineResponse20049</returns>            
        public InlineResponse20049 Destiny2GetLeaderboards (long? destinyMembershipId, int? membershipType, int? maxtop, string modes, string statid)
        {
            
            // verify the required parameter 'destinyMembershipId' is set
            if (destinyMembershipId == null) throw new ApiException(400, "Missing required parameter 'destinyMembershipId' when calling Destiny2GetLeaderboards");
            
            // verify the required parameter 'membershipType' is set
            if (membershipType == null) throw new ApiException(400, "Missing required parameter 'membershipType' when calling Destiny2GetLeaderboards");
            
    
            var path = "/Destiny2/{membershipType}/Account/{destinyMembershipId}/Stats/Leaderboards/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "destinyMembershipId" + "}", ApiClient.ParameterToString(destinyMembershipId));
path = path.Replace("{" + "membershipType" + "}", ApiClient.ParameterToString(membershipType));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (maxtop != null) queryParams.Add("maxtop", ApiClient.ParameterToString(maxtop)); // query parameter
 if (modes != null) queryParams.Add("modes", ApiClient.ParameterToString(modes)); // query parameter
 if (statid != null) queryParams.Add("statid", ApiClient.ParameterToString(statid)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2GetLeaderboards: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2GetLeaderboards: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20049) ApiClient.Deserialize(response.Content, typeof(InlineResponse20049), response.Headers);
        }
    
        /// <summary>
        ///  Gets leaderboards with the signed in user&#39;s friends and the supplied destinyMembershipId as the focus. PREVIEW: This endpoint is still in beta, and may experience rough edges. The schema is in final form, but there may be bugs that prevent desirable operation.
        /// </summary>
        /// <param name="characterId">The specific character to build the leaderboard around for the provided Destiny Membership.</param> 
        /// <param name="destinyMembershipId">The Destiny membershipId of the user to retrieve.</param> 
        /// <param name="membershipType">A valid non-BungieNet membership type.</param> 
        /// <param name="maxtop">Maximum number of top players to return. Use a large number to get entire leaderboard.</param> 
        /// <param name="modes">List of game modes for which to get leaderboards. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited.</param> 
        /// <param name="statid">ID of stat to return rather than returning all Leaderboard stats.</param> 
        /// <returns>InlineResponse20049</returns>            
        public InlineResponse20049 Destiny2GetLeaderboardsForCharacter (long? characterId, long? destinyMembershipId, int? membershipType, int? maxtop, string modes, string statid)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling Destiny2GetLeaderboardsForCharacter");
            
            // verify the required parameter 'destinyMembershipId' is set
            if (destinyMembershipId == null) throw new ApiException(400, "Missing required parameter 'destinyMembershipId' when calling Destiny2GetLeaderboardsForCharacter");
            
            // verify the required parameter 'membershipType' is set
            if (membershipType == null) throw new ApiException(400, "Missing required parameter 'membershipType' when calling Destiny2GetLeaderboardsForCharacter");
            
    
            var path = "/Destiny2/Stats/Leaderboards/{membershipType}/{destinyMembershipId}/{characterId}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "characterId" + "}", ApiClient.ParameterToString(characterId));
path = path.Replace("{" + "destinyMembershipId" + "}", ApiClient.ParameterToString(destinyMembershipId));
path = path.Replace("{" + "membershipType" + "}", ApiClient.ParameterToString(membershipType));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (maxtop != null) queryParams.Add("maxtop", ApiClient.ParameterToString(maxtop)); // query parameter
 if (modes != null) queryParams.Add("modes", ApiClient.ParameterToString(modes)); // query parameter
 if (statid != null) queryParams.Add("statid", ApiClient.ParameterToString(statid)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2GetLeaderboardsForCharacter: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2GetLeaderboardsForCharacter: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20049) ApiClient.Deserialize(response.Content, typeof(InlineResponse20049), response.Headers);
        }
    
        /// <summary>
        ///  Get items available from vendors where the vendors have items for sale that are common for everyone. If any portion of the Vendor&#39;s available inventory is character or account specific, we will be unable to return their data from this endpoint due to the way that available inventory is computed. As I am often guilty of saying: &#39;It&#39;s a long story...&#39;
        /// </summary>
        /// <param name="components">A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results.</param> 
        /// <returns>InlineResponse20043</returns>            
        public InlineResponse20043 Destiny2GetPublicVendors (List<int?> components)
        {
            
    
            var path = "/Destiny2//Vendors/";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (components != null) queryParams.Add("components", ApiClient.ParameterToString(components)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2GetPublicVendors: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2GetPublicVendors: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20043) ApiClient.Deserialize(response.Content, typeof(InlineResponse20043), response.Headers);
        }
    
        /// <summary>
        ///  Insert a plug into a socketed item. I know how it sounds, but I assure you it&#39;s much more G-rated than you might be guessing. We haven&#39;t decided yet whether this will be able to insert plugs that have side effects, but if we do it will require special scope permission for an application attempting to do so. You must have a valid Destiny Account, and either be in a social space, in orbit, or offline. Request must include proof of permission for &#39;InsertPlugs&#39; from the account owner.
        /// </summary>
        /// <returns>InlineResponse20046</returns>            
        public InlineResponse20046 Destiny2InsertSocketPlug ()
        {
            
    
            var path = "/Destiny2/Actions/Items/InsertSocketPlug/";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2InsertSocketPlug: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2InsertSocketPlug: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20046) ApiClient.Deserialize(response.Content, typeof(InlineResponse20046), response.Headers);
        }
    
    }
}
