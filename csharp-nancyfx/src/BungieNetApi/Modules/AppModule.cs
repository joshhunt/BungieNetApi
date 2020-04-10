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
    /// Module processing requests of App domain.
    /// </summary>
    public sealed class AppModule : NancyModule
    {
        /// <summary>
        /// Sets up HTTP methods mappings.
        /// </summary>
        /// <param name="service">Service handling requests</param>
        public AppModule(AppService service) : base("/Platform")
        { 
            Get["/App/ApiUsage/{applicationId}/"] = parameters =>
            {
                var applicationId = Parameters.ValueOf<int?>(parameters, Context.Request, "applicationId", ParameterType.Path);
                var end = Parameters.ValueOf<DateTime?>(parameters, Context.Request, "end", ParameterType.Query);
                var start = Parameters.ValueOf<DateTime?>(parameters, Context.Request, "start", ParameterType.Query);
                Preconditions.IsNotNull(applicationId, "Required parameter: 'applicationId' is missing at 'AppGetApplicationApiUsage'");
                
                return service.AppGetApplicationApiUsage(Context, applicationId, end, start);
            };

            Get["/App/FirstParty/"] = parameters =>
            {
                
                return service.AppGetBungieApplications(Context);
            };
        }
    }

    /// <summary>
    /// Service handling App requests.
    /// </summary>
    public interface AppService
    {
        /// <summary>
        /// Get API usage by application for time frame specified. You can go as far back as 30 days ago, and can ask for up to a 48 hour window of time in a single request. You must be authenticated with at least the ReadUserData permission to access this endpoint.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="applicationId">ID of the application to get usage statistics.</param>
        /// <param name="end">End time for query. Goes to now if not specified. (optional)</param>
        /// <param name="start">Start time for query. Goes to 24 hours ago if not specified. (optional)</param>
        /// <returns>InlineResponse200</returns>
        InlineResponse200 AppGetApplicationApiUsage(NancyContext context, int? applicationId, DateTime? end, DateTime? start);

        /// <summary>
        /// Get list of applications created by Bungie.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <returns>InlineResponse2001</returns>
        InlineResponse2001 AppGetBungieApplications(NancyContext context);
    }

    /// <summary>
    /// Abstraction of AppService.
    /// </summary>
    public abstract class AbstractAppService: AppService
    {
        public virtual InlineResponse200 AppGetApplicationApiUsage(NancyContext context, int? applicationId, DateTime? end, DateTime? start)
        {
            return AppGetApplicationApiUsage(applicationId, end, start);
        }

        public virtual InlineResponse2001 AppGetBungieApplications(NancyContext context)
        {
            return AppGetBungieApplications();
        }

        protected abstract InlineResponse200 AppGetApplicationApiUsage(int? applicationId, DateTime? end, DateTime? start);

        protected abstract InlineResponse2001 AppGetBungieApplications();
    }

}
