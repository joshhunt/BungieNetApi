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
    /// Module processing requests of Forum domain.
    /// </summary>
    public sealed class ForumModule : NancyModule
    {
        /// <summary>
        /// Sets up HTTP methods mappings.
        /// </summary>
        /// <param name="service">Service handling requests</param>
        public ForumModule(ForumService service) : base("/Platform")
        { 
            Get["/Forum/GetCoreTopicsPaged/{page}/{sort}/{quickDate}/{categoryFilter}/"] = parameters =>
            {
                var categoryFilter = Parameters.ValueOf<int?>(parameters, Context.Request, "categoryFilter", ParameterType.Path);
                var page = Parameters.ValueOf<int?>(parameters, Context.Request, "page", ParameterType.Path);
                var quickDate = Parameters.ValueOf<int?>(parameters, Context.Request, "quickDate", ParameterType.Path);
                var sort = Parameters.ValueOf<int?>(parameters, Context.Request, "sort", ParameterType.Path);
                var locales = Parameters.ValueOf<string>(parameters, Context.Request, "locales", ParameterType.Query);
                Preconditions.IsNotNull(categoryFilter, "Required parameter: 'categoryFilter' is missing at 'ForumGetCoreTopicsPaged'");
                
                Preconditions.IsNotNull(page, "Required parameter: 'page' is missing at 'ForumGetCoreTopicsPaged'");
                
                Preconditions.IsNotNull(quickDate, "Required parameter: 'quickDate' is missing at 'ForumGetCoreTopicsPaged'");
                
                Preconditions.IsNotNull(sort, "Required parameter: 'sort' is missing at 'ForumGetCoreTopicsPaged'");
                
                return service.ForumGetCoreTopicsPaged(Context, categoryFilter, page, quickDate, sort, locales);
            };

            Get["/Forum/GetForumTagSuggestions/"] = parameters =>
            {
                var partialtag = Parameters.ValueOf<string>(parameters, Context.Request, "partialtag", ParameterType.Query);
                return service.ForumGetForumTagSuggestions(Context, partialtag);
            };

            Get["/Forum/Poll/{topicId}/"] = parameters =>
            {
                var topicId = Parameters.ValueOf<long?>(parameters, Context.Request, "topicId", ParameterType.Path);
                Preconditions.IsNotNull(topicId, "Required parameter: 'topicId' is missing at 'ForumGetPoll'");
                
                return service.ForumGetPoll(Context, topicId);
            };

            Get["/Forum/GetPostAndParent/{childPostId}/"] = parameters =>
            {
                var childPostId = Parameters.ValueOf<long?>(parameters, Context.Request, "childPostId", ParameterType.Path);
                var showbanned = Parameters.ValueOf<string>(parameters, Context.Request, "showbanned", ParameterType.Query);
                Preconditions.IsNotNull(childPostId, "Required parameter: 'childPostId' is missing at 'ForumGetPostAndParent'");
                
                return service.ForumGetPostAndParent(Context, childPostId, showbanned);
            };

            Get["/Forum/GetPostAndParentAwaitingApproval/{childPostId}/"] = parameters =>
            {
                var childPostId = Parameters.ValueOf<long?>(parameters, Context.Request, "childPostId", ParameterType.Path);
                var showbanned = Parameters.ValueOf<string>(parameters, Context.Request, "showbanned", ParameterType.Query);
                Preconditions.IsNotNull(childPostId, "Required parameter: 'childPostId' is missing at 'ForumGetPostAndParentAwaitingApproval'");
                
                return service.ForumGetPostAndParentAwaitingApproval(Context, childPostId, showbanned);
            };

            Get["/Forum/GetPostsThreadedPaged/{parentPostId}/{page}/{pageSize}/{replySize}/{getParentPost}/{rootThreadMode}/{sortMode}/"] = parameters =>
            {
                var getParentPost = Parameters.ValueOf<bool?>(parameters, Context.Request, "getParentPost", ParameterType.Path);
                var page = Parameters.ValueOf<int?>(parameters, Context.Request, "page", ParameterType.Path);
                var pageSize = Parameters.ValueOf<int?>(parameters, Context.Request, "pageSize", ParameterType.Path);
                var parentPostId = Parameters.ValueOf<long?>(parameters, Context.Request, "parentPostId", ParameterType.Path);
                var replySize = Parameters.ValueOf<int?>(parameters, Context.Request, "replySize", ParameterType.Path);
                var rootThreadMode = Parameters.ValueOf<bool?>(parameters, Context.Request, "rootThreadMode", ParameterType.Path);
                var sortMode = Parameters.ValueOf<int?>(parameters, Context.Request, "sortMode", ParameterType.Path);
                var showbanned = Parameters.ValueOf<string>(parameters, Context.Request, "showbanned", ParameterType.Query);
                Preconditions.IsNotNull(getParentPost, "Required parameter: 'getParentPost' is missing at 'ForumGetPostsThreadedPaged'");
                
                Preconditions.IsNotNull(page, "Required parameter: 'page' is missing at 'ForumGetPostsThreadedPaged'");
                
                Preconditions.IsNotNull(pageSize, "Required parameter: 'pageSize' is missing at 'ForumGetPostsThreadedPaged'");
                
                Preconditions.IsNotNull(parentPostId, "Required parameter: 'parentPostId' is missing at 'ForumGetPostsThreadedPaged'");
                
                Preconditions.IsNotNull(replySize, "Required parameter: 'replySize' is missing at 'ForumGetPostsThreadedPaged'");
                
                Preconditions.IsNotNull(rootThreadMode, "Required parameter: 'rootThreadMode' is missing at 'ForumGetPostsThreadedPaged'");
                
                Preconditions.IsNotNull(sortMode, "Required parameter: 'sortMode' is missing at 'ForumGetPostsThreadedPaged'");
                
                return service.ForumGetPostsThreadedPaged(Context, getParentPost, page, pageSize, parentPostId, replySize, rootThreadMode, sortMode, showbanned);
            };

            Get["/Forum/GetPostsThreadedPagedFromChild/{childPostId}/{page}/{pageSize}/{replySize}/{rootThreadMode}/{sortMode}/"] = parameters =>
            {
                var childPostId = Parameters.ValueOf<long?>(parameters, Context.Request, "childPostId", ParameterType.Path);
                var page = Parameters.ValueOf<int?>(parameters, Context.Request, "page", ParameterType.Path);
                var pageSize = Parameters.ValueOf<int?>(parameters, Context.Request, "pageSize", ParameterType.Path);
                var replySize = Parameters.ValueOf<int?>(parameters, Context.Request, "replySize", ParameterType.Path);
                var rootThreadMode = Parameters.ValueOf<bool?>(parameters, Context.Request, "rootThreadMode", ParameterType.Path);
                var sortMode = Parameters.ValueOf<int?>(parameters, Context.Request, "sortMode", ParameterType.Path);
                var showbanned = Parameters.ValueOf<string>(parameters, Context.Request, "showbanned", ParameterType.Query);
                Preconditions.IsNotNull(childPostId, "Required parameter: 'childPostId' is missing at 'ForumGetPostsThreadedPagedFromChild'");
                
                Preconditions.IsNotNull(page, "Required parameter: 'page' is missing at 'ForumGetPostsThreadedPagedFromChild'");
                
                Preconditions.IsNotNull(pageSize, "Required parameter: 'pageSize' is missing at 'ForumGetPostsThreadedPagedFromChild'");
                
                Preconditions.IsNotNull(replySize, "Required parameter: 'replySize' is missing at 'ForumGetPostsThreadedPagedFromChild'");
                
                Preconditions.IsNotNull(rootThreadMode, "Required parameter: 'rootThreadMode' is missing at 'ForumGetPostsThreadedPagedFromChild'");
                
                Preconditions.IsNotNull(sortMode, "Required parameter: 'sortMode' is missing at 'ForumGetPostsThreadedPagedFromChild'");
                
                return service.ForumGetPostsThreadedPagedFromChild(Context, childPostId, page, pageSize, replySize, rootThreadMode, sortMode, showbanned);
            };

            Post["/Forum/Recruit/Summaries/"] = parameters =>
            {
                
                return service.ForumGetRecruitmentThreadSummaries(Context);
            };

            Get["/Forum/GetTopicForContent/{contentId}/"] = parameters =>
            {
                var contentId = Parameters.ValueOf<long?>(parameters, Context.Request, "contentId", ParameterType.Path);
                Preconditions.IsNotNull(contentId, "Required parameter: 'contentId' is missing at 'ForumGetTopicForContent'");
                
                return service.ForumGetTopicForContent(Context, contentId);
            };

            Get["/Forum/GetTopicsPaged/{page}/{pageSize}/{group}/{sort}/{quickDate}/{categoryFilter}/"] = parameters =>
            {
                var categoryFilter = Parameters.ValueOf<int?>(parameters, Context.Request, "categoryFilter", ParameterType.Path);
                var group = Parameters.ValueOf<long?>(parameters, Context.Request, "group", ParameterType.Path);
                var page = Parameters.ValueOf<int?>(parameters, Context.Request, "page", ParameterType.Path);
                var pageSize = Parameters.ValueOf<int?>(parameters, Context.Request, "pageSize", ParameterType.Path);
                var quickDate = Parameters.ValueOf<int?>(parameters, Context.Request, "quickDate", ParameterType.Path);
                var sort = Parameters.ValueOf<int?>(parameters, Context.Request, "sort", ParameterType.Path);
                var locales = Parameters.ValueOf<string>(parameters, Context.Request, "locales", ParameterType.Query);
                var tagstring = Parameters.ValueOf<string>(parameters, Context.Request, "tagstring", ParameterType.Query);
                Preconditions.IsNotNull(categoryFilter, "Required parameter: 'categoryFilter' is missing at 'ForumGetTopicsPaged'");
                
                Preconditions.IsNotNull(group, "Required parameter: 'group' is missing at 'ForumGetTopicsPaged'");
                
                Preconditions.IsNotNull(page, "Required parameter: 'page' is missing at 'ForumGetTopicsPaged'");
                
                Preconditions.IsNotNull(pageSize, "Required parameter: 'pageSize' is missing at 'ForumGetTopicsPaged'");
                
                Preconditions.IsNotNull(quickDate, "Required parameter: 'quickDate' is missing at 'ForumGetTopicsPaged'");
                
                Preconditions.IsNotNull(sort, "Required parameter: 'sort' is missing at 'ForumGetTopicsPaged'");
                
                return service.ForumGetTopicsPaged(Context, categoryFilter, group, page, pageSize, quickDate, sort, locales, tagstring);
            };
        }
    }

    /// <summary>
    /// Service handling Forum requests.
    /// </summary>
    public interface ForumService
    {
        /// <summary>
        /// Gets a listing of all topics marked as part of the core group.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="categoryFilter">The category filter.</param>
        /// <param name="page">Zero base page</param>
        /// <param name="quickDate">The date filter.</param>
        /// <param name="sort">The sort mode.</param>
        /// <param name="locales">Comma seperated list of locales posts must match to return in the result list. Default &#39;en&#39; (optional)</param>
        /// <returns>InlineResponse20011</returns>
        InlineResponse20011 ForumGetCoreTopicsPaged(NancyContext context, int? categoryFilter, int? page, int? quickDate, int? sort, string locales);

        /// <summary>
        /// Gets tag suggestions based on partial text entry, matching them with other tags previously used in the forums.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="partialtag">The partial tag input to generate suggestions from. (optional)</param>
        /// <returns>InlineResponse20013</returns>
        InlineResponse20013 ForumGetForumTagSuggestions(NancyContext context, string partialtag);

        /// <summary>
        /// Gets the specified forum poll.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="topicId">The post id of the topic that has the poll.</param>
        /// <returns>InlineResponse20011</returns>
        InlineResponse20011 ForumGetPoll(NancyContext context, long? topicId);

        /// <summary>
        /// Returns the post specified and its immediate parent.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="childPostId"></param>
        /// <param name="showbanned">If this value is not null or empty, banned posts are requested to be returned (optional)</param>
        /// <returns>InlineResponse20011</returns>
        InlineResponse20011 ForumGetPostAndParent(NancyContext context, long? childPostId, string showbanned);

        /// <summary>
        /// Returns the post specified and its immediate parent of posts that are awaiting approval.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="childPostId"></param>
        /// <param name="showbanned">If this value is not null or empty, banned posts are requested to be returned (optional)</param>
        /// <returns>InlineResponse20011</returns>
        InlineResponse20011 ForumGetPostAndParentAwaitingApproval(NancyContext context, long? childPostId, string showbanned);

        /// <summary>
        /// Returns a thread of posts at the given parent, optionally returning replies to those posts as well as the original parent.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="getParentPost"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="parentPostId"></param>
        /// <param name="replySize"></param>
        /// <param name="rootThreadMode"></param>
        /// <param name="sortMode"></param>
        /// <param name="showbanned">If this value is not null or empty, banned posts are requested to be returned (optional)</param>
        /// <returns>InlineResponse20011</returns>
        InlineResponse20011 ForumGetPostsThreadedPaged(NancyContext context, bool? getParentPost, int? page, int? pageSize, long? parentPostId, int? replySize, bool? rootThreadMode, int? sortMode, string showbanned);

        /// <summary>
        /// Returns a thread of posts starting at the topicId of the input childPostId, optionally returning replies to those posts as well as the original parent.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="childPostId"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="replySize"></param>
        /// <param name="rootThreadMode"></param>
        /// <param name="sortMode"></param>
        /// <param name="showbanned">If this value is not null or empty, banned posts are requested to be returned (optional)</param>
        /// <returns>InlineResponse20011</returns>
        InlineResponse20011 ForumGetPostsThreadedPagedFromChild(NancyContext context, long? childPostId, int? page, int? pageSize, int? replySize, bool? rootThreadMode, int? sortMode, string showbanned);

        /// <summary>
        /// Allows the caller to get a list of to 25 recruitment thread summary information objects.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <returns>InlineResponse20014</returns>
        InlineResponse20014 ForumGetRecruitmentThreadSummaries(NancyContext context);

        /// <summary>
        /// Gets the post Id for the given content item&#39;s comments, if it exists.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="contentId"></param>
        /// <returns>InlineResponse20012</returns>
        InlineResponse20012 ForumGetTopicForContent(NancyContext context, long? contentId);

        /// <summary>
        /// Get topics from any forum.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="categoryFilter">A category filter</param>
        /// <param name="group">The group, if any.</param>
        /// <param name="page">Zero paged page number</param>
        /// <param name="pageSize">Unused</param>
        /// <param name="quickDate">A date filter.</param>
        /// <param name="sort">The sort mode.</param>
        /// <param name="locales">Comma seperated list of locales posts must match to return in the result list. Default &#39;en&#39; (optional)</param>
        /// <param name="tagstring">The tags to search, if any. (optional)</param>
        /// <returns>InlineResponse20011</returns>
        InlineResponse20011 ForumGetTopicsPaged(NancyContext context, int? categoryFilter, long? group, int? page, int? pageSize, int? quickDate, int? sort, string locales, string tagstring);
    }

    /// <summary>
    /// Abstraction of ForumService.
    /// </summary>
    public abstract class AbstractForumService: ForumService
    {
        public virtual InlineResponse20011 ForumGetCoreTopicsPaged(NancyContext context, int? categoryFilter, int? page, int? quickDate, int? sort, string locales)
        {
            return ForumGetCoreTopicsPaged(categoryFilter, page, quickDate, sort, locales);
        }

        public virtual InlineResponse20013 ForumGetForumTagSuggestions(NancyContext context, string partialtag)
        {
            return ForumGetForumTagSuggestions(partialtag);
        }

        public virtual InlineResponse20011 ForumGetPoll(NancyContext context, long? topicId)
        {
            return ForumGetPoll(topicId);
        }

        public virtual InlineResponse20011 ForumGetPostAndParent(NancyContext context, long? childPostId, string showbanned)
        {
            return ForumGetPostAndParent(childPostId, showbanned);
        }

        public virtual InlineResponse20011 ForumGetPostAndParentAwaitingApproval(NancyContext context, long? childPostId, string showbanned)
        {
            return ForumGetPostAndParentAwaitingApproval(childPostId, showbanned);
        }

        public virtual InlineResponse20011 ForumGetPostsThreadedPaged(NancyContext context, bool? getParentPost, int? page, int? pageSize, long? parentPostId, int? replySize, bool? rootThreadMode, int? sortMode, string showbanned)
        {
            return ForumGetPostsThreadedPaged(getParentPost, page, pageSize, parentPostId, replySize, rootThreadMode, sortMode, showbanned);
        }

        public virtual InlineResponse20011 ForumGetPostsThreadedPagedFromChild(NancyContext context, long? childPostId, int? page, int? pageSize, int? replySize, bool? rootThreadMode, int? sortMode, string showbanned)
        {
            return ForumGetPostsThreadedPagedFromChild(childPostId, page, pageSize, replySize, rootThreadMode, sortMode, showbanned);
        }

        public virtual InlineResponse20014 ForumGetRecruitmentThreadSummaries(NancyContext context)
        {
            return ForumGetRecruitmentThreadSummaries();
        }

        public virtual InlineResponse20012 ForumGetTopicForContent(NancyContext context, long? contentId)
        {
            return ForumGetTopicForContent(contentId);
        }

        public virtual InlineResponse20011 ForumGetTopicsPaged(NancyContext context, int? categoryFilter, long? group, int? page, int? pageSize, int? quickDate, int? sort, string locales, string tagstring)
        {
            return ForumGetTopicsPaged(categoryFilter, group, page, pageSize, quickDate, sort, locales, tagstring);
        }

        protected abstract InlineResponse20011 ForumGetCoreTopicsPaged(int? categoryFilter, int? page, int? quickDate, int? sort, string locales);

        protected abstract InlineResponse20013 ForumGetForumTagSuggestions(string partialtag);

        protected abstract InlineResponse20011 ForumGetPoll(long? topicId);

        protected abstract InlineResponse20011 ForumGetPostAndParent(long? childPostId, string showbanned);

        protected abstract InlineResponse20011 ForumGetPostAndParentAwaitingApproval(long? childPostId, string showbanned);

        protected abstract InlineResponse20011 ForumGetPostsThreadedPaged(bool? getParentPost, int? page, int? pageSize, long? parentPostId, int? replySize, bool? rootThreadMode, int? sortMode, string showbanned);

        protected abstract InlineResponse20011 ForumGetPostsThreadedPagedFromChild(long? childPostId, int? page, int? pageSize, int? replySize, bool? rootThreadMode, int? sortMode, string showbanned);

        protected abstract InlineResponse20014 ForumGetRecruitmentThreadSummaries();

        protected abstract InlineResponse20012 ForumGetTopicForContent(long? contentId);

        protected abstract InlineResponse20011 ForumGetTopicsPaged(int? categoryFilter, long? group, int? page, int? pageSize, int? quickDate, int? sort, string locales, string tagstring);
    }

}
