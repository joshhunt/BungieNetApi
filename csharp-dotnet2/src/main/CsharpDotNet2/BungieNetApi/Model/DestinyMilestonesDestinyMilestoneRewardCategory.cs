using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Represents a category of \&quot;summary\&quot; rewards that can be earned for the Milestone regardless of specific quest rewards that can be earned.
  /// </summary>
  [DataContract]
  public class DestinyMilestonesDestinyMilestoneRewardCategory {
    /// <summary>
    /// Look up the relevant DestinyMilestoneDefinition, and then use rewardCategoryHash to look up the category info in DestinyMilestoneDefinition.rewards.
    /// </summary>
    /// <value>Look up the relevant DestinyMilestoneDefinition, and then use rewardCategoryHash to look up the category info in DestinyMilestoneDefinition.rewards.</value>
    [DataMember(Name="rewardCategoryHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rewardCategoryHash")]
    public int? RewardCategoryHash { get; set; }

    /// <summary>
    /// The individual reward entries for this category, and their status.
    /// </summary>
    /// <value>The individual reward entries for this category, and their status.</value>
    [DataMember(Name="entries", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "entries")]
    public List<DestinyMilestonesDestinyMilestoneRewardEntry> Entries { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyMilestonesDestinyMilestoneRewardCategory {\n");
      sb.Append("  RewardCategoryHash: ").Append(RewardCategoryHash).Append("\n");
      sb.Append("  Entries: ").Append(Entries).Append("\n");
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
