using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// The character-specific data for a milestone&#39;s reward entry. See DestinyMilestoneDefinition for more information about Reward Entries.
  /// </summary>
  [DataContract]
  public class DestinyMilestonesDestinyMilestoneRewardEntry {
    /// <summary>
    /// The identifier for the reward entry in question. It is important to look up the related DestinyMilestoneRewardEntryDefinition to get the static details about the reward, which you can do by looking up the milestone's DestinyMilestoneDefinition and examining the DestinyMilestoneDefinition.rewards[rewardCategoryHash].rewardEntries[rewardEntryHash] data.
    /// </summary>
    /// <value>The identifier for the reward entry in question. It is important to look up the related DestinyMilestoneRewardEntryDefinition to get the static details about the reward, which you can do by looking up the milestone's DestinyMilestoneDefinition and examining the DestinyMilestoneDefinition.rewards[rewardCategoryHash].rewardEntries[rewardEntryHash] data.</value>
    [DataMember(Name="rewardEntryHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rewardEntryHash")]
    public int? RewardEntryHash { get; set; }

    /// <summary>
    /// If TRUE, the player has earned this reward.
    /// </summary>
    /// <value>If TRUE, the player has earned this reward.</value>
    [DataMember(Name="earned", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "earned")]
    public bool? Earned { get; set; }

    /// <summary>
    /// If TRUE, the player has redeemed/picked up/obtained this reward. Feel free to alias this to \"gotTheShinyBauble\" in your own codebase.
    /// </summary>
    /// <value>If TRUE, the player has redeemed/picked up/obtained this reward. Feel free to alias this to \"gotTheShinyBauble\" in your own codebase.</value>
    [DataMember(Name="redeemed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "redeemed")]
    public bool? Redeemed { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyMilestonesDestinyMilestoneRewardEntry {\n");
      sb.Append("  RewardEntryHash: ").Append(RewardEntryHash).Append("\n");
      sb.Append("  Earned: ").Append(Earned).Append("\n");
      sb.Append("  Redeemed: ").Append(Redeemed).Append("\n");
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
