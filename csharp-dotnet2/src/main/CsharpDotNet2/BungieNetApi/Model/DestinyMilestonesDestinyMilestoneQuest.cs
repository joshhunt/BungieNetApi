using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// If a Milestone has one or more Quests, this will contain the live information for the character&#39;s status with one of those quests.
  /// </summary>
  [DataContract]
  public class DestinyMilestonesDestinyMilestoneQuest {
    /// <summary>
    /// Quests are defined as Items in content. As such, this is the hash identifier of the DestinyInventoryItemDefinition that represents this quest. It will have pointers to all of the steps in the quest, and display information for the quest (title, description, icon etc) Individual steps will be referred to in the Quest item's DestinyInventoryItemDefinition.setData property, and themselves are Items with their own renderable data.
    /// </summary>
    /// <value>Quests are defined as Items in content. As such, this is the hash identifier of the DestinyInventoryItemDefinition that represents this quest. It will have pointers to all of the steps in the quest, and display information for the quest (title, description, icon etc) Individual steps will be referred to in the Quest item's DestinyInventoryItemDefinition.setData property, and themselves are Items with their own renderable data.</value>
    [DataMember(Name="questItemHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "questItemHash")]
    public int? QuestItemHash { get; set; }

    /// <summary>
    /// The current status of the quest for the character making the request.
    /// </summary>
    /// <value>The current status of the quest for the character making the request.</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public DestinyQuestsDestinyQuestStatus Status { get; set; }

    /// <summary>
    /// *IF* the Milestone has an active Activity that can give you greater details about what you need to do, it will be returned here. Remember to associate this with the DestinyMilestoneDefinition's activities to get details about the activity, including what specific quest it is related to if you have multiple quests to choose from.
    /// </summary>
    /// <value>*IF* the Milestone has an active Activity that can give you greater details about what you need to do, it will be returned here. Remember to associate this with the DestinyMilestoneDefinition's activities to get details about the activity, including what specific quest it is related to if you have multiple quests to choose from.</value>
    [DataMember(Name="activity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activity")]
    public DestinyMilestonesDestinyMilestoneActivity Activity { get; set; }

    /// <summary>
    /// The activities referred to by this quest can have many associated challenges. They are all contained here, with activityHashes so that you can associate them with the specific activity variants in which they can be found. In retrospect, I probably should have put these under the specific Activity Variants, but it's too late to change it now. Theoretically, a quest without Activities can still have Challenges, which is why this is on a higher level than activity/variants, but it probably should have been in both places. That may come as a later revision.
    /// </summary>
    /// <value>The activities referred to by this quest can have many associated challenges. They are all contained here, with activityHashes so that you can associate them with the specific activity variants in which they can be found. In retrospect, I probably should have put these under the specific Activity Variants, but it's too late to change it now. Theoretically, a quest without Activities can still have Challenges, which is why this is on a higher level than activity/variants, but it probably should have been in both places. That may come as a later revision.</value>
    [DataMember(Name="challenges", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "challenges")]
    public List<DestinyChallengesDestinyChallengeStatus> Challenges { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyMilestonesDestinyMilestoneQuest {\n");
      sb.Append("  QuestItemHash: ").Append(QuestItemHash).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
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
