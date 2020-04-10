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
    public interface IDestiny2Api
    {
        /// <summary>
        ///  Returns the action token if user approves the request.
        /// </summary>
        /// <param name="correlationId">The identifier for the advanced write action request.</param>
        /// <returns>InlineResponse20060</returns>
        InlineResponse20060 Destiny2AwaGetActionToken (string correlationId);
        /// <summary>
        ///  Initialize a request to perform an advanced write action.
        /// </summary>
        /// <returns>InlineResponse20059</returns>
        InlineResponse20059 Destiny2AwaInitializeRequest ();
        /// <summary>
        ///  Provide the result of the user interaction. Called by the Bungie Destiny App to approve or reject a request.
        /// </summary>
        /// <returns>InlineResponse20022</returns>
        InlineResponse20022 Destiny2AwaProvideAuthorizationResult ();
        /// <summary>
        ///  Equip an item. You must have a valid Destiny Account, and either be in a social space, in orbit, or offline.
        /// </summary>
        /// <returns>InlineResponse20022</returns>
        InlineResponse20022 Destiny2EquipItem ();
        /// <summary>
        ///  Equip a list of items by itemInstanceIds. You must have a valid Destiny Account, and either be in a social space, in orbit, or offline. Any items not found on your character will be ignored.
        /// </summary>
        /// <returns>InlineResponse20045</returns>
        InlineResponse20045 Destiny2EquipItems ();
        /// <summary>
        ///  Gets activity history stats for indicated character.
        /// </summary>
        /// <param name="characterId">The id of the character to retrieve.</param>
        /// <param name="destinyMembershipId">The Destiny membershipId of the user to retrieve.</param>
        /// <param name="membershipType">A valid non-BungieNet membership type.</param>
        /// <param name="count">Number of rows to return</param>
        /// <param name="mode">A filter for the activity mode to be returned. None returns all activities. See the documentation for DestinyActivityModeType for valid values, and pass in string representation.</param>
        /// <param name="page">Page number to return, starting with 0.</param>
        /// <returns>InlineResponse20054</returns>
        InlineResponse20054 Destiny2GetActivityHistory (long? characterId, long? destinyMembershipId, int? membershipType, int? count, int? mode, int? page);
        /// <summary>
        ///  Returns character information for the supplied character.
        /// </summary>
        /// <param name="characterId">ID of the character.</param>
        /// <param name="destinyMembershipId">Destiny membership ID.</param>
        /// <param name="membershipType">A valid non-BungieNet membership type.</param>
        /// <param name="components">A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results.</param>
        /// <returns>InlineResponse20038</returns>
        InlineResponse20038 Destiny2GetCharacter (long? characterId, long? destinyMembershipId, int? membershipType, List<int?> components);
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
        ///  Returns information on the weekly clan rewards and if the clan has earned them or not. Note that this will always report rewards as not redeemed.
        /// </summary>
        /// <param name="groupId">A valid group id of clan.</param>
        /// <returns>InlineResponse20039</returns>
        InlineResponse20039 Destiny2GetClanWeeklyRewardState (long? groupId);
        /// <summary>
        ///  Given a Presentation Node that has Collectibles as direct descendants, this will return item details about those descendants in the context of the requesting character.
        /// </summary>
        /// <param name="characterId">The Destiny Character ID of the character for whom we&#39;re getting collectible detail info.</param>
        /// <param name="collectiblePresentationNodeHash">The hash identifier of the Presentation Node for whom we should return collectible details. Details will only be returned for collectibles that are direct descendants of this node.</param>
        /// <param name="destinyMembershipId">Destiny membership ID of another user. You may be denied.</param>
        /// <param name="membershipType">A valid non-BungieNet membership type.</param>
        /// <param name="components">A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results.</param>
        /// <returns>InlineResponse20044</returns>
        InlineResponse20044 Destiny2GetCollectibleNodeDetails (long? characterId, int? collectiblePresentationNodeHash, long? destinyMembershipId, int? membershipType, List<int?> components);
        /// <summary>
        ///  Gets all activities the character has participated in together with aggregate statistics for those activities.
        /// </summary>
        /// <param name="characterId">The specific character whose activities should be returned.</param>
        /// <param name="destinyMembershipId">The Destiny membershipId of the user to retrieve.</param>
        /// <param name="membershipType">A valid non-BungieNet membership type.</param>
        /// <returns>InlineResponse20056</returns>
        InlineResponse20056 Destiny2GetDestinyAggregateActivityStats (long? characterId, long? destinyMembershipId, int? membershipType);
        /// <summary>
        ///  Returns the static definition of an entity of the given Type and hash identifier. Examine the API Documentation for the Type Names of entities that have their own definitions. Note that the return type will always *inherit from* DestinyDefinition, but the specific type returned will be the requested entity type if it can be found. Please don&#39;t use this as a chatty alternative to the Manifest database if you require large sets of data, but for simple and one-off accesses this should be handy.
        /// </summary>
        /// <param name="entityType">The type of entity for whom you would like results. These correspond to the entity&#39;s definition contract name. For instance, if you are looking for items, this property should be &#39;DestinyInventoryItemDefinition&#39;. PREVIEW: This endpoint is still in beta, and may experience rough edges. The schema is tentatively in final form, but there may be bugs that prevent desirable operation.</param>
        /// <param name="hashIdentifier">The hash identifier for the specific Entity you want returned.</param>
        /// <returns>InlineResponse20034</returns>
        InlineResponse20034 Destiny2GetDestinyEntityDefinition (string entityType, int? hashIdentifier);
        /// <summary>
        ///  Returns the current version of the manifest as a json object.
        /// </summary>
        /// <returns>InlineResponse20033</returns>
        InlineResponse20033 Destiny2GetDestinyManifest ();
        /// <summary>
        ///  Gets historical stats for indicated character.
        /// </summary>
        /// <param name="characterId">The id of the character to retrieve. You can omit this character ID or set it to 0 to get aggregate stats across all characters.</param>
        /// <param name="destinyMembershipId">The Destiny membershipId of the user to retrieve.</param>
        /// <param name="membershipType">A valid non-BungieNet membership type.</param>
        /// <param name="dayend">Last day to return when daily stats are requested. Use the format YYYY-MM-DD. Currently, we cannot allow more than 31 days of daily data to be requested in a single request.</param>
        /// <param name="daystart">First day to return when daily stats are requested. Use the format YYYY-MM-DD. Currently, we cannot allow more than 31 days of daily data to be requested in a single request.</param>
        /// <param name="groups">Group of stats to include, otherwise only general stats are returned. Comma separated list is allowed. Values: General, Weapons, Medals</param>
        /// <param name="modes">Game modes to return. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited.</param>
        /// <param name="periodType">Indicates a specific period type to return. Optional. May be: Daily, AllTime, or Activity</param>
        /// <returns>InlineResponse20052</returns>
        InlineResponse20052 Destiny2GetHistoricalStats (long? characterId, long? destinyMembershipId, int? membershipType, DateTime? dayend, DateTime? daystart, List<int?> groups, List<int?> modes, int? periodType);
        /// <summary>
        ///  Gets historical stats definitions.
        /// </summary>
        /// <returns>InlineResponse20048</returns>
        InlineResponse20048 Destiny2GetHistoricalStatsDefinition ();
        /// <summary>
        ///  Gets aggregate historical stats organized around each character for a given account.
        /// </summary>
        /// <param name="destinyMembershipId">The Destiny membershipId of the user to retrieve.</param>
        /// <param name="membershipType">A valid non-BungieNet membership type.</param>
        /// <param name="groups">Groups of stats to include, otherwise only general stats are returned. Comma separated list is allowed. Values: General, Weapons, Medals.</param>
        /// <returns>InlineResponse20053</returns>
        InlineResponse20053 Destiny2GetHistoricalStatsForAccount (long? destinyMembershipId, int? membershipType, List<int?> groups);
        /// <summary>
        ///  Retrieve the details of an instanced Destiny Item. An instanced Destiny item is one with an ItemInstanceId. Non-instanced items, such as materials, have no useful instance-specific details and thus are not queryable here.
        /// </summary>
        /// <param name="destinyMembershipId">The membership ID of the destiny profile.</param>
        /// <param name="itemInstanceId">The Instance ID of the destiny item.</param>
        /// <param name="membershipType">A valid non-BungieNet membership type.</param>
        /// <param name="components">A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results.</param>
        /// <returns>InlineResponse20040</returns>
        InlineResponse20040 Destiny2GetItem (long? destinyMembershipId, long? itemInstanceId, int? membershipType, List<int?> components);
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
        ///  Returns a summary information about all profiles linked to the requesting membership type/membership ID that have valid Destiny information. The passed-in Membership Type/Membership ID may be a Bungie.Net membership or a Destiny membership. It only returns the minimal amount of data to begin making more substantive requests, but will hopefully serve as a useful alternative to UserServices for people who just care about Destiny data. Note that it will only return linked accounts whose linkages you are allowed to view.
        /// </summary>
        /// <param name="membershipId">The ID of the membership whose linked Destiny accounts you want returned. Make sure your membership ID matches its Membership Type: don&#39;t pass us a PSN membership ID and the XBox membership type, it&#39;s not going to work!</param>
        /// <param name="membershipType">The type for the membership whose linked Destiny accounts you want returned.</param>
        /// <param name="getAllMemberships">(optional) if set to &#39;true&#39;, all memberships regardless of whether they&#39;re obscured by overrides will be returned. Normal privacy restrictions on account linking will still apply no matter what.</param>
        /// <returns>InlineResponse20036</returns>
        InlineResponse20036 Destiny2GetLinkedProfiles (long? membershipId, int? membershipType, bool? getAllMemberships);
        /// <summary>
        ///  Gets the available post game carnage report for the activity ID.
        /// </summary>
        /// <param name="activityId">The ID of the activity whose PGCR is requested.</param>
        /// <returns>InlineResponse20047</returns>
        InlineResponse20047 Destiny2GetPostGameCarnageReport (long? activityId);
        /// <summary>
        ///  Returns Destiny Profile information for the supplied membership.
        /// </summary>
        /// <param name="destinyMembershipId">Destiny membership ID.</param>
        /// <param name="membershipType">A valid non-BungieNet membership type.</param>
        /// <param name="components">A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results.</param>
        /// <returns>InlineResponse20037</returns>
        InlineResponse20037 Destiny2GetProfile (long? destinyMembershipId, int? membershipType, List<int?> components);
        /// <summary>
        ///  Gets custom localized content for the milestone of the given hash, if it exists.
        /// </summary>
        /// <param name="milestoneHash">The identifier for the milestone to be returned.</param>
        /// <returns>InlineResponse20057</returns>
        InlineResponse20057 Destiny2GetPublicMilestoneContent (int? milestoneHash);
        /// <summary>
        ///  Gets public information about currently available Milestones.
        /// </summary>
        /// <returns>InlineResponse20058</returns>
        InlineResponse20058 Destiny2GetPublicMilestones ();
        /// <summary>
        ///  Get items available from vendors where the vendors have items for sale that are common for everyone. If any portion of the Vendor&#39;s available inventory is character or account specific, we will be unable to return their data from this endpoint due to the way that available inventory is computed. As I am often guilty of saying: &#39;It&#39;s a long story...&#39;
        /// </summary>
        /// <param name="components">A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results.</param>
        /// <returns>InlineResponse20043</returns>
        InlineResponse20043 Destiny2GetPublicVendors (List<int?> components);
        /// <summary>
        ///  Gets details about unique weapon usage, including all exotic weapons.
        /// </summary>
        /// <param name="characterId">The id of the character to retrieve.</param>
        /// <param name="destinyMembershipId">The Destiny membershipId of the user to retrieve.</param>
        /// <param name="membershipType">A valid non-BungieNet membership type.</param>
        /// <returns>InlineResponse20055</returns>
        InlineResponse20055 Destiny2GetUniqueWeaponHistory (long? characterId, long? destinyMembershipId, int? membershipType);
        /// <summary>
        ///  Get the details of a specific Vendor.
        /// </summary>
        /// <param name="characterId">The Destiny Character ID of the character for whom we&#39;re getting vendor info.</param>
        /// <param name="destinyMembershipId">Destiny membership ID of another user. You may be denied.</param>
        /// <param name="membershipType">A valid non-BungieNet membership type.</param>
        /// <param name="vendorHash">The Hash identifier of the Vendor to be returned.</param>
        /// <param name="components">A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results.</param>
        /// <returns>InlineResponse20042</returns>
        InlineResponse20042 Destiny2GetVendor (long? characterId, long? destinyMembershipId, int? membershipType, int? vendorHash, List<int?> components);
        /// <summary>
        ///  Get currently available vendors from the list of vendors that can possibly have rotating inventory. Note that this does not include things like preview vendors and vendors-as-kiosks, neither of whom have rotating/dynamic inventories. Use their definitions as-is for those.
        /// </summary>
        /// <param name="characterId">The Destiny Character ID of the character for whom we&#39;re getting vendor info.</param>
        /// <param name="destinyMembershipId">Destiny membership ID of another user. You may be denied.</param>
        /// <param name="membershipType">A valid non-BungieNet membership type.</param>
        /// <param name="components">A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results.</param>
        /// <returns>InlineResponse20041</returns>
        InlineResponse20041 Destiny2GetVendors (long? characterId, long? destinyMembershipId, int? membershipType, List<int?> components);
        /// <summary>
        ///  Insert a plug into a socketed item. I know how it sounds, but I assure you it&#39;s much more G-rated than you might be guessing. We haven&#39;t decided yet whether this will be able to insert plugs that have side effects, but if we do it will require special scope permission for an application attempting to do so. You must have a valid Destiny Account, and either be in a social space, in orbit, or offline. Request must include proof of permission for &#39;InsertPlugs&#39; from the account owner.
        /// </summary>
        /// <returns>InlineResponse20046</returns>
        InlineResponse20046 Destiny2InsertSocketPlug ();
        /// <summary>
        ///  Extract an item from the Postmaster, with whatever implications that may entail. You must have a valid Destiny account. You must also pass BOTH a reference AND an instance ID if it&#39;s an instanced item.
        /// </summary>
        /// <returns>InlineResponse20022</returns>
        InlineResponse20022 Destiny2PullFromPostmaster ();
        /// <summary>
        ///  Report a player that you met in an activity that was engaging in ToS-violating activities. Both you and the offending player must have played in the activityId passed in. Please use this judiciously and only when you have strong suspicions of violation, pretty please.
        /// </summary>
        /// <param name="activityId">The ID of the activity where you ran into the brigand that you&#39;re reporting.</param>
        /// <returns>InlineResponse20022</returns>
        InlineResponse20022 Destiny2ReportOffensivePostGameCarnageReportPlayer (long? activityId);
        /// <summary>
        ///  Gets a page list of Destiny items.
        /// </summary>
        /// <param name="searchTerm">The string to use when searching for Destiny entities.</param>
        /// <param name="type">The type of entity for whom you would like results. These correspond to the entity&#39;s definition contract name. For instance, if you are looking for items, this property should be &#39;DestinyInventoryItemDefinition&#39;.</param>
        /// <param name="page">Page number to return, starting with 0.</param>
        /// <returns>InlineResponse20051</returns>
        InlineResponse20051 Destiny2SearchDestinyEntities (string searchTerm, string type, int? page);
        /// <summary>
        ///  Returns a list of Destiny memberships given a full Gamertag or PSN ID. Unless you pass returnOriginalProfile&#x3D;true, this will return membership information for the users&#39; Primary Cross Save Profile if they are engaged in cross save rather than any original Destiny profile that is now being overridden.
        /// </summary>
        /// <param name="displayName">The full gamertag or PSN id of the player. Spaces and case are ignored.</param>
        /// <param name="membershipType">A valid non-BungieNet membership type, or All.</param>
        /// <param name="returnOriginalProfile">(optional) If passed in and set to true, we will return the original Destiny Profile(s) linked to that gamertag, and not their currently active Destiny Profile.</param>
        /// <returns>InlineResponse20035</returns>
        InlineResponse20035 Destiny2SearchDestinyPlayer (string displayName, int? membershipType, bool? returnOriginalProfile);
        /// <summary>
        ///  Set the Lock State for an instanced item. You must have a valid Destiny Account.
        /// </summary>
        /// <returns>InlineResponse20022</returns>
        InlineResponse20022 Destiny2SetItemLockState ();
        /// <summary>
        ///  Transfer an item to/from your vault. You must have a valid Destiny account. You must also pass BOTH a reference AND an instance ID if it&#39;s an instanced item. itshappening.gif
        /// </summary>
        /// <returns>InlineResponse20022</returns>
        InlineResponse20022 Destiny2TransferItem ();
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class Destiny2Api : IDestiny2Api
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Destiny2Api"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public Destiny2Api(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Destiny2Api"/> class.
        /// </summary>
        /// <returns></returns>
        public Destiny2Api(String basePath)
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
        ///  Returns the action token if user approves the request.
        /// </summary>
        /// <param name="correlationId">The identifier for the advanced write action request.</param> 
        /// <returns>InlineResponse20060</returns>            
        public InlineResponse20060 Destiny2AwaGetActionToken (string correlationId)
        {
            
            // verify the required parameter 'correlationId' is set
            if (correlationId == null) throw new ApiException(400, "Missing required parameter 'correlationId' when calling Destiny2AwaGetActionToken");
            
    
            var path = "/Destiny2/Awa/GetActionToken/{correlationId}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "correlationId" + "}", ApiClient.ParameterToString(correlationId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2AwaGetActionToken: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2AwaGetActionToken: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20060) ApiClient.Deserialize(response.Content, typeof(InlineResponse20060), response.Headers);
        }
    
        /// <summary>
        ///  Initialize a request to perform an advanced write action.
        /// </summary>
        /// <returns>InlineResponse20059</returns>            
        public InlineResponse20059 Destiny2AwaInitializeRequest ()
        {
            
    
            var path = "/Destiny2/Awa/Initialize/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2AwaInitializeRequest: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2AwaInitializeRequest: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20059) ApiClient.Deserialize(response.Content, typeof(InlineResponse20059), response.Headers);
        }
    
        /// <summary>
        ///  Provide the result of the user interaction. Called by the Bungie Destiny App to approve or reject a request.
        /// </summary>
        /// <returns>InlineResponse20022</returns>            
        public InlineResponse20022 Destiny2AwaProvideAuthorizationResult ()
        {
            
    
            var path = "/Destiny2/Awa/AwaProvideAuthorizationResult/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2AwaProvideAuthorizationResult: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2AwaProvideAuthorizationResult: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20022) ApiClient.Deserialize(response.Content, typeof(InlineResponse20022), response.Headers);
        }
    
        /// <summary>
        ///  Equip an item. You must have a valid Destiny Account, and either be in a social space, in orbit, or offline.
        /// </summary>
        /// <returns>InlineResponse20022</returns>            
        public InlineResponse20022 Destiny2EquipItem ()
        {
            
    
            var path = "/Destiny2/Actions/Items/EquipItem/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2EquipItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2EquipItem: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20022) ApiClient.Deserialize(response.Content, typeof(InlineResponse20022), response.Headers);
        }
    
        /// <summary>
        ///  Equip a list of items by itemInstanceIds. You must have a valid Destiny Account, and either be in a social space, in orbit, or offline. Any items not found on your character will be ignored.
        /// </summary>
        /// <returns>InlineResponse20045</returns>            
        public InlineResponse20045 Destiny2EquipItems ()
        {
            
    
            var path = "/Destiny2/Actions/Items/EquipItems/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2EquipItems: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2EquipItems: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20045) ApiClient.Deserialize(response.Content, typeof(InlineResponse20045), response.Headers);
        }
    
        /// <summary>
        ///  Gets activity history stats for indicated character.
        /// </summary>
        /// <param name="characterId">The id of the character to retrieve.</param> 
        /// <param name="destinyMembershipId">The Destiny membershipId of the user to retrieve.</param> 
        /// <param name="membershipType">A valid non-BungieNet membership type.</param> 
        /// <param name="count">Number of rows to return</param> 
        /// <param name="mode">A filter for the activity mode to be returned. None returns all activities. See the documentation for DestinyActivityModeType for valid values, and pass in string representation.</param> 
        /// <param name="page">Page number to return, starting with 0.</param> 
        /// <returns>InlineResponse20054</returns>            
        public InlineResponse20054 Destiny2GetActivityHistory (long? characterId, long? destinyMembershipId, int? membershipType, int? count, int? mode, int? page)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling Destiny2GetActivityHistory");
            
            // verify the required parameter 'destinyMembershipId' is set
            if (destinyMembershipId == null) throw new ApiException(400, "Missing required parameter 'destinyMembershipId' when calling Destiny2GetActivityHistory");
            
            // verify the required parameter 'membershipType' is set
            if (membershipType == null) throw new ApiException(400, "Missing required parameter 'membershipType' when calling Destiny2GetActivityHistory");
            
    
            var path = "/Destiny2/{membershipType}/Account/{destinyMembershipId}/Character/{characterId}/Stats/Activities/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "characterId" + "}", ApiClient.ParameterToString(characterId));
