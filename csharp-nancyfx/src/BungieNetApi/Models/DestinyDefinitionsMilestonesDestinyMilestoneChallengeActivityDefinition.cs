using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityDefinition
    /// </summary>
    public sealed class DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityDefinition:  IEquatable<DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityDefinition>
    { 
        /// <summary>
        /// The activity for which this challenge is active.
        /// </summary>
        public int? ActivityHash { get; private set; }

        /// <summary>
        /// Challenges
        /// </summary>
        public List<DestinyDefinitionsMilestonesDestinyMilestoneChallengeDefinition> Challenges { get; private set; }

        /// <summary>
        /// If the activity and its challenge is visible on any of these nodes, it will be returned.
        /// </summary>
        public List<DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityGraphNodeEntry> ActivityGraphNodes { get; private set; }

        /// <summary>
        /// Phases related to this activity, if there are any.  These will be listed in the order in which they will appear in the actual activity.
        /// </summary>
        public List<DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityPhase> Phases { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityDefinition()
        {
        }

        private DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityDefinition(int? ActivityHash, List<DestinyDefinitionsMilestonesDestinyMilestoneChallengeDefinition> Challenges, List<DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityGraphNodeEntry> ActivityGraphNodes, List<DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityPhase> Phases)
        {
            
            this.ActivityHash = ActivityHash;
            
            this.Challenges = Challenges;
            
            this.ActivityGraphNodes = ActivityGraphNodes;
            
            this.Phases = Phases;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityDefinitionBuilder</returns>
        public static DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityDefinitionBuilder</returns>
        public DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityDefinitionBuilder With()
        {
            return Builder()
                .ActivityHash(ActivityHash)
                .Challenges(Challenges)
                .ActivityGraphNodes(ActivityGraphNodes)
                .Phases(Phases);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityDefinition left, DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityDefinition left, DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityDefinitionBuilder
        {
            private int? _ActivityHash;
            private List<DestinyDefinitionsMilestonesDestinyMilestoneChallengeDefinition> _Challenges;
            private List<DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityGraphNodeEntry> _ActivityGraphNodes;
            private List<DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityPhase> _Phases;

            internal DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityDefinition.ActivityHash property.
            /// </summary>
            /// <param name="value">The activity for which this challenge is active.</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityDefinitionBuilder ActivityHash(int? value)
            {
                _ActivityHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityDefinition.Challenges property.
            /// </summary>
            /// <param name="value">Challenges</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityDefinitionBuilder Challenges(List<DestinyDefinitionsMilestonesDestinyMilestoneChallengeDefinition> value)
            {
                _Challenges = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityDefinition.ActivityGraphNodes property.
            /// </summary>
            /// <param name="value">If the activity and its challenge is visible on any of these nodes, it will be returned.</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityDefinitionBuilder ActivityGraphNodes(List<DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityGraphNodeEntry> value)
            {
                _ActivityGraphNodes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityDefinition.Phases property.
            /// </summary>
            /// <param name="value">Phases related to this activity, if there are any.  These will be listed in the order in which they will appear in the actual activity.</param>
            public DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityDefinitionBuilder Phases(List<DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityPhase> value)
            {
                _Phases = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityDefinition</returns>
            public DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsMilestonesDestinyMilestoneChallengeActivityDefinition(
                    ActivityHash: _ActivityHash,
                    Challenges: _Challenges,
                    ActivityGraphNodes: _ActivityGraphNodes,
                    Phases: _Phases
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}