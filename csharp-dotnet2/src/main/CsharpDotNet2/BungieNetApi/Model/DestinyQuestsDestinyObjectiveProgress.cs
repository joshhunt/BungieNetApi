using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Returns data about a character&#39;s status with a given Objective. Combine with DestinyObjectiveDefinition static data for display purposes.
  /// </summary>
  [DataContract]
  public class DestinyQuestsDestinyObjectiveProgress {
    /// <summary>
    /// The unique identifier of the Objective being referred to. Use to look up the DestinyObjectiveDefinition in static data.
    /// </summary>
    /// <value>The unique identifier of the Objective being referred to. Use to look up the DestinyObjectiveDefinition in static data.</value>
    [DataMember(Name="objectiveHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "objectiveHash")]
    public int? ObjectiveHash { get; set; }

    /// <summary>
    /// If the Objective has a Destination associated with it, this is the unique identifier of the Destination being referred to. Use to look up the DestinyDestinationDefinition in static data. This will give localized data about *where* in the universe the objective should be achieved.
    /// </summary>
    /// <value>If the Objective has a Destination associated with it, this is the unique identifier of the Destination being referred to. Use to look up the DestinyDestinationDefinition in static data. This will give localized data about *where* in the universe the objective should be achieved.</value>
    [DataMember(Name="destinationHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destinationHash")]
    public int? DestinationHash { get; set; }

    /// <summary>
    /// If the Objective has an Activity associated with it, this is the unique identifier of the Activity being referred to. Use to look up the DestinyActivityDefinition in static data. This will give localized data about *what* you should be playing for the objective to be achieved.
    /// </summary>
    /// <value>If the Objective has an Activity associated with it, this is the unique identifier of the Activity being referred to. Use to look up the DestinyActivityDefinition in static data. This will give localized data about *what* you should be playing for the objective to be achieved.</value>
    [DataMember(Name="activityHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activityHash")]
    public int? ActivityHash { get; set; }

    /// <summary>
    /// If progress has been made, and the progress can be measured numerically, this will be the value of that progress. You can compare it to the DestinyObjectiveDefinition.completionValue property for current vs. upper bounds, and use DestinyObjectiveDefinition.valueStyle to determine how this should be rendered. Note that progress, in Destiny 2, need not be a literal numeric progression. It could be one of a number of possible values, even a Timestamp. Always examine DestinyObjectiveDefinition.valueStyle before rendering progress.
    /// </summary>
    /// <value>If progress has been made, and the progress can be measured numerically, this will be the value of that progress. You can compare it to the DestinyObjectiveDefinition.completionValue property for current vs. upper bounds, and use DestinyObjectiveDefinition.valueStyle to determine how this should be rendered. Note that progress, in Destiny 2, need not be a literal numeric progression. It could be one of a number of possible values, even a Timestamp. Always examine DestinyObjectiveDefinition.valueStyle before rendering progress.</value>
    [DataMember(Name="progress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "progress")]
    public int? Progress { get; set; }

    /// <summary>
    /// As of Forsaken, objectives' completion value is determined dynamically at runtime.  This value represents the threshold of progress you need to surpass in order for this objective to be considered \"complete\".  If you were using objective data, switch from using the DestinyObjectiveDefinition's \"completionValue\" to this value.
    /// </summary>
    /// <value>As of Forsaken, objectives' completion value is determined dynamically at runtime.  This value represents the threshold of progress you need to surpass in order for this objective to be considered \"complete\".  If you were using objective data, switch from using the DestinyObjectiveDefinition's \"completionValue\" to this value.</value>
    [DataMember(Name="completionValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "completionValue")]
    public int? CompletionValue { get; set; }

    /// <summary>
    /// Whether or not the Objective is completed.
    /// </summary>
    /// <value>Whether or not the Objective is completed.</value>
    [DataMember(Name="complete", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "complete")]
    public bool? Complete { get; set; }

    /// <summary>
    /// If this is true, the objective is visible in-game. Otherwise, it's not yet visible to the player. Up to you if you want to honor this property.
    /// </summary>
    /// <value>If this is true, the objective is visible in-game. Otherwise, it's not yet visible to the player. Up to you if you want to honor this property.</value>
    [DataMember(Name="visible", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "visible")]
    public bool? Visible { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyQuestsDestinyObjectiveProgress {\n");
      sb.Append("  ObjectiveHash: ").Append(ObjectiveHash).Append("\n");
      sb.Append("  DestinationHash: ").Append(DestinationHash).Append("\n");
      sb.Append("  ActivityHash: ").Append(ActivityHash).Append("\n");
      sb.Append("  Progress: ").Append(Progress).Append("\n");
      sb.Append("  CompletionValue: ").Append(CompletionValue).Append("\n");
      sb.Append("  Complete: ").Append(Complete).Append("\n");
      sb.Append("  Visible: ").Append(Visible).Append("\n");
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