path = path.Replace("{" + "destinyMembershipId" + "}", ApiClient.ParameterToString(destinyMembershipId));
path = path.Replace("{" + "membershipType" + "}", ApiClient.ParameterToString(membershipType));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (mode != null) queryParams.Add("mode", ApiClient.ParameterToString(mode)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2GetActivityHistory: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2GetActivityHistory: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20054) ApiClient.Deserialize(response.Content, typeof(InlineResponse20054), response.Headers);
        }
    
        /// <summary>
        ///  Returns character information for the supplied character.
        /// </summary>
        /// <param name="characterId">ID of the character.</param> 
        /// <param name="destinyMembershipId">Destiny membership ID.</param> 
        /// <param name="membershipType">A valid non-BungieNet membership type.</param> 
        /// <param name="components">A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results.</param> 
        /// <returns>InlineResponse20038</returns>            
        public InlineResponse20038 Destiny2GetCharacter (long? characterId, long? destinyMembershipId, int? membershipType, List<int?> components)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling Destiny2GetCharacter");
            
            // verify the required parameter 'destinyMembershipId' is set
            if (destinyMembershipId == null) throw new ApiException(400, "Missing required parameter 'destinyMembershipId' when calling Destiny2GetCharacter");
            
            // verify the required parameter 'membershipType' is set
            if (membershipType == null) throw new ApiException(400, "Missing required parameter 'membershipType' when calling Destiny2GetCharacter");
            
    
            var path = "/Destiny2/{membershipType}/Profile/{destinyMembershipId}/Character/{characterId}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "characterId" + "}", ApiClient.ParameterToString(characterId));
