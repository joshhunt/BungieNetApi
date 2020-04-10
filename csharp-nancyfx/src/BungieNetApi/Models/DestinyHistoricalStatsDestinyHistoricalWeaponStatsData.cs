using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyHistoricalStatsDestinyHistoricalWeaponStatsData
    /// </summary>
    public sealed class DestinyHistoricalStatsDestinyHistoricalWeaponStatsData:  IEquatable<DestinyHistoricalStatsDestinyHistoricalWeaponStatsData>
    { 
        /// <summary>
        /// List of weapons and their perspective values.
        /// </summary>
        public List<DestinyHistoricalStatsDestinyHistoricalWeaponStats> Weapons { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyHistoricalStatsDestinyHistoricalWeaponStatsData.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyHistoricalStatsDestinyHistoricalWeaponStatsData()
        {
        }

        private DestinyHistoricalStatsDestinyHistoricalWeaponStatsData(List<DestinyHistoricalStatsDestinyHistoricalWeaponStats> Weapons)
        {
            
            this.Weapons = Weapons;
            
        }

        /// <summary>
        /// Returns builder of DestinyHistoricalStatsDestinyHistoricalWeaponStatsData.
        /// </summary>
        /// <returns>DestinyHistoricalStatsDestinyHistoricalWeaponStatsDataBuilder</returns>
        public static DestinyHistoricalStatsDestinyHistoricalWeaponStatsDataBuilder Builder()
        {
            return new DestinyHistoricalStatsDestinyHistoricalWeaponStatsDataBuilder();
        }

        /// <summary>
        /// Returns DestinyHistoricalStatsDestinyHistoricalWeaponStatsDataBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyHistoricalStatsDestinyHistoricalWeaponStatsDataBuilder</returns>
        public DestinyHistoricalStatsDestinyHistoricalWeaponStatsDataBuilder With()
        {
            return Builder()
                .Weapons(Weapons);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyHistoricalStatsDestinyHistoricalWeaponStatsData other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyHistoricalStatsDestinyHistoricalWeaponStatsData.
        /// </summary>
        /// <param name="left">Compared (DestinyHistoricalStatsDestinyHistoricalWeaponStatsData</param>
        /// <param name="right">Compared (DestinyHistoricalStatsDestinyHistoricalWeaponStatsData</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyHistoricalStatsDestinyHistoricalWeaponStatsData left, DestinyHistoricalStatsDestinyHistoricalWeaponStatsData right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyHistoricalStatsDestinyHistoricalWeaponStatsData.
        /// </summary>
        /// <param name="left">Compared (DestinyHistoricalStatsDestinyHistoricalWeaponStatsData</param>
        /// <param name="right">Compared (DestinyHistoricalStatsDestinyHistoricalWeaponStatsData</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyHistoricalStatsDestinyHistoricalWeaponStatsData left, DestinyHistoricalStatsDestinyHistoricalWeaponStatsData right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyHistoricalStatsDestinyHistoricalWeaponStatsData.
        /// </summary>
        public sealed class DestinyHistoricalStatsDestinyHistoricalWeaponStatsDataBuilder
        {
            private List<DestinyHistoricalStatsDestinyHistoricalWeaponStats> _Weapons;

            internal DestinyHistoricalStatsDestinyHistoricalWeaponStatsDataBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyHistoricalStatsDestinyHistoricalWeaponStatsData.Weapons property.
            /// </summary>
            /// <param name="value">List of weapons and their perspective values.</param>
            public DestinyHistoricalStatsDestinyHistoricalWeaponStatsDataBuilder Weapons(List<DestinyHistoricalStatsDestinyHistoricalWeaponStats> value)
            {
                _Weapons = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyHistoricalStatsDestinyHistoricalWeaponStatsData.
            /// </summary>
            /// <returns>DestinyHistoricalStatsDestinyHistoricalWeaponStatsData</returns>
            public DestinyHistoricalStatsDestinyHistoricalWeaponStatsData Build()
            {
                Validate();
                return new DestinyHistoricalStatsDestinyHistoricalWeaponStatsData(
                    Weapons: _Weapons
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}