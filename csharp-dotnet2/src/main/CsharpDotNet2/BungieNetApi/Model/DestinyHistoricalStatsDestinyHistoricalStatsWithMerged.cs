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
  public class DestinyHistoricalStatsDestinyHistoricalStatsWithMerged {
    /// <summary>
    /// Gets or Sets Results
    /// </summary>
    [DataMember(Name="results", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "results")]
    public Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsByPeriod> Results { get; set; }

    /// <summary>
    /// Gets or Sets Merged
    /// </summary>
    [DataMember(Name="merged", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merged")]
    public DestinyHistoricalStatsDestinyHistoricalStatsByPeriod Merged { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyHistoricalStatsDestinyHistoricalStatsWithMerged {\n");
      sb.Append("  Results: ").Append(Results).Append("\n");
      sb.Append("  Merged: ").Append(Merged).Append("\n");
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
