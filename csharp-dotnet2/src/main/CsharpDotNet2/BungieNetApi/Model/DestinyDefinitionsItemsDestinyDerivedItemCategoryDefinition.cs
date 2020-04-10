using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// A shortcut for the fact that some items have a \&quot;Preview Vendor\&quot; - See DestinyInventoryItemDefinition.preview.previewVendorHash - that is intended to be used to show what items you can get as a result of acquiring or using this item.  A common example of this in Destiny 1 was Eververse \&quot;Boxes,\&quot; which could have many possible items. This \&quot;Preview Vendor\&quot; is not a vendor you can actually see in the game, but it defines categories and sale items for all of the possible items you could get from the Box so that the game can show them to you. We summarize that info here so that you don&#39;t have to do that Vendor lookup and aggregation manually.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsItemsDestinyDerivedItemCategoryDefinition {
    /// <summary>
    /// The localized string for the category title. This will be something describing the items you can get as a group, or your likelihood/the quantity you'll get.
    /// </summary>
    /// <value>The localized string for the category title. This will be something describing the items you can get as a group, or your likelihood/the quantity you'll get.</value>
    [DataMember(Name="categoryDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "categoryDescription")]
    public string CategoryDescription { get; set; }

    /// <summary>
    /// This is the list of all of the items for this category and the basic properties we'll know about them.
    /// </summary>
    /// <value>This is the list of all of the items for this category and the basic properties we'll know about them.</value>
    [DataMember(Name="items", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "items")]
    public List<DestinyDefinitionsItemsDestinyDerivedItemDefinition> Items { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsItemsDestinyDerivedItemCategoryDefinition {\n");
      sb.Append("  CategoryDescription: ").Append(CategoryDescription).Append("\n");
      sb.Append("  Items: ").Append(Items).Append("\n");
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
