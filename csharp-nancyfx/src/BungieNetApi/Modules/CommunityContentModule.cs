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
    /// Module processing requests of CommunityContent domain.
    /// </summary>
    public sealed class CommunityContentModule : NancyModule
    {
        /// <summary>
        /// Sets up HTTP methods mappings.
        /// </summary>
        /// <param name="service">Service handling requests</param>
        public CommunityContentModule(CommunityContentService service) : base("/Platform")
        { 
            Get["/CommunityContent/Get/{sort}/{mediaFilter}/{page}/"] = parameters =>
            {
                var mediaFilter = Parameters.ValueOf<int?>(parameters, Context.Request, "mediaFilter", ParameterType.Path);
                var page = Parameters.ValueOf<int?>(parameters, Context.Request, "page", ParameterType.Path);
                var sort = Parameters.ValueOf<int?>(parameters, Context.Request, "sort", ParameterType.Path);
                Preconditions.IsNotNull(mediaFilter, "Required parameter: 'mediaFilter' is missing at 'CommunityContentGetCommunityContent'");
                
                Preconditions.IsNotNull(page, "Required parameter: 'page' is missing at 'CommunityContentGetCommunityContent'");
                
                Preconditions.IsNotNull(sort, "Required parameter: 'sort' is missing at 'CommunityContentGetCommunityContent'");
                
                return service.CommunityContentGetCommunityContent(Context, mediaFilter, page, sort);
            };
        }
    }

    /// <summary>
    /// Service handling CommunityContent requests.
    /// </summary>
    public interface CommunityContentService
    {
        /// <summary>
        /// Returns community content.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="mediaFilter">The type of media to get</param>
        /// <param name="page">Zero based page</param>
        /// <param name="sort">The sort mode.</param>
        /// <returns>InlineResponse20011</returns>
        InlineResponse20011 CommunityContentGetCommunityContent(NancyContext context, int? mediaFilter, int? page, int? sort);
    }

    /// <summary>
    /// Abstraction of CommunityContentService.
    /// </summary>
    public abstract class AbstractCommunityContentService: CommunityContentService
    {
        public virtual InlineResponse20011 CommunityContentGetCommunityContent(NancyContext context, int? mediaFilter, int? page, int? sort)
        {
            return CommunityContentGetCommunityContent(mediaFilter, page, sort);
        }

        protected abstract InlineResponse20011 CommunityContentGetCommunityContent(int? mediaFilter, int? page, int? sort);
    }

}
