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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = BungieNetApi.Client.OpenAPIDateConverter;

namespace BungieNetApi.Model
{
    /// <summary>
    /// Defines Destiny.DestinyTalentNodeState
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum DestinyDestinyTalentNodeState
    {
        /// <summary>
        /// Enum NUMBER_0 for value: 0
        /// </summary>
        [EnumMember(Value = "0")]
        NUMBER_0 = 1,

        /// <summary>
        /// Enum NUMBER_1 for value: 1
        /// </summary>
        [EnumMember(Value = "1")]
        NUMBER_1 = 2,

        /// <summary>
        /// Enum NUMBER_2 for value: 2
        /// </summary>
        [EnumMember(Value = "2")]
        NUMBER_2 = 3,

        /// <summary>
        /// Enum NUMBER_3 for value: 3
        /// </summary>
        [EnumMember(Value = "3")]
        NUMBER_3 = 4,

        /// <summary>
        /// Enum NUMBER_4 for value: 4
        /// </summary>
        [EnumMember(Value = "4")]
        NUMBER_4 = 5,

        /// <summary>
        /// Enum NUMBER_5 for value: 5
        /// </summary>
        [EnumMember(Value = "5")]
        NUMBER_5 = 6,

        /// <summary>
        /// Enum NUMBER_6 for value: 6
        /// </summary>
        [EnumMember(Value = "6")]
        NUMBER_6 = 7,

        /// <summary>
        /// Enum NUMBER_7 for value: 7
        /// </summary>
        [EnumMember(Value = "7")]
        NUMBER_7 = 8,

        /// <summary>
        /// Enum NUMBER_8 for value: 8
        /// </summary>
        [EnumMember(Value = "8")]
        NUMBER_8 = 9,

        /// <summary>
        /// Enum NUMBER_9 for value: 9
        /// </summary>
        [EnumMember(Value = "9")]
        NUMBER_9 = 10,

        /// <summary>
        /// Enum NUMBER_10 for value: 10
        /// </summary>
        [EnumMember(Value = "10")]
        NUMBER_10 = 11,

        /// <summary>
        /// Enum NUMBER_11 for value: 11
        /// </summary>
        [EnumMember(Value = "11")]
        NUMBER_11 = 12,

        /// <summary>
        /// Enum NUMBER_12 for value: 12
        /// </summary>
        [EnumMember(Value = "12")]
        NUMBER_12 = 13,

        /// <summary>
        /// Enum NUMBER_13 for value: 13
        /// </summary>
        [EnumMember(Value = "13")]
        NUMBER_13 = 14

    }

}
