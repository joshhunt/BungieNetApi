using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// This is a reference to, and summary data for, a specific item that you can get as a result of Using or Acquiring some other Item (For example, this could be summary information for an Emote that you can get by opening an an Eververse Box) See DestinyDerivedItemCategoryDefinition for more information.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsItemsDestinyDerivedItemDefinition {
    /// <summary>
    /// The hash for the DestinyInventoryItemDefinition of this derived item, if there is one. Sometimes we are given this information as a manual override, in which case there won't be an actual DestinyInventoryItemDefinition for what we display, but you can still show the strings from this object itself.
    /// </summary>
    /// <value>The hash for the DestinyInventoryItemDefinition of this derived item, if there is one. Sometimes we are given this information as a manual override, in which case there won't be an actual DestinyInventoryItemDefinition for what we display, but you can still show the strings from this object itself.</value>
    [DataMember(Name="itemHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemHash")]
    public int? ItemHash { get; set; }

    /// <summary>
    /// The name of the derived item.
    /// </summary>
    /// <value>The name of the derived item.</value>
    [DataMember(Name="itemName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemName")]
    public string ItemName { get; set; }

    /// <summary>
    /// Additional details about the derived item, in addition to the description.
    /// </summary>
    /// <value>Additional details about the derived item, in addition to the description.</value>
    [DataMember(Name="itemDetail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemDetail")]
    public string ItemDetail { get; set; }

    /// <summary>
    /// A brief description of the item.
    /// </summary>
    /// <value>A brief description of the item.</value>
    [DataMember(Name="itemDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemDescription")]
    public string ItemDescription { get; set; }

    /// <summary>
    /// An icon for the item.
    /// </summary>
    /// <value>An icon for the item.</value>
    [DataMember(Name="iconPath", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "iconPath")]
    public string IconPath { get; set; }

    /// <summary>
    /// If the item was derived from a \"Preview Vendor\", this will be an index into the DestinyVendorDefinition's itemList property. Otherwise, -1.
    /// </summary>
    /// <value>If the item was derived from a \"Preview Vendor\", this will be an index into the DestinyVendorDefinition's itemList property. Otherwise, -1.</value>
    [DataMember(Name="vendorItemIndex", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vendorItemIndex")]
    public int? VendorItemIndex { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsItemsDestinyDerivedItemDefinition {\n");
      sb.Append("  ItemHash: ").Append(ItemHash).Append("\n");
      sb.Append("  ItemName: ").Append(ItemName).Append("\n");
      sb.Append("  ItemDetail: ").Append(ItemDetail).Append("\n");
      sb.Append("  ItemDescription: ").Append(ItemDescription).Append("\n");
      sb.Append("  IconPath: ").Append(IconPath).Append("\n");
      sb.Append("  VendorItemIndex: ").Append(VendorItemIndex).Append("\n");
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
