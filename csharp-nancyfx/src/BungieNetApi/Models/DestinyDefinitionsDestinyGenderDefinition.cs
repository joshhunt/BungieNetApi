using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Gender is a social construct, and as such we have definitions for Genders. Right now there happens to only be two, but we&#39;ll see what the future holds.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyGenderDefinition:  IEquatable<DestinyDefinitionsDestinyGenderDefinition>
    { 
        /// <summary>
        /// This is a quick reference enumeration for all of the currently defined Genders. We use the enumeration for quicker lookups in related data, like DestinyClassDefinition.genderedClassNames.
        /// </summary>
        public int? GenderType { get; private set; }

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
        /// Use DestinyDefinitionsDestinyGenderDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyGenderDefinition()
        {
        }

        private DestinyDefinitionsDestinyGenderDefinition(int? GenderType, DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties, int? Hash, int? Index, bool? Redacted)
        {
            
            this.GenderType = GenderType;
            
            this.DisplayProperties = DisplayProperties;
            
            this.Hash = Hash;
            
            this.Index = Index;
            
            this.Redacted = Redacted;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyGenderDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyGenderDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyGenderDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyGenderDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyGenderDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyGenderDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyGenderDefinitionBuilder With()
        {
            return Builder()
                .GenderType(GenderType)
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

        public bool Equals(DestinyDefinitionsDestinyGenderDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyGenderDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyGenderDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyGenderDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyGenderDefinition left, DestinyDefinitionsDestinyGenderDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyGenderDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyGenderDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyGenderDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyGenderDefinition left, DestinyDefinitionsDestinyGenderDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyGenderDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyGenderDefinitionBuilder
        {
            private int? _GenderType;
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _DisplayProperties;
            private int? _Hash;
            private int? _Index;
            private bool? _Redacted;

            internal DestinyDefinitionsDestinyGenderDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyGenderDefinition.GenderType property.
            /// </summary>
            /// <param name="value">This is a quick reference enumeration for all of the currently defined Genders. We use the enumeration for quicker lookups in related data, like DestinyClassDefinition.genderedClassNames.</param>
            public DestinyDefinitionsDestinyGenderDefinitionBuilder GenderType(int? value)
            {
                _GenderType = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyGenderDefinition.DisplayProperties property.
            /// </summary>
            /// <param name="value">DisplayProperties</param>
            public DestinyDefinitionsDestinyGenderDefinitionBuilder DisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _DisplayProperties = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyGenderDefinition.Hash property.
            /// </summary>
            /// <param name="value">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</param>
            public DestinyDefinitionsDestinyGenderDefinitionBuilder Hash(int? value)
            {
                _Hash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyGenderDefinition.Index property.
            /// </summary>
            /// <param name="value">The index of the entity as it was found in the investment tables.</param>
            public DestinyDefinitionsDestinyGenderDefinitionBuilder Index(int? value)
            {
                _Index = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyGenderDefinition.Redacted property.
            /// </summary>
            /// <param name="value">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</param>
            public DestinyDefinitionsDestinyGenderDefinitionBuilder Redacted(bool? value)
            {
                _Redacted = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyGenderDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyGenderDefinition</returns>
            public DestinyDefinitionsDestinyGenderDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyGenderDefinition(
                    GenderType: _GenderType,
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