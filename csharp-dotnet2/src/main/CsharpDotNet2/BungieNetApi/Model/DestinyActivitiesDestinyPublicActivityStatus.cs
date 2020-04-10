using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Represents the public-facing status of an activity: any data about what is currently active in the Activity, regardless of an individual character&#39;s progress in it.
  /// </summary>
  [DataContract]
  public class DestinyActivitiesDestinyPublicActivityStatus {
    /// <summary>
    /// Active Challenges for the activity, if any - represented as hashes for DestinyObjectiveDefinitions.
    /// </summary>
    /// <value>Active Challenges for the activity, if any - represented as hashes for DestinyObjectiveDefinitions.</value>
    [DataMember(Name="challengeObjectiveHashes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "challengeObjectiveHashes")]
    public List<int?> ChallengeObjectiveHashes { get; set; }

    /// <summary>
    /// The active modifiers on this activity, if any - represented as hashes for DestinyActivityModifierDefinitions.
    /// </summary>
    /// <value>The active modifiers on this activity, if any - represented as hashes for DestinyActivityModifierDefinitions.</value>
    [DataMember(Name="modifierHashes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "modifierHashes")]
    public List<int?> ModifierHashes { get; set; }

    /// <summary>
    /// If the activity itself provides any specific \"mock\" rewards, this will be the items and their quantity.  Why \"mock\", you ask? Because these are the rewards as they are represented in the tooltip of the Activity.  These are often pointers to fake items that look good in a tooltip, but represent an abstract concept of what you will get for a reward rather than the specific items you may obtain.
    /// </summary>
    /// <value>If the activity itself provides any specific \"mock\" rewards, this will be the items and their quantity.  Why \"mock\", you ask? Because these are the rewards as they are represented in the tooltip of the Activity.  These are often pointers to fake items that look good in a tooltip, but represent an abstract concept of what you will get for a reward rather than the specific items you may obtain.</value>
    [DataMember(Name="rewardTooltipItems", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rewardTooltipItems")]
    public List<DestinyDestinyItemQuantity> RewardTooltipItems { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyActivitiesDestinyPublicActivityStatus {\n");
      sb.Append("  ChallengeObjectiveHashes: ").Append(ChallengeObjectiveHashes).Append("\n");
      sb.Append("  ModifierHashes: ").Append(ModifierHashes).Append("\n");
      sb.Append("  RewardTooltipItems: ").Append(RewardTooltipItems).Append("\n");
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
