using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Information about the item&#39;s calculated stats, with as much data as we can find for the stats without having an actual instance of the item.  Note that this means the entire concept of providing these stats is fundamentally insufficient: we cannot predict with 100% accuracy the conditions under which an item can spawn, so we use various heuristics to attempt to simulate the conditions as accurately as possible. Actual stats for items in-game can and will vary, but these should at least be useful base points for comparison and display.  It is also worth noting that some stats, like Magazine size, have further calculations performed on them by scripts in-game and on the game servers that BNet does not have access to. We cannot know how those stats are further transformed, and thus some stats will be inaccurate even on instances of items in BNet vs. how they appear in-game. This is a known limitation of our item statistics, without any planned fix.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyItemStatBlockDefinition {
    /// <summary>
    /// If true, the game won't show the \"primary\" stat on this item when you inspect it.  NOTE: This is being manually mapped, because I happen to want it in a block that isn't going to directly create this derivative block.
    /// </summary>
    /// <value>If true, the game won't show the \"primary\" stat on this item when you inspect it.  NOTE: This is being manually mapped, because I happen to want it in a block that isn't going to directly create this derivative block.</value>
    [DataMember(Name="disablePrimaryStatDisplay", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "disablePrimaryStatDisplay")]
    public bool? DisablePrimaryStatDisplay { get; set; }

    /// <summary>
    /// If the item's stats are meant to be modified by a DestinyStatGroupDefinition, this will be the identifier for that definition.  If you are using live data or precomputed stats data on the DestinyInventoryItemDefinition.stats.stats property, you don't have to worry about statGroupHash and how it alters stats: the already altered stats are provided to you. But if you want to see how the sausage gets made, or perform computations yourself, this is valuable information.
    /// </summary>
    /// <value>If the item's stats are meant to be modified by a DestinyStatGroupDefinition, this will be the identifier for that definition.  If you are using live data or precomputed stats data on the DestinyInventoryItemDefinition.stats.stats property, you don't have to worry about statGroupHash and how it alters stats: the already altered stats are provided to you. But if you want to see how the sausage gets made, or perform computations yourself, this is valuable information.</value>
    [DataMember(Name="statGroupHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statGroupHash")]
    public int? StatGroupHash { get; set; }

    /// <summary>
    /// If you are looking for precomputed values for the stats on a weapon, this is where they are stored. Technically these are the \"Display\" stat values. Please see DestinyStatsDefinition for what Display Stat Values means, it's a very long story... but essentially these are the closest values BNet can get to the item stats that you see in-game.  These stats are keyed by the DestinyStatDefinition's hash identifier for the stat that's found on the item.
    /// </summary>
    /// <value>If you are looking for precomputed values for the stats on a weapon, this is where they are stored. Technically these are the \"Display\" stat values. Please see DestinyStatsDefinition for what Display Stat Values means, it's a very long story... but essentially these are the closest values BNet can get to the item stats that you see in-game.  These stats are keyed by the DestinyStatDefinition's hash identifier for the stat that's found on the item.</value>
    [DataMember(Name="stats", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stats")]
    public Dictionary<string, DestinyDefinitionsDestinyInventoryItemStatDefinition> Stats { get; set; }

    /// <summary>
    /// A quick and lazy way to determine whether any stat other than the \"primary\" stat is actually visible on the item. Items often have stats that we return in case people find them useful, but they're not part of the \"Stat Group\" and thus we wouldn't display them in our UI. If this is False, then we're not going to display any of these stats other than the primary one.
    /// </summary>
    /// <value>A quick and lazy way to determine whether any stat other than the \"primary\" stat is actually visible on the item. Items often have stats that we return in case people find them useful, but they're not part of the \"Stat Group\" and thus we wouldn't display them in our UI. If this is False, then we're not going to display any of these stats other than the primary one.</value>
    [DataMember(Name="hasDisplayableStats", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hasDisplayableStats")]
    public bool? HasDisplayableStats { get; set; }

    /// <summary>
    /// This stat is determined to be the \"primary\" stat, and can be looked up in the stats or any other stat collection related to the item.  Use this hash to look up the stat's value using DestinyInventoryItemDefinition.stats.stats, and the renderable data for the primary stat in the related DestinyStatDefinition.
    /// </summary>
    /// <value>This stat is determined to be the \"primary\" stat, and can be looked up in the stats or any other stat collection related to the item.  Use this hash to look up the stat's value using DestinyInventoryItemDefinition.stats.stats, and the renderable data for the primary stat in the related DestinyStatDefinition.</value>
    [DataMember(Name="primaryBaseStatHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "primaryBaseStatHash")]
    public int? PrimaryBaseStatHash { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyItemStatBlockDefinition {\n");
      sb.Append("  DisablePrimaryStatDisplay: ").Append(DisablePrimaryStatDisplay).Append("\n");
      sb.Append("  StatGroupHash: ").Append(StatGroupHash).Append("\n");
      sb.Append("  Stats: ").Append(Stats).Append("\n");
      sb.Append("  HasDisplayableStats: ").Append(HasDisplayableStats).Append("\n");
      sb.Append("  PrimaryBaseStatHash: ").Append(PrimaryBaseStatHash).Append("\n");
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
