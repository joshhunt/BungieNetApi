using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyHistoricalStatsDestinyHistoricalStatsValuePair
    /// </summary>
    public sealed class DestinyHistoricalStatsDestinyHistoricalStatsValuePair:  IEquatable<DestinyHistoricalStatsDestinyHistoricalStatsValuePair>
    { 
        /// <summary>
        /// Raw value of the statistic
        /// </summary>
        public double? Value { get; private set; }

        /// <summary>
        /// Localized formated version of the value.
        /// </summary>
        public string DisplayValue { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyHistoricalStatsDestinyHistoricalStatsValuePair.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyHistoricalStatsDestinyHistoricalStatsValuePair()
        {
        }

        private DestinyHistoricalStatsDestinyHistoricalStatsValuePair(double? Value, string DisplayValue)
        {
            
            this.Value = Value;
            
            this.DisplayValue = DisplayValue;
            
        }

        /// <summary>
        /// Returns builder of DestinyHistoricalStatsDestinyHistoricalStatsValuePair.
        /// </summary>
        /// <returns>DestinyHistoricalStatsDestinyHistoricalStatsValuePairBuilder</returns>
        public static DestinyHistoricalStatsDestinyHistoricalStatsValuePairBuilder Builder()
        {
            return new DestinyHistoricalStatsDestinyHistoricalStatsValuePairBuilder();
        }

        /// <summary>
        /// Returns DestinyHistoricalStatsDestinyHistoricalStatsValuePairBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyHistoricalStatsDestinyHistoricalStatsValuePairBuilder</returns>
        public DestinyHistoricalStatsDestinyHistoricalStatsValuePairBuilder With()
        {
            return Builder()
                .Value(Value)
                .DisplayValue(DisplayValue);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyHistoricalStatsDestinyHistoricalStatsValuePair other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyHistoricalStatsDestinyHistoricalStatsValuePair.
        /// </summary>
        /// <param name="left">Compared (DestinyHistoricalStatsDestinyHistoricalStatsValuePair</param>
        /// <param name="right">Compared (DestinyHistoricalStatsDestinyHistoricalStatsValuePair</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyHistoricalStatsDestinyHistoricalStatsValuePair left, DestinyHistoricalStatsDestinyHistoricalStatsValuePair right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyHistoricalStatsDestinyHistoricalStatsValuePair.
        /// </summary>
        /// <param name="left">Compared (DestinyHistoricalStatsDestinyHistoricalStatsValuePair</param>
        /// <param name="right">Compared (DestinyHistoricalStatsDestinyHistoricalStatsValuePair</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyHistoricalStatsDestinyHistoricalStatsValuePair left, DestinyHistoricalStatsDestinyHistoricalStatsValuePair right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyHistoricalStatsDestinyHistoricalStatsValuePair.
        /// </summary>
        public sealed class DestinyHistoricalStatsDestinyHistoricalStatsValuePairBuilder
        {
            private double? _Value;
            private string _DisplayValue;

            internal DestinyHistoricalStatsDestinyHistoricalStatsValuePairBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyHistoricalStatsValuePair.Value property.
            /// </summary>
            /// <param name="value">Raw value of the statistic</param>
            public DestinyHistoricalStatsDestinyHistoricalStatsValuePairBuilder Value(double? value)
            {
                _Value = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyHistoricalStatsValuePair.DisplayValue property.
            /// </summary>
            /// <param name="value">Localized formated version of the value.</param>
            public DestinyHistoricalStatsDestinyHistoricalStatsValuePairBuilder DisplayValue(string value)
            {
                _DisplayValue = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyHistoricalStatsDestinyHistoricalStatsValuePair.
            /// </summary>
            /// <returns>DestinyHistoricalStatsDestinyHistoricalStatsValuePair</returns>
            public DestinyHistoricalStatsDestinyHistoricalStatsValuePair Build()
            {
                Validate();
                return new DestinyHistoricalStatsDestinyHistoricalStatsValuePair(
                    Value: _Value,
                    DisplayValue: _DisplayValue
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}