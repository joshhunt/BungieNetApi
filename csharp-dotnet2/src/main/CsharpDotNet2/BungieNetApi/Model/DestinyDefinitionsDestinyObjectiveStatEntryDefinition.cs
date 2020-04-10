using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Defines the conditions under which stat modifications will be applied to a Character while participating in an objective.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyObjectiveStatEntryDefinition {
    /// <summary>
    /// The stat being modified, and the value used.
    /// </summary>
    /// <value>The stat being modified, and the value used.</value>
    [DataMember(Name="stat", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stat")]
    public DestinyDefinitionsDestinyItemInvestmentStatDefinition Stat { get; set; }

    /// <summary>
    /// Whether it will be applied as long as the objective is active, when it's completed, or until it's completed.
    /// </summary>
    /// <value>Whether it will be applied as long as the objective is active, when it's completed, or until it's completed.</value>
    [DataMember(Name="style", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "style")]
    public int? Style { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyObjectiveStatEntryDefinition {\n");
      sb.Append("  Stat: ").Append(Stat).Append("\n");
      sb.Append("  Style: ").Append(Style).Append("\n");
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
