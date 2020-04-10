using System;
using Nancy;
using Nancy.ModelBinding;
using System.Collections.Generic;
using Sharpility.Base;
using BungieNetApi._Platform.Models;
using BungieNetApi._Platform.Utils;
using NodaTime;

namespace BungieNetApi._Platform.Modules
{ 

    /// <summary>
    /// Module processing requests of GroupV2 domain.
    /// </summary>
    public sealed class GroupV2Module : NancyModule
    {
        /// <summary>
        /// Sets up HTTP methods mappings.
        /// </summary>
        /// <param name="service">Service handling requests</param>
        public GroupV2Module(GroupV2Service service) : base("/Platform")
        { 
            Post["/GroupV2/{groupId}/Admin/AbdicateFoundership/{membershipType}/{founderIdNew}/"] = parameters =>
            {
                var founderIdNew = Parameters.ValueOf<long?>(parameters, Context.Request, "founderIdNew", ParameterType.Path);
                var groupId = Parameters.ValueOf<long?>(parameters, Context.Request, "groupId", ParameterType.Path);
                var membershipType = Parameters.ValueOf<int?>(parameters, Context.Request, "membershipType", ParameterType.Path);
                Preconditions.IsNotNull(founderIdNew, "Required parameter: 'founderIdNew' is missing at 'GroupV2AbdicateFoundership'");
                
                Preconditions.IsNotNull(groupId, "Required parameter: 'groupId' is missing at 'GroupV2AbdicateFoundership'");
                
                Preconditions.IsNotNull(membershipType, "Required parameter: 'membershipType' is missing at 'GroupV2AbdicateFoundership'");
                
                return service.GroupV2AbdicateFoundership(Context, founderIdNew, groupId, membershipType);
            };

            Post["/GroupV2/{groupId}/OptionalConversations/Add/"] = parameters =>
            {
                var groupId = Parameters.ValueOf<long?>(parameters, Context.Request, "groupId", ParameterType.Path);
                Preconditions.IsNotNull(groupId, "Required parameter: 'groupId' is missing at 'GroupV2AddOptionalConversation'");
                
                return service.GroupV2AddOptionalConversation(Context, groupId);
            };

            Post["/GroupV2/{groupId}/Members/ApproveAll/"] = parameters =>
            {
                var groupId = Parameters.ValueOf<long?>(parameters, Context.Request, "groupId", ParameterType.Path);
                Preconditions.IsNotNull(groupId, "Required parameter: 'groupId' is missing at 'GroupV2ApproveAllPending'");
                
                return service.GroupV2ApproveAllPending(Context, groupId);
            };

            Post["/GroupV2/{groupId}/Members/Approve/{membershipType}/{membershipId}/"] = parameters =>
            {
                var groupId = Parameters.ValueOf<long?>(parameters, Context.Request, "groupId", ParameterType.Path);
                var membershipId = Parameters.ValueOf<long?>(parameters, Context.Request, "membershipId", ParameterType.Path);
                var membershipType = Parameters.ValueOf<int?>(parameters, Context.Request, "membershipType", ParameterType.Path);
                Preconditions.IsNotNull(groupId, "Required parameter: 'groupId' is missing at 'GroupV2ApprovePending'");
                
                Preconditions.IsNotNull(membershipId, "Required parameter: 'membershipId' is missing at 'GroupV2ApprovePending'");
                
                Preconditions.IsNotNull(membershipType, "Required parameter: 'membershipType' is missing at 'GroupV2ApprovePending'");
                
                return service.GroupV2ApprovePending(Context, groupId, membershipId, membershipType);
            };

            Post["/GroupV2/{groupId}/Members/ApproveList/"] = parameters =>
            {
                var groupId = Parameters.ValueOf<long?>(parameters, Context.Request, "groupId", ParameterType.Path);
                Preconditions.IsNotNull(groupId, "Required parameter: 'groupId' is missing at 'GroupV2ApprovePendingForList'");
                
                return service.GroupV2ApprovePendingForList(Context, groupId);
            };

            Post["/GroupV2/{groupId}/Members/{membershipType}/{membershipId}/Ban/"] = parameters =>
            {
                var groupId = Parameters.ValueOf<long?>(parameters, Context.Request, "groupId", ParameterType.Path);
                var membershipId = Parameters.ValueOf<long?>(parameters, Context.Request, "membershipId", ParameterType.Path);
                var membershipType = Parameters.ValueOf<int?>(parameters, Context.Request, "membershipType", ParameterType.Path);
                Preconditions.IsNotNull(groupId, "Required parameter: 'groupId' is missing at 'GroupV2BanMember'");
                
                Preconditions.IsNotNull(membershipId, "Required parameter: 'membershipId' is missing at 'GroupV2BanMember'");
                
                Preconditions.IsNotNull(membershipType, "Required parameter: 'membershipType' is missing at 'GroupV2BanMember'");
                
                return service.GroupV2BanMember(Context, groupId, membershipId, membershipType);
            };

            Post["/GroupV2/{groupId}/Members/DenyAll/"] = parameters =>
            {
                var groupId = Parameters.ValueOf<long?>(parameters, Context.Request, "groupId", ParameterType.Path);
                Preconditions.IsNotNull(groupId, "Required parameter: 'groupId' is missing at 'GroupV2DenyAllPending'");
                
                return service.GroupV2DenyAllPending(Context, groupId);
            };

            Post["/GroupV2/{groupId}/Members/DenyList/"] = parameters =>
            {
                var groupId = Parameters.ValueOf<long?>(parameters, Context.Request, "groupId", ParameterType.Path);
                Preconditions.IsNotNull(groupId, "Required parameter: 'groupId' is missing at 'GroupV2DenyPendingForList'");
                
                return service.GroupV2DenyPendingForList(Context, groupId);
            };

            Post["/GroupV2/{groupId}/EditClanBanner/"] = parameters =>
            {
                var groupId = Parameters.ValueOf<long?>(parameters, Context.Request, "groupId", ParameterType.Path);
                Preconditions.IsNotNull(groupId, "Required parameter: 'groupId' is missing at 'GroupV2EditClanBanner'");
                
                return service.GroupV2EditClanBanner(Context, groupId);
            };

            Post["/GroupV2/{groupId}/EditFounderOptions/"] = parameters =>
            {
                var groupId = Parameters.ValueOf<long?>(parameters, Context.Request, "groupId", ParameterType.Path);
                Preconditions.IsNotNull(groupId, "Required parameter: 'groupId' is missing at 'GroupV2EditFounderOptions'");
                
                return service.GroupV2EditFounderOptions(Context, groupId);
            };

            Post["/GroupV2/{groupId}/Edit/"] = parameters =>
            {
                var groupId = Parameters.ValueOf<long?>(parameters, Context.Request, "groupId", ParameterType.Path);
                Preconditions.IsNotNull(groupId, "Required parameter: 'groupId' is missing at 'GroupV2EditGroup'");
                
                return service.GroupV2EditGroup(Context, groupId);
            };

            Post["/GroupV2/{groupId}/Members/{membershipType}/{membershipId}/SetMembershipType/{memberType}/"] = parameters =>
            {
                var groupId = Parameters.ValueOf<long?>(parameters, Context.Request, "groupId", ParameterType.Path);
                var membershipId = Parameters.ValueOf<long?>(parameters, Context.Request, "membershipId", ParameterType.Path);
                var membershipType = Parameters.ValueOf<int?>(parameters, Context.Request, "membershipType", ParameterType.Path);
                var memberType = Parameters.ValueOf<int?>(parameters, Context.Request, "memberType", ParameterType.Path);
                Preconditions.IsNotNull(groupId, "Required parameter: 'groupId' is missing at 'GroupV2EditGroupMembership'");
                
                Preconditions.IsNotNull(membershipId, "Required parameter: 'membershipId' is missing at 'GroupV2EditGroupMembership'");
                
                Preconditions.IsNotNull(membershipType, "Required parameter: 'membershipType' is missing at 'GroupV2EditGroupMembership'");
                
                Preconditions.IsNotNull(memberType, "Required parameter: 'memberType' is missing at 'GroupV2EditGroupMembership'");
                
                return service.GroupV2EditGroupMembership(Context, groupId, membershipId, membershipType, memberType);
            };

            Post["/GroupV2/{groupId}/OptionalConversations/Edit/{conversationId}/"] = parameters =>
            {
                var conversationId = Parameters.ValueOf<long?>(parameters, Context.Request, "conversationId", ParameterType.Path);
                var groupId = Parameters.ValueOf<long?>(parameters, Context.Request, "groupId", ParameterType.Path);
                Preconditions.IsNotNull(conversationId, "Required parameter: 'conversationId' is missing at 'GroupV2EditOptionalConversation'");
                
                Preconditions.IsNotNull(groupId, "Required parameter: 'groupId' is missing at 'GroupV2EditOptionalConversation'");
                
                return service.GroupV2EditOptionalConversation(Context, conversationId, groupId);
            };

            Get["/GroupV2/{groupId}/AdminsAndFounder/"] = parameters =>
            {
                var currentpage = Parameters.ValueOf<int?>(parameters, Context.Request, "currentpage", ParameterType.Path);
                var groupId = Parameters.ValueOf<long?>(parameters, Context.Request, "groupId", ParameterType.Path);
                Preconditions.IsNotNull(currentpage, "Required parameter: 'currentpage' is missing at 'GroupV2GetAdminsAndFounderOfGroup'");
                
                Preconditions.IsNotNull(groupId, "Required parameter: 'groupId' is missing at 'GroupV2GetAdminsAndFounderOfGroup'");
                
                return service.GroupV2GetAdminsAndFounderOfGroup(Context, currentpage, groupId);
            };

            Get["/GroupV2/GetAvailableAvatars/"] = parameters =>
            {
                
                return service.GroupV2GetAvailableAvatars(Context);
            };

            Get["/GroupV2/GetAvailableThemes/"] = parameters =>
            {
                
                return service.GroupV2GetAvailableThemes(Context);
            };

            Get["/GroupV2/{groupId}/Banned/"] = parameters =>
            {
                var currentpage = Parameters.ValueOf<int?>(parameters, Context.Request, "currentpage", ParameterType.Path);
                var groupId = Parameters.ValueOf<long?>(parameters, Context.Request, "groupId", ParameterType.Path);
                Preconditions.IsNotNull(currentpage, "Required parameter: 'currentpage' is missing at 'GroupV2GetBannedMembersOfGroup'");
                
                Preconditions.IsNotNull(groupId, "Required parameter: 'groupId' is missing at 'GroupV2GetBannedMembersOfGroup'");
                
                return service.GroupV2GetBannedMembersOfGroup(Context, currentpage, groupId);
            };

            Get["/GroupV2/{groupId}/"] = parameters =>
            {
                var groupId = Parameters.ValueOf<long?>(parameters, Context.Request, "groupId", ParameterType.Path);
                Preconditions.IsNotNull(groupId, "Required parameter: 'groupId' is missing at 'GroupV2GetGroup'");
                
                return service.GroupV2GetGroup(Context, groupId);
            };

            Get["/GroupV2/Name/{groupName}/{groupType}/"] = parameters =>
            {
                var groupName = Parameters.ValueOf<string>(parameters, Context.Request, "groupName", ParameterType.Path);
                var groupType = Parameters.ValueOf<int?>(parameters, Context.Request, "groupType", ParameterType.Path);
                Preconditions.IsNotNull(groupName, "Required parameter: 'groupName' is missing at 'GroupV2GetGroupByName'");
                
                Preconditions.IsNotNull(groupType, "Required parameter: 'groupType' is missing at 'GroupV2GetGroupByName'");
                
                return service.GroupV2GetGroupByName(Context, groupName, groupType);
            };

            Post["/GroupV2/NameV2/"] = parameters =>
            {
                
                return service.GroupV2GetGroupByNameV2(Context);
            };

            Get["/GroupV2/{groupId}/OptionalConversations/"] = parameters =>
            {
                var groupId = Parameters.ValueOf<long?>(parameters, Context.Request, "groupId", ParameterType.Path);
                Preconditions.IsNotNull(groupId, "Required parameter: 'groupId' is missing at 'GroupV2GetGroupOptionalConversations'");
                
                return service.GroupV2GetGroupOptionalConversations(Context, groupId);
            };

            Get["/GroupV2/User/{membershipType}/{membershipId}/{filter}/{groupType}/"] = parameters =>
            {
                var filter = Parameters.ValueOf<int?>(parameters, Context.Request, "filter", ParameterType.Path);
                var groupType = Parameters.ValueOf<int?>(parameters, Context.Request, "groupType", ParameterType.Path);
                var membershipId = Parameters.ValueOf<long?>(parameters, Context.Request, "membershipId", ParameterType.Path);
                var membershipType = Parameters.ValueOf<int?>(parameters, Context.Request, "membershipType", ParameterType.Path);
                Preconditions.IsNotNull(filter, "Required parameter: 'filter' is missing at 'GroupV2GetGroupsForMember'");
                
                Preconditions.IsNotNull(groupType, "Required parameter: 'groupType' is missing at 'GroupV2GetGroupsForMember'");
                
                Preconditions.IsNotNull(membershipId, "Required parameter: 'membershipId' is missing at 'GroupV2GetGroupsForMember'");
                
                Preconditions.IsNotNull(membershipType, "Required parameter: 'membershipType' is missing at 'GroupV2GetGroupsForMember'");
                
                return service.GroupV2GetGroupsForMember(Context, filter, groupType, membershipId, membershipType);
            };

            Get["/GroupV2/{groupId}/Members/InvitedIndividuals/"] = parameters =>
            {
                var currentpage = Parameters.ValueOf<int?>(parameters, Context.Request, "currentpage", ParameterType.Path);
                var groupId = Parameters.ValueOf<long?>(parameters, Context.Request, "groupId", ParameterType.Path);
                Preconditions.IsNotNull(currentpage, "Required parameter: 'currentpage' is missing at 'GroupV2GetInvitedIndividuals'");
                
                Preconditions.IsNotNull(groupId, "Required parameter: 'groupId' is missing at 'GroupV2GetInvitedIndividuals'");
                
                return service.GroupV2GetInvitedIndividuals(Context, currentpage, groupId);
            };

            Get["/GroupV2/{groupId}/Members/"] = parameters =>
            {
                var currentpage = Parameters.ValueOf<int?>(parameters, Context.Request, "currentpage", ParameterType.Path);
                var groupId = Parameters.ValueOf<long?>(parameters, Context.Request, "groupId", ParameterType.Path);
                var memberType = Parameters.ValueOf<int?>(parameters, Context.Request, "memberType", ParameterType.Query);
                var nameSearch = Parameters.ValueOf<string>(parameters, Context.Request, "nameSearch", ParameterType.Query);
                Preconditions.IsNotNull(currentpage, "Required parameter: 'currentpage' is missing at 'GroupV2GetMembersOfGroup'");
                
                Preconditions.IsNotNull(groupId, "Required parameter: 'groupId' is missing at 'GroupV2GetMembersOfGroup'");
                
                return service.GroupV2GetMembersOfGroup(Context, currentpage, groupId, memberType, nameSearch);
            };

            Get["/GroupV2/{groupId}/Members/Pending/"] = parameters =>
            {
                var currentpage = Parameters.ValueOf<int?>(parameters, Context.Request, "currentpage", ParameterType.Path);
                var groupId = Parameters.ValueOf<long?>(parameters, Context.Request, "groupId", ParameterType.Path);
                Preconditions.IsNotNull(currentpage, "Required parameter: 'currentpage' is missing at 'GroupV2GetPendingMemberships'");
                
                Preconditions.IsNotNull(groupId, "Required parameter: 'groupId' is missing at 'GroupV2GetPendingMemberships'");
                
                return service.GroupV2GetPendingMemberships(Context, currentpage, groupId);
            };

            Get["/GroupV2/User/Potential/{membershipType}/{membershipId}/{filter}/{groupType}/"] = parameters =>
            {
                var filter = Parameters.ValueOf<int?>(parameters, Context.Request, "filter", ParameterType.Path);
                var groupType = Parameters.ValueOf<int?>(parameters, Context.Request, "groupType", ParameterType.Path);
                var membershipId = Parameters.ValueOf<long?>(parameters, Context.Request, "membershipId", ParameterType.Path);
                var membershipType = Parameters.ValueOf<int?>(parameters, Context.Request, "membershipType", ParameterType.Path);
                Preconditions.IsNotNull(filter, "Required parameter: 'filter' is missing at 'GroupV2GetPotentialGroupsForMember'");
                
                Preconditions.IsNotNull(groupType, "Required parameter: 'groupType' is missing at 'GroupV2GetPotentialGroupsForMember'");
                
                Preconditions.IsNotNull(membershipId, "Required parameter: 'membershipId' is missing at 'GroupV2GetPotentialGroupsForMember'");
                
                Preconditions.IsNotNull(membershipType, "Required parameter: 'membershipType' is missing at 'GroupV2GetPotentialGroupsForMember'");
                
                return service.GroupV2GetPotentialGroupsForMember(Context, filter, groupType, membershipId, membershipType);
            };

            Post["/GroupV2/Recommended/{groupType}/{createDateRange}/"] = parameters =>
            {
                var createDateRange = Parameters.ValueOf<int?>(parameters, Context.Request, "createDateRange", ParameterType.Path);
                var groupType = Parameters.ValueOf<int?>(parameters, Context.Request, "groupType", ParameterType.Path);
                Preconditions.IsNotNull(createDateRange, "Required parameter: 'createDateRange' is missing at 'GroupV2GetRecommendedGroups'");
                
                Preconditions.IsNotNull(groupType, "Required parameter: 'groupType' is missing at 'GroupV2GetRecommendedGroups'");
                
                return service.GroupV2GetRecommendedGroups(Context, createDateRange, groupType);
            };

            Get["/GroupV2/GetUserClanInviteSetting/{mType}/"] = parameters =>
            {
                var mType = Parameters.ValueOf<int?>(parameters, Context.Request, "mType", ParameterType.Path);
                Preconditions.IsNotNull(mType, "Required parameter: 'mType' is missing at 'GroupV2GetUserClanInviteSetting'");
                
                return service.GroupV2GetUserClanInviteSetting(Context, mType);
            };

            Post["/GroupV2/Search/"] = parameters =>
            {
                
                return service.GroupV2GroupSearch(Context);
            };

            Post["/GroupV2/{groupId}/Members/IndividualInvite/{membershipType}/{membershipId}/"] = parameters =>
            {
                var groupId = Parameters.ValueOf<long?>(parameters, Context.Request, "groupId", ParameterType.Path);
                var membershipId = Parameters.ValueOf<long?>(parameters, Context.Request, "membershipId", ParameterType.Path);
                var membershipType = Parameters.ValueOf<int?>(parameters, Context.Request, "membershipType", ParameterType.Path);
                Preconditions.IsNotNull(groupId, "Required parameter: 'groupId' is missing at 'GroupV2IndividualGroupInvite'");
                
                Preconditions.IsNotNull(membershipId, "Required parameter: 'membershipId' is missing at 'GroupV2IndividualGroupInvite'");
                
                Preconditions.IsNotNull(membershipType, "Required parameter: 'membershipType' is missing at 'GroupV2IndividualGroupInvite'");
                
                return service.GroupV2IndividualGroupInvite(Context, groupId, membershipId, membershipType);
            };

            Post["/GroupV2/{groupId}/Members/IndividualInviteCancel/{membershipType}/{membershipId}/"] = parameters =>
            {
                var groupId = Parameters.ValueOf<long?>(parameters, Context.Request, "groupId", ParameterType.Path);
                var membershipId = Parameters.ValueOf<long?>(parameters, Context.Request, "membershipId", ParameterType.Path);
                var membershipType = Parameters.ValueOf<int?>(parameters, Context.Request, "membershipType", ParameterType.Path);
                Preconditions.IsNotNull(groupId, "Required parameter: 'groupId' is missing at 'GroupV2IndividualGroupInviteCancel'");
                
                Preconditions.IsNotNull(membershipId, "Required parameter: 'membershipId' is missing at 'GroupV2IndividualGroupInviteCancel'");
                
                Preconditions.IsNotNull(membershipType, "Required parameter: 'membershipType' is missing at 'GroupV2IndividualGroupInviteCancel'");
                
                return service.GroupV2IndividualGroupInviteCancel(Context, groupId, membershipId, membershipType);
            };

            Post["/GroupV2/{groupId}/Members/{membershipType}/{membershipId}/Kick/"] = parameters =>
            {
                var groupId = Parameters.ValueOf<long?>(parameters, Context.Request, "groupId", ParameterType.Path);
                var membershipId = Parameters.ValueOf<long?>(parameters, Context.Request, "membershipId", ParameterType.Path);
                var membershipType = Parameters.ValueOf<int?>(parameters, Context.Request, "membershipType", ParameterType.Path);
                Preconditions.IsNotNull(groupId, "Required parameter: 'groupId' is missing at 'GroupV2KickMember'");
                
                Preconditions.IsNotNull(membershipId, "Required parameter: 'membershipId' is missing at 'GroupV2KickMember'");
                
                Preconditions.IsNotNull(membershipType, "Required parameter: 'membershipType' is missing at 'GroupV2KickMember'");
                
                return service.GroupV2KickMember(Context, groupId, membershipId, membershipType);
            };

            Get["/GroupV2/Recover/{membershipType}/{membershipId}/{groupType}/"] = parameters =>
            {
                var groupType = Parameters.ValueOf<int?>(parameters, Context.Request, "groupType", ParameterType.Path);
                var membershipId = Parameters.ValueOf<long?>(parameters, Context.Request, "membershipId", ParameterType.Path);
                var membershipType = Parameters.ValueOf<int?>(parameters, Context.Request, "membershipType", ParameterType.Path);
                Preconditions.IsNotNull(groupType, "Required parameter: 'groupType' is missing at 'GroupV2RecoverGroupForFounder'");
                
                Preconditions.IsNotNull(membershipId, "Required parameter: 'membershipId' is missing at 'GroupV2RecoverGroupForFounder'");
                
                Preconditions.IsNotNull(membershipType, "Required parameter: 'membershipType' is missing at 'GroupV2RecoverGroupForFounder'");
                
                return service.GroupV2RecoverGroupForFounder(Context, groupType, membershipId, membershipType);
            };

            Post["/GroupV2/{groupId}/Members/{membershipType}/{membershipId}/Unban/"] = parameters =>
            {
                var groupId = Parameters.ValueOf<long?>(parameters, Context.Request, "groupId", ParameterType.Path);
                var membershipId = Parameters.ValueOf<long?>(parameters, Context.Request, "membershipId", ParameterType.Path);
                var membershipType = Parameters.ValueOf<int?>(parameters, Context.Request, "membershipType", ParameterType.Path);
                Preconditions.IsNotNull(groupId, "Required parameter: 'groupId' is missing at 'GroupV2UnbanMember'");
                
                Preconditions.IsNotNull(membershipId, "Required parameter: 'membershipId' is missing at 'GroupV2UnbanMember'");
                
                Preconditions.IsNotNull(membershipType, "Required parameter: 'membershipType' is missing at 'GroupV2UnbanMember'");
                
                return service.GroupV2UnbanMember(Context, groupId, membershipId, membershipType);
            };
        }
    }

