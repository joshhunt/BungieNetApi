using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyMilestonesDestinyPublicMilestoneQuest
    /// </summary>
    public sealed class DestinyMilestonesDestinyPublicMilestoneQuest:  IEquatable<DestinyMilestonesDestinyPublicMilestoneQuest>
    { 
        /// <summary>
        /// Quests are defined as Items in content. As such, this is the hash identifier of the DestinyInventoryItemDefinition that represents this quest. It will have pointers to all of the steps in the quest, and display information for the quest (title, description, icon etc) Individual steps will be referred to in the Quest item&#39;s DestinyInventoryItemDefinition.setData property, and themselves are Items with their own renderable data.
        /// </summary>
        public int? QuestItemHash { get; private set; }

        /// <summary>
        /// A milestone need not have an active activity, but if there is one it will be returned here, along with any variant and additional information.
        /// </summary>
        public DestinyMilestonesDestinyPublicMilestoneActivity Activity { get; private set; }

        /// <summary>
        /// For the given quest there could be 0-to-Many challenges: mini quests that you can perform in the course of doing this quest, that may grant you rewards and benefits.
        /// </summary>
        public List<DestinyMilestonesDestinyPublicMilestoneChallenge> Challenges { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyMilestonesDestinyPublicMilestoneQuest.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyMilestonesDestinyPublicMilestoneQuest()
        {
        }

        private DestinyMilestonesDestinyPublicMilestoneQuest(int? QuestItemHash, DestinyMilestonesDestinyPublicMilestoneActivity Activity, List<DestinyMilestonesDestinyPublicMilestoneChallenge> Challenges)
        {
            
            this.QuestItemHash = QuestItemHash;
            
            this.Activity = Activity;
            
            this.Challenges = Challenges;
            
        }

        /// <summary>
        /// Returns builder of DestinyMilestonesDestinyPublicMilestoneQuest.
        /// </summary>
        /// <returns>DestinyMilestonesDestinyPublicMilestoneQuestBuilder</returns>
        public static DestinyMilestonesDestinyPublicMilestoneQuestBuilder Builder()
        {
            return new DestinyMilestonesDestinyPublicMilestoneQuestBuilder();
        }

        /// <summary>
        /// Returns DestinyMilestonesDestinyPublicMilestoneQuestBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyMilestonesDestinyPublicMilestoneQuestBuilder</returns>
        public DestinyMilestonesDestinyPublicMilestoneQuestBuilder With()
        {
            return Builder()
                .QuestItemHash(QuestItemHash)
                .Activity(Activity)
                .Challenges(Challenges);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyMilestonesDestinyPublicMilestoneQuest other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyMilestonesDestinyPublicMilestoneQuest.
        /// </summary>
        /// <param name="left">Compared (DestinyMilestonesDestinyPublicMilestoneQuest</param>
        /// <param name="right">Compared (DestinyMilestonesDestinyPublicMilestoneQuest</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyMilestonesDestinyPublicMilestoneQuest left, DestinyMilestonesDestinyPublicMilestoneQuest right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyMilestonesDestinyPublicMilestoneQuest.
        /// </summary>
        /// <param name="left">Compared (DestinyMilestonesDestinyPublicMilestoneQuest</param>
        /// <param name="right">Compared (DestinyMilestonesDestinyPublicMilestoneQuest</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyMilestonesDestinyPublicMilestoneQuest left, DestinyMilestonesDestinyPublicMilestoneQuest right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyMilestonesDestinyPublicMilestoneQuest.
        /// </summary>
        public sealed class DestinyMilestonesDestinyPublicMilestoneQuestBuilder
        {
            private int? _QuestItemHash;
            private DestinyMilestonesDestinyPublicMilestoneActivity _Activity;
            private List<DestinyMilestonesDestinyPublicMilestoneChallenge> _Challenges;

            internal DestinyMilestonesDestinyPublicMilestoneQuestBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyPublicMilestoneQuest.QuestItemHash property.
            /// </summary>
            /// <param name="value">Quests are defined as Items in content. As such, this is the hash identifier of the DestinyInventoryItemDefinition that represents this quest. It will have pointers to all of the steps in the quest, and display information for the quest (title, description, icon etc) Individual steps will be referred to in the Quest item&#39;s DestinyInventoryItemDefinition.setData property, and themselves are Items with their own renderable data.</param>
            public DestinyMilestonesDestinyPublicMilestoneQuestBuilder QuestItemHash(int? value)
            {
                _QuestItemHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyPublicMilestoneQuest.Activity property.
            /// </summary>
            /// <param name="value">A milestone need not have an active activity, but if there is one it will be returned here, along with any variant and additional information.</param>
            public DestinyMilestonesDestinyPublicMilestoneQuestBuilder Activity(DestinyMilestonesDestinyPublicMilestoneActivity value)
            {
                _Activity = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyPublicMilestoneQuest.Challenges property.
            /// </summary>
            /// <param name="value">For the given quest there could be 0-to-Many challenges: mini quests that you can perform in the course of doing this quest, that may grant you rewards and benefits.</param>
            public DestinyMilestonesDestinyPublicMilestoneQuestBuilder Challenges(List<DestinyMilestonesDestinyPublicMilestoneChallenge> value)
            {
                _Challenges = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyMilestonesDestinyPublicMilestoneQuest.
            /// </summary>
            /// <returns>DestinyMilestonesDestinyPublicMilestoneQuest</returns>
            public DestinyMilestonesDestinyPublicMilestoneQuest Build()
            {
                Validate();
                return new DestinyMilestonesDestinyPublicMilestoneQuest(
                    QuestItemHash: _QuestItemHash,
                    Activity: _Activity,
                    Challenges: _Challenges
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}