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
    /// DestinyDefinitionsDestinyProgressionRewardItemQuantity
    /// </summary>
    [DataContract]
    public partial class DestinyDefinitionsDestinyProgressionRewardItemQuantity :  IEquatable<DestinyDefinitionsDestinyProgressionRewardItemQuantity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDestinyProgressionRewardItemQuantity" /> class.
        /// </summary>
        /// <param name="rewardedAtProgressionLevel">rewardedAtProgressionLevel.</param>
        /// <param name="acquisitionBehavior">acquisitionBehavior.</param>
        /// <param name="uiDisplayStyle">uiDisplayStyle.</param>
        /// <param name="claimUnlockDisplayStrings">claimUnlockDisplayStrings.</param>
        /// <param name="itemHash">The hash identifier for the item in question. Use it to look up the item&#39;s DestinyInventoryItemDefinition..</param>
        /// <param name="itemInstanceId">If this quantity is referring to a specific instance of an item, this will have the item&#39;s instance ID. Normally, this will be null..</param>
        /// <param name="quantity">The amount of the item needed/available depending on the context of where DestinyItemQuantity is being used..</param>
        public DestinyDefinitionsDestinyProgressionRewardItemQuantity(int rewardedAtProgressionLevel = default(int), int acquisitionBehavior = default(int), string uiDisplayStyle = default(string), List<string> claimUnlockDisplayStrings = default(List<string>), int itemHash = default(int), long itemInstanceId = default(long), int quantity = default(int))
        {
            this.RewardedAtProgressionLevel = rewardedAtProgressionLevel;
            this.AcquisitionBehavior = acquisitionBehavior;
            this.UiDisplayStyle = uiDisplayStyle;
            this.ClaimUnlockDisplayStrings = claimUnlockDisplayStrings;
            this.ItemHash = itemHash;
            this.ItemInstanceId = itemInstanceId;
            this.Quantity = quantity;
        }
        
        /// <summary>
        /// Gets or Sets RewardedAtProgressionLevel
        /// </summary>
        [DataMember(Name="rewardedAtProgressionLevel", EmitDefaultValue=false)]
        public int RewardedAtProgressionLevel { get; set; }

        /// <summary>
        /// Gets or Sets AcquisitionBehavior
        /// </summary>
        [DataMember(Name="acquisitionBehavior", EmitDefaultValue=false)]
        public int AcquisitionBehavior { get; set; }

        /// <summary>
        /// Gets or Sets UiDisplayStyle
        /// </summary>
        [DataMember(Name="uiDisplayStyle", EmitDefaultValue=false)]
        public string UiDisplayStyle { get; set; }

        /// <summary>
        /// Gets or Sets ClaimUnlockDisplayStrings
        /// </summary>
        [DataMember(Name="claimUnlockDisplayStrings", EmitDefaultValue=false)]
        public List<string> ClaimUnlockDisplayStrings { get; set; }

        /// <summary>
        /// The hash identifier for the item in question. Use it to look up the item&#39;s DestinyInventoryItemDefinition.
        /// </summary>
        /// <value>The hash identifier for the item in question. Use it to look up the item&#39;s DestinyInventoryItemDefinition.</value>
        [DataMember(Name="itemHash", EmitDefaultValue=false)]
        public int ItemHash { get; set; }

        /// <summary>
        /// If this quantity is referring to a specific instance of an item, this will have the item&#39;s instance ID. Normally, this will be null.
        /// </summary>
        /// <value>If this quantity is referring to a specific instance of an item, this will have the item&#39;s instance ID. Normally, this will be null.</value>
        [DataMember(Name="itemInstanceId", EmitDefaultValue=false)]
        public long ItemInstanceId { get; set; }

        /// <summary>
        /// The amount of the item needed/available depending on the context of where DestinyItemQuantity is being used.
        /// </summary>
        /// <value>The amount of the item needed/available depending on the context of where DestinyItemQuantity is being used.</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int Quantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsDestinyProgressionRewardItemQuantity {\n");
            sb.Append("  RewardedAtProgressionLevel: ").Append(RewardedAtProgressionLevel).Append("\n");
            sb.Append("  AcquisitionBehavior: ").Append(AcquisitionBehavior).Append("\n");
            sb.Append("  UiDisplayStyle: ").Append(UiDisplayStyle).Append("\n");
            sb.Append("  ClaimUnlockDisplayStrings: ").Append(ClaimUnlockDisplayStrings).Append("\n");
            sb.Append("  ItemHash: ").Append(ItemHash).Append("\n");
            sb.Append("  ItemInstanceId: ").Append(ItemInstanceId).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsDestinyProgressionRewardItemQuantity);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDestinyProgressionRewardItemQuantity instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDestinyProgressionRewardItemQuantity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDestinyProgressionRewardItemQuantity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RewardedAtProgressionLevel == input.RewardedAtProgressionLevel ||
                    (this.RewardedAtProgressionLevel != null &&
                    this.RewardedAtProgressionLevel.Equals(input.RewardedAtProgressionLevel))
                ) && 
                (
                    this.AcquisitionBehavior == input.AcquisitionBehavior ||
                    (this.AcquisitionBehavior != null &&
                    this.AcquisitionBehavior.Equals(input.AcquisitionBehavior))
                ) && 
                (
                    this.UiDisplayStyle == input.UiDisplayStyle ||
                    (this.UiDisplayStyle != null &&
                    this.UiDisplayStyle.Equals(input.UiDisplayStyle))
                ) && 
                (
                    this.ClaimUnlockDisplayStrings == input.ClaimUnlockDisplayStrings ||
                    this.ClaimUnlockDisplayStrings != null &&
                    input.ClaimUnlockDisplayStrings != null &&
                    this.ClaimUnlockDisplayStrings.SequenceEqual(input.ClaimUnlockDisplayStrings)
                ) && 
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
                if (this.RewardedAtProgressionLevel != null)
                    hashCode = hashCode * 59 + this.RewardedAtProgressionLevel.GetHashCode();
                if (this.AcquisitionBehavior != null)
                    hashCode = hashCode * 59 + this.AcquisitionBehavior.GetHashCode();
                if (this.UiDisplayStyle != null)
                    hashCode = hashCode * 59 + this.UiDisplayStyle.GetHashCode();
                if (this.ClaimUnlockDisplayStrings != null)
                    hashCode = hashCode * 59 + this.ClaimUnlockDisplayStrings.GetHashCode();
                if (this.ItemHash != null)
                    hashCode = hashCode * 59 + this.ItemHash.GetHashCode();
                if (this.ItemInstanceId != null)
                    hashCode = hashCode * 59 + this.ItemInstanceId.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
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
