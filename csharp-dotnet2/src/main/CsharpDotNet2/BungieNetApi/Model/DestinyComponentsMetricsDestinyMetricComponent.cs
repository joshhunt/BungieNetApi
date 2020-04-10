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
  public class DestinyComponentsMetricsDestinyMetricComponent {
    /// <summary>
    /// Gets or Sets Invisible
    /// </summary>
    [DataMember(Name="invisible", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invisible")]
    public bool? Invisible { get; set; }

    /// <summary>
    /// Gets or Sets ObjectiveProgress
    /// </summary>
    [DataMember(Name="objectiveProgress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "objectiveProgress")]
    public DestinyQuestsDestinyObjectiveProgress ObjectiveProgress { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyComponentsMetricsDestinyMetricComponent {\n");
      sb.Append("  Invisible: ").Append(Invisible).Append("\n");
      sb.Append("  ObjectiveProgress: ").Append(ObjectiveProgress).Append("\n");
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
