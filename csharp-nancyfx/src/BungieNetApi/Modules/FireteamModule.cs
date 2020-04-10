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
    /// Module processing requests of Fireteam domain.
    /// </summary>
    public sealed class FireteamModule : NancyModule
    {
        /// <summary>
        /// Sets up HTTP methods mappings.
        /// </summary>
        /// <param name="service">Service handling requests</param>
        public FireteamModule(FireteamService service) : base("/Platform")
        { 
            Get["/Fireteam/Clan/{groupId}/ActiveCount/"] = parameters =>
            {
                var groupId = Parameters.ValueOf<long?>(parameters, Context.Request, "groupId", ParameterType.Path);
                Preconditions.IsNotNull(groupId, "Required parameter: 'groupId' is missing at 'FireteamGetActivePrivateClanFireteamCount'");
                
                return service.FireteamGetActivePrivateClanFireteamCount(Context, groupId);
            };

            Get["/Fireteam/Clan/{groupId}/Available/{platform}/{activityType}/{dateRange}/{slotFilter}/{publicOnly}/{page}/"] = parameters =>
            {
                var activityType = Parameters.ValueOf<int?>(parameters, Context.Request, "activityType", ParameterType.Path);
                var dateRange = Parameters.ValueOf<int?>(parameters, Context.Request, "dateRange", ParameterType.Path);
                var groupId = Parameters.ValueOf<long?>(parameters, Context.Request, "groupId", ParameterType.Path);
                var page = Parameters.ValueOf<int?>(parameters, Context.Request, "page", ParameterType.Path);
                var platform = Parameters.ValueOf<int?>(parameters, Context.Request, "platform", ParameterType.Path);
                var publicOnly = Parameters.ValueOf<int?>(parameters, Context.Request, "publicOnly", ParameterType.Path);
                var slotFilter = Parameters.ValueOf<int?>(parameters, Context.Request, "slotFilter", ParameterType.Path);
                var langFilter = Parameters.ValueOf<string>(parameters, Context.Request, "langFilter", ParameterType.Query);
                Preconditions.IsNotNull(activityType, "Required parameter: 'activityType' is missing at 'FireteamGetAvailableClanFireteams'");
                
                Preconditions.IsNotNull(dateRange, "Required parameter: 'dateRange' is missing at 'FireteamGetAvailableClanFireteams'");
                
                Preconditions.IsNotNull(groupId, "Required parameter: 'groupId' is missing at 'FireteamGetAvailableClanFireteams'");
                
                Preconditions.IsNotNull(page, "Required parameter: 'page' is missing at 'FireteamGetAvailableClanFireteams'");
                
                Preconditions.IsNotNull(platform, "Required parameter: 'platform' is missing at 'FireteamGetAvailableClanFireteams'");
                
                Preconditions.IsNotNull(publicOnly, "Required parameter: 'publicOnly' is missing at 'FireteamGetAvailableClanFireteams'");
                
                Preconditions.IsNotNull(slotFilter, "Required parameter: 'slotFilter' is missing at 'FireteamGetAvailableClanFireteams'");
                
                return service.FireteamGetAvailableClanFireteams(Context, activityType, dateRange, groupId, page, platform, publicOnly, slotFilter, langFilter);
            };

            Get["/Fireteam/Clan/{groupId}/Summary/{fireteamId}/"] = parameters =>
            {
                var fireteamId = Parameters.ValueOf<long?>(parameters, Context.Request, "fireteamId", ParameterType.Path);
                var groupId = Parameters.ValueOf<long?>(parameters, Context.Request, "groupId", ParameterType.Path);
                Preconditions.IsNotNull(fireteamId, "Required parameter: 'fireteamId' is missing at 'FireteamGetClanFireteam'");
                
                Preconditions.IsNotNull(groupId, "Required parameter: 'groupId' is missing at 'FireteamGetClanFireteam'");
                
                return service.FireteamGetClanFireteam(Context, fireteamId, groupId);
            };

            Get["/Fireteam/Clan/{groupId}/My/{platform}/{includeClosed}/{page}/"] = parameters =>
            {
                var groupId = Parameters.ValueOf<long?>(parameters, Context.Request, "groupId", ParameterType.Path);
                var includeClosed = Parameters.ValueOf<bool?>(parameters, Context.Request, "includeClosed", ParameterType.Path);
                var page = Parameters.ValueOf<int?>(parameters, Context.Request, "page", ParameterType.Path);
                var platform = Parameters.ValueOf<int?>(parameters, Context.Request, "platform", ParameterType.Path);
                var groupFilter = Parameters.ValueOf<bool?>(parameters, Context.Request, "groupFilter", ParameterType.Query);
                var langFilter = Parameters.ValueOf<string>(parameters, Context.Request, "langFilter", ParameterType.Query);
                Preconditions.IsNotNull(groupId, "Required parameter: 'groupId' is missing at 'FireteamGetMyClanFireteams'");
                
                Preconditions.IsNotNull(includeClosed, "Required parameter: 'includeClosed' is missing at 'FireteamGetMyClanFireteams'");
                
                Preconditions.IsNotNull(page, "Required parameter: 'page' is missing at 'FireteamGetMyClanFireteams'");
                
                Preconditions.IsNotNull(platform, "Required parameter: 'platform' is missing at 'FireteamGetMyClanFireteams'");
                
                return service.FireteamGetMyClanFireteams(Context, groupId, includeClosed, page, platform, groupFilter, langFilter);
            };

            Get["/Fireteam/Search/Available/{platform}/{activityType}/{dateRange}/{slotFilter}/{page}/"] = parameters =>
            {
                var activityType = Parameters.ValueOf<int?>(parameters, Context.Request, "activityType", ParameterType.Path);
                var dateRange = Parameters.ValueOf<int?>(parameters, Context.Request, "dateRange", ParameterType.Path);
                var page = Parameters.ValueOf<int?>(parameters, Context.Request, "page", ParameterType.Path);
                var platform = Parameters.ValueOf<int?>(parameters, Context.Request, "platform", ParameterType.Path);
                var slotFilter = Parameters.ValueOf<int?>(parameters, Context.Request, "slotFilter", ParameterType.Path);
                var langFilter = Parameters.ValueOf<string>(parameters, Context.Request, "langFilter", ParameterType.Query);
                Preconditions.IsNotNull(activityType, "Required parameter: 'activityType' is missing at 'FireteamSearchPublicAvailableClanFireteams'");
                
                Preconditions.IsNotNull(dateRange, "Required parameter: 'dateRange' is missing at 'FireteamSearchPublicAvailableClanFireteams'");
                
                Preconditions.IsNotNull(page, "Required parameter: 'page' is missing at 'FireteamSearchPublicAvailableClanFireteams'");
                
                Preconditions.IsNotNull(platform, "Required parameter: 'platform' is missing at 'FireteamSearchPublicAvailableClanFireteams'");
                
                Preconditions.IsNotNull(slotFilter, "Required parameter: 'slotFilter' is missing at 'FireteamSearchPublicAvailableClanFireteams'");
                
                return service.FireteamSearchPublicAvailableClanFireteams(Context, activityType, dateRange, page, platform, slotFilter, langFilter);
            };
        }
    }

    /// <summary>
    /// Service handling Fireteam requests.
    /// </summary>
    public interface FireteamService
    {
        /// <summary>
        /// Gets a count of all active non-public fireteams for the specified clan. Maximum value returned is 25.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="groupId">The group id of the clan.</param>
        /// <returns>InlineResponse20022</returns>
        InlineResponse20022 FireteamGetActivePrivateClanFireteamCount(NancyContext context, long? groupId);

        /// <summary>
        /// Gets a listing of all of this clan&#39;s fireteams that are have available slots. Caller is not checked for join criteria so caching is maximized.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="activityType">The activity type to filter by.</param>
        /// <param name="dateRange">The date range to grab available fireteams.</param>
        /// <param name="groupId">The group id of the clan.</param>
        /// <param name="page">Zero based page</param>
        /// <param name="platform">The platform filter.</param>
        /// <param name="publicOnly">Determines public/private filtering.</param>
        /// <param name="slotFilter">Filters based on available slots</param>
        /// <param name="langFilter">An optional language filter. (optional)</param>
        /// <returns>InlineResponse20064</returns>
        InlineResponse20064 FireteamGetAvailableClanFireteams(NancyContext context, int? activityType, int? dateRange, long? groupId, int? page, int? platform, int? publicOnly, int? slotFilter, string langFilter);

        /// <summary>
        /// Gets a specific clan fireteam.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="fireteamId">The unique id of the fireteam.</param>
        /// <param name="groupId">The group id of the clan.</param>
        /// <returns>InlineResponse20066</returns>
        InlineResponse20066 FireteamGetClanFireteam(NancyContext context, long? fireteamId, long? groupId);

        /// <summary>
        /// Gets a listing of all clan fireteams that caller is an applicant, a member, or an alternate of.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="groupId">The group id of the clan. (This parameter is ignored unless the optional query parameter groupFilter is true).</param>
        /// <param name="includeClosed">If true, return fireteams that have been closed.</param>
        /// <param name="page">Deprecated parameter, ignored.</param>
        /// <param name="platform">The platform filter.</param>
        /// <param name="groupFilter">If true, filter by clan. Otherwise, ignore the clan and show all of the user&#39;s fireteams. (optional)</param>
        /// <param name="langFilter">An optional language filter. (optional)</param>
        /// <returns>InlineResponse20065</returns>
        InlineResponse20065 FireteamGetMyClanFireteams(NancyContext context, long? groupId, bool? includeClosed, int? page, int? platform, bool? groupFilter, string langFilter);

        /// <summary>
        /// Gets a listing of all public fireteams starting now with open slots. Caller is not checked for join criteria so caching is maximized.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="activityType">The activity type to filter by.</param>
        /// <param name="dateRange">The date range to grab available fireteams.</param>
        /// <param name="page">Zero based page</param>
        /// <param name="platform">The platform filter.</param>
        /// <param name="slotFilter">Filters based on available slots</param>
        /// <param name="langFilter">An optional language filter. (optional)</param>
        /// <returns>InlineResponse20064</returns>
        InlineResponse20064 FireteamSearchPublicAvailableClanFireteams(NancyContext context, int? activityType, int? dateRange, int? page, int? platform, int? slotFilter, string langFilter);
    }

    /// <summary>
    /// Abstraction of FireteamService.
    /// </summary>
    public abstract class AbstractFireteamService: FireteamService
    {
        public virtual InlineResponse20022 FireteamGetActivePrivateClanFireteamCount(NancyContext context, long? groupId)
        {
            return FireteamGetActivePrivateClanFireteamCount(groupId);
        }

        public virtual InlineResponse20064 FireteamGetAvailableClanFireteams(NancyContext context, int? activityType, int? dateRange, long? groupId, int? page, int? platform, int? publicOnly, int? slotFilter, string langFilter)
        {
            return FireteamGetAvailableClanFireteams(activityType, dateRange, groupId, page, platform, publicOnly, slotFilter, langFilter);
        }

        public virtual InlineResponse20066 FireteamGetClanFireteam(NancyContext context, long? fireteamId, long? groupId)
        {
            return FireteamGetClanFireteam(fireteamId, groupId);
        }

        public virtual InlineResponse20065 FireteamGetMyClanFireteams(NancyContext context, long? groupId, bool? includeClosed, int? page, int? platform, bool? groupFilter, string langFilter)
        {
            return FireteamGetMyClanFireteams(groupId, includeClosed, page, platform, groupFilter, langFilter);
        }

        public virtual InlineResponse20064 FireteamSearchPublicAvailableClanFireteams(NancyContext context, int? activityType, int? dateRange, int? page, int? platform, int? slotFilter, string langFilter)
        {
            return FireteamSearchPublicAvailableClanFireteams(activityType, dateRange, page, platform, slotFilter, langFilter);
        }

        protected abstract InlineResponse20022 FireteamGetActivePrivateClanFireteamCount(long? groupId);

        protected abstract InlineResponse20064 FireteamGetAvailableClanFireteams(int? activityType, int? dateRange, long? groupId, int? page, int? platform, int? publicOnly, int? slotFilter, string langFilter);

        protected abstract InlineResponse20066 FireteamGetClanFireteam(long? fireteamId, long? groupId);

        protected abstract InlineResponse20065 FireteamGetMyClanFireteams(long? groupId, bool? includeClosed, int? page, int? platform, bool? groupFilter, string langFilter);

        protected abstract InlineResponse20064 FireteamSearchPublicAvailableClanFireteams(int? activityType, int? dateRange, int? page, int? platform, int? slotFilter, string langFilter);
    }

}
