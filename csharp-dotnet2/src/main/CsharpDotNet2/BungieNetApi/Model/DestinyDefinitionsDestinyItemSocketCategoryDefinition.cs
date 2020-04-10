using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Sockets are grouped into categories in the UI. These define which category and which sockets are under that category.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyItemSocketCategoryDefinition {
    /// <summary>
    /// The hash for the Socket Category: a quick way to go get the header display information for the category. Use it to look up DestinySocketCategoryDefinition info.
    /// </summary>
    /// <value>The hash for the Socket Category: a quick way to go get the header display information for the category. Use it to look up DestinySocketCategoryDefinition info.</value>
    [DataMember(Name="socketCategoryHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "socketCategoryHash")]
    public int? SocketCategoryHash { get; set; }

    /// <summary>
    /// Use these indexes to look up the sockets in the \"sockets.socketEntries\" property on the item definition. These are the indexes under the category, in game-rendered order.
    /// </summary>
    /// <value>Use these indexes to look up the sockets in the \"sockets.socketEntries\" property on the item definition. These are the indexes under the category, in game-rendered order.</value>
    [DataMember(Name="socketIndexes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "socketIndexes")]
    public List<int?> SocketIndexes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyItemSocketCategoryDefinition {\n");
      sb.Append("  SocketCategoryHash: ").Append(SocketCategoryHash).Append("\n");
      sb.Append("  SocketIndexes: ").Append(SocketIndexes).Append("\n");
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
