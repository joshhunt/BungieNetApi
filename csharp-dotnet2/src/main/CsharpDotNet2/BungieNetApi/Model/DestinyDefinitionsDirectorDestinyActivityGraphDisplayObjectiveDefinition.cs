using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// When a Graph needs to show active Objectives, this defines those objectives as well as an identifier.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinition {
    /// <summary>
    /// $NOTE $amola 2017-01-19 This field is apparently something that CUI uses to manually wire up objectives to display info. I am unsure how it works.
    /// </summary>
    /// <value>$NOTE $amola 2017-01-19 This field is apparently something that CUI uses to manually wire up objectives to display info. I am unsure how it works.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// The objective being shown on the map.
    /// </summary>
    /// <value>The objective being shown on the map.</value>
    [DataMember(Name="objectiveHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "objectiveHash")]
    public int? ObjectiveHash { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinition {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ObjectiveHash: ").Append(ObjectiveHash).Append("\n");
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