    /// <summary>
    /// Service handling GroupV2 requests.
    /// </summary>
    public interface GroupV2Service
    {
        /// <summary>
        /// An administrative method to allow the founder of a group or clan to give up their position to another admin permanently.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="founderIdNew">The new founder for this group. Must already be a group admin.</param>
        /// <param name="groupId">The target group id.</param>
        /// <param name="membershipType">Membership type of the provided founderIdNew.</param>
        /// <returns>InlineResponse20017</returns>
        InlineResponse20017 GroupV2AbdicateFoundership(NancyContext context, long? founderIdNew, long? groupId, int? membershipType);

        /// <summary>
        /// Add a new optional conversation/chat channel. Requires admin permissions to the group.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="groupId">Group ID of the group to edit.</param>
        /// <returns>InlineResponse20012</returns>
        InlineResponse20012 GroupV2AddOptionalConversation(NancyContext context, long? groupId);

        /// <summary>
        /// Approve all of the pending users for the given group.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="groupId">ID of the group.</param>
        /// <returns>InlineResponse20027</returns>
        InlineResponse20027 GroupV2ApproveAllPending(NancyContext context, long? groupId);

        /// <summary>
        /// Approve the given membershipId to join the group/clan as long as they have applied.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="groupId">ID of the group.</param>
        /// <param name="membershipId">The membership id being approved.</param>
        /// <param name="membershipType">Membership type of the supplied membership ID.</param>
        /// <returns>InlineResponse20017</returns>
        InlineResponse20017 GroupV2ApprovePending(NancyContext context, long? groupId, long? membershipId, int? membershipType);

