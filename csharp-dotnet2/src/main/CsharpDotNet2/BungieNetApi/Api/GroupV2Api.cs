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
    public interface IGroupV2Api
    {
        /// <summary>
        ///  An administrative method to allow the founder of a group or clan to give up their position to another admin permanently.
        /// </summary>
        /// <param name="founderIdNew">The new founder for this group. Must already be a group admin.</param>
        /// <param name="groupId">The target group id.</param>
        /// <param name="membershipType">Membership type of the provided founderIdNew.</param>
        /// <returns>InlineResponse20017</returns>
        InlineResponse20017 GroupV2AbdicateFoundership (long? founderIdNew, long? groupId, int? membershipType);
        /// <summary>
        ///  Add a new optional conversation/chat channel. Requires admin permissions to the group.
        /// </summary>
        /// <param name="groupId">Group ID of the group to edit.</param>
        /// <returns>InlineResponse20012</returns>
        InlineResponse20012 GroupV2AddOptionalConversation (long? groupId);
        /// <summary>
        ///  Approve all of the pending users for the given group.
        /// </summary>
        /// <param name="groupId">ID of the group.</param>
        /// <returns>InlineResponse20027</returns>
        InlineResponse20027 GroupV2ApproveAllPending (long? groupId);
        /// <summary>
        ///  Approve the given membershipId to join the group/clan as long as they have applied.
        /// </summary>
        /// <param name="groupId">ID of the group.</param>
        /// <param name="membershipId">The membership id being approved.</param>
        /// <param name="membershipType">Membership type of the supplied membership ID.</param>
        /// <returns>InlineResponse20017</returns>
        InlineResponse20017 GroupV2ApprovePending (long? groupId, long? membershipId, int? membershipType);
        /// <summary>
        ///  Approve all of the pending users for the given group.
        /// </summary>
        /// <param name="groupId">ID of the group.</param>
        /// <returns>InlineResponse20027</returns>
        InlineResponse20027 GroupV2ApprovePendingForList (long? groupId);
        /// <summary>
        ///  Bans the requested member from the requested group for the specified period of time.
        /// </summary>
        /// <param name="groupId">Group ID that has the member to ban.</param>
        /// <param name="membershipId">Membership ID of the member to ban from the group.</param>
        /// <param name="membershipType">Membership type of the provided membership ID.</param>
        /// <returns>InlineResponse20022</returns>
        InlineResponse20022 GroupV2BanMember (long? groupId, long? membershipId, int? membershipType);
        /// <summary>
        ///  Deny all of the pending users for the given group.
        /// </summary>
        /// <param name="groupId">ID of the group.</param>
        /// <returns>InlineResponse20027</returns>
        InlineResponse20027 GroupV2DenyAllPending (long? groupId);
        /// <summary>
        ///  Deny all of the pending users for the given group that match the passed-in .
        /// </summary>
        /// <param name="groupId">ID of the group.</param>
        /// <returns>InlineResponse20027</returns>
        InlineResponse20027 GroupV2DenyPendingForList (long? groupId);
        /// <summary>
        ///  Edit an existing group&#39;s clan banner. You must have suitable permissions in the group to perform this operation. All fields are required.
        /// </summary>
        /// <param name="groupId">Group ID of the group to edit.</param>
        /// <returns>InlineResponse20022</returns>
        InlineResponse20022 GroupV2EditClanBanner (long? groupId);
        /// <summary>
        ///  Edit group options only available to a founder. You must have suitable permissions in the group to perform this operation.
        /// </summary>
        /// <param name="groupId">Group ID of the group to edit.</param>
        /// <returns>InlineResponse20022</returns>
        InlineResponse20022 GroupV2EditFounderOptions (long? groupId);
        /// <summary>
        ///  Edit an existing group. You must have suitable permissions in the group to perform this operation. This latest revision will only edit the fields you pass in - pass null for properties you want to leave unaltered.
        /// </summary>
        /// <param name="groupId">Group ID of the group to edit.</param>
        /// <returns>InlineResponse20022</returns>
        InlineResponse20022 GroupV2EditGroup (long? groupId);
        /// <summary>
        ///  Edit the membership type of a given member. You must have suitable permissions in the group to perform this operation.
        /// </summary>
        /// <param name="groupId">ID of the group to which the member belongs.</param>
        /// <param name="membershipId">Membership ID to modify.</param>
        /// <param name="membershipType">Membership type of the provide membership ID.</param>
        /// <param name="memberType">New membertype for the specified member.</param>
        /// <returns>InlineResponse20022</returns>
        InlineResponse20022 GroupV2EditGroupMembership (long? groupId, long? membershipId, int? membershipType, int? memberType);
        /// <summary>
        ///  Edit the settings of an optional conversation/chat channel. Requires admin permissions to the group.
        /// </summary>
        /// <param name="conversationId">Conversation Id of the channel being edited.</param>
        /// <param name="groupId">Group ID of the group to edit.</param>
        /// <returns>InlineResponse20012</returns>
        InlineResponse20012 GroupV2EditOptionalConversation (long? conversationId, long? groupId);
        /// <summary>
        ///  Get the list of members in a given group who are of admin level or higher.
        /// </summary>
        /// <param name="currentpage">Page number (starting with 1). Each page has a fixed size of 50 items per page.</param>
        /// <param name="groupId">The ID of the group.</param>
        /// <returns>InlineResponse20023</returns>
        InlineResponse20023 GroupV2GetAdminsAndFounderOfGroup (int? currentpage, long? groupId);
        /// <summary>
        ///  Returns a list of all available group avatars for the signed-in user.
        /// </summary>
        /// <returns>InlineResponse20015</returns>
        InlineResponse20015 GroupV2GetAvailableAvatars ();
        /// <summary>
        ///  Returns a list of all available group themes.
        /// </summary>
        /// <returns>InlineResponse20016</returns>
        InlineResponse20016 GroupV2GetAvailableThemes ();
        /// <summary>
        ///  Get the list of banned members in a given group. Only accessible to group Admins and above. Not applicable to all groups. Check group features.
        /// </summary>
        /// <param name="currentpage">Page number (starting with 1). Each page has a fixed size of 50 entries.</param>
        /// <param name="groupId">Group ID whose banned members you are fetching</param>
        /// <returns>InlineResponse20025</returns>
        InlineResponse20025 GroupV2GetBannedMembersOfGroup (int? currentpage, long? groupId);
        /// <summary>
        ///  Get information about a specific group of the given ID.
        /// </summary>
        /// <param name="groupId">Requested group&#39;s id.</param>
        /// <returns>InlineResponse20020</returns>
        InlineResponse20020 GroupV2GetGroup (long? groupId);
        /// <summary>
        ///  Get information about a specific group with the given name and type.
        /// </summary>
        /// <param name="groupName">Exact name of the group to find.</param>
        /// <param name="groupType">Type of group to find.</param>
        /// <returns>InlineResponse20020</returns>
        InlineResponse20020 GroupV2GetGroupByName (string groupName, int? groupType);
        /// <summary>
        ///  Get information about a specific group with the given name and type. The POST version.
        /// </summary>
        /// <returns>InlineResponse20020</returns>
        InlineResponse20020 GroupV2GetGroupByNameV2 ();
        /// <summary>
        ///  Gets a list of available optional conversation channels and their settings.
        /// </summary>
        /// <param name="groupId">Requested group&#39;s id.</param>
        /// <returns>InlineResponse20021</returns>
        InlineResponse20021 GroupV2GetGroupOptionalConversations (long? groupId);
        /// <summary>
        ///  Get information about the groups that a given member has joined.
        /// </summary>
        /// <param name="filter">Filter apply to list of joined groups.</param>
        /// <param name="groupType">Type of group the supplied member founded.</param>
        /// <param name="membershipId">Membership ID to for which to find founded groups.</param>
        /// <param name="membershipType">Membership type of the supplied membership ID.</param>
        /// <returns>InlineResponse20028</returns>
        InlineResponse20028 GroupV2GetGroupsForMember (int? filter, int? groupType, long? membershipId, int? membershipType);
        /// <summary>
        ///  Get the list of users who have been invited into the group.
        /// </summary>
        /// <param name="currentpage">Page number (starting with 1). Each page has a fixed size of 50 items per page.</param>
        /// <param name="groupId">ID of the group.</param>
        /// <returns>InlineResponse20026</returns>
        InlineResponse20026 GroupV2GetInvitedIndividuals (int? currentpage, long? groupId);
        /// <summary>
        ///  Get the list of members in a given group.
        /// </summary>
        /// <param name="currentpage">Page number (starting with 1). Each page has a fixed size of 50 items per page.</param>
        /// <param name="groupId">The ID of the group.</param>
        /// <param name="memberType">Filter out other member types. Use None for all members.</param>
        /// <param name="nameSearch">The name fragment upon which a search should be executed for members with matching display or unique names.</param>
        /// <returns>InlineResponse20023</returns>
        InlineResponse20023 GroupV2GetMembersOfGroup (int? currentpage, long? groupId, int? memberType, string nameSearch);
        /// <summary>
        ///  Get the list of users who are awaiting a decision on their application to join a given group. Modified to include application info.
        /// </summary>
        /// <param name="currentpage">Page number (starting with 1). Each page has a fixed size of 50 items per page.</param>
        /// <param name="groupId">ID of the group.</param>
        /// <returns>InlineResponse20026</returns>
        InlineResponse20026 GroupV2GetPendingMemberships (int? currentpage, long? groupId);
        /// <summary>
        ///  Get information about the groups that a given member has applied to or been invited to.
        /// </summary>
        /// <param name="filter">Filter apply to list of potential joined groups.</param>
        /// <param name="groupType">Type of group the supplied member applied.</param>
        /// <param name="membershipId">Membership ID to for which to find applied groups.</param>
        /// <param name="membershipType">Membership type of the supplied membership ID.</param>
        /// <returns>InlineResponse20030</returns>
        InlineResponse20030 GroupV2GetPotentialGroupsForMember (int? filter, int? groupType, long? membershipId, int? membershipType);
        /// <summary>
        ///  Gets groups recommended for you based on the groups to whom those you follow belong.
        /// </summary>
        /// <param name="createDateRange">Requested range in which to pull recommended groups</param>
        /// <param name="groupType">Type of groups requested</param>
        /// <returns>InlineResponse20018</returns>
        InlineResponse20018 GroupV2GetRecommendedGroups (int? createDateRange, int? groupType);
        /// <summary>
        ///  Gets the state of the user&#39;s clan invite preferences for a particular membership type - true if they wish to be invited to clans, false otherwise.
        /// </summary>
        /// <param name="mType">The Destiny membership type of the account we wish to access settings.</param>
        /// <returns>InlineResponse20017</returns>
        InlineResponse20017 GroupV2GetUserClanInviteSetting (int? mType);
        /// <summary>
        ///  Search for Groups.
        /// </summary>
        /// <returns>InlineResponse20019</returns>
        InlineResponse20019 GroupV2GroupSearch ();
        /// <summary>
        ///  Invite a user to join this group.
        /// </summary>
        /// <param name="groupId">ID of the group you would like to join.</param>
        /// <param name="membershipId">Membership id of the account being invited.</param>
        /// <param name="membershipType">MembershipType of the account being invited.</param>
        /// <returns>InlineResponse20031</returns>
        InlineResponse20031 GroupV2IndividualGroupInvite (long? groupId, long? membershipId, int? membershipType);
        /// <summary>
        ///  Cancels a pending invitation to join a group.
        /// </summary>
        /// <param name="groupId">ID of the group you would like to join.</param>
        /// <param name="membershipId">Membership id of the account being cancelled.</param>
        /// <param name="membershipType">MembershipType of the account being cancelled.</param>
        /// <returns>InlineResponse20031</returns>
        InlineResponse20031 GroupV2IndividualGroupInviteCancel (long? groupId, long? membershipId, int? membershipType);
        /// <summary>
        ///  Kick a member from the given group, forcing them to reapply if they wish to re-join the group. You must have suitable permissions in the group to perform this operation.
        /// </summary>
        /// <param name="groupId">Group ID to kick the user from.</param>
        /// <param name="membershipId">Membership ID to kick.</param>
        /// <param name="membershipType">Membership type of the provided membership ID.</param>
        /// <returns>InlineResponse20024</returns>
        InlineResponse20024 GroupV2KickMember (long? groupId, long? membershipId, int? membershipType);
        /// <summary>
        ///  Allows a founder to manually recover a group they can see in game but not on bungie.net
        /// </summary>
        /// <param name="groupType">Type of group the supplied member founded.</param>
        /// <param name="membershipId">Membership ID to for which to find founded groups.</param>
        /// <param name="membershipType">Membership type of the supplied membership ID.</param>
        /// <returns>InlineResponse20029</returns>
        InlineResponse20029 GroupV2RecoverGroupForFounder (int? groupType, long? membershipId, int? membershipType);
        /// <summary>
        ///  Unbans the requested member, allowing them to re-apply for membership.
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="membershipId">Membership ID of the member to unban from the group</param>
        /// <param name="membershipType">Membership type of the provided membership ID.</param>
        /// <returns>InlineResponse20022</returns>
        InlineResponse20022 GroupV2UnbanMember (long? groupId, long? membershipId, int? membershipType);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GroupV2Api : IGroupV2Api
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupV2Api"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public GroupV2Api(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupV2Api"/> class.
        /// </summary>
        /// <returns></returns>
        public GroupV2Api(String basePath)
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
        ///  An administrative method to allow the founder of a group or clan to give up their position to another admin permanently.
        /// </summary>
        /// <param name="founderIdNew">The new founder for this group. Must already be a group admin.</param> 
        /// <param name="groupId">The target group id.</param> 
        /// <param name="membershipType">Membership type of the provided founderIdNew.</param> 
        /// <returns>InlineResponse20017</returns>            
        public InlineResponse20017 GroupV2AbdicateFoundership (long? founderIdNew, long? groupId, int? membershipType)
        {
            
            // verify the required parameter 'founderIdNew' is set
            if (founderIdNew == null) throw new ApiException(400, "Missing required parameter 'founderIdNew' when calling GroupV2AbdicateFoundership");
            
            // verify the required parameter 'groupId' is set
            if (groupId == null) throw new ApiException(400, "Missing required parameter 'groupId' when calling GroupV2AbdicateFoundership");
            
            // verify the required parameter 'membershipType' is set
            if (membershipType == null) throw new ApiException(400, "Missing required parameter 'membershipType' when calling GroupV2AbdicateFoundership");
            
    
            var path = "/GroupV2/{groupId}/Admin/AbdicateFoundership/{membershipType}/{founderIdNew}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "founderIdNew" + "}", ApiClient.ParameterToString(founderIdNew));
path = path.Replace("{" + "groupId" + "}", ApiClient.ParameterToString(groupId));
path = path.Replace("{" + "membershipType" + "}", ApiClient.ParameterToString(membershipType));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2AbdicateFoundership: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2AbdicateFoundership: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20017) ApiClient.Deserialize(response.Content, typeof(InlineResponse20017), response.Headers);
        }
    
        /// <summary>
        ///  Add a new optional conversation/chat channel. Requires admin permissions to the group.
        /// </summary>
        /// <param name="groupId">Group ID of the group to edit.</param> 
        /// <returns>InlineResponse20012</returns>            
        public InlineResponse20012 GroupV2AddOptionalConversation (long? groupId)
        {
            
            // verify the required parameter 'groupId' is set
            if (groupId == null) throw new ApiException(400, "Missing required parameter 'groupId' when calling GroupV2AddOptionalConversation");
            
    
            var path = "/GroupV2/{groupId}/OptionalConversations/Add/";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2AddOptionalConversation: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2AddOptionalConversation: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20012) ApiClient.Deserialize(response.Content, typeof(InlineResponse20012), response.Headers);
        }
    
        /// <summary>
        ///  Approve all of the pending users for the given group.
        /// </summary>
        /// <param name="groupId">ID of the group.</param> 
        /// <returns>InlineResponse20027</returns>            
        public InlineResponse20027 GroupV2ApproveAllPending (long? groupId)
        {
            
            // verify the required parameter 'groupId' is set
            if (groupId == null) throw new ApiException(400, "Missing required parameter 'groupId' when calling GroupV2ApproveAllPending");
            
    
            var path = "/GroupV2/{groupId}/Members/ApproveAll/";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2ApproveAllPending: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2ApproveAllPending: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20027) ApiClient.Deserialize(response.Content, typeof(InlineResponse20027), response.Headers);
        }
    
        /// <summary>
        ///  Approve the given membershipId to join the group/clan as long as they have applied.
        /// </summary>
        /// <param name="groupId">ID of the group.</param> 
        /// <param name="membershipId">The membership id being approved.</param> 
        /// <param name="membershipType">Membership type of the supplied membership ID.</param> 
        /// <returns>InlineResponse20017</returns>            
        public InlineResponse20017 GroupV2ApprovePending (long? groupId, long? membershipId, int? membershipType)
        {
            
            // verify the required parameter 'groupId' is set
            if (groupId == null) throw new ApiException(400, "Missing required parameter 'groupId' when calling GroupV2ApprovePending");
            
            // verify the required parameter 'membershipId' is set
            if (membershipId == null) throw new ApiException(400, "Missing required parameter 'membershipId' when calling GroupV2ApprovePending");
            
            // verify the required parameter 'membershipType' is set
            if (membershipType == null) throw new ApiException(400, "Missing required parameter 'membershipType' when calling GroupV2ApprovePending");
            
    
            var path = "/GroupV2/{groupId}/Members/Approve/{membershipType}/{membershipId}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "groupId" + "}", ApiClient.ParameterToString(groupId));
