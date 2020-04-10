using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Items can have Energy Capacity, and plugs can provide that capacity such as on a piece of Armor in Armor 2.0. This is how much \&quot;Energy\&quot; can be spent on activating plugs for this item.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsItemsDestinyEnergyCapacityEntry {
    /// <summary>
    /// How much energy capacity this plug provides.
    /// </summary>
    /// <value>How much energy capacity this plug provides.</value>
    [DataMember(Name="capacityValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "capacityValue")]
    public int? CapacityValue { get; set; }

    /// <summary>
    /// Energy provided by a plug is always of a specific type - this is the hash identifier for the energy type for which it provides Capacity.
    /// </summary>
    /// <value>Energy provided by a plug is always of a specific type - this is the hash identifier for the energy type for which it provides Capacity.</value>
    [DataMember(Name="energyTypeHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "energyTypeHash")]
    public int? EnergyTypeHash { get; set; }

    /// <summary>
    /// The Energy Type for this energy capacity, in enum form for easy use.
    /// </summary>
    /// <value>The Energy Type for this energy capacity, in enum form for easy use.</value>
    [DataMember(Name="energyType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "energyType")]
    public int? EnergyType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsItemsDestinyEnergyCapacityEntry {\n");
      sb.Append("  CapacityValue: ").Append(CapacityValue).Append("\n");
      sb.Append("  EnergyTypeHash: ").Append(EnergyTypeHash).Append("\n");
      sb.Append("  EnergyType: ").Append(EnergyType).Append("\n");
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
