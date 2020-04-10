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
  public class DestinyAdvancedAwaAuthorizationResult {
    /// <summary>
    /// Indication of how the user responded to the request. If the value is \"Approved\" the actionToken will contain the token that can be presented when performing the advanced write action.
    /// </summary>
    /// <value>Indication of how the user responded to the request. If the value is \"Approved\" the actionToken will contain the token that can be presented when performing the advanced write action.</value>
    [DataMember(Name="userSelection", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userSelection")]
    public int? UserSelection { get; set; }

    /// <summary>
    /// Gets or Sets ResponseReason
    /// </summary>
    [DataMember(Name="responseReason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "responseReason")]
    public int? ResponseReason { get; set; }

    /// <summary>
    /// Message to the app developer to help understand the response.
    /// </summary>
    /// <value>Message to the app developer to help understand the response.</value>
    [DataMember(Name="developerNote", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "developerNote")]
    public string DeveloperNote { get; set; }

    /// <summary>
    /// Credential used to prove the user authorized an advanced write action.
    /// </summary>
    /// <value>Credential used to prove the user authorized an advanced write action.</value>
    [DataMember(Name="actionToken", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "actionToken")]
    public string ActionToken { get; set; }

    /// <summary>
    /// This token may be used to perform the requested action this number of times, at a maximum. If this value is 0, then there is no limit.
    /// </summary>
    /// <value>This token may be used to perform the requested action this number of times, at a maximum. If this value is 0, then there is no limit.</value>
    [DataMember(Name="maximumNumberOfUses", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maximumNumberOfUses")]
    public int? MaximumNumberOfUses { get; set; }

    /// <summary>
    /// Time, UTC, when token expires.
    /// </summary>
    /// <value>Time, UTC, when token expires.</value>
    [DataMember(Name="validUntil", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "validUntil")]
    public DateTime? ValidUntil { get; set; }

    /// <summary>
    /// Advanced Write Action Type from the permission request.
    /// </summary>
    /// <value>Advanced Write Action Type from the permission request.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public int? Type { get; set; }

    /// <summary>
    /// MembershipType from the permission request.
    /// </summary>
    /// <value>MembershipType from the permission request.</value>
    [DataMember(Name="membershipType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "membershipType")]
    public int? MembershipType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyAdvancedAwaAuthorizationResult {\n");
      sb.Append("  UserSelection: ").Append(UserSelection).Append("\n");
      sb.Append("  ResponseReason: ").Append(ResponseReason).Append("\n");
      sb.Append("  DeveloperNote: ").Append(DeveloperNote).Append("\n");
      sb.Append("  ActionToken: ").Append(ActionToken).Append("\n");
      sb.Append("  MaximumNumberOfUses: ").Append(MaximumNumberOfUses).Append("\n");
      sb.Append("  ValidUntil: ").Append(ValidUntil).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  MembershipType: ").Append(MembershipType).Append("\n");
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
