using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// If you are playing in an activity, this is some information about it.  Note that we cannot guarantee any of this resembles what ends up in the PGCR in any way. They are sourced by two entirely separate systems with their own logic, and the one we source this data from should be considered non-authoritative in comparison.
  /// </summary>
  [DataContract]
  public class DestinyComponentsProfilesDestinyProfileTransitoryCurrentActivity {
    /// <summary>
    /// When the activity started.
    /// </summary>
    /// <value>When the activity started.</value>
    [DataMember(Name="startTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startTime")]
    public DateTime? StartTime { get; set; }

    /// <summary>
    /// If you're still in it but it \"ended\" (like when folks are dancing around the loot after they beat a boss), this is when the activity ended.
    /// </summary>
    /// <value>If you're still in it but it \"ended\" (like when folks are dancing around the loot after they beat a boss), this is when the activity ended.</value>
    [DataMember(Name="endTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endTime")]
    public DateTime? EndTime { get; set; }

    /// <summary>
    /// This is what our non-authoritative source thought the score was.
    /// </summary>
    /// <value>This is what our non-authoritative source thought the score was.</value>
    [DataMember(Name="score", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "score")]
    public float? Score { get; set; }

    /// <summary>
    /// If you have human opponents, this is the highest opposing team's score.
    /// </summary>
    /// <value>If you have human opponents, this is the highest opposing team's score.</value>
    [DataMember(Name="highestOpposingFactionScore", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "highestOpposingFactionScore")]
    public float? HighestOpposingFactionScore { get; set; }

    /// <summary>
    /// This is how many human or poorly crafted aimbot opponents you have.
    /// </summary>
    /// <value>This is how many human or poorly crafted aimbot opponents you have.</value>
    [DataMember(Name="numberOfOpponents", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "numberOfOpponents")]
    public int? NumberOfOpponents { get; set; }

    /// <summary>
    /// This is how many human or poorly crafted aimbots are on your team.
    /// </summary>
    /// <value>This is how many human or poorly crafted aimbots are on your team.</value>
    [DataMember(Name="numberOfPlayers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "numberOfPlayers")]
    public int? NumberOfPlayers { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyComponentsProfilesDestinyProfileTransitoryCurrentActivity {\n");
      sb.Append("  StartTime: ").Append(StartTime).Append("\n");
      sb.Append("  EndTime: ").Append(EndTime).Append("\n");
      sb.Append("  Score: ").Append(Score).Append("\n");
      sb.Append("  HighestOpposingFactionScore: ").Append(HighestOpposingFactionScore).Append("\n");
      sb.Append("  NumberOfOpponents: ").Append(NumberOfOpponents).Append("\n");
      sb.Append("  NumberOfPlayers: ").Append(NumberOfPlayers).Append("\n");
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
