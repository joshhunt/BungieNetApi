using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BungieNetApi.Model {

  /// <summary>
  /// Request this component if you want the details about an item being sold in relation to the character making the request: whether the character can buy it, whether they can afford it, and other data related to purchasing the item.  Note that if you want instance, stats, etc... data for the item, you&#39;ll have to request additional components such as ItemInstances, ItemPerks etc... and acquire them from the DestinyVendorResponse&#39;s \&quot;items\&quot; property.
  /// </summary>
  [DataContract]
  public class DestinyEntitiesVendorsDestinyVendorSaleItemComponent {
    /// <summary>
    /// A flag indicating whether the requesting character can buy the item, and if not the reasons why the character can't buy it.
    /// </summary>
    /// <value>A flag indicating whether the requesting character can buy the item, and if not the reasons why the character can't buy it.</value>
    [DataMember(Name="saleStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "saleStatus")]
    public int? SaleStatus { get; set; }

    /// <summary>
    /// If you can't buy the item due to a complex character state, these will be hashes for DestinyUnlockDefinitions that you can check to see messages regarding the failure (if the unlocks have human readable information: it is not guaranteed that Unlocks will have human readable strings, and your application will have to handle that)  Prefer using failureIndexes instead. These are provided for informational purposes, but have largely been supplanted by failureIndexes.
    /// </summary>
    /// <value>If you can't buy the item due to a complex character state, these will be hashes for DestinyUnlockDefinitions that you can check to see messages regarding the failure (if the unlocks have human readable information: it is not guaranteed that Unlocks will have human readable strings, and your application will have to handle that)  Prefer using failureIndexes instead. These are provided for informational purposes, but have largely been supplanted by failureIndexes.</value>
    [DataMember(Name="requiredUnlocks", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requiredUnlocks")]
    public List<int?> RequiredUnlocks { get; set; }

    /// <summary>
    /// If any complex unlock states are checked in determining purchasability, these will be returned here along with the status of the unlock check.  Prefer using failureIndexes instead. These are provided for informational purposes, but have largely been supplanted by failureIndexes.
    /// </summary>
    /// <value>If any complex unlock states are checked in determining purchasability, these will be returned here along with the status of the unlock check.  Prefer using failureIndexes instead. These are provided for informational purposes, but have largely been supplanted by failureIndexes.</value>
    [DataMember(Name="unlockStatuses", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unlockStatuses")]
    public List<DestinyDestinyUnlockStatus> UnlockStatuses { get; set; }

    /// <summary>
    /// Indexes in to the \"failureStrings\" lookup table in DestinyVendorDefinition for the given Vendor. Gives some more reliable failure information for why you can't purchase an item.  It is preferred to use these over requiredUnlocks and unlockStatuses: the latter are provided mostly in case someone can do something interesting with it that I didn't anticipate.
    /// </summary>
    /// <value>Indexes in to the \"failureStrings\" lookup table in DestinyVendorDefinition for the given Vendor. Gives some more reliable failure information for why you can't purchase an item.  It is preferred to use these over requiredUnlocks and unlockStatuses: the latter are provided mostly in case someone can do something interesting with it that I didn't anticipate.</value>
    [DataMember(Name="failureIndexes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "failureIndexes")]
    public List<int?> FailureIndexes { get; set; }

    /// <summary>
    /// A flags enumeration value representing the current state of any \"state modifiers\" on the item being sold. These are meant to correspond with some sort of visual indicator as to the augmentation: for instance, if an item is on sale or if you already own the item in question.  Determining how you want to represent these in your own app (or if you even want to) is an exercise left for the reader.
    /// </summary>
    /// <value>A flags enumeration value representing the current state of any \"state modifiers\" on the item being sold. These are meant to correspond with some sort of visual indicator as to the augmentation: for instance, if an item is on sale or if you already own the item in question.  Determining how you want to represent these in your own app (or if you even want to) is an exercise left for the reader.</value>
    [DataMember(Name="augments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "augments")]
    public int? Augments { get; set; }

    /// <summary>
    /// The index into the DestinyVendorDefinition.itemList property. Note that this means Vendor data *is* Content Version dependent: make sure you have the latest content before you use Vendor data, or these indexes may mismatch.   Most systems avoid this problem, but Vendors is one area where we are unable to reasonably avoid content dependency at the moment.
    /// </summary>
    /// <value>The index into the DestinyVendorDefinition.itemList property. Note that this means Vendor data *is* Content Version dependent: make sure you have the latest content before you use Vendor data, or these indexes may mismatch.   Most systems avoid this problem, but Vendors is one area where we are unable to reasonably avoid content dependency at the moment.</value>
    [DataMember(Name="vendorItemIndex", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vendorItemIndex")]
    public int? VendorItemIndex { get; set; }

    /// <summary>
    /// The hash of the item being sold, as a quick shortcut for looking up the DestinyInventoryItemDefinition of the sale item.
    /// </summary>
    /// <value>The hash of the item being sold, as a quick shortcut for looking up the DestinyInventoryItemDefinition of the sale item.</value>
    [DataMember(Name="itemHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemHash")]
    public int? ItemHash { get; set; }

    /// <summary>
    /// If populated, this is the hash of the item whose icon (and other secondary styles, but *not* the human readable strings) should override whatever icons/styles are on the item being sold.  If you don't do this, certain items whose styles are being overridden by socketed items - such as the \"Recycle Shader\" item - would show whatever their default icon/style is, and it wouldn't be pretty or look accurate.
    /// </summary>
    /// <value>If populated, this is the hash of the item whose icon (and other secondary styles, but *not* the human readable strings) should override whatever icons/styles are on the item being sold.  If you don't do this, certain items whose styles are being overridden by socketed items - such as the \"Recycle Shader\" item - would show whatever their default icon/style is, and it wouldn't be pretty or look accurate.</value>
    [DataMember(Name="overrideStyleItemHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "overrideStyleItemHash")]
    public int? OverrideStyleItemHash { get; set; }

    /// <summary>
    /// How much of the item you'll be getting.
    /// </summary>
    /// <value>How much of the item you'll be getting.</value>
    [DataMember(Name="quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity")]
    public int? Quantity { get; set; }

    /// <summary>
    /// A summary of the current costs of the item.
    /// </summary>
    /// <value>A summary of the current costs of the item.</value>
    [DataMember(Name="costs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "costs")]
    public List<DestinyDestinyItemQuantity> Costs { get; set; }

    /// <summary>
    /// If this item has its own custom date where it may be removed from the Vendor's rotation, this is that date.  Note that there's not actually any guarantee that it will go away: it could be chosen again and end up still being in the Vendor's sale items! But this is the next date where that test will occur, and is also the date that the game shows for availability on things like Bounties being sold. So it's the best we can give.
    /// </summary>
    /// <value>If this item has its own custom date where it may be removed from the Vendor's rotation, this is that date.  Note that there's not actually any guarantee that it will go away: it could be chosen again and end up still being in the Vendor's sale items! But this is the next date where that test will occur, and is also the date that the game shows for availability on things like Bounties being sold. So it's the best we can give.</value>
    [DataMember(Name="overrideNextRefreshDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "overrideNextRefreshDate")]
    public DateTime? OverrideNextRefreshDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinyEntitiesVendorsDestinyVendorSaleItemComponent {\n");
      sb.Append("  SaleStatus: ").Append(SaleStatus).Append("\n");
      sb.Append("  RequiredUnlocks: ").Append(RequiredUnlocks).Append("\n");
      sb.Append("  UnlockStatuses: ").Append(UnlockStatuses).Append("\n");
      sb.Append("  FailureIndexes: ").Append(FailureIndexes).Append("\n");
      sb.Append("  Augments: ").Append(Augments).Append("\n");
      sb.Append("  VendorItemIndex: ").Append(VendorItemIndex).Append("\n");
      sb.Append("  ItemHash: ").Append(ItemHash).Append("\n");
      sb.Append("  OverrideStyleItemHash: ").Append(OverrideStyleItemHash).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
      sb.Append("  Costs: ").Append(Costs).Append("\n");
      sb.Append("  OverrideNextRefreshDate: ").Append(OverrideNextRefreshDate).Append("\n");
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
