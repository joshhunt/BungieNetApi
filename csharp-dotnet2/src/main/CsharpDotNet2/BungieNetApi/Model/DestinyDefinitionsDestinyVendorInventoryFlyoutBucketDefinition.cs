using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Information about a single inventory bucket in a vendor flyout UI and how it is shown.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyVendorInventoryFlyoutBucketDefinition {
    /// <summary>
    /// If true, the inventory bucket should be able to be collapsed visually.
    /// </summary>
    /// <value>If true, the inventory bucket should be able to be collapsed visually.</value>
    [DataMember(Name="collapsible", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "collapsible")]
    public bool? Collapsible { get; set; }

    /// <summary>
    /// The inventory bucket whose contents should be shown.
    /// </summary>
    /// <value>The inventory bucket whose contents should be shown.</value>
    [DataMember(Name="inventoryBucketHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inventoryBucketHash")]
    public int? InventoryBucketHash { get; set; }

    /// <summary>
    /// The methodology to use for sorting items from the flyout.
    /// </summary>
    /// <value>The methodology to use for sorting items from the flyout.</value>
    [DataMember(Name="sortItemsBy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sortItemsBy")]
    public int? SortItemsBy { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyVendorInventoryFlyoutBucketDefinition {\n");
      sb.Append("  Collapsible: ").Append(Collapsible).Append("\n");
      sb.Append("  InventoryBucketHash: ").Append(InventoryBucketHash).Append("\n");
      sb.Append("  SortItemsBy: ").Append(SortItemsBy).Append("\n");
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
