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
  public class GroupsV2GroupBan {
    /// <summary>
    /// Gets or Sets GroupId
    /// </summary>
    [DataMember(Name="groupId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "groupId")]
    public long? GroupId { get; set; }

    /// <summary>
    /// Gets or Sets LastModifiedBy
    /// </summary>
    [DataMember(Name="lastModifiedBy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastModifiedBy")]
    public UserUserInfoCard LastModifiedBy { get; set; }

    /// <summary>
    /// Gets or Sets CreatedBy
    /// </summary>
    [DataMember(Name="createdBy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdBy")]
    public UserUserInfoCard CreatedBy { get; set; }

    /// <summary>
    /// Gets or Sets DateBanned
    /// </summary>
    [DataMember(Name="dateBanned", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dateBanned")]
    public DateTime? DateBanned { get; set; }

    /// <summary>
    /// Gets or Sets DateExpires
    /// </summary>
    [DataMember(Name="dateExpires", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dateExpires")]
    public DateTime? DateExpires { get; set; }

    /// <summary>
    /// Gets or Sets Comment
    /// </summary>
    [DataMember(Name="comment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "comment")]
    public string Comment { get; set; }

    /// <summary>
    /// Gets or Sets BungieNetUserInfo
    /// </summary>
    [DataMember(Name="bungieNetUserInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bungieNetUserInfo")]
    public UserUserInfoCard BungieNetUserInfo { get; set; }

    /// <summary>
    /// Gets or Sets DestinyUserInfo
    /// </summary>
    [DataMember(Name="destinyUserInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destinyUserInfo")]
    public GroupsV2GroupUserInfoCard DestinyUserInfo { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GroupsV2GroupBan {\n");
      sb.Append("  GroupId: ").Append(GroupId).Append("\n");
      sb.Append("  LastModifiedBy: ").Append(LastModifiedBy).Append("\n");
      sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
      sb.Append("  DateBanned: ").Append(DateBanned).Append("\n");
      sb.Append("  DateExpires: ").Append(DateExpires).Append("\n");
      sb.Append("  Comment: ").Append(Comment).Append("\n");
      sb.Append("  BungieNetUserInfo: ").Append(BungieNetUserInfo).Append("\n");
      sb.Append("  DestinyUserInfo: ").Append(DestinyUserInfo).Append("\n");
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
