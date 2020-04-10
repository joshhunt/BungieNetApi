using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// An intrinsic perk on an item, and the requirements for it to be activated.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyItemPerkEntryDefinition {
    /// <summary>
    /// If this perk is not active, this is the string to show for why it's not providing its benefits.
    /// </summary>
    /// <value>If this perk is not active, this is the string to show for why it's not providing its benefits.</value>
    [DataMember(Name="requirementDisplayString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requirementDisplayString")]
    public string RequirementDisplayString { get; set; }

    /// <summary>
    /// A hash identifier for the DestinySandboxPerkDefinition being provided on the item.
    /// </summary>
    /// <value>A hash identifier for the DestinySandboxPerkDefinition being provided on the item.</value>
    [DataMember(Name="perkHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "perkHash")]
    public int? PerkHash { get; set; }

    /// <summary>
    /// Indicates whether this perk should be shown, or if it should be shown disabled.
    /// </summary>
    /// <value>Indicates whether this perk should be shown, or if it should be shown disabled.</value>
    [DataMember(Name="perkVisibility", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "perkVisibility")]
    public int? PerkVisibility { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyItemPerkEntryDefinition {\n");
      sb.Append("  RequirementDisplayString: ").Append(RequirementDisplayString).Append("\n");
      sb.Append("  PerkHash: ").Append(PerkHash).Append("\n");
      sb.Append("  PerkVisibility: ").Append(PerkVisibility).Append("\n");
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
