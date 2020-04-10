using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// These definitions represent faction vendors at different points in the game.  A single faction may contain multiple vendors, or the same vendor available at two different locations.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyFactionVendorDefinition:  IEquatable<DestinyDefinitionsDestinyFactionVendorDefinition>
    { 
        /// <summary>
        /// The faction vendor hash.
        /// </summary>
        public int? VendorHash { get; private set; }

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
        /// Use DestinyDefinitionsDestinyFactionVendorDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyFactionVendorDefinition()
        {
        }

        private DestinyDefinitionsDestinyFactionVendorDefinition(int? VendorHash, int? DestinationHash, string BackgroundImagePath)
        {
            
            this.VendorHash = VendorHash;
            
            this.DestinationHash = DestinationHash;
            
            this.BackgroundImagePath = BackgroundImagePath;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyFactionVendorDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyFactionVendorDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyFactionVendorDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyFactionVendorDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyFactionVendorDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyFactionVendorDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyFactionVendorDefinitionBuilder With()
        {
            return Builder()
                .VendorHash(VendorHash)
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

        public bool Equals(DestinyDefinitionsDestinyFactionVendorDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyFactionVendorDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyFactionVendorDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyFactionVendorDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyFactionVendorDefinition left, DestinyDefinitionsDestinyFactionVendorDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyFactionVendorDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyFactionVendorDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyFactionVendorDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyFactionVendorDefinition left, DestinyDefinitionsDestinyFactionVendorDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyFactionVendorDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyFactionVendorDefinitionBuilder
        {
            private int? _VendorHash;
            private int? _DestinationHash;
            private string _BackgroundImagePath;

            internal DestinyDefinitionsDestinyFactionVendorDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyFactionVendorDefinition.VendorHash property.
            /// </summary>
            /// <param name="value">The faction vendor hash.</param>
            public DestinyDefinitionsDestinyFactionVendorDefinitionBuilder VendorHash(int? value)
            {
                _VendorHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyFactionVendorDefinition.DestinationHash property.
            /// </summary>
            /// <param name="value">The hash identifier for a Destination at which this vendor may be located. Each destination where a Vendor may exist will only ever have a single entry.</param>
            public DestinyDefinitionsDestinyFactionVendorDefinitionBuilder DestinationHash(int? value)
            {
                _DestinationHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyFactionVendorDefinition.BackgroundImagePath property.
            /// </summary>
            /// <param name="value">The relative path to the background image representing this Vendor at this location, for use in a banner.</param>
            public DestinyDefinitionsDestinyFactionVendorDefinitionBuilder BackgroundImagePath(string value)
            {
                _BackgroundImagePath = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyFactionVendorDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyFactionVendorDefinition</returns>
            public DestinyDefinitionsDestinyFactionVendorDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyFactionVendorDefinition(
                    VendorHash: _VendorHash,
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