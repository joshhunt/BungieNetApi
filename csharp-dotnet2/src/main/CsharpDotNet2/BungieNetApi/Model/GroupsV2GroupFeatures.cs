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
  public class GroupsV2GroupFeatures {
    /// <summary>
    /// Gets or Sets MaximumMembers
    /// </summary>
    [DataMember(Name="maximumMembers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maximumMembers")]
    public int? MaximumMembers { get; set; }

    /// <summary>
    /// Maximum number of groups of this type a typical membership may join. For example, a user may join about 50 General groups with their Bungie.net account. They may join one clan per Destiny membership.
    /// </summary>
    /// <value>Maximum number of groups of this type a typical membership may join. For example, a user may join about 50 General groups with their Bungie.net account. They may join one clan per Destiny membership.</value>
    [DataMember(Name="maximumMembershipsOfGroupType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maximumMembershipsOfGroupType")]
    public int? MaximumMembershipsOfGroupType { get; set; }

    /// <summary>
    /// Gets or Sets Capabilities
    /// </summary>
    [DataMember(Name="capabilities", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "capabilities")]
    public int? Capabilities { get; set; }

    /// <summary>
    /// Gets or Sets MembershipTypes
    /// </summary>
    [DataMember(Name="membershipTypes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "membershipTypes")]
    public List<int?> MembershipTypes { get; set; }

    /// <summary>
    /// Minimum Member Level allowed to invite new members to group  Always Allowed: Founder, Acting Founder  True means admins have this power, false means they don't  Default is false for clans, true for groups.
    /// </summary>
    /// <value>Minimum Member Level allowed to invite new members to group  Always Allowed: Founder, Acting Founder  True means admins have this power, false means they don't  Default is false for clans, true for groups.</value>
    [DataMember(Name="invitePermissionOverride", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invitePermissionOverride")]
    public bool? InvitePermissionOverride { get; set; }

    /// <summary>
    /// Minimum Member Level allowed to update group culture  Always Allowed: Founder, Acting Founder  True means admins have this power, false means they don't  Default is false for clans, true for groups.
    /// </summary>
    /// <value>Minimum Member Level allowed to update group culture  Always Allowed: Founder, Acting Founder  True means admins have this power, false means they don't  Default is false for clans, true for groups.</value>
    [DataMember(Name="updateCulturePermissionOverride", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updateCulturePermissionOverride")]
    public bool? UpdateCulturePermissionOverride { get; set; }

    /// <summary>
    /// Minimum Member Level allowed to host guided games  Always Allowed: Founder, Acting Founder, Admin  Allowed Overrides: None, Member, Beginner  Default is Member for clans, None for groups, although this means nothing for groups.
    /// </summary>
    /// <value>Minimum Member Level allowed to host guided games  Always Allowed: Founder, Acting Founder, Admin  Allowed Overrides: None, Member, Beginner  Default is Member for clans, None for groups, although this means nothing for groups.</value>
    [DataMember(Name="hostGuidedGamePermissionOverride", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hostGuidedGamePermissionOverride")]
    public int? HostGuidedGamePermissionOverride { get; set; }

    /// <summary>
    /// Minimum Member Level allowed to update banner  Always Allowed: Founder, Acting Founder  True means admins have this power, false means they don't  Default is false for clans, true for groups.
    /// </summary>
    /// <value>Minimum Member Level allowed to update banner  Always Allowed: Founder, Acting Founder  True means admins have this power, false means they don't  Default is false for clans, true for groups.</value>
    [DataMember(Name="updateBannerPermissionOverride", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updateBannerPermissionOverride")]
    public bool? UpdateBannerPermissionOverride { get; set; }

    /// <summary>
    /// Level to join a member at when accepting an invite, application, or joining an open clan  Default is Beginner.
    /// </summary>
    /// <value>Level to join a member at when accepting an invite, application, or joining an open clan  Default is Beginner.</value>
    [DataMember(Name="joinLevel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "joinLevel")]
    public int? JoinLevel { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GroupsV2GroupFeatures {\n");
      sb.Append("  MaximumMembers: ").Append(MaximumMembers).Append("\n");
      sb.Append("  MaximumMembershipsOfGroupType: ").Append(MaximumMembershipsOfGroupType).Append("\n");
      sb.Append("  Capabilities: ").Append(Capabilities).Append("\n");
      sb.Append("  MembershipTypes: ").Append(MembershipTypes).Append("\n");
      sb.Append("  InvitePermissionOverride: ").Append(InvitePermissionOverride).Append("\n");
      sb.Append("  UpdateCulturePermissionOverride: ").Append(UpdateCulturePermissionOverride).Append("\n");
      sb.Append("  HostGuidedGamePermissionOverride: ").Append(HostGuidedGamePermissionOverride).Append("\n");
      sb.Append("  UpdateBannerPermissionOverride: ").Append(UpdateBannerPermissionOverride).Append("\n");
      sb.Append("  JoinLevel: ").Append(JoinLevel).Append("\n");
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
