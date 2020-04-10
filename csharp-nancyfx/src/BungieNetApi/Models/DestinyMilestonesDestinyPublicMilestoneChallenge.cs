using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// A Milestone can have many Challenges. Challenges are just extra Objectives that provide a fun way to mix-up play and provide extra rewards.
    /// </summary>
    public sealed class DestinyMilestonesDestinyPublicMilestoneChallenge:  IEquatable<DestinyMilestonesDestinyPublicMilestoneChallenge>
    { 
        /// <summary>
        /// The objective for the Challenge, which should have human-readable data about what needs to be done to accomplish the objective. Use this hash to look up the DestinyObjectiveDefinition.
        /// </summary>
        public int? ObjectiveHash { get; private set; }

        /// <summary>
        /// IF the Objective is related to a specific Activity, this will be that activity&#39;s hash. Use it to look up the DestinyActivityDefinition for additional data to show.
        /// </summary>
        public int? ActivityHash { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyMilestonesDestinyPublicMilestoneChallenge.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyMilestonesDestinyPublicMilestoneChallenge()
        {
        }

        private DestinyMilestonesDestinyPublicMilestoneChallenge(int? ObjectiveHash, int? ActivityHash)
        {
            
            this.ObjectiveHash = ObjectiveHash;
            
            this.ActivityHash = ActivityHash;
            
        }

        /// <summary>
        /// Returns builder of DestinyMilestonesDestinyPublicMilestoneChallenge.
        /// </summary>
        /// <returns>DestinyMilestonesDestinyPublicMilestoneChallengeBuilder</returns>
        public static DestinyMilestonesDestinyPublicMilestoneChallengeBuilder Builder()
        {
            return new DestinyMilestonesDestinyPublicMilestoneChallengeBuilder();
        }

        /// <summary>
        /// Returns DestinyMilestonesDestinyPublicMilestoneChallengeBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyMilestonesDestinyPublicMilestoneChallengeBuilder</returns>
        public DestinyMilestonesDestinyPublicMilestoneChallengeBuilder With()
        {
            return Builder()
                .ObjectiveHash(ObjectiveHash)
                .ActivityHash(ActivityHash);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyMilestonesDestinyPublicMilestoneChallenge other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyMilestonesDestinyPublicMilestoneChallenge.
        /// </summary>
        /// <param name="left">Compared (DestinyMilestonesDestinyPublicMilestoneChallenge</param>
        /// <param name="right">Compared (DestinyMilestonesDestinyPublicMilestoneChallenge</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyMilestonesDestinyPublicMilestoneChallenge left, DestinyMilestonesDestinyPublicMilestoneChallenge right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyMilestonesDestinyPublicMilestoneChallenge.
        /// </summary>
        /// <param name="left">Compared (DestinyMilestonesDestinyPublicMilestoneChallenge</param>
        /// <param name="right">Compared (DestinyMilestonesDestinyPublicMilestoneChallenge</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyMilestonesDestinyPublicMilestoneChallenge left, DestinyMilestonesDestinyPublicMilestoneChallenge right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyMilestonesDestinyPublicMilestoneChallenge.
        /// </summary>
        public sealed class DestinyMilestonesDestinyPublicMilestoneChallengeBuilder
        {
            private int? _ObjectiveHash;
            private int? _ActivityHash;

            internal DestinyMilestonesDestinyPublicMilestoneChallengeBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyPublicMilestoneChallenge.ObjectiveHash property.
            /// </summary>
            /// <param name="value">The objective for the Challenge, which should have human-readable data about what needs to be done to accomplish the objective. Use this hash to look up the DestinyObjectiveDefinition.</param>
            public DestinyMilestonesDestinyPublicMilestoneChallengeBuilder ObjectiveHash(int? value)
            {
                _ObjectiveHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyPublicMilestoneChallenge.ActivityHash property.
            /// </summary>
            /// <param name="value">IF the Objective is related to a specific Activity, this will be that activity&#39;s hash. Use it to look up the DestinyActivityDefinition for additional data to show.</param>
            public DestinyMilestonesDestinyPublicMilestoneChallengeBuilder ActivityHash(int? value)
            {
                _ActivityHash = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyMilestonesDestinyPublicMilestoneChallenge.
            /// </summary>
            /// <returns>DestinyMilestonesDestinyPublicMilestoneChallenge</returns>
            public DestinyMilestonesDestinyPublicMilestoneChallenge Build()
            {
                Validate();
                return new DestinyMilestonesDestinyPublicMilestoneChallenge(
                    ObjectiveHash: _ObjectiveHash,
                    ActivityHash: _ActivityHash
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}