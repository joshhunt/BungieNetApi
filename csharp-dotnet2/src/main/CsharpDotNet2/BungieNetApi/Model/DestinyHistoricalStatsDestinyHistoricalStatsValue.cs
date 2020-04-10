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
  public class DestinyHistoricalStatsDestinyHistoricalStatsValue {
    /// <summary>
    /// Unique ID for this stat
    /// </summary>
    /// <value>Unique ID for this stat</value>
    [DataMember(Name="statId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statId")]
    public string StatId { get; set; }

    /// <summary>
    /// Basic stat value.
    /// </summary>
    /// <value>Basic stat value.</value>
    [DataMember(Name="basic", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "basic")]
    public DestinyHistoricalStatsDestinyHistoricalStatsValuePair Basic { get; set; }

    /// <summary>
    /// Per game average for the statistic, if applicable
    /// </summary>
    /// <value>Per game average for the statistic, if applicable</value>
    [DataMember(Name="pga", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pga")]
    public DestinyHistoricalStatsDestinyHistoricalStatsValuePair Pga { get; set; }

    /// <summary>
    /// Weighted value of the stat if a weight greater than 1 has been assigned.
    /// </summary>
    /// <value>Weighted value of the stat if a weight greater than 1 has been assigned.</value>
    [DataMember(Name="weighted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "weighted")]
    public DestinyHistoricalStatsDestinyHistoricalStatsValuePair Weighted { get; set; }

    /// <summary>
    /// When a stat represents the best, most, longest, fastest or some other personal best, the actual activity ID where that personal best was established is available on this property.
    /// </summary>
    /// <value>When a stat represents the best, most, longest, fastest or some other personal best, the actual activity ID where that personal best was established is available on this property.</value>
    [DataMember(Name="activityId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activityId")]
    public long? ActivityId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyHistoricalStatsDestinyHistoricalStatsValue {\n");
      sb.Append("  StatId: ").Append(StatId).Append("\n");
      sb.Append("  Basic: ").Append(Basic).Append("\n");
      sb.Append("  Pga: ").Append(Pga).Append("\n");
      sb.Append("  Weighted: ").Append(Weighted).Append("\n");
      sb.Append("  ActivityId: ").Append(ActivityId).Append("\n");
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
