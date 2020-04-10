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
  public class DestinyDefinitionsRecordsDestinyRecordCompletionBlock {
    /// <summary>
    /// The number of objectives that must be completed before the objective is considered \"complete\"
    /// </summary>
    /// <value>The number of objectives that must be completed before the objective is considered \"complete\"</value>
    [DataMember(Name="partialCompletionObjectiveCountThreshold", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "partialCompletionObjectiveCountThreshold")]
    public int? PartialCompletionObjectiveCountThreshold { get; set; }

    /// <summary>
    /// Gets or Sets ScoreValue
    /// </summary>
    [DataMember(Name="ScoreValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ScoreValue")]
    public int? ScoreValue { get; set; }

    /// <summary>
    /// Gets or Sets ShouldFireToast
    /// </summary>
    [DataMember(Name="shouldFireToast", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shouldFireToast")]
    public bool? ShouldFireToast { get; set; }

    /// <summary>
    /// Gets or Sets ToastStyle
    /// </summary>
    [DataMember(Name="toastStyle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "toastStyle")]
    public int? ToastStyle { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsRecordsDestinyRecordCompletionBlock {\n");
      sb.Append("  PartialCompletionObjectiveCountThreshold: ").Append(PartialCompletionObjectiveCountThreshold).Append("\n");
      sb.Append("  ScoreValue: ").Append(ScoreValue).Append("\n");
      sb.Append("  ShouldFireToast: ").Append(ShouldFireToast).Append("\n");
      sb.Append("  ToastStyle: ").Append(ToastStyle).Append("\n");
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
