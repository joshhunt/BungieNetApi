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
  public class CommonModelsCoreSettingsConfiguration {
    /// <summary>
    /// Gets or Sets Environment
    /// </summary>
    [DataMember(Name="environment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "environment")]
    public string Environment { get; set; }

    /// <summary>
    /// Gets or Sets Systems
    /// </summary>
    [DataMember(Name="systems", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "systems")]
    public Dictionary<string, CommonModelsCoreSystem> Systems { get; set; }

    /// <summary>
    /// Gets or Sets IgnoreReasons
    /// </summary>
    [DataMember(Name="ignoreReasons", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ignoreReasons")]
    public List<CommonModelsCoreSetting> IgnoreReasons { get; set; }

    /// <summary>
    /// Gets or Sets ForumCategories
    /// </summary>
    [DataMember(Name="forumCategories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "forumCategories")]
    public List<CommonModelsCoreSetting> ForumCategories { get; set; }

    /// <summary>
    /// Gets or Sets GroupAvatars
    /// </summary>
    [DataMember(Name="groupAvatars", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "groupAvatars")]
    public List<CommonModelsCoreSetting> GroupAvatars { get; set; }

    /// <summary>
    /// Gets or Sets DestinyMembershipTypes
    /// </summary>
    [DataMember(Name="destinyMembershipTypes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destinyMembershipTypes")]
    public List<CommonModelsCoreSetting> DestinyMembershipTypes { get; set; }

    /// <summary>
    /// Gets or Sets RecruitmentPlatformTags
    /// </summary>
    [DataMember(Name="recruitmentPlatformTags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recruitmentPlatformTags")]
    public List<CommonModelsCoreSetting> RecruitmentPlatformTags { get; set; }

    /// <summary>
    /// Gets or Sets RecruitmentMiscTags
    /// </summary>
    [DataMember(Name="recruitmentMiscTags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recruitmentMiscTags")]
    public List<CommonModelsCoreSetting> RecruitmentMiscTags { get; set; }

    /// <summary>
    /// Gets or Sets RecruitmentActivities
    /// </summary>
    [DataMember(Name="recruitmentActivities", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recruitmentActivities")]
    public List<CommonModelsCoreSetting> RecruitmentActivities { get; set; }

    /// <summary>
    /// Gets or Sets UserContentLocales
    /// </summary>
    [DataMember(Name="userContentLocales", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userContentLocales")]
    public List<CommonModelsCoreSetting> UserContentLocales { get; set; }

    /// <summary>
    /// Gets or Sets SystemContentLocales
    /// </summary>
    [DataMember(Name="systemContentLocales", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "systemContentLocales")]
    public List<CommonModelsCoreSetting> SystemContentLocales { get; set; }

    /// <summary>
    /// Gets or Sets ClanBannerDecals
    /// </summary>
    [DataMember(Name="clanBannerDecals", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clanBannerDecals")]
    public List<CommonModelsCoreSetting> ClanBannerDecals { get; set; }

    /// <summary>
    /// Gets or Sets ClanBannerDecalColors
    /// </summary>
    [DataMember(Name="clanBannerDecalColors", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clanBannerDecalColors")]
    public List<CommonModelsCoreSetting> ClanBannerDecalColors { get; set; }

    /// <summary>
    /// Gets or Sets ClanBannerGonfalons
    /// </summary>
    [DataMember(Name="clanBannerGonfalons", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clanBannerGonfalons")]
    public List<CommonModelsCoreSetting> ClanBannerGonfalons { get; set; }

    /// <summary>
    /// Gets or Sets ClanBannerGonfalonColors
    /// </summary>
    [DataMember(Name="clanBannerGonfalonColors", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clanBannerGonfalonColors")]
    public List<CommonModelsCoreSetting> ClanBannerGonfalonColors { get; set; }

    /// <summary>
    /// Gets or Sets ClanBannerGonfalonDetails
    /// </summary>
    [DataMember(Name="clanBannerGonfalonDetails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clanBannerGonfalonDetails")]
    public List<CommonModelsCoreSetting> ClanBannerGonfalonDetails { get; set; }

    /// <summary>
    /// Gets or Sets ClanBannerGonfalonDetailColors
    /// </summary>
    [DataMember(Name="clanBannerGonfalonDetailColors", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clanBannerGonfalonDetailColors")]
    public List<CommonModelsCoreSetting> ClanBannerGonfalonDetailColors { get; set; }

    /// <summary>
    /// Gets or Sets ClanBannerStandards
    /// </summary>
    [DataMember(Name="clanBannerStandards", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clanBannerStandards")]
    public List<CommonModelsCoreSetting> ClanBannerStandards { get; set; }

    /// <summary>
    /// Gets or Sets Destiny2CoreSettings
    /// </summary>
    [DataMember(Name="destiny2CoreSettings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destiny2CoreSettings")]
    public CommonModelsDestiny2CoreSettings Destiny2CoreSettings { get; set; }

    /// <summary>
    /// Gets or Sets EmailSettings
    /// </summary>
    [DataMember(Name="emailSettings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emailSettings")]
    public UserEmailSettings EmailSettings { get; set; }

    /// <summary>
    /// Gets or Sets FireteamActivities
    /// </summary>
    [DataMember(Name="fireteamActivities", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fireteamActivities")]
    public List<CommonModelsCoreSetting> FireteamActivities { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CommonModelsCoreSettingsConfiguration {\n");
      sb.Append("  Environment: ").Append(Environment).Append("\n");
      sb.Append("  Systems: ").Append(Systems).Append("\n");
      sb.Append("  IgnoreReasons: ").Append(IgnoreReasons).Append("\n");
      sb.Append("  ForumCategories: ").Append(ForumCategories).Append("\n");
      sb.Append("  GroupAvatars: ").Append(GroupAvatars).Append("\n");
      sb.Append("  DestinyMembershipTypes: ").Append(DestinyMembershipTypes).Append("\n");
      sb.Append("  RecruitmentPlatformTags: ").Append(RecruitmentPlatformTags).Append("\n");
      sb.Append("  RecruitmentMiscTags: ").Append(RecruitmentMiscTags).Append("\n");
      sb.Append("  RecruitmentActivities: ").Append(RecruitmentActivities).Append("\n");
      sb.Append("  UserContentLocales: ").Append(UserContentLocales).Append("\n");
      sb.Append("  SystemContentLocales: ").Append(SystemContentLocales).Append("\n");
      sb.Append("  ClanBannerDecals: ").Append(ClanBannerDecals).Append("\n");
      sb.Append("  ClanBannerDecalColors: ").Append(ClanBannerDecalColors).Append("\n");
      sb.Append("  ClanBannerGonfalons: ").Append(ClanBannerGonfalons).Append("\n");
      sb.Append("  ClanBannerGonfalonColors: ").Append(ClanBannerGonfalonColors).Append("\n");
      sb.Append("  ClanBannerGonfalonDetails: ").Append(ClanBannerGonfalonDetails).Append("\n");
      sb.Append("  ClanBannerGonfalonDetailColors: ").Append(ClanBannerGonfalonDetailColors).Append("\n");
      sb.Append("  ClanBannerStandards: ").Append(ClanBannerStandards).Append("\n");
      sb.Append("  Destiny2CoreSettings: ").Append(Destiny2CoreSettings).Append("\n");
      sb.Append("  EmailSettings: ").Append(EmailSettings).Append("\n");
      sb.Append("  FireteamActivities: ").Append(FireteamActivities).Append("\n");
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
