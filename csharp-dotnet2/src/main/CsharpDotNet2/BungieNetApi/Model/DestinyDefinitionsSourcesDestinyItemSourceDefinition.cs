using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Properties of a DestinyInventoryItemDefinition that store all of the information we were able to discern about how the item spawns, and where you can find the item.  Items will have many of these sources, one per level at which it spawns, to try and give more granular data about where items spawn for specific level ranges.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsSourcesDestinyItemSourceDefinition {
    /// <summary>
    /// The level at which the item spawns. Essentially the Primary Key for this source data: there will be multiple of these source entries per item that has source data, grouped by the level at which the item spawns.
    /// </summary>
    /// <value>The level at which the item spawns. Essentially the Primary Key for this source data: there will be multiple of these source entries per item that has source data, grouped by the level at which the item spawns.</value>
    [DataMember(Name="level", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "level")]
    public int? Level { get; set; }

    /// <summary>
    /// The minimum Quality at which the item spawns for this level. Examine DestinyInventoryItemDefinition for more information about what Quality means. Just don't ask Phaedrus about it, he'll never stop talking and you'll have to write a book about it.
    /// </summary>
    /// <value>The minimum Quality at which the item spawns for this level. Examine DestinyInventoryItemDefinition for more information about what Quality means. Just don't ask Phaedrus about it, he'll never stop talking and you'll have to write a book about it.</value>
    [DataMember(Name="minQuality", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minQuality")]
    public int? MinQuality { get; set; }

    /// <summary>
    /// The maximum quality at which the item spawns for this level.
    /// </summary>
    /// <value>The maximum quality at which the item spawns for this level.</value>
    [DataMember(Name="maxQuality", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maxQuality")]
    public int? MaxQuality { get; set; }

    /// <summary>
    /// The minimum Character Level required for equipping the item when the item spawns at the item level defined on this DestinyItemSourceDefinition, as far as we saw in our processing.
    /// </summary>
    /// <value>The minimum Character Level required for equipping the item when the item spawns at the item level defined on this DestinyItemSourceDefinition, as far as we saw in our processing.</value>
    [DataMember(Name="minLevelRequired", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minLevelRequired")]
    public int? MinLevelRequired { get; set; }

    /// <summary>
    /// The maximum Character Level required for equipping the item when the item spawns at the item level defined on this DestinyItemSourceDefinition, as far as we saw in our processing.
    /// </summary>
    /// <value>The maximum Character Level required for equipping the item when the item spawns at the item level defined on this DestinyItemSourceDefinition, as far as we saw in our processing.</value>
    [DataMember(Name="maxLevelRequired", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maxLevelRequired")]
    public int? MaxLevelRequired { get; set; }

    /// <summary>
    /// The stats computed for this level/quality range.
    /// </summary>
    /// <value>The stats computed for this level/quality range.</value>
    [DataMember(Name="computedStats", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "computedStats")]
    public Dictionary<string, DestinyDefinitionsDestinyInventoryItemStatDefinition> ComputedStats { get; set; }

    /// <summary>
    /// The DestinyRewardSourceDefinitions found that can spawn the item at this level.
    /// </summary>
    /// <value>The DestinyRewardSourceDefinitions found that can spawn the item at this level.</value>
    [DataMember(Name="sourceHashes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sourceHashes")]
    public List<int?> SourceHashes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsSourcesDestinyItemSourceDefinition {\n");
      sb.Append("  Level: ").Append(Level).Append("\n");
      sb.Append("  MinQuality: ").Append(MinQuality).Append("\n");
      sb.Append("  MaxQuality: ").Append(MaxQuality).Append("\n");
      sb.Append("  MinLevelRequired: ").Append(MinLevelRequired).Append("\n");
      sb.Append("  MaxLevelRequired: ").Append(MaxLevelRequired).Append("\n");
      sb.Append("  ComputedStats: ").Append(ComputedStats).Append("\n");
      sb.Append("  SourceHashes: ").Append(SourceHashes).Append("\n");
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
