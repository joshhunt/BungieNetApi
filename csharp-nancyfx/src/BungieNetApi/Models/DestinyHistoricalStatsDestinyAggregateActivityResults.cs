using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyHistoricalStatsDestinyAggregateActivityResults
    /// </summary>
    public sealed class DestinyHistoricalStatsDestinyAggregateActivityResults:  IEquatable<DestinyHistoricalStatsDestinyAggregateActivityResults>
    { 
        /// <summary>
        /// List of all activities the player has participated in.
        /// </summary>
        public List<DestinyHistoricalStatsDestinyAggregateActivityStats> Activities { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyHistoricalStatsDestinyAggregateActivityResults.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyHistoricalStatsDestinyAggregateActivityResults()
        {
        }

        private DestinyHistoricalStatsDestinyAggregateActivityResults(List<DestinyHistoricalStatsDestinyAggregateActivityStats> Activities)
        {
            
            this.Activities = Activities;
            
        }

        /// <summary>
        /// Returns builder of DestinyHistoricalStatsDestinyAggregateActivityResults.
        /// </summary>
        /// <returns>DestinyHistoricalStatsDestinyAggregateActivityResultsBuilder</returns>
        public static DestinyHistoricalStatsDestinyAggregateActivityResultsBuilder Builder()
        {
            return new DestinyHistoricalStatsDestinyAggregateActivityResultsBuilder();
        }

        /// <summary>
        /// Returns DestinyHistoricalStatsDestinyAggregateActivityResultsBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyHistoricalStatsDestinyAggregateActivityResultsBuilder</returns>
        public DestinyHistoricalStatsDestinyAggregateActivityResultsBuilder With()
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

        public bool Equals(DestinyHistoricalStatsDestinyAggregateActivityResults other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyHistoricalStatsDestinyAggregateActivityResults.
        /// </summary>
        /// <param name="left">Compared (DestinyHistoricalStatsDestinyAggregateActivityResults</param>
        /// <param name="right">Compared (DestinyHistoricalStatsDestinyAggregateActivityResults</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyHistoricalStatsDestinyAggregateActivityResults left, DestinyHistoricalStatsDestinyAggregateActivityResults right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyHistoricalStatsDestinyAggregateActivityResults.
        /// </summary>
        /// <param name="left">Compared (DestinyHistoricalStatsDestinyAggregateActivityResults</param>
        /// <param name="right">Compared (DestinyHistoricalStatsDestinyAggregateActivityResults</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyHistoricalStatsDestinyAggregateActivityResults left, DestinyHistoricalStatsDestinyAggregateActivityResults right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyHistoricalStatsDestinyAggregateActivityResults.
        /// </summary>
        public sealed class DestinyHistoricalStatsDestinyAggregateActivityResultsBuilder
        {
            private List<DestinyHistoricalStatsDestinyAggregateActivityStats> _Activities;

            internal DestinyHistoricalStatsDestinyAggregateActivityResultsBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyAggregateActivityResults.Activities property.
            /// </summary>
            /// <param name="value">List of all activities the player has participated in.</param>
            public DestinyHistoricalStatsDestinyAggregateActivityResultsBuilder Activities(List<DestinyHistoricalStatsDestinyAggregateActivityStats> value)
            {
                _Activities = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyHistoricalStatsDestinyAggregateActivityResults.
            /// </summary>
            /// <returns>DestinyHistoricalStatsDestinyAggregateActivityResults</returns>
            public DestinyHistoricalStatsDestinyAggregateActivityResults Build()
            {
                Validate();
                return new DestinyHistoricalStatsDestinyAggregateActivityResults(
                    Activities: _Activities
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}