using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Represents a variant of an activity that&#39;s relevant to a milestone.
  /// </summary>
  [DataContract]
  public class DestinyMilestonesDestinyPublicMilestoneActivityVariant {
    /// <summary>
    /// The hash identifier of this activity variant. Examine the activity's definition in the Manifest database to determine what makes it a distinct variant. Usually it will be difficulty level or whether or not it is a guided game variant of the activity, but theoretically it could be distinguished in any arbitrary way.
    /// </summary>
    /// <value>The hash identifier of this activity variant. Examine the activity's definition in the Manifest database to determine what makes it a distinct variant. Usually it will be difficulty level or whether or not it is a guided game variant of the activity, but theoretically it could be distinguished in any arbitrary way.</value>
    [DataMember(Name="activityHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activityHash")]
    public int? ActivityHash { get; set; }

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
      sb.Append("class DestinyMilestonesDestinyPublicMilestoneActivityVariant {\n");
      sb.Append("  ActivityHash: ").Append(ActivityHash).Append("\n");
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