path = path.Replace("{" + "destinyMembershipId" + "}", ApiClient.ParameterToString(destinyMembershipId));
path = path.Replace("{" + "membershipType" + "}", ApiClient.ParameterToString(membershipType));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2GetCharacter: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2GetCharacter: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20038) ApiClient.Deserialize(response.Content, typeof(InlineResponse20038), response.Headers);
        }
    
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
        ///  Returns information on the weekly clan rewards and if the clan has earned them or not. Note that this will always report rewards as not redeemed.
        /// </summary>
        /// <param name="groupId">A valid group id of clan.</param> 
        /// <returns>InlineResponse20039</returns>            
        public InlineResponse20039 Destiny2GetClanWeeklyRewardState (long? groupId)
        {
            
            // verify the required parameter 'groupId' is set
            if (groupId == null) throw new ApiException(400, "Missing required parameter 'groupId' when calling Destiny2GetClanWeeklyRewardState");
            
    
            var path = "/Destiny2/Clan/{groupId}/WeeklyRewardState/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "groupId" + "}", ApiClient.ParameterToString(groupId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2GetClanWeeklyRewardState: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2GetClanWeeklyRewardState: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20039) ApiClient.Deserialize(response.Content, typeof(InlineResponse20039), response.Headers);
        }
    
        /// <summary>
        ///  Given a Presentation Node that has Collectibles as direct descendants, this will return item details about those descendants in the context of the requesting character.
        /// </summary>
        /// <param name="characterId">The Destiny Character ID of the character for whom we&#39;re getting collectible detail info.</param> 
        /// <param name="collectiblePresentationNodeHash">The hash identifier of the Presentation Node for whom we should return collectible details. Details will only be returned for collectibles that are direct descendants of this node.</param> 
        /// <param name="destinyMembershipId">Destiny membership ID of another user. You may be denied.</param> 
        /// <param name="membershipType">A valid non-BungieNet membership type.</param> 
        /// <param name="components">A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results.</param> 
        /// <returns>InlineResponse20044</returns>            
        public InlineResponse20044 Destiny2GetCollectibleNodeDetails (long? characterId, int? collectiblePresentationNodeHash, long? destinyMembershipId, int? membershipType, List<int?> components)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling Destiny2GetCollectibleNodeDetails");
            
            // verify the required parameter 'collectiblePresentationNodeHash' is set
            if (collectiblePresentationNodeHash == null) throw new ApiException(400, "Missing required parameter 'collectiblePresentationNodeHash' when calling Destiny2GetCollectibleNodeDetails");
            
            // verify the required parameter 'destinyMembershipId' is set
            if (destinyMembershipId == null) throw new ApiException(400, "Missing required parameter 'destinyMembershipId' when calling Destiny2GetCollectibleNodeDetails");
            
            // verify the required parameter 'membershipType' is set
            if (membershipType == null) throw new ApiException(400, "Missing required parameter 'membershipType' when calling Destiny2GetCollectibleNodeDetails");
            
    
            var path = "/Destiny2/{membershipType}/Profile/{destinyMembershipId}/Character/{characterId}/Collectibles/{collectiblePresentationNodeHash}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "characterId" + "}", ApiClient.ParameterToString(characterId));
