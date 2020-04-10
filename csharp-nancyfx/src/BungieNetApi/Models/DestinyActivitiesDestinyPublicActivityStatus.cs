using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Represents the public-facing status of an activity: any data about what is currently active in the Activity, regardless of an individual character&#39;s progress in it.
    /// </summary>
    public sealed class DestinyActivitiesDestinyPublicActivityStatus:  IEquatable<DestinyActivitiesDestinyPublicActivityStatus>
    { 
        /// <summary>
        /// Active Challenges for the activity, if any - represented as hashes for DestinyObjectiveDefinitions.
        /// </summary>
        public List<int?> ChallengeObjectiveHashes { get; private set; }

        /// <summary>
        /// The active modifiers on this activity, if any - represented as hashes for DestinyActivityModifierDefinitions.
        /// </summary>
        public List<int?> ModifierHashes { get; private set; }

        /// <summary>
        /// If the activity itself provides any specific \&quot;mock\&quot; rewards, this will be the items and their quantity.  Why \&quot;mock\&quot;, you ask? Because these are the rewards as they are represented in the tooltip of the Activity.  These are often pointers to fake items that look good in a tooltip, but represent an abstract concept of what you will get for a reward rather than the specific items you may obtain.
        /// </summary>
        public List<DestinyDestinyItemQuantity> RewardTooltipItems { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyActivitiesDestinyPublicActivityStatus.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyActivitiesDestinyPublicActivityStatus()
        {
        }

        private DestinyActivitiesDestinyPublicActivityStatus(List<int?> ChallengeObjectiveHashes, List<int?> ModifierHashes, List<DestinyDestinyItemQuantity> RewardTooltipItems)
        {
            
            this.ChallengeObjectiveHashes = ChallengeObjectiveHashes;
            
            this.ModifierHashes = ModifierHashes;
            
            this.RewardTooltipItems = RewardTooltipItems;
            
        }

        /// <summary>
        /// Returns builder of DestinyActivitiesDestinyPublicActivityStatus.
        /// </summary>
        /// <returns>DestinyActivitiesDestinyPublicActivityStatusBuilder</returns>
        public static DestinyActivitiesDestinyPublicActivityStatusBuilder Builder()
        {
            return new DestinyActivitiesDestinyPublicActivityStatusBuilder();
        }

        /// <summary>
        /// Returns DestinyActivitiesDestinyPublicActivityStatusBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyActivitiesDestinyPublicActivityStatusBuilder</returns>
        public DestinyActivitiesDestinyPublicActivityStatusBuilder With()
        {
            return Builder()
                .ChallengeObjectiveHashes(ChallengeObjectiveHashes)
                .ModifierHashes(ModifierHashes)
                .RewardTooltipItems(RewardTooltipItems);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyActivitiesDestinyPublicActivityStatus other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyActivitiesDestinyPublicActivityStatus.
        /// </summary>
        /// <param name="left">Compared (DestinyActivitiesDestinyPublicActivityStatus</param>
        /// <param name="right">Compared (DestinyActivitiesDestinyPublicActivityStatus</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyActivitiesDestinyPublicActivityStatus left, DestinyActivitiesDestinyPublicActivityStatus right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyActivitiesDestinyPublicActivityStatus.
        /// </summary>
        /// <param name="left">Compared (DestinyActivitiesDestinyPublicActivityStatus</param>
        /// <param name="right">Compared (DestinyActivitiesDestinyPublicActivityStatus</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyActivitiesDestinyPublicActivityStatus left, DestinyActivitiesDestinyPublicActivityStatus right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyActivitiesDestinyPublicActivityStatus.
        /// </summary>
        public sealed class DestinyActivitiesDestinyPublicActivityStatusBuilder
        {
            private List<int?> _ChallengeObjectiveHashes;
            private List<int?> _ModifierHashes;
            private List<DestinyDestinyItemQuantity> _RewardTooltipItems;

            internal DestinyActivitiesDestinyPublicActivityStatusBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyActivitiesDestinyPublicActivityStatus.ChallengeObjectiveHashes property.
            /// </summary>
            /// <param name="value">Active Challenges for the activity, if any - represented as hashes for DestinyObjectiveDefinitions.</param>
            public DestinyActivitiesDestinyPublicActivityStatusBuilder ChallengeObjectiveHashes(List<int?> value)
            {
                _ChallengeObjectiveHashes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyActivitiesDestinyPublicActivityStatus.ModifierHashes property.
            /// </summary>
            /// <param name="value">The active modifiers on this activity, if any - represented as hashes for DestinyActivityModifierDefinitions.</param>
            public DestinyActivitiesDestinyPublicActivityStatusBuilder ModifierHashes(List<int?> value)
            {
                _ModifierHashes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyActivitiesDestinyPublicActivityStatus.RewardTooltipItems property.
            /// </summary>
            /// <param name="value">If the activity itself provides any specific \&quot;mock\&quot; rewards, this will be the items and their quantity.  Why \&quot;mock\&quot;, you ask? Because these are the rewards as they are represented in the tooltip of the Activity.  These are often pointers to fake items that look good in a tooltip, but represent an abstract concept of what you will get for a reward rather than the specific items you may obtain.</param>
            public DestinyActivitiesDestinyPublicActivityStatusBuilder RewardTooltipItems(List<DestinyDestinyItemQuantity> value)
            {
                _RewardTooltipItems = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyActivitiesDestinyPublicActivityStatus.
            /// </summary>
            /// <returns>DestinyActivitiesDestinyPublicActivityStatus</returns>
            public DestinyActivitiesDestinyPublicActivityStatus Build()
            {
                Validate();
                return new DestinyActivitiesDestinyPublicActivityStatus(
                    ChallengeObjectiveHashes: _ChallengeObjectiveHashes,
                    ModifierHashes: _ModifierHashes,
                    RewardTooltipItems: _RewardTooltipItems
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}