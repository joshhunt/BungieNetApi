using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// A vendor can have many categories of items that they sell. This component will return the category information for available items, as well as the index into those items in the user&#39;s sale item list.  Note that, since both the category and items are indexes, this data is Content Version dependent. Be sure to check that your content is up to date before using this data. This is an unfortunate, but permanent, limitation of Vendor data.
  /// </summary>
  [DataContract]
  public class DestinyEntitiesVendorsDestinyVendorCategoriesComponent {
    /// <summary>
    /// The list of categories for items that the vendor sells, in rendering order.  These categories each point to a \"display category\" in the displayCategories property of the DestinyVendorDefinition, as opposed to the other categories.
    /// </summary>
    /// <value>The list of categories for items that the vendor sells, in rendering order.  These categories each point to a \"display category\" in the displayCategories property of the DestinyVendorDefinition, as opposed to the other categories.</value>
    [DataMember(Name="categories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "categories")]
    public List<DestinyEntitiesVendorsDestinyVendorCategory> Categories { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyEntitiesVendorsDestinyVendorCategoriesComponent {\n");
      sb.Append("  Categories: ").Append(Categories).Append("\n");
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
