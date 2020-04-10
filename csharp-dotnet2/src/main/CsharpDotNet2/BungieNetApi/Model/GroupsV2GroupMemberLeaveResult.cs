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
  public class GroupsV2GroupMemberLeaveResult {
    /// <summary>
    /// Gets or Sets Group
    /// </summary>
    [DataMember(Name="group", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "group")]
    public GroupsV2GroupV2 Group { get; set; }

    /// <summary>
    /// Gets or Sets GroupDeleted
    /// </summary>
    [DataMember(Name="groupDeleted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "groupDeleted")]
    public bool? GroupDeleted { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GroupsV2GroupMemberLeaveResult {\n");
      sb.Append("  Group: ").Append(Group).Append("\n");
      sb.Append("  GroupDeleted: ").Append(GroupDeleted).Append("\n");
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