path = path.Replace("{" + "membershipId" + "}", ApiClient.ParameterToString(membershipId));
path = path.Replace("{" + "membershipType" + "}", ApiClient.ParameterToString(membershipType));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2ApprovePending: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2ApprovePending: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20017) ApiClient.Deserialize(response.Content, typeof(InlineResponse20017), response.Headers);
        }
    
        /// <summary>
        ///  Approve all of the pending users for the given group.
        /// </summary>
        /// <param name="groupId">ID of the group.</param> 
        /// <returns>InlineResponse20027</returns>            
        public InlineResponse20027 GroupV2ApprovePendingForList (long? groupId)
        {
            
            // verify the required parameter 'groupId' is set
            if (groupId == null) throw new ApiException(400, "Missing required parameter 'groupId' when calling GroupV2ApprovePendingForList");
            
    
            var path = "/GroupV2/{groupId}/Members/ApproveList/";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2ApprovePendingForList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2ApprovePendingForList: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20027) ApiClient.Deserialize(response.Content, typeof(InlineResponse20027), response.Headers);
        }
    
        /// <summary>
        ///  Bans the requested member from the requested group for the specified period of time.
        /// </summary>
        /// <param name="groupId">Group ID that has the member to ban.</param> 
        /// <param name="membershipId">Membership ID of the member to ban from the group.</param> 
        /// <param name="membershipType">Membership type of the provided membership ID.</param> 
        /// <returns>InlineResponse20022</returns>            
        public InlineResponse20022 GroupV2BanMember (long? groupId, long? membershipId, int? membershipType)
        {
            
            // verify the required parameter 'groupId' is set
            if (groupId == null) throw new ApiException(400, "Missing required parameter 'groupId' when calling GroupV2BanMember");
            
            // verify the required parameter 'membershipId' is set
            if (membershipId == null) throw new ApiException(400, "Missing required parameter 'membershipId' when calling GroupV2BanMember");
            
            // verify the required parameter 'membershipType' is set
            if (membershipType == null) throw new ApiException(400, "Missing required parameter 'membershipType' when calling GroupV2BanMember");
            
    
            var path = "/GroupV2/{groupId}/Members/{membershipType}/{membershipId}/Ban/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "groupId" + "}", ApiClient.ParameterToString(groupId));
