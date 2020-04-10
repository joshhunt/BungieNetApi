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
  public class IgnoresIgnoreResponse {
    /// <summary>
    /// Gets or Sets IsIgnored
    /// </summary>
    [DataMember(Name="isIgnored", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isIgnored")]
    public bool? IsIgnored { get; set; }

    /// <summary>
    /// Gets or Sets IgnoreFlags
    /// </summary>
    [DataMember(Name="ignoreFlags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ignoreFlags")]
    public int? IgnoreFlags { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IgnoresIgnoreResponse {\n");
      sb.Append("  IsIgnored: ").Append(IsIgnored).Append("\n");
      sb.Append("  IgnoreFlags: ").Append(IgnoreFlags).Append("\n");
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
