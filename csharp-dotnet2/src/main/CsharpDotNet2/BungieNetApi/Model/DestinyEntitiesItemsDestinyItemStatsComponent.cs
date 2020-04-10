using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// If you want the stats on an item&#39;s instanced data, get this component.  These are stats like Attack, Defense etc... and *not* historical stats.  Note that some stats have additional computation in-game at runtime - for instance, Magazine Size - and thus these stats might not be 100% accurate compared to what you see in-game for some stats. I know, it sucks. I hate it too.
  /// </summary>
  [DataContract]
  public class DestinyEntitiesItemsDestinyItemStatsComponent {
    /// <summary>
    /// If the item has stats that it provides (damage, defense, etc...), it will be given here.
    /// </summary>
    /// <value>If the item has stats that it provides (damage, defense, etc...), it will be given here.</value>
    [DataMember(Name="stats", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stats")]
    public Dictionary<string, DestinyDestinyStat> Stats { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyEntitiesItemsDestinyItemStatsComponent {\n");
      sb.Append("  Stats: ").Append(Stats).Append("\n");
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
