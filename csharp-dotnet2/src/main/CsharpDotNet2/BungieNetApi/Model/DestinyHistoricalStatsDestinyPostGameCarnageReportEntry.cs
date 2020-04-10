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
  public class DestinyHistoricalStatsDestinyPostGameCarnageReportEntry {
    /// <summary>
    /// Standing of the player
    /// </summary>
    /// <value>Standing of the player</value>
    [DataMember(Name="standing", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "standing")]
    public int? Standing { get; set; }

    /// <summary>
    /// Score of the player if available
    /// </summary>
    /// <value>Score of the player if available</value>
    [DataMember(Name="score", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "score")]
    public DestinyHistoricalStatsDestinyHistoricalStatsValue Score { get; set; }

    /// <summary>
    /// Identity details of the player
    /// </summary>
    /// <value>Identity details of the player</value>
    [DataMember(Name="player", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "player")]
    public DestinyHistoricalStatsDestinyPlayer Player { get; set; }

    /// <summary>
    /// ID of the player's character used in the activity.
    /// </summary>
    /// <value>ID of the player's character used in the activity.</value>
    [DataMember(Name="characterId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "characterId")]
    public long? CharacterId { get; set; }

    /// <summary>
    /// Collection of stats for the player in this activity.
    /// </summary>
    /// <value>Collection of stats for the player in this activity.</value>
    [DataMember(Name="values", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "values")]
    public Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsValue> Values { get; set; }

    /// <summary>
    /// Extended data extracted from the activity blob.
    /// </summary>
    /// <value>Extended data extracted from the activity blob.</value>
    [DataMember(Name="extended", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "extended")]
    public DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedData Extended { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyHistoricalStatsDestinyPostGameCarnageReportEntry {\n");
      sb.Append("  Standing: ").Append(Standing).Append("\n");
      sb.Append("  Score: ").Append(Score).Append("\n");
      sb.Append("  Player: ").Append(Player).Append("\n");
      sb.Append("  CharacterId: ").Append(CharacterId).Append("\n");
      sb.Append("  Values: ").Append(Values).Append("\n");
      sb.Append("  Extended: ").Append(Extended).Append("\n");
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
