using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyHistoricalStatsDestinyClanAggregateStat
    /// </summary>
    public sealed class DestinyHistoricalStatsDestinyClanAggregateStat:  IEquatable<DestinyHistoricalStatsDestinyClanAggregateStat>
    { 
        /// <summary>
        /// The id of the mode of stats (allPvp, allPvE, etc)
        /// </summary>
        public int? Mode { get; private set; }

        /// <summary>
        /// The id of the stat
        /// </summary>
        public string StatId { get; private set; }

        /// <summary>
        /// Value of the stat for this player
        /// </summary>
        public DestinyHistoricalStatsDestinyHistoricalStatsValue Value { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyHistoricalStatsDestinyClanAggregateStat.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyHistoricalStatsDestinyClanAggregateStat()
        {
        }

        private DestinyHistoricalStatsDestinyClanAggregateStat(int? Mode, string StatId, DestinyHistoricalStatsDestinyHistoricalStatsValue Value)
        {
            
            this.Mode = Mode;
            
            this.StatId = StatId;
            
            this.Value = Value;
            
        }

        /// <summary>
        /// Returns builder of DestinyHistoricalStatsDestinyClanAggregateStat.
        /// </summary>
        /// <returns>DestinyHistoricalStatsDestinyClanAggregateStatBuilder</returns>
        public static DestinyHistoricalStatsDestinyClanAggregateStatBuilder Builder()
        {
            return new DestinyHistoricalStatsDestinyClanAggregateStatBuilder();
        }

        /// <summary>
        /// Returns DestinyHistoricalStatsDestinyClanAggregateStatBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyHistoricalStatsDestinyClanAggregateStatBuilder</returns>
        public DestinyHistoricalStatsDestinyClanAggregateStatBuilder With()
        {
            return Builder()
                .Mode(Mode)
                .StatId(StatId)
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

        public bool Equals(DestinyHistoricalStatsDestinyClanAggregateStat other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyHistoricalStatsDestinyClanAggregateStat.
        /// </summary>
        /// <param name="left">Compared (DestinyHistoricalStatsDestinyClanAggregateStat</param>
        /// <param name="right">Compared (DestinyHistoricalStatsDestinyClanAggregateStat</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyHistoricalStatsDestinyClanAggregateStat left, DestinyHistoricalStatsDestinyClanAggregateStat right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyHistoricalStatsDestinyClanAggregateStat.
        /// </summary>
        /// <param name="left">Compared (DestinyHistoricalStatsDestinyClanAggregateStat</param>
        /// <param name="right">Compared (DestinyHistoricalStatsDestinyClanAggregateStat</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyHistoricalStatsDestinyClanAggregateStat left, DestinyHistoricalStatsDestinyClanAggregateStat right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyHistoricalStatsDestinyClanAggregateStat.
        /// </summary>
        public sealed class DestinyHistoricalStatsDestinyClanAggregateStatBuilder
        {
            private int? _Mode;
            private string _StatId;
            private DestinyHistoricalStatsDestinyHistoricalStatsValue _Value;

            internal DestinyHistoricalStatsDestinyClanAggregateStatBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyClanAggregateStat.Mode property.
            /// </summary>
            /// <param name="value">The id of the mode of stats (allPvp, allPvE, etc)</param>
            public DestinyHistoricalStatsDestinyClanAggregateStatBuilder Mode(int? value)
            {
                _Mode = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyClanAggregateStat.StatId property.
            /// </summary>
            /// <param name="value">The id of the stat</param>
            public DestinyHistoricalStatsDestinyClanAggregateStatBuilder StatId(string value)
            {
                _StatId = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyClanAggregateStat.Value property.
            /// </summary>
            /// <param name="value">Value of the stat for this player</param>
            public DestinyHistoricalStatsDestinyClanAggregateStatBuilder Value(DestinyHistoricalStatsDestinyHistoricalStatsValue value)
            {
                _Value = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyHistoricalStatsDestinyClanAggregateStat.
            /// </summary>
            /// <returns>DestinyHistoricalStatsDestinyClanAggregateStat</returns>
            public DestinyHistoricalStatsDestinyClanAggregateStat Build()
            {
                Validate();
                return new DestinyHistoricalStatsDestinyClanAggregateStat(
                    Mode: _Mode,
                    StatId: _StatId,
                    Value: _Value
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}