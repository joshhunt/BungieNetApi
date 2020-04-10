using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Represents a category of \&quot;summary\&quot; rewards that can be earned for the Milestone regardless of specific quest rewards that can be earned.
    /// </summary>
    public sealed class DestinyMilestonesDestinyMilestoneRewardCategory:  IEquatable<DestinyMilestonesDestinyMilestoneRewardCategory>
    { 
        /// <summary>
        /// Look up the relevant DestinyMilestoneDefinition, and then use rewardCategoryHash to look up the category info in DestinyMilestoneDefinition.rewards.
        /// </summary>
        public int? RewardCategoryHash { get; private set; }

        /// <summary>
        /// The individual reward entries for this category, and their status.
        /// </summary>
        public List<DestinyMilestonesDestinyMilestoneRewardEntry> Entries { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyMilestonesDestinyMilestoneRewardCategory.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyMilestonesDestinyMilestoneRewardCategory()
        {
        }

        private DestinyMilestonesDestinyMilestoneRewardCategory(int? RewardCategoryHash, List<DestinyMilestonesDestinyMilestoneRewardEntry> Entries)
        {
            
            this.RewardCategoryHash = RewardCategoryHash;
            
            this.Entries = Entries;
            
        }

        /// <summary>
        /// Returns builder of DestinyMilestonesDestinyMilestoneRewardCategory.
        /// </summary>
        /// <returns>DestinyMilestonesDestinyMilestoneRewardCategoryBuilder</returns>
        public static DestinyMilestonesDestinyMilestoneRewardCategoryBuilder Builder()
        {
            return new DestinyMilestonesDestinyMilestoneRewardCategoryBuilder();
        }

        /// <summary>
        /// Returns DestinyMilestonesDestinyMilestoneRewardCategoryBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyMilestonesDestinyMilestoneRewardCategoryBuilder</returns>
        public DestinyMilestonesDestinyMilestoneRewardCategoryBuilder With()
        {
            return Builder()
                .RewardCategoryHash(RewardCategoryHash)
                .Entries(Entries);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyMilestonesDestinyMilestoneRewardCategory other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyMilestonesDestinyMilestoneRewardCategory.
        /// </summary>
        /// <param name="left">Compared (DestinyMilestonesDestinyMilestoneRewardCategory</param>
        /// <param name="right">Compared (DestinyMilestonesDestinyMilestoneRewardCategory</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyMilestonesDestinyMilestoneRewardCategory left, DestinyMilestonesDestinyMilestoneRewardCategory right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyMilestonesDestinyMilestoneRewardCategory.
        /// </summary>
        /// <param name="left">Compared (DestinyMilestonesDestinyMilestoneRewardCategory</param>
        /// <param name="right">Compared (DestinyMilestonesDestinyMilestoneRewardCategory</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyMilestonesDestinyMilestoneRewardCategory left, DestinyMilestonesDestinyMilestoneRewardCategory right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyMilestonesDestinyMilestoneRewardCategory.
        /// </summary>
        public sealed class DestinyMilestonesDestinyMilestoneRewardCategoryBuilder
        {
            private int? _RewardCategoryHash;
            private List<DestinyMilestonesDestinyMilestoneRewardEntry> _Entries;

            internal DestinyMilestonesDestinyMilestoneRewardCategoryBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyMilestoneRewardCategory.RewardCategoryHash property.
            /// </summary>
            /// <param name="value">Look up the relevant DestinyMilestoneDefinition, and then use rewardCategoryHash to look up the category info in DestinyMilestoneDefinition.rewards.</param>
            public DestinyMilestonesDestinyMilestoneRewardCategoryBuilder RewardCategoryHash(int? value)
            {
                _RewardCategoryHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyMilestoneRewardCategory.Entries property.
            /// </summary>
            /// <param name="value">The individual reward entries for this category, and their status.</param>
            public DestinyMilestonesDestinyMilestoneRewardCategoryBuilder Entries(List<DestinyMilestonesDestinyMilestoneRewardEntry> value)
            {
                _Entries = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyMilestonesDestinyMilestoneRewardCategory.
            /// </summary>
            /// <returns>DestinyMilestonesDestinyMilestoneRewardCategory</returns>
            public DestinyMilestonesDestinyMilestoneRewardCategory Build()
            {
                Validate();
                return new DestinyMilestonesDestinyMilestoneRewardCategory(
                    RewardCategoryHash: _RewardCategoryHash,
                    Entries: _Entries
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}