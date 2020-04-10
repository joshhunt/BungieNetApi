using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Represents the \&quot;Live\&quot; data that we can obtain about a Character&#39;s status with a specific Activity. This will tell you whether the character can participate in the activity, as well as some other basic mutable information.   Meant to be combined with static DestinyActivityDefinition data for a full picture of the Activity.
    /// </summary>
    public sealed class DestinyDestinyActivity:  IEquatable<DestinyDestinyActivity>
    { 
        /// <summary>
        /// The hash identifier of the Activity. Use this to look up the DestinyActivityDefinition of the activity.
        /// </summary>
        public int? ActivityHash { get; private set; }

        /// <summary>
        /// If true, then the activity should have a \&quot;new\&quot; indicator in the Director UI.
        /// </summary>
        public bool? IsNew { get; private set; }

        /// <summary>
        /// If true, the user is allowed to lead a Fireteam into this activity.
        /// </summary>
        public bool? CanLead { get; private set; }

        /// <summary>
        /// If true, the user is allowed to join with another Fireteam in this activity.
        /// </summary>
        public bool? CanJoin { get; private set; }

        /// <summary>
        /// If true, we both have the ability to know that the user has completed this activity and they have completed it. Unfortunately, we can&#39;t necessarily know this for all activities. As such, this should probably only be used if you already know in advance which specific activities you wish to check.
        /// </summary>
        public bool? IsCompleted { get; private set; }

        /// <summary>
        /// If true, the user should be able to see this activity.
        /// </summary>
        public bool? IsVisible { get; private set; }

        /// <summary>
        /// The difficulty level of the activity, if applicable.
        /// </summary>
        public int? DisplayLevel { get; private set; }

        /// <summary>
        /// The recommended light level for the activity, if applicable.
        /// </summary>
        public int? RecommendedLight { get; private set; }

        /// <summary>
        /// A DestinyActivityDifficultyTier enum value indicating the difficulty of the activity.
        /// </summary>
        public int? DifficultyTier { get; private set; }

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
        /// Empty constructor required by some serializers.
        /// Use DestinyDestinyActivity.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDestinyActivity()
        {
        }

        private DestinyDestinyActivity(int? ActivityHash, bool? IsNew, bool? CanLead, bool? CanJoin, bool? IsCompleted, bool? IsVisible, int? DisplayLevel, int? RecommendedLight, int? DifficultyTier, List<DestinyChallengesDestinyChallengeStatus> Challenges, List<int?> ModifierHashes, Dictionary<string, bool?> BooleanActivityOptions, int? LoadoutRequirementIndex)
        {
            
            this.ActivityHash = ActivityHash;
            
            this.IsNew = IsNew;
            
            this.CanLead = CanLead;
            
            this.CanJoin = CanJoin;
            
            this.IsCompleted = IsCompleted;
            
            this.IsVisible = IsVisible;
            
            this.DisplayLevel = DisplayLevel;
            
            this.RecommendedLight = RecommendedLight;
            
            this.DifficultyTier = DifficultyTier;
            
            this.Challenges = Challenges;
            
            this.ModifierHashes = ModifierHashes;
            
            this.BooleanActivityOptions = BooleanActivityOptions;
            
            this.LoadoutRequirementIndex = LoadoutRequirementIndex;
            
        }

        /// <summary>
        /// Returns builder of DestinyDestinyActivity.
        /// </summary>
        /// <returns>DestinyDestinyActivityBuilder</returns>
        public static DestinyDestinyActivityBuilder Builder()
        {
            return new DestinyDestinyActivityBuilder();
        }

        /// <summary>
        /// Returns DestinyDestinyActivityBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDestinyActivityBuilder</returns>
        public DestinyDestinyActivityBuilder With()
        {
            return Builder()
                .ActivityHash(ActivityHash)
                .IsNew(IsNew)
                .CanLead(CanLead)
                .CanJoin(CanJoin)
                .IsCompleted(IsCompleted)
                .IsVisible(IsVisible)
                .DisplayLevel(DisplayLevel)
                .RecommendedLight(RecommendedLight)
                .DifficultyTier(DifficultyTier)
                .Challenges(Challenges)
                .ModifierHashes(ModifierHashes)
                .BooleanActivityOptions(BooleanActivityOptions)
                .LoadoutRequirementIndex(LoadoutRequirementIndex);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDestinyActivity other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDestinyActivity.
        /// </summary>
        /// <param name="left">Compared (DestinyDestinyActivity</param>
        /// <param name="right">Compared (DestinyDestinyActivity</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDestinyActivity left, DestinyDestinyActivity right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDestinyActivity.
        /// </summary>
        /// <param name="left">Compared (DestinyDestinyActivity</param>
        /// <param name="right">Compared (DestinyDestinyActivity</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDestinyActivity left, DestinyDestinyActivity right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDestinyActivity.
        /// </summary>
        public sealed class DestinyDestinyActivityBuilder
        {
            private int? _ActivityHash;
            private bool? _IsNew;
            private bool? _CanLead;
            private bool? _CanJoin;
            private bool? _IsCompleted;
            private bool? _IsVisible;
            private int? _DisplayLevel;
            private int? _RecommendedLight;
            private int? _DifficultyTier;
            private List<DestinyChallengesDestinyChallengeStatus> _Challenges;
            private List<int?> _ModifierHashes;
            private Dictionary<string, bool?> _BooleanActivityOptions;
            private int? _LoadoutRequirementIndex;

            internal DestinyDestinyActivityBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDestinyActivity.ActivityHash property.
            /// </summary>
            /// <param name="value">The hash identifier of the Activity. Use this to look up the DestinyActivityDefinition of the activity.</param>
            public DestinyDestinyActivityBuilder ActivityHash(int? value)
            {
                _ActivityHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDestinyActivity.IsNew property.
            /// </summary>
            /// <param name="value">If true, then the activity should have a \&quot;new\&quot; indicator in the Director UI.</param>
            public DestinyDestinyActivityBuilder IsNew(bool? value)
            {
                _IsNew = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDestinyActivity.CanLead property.
            /// </summary>
            /// <param name="value">If true, the user is allowed to lead a Fireteam into this activity.</param>
            public DestinyDestinyActivityBuilder CanLead(bool? value)
            {
                _CanLead = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDestinyActivity.CanJoin property.
            /// </summary>
            /// <param name="value">If true, the user is allowed to join with another Fireteam in this activity.</param>
            public DestinyDestinyActivityBuilder CanJoin(bool? value)
            {
                _CanJoin = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDestinyActivity.IsCompleted property.
            /// </summary>
            /// <param name="value">If true, we both have the ability to know that the user has completed this activity and they have completed it. Unfortunately, we can&#39;t necessarily know this for all activities. As such, this should probably only be used if you already know in advance which specific activities you wish to check.</param>
            public DestinyDestinyActivityBuilder IsCompleted(bool? value)
            {
                _IsCompleted = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDestinyActivity.IsVisible property.
            /// </summary>
            /// <param name="value">If true, the user should be able to see this activity.</param>
            public DestinyDestinyActivityBuilder IsVisible(bool? value)
            {
                _IsVisible = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDestinyActivity.DisplayLevel property.
            /// </summary>
            /// <param name="value">The difficulty level of the activity, if applicable.</param>
            public DestinyDestinyActivityBuilder DisplayLevel(int? value)
            {
                _DisplayLevel = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDestinyActivity.RecommendedLight property.
            /// </summary>
            /// <param name="value">The recommended light level for the activity, if applicable.</param>
            public DestinyDestinyActivityBuilder RecommendedLight(int? value)
            {
                _RecommendedLight = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDestinyActivity.DifficultyTier property.
            /// </summary>
            /// <param name="value">A DestinyActivityDifficultyTier enum value indicating the difficulty of the activity.</param>
            public DestinyDestinyActivityBuilder DifficultyTier(int? value)
            {
                _DifficultyTier = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDestinyActivity.Challenges property.
            /// </summary>
            /// <param name="value">Challenges</param>
            public DestinyDestinyActivityBuilder Challenges(List<DestinyChallengesDestinyChallengeStatus> value)
            {
                _Challenges = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDestinyActivity.ModifierHashes property.
            /// </summary>
            /// <param name="value">If the activity has modifiers, this will be the list of modifiers that all variants have in common. Perform lookups against DestinyActivityModifierDefinition which defines the modifier being applied to get at the modifier data.  Note that, in the DestiyActivityDefinition, you will see many more modifiers than this being referred to: those are all *possible* modifiers for the activity, not the active ones. Use only the active ones to match what&#39;s really live.</param>
            public DestinyDestinyActivityBuilder ModifierHashes(List<int?> value)
            {
                _ModifierHashes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDestinyActivity.BooleanActivityOptions property.
            /// </summary>
            /// <param name="value">The set of activity options for this activity, keyed by an identifier that&#39;s unique for this activity (not guaranteed to be unique between or across all activities, though should be unique for every *variant* of a given *conceptual* activity: for instance, the original D2 Raid has many variant DestinyActivityDefinitions. While other activities could potentially have the same option hashes, for any given D2 base Raid variant the hash will be unique).  As a concrete example of this data, the hashes you get for Raids will correspond to the currently active \&quot;Challenge Mode\&quot;.  We don&#39;t have any human readable information for these, but saavy 3rd party app users could manually associate the key (a hash identifier for the \&quot;option\&quot; that is enabled/disabled) and the value (whether it&#39;s enabled or disabled presently)  On our side, we don&#39;t necessarily even know what these are used for (the game designers know, but we don&#39;t), and we have no human readable data for them. In order to use them, you will have to do some experimentation.</param>
            public DestinyDestinyActivityBuilder BooleanActivityOptions(Dictionary<string, bool?> value)
            {
                _BooleanActivityOptions = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDestinyActivity.LoadoutRequirementIndex property.
            /// </summary>
            /// <param name="value">If returned, this is the index into the DestinyActivityDefinition&#39;s \&quot;loadouts\&quot; property, indicating the currently active loadout requirements.</param>
            public DestinyDestinyActivityBuilder LoadoutRequirementIndex(int? value)
            {
                _LoadoutRequirementIndex = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDestinyActivity.
            /// </summary>
            /// <returns>DestinyDestinyActivity</returns>
            public DestinyDestinyActivity Build()
            {
                Validate();
                return new DestinyDestinyActivity(
                    ActivityHash: _ActivityHash,
                    IsNew: _IsNew,
                    CanLead: _CanLead,
                    CanJoin: _CanJoin,
                    IsCompleted: _IsCompleted,
                    IsVisible: _IsVisible,
                    DisplayLevel: _DisplayLevel,
                    RecommendedLight: _RecommendedLight,
                    DifficultyTier: _DifficultyTier,
                    Challenges: _Challenges,
                    ModifierHashes: _ModifierHashes,
                    BooleanActivityOptions: _BooleanActivityOptions,
                    LoadoutRequirementIndex: _LoadoutRequirementIndex
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}