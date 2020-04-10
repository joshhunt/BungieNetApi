using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Represents a socket that has a plug associated with it intrinsically. This is useful for situations where the weapon needs to have a visual plug/Mod on it, but that plug/Mod should never change.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinition {
    /// <summary>
    /// Indicates the plug that is intrinsically inserted into this socket.
    /// </summary>
    /// <value>Indicates the plug that is intrinsically inserted into this socket.</value>
    [DataMember(Name="plugItemHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "plugItemHash")]
    public int? PlugItemHash { get; set; }

    /// <summary>
    /// Indicates the type of this intrinsic socket.
    /// </summary>
    /// <value>Indicates the type of this intrinsic socket.</value>
    [DataMember(Name="socketTypeHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "socketTypeHash")]
    public int? SocketTypeHash { get; set; }

    /// <summary>
    /// If true, then this socket is visible in the item's \"default\" state. If you have an instance, you should always check the runtime state, as that can override this visibility setting: but if you're looking at the item on a conceptual level, this property can be useful for hiding data such as legacy sockets - which remain defined on items for infrastructure purposes, but can be confusing for users to see.
    /// </summary>
    /// <value>If true, then this socket is visible in the item's \"default\" state. If you have an instance, you should always check the runtime state, as that can override this visibility setting: but if you're looking at the item on a conceptual level, this property can be useful for hiding data such as legacy sockets - which remain defined on items for infrastructure purposes, but can be confusing for users to see.</value>
    [DataMember(Name="defaultVisible", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultVisible")]
    public bool? DefaultVisible { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyItemIntrinsicSocketEntryDefinition {\n");
      sb.Append("  PlugItemHash: ").Append(PlugItemHash).Append("\n");
      sb.Append("  SocketTypeHash: ").Append(SocketTypeHash).Append("\n");
      sb.Append("  DefaultVisible: ").Append(DefaultVisible).Append("\n");
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
