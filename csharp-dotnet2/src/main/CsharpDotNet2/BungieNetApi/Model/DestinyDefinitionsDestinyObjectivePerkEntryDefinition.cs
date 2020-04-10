using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Defines the conditions under which an intrinsic perk is applied while participating in an Objective.  These perks will generally not be benefit-granting perks, but rather a perk that modifies gameplay in some interesting way.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyObjectivePerkEntryDefinition {
    /// <summary>
    /// The hash identifier of the DestinySandboxPerkDefinition that will be applied to the character.
    /// </summary>
    /// <value>The hash identifier of the DestinySandboxPerkDefinition that will be applied to the character.</value>
    [DataMember(Name="perkHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "perkHash")]
    public int? PerkHash { get; set; }

    /// <summary>
    /// An enumeration indicating whether it will be applied as long as the Objective is active, when it's completed, or until it's completed.
    /// </summary>
    /// <value>An enumeration indicating whether it will be applied as long as the Objective is active, when it's completed, or until it's completed.</value>
    [DataMember(Name="style", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "style")]
    public int? Style { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyObjectivePerkEntryDefinition {\n");
      sb.Append("  PerkHash: ").Append(PerkHash).Append("\n");
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