        /// <summary>
        /// Approve all of the pending users for the given group.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="groupId">ID of the group.</param>
        /// <returns>InlineResponse20027</returns>
        InlineResponse20027 GroupV2ApprovePendingForList(NancyContext context, long? groupId);

        /// <summary>
        /// Bans the requested member from the requested group for the specified period of time.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="groupId">Group ID that has the member to ban.</param>
        /// <param name="membershipId">Membership ID of the member to ban from the group.</param>
        /// <param name="membershipType">Membership type of the provided membership ID.</param>
        /// <returns>InlineResponse20022</returns>
        InlineResponse20022 GroupV2BanMember(NancyContext context, long? groupId, long? membershipId, int? membershipType);

        /// <summary>
        /// Deny all of the pending users for the given group.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="groupId">ID of the group.</param>
        /// <returns>InlineResponse20027</returns>
        InlineResponse20027 GroupV2DenyAllPending(NancyContext context, long? groupId);

        /// <summary>
        /// Deny all of the pending users for the given group that match the passed-in .
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="groupId">ID of the group.</param>
        /// <returns>InlineResponse20027</returns>
        InlineResponse20027 GroupV2DenyPendingForList(NancyContext context, long? groupId);

        /// <summary>
        /// Edit an existing group&#39;s clan banner. You must have suitable permissions in the group to perform this operation. All fields are required.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="groupId">Group ID of the group to edit.</param>
        /// <returns>InlineResponse20022</returns>
        InlineResponse20022 GroupV2EditClanBanner(NancyContext context, long? groupId);

