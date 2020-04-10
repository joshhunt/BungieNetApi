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
  public class GroupsV2GroupEditAction {
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets About
    /// </summary>
    [DataMember(Name="about", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "about")]
    public string About { get; set; }

    /// <summary>
    /// Gets or Sets Motto
    /// </summary>
    [DataMember(Name="motto", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "motto")]
    public string Motto { get; set; }

    /// <summary>
    /// Gets or Sets Theme
    /// </summary>
    [DataMember(Name="theme", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "theme")]
    public string Theme { get; set; }

    /// <summary>
    /// Gets or Sets AvatarImageIndex
    /// </summary>
    [DataMember(Name="avatarImageIndex", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "avatarImageIndex")]
    public int? AvatarImageIndex { get; set; }

    /// <summary>
    /// Gets or Sets Tags
    /// </summary>
    [DataMember(Name="tags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tags")]
    public string Tags { get; set; }

    /// <summary>
    /// Gets or Sets IsPublic
    /// </summary>
    [DataMember(Name="isPublic", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isPublic")]
    public bool? IsPublic { get; set; }

    /// <summary>
    /// Gets or Sets MembershipOption
    /// </summary>
    [DataMember(Name="membershipOption", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "membershipOption")]
    public int? MembershipOption { get; set; }

    /// <summary>
    /// Gets or Sets IsPublicTopicAdminOnly
    /// </summary>
    [DataMember(Name="isPublicTopicAdminOnly", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isPublicTopicAdminOnly")]
    public bool? IsPublicTopicAdminOnly { get; set; }

    /// <summary>
    /// Gets or Sets AllowChat
    /// </summary>
    [DataMember(Name="allowChat", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allowChat")]
    public bool? AllowChat { get; set; }

    /// <summary>
    /// Gets or Sets ChatSecurity
    /// </summary>
    [DataMember(Name="chatSecurity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "chatSecurity")]
    public int? ChatSecurity { get; set; }

    /// <summary>
    /// Gets or Sets Callsign
    /// </summary>
    [DataMember(Name="callsign", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "callsign")]
    public string Callsign { get; set; }

    /// <summary>
    /// Gets or Sets Locale
    /// </summary>
    [DataMember(Name="locale", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locale")]
    public string Locale { get; set; }

    /// <summary>
    /// Gets or Sets Homepage
    /// </summary>
    [DataMember(Name="homepage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "homepage")]
    public int? Homepage { get; set; }

    /// <summary>
    /// Gets or Sets EnableInvitationMessagingForAdmins
    /// </summary>
    [DataMember(Name="enableInvitationMessagingForAdmins", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enableInvitationMessagingForAdmins")]
    public bool? EnableInvitationMessagingForAdmins { get; set; }

    /// <summary>
    /// Gets or Sets DefaultPublicity
    /// </summary>
    [DataMember(Name="defaultPublicity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultPublicity")]
    public int? DefaultPublicity { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GroupsV2GroupEditAction {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  About: ").Append(About).Append("\n");
      sb.Append("  Motto: ").Append(Motto).Append("\n");
      sb.Append("  Theme: ").Append(Theme).Append("\n");
      sb.Append("  AvatarImageIndex: ").Append(AvatarImageIndex).Append("\n");
      sb.Append("  Tags: ").Append(Tags).Append("\n");
      sb.Append("  IsPublic: ").Append(IsPublic).Append("\n");
      sb.Append("  MembershipOption: ").Append(MembershipOption).Append("\n");
      sb.Append("  IsPublicTopicAdminOnly: ").Append(IsPublicTopicAdminOnly).Append("\n");
      sb.Append("  AllowChat: ").Append(AllowChat).Append("\n");
      sb.Append("  ChatSecurity: ").Append(ChatSecurity).Append("\n");
      sb.Append("  Callsign: ").Append(Callsign).Append("\n");
      sb.Append("  Locale: ").Append(Locale).Append("\n");
      sb.Append("  Homepage: ").Append(Homepage).Append("\n");
      sb.Append("  EnableInvitationMessagingForAdmins: ").Append(EnableInvitationMessagingForAdmins).Append("\n");
      sb.Append("  DefaultPublicity: ").Append(DefaultPublicity).Append("\n");
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
