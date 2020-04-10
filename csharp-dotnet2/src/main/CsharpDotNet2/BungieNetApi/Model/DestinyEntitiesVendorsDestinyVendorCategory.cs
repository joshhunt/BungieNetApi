using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Information about the category and items currently sold in that category.
  /// </summary>
  [DataContract]
  public class DestinyEntitiesVendorsDestinyVendorCategory {
    /// <summary>
    /// An index into the DestinyVendorDefinition.displayCategories property, so you can grab the display data for this category.
    /// </summary>
    /// <value>An index into the DestinyVendorDefinition.displayCategories property, so you can grab the display data for this category.</value>
    [DataMember(Name="displayCategoryIndex", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayCategoryIndex")]
    public int? DisplayCategoryIndex { get; set; }

    /// <summary>
    /// An ordered list of indexes into items being sold in this category (DestinyVendorDefinition.itemList) which will contain more information about the items being sold themselves. Can also be used to index into DestinyVendorSaleItemComponent data, if you asked for that data to be returned.
    /// </summary>
    /// <value>An ordered list of indexes into items being sold in this category (DestinyVendorDefinition.itemList) which will contain more information about the items being sold themselves. Can also be used to index into DestinyVendorSaleItemComponent data, if you asked for that data to be returned.</value>
    [DataMember(Name="itemIndexes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemIndexes")]
    public List<int?> ItemIndexes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyEntitiesVendorsDestinyVendorCategory {\n");
      sb.Append("  DisplayCategoryIndex: ").Append(DisplayCategoryIndex).Append("\n");
      sb.Append("  ItemIndexes: ").Append(ItemIndexes).Append("\n");
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
