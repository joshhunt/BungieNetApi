using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyMilestonesDestinyPublicMilestoneChallengeActivity
    /// </summary>
    public sealed class DestinyMilestonesDestinyPublicMilestoneChallengeActivity:  IEquatable<DestinyMilestonesDestinyPublicMilestoneChallengeActivity>
    { 
        /// <summary>
        /// ActivityHash
        /// </summary>
        public int? ActivityHash { get; private set; }

        /// <summary>
        /// ChallengeObjectiveHashes
        /// </summary>
        public List<int?> ChallengeObjectiveHashes { get; private set; }

        /// <summary>
        /// If the activity has modifiers, this will be the list of modifiers that all variants have in common. Perform lookups against DestinyActivityModifierDefinition which defines the modifier being applied to get at the modifier data.  Note that, in the DestiyActivityDefinition, you will see many more modifiers than this being referred to: those are all *possible* modifiers for the activity, not the active ones. Use only the active ones to match what&#39;s really live.
        /// </summary>
        public List<int?> ModifierHashes { get; private set; }

        /// <summary>
        /// If returned, this is the index into the DestinyActivityDefinition&#39;s \&quot;loadouts\&quot; property, indicating the currently active loadout requirements.
        /// </summary>
        public int? LoadoutRequirementIndex { get; private set; }

        /// <summary>
        /// The ordered list of phases for this activity, if any. Note that we have no human readable info for phases, nor any entities to relate them to: relating these hashes to something human readable is up to you unfortunately.
        /// </summary>
        public List<int?> PhaseHashes { get; private set; }

        /// <summary>
        /// The set of activity options for this activity, keyed by an identifier that&#39;s unique for this activity (not guaranteed to be unique between or across all activities, though should be unique for every *variant* of a given *conceptual* activity: for instance, the original D2 Raid has many variant DestinyActivityDefinitions. While other activities could potentially have the same option hashes, for any given D2 base Raid variant the hash will be unique).  As a concrete example of this data, the hashes you get for Raids will correspond to the currently active \&quot;Challenge Mode\&quot;.  We have no human readable information for this data, so it&#39;s up to you if you want to associate it with such info to show it.
        /// </summary>
        public Dictionary<string, bool?> BooleanActivityOptions { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyMilestonesDestinyPublicMilestoneChallengeActivity.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyMilestonesDestinyPublicMilestoneChallengeActivity()
        {
        }

        private DestinyMilestonesDestinyPublicMilestoneChallengeActivity(int? ActivityHash, List<int?> ChallengeObjectiveHashes, List<int?> ModifierHashes, int? LoadoutRequirementIndex, List<int?> PhaseHashes, Dictionary<string, bool?> BooleanActivityOptions)
        {
            
            this.ActivityHash = ActivityHash;
            
            this.ChallengeObjectiveHashes = ChallengeObjectiveHashes;
            
            this.ModifierHashes = ModifierHashes;
            
            this.LoadoutRequirementIndex = LoadoutRequirementIndex;
            
            this.PhaseHashes = PhaseHashes;
            
            this.BooleanActivityOptions = BooleanActivityOptions;
            
        }

        /// <summary>
        /// Returns builder of DestinyMilestonesDestinyPublicMilestoneChallengeActivity.
        /// </summary>
        /// <returns>DestinyMilestonesDestinyPublicMilestoneChallengeActivityBuilder</returns>
        public static DestinyMilestonesDestinyPublicMilestoneChallengeActivityBuilder Builder()
        {
            return new DestinyMilestonesDestinyPublicMilestoneChallengeActivityBuilder();
        }

        /// <summary>
        /// Returns DestinyMilestonesDestinyPublicMilestoneChallengeActivityBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyMilestonesDestinyPublicMilestoneChallengeActivityBuilder</returns>
        public DestinyMilestonesDestinyPublicMilestoneChallengeActivityBuilder With()
        {
            return Builder()
                .ActivityHash(ActivityHash)
                .ChallengeObjectiveHashes(ChallengeObjectiveHashes)
                .ModifierHashes(ModifierHashes)
                .LoadoutRequirementIndex(LoadoutRequirementIndex)
                .PhaseHashes(PhaseHashes)
                .BooleanActivityOptions(BooleanActivityOptions);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyMilestonesDestinyPublicMilestoneChallengeActivity other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyMilestonesDestinyPublicMilestoneChallengeActivity.
        /// </summary>
        /// <param name="left">Compared (DestinyMilestonesDestinyPublicMilestoneChallengeActivity</param>
        /// <param name="right">Compared (DestinyMilestonesDestinyPublicMilestoneChallengeActivity</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyMilestonesDestinyPublicMilestoneChallengeActivity left, DestinyMilestonesDestinyPublicMilestoneChallengeActivity right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyMilestonesDestinyPublicMilestoneChallengeActivity.
        /// </summary>
        /// <param name="left">Compared (DestinyMilestonesDestinyPublicMilestoneChallengeActivity</param>
        /// <param name="right">Compared (DestinyMilestonesDestinyPublicMilestoneChallengeActivity</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyMilestonesDestinyPublicMilestoneChallengeActivity left, DestinyMilestonesDestinyPublicMilestoneChallengeActivity right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyMilestonesDestinyPublicMilestoneChallengeActivity.
        /// </summary>
        public sealed class DestinyMilestonesDestinyPublicMilestoneChallengeActivityBuilder
        {
            private int? _ActivityHash;
            private List<int?> _ChallengeObjectiveHashes;
            private List<int?> _ModifierHashes;
            private int? _LoadoutRequirementIndex;
            private List<int?> _PhaseHashes;
            private Dictionary<string, bool?> _BooleanActivityOptions;

            internal DestinyMilestonesDestinyPublicMilestoneChallengeActivityBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyPublicMilestoneChallengeActivity.ActivityHash property.
            /// </summary>
            /// <param name="value">ActivityHash</param>
            public DestinyMilestonesDestinyPublicMilestoneChallengeActivityBuilder ActivityHash(int? value)
            {
                _ActivityHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyPublicMilestoneChallengeActivity.ChallengeObjectiveHashes property.
            /// </summary>
            /// <param name="value">ChallengeObjectiveHashes</param>
            public DestinyMilestonesDestinyPublicMilestoneChallengeActivityBuilder ChallengeObjectiveHashes(List<int?> value)
            {
                _ChallengeObjectiveHashes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyPublicMilestoneChallengeActivity.ModifierHashes property.
            /// </summary>
            /// <param name="value">If the activity has modifiers, this will be the list of modifiers that all variants have in common. Perform lookups against DestinyActivityModifierDefinition which defines the modifier being applied to get at the modifier data.  Note that, in the DestiyActivityDefinition, you will see many more modifiers than this being referred to: those are all *possible* modifiers for the activity, not the active ones. Use only the active ones to match what&#39;s really live.</param>
            public DestinyMilestonesDestinyPublicMilestoneChallengeActivityBuilder ModifierHashes(List<int?> value)
            {
                _ModifierHashes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyPublicMilestoneChallengeActivity.LoadoutRequirementIndex property.
            /// </summary>
            /// <param name="value">If returned, this is the index into the DestinyActivityDefinition&#39;s \&quot;loadouts\&quot; property, indicating the currently active loadout requirements.</param>
            public DestinyMilestonesDestinyPublicMilestoneChallengeActivityBuilder LoadoutRequirementIndex(int? value)
            {
                _LoadoutRequirementIndex = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyPublicMilestoneChallengeActivity.PhaseHashes property.
            /// </summary>
            /// <param name="value">The ordered list of phases for this activity, if any. Note that we have no human readable info for phases, nor any entities to relate them to: relating these hashes to something human readable is up to you unfortunately.</param>
            public DestinyMilestonesDestinyPublicMilestoneChallengeActivityBuilder PhaseHashes(List<int?> value)
            {
                _PhaseHashes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyMilestonesDestinyPublicMilestoneChallengeActivity.BooleanActivityOptions property.
            /// </summary>
            /// <param name="value">The set of activity options for this activity, keyed by an identifier that&#39;s unique for this activity (not guaranteed to be unique between or across all activities, though should be unique for every *variant* of a given *conceptual* activity: for instance, the original D2 Raid has many variant DestinyActivityDefinitions. While other activities could potentially have the same option hashes, for any given D2 base Raid variant the hash will be unique).  As a concrete example of this data, the hashes you get for Raids will correspond to the currently active \&quot;Challenge Mode\&quot;.  We have no human readable information for this data, so it&#39;s up to you if you want to associate it with such info to show it.</param>
            public DestinyMilestonesDestinyPublicMilestoneChallengeActivityBuilder BooleanActivityOptions(Dictionary<string, bool?> value)
            {
                _BooleanActivityOptions = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyMilestonesDestinyPublicMilestoneChallengeActivity.
            /// </summary>
            /// <returns>DestinyMilestonesDestinyPublicMilestoneChallengeActivity</returns>
            public DestinyMilestonesDestinyPublicMilestoneChallengeActivity Build()
            {
                Validate();
                return new DestinyMilestonesDestinyPublicMilestoneChallengeActivity(
                    ActivityHash: _ActivityHash,
                    ChallengeObjectiveHashes: _ChallengeObjectiveHashes,
                    ModifierHashes: _ModifierHashes,
                    LoadoutRequirementIndex: _LoadoutRequirementIndex,
                    PhaseHashes: _PhaseHashes,
                    BooleanActivityOptions: _BooleanActivityOptions
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}