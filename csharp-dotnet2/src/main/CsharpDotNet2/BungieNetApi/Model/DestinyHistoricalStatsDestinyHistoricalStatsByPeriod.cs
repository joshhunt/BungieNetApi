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
  public class DestinyHistoricalStatsDestinyHistoricalStatsByPeriod {
    /// <summary>
    /// Gets or Sets AllTime
    /// </summary>
    [DataMember(Name="allTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allTime")]
    public Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsValue> AllTime { get; set; }

    /// <summary>
    /// Gets or Sets AllTimeTier1
    /// </summary>
    [DataMember(Name="allTimeTier1", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allTimeTier1")]
    public Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsValue> AllTimeTier1 { get; set; }

    /// <summary>
    /// Gets or Sets AllTimeTier2
    /// </summary>
    [DataMember(Name="allTimeTier2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allTimeTier2")]
    public Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsValue> AllTimeTier2 { get; set; }

    /// <summary>
    /// Gets or Sets AllTimeTier3
    /// </summary>
    [DataMember(Name="allTimeTier3", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allTimeTier3")]
    public Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsValue> AllTimeTier3 { get; set; }

    /// <summary>
    /// Gets or Sets Daily
    /// </summary>
    [DataMember(Name="daily", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "daily")]
    public List<DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup> Daily { get; set; }

    /// <summary>
    /// Gets or Sets Monthly
    /// </summary>
    [DataMember(Name="monthly", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "monthly")]
    public List<DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup> Monthly { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyHistoricalStatsDestinyHistoricalStatsByPeriod {\n");
      sb.Append("  AllTime: ").Append(AllTime).Append("\n");
      sb.Append("  AllTimeTier1: ").Append(AllTimeTier1).Append("\n");
      sb.Append("  AllTimeTier2: ").Append(AllTimeTier2).Append("\n");
      sb.Append("  AllTimeTier3: ").Append(AllTimeTier3).Append("\n");
      sb.Append("  Daily: ").Append(Daily).Append("\n");
      sb.Append("  Monthly: ").Append(Monthly).Append("\n");
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
