using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyHistoricalStatsDestinyPostGameCarnageReportEntry
    /// </summary>
    public sealed class DestinyHistoricalStatsDestinyPostGameCarnageReportEntry:  IEquatable<DestinyHistoricalStatsDestinyPostGameCarnageReportEntry>
    { 
        /// <summary>
        /// Standing of the player
        /// </summary>
        public int? Standing { get; private set; }

        /// <summary>
        /// Score of the player if available
        /// </summary>
        public DestinyHistoricalStatsDestinyHistoricalStatsValue Score { get; private set; }

        /// <summary>
        /// Identity details of the player
        /// </summary>
        public DestinyHistoricalStatsDestinyPlayer Player { get; private set; }

        /// <summary>
        /// ID of the player&#39;s character used in the activity.
        /// </summary>
        public long? CharacterId { get; private set; }

        /// <summary>
        /// Collection of stats for the player in this activity.
        /// </summary>
        public Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsValue> Values { get; private set; }

        /// <summary>
        /// Extended data extracted from the activity blob.
        /// </summary>
        public DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedData Extended { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyHistoricalStatsDestinyPostGameCarnageReportEntry.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyHistoricalStatsDestinyPostGameCarnageReportEntry()
        {
        }

        private DestinyHistoricalStatsDestinyPostGameCarnageReportEntry(int? Standing, DestinyHistoricalStatsDestinyHistoricalStatsValue Score, DestinyHistoricalStatsDestinyPlayer Player, long? CharacterId, Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsValue> Values, DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedData Extended)
        {
            
            this.Standing = Standing;
            
            this.Score = Score;
            
            this.Player = Player;
            
            this.CharacterId = CharacterId;
            
            this.Values = Values;
            
            this.Extended = Extended;
            
        }

        /// <summary>
        /// Returns builder of DestinyHistoricalStatsDestinyPostGameCarnageReportEntry.
        /// </summary>
        /// <returns>DestinyHistoricalStatsDestinyPostGameCarnageReportEntryBuilder</returns>
        public static DestinyHistoricalStatsDestinyPostGameCarnageReportEntryBuilder Builder()
        {
            return new DestinyHistoricalStatsDestinyPostGameCarnageReportEntryBuilder();
        }

        /// <summary>
        /// Returns DestinyHistoricalStatsDestinyPostGameCarnageReportEntryBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyHistoricalStatsDestinyPostGameCarnageReportEntryBuilder</returns>
        public DestinyHistoricalStatsDestinyPostGameCarnageReportEntryBuilder With()
        {
            return Builder()
                .Standing(Standing)
                .Score(Score)
                .Player(Player)
                .CharacterId(CharacterId)
                .Values(Values)
                .Extended(Extended);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyHistoricalStatsDestinyPostGameCarnageReportEntry other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyHistoricalStatsDestinyPostGameCarnageReportEntry.
        /// </summary>
        /// <param name="left">Compared (DestinyHistoricalStatsDestinyPostGameCarnageReportEntry</param>
        /// <param name="right">Compared (DestinyHistoricalStatsDestinyPostGameCarnageReportEntry</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyHistoricalStatsDestinyPostGameCarnageReportEntry left, DestinyHistoricalStatsDestinyPostGameCarnageReportEntry right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyHistoricalStatsDestinyPostGameCarnageReportEntry.
        /// </summary>
        /// <param name="left">Compared (DestinyHistoricalStatsDestinyPostGameCarnageReportEntry</param>
        /// <param name="right">Compared (DestinyHistoricalStatsDestinyPostGameCarnageReportEntry</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyHistoricalStatsDestinyPostGameCarnageReportEntry left, DestinyHistoricalStatsDestinyPostGameCarnageReportEntry right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyHistoricalStatsDestinyPostGameCarnageReportEntry.
        /// </summary>
        public sealed class DestinyHistoricalStatsDestinyPostGameCarnageReportEntryBuilder
        {
            private int? _Standing;
            private DestinyHistoricalStatsDestinyHistoricalStatsValue _Score;
            private DestinyHistoricalStatsDestinyPlayer _Player;
            private long? _CharacterId;
            private Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsValue> _Values;
            private DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedData _Extended;

            internal DestinyHistoricalStatsDestinyPostGameCarnageReportEntryBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyPostGameCarnageReportEntry.Standing property.
            /// </summary>
            /// <param name="value">Standing of the player</param>
            public DestinyHistoricalStatsDestinyPostGameCarnageReportEntryBuilder Standing(int? value)
            {
                _Standing = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyPostGameCarnageReportEntry.Score property.
            /// </summary>
            /// <param name="value">Score of the player if available</param>
            public DestinyHistoricalStatsDestinyPostGameCarnageReportEntryBuilder Score(DestinyHistoricalStatsDestinyHistoricalStatsValue value)
            {
                _Score = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyPostGameCarnageReportEntry.Player property.
            /// </summary>
            /// <param name="value">Identity details of the player</param>
            public DestinyHistoricalStatsDestinyPostGameCarnageReportEntryBuilder Player(DestinyHistoricalStatsDestinyPlayer value)
            {
                _Player = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyPostGameCarnageReportEntry.CharacterId property.
            /// </summary>
            /// <param name="value">ID of the player&#39;s character used in the activity.</param>
            public DestinyHistoricalStatsDestinyPostGameCarnageReportEntryBuilder CharacterId(long? value)
            {
                _CharacterId = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyPostGameCarnageReportEntry.Values property.
            /// </summary>
            /// <param name="value">Collection of stats for the player in this activity.</param>
            public DestinyHistoricalStatsDestinyPostGameCarnageReportEntryBuilder Values(Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsValue> value)
            {
                _Values = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyPostGameCarnageReportEntry.Extended property.
            /// </summary>
            /// <param name="value">Extended data extracted from the activity blob.</param>
            public DestinyHistoricalStatsDestinyPostGameCarnageReportEntryBuilder Extended(DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedData value)
            {
                _Extended = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyHistoricalStatsDestinyPostGameCarnageReportEntry.
            /// </summary>
            /// <returns>DestinyHistoricalStatsDestinyPostGameCarnageReportEntry</returns>
            public DestinyHistoricalStatsDestinyPostGameCarnageReportEntry Build()
            {
                Validate();
                return new DestinyHistoricalStatsDestinyPostGameCarnageReportEntry(
                    Standing: _Standing,
                    Score: _Score,
                    Player: _Player,
                    CharacterId: _CharacterId,
                    Values: _Values,
                    Extended: _Extended
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}