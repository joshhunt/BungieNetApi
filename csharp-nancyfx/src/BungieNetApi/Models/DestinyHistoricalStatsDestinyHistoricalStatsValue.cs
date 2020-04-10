using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyHistoricalStatsDestinyHistoricalStatsValue
    /// </summary>
    public sealed class DestinyHistoricalStatsDestinyHistoricalStatsValue:  IEquatable<DestinyHistoricalStatsDestinyHistoricalStatsValue>
    { 
        /// <summary>
        /// Unique ID for this stat
        /// </summary>
        public string StatId { get; private set; }

        /// <summary>
        /// Basic stat value.
        /// </summary>
        public DestinyHistoricalStatsDestinyHistoricalStatsValuePair Basic { get; private set; }

        /// <summary>
        /// Per game average for the statistic, if applicable
        /// </summary>
        public DestinyHistoricalStatsDestinyHistoricalStatsValuePair Pga { get; private set; }

        /// <summary>
        /// Weighted value of the stat if a weight greater than 1 has been assigned.
        /// </summary>
        public DestinyHistoricalStatsDestinyHistoricalStatsValuePair Weighted { get; private set; }

        /// <summary>
        /// When a stat represents the best, most, longest, fastest or some other personal best, the actual activity ID where that personal best was established is available on this property.
        /// </summary>
        public long? ActivityId { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyHistoricalStatsDestinyHistoricalStatsValue.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyHistoricalStatsDestinyHistoricalStatsValue()
        {
        }

        private DestinyHistoricalStatsDestinyHistoricalStatsValue(string StatId, DestinyHistoricalStatsDestinyHistoricalStatsValuePair Basic, DestinyHistoricalStatsDestinyHistoricalStatsValuePair Pga, DestinyHistoricalStatsDestinyHistoricalStatsValuePair Weighted, long? ActivityId)
        {
            
            this.StatId = StatId;
            
            this.Basic = Basic;
            
            this.Pga = Pga;
            
            this.Weighted = Weighted;
            
            this.ActivityId = ActivityId;
            
        }

        /// <summary>
        /// Returns builder of DestinyHistoricalStatsDestinyHistoricalStatsValue.
        /// </summary>
        /// <returns>DestinyHistoricalStatsDestinyHistoricalStatsValueBuilder</returns>
        public static DestinyHistoricalStatsDestinyHistoricalStatsValueBuilder Builder()
        {
            return new DestinyHistoricalStatsDestinyHistoricalStatsValueBuilder();
        }

        /// <summary>
        /// Returns DestinyHistoricalStatsDestinyHistoricalStatsValueBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyHistoricalStatsDestinyHistoricalStatsValueBuilder</returns>
        public DestinyHistoricalStatsDestinyHistoricalStatsValueBuilder With()
        {
            return Builder()
                .StatId(StatId)
                .Basic(Basic)
                .Pga(Pga)
                .Weighted(Weighted)
                .ActivityId(ActivityId);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyHistoricalStatsDestinyHistoricalStatsValue other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyHistoricalStatsDestinyHistoricalStatsValue.
        /// </summary>
        /// <param name="left">Compared (DestinyHistoricalStatsDestinyHistoricalStatsValue</param>
        /// <param name="right">Compared (DestinyHistoricalStatsDestinyHistoricalStatsValue</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyHistoricalStatsDestinyHistoricalStatsValue left, DestinyHistoricalStatsDestinyHistoricalStatsValue right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyHistoricalStatsDestinyHistoricalStatsValue.
        /// </summary>
        /// <param name="left">Compared (DestinyHistoricalStatsDestinyHistoricalStatsValue</param>
        /// <param name="right">Compared (DestinyHistoricalStatsDestinyHistoricalStatsValue</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyHistoricalStatsDestinyHistoricalStatsValue left, DestinyHistoricalStatsDestinyHistoricalStatsValue right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyHistoricalStatsDestinyHistoricalStatsValue.
        /// </summary>
        public sealed class DestinyHistoricalStatsDestinyHistoricalStatsValueBuilder
        {
            private string _StatId;
            private DestinyHistoricalStatsDestinyHistoricalStatsValuePair _Basic;
            private DestinyHistoricalStatsDestinyHistoricalStatsValuePair _Pga;
            private DestinyHistoricalStatsDestinyHistoricalStatsValuePair _Weighted;
            private long? _ActivityId;

            internal DestinyHistoricalStatsDestinyHistoricalStatsValueBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyHistoricalStatsValue.StatId property.
            /// </summary>
            /// <param name="value">Unique ID for this stat</param>
            public DestinyHistoricalStatsDestinyHistoricalStatsValueBuilder StatId(string value)
            {
                _StatId = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyHistoricalStatsValue.Basic property.
            /// </summary>
            /// <param name="value">Basic stat value.</param>
            public DestinyHistoricalStatsDestinyHistoricalStatsValueBuilder Basic(DestinyHistoricalStatsDestinyHistoricalStatsValuePair value)
            {
                _Basic = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyHistoricalStatsValue.Pga property.
            /// </summary>
            /// <param name="value">Per game average for the statistic, if applicable</param>
            public DestinyHistoricalStatsDestinyHistoricalStatsValueBuilder Pga(DestinyHistoricalStatsDestinyHistoricalStatsValuePair value)
            {
                _Pga = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyHistoricalStatsValue.Weighted property.
            /// </summary>
            /// <param name="value">Weighted value of the stat if a weight greater than 1 has been assigned.</param>
            public DestinyHistoricalStatsDestinyHistoricalStatsValueBuilder Weighted(DestinyHistoricalStatsDestinyHistoricalStatsValuePair value)
            {
                _Weighted = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyHistoricalStatsValue.ActivityId property.
            /// </summary>
            /// <param name="value">When a stat represents the best, most, longest, fastest or some other personal best, the actual activity ID where that personal best was established is available on this property.</param>
            public DestinyHistoricalStatsDestinyHistoricalStatsValueBuilder ActivityId(long? value)
            {
                _ActivityId = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyHistoricalStatsDestinyHistoricalStatsValue.
            /// </summary>
            /// <returns>DestinyHistoricalStatsDestinyHistoricalStatsValue</returns>
            public DestinyHistoricalStatsDestinyHistoricalStatsValue Build()
            {
                Validate();
                return new DestinyHistoricalStatsDestinyHistoricalStatsValue(
                    StatId: _StatId,
                    Basic: _Basic,
                    Pga: _Pga,
                    Weighted: _Weighted,
                    ActivityId: _ActivityId
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}