using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Items can have Energy Capacity, and plugs can provide that capacity such as on a piece of Armor in Armor 2.0. This is how much \&quot;Energy\&quot; can be spent on activating plugs for this item.
    /// </summary>
    public sealed class DestinyDefinitionsItemsDestinyEnergyCapacityEntry:  IEquatable<DestinyDefinitionsItemsDestinyEnergyCapacityEntry>
    { 
        /// <summary>
        /// How much energy capacity this plug provides.
        /// </summary>
        public int? CapacityValue { get; private set; }

        /// <summary>
        /// Energy provided by a plug is always of a specific type - this is the hash identifier for the energy type for which it provides Capacity.
        /// </summary>
        public int? EnergyTypeHash { get; private set; }

        /// <summary>
        /// The Energy Type for this energy capacity, in enum form for easy use.
        /// </summary>
        public int? EnergyType { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsItemsDestinyEnergyCapacityEntry.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsItemsDestinyEnergyCapacityEntry()
        {
        }

        private DestinyDefinitionsItemsDestinyEnergyCapacityEntry(int? CapacityValue, int? EnergyTypeHash, int? EnergyType)
        {
            
            this.CapacityValue = CapacityValue;
            
            this.EnergyTypeHash = EnergyTypeHash;
            
            this.EnergyType = EnergyType;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsItemsDestinyEnergyCapacityEntry.
        /// </summary>
        /// <returns>DestinyDefinitionsItemsDestinyEnergyCapacityEntryBuilder</returns>
        public static DestinyDefinitionsItemsDestinyEnergyCapacityEntryBuilder Builder()
        {
            return new DestinyDefinitionsItemsDestinyEnergyCapacityEntryBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsItemsDestinyEnergyCapacityEntryBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsItemsDestinyEnergyCapacityEntryBuilder</returns>
        public DestinyDefinitionsItemsDestinyEnergyCapacityEntryBuilder With()
        {
            return Builder()
                .CapacityValue(CapacityValue)
                .EnergyTypeHash(EnergyTypeHash)
                .EnergyType(EnergyType);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsItemsDestinyEnergyCapacityEntry other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsItemsDestinyEnergyCapacityEntry.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsItemsDestinyEnergyCapacityEntry</param>
        /// <param name="right">Compared (DestinyDefinitionsItemsDestinyEnergyCapacityEntry</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsItemsDestinyEnergyCapacityEntry left, DestinyDefinitionsItemsDestinyEnergyCapacityEntry right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsItemsDestinyEnergyCapacityEntry.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsItemsDestinyEnergyCapacityEntry</param>
        /// <param name="right">Compared (DestinyDefinitionsItemsDestinyEnergyCapacityEntry</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsItemsDestinyEnergyCapacityEntry left, DestinyDefinitionsItemsDestinyEnergyCapacityEntry right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsItemsDestinyEnergyCapacityEntry.
        /// </summary>
        public sealed class DestinyDefinitionsItemsDestinyEnergyCapacityEntryBuilder
        {
            private int? _CapacityValue;
            private int? _EnergyTypeHash;
            private int? _EnergyType;

            internal DestinyDefinitionsItemsDestinyEnergyCapacityEntryBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsItemsDestinyEnergyCapacityEntry.CapacityValue property.
            /// </summary>
            /// <param name="value">How much energy capacity this plug provides.</param>
            public DestinyDefinitionsItemsDestinyEnergyCapacityEntryBuilder CapacityValue(int? value)
            {
                _CapacityValue = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsItemsDestinyEnergyCapacityEntry.EnergyTypeHash property.
            /// </summary>
            /// <param name="value">Energy provided by a plug is always of a specific type - this is the hash identifier for the energy type for which it provides Capacity.</param>
            public DestinyDefinitionsItemsDestinyEnergyCapacityEntryBuilder EnergyTypeHash(int? value)
            {
                _EnergyTypeHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsItemsDestinyEnergyCapacityEntry.EnergyType property.
            /// </summary>
            /// <param name="value">The Energy Type for this energy capacity, in enum form for easy use.</param>
            public DestinyDefinitionsItemsDestinyEnergyCapacityEntryBuilder EnergyType(int? value)
            {
                _EnergyType = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsItemsDestinyEnergyCapacityEntry.
            /// </summary>
            /// <returns>DestinyDefinitionsItemsDestinyEnergyCapacityEntry</returns>
            public DestinyDefinitionsItemsDestinyEnergyCapacityEntry Build()
            {
                Validate();
                return new DestinyDefinitionsItemsDestinyEnergyCapacityEntry(
                    CapacityValue: _CapacityValue,
                    EnergyTypeHash: _EnergyTypeHash,
                    EnergyType: _EnergyType
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}