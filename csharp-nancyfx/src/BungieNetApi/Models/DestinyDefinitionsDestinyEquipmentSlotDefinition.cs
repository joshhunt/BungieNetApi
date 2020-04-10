using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Characters can not only have Inventory buckets (containers of items that are generally matched by their type or functionality), they can also have Equipment Slots.  The Equipment Slot is an indicator that the related bucket can have instanced items equipped on the character. For instance, the Primary Weapon bucket has an Equipment Slot that determines whether you can equip primary weapons, and holds the association between its slot and the inventory bucket from which it can have items equipped.  An Equipment Slot must have a related Inventory Bucket, but not all inventory buckets must have Equipment Slots.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyEquipmentSlotDefinition:  IEquatable<DestinyDefinitionsDestinyEquipmentSlotDefinition>
    { 
        /// <summary>
        /// DisplayProperties
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; private set; }

        /// <summary>
        /// These technically point to \&quot;Equipment Category Definitions\&quot;. But don&#39;t get excited. There&#39;s nothing of significant value in those definitions, so I didn&#39;t bother to expose them. You can use the hash here to group equipment slots by common functionality, which serves the same purpose as if we had the Equipment Category definitions exposed.
        /// </summary>
        public int? EquipmentCategoryHash { get; private set; }

        /// <summary>
        /// The inventory bucket that owns this equipment slot.
        /// </summary>
        public int? BucketTypeHash { get; private set; }

        /// <summary>
        /// If True, equipped items should have their custom art dyes applied when rendering the item. Otherwise, custom art dyes on an item should be ignored if the item is equipped in this slot.
        /// </summary>
        public bool? ApplyCustomArtDyes { get; private set; }

        /// <summary>
        /// The Art Dye Channels that apply to this equipment slot.
        /// </summary>
        public List<DestinyDefinitionsDestinyArtDyeReference> ArtDyeChannels { get; private set; }

        /// <summary>
        /// The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.
        /// </summary>
        public int? Hash { get; private set; }

        /// <summary>
        /// The index of the entity as it was found in the investment tables.
        /// </summary>
        public int? Index { get; private set; }

        /// <summary>
        /// If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!
        /// </summary>
        public bool? Redacted { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyEquipmentSlotDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyEquipmentSlotDefinition()
        {
        }

        private DestinyDefinitionsDestinyEquipmentSlotDefinition(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties, int? EquipmentCategoryHash, int? BucketTypeHash, bool? ApplyCustomArtDyes, List<DestinyDefinitionsDestinyArtDyeReference> ArtDyeChannels, int? Hash, int? Index, bool? Redacted)
        {
            
            this.DisplayProperties = DisplayProperties;
            
            this.EquipmentCategoryHash = EquipmentCategoryHash;
            
            this.BucketTypeHash = BucketTypeHash;
            
            this.ApplyCustomArtDyes = ApplyCustomArtDyes;
            
            this.ArtDyeChannels = ArtDyeChannels;
            
            this.Hash = Hash;
            
            this.Index = Index;
            
            this.Redacted = Redacted;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyEquipmentSlotDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyEquipmentSlotDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyEquipmentSlotDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyEquipmentSlotDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyEquipmentSlotDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyEquipmentSlotDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyEquipmentSlotDefinitionBuilder With()
        {
            return Builder()
                .DisplayProperties(DisplayProperties)
                .EquipmentCategoryHash(EquipmentCategoryHash)
                .BucketTypeHash(BucketTypeHash)
                .ApplyCustomArtDyes(ApplyCustomArtDyes)
                .ArtDyeChannels(ArtDyeChannels)
                .Hash(Hash)
                .Index(Index)
                .Redacted(Redacted);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyEquipmentSlotDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyEquipmentSlotDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyEquipmentSlotDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyEquipmentSlotDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyEquipmentSlotDefinition left, DestinyDefinitionsDestinyEquipmentSlotDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyEquipmentSlotDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyEquipmentSlotDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyEquipmentSlotDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyEquipmentSlotDefinition left, DestinyDefinitionsDestinyEquipmentSlotDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyEquipmentSlotDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyEquipmentSlotDefinitionBuilder
        {
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _DisplayProperties;
            private int? _EquipmentCategoryHash;
            private int? _BucketTypeHash;
            private bool? _ApplyCustomArtDyes;
            private List<DestinyDefinitionsDestinyArtDyeReference> _ArtDyeChannels;
            private int? _Hash;
            private int? _Index;
            private bool? _Redacted;

            internal DestinyDefinitionsDestinyEquipmentSlotDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyEquipmentSlotDefinition.DisplayProperties property.
            /// </summary>
            /// <param name="value">DisplayProperties</param>
            public DestinyDefinitionsDestinyEquipmentSlotDefinitionBuilder DisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _DisplayProperties = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyEquipmentSlotDefinition.EquipmentCategoryHash property.
            /// </summary>
            /// <param name="value">These technically point to \&quot;Equipment Category Definitions\&quot;. But don&#39;t get excited. There&#39;s nothing of significant value in those definitions, so I didn&#39;t bother to expose them. You can use the hash here to group equipment slots by common functionality, which serves the same purpose as if we had the Equipment Category definitions exposed.</param>
            public DestinyDefinitionsDestinyEquipmentSlotDefinitionBuilder EquipmentCategoryHash(int? value)
            {
                _EquipmentCategoryHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyEquipmentSlotDefinition.BucketTypeHash property.
            /// </summary>
            /// <param name="value">The inventory bucket that owns this equipment slot.</param>
            public DestinyDefinitionsDestinyEquipmentSlotDefinitionBuilder BucketTypeHash(int? value)
            {
                _BucketTypeHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyEquipmentSlotDefinition.ApplyCustomArtDyes property.
            /// </summary>
            /// <param name="value">If True, equipped items should have their custom art dyes applied when rendering the item. Otherwise, custom art dyes on an item should be ignored if the item is equipped in this slot.</param>
            public DestinyDefinitionsDestinyEquipmentSlotDefinitionBuilder ApplyCustomArtDyes(bool? value)
            {
                _ApplyCustomArtDyes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyEquipmentSlotDefinition.ArtDyeChannels property.
            /// </summary>
            /// <param name="value">The Art Dye Channels that apply to this equipment slot.</param>
            public DestinyDefinitionsDestinyEquipmentSlotDefinitionBuilder ArtDyeChannels(List<DestinyDefinitionsDestinyArtDyeReference> value)
            {
                _ArtDyeChannels = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyEquipmentSlotDefinition.Hash property.
            /// </summary>
            /// <param name="value">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</param>
            public DestinyDefinitionsDestinyEquipmentSlotDefinitionBuilder Hash(int? value)
            {
                _Hash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyEquipmentSlotDefinition.Index property.
            /// </summary>
            /// <param name="value">The index of the entity as it was found in the investment tables.</param>
            public DestinyDefinitionsDestinyEquipmentSlotDefinitionBuilder Index(int? value)
            {
                _Index = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyEquipmentSlotDefinition.Redacted property.
            /// </summary>
            /// <param name="value">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</param>
            public DestinyDefinitionsDestinyEquipmentSlotDefinitionBuilder Redacted(bool? value)
            {
                _Redacted = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyEquipmentSlotDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyEquipmentSlotDefinition</returns>
            public DestinyDefinitionsDestinyEquipmentSlotDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyEquipmentSlotDefinition(
                    DisplayProperties: _DisplayProperties,
                    EquipmentCategoryHash: _EquipmentCategoryHash,
                    BucketTypeHash: _BucketTypeHash,
                    ApplyCustomArtDyes: _ApplyCustomArtDyes,
                    ArtDyeChannels: _ArtDyeChannels,
                    Hash: _Hash,
                    Index: _Index,
                    Redacted: _Redacted
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}