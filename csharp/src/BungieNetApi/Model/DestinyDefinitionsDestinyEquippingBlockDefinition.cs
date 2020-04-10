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
    /// Items that can be equipped define this block. It contains information we need to understand how and when the item can be equipped.
    /// </summary>
    [DataContract]
    public partial class DestinyDefinitionsDestinyEquippingBlockDefinition :  IEquatable<DestinyDefinitionsDestinyEquippingBlockDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDestinyEquippingBlockDefinition" /> class.
        /// </summary>
        /// <param name="gearsetItemHash">If the item is part of a gearset, this is a reference to that gearset item..</param>
        /// <param name="uniqueLabel">If defined, this is the label used to check if the item has other items of matching types already equipped.   For instance, when you aren&#39;t allowed to equip more than one Exotic Weapon, that&#39;s because all exotic weapons have identical uniqueLabels and the game checks the to-be-equipped item&#39;s uniqueLabel vs. all other already equipped items (other than the item in the slot that&#39;s about to be occupied)..</param>
        /// <param name="uniqueLabelHash">The hash of that unique label. Does not point to a specific definition..</param>
        /// <param name="equipmentSlotTypeHash">An equipped item *must* be equipped in an Equipment Slot. This is the hash identifier of the DestinyEquipmentSlotDefinition into which it must be equipped..</param>
        /// <param name="attributes">These are custom attributes on the equippability of the item.  For now, this can only be \&quot;equip on acquire\&quot;, which would mean that the item will be automatically equipped as soon as you pick it up..</param>
        /// <param name="ammoType">Ammo type used by a weapon is no longer determined by the bucket in which it is contained. If the item has an ammo type - i.e. if it is a weapon - this will be the type of ammunition expected..</param>
        /// <param name="displayStrings">These are strings that represent the possible Game/Account/Character state failure conditions that can occur when trying to equip the item. They match up one-to-one with requiredUnlockExpressions..</param>
        public DestinyDefinitionsDestinyEquippingBlockDefinition(int gearsetItemHash = default(int), string uniqueLabel = default(string), int uniqueLabelHash = default(int), int equipmentSlotTypeHash = default(int), int attributes = default(int), int ammoType = default(int), List<string> displayStrings = default(List<string>))
        {
            this.GearsetItemHash = gearsetItemHash;
            this.UniqueLabel = uniqueLabel;
            this.UniqueLabelHash = uniqueLabelHash;
            this.EquipmentSlotTypeHash = equipmentSlotTypeHash;
            this.Attributes = attributes;
            this.AmmoType = ammoType;
            this.DisplayStrings = displayStrings;
        }
        
        /// <summary>
        /// If the item is part of a gearset, this is a reference to that gearset item.
        /// </summary>
        /// <value>If the item is part of a gearset, this is a reference to that gearset item.</value>
        [DataMember(Name="gearsetItemHash", EmitDefaultValue=false)]
        public int GearsetItemHash { get; set; }

        /// <summary>
        /// If defined, this is the label used to check if the item has other items of matching types already equipped.   For instance, when you aren&#39;t allowed to equip more than one Exotic Weapon, that&#39;s because all exotic weapons have identical uniqueLabels and the game checks the to-be-equipped item&#39;s uniqueLabel vs. all other already equipped items (other than the item in the slot that&#39;s about to be occupied).
        /// </summary>
        /// <value>If defined, this is the label used to check if the item has other items of matching types already equipped.   For instance, when you aren&#39;t allowed to equip more than one Exotic Weapon, that&#39;s because all exotic weapons have identical uniqueLabels and the game checks the to-be-equipped item&#39;s uniqueLabel vs. all other already equipped items (other than the item in the slot that&#39;s about to be occupied).</value>
        [DataMember(Name="uniqueLabel", EmitDefaultValue=false)]
        public string UniqueLabel { get; set; }

        /// <summary>
        /// The hash of that unique label. Does not point to a specific definition.
        /// </summary>
        /// <value>The hash of that unique label. Does not point to a specific definition.</value>
        [DataMember(Name="uniqueLabelHash", EmitDefaultValue=false)]
        public int UniqueLabelHash { get; set; }

        /// <summary>
        /// An equipped item *must* be equipped in an Equipment Slot. This is the hash identifier of the DestinyEquipmentSlotDefinition into which it must be equipped.
        /// </summary>
        /// <value>An equipped item *must* be equipped in an Equipment Slot. This is the hash identifier of the DestinyEquipmentSlotDefinition into which it must be equipped.</value>
        [DataMember(Name="equipmentSlotTypeHash", EmitDefaultValue=false)]
        public int EquipmentSlotTypeHash { get; set; }

        /// <summary>
        /// These are custom attributes on the equippability of the item.  For now, this can only be \&quot;equip on acquire\&quot;, which would mean that the item will be automatically equipped as soon as you pick it up.
        /// </summary>
        /// <value>These are custom attributes on the equippability of the item.  For now, this can only be \&quot;equip on acquire\&quot;, which would mean that the item will be automatically equipped as soon as you pick it up.</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public int Attributes { get; set; }

        /// <summary>
        /// Ammo type used by a weapon is no longer determined by the bucket in which it is contained. If the item has an ammo type - i.e. if it is a weapon - this will be the type of ammunition expected.
        /// </summary>
        /// <value>Ammo type used by a weapon is no longer determined by the bucket in which it is contained. If the item has an ammo type - i.e. if it is a weapon - this will be the type of ammunition expected.</value>
        [DataMember(Name="ammoType", EmitDefaultValue=false)]
        public int AmmoType { get; set; }

        /// <summary>
        /// These are strings that represent the possible Game/Account/Character state failure conditions that can occur when trying to equip the item. They match up one-to-one with requiredUnlockExpressions.
        /// </summary>
        /// <value>These are strings that represent the possible Game/Account/Character state failure conditions that can occur when trying to equip the item. They match up one-to-one with requiredUnlockExpressions.</value>
        [DataMember(Name="displayStrings", EmitDefaultValue=false)]
        public List<string> DisplayStrings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
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
            return this.Equals(input as DestinyDefinitionsDestinyEquippingBlockDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDestinyEquippingBlockDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDestinyEquippingBlockDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDestinyEquippingBlockDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GearsetItemHash == input.GearsetItemHash ||
                    (this.GearsetItemHash != null &&
                    this.GearsetItemHash.Equals(input.GearsetItemHash))
                ) && 
                (
                    this.UniqueLabel == input.UniqueLabel ||
                    (this.UniqueLabel != null &&
                    this.UniqueLabel.Equals(input.UniqueLabel))
                ) && 
                (
                    this.UniqueLabelHash == input.UniqueLabelHash ||
                    (this.UniqueLabelHash != null &&
                    this.UniqueLabelHash.Equals(input.UniqueLabelHash))
                ) && 
                (
                    this.EquipmentSlotTypeHash == input.EquipmentSlotTypeHash ||
                    (this.EquipmentSlotTypeHash != null &&
                    this.EquipmentSlotTypeHash.Equals(input.EquipmentSlotTypeHash))
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    (this.Attributes != null &&
                    this.Attributes.Equals(input.Attributes))
                ) && 
                (
                    this.AmmoType == input.AmmoType ||
                    (this.AmmoType != null &&
                    this.AmmoType.Equals(input.AmmoType))
                ) && 
                (
                    this.DisplayStrings == input.DisplayStrings ||
                    this.DisplayStrings != null &&
                    input.DisplayStrings != null &&
                    this.DisplayStrings.SequenceEqual(input.DisplayStrings)
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
                if (this.GearsetItemHash != null)
                    hashCode = hashCode * 59 + this.GearsetItemHash.GetHashCode();
                if (this.UniqueLabel != null)
                    hashCode = hashCode * 59 + this.UniqueLabel.GetHashCode();
                if (this.UniqueLabelHash != null)
                    hashCode = hashCode * 59 + this.UniqueLabelHash.GetHashCode();
                if (this.EquipmentSlotTypeHash != null)
                    hashCode = hashCode * 59 + this.EquipmentSlotTypeHash.GetHashCode();
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.AmmoType != null)
                    hashCode = hashCode * 59 + this.AmmoType.GetHashCode();
                if (this.DisplayStrings != null)
                    hashCode = hashCode * 59 + this.DisplayStrings.GetHashCode();
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
