using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// The definition of a known, reusable plug that can be applied to a socket.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinition {
    /// <summary>
    /// The hash identifier of a DestinyInventoryItemDefinition representing the plug that can be inserted.
    /// </summary>
    /// <value>The hash identifier of a DestinyInventoryItemDefinition representing the plug that can be inserted.</value>
    [DataMember(Name="plugItemHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "plugItemHash")]
    public int? PlugItemHash { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinition {\n");
      sb.Append("  PlugItemHash: ").Append(PlugItemHash).Append("\n");
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
