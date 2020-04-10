using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// When a Graph needs to show active Progressions, this defines those objectives as well as an identifier.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDirectorDestinyActivityGraphDisplayProgressionDefinition {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets ProgressionHash
    /// </summary>
    [DataMember(Name="progressionHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "progressionHash")]
    public int? ProgressionHash { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDirectorDestinyActivityGraphDisplayProgressionDefinition {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ProgressionHash: ").Append(ProgressionHash).Append("\n");
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
