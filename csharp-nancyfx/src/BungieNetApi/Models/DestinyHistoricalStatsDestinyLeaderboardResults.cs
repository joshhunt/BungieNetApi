using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyHistoricalStatsDestinyLeaderboardResults
    /// </summary>
    public sealed class DestinyHistoricalStatsDestinyLeaderboardResults: Dictionary<String, Dictionary>,  IEquatable<DestinyHistoricalStatsDestinyLeaderboardResults>
    { 
        /// <summary>
        /// Indicate the membership ID of the account that is the focal point of the provided leaderboards.
        /// </summary>
        public long? FocusMembershipId { get; private set; }

        /// <summary>
        /// Indicate the character ID of the character that is the focal point of the provided leaderboards. May be null, in which case any character from the focus membership can appear in the provided leaderboards.
        /// </summary>
        public long? FocusCharacterId { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyHistoricalStatsDestinyLeaderboardResults.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyHistoricalStatsDestinyLeaderboardResults() : base()
        {
        }

        private DestinyHistoricalStatsDestinyLeaderboardResults(long? FocusMembershipId, long? FocusCharacterId) : base()
        {
            
            this.FocusMembershipId = FocusMembershipId;
            
            this.FocusCharacterId = FocusCharacterId;
            
        }

        /// <summary>
        /// Returns builder of DestinyHistoricalStatsDestinyLeaderboardResults.
        /// </summary>
        /// <returns>DestinyHistoricalStatsDestinyLeaderboardResultsBuilder</returns>
        public static new DestinyHistoricalStatsDestinyLeaderboardResultsBuilder Builder()
        {
            return new DestinyHistoricalStatsDestinyLeaderboardResultsBuilder();
        }

        /// <summary>
        /// Returns DestinyHistoricalStatsDestinyLeaderboardResultsBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyHistoricalStatsDestinyLeaderboardResultsBuilder</returns>
        public new DestinyHistoricalStatsDestinyLeaderboardResultsBuilder With()
        {
            return Builder()
                .FocusMembershipId(FocusMembershipId)
                .FocusCharacterId(FocusCharacterId);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyHistoricalStatsDestinyLeaderboardResults other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyHistoricalStatsDestinyLeaderboardResults.
        /// </summary>
        /// <param name="left">Compared (DestinyHistoricalStatsDestinyLeaderboardResults</param>
        /// <param name="right">Compared (DestinyHistoricalStatsDestinyLeaderboardResults</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyHistoricalStatsDestinyLeaderboardResults left, DestinyHistoricalStatsDestinyLeaderboardResults right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyHistoricalStatsDestinyLeaderboardResults.
        /// </summary>
        /// <param name="left">Compared (DestinyHistoricalStatsDestinyLeaderboardResults</param>
        /// <param name="right">Compared (DestinyHistoricalStatsDestinyLeaderboardResults</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyHistoricalStatsDestinyLeaderboardResults left, DestinyHistoricalStatsDestinyLeaderboardResults right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyHistoricalStatsDestinyLeaderboardResults.
        /// </summary>
        public sealed class DestinyHistoricalStatsDestinyLeaderboardResultsBuilder
        {
            private long? _FocusMembershipId;
            private long? _FocusCharacterId;

            internal DestinyHistoricalStatsDestinyLeaderboardResultsBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyLeaderboardResults.FocusMembershipId property.
            /// </summary>
            /// <param name="value">Indicate the membership ID of the account that is the focal point of the provided leaderboards.</param>
            public DestinyHistoricalStatsDestinyLeaderboardResultsBuilder FocusMembershipId(long? value)
            {
                _FocusMembershipId = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyLeaderboardResults.FocusCharacterId property.
            /// </summary>
            /// <param name="value">Indicate the character ID of the character that is the focal point of the provided leaderboards. May be null, in which case any character from the focus membership can appear in the provided leaderboards.</param>
            public DestinyHistoricalStatsDestinyLeaderboardResultsBuilder FocusCharacterId(long? value)
            {
                _FocusCharacterId = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyHistoricalStatsDestinyLeaderboardResults.
            /// </summary>
            /// <returns>DestinyHistoricalStatsDestinyLeaderboardResults</returns>
            public DestinyHistoricalStatsDestinyLeaderboardResults Build()
            {
                Validate();
                return new DestinyHistoricalStatsDestinyLeaderboardResults(
                    FocusMembershipId: _FocusMembershipId,
                    FocusCharacterId: _FocusCharacterId
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}