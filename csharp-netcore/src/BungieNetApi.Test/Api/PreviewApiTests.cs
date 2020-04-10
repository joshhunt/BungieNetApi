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
    ///  Class for testing PreviewApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PreviewApiTests : IDisposable
    {
        private PreviewApi instance;

        public PreviewApiTests()
        {
            instance = new PreviewApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PreviewApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PreviewApi
            //Assert.IsType(typeof(PreviewApi), instance, "instance is a PreviewApi");
        }

        
        /// <summary>
        /// Test Destiny2GetClanAggregateStats
        /// </summary>
        [Fact]
        public void Destiny2GetClanAggregateStatsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long groupId = null;
            //string modes = null;
            //var response = instance.Destiny2GetClanAggregateStats(groupId, modes);
            //Assert.IsType<InlineResponse20050> (response, "response is InlineResponse20050");
        }
        
        /// <summary>
        /// Test Destiny2GetClanLeaderboards
        /// </summary>
        [Fact]
        public void Destiny2GetClanLeaderboardsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long groupId = null;
            //int? maxtop = null;
            //string modes = null;
            //string statid = null;
            //var response = instance.Destiny2GetClanLeaderboards(groupId, maxtop, modes, statid);
            //Assert.IsType<InlineResponse20049> (response, "response is InlineResponse20049");
        }
        
        /// <summary>
        /// Test Destiny2GetLeaderboards
        /// </summary>
        [Fact]
        public void Destiny2GetLeaderboardsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long destinyMembershipId = null;
            //int membershipType = null;
            //int? maxtop = null;
            //string modes = null;
            //string statid = null;
            //var response = instance.Destiny2GetLeaderboards(destinyMembershipId, membershipType, maxtop, modes, statid);
            //Assert.IsType<InlineResponse20049> (response, "response is InlineResponse20049");
        }
        
        /// <summary>
        /// Test Destiny2GetLeaderboardsForCharacter
        /// </summary>
        [Fact]
        public void Destiny2GetLeaderboardsForCharacterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long characterId = null;
            //long destinyMembershipId = null;
            //int membershipType = null;
            //int? maxtop = null;
            //string modes = null;
            //string statid = null;
            //var response = instance.Destiny2GetLeaderboardsForCharacter(characterId, destinyMembershipId, membershipType, maxtop, modes, statid);
            //Assert.IsType<InlineResponse20049> (response, "response is InlineResponse20049");
        }
        
        /// <summary>
        /// Test Destiny2GetPublicVendors
        /// </summary>
        [Fact]
        public void Destiny2GetPublicVendorsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<int> components = null;
            //var response = instance.Destiny2GetPublicVendors(components);
            //Assert.IsType<InlineResponse20043> (response, "response is InlineResponse20043");
        }
        
        /// <summary>
        /// Test Destiny2InsertSocketPlug
        /// </summary>
        [Fact]
        public void Destiny2InsertSocketPlugTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.Destiny2InsertSocketPlug();
            //Assert.IsType<InlineResponse20046> (response, "response is InlineResponse20046");
        }
        
    }

}