path = path.Replace("{" + "collectiblePresentationNodeHash" + "}", ApiClient.ParameterToString(collectiblePresentationNodeHash));
path = path.Replace("{" + "destinyMembershipId" + "}", ApiClient.ParameterToString(destinyMembershipId));
path = path.Replace("{" + "membershipType" + "}", ApiClient.ParameterToString(membershipType));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2GetCollectibleNodeDetails: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2GetCollectibleNodeDetails: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20044) ApiClient.Deserialize(response.Content, typeof(InlineResponse20044), response.Headers);
        }
    
        /// <summary>
        ///  Gets all activities the character has participated in together with aggregate statistics for those activities.
        /// </summary>
        /// <param name="characterId">The specific character whose activities should be returned.</param> 
        /// <param name="destinyMembershipId">The Destiny membershipId of the user to retrieve.</param> 
        /// <param name="membershipType">A valid non-BungieNet membership type.</param> 
        /// <returns>InlineResponse20056</returns>            
        public InlineResponse20056 Destiny2GetDestinyAggregateActivityStats (long? characterId, long? destinyMembershipId, int? membershipType)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling Destiny2GetDestinyAggregateActivityStats");
            
            // verify the required parameter 'destinyMembershipId' is set
            if (destinyMembershipId == null) throw new ApiException(400, "Missing required parameter 'destinyMembershipId' when calling Destiny2GetDestinyAggregateActivityStats");
            
            // verify the required parameter 'membershipType' is set
            if (membershipType == null) throw new ApiException(400, "Missing required parameter 'membershipType' when calling Destiny2GetDestinyAggregateActivityStats");
            
    
            var path = "/Destiny2/{membershipType}/Account/{destinyMembershipId}/Character/{characterId}/Stats/AggregateActivityStats/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "characterId" + "}", ApiClient.ParameterToString(characterId));
