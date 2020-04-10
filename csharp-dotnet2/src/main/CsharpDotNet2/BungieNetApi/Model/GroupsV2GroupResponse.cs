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
  public class GroupsV2GroupResponse {
    /// <summary>
    /// Gets or Sets Detail
    /// </summary>
    [DataMember(Name="detail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "detail")]
    public GroupsV2GroupV2 Detail { get; set; }

    /// <summary>
    /// Gets or Sets Founder
    /// </summary>
    [DataMember(Name="founder", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "founder")]
    public GroupsV2GroupMember Founder { get; set; }

    /// <summary>
    /// Gets or Sets AlliedIds
    /// </summary>
    [DataMember(Name="alliedIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "alliedIds")]
    public List<long?> AlliedIds { get; set; }

    /// <summary>
    /// Gets or Sets ParentGroup
    /// </summary>
    [DataMember(Name="parentGroup", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parentGroup")]
    public GroupsV2GroupV2 ParentGroup { get; set; }

    /// <summary>
    /// Gets or Sets AllianceStatus
    /// </summary>
    [DataMember(Name="allianceStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allianceStatus")]
    public int? AllianceStatus { get; set; }

    /// <summary>
    /// Gets or Sets GroupJoinInviteCount
    /// </summary>
    [DataMember(Name="groupJoinInviteCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "groupJoinInviteCount")]
    public int? GroupJoinInviteCount { get; set; }

    /// <summary>
    /// A convenience property that indicates if every membership you (the current user) have that is a part of this group are part of an account that is considered inactive - for example, overridden accounts in Cross Save.
    /// </summary>
    /// <value>A convenience property that indicates if every membership you (the current user) have that is a part of this group are part of an account that is considered inactive - for example, overridden accounts in Cross Save.</value>
    [DataMember(Name="currentUserMembershipsInactiveForDestiny", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentUserMembershipsInactiveForDestiny")]
    public bool? CurrentUserMembershipsInactiveForDestiny { get; set; }

    /// <summary>
    /// This property will be populated if the authenticated user is a member of the group. Note that because of account linking, a user can sometimes be part of a clan more than once. As such, this returns the highest member type available.
    /// </summary>
    /// <value>This property will be populated if the authenticated user is a member of the group. Note that because of account linking, a user can sometimes be part of a clan more than once. As such, this returns the highest member type available.</value>
    [DataMember(Name="currentUserMemberMap", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentUserMemberMap")]
    public Dictionary<string, GroupsV2GroupMember> CurrentUserMemberMap { get; set; }

    /// <summary>
    /// This property will be populated if the authenticated user is an applicant or has an outstanding invitation to join. Note that because of account linking, a user can sometimes be part of a clan more than once.
    /// </summary>
    /// <value>This property will be populated if the authenticated user is an applicant or has an outstanding invitation to join. Note that because of account linking, a user can sometimes be part of a clan more than once.</value>
    [DataMember(Name="currentUserPotentialMemberMap", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentUserPotentialMemberMap")]
    public Dictionary<string, GroupsV2GroupPotentialMember> CurrentUserPotentialMemberMap { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GroupsV2GroupResponse {\n");
      sb.Append("  Detail: ").Append(Detail).Append("\n");
      sb.Append("  Founder: ").Append(Founder).Append("\n");
      sb.Append("  AlliedIds: ").Append(AlliedIds).Append("\n");
      sb.Append("  ParentGroup: ").Append(ParentGroup).Append("\n");
      sb.Append("  AllianceStatus: ").Append(AllianceStatus).Append("\n");
      sb.Append("  GroupJoinInviteCount: ").Append(GroupJoinInviteCount).Append("\n");
      sb.Append("  CurrentUserMembershipsInactiveForDestiny: ").Append(CurrentUserMembershipsInactiveForDestiny).Append("\n");
      sb.Append("  CurrentUserMemberMap: ").Append(CurrentUserMemberMap).Append("\n");
      sb.Append("  CurrentUserPotentialMemberMap: ").Append(CurrentUserPotentialMemberMap).Append("\n");
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
