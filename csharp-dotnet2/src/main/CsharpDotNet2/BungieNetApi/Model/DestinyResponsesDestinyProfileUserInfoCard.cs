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
  public class DestinyResponsesDestinyProfileUserInfoCard {
    /// <summary>
    /// Gets or Sets DateLastPlayed
    /// </summary>
    [DataMember(Name="dateLastPlayed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dateLastPlayed")]
    public DateTime? DateLastPlayed { get; set; }

    /// <summary>
    /// If this profile is being overridden/obscured by Cross Save, this will be set to true. We will still return the profile for display purposes where users need to know the info: it is up to any given area of the app/site to determine if this profile should still be shown.
    /// </summary>
    /// <value>If this profile is being overridden/obscured by Cross Save, this will be set to true. We will still return the profile for display purposes where users need to know the info: it is up to any given area of the app/site to determine if this profile should still be shown.</value>
    [DataMember(Name="isOverridden", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isOverridden")]
    public bool? IsOverridden { get; set; }

    /// <summary>
    /// If true, this account is hooked up as the \"Primary\" cross save account for one or more platforms.
    /// </summary>
    /// <value>If true, this account is hooked up as the \"Primary\" cross save account for one or more platforms.</value>
    [DataMember(Name="isCrossSavePrimary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isCrossSavePrimary")]
    public bool? IsCrossSavePrimary { get; set; }

    /// <summary>
    /// This is the silver available on this Profile across any platforms on which they have purchased silver.   This is only available if you are requesting yourself.
    /// </summary>
    /// <value>This is the silver available on this Profile across any platforms on which they have purchased silver.   This is only available if you are requesting yourself.</value>
    [DataMember(Name="platformSilver", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "platformSilver")]
    public DestinyComponentsInventoryDestinyPlatformSilverComponent PlatformSilver { get; set; }

    /// <summary>
    /// If this profile is not in a cross save pairing, this will return the game versions that we believe this profile has access to.   For the time being, we will not return this information for any membership that is in a cross save pairing. The gist is that, once the pairing occurs, we do not currently have a consistent way to get that information for the profile's original Platform, and thus gameVersions would be too inconsistent (based on the last platform they happened to play on) for the info to be useful.   If we ever can get this data, this field will be deprecated and replaced with data on the DestinyLinkedProfileResponse itself, with game versions per linked Platform. But since we can't get that, we have this as a stop-gap measure for getting the data in the only situation that we currently need it.
    /// </summary>
    /// <value>If this profile is not in a cross save pairing, this will return the game versions that we believe this profile has access to.   For the time being, we will not return this information for any membership that is in a cross save pairing. The gist is that, once the pairing occurs, we do not currently have a consistent way to get that information for the profile's original Platform, and thus gameVersions would be too inconsistent (based on the last platform they happened to play on) for the info to be useful.   If we ever can get this data, this field will be deprecated and replaced with data on the DestinyLinkedProfileResponse itself, with game versions per linked Platform. But since we can't get that, we have this as a stop-gap measure for getting the data in the only situation that we currently need it.</value>
    [DataMember(Name="unpairedGameVersions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unpairedGameVersions")]
    public int? UnpairedGameVersions { get; set; }

    /// <summary>
    /// A platform specific additional display name - ex: psn Real Name, bnet Unique Name, etc.
    /// </summary>
    /// <value>A platform specific additional display name - ex: psn Real Name, bnet Unique Name, etc.</value>
    [DataMember(Name="supplementalDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supplementalDisplayName")]
    public string SupplementalDisplayName { get; set; }

    /// <summary>
    /// URL the Icon if available.
    /// </summary>
    /// <value>URL the Icon if available.</value>
    [DataMember(Name="iconPath", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "iconPath")]
    public string IconPath { get; set; }

    /// <summary>
    /// If there is a cross save override in effect, this value will tell you the type that is overridding this one.
    /// </summary>
    /// <value>If there is a cross save override in effect, this value will tell you the type that is overridding this one.</value>
    [DataMember(Name="crossSaveOverride", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "crossSaveOverride")]
    public int? CrossSaveOverride { get; set; }

    /// <summary>
    /// The list of Membership Types indicating the platforms on which this Membership can be used.   Not in Cross Save = its original membership type. Cross Save Primary = Any membership types it is overridding, and its original membership type Cross Save Overridden = Empty list
    /// </summary>
    /// <value>The list of Membership Types indicating the platforms on which this Membership can be used.   Not in Cross Save = its original membership type. Cross Save Primary = Any membership types it is overridding, and its original membership type Cross Save Overridden = Empty list</value>
    [DataMember(Name="applicableMembershipTypes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "applicableMembershipTypes")]
    public List<int?> ApplicableMembershipTypes { get; set; }

    /// <summary>
    /// If True, this is a public user membership.
    /// </summary>
    /// <value>If True, this is a public user membership.</value>
    [DataMember(Name="isPublic", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isPublic")]
    public bool? IsPublic { get; set; }

    /// <summary>
    /// Type of the membership. Not necessarily the native type.
    /// </summary>
    /// <value>Type of the membership. Not necessarily the native type.</value>
    [DataMember(Name="membershipType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "membershipType")]
    public int? MembershipType { get; set; }

    /// <summary>
    /// Membership ID as they user is known in the Accounts service
    /// </summary>
    /// <value>Membership ID as they user is known in the Accounts service</value>
    [DataMember(Name="membershipId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "membershipId")]
    public long? MembershipId { get; set; }

    /// <summary>
    /// Display Name the player has chosen for themselves. The display name is optional when the data type is used as input to a platform API.
    /// </summary>
    /// <value>Display Name the player has chosen for themselves. The display name is optional when the data type is used as input to a platform API.</value>
    [DataMember(Name="displayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayName")]
    public string DisplayName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyResponsesDestinyProfileUserInfoCard {\n");
      sb.Append("  DateLastPlayed: ").Append(DateLastPlayed).Append("\n");
      sb.Append("  IsOverridden: ").Append(IsOverridden).Append("\n");
      sb.Append("  IsCrossSavePrimary: ").Append(IsCrossSavePrimary).Append("\n");
      sb.Append("  PlatformSilver: ").Append(PlatformSilver).Append("\n");
      sb.Append("  UnpairedGameVersions: ").Append(UnpairedGameVersions).Append("\n");
      sb.Append("  SupplementalDisplayName: ").Append(SupplementalDisplayName).Append("\n");
      sb.Append("  IconPath: ").Append(IconPath).Append("\n");
      sb.Append("  CrossSaveOverride: ").Append(CrossSaveOverride).Append("\n");
      sb.Append("  ApplicableMembershipTypes: ").Append(ApplicableMembershipTypes).Append("\n");
      sb.Append("  IsPublic: ").Append(IsPublic).Append("\n");
      sb.Append("  MembershipType: ").Append(MembershipType).Append("\n");
      sb.Append("  MembershipId: ").Append(MembershipId).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
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
