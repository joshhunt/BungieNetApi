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
  public class DestinyEntitiesItemsDestinyItemInstanceEnergy {
    /// <summary>
    /// The type of energy for this item. Plugs that require Energy can only be inserted if they have the \"Any\" Energy Type or the matching energy type of this item. This is a reference to the DestinyEnergyTypeDefinition for the energy type, where you can find extended info about it.
    /// </summary>
    /// <value>The type of energy for this item. Plugs that require Energy can only be inserted if they have the \"Any\" Energy Type or the matching energy type of this item. This is a reference to the DestinyEnergyTypeDefinition for the energy type, where you can find extended info about it.</value>
    [DataMember(Name="energyTypeHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "energyTypeHash")]
    public int? EnergyTypeHash { get; set; }

    /// <summary>
    /// This is the enum version of the Energy Type value, for convenience.
    /// </summary>
    /// <value>This is the enum version of the Energy Type value, for convenience.</value>
    [DataMember(Name="energyType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "energyType")]
    public int? EnergyType { get; set; }

    /// <summary>
    /// The total capacity of Energy that the item currently has, regardless of if it is currently being used.
    /// </summary>
    /// <value>The total capacity of Energy that the item currently has, regardless of if it is currently being used.</value>
    [DataMember(Name="energyCapacity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "energyCapacity")]
    public int? EnergyCapacity { get; set; }

    /// <summary>
    /// The amount of Energy currently in use by inserted plugs.
    /// </summary>
    /// <value>The amount of Energy currently in use by inserted plugs.</value>
    [DataMember(Name="energyUsed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "energyUsed")]
    public int? EnergyUsed { get; set; }

    /// <summary>
    /// The amount of energy still available for inserting new plugs.
    /// </summary>
    /// <value>The amount of energy still available for inserting new plugs.</value>
    [DataMember(Name="energyUnused", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "energyUnused")]
    public int? EnergyUnused { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyEntitiesItemsDestinyItemInstanceEnergy {\n");
      sb.Append("  EnergyTypeHash: ").Append(EnergyTypeHash).Append("\n");
      sb.Append("  EnergyType: ").Append(EnergyType).Append("\n");
      sb.Append("  EnergyCapacity: ").Append(EnergyCapacity).Append("\n");
      sb.Append("  EnergyUsed: ").Append(EnergyUsed).Append("\n");
      sb.Append("  EnergyUnused: ").Append(EnergyUnused).Append("\n");
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