path = path.Replace("{" + "destinyMembershipId" + "}", ApiClient.ParameterToString(destinyMembershipId));
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
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2GetDestinyAggregateActivityStats: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2GetDestinyAggregateActivityStats: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20056) ApiClient.Deserialize(response.Content, typeof(InlineResponse20056), response.Headers);
        }
    
        /// <summary>
        ///  Returns the static definition of an entity of the given Type and hash identifier. Examine the API Documentation for the Type Names of entities that have their own definitions. Note that the return type will always *inherit from* DestinyDefinition, but the specific type returned will be the requested entity type if it can be found. Please don&#39;t use this as a chatty alternative to the Manifest database if you require large sets of data, but for simple and one-off accesses this should be handy.
        /// </summary>
        /// <param name="entityType">The type of entity for whom you would like results. These correspond to the entity&#39;s definition contract name. For instance, if you are looking for items, this property should be &#39;DestinyInventoryItemDefinition&#39;. PREVIEW: This endpoint is still in beta, and may experience rough edges. The schema is tentatively in final form, but there may be bugs that prevent desirable operation.</param> 
        /// <param name="hashIdentifier">The hash identifier for the specific Entity you want returned.</param> 
        /// <returns>InlineResponse20034</returns>            
        public InlineResponse20034 Destiny2GetDestinyEntityDefinition (string entityType, int? hashIdentifier)
        {
            
            // verify the required parameter 'entityType' is set
            if (entityType == null) throw new ApiException(400, "Missing required parameter 'entityType' when calling Destiny2GetDestinyEntityDefinition");
            
            // verify the required parameter 'hashIdentifier' is set
            if (hashIdentifier == null) throw new ApiException(400, "Missing required parameter 'hashIdentifier' when calling Destiny2GetDestinyEntityDefinition");
            
    
            var path = "/Destiny2/Manifest/{entityType}/{hashIdentifier}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "entityType" + "}", ApiClient.ParameterToString(entityType));
path = path.Replace("{" + "hashIdentifier" + "}", ApiClient.ParameterToString(hashIdentifier));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2GetDestinyEntityDefinition: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2GetDestinyEntityDefinition: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20034) ApiClient.Deserialize(response.Content, typeof(InlineResponse20034), response.Headers);
        }
    
        /// <summary>
        ///  Returns the current version of the manifest as a json object.
        /// </summary>
        /// <returns>InlineResponse20033</returns>            
        public InlineResponse20033 Destiny2GetDestinyManifest ()
        {
            
    
            var path = "/Destiny2/Manifest/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2GetDestinyManifest: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2GetDestinyManifest: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20033) ApiClient.Deserialize(response.Content, typeof(InlineResponse20033), response.Headers);
        }
    
        /// <summary>
        ///  Gets historical stats for indicated character.
        /// </summary>
        /// <param name="characterId">The id of the character to retrieve. You can omit this character ID or set it to 0 to get aggregate stats across all characters.</param> 
        /// <param name="destinyMembershipId">The Destiny membershipId of the user to retrieve.</param> 
        /// <param name="membershipType">A valid non-BungieNet membership type.</param> 
        /// <param name="dayend">Last day to return when daily stats are requested. Use the format YYYY-MM-DD. Currently, we cannot allow more than 31 days of daily data to be requested in a single request.</param> 
        /// <param name="daystart">First day to return when daily stats are requested. Use the format YYYY-MM-DD. Currently, we cannot allow more than 31 days of daily data to be requested in a single request.</param> 
        /// <param name="groups">Group of stats to include, otherwise only general stats are returned. Comma separated list is allowed. Values: General, Weapons, Medals</param> 
        /// <param name="modes">Game modes to return. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited.</param> 
        /// <param name="periodType">Indicates a specific period type to return. Optional. May be: Daily, AllTime, or Activity</param> 
        /// <returns>InlineResponse20052</returns>            
        public InlineResponse20052 Destiny2GetHistoricalStats (long? characterId, long? destinyMembershipId, int? membershipType, DateTime? dayend, DateTime? daystart, List<int?> groups, List<int?> modes, int? periodType)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling Destiny2GetHistoricalStats");
            
            // verify the required parameter 'destinyMembershipId' is set
            if (destinyMembershipId == null) throw new ApiException(400, "Missing required parameter 'destinyMembershipId' when calling Destiny2GetHistoricalStats");
            
            // verify the required parameter 'membershipType' is set
            if (membershipType == null) throw new ApiException(400, "Missing required parameter 'membershipType' when calling Destiny2GetHistoricalStats");
            
    
            var path = "/Destiny2/{membershipType}/Account/{destinyMembershipId}/Character/{characterId}/Stats/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "characterId" + "}", ApiClient.ParameterToString(characterId));
path = path.Replace("{" + "destinyMembershipId" + "}", ApiClient.ParameterToString(destinyMembershipId));
path = path.Replace("{" + "membershipType" + "}", ApiClient.ParameterToString(membershipType));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (dayend != null) queryParams.Add("dayend", ApiClient.ParameterToString(dayend)); // query parameter
 if (daystart != null) queryParams.Add("daystart", ApiClient.ParameterToString(daystart)); // query parameter
 if (groups != null) queryParams.Add("groups", ApiClient.ParameterToString(groups)); // query parameter
 if (modes != null) queryParams.Add("modes", ApiClient.ParameterToString(modes)); // query parameter
 if (periodType != null) queryParams.Add("periodType", ApiClient.ParameterToString(periodType)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2GetHistoricalStats: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2GetHistoricalStats: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20052) ApiClient.Deserialize(response.Content, typeof(InlineResponse20052), response.Headers);
        }
    
        /// <summary>
        ///  Gets historical stats definitions.
        /// </summary>
        /// <returns>InlineResponse20048</returns>            
        public InlineResponse20048 Destiny2GetHistoricalStatsDefinition ()
        {
            
    
            var path = "/Destiny2/Stats/Definition/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2GetHistoricalStatsDefinition: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2GetHistoricalStatsDefinition: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20048) ApiClient.Deserialize(response.Content, typeof(InlineResponse20048), response.Headers);
        }
    
        /// <summary>
        ///  Gets aggregate historical stats organized around each character for a given account.
        /// </summary>
        /// <param name="destinyMembershipId">The Destiny membershipId of the user to retrieve.</param> 
        /// <param name="membershipType">A valid non-BungieNet membership type.</param> 
        /// <param name="groups">Groups of stats to include, otherwise only general stats are returned. Comma separated list is allowed. Values: General, Weapons, Medals.</param> 
        /// <returns>InlineResponse20053</returns>            
        public InlineResponse20053 Destiny2GetHistoricalStatsForAccount (long? destinyMembershipId, int? membershipType, List<int?> groups)
        {
            
            // verify the required parameter 'destinyMembershipId' is set
            if (destinyMembershipId == null) throw new ApiException(400, "Missing required parameter 'destinyMembershipId' when calling Destiny2GetHistoricalStatsForAccount");
            
            // verify the required parameter 'membershipType' is set
            if (membershipType == null) throw new ApiException(400, "Missing required parameter 'membershipType' when calling Destiny2GetHistoricalStatsForAccount");
            
    
            var path = "/Destiny2/{membershipType}/Account/{destinyMembershipId}/Stats/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "destinyMembershipId" + "}", ApiClient.ParameterToString(destinyMembershipId));
