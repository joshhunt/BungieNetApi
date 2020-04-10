using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Data regarding the progress of a Quest for a specific character. Quests are composed of multiple steps, each with potentially multiple objectives: this QuestStatus will return Objective data for the *currently active* step in this quest.
  /// </summary>
  [DataContract]
  public class DestinyQuestsDestinyQuestStatus {
    /// <summary>
    /// The hash identifier for the Quest Item. (Note: Quests are defined as Items, and thus you would use this to look up the quest's DestinyInventoryItemDefinition). For information on all steps in the quest, you can then examine its DestinyInventoryItemDefinition.setData property for Quest Steps (which are *also* items). You can use the Item Definition to display human readable data about the overall quest.
    /// </summary>
    /// <value>The hash identifier for the Quest Item. (Note: Quests are defined as Items, and thus you would use this to look up the quest's DestinyInventoryItemDefinition). For information on all steps in the quest, you can then examine its DestinyInventoryItemDefinition.setData property for Quest Steps (which are *also* items). You can use the Item Definition to display human readable data about the overall quest.</value>
    [DataMember(Name="questHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "questHash")]
    public int? QuestHash { get; set; }

    /// <summary>
    /// The hash identifier of the current Quest Step, which is also a DestinyInventoryItemDefinition. You can use this to get human readable data about the current step and what to do in that step.
    /// </summary>
    /// <value>The hash identifier of the current Quest Step, which is also a DestinyInventoryItemDefinition. You can use this to get human readable data about the current step and what to do in that step.</value>
    [DataMember(Name="stepHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stepHash")]
    public int? StepHash { get; set; }

    /// <summary>
    /// A step can have multiple objectives. This will give you the progress for each objective in the current step, in the order in which they are rendered in-game.
    /// </summary>
    /// <value>A step can have multiple objectives. This will give you the progress for each objective in the current step, in the order in which they are rendered in-game.</value>
    [DataMember(Name="stepObjectives", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stepObjectives")]
    public List<DestinyQuestsDestinyObjectiveProgress> StepObjectives { get; set; }

    /// <summary>
    /// Whether or not the quest is tracked
    /// </summary>
    /// <value>Whether or not the quest is tracked</value>
    [DataMember(Name="tracked", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tracked")]
    public bool? Tracked { get; set; }

    /// <summary>
    /// The current Quest Step will be an instanced item in the player's inventory. If you care about that, this is the instance ID of that item.
    /// </summary>
    /// <value>The current Quest Step will be an instanced item in the player's inventory. If you care about that, this is the instance ID of that item.</value>
    [DataMember(Name="itemInstanceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemInstanceId")]
    public long? ItemInstanceId { get; set; }

    /// <summary>
    /// Whether or not the whole quest has been completed, regardless of whether or not you have redeemed the rewards for the quest.
    /// </summary>
    /// <value>Whether or not the whole quest has been completed, regardless of whether or not you have redeemed the rewards for the quest.</value>
    [DataMember(Name="completed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "completed")]
    public bool? Completed { get; set; }

    /// <summary>
    /// Whether or not you have redeemed rewards for this quest.
    /// </summary>
    /// <value>Whether or not you have redeemed rewards for this quest.</value>
    [DataMember(Name="redeemed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "redeemed")]
    public bool? Redeemed { get; set; }

    /// <summary>
    /// Whether or not you have started this quest.
    /// </summary>
    /// <value>Whether or not you have started this quest.</value>
    [DataMember(Name="started", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "started")]
    public bool? Started { get; set; }

    /// <summary>
    /// If the quest has a related Vendor that you should talk to in order to initiate the quest/earn rewards/continue the quest, this will be the hash identifier of that Vendor. Look it up its DestinyVendorDefinition.
    /// </summary>
    /// <value>If the quest has a related Vendor that you should talk to in order to initiate the quest/earn rewards/continue the quest, this will be the hash identifier of that Vendor. Look it up its DestinyVendorDefinition.</value>
    [DataMember(Name="vendorHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vendorHash")]
    public int? VendorHash { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyQuestsDestinyQuestStatus {\n");
      sb.Append("  QuestHash: ").Append(QuestHash).Append("\n");
      sb.Append("  StepHash: ").Append(StepHash).Append("\n");
      sb.Append("  StepObjectives: ").Append(StepObjectives).Append("\n");
      sb.Append("  Tracked: ").Append(Tracked).Append("\n");
      sb.Append("  ItemInstanceId: ").Append(ItemInstanceId).Append("\n");
      sb.Append("  Completed: ").Append(Completed).Append("\n");
      sb.Append("  Redeemed: ").Append(Redeemed).Append("\n");
      sb.Append("  Started: ").Append(Started).Append("\n");
      sb.Append("  VendorHash: ").Append(VendorHash).Append("\n");
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
