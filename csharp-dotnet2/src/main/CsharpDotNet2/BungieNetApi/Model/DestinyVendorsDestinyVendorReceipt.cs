using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// If a character purchased an item that is refundable, a Vendor Receipt will be created on the user&#39;s Destiny Profile. These expire after a configurable period of time, but until then can be used to get refunds on items. BNet does not provide the ability to refund a purchase *yet*, but you know.
  /// </summary>
  [DataContract]
  public class DestinyVendorsDestinyVendorReceipt {
    /// <summary>
    /// The amount paid for the item, in terms of items that were consumed in the purchase and their quantity.
    /// </summary>
    /// <value>The amount paid for the item, in terms of items that were consumed in the purchase and their quantity.</value>
    [DataMember(Name="currencyPaid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currencyPaid")]
    public List<DestinyDestinyItemQuantity> CurrencyPaid { get; set; }

    /// <summary>
    /// The item that was received, and its quantity.
    /// </summary>
    /// <value>The item that was received, and its quantity.</value>
    [DataMember(Name="itemReceived", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemReceived")]
    public DestinyDestinyItemQuantity ItemReceived { get; set; }

    /// <summary>
    /// The unlock flag used to determine whether you still have the purchased item.
    /// </summary>
    /// <value>The unlock flag used to determine whether you still have the purchased item.</value>
    [DataMember(Name="licenseUnlockHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "licenseUnlockHash")]
    public int? LicenseUnlockHash { get; set; }

    /// <summary>
    /// The ID of the character who made the purchase.
    /// </summary>
    /// <value>The ID of the character who made the purchase.</value>
    [DataMember(Name="purchasedByCharacterId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "purchasedByCharacterId")]
    public long? PurchasedByCharacterId { get; set; }

    /// <summary>
    /// Whether you can get a refund, and what happens in order for the refund to be received. See the DestinyVendorItemRefundPolicy enum for details.
    /// </summary>
    /// <value>Whether you can get a refund, and what happens in order for the refund to be received. See the DestinyVendorItemRefundPolicy enum for details.</value>
    [DataMember(Name="refundPolicy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "refundPolicy")]
    public int? RefundPolicy { get; set; }

    /// <summary>
    /// The identifier of this receipt.
    /// </summary>
    /// <value>The identifier of this receipt.</value>
    [DataMember(Name="sequenceNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sequenceNumber")]
    public int? SequenceNumber { get; set; }

    /// <summary>
    /// The seconds since epoch at which this receipt is rendered invalid.
    /// </summary>
    /// <value>The seconds since epoch at which this receipt is rendered invalid.</value>
    [DataMember(Name="timeToExpiration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timeToExpiration")]
    public long? TimeToExpiration { get; set; }

    /// <summary>
    /// The date at which this receipt is rendered invalid.
    /// </summary>
    /// <value>The date at which this receipt is rendered invalid.</value>
    [DataMember(Name="expiresOn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expiresOn")]
    public DateTime? ExpiresOn { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyVendorsDestinyVendorReceipt {\n");
      sb.Append("  CurrencyPaid: ").Append(CurrencyPaid).Append("\n");
      sb.Append("  ItemReceived: ").Append(ItemReceived).Append("\n");
      sb.Append("  LicenseUnlockHash: ").Append(LicenseUnlockHash).Append("\n");
      sb.Append("  PurchasedByCharacterId: ").Append(PurchasedByCharacterId).Append("\n");
      sb.Append("  RefundPolicy: ").Append(RefundPolicy).Append("\n");
      sb.Append("  SequenceNumber: ").Append(SequenceNumber).Append("\n");
      sb.Append("  TimeToExpiration: ").Append(TimeToExpiration).Append("\n");
      sb.Append("  ExpiresOn: ").Append(ExpiresOn).Append("\n");
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
