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
  public class TokensPartnerOfferClaimRequest {
    /// <summary>
    /// Gets or Sets PartnerOfferId
    /// </summary>
    [DataMember(Name="PartnerOfferId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PartnerOfferId")]
    public string PartnerOfferId { get; set; }

    /// <summary>
    /// Gets or Sets BungieNetMembershipId
    /// </summary>
    [DataMember(Name="BungieNetMembershipId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BungieNetMembershipId")]
    public long? BungieNetMembershipId { get; set; }

    /// <summary>
    /// Gets or Sets TransactionId
    /// </summary>
    [DataMember(Name="TransactionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TransactionId")]
    public string TransactionId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TokensPartnerOfferClaimRequest {\n");
      sb.Append("  PartnerOfferId: ").Append(PartnerOfferId).Append("\n");
      sb.Append("  BungieNetMembershipId: ").Append(BungieNetMembershipId).Append("\n");
      sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
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
