using System;
using System.Collections.Generic;
using RestSharp;
using Org.OpenAPITools.Client;
using BungieNetApi.Model;

namespace BungieNetApi.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IContentApi
    {
        /// <summary>
        ///  Returns a content item referenced by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="locale"></param>
        /// <param name="head">false</param>
        /// <returns>InlineResponse2008</returns>
        InlineResponse2008 ContentGetContentById (long? id, string locale, bool? head);
        /// <summary>
        ///  Returns the newest item that matches a given tag and Content Type.
        /// </summary>
        /// <param name="locale"></param>
        /// <param name="tag"></param>
        /// <param name="type"></param>
        /// <param name="head">Not used.</param>
        /// <returns>InlineResponse2008</returns>
        InlineResponse2008 ContentGetContentByTagAndType (string locale, string tag, string type, bool? head);
        /// <summary>
        ///  Gets an object describing a particular variant of content.
        /// </summary>
        /// <param name="type"></param>
        /// <returns>InlineResponse2007</returns>
        InlineResponse2007 ContentGetContentType (string type);
        /// <summary>
        ///  Searches for Content Items that match the given Tag and Content Type.
        /// </summary>
        /// <param name="locale"></param>
        /// <param name="tag"></param>
        /// <param name="type"></param>
        /// <param name="currentpage">Page number for the search results starting with page 1.</param>
        /// <param name="head">Not used.</param>
        /// <param name="itemsperpage">Not used.</param>
        /// <returns>InlineResponse2009</returns>
        InlineResponse2009 ContentSearchContentByTagAndType (string locale, string tag, string type, int? currentpage, bool? head, int? itemsperpage);
        /// <summary>
        ///  Gets content based on querystring information passed in. Provides basic search and text search capabilities.
        /// </summary>
        /// <param name="locale"></param>
        /// <param name="ctype">Content type tag: Help, News, etc. Supply multiple ctypes separated by space.</param>
        /// <param name="currentpage">Page number for the search results, starting with page 1.</param>
        /// <param name="head">Not used.</param>
        /// <param name="searchtext">Word or phrase for the search.</param>
        /// <param name="source">For analytics, hint at the part of the app that triggered the search. Optional.</param>
        /// <param name="tag">Tag used on the content to be searched.</param>
        /// <returns>InlineResponse2009</returns>
        InlineResponse2009 ContentSearchContentWithText (string locale, string ctype, int? currentpage, bool? head, string searchtext, string source, string tag);
        /// <summary>
        ///  Search for Help Articles.
        /// </summary>
        /// <param name="searchtext"></param>
        /// <param name="size"></param>
        /// <returns>InlineResponse20010</returns>
        InlineResponse20010 ContentSearchHelpArticles (string searchtext, string size);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ContentApi : IContentApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ContentApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ContentApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        ///  Returns a content item referenced by id
        /// </summary>
        /// <param name="id"></param> 
        /// <param name="locale"></param> 
        /// <param name="head">false</param> 
        /// <returns>InlineResponse2008</returns>            
        public InlineResponse2008 ContentGetContentById (long? id, string locale, bool? head)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ContentGetContentById");
            
            // verify the required parameter 'locale' is set
            if (locale == null) throw new ApiException(400, "Missing required parameter 'locale' when calling ContentGetContentById");
            
    
            var path = "/Content/GetContentById/{id}/{locale}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "locale" + "}", ApiClient.ParameterToString(locale));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (head != null) queryParams.Add("head", ApiClient.ParameterToString(head)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ContentGetContentById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ContentGetContentById: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2008) ApiClient.Deserialize(response.Content, typeof(InlineResponse2008), response.Headers);
        }
    
        /// <summary>
        ///  Returns the newest item that matches a given tag and Content Type.
        /// </summary>
        /// <param name="locale"></param> 
        /// <param name="tag"></param> 
        /// <param name="type"></param> 
        /// <param name="head">Not used.</param> 
        /// <returns>InlineResponse2008</returns>            
        public InlineResponse2008 ContentGetContentByTagAndType (string locale, string tag, string type, bool? head)
        {
            
            // verify the required parameter 'locale' is set
            if (locale == null) throw new ApiException(400, "Missing required parameter 'locale' when calling ContentGetContentByTagAndType");
            
            // verify the required parameter 'tag' is set
            if (tag == null) throw new ApiException(400, "Missing required parameter 'tag' when calling ContentGetContentByTagAndType");
            
            // verify the required parameter 'type' is set
            if (type == null) throw new ApiException(400, "Missing required parameter 'type' when calling ContentGetContentByTagAndType");
            
    
            var path = "/Content/GetContentByTagAndType/{tag}/{type}/{locale}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "locale" + "}", ApiClient.ParameterToString(locale));
