using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class DestinyMilestonesDestinyPublicMilestoneQuest {
    /// <summary>
    /// Quests are defined as Items in content. As such, this is the hash identifier of the DestinyInventoryItemDefinition that represents this quest. It will have pointers to all of the steps in the quest, and display information for the quest (title, description, icon etc) Individual steps will be referred to in the Quest item's DestinyInventoryItemDefinition.setData property, and themselves are Items with their own renderable data.
    /// </summary>
    /// <value>Quests are defined as Items in content. As such, this is the hash identifier of the DestinyInventoryItemDefinition that represents this quest. It will have pointers to all of the steps in the quest, and display information for the quest (title, description, icon etc) Individual steps will be referred to in the Quest item's DestinyInventoryItemDefinition.setData property, and themselves are Items with their own renderable data.</value>
    [DataMember(Name="questItemHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "questItemHash")]
    public int? QuestItemHash { get; set; }

    /// <summary>
    /// A milestone need not have an active activity, but if there is one it will be returned here, along with any variant and additional information.
    /// </summary>
    /// <value>A milestone need not have an active activity, but if there is one it will be returned here, along with any variant and additional information.</value>
    [DataMember(Name="activity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activity")]
    public DestinyMilestonesDestinyPublicMilestoneActivity Activity { get; set; }

    /// <summary>
    /// For the given quest there could be 0-to-Many challenges: mini quests that you can perform in the course of doing this quest, that may grant you rewards and benefits.
    /// </summary>
    /// <value>For the given quest there could be 0-to-Many challenges: mini quests that you can perform in the course of doing this quest, that may grant you rewards and benefits.</value>
    [DataMember(Name="challenges", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "challenges")]
    public List<DestinyMilestonesDestinyPublicMilestoneChallenge> Challenges { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyMilestonesDestinyPublicMilestoneQuest {\n");
      sb.Append("  QuestItemHash: ").Append(QuestItemHash).Append("\n");
      sb.Append("  Activity: ").Append(Activity).Append("\n");
      sb.Append("  Challenges: ").Append(Challenges).Append("\n");
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