        /// <summary>
        /// Edit group options only available to a founder. You must have suitable permissions in the group to perform this operation.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="groupId">Group ID of the group to edit.</param>
        /// <returns>InlineResponse20022</returns>
        InlineResponse20022 GroupV2EditFounderOptions(NancyContext context, long? groupId);

        /// <summary>
        /// Edit an existing group. You must have suitable permissions in the group to perform this operation. This latest revision will only edit the fields you pass in - pass null for properties you want to leave unaltered.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="groupId">Group ID of the group to edit.</param>
        /// <returns>InlineResponse20022</returns>
        InlineResponse20022 GroupV2EditGroup(NancyContext context, long? groupId);

        /// <summary>
        /// Edit the membership type of a given member. You must have suitable permissions in the group to perform this operation.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="groupId">ID of the group to which the member belongs.</param>
        /// <param name="membershipId">Membership ID to modify.</param>
        /// <param name="membershipType">Membership type of the provide membership ID.</param>
        /// <param name="memberType">New membertype for the specified member.</param>
        /// <returns>InlineResponse20022</returns>
        InlineResponse20022 GroupV2EditGroupMembership(NancyContext context, long? groupId, long? membershipId, int? membershipType, int? memberType);

        /// <summary>
        /// Edit the settings of an optional conversation/chat channel. Requires admin permissions to the group.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="conversationId">Conversation Id of the channel being edited.</param>
        /// <param name="groupId">Group ID of the group to edit.</param>
        /// <returns>InlineResponse20012</returns>
        InlineResponse20012 GroupV2EditOptionalConversation(NancyContext context, long? conversationId, long? groupId);

