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
  public class DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityDefinition {
    /// <summary>
    /// The activity for which this challenge is active.
    /// </summary>
    /// <value>The activity for which this challenge is active.</value>
    [DataMember(Name="activityHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activityHash")]
    public int? ActivityHash { get; set; }

    /// <summary>
    /// Gets or Sets Challenges
    /// </summary>
    [DataMember(Name="challenges", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "challenges")]
    public List<DestinyDefinitionsMilestonesDestinyMilestoneChallengeDefinition> Challenges { get; set; }

    /// <summary>
    /// If the activity and its challenge is visible on any of these nodes, it will be returned.
    /// </summary>
    /// <value>If the activity and its challenge is visible on any of these nodes, it will be returned.</value>
    [DataMember(Name="activityGraphNodes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activityGraphNodes")]
    public List<DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityGraphNodeEntry> ActivityGraphNodes { get; set; }

    /// <summary>
    /// Phases related to this activity, if there are any.  These will be listed in the order in which they will appear in the actual activity.
    /// </summary>
    /// <value>Phases related to this activity, if there are any.  These will be listed in the order in which they will appear in the actual activity.</value>
    [DataMember(Name="phases", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phases")]
    public List<DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityPhase> Phases { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityDefinition {\n");
      sb.Append("  ActivityHash: ").Append(ActivityHash).Append("\n");
      sb.Append("  Challenges: ").Append(Challenges).Append("\n");
      sb.Append("  ActivityGraphNodes: ").Append(ActivityGraphNodes).Append("\n");
      sb.Append("  Phases: ").Append(Phases).Append("\n");
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
