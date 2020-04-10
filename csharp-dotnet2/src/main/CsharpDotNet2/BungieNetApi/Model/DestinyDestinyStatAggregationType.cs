using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// When a Stat (DestinyStatDefinition) is aggregated, this is the rules used for determining the level and formula used for aggregation.  * CharacterAverage &#x3D; apply a weighted average using the related DestinyStatGroupDefinition on the DestinyInventoryItemDefinition across the character&#39;s equipped items. See both of those definitions for details. * Character &#x3D; don&#39;t aggregate: the stat should be located and used directly on the character. * Item &#x3D; don&#39;t aggregate: the stat should be located and used directly on the item.
  /// </summary>
  [DataContract]
  public class DestinyDestinyStatAggregationType {

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDestinyStatAggregationType {\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
