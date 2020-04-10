using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Some plugs cost Energy, which is a stat on the item that can be increased by other plugs (that, at least in Armor 2.0, have a \&quot;masterworks-like\&quot; mechanic for upgrading). If a plug has costs, the details of that cost are defined here.
    /// </summary>
    public sealed class DestinyDefinitionsItemsDestinyEnergyCostEntry:  IEquatable<DestinyDefinitionsItemsDestinyEnergyCostEntry>
    { 
        /// <summary>
        /// The Energy cost for inserting this plug.
        /// </summary>
        public int? EnergyCost { get; private set; }

        /// <summary>
        /// The type of energy that this plug costs, as a reference to the DestinyEnergyTypeDefinition of the energy type.
        /// </summary>
        public int? EnergyTypeHash { get; private set; }

        /// <summary>
        /// The type of energy that this plug costs, in enum form.
        /// </summary>
        public int? EnergyType { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsItemsDestinyEnergyCostEntry.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsItemsDestinyEnergyCostEntry()
        {
        }

        private DestinyDefinitionsItemsDestinyEnergyCostEntry(int? EnergyCost, int? EnergyTypeHash, int? EnergyType)
        {
            
            this.EnergyCost = EnergyCost;
            
            this.EnergyTypeHash = EnergyTypeHash;
            
            this.EnergyType = EnergyType;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsItemsDestinyEnergyCostEntry.
        /// </summary>
        /// <returns>DestinyDefinitionsItemsDestinyEnergyCostEntryBuilder</returns>
        public static DestinyDefinitionsItemsDestinyEnergyCostEntryBuilder Builder()
        {
            return new DestinyDefinitionsItemsDestinyEnergyCostEntryBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsItemsDestinyEnergyCostEntryBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsItemsDestinyEnergyCostEntryBuilder</returns>
        public DestinyDefinitionsItemsDestinyEnergyCostEntryBuilder With()
        {
            return Builder()
                .EnergyCost(EnergyCost)
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

        public bool Equals(DestinyDefinitionsItemsDestinyEnergyCostEntry other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsItemsDestinyEnergyCostEntry.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsItemsDestinyEnergyCostEntry</param>
        /// <param name="right">Compared (DestinyDefinitionsItemsDestinyEnergyCostEntry</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsItemsDestinyEnergyCostEntry left, DestinyDefinitionsItemsDestinyEnergyCostEntry right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsItemsDestinyEnergyCostEntry.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsItemsDestinyEnergyCostEntry</param>
        /// <param name="right">Compared (DestinyDefinitionsItemsDestinyEnergyCostEntry</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsItemsDestinyEnergyCostEntry left, DestinyDefinitionsItemsDestinyEnergyCostEntry right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsItemsDestinyEnergyCostEntry.
        /// </summary>
        public sealed class DestinyDefinitionsItemsDestinyEnergyCostEntryBuilder
        {
            private int? _EnergyCost;
            private int? _EnergyTypeHash;
            private int? _EnergyType;

            internal DestinyDefinitionsItemsDestinyEnergyCostEntryBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsItemsDestinyEnergyCostEntry.EnergyCost property.
            /// </summary>
            /// <param name="value">The Energy cost for inserting this plug.</param>
            public DestinyDefinitionsItemsDestinyEnergyCostEntryBuilder EnergyCost(int? value)
            {
                _EnergyCost = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsItemsDestinyEnergyCostEntry.EnergyTypeHash property.
            /// </summary>
            /// <param name="value">The type of energy that this plug costs, as a reference to the DestinyEnergyTypeDefinition of the energy type.</param>
            public DestinyDefinitionsItemsDestinyEnergyCostEntryBuilder EnergyTypeHash(int? value)
            {
                _EnergyTypeHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsItemsDestinyEnergyCostEntry.EnergyType property.
            /// </summary>
            /// <param name="value">The type of energy that this plug costs, in enum form.</param>
            public DestinyDefinitionsItemsDestinyEnergyCostEntryBuilder EnergyType(int? value)
            {
                _EnergyType = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsItemsDestinyEnergyCostEntry.
            /// </summary>
            /// <returns>DestinyDefinitionsItemsDestinyEnergyCostEntry</returns>
            public DestinyDefinitionsItemsDestinyEnergyCostEntry Build()
            {
                Validate();
                return new DestinyDefinitionsItemsDestinyEnergyCostEntry(
                    EnergyCost: _EnergyCost,
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