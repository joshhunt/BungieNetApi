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
  public class DestinyHistoricalStatsDestinyClanAggregateStat {
    /// <summary>
    /// The id of the mode of stats (allPvp, allPvE, etc)
    /// </summary>
    /// <value>The id of the mode of stats (allPvp, allPvE, etc)</value>
    [DataMember(Name="mode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mode")]
    public int? Mode { get; set; }

    /// <summary>
    /// The id of the stat
    /// </summary>
    /// <value>The id of the stat</value>
    [DataMember(Name="statId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statId")]
    public string StatId { get; set; }

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
      sb.Append("class DestinyHistoricalStatsDestinyClanAggregateStat {\n");
      sb.Append("  Mode: ").Append(Mode).Append("\n");
      sb.Append("  StatId: ").Append(StatId).Append("\n");
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
