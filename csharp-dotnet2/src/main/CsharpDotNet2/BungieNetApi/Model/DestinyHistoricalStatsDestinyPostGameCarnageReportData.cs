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
  public class DestinyHistoricalStatsDestinyPostGameCarnageReportData {
    /// <summary>
    /// Date and time for the activity.
    /// </summary>
    /// <value>Date and time for the activity.</value>
    [DataMember(Name="period", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "period")]
    public DateTime? Period { get; set; }

    /// <summary>
    /// If this activity has \"phases\", this is the phase at which the activity was started.
    /// </summary>
    /// <value>If this activity has \"phases\", this is the phase at which the activity was started.</value>
    [DataMember(Name="startingPhaseIndex", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startingPhaseIndex")]
    public int? StartingPhaseIndex { get; set; }

    /// <summary>
    /// Details about the activity.
    /// </summary>
    /// <value>Details about the activity.</value>
    [DataMember(Name="activityDetails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activityDetails")]
    public DestinyHistoricalStatsDestinyHistoricalStatsActivity ActivityDetails { get; set; }

    /// <summary>
    /// Collection of players and their data for this activity.
    /// </summary>
    /// <value>Collection of players and their data for this activity.</value>
    [DataMember(Name="entries", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "entries")]
    public List<DestinyHistoricalStatsDestinyPostGameCarnageReportEntry> Entries { get; set; }

    /// <summary>
    /// Collection of stats for the player in this activity.
    /// </summary>
    /// <value>Collection of stats for the player in this activity.</value>
    [DataMember(Name="teams", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "teams")]
    public List<DestinyHistoricalStatsDestinyPostGameCarnageReportTeamEntry> Teams { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyHistoricalStatsDestinyPostGameCarnageReportData {\n");
      sb.Append("  Period: ").Append(Period).Append("\n");
      sb.Append("  StartingPhaseIndex: ").Append(StartingPhaseIndex).Append("\n");
      sb.Append("  ActivityDetails: ").Append(ActivityDetails).Append("\n");
      sb.Append("  Entries: ").Append(Entries).Append("\n");
      sb.Append("  Teams: ").Append(Teams).Append("\n");
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