        /// <summary>
        /// Get the list of members in a given group who are of admin level or higher.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="currentpage">Page number (starting with 1). Each page has a fixed size of 50 items per page.</param>
        /// <param name="groupId">The ID of the group.</param>
        /// <returns>InlineResponse20023</returns>
        InlineResponse20023 GroupV2GetAdminsAndFounderOfGroup(NancyContext context, int? currentpage, long? groupId);

        /// <summary>
        /// Returns a list of all available group avatars for the signed-in user.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <returns>InlineResponse20015</returns>
        InlineResponse20015 GroupV2GetAvailableAvatars(NancyContext context);

        /// <summary>
        /// Returns a list of all available group themes.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <returns>InlineResponse20016</returns>
        InlineResponse20016 GroupV2GetAvailableThemes(NancyContext context);

        /// <summary>
        /// Get the list of banned members in a given group. Only accessible to group Admins and above. Not applicable to all groups. Check group features.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="currentpage">Page number (starting with 1). Each page has a fixed size of 50 entries.</param>
        /// <param name="groupId">Group ID whose banned members you are fetching</param>
        /// <returns>InlineResponse20025</returns>
        InlineResponse20025 GroupV2GetBannedMembersOfGroup(NancyContext context, int? currentpage, long? groupId);

        /// <summary>
        /// Get information about a specific group of the given ID.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="groupId">Requested group&#39;s id.</param>
        /// <returns>InlineResponse20020</returns>
        InlineResponse20020 GroupV2GetGroup(NancyContext context, long? groupId);

