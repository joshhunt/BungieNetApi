using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// A point of entry into an activity, gated by an unlock flag and with some more-or-less useless (for our purposes) phase information. I&#39;m including it in case we end up being able to bolt more useful information onto it in the future.  UPDATE: Turns out this information isn&#39;t actually useless, and is in fact actually useful for people. Who would have thought? We still don&#39;t have localized info for it, but at least this will help people when they&#39;re looking at phase indexes in stats data, or when they want to know what phases have been completed on a weekly achievement.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyActivityInsertionPointDefinition {
    /// <summary>
    /// A unique hash value representing the phase. This can be useful for, for example, comparing how different instances of Raids have phases in different orders!
    /// </summary>
    /// <value>A unique hash value representing the phase. This can be useful for, for example, comparing how different instances of Raids have phases in different orders!</value>
    [DataMember(Name="phaseHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phaseHash")]
    public int? PhaseHash { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyActivityInsertionPointDefinition {\n");
      sb.Append("  PhaseHash: ").Append(PhaseHash).Append("\n");
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
