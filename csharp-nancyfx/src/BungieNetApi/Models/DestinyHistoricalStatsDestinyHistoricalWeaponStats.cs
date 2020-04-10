using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyHistoricalStatsDestinyHistoricalWeaponStats
    /// </summary>
    public sealed class DestinyHistoricalStatsDestinyHistoricalWeaponStats:  IEquatable<DestinyHistoricalStatsDestinyHistoricalWeaponStats>
    { 
        /// <summary>
        /// The hash ID of the item definition that describes the weapon.
        /// </summary>
        public int? ReferenceId { get; private set; }

        /// <summary>
        /// Collection of stats for the period.
        /// </summary>
        public Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsValue> Values { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyHistoricalStatsDestinyHistoricalWeaponStats.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyHistoricalStatsDestinyHistoricalWeaponStats()
        {
        }

        private DestinyHistoricalStatsDestinyHistoricalWeaponStats(int? ReferenceId, Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsValue> Values)
        {
            
            this.ReferenceId = ReferenceId;
            
            this.Values = Values;
            
        }

        /// <summary>
        /// Returns builder of DestinyHistoricalStatsDestinyHistoricalWeaponStats.
        /// </summary>
        /// <returns>DestinyHistoricalStatsDestinyHistoricalWeaponStatsBuilder</returns>
        public static DestinyHistoricalStatsDestinyHistoricalWeaponStatsBuilder Builder()
        {
            return new DestinyHistoricalStatsDestinyHistoricalWeaponStatsBuilder();
        }

        /// <summary>
        /// Returns DestinyHistoricalStatsDestinyHistoricalWeaponStatsBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyHistoricalStatsDestinyHistoricalWeaponStatsBuilder</returns>
        public DestinyHistoricalStatsDestinyHistoricalWeaponStatsBuilder With()
        {
            return Builder()
                .ReferenceId(ReferenceId)
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

        public bool Equals(DestinyHistoricalStatsDestinyHistoricalWeaponStats other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyHistoricalStatsDestinyHistoricalWeaponStats.
        /// </summary>
        /// <param name="left">Compared (DestinyHistoricalStatsDestinyHistoricalWeaponStats</param>
        /// <param name="right">Compared (DestinyHistoricalStatsDestinyHistoricalWeaponStats</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyHistoricalStatsDestinyHistoricalWeaponStats left, DestinyHistoricalStatsDestinyHistoricalWeaponStats right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyHistoricalStatsDestinyHistoricalWeaponStats.
        /// </summary>
        /// <param name="left">Compared (DestinyHistoricalStatsDestinyHistoricalWeaponStats</param>
        /// <param name="right">Compared (DestinyHistoricalStatsDestinyHistoricalWeaponStats</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyHistoricalStatsDestinyHistoricalWeaponStats left, DestinyHistoricalStatsDestinyHistoricalWeaponStats right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyHistoricalStatsDestinyHistoricalWeaponStats.
        /// </summary>
        public sealed class DestinyHistoricalStatsDestinyHistoricalWeaponStatsBuilder
        {
            private int? _ReferenceId;
            private Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsValue> _Values;

            internal DestinyHistoricalStatsDestinyHistoricalWeaponStatsBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyHistoricalWeaponStats.ReferenceId property.
            /// </summary>
            /// <param name="value">The hash ID of the item definition that describes the weapon.</param>
            public DestinyHistoricalStatsDestinyHistoricalWeaponStatsBuilder ReferenceId(int? value)
            {
                _ReferenceId = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyHistoricalWeaponStats.Values property.
            /// </summary>
            /// <param name="value">Collection of stats for the period.</param>
            public DestinyHistoricalStatsDestinyHistoricalWeaponStatsBuilder Values(Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsValue> value)
            {
                _Values = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyHistoricalStatsDestinyHistoricalWeaponStats.
            /// </summary>
            /// <returns>DestinyHistoricalStatsDestinyHistoricalWeaponStats</returns>
            public DestinyHistoricalStatsDestinyHistoricalWeaponStats Build()
            {
                Validate();
                return new DestinyHistoricalStatsDestinyHistoricalWeaponStats(
                    ReferenceId: _ReferenceId,
                    Values: _Values
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}