path = path.Replace("{" + "membershipId" + "}", ApiClient.ParameterToString(membershipId));
path = path.Replace("{" + "membershipType" + "}", ApiClient.ParameterToString(membershipType));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2BanMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2BanMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20022) ApiClient.Deserialize(response.Content, typeof(InlineResponse20022), response.Headers);
        }
    
        /// <summary>
        ///  Deny all of the pending users for the given group.
        /// </summary>
        /// <param name="groupId">ID of the group.</param> 
        /// <returns>InlineResponse20027</returns>            
        public InlineResponse20027 GroupV2DenyAllPending (long? groupId)
        {
            
            // verify the required parameter 'groupId' is set
            if (groupId == null) throw new ApiException(400, "Missing required parameter 'groupId' when calling GroupV2DenyAllPending");
            
    
            var path = "/GroupV2/{groupId}/Members/DenyAll/";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2DenyAllPending: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2DenyAllPending: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20027) ApiClient.Deserialize(response.Content, typeof(InlineResponse20027), response.Headers);
        }
    
        /// <summary>
        ///  Deny all of the pending users for the given group that match the passed-in .
        /// </summary>
        /// <param name="groupId">ID of the group.</param> 
        /// <returns>InlineResponse20027</returns>            
        public InlineResponse20027 GroupV2DenyPendingForList (long? groupId)
        {
            
            // verify the required parameter 'groupId' is set
            if (groupId == null) throw new ApiException(400, "Missing required parameter 'groupId' when calling GroupV2DenyPendingForList");
            
    
            var path = "/GroupV2/{groupId}/Members/DenyList/";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2DenyPendingForList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2DenyPendingForList: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20027) ApiClient.Deserialize(response.Content, typeof(InlineResponse20027), response.Headers);
        }
    
        /// <summary>
        ///  Edit an existing group&#39;s clan banner. You must have suitable permissions in the group to perform this operation. All fields are required.
        /// </summary>
        /// <param name="groupId">Group ID of the group to edit.</param> 
        /// <returns>InlineResponse20022</returns>            
        public InlineResponse20022 GroupV2EditClanBanner (long? groupId)
        {
            
            // verify the required parameter 'groupId' is set
            if (groupId == null) throw new ApiException(400, "Missing required parameter 'groupId' when calling GroupV2EditClanBanner");
            
    
            var path = "/GroupV2/{groupId}/EditClanBanner/";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2EditClanBanner: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2EditClanBanner: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20022) ApiClient.Deserialize(response.Content, typeof(InlineResponse20022), response.Headers);
        }
    
        /// <summary>
        ///  Edit group options only available to a founder. You must have suitable permissions in the group to perform this operation.
        /// </summary>
        /// <param name="groupId">Group ID of the group to edit.</param> 
        /// <returns>InlineResponse20022</returns>            
        public InlineResponse20022 GroupV2EditFounderOptions (long? groupId)
        {
            
            // verify the required parameter 'groupId' is set
            if (groupId == null) throw new ApiException(400, "Missing required parameter 'groupId' when calling GroupV2EditFounderOptions");
            
    
            var path = "/GroupV2/{groupId}/EditFounderOptions/";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2EditFounderOptions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2EditFounderOptions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20022) ApiClient.Deserialize(response.Content, typeof(InlineResponse20022), response.Headers);
        }
    
        /// <summary>
        ///  Edit an existing group. You must have suitable permissions in the group to perform this operation. This latest revision will only edit the fields you pass in - pass null for properties you want to leave unaltered.
        /// </summary>
        /// <param name="groupId">Group ID of the group to edit.</param> 
        /// <returns>InlineResponse20022</returns>            
        public InlineResponse20022 GroupV2EditGroup (long? groupId)
        {
            
            // verify the required parameter 'groupId' is set
            if (groupId == null) throw new ApiException(400, "Missing required parameter 'groupId' when calling GroupV2EditGroup");
            
    
            var path = "/GroupV2/{groupId}/Edit/";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2EditGroup: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2EditGroup: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20022) ApiClient.Deserialize(response.Content, typeof(InlineResponse20022), response.Headers);
        }
    
        /// <summary>
        ///  Edit the membership type of a given member. You must have suitable permissions in the group to perform this operation.
        /// </summary>
        /// <param name="groupId">ID of the group to which the member belongs.</param> 
        /// <param name="membershipId">Membership ID to modify.</param> 
        /// <param name="membershipType">Membership type of the provide membership ID.</param> 
        /// <param name="memberType">New membertype for the specified member.</param> 
        /// <returns>InlineResponse20022</returns>            
        public InlineResponse20022 GroupV2EditGroupMembership (long? groupId, long? membershipId, int? membershipType, int? memberType)
        {
            
            // verify the required parameter 'groupId' is set
            if (groupId == null) throw new ApiException(400, "Missing required parameter 'groupId' when calling GroupV2EditGroupMembership");
            
            // verify the required parameter 'membershipId' is set
            if (membershipId == null) throw new ApiException(400, "Missing required parameter 'membershipId' when calling GroupV2EditGroupMembership");
            
            // verify the required parameter 'membershipType' is set
            if (membershipType == null) throw new ApiException(400, "Missing required parameter 'membershipType' when calling GroupV2EditGroupMembership");
            
            // verify the required parameter 'memberType' is set
            if (memberType == null) throw new ApiException(400, "Missing required parameter 'memberType' when calling GroupV2EditGroupMembership");
            
    
            var path = "/GroupV2/{groupId}/Members/{membershipType}/{membershipId}/SetMembershipType/{memberType}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "groupId" + "}", ApiClient.ParameterToString(groupId));
