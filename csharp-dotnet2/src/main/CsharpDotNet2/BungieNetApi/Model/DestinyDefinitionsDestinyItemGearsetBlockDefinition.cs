using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// If an item has a related gearset, this is the list of items in that set, and an unlock expression that evaluates to a number representing the progress toward gearset completion (a very rare use for unlock expressions!)
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyItemGearsetBlockDefinition {
    /// <summary>
    /// The maximum possible number of items that can be collected.
    /// </summary>
    /// <value>The maximum possible number of items that can be collected.</value>
    [DataMember(Name="trackingValueMax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trackingValueMax")]
    public int? TrackingValueMax { get; set; }

    /// <summary>
    /// The list of hashes for items in the gearset. Use them to look up DestinyInventoryItemDefinition entries for the items in the set.
    /// </summary>
    /// <value>The list of hashes for items in the gearset. Use them to look up DestinyInventoryItemDefinition entries for the items in the set.</value>
    [DataMember(Name="itemList", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemList")]
    public List<int?> ItemList { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyItemGearsetBlockDefinition {\n");
      sb.Append("  TrackingValueMax: ").Append(TrackingValueMax).Append("\n");
      sb.Append("  ItemList: ").Append(ItemList).Append("\n");
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
