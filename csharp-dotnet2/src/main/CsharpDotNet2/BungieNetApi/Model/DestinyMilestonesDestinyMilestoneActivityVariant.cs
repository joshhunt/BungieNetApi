using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Represents custom data that we know about an individual variant of an activity.
  /// </summary>
  [DataContract]
  public class DestinyMilestonesDestinyMilestoneActivityVariant {
    /// <summary>
    /// The hash for the specific variant of the activity related to this milestone. You can pull more detailed static info from the DestinyActivityDefinition, such as difficulty level.
    /// </summary>
    /// <value>The hash for the specific variant of the activity related to this milestone. You can pull more detailed static info from the DestinyActivityDefinition, such as difficulty level.</value>
    [DataMember(Name="activityHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activityHash")]
    public int? ActivityHash { get; set; }

    /// <summary>
    /// An OPTIONAL component: if it makes sense to talk about this activity variant in terms of whether or not it has been completed or what progress you have made in it, this will be returned. Otherwise, this will be NULL.
    /// </summary>
    /// <value>An OPTIONAL component: if it makes sense to talk about this activity variant in terms of whether or not it has been completed or what progress you have made in it, this will be returned. Otherwise, this will be NULL.</value>
    [DataMember(Name="completionStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "completionStatus")]
    public DestinyMilestonesDestinyMilestoneActivityCompletionStatus CompletionStatus { get; set; }

    /// <summary>
    /// The hash identifier of the most specific Activity Mode under which this activity is played. This is useful for situations where the activity in question is - for instance - a PVP map, but it's not clear what mode the PVP map is being played under. If it's a playlist, this will be less specific: but hopefully useful in some way.
    /// </summary>
    /// <value>The hash identifier of the most specific Activity Mode under which this activity is played. This is useful for situations where the activity in question is - for instance - a PVP map, but it's not clear what mode the PVP map is being played under. If it's a playlist, this will be less specific: but hopefully useful in some way.</value>
    [DataMember(Name="activityModeHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activityModeHash")]
    public int? ActivityModeHash { get; set; }

    /// <summary>
    /// The enumeration equivalent of the most specific Activity Mode under which this activity is played.
    /// </summary>
    /// <value>The enumeration equivalent of the most specific Activity Mode under which this activity is played.</value>
    [DataMember(Name="activityModeType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activityModeType")]
    public int? ActivityModeType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyMilestonesDestinyMilestoneActivityVariant {\n");
      sb.Append("  ActivityHash: ").Append(ActivityHash).Append("\n");
      sb.Append("  CompletionStatus: ").Append(CompletionStatus).Append("\n");
      sb.Append("  ActivityModeHash: ").Append(ActivityModeHash).Append("\n");
      sb.Append("  ActivityModeType: ").Append(ActivityModeType).Append("\n");
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
