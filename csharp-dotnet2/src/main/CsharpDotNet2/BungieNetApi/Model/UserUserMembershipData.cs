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
  public class UserUserMembershipData {
    /// <summary>
    /// this allows you to see destiny memberships that are visible and linked to this account (regardless of whether or not they have characters on the world server)
    /// </summary>
    /// <value>this allows you to see destiny memberships that are visible and linked to this account (regardless of whether or not they have characters on the world server)</value>
    [DataMember(Name="destinyMemberships", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destinyMemberships")]
    public List<GroupsV2GroupUserInfoCard> DestinyMemberships { get; set; }

    /// <summary>
    /// If this property is populated, it will have the membership ID of the account considered to be \"primary\" in this user's cross save relationship.   If null, this user has no cross save relationship, nor primary account.
    /// </summary>
    /// <value>If this property is populated, it will have the membership ID of the account considered to be \"primary\" in this user's cross save relationship.   If null, this user has no cross save relationship, nor primary account.</value>
    [DataMember(Name="primaryMembershipId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "primaryMembershipId")]
    public long? PrimaryMembershipId { get; set; }

    /// <summary>
    /// Gets or Sets BungieNetUser
    /// </summary>
    [DataMember(Name="bungieNetUser", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bungieNetUser")]
    public UserGeneralUser BungieNetUser { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserUserMembershipData {\n");
      sb.Append("  DestinyMemberships: ").Append(DestinyMemberships).Append("\n");
      sb.Append("  PrimaryMembershipId: ").Append(PrimaryMembershipId).Append("\n");
      sb.Append("  BungieNetUser: ").Append(BungieNetUser).Append("\n");
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
