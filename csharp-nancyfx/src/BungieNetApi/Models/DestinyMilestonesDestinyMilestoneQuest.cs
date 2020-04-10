using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// If a Milestone has one or more Quests, this will contain the live information for the character&#39;s status with one of those quests.
    /// </summary>
    public sealed class DestinyMilestonesDestinyMilestoneQuest:  IEquatable<DestinyMilestonesDestinyMilestoneQuest>
    { 
        /// <summary>
        /// Quests are defined as Items in content. As such, this is the hash identifier of the DestinyInventoryItemDefinition that represents this quest. It will have pointers to all of the steps in the quest, and display information for the quest (title, description, icon etc) Individual steps will be referred to in the Quest item&#39;s DestinyInventoryItemDefinition.setData property, and themselves are Items with their own renderable data.
        /// </summary>
        public int? QuestItemHash { get; private set; }

        /// <summary>
        /// The current status of the quest for the character making the request.
        /// </summary>
        public DestinyQuestsDestinyQuestStatus Status { get; private set; }

        /// <summary>
        /// *IF* the Milestone has an active Activity that can give you greater details about what you need to do, it will be returned here. Remember to associate this with the DestinyMilestoneDefinition&#39;s activities to get details about the activity, including what specific quest it is related to if you have multiple quests to choose from.
        /// </summary>
        public DestinyMilestonesDestinyMilestoneActivity Activity { get; private set; }

        /// <summary>
        /// The activities referred to by this quest can have many associated challenges. They are all contained here, with activityHashes so that you can associate them with the specific activity variants in which they can be found. In retrospect, I probably should have put these under the specific Activity Variants, but it&#39;s too late to change it now. Theoretically, a quest without Activities can still have Challenges, which is why this is on a higher level than activity/variants, but it probably should have been in both places. That may come as a later revision.
        /// </summary>
        public List<DestinyChallengesDestinyChallengeStatus> Challenges { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyMilestonesDestinyMilestoneQuest.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyMilestonesDestinyMilestoneQuest()
        {
        }

        private DestinyMilestonesDestinyMilestoneQuest(int? QuestItemHash, DestinyQuestsDestinyQuestStatus Status, DestinyMilestonesDestinyMilestoneActivity Activity, List<DestinyChallengesDestinyChallengeStatus> Challenges)
        {
            
            this.QuestItemHash = QuestItemHash;
            
            this.Status = Status;
            
            this.Activity = Activity;
            
            this.Challenges = Challenges;
            
        }

        /// <summary>
        /// Returns builder of DestinyMilestonesDestinyMilestoneQuest.
        /// </summary>
        /// <returns>DestinyMilestonesDestinyMilestoneQuestBuilder</returns>
        public static DestinyMilestonesDestinyMilestoneQuestBuilder Builder()
        {
            return new DestinyMilestonesDestinyMilestoneQuestBuilder();
        }

        /// <summary>
        /// Returns DestinyMilestonesDestinyMilestoneQuestBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyMilestonesDestinyMilestoneQuestBuilder</returns>
        public DestinyMilestonesDestinyMilestoneQuestBuilder With()
        {
            return Builder()
                .QuestItemHash(QuestItemHash)
                .Status(Status)
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

        public bool Equals(DestinyMilestonesDestinyMilestoneQuest other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyMilestonesDestinyMilestoneQuest.
        /// </summary>
        /// <param name="left">Compared (DestinyMilestonesDestinyMilestoneQuest</param>
        /// <param name="right">Compared (DestinyMilestonesDestinyMilestoneQuest</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyMilestonesDestinyMilestoneQuest left, DestinyMilestonesDestinyMilestoneQuest right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyMilestonesDestinyMilestoneQuest.
        /// </summary>
        /// <param name="left">Compared (DestinyMilestonesDestinyMilestoneQuest</param>
        /// <param name="right">Compared (DestinyMilestonesDestinyMilestoneQuest</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyMilestonesDestinyMilestoneQuest left, DestinyMilestonesDestinyMilestoneQuest right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyMilestonesDestinyMilestoneQuest.
        /// </summary>
        public sealed class DestinyMilestonesDestinyMilestoneQuestBuilder
        {
            private int? _QuestItemHash;
            private DestinyQuestsDestinyQuestStatus _Status;
            private DestinyMilestonesDestinyMilestoneActivity _Activity;
            private List<DestinyChallengesDestinyChallengeStatus> _Challenges;

            internal DestinyMilestonesDestinyMilestoneQuestBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyMilestoneQuest.QuestItemHash property.
            /// </summary>
            /// <param name="value">Quests are defined as Items in content. As such, this is the hash identifier of the DestinyInventoryItemDefinition that represents this quest. It will have pointers to all of the steps in the quest, and display information for the quest (title, description, icon etc) Individual steps will be referred to in the Quest item&#39;s DestinyInventoryItemDefinition.setData property, and themselves are Items with their own renderable data.</param>
            public DestinyMilestonesDestinyMilestoneQuestBuilder QuestItemHash(int? value)
            {
                _QuestItemHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyMilestoneQuest.Status property.
            /// </summary>
            /// <param name="value">The current status of the quest for the character making the request.</param>
            public DestinyMilestonesDestinyMilestoneQuestBuilder Status(DestinyQuestsDestinyQuestStatus value)
            {
                _Status = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyMilestoneQuest.Activity property.
            /// </summary>
            /// <param name="value">*IF* the Milestone has an active Activity that can give you greater details about what you need to do, it will be returned here. Remember to associate this with the DestinyMilestoneDefinition&#39;s activities to get details about the activity, including what specific quest it is related to if you have multiple quests to choose from.</param>
            public DestinyMilestonesDestinyMilestoneQuestBuilder Activity(DestinyMilestonesDestinyMilestoneActivity value)
            {
                _Activity = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyMilestoneQuest.Challenges property.
            /// </summary>
            /// <param name="value">The activities referred to by this quest can have many associated challenges. They are all contained here, with activityHashes so that you can associate them with the specific activity variants in which they can be found. In retrospect, I probably should have put these under the specific Activity Variants, but it&#39;s too late to change it now. Theoretically, a quest without Activities can still have Challenges, which is why this is on a higher level than activity/variants, but it probably should have been in both places. That may come as a later revision.</param>
            public DestinyMilestonesDestinyMilestoneQuestBuilder Challenges(List<DestinyChallengesDestinyChallengeStatus> value)
            {
                _Challenges = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyMilestonesDestinyMilestoneQuest.
            /// </summary>
            /// <returns>DestinyMilestonesDestinyMilestoneQuest</returns>
            public DestinyMilestonesDestinyMilestoneQuest Build()
            {
                Validate();
                return new DestinyMilestonesDestinyMilestoneQuest(
                    QuestItemHash: _QuestItemHash,
                    Status: _Status,
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