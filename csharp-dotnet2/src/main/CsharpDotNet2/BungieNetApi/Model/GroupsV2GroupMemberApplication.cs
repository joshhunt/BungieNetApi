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
  public class GroupsV2GroupMemberApplication {
    /// <summary>
    /// Gets or Sets GroupId
    /// </summary>
    [DataMember(Name="groupId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "groupId")]
    public long? GroupId { get; set; }

    /// <summary>
    /// Gets or Sets CreationDate
    /// </summary>
    [DataMember(Name="creationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creationDate")]
    public DateTime? CreationDate { get; set; }

    /// <summary>
    /// Gets or Sets ResolveState
    /// </summary>
    [DataMember(Name="resolveState", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resolveState")]
    public int? ResolveState { get; set; }

    /// <summary>
    /// Gets or Sets ResolveDate
    /// </summary>
    [DataMember(Name="resolveDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resolveDate")]
    public DateTime? ResolveDate { get; set; }

    /// <summary>
    /// Gets or Sets ResolvedByMembershipId
    /// </summary>
    [DataMember(Name="resolvedByMembershipId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resolvedByMembershipId")]
    public long? ResolvedByMembershipId { get; set; }

    /// <summary>
    /// Gets or Sets RequestMessage
    /// </summary>
    [DataMember(Name="requestMessage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requestMessage")]
    public string RequestMessage { get; set; }

    /// <summary>
    /// Gets or Sets ResolveMessage
    /// </summary>
    [DataMember(Name="resolveMessage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resolveMessage")]
    public string ResolveMessage { get; set; }

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
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GroupsV2GroupMemberApplication {\n");
      sb.Append("  GroupId: ").Append(GroupId).Append("\n");
      sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
      sb.Append("  ResolveState: ").Append(ResolveState).Append("\n");
      sb.Append("  ResolveDate: ").Append(ResolveDate).Append("\n");
      sb.Append("  ResolvedByMembershipId: ").Append(ResolvedByMembershipId).Append("\n");
      sb.Append("  RequestMessage: ").Append(RequestMessage).Append("\n");
      sb.Append("  ResolveMessage: ").Append(ResolveMessage).Append("\n");
      sb.Append("  DestinyUserInfo: ").Append(DestinyUserInfo).Append("\n");
      sb.Append("  BungieNetUserInfo: ").Append(BungieNetUserInfo).Append("\n");
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
