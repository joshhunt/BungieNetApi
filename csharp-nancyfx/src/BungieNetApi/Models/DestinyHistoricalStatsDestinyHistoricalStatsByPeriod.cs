using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyHistoricalStatsDestinyHistoricalStatsByPeriod
    /// </summary>
    public sealed class DestinyHistoricalStatsDestinyHistoricalStatsByPeriod:  IEquatable<DestinyHistoricalStatsDestinyHistoricalStatsByPeriod>
    { 
        /// <summary>
        /// AllTime
        /// </summary>
        public Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsValue> AllTime { get; private set; }

        /// <summary>
        /// AllTimeTier1
        /// </summary>
        public Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsValue> AllTimeTier1 { get; private set; }

        /// <summary>
        /// AllTimeTier2
        /// </summary>
        public Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsValue> AllTimeTier2 { get; private set; }

        /// <summary>
        /// AllTimeTier3
        /// </summary>
        public Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsValue> AllTimeTier3 { get; private set; }

        /// <summary>
        /// Daily
        /// </summary>
        public List<DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup> Daily { get; private set; }

        /// <summary>
        /// Monthly
        /// </summary>
        public List<DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup> Monthly { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyHistoricalStatsDestinyHistoricalStatsByPeriod.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyHistoricalStatsDestinyHistoricalStatsByPeriod()
        {
        }

        private DestinyHistoricalStatsDestinyHistoricalStatsByPeriod(Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsValue> AllTime, Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsValue> AllTimeTier1, Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsValue> AllTimeTier2, Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsValue> AllTimeTier3, List<DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup> Daily, List<DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup> Monthly)
        {
            
            this.AllTime = AllTime;
            
            this.AllTimeTier1 = AllTimeTier1;
            
            this.AllTimeTier2 = AllTimeTier2;
            
            this.AllTimeTier3 = AllTimeTier3;
            
            this.Daily = Daily;
            
            this.Monthly = Monthly;
            
        }

        /// <summary>
        /// Returns builder of DestinyHistoricalStatsDestinyHistoricalStatsByPeriod.
        /// </summary>
        /// <returns>DestinyHistoricalStatsDestinyHistoricalStatsByPeriodBuilder</returns>
        public static DestinyHistoricalStatsDestinyHistoricalStatsByPeriodBuilder Builder()
        {
            return new DestinyHistoricalStatsDestinyHistoricalStatsByPeriodBuilder();
        }

        /// <summary>
        /// Returns DestinyHistoricalStatsDestinyHistoricalStatsByPeriodBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyHistoricalStatsDestinyHistoricalStatsByPeriodBuilder</returns>
        public DestinyHistoricalStatsDestinyHistoricalStatsByPeriodBuilder With()
        {
            return Builder()
                .AllTime(AllTime)
                .AllTimeTier1(AllTimeTier1)
                .AllTimeTier2(AllTimeTier2)
                .AllTimeTier3(AllTimeTier3)
                .Daily(Daily)
                .Monthly(Monthly);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyHistoricalStatsDestinyHistoricalStatsByPeriod other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyHistoricalStatsDestinyHistoricalStatsByPeriod.
        /// </summary>
        /// <param name="left">Compared (DestinyHistoricalStatsDestinyHistoricalStatsByPeriod</param>
        /// <param name="right">Compared (DestinyHistoricalStatsDestinyHistoricalStatsByPeriod</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyHistoricalStatsDestinyHistoricalStatsByPeriod left, DestinyHistoricalStatsDestinyHistoricalStatsByPeriod right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyHistoricalStatsDestinyHistoricalStatsByPeriod.
        /// </summary>
        /// <param name="left">Compared (DestinyHistoricalStatsDestinyHistoricalStatsByPeriod</param>
        /// <param name="right">Compared (DestinyHistoricalStatsDestinyHistoricalStatsByPeriod</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyHistoricalStatsDestinyHistoricalStatsByPeriod left, DestinyHistoricalStatsDestinyHistoricalStatsByPeriod right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyHistoricalStatsDestinyHistoricalStatsByPeriod.
        /// </summary>
        public sealed class DestinyHistoricalStatsDestinyHistoricalStatsByPeriodBuilder
        {
            private Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsValue> _AllTime;
            private Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsValue> _AllTimeTier1;
            private Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsValue> _AllTimeTier2;
            private Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsValue> _AllTimeTier3;
            private List<DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup> _Daily;
            private List<DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup> _Monthly;

            internal DestinyHistoricalStatsDestinyHistoricalStatsByPeriodBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyHistoricalStatsByPeriod.AllTime property.
            /// </summary>
            /// <param name="value">AllTime</param>
            public DestinyHistoricalStatsDestinyHistoricalStatsByPeriodBuilder AllTime(Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsValue> value)
            {
                _AllTime = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyHistoricalStatsByPeriod.AllTimeTier1 property.
            /// </summary>
            /// <param name="value">AllTimeTier1</param>
            public DestinyHistoricalStatsDestinyHistoricalStatsByPeriodBuilder AllTimeTier1(Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsValue> value)
            {
                _AllTimeTier1 = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyHistoricalStatsByPeriod.AllTimeTier2 property.
            /// </summary>
            /// <param name="value">AllTimeTier2</param>
            public DestinyHistoricalStatsDestinyHistoricalStatsByPeriodBuilder AllTimeTier2(Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsValue> value)
            {
                _AllTimeTier2 = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyHistoricalStatsByPeriod.AllTimeTier3 property.
            /// </summary>
            /// <param name="value">AllTimeTier3</param>
            public DestinyHistoricalStatsDestinyHistoricalStatsByPeriodBuilder AllTimeTier3(Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsValue> value)
            {
                _AllTimeTier3 = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyHistoricalStatsByPeriod.Daily property.
            /// </summary>
            /// <param name="value">Daily</param>
            public DestinyHistoricalStatsDestinyHistoricalStatsByPeriodBuilder Daily(List<DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup> value)
            {
                _Daily = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyHistoricalStatsByPeriod.Monthly property.
            /// </summary>
            /// <param name="value">Monthly</param>
            public DestinyHistoricalStatsDestinyHistoricalStatsByPeriodBuilder Monthly(List<DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup> value)
            {
                _Monthly = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyHistoricalStatsDestinyHistoricalStatsByPeriod.
            /// </summary>
            /// <returns>DestinyHistoricalStatsDestinyHistoricalStatsByPeriod</returns>
            public DestinyHistoricalStatsDestinyHistoricalStatsByPeriod Build()
            {
                Validate();
                return new DestinyHistoricalStatsDestinyHistoricalStatsByPeriod(
                    AllTime: _AllTime,
                    AllTimeTier1: _AllTimeTier1,
                    AllTimeTier2: _AllTimeTier2,
                    AllTimeTier3: _AllTimeTier3,
                    Daily: _Daily,
                    Monthly: _Monthly
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}