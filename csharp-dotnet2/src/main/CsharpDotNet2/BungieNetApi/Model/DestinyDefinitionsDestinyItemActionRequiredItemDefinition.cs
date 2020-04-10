using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// The definition of an item and quantity required in a character&#39;s inventory in order to perform an action.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyItemActionRequiredItemDefinition {
    /// <summary>
    /// The minimum quantity of the item you have to have.
    /// </summary>
    /// <value>The minimum quantity of the item you have to have.</value>
    [DataMember(Name="count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "count")]
    public int? Count { get; set; }

    /// <summary>
    /// The hash identifier of the item you need to have. Use it to look up the DestinyInventoryItemDefinition for more info.
    /// </summary>
    /// <value>The hash identifier of the item you need to have. Use it to look up the DestinyInventoryItemDefinition for more info.</value>
    [DataMember(Name="itemHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemHash")]
    public int? ItemHash { get; set; }

    /// <summary>
    /// If true, the item/quantity will be deleted from your inventory when the action is performed. Otherwise, you'll retain these required items after the action is complete.
    /// </summary>
    /// <value>If true, the item/quantity will be deleted from your inventory when the action is performed. Otherwise, you'll retain these required items after the action is complete.</value>
    [DataMember(Name="deleteOnAction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deleteOnAction")]
    public bool? DeleteOnAction { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyItemActionRequiredItemDefinition {\n");
      sb.Append("  Count: ").Append(Count).Append("\n");
      sb.Append("  ItemHash: ").Append(ItemHash).Append("\n");
      sb.Append("  DeleteOnAction: ").Append(DeleteOnAction).Append("\n");
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
