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
  public class TokensPartnerOfferHistoryResponse {
    /// <summary>
    /// Gets or Sets PartnerOfferKey
    /// </summary>
    [DataMember(Name="PartnerOfferKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PartnerOfferKey")]
    public string PartnerOfferKey { get; set; }

    /// <summary>
    /// Gets or Sets MembershipId
    /// </summary>
    [DataMember(Name="MembershipId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MembershipId")]
    public long? MembershipId { get; set; }

    /// <summary>
    /// Gets or Sets MembershipType
    /// </summary>
    [DataMember(Name="MembershipType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MembershipType")]
    public int? MembershipType { get; set; }

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
    /// Gets or Sets IsConsumable
    /// </summary>
    [DataMember(Name="IsConsumable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsConsumable")]
    public bool? IsConsumable { get; set; }

    /// <summary>
    /// Gets or Sets QuantityApplied
    /// </summary>
    [DataMember(Name="QuantityApplied", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QuantityApplied")]
    public int? QuantityApplied { get; set; }

    /// <summary>
    /// Gets or Sets ApplyDate
    /// </summary>
    [DataMember(Name="ApplyDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ApplyDate")]
    public DateTime? ApplyDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TokensPartnerOfferHistoryResponse {\n");
      sb.Append("  PartnerOfferKey: ").Append(PartnerOfferKey).Append("\n");
      sb.Append("  MembershipId: ").Append(MembershipId).Append("\n");
      sb.Append("  MembershipType: ").Append(MembershipType).Append("\n");
      sb.Append("  LocalizedName: ").Append(LocalizedName).Append("\n");
      sb.Append("  LocalizedDescription: ").Append(LocalizedDescription).Append("\n");
      sb.Append("  IsConsumable: ").Append(IsConsumable).Append("\n");
      sb.Append("  QuantityApplied: ").Append(QuantityApplied).Append("\n");
      sb.Append("  ApplyDate: ").Append(ApplyDate).Append("\n");
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
