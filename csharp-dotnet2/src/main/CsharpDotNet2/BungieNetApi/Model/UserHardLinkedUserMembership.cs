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
  public class UserHardLinkedUserMembership {
    /// <summary>
    /// Gets or Sets MembershipType
    /// </summary>
    [DataMember(Name="membershipType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "membershipType")]
    public int? MembershipType { get; set; }

    /// <summary>
    /// Gets or Sets MembershipId
    /// </summary>
    [DataMember(Name="membershipId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "membershipId")]
    public long? MembershipId { get; set; }

    /// <summary>
    /// Gets or Sets CrossSaveOverriddenType
    /// </summary>
    [DataMember(Name="CrossSaveOverriddenType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CrossSaveOverriddenType")]
    public int? CrossSaveOverriddenType { get; set; }

    /// <summary>
    /// Gets or Sets CrossSaveOverriddenMembershipId
    /// </summary>
    [DataMember(Name="CrossSaveOverriddenMembershipId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CrossSaveOverriddenMembershipId")]
    public long? CrossSaveOverriddenMembershipId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserHardLinkedUserMembership {\n");
      sb.Append("  MembershipType: ").Append(MembershipType).Append("\n");
      sb.Append("  MembershipId: ").Append(MembershipId).Append("\n");
      sb.Append("  CrossSaveOverriddenType: ").Append(CrossSaveOverriddenType).Append("\n");
      sb.Append("  CrossSaveOverriddenMembershipId: ").Append(CrossSaveOverriddenMembershipId).Append("\n");
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
