using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// This Block defines the rendering data associated with the item, if any.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyItemTranslationBlockDefinition {
    /// <summary>
    /// Gets or Sets WeaponPatternIdentifier
    /// </summary>
    [DataMember(Name="weaponPatternIdentifier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "weaponPatternIdentifier")]
    public string WeaponPatternIdentifier { get; set; }

    /// <summary>
    /// Gets or Sets WeaponPatternHash
    /// </summary>
    [DataMember(Name="weaponPatternHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "weaponPatternHash")]
    public int? WeaponPatternHash { get; set; }

    /// <summary>
    /// Gets or Sets DefaultDyes
    /// </summary>
    [DataMember(Name="defaultDyes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultDyes")]
    public List<DestinyDyeReference> DefaultDyes { get; set; }

    /// <summary>
    /// Gets or Sets LockedDyes
    /// </summary>
    [DataMember(Name="lockedDyes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lockedDyes")]
    public List<DestinyDyeReference> LockedDyes { get; set; }

    /// <summary>
    /// Gets or Sets CustomDyes
    /// </summary>
    [DataMember(Name="customDyes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customDyes")]
    public List<DestinyDyeReference> CustomDyes { get; set; }

    /// <summary>
    /// Gets or Sets Arrangements
    /// </summary>
    [DataMember(Name="arrangements", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "arrangements")]
    public List<DestinyDefinitionsDestinyGearArtArrangementReference> Arrangements { get; set; }

    /// <summary>
    /// Gets or Sets HasGeometry
    /// </summary>
    [DataMember(Name="hasGeometry", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hasGeometry")]
    public bool? HasGeometry { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyItemTranslationBlockDefinition {\n");
      sb.Append("  WeaponPatternIdentifier: ").Append(WeaponPatternIdentifier).Append("\n");
      sb.Append("  WeaponPatternHash: ").Append(WeaponPatternHash).Append("\n");
      sb.Append("  DefaultDyes: ").Append(DefaultDyes).Append("\n");
      sb.Append("  LockedDyes: ").Append(LockedDyes).Append("\n");
      sb.Append("  CustomDyes: ").Append(CustomDyes).Append("\n");
      sb.Append("  Arrangements: ").Append(Arrangements).Append("\n");
      sb.Append("  HasGeometry: ").Append(HasGeometry).Append("\n");
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
