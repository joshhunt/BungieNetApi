using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// In Destiny, \&quot;Races\&quot; are really more like \&quot;Species\&quot;. Sort of. I mean, are the Awoken a separate species from humans? I&#39;m not sure. But either way, they&#39;re defined here. You&#39;ll see Exo, Awoken, and Human as examples of these Species. Players will choose one for their character.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyRaceDefinition:  IEquatable<DestinyDefinitionsDestinyRaceDefinition>
    { 
        /// <summary>
        /// DisplayProperties
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; private set; }

        /// <summary>
        /// An enumeration defining the existing, known Races/Species for player characters. This value will be the enum value matching this definition.
        /// </summary>
        public int? RaceType { get; private set; }

        /// <summary>
        /// A localized string referring to the singular form of the Race&#39;s name when referred to in gendered form. Keyed by the DestinyGender.
        /// </summary>
        public Dictionary<string, string> GenderedRaceNames { get; private set; }

        /// <summary>
        /// GenderedRaceNamesByGenderHash
        /// </summary>
        public Dictionary<string, string> GenderedRaceNamesByGenderHash { get; private set; }

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
        /// Use DestinyDefinitionsDestinyRaceDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyRaceDefinition()
        {
        }

        private DestinyDefinitionsDestinyRaceDefinition(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties, int? RaceType, Dictionary<string, string> GenderedRaceNames, Dictionary<string, string> GenderedRaceNamesByGenderHash, int? Hash, int? Index, bool? Redacted)
        {
            
            this.DisplayProperties = DisplayProperties;
            
            this.RaceType = RaceType;
            
            this.GenderedRaceNames = GenderedRaceNames;
            
            this.GenderedRaceNamesByGenderHash = GenderedRaceNamesByGenderHash;
            
            this.Hash = Hash;
            
            this.Index = Index;
            
            this.Redacted = Redacted;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyRaceDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyRaceDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyRaceDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyRaceDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyRaceDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyRaceDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyRaceDefinitionBuilder With()
        {
            return Builder()
                .DisplayProperties(DisplayProperties)
                .RaceType(RaceType)
                .GenderedRaceNames(GenderedRaceNames)
                .GenderedRaceNamesByGenderHash(GenderedRaceNamesByGenderHash)
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

        public bool Equals(DestinyDefinitionsDestinyRaceDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyRaceDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyRaceDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyRaceDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyRaceDefinition left, DestinyDefinitionsDestinyRaceDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyRaceDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyRaceDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyRaceDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyRaceDefinition left, DestinyDefinitionsDestinyRaceDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyRaceDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyRaceDefinitionBuilder
        {
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _DisplayProperties;
            private int? _RaceType;
            private Dictionary<string, string> _GenderedRaceNames;
            private Dictionary<string, string> _GenderedRaceNamesByGenderHash;
            private int? _Hash;
            private int? _Index;
            private bool? _Redacted;

            internal DestinyDefinitionsDestinyRaceDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyRaceDefinition.DisplayProperties property.
            /// </summary>
            /// <param name="value">DisplayProperties</param>
            public DestinyDefinitionsDestinyRaceDefinitionBuilder DisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _DisplayProperties = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyRaceDefinition.RaceType property.
            /// </summary>
            /// <param name="value">An enumeration defining the existing, known Races/Species for player characters. This value will be the enum value matching this definition.</param>
            public DestinyDefinitionsDestinyRaceDefinitionBuilder RaceType(int? value)
            {
                _RaceType = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyRaceDefinition.GenderedRaceNames property.
            /// </summary>
            /// <param name="value">A localized string referring to the singular form of the Race&#39;s name when referred to in gendered form. Keyed by the DestinyGender.</param>
            public DestinyDefinitionsDestinyRaceDefinitionBuilder GenderedRaceNames(Dictionary<string, string> value)
            {
                _GenderedRaceNames = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyRaceDefinition.GenderedRaceNamesByGenderHash property.
            /// </summary>
            /// <param name="value">GenderedRaceNamesByGenderHash</param>
            public DestinyDefinitionsDestinyRaceDefinitionBuilder GenderedRaceNamesByGenderHash(Dictionary<string, string> value)
            {
                _GenderedRaceNamesByGenderHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyRaceDefinition.Hash property.
            /// </summary>
            /// <param name="value">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</param>
            public DestinyDefinitionsDestinyRaceDefinitionBuilder Hash(int? value)
            {
                _Hash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyRaceDefinition.Index property.
            /// </summary>
            /// <param name="value">The index of the entity as it was found in the investment tables.</param>
            public DestinyDefinitionsDestinyRaceDefinitionBuilder Index(int? value)
            {
                _Index = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyRaceDefinition.Redacted property.
            /// </summary>
            /// <param name="value">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</param>
            public DestinyDefinitionsDestinyRaceDefinitionBuilder Redacted(bool? value)
            {
                _Redacted = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyRaceDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyRaceDefinition</returns>
            public DestinyDefinitionsDestinyRaceDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyRaceDefinition(
                    DisplayProperties: _DisplayProperties,
                    RaceType: _RaceType,
                    GenderedRaceNames: _GenderedRaceNames,
                    GenderedRaceNamesByGenderHash: _GenderedRaceNamesByGenderHash,
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