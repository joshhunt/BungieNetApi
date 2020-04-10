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
  public class DestinyDefinitionsDestinyActivityLoadoutRequirementSet {
    /// <summary>
    /// The set of requirements that will be applied on the activity if this requirement set is active.
    /// </summary>
    /// <value>The set of requirements that will be applied on the activity if this requirement set is active.</value>
    [DataMember(Name="requirements", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requirements")]
    public List<DestinyDefinitionsDestinyActivityLoadoutRequirement> Requirements { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyActivityLoadoutRequirementSet {\n");
      sb.Append("  Requirements: ").Append(Requirements).Append("\n");
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
