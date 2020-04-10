using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// An Inventory (be it Character or Profile level) is comprised of many Buckets. An example of a bucket is \&quot;Primary Weapons\&quot;, where all of the primary weapons on a character are gathered together into a single visual element in the UI: a subset of the inventory that has a limited number of slots, and in this case also has an associated Equipment Slot for equipping an item in the bucket.  Item definitions declare what their \&quot;default\&quot; bucket is (DestinyInventoryItemDefinition.inventory.bucketTypeHash), and Item instances will tell you which bucket they are currently residing in (DestinyItemComponent.bucketHash). You can use this information along with the DestinyInventoryBucketDefinition to show these items grouped by bucket.  You cannot transfer an item to a bucket that is not its Default without going through a Vendor&#39;s \&quot;accepted items\&quot; (DestinyVendorDefinition.acceptedItems). This is how transfer functionality like the Vault is implemented, as a feature of a Vendor. See the vendor&#39;s acceptedItems property for more details.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyInventoryBucketDefinition:  IEquatable<DestinyDefinitionsDestinyInventoryBucketDefinition>
    { 
        /// <summary>
        /// DisplayProperties
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; private set; }

        /// <summary>
        /// Where the bucket is found. 0 &#x3D; Character, 1 &#x3D; Account
        /// </summary>
        public int? Scope { get; private set; }

        /// <summary>
        /// An enum value for what items can be found in the bucket. See the BucketCategory enum for more details.
        /// </summary>
        public int? Category { get; private set; }

        /// <summary>
        /// Use this property to provide a quick-and-dirty recommended ordering for buckets in the UI. Most UIs will likely want to forsake this for something more custom and manual.
        /// </summary>
        public int? BucketOrder { get; private set; }

        /// <summary>
        /// The maximum # of item \&quot;slots\&quot; in a bucket. A slot is a given combination of item + quantity.  For instance, a Weapon will always take up a single slot, and always have a quantity of 1. But a material could take up only a single slot with hundreds of quantity.
        /// </summary>
        public int? ItemCount { get; private set; }

        /// <summary>
        /// Sometimes, inventory buckets represent conceptual \&quot;locations\&quot; in the game that might not be expected. This value indicates the conceptual location of the bucket, regardless of where it is actually contained on the character/account.   See ItemLocation for details.   Note that location includes the Vault and the Postmaster (both of whom being just inventory buckets with additional actions that can be performed on them through a Vendor)
        /// </summary>
        public int? Location { get; private set; }

        /// <summary>
        /// If TRUE, there is at least one Vendor that can transfer items to/from this bucket. See the DestinyVendorDefinition&#39;s acceptedItems property for more information on how transferring works.
        /// </summary>
        public bool? HasTransferDestination { get; private set; }

        /// <summary>
        /// If True, this bucket is enabled. Disabled buckets may include buckets that were included for test purposes, or that were going to be used but then were abandoned but never removed from content *cough*.
        /// </summary>
        public bool? Enabled { get; private set; }

        /// <summary>
        /// if a FIFO bucket fills up, it will delete the oldest item from said bucket when a new item tries to be added to it. If this is FALSE, the bucket will not allow new items to be placed in it until room is made by the user manually deleting items from it. You can see an example of this with the Postmaster&#39;s bucket.
        /// </summary>
        public bool? Fifo { get; private set; }

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
        /// Use DestinyDefinitionsDestinyInventoryBucketDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyInventoryBucketDefinition()
        {
        }

        private DestinyDefinitionsDestinyInventoryBucketDefinition(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties, int? Scope, int? Category, int? BucketOrder, int? ItemCount, int? Location, bool? HasTransferDestination, bool? Enabled, bool? Fifo, int? Hash, int? Index, bool? Redacted)
        {
            
            this.DisplayProperties = DisplayProperties;
            
            this.Scope = Scope;
            
            this.Category = Category;
            
            this.BucketOrder = BucketOrder;
            
            this.ItemCount = ItemCount;
            
            this.Location = Location;
            
            this.HasTransferDestination = HasTransferDestination;
            
            this.Enabled = Enabled;
            
            this.Fifo = Fifo;
            
            this.Hash = Hash;
            
            this.Index = Index;
            
            this.Redacted = Redacted;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyInventoryBucketDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyInventoryBucketDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyInventoryBucketDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyInventoryBucketDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyInventoryBucketDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyInventoryBucketDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyInventoryBucketDefinitionBuilder With()
        {
            return Builder()
                .DisplayProperties(DisplayProperties)
                .Scope(Scope)
                .Category(Category)
                .BucketOrder(BucketOrder)
                .ItemCount(ItemCount)
                .Location(Location)
                .HasTransferDestination(HasTransferDestination)
                .Enabled(Enabled)
                .Fifo(Fifo)
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

        public bool Equals(DestinyDefinitionsDestinyInventoryBucketDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyInventoryBucketDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyInventoryBucketDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyInventoryBucketDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyInventoryBucketDefinition left, DestinyDefinitionsDestinyInventoryBucketDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyInventoryBucketDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyInventoryBucketDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyInventoryBucketDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyInventoryBucketDefinition left, DestinyDefinitionsDestinyInventoryBucketDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyInventoryBucketDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyInventoryBucketDefinitionBuilder
        {
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _DisplayProperties;
            private int? _Scope;
            private int? _Category;
            private int? _BucketOrder;
            private int? _ItemCount;
            private int? _Location;
            private bool? _HasTransferDestination;
            private bool? _Enabled;
            private bool? _Fifo;
            private int? _Hash;
            private int? _Index;
            private bool? _Redacted;

            internal DestinyDefinitionsDestinyInventoryBucketDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryBucketDefinition.DisplayProperties property.
            /// </summary>
            /// <param name="value">DisplayProperties</param>
            public DestinyDefinitionsDestinyInventoryBucketDefinitionBuilder DisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _DisplayProperties = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryBucketDefinition.Scope property.
            /// </summary>
            /// <param name="value">Where the bucket is found. 0 &#x3D; Character, 1 &#x3D; Account</param>
            public DestinyDefinitionsDestinyInventoryBucketDefinitionBuilder Scope(int? value)
            {
                _Scope = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryBucketDefinition.Category property.
            /// </summary>
            /// <param name="value">An enum value for what items can be found in the bucket. See the BucketCategory enum for more details.</param>
            public DestinyDefinitionsDestinyInventoryBucketDefinitionBuilder Category(int? value)
            {
                _Category = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryBucketDefinition.BucketOrder property.
            /// </summary>
            /// <param name="value">Use this property to provide a quick-and-dirty recommended ordering for buckets in the UI. Most UIs will likely want to forsake this for something more custom and manual.</param>
            public DestinyDefinitionsDestinyInventoryBucketDefinitionBuilder BucketOrder(int? value)
            {
                _BucketOrder = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryBucketDefinition.ItemCount property.
            /// </summary>
            /// <param name="value">The maximum # of item \&quot;slots\&quot; in a bucket. A slot is a given combination of item + quantity.  For instance, a Weapon will always take up a single slot, and always have a quantity of 1. But a material could take up only a single slot with hundreds of quantity.</param>
            public DestinyDefinitionsDestinyInventoryBucketDefinitionBuilder ItemCount(int? value)
            {
                _ItemCount = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryBucketDefinition.Location property.
            /// </summary>
            /// <param name="value">Sometimes, inventory buckets represent conceptual \&quot;locations\&quot; in the game that might not be expected. This value indicates the conceptual location of the bucket, regardless of where it is actually contained on the character/account.   See ItemLocation for details.   Note that location includes the Vault and the Postmaster (both of whom being just inventory buckets with additional actions that can be performed on them through a Vendor)</param>
            public DestinyDefinitionsDestinyInventoryBucketDefinitionBuilder Location(int? value)
            {
                _Location = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryBucketDefinition.HasTransferDestination property.
            /// </summary>
            /// <param name="value">If TRUE, there is at least one Vendor that can transfer items to/from this bucket. See the DestinyVendorDefinition&#39;s acceptedItems property for more information on how transferring works.</param>
            public DestinyDefinitionsDestinyInventoryBucketDefinitionBuilder HasTransferDestination(bool? value)
            {
                _HasTransferDestination = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryBucketDefinition.Enabled property.
            /// </summary>
            /// <param name="value">If True, this bucket is enabled. Disabled buckets may include buckets that were included for test purposes, or that were going to be used but then were abandoned but never removed from content *cough*.</param>
            public DestinyDefinitionsDestinyInventoryBucketDefinitionBuilder Enabled(bool? value)
            {
                _Enabled = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryBucketDefinition.Fifo property.
            /// </summary>
            /// <param name="value">if a FIFO bucket fills up, it will delete the oldest item from said bucket when a new item tries to be added to it. If this is FALSE, the bucket will not allow new items to be placed in it until room is made by the user manually deleting items from it. You can see an example of this with the Postmaster&#39;s bucket.</param>
            public DestinyDefinitionsDestinyInventoryBucketDefinitionBuilder Fifo(bool? value)
            {
                _Fifo = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryBucketDefinition.Hash property.
            /// </summary>
            /// <param name="value">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</param>
            public DestinyDefinitionsDestinyInventoryBucketDefinitionBuilder Hash(int? value)
            {
                _Hash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryBucketDefinition.Index property.
            /// </summary>
            /// <param name="value">The index of the entity as it was found in the investment tables.</param>
            public DestinyDefinitionsDestinyInventoryBucketDefinitionBuilder Index(int? value)
            {
                _Index = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyInventoryBucketDefinition.Redacted property.
            /// </summary>
            /// <param name="value">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</param>
            public DestinyDefinitionsDestinyInventoryBucketDefinitionBuilder Redacted(bool? value)
            {
                _Redacted = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyInventoryBucketDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyInventoryBucketDefinition</returns>
            public DestinyDefinitionsDestinyInventoryBucketDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyInventoryBucketDefinition(
                    DisplayProperties: _DisplayProperties,
                    Scope: _Scope,
                    Category: _Category,
                    BucketOrder: _BucketOrder,
                    ItemCount: _ItemCount,
                    Location: _Location,
                    HasTransferDestination: _HasTransferDestination,
                    Enabled: _Enabled,
                    Fifo: _Fifo,
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