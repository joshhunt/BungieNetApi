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
  public class GroupsV2GroupOptionsEditAction {
    /// <summary>
    /// Minimum Member Level allowed to invite new members to group  Always Allowed: Founder, Acting Founder  True means admins have this power, false means they don't  Default is false for clans, true for groups.
    /// </summary>
    /// <value>Minimum Member Level allowed to invite new members to group  Always Allowed: Founder, Acting Founder  True means admins have this power, false means they don't  Default is false for clans, true for groups.</value>
    [DataMember(Name="InvitePermissionOverride", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InvitePermissionOverride")]
    public bool? InvitePermissionOverride { get; set; }

    /// <summary>
    /// Minimum Member Level allowed to update group culture  Always Allowed: Founder, Acting Founder  True means admins have this power, false means they don't  Default is false for clans, true for groups.
    /// </summary>
    /// <value>Minimum Member Level allowed to update group culture  Always Allowed: Founder, Acting Founder  True means admins have this power, false means they don't  Default is false for clans, true for groups.</value>
    [DataMember(Name="UpdateCulturePermissionOverride", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpdateCulturePermissionOverride")]
    public bool? UpdateCulturePermissionOverride { get; set; }

    /// <summary>
    /// Minimum Member Level allowed to host guided games  Always Allowed: Founder, Acting Founder, Admin  Allowed Overrides: None, Member, Beginner  Default is Member for clans, None for groups, although this means nothing for groups.
    /// </summary>
    /// <value>Minimum Member Level allowed to host guided games  Always Allowed: Founder, Acting Founder, Admin  Allowed Overrides: None, Member, Beginner  Default is Member for clans, None for groups, although this means nothing for groups.</value>
    [DataMember(Name="HostGuidedGamePermissionOverride", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "HostGuidedGamePermissionOverride")]
    public int? HostGuidedGamePermissionOverride { get; set; }

    /// <summary>
    /// Minimum Member Level allowed to update banner  Always Allowed: Founder, Acting Founder  True means admins have this power, false means they don't  Default is false for clans, true for groups.
    /// </summary>
    /// <value>Minimum Member Level allowed to update banner  Always Allowed: Founder, Acting Founder  True means admins have this power, false means they don't  Default is false for clans, true for groups.</value>
    [DataMember(Name="UpdateBannerPermissionOverride", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpdateBannerPermissionOverride")]
    public bool? UpdateBannerPermissionOverride { get; set; }

    /// <summary>
    /// Level to join a member at when accepting an invite, application, or joining an open clan  Default is Beginner.
    /// </summary>
    /// <value>Level to join a member at when accepting an invite, application, or joining an open clan  Default is Beginner.</value>
    [DataMember(Name="JoinLevel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "JoinLevel")]
    public int? JoinLevel { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GroupsV2GroupOptionsEditAction {\n");
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
