using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyHistoricalStatsDestinyLeaderboard
    /// </summary>
    public sealed class DestinyHistoricalStatsDestinyLeaderboard:  IEquatable<DestinyHistoricalStatsDestinyLeaderboard>
    { 
        /// <summary>
        /// StatId
        /// </summary>
        public string StatId { get; private set; }

        /// <summary>
        /// Entries
        /// </summary>
        public List<DestinyHistoricalStatsDestinyLeaderboardEntry> Entries { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyHistoricalStatsDestinyLeaderboard.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyHistoricalStatsDestinyLeaderboard()
        {
        }

        private DestinyHistoricalStatsDestinyLeaderboard(string StatId, List<DestinyHistoricalStatsDestinyLeaderboardEntry> Entries)
        {
            
            this.StatId = StatId;
            
            this.Entries = Entries;
            
        }

        /// <summary>
        /// Returns builder of DestinyHistoricalStatsDestinyLeaderboard.
        /// </summary>
        /// <returns>DestinyHistoricalStatsDestinyLeaderboardBuilder</returns>
        public static DestinyHistoricalStatsDestinyLeaderboardBuilder Builder()
        {
            return new DestinyHistoricalStatsDestinyLeaderboardBuilder();
        }

        /// <summary>
        /// Returns DestinyHistoricalStatsDestinyLeaderboardBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyHistoricalStatsDestinyLeaderboardBuilder</returns>
        public DestinyHistoricalStatsDestinyLeaderboardBuilder With()
        {
            return Builder()
                .StatId(StatId)
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

        public bool Equals(DestinyHistoricalStatsDestinyLeaderboard other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyHistoricalStatsDestinyLeaderboard.
        /// </summary>
        /// <param name="left">Compared (DestinyHistoricalStatsDestinyLeaderboard</param>
        /// <param name="right">Compared (DestinyHistoricalStatsDestinyLeaderboard</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyHistoricalStatsDestinyLeaderboard left, DestinyHistoricalStatsDestinyLeaderboard right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyHistoricalStatsDestinyLeaderboard.
        /// </summary>
        /// <param name="left">Compared (DestinyHistoricalStatsDestinyLeaderboard</param>
        /// <param name="right">Compared (DestinyHistoricalStatsDestinyLeaderboard</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyHistoricalStatsDestinyLeaderboard left, DestinyHistoricalStatsDestinyLeaderboard right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyHistoricalStatsDestinyLeaderboard.
        /// </summary>
        public sealed class DestinyHistoricalStatsDestinyLeaderboardBuilder
        {
            private string _StatId;
            private List<DestinyHistoricalStatsDestinyLeaderboardEntry> _Entries;

            internal DestinyHistoricalStatsDestinyLeaderboardBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyLeaderboard.StatId property.
            /// </summary>
            /// <param name="value">StatId</param>
            public DestinyHistoricalStatsDestinyLeaderboardBuilder StatId(string value)
            {
                _StatId = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyLeaderboard.Entries property.
            /// </summary>
            /// <param name="value">Entries</param>
            public DestinyHistoricalStatsDestinyLeaderboardBuilder Entries(List<DestinyHistoricalStatsDestinyLeaderboardEntry> value)
            {
                _Entries = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyHistoricalStatsDestinyLeaderboard.
            /// </summary>
            /// <returns>DestinyHistoricalStatsDestinyLeaderboard</returns>
            public DestinyHistoricalStatsDestinyLeaderboard Build()
            {
                Validate();
                return new DestinyHistoricalStatsDestinyLeaderboard(
                    StatId: _StatId,
                    Entries: _Entries
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}