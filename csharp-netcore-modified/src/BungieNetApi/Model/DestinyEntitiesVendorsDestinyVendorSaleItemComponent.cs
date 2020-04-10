/* 
 * Bungie.Net API
 *
 * These endpoints constitute the functionality exposed by Bungie.net, both for more traditional website functionality and for connectivity to Bungie video games and their related functionality.
 *
 * The version of the OpenAPI document: 2.8.0
 * Contact: support@bungie.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = BungieNetApi.Client.OpenAPIDateConverter;

namespace BungieNetApi.Model
{
    /// <summary>
    /// Request this component if you want the details about an item being sold in relation to the character making the request: whether the character can buy it, whether they can afford it, and other data related to purchasing the item.  Note that if you want instance, stats, etc... data for the item, you&#39;ll have to request additional components such as ItemInstances, ItemPerks etc... and acquire them from the DestinyVendorResponse&#39;s \&quot;items\&quot; property.
    /// </summary>
    [DataContract]
    public partial class DestinyEntitiesVendorsDestinyVendorSaleItemComponent :  IEquatable<DestinyEntitiesVendorsDestinyVendorSaleItemComponent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyEntitiesVendorsDestinyVendorSaleItemComponent" /> class.
        /// </summary>
        /// <param name="saleStatus">A flag indicating whether the requesting character can buy the item, and if not the reasons why the character can&#39;t buy it..</param>
        /// <param name="requiredUnlocks">If you can&#39;t buy the item due to a complex character state, these will be hashes for DestinyUnlockDefinitions that you can check to see messages regarding the failure (if the unlocks have human readable information: it is not guaranteed that Unlocks will have human readable strings, and your application will have to handle that)  Prefer using failureIndexes instead. These are provided for informational purposes, but have largely been supplanted by failureIndexes..</param>
        /// <param name="unlockStatuses">If any complex unlock states are checked in determining purchasability, these will be returned here along with the status of the unlock check.  Prefer using failureIndexes instead. These are provided for informational purposes, but have largely been supplanted by failureIndexes..</param>
        /// <param name="failureIndexes">Indexes in to the \&quot;failureStrings\&quot; lookup table in DestinyVendorDefinition for the given Vendor. Gives some more reliable failure information for why you can&#39;t purchase an item.  It is preferred to use these over requiredUnlocks and unlockStatuses: the latter are provided mostly in case someone can do something interesting with it that I didn&#39;t anticipate..</param>
        /// <param name="augments">A flags enumeration value representing the current state of any \&quot;state modifiers\&quot; on the item being sold. These are meant to correspond with some sort of visual indicator as to the augmentation: for instance, if an item is on sale or if you already own the item in question.  Determining how you want to represent these in your own app (or if you even want to) is an exercise left for the reader..</param>
        /// <param name="vendorItemIndex">The index into the DestinyVendorDefinition.itemList property. Note that this means Vendor data *is* Content Version dependent: make sure you have the latest content before you use Vendor data, or these indexes may mismatch.   Most systems avoid this problem, but Vendors is one area where we are unable to reasonably avoid content dependency at the moment..</param>
        /// <param name="itemHash">The hash of the item being sold, as a quick shortcut for looking up the DestinyInventoryItemDefinition of the sale item..</param>
        /// <param name="overrideStyleItemHash">If populated, this is the hash of the item whose icon (and other secondary styles, but *not* the human readable strings) should override whatever icons/styles are on the item being sold.  If you don&#39;t do this, certain items whose styles are being overridden by socketed items - such as the \&quot;Recycle Shader\&quot; item - would show whatever their default icon/style is, and it wouldn&#39;t be pretty or look accurate..</param>
        /// <param name="quantity">How much of the item you&#39;ll be getting..</param>
        /// <param name="costs">A summary of the current costs of the item..</param>
        /// <param name="overrideNextRefreshDate">If this item has its own custom date where it may be removed from the Vendor&#39;s rotation, this is that date.  Note that there&#39;s not actually any guarantee that it will go away: it could be chosen again and end up still being in the Vendor&#39;s sale items! But this is the next date where that test will occur, and is also the date that the game shows for availability on things like Bounties being sold. So it&#39;s the best we can give..</param>
        public DestinyEntitiesVendorsDestinyVendorSaleItemComponent(int saleStatus = default(int), List<long> requiredUnlocks = default(List<long>), List<DestinyDestinyUnlockStatus> unlockStatuses = default(List<DestinyDestinyUnlockStatus>), List<int> failureIndexes = default(List<int>), int augments = default(int), int vendorItemIndex = default(int), long itemHash = default(long), long overrideStyleItemHash = default(long), int quantity = default(int), List<DestinyDestinyItemQuantity> costs = default(List<DestinyDestinyItemQuantity>), DateTime overrideNextRefreshDate = default(DateTime))
        {
            this.SaleStatus = saleStatus;
            this.RequiredUnlocks = requiredUnlocks;
            this.UnlockStatuses = unlockStatuses;
            this.FailureIndexes = failureIndexes;
            this.Augments = augments;
            this.VendorItemIndex = vendorItemIndex;
            this.ItemHash = itemHash;
            this.OverrideStyleItemHash = overrideStyleItemHash;
            this.Quantity = quantity;
            this.Costs = costs;
            this.OverrideNextRefreshDate = overrideNextRefreshDate;
        }
        
        /// <summary>
        /// A flag indicating whether the requesting character can buy the item, and if not the reasons why the character can&#39;t buy it.
        /// </summary>
        /// <value>A flag indicating whether the requesting character can buy the item, and if not the reasons why the character can&#39;t buy it.</value>
        [DataMember(Name="saleStatus", EmitDefaultValue=false)]
        public int SaleStatus { get; set; }

        /// <summary>
        /// If you can&#39;t buy the item due to a complex character state, these will be hashes for DestinyUnlockDefinitions that you can check to see messages regarding the failure (if the unlocks have human readable information: it is not guaranteed that Unlocks will have human readable strings, and your application will have to handle that)  Prefer using failureIndexes instead. These are provided for informational purposes, but have largely been supplanted by failureIndexes.
        /// </summary>
        /// <value>If you can&#39;t buy the item due to a complex character state, these will be hashes for DestinyUnlockDefinitions that you can check to see messages regarding the failure (if the unlocks have human readable information: it is not guaranteed that Unlocks will have human readable strings, and your application will have to handle that)  Prefer using failureIndexes instead. These are provided for informational purposes, but have largely been supplanted by failureIndexes.</value>
        [DataMember(Name="requiredUnlocks", EmitDefaultValue=false)]
        public List<long> RequiredUnlocks { get; set; }

        /// <summary>
        /// If any complex unlock states are checked in determining purchasability, these will be returned here along with the status of the unlock check.  Prefer using failureIndexes instead. These are provided for informational purposes, but have largely been supplanted by failureIndexes.
        /// </summary>
        /// <value>If any complex unlock states are checked in determining purchasability, these will be returned here along with the status of the unlock check.  Prefer using failureIndexes instead. These are provided for informational purposes, but have largely been supplanted by failureIndexes.</value>
        [DataMember(Name="unlockStatuses", EmitDefaultValue=false)]
        public List<DestinyDestinyUnlockStatus> UnlockStatuses { get; set; }

        /// <summary>
        /// Indexes in to the \&quot;failureStrings\&quot; lookup table in DestinyVendorDefinition for the given Vendor. Gives some more reliable failure information for why you can&#39;t purchase an item.  It is preferred to use these over requiredUnlocks and unlockStatuses: the latter are provided mostly in case someone can do something interesting with it that I didn&#39;t anticipate.
        /// </summary>
        /// <value>Indexes in to the \&quot;failureStrings\&quot; lookup table in DestinyVendorDefinition for the given Vendor. Gives some more reliable failure information for why you can&#39;t purchase an item.  It is preferred to use these over requiredUnlocks and unlockStatuses: the latter are provided mostly in case someone can do something interesting with it that I didn&#39;t anticipate.</value>
        [DataMember(Name="failureIndexes", EmitDefaultValue=false)]
        public List<int> FailureIndexes { get; set; }

        /// <summary>
        /// A flags enumeration value representing the current state of any \&quot;state modifiers\&quot; on the item being sold. These are meant to correspond with some sort of visual indicator as to the augmentation: for instance, if an item is on sale or if you already own the item in question.  Determining how you want to represent these in your own app (or if you even want to) is an exercise left for the reader.
        /// </summary>
        /// <value>A flags enumeration value representing the current state of any \&quot;state modifiers\&quot; on the item being sold. These are meant to correspond with some sort of visual indicator as to the augmentation: for instance, if an item is on sale or if you already own the item in question.  Determining how you want to represent these in your own app (or if you even want to) is an exercise left for the reader.</value>
        [DataMember(Name="augments", EmitDefaultValue=false)]
        public int Augments { get; set; }

        /// <summary>
        /// The index into the DestinyVendorDefinition.itemList property. Note that this means Vendor data *is* Content Version dependent: make sure you have the latest content before you use Vendor data, or these indexes may mismatch.   Most systems avoid this problem, but Vendors is one area where we are unable to reasonably avoid content dependency at the moment.
        /// </summary>
        /// <value>The index into the DestinyVendorDefinition.itemList property. Note that this means Vendor data *is* Content Version dependent: make sure you have the latest content before you use Vendor data, or these indexes may mismatch.   Most systems avoid this problem, but Vendors is one area where we are unable to reasonably avoid content dependency at the moment.</value>
        [DataMember(Name="vendorItemIndex", EmitDefaultValue=false)]
        public int VendorItemIndex { get; set; }

        /// <summary>
        /// The hash of the item being sold, as a quick shortcut for looking up the DestinyInventoryItemDefinition of the sale item.
        /// </summary>
        /// <value>The hash of the item being sold, as a quick shortcut for looking up the DestinyInventoryItemDefinition of the sale item.</value>
        [DataMember(Name="itemHash", EmitDefaultValue=false)]
        public long ItemHash { get; set; }

        /// <summary>
        /// If populated, this is the hash of the item whose icon (and other secondary styles, but *not* the human readable strings) should override whatever icons/styles are on the item being sold.  If you don&#39;t do this, certain items whose styles are being overridden by socketed items - such as the \&quot;Recycle Shader\&quot; item - would show whatever their default icon/style is, and it wouldn&#39;t be pretty or look accurate.
        /// </summary>
        /// <value>If populated, this is the hash of the item whose icon (and other secondary styles, but *not* the human readable strings) should override whatever icons/styles are on the item being sold.  If you don&#39;t do this, certain items whose styles are being overridden by socketed items - such as the \&quot;Recycle Shader\&quot; item - would show whatever their default icon/style is, and it wouldn&#39;t be pretty or look accurate.</value>
        [DataMember(Name="overrideStyleItemHash", EmitDefaultValue=false)]
        public long OverrideStyleItemHash { get; set; }

        /// <summary>
        /// How much of the item you&#39;ll be getting.
        /// </summary>
        /// <value>How much of the item you&#39;ll be getting.</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int Quantity { get; set; }

        /// <summary>
        /// A summary of the current costs of the item.
        /// </summary>
        /// <value>A summary of the current costs of the item.</value>
        [DataMember(Name="costs", EmitDefaultValue=false)]
        public List<DestinyDestinyItemQuantity> Costs { get; set; }

        /// <summary>
        /// If this item has its own custom date where it may be removed from the Vendor&#39;s rotation, this is that date.  Note that there&#39;s not actually any guarantee that it will go away: it could be chosen again and end up still being in the Vendor&#39;s sale items! But this is the next date where that test will occur, and is also the date that the game shows for availability on things like Bounties being sold. So it&#39;s the best we can give.
        /// </summary>
        /// <value>If this item has its own custom date where it may be removed from the Vendor&#39;s rotation, this is that date.  Note that there&#39;s not actually any guarantee that it will go away: it could be chosen again and end up still being in the Vendor&#39;s sale items! But this is the next date where that test will occur, and is also the date that the game shows for availability on things like Bounties being sold. So it&#39;s the best we can give.</value>
        [DataMember(Name="overrideNextRefreshDate", EmitDefaultValue=false)]
        public DateTime OverrideNextRefreshDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
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
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyEntitiesVendorsDestinyVendorSaleItemComponent);
        }

        /// <summary>
        /// Returns true if DestinyEntitiesVendorsDestinyVendorSaleItemComponent instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyEntitiesVendorsDestinyVendorSaleItemComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyEntitiesVendorsDestinyVendorSaleItemComponent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SaleStatus == input.SaleStatus ||
                    this.SaleStatus.Equals(input.SaleStatus)
                ) && 
                (
                    this.RequiredUnlocks == input.RequiredUnlocks ||
                    this.RequiredUnlocks != null &&
                    input.RequiredUnlocks != null &&
                    this.RequiredUnlocks.SequenceEqual(input.RequiredUnlocks)
                ) && 
                (
                    this.UnlockStatuses == input.UnlockStatuses ||
                    this.UnlockStatuses != null &&
                    input.UnlockStatuses != null &&
                    this.UnlockStatuses.SequenceEqual(input.UnlockStatuses)
                ) && 
                (
                    this.FailureIndexes == input.FailureIndexes ||
                    this.FailureIndexes != null &&
                    input.FailureIndexes != null &&
                    this.FailureIndexes.SequenceEqual(input.FailureIndexes)
                ) && 
                (
                    this.Augments == input.Augments ||
                    this.Augments.Equals(input.Augments)
                ) && 
                (
                    this.VendorItemIndex == input.VendorItemIndex ||
                    this.VendorItemIndex.Equals(input.VendorItemIndex)
                ) && 
                (
                    this.ItemHash == input.ItemHash ||
                    this.ItemHash.Equals(input.ItemHash)
                ) && 
                (
                    this.OverrideStyleItemHash == input.OverrideStyleItemHash ||
                    this.OverrideStyleItemHash.Equals(input.OverrideStyleItemHash)
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    this.Quantity.Equals(input.Quantity)
                ) && 
                (
                    this.Costs == input.Costs ||
                    this.Costs != null &&
                    input.Costs != null &&
                    this.Costs.SequenceEqual(input.Costs)
                ) && 
                (
                    this.OverrideNextRefreshDate == input.OverrideNextRefreshDate ||
                    (this.OverrideNextRefreshDate != null &&
                    this.OverrideNextRefreshDate.Equals(input.OverrideNextRefreshDate))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = hashCode * 59 + this.SaleStatus.GetHashCode();
                if (this.RequiredUnlocks != null)
                    hashCode = hashCode * 59 + this.RequiredUnlocks.GetHashCode();
                if (this.UnlockStatuses != null)
                    hashCode = hashCode * 59 + this.UnlockStatuses.GetHashCode();
                if (this.FailureIndexes != null)
                    hashCode = hashCode * 59 + this.FailureIndexes.GetHashCode();
                hashCode = hashCode * 59 + this.Augments.GetHashCode();
                hashCode = hashCode * 59 + this.VendorItemIndex.GetHashCode();
                hashCode = hashCode * 59 + this.ItemHash.GetHashCode();
                hashCode = hashCode * 59 + this.OverrideStyleItemHash.GetHashCode();
                hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.Costs != null)
                    hashCode = hashCode * 59 + this.Costs.GetHashCode();
                if (this.OverrideNextRefreshDate != null)
                    hashCode = hashCode * 59 + this.OverrideNextRefreshDate.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