path = path.Replace("{" + "membershipId" + "}", ApiClient.ParameterToString(membershipId));
path = path.Replace("{" + "membershipType" + "}", ApiClient.ParameterToString(membershipType));
path = path.Replace("{" + "memberType" + "}", ApiClient.ParameterToString(memberType));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2EditGroupMembership: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2EditGroupMembership: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20022) ApiClient.Deserialize(response.Content, typeof(InlineResponse20022), response.Headers);
        }
    
        /// <summary>
        ///  Edit the settings of an optional conversation/chat channel. Requires admin permissions to the group.
        /// </summary>
        /// <param name="conversationId">Conversation Id of the channel being edited.</param> 
        /// <param name="groupId">Group ID of the group to edit.</param> 
        /// <returns>InlineResponse20012</returns>            
        public InlineResponse20012 GroupV2EditOptionalConversation (long? conversationId, long? groupId)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling GroupV2EditOptionalConversation");
            
            // verify the required parameter 'groupId' is set
            if (groupId == null) throw new ApiException(400, "Missing required parameter 'groupId' when calling GroupV2EditOptionalConversation");
            
    
            var path = "/GroupV2/{groupId}/OptionalConversations/Edit/{conversationId}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "conversationId" + "}", ApiClient.ParameterToString(conversationId));