        /// <summary>
        /// Get information about a specific group with the given name and type.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="groupName">Exact name of the group to find.</param>
        /// <param name="groupType">Type of group to find.</param>
        /// <returns>InlineResponse20020</returns>
        InlineResponse20020 GroupV2GetGroupByName(NancyContext context, string groupName, int? groupType);

        /// <summary>
        /// Get information about a specific group with the given name and type. The POST version.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <returns>InlineResponse20020</returns>
        InlineResponse20020 GroupV2GetGroupByNameV2(NancyContext context);

        /// <summary>
        /// Gets a list of available optional conversation channels and their settings.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="groupId">Requested group&#39;s id.</param>
        /// <returns>InlineResponse20021</returns>
        InlineResponse20021 GroupV2GetGroupOptionalConversations(NancyContext context, long? groupId);

        /// <summary>
        /// Get information about the groups that a given member has joined.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="filter">Filter apply to list of joined groups.</param>
        /// <param name="groupType">Type of group the supplied member founded.</param>
        /// <param name="membershipId">Membership ID to for which to find founded groups.</param>
        /// <param name="membershipType">Membership type of the supplied membership ID.</param>
        /// <returns>InlineResponse20028</returns>
        InlineResponse20028 GroupV2GetGroupsForMember(NancyContext context, int? filter, int? groupType, long? membershipId, int? membershipType);

        /// <summary>
        /// Get the list of users who have been invited into the group.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="currentpage">Page number (starting with 1). Each page has a fixed size of 50 items per page.</param>
        /// <param name="groupId">ID of the group.</param>
        /// <returns>InlineResponse20026</returns>
        InlineResponse20026 GroupV2GetInvitedIndividuals(NancyContext context, int? currentpage, long? groupId);

        /// <summary>
        /// Get the list of members in a given group.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="currentpage">Page number (starting with 1). Each page has a fixed size of 50 items per page.</param>
        /// <param name="groupId">The ID of the group.</param>
        /// <param name="memberType">Filter out other member types. Use None for all members. (optional)</param>
        /// <param name="nameSearch">The name fragment upon which a search should be executed for members with matching display or unique names. (optional)</param>
        /// <returns>InlineResponse20023</returns>
        InlineResponse20023 GroupV2GetMembersOfGroup(NancyContext context, int? currentpage, long? groupId, int? memberType, string nameSearch);

        /// <summary>
        /// Get the list of users who are awaiting a decision on their application to join a given group. Modified to include application info.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="currentpage">Page number (starting with 1). Each page has a fixed size of 50 items per page.</param>
        /// <param name="groupId">ID of the group.</param>
        /// <returns>InlineResponse20026</returns>
        InlineResponse20026 GroupV2GetPendingMemberships(NancyContext context, int? currentpage, long? groupId);

        /// <summary>
        /// Get information about the groups that a given member has applied to or been invited to.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="filter">Filter apply to list of potential joined groups.</param>
        /// <param name="groupType">Type of group the supplied member applied.</param>
        /// <param name="membershipId">Membership ID to for which to find applied groups.</param>
        /// <param name="membershipType">Membership type of the supplied membership ID.</param>
        /// <returns>InlineResponse20030</returns>
        InlineResponse20030 GroupV2GetPotentialGroupsForMember(NancyContext context, int? filter, int? groupType, long? membershipId, int? membershipType);

        /// <summary>
        /// Gets groups recommended for you based on the groups to whom those you follow belong.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="createDateRange">Requested range in which to pull recommended groups</param>
        /// <param name="groupType">Type of groups requested</param>
        /// <returns>InlineResponse20018</returns>
        InlineResponse20018 GroupV2GetRecommendedGroups(NancyContext context, int? createDateRange, int? groupType);

        /// <summary>
        /// Gets the state of the user&#39;s clan invite preferences for a particular membership type - true if they wish to be invited to clans, false otherwise.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="mType">The Destiny membership type of the account we wish to access settings.</param>
        /// <returns>InlineResponse20017</returns>
        InlineResponse20017 GroupV2GetUserClanInviteSetting(NancyContext context, int? mType);

        /// <summary>
        /// Search for Groups.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <returns>InlineResponse20019</returns>
        InlineResponse20019 GroupV2GroupSearch(NancyContext context);

        /// <summary>
        /// Invite a user to join this group.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="groupId">ID of the group you would like to join.</param>
        /// <param name="membershipId">Membership id of the account being invited.</param>
        /// <param name="membershipType">MembershipType of the account being invited.</param>
        /// <returns>InlineResponse20031</returns>
        InlineResponse20031 GroupV2IndividualGroupInvite(NancyContext context, long? groupId, long? membershipId, int? membershipType);

        /// <summary>
        /// Cancels a pending invitation to join a group.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="groupId">ID of the group you would like to join.</param>
        /// <param name="membershipId">Membership id of the account being cancelled.</param>
        /// <param name="membershipType">MembershipType of the account being cancelled.</param>
        /// <returns>InlineResponse20031</returns>
        InlineResponse20031 GroupV2IndividualGroupInviteCancel(NancyContext context, long? groupId, long? membershipId, int? membershipType);

        /// <summary>
        /// Kick a member from the given group, forcing them to reapply if they wish to re-join the group. You must have suitable permissions in the group to perform this operation.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="groupId">Group ID to kick the user from.</param>
        /// <param name="membershipId">Membership ID to kick.</param>
        /// <param name="membershipType">Membership type of the provided membership ID.</param>
        /// <returns>InlineResponse20024</returns>
        InlineResponse20024 GroupV2KickMember(NancyContext context, long? groupId, long? membershipId, int? membershipType);

