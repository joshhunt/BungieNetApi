using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// When a vendor provides services, this is the localized name of those services.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyVendorServiceDefinition:  IEquatable<DestinyDefinitionsDestinyVendorServiceDefinition>
    { 
        /// <summary>
        /// The localized name of a service provided.
        /// </summary>
        public string Name { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyVendorServiceDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyVendorServiceDefinition()
        {
        }

        private DestinyDefinitionsDestinyVendorServiceDefinition(string Name)
        {
            
            this.Name = Name;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyVendorServiceDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyVendorServiceDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyVendorServiceDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyVendorServiceDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyVendorServiceDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyVendorServiceDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyVendorServiceDefinitionBuilder With()
        {
            return Builder()
                .Name(Name);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyVendorServiceDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyVendorServiceDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyVendorServiceDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyVendorServiceDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyVendorServiceDefinition left, DestinyDefinitionsDestinyVendorServiceDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyVendorServiceDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyVendorServiceDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyVendorServiceDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyVendorServiceDefinition left, DestinyDefinitionsDestinyVendorServiceDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyVendorServiceDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyVendorServiceDefinitionBuilder
        {
            private string _Name;

            internal DestinyDefinitionsDestinyVendorServiceDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorServiceDefinition.Name property.
            /// </summary>
            /// <param name="value">The localized name of a service provided.</param>
            public DestinyDefinitionsDestinyVendorServiceDefinitionBuilder Name(string value)
            {
                _Name = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyVendorServiceDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyVendorServiceDefinition</returns>
            public DestinyDefinitionsDestinyVendorServiceDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyVendorServiceDefinition(
                    Name: _Name
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}