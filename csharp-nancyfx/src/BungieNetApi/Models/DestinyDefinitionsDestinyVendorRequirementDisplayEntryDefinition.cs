using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// The localized properties of the requirementsDisplay, allowing information about the requirement or item being featured to be seen.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyVendorRequirementDisplayEntryDefinition:  IEquatable<DestinyDefinitionsDestinyVendorRequirementDisplayEntryDefinition>
    { 
        /// <summary>
        /// Icon
        /// </summary>
        public string Icon { get; private set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Source
        /// </summary>
        public string Source { get; private set; }

        /// <summary>
        /// Type
        /// </summary>
        public string Type { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyVendorRequirementDisplayEntryDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyVendorRequirementDisplayEntryDefinition()
        {
        }

        private DestinyDefinitionsDestinyVendorRequirementDisplayEntryDefinition(string Icon, string Name, string Source, string Type)
        {
            
            this.Icon = Icon;
            
            this.Name = Name;
            
            this.Source = Source;
            
            this.Type = Type;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyVendorRequirementDisplayEntryDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyVendorRequirementDisplayEntryDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyVendorRequirementDisplayEntryDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyVendorRequirementDisplayEntryDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyVendorRequirementDisplayEntryDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyVendorRequirementDisplayEntryDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyVendorRequirementDisplayEntryDefinitionBuilder With()
        {
            return Builder()
                .Icon(Icon)
                .Name(Name)
                .Source(Source)
                .Type(Type);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyVendorRequirementDisplayEntryDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyVendorRequirementDisplayEntryDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyVendorRequirementDisplayEntryDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyVendorRequirementDisplayEntryDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyVendorRequirementDisplayEntryDefinition left, DestinyDefinitionsDestinyVendorRequirementDisplayEntryDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyVendorRequirementDisplayEntryDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyVendorRequirementDisplayEntryDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyVendorRequirementDisplayEntryDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyVendorRequirementDisplayEntryDefinition left, DestinyDefinitionsDestinyVendorRequirementDisplayEntryDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyVendorRequirementDisplayEntryDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyVendorRequirementDisplayEntryDefinitionBuilder
        {
            private string _Icon;
            private string _Name;
            private string _Source;
            private string _Type;

            internal DestinyDefinitionsDestinyVendorRequirementDisplayEntryDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorRequirementDisplayEntryDefinition.Icon property.
            /// </summary>
            /// <param name="value">Icon</param>
            public DestinyDefinitionsDestinyVendorRequirementDisplayEntryDefinitionBuilder Icon(string value)
            {
                _Icon = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorRequirementDisplayEntryDefinition.Name property.
            /// </summary>
            /// <param name="value">Name</param>
            public DestinyDefinitionsDestinyVendorRequirementDisplayEntryDefinitionBuilder Name(string value)
            {
                _Name = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorRequirementDisplayEntryDefinition.Source property.
            /// </summary>
            /// <param name="value">Source</param>
            public DestinyDefinitionsDestinyVendorRequirementDisplayEntryDefinitionBuilder Source(string value)
            {
                _Source = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyVendorRequirementDisplayEntryDefinition.Type property.
            /// </summary>
            /// <param name="value">Type</param>
            public DestinyDefinitionsDestinyVendorRequirementDisplayEntryDefinitionBuilder Type(string value)
            {
                _Type = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyVendorRequirementDisplayEntryDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyVendorRequirementDisplayEntryDefinition</returns>
            public DestinyDefinitionsDestinyVendorRequirementDisplayEntryDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyVendorRequirementDisplayEntryDefinition(
                    Icon: _Icon,
                    Name: _Name,
                    Source: _Source,
                    Type: _Type
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}