        /// <summary>
        /// Allows a founder to manually recover a group they can see in game but not on bungie.net
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="groupType">Type of group the supplied member founded.</param>
        /// <param name="membershipId">Membership ID to for which to find founded groups.</param>
        /// <param name="membershipType">Membership type of the supplied membership ID.</param>
        /// <returns>InlineResponse20029</returns>
        InlineResponse20029 GroupV2RecoverGroupForFounder(NancyContext context, int? groupType, long? membershipId, int? membershipType);

        /// <summary>
        /// Unbans the requested member, allowing them to re-apply for membership.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="groupId"></param>
        /// <param name="membershipId">Membership ID of the member to unban from the group</param>
        /// <param name="membershipType">Membership type of the provided membership ID.</param>
        /// <returns>InlineResponse20022</returns>
        InlineResponse20022 GroupV2UnbanMember(NancyContext context, long? groupId, long? membershipId, int? membershipType);
    }

    /// <summary>
    /// Abstraction of GroupV2Service.
    /// </summary>
    public abstract class AbstractGroupV2Service: GroupV2Service
    {
        public virtual InlineResponse20017 GroupV2AbdicateFoundership(NancyContext context, long? founderIdNew, long? groupId, int? membershipType)
        {
            return GroupV2AbdicateFoundership(founderIdNew, groupId, membershipType);
        }

        public virtual InlineResponse20012 GroupV2AddOptionalConversation(NancyContext context, long? groupId)
        {
            return GroupV2AddOptionalConversation(groupId);
        }

        public virtual InlineResponse20027 GroupV2ApproveAllPending(NancyContext context, long? groupId)
        {
            return GroupV2ApproveAllPending(groupId);
        }

        public virtual InlineResponse20017 GroupV2ApprovePending(NancyContext context, long? groupId, long? membershipId, int? membershipType)
        {
            return GroupV2ApprovePending(groupId, membershipId, membershipType);
        }

        public virtual InlineResponse20027 GroupV2ApprovePendingForList(NancyContext context, long? groupId)
        {
            return GroupV2ApprovePendingForList(groupId);
        }

        public virtual InlineResponse20022 GroupV2BanMember(NancyContext context, long? groupId, long? membershipId, int? membershipType)
        {
            return GroupV2BanMember(groupId, membershipId, membershipType);
        }

        public virtual InlineResponse20027 GroupV2DenyAllPending(NancyContext context, long? groupId)
        {
            return GroupV2DenyAllPending(groupId);
        }

        public virtual InlineResponse20027 GroupV2DenyPendingForList(NancyContext context, long? groupId)
        {
            return GroupV2DenyPendingForList(groupId);
        }

        public virtual InlineResponse20022 GroupV2EditClanBanner(NancyContext context, long? groupId)
        {
            return GroupV2EditClanBanner(groupId);
        }

        public virtual InlineResponse20022 GroupV2EditFounderOptions(NancyContext context, long? groupId)
        {
            return GroupV2EditFounderOptions(groupId);
        }

        public virtual InlineResponse20022 GroupV2EditGroup(NancyContext context, long? groupId)
        {
            return GroupV2EditGroup(groupId);
        }

        public virtual InlineResponse20022 GroupV2EditGroupMembership(NancyContext context, long? groupId, long? membershipId, int? membershipType, int? memberType)
        {
            return GroupV2EditGroupMembership(groupId, membershipId, membershipType, memberType);
        }

        public virtual InlineResponse20012 GroupV2EditOptionalConversation(NancyContext context, long? conversationId, long? groupId)
        {
            return GroupV2EditOptionalConversation(conversationId, groupId);
        }

        public virtual InlineResponse20023 GroupV2GetAdminsAndFounderOfGroup(NancyContext context, int? currentpage, long? groupId)
        {
            return GroupV2GetAdminsAndFounderOfGroup(currentpage, groupId);
        }

        public virtual InlineResponse20015 GroupV2GetAvailableAvatars(NancyContext context)
        {
            return GroupV2GetAvailableAvatars();
        }

        public virtual InlineResponse20016 GroupV2GetAvailableThemes(NancyContext context)
        {
            return GroupV2GetAvailableThemes();
        }

        public virtual InlineResponse20025 GroupV2GetBannedMembersOfGroup(NancyContext context, int? currentpage, long? groupId)
        {
            return GroupV2GetBannedMembersOfGroup(currentpage, groupId);
        }

        public virtual InlineResponse20020 GroupV2GetGroup(NancyContext context, long? groupId)
        {
            return GroupV2GetGroup(groupId);
        }

        public virtual InlineResponse20020 GroupV2GetGroupByName(NancyContext context, string groupName, int? groupType)
        {
            return GroupV2GetGroupByName(groupName, groupType);
        }

        public virtual InlineResponse20020 GroupV2GetGroupByNameV2(NancyContext context)
        {
            return GroupV2GetGroupByNameV2();
        }

        public virtual InlineResponse20021 GroupV2GetGroupOptionalConversations(NancyContext context, long? groupId)
        {
            return GroupV2GetGroupOptionalConversations(groupId);
        }

        public virtual InlineResponse20028 GroupV2GetGroupsForMember(NancyContext context, int? filter, int? groupType, long? membershipId, int? membershipType)
        {
            return GroupV2GetGroupsForMember(filter, groupType, membershipId, membershipType);
        }

        public virtual InlineResponse20026 GroupV2GetInvitedIndividuals(NancyContext context, int? currentpage, long? groupId)
        {
            return GroupV2GetInvitedIndividuals(currentpage, groupId);
        }

        public virtual InlineResponse20023 GroupV2GetMembersOfGroup(NancyContext context, int? currentpage, long? groupId, int? memberType, string nameSearch)
        {
            return GroupV2GetMembersOfGroup(currentpage, groupId, memberType, nameSearch);
        }

