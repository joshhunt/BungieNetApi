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
    /// This Enumeration further classifies items by more specific categorizations than DestinyItemType. The \&quot;Sub-Type\&quot; is where we classify and categorize items one step further in specificity: \&quot;Auto Rifle\&quot; instead of just \&quot;Weapon\&quot; for example, or \&quot;Vanguard Bounty\&quot; instead of merely \&quot;Bounty\&quot;.  These sub-types are provided for historical compatibility with Destiny 1, but an ideal alternative is to use DestinyItemCategoryDefinitions and the DestinyItemDefinition.itemCategories property instead. Item Categories allow for arbitrary hierarchies of specificity, and for items to belong to multiple categories across multiple hierarchies simultaneously. For this enum, we pick a single type as a \&quot;best guess\&quot; fit.  NOTE: This is not all of the item types available, and some of these are holdovers from Destiny 1 that may or may not still exist.
    /// </summary>
    /// <value>This Enumeration further classifies items by more specific categorizations than DestinyItemType. The \&quot;Sub-Type\&quot; is where we classify and categorize items one step further in specificity: \&quot;Auto Rifle\&quot; instead of just \&quot;Weapon\&quot; for example, or \&quot;Vanguard Bounty\&quot; instead of merely \&quot;Bounty\&quot;.  These sub-types are provided for historical compatibility with Destiny 1, but an ideal alternative is to use DestinyItemCategoryDefinitions and the DestinyItemDefinition.itemCategories property instead. Item Categories allow for arbitrary hierarchies of specificity, and for items to belong to multiple categories across multiple hierarchies simultaneously. For this enum, we pick a single type as a \&quot;best guess\&quot; fit.  NOTE: This is not all of the item types available, and some of these are holdovers from Destiny 1 that may or may not still exist.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum DestinyDestinyItemSubType
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
        /// Enum NUMBER_5 for value: 5
        /// </summary>
        [EnumMember(Value = "5")]
        NUMBER_5 = 4,

        /// <summary>
        /// Enum NUMBER_6 for value: 6
        /// </summary>
        [EnumMember(Value = "6")]
        NUMBER_6 = 5,

        /// <summary>
        /// Enum NUMBER_7 for value: 7
        /// </summary>
        [EnumMember(Value = "7")]
        NUMBER_7 = 6,

        /// <summary>
        /// Enum NUMBER_8 for value: 8
        /// </summary>
        [EnumMember(Value = "8")]
        NUMBER_8 = 7,

        /// <summary>
        /// Enum NUMBER_9 for value: 9
        /// </summary>
        [EnumMember(Value = "9")]
        NUMBER_9 = 8,

        /// <summary>
        /// Enum NUMBER_10 for value: 10
        /// </summary>
        [EnumMember(Value = "10")]
        NUMBER_10 = 9,

        /// <summary>
        /// Enum NUMBER_11 for value: 11
        /// </summary>
        [EnumMember(Value = "11")]
        NUMBER_11 = 10,

        /// <summary>
        /// Enum NUMBER_12 for value: 12
        /// </summary>
        [EnumMember(Value = "12")]
        NUMBER_12 = 11,

        /// <summary>
        /// Enum NUMBER_13 for value: 13
        /// </summary>
        [EnumMember(Value = "13")]
        NUMBER_13 = 12,

        /// <summary>
        /// Enum NUMBER_14 for value: 14
        /// </summary>
        [EnumMember(Value = "14")]
        NUMBER_14 = 13,

        /// <summary>
        /// Enum NUMBER_16 for value: 16
        /// </summary>
        [EnumMember(Value = "16")]
        NUMBER_16 = 14,

        /// <summary>
        /// Enum NUMBER_17 for value: 17
        /// </summary>
        [EnumMember(Value = "17")]
        NUMBER_17 = 15,

        /// <summary>
        /// Enum NUMBER_18 for value: 18
        /// </summary>
        [EnumMember(Value = "18")]
        NUMBER_18 = 16,

        /// <summary>
        /// Enum NUMBER_19 for value: 19
        /// </summary>
        [EnumMember(Value = "19")]
        NUMBER_19 = 17,

        /// <summary>
        /// Enum NUMBER_20 for value: 20
        /// </summary>
        [EnumMember(Value = "20")]
        NUMBER_20 = 18,

        /// <summary>
        /// Enum NUMBER_21 for value: 21
        /// </summary>
        [EnumMember(Value = "21")]
        NUMBER_21 = 19,

        /// <summary>
        /// Enum NUMBER_22 for value: 22
        /// </summary>
        [EnumMember(Value = "22")]
        NUMBER_22 = 20,

        /// <summary>
        /// Enum NUMBER_23 for value: 23
        /// </summary>
        [EnumMember(Value = "23")]
        NUMBER_23 = 21,

        /// <summary>
        /// Enum NUMBER_24 for value: 24
        /// </summary>
        [EnumMember(Value = "24")]
        NUMBER_24 = 22,

        /// <summary>
        /// Enum NUMBER_25 for value: 25
        /// </summary>
        [EnumMember(Value = "25")]
        NUMBER_25 = 23,

        /// <summary>
        /// Enum NUMBER_26 for value: 26
        /// </summary>
        [EnumMember(Value = "26")]
        NUMBER_26 = 24,

        /// <summary>
        /// Enum NUMBER_27 for value: 27
        /// </summary>
        [EnumMember(Value = "27")]
        NUMBER_27 = 25,

        /// <summary>
        /// Enum NUMBER_28 for value: 28
        /// </summary>
        [EnumMember(Value = "28")]
        NUMBER_28 = 26,

        /// <summary>
        /// Enum NUMBER_29 for value: 29
        /// </summary>
        [EnumMember(Value = "29")]
        NUMBER_29 = 27,

        /// <summary>
        /// Enum NUMBER_30 for value: 30
        /// </summary>
        [EnumMember(Value = "30")]
        NUMBER_30 = 28,

        /// <summary>
        /// Enum NUMBER_31 for value: 31
        /// </summary>
        [EnumMember(Value = "31")]
        NUMBER_31 = 29

    }

}
