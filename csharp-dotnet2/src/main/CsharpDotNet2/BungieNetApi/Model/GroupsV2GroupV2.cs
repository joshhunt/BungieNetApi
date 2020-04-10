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
  public class GroupsV2GroupV2 {
    /// <summary>
    /// Gets or Sets GroupId
    /// </summary>
    [DataMember(Name="groupId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "groupId")]
    public long? GroupId { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets GroupType
    /// </summary>
    [DataMember(Name="groupType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "groupType")]
    public int? GroupType { get; set; }

    /// <summary>
    /// Gets or Sets MembershipIdCreated
    /// </summary>
    [DataMember(Name="membershipIdCreated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "membershipIdCreated")]
    public long? MembershipIdCreated { get; set; }

    /// <summary>
    /// Gets or Sets CreationDate
    /// </summary>
    [DataMember(Name="creationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creationDate")]
    public DateTime? CreationDate { get; set; }

    /// <summary>
    /// Gets or Sets ModificationDate
    /// </summary>
    [DataMember(Name="modificationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "modificationDate")]
    public DateTime? ModificationDate { get; set; }

    /// <summary>
    /// Gets or Sets About
    /// </summary>
    [DataMember(Name="about", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "about")]
    public string About { get; set; }

    /// <summary>
    /// Gets or Sets Tags
    /// </summary>
    [DataMember(Name="tags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tags")]
    public List<string> Tags { get; set; }

    /// <summary>
    /// Gets or Sets MemberCount
    /// </summary>
    [DataMember(Name="memberCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "memberCount")]
    public int? MemberCount { get; set; }

    /// <summary>
    /// Gets or Sets IsPublic
    /// </summary>
    [DataMember(Name="isPublic", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isPublic")]
    public bool? IsPublic { get; set; }

    /// <summary>
    /// Gets or Sets IsPublicTopicAdminOnly
    /// </summary>
    [DataMember(Name="isPublicTopicAdminOnly", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isPublicTopicAdminOnly")]
    public bool? IsPublicTopicAdminOnly { get; set; }

    /// <summary>
    /// Gets or Sets Motto
    /// </summary>
    [DataMember(Name="motto", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "motto")]
    public string Motto { get; set; }

    /// <summary>
    /// Gets or Sets AllowChat
    /// </summary>
    [DataMember(Name="allowChat", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allowChat")]
    public bool? AllowChat { get; set; }

    /// <summary>
    /// Gets or Sets IsDefaultPostPublic
    /// </summary>
    [DataMember(Name="isDefaultPostPublic", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isDefaultPostPublic")]
    public bool? IsDefaultPostPublic { get; set; }

    /// <summary>
    /// Gets or Sets ChatSecurity
    /// </summary>
    [DataMember(Name="chatSecurity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "chatSecurity")]
    public int? ChatSecurity { get; set; }

    /// <summary>
    /// Gets or Sets Locale
    /// </summary>
    [DataMember(Name="locale", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locale")]
    public string Locale { get; set; }

    /// <summary>
    /// Gets or Sets AvatarImageIndex
    /// </summary>
    [DataMember(Name="avatarImageIndex", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "avatarImageIndex")]
    public int? AvatarImageIndex { get; set; }

    /// <summary>
    /// Gets or Sets Homepage
    /// </summary>
    [DataMember(Name="homepage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "homepage")]
    public int? Homepage { get; set; }

    /// <summary>
    /// Gets or Sets MembershipOption
    /// </summary>
    [DataMember(Name="membershipOption", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "membershipOption")]
    public int? MembershipOption { get; set; }

    /// <summary>
    /// Gets or Sets DefaultPublicity
    /// </summary>
    [DataMember(Name="defaultPublicity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultPublicity")]
    public int? DefaultPublicity { get; set; }

    /// <summary>
    /// Gets or Sets Theme
    /// </summary>
    [DataMember(Name="theme", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "theme")]
    public string Theme { get; set; }

    /// <summary>
    /// Gets or Sets BannerPath
    /// </summary>
    [DataMember(Name="bannerPath", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bannerPath")]
    public string BannerPath { get; set; }

    /// <summary>
    /// Gets or Sets AvatarPath
    /// </summary>
    [DataMember(Name="avatarPath", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "avatarPath")]
    public string AvatarPath { get; set; }

    /// <summary>
    /// Gets or Sets ConversationId
    /// </summary>
    [DataMember(Name="conversationId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "conversationId")]
    public long? ConversationId { get; set; }

    /// <summary>
    /// Gets or Sets EnableInvitationMessagingForAdmins
    /// </summary>
    [DataMember(Name="enableInvitationMessagingForAdmins", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enableInvitationMessagingForAdmins")]
    public bool? EnableInvitationMessagingForAdmins { get; set; }

    /// <summary>
    /// Gets or Sets BanExpireDate
    /// </summary>
    [DataMember(Name="banExpireDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "banExpireDate")]
    public DateTime? BanExpireDate { get; set; }

    /// <summary>
    /// Gets or Sets Features
    /// </summary>
    [DataMember(Name="features", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "features")]
    public GroupsV2GroupFeatures Features { get; set; }

    /// <summary>
    /// Gets or Sets ClanInfo
    /// </summary>
    [DataMember(Name="clanInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clanInfo")]
    public GroupsV2GroupV2ClanInfoAndInvestment ClanInfo { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GroupsV2GroupV2 {\n");
      sb.Append("  GroupId: ").Append(GroupId).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  GroupType: ").Append(GroupType).Append("\n");
      sb.Append("  MembershipIdCreated: ").Append(MembershipIdCreated).Append("\n");
      sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
      sb.Append("  ModificationDate: ").Append(ModificationDate).Append("\n");
      sb.Append("  About: ").Append(About).Append("\n");
      sb.Append("  Tags: ").Append(Tags).Append("\n");
      sb.Append("  MemberCount: ").Append(MemberCount).Append("\n");
      sb.Append("  IsPublic: ").Append(IsPublic).Append("\n");
      sb.Append("  IsPublicTopicAdminOnly: ").Append(IsPublicTopicAdminOnly).Append("\n");
      sb.Append("  Motto: ").Append(Motto).Append("\n");
      sb.Append("  AllowChat: ").Append(AllowChat).Append("\n");
      sb.Append("  IsDefaultPostPublic: ").Append(IsDefaultPostPublic).Append("\n");
      sb.Append("  ChatSecurity: ").Append(ChatSecurity).Append("\n");
      sb.Append("  Locale: ").Append(Locale).Append("\n");
      sb.Append("  AvatarImageIndex: ").Append(AvatarImageIndex).Append("\n");
      sb.Append("  Homepage: ").Append(Homepage).Append("\n");
      sb.Append("  MembershipOption: ").Append(MembershipOption).Append("\n");
      sb.Append("  DefaultPublicity: ").Append(DefaultPublicity).Append("\n");
      sb.Append("  Theme: ").Append(Theme).Append("\n");
      sb.Append("  BannerPath: ").Append(BannerPath).Append("\n");
      sb.Append("  AvatarPath: ").Append(AvatarPath).Append("\n");
      sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
      sb.Append("  EnableInvitationMessagingForAdmins: ").Append(EnableInvitationMessagingForAdmins).Append("\n");
      sb.Append("  BanExpireDate: ").Append(BanExpireDate).Append("\n");
      sb.Append("  Features: ").Append(Features).Append("\n");
      sb.Append("  ClanInfo: ").Append(ClanInfo).Append("\n");
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
