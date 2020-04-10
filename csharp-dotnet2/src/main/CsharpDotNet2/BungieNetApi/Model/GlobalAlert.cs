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
  public class GlobalAlert {
    /// <summary>
    /// Gets or Sets AlertKey
    /// </summary>
    [DataMember(Name="AlertKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AlertKey")]
    public string AlertKey { get; set; }

    /// <summary>
    /// Gets or Sets AlertHtml
    /// </summary>
    [DataMember(Name="AlertHtml", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AlertHtml")]
    public string AlertHtml { get; set; }

    /// <summary>
    /// Gets or Sets AlertTimestamp
    /// </summary>
    [DataMember(Name="AlertTimestamp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AlertTimestamp")]
    public DateTime? AlertTimestamp { get; set; }

    /// <summary>
    /// Gets or Sets AlertLink
    /// </summary>
    [DataMember(Name="AlertLink", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AlertLink")]
    public string AlertLink { get; set; }

    /// <summary>
    /// Gets or Sets AlertLevel
    /// </summary>
    [DataMember(Name="AlertLevel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AlertLevel")]
    public int? AlertLevel { get; set; }

    /// <summary>
    /// Gets or Sets AlertType
    /// </summary>
    [DataMember(Name="AlertType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AlertType")]
    public int? AlertType { get; set; }

    /// <summary>
    /// Gets or Sets StreamInfo
    /// </summary>
    [DataMember(Name="StreamInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StreamInfo")]
    public StreamInfo StreamInfo { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GlobalAlert {\n");
      sb.Append("  AlertKey: ").Append(AlertKey).Append("\n");
      sb.Append("  AlertHtml: ").Append(AlertHtml).Append("\n");
      sb.Append("  AlertTimestamp: ").Append(AlertTimestamp).Append("\n");
      sb.Append("  AlertLink: ").Append(AlertLink).Append("\n");
      sb.Append("  AlertLevel: ").Append(AlertLevel).Append("\n");
      sb.Append("  AlertType: ").Append(AlertType).Append("\n");
      sb.Append("  StreamInfo: ").Append(StreamInfo).Append("\n");
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