path = path.Replace("{" + "groupId" + "}", ApiClient.ParameterToString(groupId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2EditOptionalConversation: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2EditOptionalConversation: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20012) ApiClient.Deserialize(response.Content, typeof(InlineResponse20012), response.Headers);
        }
    
        /// <summary>
        ///  Get the list of members in a given group who are of admin level or higher.
        /// </summary>
        /// <param name="currentpage">Page number (starting with 1). Each page has a fixed size of 50 items per page.</param> 
        /// <param name="groupId">The ID of the group.</param> 
        /// <returns>InlineResponse20023</returns>            
        public InlineResponse20023 GroupV2GetAdminsAndFounderOfGroup (int? currentpage, long? groupId)
        {
            
            // verify the required parameter 'currentpage' is set
            if (currentpage == null) throw new ApiException(400, "Missing required parameter 'currentpage' when calling GroupV2GetAdminsAndFounderOfGroup");
            
            // verify the required parameter 'groupId' is set
            if (groupId == null) throw new ApiException(400, "Missing required parameter 'groupId' when calling GroupV2GetAdminsAndFounderOfGroup");
            
    
            var path = "/GroupV2/{groupId}/AdminsAndFounder/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "currentpage" + "}", ApiClient.ParameterToString(currentpage));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2GetAdminsAndFounderOfGroup: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2GetAdminsAndFounderOfGroup: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20023) ApiClient.Deserialize(response.Content, typeof(InlineResponse20023), response.Headers);
        }
    
        /// <summary>
        ///  Returns a list of all available group avatars for the signed-in user.
        /// </summary>
        /// <returns>InlineResponse20015</returns>            
        public InlineResponse20015 GroupV2GetAvailableAvatars ()
        {
            
    
            var path = "/GroupV2/GetAvailableAvatars/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2GetAvailableAvatars: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2GetAvailableAvatars: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20015) ApiClient.Deserialize(response.Content, typeof(InlineResponse20015), response.Headers);
        }
    
        /// <summary>
        ///  Returns a list of all available group themes.
        /// </summary>
        /// <returns>InlineResponse20016</returns>            
        public InlineResponse20016 GroupV2GetAvailableThemes ()
        {
            
    
            var path = "/GroupV2/GetAvailableThemes/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2GetAvailableThemes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2GetAvailableThemes: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20016) ApiClient.Deserialize(response.Content, typeof(InlineResponse20016), response.Headers);
        }
    
        /// <summary>
        ///  Get the list of banned members in a given group. Only accessible to group Admins and above. Not applicable to all groups. Check group features.
        /// </summary>
        /// <param name="currentpage">Page number (starting with 1). Each page has a fixed size of 50 entries.</param> 
        /// <param name="groupId">Group ID whose banned members you are fetching</param> 
        /// <returns>InlineResponse20025</returns>            
        public InlineResponse20025 GroupV2GetBannedMembersOfGroup (int? currentpage, long? groupId)
        {
            
            // verify the required parameter 'currentpage' is set
            if (currentpage == null) throw new ApiException(400, "Missing required parameter 'currentpage' when calling GroupV2GetBannedMembersOfGroup");
            
            // verify the required parameter 'groupId' is set
            if (groupId == null) throw new ApiException(400, "Missing required parameter 'groupId' when calling GroupV2GetBannedMembersOfGroup");
            
    
            var path = "/GroupV2/{groupId}/Banned/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "currentpage" + "}", ApiClient.ParameterToString(currentpage));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2GetBannedMembersOfGroup: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2GetBannedMembersOfGroup: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20025) ApiClient.Deserialize(response.Content, typeof(InlineResponse20025), response.Headers);
        }
    
        /// <summary>
        ///  Get information about a specific group of the given ID.
        /// </summary>
        /// <param name="groupId">Requested group&#39;s id.</param> 
        /// <returns>InlineResponse20020</returns>            
        public InlineResponse20020 GroupV2GetGroup (long? groupId)
        {
            
            // verify the required parameter 'groupId' is set
            if (groupId == null) throw new ApiException(400, "Missing required parameter 'groupId' when calling GroupV2GetGroup");
            
    
            var path = "/GroupV2/{groupId}/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2GetGroup: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2GetGroup: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20020) ApiClient.Deserialize(response.Content, typeof(InlineResponse20020), response.Headers);
        }
    
        /// <summary>
        ///  Get information about a specific group with the given name and type.
        /// </summary>
        /// <param name="groupName">Exact name of the group to find.</param> 
        /// <param name="groupType">Type of group to find.</param> 
        /// <returns>InlineResponse20020</returns>            
        public InlineResponse20020 GroupV2GetGroupByName (string groupName, int? groupType)
        {
            
            // verify the required parameter 'groupName' is set
            if (groupName == null) throw new ApiException(400, "Missing required parameter 'groupName' when calling GroupV2GetGroupByName");
            
            // verify the required parameter 'groupType' is set
            if (groupType == null) throw new ApiException(400, "Missing required parameter 'groupType' when calling GroupV2GetGroupByName");
            
    
            var path = "/GroupV2/Name/{groupName}/{groupType}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "groupName" + "}", ApiClient.ParameterToString(groupName));
