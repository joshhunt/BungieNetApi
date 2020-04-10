using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Summary information about the activity that was played.
  /// </summary>
  [DataContract]
  public class DestinyHistoricalStatsDestinyHistoricalStatsActivity {
    /// <summary>
    /// The unique hash identifier of the DestinyActivityDefinition that was played. If I had this to do over, it'd be named activityHash. Too late now.
    /// </summary>
    /// <value>The unique hash identifier of the DestinyActivityDefinition that was played. If I had this to do over, it'd be named activityHash. Too late now.</value>
    [DataMember(Name="referenceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "referenceId")]
    public int? ReferenceId { get; set; }

    /// <summary>
    /// The unique hash identifier of the DestinyActivityDefinition that was played.
    /// </summary>
    /// <value>The unique hash identifier of the DestinyActivityDefinition that was played.</value>
    [DataMember(Name="directorActivityHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "directorActivityHash")]
    public int? DirectorActivityHash { get; set; }

    /// <summary>
    /// The unique identifier for this *specific* match that was played.  This value can be used to get additional data about this activity such as who else was playing via the GetPostGameCarnageReport endpoint.
    /// </summary>
    /// <value>The unique identifier for this *specific* match that was played.  This value can be used to get additional data about this activity such as who else was playing via the GetPostGameCarnageReport endpoint.</value>
    [DataMember(Name="instanceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "instanceId")]
    public long? InstanceId { get; set; }

    /// <summary>
    /// Indicates the most specific game mode of the activity that we could find.
    /// </summary>
    /// <value>Indicates the most specific game mode of the activity that we could find.</value>
    [DataMember(Name="mode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mode")]
    public int? Mode { get; set; }

    /// <summary>
    /// The list of all Activity Modes to which this activity applies, including aggregates. This will let you see, for example, whether the activity was both Clash and part of the Trials of the Nine event.
    /// </summary>
    /// <value>The list of all Activity Modes to which this activity applies, including aggregates. This will let you see, for example, whether the activity was both Clash and part of the Trials of the Nine event.</value>
    [DataMember(Name="modes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "modes")]
    public List<int?> Modes { get; set; }

    /// <summary>
    /// Whether or not the match was a private match.
    /// </summary>
    /// <value>Whether or not the match was a private match.</value>
    [DataMember(Name="isPrivate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isPrivate")]
    public bool? IsPrivate { get; set; }

    /// <summary>
    /// The Membership Type indicating the platform on which this match was played.
    /// </summary>
    /// <value>The Membership Type indicating the platform on which this match was played.</value>
    [DataMember(Name="membershipType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "membershipType")]
    public int? MembershipType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyHistoricalStatsDestinyHistoricalStatsActivity {\n");
      sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
      sb.Append("  DirectorActivityHash: ").Append(DirectorActivityHash).Append("\n");
      sb.Append("  InstanceId: ").Append(InstanceId).Append("\n");
      sb.Append("  Mode: ").Append(Mode).Append("\n");
      sb.Append("  Modes: ").Append(Modes).Append("\n");
      sb.Append("  IsPrivate: ").Append(IsPrivate).Append("\n");
      sb.Append("  MembershipType: ").Append(MembershipType).Append("\n");
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
