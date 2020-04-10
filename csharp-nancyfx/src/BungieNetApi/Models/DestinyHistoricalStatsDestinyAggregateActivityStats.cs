using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyHistoricalStatsDestinyAggregateActivityStats
    /// </summary>
    public sealed class DestinyHistoricalStatsDestinyAggregateActivityStats:  IEquatable<DestinyHistoricalStatsDestinyAggregateActivityStats>
    { 
        /// <summary>
        /// Hash ID that can be looked up in the DestinyActivityTable.
        /// </summary>
        public int? ActivityHash { get; private set; }

        /// <summary>
        /// Collection of stats for the player in this activity.
        /// </summary>
        public Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsValue> Values { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyHistoricalStatsDestinyAggregateActivityStats.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyHistoricalStatsDestinyAggregateActivityStats()
        {
        }

        private DestinyHistoricalStatsDestinyAggregateActivityStats(int? ActivityHash, Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsValue> Values)
        {
            
            this.ActivityHash = ActivityHash;
            
            this.Values = Values;
            
        }

        /// <summary>
        /// Returns builder of DestinyHistoricalStatsDestinyAggregateActivityStats.
        /// </summary>
        /// <returns>DestinyHistoricalStatsDestinyAggregateActivityStatsBuilder</returns>
        public static DestinyHistoricalStatsDestinyAggregateActivityStatsBuilder Builder()
        {
            return new DestinyHistoricalStatsDestinyAggregateActivityStatsBuilder();
        }

        /// <summary>
        /// Returns DestinyHistoricalStatsDestinyAggregateActivityStatsBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyHistoricalStatsDestinyAggregateActivityStatsBuilder</returns>
        public DestinyHistoricalStatsDestinyAggregateActivityStatsBuilder With()
        {
            return Builder()
                .ActivityHash(ActivityHash)
                .Values(Values);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyHistoricalStatsDestinyAggregateActivityStats other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyHistoricalStatsDestinyAggregateActivityStats.
        /// </summary>
        /// <param name="left">Compared (DestinyHistoricalStatsDestinyAggregateActivityStats</param>
        /// <param name="right">Compared (DestinyHistoricalStatsDestinyAggregateActivityStats</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyHistoricalStatsDestinyAggregateActivityStats left, DestinyHistoricalStatsDestinyAggregateActivityStats right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyHistoricalStatsDestinyAggregateActivityStats.
        /// </summary>
        /// <param name="left">Compared (DestinyHistoricalStatsDestinyAggregateActivityStats</param>
        /// <param name="right">Compared (DestinyHistoricalStatsDestinyAggregateActivityStats</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyHistoricalStatsDestinyAggregateActivityStats left, DestinyHistoricalStatsDestinyAggregateActivityStats right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyHistoricalStatsDestinyAggregateActivityStats.
        /// </summary>
        public sealed class DestinyHistoricalStatsDestinyAggregateActivityStatsBuilder
        {
            private int? _ActivityHash;
            private Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsValue> _Values;

            internal DestinyHistoricalStatsDestinyAggregateActivityStatsBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyAggregateActivityStats.ActivityHash property.
            /// </summary>
            /// <param name="value">Hash ID that can be looked up in the DestinyActivityTable.</param>
            public DestinyHistoricalStatsDestinyAggregateActivityStatsBuilder ActivityHash(int? value)
            {
                _ActivityHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyAggregateActivityStats.Values property.
            /// </summary>
            /// <param name="value">Collection of stats for the player in this activity.</param>
            public DestinyHistoricalStatsDestinyAggregateActivityStatsBuilder Values(Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsValue> value)
            {
                _Values = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyHistoricalStatsDestinyAggregateActivityStats.
            /// </summary>
            /// <returns>DestinyHistoricalStatsDestinyAggregateActivityStats</returns>
            public DestinyHistoricalStatsDestinyAggregateActivityStats Build()
            {
                Validate();
                return new DestinyHistoricalStatsDestinyAggregateActivityStats(
                    ActivityHash: _ActivityHash,
                    Values: _Values
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}