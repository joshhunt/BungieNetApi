using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// If rewards are given in a quest - as opposed to overall in the entire Milestone - there&#39;s way less to track. We&#39;re going to simplify this contract as a result. However, this also gives us the opportunity to potentially put more than just item information into the reward data if we&#39;re able to mine it out in the future. Remember this if you come back and ask \&quot;why are quest reward items nested inside of their own class?\&quot;
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardsDefinition {
    /// <summary>
    /// The items that represent your reward for completing the quest.  Be warned, these could be \"dummy\" items: items that are only used to render a good-looking in-game tooltip, but aren't the actual items themselves.  For instance, when experience is given there's often a dummy item representing \"experience\", with quantity being the amount of experience you got. We don't have a programmatic association between those and whatever Progression is actually getting that experience... yet.
    /// </summary>
    /// <value>The items that represent your reward for completing the quest.  Be warned, these could be \"dummy\" items: items that are only used to render a good-looking in-game tooltip, but aren't the actual items themselves.  For instance, when experience is given there's often a dummy item representing \"experience\", with quantity being the amount of experience you got. We don't have a programmatic association between those and whatever Progression is actually getting that experience... yet.</value>
    [DataMember(Name="items", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "items")]
    public List<DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardItem> Items { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardsDefinition {\n");
      sb.Append("  Items: ").Append(Items).Append("\n");
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