path = path.Replace("{" + "groupType" + "}", ApiClient.ParameterToString(groupType));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2GetGroupByName: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2GetGroupByName: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20020) ApiClient.Deserialize(response.Content, typeof(InlineResponse20020), response.Headers);
        }
    
        /// <summary>
        ///  Get information about a specific group with the given name and type. The POST version.
        /// </summary>
        /// <returns>InlineResponse20020</returns>            
        public InlineResponse20020 GroupV2GetGroupByNameV2 ()
        {
            
    
            var path = "/GroupV2/NameV2/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2GetGroupByNameV2: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2GetGroupByNameV2: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20020) ApiClient.Deserialize(response.Content, typeof(InlineResponse20020), response.Headers);
        }
    
        /// <summary>
        ///  Gets a list of available optional conversation channels and their settings.
        /// </summary>
        /// <param name="groupId">Requested group&#39;s id.</param> 
        /// <returns>InlineResponse20021</returns>            
        public InlineResponse20021 GroupV2GetGroupOptionalConversations (long? groupId)
        {
            
            // verify the required parameter 'groupId' is set
            if (groupId == null) throw new ApiException(400, "Missing required parameter 'groupId' when calling GroupV2GetGroupOptionalConversations");
            
    
            var path = "/GroupV2/{groupId}/OptionalConversations/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2GetGroupOptionalConversations: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2GetGroupOptionalConversations: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20021) ApiClient.Deserialize(response.Content, typeof(InlineResponse20021), response.Headers);
        }
    
        /// <summary>
        ///  Get information about the groups that a given member has joined.
        /// </summary>
        /// <param name="filter">Filter apply to list of joined groups.</param> 
        /// <param name="groupType">Type of group the supplied member founded.</param> 
        /// <param name="membershipId">Membership ID to for which to find founded groups.</param> 
        /// <param name="membershipType">Membership type of the supplied membership ID.</param> 
        /// <returns>InlineResponse20028</returns>            
        public InlineResponse20028 GroupV2GetGroupsForMember (int? filter, int? groupType, long? membershipId, int? membershipType)
        {
            
            // verify the required parameter 'filter' is set
            if (filter == null) throw new ApiException(400, "Missing required parameter 'filter' when calling GroupV2GetGroupsForMember");
            
            // verify the required parameter 'groupType' is set
            if (groupType == null) throw new ApiException(400, "Missing required parameter 'groupType' when calling GroupV2GetGroupsForMember");
            
            // verify the required parameter 'membershipId' is set
            if (membershipId == null) throw new ApiException(400, "Missing required parameter 'membershipId' when calling GroupV2GetGroupsForMember");
            
            // verify the required parameter 'membershipType' is set
            if (membershipType == null) throw new ApiException(400, "Missing required parameter 'membershipType' when calling GroupV2GetGroupsForMember");
            
    
            var path = "/GroupV2/User/{membershipType}/{membershipId}/{filter}/{groupType}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "filter" + "}", ApiClient.ParameterToString(filter));
path = path.Replace("{" + "groupType" + "}", ApiClient.ParameterToString(groupType));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2GetGroupsForMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2GetGroupsForMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20028) ApiClient.Deserialize(response.Content, typeof(InlineResponse20028), response.Headers);
        }
    
        /// <summary>
        ///  Get the list of users who have been invited into the group.
        /// </summary>
        /// <param name="currentpage">Page number (starting with 1). Each page has a fixed size of 50 items per page.</param> 
        /// <param name="groupId">ID of the group.</param> 
        /// <returns>InlineResponse20026</returns>            
        public InlineResponse20026 GroupV2GetInvitedIndividuals (int? currentpage, long? groupId)
        {
            
            // verify the required parameter 'currentpage' is set
            if (currentpage == null) throw new ApiException(400, "Missing required parameter 'currentpage' when calling GroupV2GetInvitedIndividuals");
            
            // verify the required parameter 'groupId' is set
            if (groupId == null) throw new ApiException(400, "Missing required parameter 'groupId' when calling GroupV2GetInvitedIndividuals");
            
    
            var path = "/GroupV2/{groupId}/Members/InvitedIndividuals/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "currentpage" + "}", ApiClient.ParameterToString(currentpage));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2GetInvitedIndividuals: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2GetInvitedIndividuals: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20026) ApiClient.Deserialize(response.Content, typeof(InlineResponse20026), response.Headers);
        }
    
        /// <summary>
        ///  Get the list of members in a given group.
        /// </summary>
        /// <param name="currentpage">Page number (starting with 1). Each page has a fixed size of 50 items per page.</param> 
        /// <param name="groupId">The ID of the group.</param> 
        /// <param name="memberType">Filter out other member types. Use None for all members.</param> 
        /// <param name="nameSearch">The name fragment upon which a search should be executed for members with matching display or unique names.</param> 
        /// <returns>InlineResponse20023</returns>            
        public InlineResponse20023 GroupV2GetMembersOfGroup (int? currentpage, long? groupId, int? memberType, string nameSearch)
        {
            
            // verify the required parameter 'currentpage' is set
            if (currentpage == null) throw new ApiException(400, "Missing required parameter 'currentpage' when calling GroupV2GetMembersOfGroup");
            
            // verify the required parameter 'groupId' is set
            if (groupId == null) throw new ApiException(400, "Missing required parameter 'groupId' when calling GroupV2GetMembersOfGroup");
            
    
            var path = "/GroupV2/{groupId}/Members/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "currentpage" + "}", ApiClient.ParameterToString(currentpage));
