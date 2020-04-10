using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// The definition of a specific reward, which may be contained in a category of rewards and that has optional information about how it is obtained.
    /// </summary>
    public sealed class DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinition:  IEquatable<DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinition>
    { 
        /// <summary>
        /// The identifier for this reward entry. Runtime data will refer to reward entries by this hash. Only guaranteed unique within the specific Milestone.
        /// </summary>
        public int? RewardEntryHash { get; private set; }

        /// <summary>
        /// The string identifier, if you care about it. Only guaranteed unique within the specific Milestone.
        /// </summary>
        public string RewardEntryIdentifier { get; private set; }

        /// <summary>
        /// The items you will get as rewards, and how much of it you&#39;ll get.
        /// </summary>
        public List<DestinyDestinyItemQuantity> Items { get; private set; }

        /// <summary>
        /// If this reward is redeemed at a Vendor, this is the hash of the Vendor to go to in order to redeem the reward. Use this hash to look up the DestinyVendorDefinition.
        /// </summary>
        public int? VendorHash { get; private set; }

        /// <summary>
        /// For us to bother returning this info, we should be able to return some kind of information about why these rewards are grouped together. This is ideally that information. Look at how confident I am that this will always remain true.
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; private set; }

        /// <summary>
        /// If you want to follow BNet&#39;s ordering of these rewards, use this number within a given category to order the rewards. Yeah, I know. I feel dirty too.
        /// </summary>
        public int? Order { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinition()
        {
        }

        private DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinition(int? RewardEntryHash, string RewardEntryIdentifier, List<DestinyDestinyItemQuantity> Items, int? VendorHash, DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties, int? Order)
        {
            
            this.RewardEntryHash = RewardEntryHash;
            
            this.RewardEntryIdentifier = RewardEntryIdentifier;
            
            this.Items = Items;
            
            this.VendorHash = VendorHash;
            
            this.DisplayProperties = DisplayProperties;
            
            this.Order = Order;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinitionBuilder</returns>
        public static DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinitionBuilder</returns>
        public DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinitionBuilder With()
        {
            return Builder()
                .RewardEntryHash(RewardEntryHash)
                .RewardEntryIdentifier(RewardEntryIdentifier)
                .Items(Items)
                .VendorHash(VendorHash)
                .DisplayProperties(DisplayProperties)
                .Order(Order);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinition left, DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinition left, DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinitionBuilder
        {
            private int? _RewardEntryHash;
            private string _RewardEntryIdentifier;
            private List<DestinyDestinyItemQuantity> _Items;
            private int? _VendorHash;
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _DisplayProperties;
            private int? _Order;

            internal DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinition.RewardEntryHash property.
            /// </summary>
            /// <param name="value">The identifier for this reward entry. Runtime data will refer to reward entries by this hash. Only guaranteed unique within the specific Milestone.</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinitionBuilder RewardEntryHash(int? value)
            {
                _RewardEntryHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinition.RewardEntryIdentifier property.
            /// </summary>
            /// <param name="value">The string identifier, if you care about it. Only guaranteed unique within the specific Milestone.</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinitionBuilder RewardEntryIdentifier(string value)
            {
                _RewardEntryIdentifier = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinition.Items property.
            /// </summary>
            /// <param name="value">The items you will get as rewards, and how much of it you&#39;ll get.</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinitionBuilder Items(List<DestinyDestinyItemQuantity> value)
            {
                _Items = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinition.VendorHash property.
            /// </summary>
            /// <param name="value">If this reward is redeemed at a Vendor, this is the hash of the Vendor to go to in order to redeem the reward. Use this hash to look up the DestinyVendorDefinition.</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinitionBuilder VendorHash(int? value)
            {
                _VendorHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinition.DisplayProperties property.
            /// </summary>
            /// <param name="value">For us to bother returning this info, we should be able to return some kind of information about why these rewards are grouped together. This is ideally that information. Look at how confident I am that this will always remain true.</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinitionBuilder DisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _DisplayProperties = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinition.Order property.
            /// </summary>
            /// <param name="value">If you want to follow BNet&#39;s ordering of these rewards, use this number within a given category to order the rewards. Yeah, I know. I feel dirty too.</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinitionBuilder Order(int? value)
            {
                _Order = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinition</returns>
            public DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinition(
                    RewardEntryHash: _RewardEntryHash,
                    RewardEntryIdentifier: _RewardEntryIdentifier,
                    Items: _Items,
                    VendorHash: _VendorHash,
                    DisplayProperties: _DisplayProperties,
                    Order: _Order
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}