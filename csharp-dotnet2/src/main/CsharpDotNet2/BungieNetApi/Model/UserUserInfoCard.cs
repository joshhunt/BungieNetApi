using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// This contract supplies basic information commonly used to display a minimal amount of information about a user. Take care to not add more properties here unless the property applies in all (or at least the majority) of the situations where UserInfoCard is used. Avoid adding game specific or platform specific details here. In cases where UserInfoCard is a subset of the data needed in a contract, use UserInfoCard as a property of other contracts.
  /// </summary>
  [DataContract]
  public class UserUserInfoCard {
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
      sb.Append("class UserUserInfoCard {\n");
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
