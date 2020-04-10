using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// The definition of a category of rewards, that contains many individual rewards.
    /// </summary>
    public sealed class DestinyDefinitionsMilestonesDestinyMilestoneRewardCategoryDefinition:  IEquatable<DestinyDefinitionsMilestonesDestinyMilestoneRewardCategoryDefinition>
    { 
        /// <summary>
        /// Identifies the reward category. Only guaranteed unique within this specific component!
        /// </summary>
        public int? CategoryHash { get; private set; }

        /// <summary>
        /// The string identifier for the category, if you want to use it for some end. Guaranteed unique within the specific component.
        /// </summary>
        public string CategoryIdentifier { get; private set; }

        /// <summary>
        /// Hopefully this is obvious by now.
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; private set; }

        /// <summary>
        /// If this milestone can provide rewards, this will define the sets of rewards that can be earned, the conditions under which they can be acquired, internal data that we&#39;ll use at runtime to determine whether you&#39;ve already earned or redeemed this set of rewards, and the category that this reward should be placed under.
        /// </summary>
        public Dictionary<string, DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinition> RewardEntries { get; private set; }

        /// <summary>
        /// If you want to use BNet&#39;s recommended order for rendering categories programmatically, use this value and compare it to other categories to determine the order in which they should be rendered. I don&#39;t feel great about putting this here, I won&#39;t lie.
        /// </summary>
        public int? Order { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsMilestonesDestinyMilestoneRewardCategoryDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsMilestonesDestinyMilestoneRewardCategoryDefinition()
        {
        }

        private DestinyDefinitionsMilestonesDestinyMilestoneRewardCategoryDefinition(int? CategoryHash, string CategoryIdentifier, DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties, Dictionary<string, DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinition> RewardEntries, int? Order)
        {
            
            this.CategoryHash = CategoryHash;
            
            this.CategoryIdentifier = CategoryIdentifier;
            
            this.DisplayProperties = DisplayProperties;
            
            this.RewardEntries = RewardEntries;
            
            this.Order = Order;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsMilestonesDestinyMilestoneRewardCategoryDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsMilestonesDestinyMilestoneRewardCategoryDefinitionBuilder</returns>
        public static DestinyDefinitionsMilestonesDestinyMilestoneRewardCategoryDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsMilestonesDestinyMilestoneRewardCategoryDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsMilestonesDestinyMilestoneRewardCategoryDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsMilestonesDestinyMilestoneRewardCategoryDefinitionBuilder</returns>
        public DestinyDefinitionsMilestonesDestinyMilestoneRewardCategoryDefinitionBuilder With()
        {
            return Builder()
                .CategoryHash(CategoryHash)
                .CategoryIdentifier(CategoryIdentifier)
                .DisplayProperties(DisplayProperties)
                .RewardEntries(RewardEntries)
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

        public bool Equals(DestinyDefinitionsMilestonesDestinyMilestoneRewardCategoryDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsMilestonesDestinyMilestoneRewardCategoryDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsMilestonesDestinyMilestoneRewardCategoryDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsMilestonesDestinyMilestoneRewardCategoryDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsMilestonesDestinyMilestoneRewardCategoryDefinition left, DestinyDefinitionsMilestonesDestinyMilestoneRewardCategoryDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsMilestonesDestinyMilestoneRewardCategoryDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsMilestonesDestinyMilestoneRewardCategoryDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsMilestonesDestinyMilestoneRewardCategoryDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsMilestonesDestinyMilestoneRewardCategoryDefinition left, DestinyDefinitionsMilestonesDestinyMilestoneRewardCategoryDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsMilestonesDestinyMilestoneRewardCategoryDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsMilestonesDestinyMilestoneRewardCategoryDefinitionBuilder
        {
            private int? _CategoryHash;
            private string _CategoryIdentifier;
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _DisplayProperties;
            private Dictionary<string, DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinition> _RewardEntries;
            private int? _Order;

            internal DestinyDefinitionsMilestonesDestinyMilestoneRewardCategoryDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneRewardCategoryDefinition.CategoryHash property.
            /// </summary>
            /// <param name="value">Identifies the reward category. Only guaranteed unique within this specific component!</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneRewardCategoryDefinitionBuilder CategoryHash(int? value)
            {
                _CategoryHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneRewardCategoryDefinition.CategoryIdentifier property.
            /// </summary>
            /// <param name="value">The string identifier for the category, if you want to use it for some end. Guaranteed unique within the specific component.</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneRewardCategoryDefinitionBuilder CategoryIdentifier(string value)
            {
                _CategoryIdentifier = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneRewardCategoryDefinition.DisplayProperties property.
            /// </summary>
            /// <param name="value">Hopefully this is obvious by now.</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneRewardCategoryDefinitionBuilder DisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _DisplayProperties = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneRewardCategoryDefinition.RewardEntries property.
            /// </summary>
            /// <param name="value">If this milestone can provide rewards, this will define the sets of rewards that can be earned, the conditions under which they can be acquired, internal data that we&#39;ll use at runtime to determine whether you&#39;ve already earned or redeemed this set of rewards, and the category that this reward should be placed under.</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneRewardCategoryDefinitionBuilder RewardEntries(Dictionary<string, DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinition> value)
            {
                _RewardEntries = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneRewardCategoryDefinition.Order property.
            /// </summary>
            /// <param name="value">If you want to use BNet&#39;s recommended order for rendering categories programmatically, use this value and compare it to other categories to determine the order in which they should be rendered. I don&#39;t feel great about putting this here, I won&#39;t lie.</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneRewardCategoryDefinitionBuilder Order(int? value)
            {
                _Order = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsMilestonesDestinyMilestoneRewardCategoryDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsMilestonesDestinyMilestoneRewardCategoryDefinition</returns>
            public DestinyDefinitionsMilestonesDestinyMilestoneRewardCategoryDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsMilestonesDestinyMilestoneRewardCategoryDefinition(
                    CategoryHash: _CategoryHash,
                    CategoryIdentifier: _CategoryIdentifier,
                    DisplayProperties: _DisplayProperties,
                    RewardEntries: _RewardEntries,
                    Order: _Order
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}