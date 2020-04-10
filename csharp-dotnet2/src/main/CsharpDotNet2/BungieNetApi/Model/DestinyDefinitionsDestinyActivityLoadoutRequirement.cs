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
  public class DestinyDefinitionsDestinyActivityLoadoutRequirement {
    /// <summary>
    /// Gets or Sets EquipmentSlotHash
    /// </summary>
    [DataMember(Name="equipmentSlotHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "equipmentSlotHash")]
    public int? EquipmentSlotHash { get; set; }

    /// <summary>
    /// Gets or Sets AllowedEquippedItemHashes
    /// </summary>
    [DataMember(Name="allowedEquippedItemHashes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allowedEquippedItemHashes")]
    public List<int?> AllowedEquippedItemHashes { get; set; }

    /// <summary>
    /// Gets or Sets AllowedWeaponSubTypes
    /// </summary>
    [DataMember(Name="allowedWeaponSubTypes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allowedWeaponSubTypes")]
    public List<int?> AllowedWeaponSubTypes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyActivityLoadoutRequirement {\n");
      sb.Append("  EquipmentSlotHash: ").Append(EquipmentSlotHash).Append("\n");
      sb.Append("  AllowedEquippedItemHashes: ").Append(AllowedEquippedItemHashes).Append("\n");
      sb.Append("  AllowedWeaponSubTypes: ").Append(AllowedWeaponSubTypes).Append("\n");
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
