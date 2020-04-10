using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup
    /// </summary>
    public sealed class DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup:  IEquatable<DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup>
    { 
        /// <summary>
        /// Period for the group. If the stat periodType is day, then this will have a specific day. If the type is monthly, then this value will be the first day of the applicable month. This value is not set when the periodType is &#39;all time&#39;.
        /// </summary>
        public DateTime? Period { get; private set; }

        /// <summary>
        /// If the period group is for a specific activity, this property will be set.
        /// </summary>
        public DestinyHistoricalStatsDestinyHistoricalStatsActivity ActivityDetails { get; private set; }

        /// <summary>
        /// Collection of stats for the period.
        /// </summary>
        public Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsValue> Values { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup()
        {
        }

        private DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup(DateTime? Period, DestinyHistoricalStatsDestinyHistoricalStatsActivity ActivityDetails, Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsValue> Values)
        {
            
            this.Period = Period;
            
            this.ActivityDetails = ActivityDetails;
            
            this.Values = Values;
            
        }

        /// <summary>
        /// Returns builder of DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup.
        /// </summary>
        /// <returns>DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroupBuilder</returns>
        public static DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroupBuilder Builder()
        {
            return new DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroupBuilder();
        }

        /// <summary>
        /// Returns DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroupBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroupBuilder</returns>
        public DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroupBuilder With()
        {
            return Builder()
                .Period(Period)
                .ActivityDetails(ActivityDetails)
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

        public bool Equals(DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup.
        /// </summary>
        /// <param name="left">Compared (DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup</param>
        /// <param name="right">Compared (DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup left, DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup.
        /// </summary>
        /// <param name="left">Compared (DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup</param>
        /// <param name="right">Compared (DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup left, DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup.
        /// </summary>
        public sealed class DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroupBuilder
        {
            private DateTime? _Period;
            private DestinyHistoricalStatsDestinyHistoricalStatsActivity _ActivityDetails;
            private Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsValue> _Values;

            internal DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroupBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup.Period property.
            /// </summary>
            /// <param name="value">Period for the group. If the stat periodType is day, then this will have a specific day. If the type is monthly, then this value will be the first day of the applicable month. This value is not set when the periodType is &#39;all time&#39;.</param>
            public DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroupBuilder Period(DateTime? value)
            {
                _Period = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup.ActivityDetails property.
            /// </summary>
            /// <param name="value">If the period group is for a specific activity, this property will be set.</param>
            public DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroupBuilder ActivityDetails(DestinyHistoricalStatsDestinyHistoricalStatsActivity value)
            {
                _ActivityDetails = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup.Values property.
            /// </summary>
            /// <param name="value">Collection of stats for the period.</param>
            public DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroupBuilder Values(Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsValue> value)
            {
                _Values = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup.
            /// </summary>
            /// <returns>DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup</returns>
            public DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup Build()
            {
                Validate();
                return new DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup(
                    Period: _Period,
                    ActivityDetails: _ActivityDetails,
                    Values: _Values
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}