/* 
 * Bungie.Net API
 *
 * These endpoints constitute the functionality exposed by Bungie.net, both for more traditional website functionality and for connectivity to Bungie video games and their related functionality.
 *
 * The version of the OpenAPI document: 2.8.0
 * Contact: support@bungie.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using BungieNetApi.Client;
using BungieNetApi.Api;
using BungieNetApi.Model;

namespace BungieNetApi.Test
{
    /// <summary>
    ///  Class for testing ContentApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ContentApiTests : IDisposable
    {
        private ContentApi instance;

        public ContentApiTests()
        {
            instance = new ContentApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ContentApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ContentApi
            //Assert.IsType(typeof(ContentApi), instance, "instance is a ContentApi");
        }

        
        /// <summary>
        /// Test ContentGetContentById
        /// </summary>
        [Fact]
        public void ContentGetContentByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //string locale = null;
            //bool? head = null;
            //var response = instance.ContentGetContentById(id, locale, head);
            //Assert.IsType<InlineResponse2008> (response, "response is InlineResponse2008");
        }
        
        /// <summary>
        /// Test ContentGetContentByTagAndType
        /// </summary>
        [Fact]
        public void ContentGetContentByTagAndTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string locale = null;
            //string tag = null;
            //string type = null;
            //bool? head = null;
            //var response = instance.ContentGetContentByTagAndType(locale, tag, type, head);
            //Assert.IsType<InlineResponse2008> (response, "response is InlineResponse2008");
        }
        
        /// <summary>
        /// Test ContentGetContentType
        /// </summary>
        [Fact]
        public void ContentGetContentTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string type = null;
            //var response = instance.ContentGetContentType(type);
            //Assert.IsType<InlineResponse2007> (response, "response is InlineResponse2007");
        }
        
        /// <summary>
        /// Test ContentSearchContentByTagAndType
        /// </summary>
        [Fact]
        public void ContentSearchContentByTagAndTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string locale = null;
            //string tag = null;
            //string type = null;
            //int? currentpage = null;
            //bool? head = null;
            //int? itemsperpage = null;
            //var response = instance.ContentSearchContentByTagAndType(locale, tag, type, currentpage, head, itemsperpage);
            //Assert.IsType<InlineResponse2009> (response, "response is InlineResponse2009");
        }
        
        /// <summary>
        /// Test ContentSearchContentWithText
        /// </summary>
        [Fact]
        public void ContentSearchContentWithTextTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string locale = null;
            //string ctype = null;
            //int? currentpage = null;
            //bool? head = null;
            //string searchtext = null;
            //string source = null;
            //string tag = null;
            //var response = instance.ContentSearchContentWithText(locale, ctype, currentpage, head, searchtext, source, tag);
            //Assert.IsType<InlineResponse2009> (response, "response is InlineResponse2009");
        }
        
        /// <summary>
        /// Test ContentSearchHelpArticles
        /// </summary>
        [Fact]
        public void ContentSearchHelpArticlesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string searchtext = null;
            //string size = null;
            //var response = instance.ContentSearchHelpArticles(searchtext, size);
            //Assert.IsType<InlineResponse20010> (response, "response is InlineResponse20010");
        }
        
    }

}