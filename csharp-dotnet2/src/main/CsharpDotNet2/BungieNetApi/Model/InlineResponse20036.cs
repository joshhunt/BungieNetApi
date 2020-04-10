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
  public class InlineResponse20036 {
    /// <summary>
    /// Gets or Sets Response
    /// </summary>
    [DataMember(Name="Response", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Response")]
    public DestinyResponsesDestinyLinkedProfilesResponse Response { get; set; }

    /// <summary>
    /// Gets or Sets ErrorCode
    /// </summary>
    [DataMember(Name="ErrorCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ErrorCode")]
    public int? ErrorCode { get; set; }

    /// <summary>
    /// Gets or Sets ThrottleSeconds
    /// </summary>
    [DataMember(Name="ThrottleSeconds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ThrottleSeconds")]
    public int? ThrottleSeconds { get; set; }

    /// <summary>
    /// Gets or Sets ErrorStatus
    /// </summary>
    [DataMember(Name="ErrorStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ErrorStatus")]
    public string ErrorStatus { get; set; }

    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    [DataMember(Name="Message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Message")]
    public string Message { get; set; }

    /// <summary>
    /// Gets or Sets MessageData
    /// </summary>
    [DataMember(Name="MessageData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MessageData")]
    public Dictionary<string, string> MessageData { get; set; }

    /// <summary>
    /// Gets or Sets DetailedErrorTrace
    /// </summary>
    [DataMember(Name="DetailedErrorTrace", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DetailedErrorTrace")]
    public string DetailedErrorTrace { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InlineResponse20036 {\n");
      sb.Append("  Response: ").Append(Response).Append("\n");
      sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
      sb.Append("  ThrottleSeconds: ").Append(ThrottleSeconds).Append("\n");
      sb.Append("  ErrorStatus: ").Append(ErrorStatus).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  MessageData: ").Append(MessageData).Append("\n");
      sb.Append("  DetailedErrorTrace: ").Append(DetailedErrorTrace).Append("\n");
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
