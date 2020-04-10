using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// An item can have objectives on it. In practice, these are the exclusive purview of \&quot;Quest Step\&quot; items: DestinyInventoryItemDefinitions that represent a specific step in a Quest.  Quest steps have 1:M objectives that we end up processing and returning in live data as DestinyQuestStatus data, and other useful information.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyItemObjectiveBlockDefinition {
    /// <summary>
    /// The hashes to Objectives (DestinyObjectiveDefinition) that are part of this Quest Step, in the order that they should be rendered.
    /// </summary>
    /// <value>The hashes to Objectives (DestinyObjectiveDefinition) that are part of this Quest Step, in the order that they should be rendered.</value>
    [DataMember(Name="objectiveHashes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "objectiveHashes")]
    public List<int?> ObjectiveHashes { get; set; }

    /// <summary>
    /// For every entry in objectiveHashes, there is a corresponding entry in this array at the same index. If the objective is meant to be associated with a specific DestinyActivityDefinition, there will be a valid hash at that index. Otherwise, it will be invalid (0).  Rendered somewhat obsolete by perObjectiveDisplayProperties, which currently has much the same information but may end up with more info in the future.
    /// </summary>
    /// <value>For every entry in objectiveHashes, there is a corresponding entry in this array at the same index. If the objective is meant to be associated with a specific DestinyActivityDefinition, there will be a valid hash at that index. Otherwise, it will be invalid (0).  Rendered somewhat obsolete by perObjectiveDisplayProperties, which currently has much the same information but may end up with more info in the future.</value>
    [DataMember(Name="displayActivityHashes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayActivityHashes")]
    public List<int?> DisplayActivityHashes { get; set; }

    /// <summary>
    /// If True, all objectives must be completed for the step to be completed. If False, any one objective can be completed for the step to be completed.
    /// </summary>
    /// <value>If True, all objectives must be completed for the step to be completed. If False, any one objective can be completed for the step to be completed.</value>
    [DataMember(Name="requireFullObjectiveCompletion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requireFullObjectiveCompletion")]
    public bool? RequireFullObjectiveCompletion { get; set; }

    /// <summary>
    /// The hash for the DestinyInventoryItemDefinition representing the Quest to which this Quest Step belongs.
    /// </summary>
    /// <value>The hash for the DestinyInventoryItemDefinition representing the Quest to which this Quest Step belongs.</value>
    [DataMember(Name="questlineItemHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "questlineItemHash")]
    public int? QuestlineItemHash { get; set; }

    /// <summary>
    /// The localized string for narrative text related to this quest step, if any.
    /// </summary>
    /// <value>The localized string for narrative text related to this quest step, if any.</value>
    [DataMember(Name="narrative", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "narrative")]
    public string Narrative { get; set; }

    /// <summary>
    /// The localized string describing an action to be performed associated with the objectives, if any.
    /// </summary>
    /// <value>The localized string describing an action to be performed associated with the objectives, if any.</value>
    [DataMember(Name="objectiveVerbName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "objectiveVerbName")]
    public string ObjectiveVerbName { get; set; }

    /// <summary>
    /// The identifier for the type of quest being performed, if any. Not associated with any fixed definition, yet.
    /// </summary>
    /// <value>The identifier for the type of quest being performed, if any. Not associated with any fixed definition, yet.</value>
    [DataMember(Name="questTypeIdentifier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "questTypeIdentifier")]
    public string QuestTypeIdentifier { get; set; }

    /// <summary>
    /// A hashed value for the questTypeIdentifier, because apparently I like to be redundant.
    /// </summary>
    /// <value>A hashed value for the questTypeIdentifier, because apparently I like to be redundant.</value>
    [DataMember(Name="questTypeHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "questTypeHash")]
    public int? QuestTypeHash { get; set; }

    /// <summary>
    /// One entry per Objective on the item, it will have related display information.
    /// </summary>
    /// <value>One entry per Objective on the item, it will have related display information.</value>
    [DataMember(Name="perObjectiveDisplayProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "perObjectiveDisplayProperties")]
    public List<DestinyDefinitionsDestinyObjectiveDisplayProperties> PerObjectiveDisplayProperties { get; set; }

    /// <summary>
    /// Gets or Sets DisplayAsStatTracker
    /// </summary>
    [DataMember(Name="displayAsStatTracker", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayAsStatTracker")]
    public bool? DisplayAsStatTracker { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyItemObjectiveBlockDefinition {\n");
      sb.Append("  ObjectiveHashes: ").Append(ObjectiveHashes).Append("\n");
      sb.Append("  DisplayActivityHashes: ").Append(DisplayActivityHashes).Append("\n");
      sb.Append("  RequireFullObjectiveCompletion: ").Append(RequireFullObjectiveCompletion).Append("\n");
      sb.Append("  QuestlineItemHash: ").Append(QuestlineItemHash).Append("\n");
      sb.Append("  Narrative: ").Append(Narrative).Append("\n");
      sb.Append("  ObjectiveVerbName: ").Append(ObjectiveVerbName).Append("\n");
      sb.Append("  QuestTypeIdentifier: ").Append(QuestTypeIdentifier).Append("\n");
      sb.Append("  QuestTypeHash: ").Append(QuestTypeHash).Append("\n");
      sb.Append("  PerObjectiveDisplayProperties: ").Append(PerObjectiveDisplayProperties).Append("\n");
      sb.Append("  DisplayAsStatTracker: ").Append(DisplayAsStatTracker).Append("\n");
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
