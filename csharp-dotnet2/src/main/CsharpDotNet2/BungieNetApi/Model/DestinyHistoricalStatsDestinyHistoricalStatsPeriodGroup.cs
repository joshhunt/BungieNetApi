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
  public class DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup {
    /// <summary>
    /// Period for the group. If the stat periodType is day, then this will have a specific day. If the type is monthly, then this value will be the first day of the applicable month. This value is not set when the periodType is 'all time'.
    /// </summary>
    /// <value>Period for the group. If the stat periodType is day, then this will have a specific day. If the type is monthly, then this value will be the first day of the applicable month. This value is not set when the periodType is 'all time'.</value>
    [DataMember(Name="period", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "period")]
    public DateTime? Period { get; set; }

    /// <summary>
    /// If the period group is for a specific activity, this property will be set.
    /// </summary>
    /// <value>If the period group is for a specific activity, this property will be set.</value>
    [DataMember(Name="activityDetails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activityDetails")]
    public DestinyHistoricalStatsDestinyHistoricalStatsActivity ActivityDetails { get; set; }

    /// <summary>
    /// Collection of stats for the period.
    /// </summary>
    /// <value>Collection of stats for the period.</value>
    [DataMember(Name="values", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "values")]
    public Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsValue> Values { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup {\n");
      sb.Append("  Period: ").Append(Period).Append("\n");
      sb.Append("  ActivityDetails: ").Append(ActivityDetails).Append("\n");
      sb.Append("  Values: ").Append(Values).Append("\n");
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
