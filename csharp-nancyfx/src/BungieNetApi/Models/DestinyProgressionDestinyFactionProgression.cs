using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Mostly for historical purposes, we segregate Faction progressions from other progressions. This is just a DestinyProgression with a shortcut for finding the DestinyFactionDefinition of the faction related to the progression.
    /// </summary>
    public sealed class DestinyProgressionDestinyFactionProgression:  IEquatable<DestinyProgressionDestinyFactionProgression>
    { 
        /// <summary>
        /// The hash identifier of the Faction related to this progression. Use it to look up the DestinyFactionDefinition for more rendering info.
        /// </summary>
        public int? FactionHash { get; private set; }

        /// <summary>
        /// The index of the Faction vendor that is currently available. Will be set to -1 if no vendors are available.
        /// </summary>
        public int? FactionVendorIndex { get; private set; }

        /// <summary>
        /// The hash identifier of the Progression in question. Use it to look up the DestinyProgressionDefinition in static data.
        /// </summary>
        public int? ProgressionHash { get; private set; }

        /// <summary>
        /// The amount of progress earned today for this progression.
        /// </summary>
        public int? DailyProgress { get; private set; }

        /// <summary>
        /// If this progression has a daily limit, this is that limit.
        /// </summary>
        public int? DailyLimit { get; private set; }

        /// <summary>
        /// The amount of progress earned toward this progression in the current week.
        /// </summary>
        public int? WeeklyProgress { get; private set; }

        /// <summary>
        /// If this progression has a weekly limit, this is that limit.
        /// </summary>
        public int? WeeklyLimit { get; private set; }

        /// <summary>
        /// This is the total amount of progress obtained overall for this progression (for instance, the total amount of Character Level experience earned)
        /// </summary>
        public int? CurrentProgress { get; private set; }

        /// <summary>
        /// This is the level of the progression (for instance, the Character Level).
        /// </summary>
        public int? Level { get; private set; }

        /// <summary>
        /// This is the maximum possible level you can achieve for this progression (for example, the maximum character level obtainable)
        /// </summary>
        public int? LevelCap { get; private set; }

        /// <summary>
        /// Progressions define their levels in \&quot;steps\&quot;. Since the last step may be repeatable, the user may be at a higher level than the actual Step achieved in the progression. Not necessarily useful, but potentially interesting for those cruising the API. Relate this to the \&quot;steps\&quot; property of the DestinyProgression to see which step the user is on, if you care about that. (Note that this is Content Version dependent since it refers to indexes.)
        /// </summary>
        public int? StepIndex { get; private set; }

        /// <summary>
        /// The amount of progression (i.e. \&quot;Experience\&quot;) needed to reach the next level of this Progression. Jeez, progression is such an overloaded word.
        /// </summary>
        public int? ProgressToNextLevel { get; private set; }

        /// <summary>
        /// The total amount of progression (i.e. \&quot;Experience\&quot;) needed in order to reach the next level.
        /// </summary>
        public int? NextLevelAt { get; private set; }

        /// <summary>
        /// The number of resets of this progression you&#39;ve executed this season, if applicable to this progression.
        /// </summary>
        public int? CurrentResetCount { get; private set; }

        /// <summary>
        /// Information about historical resets of this progression, if there is any data for it.
        /// </summary>
        public List<DestinyDestinyProgressionResetEntry> SeasonResets { get; private set; }

        /// <summary>
        /// Information about historical rewards for this progression, if there is any data for it.
        /// </summary>
        public List<int?> RewardItemStates { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyProgressionDestinyFactionProgression.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyProgressionDestinyFactionProgression()
        {
        }

        private DestinyProgressionDestinyFactionProgression(int? FactionHash, int? FactionVendorIndex, int? ProgressionHash, int? DailyProgress, int? DailyLimit, int? WeeklyProgress, int? WeeklyLimit, int? CurrentProgress, int? Level, int? LevelCap, int? StepIndex, int? ProgressToNextLevel, int? NextLevelAt, int? CurrentResetCount, List<DestinyDestinyProgressionResetEntry> SeasonResets, List<int?> RewardItemStates)
        {
            
            this.FactionHash = FactionHash;
            
            this.FactionVendorIndex = FactionVendorIndex;
            
            this.ProgressionHash = ProgressionHash;
            
            this.DailyProgress = DailyProgress;
            
            this.DailyLimit = DailyLimit;
            
            this.WeeklyProgress = WeeklyProgress;
            
            this.WeeklyLimit = WeeklyLimit;
            
            this.CurrentProgress = CurrentProgress;
            
            this.Level = Level;
            
            this.LevelCap = LevelCap;
            
            this.StepIndex = StepIndex;
            
            this.ProgressToNextLevel = ProgressToNextLevel;
            
            this.NextLevelAt = NextLevelAt;
            
            this.CurrentResetCount = CurrentResetCount;
            
            this.SeasonResets = SeasonResets;
            
            this.RewardItemStates = RewardItemStates;
            
        }

        /// <summary>
        /// Returns builder of DestinyProgressionDestinyFactionProgression.
        /// </summary>
        /// <returns>DestinyProgressionDestinyFactionProgressionBuilder</returns>
        public static DestinyProgressionDestinyFactionProgressionBuilder Builder()
        {
            return new DestinyProgressionDestinyFactionProgressionBuilder();
        }

        /// <summary>
        /// Returns DestinyProgressionDestinyFactionProgressionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyProgressionDestinyFactionProgressionBuilder</returns>
        public DestinyProgressionDestinyFactionProgressionBuilder With()
        {
            return Builder()
                .FactionHash(FactionHash)
                .FactionVendorIndex(FactionVendorIndex)
                .ProgressionHash(ProgressionHash)
                .DailyProgress(DailyProgress)
                .DailyLimit(DailyLimit)
                .WeeklyProgress(WeeklyProgress)
                .WeeklyLimit(WeeklyLimit)
                .CurrentProgress(CurrentProgress)
                .Level(Level)
                .LevelCap(LevelCap)
                .StepIndex(StepIndex)
                .ProgressToNextLevel(ProgressToNextLevel)
                .NextLevelAt(NextLevelAt)
                .CurrentResetCount(CurrentResetCount)
                .SeasonResets(SeasonResets)
                .RewardItemStates(RewardItemStates);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyProgressionDestinyFactionProgression other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyProgressionDestinyFactionProgression.
        /// </summary>
        /// <param name="left">Compared (DestinyProgressionDestinyFactionProgression</param>
        /// <param name="right">Compared (DestinyProgressionDestinyFactionProgression</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyProgressionDestinyFactionProgression left, DestinyProgressionDestinyFactionProgression right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyProgressionDestinyFactionProgression.
        /// </summary>
        /// <param name="left">Compared (DestinyProgressionDestinyFactionProgression</param>
        /// <param name="right">Compared (DestinyProgressionDestinyFactionProgression</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyProgressionDestinyFactionProgression left, DestinyProgressionDestinyFactionProgression right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyProgressionDestinyFactionProgression.
        /// </summary>
        public sealed class DestinyProgressionDestinyFactionProgressionBuilder
        {
            private int? _FactionHash;
            private int? _FactionVendorIndex;
            private int? _ProgressionHash;
            private int? _DailyProgress;
            private int? _DailyLimit;
            private int? _WeeklyProgress;
            private int? _WeeklyLimit;
            private int? _CurrentProgress;
            private int? _Level;
            private int? _LevelCap;
            private int? _StepIndex;
            private int? _ProgressToNextLevel;
            private int? _NextLevelAt;
            private int? _CurrentResetCount;
            private List<DestinyDestinyProgressionResetEntry> _SeasonResets;
            private List<int?> _RewardItemStates;

            internal DestinyProgressionDestinyFactionProgressionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyProgressionDestinyFactionProgression.FactionHash property.
            /// </summary>
            /// <param name="value">The hash identifier of the Faction related to this progression. Use it to look up the DestinyFactionDefinition for more rendering info.</param>
            public DestinyProgressionDestinyFactionProgressionBuilder FactionHash(int? value)
            {
                _FactionHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyProgressionDestinyFactionProgression.FactionVendorIndex property.
            /// </summary>
            /// <param name="value">The index of the Faction vendor that is currently available. Will be set to -1 if no vendors are available.</param>
            public DestinyProgressionDestinyFactionProgressionBuilder FactionVendorIndex(int? value)
            {
                _FactionVendorIndex = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyProgressionDestinyFactionProgression.ProgressionHash property.
            /// </summary>
            /// <param name="value">The hash identifier of the Progression in question. Use it to look up the DestinyProgressionDefinition in static data.</param>
            public DestinyProgressionDestinyFactionProgressionBuilder ProgressionHash(int? value)
            {
                _ProgressionHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyProgressionDestinyFactionProgression.DailyProgress property.
            /// </summary>
            /// <param name="value">The amount of progress earned today for this progression.</param>
            public DestinyProgressionDestinyFactionProgressionBuilder DailyProgress(int? value)
            {
                _DailyProgress = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyProgressionDestinyFactionProgression.DailyLimit property.
            /// </summary>
            /// <param name="value">If this progression has a daily limit, this is that limit.</param>
            public DestinyProgressionDestinyFactionProgressionBuilder DailyLimit(int? value)
            {
                _DailyLimit = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyProgressionDestinyFactionProgression.WeeklyProgress property.
            /// </summary>
            /// <param name="value">The amount of progress earned toward this progression in the current week.</param>
            public DestinyProgressionDestinyFactionProgressionBuilder WeeklyProgress(int? value)
            {
                _WeeklyProgress = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyProgressionDestinyFactionProgression.WeeklyLimit property.
            /// </summary>
            /// <param name="value">If this progression has a weekly limit, this is that limit.</param>
            public DestinyProgressionDestinyFactionProgressionBuilder WeeklyLimit(int? value)
            {
                _WeeklyLimit = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyProgressionDestinyFactionProgression.CurrentProgress property.
            /// </summary>
            /// <param name="value">This is the total amount of progress obtained overall for this progression (for instance, the total amount of Character Level experience earned)</param>
            public DestinyProgressionDestinyFactionProgressionBuilder CurrentProgress(int? value)
            {
                _CurrentProgress = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyProgressionDestinyFactionProgression.Level property.
            /// </summary>
            /// <param name="value">This is the level of the progression (for instance, the Character Level).</param>
            public DestinyProgressionDestinyFactionProgressionBuilder Level(int? value)
            {
                _Level = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyProgressionDestinyFactionProgression.LevelCap property.
            /// </summary>
            /// <param name="value">This is the maximum possible level you can achieve for this progression (for example, the maximum character level obtainable)</param>
            public DestinyProgressionDestinyFactionProgressionBuilder LevelCap(int? value)
            {
                _LevelCap = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyProgressionDestinyFactionProgression.StepIndex property.
            /// </summary>
            /// <param name="value">Progressions define their levels in \&quot;steps\&quot;. Since the last step may be repeatable, the user may be at a higher level than the actual Step achieved in the progression. Not necessarily useful, but potentially interesting for those cruising the API. Relate this to the \&quot;steps\&quot; property of the DestinyProgression to see which step the user is on, if you care about that. (Note that this is Content Version dependent since it refers to indexes.)</param>
            public DestinyProgressionDestinyFactionProgressionBuilder StepIndex(int? value)
            {
                _StepIndex = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyProgressionDestinyFactionProgression.ProgressToNextLevel property.
            /// </summary>
            /// <param name="value">The amount of progression (i.e. \&quot;Experience\&quot;) needed to reach the next level of this Progression. Jeez, progression is such an overloaded word.</param>
            public DestinyProgressionDestinyFactionProgressionBuilder ProgressToNextLevel(int? value)
            {
                _ProgressToNextLevel = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyProgressionDestinyFactionProgression.NextLevelAt property.
            /// </summary>
            /// <param name="value">The total amount of progression (i.e. \&quot;Experience\&quot;) needed in order to reach the next level.</param>
            public DestinyProgressionDestinyFactionProgressionBuilder NextLevelAt(int? value)
            {
                _NextLevelAt = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyProgressionDestinyFactionProgression.CurrentResetCount property.
            /// </summary>
            /// <param name="value">The number of resets of this progression you&#39;ve executed this season, if applicable to this progression.</param>
            public DestinyProgressionDestinyFactionProgressionBuilder CurrentResetCount(int? value)
            {
                _CurrentResetCount = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyProgressionDestinyFactionProgression.SeasonResets property.
            /// </summary>
            /// <param name="value">Information about historical resets of this progression, if there is any data for it.</param>
            public DestinyProgressionDestinyFactionProgressionBuilder SeasonResets(List<DestinyDestinyProgressionResetEntry> value)
            {
                _SeasonResets = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyProgressionDestinyFactionProgression.RewardItemStates property.
            /// </summary>
            /// <param name="value">Information about historical rewards for this progression, if there is any data for it.</param>
            public DestinyProgressionDestinyFactionProgressionBuilder RewardItemStates(List<int?> value)
            {
                _RewardItemStates = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyProgressionDestinyFactionProgression.
            /// </summary>
            /// <returns>DestinyProgressionDestinyFactionProgression</returns>
            public DestinyProgressionDestinyFactionProgression Build()
            {
                Validate();
                return new DestinyProgressionDestinyFactionProgression(
                    FactionHash: _FactionHash,
                    FactionVendorIndex: _FactionVendorIndex,
                    ProgressionHash: _ProgressionHash,
                    DailyProgress: _DailyProgress,
                    DailyLimit: _DailyLimit,
                    WeeklyProgress: _WeeklyProgress,
                    WeeklyLimit: _WeeklyLimit,
                    CurrentProgress: _CurrentProgress,
                    Level: _Level,
                    LevelCap: _LevelCap,
                    StepIndex: _StepIndex,
                    ProgressToNextLevel: _ProgressToNextLevel,
                    NextLevelAt: _NextLevelAt,
                    CurrentResetCount: _CurrentResetCount,
                    SeasonResets: _SeasonResets,
                    RewardItemStates: _RewardItemStates
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}