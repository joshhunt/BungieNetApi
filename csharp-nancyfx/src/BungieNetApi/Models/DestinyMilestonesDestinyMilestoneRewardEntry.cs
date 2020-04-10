using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// The character-specific data for a milestone&#39;s reward entry. See DestinyMilestoneDefinition for more information about Reward Entries.
    /// </summary>
    public sealed class DestinyMilestonesDestinyMilestoneRewardEntry:  IEquatable<DestinyMilestonesDestinyMilestoneRewardEntry>
    { 
        /// <summary>
        /// The identifier for the reward entry in question. It is important to look up the related DestinyMilestoneRewardEntryDefinition to get the static details about the reward, which you can do by looking up the milestone&#39;s DestinyMilestoneDefinition and examining the DestinyMilestoneDefinition.rewards[rewardCategoryHash].rewardEntries[rewardEntryHash] data.
        /// </summary>
        public int? RewardEntryHash { get; private set; }

        /// <summary>
        /// If TRUE, the player has earned this reward.
        /// </summary>
        public bool? Earned { get; private set; }

        /// <summary>
        /// If TRUE, the player has redeemed/picked up/obtained this reward. Feel free to alias this to \&quot;gotTheShinyBauble\&quot; in your own codebase.
        /// </summary>
        public bool? Redeemed { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyMilestonesDestinyMilestoneRewardEntry.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyMilestonesDestinyMilestoneRewardEntry()
        {
        }

        private DestinyMilestonesDestinyMilestoneRewardEntry(int? RewardEntryHash, bool? Earned, bool? Redeemed)
        {
            
            this.RewardEntryHash = RewardEntryHash;
            
            this.Earned = Earned;
            
            this.Redeemed = Redeemed;
            
        }

        /// <summary>
        /// Returns builder of DestinyMilestonesDestinyMilestoneRewardEntry.
        /// </summary>
        /// <returns>DestinyMilestonesDestinyMilestoneRewardEntryBuilder</returns>
        public static DestinyMilestonesDestinyMilestoneRewardEntryBuilder Builder()
        {
            return new DestinyMilestonesDestinyMilestoneRewardEntryBuilder();
        }

        /// <summary>
        /// Returns DestinyMilestonesDestinyMilestoneRewardEntryBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyMilestonesDestinyMilestoneRewardEntryBuilder</returns>
        public DestinyMilestonesDestinyMilestoneRewardEntryBuilder With()
        {
            return Builder()
                .RewardEntryHash(RewardEntryHash)
                .Earned(Earned)
                .Redeemed(Redeemed);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyMilestonesDestinyMilestoneRewardEntry other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyMilestonesDestinyMilestoneRewardEntry.
        /// </summary>
        /// <param name="left">Compared (DestinyMilestonesDestinyMilestoneRewardEntry</param>
        /// <param name="right">Compared (DestinyMilestonesDestinyMilestoneRewardEntry</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyMilestonesDestinyMilestoneRewardEntry left, DestinyMilestonesDestinyMilestoneRewardEntry right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyMilestonesDestinyMilestoneRewardEntry.
        /// </summary>
        /// <param name="left">Compared (DestinyMilestonesDestinyMilestoneRewardEntry</param>
        /// <param name="right">Compared (DestinyMilestonesDestinyMilestoneRewardEntry</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyMilestonesDestinyMilestoneRewardEntry left, DestinyMilestonesDestinyMilestoneRewardEntry right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyMilestonesDestinyMilestoneRewardEntry.
        /// </summary>
        public sealed class DestinyMilestonesDestinyMilestoneRewardEntryBuilder
        {
            private int? _RewardEntryHash;
            private bool? _Earned;
            private bool? _Redeemed;

            internal DestinyMilestonesDestinyMilestoneRewardEntryBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyMilestoneRewardEntry.RewardEntryHash property.
            /// </summary>
            /// <param name="value">The identifier for the reward entry in question. It is important to look up the related DestinyMilestoneRewardEntryDefinition to get the static details about the reward, which you can do by looking up the milestone&#39;s DestinyMilestoneDefinition and examining the DestinyMilestoneDefinition.rewards[rewardCategoryHash].rewardEntries[rewardEntryHash] data.</param>
            public DestinyMilestonesDestinyMilestoneRewardEntryBuilder RewardEntryHash(int? value)
            {
                _RewardEntryHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyMilestoneRewardEntry.Earned property.
            /// </summary>
            /// <param name="value">If TRUE, the player has earned this reward.</param>
            public DestinyMilestonesDestinyMilestoneRewardEntryBuilder Earned(bool? value)
            {
                _Earned = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyMilestoneRewardEntry.Redeemed property.
            /// </summary>
            /// <param name="value">If TRUE, the player has redeemed/picked up/obtained this reward. Feel free to alias this to \&quot;gotTheShinyBauble\&quot; in your own codebase.</param>
            public DestinyMilestonesDestinyMilestoneRewardEntryBuilder Redeemed(bool? value)
            {
                _Redeemed = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyMilestonesDestinyMilestoneRewardEntry.
            /// </summary>
            /// <returns>DestinyMilestonesDestinyMilestoneRewardEntry</returns>
            public DestinyMilestonesDestinyMilestoneRewardEntry Build()
            {
                Validate();
                return new DestinyMilestonesDestinyMilestoneRewardEntry(
                    RewardEntryHash: _RewardEntryHash,
                    Earned: _Earned,
                    Redeemed: _Redeemed
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}