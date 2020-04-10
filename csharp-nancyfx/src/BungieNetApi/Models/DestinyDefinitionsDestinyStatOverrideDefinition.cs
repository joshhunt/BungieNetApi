using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Stat Groups (DestinyStatGroupDefinition) has the ability to override the localized text associated with stats that are to be shown on the items with which they are associated.  This defines a specific overridden stat. You could theoretically check these before rendering your stat UI, and for each stat that has an override show these displayProperties instead of those on the DestinyStatDefinition.  Or you could be like us, and skip that for now because the game has yet to actually use this feature. But know that it&#39;s here, waiting for a resilliant young designer to take up the mantle and make us all look foolish by showing the wrong name for stats.  Note that, if this gets used, the override will apply only to items using the overriding Stat Group. Other items will still show the default stat&#39;s name/description.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyStatOverrideDefinition:  IEquatable<DestinyDefinitionsDestinyStatOverrideDefinition>
    { 
        /// <summary>
        /// The hash identifier of the stat whose display properties are being overridden.
        /// </summary>
        public int? StatHash { get; private set; }

        /// <summary>
        /// The display properties to show instead of the base DestinyStatDefinition display properties.
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyStatOverrideDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyStatOverrideDefinition()
        {
        }

        private DestinyDefinitionsDestinyStatOverrideDefinition(int? StatHash, DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties)
        {
            
            this.StatHash = StatHash;
            
            this.DisplayProperties = DisplayProperties;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyStatOverrideDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyStatOverrideDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyStatOverrideDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyStatOverrideDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyStatOverrideDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyStatOverrideDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyStatOverrideDefinitionBuilder With()
        {
            return Builder()
                .StatHash(StatHash)
                .DisplayProperties(DisplayProperties);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyStatOverrideDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyStatOverrideDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyStatOverrideDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyStatOverrideDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyStatOverrideDefinition left, DestinyDefinitionsDestinyStatOverrideDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyStatOverrideDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyStatOverrideDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyStatOverrideDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyStatOverrideDefinition left, DestinyDefinitionsDestinyStatOverrideDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyStatOverrideDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyStatOverrideDefinitionBuilder
        {
            private int? _StatHash;
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _DisplayProperties;

            internal DestinyDefinitionsDestinyStatOverrideDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyStatOverrideDefinition.StatHash property.
            /// </summary>
            /// <param name="value">The hash identifier of the stat whose display properties are being overridden.</param>
            public DestinyDefinitionsDestinyStatOverrideDefinitionBuilder StatHash(int? value)
            {
                _StatHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyStatOverrideDefinition.DisplayProperties property.
            /// </summary>
            /// <param name="value">The display properties to show instead of the base DestinyStatDefinition display properties.</param>
            public DestinyDefinitionsDestinyStatOverrideDefinitionBuilder DisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _DisplayProperties = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyStatOverrideDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyStatOverrideDefinition</returns>
            public DestinyDefinitionsDestinyStatOverrideDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyStatOverrideDefinition(
                    StatHash: _StatHash,
                    DisplayProperties: _DisplayProperties
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}