path = path.Replace("{" + "groupId" + "}", ApiClient.ParameterToString(groupId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (memberType != null) queryParams.Add("memberType", ApiClient.ParameterToString(memberType)); // query parameter
 if (nameSearch != null) queryParams.Add("nameSearch", ApiClient.ParameterToString(nameSearch)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2GetMembersOfGroup: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2GetMembersOfGroup: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20023) ApiClient.Deserialize(response.Content, typeof(InlineResponse20023), response.Headers);
        }
    
        /// <summary>
        ///  Get the list of users who are awaiting a decision on their application to join a given group. Modified to include application info.
        /// </summary>
        /// <param name="currentpage">Page number (starting with 1). Each page has a fixed size of 50 items per page.</param> 
        /// <param name="groupId">ID of the group.</param> 
        /// <returns>InlineResponse20026</returns>            
        public InlineResponse20026 GroupV2GetPendingMemberships (int? currentpage, long? groupId)
        {
            
            // verify the required parameter 'currentpage' is set
            if (currentpage == null) throw new ApiException(400, "Missing required parameter 'currentpage' when calling GroupV2GetPendingMemberships");
            
            // verify the required parameter 'groupId' is set
            if (groupId == null) throw new ApiException(400, "Missing required parameter 'groupId' when calling GroupV2GetPendingMemberships");
            
    
            var path = "/GroupV2/{groupId}/Members/Pending/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "currentpage" + "}", ApiClient.ParameterToString(currentpage));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2GetPendingMemberships: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2GetPendingMemberships: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20026) ApiClient.Deserialize(response.Content, typeof(InlineResponse20026), response.Headers);
        }
    
        /// <summary>
        ///  Get information about the groups that a given member has applied to or been invited to.
        /// </summary>
        /// <param name="filter">Filter apply to list of potential joined groups.</param> 
        /// <param name="groupType">Type of group the supplied member applied.</param> 
        /// <param name="membershipId">Membership ID to for which to find applied groups.</param> 
        /// <param name="membershipType">Membership type of the supplied membership ID.</param> 
        /// <returns>InlineResponse20030</returns>            
        public InlineResponse20030 GroupV2GetPotentialGroupsForMember (int? filter, int? groupType, long? membershipId, int? membershipType)
        {
            
            // verify the required parameter 'filter' is set
            if (filter == null) throw new ApiException(400, "Missing required parameter 'filter' when calling GroupV2GetPotentialGroupsForMember");
            
            // verify the required parameter 'groupType' is set
            if (groupType == null) throw new ApiException(400, "Missing required parameter 'groupType' when calling GroupV2GetPotentialGroupsForMember");
            
            // verify the required parameter 'membershipId' is set
            if (membershipId == null) throw new ApiException(400, "Missing required parameter 'membershipId' when calling GroupV2GetPotentialGroupsForMember");
            
            // verify the required parameter 'membershipType' is set
            if (membershipType == null) throw new ApiException(400, "Missing required parameter 'membershipType' when calling GroupV2GetPotentialGroupsForMember");
            
    
            var path = "/GroupV2/User/Potential/{membershipType}/{membershipId}/{filter}/{groupType}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "filter" + "}", ApiClient.ParameterToString(filter));
path = path.Replace("{" + "groupType" + "}", ApiClient.ParameterToString(groupType));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2GetPotentialGroupsForMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2GetPotentialGroupsForMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20030) ApiClient.Deserialize(response.Content, typeof(InlineResponse20030), response.Headers);
        }
    
        /// <summary>
        ///  Gets groups recommended for you based on the groups to whom those you follow belong.
        /// </summary>
        /// <param name="createDateRange">Requested range in which to pull recommended groups</param> 
        /// <param name="groupType">Type of groups requested</param> 
        /// <returns>InlineResponse20018</returns>            
        public InlineResponse20018 GroupV2GetRecommendedGroups (int? createDateRange, int? groupType)
        {
            
            // verify the required parameter 'createDateRange' is set
            if (createDateRange == null) throw new ApiException(400, "Missing required parameter 'createDateRange' when calling GroupV2GetRecommendedGroups");
            
            // verify the required parameter 'groupType' is set
            if (groupType == null) throw new ApiException(400, "Missing required parameter 'groupType' when calling GroupV2GetRecommendedGroups");
            
    
            var path = "/GroupV2/Recommended/{groupType}/{createDateRange}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "createDateRange" + "}", ApiClient.ParameterToString(createDateRange));
path = path.Replace("{" + "groupType" + "}", ApiClient.ParameterToString(groupType));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2GetRecommendedGroups: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2GetRecommendedGroups: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20018) ApiClient.Deserialize(response.Content, typeof(InlineResponse20018), response.Headers);
        }
    
        /// <summary>
        ///  Gets the state of the user&#39;s clan invite preferences for a particular membership type - true if they wish to be invited to clans, false otherwise.
        /// </summary>
        /// <param name="mType">The Destiny membership type of the account we wish to access settings.</param> 
        /// <returns>InlineResponse20017</returns>            
        public InlineResponse20017 GroupV2GetUserClanInviteSetting (int? mType)
        {
            
            // verify the required parameter 'mType' is set
            if (mType == null) throw new ApiException(400, "Missing required parameter 'mType' when calling GroupV2GetUserClanInviteSetting");
            
    
            var path = "/GroupV2/GetUserClanInviteSetting/{mType}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "mType" + "}", ApiClient.ParameterToString(mType));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2GetUserClanInviteSetting: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2GetUserClanInviteSetting: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20017) ApiClient.Deserialize(response.Content, typeof(InlineResponse20017), response.Headers);
        }
    
        /// <summary>
        ///  Search for Groups.
        /// </summary>
        /// <returns>InlineResponse20019</returns>            
        public InlineResponse20019 GroupV2GroupSearch ()
        {
            
    
            var path = "/GroupV2/Search/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2GroupSearch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2GroupSearch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20019) ApiClient.Deserialize(response.Content, typeof(InlineResponse20019), response.Headers);
        }
    
        /// <summary>
        ///  Invite a user to join this group.
        /// </summary>
        /// <param name="groupId">ID of the group you would like to join.</param> 
        /// <param name="membershipId">Membership id of the account being invited.</param> 
        /// <param name="membershipType">MembershipType of the account being invited.</param> 
        /// <returns>InlineResponse20031</returns>            
        public InlineResponse20031 GroupV2IndividualGroupInvite (long? groupId, long? membershipId, int? membershipType)
        {
            
            // verify the required parameter 'groupId' is set
            if (groupId == null) throw new ApiException(400, "Missing required parameter 'groupId' when calling GroupV2IndividualGroupInvite");
            
            // verify the required parameter 'membershipId' is set
            if (membershipId == null) throw new ApiException(400, "Missing required parameter 'membershipId' when calling GroupV2IndividualGroupInvite");
            
            // verify the required parameter 'membershipType' is set
            if (membershipType == null) throw new ApiException(400, "Missing required parameter 'membershipType' when calling GroupV2IndividualGroupInvite");
            
    
            var path = "/GroupV2/{groupId}/Members/IndividualInvite/{membershipType}/{membershipId}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "groupId" + "}", ApiClient.ParameterToString(groupId));
