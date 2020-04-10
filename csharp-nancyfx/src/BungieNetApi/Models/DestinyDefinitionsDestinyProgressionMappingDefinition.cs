using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Aggregations of multiple progressions.  These are used to apply rewards to multiple progressions at once. They can sometimes have human readable data as well, but only extremely sporadically.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyProgressionMappingDefinition:  IEquatable<DestinyDefinitionsDestinyProgressionMappingDefinition>
    { 
        /// <summary>
        /// Infrequently defined in practice. Defer to the individual progressions&#39; display properties.
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; private set; }

        /// <summary>
        /// The localized unit of measurement for progression across the progressions defined in this mapping. Unfortunately, this is very infrequently defined. Defer to the individual progressions&#39; display units.
        /// </summary>
        public string DisplayUnits { get; private set; }

        /// <summary>
        /// The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.
        /// </summary>
        public int? Hash { get; private set; }

        /// <summary>
        /// The index of the entity as it was found in the investment tables.
        /// </summary>
        public int? Index { get; private set; }

        /// <summary>
        /// If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!
        /// </summary>
        public bool? Redacted { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDestinyProgressionMappingDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyProgressionMappingDefinition()
        {
        }

        private DestinyDefinitionsDestinyProgressionMappingDefinition(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties, string DisplayUnits, int? Hash, int? Index, bool? Redacted)
        {
            
            this.DisplayProperties = DisplayProperties;
            
            this.DisplayUnits = DisplayUnits;
            
            this.Hash = Hash;
            
            this.Index = Index;
            
            this.Redacted = Redacted;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyProgressionMappingDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyProgressionMappingDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyProgressionMappingDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyProgressionMappingDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyProgressionMappingDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyProgressionMappingDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyProgressionMappingDefinitionBuilder With()
        {
            return Builder()
                .DisplayProperties(DisplayProperties)
                .DisplayUnits(DisplayUnits)
                .Hash(Hash)
                .Index(Index)
                .Redacted(Redacted);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDestinyProgressionMappingDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyProgressionMappingDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyProgressionMappingDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyProgressionMappingDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyProgressionMappingDefinition left, DestinyDefinitionsDestinyProgressionMappingDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyProgressionMappingDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyProgressionMappingDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyProgressionMappingDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyProgressionMappingDefinition left, DestinyDefinitionsDestinyProgressionMappingDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyProgressionMappingDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyProgressionMappingDefinitionBuilder
        {
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _DisplayProperties;
            private string _DisplayUnits;
            private int? _Hash;
            private int? _Index;
            private bool? _Redacted;

            internal DestinyDefinitionsDestinyProgressionMappingDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyProgressionMappingDefinition.DisplayProperties property.
            /// </summary>
            /// <param name="value">Infrequently defined in practice. Defer to the individual progressions&#39; display properties.</param>
            public DestinyDefinitionsDestinyProgressionMappingDefinitionBuilder DisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _DisplayProperties = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyProgressionMappingDefinition.DisplayUnits property.
            /// </summary>
            /// <param name="value">The localized unit of measurement for progression across the progressions defined in this mapping. Unfortunately, this is very infrequently defined. Defer to the individual progressions&#39; display units.</param>
            public DestinyDefinitionsDestinyProgressionMappingDefinitionBuilder DisplayUnits(string value)
            {
                _DisplayUnits = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyProgressionMappingDefinition.Hash property.
            /// </summary>
            /// <param name="value">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</param>
            public DestinyDefinitionsDestinyProgressionMappingDefinitionBuilder Hash(int? value)
            {
                _Hash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyProgressionMappingDefinition.Index property.
            /// </summary>
            /// <param name="value">The index of the entity as it was found in the investment tables.</param>
            public DestinyDefinitionsDestinyProgressionMappingDefinitionBuilder Index(int? value)
            {
                _Index = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyProgressionMappingDefinition.Redacted property.
            /// </summary>
            /// <param name="value">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</param>
            public DestinyDefinitionsDestinyProgressionMappingDefinitionBuilder Redacted(bool? value)
            {
                _Redacted = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyProgressionMappingDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyProgressionMappingDefinition</returns>
            public DestinyDefinitionsDestinyProgressionMappingDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyProgressionMappingDefinition(
                    DisplayProperties: _DisplayProperties,
                    DisplayUnits: _DisplayUnits,
                    Hash: _Hash,
                    Index: _Index,
                    Redacted: _Redacted
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}