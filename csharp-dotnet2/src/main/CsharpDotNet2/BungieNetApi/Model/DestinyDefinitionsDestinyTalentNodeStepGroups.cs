using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// These properties are an attempt to categorize talent node steps by certain common properties. See the related enumerations for the type of properties being categorized.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyTalentNodeStepGroups {
    /// <summary>
    /// Gets or Sets WeaponPerformance
    /// </summary>
    [DataMember(Name="weaponPerformance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "weaponPerformance")]
    public int? WeaponPerformance { get; set; }

    /// <summary>
    /// Gets or Sets ImpactEffects
    /// </summary>
    [DataMember(Name="impactEffects", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "impactEffects")]
    public int? ImpactEffects { get; set; }

    /// <summary>
    /// Gets or Sets GuardianAttributes
    /// </summary>
    [DataMember(Name="guardianAttributes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "guardianAttributes")]
    public int? GuardianAttributes { get; set; }

    /// <summary>
    /// Gets or Sets LightAbilities
    /// </summary>
    [DataMember(Name="lightAbilities", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lightAbilities")]
    public int? LightAbilities { get; set; }

    /// <summary>
    /// Gets or Sets DamageTypes
    /// </summary>
    [DataMember(Name="damageTypes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damageTypes")]
    public int? DamageTypes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyTalentNodeStepGroups {\n");
      sb.Append("  WeaponPerformance: ").Append(WeaponPerformance).Append("\n");
      sb.Append("  ImpactEffects: ").Append(ImpactEffects).Append("\n");
      sb.Append("  GuardianAttributes: ").Append(GuardianAttributes).Append("\n");
      sb.Append("  LightAbilities: ").Append(LightAbilities).Append("\n");
      sb.Append("  DamageTypes: ").Append(DamageTypes).Append("\n");
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
