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
    /// Module processing requests of Trending domain.
    /// </summary>
    public sealed class TrendingModule : NancyModule
    {
        /// <summary>
        /// Sets up HTTP methods mappings.
        /// </summary>
        /// <param name="service">Service handling requests</param>
        public TrendingModule(TrendingService service) : base("/Platform")
        { 
            Get["/Trending/Categories/"] = parameters =>
            {
                
                return service.TrendingGetTrendingCategories(Context);
            };

            Get["/Trending/Categories/{categoryId}/{pageNumber}/"] = parameters =>
            {
                var categoryId = Parameters.ValueOf<string>(parameters, Context.Request, "categoryId", ParameterType.Path);
                var pageNumber = Parameters.ValueOf<int?>(parameters, Context.Request, "pageNumber", ParameterType.Path);
                Preconditions.IsNotNull(categoryId, "Required parameter: 'categoryId' is missing at 'TrendingGetTrendingCategory'");
                
                Preconditions.IsNotNull(pageNumber, "Required parameter: 'pageNumber' is missing at 'TrendingGetTrendingCategory'");
                
                return service.TrendingGetTrendingCategory(Context, categoryId, pageNumber);
            };

            Get["/Trending/Details/{trendingEntryType}/{identifier}/"] = parameters =>
            {
                var identifier = Parameters.ValueOf<string>(parameters, Context.Request, "identifier", ParameterType.Path);
                var trendingEntryType = Parameters.ValueOf<int?>(parameters, Context.Request, "trendingEntryType", ParameterType.Path);
                Preconditions.IsNotNull(identifier, "Required parameter: 'identifier' is missing at 'TrendingGetTrendingEntryDetail'");
                
                Preconditions.IsNotNull(trendingEntryType, "Required parameter: 'trendingEntryType' is missing at 'TrendingGetTrendingEntryDetail'");
                
                return service.TrendingGetTrendingEntryDetail(Context, identifier, trendingEntryType);
            };
        }
    }

    /// <summary>
    /// Service handling Trending requests.
    /// </summary>
    public interface TrendingService
    {
        /// <summary>
        /// Returns trending items for Bungie.net, collapsed into the first page of items per category. For pagination within a category, call GetTrendingCategory.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <returns>InlineResponse20061</returns>
        InlineResponse20061 TrendingGetTrendingCategories(NancyContext context);

        /// <summary>
        /// Returns paginated lists of trending items for a category.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="categoryId">The ID of the category for whom you want additional results.</param>
        /// <param name="pageNumber">The page # of results to return.</param>
        /// <returns>InlineResponse20062</returns>
        InlineResponse20062 TrendingGetTrendingCategory(NancyContext context, string categoryId, int? pageNumber);

        /// <summary>
        /// Returns the detailed results for a specific trending entry. Note that trending entries are uniquely identified by a combination of *both* the TrendingEntryType *and* the identifier: the identifier alone is not guaranteed to be globally unique.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="identifier">The identifier for the entity to be returned.</param>
        /// <param name="trendingEntryType">The type of entity to be returned.</param>
        /// <returns>InlineResponse20063</returns>
        InlineResponse20063 TrendingGetTrendingEntryDetail(NancyContext context, string identifier, int? trendingEntryType);
    }

    /// <summary>
    /// Abstraction of TrendingService.
    /// </summary>
    public abstract class AbstractTrendingService: TrendingService
    {
        public virtual InlineResponse20061 TrendingGetTrendingCategories(NancyContext context)
        {
            return TrendingGetTrendingCategories();
        }

        public virtual InlineResponse20062 TrendingGetTrendingCategory(NancyContext context, string categoryId, int? pageNumber)
        {
            return TrendingGetTrendingCategory(categoryId, pageNumber);
        }

        public virtual InlineResponse20063 TrendingGetTrendingEntryDetail(NancyContext context, string identifier, int? trendingEntryType)
        {
            return TrendingGetTrendingEntryDetail(identifier, trendingEntryType);
        }

        protected abstract InlineResponse20061 TrendingGetTrendingCategories();

        protected abstract InlineResponse20062 TrendingGetTrendingCategory(string categoryId, int? pageNumber);

        protected abstract InlineResponse20063 TrendingGetTrendingEntryDetail(string identifier, int? trendingEntryType);
    }

}
