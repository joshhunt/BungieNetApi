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
    /// Module processing requests of Content domain.
    /// </summary>
    public sealed class ContentModule : NancyModule
    {
        /// <summary>
        /// Sets up HTTP methods mappings.
        /// </summary>
        /// <param name="service">Service handling requests</param>
        public ContentModule(ContentService service) : base("/Platform")
        { 
            Get["/Content/GetContentById/{id}/{locale}/"] = parameters =>
            {
                var id = Parameters.ValueOf<long?>(parameters, Context.Request, "id", ParameterType.Path);
                var locale = Parameters.ValueOf<string>(parameters, Context.Request, "locale", ParameterType.Path);
                var head = Parameters.ValueOf<bool?>(parameters, Context.Request, "head", ParameterType.Query);
                Preconditions.IsNotNull(id, "Required parameter: 'id' is missing at 'ContentGetContentById'");
                
                Preconditions.IsNotNull(locale, "Required parameter: 'locale' is missing at 'ContentGetContentById'");
                
                return service.ContentGetContentById(Context, id, locale, head);
            };

            Get["/Content/GetContentByTagAndType/{tag}/{type}/{locale}/"] = parameters =>
            {
                var locale = Parameters.ValueOf<string>(parameters, Context.Request, "locale", ParameterType.Path);
                var tag = Parameters.ValueOf<string>(parameters, Context.Request, "tag", ParameterType.Path);
                var type = Parameters.ValueOf<string>(parameters, Context.Request, "type", ParameterType.Path);
                var head = Parameters.ValueOf<bool?>(parameters, Context.Request, "head", ParameterType.Query);
                Preconditions.IsNotNull(locale, "Required parameter: 'locale' is missing at 'ContentGetContentByTagAndType'");
                
                Preconditions.IsNotNull(tag, "Required parameter: 'tag' is missing at 'ContentGetContentByTagAndType'");
                
                Preconditions.IsNotNull(type, "Required parameter: 'type' is missing at 'ContentGetContentByTagAndType'");
                
                return service.ContentGetContentByTagAndType(Context, locale, tag, type, head);
            };

            Get["/Content/GetContentType/{type}/"] = parameters =>
            {
                var type = Parameters.ValueOf<string>(parameters, Context.Request, "type", ParameterType.Path);
                Preconditions.IsNotNull(type, "Required parameter: 'type' is missing at 'ContentGetContentType'");
                
                return service.ContentGetContentType(Context, type);
            };

            Get["/Content/SearchContentByTagAndType/{tag}/{type}/{locale}/"] = parameters =>
            {
                var locale = Parameters.ValueOf<string>(parameters, Context.Request, "locale", ParameterType.Path);
                var tag = Parameters.ValueOf<string>(parameters, Context.Request, "tag", ParameterType.Path);
                var type = Parameters.ValueOf<string>(parameters, Context.Request, "type", ParameterType.Path);
                var currentpage = Parameters.ValueOf<int?>(parameters, Context.Request, "currentpage", ParameterType.Query);
                var head = Parameters.ValueOf<bool?>(parameters, Context.Request, "head", ParameterType.Query);
                var itemsperpage = Parameters.ValueOf<int?>(parameters, Context.Request, "itemsperpage", ParameterType.Query);
                Preconditions.IsNotNull(locale, "Required parameter: 'locale' is missing at 'ContentSearchContentByTagAndType'");
                
                Preconditions.IsNotNull(tag, "Required parameter: 'tag' is missing at 'ContentSearchContentByTagAndType'");
                
                Preconditions.IsNotNull(type, "Required parameter: 'type' is missing at 'ContentSearchContentByTagAndType'");
                
                return service.ContentSearchContentByTagAndType(Context, locale, tag, type, currentpage, head, itemsperpage);
            };

            Get["/Content/Search/{locale}/"] = parameters =>
            {
                var locale = Parameters.ValueOf<string>(parameters, Context.Request, "locale", ParameterType.Path);
                var ctype = Parameters.ValueOf<string>(parameters, Context.Request, "ctype", ParameterType.Query);
                var currentpage = Parameters.ValueOf<int?>(parameters, Context.Request, "currentpage", ParameterType.Query);
                var head = Parameters.ValueOf<bool?>(parameters, Context.Request, "head", ParameterType.Query);
                var searchtext = Parameters.ValueOf<string>(parameters, Context.Request, "searchtext", ParameterType.Query);
                var source = Parameters.ValueOf<string>(parameters, Context.Request, "source", ParameterType.Query);
                var tag = Parameters.ValueOf<string>(parameters, Context.Request, "tag", ParameterType.Query);
                Preconditions.IsNotNull(locale, "Required parameter: 'locale' is missing at 'ContentSearchContentWithText'");
                
                return service.ContentSearchContentWithText(Context, locale, ctype, currentpage, head, searchtext, source, tag);
            };

            Get["/Content/SearchHelpArticles/{searchtext}/{size}/"] = parameters =>
            {
                var searchtext = Parameters.ValueOf<string>(parameters, Context.Request, "searchtext", ParameterType.Path);
                var size = Parameters.ValueOf<string>(parameters, Context.Request, "size", ParameterType.Path);
                Preconditions.IsNotNull(searchtext, "Required parameter: 'searchtext' is missing at 'ContentSearchHelpArticles'");
                
                Preconditions.IsNotNull(size, "Required parameter: 'size' is missing at 'ContentSearchHelpArticles'");
                
                return service.ContentSearchHelpArticles(Context, searchtext, size);
            };
        }
    }

    /// <summary>
    /// Service handling Content requests.
    /// </summary>
    public interface ContentService
    {
        /// <summary>
        /// Returns a content item referenced by id
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="id"></param>
        /// <param name="locale"></param>
        /// <param name="head">false (optional)</param>
        /// <returns>InlineResponse2008</returns>
        InlineResponse2008 ContentGetContentById(NancyContext context, long? id, string locale, bool? head);

        /// <summary>
        /// Returns the newest item that matches a given tag and Content Type.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="locale"></param>
        /// <param name="tag"></param>
        /// <param name="type"></param>
        /// <param name="head">Not used. (optional)</param>
        /// <returns>InlineResponse2008</returns>
        InlineResponse2008 ContentGetContentByTagAndType(NancyContext context, string locale, string tag, string type, bool? head);

        /// <summary>
        /// Gets an object describing a particular variant of content.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="type"></param>
        /// <returns>InlineResponse2007</returns>
        InlineResponse2007 ContentGetContentType(NancyContext context, string type);

        /// <summary>
        /// Searches for Content Items that match the given Tag and Content Type.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="locale"></param>
        /// <param name="tag"></param>
        /// <param name="type"></param>
        /// <param name="currentpage">Page number for the search results starting with page 1. (optional)</param>
        /// <param name="head">Not used. (optional)</param>
        /// <param name="itemsperpage">Not used. (optional)</param>
        /// <returns>InlineResponse2009</returns>
        InlineResponse2009 ContentSearchContentByTagAndType(NancyContext context, string locale, string tag, string type, int? currentpage, bool? head, int? itemsperpage);

        /// <summary>
        /// Gets content based on querystring information passed in. Provides basic search and text search capabilities.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="locale"></param>
        /// <param name="ctype">Content type tag: Help, News, etc. Supply multiple ctypes separated by space. (optional)</param>
        /// <param name="currentpage">Page number for the search results, starting with page 1. (optional)</param>
        /// <param name="head">Not used. (optional)</param>
        /// <param name="searchtext">Word or phrase for the search. (optional)</param>
        /// <param name="source">For analytics, hint at the part of the app that triggered the search. Optional. (optional)</param>
        /// <param name="tag">Tag used on the content to be searched. (optional)</param>
        /// <returns>InlineResponse2009</returns>
        InlineResponse2009 ContentSearchContentWithText(NancyContext context, string locale, string ctype, int? currentpage, bool? head, string searchtext, string source, string tag);

        /// <summary>
        /// Search for Help Articles.
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="searchtext"></param>
        /// <param name="size"></param>
        /// <returns>InlineResponse20010</returns>
        InlineResponse20010 ContentSearchHelpArticles(NancyContext context, string searchtext, string size);
    }

    /// <summary>
    /// Abstraction of ContentService.
    /// </summary>
    public abstract class AbstractContentService: ContentService
    {
        public virtual InlineResponse2008 ContentGetContentById(NancyContext context, long? id, string locale, bool? head)
        {
            return ContentGetContentById(id, locale, head);
        }

        public virtual InlineResponse2008 ContentGetContentByTagAndType(NancyContext context, string locale, string tag, string type, bool? head)
        {
            return ContentGetContentByTagAndType(locale, tag, type, head);
        }

        public virtual InlineResponse2007 ContentGetContentType(NancyContext context, string type)
        {
            return ContentGetContentType(type);
        }

        public virtual InlineResponse2009 ContentSearchContentByTagAndType(NancyContext context, string locale, string tag, string type, int? currentpage, bool? head, int? itemsperpage)
        {
            return ContentSearchContentByTagAndType(locale, tag, type, currentpage, head, itemsperpage);
        }

        public virtual InlineResponse2009 ContentSearchContentWithText(NancyContext context, string locale, string ctype, int? currentpage, bool? head, string searchtext, string source, string tag)
        {
            return ContentSearchContentWithText(locale, ctype, currentpage, head, searchtext, source, tag);
        }

        public virtual InlineResponse20010 ContentSearchHelpArticles(NancyContext context, string searchtext, string size)
        {
            return ContentSearchHelpArticles(searchtext, size);
        }

        protected abstract InlineResponse2008 ContentGetContentById(long? id, string locale, bool? head);

        protected abstract InlineResponse2008 ContentGetContentByTagAndType(string locale, string tag, string type, bool? head);

        protected abstract InlineResponse2007 ContentGetContentType(string type);

        protected abstract InlineResponse2009 ContentSearchContentByTagAndType(string locale, string tag, string type, int? currentpage, bool? head, int? itemsperpage);

        protected abstract InlineResponse2009 ContentSearchContentWithText(string locale, string ctype, int? currentpage, bool? head, string searchtext, string source, string tag);

        protected abstract InlineResponse20010 ContentSearchHelpArticles(string searchtext, string size);
    }

}
