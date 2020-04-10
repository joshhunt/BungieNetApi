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
    ///  Class for testing DefaultApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DefaultApiTests : IDisposable
    {
        private DefaultApi instance;

        public DefaultApiTests()
        {
            instance = new DefaultApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DefaultApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DefaultApi
            //Assert.IsType(typeof(DefaultApi), instance, "instance is a DefaultApi");
        }

        
        /// <summary>
        /// Test GetAvailableLocales
        /// </summary>
        [Fact]
        public void GetAvailableLocalesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAvailableLocales();
            //Assert.IsType<InlineResponse20015> (response, "response is InlineResponse20015");
        }
        
        /// <summary>
        /// Test GetCommonSettings
        /// </summary>
        [Fact]
        public void GetCommonSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetCommonSettings();
            //Assert.IsType<InlineResponse20067> (response, "response is InlineResponse20067");
        }
        
        /// <summary>
        /// Test GetGlobalAlerts
        /// </summary>
        [Fact]
        public void GetGlobalAlertsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? includestreaming = null;
            //var response = instance.GetGlobalAlerts(includestreaming);
            //Assert.IsType<InlineResponse20068> (response, "response is InlineResponse20068");
        }
        
    }

}