path = path.Replace("{" + "membershipType" + "}", ApiClient.ParameterToString(membershipType));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (groups != null) queryParams.Add("groups", ApiClient.ParameterToString(groups)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2GetHistoricalStatsForAccount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2GetHistoricalStatsForAccount: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20053) ApiClient.Deserialize(response.Content, typeof(InlineResponse20053), response.Headers);
        }
    
        /// <summary>
        ///  Retrieve the details of an instanced Destiny Item. An instanced Destiny item is one with an ItemInstanceId. Non-instanced items, such as materials, have no useful instance-specific details and thus are not queryable here.
        /// </summary>
        /// <param name="destinyMembershipId">The membership ID of the destiny profile.</param> 
        /// <param name="itemInstanceId">The Instance ID of the destiny item.</param> 
        /// <param name="membershipType">A valid non-BungieNet membership type.</param> 
        /// <param name="components">A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results.</param> 
        /// <returns>InlineResponse20040</returns>            
        public InlineResponse20040 Destiny2GetItem (long? destinyMembershipId, long? itemInstanceId, int? membershipType, List<int?> components)
        {
            
            // verify the required parameter 'destinyMembershipId' is set
            if (destinyMembershipId == null) throw new ApiException(400, "Missing required parameter 'destinyMembershipId' when calling Destiny2GetItem");
            
            // verify the required parameter 'itemInstanceId' is set
            if (itemInstanceId == null) throw new ApiException(400, "Missing required parameter 'itemInstanceId' when calling Destiny2GetItem");
            
            // verify the required parameter 'membershipType' is set
            if (membershipType == null) throw new ApiException(400, "Missing required parameter 'membershipType' when calling Destiny2GetItem");
            
    
            var path = "/Destiny2/{membershipType}/Profile/{destinyMembershipId}/Item/{itemInstanceId}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "destinyMembershipId" + "}", ApiClient.ParameterToString(destinyMembershipId));
path = path.Replace("{" + "itemInstanceId" + "}", ApiClient.ParameterToString(itemInstanceId));
path = path.Replace("{" + "membershipType" + "}", ApiClient.ParameterToString(membershipType));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2GetItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2GetItem: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20040) ApiClient.Deserialize(response.Content, typeof(InlineResponse20040), response.Headers);
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
        ///  Returns a summary information about all profiles linked to the requesting membership type/membership ID that have valid Destiny information. The passed-in Membership Type/Membership ID may be a Bungie.Net membership or a Destiny membership. It only returns the minimal amount of data to begin making more substantive requests, but will hopefully serve as a useful alternative to UserServices for people who just care about Destiny data. Note that it will only return linked accounts whose linkages you are allowed to view.
        /// </summary>
        /// <param name="membershipId">The ID of the membership whose linked Destiny accounts you want returned. Make sure your membership ID matches its Membership Type: don&#39;t pass us a PSN membership ID and the XBox membership type, it&#39;s not going to work!</param> 
        /// <param name="membershipType">The type for the membership whose linked Destiny accounts you want returned.</param> 
        /// <param name="getAllMemberships">(optional) if set to &#39;true&#39;, all memberships regardless of whether they&#39;re obscured by overrides will be returned. Normal privacy restrictions on account linking will still apply no matter what.</param> 
        /// <returns>InlineResponse20036</returns>            
        public InlineResponse20036 Destiny2GetLinkedProfiles (long? membershipId, int? membershipType, bool? getAllMemberships)
        {
            
            // verify the required parameter 'membershipId' is set
            if (membershipId == null) throw new ApiException(400, "Missing required parameter 'membershipId' when calling Destiny2GetLinkedProfiles");
            
            // verify the required parameter 'membershipType' is set
            if (membershipType == null) throw new ApiException(400, "Missing required parameter 'membershipType' when calling Destiny2GetLinkedProfiles");
            
    
            var path = "/Destiny2/{membershipType}/Profile/{membershipId}/LinkedProfiles/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "membershipId" + "}", ApiClient.ParameterToString(membershipId));
path = path.Replace("{" + "membershipType" + "}", ApiClient.ParameterToString(membershipType));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (getAllMemberships != null) queryParams.Add("getAllMemberships", ApiClient.ParameterToString(getAllMemberships)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2GetLinkedProfiles: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2GetLinkedProfiles: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20036) ApiClient.Deserialize(response.Content, typeof(InlineResponse20036), response.Headers);
        }
    
        /// <summary>
        ///  Gets the available post game carnage report for the activity ID.
        /// </summary>
        /// <param name="activityId">The ID of the activity whose PGCR is requested.</param> 
        /// <returns>InlineResponse20047</returns>            
        public InlineResponse20047 Destiny2GetPostGameCarnageReport (long? activityId)
        {
            
            // verify the required parameter 'activityId' is set
            if (activityId == null) throw new ApiException(400, "Missing required parameter 'activityId' when calling Destiny2GetPostGameCarnageReport");
            
    
            var path = "/Destiny2/Stats/PostGameCarnageReport/{activityId}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "activityId" + "}", ApiClient.ParameterToString(activityId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2GetPostGameCarnageReport: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2GetPostGameCarnageReport: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20047) ApiClient.Deserialize(response.Content, typeof(InlineResponse20047), response.Headers);
        }
    
        /// <summary>
        ///  Returns Destiny Profile information for the supplied membership.
        /// </summary>
        /// <param name="destinyMembershipId">Destiny membership ID.</param> 
        /// <param name="membershipType">A valid non-BungieNet membership type.</param> 
        /// <param name="components">A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results.</param> 
        /// <returns>InlineResponse20037</returns>            
        public InlineResponse20037 Destiny2GetProfile (long? destinyMembershipId, int? membershipType, List<int?> components)
        {
            
            // verify the required parameter 'destinyMembershipId' is set
            if (destinyMembershipId == null) throw new ApiException(400, "Missing required parameter 'destinyMembershipId' when calling Destiny2GetProfile");
            
            // verify the required parameter 'membershipType' is set
            if (membershipType == null) throw new ApiException(400, "Missing required parameter 'membershipType' when calling Destiny2GetProfile");
            
    
            var path = "/Destiny2/{membershipType}/Profile/{destinyMembershipId}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "destinyMembershipId" + "}", ApiClient.ParameterToString(destinyMembershipId));
