using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Nodes on a graph can be visually connected: this appears to be the information about which nodes to link. It appears to lack more detailed information, such as the path for that linking.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDirectorDestinyActivityGraphConnectionDefinition {
    /// <summary>
    /// Gets or Sets SourceNodeHash
    /// </summary>
    [DataMember(Name="sourceNodeHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sourceNodeHash")]
    public int? SourceNodeHash { get; set; }

    /// <summary>
    /// Gets or Sets DestNodeHash
    /// </summary>
    [DataMember(Name="destNodeHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destNodeHash")]
    public int? DestNodeHash { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDirectorDestinyActivityGraphConnectionDefinition {\n");
      sb.Append("  SourceNodeHash: ").Append(SourceNodeHash).Append("\n");
      sb.Append("  DestNodeHash: ").Append(DestNodeHash).Append("\n");
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
