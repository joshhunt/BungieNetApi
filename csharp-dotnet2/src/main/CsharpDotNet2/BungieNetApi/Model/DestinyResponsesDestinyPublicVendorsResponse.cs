using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// A response containing all valid components for the public Vendors endpoint.   It is a decisively smaller subset of data compared to what we can get when we know the specific user making the request.   If you want any of the other data - item details, whether or not you can buy it, etc... you&#39;ll have to call in the context of a character. I know, sad but true.
  /// </summary>
  [DataContract]
  public class DestinyResponsesDestinyPublicVendorsResponse {
    /// <summary>
    /// For Vendors being returned, this will give you the information you need to group them and order them in the same way that the Bungie Companion app performs grouping. It will automatically be returned if you request the Vendors component.  COMPONENT TYPE: Vendors
    /// </summary>
    /// <value>For Vendors being returned, this will give you the information you need to group them and order them in the same way that the Bungie Companion app performs grouping. It will automatically be returned if you request the Vendors component.  COMPONENT TYPE: Vendors</value>
    [DataMember(Name="vendorGroups", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vendorGroups")]
    public SingleComponentResponseOfDestinyVendorGroupComponent VendorGroups { get; set; }

    /// <summary>
    /// The base properties of the vendor. These are keyed by the Vendor Hash, so you will get one Vendor Component per vendor returned.  COMPONENT TYPE: Vendors
    /// </summary>
    /// <value>The base properties of the vendor. These are keyed by the Vendor Hash, so you will get one Vendor Component per vendor returned.  COMPONENT TYPE: Vendors</value>
    [DataMember(Name="vendors", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vendors")]
    public DictionaryComponentResponseOfuint32AndDestinyPublicVendorComponent Vendors { get; set; }

    /// <summary>
    /// Categories that the vendor has available, and references to the sales therein. These are keyed by the Vendor Hash, so you will get one Categories Component per vendor returned.  COMPONENT TYPE: VendorCategories
    /// </summary>
    /// <value>Categories that the vendor has available, and references to the sales therein. These are keyed by the Vendor Hash, so you will get one Categories Component per vendor returned.  COMPONENT TYPE: VendorCategories</value>
    [DataMember(Name="categories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "categories")]
    public DictionaryComponentResponseOfuint32AndDestinyVendorCategoriesComponent Categories { get; set; }

    /// <summary>
    /// Sales, keyed by the vendorItemIndex of the item being sold. These are keyed by the Vendor Hash, so you will get one Sale Item Set Component per vendor returned.  Note that within the Sale Item Set component, the sales are themselves keyed by the vendorSaleIndex, so you can relate it to the corrent sale item definition within the Vendor's definition.  COMPONENT TYPE: VendorSales
    /// </summary>
    /// <value>Sales, keyed by the vendorItemIndex of the item being sold. These are keyed by the Vendor Hash, so you will get one Sale Item Set Component per vendor returned.  Note that within the Sale Item Set component, the sales are themselves keyed by the vendorSaleIndex, so you can relate it to the corrent sale item definition within the Vendor's definition.  COMPONENT TYPE: VendorSales</value>
    [DataMember(Name="sales", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sales")]
    public DictionaryComponentResponseOfuint32AndPublicDestinyVendorSaleItemSetComponent Sales { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyResponsesDestinyPublicVendorsResponse {\n");
      sb.Append("  VendorGroups: ").Append(VendorGroups).Append("\n");
      sb.Append("  Vendors: ").Append(Vendors).Append("\n");
      sb.Append("  Categories: ").Append(Categories).Append("\n");
      sb.Append("  Sales: ").Append(Sales).Append("\n");
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
