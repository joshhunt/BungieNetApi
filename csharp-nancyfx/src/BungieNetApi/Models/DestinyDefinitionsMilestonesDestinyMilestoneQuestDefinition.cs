using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Any data we need to figure out whether this Quest Item is the currently active one for the conceptual Milestone. Even just typing this description, I already regret it.
    /// </summary>
    public sealed class DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition:  IEquatable<DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition>
    { 
        /// <summary>
        /// The item representing this Milestone quest. Use this hash to look up the DestinyInventoryItemDefinition for the quest to find its steps and human readable data.
        /// </summary>
        public int? QuestItemHash { get; private set; }

        /// <summary>
        /// The individual quests may have different definitions from the overall milestone: if there&#39;s a specific active quest, use these displayProperties instead of that of the overall DestinyMilestoneDefinition.
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; private set; }

        /// <summary>
        /// If populated, this image can be shown instead of the generic milestone&#39;s image when this quest is live, or it can be used to show a background image for the quest itself that differs from that of the Activity or the Milestone.
        /// </summary>
        public string OverrideImage { get; private set; }

        /// <summary>
        /// The rewards you will get for completing this quest, as best as we could extract them from our data. Sometimes, it&#39;ll be a decent amount of data. Sometimes, it&#39;s going to be sucky. Sorry.
        /// </summary>
        public DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardsDefinition QuestRewards { get; private set; }

        /// <summary>
        /// The full set of all possible \&quot;conceptual activities\&quot; that are related to this Milestone. Tiers or alternative modes of play within these conceptual activities will be defined as sub-entities. Keyed by the Conceptual Activity Hash. Use the key to look up DestinyActivityDefinition.
        /// </summary>
        public Dictionary<string, DestinyDefinitionsMilestonesDestinyMilestoneActivityDefinition> Activities { get; private set; }

        /// <summary>
        /// Sometimes, a Milestone&#39;s quest is related to an entire Destination rather than a specific activity. In that situation, this will be the hash of that Destination. Hotspots are currently the only Milestones that expose this data, but that does not preclude this data from being returned for other Milestones in the future.
        /// </summary>
        public int? DestinationHash { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition()
        {
        }

        private DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition(int? QuestItemHash, DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties, string OverrideImage, DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardsDefinition QuestRewards, Dictionary<string, DestinyDefinitionsMilestonesDestinyMilestoneActivityDefinition> Activities, int? DestinationHash)
        {
            
            this.QuestItemHash = QuestItemHash;
            
            this.DisplayProperties = DisplayProperties;
            
            this.OverrideImage = OverrideImage;
            
            this.QuestRewards = QuestRewards;
            
            this.Activities = Activities;
            
            this.DestinationHash = DestinationHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinitionBuilder</returns>
        public static DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinitionBuilder</returns>
        public DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinitionBuilder With()
        {
            return Builder()
                .QuestItemHash(QuestItemHash)
                .DisplayProperties(DisplayProperties)
                .OverrideImage(OverrideImage)
                .QuestRewards(QuestRewards)
                .Activities(Activities)
                .DestinationHash(DestinationHash);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition left, DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition left, DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinitionBuilder
        {
            private int? _QuestItemHash;
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _DisplayProperties;
            private string _OverrideImage;
            private DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardsDefinition _QuestRewards;
            private Dictionary<string, DestinyDefinitionsMilestonesDestinyMilestoneActivityDefinition> _Activities;
            private int? _DestinationHash;

            internal DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition.QuestItemHash property.
            /// </summary>
            /// <param name="value">The item representing this Milestone quest. Use this hash to look up the DestinyInventoryItemDefinition for the quest to find its steps and human readable data.</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinitionBuilder QuestItemHash(int? value)
            {
                _QuestItemHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition.DisplayProperties property.
            /// </summary>
            /// <param name="value">The individual quests may have different definitions from the overall milestone: if there&#39;s a specific active quest, use these displayProperties instead of that of the overall DestinyMilestoneDefinition.</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinitionBuilder DisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _DisplayProperties = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition.OverrideImage property.
            /// </summary>
            /// <param name="value">If populated, this image can be shown instead of the generic milestone&#39;s image when this quest is live, or it can be used to show a background image for the quest itself that differs from that of the Activity or the Milestone.</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinitionBuilder OverrideImage(string value)
            {
                _OverrideImage = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition.QuestRewards property.
            /// </summary>
            /// <param name="value">The rewards you will get for completing this quest, as best as we could extract them from our data. Sometimes, it&#39;ll be a decent amount of data. Sometimes, it&#39;s going to be sucky. Sorry.</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinitionBuilder QuestRewards(DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardsDefinition value)
            {
                _QuestRewards = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition.Activities property.
            /// </summary>
            /// <param name="value">The full set of all possible \&quot;conceptual activities\&quot; that are related to this Milestone. Tiers or alternative modes of play within these conceptual activities will be defined as sub-entities. Keyed by the Conceptual Activity Hash. Use the key to look up DestinyActivityDefinition.</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinitionBuilder Activities(Dictionary<string, DestinyDefinitionsMilestonesDestinyMilestoneActivityDefinition> value)
            {
                _Activities = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition.DestinationHash property.
            /// </summary>
            /// <param name="value">Sometimes, a Milestone&#39;s quest is related to an entire Destination rather than a specific activity. In that situation, this will be the hash of that Destination. Hotspots are currently the only Milestones that expose this data, but that does not preclude this data from being returned for other Milestones in the future.</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinitionBuilder DestinationHash(int? value)
            {
                _DestinationHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition</returns>
            public DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition(
                    QuestItemHash: _QuestItemHash,
                    DisplayProperties: _DisplayProperties,
                    OverrideImage: _OverrideImage,
                    QuestRewards: _QuestRewards,
                    Activities: _Activities,
                    DestinationHash: _DestinationHash
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}