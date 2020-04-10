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
  public class TokensPartnerOfferSkuHistoryResponse {
    /// <summary>
    /// Gets or Sets SkuIdentifier
    /// </summary>
    [DataMember(Name="SkuIdentifier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SkuIdentifier")]
    public string SkuIdentifier { get; set; }

    /// <summary>
    /// Gets or Sets LocalizedName
    /// </summary>
    [DataMember(Name="LocalizedName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LocalizedName")]
    public string LocalizedName { get; set; }

    /// <summary>
    /// Gets or Sets LocalizedDescription
    /// </summary>
    [DataMember(Name="LocalizedDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LocalizedDescription")]
    public string LocalizedDescription { get; set; }

    /// <summary>
    /// Gets or Sets ClaimDate
    /// </summary>
    [DataMember(Name="ClaimDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ClaimDate")]
    public DateTime? ClaimDate { get; set; }

    /// <summary>
    /// Gets or Sets AllOffersApplied
    /// </summary>
    [DataMember(Name="AllOffersApplied", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllOffersApplied")]
    public bool? AllOffersApplied { get; set; }

    /// <summary>
    /// Gets or Sets TransactionId
    /// </summary>
    [DataMember(Name="TransactionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TransactionId")]
    public string TransactionId { get; set; }

    /// <summary>
    /// Gets or Sets SkuOffers
    /// </summary>
    [DataMember(Name="SkuOffers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SkuOffers")]
    public List<TokensPartnerOfferHistoryResponse> SkuOffers { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TokensPartnerOfferSkuHistoryResponse {\n");
      sb.Append("  SkuIdentifier: ").Append(SkuIdentifier).Append("\n");
      sb.Append("  LocalizedName: ").Append(LocalizedName).Append("\n");
      sb.Append("  LocalizedDescription: ").Append(LocalizedDescription).Append("\n");
      sb.Append("  ClaimDate: ").Append(ClaimDate).Append("\n");
      sb.Append("  AllOffersApplied: ").Append(AllOffersApplied).Append("\n");
      sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
      sb.Append("  SkuOffers: ").Append(SkuOffers).Append("\n");
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
