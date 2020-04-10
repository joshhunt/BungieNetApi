using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyHistoricalStatsDestinyLeaderboardEntry
    /// </summary>
    public sealed class DestinyHistoricalStatsDestinyLeaderboardEntry:  IEquatable<DestinyHistoricalStatsDestinyLeaderboardEntry>
    { 
        /// <summary>
        /// Where this player ranks on the leaderboard. A value of 1 is the top rank.
        /// </summary>
        public int? Rank { get; private set; }

        /// <summary>
        /// Identity details of the player
        /// </summary>
        public DestinyHistoricalStatsDestinyPlayer Player { get; private set; }

        /// <summary>
        /// ID of the player&#39;s best character for the reported stat.
        /// </summary>
        public long? CharacterId { get; private set; }

        /// <summary>
        /// Value of the stat for this player
        /// </summary>
        public DestinyHistoricalStatsDestinyHistoricalStatsValue Value { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyHistoricalStatsDestinyLeaderboardEntry.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyHistoricalStatsDestinyLeaderboardEntry()
        {
        }

        private DestinyHistoricalStatsDestinyLeaderboardEntry(int? Rank, DestinyHistoricalStatsDestinyPlayer Player, long? CharacterId, DestinyHistoricalStatsDestinyHistoricalStatsValue Value)
        {
            
            this.Rank = Rank;
            
            this.Player = Player;
            
            this.CharacterId = CharacterId;
            
            this.Value = Value;
            
        }

        /// <summary>
        /// Returns builder of DestinyHistoricalStatsDestinyLeaderboardEntry.
        /// </summary>
        /// <returns>DestinyHistoricalStatsDestinyLeaderboardEntryBuilder</returns>
        public static DestinyHistoricalStatsDestinyLeaderboardEntryBuilder Builder()
        {
            return new DestinyHistoricalStatsDestinyLeaderboardEntryBuilder();
        }

        /// <summary>
        /// Returns DestinyHistoricalStatsDestinyLeaderboardEntryBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyHistoricalStatsDestinyLeaderboardEntryBuilder</returns>
        public DestinyHistoricalStatsDestinyLeaderboardEntryBuilder With()
        {
            return Builder()
                .Rank(Rank)
                .Player(Player)
                .CharacterId(CharacterId)
                .Value(Value);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyHistoricalStatsDestinyLeaderboardEntry other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyHistoricalStatsDestinyLeaderboardEntry.
        /// </summary>
        /// <param name="left">Compared (DestinyHistoricalStatsDestinyLeaderboardEntry</param>
        /// <param name="right">Compared (DestinyHistoricalStatsDestinyLeaderboardEntry</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyHistoricalStatsDestinyLeaderboardEntry left, DestinyHistoricalStatsDestinyLeaderboardEntry right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyHistoricalStatsDestinyLeaderboardEntry.
        /// </summary>
        /// <param name="left">Compared (DestinyHistoricalStatsDestinyLeaderboardEntry</param>
        /// <param name="right">Compared (DestinyHistoricalStatsDestinyLeaderboardEntry</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyHistoricalStatsDestinyLeaderboardEntry left, DestinyHistoricalStatsDestinyLeaderboardEntry right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyHistoricalStatsDestinyLeaderboardEntry.
        /// </summary>
        public sealed class DestinyHistoricalStatsDestinyLeaderboardEntryBuilder
        {
            private int? _Rank;
            private DestinyHistoricalStatsDestinyPlayer _Player;
            private long? _CharacterId;
            private DestinyHistoricalStatsDestinyHistoricalStatsValue _Value;

            internal DestinyHistoricalStatsDestinyLeaderboardEntryBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyLeaderboardEntry.Rank property.
            /// </summary>
            /// <param name="value">Where this player ranks on the leaderboard. A value of 1 is the top rank.</param>
            public DestinyHistoricalStatsDestinyLeaderboardEntryBuilder Rank(int? value)
            {
                _Rank = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyLeaderboardEntry.Player property.
            /// </summary>
            /// <param name="value">Identity details of the player</param>
            public DestinyHistoricalStatsDestinyLeaderboardEntryBuilder Player(DestinyHistoricalStatsDestinyPlayer value)
            {
                _Player = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyLeaderboardEntry.CharacterId property.
            /// </summary>
            /// <param name="value">ID of the player&#39;s best character for the reported stat.</param>
            public DestinyHistoricalStatsDestinyLeaderboardEntryBuilder CharacterId(long? value)
            {
                _CharacterId = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyLeaderboardEntry.Value property.
            /// </summary>
            /// <param name="value">Value of the stat for this player</param>
            public DestinyHistoricalStatsDestinyLeaderboardEntryBuilder Value(DestinyHistoricalStatsDestinyHistoricalStatsValue value)
            {
                _Value = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyHistoricalStatsDestinyLeaderboardEntry.
            /// </summary>
            /// <returns>DestinyHistoricalStatsDestinyLeaderboardEntry</returns>
            public DestinyHistoricalStatsDestinyLeaderboardEntry Build()
            {
                Validate();
                return new DestinyHistoricalStatsDestinyLeaderboardEntry(
                    Rank: _Rank,
                    Player: _Player,
                    CharacterId: _CharacterId,
                    Value: _Value
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}