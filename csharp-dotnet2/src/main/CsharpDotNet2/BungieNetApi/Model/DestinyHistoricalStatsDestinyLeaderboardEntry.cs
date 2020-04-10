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
  public class DestinyHistoricalStatsDestinyLeaderboardEntry {
    /// <summary>
    /// Where this player ranks on the leaderboard. A value of 1 is the top rank.
    /// </summary>
    /// <value>Where this player ranks on the leaderboard. A value of 1 is the top rank.</value>
    [DataMember(Name="rank", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rank")]
    public int? Rank { get; set; }

    /// <summary>
    /// Identity details of the player
    /// </summary>
    /// <value>Identity details of the player</value>
    [DataMember(Name="player", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "player")]
    public DestinyHistoricalStatsDestinyPlayer Player { get; set; }

    /// <summary>
    /// ID of the player's best character for the reported stat.
    /// </summary>
    /// <value>ID of the player's best character for the reported stat.</value>
    [DataMember(Name="characterId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "characterId")]
    public long? CharacterId { get; set; }

    /// <summary>
    /// Value of the stat for this player
    /// </summary>
    /// <value>Value of the stat for this player</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public DestinyHistoricalStatsDestinyHistoricalStatsValue Value { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyHistoricalStatsDestinyLeaderboardEntry {\n");
      sb.Append("  Rank: ").Append(Rank).Append("\n");
      sb.Append("  Player: ").Append(Player).Append("\n");
      sb.Append("  CharacterId: ").Append(CharacterId).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
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
