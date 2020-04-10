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
  public class GroupsV2GroupOptionalConversationEditRequest {
    /// <summary>
    /// Gets or Sets ChatEnabled
    /// </summary>
    [DataMember(Name="chatEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "chatEnabled")]
    public bool? ChatEnabled { get; set; }

    /// <summary>
    /// Gets or Sets ChatName
    /// </summary>
    [DataMember(Name="chatName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "chatName")]
    public string ChatName { get; set; }

    /// <summary>
    /// Gets or Sets ChatSecurity
    /// </summary>
    [DataMember(Name="chatSecurity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "chatSecurity")]
    public int? ChatSecurity { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GroupsV2GroupOptionalConversationEditRequest {\n");
      sb.Append("  ChatEnabled: ").Append(ChatEnabled).Append("\n");
      sb.Append("  ChatName: ").Append(ChatName).Append("\n");
      sb.Append("  ChatSecurity: ").Append(ChatSecurity).Append("\n");
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
