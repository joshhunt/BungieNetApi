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
  public class DestinyComponentsMetricsDestinyMetricsComponent {
    /// <summary>
    /// Gets or Sets Metrics
    /// </summary>
    [DataMember(Name="metrics", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "metrics")]
    public Dictionary<string, DestinyComponentsMetricsDestinyMetricComponent> Metrics { get; set; }

    /// <summary>
    /// Gets or Sets MetricsRootNodeHash
    /// </summary>
    [DataMember(Name="metricsRootNodeHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "metricsRootNodeHash")]
    public int? MetricsRootNodeHash { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyComponentsMetricsDestinyMetricsComponent {\n");
      sb.Append("  Metrics: ").Append(Metrics).Append("\n");
      sb.Append("  MetricsRootNodeHash: ").Append(MetricsRootNodeHash).Append("\n");
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
