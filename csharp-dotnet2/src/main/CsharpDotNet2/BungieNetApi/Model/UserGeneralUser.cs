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
  public class UserGeneralUser {
    /// <summary>
    /// Gets or Sets MembershipId
    /// </summary>
    [DataMember(Name="membershipId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "membershipId")]
    public long? MembershipId { get; set; }

    /// <summary>
    /// Gets or Sets UniqueName
    /// </summary>
    [DataMember(Name="uniqueName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uniqueName")]
    public string UniqueName { get; set; }

    /// <summary>
    /// Gets or Sets NormalizedName
    /// </summary>
    [DataMember(Name="normalizedName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "normalizedName")]
    public string NormalizedName { get; set; }

    /// <summary>
    /// Gets or Sets DisplayName
    /// </summary>
    [DataMember(Name="displayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayName")]
    public string DisplayName { get; set; }

    /// <summary>
    /// Gets or Sets ProfilePicture
    /// </summary>
    [DataMember(Name="profilePicture", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "profilePicture")]
    public int? ProfilePicture { get; set; }

    /// <summary>
    /// Gets or Sets ProfileTheme
    /// </summary>
    [DataMember(Name="profileTheme", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "profileTheme")]
    public int? ProfileTheme { get; set; }

    /// <summary>
    /// Gets or Sets UserTitle
    /// </summary>
    [DataMember(Name="userTitle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userTitle")]
    public int? UserTitle { get; set; }

    /// <summary>
    /// Gets or Sets SuccessMessageFlags
    /// </summary>
    [DataMember(Name="successMessageFlags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "successMessageFlags")]
    public long? SuccessMessageFlags { get; set; }

    /// <summary>
    /// Gets or Sets IsDeleted
    /// </summary>
    [DataMember(Name="isDeleted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isDeleted")]
    public bool? IsDeleted { get; set; }

    /// <summary>
    /// Gets or Sets About
    /// </summary>
    [DataMember(Name="about", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "about")]
    public string About { get; set; }

    /// <summary>
    /// Gets or Sets FirstAccess
    /// </summary>
    [DataMember(Name="firstAccess", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "firstAccess")]
    public DateTime? FirstAccess { get; set; }

    /// <summary>
    /// Gets or Sets LastUpdate
    /// </summary>
    [DataMember(Name="lastUpdate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastUpdate")]
    public DateTime? LastUpdate { get; set; }

    /// <summary>
    /// Gets or Sets LegacyPortalUID
    /// </summary>
    [DataMember(Name="legacyPortalUID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "legacyPortalUID")]
    public long? LegacyPortalUID { get; set; }

    /// <summary>
    /// Gets or Sets Context
    /// </summary>
    [DataMember(Name="context", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "context")]
    public UserUserToUserContext Context { get; set; }

    /// <summary>
    /// Gets or Sets PsnDisplayName
    /// </summary>
    [DataMember(Name="psnDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "psnDisplayName")]
    public string PsnDisplayName { get; set; }

    /// <summary>
    /// Gets or Sets XboxDisplayName
    /// </summary>
    [DataMember(Name="xboxDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "xboxDisplayName")]
    public string XboxDisplayName { get; set; }

    /// <summary>
    /// Gets or Sets FbDisplayName
    /// </summary>
    [DataMember(Name="fbDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fbDisplayName")]
    public string FbDisplayName { get; set; }

    /// <summary>
    /// Gets or Sets ShowActivity
    /// </summary>
    [DataMember(Name="showActivity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "showActivity")]
    public bool? ShowActivity { get; set; }

    /// <summary>
    /// Gets or Sets Locale
    /// </summary>
    [DataMember(Name="locale", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locale")]
    public string Locale { get; set; }

    /// <summary>
    /// Gets or Sets LocaleInheritDefault
    /// </summary>
    [DataMember(Name="localeInheritDefault", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "localeInheritDefault")]
    public bool? LocaleInheritDefault { get; set; }

    /// <summary>
    /// Gets or Sets LastBanReportId
    /// </summary>
    [DataMember(Name="lastBanReportId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastBanReportId")]
    public long? LastBanReportId { get; set; }

    /// <summary>
    /// Gets or Sets ShowGroupMessaging
    /// </summary>
    [DataMember(Name="showGroupMessaging", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "showGroupMessaging")]
    public bool? ShowGroupMessaging { get; set; }

    /// <summary>
    /// Gets or Sets ProfilePicturePath
    /// </summary>
    [DataMember(Name="profilePicturePath", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "profilePicturePath")]
    public string ProfilePicturePath { get; set; }

    /// <summary>
    /// Gets or Sets ProfilePictureWidePath
    /// </summary>
    [DataMember(Name="profilePictureWidePath", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "profilePictureWidePath")]
    public string ProfilePictureWidePath { get; set; }

    /// <summary>
    /// Gets or Sets ProfileThemeName
    /// </summary>
    [DataMember(Name="profileThemeName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "profileThemeName")]
    public string ProfileThemeName { get; set; }

    /// <summary>
    /// Gets or Sets UserTitleDisplay
    /// </summary>
    [DataMember(Name="userTitleDisplay", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userTitleDisplay")]
    public string UserTitleDisplay { get; set; }

    /// <summary>
    /// Gets or Sets StatusText
    /// </summary>
    [DataMember(Name="statusText", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statusText")]
    public string StatusText { get; set; }

    /// <summary>
    /// Gets or Sets StatusDate
    /// </summary>
    [DataMember(Name="statusDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statusDate")]
    public DateTime? StatusDate { get; set; }

    /// <summary>
    /// Gets or Sets ProfileBanExpire
    /// </summary>
    [DataMember(Name="profileBanExpire", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "profileBanExpire")]
    public DateTime? ProfileBanExpire { get; set; }

    /// <summary>
    /// Gets or Sets BlizzardDisplayName
    /// </summary>
    [DataMember(Name="blizzardDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "blizzardDisplayName")]
    public string BlizzardDisplayName { get; set; }

    /// <summary>
    /// Gets or Sets SteamDisplayName
    /// </summary>
    [DataMember(Name="steamDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "steamDisplayName")]
    public string SteamDisplayName { get; set; }

    /// <summary>
    /// Gets or Sets StadiaDisplayName
    /// </summary>
    [DataMember(Name="stadiaDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stadiaDisplayName")]
    public string StadiaDisplayName { get; set; }

    /// <summary>
    /// Gets or Sets TwitchDisplayName
    /// </summary>
    [DataMember(Name="twitchDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "twitchDisplayName")]
    public string TwitchDisplayName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserGeneralUser {\n");
      sb.Append("  MembershipId: ").Append(MembershipId).Append("\n");
      sb.Append("  UniqueName: ").Append(UniqueName).Append("\n");
      sb.Append("  NormalizedName: ").Append(NormalizedName).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  ProfilePicture: ").Append(ProfilePicture).Append("\n");
      sb.Append("  ProfileTheme: ").Append(ProfileTheme).Append("\n");
      sb.Append("  UserTitle: ").Append(UserTitle).Append("\n");
      sb.Append("  SuccessMessageFlags: ").Append(SuccessMessageFlags).Append("\n");
      sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
      sb.Append("  About: ").Append(About).Append("\n");
      sb.Append("  FirstAccess: ").Append(FirstAccess).Append("\n");
      sb.Append("  LastUpdate: ").Append(LastUpdate).Append("\n");
      sb.Append("  LegacyPortalUID: ").Append(LegacyPortalUID).Append("\n");
      sb.Append("  Context: ").Append(Context).Append("\n");
      sb.Append("  PsnDisplayName: ").Append(PsnDisplayName).Append("\n");
      sb.Append("  XboxDisplayName: ").Append(XboxDisplayName).Append("\n");
      sb.Append("  FbDisplayName: ").Append(FbDisplayName).Append("\n");
      sb.Append("  ShowActivity: ").Append(ShowActivity).Append("\n");
      sb.Append("  Locale: ").Append(Locale).Append("\n");
      sb.Append("  LocaleInheritDefault: ").Append(LocaleInheritDefault).Append("\n");
      sb.Append("  LastBanReportId: ").Append(LastBanReportId).Append("\n");
      sb.Append("  ShowGroupMessaging: ").Append(ShowGroupMessaging).Append("\n");
      sb.Append("  ProfilePicturePath: ").Append(ProfilePicturePath).Append("\n");
      sb.Append("  ProfilePictureWidePath: ").Append(ProfilePictureWidePath).Append("\n");
      sb.Append("  ProfileThemeName: ").Append(ProfileThemeName).Append("\n");
      sb.Append("  UserTitleDisplay: ").Append(UserTitleDisplay).Append("\n");
      sb.Append("  StatusText: ").Append(StatusText).Append("\n");
      sb.Append("  StatusDate: ").Append(StatusDate).Append("\n");
      sb.Append("  ProfileBanExpire: ").Append(ProfileBanExpire).Append("\n");
      sb.Append("  BlizzardDisplayName: ").Append(BlizzardDisplayName).Append("\n");
      sb.Append("  SteamDisplayName: ").Append(SteamDisplayName).Append("\n");
      sb.Append("  StadiaDisplayName: ").Append(StadiaDisplayName).Append("\n");
      sb.Append("  TwitchDisplayName: ").Append(TwitchDisplayName).Append("\n");
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