        public virtual InlineResponse20026 GroupV2GetPendingMemberships(NancyContext context, int? currentpage, long? groupId)
        {
            return GroupV2GetPendingMemberships(currentpage, groupId);
        }

        public virtual InlineResponse20030 GroupV2GetPotentialGroupsForMember(NancyContext context, int? filter, int? groupType, long? membershipId, int? membershipType)
        {
            return GroupV2GetPotentialGroupsForMember(filter, groupType, membershipId, membershipType);
        }

        public virtual InlineResponse20018 GroupV2GetRecommendedGroups(NancyContext context, int? createDateRange, int? groupType)
        {
            return GroupV2GetRecommendedGroups(createDateRange, groupType);
        }

        public virtual InlineResponse20017 GroupV2GetUserClanInviteSetting(NancyContext context, int? mType)
        {
            return GroupV2GetUserClanInviteSetting(mType);
        }

        public virtual InlineResponse20019 GroupV2GroupSearch(NancyContext context)
        {
            return GroupV2GroupSearch();
        }

        public virtual InlineResponse20031 GroupV2IndividualGroupInvite(NancyContext context, long? groupId, long? membershipId, int? membershipType)
        {
            return GroupV2IndividualGroupInvite(groupId, membershipId, membershipType);
        }

        public virtual InlineResponse20031 GroupV2IndividualGroupInviteCancel(NancyContext context, long? groupId, long? membershipId, int? membershipType)
        {
            return GroupV2IndividualGroupInviteCancel(groupId, membershipId, membershipType);
        }

        public virtual InlineResponse20024 GroupV2KickMember(NancyContext context, long? groupId, long? membershipId, int? membershipType)
        {
            return GroupV2KickMember(groupId, membershipId, membershipType);
        }

        public virtual InlineResponse20029 GroupV2RecoverGroupForFounder(NancyContext context, int? groupType, long? membershipId, int? membershipType)
        {
            return GroupV2RecoverGroupForFounder(groupType, membershipId, membershipType);
        }

        public virtual InlineResponse20022 GroupV2UnbanMember(NancyContext context, long? groupId, long? membershipId, int? membershipType)
        {
            return GroupV2UnbanMember(groupId, membershipId, membershipType);
        }

        protected abstract InlineResponse20017 GroupV2AbdicateFoundership(long? founderIdNew, long? groupId, int? membershipType);

        protected abstract InlineResponse20012 GroupV2AddOptionalConversation(long? groupId);

        protected abstract InlineResponse20027 GroupV2ApproveAllPending(long? groupId);

        protected abstract InlineResponse20017 GroupV2ApprovePending(long? groupId, long? membershipId, int? membershipType);

        protected abstract InlineResponse20027 GroupV2ApprovePendingForList(long? groupId);

        protected abstract InlineResponse20022 GroupV2BanMember(long? groupId, long? membershipId, int? membershipType);

        protected abstract InlineResponse20027 GroupV2DenyAllPending(long? groupId);

        protected abstract InlineResponse20027 GroupV2DenyPendingForList(long? groupId);

        protected abstract InlineResponse20022 GroupV2EditClanBanner(long? groupId);

        protected abstract InlineResponse20022 GroupV2EditFounderOptions(long? groupId);

        protected abstract InlineResponse20022 GroupV2EditGroup(long? groupId);

        protected abstract InlineResponse20022 GroupV2EditGroupMembership(long? groupId, long? membershipId, int? membershipType, int? memberType);

        protected abstract InlineResponse20012 GroupV2EditOptionalConversation(long? conversationId, long? groupId);

        protected abstract InlineResponse20023 GroupV2GetAdminsAndFounderOfGroup(int? currentpage, long? groupId);

        protected abstract InlineResponse20015 GroupV2GetAvailableAvatars();

        protected abstract InlineResponse20016 GroupV2GetAvailableThemes();

        protected abstract InlineResponse20025 GroupV2GetBannedMembersOfGroup(int? currentpage, long? groupId);

        protected abstract InlineResponse20020 GroupV2GetGroup(long? groupId);

        protected abstract InlineResponse20020 GroupV2GetGroupByName(string groupName, int? groupType);

        protected abstract InlineResponse20020 GroupV2GetGroupByNameV2();

        protected abstract InlineResponse20021 GroupV2GetGroupOptionalConversations(long? groupId);

        protected abstract InlineResponse20028 GroupV2GetGroupsForMember(int? filter, int? groupType, long? membershipId, int? membershipType);

        protected abstract InlineResponse20026 GroupV2GetInvitedIndividuals(int? currentpage, long? groupId);

        protected abstract InlineResponse20023 GroupV2GetMembersOfGroup(int? currentpage, long? groupId, int? memberType, string nameSearch);

        protected abstract InlineResponse20026 GroupV2GetPendingMemberships(int? currentpage, long? groupId);

        protected abstract InlineResponse20030 GroupV2GetPotentialGroupsForMember(int? filter, int? groupType, long? membershipId, int? membershipType);

        protected abstract InlineResponse20018 GroupV2GetRecommendedGroups(int? createDateRange, int? groupType);

        protected abstract InlineResponse20017 GroupV2GetUserClanInviteSetting(int? mType);

        protected abstract InlineResponse20019 GroupV2GroupSearch();

        protected abstract InlineResponse20031 GroupV2IndividualGroupInvite(long? groupId, long? membershipId, int? membershipType);

        protected abstract InlineResponse20031 GroupV2IndividualGroupInviteCancel(long? groupId, long? membershipId, int? membershipType);

        protected abstract InlineResponse20024 GroupV2KickMember(long? groupId, long? membershipId, int? membershipType);

        protected abstract InlineResponse20029 GroupV2RecoverGroupForFounder(int? groupType, long? membershipId, int? membershipType);

        protected abstract InlineResponse20022 GroupV2UnbanMember(long? groupId, long? membershipId, int? membershipType);
    }

}
