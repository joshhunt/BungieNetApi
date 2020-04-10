using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyMilestonesDestinyMilestoneChallengeActivity
    /// </summary>
    public sealed class DestinyMilestonesDestinyMilestoneChallengeActivity:  IEquatable<DestinyMilestonesDestinyMilestoneChallengeActivity>
    { 
        /// <summary>
        /// ActivityHash
        /// </summary>
        public int? ActivityHash { get; private set; }

        /// <summary>
        /// Challenges
        /// </summary>
        public List<DestinyChallengesDestinyChallengeStatus> Challenges { get; private set; }

        /// <summary>
        /// If the activity has modifiers, this will be the list of modifiers that all variants have in common. Perform lookups against DestinyActivityModifierDefinition which defines the modifier being applied to get at the modifier data.  Note that, in the DestiyActivityDefinition, you will see many more modifiers than this being referred to: those are all *possible* modifiers for the activity, not the active ones. Use only the active ones to match what&#39;s really live.
        /// </summary>
        public List<int?> ModifierHashes { get; private set; }

        /// <summary>
        /// The set of activity options for this activity, keyed by an identifier that&#39;s unique for this activity (not guaranteed to be unique between or across all activities, though should be unique for every *variant* of a given *conceptual* activity: for instance, the original D2 Raid has many variant DestinyActivityDefinitions. While other activities could potentially have the same option hashes, for any given D2 base Raid variant the hash will be unique).  As a concrete example of this data, the hashes you get for Raids will correspond to the currently active \&quot;Challenge Mode\&quot;.  We don&#39;t have any human readable information for these, but saavy 3rd party app users could manually associate the key (a hash identifier for the \&quot;option\&quot; that is enabled/disabled) and the value (whether it&#39;s enabled or disabled presently)  On our side, we don&#39;t necessarily even know what these are used for (the game designers know, but we don&#39;t), and we have no human readable data for them. In order to use them, you will have to do some experimentation.
        /// </summary>
        public Dictionary<string, bool?> BooleanActivityOptions { get; private set; }

        /// <summary>
        /// If returned, this is the index into the DestinyActivityDefinition&#39;s \&quot;loadouts\&quot; property, indicating the currently active loadout requirements.
        /// </summary>
        public int? LoadoutRequirementIndex { get; private set; }

        /// <summary>
        /// If the Activity has discrete \&quot;phases\&quot; that we can track, that info will be here. Otherwise, this value will be NULL. Note that this is a list and not a dictionary: the order implies the ascending order of phases or progression in this activity.
        /// </summary>
        public List<DestinyMilestonesDestinyMilestoneActivityPhase> Phases { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyMilestonesDestinyMilestoneChallengeActivity.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyMilestonesDestinyMilestoneChallengeActivity()
        {
        }

        private DestinyMilestonesDestinyMilestoneChallengeActivity(int? ActivityHash, List<DestinyChallengesDestinyChallengeStatus> Challenges, List<int?> ModifierHashes, Dictionary<string, bool?> BooleanActivityOptions, int? LoadoutRequirementIndex, List<DestinyMilestonesDestinyMilestoneActivityPhase> Phases)
        {
            
            this.ActivityHash = ActivityHash;
            
            this.Challenges = Challenges;
            
            this.ModifierHashes = ModifierHashes;
            
            this.BooleanActivityOptions = BooleanActivityOptions;
            
            this.LoadoutRequirementIndex = LoadoutRequirementIndex;
            
            this.Phases = Phases;
            
        }

        /// <summary>
        /// Returns builder of DestinyMilestonesDestinyMilestoneChallengeActivity.
        /// </summary>
        /// <returns>DestinyMilestonesDestinyMilestoneChallengeActivityBuilder</returns>
        public static DestinyMilestonesDestinyMilestoneChallengeActivityBuilder Builder()
        {
            return new DestinyMilestonesDestinyMilestoneChallengeActivityBuilder();
        }

        /// <summary>
        /// Returns DestinyMilestonesDestinyMilestoneChallengeActivityBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyMilestonesDestinyMilestoneChallengeActivityBuilder</returns>
        public DestinyMilestonesDestinyMilestoneChallengeActivityBuilder With()
        {
            return Builder()
                .ActivityHash(ActivityHash)
                .Challenges(Challenges)
                .ModifierHashes(ModifierHashes)
                .BooleanActivityOptions(BooleanActivityOptions)
                .LoadoutRequirementIndex(LoadoutRequirementIndex)
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

        public bool Equals(DestinyMilestonesDestinyMilestoneChallengeActivity other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyMilestonesDestinyMilestoneChallengeActivity.
        /// </summary>
        /// <param name="left">Compared (DestinyMilestonesDestinyMilestoneChallengeActivity</param>
        /// <param name="right">Compared (DestinyMilestonesDestinyMilestoneChallengeActivity</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyMilestonesDestinyMilestoneChallengeActivity left, DestinyMilestonesDestinyMilestoneChallengeActivity right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyMilestonesDestinyMilestoneChallengeActivity.
        /// </summary>
        /// <param name="left">Compared (DestinyMilestonesDestinyMilestoneChallengeActivity</param>
        /// <param name="right">Compared (DestinyMilestonesDestinyMilestoneChallengeActivity</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyMilestonesDestinyMilestoneChallengeActivity left, DestinyMilestonesDestinyMilestoneChallengeActivity right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyMilestonesDestinyMilestoneChallengeActivity.
        /// </summary>
        public sealed class DestinyMilestonesDestinyMilestoneChallengeActivityBuilder
        {
            private int? _ActivityHash;
            private List<DestinyChallengesDestinyChallengeStatus> _Challenges;
            private List<int?> _ModifierHashes;
            private Dictionary<string, bool?> _BooleanActivityOptions;
            private int? _LoadoutRequirementIndex;
            private List<DestinyMilestonesDestinyMilestoneActivityPhase> _Phases;

            internal DestinyMilestonesDestinyMilestoneChallengeActivityBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyMilestoneChallengeActivity.ActivityHash property.
            /// </summary>
            /// <param name="value">ActivityHash</param>
            public DestinyMilestonesDestinyMilestoneChallengeActivityBuilder ActivityHash(int? value)
            {
                _ActivityHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyMilestoneChallengeActivity.Challenges property.
            /// </summary>
            /// <param name="value">Challenges</param>
            public DestinyMilestonesDestinyMilestoneChallengeActivityBuilder Challenges(List<DestinyChallengesDestinyChallengeStatus> value)
            {
                _Challenges = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyMilestoneChallengeActivity.ModifierHashes property.
            /// </summary>
            /// <param name="value">If the activity has modifiers, this will be the list of modifiers that all variants have in common. Perform lookups against DestinyActivityModifierDefinition which defines the modifier being applied to get at the modifier data.  Note that, in the DestiyActivityDefinition, you will see many more modifiers than this being referred to: those are all *possible* modifiers for the activity, not the active ones. Use only the active ones to match what&#39;s really live.</param>
            public DestinyMilestonesDestinyMilestoneChallengeActivityBuilder ModifierHashes(List<int?> value)
            {
                _ModifierHashes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyMilestoneChallengeActivity.BooleanActivityOptions property.
            /// </summary>
            /// <param name="value">The set of activity options for this activity, keyed by an identifier that&#39;s unique for this activity (not guaranteed to be unique between or across all activities, though should be unique for every *variant* of a given *conceptual* activity: for instance, the original D2 Raid has many variant DestinyActivityDefinitions. While other activities could potentially have the same option hashes, for any given D2 base Raid variant the hash will be unique).  As a concrete example of this data, the hashes you get for Raids will correspond to the currently active \&quot;Challenge Mode\&quot;.  We don&#39;t have any human readable information for these, but saavy 3rd party app users could manually associate the key (a hash identifier for the \&quot;option\&quot; that is enabled/disabled) and the value (whether it&#39;s enabled or disabled presently)  On our side, we don&#39;t necessarily even know what these are used for (the game designers know, but we don&#39;t), and we have no human readable data for them. In order to use them, you will have to do some experimentation.</param>
            public DestinyMilestonesDestinyMilestoneChallengeActivityBuilder BooleanActivityOptions(Dictionary<string, bool?> value)
            {
                _BooleanActivityOptions = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyMilestoneChallengeActivity.LoadoutRequirementIndex property.
            /// </summary>
            /// <param name="value">If returned, this is the index into the DestinyActivityDefinition&#39;s \&quot;loadouts\&quot; property, indicating the currently active loadout requirements.</param>
            public DestinyMilestonesDestinyMilestoneChallengeActivityBuilder LoadoutRequirementIndex(int? value)
            {
                _LoadoutRequirementIndex = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyMilestoneChallengeActivity.Phases property.
            /// </summary>
            /// <param name="value">If the Activity has discrete \&quot;phases\&quot; that we can track, that info will be here. Otherwise, this value will be NULL. Note that this is a list and not a dictionary: the order implies the ascending order of phases or progression in this activity.</param>
            public DestinyMilestonesDestinyMilestoneChallengeActivityBuilder Phases(List<DestinyMilestonesDestinyMilestoneActivityPhase> value)
            {
                _Phases = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyMilestonesDestinyMilestoneChallengeActivity.
            /// </summary>
            /// <returns>DestinyMilestonesDestinyMilestoneChallengeActivity</returns>
            public DestinyMilestonesDestinyMilestoneChallengeActivity Build()
            {
                Validate();
                return new DestinyMilestonesDestinyMilestoneChallengeActivity(
                    ActivityHash: _ActivityHash,
                    Challenges: _Challenges,
                    ModifierHashes: _ModifierHashes,
                    BooleanActivityOptions: _BooleanActivityOptions,
                    LoadoutRequirementIndex: _LoadoutRequirementIndex,
                    Phases: _Phases
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}