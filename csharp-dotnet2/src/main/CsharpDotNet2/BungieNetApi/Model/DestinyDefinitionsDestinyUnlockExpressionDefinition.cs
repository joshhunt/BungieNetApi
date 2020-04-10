using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Where the sausage gets made. Unlock Expressions are the foundation of the game&#39;s gating mechanics and investment-related restrictions. They can test Unlock Flags and Unlock Values for certain states, using a sufficient amount of logical operators such that unlock expressions are effectively Turing complete.  Use UnlockExpressionParser to evaluate expressions using an IUnlockContext parsed from Babel.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyUnlockExpressionDefinition {
    /// <summary>
    /// A shortcut for determining the most restrictive gating that this expression performs. See the DestinyGatingScope enum's documentation for more details.
    /// </summary>
    /// <value>A shortcut for determining the most restrictive gating that this expression performs. See the DestinyGatingScope enum's documentation for more details.</value>
    [DataMember(Name="scope", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scope")]
    public int? Scope { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyUnlockExpressionDefinition {\n");
      sb.Append("  Scope: ").Append(Scope).Append("\n");
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
