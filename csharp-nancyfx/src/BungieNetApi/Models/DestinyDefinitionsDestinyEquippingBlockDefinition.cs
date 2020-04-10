using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Items that can be equipped define this block. It contains information we need to understand how and when the item can be equipped.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyEquippingBlockDefinition:  IEquatable<DestinyDefinitionsDestinyEquippingBlockDefinition>
    { 
        /// <summary>
        /// If the item is part of a gearset, this is a reference to that gearset item.
        /// </summary>
        public int? GearsetItemHash { get; private set; }

        /// <summary>
        /// If defined, this is the label used to check if the item has other items of matching types already equipped.   For instance, when you aren&#39;t allowed to equip more than one Exotic Weapon, that&#39;s because all exotic weapons have identical uniqueLabels and the game checks the to-be-equipped item&#39;s uniqueLabel vs. all other already equipped items (other than the item in the slot that&#39;s about to be occupied).
        /// </summary>
        public string UniqueLabel { get; private set; }

        /// <summary>
        /// The hash of that unique label. Does not point to a specific definition.
        /// </summary>
        public int? UniqueLabelHash { get; private set; }

        /// <summary>
        /// An equipped item *must* be equipped in an Equipment Slot. This is the hash identifier of the DestinyEquipmentSlotDefinition into which it must be equipped.
        /// </summary>
        public int? EquipmentSlotTypeHash { get; private set; }

        /// <summary>
        /// These are custom attributes on the equippability of the item.  For now, this can only be \&quot;equip on acquire\&quot;, which would mean that the item will be automatically equipped as soon as you pick it up.
        /// </summary>
        public int? Attributes { get; private set; }

        /// <summary>
        /// Ammo type used by a weapon is no longer determined by the bucket in which it is contained. If the item has an ammo type - i.e. if it is a weapon - this will be the type of ammunition expected.
        /// </summary>
        public int? AmmoType { get; private set; }

        /// <summary>
        /// These are strings that represent the possible Game/Account/Character state failure conditions that can occur when trying to equip the item. They match up one-to-one with requiredUnlockExpressions.
        /// </summary>
        public List<string> DisplayStrings { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyEquippingBlockDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyEquippingBlockDefinition()
        {
        }

        private DestinyDefinitionsDestinyEquippingBlockDefinition(int? GearsetItemHash, string UniqueLabel, int? UniqueLabelHash, int? EquipmentSlotTypeHash, int? Attributes, int? AmmoType, List<string> DisplayStrings)
        {
            
            this.GearsetItemHash = GearsetItemHash;
            
            this.UniqueLabel = UniqueLabel;
            
            this.UniqueLabelHash = UniqueLabelHash;
            
            this.EquipmentSlotTypeHash = EquipmentSlotTypeHash;
            
            this.Attributes = Attributes;
            
            this.AmmoType = AmmoType;
            
            this.DisplayStrings = DisplayStrings;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyEquippingBlockDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyEquippingBlockDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyEquippingBlockDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyEquippingBlockDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyEquippingBlockDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyEquippingBlockDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyEquippingBlockDefinitionBuilder With()
        {
            return Builder()
                .GearsetItemHash(GearsetItemHash)
                .UniqueLabel(UniqueLabel)
                .UniqueLabelHash(UniqueLabelHash)
                .EquipmentSlotTypeHash(EquipmentSlotTypeHash)
                .Attributes(Attributes)
                .AmmoType(AmmoType)
                .DisplayStrings(DisplayStrings);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyEquippingBlockDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyEquippingBlockDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyEquippingBlockDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyEquippingBlockDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyEquippingBlockDefinition left, DestinyDefinitionsDestinyEquippingBlockDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyEquippingBlockDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyEquippingBlockDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyEquippingBlockDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyEquippingBlockDefinition left, DestinyDefinitionsDestinyEquippingBlockDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyEquippingBlockDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyEquippingBlockDefinitionBuilder
        {
            private int? _GearsetItemHash;
            private string _UniqueLabel;
            private int? _UniqueLabelHash;
            private int? _EquipmentSlotTypeHash;
            private int? _Attributes;
            private int? _AmmoType;
            private List<string> _DisplayStrings;

            internal DestinyDefinitionsDestinyEquippingBlockDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyEquippingBlockDefinition.GearsetItemHash property.
            /// </summary>
            /// <param name="value">If the item is part of a gearset, this is a reference to that gearset item.</param>
            public DestinyDefinitionsDestinyEquippingBlockDefinitionBuilder GearsetItemHash(int? value)
            {
                _GearsetItemHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyEquippingBlockDefinition.UniqueLabel property.
            /// </summary>
            /// <param name="value">If defined, this is the label used to check if the item has other items of matching types already equipped.   For instance, when you aren&#39;t allowed to equip more than one Exotic Weapon, that&#39;s because all exotic weapons have identical uniqueLabels and the game checks the to-be-equipped item&#39;s uniqueLabel vs. all other already equipped items (other than the item in the slot that&#39;s about to be occupied).</param>
            public DestinyDefinitionsDestinyEquippingBlockDefinitionBuilder UniqueLabel(string value)
            {
                _UniqueLabel = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyEquippingBlockDefinition.UniqueLabelHash property.
            /// </summary>
            /// <param name="value">The hash of that unique label. Does not point to a specific definition.</param>
            public DestinyDefinitionsDestinyEquippingBlockDefinitionBuilder UniqueLabelHash(int? value)
            {
                _UniqueLabelHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyEquippingBlockDefinition.EquipmentSlotTypeHash property.
            /// </summary>
            /// <param name="value">An equipped item *must* be equipped in an Equipment Slot. This is the hash identifier of the DestinyEquipmentSlotDefinition into which it must be equipped.</param>
            public DestinyDefinitionsDestinyEquippingBlockDefinitionBuilder EquipmentSlotTypeHash(int? value)
            {
                _EquipmentSlotTypeHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyEquippingBlockDefinition.Attributes property.
            /// </summary>
            /// <param name="value">These are custom attributes on the equippability of the item.  For now, this can only be \&quot;equip on acquire\&quot;, which would mean that the item will be automatically equipped as soon as you pick it up.</param>
            public DestinyDefinitionsDestinyEquippingBlockDefinitionBuilder Attributes(int? value)
            {
                _Attributes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyEquippingBlockDefinition.AmmoType property.
            /// </summary>
            /// <param name="value">Ammo type used by a weapon is no longer determined by the bucket in which it is contained. If the item has an ammo type - i.e. if it is a weapon - this will be the type of ammunition expected.</param>
            public DestinyDefinitionsDestinyEquippingBlockDefinitionBuilder AmmoType(int? value)
            {
                _AmmoType = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyEquippingBlockDefinition.DisplayStrings property.
            /// </summary>
            /// <param name="value">These are strings that represent the possible Game/Account/Character state failure conditions that can occur when trying to equip the item. They match up one-to-one with requiredUnlockExpressions.</param>
            public DestinyDefinitionsDestinyEquippingBlockDefinitionBuilder DisplayStrings(List<string> value)
            {
                _DisplayStrings = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyEquippingBlockDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyEquippingBlockDefinition</returns>
            public DestinyDefinitionsDestinyEquippingBlockDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyEquippingBlockDefinition(
                    GearsetItemHash: _GearsetItemHash,
                    UniqueLabel: _UniqueLabel,
                    UniqueLabelHash: _UniqueLabelHash,
                    EquipmentSlotTypeHash: _EquipmentSlotTypeHash,
                    Attributes: _Attributes,
                    AmmoType: _AmmoType,
                    DisplayStrings: _DisplayStrings
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}