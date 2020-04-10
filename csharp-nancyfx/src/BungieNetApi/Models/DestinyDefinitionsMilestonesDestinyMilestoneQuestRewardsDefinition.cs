using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// If rewards are given in a quest - as opposed to overall in the entire Milestone - there&#39;s way less to track. We&#39;re going to simplify this contract as a result. However, this also gives us the opportunity to potentially put more than just item information into the reward data if we&#39;re able to mine it out in the future. Remember this if you come back and ask \&quot;why are quest reward items nested inside of their own class?\&quot;
    /// </summary>
    public sealed class DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardsDefinition:  IEquatable<DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardsDefinition>
    { 
        /// <summary>
        /// The items that represent your reward for completing the quest.  Be warned, these could be \&quot;dummy\&quot; items: items that are only used to render a good-looking in-game tooltip, but aren&#39;t the actual items themselves.  For instance, when experience is given there&#39;s often a dummy item representing \&quot;experience\&quot;, with quantity being the amount of experience you got. We don&#39;t have a programmatic association between those and whatever Progression is actually getting that experience... yet.
        /// </summary>
        public List<DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardItem> Items { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardsDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardsDefinition()
        {
        }

        private DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardsDefinition(List<DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardItem> Items)
        {
            
            this.Items = Items;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardsDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardsDefinitionBuilder</returns>
        public static DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardsDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardsDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardsDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardsDefinitionBuilder</returns>
        public DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardsDefinitionBuilder With()
        {
            return Builder()
                .Items(Items);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardsDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardsDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardsDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardsDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardsDefinition left, DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardsDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardsDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardsDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardsDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardsDefinition left, DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardsDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardsDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardsDefinitionBuilder
        {
            private List<DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardItem> _Items;

            internal DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardsDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardsDefinition.Items property.
            /// </summary>
            /// <param name="value">The items that represent your reward for completing the quest.  Be warned, these could be \&quot;dummy\&quot; items: items that are only used to render a good-looking in-game tooltip, but aren&#39;t the actual items themselves.  For instance, when experience is given there&#39;s often a dummy item representing \&quot;experience\&quot;, with quantity being the amount of experience you got. We don&#39;t have a programmatic association between those and whatever Progression is actually getting that experience... yet.</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardsDefinitionBuilder Items(List<DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardItem> value)
            {
                _Items = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardsDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardsDefinition</returns>
            public DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardsDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardsDefinition(
                    Items: _Items
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}