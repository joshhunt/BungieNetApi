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
  public class DestinyComponentsPresentationDestinyPresentationNodesComponent {
    /// <summary>
    /// Gets or Sets Nodes
    /// </summary>
    [DataMember(Name="nodes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nodes")]
    public Dictionary<string, DestinyComponentsPresentationDestinyPresentationNodeComponent> Nodes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyComponentsPresentationDestinyPresentationNodesComponent {\n");
      sb.Append("  Nodes: ").Append(Nodes).Append("\n");
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
