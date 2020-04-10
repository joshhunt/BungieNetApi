using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// This component returns anything that could be considered \&quot;Progression\&quot; on a user: data where the user is gaining levels, reputation, completions, rewards, etc...
  /// </summary>
  [DataContract]
  public class DestinyEntitiesCharactersDestinyCharacterProgressionComponent {
    /// <summary>
    /// A Dictionary of all known progressions for the Character, keyed by the Progression's hash.  Not all progressions have user-facing data, but those who do will have that data contained in the DestinyProgressionDefinition.
    /// </summary>
    /// <value>A Dictionary of all known progressions for the Character, keyed by the Progression's hash.  Not all progressions have user-facing data, but those who do will have that data contained in the DestinyProgressionDefinition.</value>
    [DataMember(Name="progressions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "progressions")]
    public Dictionary<string, DestinyDestinyProgression> Progressions { get; set; }

    /// <summary>
    /// A dictionary of all known Factions, keyed by the Faction's hash. It contains data about this character's status with the faction.
    /// </summary>
    /// <value>A dictionary of all known Factions, keyed by the Faction's hash. It contains data about this character's status with the faction.</value>
    [DataMember(Name="factions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "factions")]
    public Dictionary<string, DestinyProgressionDestinyFactionProgression> Factions { get; set; }

    /// <summary>
    /// Milestones are related to the simple progressions shown in the game, but return additional and hopefully helpful information for users about the specifics of the Milestone's status.
    /// </summary>
    /// <value>Milestones are related to the simple progressions shown in the game, but return additional and hopefully helpful information for users about the specifics of the Milestone's status.</value>
    [DataMember(Name="milestones", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "milestones")]
    public Dictionary<string, DestinyMilestonesDestinyMilestone> Milestones { get; set; }

    /// <summary>
    /// If the user has any active quests, the quests' statuses will be returned here.   Note that quests have been largely supplanted by Milestones, but that doesn't mean that they won't make a comeback independent of milestones at some point.   (Fun fact: quests came back as I feared they would, but we never looped back to populate this... I'm going to put that in the backlog.)
    /// </summary>
    /// <value>If the user has any active quests, the quests' statuses will be returned here.   Note that quests have been largely supplanted by Milestones, but that doesn't mean that they won't make a comeback independent of milestones at some point.   (Fun fact: quests came back as I feared they would, but we never looped back to populate this... I'm going to put that in the backlog.)</value>
    [DataMember(Name="quests", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quests")]
    public List<DestinyQuestsDestinyQuestStatus> Quests { get; set; }

    /// <summary>
    /// Sometimes, you have items in your inventory that don't have instances, but still have Objective information. This provides you that objective information for uninstanced items.   This dictionary is keyed by the item's hash: which you can use to look up the name and description for the overall task(s) implied by the objective. The value is the list of objectives for this item, and their statuses.
    /// </summary>
    /// <value>Sometimes, you have items in your inventory that don't have instances, but still have Objective information. This provides you that objective information for uninstanced items.   This dictionary is keyed by the item's hash: which you can use to look up the name and description for the overall task(s) implied by the objective. The value is the list of objectives for this item, and their statuses.</value>
    [DataMember(Name="uninstancedItemObjectives", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uninstancedItemObjectives")]
    public Dictionary<string, List<DestinyQuestsDestinyObjectiveProgress>> UninstancedItemObjectives { get; set; }

    /// <summary>
    /// The set of checklists that can be examined for this specific character, keyed by the hash identifier of the Checklist (DestinyChecklistDefinition)  For each checklist returned, its value is itself a Dictionary keyed by the checklist's hash identifier with the value being a boolean indicating if it's been discovered yet.
    /// </summary>
    /// <value>The set of checklists that can be examined for this specific character, keyed by the hash identifier of the Checklist (DestinyChecklistDefinition)  For each checklist returned, its value is itself a Dictionary keyed by the checklist's hash identifier with the value being a boolean indicating if it's been discovered yet.</value>
    [DataMember(Name="checklists", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "checklists")]
    public Dictionary<string, Dictionary<string, bool?>> Checklists { get; set; }

    /// <summary>
    /// Data related to your progress on the current season's artifact that can vary per character.
    /// </summary>
    /// <value>Data related to your progress on the current season's artifact that can vary per character.</value>
    [DataMember(Name="seasonalArtifact", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "seasonalArtifact")]
    public DestinyArtifactsDestinyArtifactCharacterScoped SeasonalArtifact { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyEntitiesCharactersDestinyCharacterProgressionComponent {\n");
      sb.Append("  Progressions: ").Append(Progressions).Append("\n");
      sb.Append("  Factions: ").Append(Factions).Append("\n");
      sb.Append("  Milestones: ").Append(Milestones).Append("\n");
      sb.Append("  Quests: ").Append(Quests).Append("\n");
      sb.Append("  UninstancedItemObjectives: ").Append(UninstancedItemObjectives).Append("\n");
      sb.Append("  Checklists: ").Append(Checklists).Append("\n");
      sb.Append("  SeasonalArtifact: ").Append(SeasonalArtifact).Append("\n");
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
