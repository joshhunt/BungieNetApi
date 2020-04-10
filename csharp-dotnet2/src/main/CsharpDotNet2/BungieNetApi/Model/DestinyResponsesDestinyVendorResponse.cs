using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// A response containing all of the components for a vendor.
  /// </summary>
  [DataContract]
  public class DestinyResponsesDestinyVendorResponse {
    /// <summary>
    /// The base properties of the vendor.  COMPONENT TYPE: Vendors
    /// </summary>
    /// <value>The base properties of the vendor.  COMPONENT TYPE: Vendors</value>
    [DataMember(Name="vendor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vendor")]
    public SingleComponentResponseOfDestinyVendorComponent Vendor { get; set; }

    /// <summary>
    /// Categories that the vendor has available, and references to the sales therein.  COMPONENT TYPE: VendorCategories
    /// </summary>
    /// <value>Categories that the vendor has available, and references to the sales therein.  COMPONENT TYPE: VendorCategories</value>
    [DataMember(Name="categories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "categories")]
    public SingleComponentResponseOfDestinyVendorCategoriesComponent Categories { get; set; }

    /// <summary>
    /// Sales, keyed by the vendorItemIndex of the item being sold.  COMPONENT TYPE: VendorSales
    /// </summary>
    /// <value>Sales, keyed by the vendorItemIndex of the item being sold.  COMPONENT TYPE: VendorSales</value>
    [DataMember(Name="sales", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sales")]
    public DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponent Sales { get; set; }

    /// <summary>
    /// Item components, keyed by the vendorItemIndex of the active sale items.  COMPONENT TYPE: [See inside the DestinyItemComponentSet contract for component types.]
    /// </summary>
    /// <value>Item components, keyed by the vendorItemIndex of the active sale items.  COMPONENT TYPE: [See inside the DestinyItemComponentSet contract for component types.]</value>
    [DataMember(Name="itemComponents", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemComponents")]
    public DestinyItemComponentSetOfint32 ItemComponents { get; set; }

    /// <summary>
    /// A \"lookup\" convenience component that can be used to quickly check if the character has access to items that can be used for purchasing.  COMPONENT TYPE: CurrencyLookups
    /// </summary>
    /// <value>A \"lookup\" convenience component that can be used to quickly check if the character has access to items that can be used for purchasing.  COMPONENT TYPE: CurrencyLookups</value>
    [DataMember(Name="currencyLookups", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currencyLookups")]
    public SingleComponentResponseOfDestinyCurrenciesComponent CurrencyLookups { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyResponsesDestinyVendorResponse {\n");
      sb.Append("  Vendor: ").Append(Vendor).Append("\n");
      sb.Append("  Categories: ").Append(Categories).Append("\n");
      sb.Append("  Sales: ").Append(Sales).Append("\n");
      sb.Append("  ItemComponents: ").Append(ItemComponents).Append("\n");
      sb.Append("  CurrencyLookups: ").Append(CurrencyLookups).Append("\n");
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
