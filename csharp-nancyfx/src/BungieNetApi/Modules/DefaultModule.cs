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
    /// Module processing requests of Default domain.
    /// </summary>
    public sealed class DefaultModule : NancyModule
    {
        /// <summary>
        /// Sets up HTTP methods mappings.
        /// </summary>
        /// <param name="service">Service handling requests</param>
        public DefaultModule(DefaultService service) : base("/Platform")
        { 
            Get["/GetAvailableLocales/"] = parameters =>
            {
                
                return service.GetAvailableLocales(Context);
            };

            Get["/Settings/"] = parameters =>
            {
                
                return service.GetCommonSettings(Context);
            };

            Get["/GlobalAlerts/"] = parameters =>
            {
                var includestreaming = Parameters.ValueOf<bool?>(parameters, Context.Request, "includestreaming", ParameterType.Query);
                return service.GetGlobalAlerts(Context, includestreaming);
            };
        }
    }

    /// <summary>
    /// Service handling Default requests.
    /// </summary>
    public interface DefaultService
    {
        /// <summary>
        /// List of available localization cultures
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <returns>InlineResponse20015</returns>
        InlineResponse20015 GetAvailableLocales(NancyContext context);

        /// <summary>
        /// Get the common settings used by the Bungie.Net environment.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <returns>InlineResponse20067</returns>
        InlineResponse20067 GetCommonSettings(NancyContext context);

        /// <summary>
        /// Gets any active global alert for display in the forum banners, help pages, etc. Usually used for DOC alerts.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="includestreaming">Determines whether Streaming Alerts are included in results (optional)</param>
        /// <returns>InlineResponse20068</returns>
        InlineResponse20068 GetGlobalAlerts(NancyContext context, bool? includestreaming);
    }

    /// <summary>
    /// Abstraction of DefaultService.
    /// </summary>
    public abstract class AbstractDefaultService: DefaultService
    {
        public virtual InlineResponse20015 GetAvailableLocales(NancyContext context)
        {
            return GetAvailableLocales();
        }

        public virtual InlineResponse20067 GetCommonSettings(NancyContext context)
        {
            return GetCommonSettings();
        }

        public virtual InlineResponse20068 GetGlobalAlerts(NancyContext context, bool? includestreaming)
        {
            return GetGlobalAlerts(includestreaming);
        }

        protected abstract InlineResponse20015 GetAvailableLocales();

        protected abstract InlineResponse20067 GetCommonSettings();

        protected abstract InlineResponse20068 GetGlobalAlerts(bool? includestreaming);
    }

}
