using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyHistoricalStatsDestinyHistoricalStatsWithMerged
    /// </summary>
    public sealed class DestinyHistoricalStatsDestinyHistoricalStatsWithMerged:  IEquatable<DestinyHistoricalStatsDestinyHistoricalStatsWithMerged>
    { 
        /// <summary>
        /// Results
        /// </summary>
        public Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsByPeriod> Results { get; private set; }

        /// <summary>
        /// Merged
        /// </summary>
        public DestinyHistoricalStatsDestinyHistoricalStatsByPeriod Merged { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyHistoricalStatsDestinyHistoricalStatsWithMerged.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyHistoricalStatsDestinyHistoricalStatsWithMerged()
        {
        }

        private DestinyHistoricalStatsDestinyHistoricalStatsWithMerged(Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsByPeriod> Results, DestinyHistoricalStatsDestinyHistoricalStatsByPeriod Merged)
        {
            
            this.Results = Results;
            
            this.Merged = Merged;
            
        }

        /// <summary>
        /// Returns builder of DestinyHistoricalStatsDestinyHistoricalStatsWithMerged.
        /// </summary>
        /// <returns>DestinyHistoricalStatsDestinyHistoricalStatsWithMergedBuilder</returns>
        public static DestinyHistoricalStatsDestinyHistoricalStatsWithMergedBuilder Builder()
        {
            return new DestinyHistoricalStatsDestinyHistoricalStatsWithMergedBuilder();
        }

        /// <summary>
        /// Returns DestinyHistoricalStatsDestinyHistoricalStatsWithMergedBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyHistoricalStatsDestinyHistoricalStatsWithMergedBuilder</returns>
        public DestinyHistoricalStatsDestinyHistoricalStatsWithMergedBuilder With()
        {
            return Builder()
                .Results(Results)
                .Merged(Merged);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyHistoricalStatsDestinyHistoricalStatsWithMerged other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyHistoricalStatsDestinyHistoricalStatsWithMerged.
        /// </summary>
        /// <param name="left">Compared (DestinyHistoricalStatsDestinyHistoricalStatsWithMerged</param>
        /// <param name="right">Compared (DestinyHistoricalStatsDestinyHistoricalStatsWithMerged</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyHistoricalStatsDestinyHistoricalStatsWithMerged left, DestinyHistoricalStatsDestinyHistoricalStatsWithMerged right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyHistoricalStatsDestinyHistoricalStatsWithMerged.
        /// </summary>
        /// <param name="left">Compared (DestinyHistoricalStatsDestinyHistoricalStatsWithMerged</param>
        /// <param name="right">Compared (DestinyHistoricalStatsDestinyHistoricalStatsWithMerged</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyHistoricalStatsDestinyHistoricalStatsWithMerged left, DestinyHistoricalStatsDestinyHistoricalStatsWithMerged right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyHistoricalStatsDestinyHistoricalStatsWithMerged.
        /// </summary>
        public sealed class DestinyHistoricalStatsDestinyHistoricalStatsWithMergedBuilder
        {
            private Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsByPeriod> _Results;
            private DestinyHistoricalStatsDestinyHistoricalStatsByPeriod _Merged;

            internal DestinyHistoricalStatsDestinyHistoricalStatsWithMergedBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyHistoricalStatsWithMerged.Results property.
            /// </summary>
            /// <param name="value">Results</param>
            public DestinyHistoricalStatsDestinyHistoricalStatsWithMergedBuilder Results(Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsByPeriod> value)
            {
                _Results = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyHistoricalStatsWithMerged.Merged property.
            /// </summary>
            /// <param name="value">Merged</param>
            public DestinyHistoricalStatsDestinyHistoricalStatsWithMergedBuilder Merged(DestinyHistoricalStatsDestinyHistoricalStatsByPeriod value)
            {
                _Merged = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyHistoricalStatsDestinyHistoricalStatsWithMerged.
            /// </summary>
            /// <returns>DestinyHistoricalStatsDestinyHistoricalStatsWithMerged</returns>
            public DestinyHistoricalStatsDestinyHistoricalStatsWithMerged Build()
            {
                Validate();
                return new DestinyHistoricalStatsDestinyHistoricalStatsWithMerged(
                    Results: _Results,
                    Merged: _Merged
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}