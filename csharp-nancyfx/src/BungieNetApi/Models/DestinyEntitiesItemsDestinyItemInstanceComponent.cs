using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// If an item is \&quot;instanced\&quot;, this will contain information about the item&#39;s instance that doesn&#39;t fit easily into other components. One might say this is the \&quot;essential\&quot; instance data for the item.  Items are instanced if they require information or state that can vary. For instance, weapons are Instanced: they are given a unique identifier, uniquely generated stats, and can have their properties altered. Non-instanced items have none of these things: for instance, Glimmer has no unique properties aside from how much of it you own.  You can tell from an item&#39;s definition whether it will be instanced or not by looking at the DestinyInventoryItemDefinition&#39;s definition.inventory.isInstanceItem property.
    /// </summary>
    public sealed class DestinyEntitiesItemsDestinyItemInstanceComponent:  IEquatable<DestinyEntitiesItemsDestinyItemInstanceComponent>
    { 
        /// <summary>
        /// If the item has a damage type, this is the item&#39;s current damage type.
        /// </summary>
        public int? DamageType { get; private set; }

        /// <summary>
        /// The current damage type&#39;s hash, so you can look up localized info and icons for it.
        /// </summary>
        public int? DamageTypeHash { get; private set; }

        /// <summary>
        /// The item stat that we consider to be \&quot;primary\&quot; for the item. For instance, this would be \&quot;Attack\&quot; for Weapons or \&quot;Defense\&quot; for armor.
        /// </summary>
        public DestinyDestinyStat PrimaryStat { get; private set; }

        /// <summary>
        /// The Item&#39;s \&quot;Level\&quot; has the most significant bearing on its stats, such as Light and Power.
        /// </summary>
        public int? ItemLevel { get; private set; }

        /// <summary>
        /// The \&quot;Quality\&quot; of the item has a lesser - but still impactful - bearing on stats like Light and Power.
        /// </summary>
        public int? Quality { get; private set; }

        /// <summary>
        /// Is the item currently equipped on the given character?
        /// </summary>
        public bool? IsEquipped { get; private set; }

        /// <summary>
        /// If this is an equippable item, you can check it here. There are permanent as well as transitory reasons why an item might not be able to be equipped: check cannotEquipReason for details.
        /// </summary>
        public bool? CanEquip { get; private set; }

        /// <summary>
        /// If the item cannot be equipped until you reach a certain level, that level will be reflected here.
        /// </summary>
        public int? EquipRequiredLevel { get; private set; }

        /// <summary>
        /// Sometimes, there are limitations to equipping that are represented by character-level flags called \&quot;unlocks\&quot;.  This is a list of flags that they need in order to equip the item that the character has not met. Use these to look up the descriptions to show in your UI by looking up the relevant DestinyUnlockDefinitions for the hashes.
        /// </summary>
        public List<int?> UnlockHashesRequiredToEquip { get; private set; }

        /// <summary>
        /// If you cannot equip the item, this is a flags enum that enumerates all of the reasons why you couldn&#39;t equip the item. You may need to refine your UI further by using unlockHashesRequiredToEquip and equipRequiredLevel.
        /// </summary>
        public int? CannotEquipReason { get; private set; }

        /// <summary>
        /// If populated, this item has a breaker type corresponding to the given value. See DestinyBreakerTypeDefinition for more details.
        /// </summary>
        public BreakerTypeEnum? BreakerType { get; private set; }

        /// <summary>
        /// If populated, this is the hash identifier for the item&#39;s breaker type. See DestinyBreakerTypeDefinition for more details.
        /// </summary>
        public int? BreakerTypeHash { get; private set; }

        /// <summary>
        /// IF populated, this item supports Energy mechanics (i.e. Armor 2.0), and these are the current details of its energy type and available capacity to spend energy points.
        /// </summary>
        public DestinyEntitiesItemsDestinyItemInstanceEnergy Energy { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyEntitiesItemsDestinyItemInstanceComponent.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyEntitiesItemsDestinyItemInstanceComponent()
        {
        }

        private DestinyEntitiesItemsDestinyItemInstanceComponent(int? DamageType, int? DamageTypeHash, DestinyDestinyStat PrimaryStat, int? ItemLevel, int? Quality, bool? IsEquipped, bool? CanEquip, int? EquipRequiredLevel, List<int?> UnlockHashesRequiredToEquip, int? CannotEquipReason, BreakerTypeEnum? BreakerType, int? BreakerTypeHash, DestinyEntitiesItemsDestinyItemInstanceEnergy Energy)
        {
            
            this.DamageType = DamageType;
            
            this.DamageTypeHash = DamageTypeHash;
            
            this.PrimaryStat = PrimaryStat;
            
            this.ItemLevel = ItemLevel;
            
            this.Quality = Quality;
            
            this.IsEquipped = IsEquipped;
            
            this.CanEquip = CanEquip;
            
            this.EquipRequiredLevel = EquipRequiredLevel;
            
            this.UnlockHashesRequiredToEquip = UnlockHashesRequiredToEquip;
            
            this.CannotEquipReason = CannotEquipReason;
            
            this.BreakerType = BreakerType;
            
            this.BreakerTypeHash = BreakerTypeHash;
            
            this.Energy = Energy;
            
        }

        /// <summary>
        /// Returns builder of DestinyEntitiesItemsDestinyItemInstanceComponent.
        /// </summary>
        /// <returns>DestinyEntitiesItemsDestinyItemInstanceComponentBuilder</returns>
        public static DestinyEntitiesItemsDestinyItemInstanceComponentBuilder Builder()
        {
            return new DestinyEntitiesItemsDestinyItemInstanceComponentBuilder();
        }

        /// <summary>
        /// Returns DestinyEntitiesItemsDestinyItemInstanceComponentBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyEntitiesItemsDestinyItemInstanceComponentBuilder</returns>
        public DestinyEntitiesItemsDestinyItemInstanceComponentBuilder With()
        {
            return Builder()
                .DamageType(DamageType)
                .DamageTypeHash(DamageTypeHash)
                .PrimaryStat(PrimaryStat)
                .ItemLevel(ItemLevel)
                .Quality(Quality)
                .IsEquipped(IsEquipped)
                .CanEquip(CanEquip)
                .EquipRequiredLevel(EquipRequiredLevel)
                .UnlockHashesRequiredToEquip(UnlockHashesRequiredToEquip)
                .CannotEquipReason(CannotEquipReason)
                .BreakerType(BreakerType)
                .BreakerTypeHash(BreakerTypeHash)
                .Energy(Energy);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyEntitiesItemsDestinyItemInstanceComponent other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyEntitiesItemsDestinyItemInstanceComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyEntitiesItemsDestinyItemInstanceComponent</param>
        /// <param name="right">Compared (DestinyEntitiesItemsDestinyItemInstanceComponent</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyEntitiesItemsDestinyItemInstanceComponent left, DestinyEntitiesItemsDestinyItemInstanceComponent right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyEntitiesItemsDestinyItemInstanceComponent.
        /// </summary>
        /// <param name="left">Compared (DestinyEntitiesItemsDestinyItemInstanceComponent</param>
        /// <param name="right">Compared (DestinyEntitiesItemsDestinyItemInstanceComponent</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyEntitiesItemsDestinyItemInstanceComponent left, DestinyEntitiesItemsDestinyItemInstanceComponent right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyEntitiesItemsDestinyItemInstanceComponent.
        /// </summary>
        public sealed class DestinyEntitiesItemsDestinyItemInstanceComponentBuilder
        {
            private int? _DamageType;
            private int? _DamageTypeHash;
            private DestinyDestinyStat _PrimaryStat;
            private int? _ItemLevel;
            private int? _Quality;
            private bool? _IsEquipped;
            private bool? _CanEquip;
            private int? _EquipRequiredLevel;
            private List<int?> _UnlockHashesRequiredToEquip;
            private int? _CannotEquipReason;
            private BreakerTypeEnum? _BreakerType;
            private int? _BreakerTypeHash;
            private DestinyEntitiesItemsDestinyItemInstanceEnergy _Energy;

            internal DestinyEntitiesItemsDestinyItemInstanceComponentBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyEntitiesItemsDestinyItemInstanceComponent.DamageType property.
            /// </summary>
            /// <param name="value">If the item has a damage type, this is the item&#39;s current damage type.</param>
            public DestinyEntitiesItemsDestinyItemInstanceComponentBuilder DamageType(int? value)
            {
                _DamageType = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesItemsDestinyItemInstanceComponent.DamageTypeHash property.
            /// </summary>
            /// <param name="value">The current damage type&#39;s hash, so you can look up localized info and icons for it.</param>
            public DestinyEntitiesItemsDestinyItemInstanceComponentBuilder DamageTypeHash(int? value)
            {
                _DamageTypeHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesItemsDestinyItemInstanceComponent.PrimaryStat property.
            /// </summary>
            /// <param name="value">The item stat that we consider to be \&quot;primary\&quot; for the item. For instance, this would be \&quot;Attack\&quot; for Weapons or \&quot;Defense\&quot; for armor.</param>
            public DestinyEntitiesItemsDestinyItemInstanceComponentBuilder PrimaryStat(DestinyDestinyStat value)
            {
                _PrimaryStat = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesItemsDestinyItemInstanceComponent.ItemLevel property.
            /// </summary>
            /// <param name="value">The Item&#39;s \&quot;Level\&quot; has the most significant bearing on its stats, such as Light and Power.</param>
            public DestinyEntitiesItemsDestinyItemInstanceComponentBuilder ItemLevel(int? value)
            {
                _ItemLevel = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesItemsDestinyItemInstanceComponent.Quality property.
            /// </summary>
            /// <param name="value">The \&quot;Quality\&quot; of the item has a lesser - but still impactful - bearing on stats like Light and Power.</param>
            public DestinyEntitiesItemsDestinyItemInstanceComponentBuilder Quality(int? value)
            {
                _Quality = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesItemsDestinyItemInstanceComponent.IsEquipped property.
            /// </summary>
            /// <param name="value">Is the item currently equipped on the given character?</param>
            public DestinyEntitiesItemsDestinyItemInstanceComponentBuilder IsEquipped(bool? value)
            {
                _IsEquipped = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesItemsDestinyItemInstanceComponent.CanEquip property.
            /// </summary>
            /// <param name="value">If this is an equippable item, you can check it here. There are permanent as well as transitory reasons why an item might not be able to be equipped: check cannotEquipReason for details.</param>
            public DestinyEntitiesItemsDestinyItemInstanceComponentBuilder CanEquip(bool? value)
            {
                _CanEquip = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesItemsDestinyItemInstanceComponent.EquipRequiredLevel property.
            /// </summary>
            /// <param name="value">If the item cannot be equipped until you reach a certain level, that level will be reflected here.</param>
            public DestinyEntitiesItemsDestinyItemInstanceComponentBuilder EquipRequiredLevel(int? value)
            {
                _EquipRequiredLevel = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesItemsDestinyItemInstanceComponent.UnlockHashesRequiredToEquip property.
            /// </summary>
            /// <param name="value">Sometimes, there are limitations to equipping that are represented by character-level flags called \&quot;unlocks\&quot;.  This is a list of flags that they need in order to equip the item that the character has not met. Use these to look up the descriptions to show in your UI by looking up the relevant DestinyUnlockDefinitions for the hashes.</param>
            public DestinyEntitiesItemsDestinyItemInstanceComponentBuilder UnlockHashesRequiredToEquip(List<int?> value)
            {
                _UnlockHashesRequiredToEquip = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesItemsDestinyItemInstanceComponent.CannotEquipReason property.
            /// </summary>
            /// <param name="value">If you cannot equip the item, this is a flags enum that enumerates all of the reasons why you couldn&#39;t equip the item. You may need to refine your UI further by using unlockHashesRequiredToEquip and equipRequiredLevel.</param>
            public DestinyEntitiesItemsDestinyItemInstanceComponentBuilder CannotEquipReason(int? value)
            {
                _CannotEquipReason = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesItemsDestinyItemInstanceComponent.BreakerType property.
            /// </summary>
            /// <param name="value">If populated, this item has a breaker type corresponding to the given value. See DestinyBreakerTypeDefinition for more details.</param>
            public DestinyEntitiesItemsDestinyItemInstanceComponentBuilder BreakerType(BreakerTypeEnum? value)
            {
                _BreakerType = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesItemsDestinyItemInstanceComponent.BreakerTypeHash property.
            /// </summary>
            /// <param name="value">If populated, this is the hash identifier for the item&#39;s breaker type. See DestinyBreakerTypeDefinition for more details.</param>
            public DestinyEntitiesItemsDestinyItemInstanceComponentBuilder BreakerTypeHash(int? value)
            {
                _BreakerTypeHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesItemsDestinyItemInstanceComponent.Energy property.
            /// </summary>
            /// <param name="value">IF populated, this item supports Energy mechanics (i.e. Armor 2.0), and these are the current details of its energy type and available capacity to spend energy points.</param>
            public DestinyEntitiesItemsDestinyItemInstanceComponentBuilder Energy(DestinyEntitiesItemsDestinyItemInstanceEnergy value)
            {
                _Energy = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyEntitiesItemsDestinyItemInstanceComponent.
            /// </summary>
            /// <returns>DestinyEntitiesItemsDestinyItemInstanceComponent</returns>
            public DestinyEntitiesItemsDestinyItemInstanceComponent Build()
            {
                Validate();
                return new DestinyEntitiesItemsDestinyItemInstanceComponent(
                    DamageType: _DamageType,
                    DamageTypeHash: _DamageTypeHash,
                    PrimaryStat: _PrimaryStat,
                    ItemLevel: _ItemLevel,
                    Quality: _Quality,
                    IsEquipped: _IsEquipped,
                    CanEquip: _CanEquip,
                    EquipRequiredLevel: _EquipRequiredLevel,
                    UnlockHashesRequiredToEquip: _UnlockHashesRequiredToEquip,
                    CannotEquipReason: _CannotEquipReason,
                    BreakerType: _BreakerType,
                    BreakerTypeHash: _BreakerTypeHash,
                    Energy: _Energy
                );
            }

            private void Validate()
            { 
            }
        }

        
        public enum BreakerTypeEnum { _0, _1, _2, _3 };
    }
}