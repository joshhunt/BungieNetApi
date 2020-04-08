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
    /// The base item component, filled with properties that are generally useful to know in any item request or that don&#39;t feel worthwhile to put in their own component.
    /// </summary>
    [DataContract]
    public partial class DestinyEntitiesItemsDestinyItemComponent :  IEquatable<DestinyEntitiesItemsDestinyItemComponent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyEntitiesItemsDestinyItemComponent" /> class.
        /// </summary>
        /// <param name="itemHash">The identifier for the item&#39;s definition, which is where most of the useful static information for the item can be found..</param>
        /// <param name="itemInstanceId">If the item is instanced, it will have an instance ID. Lack of an instance ID implies that the item has no distinct local qualities aside from stack size..</param>
        /// <param name="quantity">The quantity of the item in this stack. Note that Instanced items cannot stack. If an instanced item, this value will always be 1 (as the stack has exactly one item in it).</param>
        /// <param name="bindStatus">If the item is bound to a location, it will be specified in this enum..</param>
        /// <param name="location">An easy reference for where the item is located. Redundant if you got the item from an Inventory, but useful when making detail calls on specific items..</param>
        /// <param name="bucketHash">The hash identifier for the specific inventory bucket in which the item is located..</param>
        /// <param name="transferStatus">If there is a known error state that would cause this item to not be transferable, this Flags enum will indicate all of those error states. Otherwise, it will be 0 (CanTransfer)..</param>
        /// <param name="lockable">If the item can be locked, this will indicate that state..</param>
        /// <param name="state">A flags enumeration indicating the transient/custom states of the item that affect how it is rendered: whether it&#39;s tracked or locked for example, or whether it has a masterwork plug inserted..</param>
        /// <param name="overrideStyleItemHash">If populated, this is the hash of the item whose icon (and other secondary styles, but *not* the human readable strings) should override whatever icons/styles are on the item being sold.  If you don&#39;t do this, certain items whose styles are being overridden by socketed items - such as the \&quot;Recycle Shader\&quot; item - would show whatever their default icon/style is, and it wouldn&#39;t be pretty or look accurate..</param>
        /// <param name="expirationDate">If the item can expire, this is the date at which it will/did expire..</param>
        /// <param name="isWrapper">If this is true, the object is actually a \&quot;wrapper\&quot; of the object it&#39;s representing. This means that it&#39;s not the actual item itself, but rather an item that must be \&quot;opened\&quot; in game before you have and can use the item.   Wrappers are an evolution of \&quot;bundles\&quot;, which give an easy way to let you preview the contents of what you purchased while still letting you get a refund before you \&quot;open\&quot; it..</param>
        /// <param name="tooltipNotificationIndexes">If this is populated, it is a list of indexes into DestinyInventoryItemDefinition.tooltipNotifications for any special tooltip messages that need to be shown for this item..</param>
        /// <param name="metricHash">The identifier for the currently-selected metric definition, to be displayed on the emblem nameplate..</param>
        /// <param name="metricObjective">The objective progress for the currently-selected metric definition, to be displayed on the emblem nameplate..</param>
        public DestinyEntitiesItemsDestinyItemComponent(int itemHash = default(int), long itemInstanceId = default(long), int quantity = default(int), int bindStatus = default(int), int location = default(int), int bucketHash = default(int), int transferStatus = default(int), bool lockable = default(bool), int state = default(int), int overrideStyleItemHash = default(int), DateTime expirationDate = default(DateTime), bool isWrapper = default(bool), List<int> tooltipNotificationIndexes = default(List<int>), int metricHash = default(int), DestinyQuestsDestinyObjectiveProgress metricObjective = default(DestinyQuestsDestinyObjectiveProgress))
        {
            this.ItemHash = itemHash;
            this.ItemInstanceId = itemInstanceId;
            this.Quantity = quantity;
            this.BindStatus = bindStatus;
            this.Location = location;
            this.BucketHash = bucketHash;
            this.TransferStatus = transferStatus;
            this.Lockable = lockable;
            this.State = state;
            this.OverrideStyleItemHash = overrideStyleItemHash;
            this.ExpirationDate = expirationDate;
            this.IsWrapper = isWrapper;
            this.TooltipNotificationIndexes = tooltipNotificationIndexes;
            this.MetricHash = metricHash;
            this.MetricObjective = metricObjective;
        }
        
        /// <summary>
        /// The identifier for the item&#39;s definition, which is where most of the useful static information for the item can be found.
        /// </summary>
        /// <value>The identifier for the item&#39;s definition, which is where most of the useful static information for the item can be found.</value>
        [DataMember(Name="itemHash", EmitDefaultValue=false)]
        public int ItemHash { get; set; }

        /// <summary>
        /// If the item is instanced, it will have an instance ID. Lack of an instance ID implies that the item has no distinct local qualities aside from stack size.
        /// </summary>
        /// <value>If the item is instanced, it will have an instance ID. Lack of an instance ID implies that the item has no distinct local qualities aside from stack size.</value>
        [DataMember(Name="itemInstanceId", EmitDefaultValue=false)]
        public long ItemInstanceId { get; set; }

        /// <summary>
        /// The quantity of the item in this stack. Note that Instanced items cannot stack. If an instanced item, this value will always be 1 (as the stack has exactly one item in it)
        /// </summary>
        /// <value>The quantity of the item in this stack. Note that Instanced items cannot stack. If an instanced item, this value will always be 1 (as the stack has exactly one item in it)</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int Quantity { get; set; }

        /// <summary>
        /// If the item is bound to a location, it will be specified in this enum.
        /// </summary>
        /// <value>If the item is bound to a location, it will be specified in this enum.</value>
        [DataMember(Name="bindStatus", EmitDefaultValue=false)]
        public int BindStatus { get; set; }

        /// <summary>
        /// An easy reference for where the item is located. Redundant if you got the item from an Inventory, but useful when making detail calls on specific items.
        /// </summary>
        /// <value>An easy reference for where the item is located. Redundant if you got the item from an Inventory, but useful when making detail calls on specific items.</value>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public int Location { get; set; }

        /// <summary>
        /// The hash identifier for the specific inventory bucket in which the item is located.
        /// </summary>
        /// <value>The hash identifier for the specific inventory bucket in which the item is located.</value>
        [DataMember(Name="bucketHash", EmitDefaultValue=false)]
        public int BucketHash { get; set; }

        /// <summary>
        /// If there is a known error state that would cause this item to not be transferable, this Flags enum will indicate all of those error states. Otherwise, it will be 0 (CanTransfer).
        /// </summary>
        /// <value>If there is a known error state that would cause this item to not be transferable, this Flags enum will indicate all of those error states. Otherwise, it will be 0 (CanTransfer).</value>
        [DataMember(Name="transferStatus", EmitDefaultValue=false)]
        public int TransferStatus { get; set; }

        /// <summary>
        /// If the item can be locked, this will indicate that state.
        /// </summary>
        /// <value>If the item can be locked, this will indicate that state.</value>
        [DataMember(Name="lockable", EmitDefaultValue=false)]
        public bool Lockable { get; set; }

        /// <summary>
        /// A flags enumeration indicating the transient/custom states of the item that affect how it is rendered: whether it&#39;s tracked or locked for example, or whether it has a masterwork plug inserted.
        /// </summary>
        /// <value>A flags enumeration indicating the transient/custom states of the item that affect how it is rendered: whether it&#39;s tracked or locked for example, or whether it has a masterwork plug inserted.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public int State { get; set; }

        /// <summary>
        /// If populated, this is the hash of the item whose icon (and other secondary styles, but *not* the human readable strings) should override whatever icons/styles are on the item being sold.  If you don&#39;t do this, certain items whose styles are being overridden by socketed items - such as the \&quot;Recycle Shader\&quot; item - would show whatever their default icon/style is, and it wouldn&#39;t be pretty or look accurate.
        /// </summary>
        /// <value>If populated, this is the hash of the item whose icon (and other secondary styles, but *not* the human readable strings) should override whatever icons/styles are on the item being sold.  If you don&#39;t do this, certain items whose styles are being overridden by socketed items - such as the \&quot;Recycle Shader\&quot; item - would show whatever their default icon/style is, and it wouldn&#39;t be pretty or look accurate.</value>
        [DataMember(Name="overrideStyleItemHash", EmitDefaultValue=false)]
        public int OverrideStyleItemHash { get; set; }

        /// <summary>
        /// If the item can expire, this is the date at which it will/did expire.
        /// </summary>
        /// <value>If the item can expire, this is the date at which it will/did expire.</value>
        [DataMember(Name="expirationDate", EmitDefaultValue=false)]
        public DateTime ExpirationDate { get; set; }

        /// <summary>
        /// If this is true, the object is actually a \&quot;wrapper\&quot; of the object it&#39;s representing. This means that it&#39;s not the actual item itself, but rather an item that must be \&quot;opened\&quot; in game before you have and can use the item.   Wrappers are an evolution of \&quot;bundles\&quot;, which give an easy way to let you preview the contents of what you purchased while still letting you get a refund before you \&quot;open\&quot; it.
        /// </summary>
        /// <value>If this is true, the object is actually a \&quot;wrapper\&quot; of the object it&#39;s representing. This means that it&#39;s not the actual item itself, but rather an item that must be \&quot;opened\&quot; in game before you have and can use the item.   Wrappers are an evolution of \&quot;bundles\&quot;, which give an easy way to let you preview the contents of what you purchased while still letting you get a refund before you \&quot;open\&quot; it.</value>
        [DataMember(Name="isWrapper", EmitDefaultValue=false)]
        public bool IsWrapper { get; set; }

        /// <summary>
        /// If this is populated, it is a list of indexes into DestinyInventoryItemDefinition.tooltipNotifications for any special tooltip messages that need to be shown for this item.
        /// </summary>
        /// <value>If this is populated, it is a list of indexes into DestinyInventoryItemDefinition.tooltipNotifications for any special tooltip messages that need to be shown for this item.</value>
        [DataMember(Name="tooltipNotificationIndexes", EmitDefaultValue=false)]
        public List<int> TooltipNotificationIndexes { get; set; }

        /// <summary>
        /// The identifier for the currently-selected metric definition, to be displayed on the emblem nameplate.
        /// </summary>
        /// <value>The identifier for the currently-selected metric definition, to be displayed on the emblem nameplate.</value>
        [DataMember(Name="metricHash", EmitDefaultValue=false)]
        public int MetricHash { get; set; }

        /// <summary>
        /// The objective progress for the currently-selected metric definition, to be displayed on the emblem nameplate.
        /// </summary>
        /// <value>The objective progress for the currently-selected metric definition, to be displayed on the emblem nameplate.</value>
        [DataMember(Name="metricObjective", EmitDefaultValue=false)]
        public DestinyQuestsDestinyObjectiveProgress MetricObjective { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
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
            return this.Equals(input as DestinyEntitiesItemsDestinyItemComponent);
        }

        /// <summary>
        /// Returns true if DestinyEntitiesItemsDestinyItemComponent instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyEntitiesItemsDestinyItemComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyEntitiesItemsDestinyItemComponent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ItemHash == input.ItemHash ||
                    (this.ItemHash != null &&
                    this.ItemHash.Equals(input.ItemHash))
                ) && 
                (
                    this.ItemInstanceId == input.ItemInstanceId ||
                    (this.ItemInstanceId != null &&
                    this.ItemInstanceId.Equals(input.ItemInstanceId))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.BindStatus == input.BindStatus ||
                    (this.BindStatus != null &&
                    this.BindStatus.Equals(input.BindStatus))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.BucketHash == input.BucketHash ||
                    (this.BucketHash != null &&
                    this.BucketHash.Equals(input.BucketHash))
                ) && 
                (
                    this.TransferStatus == input.TransferStatus ||
                    (this.TransferStatus != null &&
                    this.TransferStatus.Equals(input.TransferStatus))
                ) && 
                (
                    this.Lockable == input.Lockable ||
                    (this.Lockable != null &&
                    this.Lockable.Equals(input.Lockable))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.OverrideStyleItemHash == input.OverrideStyleItemHash ||
                    (this.OverrideStyleItemHash != null &&
                    this.OverrideStyleItemHash.Equals(input.OverrideStyleItemHash))
                ) && 
                (
                    this.ExpirationDate == input.ExpirationDate ||
                    (this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(input.ExpirationDate))
                ) && 
                (
                    this.IsWrapper == input.IsWrapper ||
                    (this.IsWrapper != null &&
                    this.IsWrapper.Equals(input.IsWrapper))
                ) && 
                (
                    this.TooltipNotificationIndexes == input.TooltipNotificationIndexes ||
                    this.TooltipNotificationIndexes != null &&
                    input.TooltipNotificationIndexes != null &&
                    this.TooltipNotificationIndexes.SequenceEqual(input.TooltipNotificationIndexes)
                ) && 
                (
                    this.MetricHash == input.MetricHash ||
                    (this.MetricHash != null &&
                    this.MetricHash.Equals(input.MetricHash))
                ) && 
                (
                    this.MetricObjective == input.MetricObjective ||
                    (this.MetricObjective != null &&
                    this.MetricObjective.Equals(input.MetricObjective))
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
                if (this.ItemHash != null)
                    hashCode = hashCode * 59 + this.ItemHash.GetHashCode();
                if (this.ItemInstanceId != null)
                    hashCode = hashCode * 59 + this.ItemInstanceId.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.BindStatus != null)
                    hashCode = hashCode * 59 + this.BindStatus.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.BucketHash != null)
                    hashCode = hashCode * 59 + this.BucketHash.GetHashCode();
                if (this.TransferStatus != null)
                    hashCode = hashCode * 59 + this.TransferStatus.GetHashCode();
                if (this.Lockable != null)
                    hashCode = hashCode * 59 + this.Lockable.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.OverrideStyleItemHash != null)
                    hashCode = hashCode * 59 + this.OverrideStyleItemHash.GetHashCode();
                if (this.ExpirationDate != null)
                    hashCode = hashCode * 59 + this.ExpirationDate.GetHashCode();
                if (this.IsWrapper != null)
                    hashCode = hashCode * 59 + this.IsWrapper.GetHashCode();
                if (this.TooltipNotificationIndexes != null)
                    hashCode = hashCode * 59 + this.TooltipNotificationIndexes.GetHashCode();
                if (this.MetricHash != null)
                    hashCode = hashCode * 59 + this.MetricHash.GetHashCode();
                if (this.MetricObjective != null)
                    hashCode = hashCode * 59 + this.MetricObjective.GetHashCode();
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
