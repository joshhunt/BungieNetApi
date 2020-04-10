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
    /// When a Stat (DestinyStatDefinition) is aggregated, this is the rules used for determining the level and formula used for aggregation.  * CharacterAverage &#x3D; apply a weighted average using the related DestinyStatGroupDefinition on the DestinyInventoryItemDefinition across the character&#39;s equipped items. See both of those definitions for details. * Character &#x3D; don&#39;t aggregate: the stat should be located and used directly on the character. * Item &#x3D; don&#39;t aggregate: the stat should be located and used directly on the item.
    /// </summary>
    /// <value>When a Stat (DestinyStatDefinition) is aggregated, this is the rules used for determining the level and formula used for aggregation.  * CharacterAverage &#x3D; apply a weighted average using the related DestinyStatGroupDefinition on the DestinyInventoryItemDefinition across the character&#39;s equipped items. See both of those definitions for details. * Character &#x3D; don&#39;t aggregate: the stat should be located and used directly on the character. * Item &#x3D; don&#39;t aggregate: the stat should be located and used directly on the item.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum DestinyDestinyStatAggregationType
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
        NUMBER_2 = 3

    }

}
