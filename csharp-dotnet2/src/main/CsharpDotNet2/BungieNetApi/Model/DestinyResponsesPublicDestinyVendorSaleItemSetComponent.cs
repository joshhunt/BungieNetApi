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
  public class DestinyResponsesPublicDestinyVendorSaleItemSetComponent {
    /// <summary>
    /// Gets or Sets SaleItems
    /// </summary>
    [DataMember(Name="saleItems", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "saleItems")]
    public Dictionary<string, DestinyComponentsVendorsDestinyPublicVendorSaleItemComponent> SaleItems { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyResponsesPublicDestinyVendorSaleItemSetComponent {\n");
      sb.Append("  SaleItems: ").Append(SaleItems).Append("\n");
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
