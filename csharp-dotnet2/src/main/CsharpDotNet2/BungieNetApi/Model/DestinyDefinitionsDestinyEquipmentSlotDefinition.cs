using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Characters can not only have Inventory buckets (containers of items that are generally matched by their type or functionality), they can also have Equipment Slots.  The Equipment Slot is an indicator that the related bucket can have instanced items equipped on the character. For instance, the Primary Weapon bucket has an Equipment Slot that determines whether you can equip primary weapons, and holds the association between its slot and the inventory bucket from which it can have items equipped.  An Equipment Slot must have a related Inventory Bucket, but not all inventory buckets must have Equipment Slots.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyEquipmentSlotDefinition {
    /// <summary>
    /// Gets or Sets DisplayProperties
    /// </summary>
    [DataMember(Name="displayProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayProperties")]
    public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

    /// <summary>
    /// These technically point to \"Equipment Category Definitions\". But don't get excited. There's nothing of significant value in those definitions, so I didn't bother to expose them. You can use the hash here to group equipment slots by common functionality, which serves the same purpose as if we had the Equipment Category definitions exposed.
    /// </summary>
    /// <value>These technically point to \"Equipment Category Definitions\". But don't get excited. There's nothing of significant value in those definitions, so I didn't bother to expose them. You can use the hash here to group equipment slots by common functionality, which serves the same purpose as if we had the Equipment Category definitions exposed.</value>
    [DataMember(Name="equipmentCategoryHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "equipmentCategoryHash")]
    public int? EquipmentCategoryHash { get; set; }

    /// <summary>
    /// The inventory bucket that owns this equipment slot.
    /// </summary>
    /// <value>The inventory bucket that owns this equipment slot.</value>
    [DataMember(Name="bucketTypeHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bucketTypeHash")]
    public int? BucketTypeHash { get; set; }

    /// <summary>
    /// If True, equipped items should have their custom art dyes applied when rendering the item. Otherwise, custom art dyes on an item should be ignored if the item is equipped in this slot.
    /// </summary>
    /// <value>If True, equipped items should have their custom art dyes applied when rendering the item. Otherwise, custom art dyes on an item should be ignored if the item is equipped in this slot.</value>
    [DataMember(Name="applyCustomArtDyes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "applyCustomArtDyes")]
    public bool? ApplyCustomArtDyes { get; set; }

    /// <summary>
    /// The Art Dye Channels that apply to this equipment slot.
    /// </summary>
    /// <value>The Art Dye Channels that apply to this equipment slot.</value>
    [DataMember(Name="artDyeChannels", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "artDyeChannels")]
    public List<DestinyDefinitionsDestinyArtDyeReference> ArtDyeChannels { get; set; }

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
      sb.Append("class DestinyDefinitionsDestinyEquipmentSlotDefinition {\n");
      sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
      sb.Append("  EquipmentCategoryHash: ").Append(EquipmentCategoryHash).Append("\n");
      sb.Append("  BucketTypeHash: ").Append(BucketTypeHash).Append("\n");
      sb.Append("  ApplyCustomArtDyes: ").Append(ApplyCustomArtDyes).Append("\n");
      sb.Append("  ArtDyeChannels: ").Append(ArtDyeChannels).Append("\n");
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
