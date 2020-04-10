using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Represents whatever information we can return about an explicit phase in an activity. In the future, I hope we&#39;ll have more than just \&quot;guh, you done gone and did something,\&quot; but for the forseeable future that&#39;s all we&#39;ve got. I&#39;m making it more than just a list of booleans out of that overly-optimistic hope.
  /// </summary>
  [DataContract]
  public class DestinyMilestonesDestinyMilestoneActivityPhase {
    /// <summary>
    /// Indicates if the phase has been completed.
    /// </summary>
    /// <value>Indicates if the phase has been completed.</value>
    [DataMember(Name="complete", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "complete")]
    public bool? Complete { get; set; }

    /// <summary>
    /// In DestinyActivityDefinition, if the activity has phases, there will be a set of phases defined in the \"insertionPoints\" property. This is the hash that maps to that phase.
    /// </summary>
    /// <value>In DestinyActivityDefinition, if the activity has phases, there will be a set of phases defined in the \"insertionPoints\" property. This is the hash that maps to that phase.</value>
    [DataMember(Name="phaseHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phaseHash")]
    public int? PhaseHash { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyMilestonesDestinyMilestoneActivityPhase {\n");
      sb.Append("  Complete: ").Append(Complete).Append("\n");
      sb.Append("  PhaseHash: ").Append(PhaseHash).Append("\n");
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
