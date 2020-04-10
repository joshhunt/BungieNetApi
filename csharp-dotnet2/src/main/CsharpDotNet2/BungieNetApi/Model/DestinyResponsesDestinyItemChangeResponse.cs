using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class DestinyResponsesDestinyItemChangeResponse {
    /// <summary>
    /// Gets or Sets Item
    /// </summary>
    [DataMember(Name="item", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "item")]
    public DestinyResponsesDestinyItemResponse Item { get; set; }

    /// <summary>
    /// Items that appeared in the inventory possibly as a result of an action.
    /// </summary>
    /// <value>Items that appeared in the inventory possibly as a result of an action.</value>
    [DataMember(Name="addedInventoryItems", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "addedInventoryItems")]
    public List<DestinyEntitiesItemsDestinyItemComponent> AddedInventoryItems { get; set; }

    /// <summary>
    /// Items that disappeared from the inventory possibly as a result of an action.
    /// </summary>
    /// <value>Items that disappeared from the inventory possibly as a result of an action.</value>
    [DataMember(Name="removedInventoryItems", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "removedInventoryItems")]
    public List<DestinyEntitiesItemsDestinyItemComponent> RemovedInventoryItems { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyResponsesDestinyItemChangeResponse {\n");
      sb.Append("  Item: ").Append(Item).Append("\n");
      sb.Append("  AddedInventoryItems: ").Append(AddedInventoryItems).Append("\n");
      sb.Append("  RemovedInventoryItems: ").Append(RemovedInventoryItems).Append("\n");
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
