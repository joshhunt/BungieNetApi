using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// The list of indexes into the Talent Grid&#39;s \&quot;nodes\&quot; property for nodes in this exclusive set. (See DestinyTalentNodeDefinition.nodeIndex)
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyTalentNodeExclusiveSetDefinition {
    /// <summary>
    /// The list of node indexes for the exclusive set. Historically, these were indexes. I would have liked to replace this with nodeHashes for consistency, but it's way too late for that. (9:09 PM, he's right!)
    /// </summary>
    /// <value>The list of node indexes for the exclusive set. Historically, these were indexes. I would have liked to replace this with nodeHashes for consistency, but it's way too late for that. (9:09 PM, he's right!)</value>
    [DataMember(Name="nodeIndexes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nodeIndexes")]
    public List<int?> NodeIndexes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyTalentNodeExclusiveSetDefinition {\n");
      sb.Append("  NodeIndexes: ").Append(NodeIndexes).Append("\n");
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
