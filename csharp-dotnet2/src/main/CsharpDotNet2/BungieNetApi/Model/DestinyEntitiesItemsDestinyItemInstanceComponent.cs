using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// If an item is \&quot;instanced\&quot;, this will contain information about the item&#39;s instance that doesn&#39;t fit easily into other components. One might say this is the \&quot;essential\&quot; instance data for the item.  Items are instanced if they require information or state that can vary. For instance, weapons are Instanced: they are given a unique identifier, uniquely generated stats, and can have their properties altered. Non-instanced items have none of these things: for instance, Glimmer has no unique properties aside from how much of it you own.  You can tell from an item&#39;s definition whether it will be instanced or not by looking at the DestinyInventoryItemDefinition&#39;s definition.inventory.isInstanceItem property.
  /// </summary>
  [DataContract]
  public class DestinyEntitiesItemsDestinyItemInstanceComponent {
    /// <summary>
    /// If the item has a damage type, this is the item's current damage type.
    /// </summary>
    /// <value>If the item has a damage type, this is the item's current damage type.</value>
    [DataMember(Name="damageType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damageType")]
    public int? DamageType { get; set; }

    /// <summary>
    /// The current damage type's hash, so you can look up localized info and icons for it.
    /// </summary>
    /// <value>The current damage type's hash, so you can look up localized info and icons for it.</value>
    [DataMember(Name="damageTypeHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damageTypeHash")]
    public int? DamageTypeHash { get; set; }

    /// <summary>
    /// The item stat that we consider to be \"primary\" for the item. For instance, this would be \"Attack\" for Weapons or \"Defense\" for armor.
    /// </summary>
    /// <value>The item stat that we consider to be \"primary\" for the item. For instance, this would be \"Attack\" for Weapons or \"Defense\" for armor.</value>
    [DataMember(Name="primaryStat", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "primaryStat")]
    public DestinyDestinyStat PrimaryStat { get; set; }

    /// <summary>
    /// The Item's \"Level\" has the most significant bearing on its stats, such as Light and Power.
    /// </summary>
    /// <value>The Item's \"Level\" has the most significant bearing on its stats, such as Light and Power.</value>
    [DataMember(Name="itemLevel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemLevel")]
    public int? ItemLevel { get; set; }

    /// <summary>
    /// The \"Quality\" of the item has a lesser - but still impactful - bearing on stats like Light and Power.
    /// </summary>
    /// <value>The \"Quality\" of the item has a lesser - but still impactful - bearing on stats like Light and Power.</value>
    [DataMember(Name="quality", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quality")]
    public int? Quality { get; set; }

    /// <summary>
    /// Is the item currently equipped on the given character?
    /// </summary>
    /// <value>Is the item currently equipped on the given character?</value>
    [DataMember(Name="isEquipped", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isEquipped")]
    public bool? IsEquipped { get; set; }

    /// <summary>
    /// If this is an equippable item, you can check it here. There are permanent as well as transitory reasons why an item might not be able to be equipped: check cannotEquipReason for details.
    /// </summary>
    /// <value>If this is an equippable item, you can check it here. There are permanent as well as transitory reasons why an item might not be able to be equipped: check cannotEquipReason for details.</value>
    [DataMember(Name="canEquip", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "canEquip")]
    public bool? CanEquip { get; set; }

    /// <summary>
    /// If the item cannot be equipped until you reach a certain level, that level will be reflected here.
    /// </summary>
    /// <value>If the item cannot be equipped until you reach a certain level, that level will be reflected here.</value>
    [DataMember(Name="equipRequiredLevel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "equipRequiredLevel")]
    public int? EquipRequiredLevel { get; set; }

    /// <summary>
    /// Sometimes, there are limitations to equipping that are represented by character-level flags called \"unlocks\".  This is a list of flags that they need in order to equip the item that the character has not met. Use these to look up the descriptions to show in your UI by looking up the relevant DestinyUnlockDefinitions for the hashes.
    /// </summary>
    /// <value>Sometimes, there are limitations to equipping that are represented by character-level flags called \"unlocks\".  This is a list of flags that they need in order to equip the item that the character has not met. Use these to look up the descriptions to show in your UI by looking up the relevant DestinyUnlockDefinitions for the hashes.</value>
    [DataMember(Name="unlockHashesRequiredToEquip", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unlockHashesRequiredToEquip")]
    public List<int?> UnlockHashesRequiredToEquip { get; set; }

    /// <summary>
    /// If you cannot equip the item, this is a flags enum that enumerates all of the reasons why you couldn't equip the item. You may need to refine your UI further by using unlockHashesRequiredToEquip and equipRequiredLevel.
    /// </summary>
    /// <value>If you cannot equip the item, this is a flags enum that enumerates all of the reasons why you couldn't equip the item. You may need to refine your UI further by using unlockHashesRequiredToEquip and equipRequiredLevel.</value>
    [DataMember(Name="cannotEquipReason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cannotEquipReason")]
    public int? CannotEquipReason { get; set; }

    /// <summary>
    /// If populated, this item has a breaker type corresponding to the given value. See DestinyBreakerTypeDefinition for more details.
    /// </summary>
    /// <value>If populated, this item has a breaker type corresponding to the given value. See DestinyBreakerTypeDefinition for more details.</value>
    [DataMember(Name="breakerType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "breakerType")]
    public int? BreakerType { get; set; }

    /// <summary>
    /// If populated, this is the hash identifier for the item's breaker type. See DestinyBreakerTypeDefinition for more details.
    /// </summary>
    /// <value>If populated, this is the hash identifier for the item's breaker type. See DestinyBreakerTypeDefinition for more details.</value>
    [DataMember(Name="breakerTypeHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "breakerTypeHash")]
    public int? BreakerTypeHash { get; set; }

    /// <summary>
    /// IF populated, this item supports Energy mechanics (i.e. Armor 2.0), and these are the current details of its energy type and available capacity to spend energy points.
    /// </summary>
    /// <value>IF populated, this item supports Energy mechanics (i.e. Armor 2.0), and these are the current details of its energy type and available capacity to spend energy points.</value>
    [DataMember(Name="energy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "energy")]
    public DestinyEntitiesItemsDestinyItemInstanceEnergy Energy { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyEntitiesItemsDestinyItemInstanceComponent {\n");
      sb.Append("  DamageType: ").Append(DamageType).Append("\n");
      sb.Append("  DamageTypeHash: ").Append(DamageTypeHash).Append("\n");
      sb.Append("  PrimaryStat: ").Append(PrimaryStat).Append("\n");
      sb.Append("  ItemLevel: ").Append(ItemLevel).Append("\n");
      sb.Append("  Quality: ").Append(Quality).Append("\n");
      sb.Append("  IsEquipped: ").Append(IsEquipped).Append("\n");
      sb.Append("  CanEquip: ").Append(CanEquip).Append("\n");
      sb.Append("  EquipRequiredLevel: ").Append(EquipRequiredLevel).Append("\n");
      sb.Append("  UnlockHashesRequiredToEquip: ").Append(UnlockHashesRequiredToEquip).Append("\n");
      sb.Append("  CannotEquipReason: ").Append(CannotEquipReason).Append("\n");
      sb.Append("  BreakerType: ").Append(BreakerType).Append("\n");
      sb.Append("  BreakerTypeHash: ").Append(BreakerTypeHash).Append("\n");
      sb.Append("  Energy: ").Append(Energy).Append("\n");
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
