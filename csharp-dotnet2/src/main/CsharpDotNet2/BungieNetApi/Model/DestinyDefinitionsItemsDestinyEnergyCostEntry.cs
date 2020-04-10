using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Some plugs cost Energy, which is a stat on the item that can be increased by other plugs (that, at least in Armor 2.0, have a \&quot;masterworks-like\&quot; mechanic for upgrading). If a plug has costs, the details of that cost are defined here.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsItemsDestinyEnergyCostEntry {
    /// <summary>
    /// The Energy cost for inserting this plug.
    /// </summary>
    /// <value>The Energy cost for inserting this plug.</value>
    [DataMember(Name="energyCost", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "energyCost")]
    public int? EnergyCost { get; set; }

    /// <summary>
    /// The type of energy that this plug costs, as a reference to the DestinyEnergyTypeDefinition of the energy type.
    /// </summary>
    /// <value>The type of energy that this plug costs, as a reference to the DestinyEnergyTypeDefinition of the energy type.</value>
    [DataMember(Name="energyTypeHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "energyTypeHash")]
    public int? EnergyTypeHash { get; set; }

    /// <summary>
    /// The type of energy that this plug costs, in enum form.
    /// </summary>
    /// <value>The type of energy that this plug costs, in enum form.</value>
    [DataMember(Name="energyType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "energyType")]
    public int? EnergyType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsItemsDestinyEnergyCostEntry {\n");
      sb.Append("  EnergyCost: ").Append(EnergyCost).Append("\n");
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