path = path.Replace("{" + "membershipType" + "}", ApiClient.ParameterToString(membershipType));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2GetProfile: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2GetProfile: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20037) ApiClient.Deserialize(response.Content, typeof(InlineResponse20037), response.Headers);
        }
    
        /// <summary>
        ///  Gets custom localized content for the milestone of the given hash, if it exists.
        /// </summary>
        /// <param name="milestoneHash">The identifier for the milestone to be returned.</param> 
        /// <returns>InlineResponse20057</returns>            
        public InlineResponse20057 Destiny2GetPublicMilestoneContent (int? milestoneHash)
        {
            
            // verify the required parameter 'milestoneHash' is set
            if (milestoneHash == null) throw new ApiException(400, "Missing required parameter 'milestoneHash' when calling Destiny2GetPublicMilestoneContent");
            
    
            var path = "/Destiny2/Milestones/{milestoneHash}/Content/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "milestoneHash" + "}", ApiClient.ParameterToString(milestoneHash));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2GetPublicMilestoneContent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2GetPublicMilestoneContent: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20057) ApiClient.Deserialize(response.Content, typeof(InlineResponse20057), response.Headers);
        }
    
        /// <summary>
        ///  Gets public information about currently available Milestones.
        /// </summary>
        /// <returns>InlineResponse20058</returns>            
        public InlineResponse20058 Destiny2GetPublicMilestones ()
        {
            
    
            var path = "/Destiny2/Milestones/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2GetPublicMilestones: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2GetPublicMilestones: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20058) ApiClient.Deserialize(response.Content, typeof(InlineResponse20058), response.Headers);
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
        ///  Gets details about unique weapon usage, including all exotic weapons.
        /// </summary>
        /// <param name="characterId">The id of the character to retrieve.</param> 
        /// <param name="destinyMembershipId">The Destiny membershipId of the user to retrieve.</param> 
        /// <param name="membershipType">A valid non-BungieNet membership type.</param> 
        /// <returns>InlineResponse20055</returns>            
        public InlineResponse20055 Destiny2GetUniqueWeaponHistory (long? characterId, long? destinyMembershipId, int? membershipType)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling Destiny2GetUniqueWeaponHistory");
            
            // verify the required parameter 'destinyMembershipId' is set
            if (destinyMembershipId == null) throw new ApiException(400, "Missing required parameter 'destinyMembershipId' when calling Destiny2GetUniqueWeaponHistory");
            
            // verify the required parameter 'membershipType' is set
            if (membershipType == null) throw new ApiException(400, "Missing required parameter 'membershipType' when calling Destiny2GetUniqueWeaponHistory");
            
    
            var path = "/Destiny2/{membershipType}/Account/{destinyMembershipId}/Character/{characterId}/Stats/UniqueWeapons/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "characterId" + "}", ApiClient.ParameterToString(characterId));
path = path.Replace("{" + "destinyMembershipId" + "}", ApiClient.ParameterToString(destinyMembershipId));
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
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2GetUniqueWeaponHistory: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2GetUniqueWeaponHistory: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20055) ApiClient.Deserialize(response.Content, typeof(InlineResponse20055), response.Headers);
        }
    
        /// <summary>
        ///  Get the details of a specific Vendor.
        /// </summary>
        /// <param name="characterId">The Destiny Character ID of the character for whom we&#39;re getting vendor info.</param> 
        /// <param name="destinyMembershipId">Destiny membership ID of another user. You may be denied.</param> 
        /// <param name="membershipType">A valid non-BungieNet membership type.</param> 
        /// <param name="vendorHash">The Hash identifier of the Vendor to be returned.</param> 
        /// <param name="components">A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results.</param> 
        /// <returns>InlineResponse20042</returns>            
        public InlineResponse20042 Destiny2GetVendor (long? characterId, long? destinyMembershipId, int? membershipType, int? vendorHash, List<int?> components)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling Destiny2GetVendor");
            
            // verify the required parameter 'destinyMembershipId' is set
            if (destinyMembershipId == null) throw new ApiException(400, "Missing required parameter 'destinyMembershipId' when calling Destiny2GetVendor");
            
            // verify the required parameter 'membershipType' is set
            if (membershipType == null) throw new ApiException(400, "Missing required parameter 'membershipType' when calling Destiny2GetVendor");
            
            // verify the required parameter 'vendorHash' is set
            if (vendorHash == null) throw new ApiException(400, "Missing required parameter 'vendorHash' when calling Destiny2GetVendor");
            
    
            var path = "/Destiny2/{membershipType}/Profile/{destinyMembershipId}/Character/{characterId}/Vendors/{vendorHash}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "characterId" + "}", ApiClient.ParameterToString(characterId));
path = path.Replace("{" + "destinyMembershipId" + "}", ApiClient.ParameterToString(destinyMembershipId));
path = path.Replace("{" + "membershipType" + "}", ApiClient.ParameterToString(membershipType));
path = path.Replace("{" + "vendorHash" + "}", ApiClient.ParameterToString(vendorHash));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2GetVendor: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2GetVendor: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20042) ApiClient.Deserialize(response.Content, typeof(InlineResponse20042), response.Headers);
        }
    
        /// <summary>
        ///  Get currently available vendors from the list of vendors that can possibly have rotating inventory. Note that this does not include things like preview vendors and vendors-as-kiosks, neither of whom have rotating/dynamic inventories. Use their definitions as-is for those.
        /// </summary>
        /// <param name="characterId">The Destiny Character ID of the character for whom we&#39;re getting vendor info.</param> 
        /// <param name="destinyMembershipId">Destiny membership ID of another user. You may be denied.</param> 
        /// <param name="membershipType">A valid non-BungieNet membership type.</param> 
        /// <param name="components">A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results.</param> 
        /// <returns>InlineResponse20041</returns>            
        public InlineResponse20041 Destiny2GetVendors (long? characterId, long? destinyMembershipId, int? membershipType, List<int?> components)
        {
            
            // verify the required parameter 'characterId' is set
            if (characterId == null) throw new ApiException(400, "Missing required parameter 'characterId' when calling Destiny2GetVendors");
            
            // verify the required parameter 'destinyMembershipId' is set
            if (destinyMembershipId == null) throw new ApiException(400, "Missing required parameter 'destinyMembershipId' when calling Destiny2GetVendors");
            
            // verify the required parameter 'membershipType' is set
            if (membershipType == null) throw new ApiException(400, "Missing required parameter 'membershipType' when calling Destiny2GetVendors");
            
    
            var path = "/Destiny2/{membershipType}/Profile/{destinyMembershipId}/Character/{characterId}/Vendors/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "characterId" + "}", ApiClient.ParameterToString(characterId));
