using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// These are pre-constructed collections of data that can be used to determine the Level Requirement for an item given a Progression to be tested (such as the Character&#39;s level).  For instance, say a character receives a new Auto Rifle, and that Auto Rifle&#39;s DestinyInventoryItemDefinition.quality.progressionLevelRequirementHash property is pointing at one of these DestinyProgressionLevelRequirementDefinitions. Let&#39;s pretend also that the progressionHash it is pointing at is the Character Level progression. In that situation, the character&#39;s level will be used to interpolate a value in the requirementCurve property. The value picked up from that interpolation will be the required level for the item.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsProgressionDestinyProgressionLevelRequirementDefinition {
    /// <summary>
    /// A curve of level requirements, weighted by the related progressions' level.  Interpolate against this curve with the character's progression level to determine what the level requirement of the generated item that is using this data will be.
    /// </summary>
    /// <value>A curve of level requirements, weighted by the related progressions' level.  Interpolate against this curve with the character's progression level to determine what the level requirement of the generated item that is using this data will be.</value>
    [DataMember(Name="requirementCurve", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requirementCurve")]
    public List<InterpolationInterpolationPointFloat> RequirementCurve { get; set; }

    /// <summary>
    /// The progression whose level should be used to determine the level requirement.  Look up the DestinyProgressionDefinition with this hash for more information about the progression in question.
    /// </summary>
    /// <value>The progression whose level should be used to determine the level requirement.  Look up the DestinyProgressionDefinition with this hash for more information about the progression in question.</value>
    [DataMember(Name="progressionHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "progressionHash")]
    public int? ProgressionHash { get; set; }

    /// <summary>
    /// The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.
    /// </summary>
    /// <value>The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</value>
    [DataMember(Name="hash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hash")]
    public int? Hash { get; set; }

    /// <summary>
    /// The index of the entity as it was found in the investment tables.
    /// </summary>
    /// <value>The index of the entity as it was found in the investment tables.</value>
    [DataMember(Name="index", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "index")]
    public int? Index { get; set; }

    /// <summary>
    /// If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!
    /// </summary>
    /// <value>If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</value>
    [DataMember(Name="redacted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "redacted")]
    public bool? Redacted { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsProgressionDestinyProgressionLevelRequirementDefinition {\n");
      sb.Append("  RequirementCurve: ").Append(RequirementCurve).Append("\n");
      sb.Append("  ProgressionHash: ").Append(ProgressionHash).Append("\n");
      sb.Append("  Hash: ").Append(Hash).Append("\n");
      sb.Append("  Index: ").Append(Index).Append("\n");
      sb.Append("  Redacted: ").Append(Redacted).Append("\n");
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
