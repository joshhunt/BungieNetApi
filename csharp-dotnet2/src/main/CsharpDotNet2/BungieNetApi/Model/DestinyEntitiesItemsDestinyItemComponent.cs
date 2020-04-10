using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// The base item component, filled with properties that are generally useful to know in any item request or that don&#39;t feel worthwhile to put in their own component.
  /// </summary>
  [DataContract]
  public class DestinyEntitiesItemsDestinyItemComponent {
    /// <summary>
    /// The identifier for the item's definition, which is where most of the useful static information for the item can be found.
    /// </summary>
    /// <value>The identifier for the item's definition, which is where most of the useful static information for the item can be found.</value>
    [DataMember(Name="itemHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemHash")]
    public int? ItemHash { get; set; }

    /// <summary>
    /// If the item is instanced, it will have an instance ID. Lack of an instance ID implies that the item has no distinct local qualities aside from stack size.
    /// </summary>
    /// <value>If the item is instanced, it will have an instance ID. Lack of an instance ID implies that the item has no distinct local qualities aside from stack size.</value>
    [DataMember(Name="itemInstanceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemInstanceId")]
    public long? ItemInstanceId { get; set; }

    /// <summary>
    /// The quantity of the item in this stack. Note that Instanced items cannot stack. If an instanced item, this value will always be 1 (as the stack has exactly one item in it)
    /// </summary>
    /// <value>The quantity of the item in this stack. Note that Instanced items cannot stack. If an instanced item, this value will always be 1 (as the stack has exactly one item in it)</value>
    [DataMember(Name="quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity")]
    public int? Quantity { get; set; }

    /// <summary>
    /// If the item is bound to a location, it will be specified in this enum.
    /// </summary>
    /// <value>If the item is bound to a location, it will be specified in this enum.</value>
    [DataMember(Name="bindStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bindStatus")]
    public int? BindStatus { get; set; }

    /// <summary>
    /// An easy reference for where the item is located. Redundant if you got the item from an Inventory, but useful when making detail calls on specific items.
    /// </summary>
    /// <value>An easy reference for where the item is located. Redundant if you got the item from an Inventory, but useful when making detail calls on specific items.</value>
    [DataMember(Name="location", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location")]
    public int? Location { get; set; }

    /// <summary>
    /// The hash identifier for the specific inventory bucket in which the item is located.
    /// </summary>
    /// <value>The hash identifier for the specific inventory bucket in which the item is located.</value>
    [DataMember(Name="bucketHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bucketHash")]
    public int? BucketHash { get; set; }

    /// <summary>
    /// If there is a known error state that would cause this item to not be transferable, this Flags enum will indicate all of those error states. Otherwise, it will be 0 (CanTransfer).
    /// </summary>
    /// <value>If there is a known error state that would cause this item to not be transferable, this Flags enum will indicate all of those error states. Otherwise, it will be 0 (CanTransfer).</value>
    [DataMember(Name="transferStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transferStatus")]
    public int? TransferStatus { get; set; }

    /// <summary>
    /// If the item can be locked, this will indicate that state.
    /// </summary>
    /// <value>If the item can be locked, this will indicate that state.</value>
    [DataMember(Name="lockable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lockable")]
    public bool? Lockable { get; set; }

    /// <summary>
    /// A flags enumeration indicating the transient/custom states of the item that affect how it is rendered: whether it's tracked or locked for example, or whether it has a masterwork plug inserted.
    /// </summary>
    /// <value>A flags enumeration indicating the transient/custom states of the item that affect how it is rendered: whether it's tracked or locked for example, or whether it has a masterwork plug inserted.</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public int? State { get; set; }

    /// <summary>
    /// If populated, this is the hash of the item whose icon (and other secondary styles, but *not* the human readable strings) should override whatever icons/styles are on the item being sold.  If you don't do this, certain items whose styles are being overridden by socketed items - such as the \"Recycle Shader\" item - would show whatever their default icon/style is, and it wouldn't be pretty or look accurate.
    /// </summary>
    /// <value>If populated, this is the hash of the item whose icon (and other secondary styles, but *not* the human readable strings) should override whatever icons/styles are on the item being sold.  If you don't do this, certain items whose styles are being overridden by socketed items - such as the \"Recycle Shader\" item - would show whatever their default icon/style is, and it wouldn't be pretty or look accurate.</value>
    [DataMember(Name="overrideStyleItemHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "overrideStyleItemHash")]
    public int? OverrideStyleItemHash { get; set; }

    /// <summary>
    /// If the item can expire, this is the date at which it will/did expire.
    /// </summary>
    /// <value>If the item can expire, this is the date at which it will/did expire.</value>
    [DataMember(Name="expirationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expirationDate")]
    public DateTime? ExpirationDate { get; set; }

    /// <summary>
    /// If this is true, the object is actually a \"wrapper\" of the object it's representing. This means that it's not the actual item itself, but rather an item that must be \"opened\" in game before you have and can use the item.   Wrappers are an evolution of \"bundles\", which give an easy way to let you preview the contents of what you purchased while still letting you get a refund before you \"open\" it.
    /// </summary>
    /// <value>If this is true, the object is actually a \"wrapper\" of the object it's representing. This means that it's not the actual item itself, but rather an item that must be \"opened\" in game before you have and can use the item.   Wrappers are an evolution of \"bundles\", which give an easy way to let you preview the contents of what you purchased while still letting you get a refund before you \"open\" it.</value>
    [DataMember(Name="isWrapper", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isWrapper")]
    public bool? IsWrapper { get; set; }

    /// <summary>
    /// If this is populated, it is a list of indexes into DestinyInventoryItemDefinition.tooltipNotifications for any special tooltip messages that need to be shown for this item.
    /// </summary>
    /// <value>If this is populated, it is a list of indexes into DestinyInventoryItemDefinition.tooltipNotifications for any special tooltip messages that need to be shown for this item.</value>
    [DataMember(Name="tooltipNotificationIndexes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tooltipNotificationIndexes")]
    public List<int?> TooltipNotificationIndexes { get; set; }

    /// <summary>
    /// The identifier for the currently-selected metric definition, to be displayed on the emblem nameplate.
    /// </summary>
    /// <value>The identifier for the currently-selected metric definition, to be displayed on the emblem nameplate.</value>
    [DataMember(Name="metricHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "metricHash")]
    public int? MetricHash { get; set; }

    /// <summary>
    /// The objective progress for the currently-selected metric definition, to be displayed on the emblem nameplate.
    /// </summary>
    /// <value>The objective progress for the currently-selected metric definition, to be displayed on the emblem nameplate.</value>
    [DataMember(Name="metricObjective", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "metricObjective")]
    public DestinyQuestsDestinyObjectiveProgress MetricObjective { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyEntitiesItemsDestinyItemComponent {\n");
      sb.Append("  ItemHash: ").Append(ItemHash).Append("\n");
      sb.Append("  ItemInstanceId: ").Append(ItemInstanceId).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
      sb.Append("  BindStatus: ").Append(BindStatus).Append("\n");
      sb.Append("  Location: ").Append(Location).Append("\n");
      sb.Append("  BucketHash: ").Append(BucketHash).Append("\n");
      sb.Append("  TransferStatus: ").Append(TransferStatus).Append("\n");
      sb.Append("  Lockable: ").Append(Lockable).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  OverrideStyleItemHash: ").Append(OverrideStyleItemHash).Append("\n");
      sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
      sb.Append("  IsWrapper: ").Append(IsWrapper).Append("\n");
      sb.Append("  TooltipNotificationIndexes: ").Append(TooltipNotificationIndexes).Append("\n");
      sb.Append("  MetricHash: ").Append(MetricHash).Append("\n");
      sb.Append("  MetricObjective: ").Append(MetricObjective).Append("\n");
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
