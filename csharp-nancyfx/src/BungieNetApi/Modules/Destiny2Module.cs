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
    /// Module processing requests of Destiny2 domain.
    /// </summary>
    public sealed class Destiny2Module : NancyModule
    {
        /// <summary>
        /// Sets up HTTP methods mappings.
        /// </summary>
        /// <param name="service">Service handling requests</param>
        public Destiny2Module(Destiny2Service service) : base("/Platform")
        { 
            Get["/Destiny2/Awa/GetActionToken/{correlationId}/"] = parameters =>
            {
                var correlationId = Parameters.ValueOf<string>(parameters, Context.Request, "correlationId", ParameterType.Path);
                Preconditions.IsNotNull(correlationId, "Required parameter: 'correlationId' is missing at 'Destiny2AwaGetActionToken'");
                
                return service.Destiny2AwaGetActionToken(Context, correlationId);
            };

            Post["/Destiny2/Awa/Initialize/"] = parameters =>
            {
                
                return service.Destiny2AwaInitializeRequest(Context);
            };

            Post["/Destiny2/Awa/AwaProvideAuthorizationResult/"] = parameters =>
            {
                
                return service.Destiny2AwaProvideAuthorizationResult(Context);
            };

            Post["/Destiny2/Actions/Items/EquipItem/"] = parameters =>
            {
                
                return service.Destiny2EquipItem(Context);
            };

            Post["/Destiny2/Actions/Items/EquipItems/"] = parameters =>
            {
                
                return service.Destiny2EquipItems(Context);
            };

            Get["/Destiny2/{membershipType}/Account/{destinyMembershipId}/Character/{characterId}/Stats/Activities/"] = parameters =>
            {
                var characterId = Parameters.ValueOf<long?>(parameters, Context.Request, "characterId", ParameterType.Path);
                var destinyMembershipId = Parameters.ValueOf<long?>(parameters, Context.Request, "destinyMembershipId", ParameterType.Path);
                var membershipType = Parameters.ValueOf<int?>(parameters, Context.Request, "membershipType", ParameterType.Path);
                var count = Parameters.ValueOf<int?>(parameters, Context.Request, "count", ParameterType.Query);
                var mode = Parameters.ValueOf<int?>(parameters, Context.Request, "mode", ParameterType.Query);
                var page = Parameters.ValueOf<int?>(parameters, Context.Request, "page", ParameterType.Query);
                Preconditions.IsNotNull(characterId, "Required parameter: 'characterId' is missing at 'Destiny2GetActivityHistory'");
                
                Preconditions.IsNotNull(destinyMembershipId, "Required parameter: 'destinyMembershipId' is missing at 'Destiny2GetActivityHistory'");
                
                Preconditions.IsNotNull(membershipType, "Required parameter: 'membershipType' is missing at 'Destiny2GetActivityHistory'");
                
                return service.Destiny2GetActivityHistory(Context, characterId, destinyMembershipId, membershipType, count, mode, page);
            };

            Get["/Destiny2/{membershipType}/Profile/{destinyMembershipId}/Character/{characterId}/"] = parameters =>
            {
                var characterId = Parameters.ValueOf<long?>(parameters, Context.Request, "characterId", ParameterType.Path);
                var destinyMembershipId = Parameters.ValueOf<long?>(parameters, Context.Request, "destinyMembershipId", ParameterType.Path);
                var membershipType = Parameters.ValueOf<int?>(parameters, Context.Request, "membershipType", ParameterType.Path);
                var components = Parameters.ValueOf<List<int?>>(parameters, Context.Request, "components", ParameterType.Query);
                Preconditions.IsNotNull(characterId, "Required parameter: 'characterId' is missing at 'Destiny2GetCharacter'");
                
                Preconditions.IsNotNull(destinyMembershipId, "Required parameter: 'destinyMembershipId' is missing at 'Destiny2GetCharacter'");
                
                Preconditions.IsNotNull(membershipType, "Required parameter: 'membershipType' is missing at 'Destiny2GetCharacter'");
                
                return service.Destiny2GetCharacter(Context, characterId, destinyMembershipId, membershipType, components);
            };

            Get["/Destiny2/Stats/AggregateClanStats/{groupId}/"] = parameters =>
            {
                var groupId = Parameters.ValueOf<long?>(parameters, Context.Request, "groupId", ParameterType.Path);
                var modes = Parameters.ValueOf<string>(parameters, Context.Request, "modes", ParameterType.Query);
                Preconditions.IsNotNull(groupId, "Required parameter: 'groupId' is missing at 'Destiny2GetClanAggregateStats'");
                
                return service.Destiny2GetClanAggregateStats(Context, groupId, modes);
            };

            Get["/Destiny2/Stats/Leaderboards/Clans/{groupId}/"] = parameters =>
            {
                var groupId = Parameters.ValueOf<long?>(parameters, Context.Request, "groupId", ParameterType.Path);
                var maxtop = Parameters.ValueOf<int?>(parameters, Context.Request, "maxtop", ParameterType.Query);
                var modes = Parameters.ValueOf<string>(parameters, Context.Request, "modes", ParameterType.Query);
                var statid = Parameters.ValueOf<string>(parameters, Context.Request, "statid", ParameterType.Query);
                Preconditions.IsNotNull(groupId, "Required parameter: 'groupId' is missing at 'Destiny2GetClanLeaderboards'");
                
                return service.Destiny2GetClanLeaderboards(Context, groupId, maxtop, modes, statid);
            };

            Get["/Destiny2/Clan/{groupId}/WeeklyRewardState/"] = parameters =>
            {
                var groupId = Parameters.ValueOf<long?>(parameters, Context.Request, "groupId", ParameterType.Path);
                Preconditions.IsNotNull(groupId, "Required parameter: 'groupId' is missing at 'Destiny2GetClanWeeklyRewardState'");
                
                return service.Destiny2GetClanWeeklyRewardState(Context, groupId);
            };

            Get["/Destiny2/{membershipType}/Profile/{destinyMembershipId}/Character/{characterId}/Collectibles/{collectiblePresentationNodeHash}/"] = parameters =>
            {
                var characterId = Parameters.ValueOf<long?>(parameters, Context.Request, "characterId", ParameterType.Path);
                var collectiblePresentationNodeHash = Parameters.ValueOf<int?>(parameters, Context.Request, "collectiblePresentationNodeHash", ParameterType.Path);
                var destinyMembershipId = Parameters.ValueOf<long?>(parameters, Context.Request, "destinyMembershipId", ParameterType.Path);
                var membershipType = Parameters.ValueOf<int?>(parameters, Context.Request, "membershipType", ParameterType.Path);
                var components = Parameters.ValueOf<List<int?>>(parameters, Context.Request, "components", ParameterType.Query);
                Preconditions.IsNotNull(characterId, "Required parameter: 'characterId' is missing at 'Destiny2GetCollectibleNodeDetails'");
                
                Preconditions.IsNotNull(collectiblePresentationNodeHash, "Required parameter: 'collectiblePresentationNodeHash' is missing at 'Destiny2GetCollectibleNodeDetails'");
                
                Preconditions.IsNotNull(destinyMembershipId, "Required parameter: 'destinyMembershipId' is missing at 'Destiny2GetCollectibleNodeDetails'");
                
                Preconditions.IsNotNull(membershipType, "Required parameter: 'membershipType' is missing at 'Destiny2GetCollectibleNodeDetails'");
                
                return service.Destiny2GetCollectibleNodeDetails(Context, characterId, collectiblePresentationNodeHash, destinyMembershipId, membershipType, components);
            };

            Get["/Destiny2/{membershipType}/Account/{destinyMembershipId}/Character/{characterId}/Stats/AggregateActivityStats/"] = parameters =>
            {
                var characterId = Parameters.ValueOf<long?>(parameters, Context.Request, "characterId", ParameterType.Path);
                var destinyMembershipId = Parameters.ValueOf<long?>(parameters, Context.Request, "destinyMembershipId", ParameterType.Path);
                var membershipType = Parameters.ValueOf<int?>(parameters, Context.Request, "membershipType", ParameterType.Path);
                Preconditions.IsNotNull(characterId, "Required parameter: 'characterId' is missing at 'Destiny2GetDestinyAggregateActivityStats'");
                
                Preconditions.IsNotNull(destinyMembershipId, "Required parameter: 'destinyMembershipId' is missing at 'Destiny2GetDestinyAggregateActivityStats'");
                
                Preconditions.IsNotNull(membershipType, "Required parameter: 'membershipType' is missing at 'Destiny2GetDestinyAggregateActivityStats'");
                
                return service.Destiny2GetDestinyAggregateActivityStats(Context, characterId, destinyMembershipId, membershipType);
            };

            Get["/Destiny2/Manifest/{entityType}/{hashIdentifier}/"] = parameters =>
            {
                var entityType = Parameters.ValueOf<string>(parameters, Context.Request, "entityType", ParameterType.Path);
                var hashIdentifier = Parameters.ValueOf<int?>(parameters, Context.Request, "hashIdentifier", ParameterType.Path);
                Preconditions.IsNotNull(entityType, "Required parameter: 'entityType' is missing at 'Destiny2GetDestinyEntityDefinition'");
                
                Preconditions.IsNotNull(hashIdentifier, "Required parameter: 'hashIdentifier' is missing at 'Destiny2GetDestinyEntityDefinition'");
                
                return service.Destiny2GetDestinyEntityDefinition(Context, entityType, hashIdentifier);
            };

            Get["/Destiny2/Manifest/"] = parameters =>
            {
                
                return service.Destiny2GetDestinyManifest(Context);
            };

            Get["/Destiny2/{membershipType}/Account/{destinyMembershipId}/Character/{characterId}/Stats/"] = parameters =>
            {
                var characterId = Parameters.ValueOf<long?>(parameters, Context.Request, "characterId", ParameterType.Path);
                var destinyMembershipId = Parameters.ValueOf<long?>(parameters, Context.Request, "destinyMembershipId", ParameterType.Path);
                var membershipType = Parameters.ValueOf<int?>(parameters, Context.Request, "membershipType", ParameterType.Path);
                var dayend = Parameters.ValueOf<DateTime?>(parameters, Context.Request, "dayend", ParameterType.Query);
                var daystart = Parameters.ValueOf<DateTime?>(parameters, Context.Request, "daystart", ParameterType.Query);
                var groups = Parameters.ValueOf<List<int?>>(parameters, Context.Request, "groups", ParameterType.Query);
                var modes = Parameters.ValueOf<List<int?>>(parameters, Context.Request, "modes", ParameterType.Query);
                var periodType = Parameters.ValueOf<int?>(parameters, Context.Request, "periodType", ParameterType.Query);
                Preconditions.IsNotNull(characterId, "Required parameter: 'characterId' is missing at 'Destiny2GetHistoricalStats'");
                
                Preconditions.IsNotNull(destinyMembershipId, "Required parameter: 'destinyMembershipId' is missing at 'Destiny2GetHistoricalStats'");
                
                Preconditions.IsNotNull(membershipType, "Required parameter: 'membershipType' is missing at 'Destiny2GetHistoricalStats'");
                
                return service.Destiny2GetHistoricalStats(Context, characterId, destinyMembershipId, membershipType, dayend, daystart, groups, modes, periodType);
            };

            Get["/Destiny2/Stats/Definition/"] = parameters =>
            {
                
                return service.Destiny2GetHistoricalStatsDefinition(Context);
            };

            Get["/Destiny2/{membershipType}/Account/{destinyMembershipId}/Stats/"] = parameters =>
            {
                var destinyMembershipId = Parameters.ValueOf<long?>(parameters, Context.Request, "destinyMembershipId", ParameterType.Path);
                var membershipType = Parameters.ValueOf<int?>(parameters, Context.Request, "membershipType", ParameterType.Path);
                var groups = Parameters.ValueOf<List<int?>>(parameters, Context.Request, "groups", ParameterType.Query);
                Preconditions.IsNotNull(destinyMembershipId, "Required parameter: 'destinyMembershipId' is missing at 'Destiny2GetHistoricalStatsForAccount'");
                
                Preconditions.IsNotNull(membershipType, "Required parameter: 'membershipType' is missing at 'Destiny2GetHistoricalStatsForAccount'");
                
                return service.Destiny2GetHistoricalStatsForAccount(Context, destinyMembershipId, membershipType, groups);
            };

            Get["/Destiny2/{membershipType}/Profile/{destinyMembershipId}/Item/{itemInstanceId}/"] = parameters =>
            {
                var destinyMembershipId = Parameters.ValueOf<long?>(parameters, Context.Request, "destinyMembershipId", ParameterType.Path);
                var itemInstanceId = Parameters.ValueOf<long?>(parameters, Context.Request, "itemInstanceId", ParameterType.Path);
                var membershipType = Parameters.ValueOf<int?>(parameters, Context.Request, "membershipType", ParameterType.Path);
                var components = Parameters.ValueOf<List<int?>>(parameters, Context.Request, "components", ParameterType.Query);
                Preconditions.IsNotNull(destinyMembershipId, "Required parameter: 'destinyMembershipId' is missing at 'Destiny2GetItem'");
                
                Preconditions.IsNotNull(itemInstanceId, "Required parameter: 'itemInstanceId' is missing at 'Destiny2GetItem'");
                
                Preconditions.IsNotNull(membershipType, "Required parameter: 'membershipType' is missing at 'Destiny2GetItem'");
                
                return service.Destiny2GetItem(Context, destinyMembershipId, itemInstanceId, membershipType, components);
            };

            Get["/Destiny2/{membershipType}/Account/{destinyMembershipId}/Stats/Leaderboards/"] = parameters =>
            {
                var destinyMembershipId = Parameters.ValueOf<long?>(parameters, Context.Request, "destinyMembershipId", ParameterType.Path);
                var membershipType = Parameters.ValueOf<int?>(parameters, Context.Request, "membershipType", ParameterType.Path);
                var maxtop = Parameters.ValueOf<int?>(parameters, Context.Request, "maxtop", ParameterType.Query);
                var modes = Parameters.ValueOf<string>(parameters, Context.Request, "modes", ParameterType.Query);
                var statid = Parameters.ValueOf<string>(parameters, Context.Request, "statid", ParameterType.Query);
                Preconditions.IsNotNull(destinyMembershipId, "Required parameter: 'destinyMembershipId' is missing at 'Destiny2GetLeaderboards'");
                
                Preconditions.IsNotNull(membershipType, "Required parameter: 'membershipType' is missing at 'Destiny2GetLeaderboards'");
                
                return service.Destiny2GetLeaderboards(Context, destinyMembershipId, membershipType, maxtop, modes, statid);
            };

            Get["/Destiny2/Stats/Leaderboards/{membershipType}/{destinyMembershipId}/{characterId}/"] = parameters =>
            {
                var characterId = Parameters.ValueOf<long?>(parameters, Context.Request, "characterId", ParameterType.Path);
                var destinyMembershipId = Parameters.ValueOf<long?>(parameters, Context.Request, "destinyMembershipId", ParameterType.Path);
                var membershipType = Parameters.ValueOf<int?>(parameters, Context.Request, "membershipType", ParameterType.Path);
                var maxtop = Parameters.ValueOf<int?>(parameters, Context.Request, "maxtop", ParameterType.Query);
                var modes = Parameters.ValueOf<string>(parameters, Context.Request, "modes", ParameterType.Query);
                var statid = Parameters.ValueOf<string>(parameters, Context.Request, "statid", ParameterType.Query);
                Preconditions.IsNotNull(characterId, "Required parameter: 'characterId' is missing at 'Destiny2GetLeaderboardsForCharacter'");
                
                Preconditions.IsNotNull(destinyMembershipId, "Required parameter: 'destinyMembershipId' is missing at 'Destiny2GetLeaderboardsForCharacter'");
                
                Preconditions.IsNotNull(membershipType, "Required parameter: 'membershipType' is missing at 'Destiny2GetLeaderboardsForCharacter'");
                
                return service.Destiny2GetLeaderboardsForCharacter(Context, characterId, destinyMembershipId, membershipType, maxtop, modes, statid);
            };

            Get["/Destiny2/{membershipType}/Profile/{membershipId}/LinkedProfiles/"] = parameters =>
            {
                var membershipId = Parameters.ValueOf<long?>(parameters, Context.Request, "membershipId", ParameterType.Path);
                var membershipType = Parameters.ValueOf<int?>(parameters, Context.Request, "membershipType", ParameterType.Path);
                var getAllMemberships = Parameters.ValueOf<bool?>(parameters, Context.Request, "getAllMemberships", ParameterType.Query);
                Preconditions.IsNotNull(membershipId, "Required parameter: 'membershipId' is missing at 'Destiny2GetLinkedProfiles'");
                
                Preconditions.IsNotNull(membershipType, "Required parameter: 'membershipType' is missing at 'Destiny2GetLinkedProfiles'");
                
                return service.Destiny2GetLinkedProfiles(Context, membershipId, membershipType, getAllMemberships);
            };

            Get["/Destiny2/Stats/PostGameCarnageReport/{activityId}/"] = parameters =>
            {
                var activityId = Parameters.ValueOf<long?>(parameters, Context.Request, "activityId", ParameterType.Path);
                Preconditions.IsNotNull(activityId, "Required parameter: 'activityId' is missing at 'Destiny2GetPostGameCarnageReport'");
                
                return service.Destiny2GetPostGameCarnageReport(Context, activityId);
            };

            Get["/Destiny2/{membershipType}/Profile/{destinyMembershipId}/"] = parameters =>
            {
                var destinyMembershipId = Parameters.ValueOf<long?>(parameters, Context.Request, "destinyMembershipId", ParameterType.Path);
                var membershipType = Parameters.ValueOf<int?>(parameters, Context.Request, "membershipType", ParameterType.Path);
                var components = Parameters.ValueOf<List<int?>>(parameters, Context.Request, "components", ParameterType.Query);
                Preconditions.IsNotNull(destinyMembershipId, "Required parameter: 'destinyMembershipId' is missing at 'Destiny2GetProfile'");
                
                Preconditions.IsNotNull(membershipType, "Required parameter: 'membershipType' is missing at 'Destiny2GetProfile'");
                
                return service.Destiny2GetProfile(Context, destinyMembershipId, membershipType, components);
            };

            Get["/Destiny2/Milestones/{milestoneHash}/Content/"] = parameters =>
            {
                var milestoneHash = Parameters.ValueOf<int?>(parameters, Context.Request, "milestoneHash", ParameterType.Path);
                Preconditions.IsNotNull(milestoneHash, "Required parameter: 'milestoneHash' is missing at 'Destiny2GetPublicMilestoneContent'");
                
                return service.Destiny2GetPublicMilestoneContent(Context, milestoneHash);
            };

            Get["/Destiny2/Milestones/"] = parameters =>
            {
                
                return service.Destiny2GetPublicMilestones(Context);
            };

            Get["/Destiny2//Vendors/"] = parameters =>
            {
                var components = Parameters.ValueOf<List<int?>>(parameters, Context.Request, "components", ParameterType.Query);
                return service.Destiny2GetPublicVendors(Context, components);
            };

            Get["/Destiny2/{membershipType}/Account/{destinyMembershipId}/Character/{characterId}/Stats/UniqueWeapons/"] = parameters =>
            {
                var characterId = Parameters.ValueOf<long?>(parameters, Context.Request, "characterId", ParameterType.Path);
                var destinyMembershipId = Parameters.ValueOf<long?>(parameters, Context.Request, "destinyMembershipId", ParameterType.Path);
                var membershipType = Parameters.ValueOf<int?>(parameters, Context.Request, "membershipType", ParameterType.Path);
                Preconditions.IsNotNull(characterId, "Required parameter: 'characterId' is missing at 'Destiny2GetUniqueWeaponHistory'");
                
                Preconditions.IsNotNull(destinyMembershipId, "Required parameter: 'destinyMembershipId' is missing at 'Destiny2GetUniqueWeaponHistory'");
                
                Preconditions.IsNotNull(membershipType, "Required parameter: 'membershipType' is missing at 'Destiny2GetUniqueWeaponHistory'");
                
                return service.Destiny2GetUniqueWeaponHistory(Context, characterId, destinyMembershipId, membershipType);
            };

            Get["/Destiny2/{membershipType}/Profile/{destinyMembershipId}/Character/{characterId}/Vendors/{vendorHash}/"] = parameters =>
            {
                var characterId = Parameters.ValueOf<long?>(parameters, Context.Request, "characterId", ParameterType.Path);
                var destinyMembershipId = Parameters.ValueOf<long?>(parameters, Context.Request, "destinyMembershipId", ParameterType.Path);
                var membershipType = Parameters.ValueOf<int?>(parameters, Context.Request, "membershipType", ParameterType.Path);
                var vendorHash = Parameters.ValueOf<int?>(parameters, Context.Request, "vendorHash", ParameterType.Path);
                var components = Parameters.ValueOf<List<int?>>(parameters, Context.Request, "components", ParameterType.Query);
                Preconditions.IsNotNull(characterId, "Required parameter: 'characterId' is missing at 'Destiny2GetVendor'");
                
                Preconditions.IsNotNull(destinyMembershipId, "Required parameter: 'destinyMembershipId' is missing at 'Destiny2GetVendor'");
                
                Preconditions.IsNotNull(membershipType, "Required parameter: 'membershipType' is missing at 'Destiny2GetVendor'");
                
                Preconditions.IsNotNull(vendorHash, "Required parameter: 'vendorHash' is missing at 'Destiny2GetVendor'");
                
                return service.Destiny2GetVendor(Context, characterId, destinyMembershipId, membershipType, vendorHash, components);
            };

            Get["/Destiny2/{membershipType}/Profile/{destinyMembershipId}/Character/{characterId}/Vendors/"] = parameters =>
            {
                var characterId = Parameters.ValueOf<long?>(parameters, Context.Request, "characterId", ParameterType.Path);
                var destinyMembershipId = Parameters.ValueOf<long?>(parameters, Context.Request, "destinyMembershipId", ParameterType.Path);
                var membershipType = Parameters.ValueOf<int?>(parameters, Context.Request, "membershipType", ParameterType.Path);
                var components = Parameters.ValueOf<List<int?>>(parameters, Context.Request, "components", ParameterType.Query);
                Preconditions.IsNotNull(characterId, "Required parameter: 'characterId' is missing at 'Destiny2GetVendors'");
                
                Preconditions.IsNotNull(destinyMembershipId, "Required parameter: 'destinyMembershipId' is missing at 'Destiny2GetVendors'");
                
                Preconditions.IsNotNull(membershipType, "Required parameter: 'membershipType' is missing at 'Destiny2GetVendors'");
                
                return service.Destiny2GetVendors(Context, characterId, destinyMembershipId, membershipType, components);
            };

            Post["/Destiny2/Actions/Items/InsertSocketPlug/"] = parameters =>
            {
                
                return service.Destiny2InsertSocketPlug(Context);
            };

            Post["/Destiny2/Actions/Items/PullFromPostmaster/"] = parameters =>
            {
                
                return service.Destiny2PullFromPostmaster(Context);
            };

            Post["/Destiny2/Stats/PostGameCarnageReport/{activityId}/Report/"] = parameters =>
            {
                var activityId = Parameters.ValueOf<long?>(parameters, Context.Request, "activityId", ParameterType.Path);
                Preconditions.IsNotNull(activityId, "Required parameter: 'activityId' is missing at 'Destiny2ReportOffensivePostGameCarnageReportPlayer'");
                
                return service.Destiny2ReportOffensivePostGameCarnageReportPlayer(Context, activityId);
            };

            Get["/Destiny2/Armory/Search/{type}/{searchTerm}/"] = parameters =>
            {
                var searchTerm = Parameters.ValueOf<string>(parameters, Context.Request, "searchTerm", ParameterType.Path);
                var type = Parameters.ValueOf<string>(parameters, Context.Request, "type", ParameterType.Path);
                var page = Parameters.ValueOf<int?>(parameters, Context.Request, "page", ParameterType.Query);
                Preconditions.IsNotNull(searchTerm, "Required parameter: 'searchTerm' is missing at 'Destiny2SearchDestinyEntities'");
                
                Preconditions.IsNotNull(type, "Required parameter: 'type' is missing at 'Destiny2SearchDestinyEntities'");
                
                return service.Destiny2SearchDestinyEntities(Context, searchTerm, type, page);
            };

            Get["/Destiny2/SearchDestinyPlayer/{membershipType}/{displayName}/"] = parameters =>
            {
                var displayName = Parameters.ValueOf<string>(parameters, Context.Request, "displayName", ParameterType.Path);
                var membershipType = Parameters.ValueOf<int?>(parameters, Context.Request, "membershipType", ParameterType.Path);
                var returnOriginalProfile = Parameters.ValueOf<bool?>(parameters, Context.Request, "returnOriginalProfile", ParameterType.Query);
                Preconditions.IsNotNull(displayName, "Required parameter: 'displayName' is missing at 'Destiny2SearchDestinyPlayer'");
                
                Preconditions.IsNotNull(membershipType, "Required parameter: 'membershipType' is missing at 'Destiny2SearchDestinyPlayer'");
                
                return service.Destiny2SearchDestinyPlayer(Context, displayName, membershipType, returnOriginalProfile);
            };

            Post["/Destiny2/Actions/Items/SetLockState/"] = parameters =>
            {
                
                return service.Destiny2SetItemLockState(Context);
            };

            Post["/Destiny2/Actions/Items/TransferItem/"] = parameters =>
            {
                
                return service.Destiny2TransferItem(Context);
            };
        }
    }

    /// <summary>
    /// Service handling Destiny2 requests.
    /// </summary>
    public interface Destiny2Service
    {
        /// <summary>
        /// Returns the action token if user approves the request.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="correlationId">The identifier for the advanced write action request.</param>
        /// <returns>InlineResponse20060</returns>
        InlineResponse20060 Destiny2AwaGetActionToken(NancyContext context, string correlationId);

        /// <summary>
        /// Initialize a request to perform an advanced write action.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <returns>InlineResponse20059</returns>
        InlineResponse20059 Destiny2AwaInitializeRequest(NancyContext context);

        /// <summary>
        /// Provide the result of the user interaction. Called by the Bungie Destiny App to approve or reject a request.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <returns>InlineResponse20022</returns>
        InlineResponse20022 Destiny2AwaProvideAuthorizationResult(NancyContext context);

        /// <summary>
        /// Equip an item. You must have a valid Destiny Account, and either be in a social space, in orbit, or offline.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <returns>InlineResponse20022</returns>
        InlineResponse20022 Destiny2EquipItem(NancyContext context);

        /// <summary>
        /// Equip a list of items by itemInstanceIds. You must have a valid Destiny Account, and either be in a social space, in orbit, or offline. Any items not found on your character will be ignored.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <returns>InlineResponse20045</returns>
        InlineResponse20045 Destiny2EquipItems(NancyContext context);

        /// <summary>
        /// Gets activity history stats for indicated character.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="characterId">The id of the character to retrieve.</param>
        /// <param name="destinyMembershipId">The Destiny membershipId of the user to retrieve.</param>
        /// <param name="membershipType">A valid non-BungieNet membership type.</param>
        /// <param name="count">Number of rows to return (optional)</param>
        /// <param name="mode">A filter for the activity mode to be returned. None returns all activities. See the documentation for DestinyActivityModeType for valid values, and pass in string representation. (optional)</param>
        /// <param name="page">Page number to return, starting with 0. (optional)</param>
        /// <returns>InlineResponse20054</returns>
        InlineResponse20054 Destiny2GetActivityHistory(NancyContext context, long? characterId, long? destinyMembershipId, int? membershipType, int? count, int? mode, int? page);

        /// <summary>
        /// Returns character information for the supplied character.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="characterId">ID of the character.</param>
        /// <param name="destinyMembershipId">Destiny membership ID.</param>
        /// <param name="membershipType">A valid non-BungieNet membership type.</param>
        /// <param name="components">A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results. (optional)</param>
        /// <returns>InlineResponse20038</returns>
        InlineResponse20038 Destiny2GetCharacter(NancyContext context, long? characterId, long? destinyMembershipId, int? membershipType, List<int?> components);

        /// <summary>
        /// Gets aggregated stats for a clan using the same categories as the clan leaderboards. PREVIEW: This endpoint is still in beta, and may experience rough edges. The schema is in final form, but there may be bugs that prevent desirable operation.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="groupId">Group ID of the clan whose leaderboards you wish to fetch.</param>
        /// <param name="modes">List of game modes for which to get leaderboards. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited. (optional)</param>
        /// <returns>InlineResponse20050</returns>
        InlineResponse20050 Destiny2GetClanAggregateStats(NancyContext context, long? groupId, string modes);

        /// <summary>
        /// Gets leaderboards with the signed in user&#39;s friends and the supplied destinyMembershipId as the focus. PREVIEW: This endpoint is still in beta, and may experience rough edges. The schema is in final form, but there may be bugs that prevent desirable operation.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="groupId">Group ID of the clan whose leaderboards you wish to fetch.</param>
        /// <param name="maxtop">Maximum number of top players to return. Use a large number to get entire leaderboard. (optional)</param>
        /// <param name="modes">List of game modes for which to get leaderboards. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited. (optional)</param>
        /// <param name="statid">ID of stat to return rather than returning all Leaderboard stats. (optional)</param>
        /// <returns>InlineResponse20049</returns>
        InlineResponse20049 Destiny2GetClanLeaderboards(NancyContext context, long? groupId, int? maxtop, string modes, string statid);

        /// <summary>
        /// Returns information on the weekly clan rewards and if the clan has earned them or not. Note that this will always report rewards as not redeemed.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="groupId">A valid group id of clan.</param>
        /// <returns>InlineResponse20039</returns>
        InlineResponse20039 Destiny2GetClanWeeklyRewardState(NancyContext context, long? groupId);

        /// <summary>
        /// Given a Presentation Node that has Collectibles as direct descendants, this will return item details about those descendants in the context of the requesting character.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="characterId">The Destiny Character ID of the character for whom we&#39;re getting collectible detail info.</param>
        /// <param name="collectiblePresentationNodeHash">The hash identifier of the Presentation Node for whom we should return collectible details. Details will only be returned for collectibles that are direct descendants of this node.</param>
        /// <param name="destinyMembershipId">Destiny membership ID of another user. You may be denied.</param>
        /// <param name="membershipType">A valid non-BungieNet membership type.</param>
        /// <param name="components">A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results. (optional)</param>
        /// <returns>InlineResponse20044</returns>
        InlineResponse20044 Destiny2GetCollectibleNodeDetails(NancyContext context, long? characterId, int? collectiblePresentationNodeHash, long? destinyMembershipId, int? membershipType, List<int?> components);

        /// <summary>
        /// Gets all activities the character has participated in together with aggregate statistics for those activities.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="characterId">The specific character whose activities should be returned.</param>
        /// <param name="destinyMembershipId">The Destiny membershipId of the user to retrieve.</param>
        /// <param name="membershipType">A valid non-BungieNet membership type.</param>
        /// <returns>InlineResponse20056</returns>
        InlineResponse20056 Destiny2GetDestinyAggregateActivityStats(NancyContext context, long? characterId, long? destinyMembershipId, int? membershipType);

        /// <summary>
        /// Returns the static definition of an entity of the given Type and hash identifier. Examine the API Documentation for the Type Names of entities that have their own definitions. Note that the return type will always *inherit from* DestinyDefinition, but the specific type returned will be the requested entity type if it can be found. Please don&#39;t use this as a chatty alternative to the Manifest database if you require large sets of data, but for simple and one-off accesses this should be handy.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="entityType">The type of entity for whom you would like results. These correspond to the entity&#39;s definition contract name. For instance, if you are looking for items, this property should be &#39;DestinyInventoryItemDefinition&#39;. PREVIEW: This endpoint is still in beta, and may experience rough edges. The schema is tentatively in final form, but there may be bugs that prevent desirable operation.</param>
        /// <param name="hashIdentifier">The hash identifier for the specific Entity you want returned.</param>
        /// <returns>InlineResponse20034</returns>
        InlineResponse20034 Destiny2GetDestinyEntityDefinition(NancyContext context, string entityType, int? hashIdentifier);

        /// <summary>
        /// Returns the current version of the manifest as a json object.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <returns>InlineResponse20033</returns>
        InlineResponse20033 Destiny2GetDestinyManifest(NancyContext context);

        /// <summary>
        /// Gets historical stats for indicated character.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="characterId">The id of the character to retrieve. You can omit this character ID or set it to 0 to get aggregate stats across all characters.</param>
        /// <param name="destinyMembershipId">The Destiny membershipId of the user to retrieve.</param>
        /// <param name="membershipType">A valid non-BungieNet membership type.</param>
        /// <param name="dayend">Last day to return when daily stats are requested. Use the format YYYY-MM-DD. Currently, we cannot allow more than 31 days of daily data to be requested in a single request. (optional)</param>
        /// <param name="daystart">First day to return when daily stats are requested. Use the format YYYY-MM-DD. Currently, we cannot allow more than 31 days of daily data to be requested in a single request. (optional)</param>
        /// <param name="groups">Group of stats to include, otherwise only general stats are returned. Comma separated list is allowed. Values: General, Weapons, Medals (optional)</param>
        /// <param name="modes">Game modes to return. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited. (optional)</param>
        /// <param name="periodType">Indicates a specific period type to return. Optional. May be: Daily, AllTime, or Activity (optional)</param>
        /// <returns>InlineResponse20052</returns>
        InlineResponse20052 Destiny2GetHistoricalStats(NancyContext context, long? characterId, long? destinyMembershipId, int? membershipType, DateTime? dayend, DateTime? daystart, List<int?> groups, List<int?> modes, int? periodType);

        /// <summary>
        /// Gets historical stats definitions.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <returns>InlineResponse20048</returns>
        InlineResponse20048 Destiny2GetHistoricalStatsDefinition(NancyContext context);

        /// <summary>
        /// Gets aggregate historical stats organized around each character for a given account.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="destinyMembershipId">The Destiny membershipId of the user to retrieve.</param>
        /// <param name="membershipType">A valid non-BungieNet membership type.</param>
        /// <param name="groups">Groups of stats to include, otherwise only general stats are returned. Comma separated list is allowed. Values: General, Weapons, Medals. (optional)</param>
        /// <returns>InlineResponse20053</returns>
        InlineResponse20053 Destiny2GetHistoricalStatsForAccount(NancyContext context, long? destinyMembershipId, int? membershipType, List<int?> groups);

        /// <summary>
        /// Retrieve the details of an instanced Destiny Item. An instanced Destiny item is one with an ItemInstanceId. Non-instanced items, such as materials, have no useful instance-specific details and thus are not queryable here.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="destinyMembershipId">The membership ID of the destiny profile.</param>
        /// <param name="itemInstanceId">The Instance ID of the destiny item.</param>
        /// <param name="membershipType">A valid non-BungieNet membership type.</param>
        /// <param name="components">A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results. (optional)</param>
        /// <returns>InlineResponse20040</returns>
        InlineResponse20040 Destiny2GetItem(NancyContext context, long? destinyMembershipId, long? itemInstanceId, int? membershipType, List<int?> components);

        /// <summary>
        /// Gets leaderboards with the signed in user&#39;s friends and the supplied destinyMembershipId as the focus. PREVIEW: This endpoint has not yet been implemented. It is being returned for a preview of future functionality, and for public comment/suggestion/preparation.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="destinyMembershipId">The Destiny membershipId of the user to retrieve.</param>
        /// <param name="membershipType">A valid non-BungieNet membership type.</param>
        /// <param name="maxtop">Maximum number of top players to return. Use a large number to get entire leaderboard. (optional)</param>
        /// <param name="modes">List of game modes for which to get leaderboards. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited. (optional)</param>
        /// <param name="statid">ID of stat to return rather than returning all Leaderboard stats. (optional)</param>
        /// <returns>InlineResponse20049</returns>
        InlineResponse20049 Destiny2GetLeaderboards(NancyContext context, long? destinyMembershipId, int? membershipType, int? maxtop, string modes, string statid);

        /// <summary>
        /// Gets leaderboards with the signed in user&#39;s friends and the supplied destinyMembershipId as the focus. PREVIEW: This endpoint is still in beta, and may experience rough edges. The schema is in final form, but there may be bugs that prevent desirable operation.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="characterId">The specific character to build the leaderboard around for the provided Destiny Membership.</param>
        /// <param name="destinyMembershipId">The Destiny membershipId of the user to retrieve.</param>
        /// <param name="membershipType">A valid non-BungieNet membership type.</param>
        /// <param name="maxtop">Maximum number of top players to return. Use a large number to get entire leaderboard. (optional)</param>
        /// <param name="modes">List of game modes for which to get leaderboards. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited. (optional)</param>
        /// <param name="statid">ID of stat to return rather than returning all Leaderboard stats. (optional)</param>
        /// <returns>InlineResponse20049</returns>
        InlineResponse20049 Destiny2GetLeaderboardsForCharacter(NancyContext context, long? characterId, long? destinyMembershipId, int? membershipType, int? maxtop, string modes, string statid);

        /// <summary>
        /// Returns a summary information about all profiles linked to the requesting membership type/membership ID that have valid Destiny information. The passed-in Membership Type/Membership ID may be a Bungie.Net membership or a Destiny membership. It only returns the minimal amount of data to begin making more substantive requests, but will hopefully serve as a useful alternative to UserServices for people who just care about Destiny data. Note that it will only return linked accounts whose linkages you are allowed to view.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="membershipId">The ID of the membership whose linked Destiny accounts you want returned. Make sure your membership ID matches its Membership Type: don&#39;t pass us a PSN membership ID and the XBox membership type, it&#39;s not going to work!</param>
        /// <param name="membershipType">The type for the membership whose linked Destiny accounts you want returned.</param>
        /// <param name="getAllMemberships">(optional) if set to &#39;true&#39;, all memberships regardless of whether they&#39;re obscured by overrides will be returned. Normal privacy restrictions on account linking will still apply no matter what. (optional)</param>
        /// <returns>InlineResponse20036</returns>
        InlineResponse20036 Destiny2GetLinkedProfiles(NancyContext context, long? membershipId, int? membershipType, bool? getAllMemberships);

        /// <summary>
        /// Gets the available post game carnage report for the activity ID.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="activityId">The ID of the activity whose PGCR is requested.</param>
        /// <returns>InlineResponse20047</returns>
        InlineResponse20047 Destiny2GetPostGameCarnageReport(NancyContext context, long? activityId);

        /// <summary>
        /// Returns Destiny Profile information for the supplied membership.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="destinyMembershipId">Destiny membership ID.</param>
        /// <param name="membershipType">A valid non-BungieNet membership type.</param>
        /// <param name="components">A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results. (optional)</param>
        /// <returns>InlineResponse20037</returns>
        InlineResponse20037 Destiny2GetProfile(NancyContext context, long? destinyMembershipId, int? membershipType, List<int?> components);

        /// <summary>
        /// Gets custom localized content for the milestone of the given hash, if it exists.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="milestoneHash">The identifier for the milestone to be returned.</param>
        /// <returns>InlineResponse20057</returns>
        InlineResponse20057 Destiny2GetPublicMilestoneContent(NancyContext context, int? milestoneHash);

        /// <summary>
        /// Gets public information about currently available Milestones.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <returns>InlineResponse20058</returns>
        InlineResponse20058 Destiny2GetPublicMilestones(NancyContext context);

        /// <summary>
        /// Get items available from vendors where the vendors have items for sale that are common for everyone. If any portion of the Vendor&#39;s available inventory is character or account specific, we will be unable to return their data from this endpoint due to the way that available inventory is computed. As I am often guilty of saying: &#39;It&#39;s a long story...&#39;
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="components">A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results. (optional)</param>
        /// <returns>InlineResponse20043</returns>
        InlineResponse20043 Destiny2GetPublicVendors(NancyContext context, List<int?> components);

        /// <summary>
        /// Gets details about unique weapon usage, including all exotic weapons.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="characterId">The id of the character to retrieve.</param>
        /// <param name="destinyMembershipId">The Destiny membershipId of the user to retrieve.</param>
        /// <param name="membershipType">A valid non-BungieNet membership type.</param>
        /// <returns>InlineResponse20055</returns>
        InlineResponse20055 Destiny2GetUniqueWeaponHistory(NancyContext context, long? characterId, long? destinyMembershipId, int? membershipType);

        /// <summary>
        /// Get the details of a specific Vendor.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="characterId">The Destiny Character ID of the character for whom we&#39;re getting vendor info.</param>
        /// <param name="destinyMembershipId">Destiny membership ID of another user. You may be denied.</param>
        /// <param name="membershipType">A valid non-BungieNet membership type.</param>
        /// <param name="vendorHash">The Hash identifier of the Vendor to be returned.</param>
        /// <param name="components">A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results. (optional)</param>
        /// <returns>InlineResponse20042</returns>
        InlineResponse20042 Destiny2GetVendor(NancyContext context, long? characterId, long? destinyMembershipId, int? membershipType, int? vendorHash, List<int?> components);

        /// <summary>
        /// Get currently available vendors from the list of vendors that can possibly have rotating inventory. Note that this does not include things like preview vendors and vendors-as-kiosks, neither of whom have rotating/dynamic inventories. Use their definitions as-is for those.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="characterId">The Destiny Character ID of the character for whom we&#39;re getting vendor info.</param>
        /// <param name="destinyMembershipId">Destiny membership ID of another user. You may be denied.</param>
        /// <param name="membershipType">A valid non-BungieNet membership type.</param>
        /// <param name="components">A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results. (optional)</param>
        /// <returns>InlineResponse20041</returns>
        InlineResponse20041 Destiny2GetVendors(NancyContext context, long? characterId, long? destinyMembershipId, int? membershipType, List<int?> components);

        /// <summary>
        /// Insert a plug into a socketed item. I know how it sounds, but I assure you it&#39;s much more G-rated than you might be guessing. We haven&#39;t decided yet whether this will be able to insert plugs that have side effects, but if we do it will require special scope permission for an application attempting to do so. You must have a valid Destiny Account, and either be in a social space, in orbit, or offline. Request must include proof of permission for &#39;InsertPlugs&#39; from the account owner.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <returns>InlineResponse20046</returns>
        InlineResponse20046 Destiny2InsertSocketPlug(NancyContext context);

        /// <summary>
        /// Extract an item from the Postmaster, with whatever implications that may entail. You must have a valid Destiny account. You must also pass BOTH a reference AND an instance ID if it&#39;s an instanced item.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <returns>InlineResponse20022</returns>
        InlineResponse20022 Destiny2PullFromPostmaster(NancyContext context);

        /// <summary>
        /// Report a player that you met in an activity that was engaging in ToS-violating activities. Both you and the offending player must have played in the activityId passed in. Please use this judiciously and only when you have strong suspicions of violation, pretty please.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="activityId">The ID of the activity where you ran into the brigand that you&#39;re reporting.</param>
        /// <returns>InlineResponse20022</returns>
        InlineResponse20022 Destiny2ReportOffensivePostGameCarnageReportPlayer(NancyContext context, long? activityId);

        /// <summary>
        /// Gets a page list of Destiny items.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="searchTerm">The string to use when searching for Destiny entities.</param>
        /// <param name="type">The type of entity for whom you would like results. These correspond to the entity&#39;s definition contract name. For instance, if you are looking for items, this property should be &#39;DestinyInventoryItemDefinition&#39;.</param>
        /// <param name="page">Page number to return, starting with 0. (optional)</param>
        /// <returns>InlineResponse20051</returns>
        InlineResponse20051 Destiny2SearchDestinyEntities(NancyContext context, string searchTerm, string type, int? page);

        /// <summary>
        /// Returns a list of Destiny memberships given a full Gamertag or PSN ID. Unless you pass returnOriginalProfile&#x3D;true, this will return membership information for the users&#39; Primary Cross Save Profile if they are engaged in cross save rather than any original Destiny profile that is now being overridden.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="displayName">The full gamertag or PSN id of the player. Spaces and case are ignored.</param>
        /// <param name="membershipType">A valid non-BungieNet membership type, or All.</param>
        /// <param name="returnOriginalProfile">(optional) If passed in and set to true, we will return the original Destiny Profile(s) linked to that gamertag, and not their currently active Destiny Profile. (optional)</param>
        /// <returns>InlineResponse20035</returns>
        InlineResponse20035 Destiny2SearchDestinyPlayer(NancyContext context, string displayName, int? membershipType, bool? returnOriginalProfile);

        /// <summary>
        /// Set the Lock State for an instanced item. You must have a valid Destiny Account.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <returns>InlineResponse20022</returns>
        InlineResponse20022 Destiny2SetItemLockState(NancyContext context);

        /// <summary>
        /// Transfer an item to/from your vault. You must have a valid Destiny account. You must also pass BOTH a reference AND an instance ID if it&#39;s an instanced item. itshappening.gif
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <returns>InlineResponse20022</returns>
        InlineResponse20022 Destiny2TransferItem(NancyContext context);
    }

    /// <summary>
    /// Abstraction of Destiny2Service.
    /// </summary>
    public abstract class AbstractDestiny2Service: Destiny2Service
    {
        public virtual InlineResponse20060 Destiny2AwaGetActionToken(NancyContext context, string correlationId)
        {
            return Destiny2AwaGetActionToken(correlationId);
        }

        public virtual InlineResponse20059 Destiny2AwaInitializeRequest(NancyContext context)
        {
            return Destiny2AwaInitializeRequest();
        }

        public virtual InlineResponse20022 Destiny2AwaProvideAuthorizationResult(NancyContext context)
        {
            return Destiny2AwaProvideAuthorizationResult();
        }

        public virtual InlineResponse20022 Destiny2EquipItem(NancyContext context)
        {
            return Destiny2EquipItem();
        }

        public virtual InlineResponse20045 Destiny2EquipItems(NancyContext context)
        {
            return Destiny2EquipItems();
        }

        public virtual InlineResponse20054 Destiny2GetActivityHistory(NancyContext context, long? characterId, long? destinyMembershipId, int? membershipType, int? count, int? mode, int? page)
        {
            return Destiny2GetActivityHistory(characterId, destinyMembershipId, membershipType, count, mode, page);
        }

        public virtual InlineResponse20038 Destiny2GetCharacter(NancyContext context, long? characterId, long? destinyMembershipId, int? membershipType, List<int?> components)
        {
            return Destiny2GetCharacter(characterId, destinyMembershipId, membershipType, components);
        }

        public virtual InlineResponse20050 Destiny2GetClanAggregateStats(NancyContext context, long? groupId, string modes)
        {
            return Destiny2GetClanAggregateStats(groupId, modes);
        }

        public virtual InlineResponse20049 Destiny2GetClanLeaderboards(NancyContext context, long? groupId, int? maxtop, string modes, string statid)
        {
            return Destiny2GetClanLeaderboards(groupId, maxtop, modes, statid);
        }

        public virtual InlineResponse20039 Destiny2GetClanWeeklyRewardState(NancyContext context, long? groupId)
        {
            return Destiny2GetClanWeeklyRewardState(groupId);
        }

        public virtual InlineResponse20044 Destiny2GetCollectibleNodeDetails(NancyContext context, long? characterId, int? collectiblePresentationNodeHash, long? destinyMembershipId, int? membershipType, List<int?> components)
        {
            return Destiny2GetCollectibleNodeDetails(characterId, collectiblePresentationNodeHash, destinyMembershipId, membershipType, components);
        }

        public virtual InlineResponse20056 Destiny2GetDestinyAggregateActivityStats(NancyContext context, long? characterId, long? destinyMembershipId, int? membershipType)
        {
            return Destiny2GetDestinyAggregateActivityStats(characterId, destinyMembershipId, membershipType);
        }

        public virtual InlineResponse20034 Destiny2GetDestinyEntityDefinition(NancyContext context, string entityType, int? hashIdentifier)
        {
            return Destiny2GetDestinyEntityDefinition(entityType, hashIdentifier);
        }

        public virtual InlineResponse20033 Destiny2GetDestinyManifest(NancyContext context)
        {
            return Destiny2GetDestinyManifest();
        }

        public virtual InlineResponse20052 Destiny2GetHistoricalStats(NancyContext context, long? characterId, long? destinyMembershipId, int? membershipType, DateTime? dayend, DateTime? daystart, List<int?> groups, List<int?> modes, int? periodType)
        {
            return Destiny2GetHistoricalStats(characterId, destinyMembershipId, membershipType, dayend, daystart, groups, modes, periodType);
        }

        public virtual InlineResponse20048 Destiny2GetHistoricalStatsDefinition(NancyContext context)
        {
            return Destiny2GetHistoricalStatsDefinition();
        }

        public virtual InlineResponse20053 Destiny2GetHistoricalStatsForAccount(NancyContext context, long? destinyMembershipId, int? membershipType, List<int?> groups)
        {
            return Destiny2GetHistoricalStatsForAccount(destinyMembershipId, membershipType, groups);
        }

        public virtual InlineResponse20040 Destiny2GetItem(NancyContext context, long? destinyMembershipId, long? itemInstanceId, int? membershipType, List<int?> components)
        {
            return Destiny2GetItem(destinyMembershipId, itemInstanceId, membershipType, components);
        }

        public virtual InlineResponse20049 Destiny2GetLeaderboards(NancyContext context, long? destinyMembershipId, int? membershipType, int? maxtop, string modes, string statid)
        {
            return Destiny2GetLeaderboards(destinyMembershipId, membershipType, maxtop, modes, statid);
        }

        public virtual InlineResponse20049 Destiny2GetLeaderboardsForCharacter(NancyContext context, long? characterId, long? destinyMembershipId, int? membershipType, int? maxtop, string modes, string statid)
        {
            return Destiny2GetLeaderboardsForCharacter(characterId, destinyMembershipId, membershipType, maxtop, modes, statid);
        }

        public virtual InlineResponse20036 Destiny2GetLinkedProfiles(NancyContext context, long? membershipId, int? membershipType, bool? getAllMemberships)
        {
            return Destiny2GetLinkedProfiles(membershipId, membershipType, getAllMemberships);
        }

        public virtual InlineResponse20047 Destiny2GetPostGameCarnageReport(NancyContext context, long? activityId)
        {
            return Destiny2GetPostGameCarnageReport(activityId);
        }

        public virtual InlineResponse20037 Destiny2GetProfile(NancyContext context, long? destinyMembershipId, int? membershipType, List<int?> components)
        {
            return Destiny2GetProfile(destinyMembershipId, membershipType, components);
        }

        public virtual InlineResponse20057 Destiny2GetPublicMilestoneContent(NancyContext context, int? milestoneHash)
        {
            return Destiny2GetPublicMilestoneContent(milestoneHash);
        }

        public virtual InlineResponse20058 Destiny2GetPublicMilestones(NancyContext context)
        {
            return Destiny2GetPublicMilestones();
        }

        public virtual InlineResponse20043 Destiny2GetPublicVendors(NancyContext context, List<int?> components)
        {
            return Destiny2GetPublicVendors(components);
        }

        public virtual InlineResponse20055 Destiny2GetUniqueWeaponHistory(NancyContext context, long? characterId, long? destinyMembershipId, int? membershipType)
        {
            return Destiny2GetUniqueWeaponHistory(characterId, destinyMembershipId, membershipType);
        }

        public virtual InlineResponse20042 Destiny2GetVendor(NancyContext context, long? characterId, long? destinyMembershipId, int? membershipType, int? vendorHash, List<int?> components)
        {
            return Destiny2GetVendor(characterId, destinyMembershipId, membershipType, vendorHash, components);
        }

        public virtual InlineResponse20041 Destiny2GetVendors(NancyContext context, long? characterId, long? destinyMembershipId, int? membershipType, List<int?> components)
        {
            return Destiny2GetVendors(characterId, destinyMembershipId, membershipType, components);
        }

        public virtual InlineResponse20046 Destiny2InsertSocketPlug(NancyContext context)
        {
            return Destiny2InsertSocketPlug();
        }

        public virtual InlineResponse20022 Destiny2PullFromPostmaster(NancyContext context)
        {
            return Destiny2PullFromPostmaster();
        }

        public virtual InlineResponse20022 Destiny2ReportOffensivePostGameCarnageReportPlayer(NancyContext context, long? activityId)
        {
            return Destiny2ReportOffensivePostGameCarnageReportPlayer(activityId);
        }

        public virtual InlineResponse20051 Destiny2SearchDestinyEntities(NancyContext context, string searchTerm, string type, int? page)
        {
            return Destiny2SearchDestinyEntities(searchTerm, type, page);
        }

        public virtual InlineResponse20035 Destiny2SearchDestinyPlayer(NancyContext context, string displayName, int? membershipType, bool? returnOriginalProfile)
        {
            return Destiny2SearchDestinyPlayer(displayName, membershipType, returnOriginalProfile);
        }

        public virtual InlineResponse20022 Destiny2SetItemLockState(NancyContext context)
        {
            return Destiny2SetItemLockState();
        }

        public virtual InlineResponse20022 Destiny2TransferItem(NancyContext context)
        {
            return Destiny2TransferItem();
        }

        protected abstract InlineResponse20060 Destiny2AwaGetActionToken(string correlationId);

        protected abstract InlineResponse20059 Destiny2AwaInitializeRequest();

        protected abstract InlineResponse20022 Destiny2AwaProvideAuthorizationResult();

        protected abstract InlineResponse20022 Destiny2EquipItem();

        protected abstract InlineResponse20045 Destiny2EquipItems();

        protected abstract InlineResponse20054 Destiny2GetActivityHistory(long? characterId, long? destinyMembershipId, int? membershipType, int? count, int? mode, int? page);

        protected abstract InlineResponse20038 Destiny2GetCharacter(long? characterId, long? destinyMembershipId, int? membershipType, List<int?> components);

        protected abstract InlineResponse20050 Destiny2GetClanAggregateStats(long? groupId, string modes);

        protected abstract InlineResponse20049 Destiny2GetClanLeaderboards(long? groupId, int? maxtop, string modes, string statid);

        protected abstract InlineResponse20039 Destiny2GetClanWeeklyRewardState(long? groupId);

        protected abstract InlineResponse20044 Destiny2GetCollectibleNodeDetails(long? characterId, int? collectiblePresentationNodeHash, long? destinyMembershipId, int? membershipType, List<int?> components);

        protected abstract InlineResponse20056 Destiny2GetDestinyAggregateActivityStats(long? characterId, long? destinyMembershipId, int? membershipType);

        protected abstract InlineResponse20034 Destiny2GetDestinyEntityDefinition(string entityType, int? hashIdentifier);

        protected abstract InlineResponse20033 Destiny2GetDestinyManifest();

        protected abstract InlineResponse20052 Destiny2GetHistoricalStats(long? characterId, long? destinyMembershipId, int? membershipType, DateTime? dayend, DateTime? daystart, List<int?> groups, List<int?> modes, int? periodType);

        protected abstract InlineResponse20048 Destiny2GetHistoricalStatsDefinition();

        protected abstract InlineResponse20053 Destiny2GetHistoricalStatsForAccount(long? destinyMembershipId, int? membershipType, List<int?> groups);

        protected abstract InlineResponse20040 Destiny2GetItem(long? destinyMembershipId, long? itemInstanceId, int? membershipType, List<int?> components);

        protected abstract InlineResponse20049 Destiny2GetLeaderboards(long? destinyMembershipId, int? membershipType, int? maxtop, string modes, string statid);

        protected abstract InlineResponse20049 Destiny2GetLeaderboardsForCharacter(long? characterId, long? destinyMembershipId, int? membershipType, int? maxtop, string modes, string statid);

        protected abstract InlineResponse20036 Destiny2GetLinkedProfiles(long? membershipId, int? membershipType, bool? getAllMemberships);

        protected abstract InlineResponse20047 Destiny2GetPostGameCarnageReport(long? activityId);

        protected abstract InlineResponse20037 Destiny2GetProfile(long? destinyMembershipId, int? membershipType, List<int?> components);

        protected abstract InlineResponse20057 Destiny2GetPublicMilestoneContent(int? milestoneHash);

        protected abstract InlineResponse20058 Destiny2GetPublicMilestones();

        protected abstract InlineResponse20043 Destiny2GetPublicVendors(List<int?> components);

        protected abstract InlineResponse20055 Destiny2GetUniqueWeaponHistory(long? characterId, long? destinyMembershipId, int? membershipType);

        protected abstract InlineResponse20042 Destiny2GetVendor(long? characterId, long? destinyMembershipId, int? membershipType, int? vendorHash, List<int?> components);

        protected abstract InlineResponse20041 Destiny2GetVendors(long? characterId, long? destinyMembershipId, int? membershipType, List<int?> components);

        protected abstract InlineResponse20046 Destiny2InsertSocketPlug();

        protected abstract InlineResponse20022 Destiny2PullFromPostmaster();

        protected abstract InlineResponse20022 Destiny2ReportOffensivePostGameCarnageReportPlayer(long? activityId);

        protected abstract InlineResponse20051 Destiny2SearchDestinyEntities(string searchTerm, string type, int? page);

        protected abstract InlineResponse20035 Destiny2SearchDestinyPlayer(string displayName, int? membershipType, bool? returnOriginalProfile);

        protected abstract InlineResponse20022 Destiny2SetItemLockState();

        protected abstract InlineResponse20022 Destiny2TransferItem();
    }

}
