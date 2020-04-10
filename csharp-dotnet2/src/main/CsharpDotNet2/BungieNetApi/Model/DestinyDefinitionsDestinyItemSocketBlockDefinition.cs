using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// If defined, the item has at least one socket.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyItemSocketBlockDefinition {
    /// <summary>
    /// This was supposed to be a string that would give per-item details about sockets. In practice, it turns out that all this ever has is the localized word \"details\". ... that's lame, but perhaps it will become something cool in the future.
    /// </summary>
    /// <value>This was supposed to be a string that would give per-item details about sockets. In practice, it turns out that all this ever has is the localized word \"details\". ... that's lame, but perhaps it will become something cool in the future.</value>
    [DataMember(Name="detail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "detail")]
    public string Detail { get; set; }

    /// <summary>
    /// Each non-intrinsic (or mutable) socket on an item is defined here. Check inside for more info.
    /// </summary>
    /// <value>Each non-intrinsic (or mutable) socket on an item is defined here. Check inside for more info.</value>
    [DataMember(Name="socketEntries", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "socketEntries")]
    public List<DestinyDefinitionsDestinyItemSocketEntryDefinition> SocketEntries { get; set; }

    /// <summary>
    /// Each intrinsic (or immutable/permanent) socket on an item is defined here, along with the plug that is permanently affixed to the socket.
    /// </summary>
    /// <value>Each intrinsic (or immutable/permanent) socket on an item is defined here, along with the plug that is permanently affixed to the socket.</value>
    [DataMember(Name="intrinsicSockets", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "intrinsicSockets")]
    public List<DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinition> IntrinsicSockets { get; set; }

    /// <summary>
    /// A convenience property, that refers to the sockets in the \"sockets\" property, pre-grouped by category and ordered in the manner that they should be grouped in the UI. You could form this yourself with the existing data, but why would you want to? Enjoy life man.
    /// </summary>
    /// <value>A convenience property, that refers to the sockets in the \"sockets\" property, pre-grouped by category and ordered in the manner that they should be grouped in the UI. You could form this yourself with the existing data, but why would you want to? Enjoy life man.</value>
    [DataMember(Name="socketCategories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "socketCategories")]
    public List<DestinyDefinitionsDestinyItemSocketCategoryDefinition> SocketCategories { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyItemSocketBlockDefinition {\n");
      sb.Append("  Detail: ").Append(Detail).Append("\n");
      sb.Append("  SocketEntries: ").Append(SocketEntries).Append("\n");
      sb.Append("  IntrinsicSockets: ").Append(IntrinsicSockets).Append("\n");
      sb.Append("  SocketCategories: ").Append(SocketCategories).Append("\n");
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
