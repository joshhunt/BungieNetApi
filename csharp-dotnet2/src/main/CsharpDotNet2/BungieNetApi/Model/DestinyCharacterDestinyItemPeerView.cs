using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Bare minimum summary information for an item, for the sake of 3D rendering the item.
  /// </summary>
  [DataContract]
  public class DestinyCharacterDestinyItemPeerView {
    /// <summary>
    /// The hash identifier of the item in question. Use it to look up the DestinyInventoryItemDefinition of the item for static rendering data.
    /// </summary>
    /// <value>The hash identifier of the item in question. Use it to look up the DestinyInventoryItemDefinition of the item for static rendering data.</value>
    [DataMember(Name="itemHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemHash")]
    public int? ItemHash { get; set; }

    /// <summary>
    /// The list of dyes that have been applied to this item.
    /// </summary>
    /// <value>The list of dyes that have been applied to this item.</value>
    [DataMember(Name="dyes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dyes")]
    public List<DestinyDyeReference> Dyes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyCharacterDestinyItemPeerView {\n");
      sb.Append("  ItemHash: ").Append(ItemHash).Append("\n");
      sb.Append("  Dyes: ").Append(Dyes).Append("\n");
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
