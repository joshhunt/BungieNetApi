using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// A subclass of DestinyItemQuantity, that provides not just the item and its quantity but also information that BNet can - at some point - use internally to provide more robust runtime information about the item&#39;s qualities.  If you want it, please ask! We&#39;re just out of time to wire it up right now. Or a clever person just may do it with our existing endpoints.
    /// </summary>
    public sealed class DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardItem:  IEquatable<DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardItem>
    { 
        /// <summary>
        /// The quest reward item *may* be associated with a vendor. If so, this is that vendor. Use this hash to look up the DestinyVendorDefinition.
        /// </summary>
        public int? VendorHash { get; private set; }

        /// <summary>
        /// The quest reward item *may* be associated with a vendor. If so, this is the index of the item being sold, which we can use at runtime to find instanced item information for the reward item.
        /// </summary>
        public int? VendorItemIndex { get; private set; }

        /// <summary>
        /// The hash identifier for the item in question. Use it to look up the item&#39;s DestinyInventoryItemDefinition.
        /// </summary>
        public int? ItemHash { get; private set; }

        /// <summary>
        /// If this quantity is referring to a specific instance of an item, this will have the item&#39;s instance ID. Normally, this will be null.
        /// </summary>
        public long? ItemInstanceId { get; private set; }

        /// <summary>
        /// The amount of the item needed/available depending on the context of where DestinyItemQuantity is being used.
        /// </summary>
        public int? Quantity { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardItem.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardItem()
        {
        }

        private DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardItem(int? VendorHash, int? VendorItemIndex, int? ItemHash, long? ItemInstanceId, int? Quantity)
        {
            
            this.VendorHash = VendorHash;
            
            this.VendorItemIndex = VendorItemIndex;
            
            this.ItemHash = ItemHash;
            
            this.ItemInstanceId = ItemInstanceId;
            
            this.Quantity = Quantity;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardItem.
        /// </summary>
        /// <returns>DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardItemBuilder</returns>
        public static DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardItemBuilder Builder()
        {
            return new DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardItemBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardItemBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardItemBuilder</returns>
        public DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardItemBuilder With()
        {
            return Builder()
                .VendorHash(VendorHash)
                .VendorItemIndex(VendorItemIndex)
                .ItemHash(ItemHash)
                .ItemInstanceId(ItemInstanceId)
                .Quantity(Quantity);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardItem other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardItem.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardItem</param>
        /// <param name="right">Compared (DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardItem</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardItem left, DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardItem right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardItem.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardItem</param>
        /// <param name="right">Compared (DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardItem</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardItem left, DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardItem right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardItem.
        /// </summary>
        public sealed class DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardItemBuilder
        {
            private int? _VendorHash;
            private int? _VendorItemIndex;
            private int? _ItemHash;
            private long? _ItemInstanceId;
            private int? _Quantity;

            internal DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardItemBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardItem.VendorHash property.
            /// </summary>
            /// <param name="value">The quest reward item *may* be associated with a vendor. If so, this is that vendor. Use this hash to look up the DestinyVendorDefinition.</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardItemBuilder VendorHash(int? value)
            {
                _VendorHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardItem.VendorItemIndex property.
            /// </summary>
            /// <param name="value">The quest reward item *may* be associated with a vendor. If so, this is the index of the item being sold, which we can use at runtime to find instanced item information for the reward item.</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardItemBuilder VendorItemIndex(int? value)
            {
                _VendorItemIndex = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardItem.ItemHash property.
            /// </summary>
            /// <param name="value">The hash identifier for the item in question. Use it to look up the item&#39;s DestinyInventoryItemDefinition.</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardItemBuilder ItemHash(int? value)
            {
                _ItemHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardItem.ItemInstanceId property.
            /// </summary>
            /// <param name="value">If this quantity is referring to a specific instance of an item, this will have the item&#39;s instance ID. Normally, this will be null.</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardItemBuilder ItemInstanceId(long? value)
            {
                _ItemInstanceId = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardItem.Quantity property.
            /// </summary>
            /// <param name="value">The amount of the item needed/available depending on the context of where DestinyItemQuantity is being used.</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardItemBuilder Quantity(int? value)
            {
                _Quantity = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardItem.
            /// </summary>
            /// <returns>DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardItem</returns>
            public DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardItem Build()
            {
                Validate();
                return new DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardItem(
                    VendorHash: _VendorHash,
                    VendorItemIndex: _VendorItemIndex,
                    ItemHash: _ItemHash,
                    ItemInstanceId: _ItemInstanceId,
                    Quantity: _Quantity
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}