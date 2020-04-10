using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// If you are playing in an activity, this is some information about it.  Note that we cannot guarantee any of this resembles what ends up in the PGCR in any way. They are sourced by two entirely separate systems with their own logic, and the one we source this data from should be considered non-authoritative in comparison.
    /// </summary>
    public sealed class DestinyComponentsProfilesDestinyProfileTransitoryCurrentActivity:  IEquatable<DestinyComponentsProfilesDestinyProfileTransitoryCurrentActivity>
    { 
        /// <summary>
        /// When the activity started.
        /// </summary>
        public DateTime? StartTime { get; private set; }

        /// <summary>
        /// If you&#39;re still in it but it \&quot;ended\&quot; (like when folks are dancing around the loot after they beat a boss), this is when the activity ended.
        /// </summary>
        public DateTime? EndTime { get; private set; }

        /// <summary>
        /// This is what our non-authoritative source thought the score was.
        /// </summary>
        public float? Score { get; private set; }

        /// <summary>
        /// If you have human opponents, this is the highest opposing team&#39;s score.
        /// </summary>
        public float? HighestOpposingFactionScore { get; private set; }

        /// <summary>
        /// This is how many human or poorly crafted aimbot opponents you have.
        /// </summary>
        public int? NumberOfOpponents { get; private set; }

        /// <summary>
        /// This is how many human or poorly crafted aimbots are on your team.
        /// </summary>
        public int? NumberOfPlayers { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyComponentsProfilesDestinyProfileTransitoryCurrentActivity.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyComponentsProfilesDestinyProfileTransitoryCurrentActivity()
        {
        }

        private DestinyComponentsProfilesDestinyProfileTransitoryCurrentActivity(DateTime? StartTime, DateTime? EndTime, float? Score, float? HighestOpposingFactionScore, int? NumberOfOpponents, int? NumberOfPlayers)
        {
            
            this.StartTime = StartTime;
            
            this.EndTime = EndTime;
            
            this.Score = Score;
            
            this.HighestOpposingFactionScore = HighestOpposingFactionScore;
            
            this.NumberOfOpponents = NumberOfOpponents;
            
            this.NumberOfPlayers = NumberOfPlayers;
            
        }

        /// <summary>
        /// Returns builder of DestinyComponentsProfilesDestinyProfileTransitoryCurrentActivity.
        /// </summary>
        /// <returns>DestinyComponentsProfilesDestinyProfileTransitoryCurrentActivityBuilder</returns>
        public static DestinyComponentsProfilesDestinyProfileTransitoryCurrentActivityBuilder Builder()
        {
            return new DestinyComponentsProfilesDestinyProfileTransitoryCurrentActivityBuilder();
        }

        /// <summary>
        /// Returns DestinyComponentsProfilesDestinyProfileTransitoryCurrentActivityBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyComponentsProfilesDestinyProfileTransitoryCurrentActivityBuilder</returns>
        public DestinyComponentsProfilesDestinyProfileTransitoryCurrentActivityBuilder With()
        {
            return Builder()
                .StartTime(StartTime)
                .EndTime(EndTime)
                .Score(Score)
                .HighestOpposingFactionScore(HighestOpposingFactionScore)
                .NumberOfOpponents(NumberOfOpponents)
                .NumberOfPlayers(NumberOfPlayers);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyComponentsProfilesDestinyProfileTransitoryCurrentActivity other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyComponentsProfilesDestinyProfileTransitoryCurrentActivity.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsProfilesDestinyProfileTransitoryCurrentActivity</param>
        /// <param name="right">Compared (DestinyComponentsProfilesDestinyProfileTransitoryCurrentActivity</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyComponentsProfilesDestinyProfileTransitoryCurrentActivity left, DestinyComponentsProfilesDestinyProfileTransitoryCurrentActivity right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyComponentsProfilesDestinyProfileTransitoryCurrentActivity.
        /// </summary>
        /// <param name="left">Compared (DestinyComponentsProfilesDestinyProfileTransitoryCurrentActivity</param>
        /// <param name="right">Compared (DestinyComponentsProfilesDestinyProfileTransitoryCurrentActivity</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyComponentsProfilesDestinyProfileTransitoryCurrentActivity left, DestinyComponentsProfilesDestinyProfileTransitoryCurrentActivity right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyComponentsProfilesDestinyProfileTransitoryCurrentActivity.
        /// </summary>
        public sealed class DestinyComponentsProfilesDestinyProfileTransitoryCurrentActivityBuilder
        {
            private DateTime? _StartTime;
            private DateTime? _EndTime;
            private float? _Score;
            private float? _HighestOpposingFactionScore;
            private int? _NumberOfOpponents;
            private int? _NumberOfPlayers;

            internal DestinyComponentsProfilesDestinyProfileTransitoryCurrentActivityBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyComponentsProfilesDestinyProfileTransitoryCurrentActivity.StartTime property.
            /// </summary>
            /// <param name="value">When the activity started.</param>
            public DestinyComponentsProfilesDestinyProfileTransitoryCurrentActivityBuilder StartTime(DateTime? value)
            {
                _StartTime = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsProfilesDestinyProfileTransitoryCurrentActivity.EndTime property.
            /// </summary>
            /// <param name="value">If you&#39;re still in it but it \&quot;ended\&quot; (like when folks are dancing around the loot after they beat a boss), this is when the activity ended.</param>
            public DestinyComponentsProfilesDestinyProfileTransitoryCurrentActivityBuilder EndTime(DateTime? value)
            {
                _EndTime = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsProfilesDestinyProfileTransitoryCurrentActivity.Score property.
            /// </summary>
            /// <param name="value">This is what our non-authoritative source thought the score was.</param>
            public DestinyComponentsProfilesDestinyProfileTransitoryCurrentActivityBuilder Score(float? value)
            {
                _Score = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsProfilesDestinyProfileTransitoryCurrentActivity.HighestOpposingFactionScore property.
            /// </summary>
            /// <param name="value">If you have human opponents, this is the highest opposing team&#39;s score.</param>
            public DestinyComponentsProfilesDestinyProfileTransitoryCurrentActivityBuilder HighestOpposingFactionScore(float? value)
            {
                _HighestOpposingFactionScore = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsProfilesDestinyProfileTransitoryCurrentActivity.NumberOfOpponents property.
            /// </summary>
            /// <param name="value">This is how many human or poorly crafted aimbot opponents you have.</param>
            public DestinyComponentsProfilesDestinyProfileTransitoryCurrentActivityBuilder NumberOfOpponents(int? value)
            {
                _NumberOfOpponents = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyComponentsProfilesDestinyProfileTransitoryCurrentActivity.NumberOfPlayers property.
            /// </summary>
            /// <param name="value">This is how many human or poorly crafted aimbots are on your team.</param>
            public DestinyComponentsProfilesDestinyProfileTransitoryCurrentActivityBuilder NumberOfPlayers(int? value)
            {
                _NumberOfPlayers = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyComponentsProfilesDestinyProfileTransitoryCurrentActivity.
            /// </summary>
            /// <returns>DestinyComponentsProfilesDestinyProfileTransitoryCurrentActivity</returns>
            public DestinyComponentsProfilesDestinyProfileTransitoryCurrentActivity Build()
            {
                Validate();
                return new DestinyComponentsProfilesDestinyProfileTransitoryCurrentActivity(
                    StartTime: _StartTime,
                    EndTime: _EndTime,
                    Score: _Score,
                    HighestOpposingFactionScore: _HighestOpposingFactionScore,
                    NumberOfOpponents: _NumberOfOpponents,
                    NumberOfPlayers: _NumberOfPlayers
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}