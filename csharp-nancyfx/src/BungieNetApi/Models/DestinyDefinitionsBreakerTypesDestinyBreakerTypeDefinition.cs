using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyDefinitionsBreakerTypesDestinyBreakerTypeDefinition
    /// </summary>
    public sealed class DestinyDefinitionsBreakerTypesDestinyBreakerTypeDefinition:  IEquatable<DestinyDefinitionsBreakerTypesDestinyBreakerTypeDefinition>
    { 
        /// <summary>
        /// DisplayProperties
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; private set; }

        /// <summary>
        /// We have an enumeration for Breaker types for quick reference. This is the current definition&#39;s breaker type enum value.
        /// </summary>
        public int? EnumValue { get; private set; }

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
        /// Use DestinyDefinitionsBreakerTypesDestinyBreakerTypeDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsBreakerTypesDestinyBreakerTypeDefinition()
        {
        }

        private DestinyDefinitionsBreakerTypesDestinyBreakerTypeDefinition(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties, int? EnumValue, int? Hash, int? Index, bool? Redacted)
        {
            
            this.DisplayProperties = DisplayProperties;
            
            this.EnumValue = EnumValue;
            
            this.Hash = Hash;
            
            this.Index = Index;
            
            this.Redacted = Redacted;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsBreakerTypesDestinyBreakerTypeDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsBreakerTypesDestinyBreakerTypeDefinitionBuilder</returns>
        public static DestinyDefinitionsBreakerTypesDestinyBreakerTypeDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsBreakerTypesDestinyBreakerTypeDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsBreakerTypesDestinyBreakerTypeDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsBreakerTypesDestinyBreakerTypeDefinitionBuilder</returns>
        public DestinyDefinitionsBreakerTypesDestinyBreakerTypeDefinitionBuilder With()
        {
            return Builder()
                .DisplayProperties(DisplayProperties)
                .EnumValue(EnumValue)
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

        public bool Equals(DestinyDefinitionsBreakerTypesDestinyBreakerTypeDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsBreakerTypesDestinyBreakerTypeDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsBreakerTypesDestinyBreakerTypeDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsBreakerTypesDestinyBreakerTypeDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsBreakerTypesDestinyBreakerTypeDefinition left, DestinyDefinitionsBreakerTypesDestinyBreakerTypeDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsBreakerTypesDestinyBreakerTypeDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsBreakerTypesDestinyBreakerTypeDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsBreakerTypesDestinyBreakerTypeDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsBreakerTypesDestinyBreakerTypeDefinition left, DestinyDefinitionsBreakerTypesDestinyBreakerTypeDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsBreakerTypesDestinyBreakerTypeDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsBreakerTypesDestinyBreakerTypeDefinitionBuilder
        {
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _DisplayProperties;
            private int? _EnumValue;
            private int? _Hash;
            private int? _Index;
            private bool? _Redacted;

            internal DestinyDefinitionsBreakerTypesDestinyBreakerTypeDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsBreakerTypesDestinyBreakerTypeDefinition.DisplayProperties property.
            /// </summary>
            /// <param name="value">DisplayProperties</param>
            public DestinyDefinitionsBreakerTypesDestinyBreakerTypeDefinitionBuilder DisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _DisplayProperties = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsBreakerTypesDestinyBreakerTypeDefinition.EnumValue property.
            /// </summary>
            /// <param name="value">We have an enumeration for Breaker types for quick reference. This is the current definition&#39;s breaker type enum value.</param>
            public DestinyDefinitionsBreakerTypesDestinyBreakerTypeDefinitionBuilder EnumValue(int? value)
            {
                _EnumValue = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsBreakerTypesDestinyBreakerTypeDefinition.Hash property.
            /// </summary>
            /// <param name="value">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</param>
            public DestinyDefinitionsBreakerTypesDestinyBreakerTypeDefinitionBuilder Hash(int? value)
            {
                _Hash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsBreakerTypesDestinyBreakerTypeDefinition.Index property.
            /// </summary>
            /// <param name="value">The index of the entity as it was found in the investment tables.</param>
            public DestinyDefinitionsBreakerTypesDestinyBreakerTypeDefinitionBuilder Index(int? value)
            {
                _Index = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsBreakerTypesDestinyBreakerTypeDefinition.Redacted property.
            /// </summary>
            /// <param name="value">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</param>
            public DestinyDefinitionsBreakerTypesDestinyBreakerTypeDefinitionBuilder Redacted(bool? value)
            {
                _Redacted = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsBreakerTypesDestinyBreakerTypeDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsBreakerTypesDestinyBreakerTypeDefinition</returns>
            public DestinyDefinitionsBreakerTypesDestinyBreakerTypeDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsBreakerTypesDestinyBreakerTypeDefinition(
                    DisplayProperties: _DisplayProperties,
                    EnumValue: _EnumValue,
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