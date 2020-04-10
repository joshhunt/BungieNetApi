using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Represents that a vendor could sell this item, and provides a quick link to that vendor and sale item.   Note that we do not and cannot make a guarantee that the vendor will ever *actually* sell this item, only that the Vendor has a definition that indicates it *could* be sold.   Note also that a vendor may sell the same item in multiple \&quot;ways\&quot;, which means there may be multiple vendorItemIndexes for a single Vendor hash.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyItemVendorSourceReference {
    /// <summary>
    /// The identifier for the vendor that may sell this item.
    /// </summary>
    /// <value>The identifier for the vendor that may sell this item.</value>
    [DataMember(Name="vendorHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vendorHash")]
    public int? VendorHash { get; set; }

    /// <summary>
    /// The Vendor sale item indexes that represent the sale information for this item. The same vendor may sell an item in multiple \"ways\", hence why this is a list. (for instance, a weapon may be \"sold\" as a reward in a quest, for Glimmer, and for Masterwork Cores: each of those ways would be represented by a different vendor sale item with a different index)
    /// </summary>
    /// <value>The Vendor sale item indexes that represent the sale information for this item. The same vendor may sell an item in multiple \"ways\", hence why this is a list. (for instance, a weapon may be \"sold\" as a reward in a quest, for Glimmer, and for Masterwork Cores: each of those ways would be represented by a different vendor sale item with a different index)</value>
    [DataMember(Name="vendorItemIndexes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vendorItemIndexes")]
    public List<int?> VendorItemIndexes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyItemVendorSourceReference {\n");
      sb.Append("  VendorHash: ").Append(VendorHash).Append("\n");
      sb.Append("  VendorItemIndexes: ").Append(VendorItemIndexes).Append("\n");
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
