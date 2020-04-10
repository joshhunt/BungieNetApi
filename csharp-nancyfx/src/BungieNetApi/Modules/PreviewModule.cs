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
    /// Module processing requests of Preview domain.
    /// </summary>
    public sealed class PreviewModule : NancyModule
    {
        /// <summary>
        /// Sets up HTTP methods mappings.
        /// </summary>
        /// <param name="service">Service handling requests</param>
        public PreviewModule(PreviewService service) : base("/Platform")
        { 
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

            Get["/Destiny2//Vendors/"] = parameters =>
            {
                var components = Parameters.ValueOf<List<int?>>(parameters, Context.Request, "components", ParameterType.Query);
                return service.Destiny2GetPublicVendors(Context, components);
            };

            Post["/Destiny2/Actions/Items/InsertSocketPlug/"] = parameters =>
            {
                
                return service.Destiny2InsertSocketPlug(Context);
            };
        }
    }

    /// <summary>
    /// Service handling Preview requests.
    /// </summary>
    public interface PreviewService
    {
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
        /// Get items available from vendors where the vendors have items for sale that are common for everyone. If any portion of the Vendor&#39;s available inventory is character or account specific, we will be unable to return their data from this endpoint due to the way that available inventory is computed. As I am often guilty of saying: &#39;It&#39;s a long story...&#39;
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="components">A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results. (optional)</param>
        /// <returns>InlineResponse20043</returns>
        InlineResponse20043 Destiny2GetPublicVendors(NancyContext context, List<int?> components);

        /// <summary>
        /// Insert a plug into a socketed item. I know how it sounds, but I assure you it&#39;s much more G-rated than you might be guessing. We haven&#39;t decided yet whether this will be able to insert plugs that have side effects, but if we do it will require special scope permission for an application attempting to do so. You must have a valid Destiny Account, and either be in a social space, in orbit, or offline. Request must include proof of permission for &#39;InsertPlugs&#39; from the account owner.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <returns>InlineResponse20046</returns>
        InlineResponse20046 Destiny2InsertSocketPlug(NancyContext context);
    }

    /// <summary>
    /// Abstraction of PreviewService.
    /// </summary>
    public abstract class AbstractPreviewService: PreviewService
    {
        public virtual InlineResponse20050 Destiny2GetClanAggregateStats(NancyContext context, long? groupId, string modes)
        {
            return Destiny2GetClanAggregateStats(groupId, modes);
        }

        public virtual InlineResponse20049 Destiny2GetClanLeaderboards(NancyContext context, long? groupId, int? maxtop, string modes, string statid)
        {
            return Destiny2GetClanLeaderboards(groupId, maxtop, modes, statid);
        }

        public virtual InlineResponse20049 Destiny2GetLeaderboards(NancyContext context, long? destinyMembershipId, int? membershipType, int? maxtop, string modes, string statid)
        {
            return Destiny2GetLeaderboards(destinyMembershipId, membershipType, maxtop, modes, statid);
        }

        public virtual InlineResponse20049 Destiny2GetLeaderboardsForCharacter(NancyContext context, long? characterId, long? destinyMembershipId, int? membershipType, int? maxtop, string modes, string statid)
        {
            return Destiny2GetLeaderboardsForCharacter(characterId, destinyMembershipId, membershipType, maxtop, modes, statid);
        }

        public virtual InlineResponse20043 Destiny2GetPublicVendors(NancyContext context, List<int?> components)
        {
            return Destiny2GetPublicVendors(components);
        }

        public virtual InlineResponse20046 Destiny2InsertSocketPlug(NancyContext context)
        {
            return Destiny2InsertSocketPlug();
        }

        protected abstract InlineResponse20050 Destiny2GetClanAggregateStats(long? groupId, string modes);

        protected abstract InlineResponse20049 Destiny2GetClanLeaderboards(long? groupId, int? maxtop, string modes, string statid);

        protected abstract InlineResponse20049 Destiny2GetLeaderboards(long? destinyMembershipId, int? membershipType, int? maxtop, string modes, string statid);

        protected abstract InlineResponse20049 Destiny2GetLeaderboardsForCharacter(long? characterId, long? destinyMembershipId, int? membershipType, int? maxtop, string modes, string statid);

        protected abstract InlineResponse20043 Destiny2GetPublicVendors(List<int?> components);

        protected abstract InlineResponse20046 Destiny2InsertSocketPlug();
    }

}
