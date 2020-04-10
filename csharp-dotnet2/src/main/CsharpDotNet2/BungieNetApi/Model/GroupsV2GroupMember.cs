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
  public class GroupsV2GroupMember {
    /// <summary>
    /// Gets or Sets MemberType
    /// </summary>
    [DataMember(Name="memberType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "memberType")]
    public int? MemberType { get; set; }

    /// <summary>
    /// Gets or Sets IsOnline
    /// </summary>
    [DataMember(Name="isOnline", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isOnline")]
    public bool? IsOnline { get; set; }

    /// <summary>
    /// Gets or Sets LastOnlineStatusChange
    /// </summary>
    [DataMember(Name="lastOnlineStatusChange", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastOnlineStatusChange")]
    public long? LastOnlineStatusChange { get; set; }

    /// <summary>
    /// Gets or Sets GroupId
    /// </summary>
    [DataMember(Name="groupId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "groupId")]
    public long? GroupId { get; set; }

    /// <summary>
    /// Gets or Sets DestinyUserInfo
    /// </summary>
    [DataMember(Name="destinyUserInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destinyUserInfo")]
    public GroupsV2GroupUserInfoCard DestinyUserInfo { get; set; }

    /// <summary>
    /// Gets or Sets BungieNetUserInfo
    /// </summary>
    [DataMember(Name="bungieNetUserInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bungieNetUserInfo")]
    public UserUserInfoCard BungieNetUserInfo { get; set; }

    /// <summary>
    /// Gets or Sets JoinDate
    /// </summary>
    [DataMember(Name="joinDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "joinDate")]
    public DateTime? JoinDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GroupsV2GroupMember {\n");
      sb.Append("  MemberType: ").Append(MemberType).Append("\n");
      sb.Append("  IsOnline: ").Append(IsOnline).Append("\n");
      sb.Append("  LastOnlineStatusChange: ").Append(LastOnlineStatusChange).Append("\n");
      sb.Append("  GroupId: ").Append(GroupId).Append("\n");
      sb.Append("  DestinyUserInfo: ").Append(DestinyUserInfo).Append("\n");
      sb.Append("  BungieNetUserInfo: ").Append(BungieNetUserInfo).Append("\n");
      sb.Append("  JoinDate: ").Append(JoinDate).Append("\n");
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
