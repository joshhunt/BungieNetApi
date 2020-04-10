using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Defines a Character Class in Destiny 2. These are types of characters you can play, like Titan, Warlock, and Hunter.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyClassDefinition:  IEquatable<DestinyDefinitionsDestinyClassDefinition>
    { 
        /// <summary>
        /// In Destiny 1, we added a convenience Enumeration for referring to classes. We&#39;ve kept it, though mostly for posterity. This is the enum value for this definition&#39;s class.
        /// </summary>
        public int? ClassType { get; private set; }

        /// <summary>
        /// DisplayProperties
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; private set; }

        /// <summary>
        /// A localized string referring to the singular form of the Class&#39;s name when referred to in gendered form. Keyed by the DestinyGender.
        /// </summary>
        public Dictionary<string, string> GenderedClassNames { get; private set; }

        /// <summary>
        /// GenderedClassNamesByGenderHash
        /// </summary>
        public Dictionary<string, string> GenderedClassNamesByGenderHash { get; private set; }

        /// <summary>
        /// Mentors don&#39;t really mean anything anymore. Don&#39;t expect this to be populated.
        /// </summary>
        public int? MentorVendorHash { get; private set; }

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
        /// Use DestinyDefinitionsDestinyClassDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyClassDefinition()
        {
        }

        private DestinyDefinitionsDestinyClassDefinition(int? ClassType, DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties, Dictionary<string, string> GenderedClassNames, Dictionary<string, string> GenderedClassNamesByGenderHash, int? MentorVendorHash, int? Hash, int? Index, bool? Redacted)
        {
            
            this.ClassType = ClassType;
            
            this.DisplayProperties = DisplayProperties;
            
            this.GenderedClassNames = GenderedClassNames;
            
            this.GenderedClassNamesByGenderHash = GenderedClassNamesByGenderHash;
            
            this.MentorVendorHash = MentorVendorHash;
            
            this.Hash = Hash;
            
            this.Index = Index;
            
            this.Redacted = Redacted;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyClassDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyClassDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyClassDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyClassDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyClassDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyClassDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyClassDefinitionBuilder With()
        {
            return Builder()
                .ClassType(ClassType)
                .DisplayProperties(DisplayProperties)
                .GenderedClassNames(GenderedClassNames)
                .GenderedClassNamesByGenderHash(GenderedClassNamesByGenderHash)
                .MentorVendorHash(MentorVendorHash)
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

        public bool Equals(DestinyDefinitionsDestinyClassDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyClassDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyClassDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyClassDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyClassDefinition left, DestinyDefinitionsDestinyClassDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyClassDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyClassDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyClassDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyClassDefinition left, DestinyDefinitionsDestinyClassDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyClassDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyClassDefinitionBuilder
        {
            private int? _ClassType;
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _DisplayProperties;
            private Dictionary<string, string> _GenderedClassNames;
            private Dictionary<string, string> _GenderedClassNamesByGenderHash;
            private int? _MentorVendorHash;
            private int? _Hash;
            private int? _Index;
            private bool? _Redacted;

            internal DestinyDefinitionsDestinyClassDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyClassDefinition.ClassType property.
            /// </summary>
            /// <param name="value">In Destiny 1, we added a convenience Enumeration for referring to classes. We&#39;ve kept it, though mostly for posterity. This is the enum value for this definition&#39;s class.</param>
            public DestinyDefinitionsDestinyClassDefinitionBuilder ClassType(int? value)
            {
                _ClassType = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyClassDefinition.DisplayProperties property.
            /// </summary>
            /// <param name="value">DisplayProperties</param>
            public DestinyDefinitionsDestinyClassDefinitionBuilder DisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _DisplayProperties = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyClassDefinition.GenderedClassNames property.
            /// </summary>
            /// <param name="value">A localized string referring to the singular form of the Class&#39;s name when referred to in gendered form. Keyed by the DestinyGender.</param>
            public DestinyDefinitionsDestinyClassDefinitionBuilder GenderedClassNames(Dictionary<string, string> value)
            {
                _GenderedClassNames = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyClassDefinition.GenderedClassNamesByGenderHash property.
            /// </summary>
            /// <param name="value">GenderedClassNamesByGenderHash</param>
            public DestinyDefinitionsDestinyClassDefinitionBuilder GenderedClassNamesByGenderHash(Dictionary<string, string> value)
            {
                _GenderedClassNamesByGenderHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyClassDefinition.MentorVendorHash property.
            /// </summary>
            /// <param name="value">Mentors don&#39;t really mean anything anymore. Don&#39;t expect this to be populated.</param>
            public DestinyDefinitionsDestinyClassDefinitionBuilder MentorVendorHash(int? value)
            {
                _MentorVendorHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyClassDefinition.Hash property.
            /// </summary>
            /// <param name="value">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</param>
            public DestinyDefinitionsDestinyClassDefinitionBuilder Hash(int? value)
            {
                _Hash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyClassDefinition.Index property.
            /// </summary>
            /// <param name="value">The index of the entity as it was found in the investment tables.</param>
            public DestinyDefinitionsDestinyClassDefinitionBuilder Index(int? value)
            {
                _Index = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyClassDefinition.Redacted property.
            /// </summary>
            /// <param name="value">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</param>
            public DestinyDefinitionsDestinyClassDefinitionBuilder Redacted(bool? value)
            {
                _Redacted = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyClassDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyClassDefinition</returns>
            public DestinyDefinitionsDestinyClassDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyClassDefinition(
                    ClassType: _ClassType,
                    DisplayProperties: _DisplayProperties,
                    GenderedClassNames: _GenderedClassNames,
                    GenderedClassNamesByGenderHash: _GenderedClassNamesByGenderHash,
                    MentorVendorHash: _MentorVendorHash,
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