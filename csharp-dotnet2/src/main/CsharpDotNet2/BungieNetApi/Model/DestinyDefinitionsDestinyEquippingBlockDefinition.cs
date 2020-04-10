using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Items that can be equipped define this block. It contains information we need to understand how and when the item can be equipped.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyEquippingBlockDefinition {
    /// <summary>
    /// If the item is part of a gearset, this is a reference to that gearset item.
    /// </summary>
    /// <value>If the item is part of a gearset, this is a reference to that gearset item.</value>
    [DataMember(Name="gearsetItemHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gearsetItemHash")]
    public int? GearsetItemHash { get; set; }

    /// <summary>
    /// If defined, this is the label used to check if the item has other items of matching types already equipped.   For instance, when you aren't allowed to equip more than one Exotic Weapon, that's because all exotic weapons have identical uniqueLabels and the game checks the to-be-equipped item's uniqueLabel vs. all other already equipped items (other than the item in the slot that's about to be occupied).
    /// </summary>
    /// <value>If defined, this is the label used to check if the item has other items of matching types already equipped.   For instance, when you aren't allowed to equip more than one Exotic Weapon, that's because all exotic weapons have identical uniqueLabels and the game checks the to-be-equipped item's uniqueLabel vs. all other already equipped items (other than the item in the slot that's about to be occupied).</value>
    [DataMember(Name="uniqueLabel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uniqueLabel")]
    public string UniqueLabel { get; set; }

    /// <summary>
    /// The hash of that unique label. Does not point to a specific definition.
    /// </summary>
    /// <value>The hash of that unique label. Does not point to a specific definition.</value>
    [DataMember(Name="uniqueLabelHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uniqueLabelHash")]
    public int? UniqueLabelHash { get; set; }

    /// <summary>
    /// An equipped item *must* be equipped in an Equipment Slot. This is the hash identifier of the DestinyEquipmentSlotDefinition into which it must be equipped.
    /// </summary>
    /// <value>An equipped item *must* be equipped in an Equipment Slot. This is the hash identifier of the DestinyEquipmentSlotDefinition into which it must be equipped.</value>
    [DataMember(Name="equipmentSlotTypeHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "equipmentSlotTypeHash")]
    public int? EquipmentSlotTypeHash { get; set; }

    /// <summary>
    /// These are custom attributes on the equippability of the item.  For now, this can only be \"equip on acquire\", which would mean that the item will be automatically equipped as soon as you pick it up.
    /// </summary>
    /// <value>These are custom attributes on the equippability of the item.  For now, this can only be \"equip on acquire\", which would mean that the item will be automatically equipped as soon as you pick it up.</value>
    [DataMember(Name="attributes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attributes")]
    public int? Attributes { get; set; }

    /// <summary>
    /// Ammo type used by a weapon is no longer determined by the bucket in which it is contained. If the item has an ammo type - i.e. if it is a weapon - this will be the type of ammunition expected.
    /// </summary>
    /// <value>Ammo type used by a weapon is no longer determined by the bucket in which it is contained. If the item has an ammo type - i.e. if it is a weapon - this will be the type of ammunition expected.</value>
    [DataMember(Name="ammoType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ammoType")]
    public int? AmmoType { get; set; }

    /// <summary>
    /// These are strings that represent the possible Game/Account/Character state failure conditions that can occur when trying to equip the item. They match up one-to-one with requiredUnlockExpressions.
    /// </summary>
    /// <value>These are strings that represent the possible Game/Account/Character state failure conditions that can occur when trying to equip the item. They match up one-to-one with requiredUnlockExpressions.</value>
    [DataMember(Name="displayStrings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayStrings")]
    public List<string> DisplayStrings { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyEquippingBlockDefinition {\n");
      sb.Append("  GearsetItemHash: ").Append(GearsetItemHash).Append("\n");
      sb.Append("  UniqueLabel: ").Append(UniqueLabel).Append("\n");
      sb.Append("  UniqueLabelHash: ").Append(UniqueLabelHash).Append("\n");
      sb.Append("  EquipmentSlotTypeHash: ").Append(EquipmentSlotTypeHash).Append("\n");
      sb.Append("  Attributes: ").Append(Attributes).Append("\n");
      sb.Append("  AmmoType: ").Append(AmmoType).Append("\n");
      sb.Append("  DisplayStrings: ").Append(DisplayStrings).Append("\n");
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
