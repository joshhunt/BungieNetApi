using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// This defines an item&#39;s \&quot;Value\&quot;. Unfortunately, this appears to be used in different ways depending on the way that the item itself is used.  For items being sold at a Vendor, this is the default \&quot;sale price\&quot; of the item. These days, the vendor itself almost always sets the price, but it still possible for the price to fall back to this value. For quests, it is a preview of rewards you can gain by completing the quest. For dummy items, if the itemValue refers to an Emblem, it is the emblem that should be shown as the reward. (jeez louise)  It will likely be used in a number of other ways in the future, it appears to be a bucket where they put arbitrary items and quantities into the item.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyItemValueBlockDefinition {
    /// <summary>
    /// References to the items that make up this item's \"value\", and the quantity.
    /// </summary>
    /// <value>References to the items that make up this item's \"value\", and the quantity.</value>
    [DataMember(Name="itemValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemValue")]
    public List<DestinyDestinyItemQuantity> ItemValue { get; set; }

    /// <summary>
    /// If there's a localized text description of the value provided, this will be said description.
    /// </summary>
    /// <value>If there's a localized text description of the value provided, this will be said description.</value>
    [DataMember(Name="valueDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "valueDescription")]
    public string ValueDescription { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyItemValueBlockDefinition {\n");
      sb.Append("  ItemValue: ").Append(ItemValue).Append("\n");
      sb.Append("  ValueDescription: ").Append(ValueDescription).Append("\n");
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
