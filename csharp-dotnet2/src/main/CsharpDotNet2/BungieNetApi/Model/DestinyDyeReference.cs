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
  public class DestinyDyeReference {
    /// <summary>
    /// Gets or Sets ChannelHash
    /// </summary>
    [DataMember(Name="channelHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "channelHash")]
    public int? ChannelHash { get; set; }

    /// <summary>
    /// Gets or Sets DyeHash
    /// </summary>
    [DataMember(Name="dyeHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dyeHash")]
    public int? DyeHash { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDyeReference {\n");
      sb.Append("  ChannelHash: ").Append(ChannelHash).Append("\n");
      sb.Append("  DyeHash: ").Append(DyeHash).Append("\n");
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
