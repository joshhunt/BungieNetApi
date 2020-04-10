using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// These definitions represent vendors&#39; locations and relevant display information at different times in the game.
    /// </summary>
    public sealed class DestinyDefinitionsVendorsDestinyVendorLocationDefinition:  IEquatable<DestinyDefinitionsVendorsDestinyVendorLocationDefinition>
    { 
        /// <summary>
        /// The hash identifier for a Destination at which this vendor may be located. Each destination where a Vendor may exist will only ever have a single entry.
        /// </summary>
        public int? DestinationHash { get; private set; }

        /// <summary>
        /// The relative path to the background image representing this Vendor at this location, for use in a banner.
        /// </summary>
        public string BackgroundImagePath { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsVendorsDestinyVendorLocationDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsVendorsDestinyVendorLocationDefinition()
        {
        }

        private DestinyDefinitionsVendorsDestinyVendorLocationDefinition(int? DestinationHash, string BackgroundImagePath)
        {
            
            this.DestinationHash = DestinationHash;
            
            this.BackgroundImagePath = BackgroundImagePath;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsVendorsDestinyVendorLocationDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsVendorsDestinyVendorLocationDefinitionBuilder</returns>
        public static DestinyDefinitionsVendorsDestinyVendorLocationDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsVendorsDestinyVendorLocationDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsVendorsDestinyVendorLocationDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsVendorsDestinyVendorLocationDefinitionBuilder</returns>
        public DestinyDefinitionsVendorsDestinyVendorLocationDefinitionBuilder With()
        {
            return Builder()
                .DestinationHash(DestinationHash)
                .BackgroundImagePath(BackgroundImagePath);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsVendorsDestinyVendorLocationDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsVendorsDestinyVendorLocationDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsVendorsDestinyVendorLocationDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsVendorsDestinyVendorLocationDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsVendorsDestinyVendorLocationDefinition left, DestinyDefinitionsVendorsDestinyVendorLocationDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsVendorsDestinyVendorLocationDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsVendorsDestinyVendorLocationDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsVendorsDestinyVendorLocationDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsVendorsDestinyVendorLocationDefinition left, DestinyDefinitionsVendorsDestinyVendorLocationDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsVendorsDestinyVendorLocationDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsVendorsDestinyVendorLocationDefinitionBuilder
        {
            private int? _DestinationHash;
            private string _BackgroundImagePath;

            internal DestinyDefinitionsVendorsDestinyVendorLocationDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsVendorsDestinyVendorLocationDefinition.DestinationHash property.
            /// </summary>
            /// <param name="value">The hash identifier for a Destination at which this vendor may be located. Each destination where a Vendor may exist will only ever have a single entry.</param>
            public DestinyDefinitionsVendorsDestinyVendorLocationDefinitionBuilder DestinationHash(int? value)
            {
                _DestinationHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsVendorsDestinyVendorLocationDefinition.BackgroundImagePath property.
            /// </summary>
            /// <param name="value">The relative path to the background image representing this Vendor at this location, for use in a banner.</param>
            public DestinyDefinitionsVendorsDestinyVendorLocationDefinitionBuilder BackgroundImagePath(string value)
            {
                _BackgroundImagePath = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsVendorsDestinyVendorLocationDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsVendorsDestinyVendorLocationDefinition</returns>
            public DestinyDefinitionsVendorsDestinyVendorLocationDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsVendorsDestinyVendorLocationDefinition(
                    DestinationHash: _DestinationHash,
                    BackgroundImagePath: _BackgroundImagePath
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}