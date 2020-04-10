using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Okay, so Activities (DestinyActivityDefinition) take place in Destinations (DestinyDestinationDefinition). Destinations are part of larger locations known as Places (you&#39;re reading its documentation right now).  Places are more on the planetary scale, like \&quot;Earth\&quot; and \&quot;Your Mom.\&quot;
    /// </summary>
    public sealed class DestinyDefinitionsDestinyPlaceDefinition:  IEquatable<DestinyDefinitionsDestinyPlaceDefinition>
    { 
        /// <summary>
        /// DisplayProperties
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; private set; }

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
        /// Use DestinyDefinitionsDestinyPlaceDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyPlaceDefinition()
        {
        }

        private DestinyDefinitionsDestinyPlaceDefinition(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties, int? Hash, int? Index, bool? Redacted)
        {
            
            this.DisplayProperties = DisplayProperties;
            
            this.Hash = Hash;
            
            this.Index = Index;
            
            this.Redacted = Redacted;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyPlaceDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyPlaceDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyPlaceDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyPlaceDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyPlaceDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyPlaceDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyPlaceDefinitionBuilder With()
        {
            return Builder()
                .DisplayProperties(DisplayProperties)
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

        public bool Equals(DestinyDefinitionsDestinyPlaceDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyPlaceDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyPlaceDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyPlaceDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyPlaceDefinition left, DestinyDefinitionsDestinyPlaceDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyPlaceDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyPlaceDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyPlaceDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyPlaceDefinition left, DestinyDefinitionsDestinyPlaceDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyPlaceDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyPlaceDefinitionBuilder
        {
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _DisplayProperties;
            private int? _Hash;
            private int? _Index;
            private bool? _Redacted;

            internal DestinyDefinitionsDestinyPlaceDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyPlaceDefinition.DisplayProperties property.
            /// </summary>
            /// <param name="value">DisplayProperties</param>
            public DestinyDefinitionsDestinyPlaceDefinitionBuilder DisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _DisplayProperties = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyPlaceDefinition.Hash property.
            /// </summary>
            /// <param name="value">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</param>
            public DestinyDefinitionsDestinyPlaceDefinitionBuilder Hash(int? value)
            {
                _Hash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyPlaceDefinition.Index property.
            /// </summary>
            /// <param name="value">The index of the entity as it was found in the investment tables.</param>
            public DestinyDefinitionsDestinyPlaceDefinitionBuilder Index(int? value)
            {
                _Index = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyPlaceDefinition.Redacted property.
            /// </summary>
            /// <param name="value">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</param>
            public DestinyDefinitionsDestinyPlaceDefinitionBuilder Redacted(bool? value)
            {
                _Redacted = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyPlaceDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyPlaceDefinition</returns>
            public DestinyDefinitionsDestinyPlaceDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyPlaceDefinition(
                    DisplayProperties: _DisplayProperties,
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