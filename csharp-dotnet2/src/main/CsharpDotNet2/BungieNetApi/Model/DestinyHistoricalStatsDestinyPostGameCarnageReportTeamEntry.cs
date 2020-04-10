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
  public class DestinyHistoricalStatsDestinyPostGameCarnageReportTeamEntry {
    /// <summary>
    /// Integer ID for the team.
    /// </summary>
    /// <value>Integer ID for the team.</value>
    [DataMember(Name="teamId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "teamId")]
    public int? TeamId { get; set; }

    /// <summary>
    /// Team's standing relative to other teams.
    /// </summary>
    /// <value>Team's standing relative to other teams.</value>
    [DataMember(Name="standing", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "standing")]
    public DestinyHistoricalStatsDestinyHistoricalStatsValue Standing { get; set; }

    /// <summary>
    /// Score earned by the team
    /// </summary>
    /// <value>Score earned by the team</value>
    [DataMember(Name="score", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "score")]
    public DestinyHistoricalStatsDestinyHistoricalStatsValue Score { get; set; }

    /// <summary>
    /// Alpha or Bravo
    /// </summary>
    /// <value>Alpha or Bravo</value>
    [DataMember(Name="teamName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "teamName")]
    public string TeamName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyHistoricalStatsDestinyPostGameCarnageReportTeamEntry {\n");
      sb.Append("  TeamId: ").Append(TeamId).Append("\n");
      sb.Append("  Standing: ").Append(Standing).Append("\n");
      sb.Append("  Score: ").Append(Score).Append("\n");
      sb.Append("  TeamName: ").Append(TeamName).Append("\n");
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