path = path.Replace("{" + "destinyMembershipId" + "}", ApiClient.ParameterToString(destinyMembershipId));
path = path.Replace("{" + "membershipType" + "}", ApiClient.ParameterToString(membershipType));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2GetVendors: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2GetVendors: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20041) ApiClient.Deserialize(response.Content, typeof(InlineResponse20041), response.Headers);
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
    
        /// <summary>
        ///  Extract an item from the Postmaster, with whatever implications that may entail. You must have a valid Destiny account. You must also pass BOTH a reference AND an instance ID if it&#39;s an instanced item.
        /// </summary>
        /// <returns>InlineResponse20022</returns>            
        public InlineResponse20022 Destiny2PullFromPostmaster ()
        {
            
    
            var path = "/Destiny2/Actions/Items/PullFromPostmaster/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2PullFromPostmaster: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2PullFromPostmaster: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20022) ApiClient.Deserialize(response.Content, typeof(InlineResponse20022), response.Headers);
        }
    
        /// <summary>
        ///  Report a player that you met in an activity that was engaging in ToS-violating activities. Both you and the offending player must have played in the activityId passed in. Please use this judiciously and only when you have strong suspicions of violation, pretty please.
        /// </summary>
        /// <param name="activityId">The ID of the activity where you ran into the brigand that you&#39;re reporting.</param> 
        /// <returns>InlineResponse20022</returns>            
        public InlineResponse20022 Destiny2ReportOffensivePostGameCarnageReportPlayer (long? activityId)
        {
            
            // verify the required parameter 'activityId' is set
            if (activityId == null) throw new ApiException(400, "Missing required parameter 'activityId' when calling Destiny2ReportOffensivePostGameCarnageReportPlayer");
            
    
            var path = "/Destiny2/Stats/PostGameCarnageReport/{activityId}/Report/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "activityId" + "}", ApiClient.ParameterToString(activityId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2ReportOffensivePostGameCarnageReportPlayer: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2ReportOffensivePostGameCarnageReportPlayer: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20022) ApiClient.Deserialize(response.Content, typeof(InlineResponse20022), response.Headers);
        }
    
        /// <summary>
        ///  Gets a page list of Destiny items.
        /// </summary>
        /// <param name="searchTerm">The string to use when searching for Destiny entities.</param> 
        /// <param name="type">The type of entity for whom you would like results. These correspond to the entity&#39;s definition contract name. For instance, if you are looking for items, this property should be &#39;DestinyInventoryItemDefinition&#39;.</param> 
        /// <param name="page">Page number to return, starting with 0.</param> 
        /// <returns>InlineResponse20051</returns>            
        public InlineResponse20051 Destiny2SearchDestinyEntities (string searchTerm, string type, int? page)
        {
            
            // verify the required parameter 'searchTerm' is set
            if (searchTerm == null) throw new ApiException(400, "Missing required parameter 'searchTerm' when calling Destiny2SearchDestinyEntities");
            
            // verify the required parameter 'type' is set
            if (type == null) throw new ApiException(400, "Missing required parameter 'type' when calling Destiny2SearchDestinyEntities");
            
    
            var path = "/Destiny2/Armory/Search/{type}/{searchTerm}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "searchTerm" + "}", ApiClient.ParameterToString(searchTerm));
path = path.Replace("{" + "type" + "}", ApiClient.ParameterToString(type));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2SearchDestinyEntities: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2SearchDestinyEntities: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20051) ApiClient.Deserialize(response.Content, typeof(InlineResponse20051), response.Headers);
        }
    
        /// <summary>
        ///  Returns a list of Destiny memberships given a full Gamertag or PSN ID. Unless you pass returnOriginalProfile&#x3D;true, this will return membership information for the users&#39; Primary Cross Save Profile if they are engaged in cross save rather than any original Destiny profile that is now being overridden.
        /// </summary>
        /// <param name="displayName">The full gamertag or PSN id of the player. Spaces and case are ignored.</param> 
        /// <param name="membershipType">A valid non-BungieNet membership type, or All.</param> 
        /// <param name="returnOriginalProfile">(optional) If passed in and set to true, we will return the original Destiny Profile(s) linked to that gamertag, and not their currently active Destiny Profile.</param> 
        /// <returns>InlineResponse20035</returns>            
        public InlineResponse20035 Destiny2SearchDestinyPlayer (string displayName, int? membershipType, bool? returnOriginalProfile)
        {
            
            // verify the required parameter 'displayName' is set
            if (displayName == null) throw new ApiException(400, "Missing required parameter 'displayName' when calling Destiny2SearchDestinyPlayer");
            
            // verify the required parameter 'membershipType' is set
            if (membershipType == null) throw new ApiException(400, "Missing required parameter 'membershipType' when calling Destiny2SearchDestinyPlayer");
            
    
            var path = "/Destiny2/SearchDestinyPlayer/{membershipType}/{displayName}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "displayName" + "}", ApiClient.ParameterToString(displayName));
path = path.Replace("{" + "membershipType" + "}", ApiClient.ParameterToString(membershipType));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (returnOriginalProfile != null) queryParams.Add("returnOriginalProfile", ApiClient.ParameterToString(returnOriginalProfile)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2SearchDestinyPlayer: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2SearchDestinyPlayer: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20035) ApiClient.Deserialize(response.Content, typeof(InlineResponse20035), response.Headers);
        }
    
        /// <summary>
        ///  Set the Lock State for an instanced item. You must have a valid Destiny Account.
        /// </summary>
        /// <returns>InlineResponse20022</returns>            
        public InlineResponse20022 Destiny2SetItemLockState ()
        {
            
    
            var path = "/Destiny2/Actions/Items/SetLockState/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2SetItemLockState: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2SetItemLockState: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20022) ApiClient.Deserialize(response.Content, typeof(InlineResponse20022), response.Headers);
        }
    
        /// <summary>
        ///  Transfer an item to/from your vault. You must have a valid Destiny account. You must also pass BOTH a reference AND an instance ID if it&#39;s an instanced item. itshappening.gif
        /// </summary>
        /// <returns>InlineResponse20022</returns>            
        public InlineResponse20022 Destiny2TransferItem ()
        {
            
    
            var path = "/Destiny2/Actions/Items/TransferItem/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2TransferItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Destiny2TransferItem: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20022) ApiClient.Deserialize(response.Content, typeof(InlineResponse20022), response.Headers);
        }
    
    }
}
