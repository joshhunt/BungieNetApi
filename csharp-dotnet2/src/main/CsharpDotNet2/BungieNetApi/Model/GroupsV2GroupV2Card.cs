using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// A small infocard of group information, usually used for when a list of groups are returned
  /// </summary>
  [DataContract]
  public class GroupsV2GroupV2Card {
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
    /// Gets or Sets CreationDate
    /// </summary>
    [DataMember(Name="creationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creationDate")]
    public DateTime? CreationDate { get; set; }

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
    /// Gets or Sets MemberCount
    /// </summary>
    [DataMember(Name="memberCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "memberCount")]
    public int? MemberCount { get; set; }

    /// <summary>
    /// Gets or Sets Locale
    /// </summary>
    [DataMember(Name="locale", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locale")]
    public string Locale { get; set; }

    /// <summary>
    /// Gets or Sets MembershipOption
    /// </summary>
    [DataMember(Name="membershipOption", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "membershipOption")]
    public int? MembershipOption { get; set; }

    /// <summary>
    /// Gets or Sets Capabilities
    /// </summary>
    [DataMember(Name="capabilities", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "capabilities")]
    public int? Capabilities { get; set; }

    /// <summary>
    /// Gets or Sets ClanInfo
    /// </summary>
    [DataMember(Name="clanInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clanInfo")]
    public GroupsV2GroupV2ClanInfo ClanInfo { get; set; }

    /// <summary>
    /// Gets or Sets AvatarPath
    /// </summary>
    [DataMember(Name="avatarPath", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "avatarPath")]
    public string AvatarPath { get; set; }

    /// <summary>
    /// Gets or Sets Theme
    /// </summary>
    [DataMember(Name="theme", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "theme")]
    public string Theme { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GroupsV2GroupV2Card {\n");
      sb.Append("  GroupId: ").Append(GroupId).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  GroupType: ").Append(GroupType).Append("\n");
      sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
      sb.Append("  About: ").Append(About).Append("\n");
      sb.Append("  Motto: ").Append(Motto).Append("\n");
      sb.Append("  MemberCount: ").Append(MemberCount).Append("\n");
      sb.Append("  Locale: ").Append(Locale).Append("\n");
      sb.Append("  MembershipOption: ").Append(MembershipOption).Append("\n");
      sb.Append("  Capabilities: ").Append(Capabilities).Append("\n");
      sb.Append("  ClanInfo: ").Append(ClanInfo).Append("\n");
      sb.Append("  AvatarPath: ").Append(AvatarPath).Append("\n");
      sb.Append("  Theme: ").Append(Theme).Append("\n");
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
