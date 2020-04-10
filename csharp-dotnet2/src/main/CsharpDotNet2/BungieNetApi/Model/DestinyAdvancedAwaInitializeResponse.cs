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
  public class DestinyAdvancedAwaInitializeResponse {
    /// <summary>
    /// ID used to get the token. Present this ID to the user as it will identify this specific request on their device.
    /// </summary>
    /// <value>ID used to get the token. Present this ID to the user as it will identify this specific request on their device.</value>
    [DataMember(Name="correlationId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "correlationId")]
    public string CorrelationId { get; set; }

    /// <summary>
    /// True if the PUSH message will only be sent to the device that made this request.
    /// </summary>
    /// <value>True if the PUSH message will only be sent to the device that made this request.</value>
    [DataMember(Name="sentToSelf", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sentToSelf")]
    public bool? SentToSelf { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyAdvancedAwaInitializeResponse {\n");
      sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
      sb.Append("  SentToSelf: ").Append(SentToSelf).Append("\n");
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
