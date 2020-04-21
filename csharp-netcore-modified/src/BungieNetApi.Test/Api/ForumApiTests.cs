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
    ///  Class for testing ForumApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ForumApiTests : IDisposable
    {
        private ForumApi instance;

        public ForumApiTests()
        {
            instance = new ForumApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ForumApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ForumApi
            //Assert.IsType(typeof(ForumApi), instance, "instance is a ForumApi");
        }

        
        /// <summary>
        /// Test ForumGetCoreTopicsPaged
        /// </summary>
        [Fact]
        public void ForumGetCoreTopicsPagedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int categoryFilter = null;
            //int page = null;
            //int quickDate = null;
            //int sort = null;
            //string locales = null;
            //var response = instance.ForumGetCoreTopicsPaged(categoryFilter, page, quickDate, sort, locales);
            //Assert.IsType<InlineResponse20011> (response, "response is InlineResponse20011");
        }
        
        /// <summary>
        /// Test ForumGetForumTagSuggestions
        /// </summary>
        [Fact]
        public void ForumGetForumTagSuggestionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string partialtag = null;
            //var response = instance.ForumGetForumTagSuggestions(partialtag);
            //Assert.IsType<InlineResponse20013> (response, "response is InlineResponse20013");
        }
        
        /// <summary>
        /// Test ForumGetPoll
        /// </summary>
        [Fact]
        public void ForumGetPollTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long topicId = null;
            //var response = instance.ForumGetPoll(topicId);
            //Assert.IsType<InlineResponse20011> (response, "response is InlineResponse20011");
        }
        
        /// <summary>
        /// Test ForumGetPostAndParent
        /// </summary>
        [Fact]
        public void ForumGetPostAndParentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long childPostId = null;
            //string showbanned = null;
            //var response = instance.ForumGetPostAndParent(childPostId, showbanned);
            //Assert.IsType<InlineResponse20011> (response, "response is InlineResponse20011");
        }
        
        /// <summary>
        /// Test ForumGetPostAndParentAwaitingApproval
        /// </summary>
        [Fact]
        public void ForumGetPostAndParentAwaitingApprovalTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long childPostId = null;
            //string showbanned = null;
            //var response = instance.ForumGetPostAndParentAwaitingApproval(childPostId, showbanned);
            //Assert.IsType<InlineResponse20011> (response, "response is InlineResponse20011");
        }
        
        /// <summary>
        /// Test ForumGetPostsThreadedPaged
        /// </summary>
        [Fact]
        public void ForumGetPostsThreadedPagedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool getParentPost = null;
            //int page = null;
            //int pageSize = null;
            //long parentPostId = null;
            //int replySize = null;
            //bool rootThreadMode = null;
            //int sortMode = null;
            //string showbanned = null;
            //var response = instance.ForumGetPostsThreadedPaged(getParentPost, page, pageSize, parentPostId, replySize, rootThreadMode, sortMode, showbanned);
            //Assert.IsType<InlineResponse20011> (response, "response is InlineResponse20011");
        }
        
        /// <summary>
        /// Test ForumGetPostsThreadedPagedFromChild
        /// </summary>
        [Fact]
        public void ForumGetPostsThreadedPagedFromChildTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long childPostId = null;
            //int page = null;
            //int pageSize = null;
            //int replySize = null;
            //bool rootThreadMode = null;
            //int sortMode = null;
            //string showbanned = null;
            //var response = instance.ForumGetPostsThreadedPagedFromChild(childPostId, page, pageSize, replySize, rootThreadMode, sortMode, showbanned);
            //Assert.IsType<InlineResponse20011> (response, "response is InlineResponse20011");
        }
        
        /// <summary>
        /// Test ForumGetRecruitmentThreadSummaries
        /// </summary>
        [Fact]
        public void ForumGetRecruitmentThreadSummariesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ForumGetRecruitmentThreadSummaries();
            //Assert.IsType<InlineResponse20014> (response, "response is InlineResponse20014");
        }
        
        /// <summary>
        /// Test ForumGetTopicForContent
        /// </summary>
        [Fact]
        public void ForumGetTopicForContentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long contentId = null;
            //var response = instance.ForumGetTopicForContent(contentId);
            //Assert.IsType<InlineResponse20012> (response, "response is InlineResponse20012");
        }
        
        /// <summary>
        /// Test ForumGetTopicsPaged
        /// </summary>
        [Fact]
        public void ForumGetTopicsPagedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int categoryFilter = null;
            //long group = null;
            //int page = null;
            //int pageSize = null;
            //int quickDate = null;
            //int sort = null;
            //string locales = null;
            //string tagstring = null;
            //var response = instance.ForumGetTopicsPaged(categoryFilter, group, page, pageSize, quickDate, sort, locales, tagstring);
            //Assert.IsType<InlineResponse20011> (response, "response is InlineResponse20011");
        }
        
    }

}