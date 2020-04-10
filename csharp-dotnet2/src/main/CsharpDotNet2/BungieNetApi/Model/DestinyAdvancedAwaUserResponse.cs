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
  public class DestinyAdvancedAwaUserResponse {
    /// <summary>
    /// Indication of the selection the user has made (Approving or rejecting the action)
    /// </summary>
    /// <value>Indication of the selection the user has made (Approving or rejecting the action)</value>
    [DataMember(Name="selection", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "selection")]
    public int? Selection { get; set; }

    /// <summary>
    /// Correlation ID of the request
    /// </summary>
    /// <value>Correlation ID of the request</value>
    [DataMember(Name="correlationId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "correlationId")]
    public string CorrelationId { get; set; }

    /// <summary>
    /// Secret nonce received via the PUSH notification.
    /// </summary>
    /// <value>Secret nonce received via the PUSH notification.</value>
    [DataMember(Name="nonce", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nonce")]
    public List<byte[]> Nonce { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyAdvancedAwaUserResponse {\n");
      sb.Append("  Selection: ").Append(Selection).Append("\n");
      sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
      sb.Append("  Nonce: ").Append(Nonce).Append("\n");
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
