using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Used in a number of Destiny contracts to return data about an item stack and its quantity. Can optionally return an itemInstanceId if the item is instanced - in which case, the quantity returned will be 1. If it&#39;s not... uh, let me know okay? Thanks.
  /// </summary>
  [DataContract]
  public class DestinyDestinyItemQuantity {
    /// <summary>
    /// The hash identifier for the item in question. Use it to look up the item's DestinyInventoryItemDefinition.
    /// </summary>
    /// <value>The hash identifier for the item in question. Use it to look up the item's DestinyInventoryItemDefinition.</value>
    [DataMember(Name="itemHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemHash")]
    public int? ItemHash { get; set; }

    /// <summary>
    /// If this quantity is referring to a specific instance of an item, this will have the item's instance ID. Normally, this will be null.
    /// </summary>
    /// <value>If this quantity is referring to a specific instance of an item, this will have the item's instance ID. Normally, this will be null.</value>
    [DataMember(Name="itemInstanceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemInstanceId")]
    public long? ItemInstanceId { get; set; }

    /// <summary>
    /// The amount of the item needed/available depending on the context of where DestinyItemQuantity is being used.
    /// </summary>
    /// <value>The amount of the item needed/available depending on the context of where DestinyItemQuantity is being used.</value>
    [DataMember(Name="quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity")]
    public int? Quantity { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDestinyItemQuantity {\n");
      sb.Append("  ItemHash: ").Append(ItemHash).Append("\n");
      sb.Append("  ItemInstanceId: ").Append(ItemInstanceId).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
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