path = path.Replace("{" + "tag" + "}", ApiClient.ParameterToString(tag));
path = path.Replace("{" + "type" + "}", ApiClient.ParameterToString(type));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (head != null) queryParams.Add("head", ApiClient.ParameterToString(head)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ContentGetContentByTagAndType: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ContentGetContentByTagAndType: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2008) ApiClient.Deserialize(response.Content, typeof(InlineResponse2008), response.Headers);
        }
    
        /// <summary>
        ///  Gets an object describing a particular variant of content.
        /// </summary>
        /// <param name="type"></param> 
        /// <returns>InlineResponse2007</returns>            
        public InlineResponse2007 ContentGetContentType (string type)
        {
            
            // verify the required parameter 'type' is set
            if (type == null) throw new ApiException(400, "Missing required parameter 'type' when calling ContentGetContentType");
            
    
            var path = "/Content/GetContentType/{type}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "type" + "}", ApiClient.ParameterToString(type));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ContentGetContentType: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ContentGetContentType: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2007) ApiClient.Deserialize(response.Content, typeof(InlineResponse2007), response.Headers);
        }
    
        /// <summary>
        ///  Searches for Content Items that match the given Tag and Content Type.
        /// </summary>
        /// <param name="locale"></param> 
        /// <param name="tag"></param> 
        /// <param name="type"></param> 
        /// <param name="currentpage">Page number for the search results starting with page 1.</param> 
        /// <param name="head">Not used.</param> 
        /// <param name="itemsperpage">Not used.</param> 
        /// <returns>InlineResponse2009</returns>            
        public InlineResponse2009 ContentSearchContentByTagAndType (string locale, string tag, string type, int? currentpage, bool? head, int? itemsperpage)
        {
            
            // verify the required parameter 'locale' is set
            if (locale == null) throw new ApiException(400, "Missing required parameter 'locale' when calling ContentSearchContentByTagAndType");
            
            // verify the required parameter 'tag' is set
            if (tag == null) throw new ApiException(400, "Missing required parameter 'tag' when calling ContentSearchContentByTagAndType");
            
            // verify the required parameter 'type' is set
            if (type == null) throw new ApiException(400, "Missing required parameter 'type' when calling ContentSearchContentByTagAndType");
            
    
            var path = "/Content/SearchContentByTagAndType/{tag}/{type}/{locale}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "locale" + "}", ApiClient.ParameterToString(locale));
path = path.Replace("{" + "tag" + "}", ApiClient.ParameterToString(tag));
path = path.Replace("{" + "type" + "}", ApiClient.ParameterToString(type));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (currentpage != null) queryParams.Add("currentpage", ApiClient.ParameterToString(currentpage)); // query parameter
 if (head != null) queryParams.Add("head", ApiClient.ParameterToString(head)); // query parameter
 if (itemsperpage != null) queryParams.Add("itemsperpage", ApiClient.ParameterToString(itemsperpage)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ContentSearchContentByTagAndType: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ContentSearchContentByTagAndType: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2009) ApiClient.Deserialize(response.Content, typeof(InlineResponse2009), response.Headers);
        }
    
        /// <summary>
        ///  Gets content based on querystring information passed in. Provides basic search and text search capabilities.
        /// </summary>
        /// <param name="locale"></param> 
        /// <param name="ctype">Content type tag: Help, News, etc. Supply multiple ctypes separated by space.</param> 
        /// <param name="currentpage">Page number for the search results, starting with page 1.</param> 
        /// <param name="head">Not used.</param> 
        /// <param name="searchtext">Word or phrase for the search.</param> 
        /// <param name="source">For analytics, hint at the part of the app that triggered the search. Optional.</param> 
        /// <param name="tag">Tag used on the content to be searched.</param> 
        /// <returns>InlineResponse2009</returns>            
        public InlineResponse2009 ContentSearchContentWithText (string locale, string ctype, int? currentpage, bool? head, string searchtext, string source, string tag)
        {
            
            // verify the required parameter 'locale' is set
            if (locale == null) throw new ApiException(400, "Missing required parameter 'locale' when calling ContentSearchContentWithText");
            
    
            var path = "/Content/Search/{locale}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "locale" + "}", ApiClient.ParameterToString(locale));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (ctype != null) queryParams.Add("ctype", ApiClient.ParameterToString(ctype)); // query parameter
 if (currentpage != null) queryParams.Add("currentpage", ApiClient.ParameterToString(currentpage)); // query parameter
 if (head != null) queryParams.Add("head", ApiClient.ParameterToString(head)); // query parameter
 if (searchtext != null) queryParams.Add("searchtext", ApiClient.ParameterToString(searchtext)); // query parameter
 if (source != null) queryParams.Add("source", ApiClient.ParameterToString(source)); // query parameter
 if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ContentSearchContentWithText: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ContentSearchContentWithText: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2009) ApiClient.Deserialize(response.Content, typeof(InlineResponse2009), response.Headers);
        }
    
        /// <summary>
        ///  Search for Help Articles.
        /// </summary>
        /// <param name="searchtext"></param> 
        /// <param name="size"></param> 
        /// <returns>InlineResponse20010</returns>            
        public InlineResponse20010 ContentSearchHelpArticles (string searchtext, string size)
        {
            
            // verify the required parameter 'searchtext' is set
            if (searchtext == null) throw new ApiException(400, "Missing required parameter 'searchtext' when calling ContentSearchHelpArticles");
            
            // verify the required parameter 'size' is set
            if (size == null) throw new ApiException(400, "Missing required parameter 'size' when calling ContentSearchHelpArticles");
            
    
            var path = "/Content/SearchHelpArticles/{searchtext}/{size}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "searchtext" + "}", ApiClient.ParameterToString(searchtext));
path = path.Replace("{" + "size" + "}", ApiClient.ParameterToString(size));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ContentSearchHelpArticles: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ContentSearchHelpArticles: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20010) ApiClient.Deserialize(response.Content, typeof(InlineResponse20010), response.Headers);
        }
    
    }
}
