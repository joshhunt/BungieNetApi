using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedData
    /// </summary>
    public sealed class DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedData:  IEquatable<DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedData>
    { 
        /// <summary>
        /// List of weapons and their perspective values.
        /// </summary>
        public List<DestinyHistoricalStatsDestinyHistoricalWeaponStats> Weapons { get; private set; }

        /// <summary>
        /// Collection of stats for the player in this activity.
        /// </summary>
        public Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsValue> Values { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedData.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedData()
        {
        }

        private DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedData(List<DestinyHistoricalStatsDestinyHistoricalWeaponStats> Weapons, Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsValue> Values)
        {
            
            this.Weapons = Weapons;
            
            this.Values = Values;
            
        }

        /// <summary>
        /// Returns builder of DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedData.
        /// </summary>
        /// <returns>DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedDataBuilder</returns>
        public static DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedDataBuilder Builder()
        {
            return new DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedDataBuilder();
        }

        /// <summary>
        /// Returns DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedDataBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedDataBuilder</returns>
        public DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedDataBuilder With()
        {
            return Builder()
                .Weapons(Weapons)
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

        public bool Equals(DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedData other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedData.
        /// </summary>
        /// <param name="left">Compared (DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedData</param>
        /// <param name="right">Compared (DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedData</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedData left, DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedData right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedData.
        /// </summary>
        /// <param name="left">Compared (DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedData</param>
        /// <param name="right">Compared (DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedData</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedData left, DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedData right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedData.
        /// </summary>
        public sealed class DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedDataBuilder
        {
            private List<DestinyHistoricalStatsDestinyHistoricalWeaponStats> _Weapons;
            private Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsValue> _Values;

            internal DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedDataBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedData.Weapons property.
            /// </summary>
            /// <param name="value">List of weapons and their perspective values.</param>
            public DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedDataBuilder Weapons(List<DestinyHistoricalStatsDestinyHistoricalWeaponStats> value)
            {
                _Weapons = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedData.Values property.
            /// </summary>
            /// <param name="value">Collection of stats for the player in this activity.</param>
            public DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedDataBuilder Values(Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsValue> value)
            {
                _Values = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedData.
            /// </summary>
            /// <returns>DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedData</returns>
            public DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedData Build()
            {
                Validate();
                return new DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedData(
                    Weapons: _Weapons,
                    Values: _Values
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}