path = path.Replace("{" + "membershipId" + "}", ApiClient.ParameterToString(membershipId));
path = path.Replace("{" + "membershipType" + "}", ApiClient.ParameterToString(membershipType));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2IndividualGroupInvite: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2IndividualGroupInvite: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20031) ApiClient.Deserialize(response.Content, typeof(InlineResponse20031), response.Headers);
        }
    
        /// <summary>
        ///  Cancels a pending invitation to join a group.
        /// </summary>
        /// <param name="groupId">ID of the group you would like to join.</param> 
        /// <param name="membershipId">Membership id of the account being cancelled.</param> 
        /// <param name="membershipType">MembershipType of the account being cancelled.</param> 
        /// <returns>InlineResponse20031</returns>            
        public InlineResponse20031 GroupV2IndividualGroupInviteCancel (long? groupId, long? membershipId, int? membershipType)
        {
            
            // verify the required parameter 'groupId' is set
            if (groupId == null) throw new ApiException(400, "Missing required parameter 'groupId' when calling GroupV2IndividualGroupInviteCancel");
            
            // verify the required parameter 'membershipId' is set
            if (membershipId == null) throw new ApiException(400, "Missing required parameter 'membershipId' when calling GroupV2IndividualGroupInviteCancel");
            
            // verify the required parameter 'membershipType' is set
            if (membershipType == null) throw new ApiException(400, "Missing required parameter 'membershipType' when calling GroupV2IndividualGroupInviteCancel");
            
    
            var path = "/GroupV2/{groupId}/Members/IndividualInviteCancel/{membershipType}/{membershipId}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "groupId" + "}", ApiClient.ParameterToString(groupId));
path = path.Replace("{" + "membershipId" + "}", ApiClient.ParameterToString(membershipId));
path = path.Replace("{" + "membershipType" + "}", ApiClient.ParameterToString(membershipType));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2IndividualGroupInviteCancel: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2IndividualGroupInviteCancel: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20031) ApiClient.Deserialize(response.Content, typeof(InlineResponse20031), response.Headers);
        }
    
        /// <summary>
        ///  Kick a member from the given group, forcing them to reapply if they wish to re-join the group. You must have suitable permissions in the group to perform this operation.
        /// </summary>
        /// <param name="groupId">Group ID to kick the user from.</param> 
        /// <param name="membershipId">Membership ID to kick.</param> 
        /// <param name="membershipType">Membership type of the provided membership ID.</param> 
        /// <returns>InlineResponse20024</returns>            
        public InlineResponse20024 GroupV2KickMember (long? groupId, long? membershipId, int? membershipType)
        {
            
            // verify the required parameter 'groupId' is set
            if (groupId == null) throw new ApiException(400, "Missing required parameter 'groupId' when calling GroupV2KickMember");
            
            // verify the required parameter 'membershipId' is set
            if (membershipId == null) throw new ApiException(400, "Missing required parameter 'membershipId' when calling GroupV2KickMember");
            
            // verify the required parameter 'membershipType' is set
            if (membershipType == null) throw new ApiException(400, "Missing required parameter 'membershipType' when calling GroupV2KickMember");
            
    
            var path = "/GroupV2/{groupId}/Members/{membershipType}/{membershipId}/Kick/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "groupId" + "}", ApiClient.ParameterToString(groupId));
path = path.Replace("{" + "membershipId" + "}", ApiClient.ParameterToString(membershipId));
path = path.Replace("{" + "membershipType" + "}", ApiClient.ParameterToString(membershipType));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2KickMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2KickMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20024) ApiClient.Deserialize(response.Content, typeof(InlineResponse20024), response.Headers);
        }
    
        /// <summary>
        ///  Allows a founder to manually recover a group they can see in game but not on bungie.net
        /// </summary>
        /// <param name="groupType">Type of group the supplied member founded.</param> 
        /// <param name="membershipId">Membership ID to for which to find founded groups.</param> 
        /// <param name="membershipType">Membership type of the supplied membership ID.</param> 
        /// <returns>InlineResponse20029</returns>            
        public InlineResponse20029 GroupV2RecoverGroupForFounder (int? groupType, long? membershipId, int? membershipType)
        {
            
            // verify the required parameter 'groupType' is set
            if (groupType == null) throw new ApiException(400, "Missing required parameter 'groupType' when calling GroupV2RecoverGroupForFounder");
            
            // verify the required parameter 'membershipId' is set
            if (membershipId == null) throw new ApiException(400, "Missing required parameter 'membershipId' when calling GroupV2RecoverGroupForFounder");
            
            // verify the required parameter 'membershipType' is set
            if (membershipType == null) throw new ApiException(400, "Missing required parameter 'membershipType' when calling GroupV2RecoverGroupForFounder");
            
    
            var path = "/GroupV2/Recover/{membershipType}/{membershipId}/{groupType}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "groupType" + "}", ApiClient.ParameterToString(groupType));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2RecoverGroupForFounder: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2RecoverGroupForFounder: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20029) ApiClient.Deserialize(response.Content, typeof(InlineResponse20029), response.Headers);
        }
    
        /// <summary>
        ///  Unbans the requested member, allowing them to re-apply for membership.
        /// </summary>
        /// <param name="groupId"></param> 
        /// <param name="membershipId">Membership ID of the member to unban from the group</param> 
        /// <param name="membershipType">Membership type of the provided membership ID.</param> 
        /// <returns>InlineResponse20022</returns>            
        public InlineResponse20022 GroupV2UnbanMember (long? groupId, long? membershipId, int? membershipType)
        {
            
            // verify the required parameter 'groupId' is set
            if (groupId == null) throw new ApiException(400, "Missing required parameter 'groupId' when calling GroupV2UnbanMember");
            
            // verify the required parameter 'membershipId' is set
            if (membershipId == null) throw new ApiException(400, "Missing required parameter 'membershipId' when calling GroupV2UnbanMember");
            
            // verify the required parameter 'membershipType' is set
            if (membershipType == null) throw new ApiException(400, "Missing required parameter 'membershipType' when calling GroupV2UnbanMember");
            
    
            var path = "/GroupV2/{groupId}/Members/{membershipType}/{membershipId}/Unban/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "groupId" + "}", ApiClient.ParameterToString(groupId));
path = path.Replace("{" + "membershipId" + "}", ApiClient.ParameterToString(membershipId));
path = path.Replace("{" + "membershipType" + "}", ApiClient.ParameterToString(membershipType));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2UnbanMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GroupV2UnbanMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20022) ApiClient.Deserialize(response.Content, typeof(InlineResponse20022), response.Headers);
        }
    
    }
}
