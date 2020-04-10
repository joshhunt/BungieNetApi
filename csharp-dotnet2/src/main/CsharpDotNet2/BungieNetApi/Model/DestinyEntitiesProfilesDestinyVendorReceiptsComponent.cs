using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// For now, this isn&#39;t used for much: it&#39;s a record of the recent refundable purchases that the user has made. In the future, it could be used for providing refunds/buyback via the API. Wouldn&#39;t that be fun?
  /// </summary>
  [DataContract]
  public class DestinyEntitiesProfilesDestinyVendorReceiptsComponent {
    /// <summary>
    /// The receipts for refundable purchases made at a vendor.
    /// </summary>
    /// <value>The receipts for refundable purchases made at a vendor.</value>
    [DataMember(Name="receipts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "receipts")]
    public List<DestinyVendorsDestinyVendorReceipt> Receipts { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyEntitiesProfilesDestinyVendorReceiptsComponent {\n");
      sb.Append("  Receipts: ").Append(Receipts).Append("\n");
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
