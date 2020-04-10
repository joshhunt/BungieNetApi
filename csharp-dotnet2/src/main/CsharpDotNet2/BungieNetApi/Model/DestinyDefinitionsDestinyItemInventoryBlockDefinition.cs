using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// If the item can exist in an inventory - the overwhelming majority of them can and do - then this is the basic properties regarding the item&#39;s relationship with the inventory.
  /// </summary>
  [DataContract]
  public class DestinyDefinitionsDestinyItemInventoryBlockDefinition {
    /// <summary>
    /// If this string is populated, you can't have more than one stack with this label in a given inventory. Note that this is different from the equipping block's unique label, which is used for equipping uniqueness.
    /// </summary>
    /// <value>If this string is populated, you can't have more than one stack with this label in a given inventory. Note that this is different from the equipping block's unique label, which is used for equipping uniqueness.</value>
    [DataMember(Name="stackUniqueLabel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stackUniqueLabel")]
    public string StackUniqueLabel { get; set; }

    /// <summary>
    /// The maximum quantity of this item that can exist in a stack.
    /// </summary>
    /// <value>The maximum quantity of this item that can exist in a stack.</value>
    [DataMember(Name="maxStackSize", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maxStackSize")]
    public int? MaxStackSize { get; set; }

    /// <summary>
    /// The hash identifier for the DestinyInventoryBucketDefinition to which this item belongs. I should have named this \"bucketHash\", but too many things refer to it now. Sigh.
    /// </summary>
    /// <value>The hash identifier for the DestinyInventoryBucketDefinition to which this item belongs. I should have named this \"bucketHash\", but too many things refer to it now. Sigh.</value>
    [DataMember(Name="bucketTypeHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bucketTypeHash")]
    public int? BucketTypeHash { get; set; }

    /// <summary>
    /// If the item is picked up by the lost loot queue, this is the hash identifier for the DestinyInventoryBucketDefinition into which it will be placed. Again, I should have named this recoveryBucketHash instead.
    /// </summary>
    /// <value>If the item is picked up by the lost loot queue, this is the hash identifier for the DestinyInventoryBucketDefinition into which it will be placed. Again, I should have named this recoveryBucketHash instead.</value>
    [DataMember(Name="recoveryBucketTypeHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recoveryBucketTypeHash")]
    public int? RecoveryBucketTypeHash { get; set; }

    /// <summary>
    /// The hash identifier for the Tier Type of the item, use to look up its DestinyItemTierTypeDefinition if you need to show localized data for the item's tier.
    /// </summary>
    /// <value>The hash identifier for the Tier Type of the item, use to look up its DestinyItemTierTypeDefinition if you need to show localized data for the item's tier.</value>
    [DataMember(Name="tierTypeHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tierTypeHash")]
    public int? TierTypeHash { get; set; }

    /// <summary>
    /// If TRUE, this item is instanced. Otherwise, it is a generic item that merely has a quantity in a stack (like Glimmer).
    /// </summary>
    /// <value>If TRUE, this item is instanced. Otherwise, it is a generic item that merely has a quantity in a stack (like Glimmer).</value>
    [DataMember(Name="isInstanceItem", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isInstanceItem")]
    public bool? IsInstanceItem { get; set; }

    /// <summary>
    /// The localized name of the tier type, which is a useful shortcut so you don't have to look up the definition every time. However, it's mostly a holdover from days before we had a DestinyItemTierTypeDefinition to refer to.
    /// </summary>
    /// <value>The localized name of the tier type, which is a useful shortcut so you don't have to look up the definition every time. However, it's mostly a holdover from days before we had a DestinyItemTierTypeDefinition to refer to.</value>
    [DataMember(Name="tierTypeName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tierTypeName")]
    public string TierTypeName { get; set; }

    /// <summary>
    /// The enumeration matching the tier type of the item to known values, again for convenience sake.
    /// </summary>
    /// <value>The enumeration matching the tier type of the item to known values, again for convenience sake.</value>
    [DataMember(Name="tierType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tierType")]
    public int? TierType { get; set; }

    /// <summary>
    /// The tooltip message to show, if any, when the item expires.
    /// </summary>
    /// <value>The tooltip message to show, if any, when the item expires.</value>
    [DataMember(Name="expirationTooltip", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expirationTooltip")]
    public string ExpirationTooltip { get; set; }

    /// <summary>
    /// If the item expires while playing in an activity, we show a different message.
    /// </summary>
    /// <value>If the item expires while playing in an activity, we show a different message.</value>
    [DataMember(Name="expiredInActivityMessage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expiredInActivityMessage")]
    public string ExpiredInActivityMessage { get; set; }

    /// <summary>
    /// If the item expires in orbit, we show a... more different message. (\"Consummate V's, consummate!\")
    /// </summary>
    /// <value>If the item expires in orbit, we show a... more different message. (\"Consummate V's, consummate!\")</value>
    [DataMember(Name="expiredInOrbitMessage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expiredInOrbitMessage")]
    public string ExpiredInOrbitMessage { get; set; }

    /// <summary>
    /// Gets or Sets SuppressExpirationWhenObjectivesComplete
    /// </summary>
    [DataMember(Name="suppressExpirationWhenObjectivesComplete", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "suppressExpirationWhenObjectivesComplete")]
    public bool? SuppressExpirationWhenObjectivesComplete { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyDefinitionsDestinyItemInventoryBlockDefinition {\n");
      sb.Append("  StackUniqueLabel: ").Append(StackUniqueLabel).Append("\n");
      sb.Append("  MaxStackSize: ").Append(MaxStackSize).Append("\n");
      sb.Append("  BucketTypeHash: ").Append(BucketTypeHash).Append("\n");
      sb.Append("  RecoveryBucketTypeHash: ").Append(RecoveryBucketTypeHash).Append("\n");
      sb.Append("  TierTypeHash: ").Append(TierTypeHash).Append("\n");
      sb.Append("  IsInstanceItem: ").Append(IsInstanceItem).Append("\n");
      sb.Append("  TierTypeName: ").Append(TierTypeName).Append("\n");
      sb.Append("  TierType: ").Append(TierType).Append("\n");
      sb.Append("  ExpirationTooltip: ").Append(ExpirationTooltip).Append("\n");
      sb.Append("  ExpiredInActivityMessage: ").Append(ExpiredInActivityMessage).Append("\n");
      sb.Append("  ExpiredInOrbitMessage: ").Append(ExpiredInOrbitMessage).Append("\n");
      sb.Append("  SuppressExpirationWhenObjectivesComplete: ").Append(SuppressExpirationWhenObjectivesComplete).Append("\n");
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
