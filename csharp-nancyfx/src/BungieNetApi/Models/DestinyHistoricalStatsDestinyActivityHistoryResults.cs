using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyHistoricalStatsDestinyActivityHistoryResults
    /// </summary>
    public sealed class DestinyHistoricalStatsDestinyActivityHistoryResults:  IEquatable<DestinyHistoricalStatsDestinyActivityHistoryResults>
    { 
        /// <summary>
        /// List of activities, the most recent activity first.
        /// </summary>
        public List<DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup> Activities { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyHistoricalStatsDestinyActivityHistoryResults.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyHistoricalStatsDestinyActivityHistoryResults()
        {
        }

        private DestinyHistoricalStatsDestinyActivityHistoryResults(List<DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup> Activities)
        {
            
            this.Activities = Activities;
            
        }

        /// <summary>
        /// Returns builder of DestinyHistoricalStatsDestinyActivityHistoryResults.
        /// </summary>
        /// <returns>DestinyHistoricalStatsDestinyActivityHistoryResultsBuilder</returns>
        public static DestinyHistoricalStatsDestinyActivityHistoryResultsBuilder Builder()
        {
            return new DestinyHistoricalStatsDestinyActivityHistoryResultsBuilder();
        }

        /// <summary>
        /// Returns DestinyHistoricalStatsDestinyActivityHistoryResultsBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyHistoricalStatsDestinyActivityHistoryResultsBuilder</returns>
        public DestinyHistoricalStatsDestinyActivityHistoryResultsBuilder With()
        {
            return Builder()
                .Activities(Activities);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyHistoricalStatsDestinyActivityHistoryResults other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyHistoricalStatsDestinyActivityHistoryResults.
        /// </summary>
        /// <param name="left">Compared (DestinyHistoricalStatsDestinyActivityHistoryResults</param>
        /// <param name="right">Compared (DestinyHistoricalStatsDestinyActivityHistoryResults</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyHistoricalStatsDestinyActivityHistoryResults left, DestinyHistoricalStatsDestinyActivityHistoryResults right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyHistoricalStatsDestinyActivityHistoryResults.
        /// </summary>
        /// <param name="left">Compared (DestinyHistoricalStatsDestinyActivityHistoryResults</param>
        /// <param name="right">Compared (DestinyHistoricalStatsDestinyActivityHistoryResults</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyHistoricalStatsDestinyActivityHistoryResults left, DestinyHistoricalStatsDestinyActivityHistoryResults right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyHistoricalStatsDestinyActivityHistoryResults.
        /// </summary>
        public sealed class DestinyHistoricalStatsDestinyActivityHistoryResultsBuilder
        {
            private List<DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup> _Activities;

            internal DestinyHistoricalStatsDestinyActivityHistoryResultsBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyActivityHistoryResults.Activities property.
            /// </summary>
            /// <param name="value">List of activities, the most recent activity first.</param>
            public DestinyHistoricalStatsDestinyActivityHistoryResultsBuilder Activities(List<DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup> value)
            {
                _Activities = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyHistoricalStatsDestinyActivityHistoryResults.
            /// </summary>
            /// <returns>DestinyHistoricalStatsDestinyActivityHistoryResults</returns>
            public DestinyHistoricalStatsDestinyActivityHistoryResults Build()
            {
                Validate();
                return new DestinyHistoricalStatsDestinyActivityHistoryResults(
                    Activities: _Activities
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}