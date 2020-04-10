using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Represents types of Energy that can be used for costs and payments related to Armor 2.0 mods.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsEnergyTypesDestinyEnergyTypeDefinition {
    /// <summary>
    /// The description of the energy type, icon etc...
    /// </summary>
    /// <value>The description of the energy type, icon etc...</value>
    [DataMember(Name="displayProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayProperties")]
    public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

    /// <summary>
    /// A variant of the icon that is transparent and colorless.
    /// </summary>
    /// <value>A variant of the icon that is transparent and colorless.</value>
    [DataMember(Name="transparentIconPath", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transparentIconPath")]
    public string TransparentIconPath { get; set; }

    /// <summary>
    /// If TRUE, the game shows this Energy type's icon. Otherwise, it doesn't. Whether you show it or not is up to you.
    /// </summary>
    /// <value>If TRUE, the game shows this Energy type's icon. Otherwise, it doesn't. Whether you show it or not is up to you.</value>
    [DataMember(Name="showIcon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "showIcon")]
    public bool? ShowIcon { get; set; }

    /// <summary>
    /// We have an enumeration for Energy types for quick reference. This is the current definition's Energy type enum value.
    /// </summary>
    /// <value>We have an enumeration for Energy types for quick reference. This is the current definition's Energy type enum value.</value>
    [DataMember(Name="enumValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enumValue")]
    public int? EnumValue { get; set; }

    /// <summary>
    /// If this Energy Type can be used for determining the Type of Energy that an item can consume, this is the hash for the DestinyInvestmentStatDefinition that represents the stat which holds the Capacity for that energy type. (Note that this is optional because \"Any\" is a valid cost, but not valid for Capacity - an Armor must have a specific Energy Type for determining the energy type that the Armor is restricted to use)
    /// </summary>
    /// <value>If this Energy Type can be used for determining the Type of Energy that an item can consume, this is the hash for the DestinyInvestmentStatDefinition that represents the stat which holds the Capacity for that energy type. (Note that this is optional because \"Any\" is a valid cost, but not valid for Capacity - an Armor must have a specific Energy Type for determining the energy type that the Armor is restricted to use)</value>
    [DataMember(Name="capacityStatHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "capacityStatHash")]
    public int? CapacityStatHash { get; set; }

    /// <summary>
    /// If this Energy Type can be used as a cost to pay for socketing Armor 2.0 items, this is the hash for the DestinyInvestmentStatDefinition that stores the plug's raw cost.
    /// </summary>
    /// <value>If this Energy Type can be used as a cost to pay for socketing Armor 2.0 items, this is the hash for the DestinyInvestmentStatDefinition that stores the plug's raw cost.</value>
    [DataMember(Name="costStatHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "costStatHash")]
    public int? CostStatHash { get; set; }

    /// <summary>
    /// The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.
    /// </summary>
    /// <value>The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</value>
    [DataMember(Name="hash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hash")]
    public int? Hash { get; set; }

    /// <summary>
    /// The index of the entity as it was found in the investment tables.
    /// </summary>
    /// <value>The index of the entity as it was found in the investment tables.</value>
    [DataMember(Name="index", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "index")]
    public int? Index { get; set; }

    /// <summary>
    /// If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!
    /// </summary>
    /// <value>If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</value>
    [DataMember(Name="redacted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "redacted")]
    public bool? Redacted { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsEnergyTypesDestinyEnergyTypeDefinition {\n");
      sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
      sb.Append("  TransparentIconPath: ").Append(TransparentIconPath).Append("\n");
      sb.Append("  ShowIcon: ").Append(ShowIcon).Append("\n");
      sb.Append("  EnumValue: ").Append(EnumValue).Append("\n");
      sb.Append("  CapacityStatHash: ").Append(CapacityStatHash).Append("\n");
      sb.Append("  CostStatHash: ").Append(CostStatHash).Append("\n");
      sb.Append("  Hash: ").Append(Hash).Append("\n");
      sb.Append("  Index: ").Append(Index).Append("\n");
      sb.Append("  Redacted: ").Append(Redacted).Append("\n");
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
