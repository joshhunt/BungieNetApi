using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyEntitiesItemsDestinyItemInstanceEnergy
    /// </summary>
    public sealed class DestinyEntitiesItemsDestinyItemInstanceEnergy:  IEquatable<DestinyEntitiesItemsDestinyItemInstanceEnergy>
    { 
        /// <summary>
        /// The type of energy for this item. Plugs that require Energy can only be inserted if they have the \&quot;Any\&quot; Energy Type or the matching energy type of this item. This is a reference to the DestinyEnergyTypeDefinition for the energy type, where you can find extended info about it.
        /// </summary>
        public int? EnergyTypeHash { get; private set; }

        /// <summary>
        /// This is the enum version of the Energy Type value, for convenience.
        /// </summary>
        public int? EnergyType { get; private set; }

        /// <summary>
        /// The total capacity of Energy that the item currently has, regardless of if it is currently being used.
        /// </summary>
        public int? EnergyCapacity { get; private set; }

        /// <summary>
        /// The amount of Energy currently in use by inserted plugs.
        /// </summary>
        public int? EnergyUsed { get; private set; }

        /// <summary>
        /// The amount of energy still available for inserting new plugs.
        /// </summary>
        public int? EnergyUnused { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyEntitiesItemsDestinyItemInstanceEnergy.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyEntitiesItemsDestinyItemInstanceEnergy()
        {
        }

        private DestinyEntitiesItemsDestinyItemInstanceEnergy(int? EnergyTypeHash, int? EnergyType, int? EnergyCapacity, int? EnergyUsed, int? EnergyUnused)
        {
            
            this.EnergyTypeHash = EnergyTypeHash;
            
            this.EnergyType = EnergyType;
            
            this.EnergyCapacity = EnergyCapacity;
            
            this.EnergyUsed = EnergyUsed;
            
            this.EnergyUnused = EnergyUnused;
            
        }

        /// <summary>
        /// Returns builder of DestinyEntitiesItemsDestinyItemInstanceEnergy.
        /// </summary>
        /// <returns>DestinyEntitiesItemsDestinyItemInstanceEnergyBuilder</returns>
        public static DestinyEntitiesItemsDestinyItemInstanceEnergyBuilder Builder()
        {
            return new DestinyEntitiesItemsDestinyItemInstanceEnergyBuilder();
        }

        /// <summary>
        /// Returns DestinyEntitiesItemsDestinyItemInstanceEnergyBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyEntitiesItemsDestinyItemInstanceEnergyBuilder</returns>
        public DestinyEntitiesItemsDestinyItemInstanceEnergyBuilder With()
        {
            return Builder()
                .EnergyTypeHash(EnergyTypeHash)
                .EnergyType(EnergyType)
                .EnergyCapacity(EnergyCapacity)
                .EnergyUsed(EnergyUsed)
                .EnergyUnused(EnergyUnused);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyEntitiesItemsDestinyItemInstanceEnergy other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyEntitiesItemsDestinyItemInstanceEnergy.
        /// </summary>
        /// <param name="left">Compared (DestinyEntitiesItemsDestinyItemInstanceEnergy</param>
        /// <param name="right">Compared (DestinyEntitiesItemsDestinyItemInstanceEnergy</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyEntitiesItemsDestinyItemInstanceEnergy left, DestinyEntitiesItemsDestinyItemInstanceEnergy right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyEntitiesItemsDestinyItemInstanceEnergy.
        /// </summary>
        /// <param name="left">Compared (DestinyEntitiesItemsDestinyItemInstanceEnergy</param>
        /// <param name="right">Compared (DestinyEntitiesItemsDestinyItemInstanceEnergy</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyEntitiesItemsDestinyItemInstanceEnergy left, DestinyEntitiesItemsDestinyItemInstanceEnergy right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyEntitiesItemsDestinyItemInstanceEnergy.
        /// </summary>
        public sealed class DestinyEntitiesItemsDestinyItemInstanceEnergyBuilder
        {
            private int? _EnergyTypeHash;
            private int? _EnergyType;
            private int? _EnergyCapacity;
            private int? _EnergyUsed;
            private int? _EnergyUnused;

            internal DestinyEntitiesItemsDestinyItemInstanceEnergyBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyEntitiesItemsDestinyItemInstanceEnergy.EnergyTypeHash property.
            /// </summary>
            /// <param name="value">The type of energy for this item. Plugs that require Energy can only be inserted if they have the \&quot;Any\&quot; Energy Type or the matching energy type of this item. This is a reference to the DestinyEnergyTypeDefinition for the energy type, where you can find extended info about it.</param>
            public DestinyEntitiesItemsDestinyItemInstanceEnergyBuilder EnergyTypeHash(int? value)
            {
                _EnergyTypeHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesItemsDestinyItemInstanceEnergy.EnergyType property.
            /// </summary>
            /// <param name="value">This is the enum version of the Energy Type value, for convenience.</param>
            public DestinyEntitiesItemsDestinyItemInstanceEnergyBuilder EnergyType(int? value)
            {
                _EnergyType = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesItemsDestinyItemInstanceEnergy.EnergyCapacity property.
            /// </summary>
            /// <param name="value">The total capacity of Energy that the item currently has, regardless of if it is currently being used.</param>
            public DestinyEntitiesItemsDestinyItemInstanceEnergyBuilder EnergyCapacity(int? value)
            {
                _EnergyCapacity = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesItemsDestinyItemInstanceEnergy.EnergyUsed property.
            /// </summary>
            /// <param name="value">The amount of Energy currently in use by inserted plugs.</param>
            public DestinyEntitiesItemsDestinyItemInstanceEnergyBuilder EnergyUsed(int? value)
            {
                _EnergyUsed = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyEntitiesItemsDestinyItemInstanceEnergy.EnergyUnused property.
            /// </summary>
            /// <param name="value">The amount of energy still available for inserting new plugs.</param>
            public DestinyEntitiesItemsDestinyItemInstanceEnergyBuilder EnergyUnused(int? value)
            {
                _EnergyUnused = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyEntitiesItemsDestinyItemInstanceEnergy.
            /// </summary>
            /// <returns>DestinyEntitiesItemsDestinyItemInstanceEnergy</returns>
            public DestinyEntitiesItemsDestinyItemInstanceEnergy Build()
            {
                Validate();
                return new DestinyEntitiesItemsDestinyItemInstanceEnergy(
                    EnergyTypeHash: _EnergyTypeHash,
                    EnergyType: _EnergyType,
                    EnergyCapacity: _EnergyCapacity,
                    EnergyUsed: _EnergyUsed,
                    EnergyUnused: _EnergyUnused
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}