using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Represents this player&#39;s personal completion status for the Activity under a Milestone, if the activity has trackable completion and progress information. (most activities won&#39;t, or the concept won&#39;t apply. For instance, it makes sense to talk about a tier of a raid as being Completed or having progress, but it doesn&#39;t make sense to talk about a Crucible Playlist in those terms.
  /// </summary>
  [DataContract]
  public class DestinyMilestonesDestinyMilestoneActivityCompletionStatus {
    /// <summary>
    /// If the activity has been \"completed\", that information will be returned here.
    /// </summary>
    /// <value>If the activity has been \"completed\", that information will be returned here.</value>
    [DataMember(Name="completed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "completed")]
    public bool? Completed { get; set; }

    /// <summary>
    /// If the Activity has discrete \"phases\" that we can track, that info will be here. Otherwise, this value will be NULL. Note that this is a list and not a dictionary: the order implies the ascending order of phases or progression in this activity.
    /// </summary>
    /// <value>If the Activity has discrete \"phases\" that we can track, that info will be here. Otherwise, this value will be NULL. Note that this is a list and not a dictionary: the order implies the ascending order of phases or progression in this activity.</value>
    [DataMember(Name="phases", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phases")]
    public List<DestinyMilestonesDestinyMilestoneActivityPhase> Phases { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyMilestonesDestinyMilestoneActivityCompletionStatus {\n");
      sb.Append("  Completed: ").Append(Completed).Append("\n");
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
