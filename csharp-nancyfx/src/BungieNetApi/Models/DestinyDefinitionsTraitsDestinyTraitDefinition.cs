using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyDefinitionsTraitsDestinyTraitDefinition
    /// </summary>
    public sealed class DestinyDefinitionsTraitsDestinyTraitDefinition:  IEquatable<DestinyDefinitionsTraitsDestinyTraitDefinition>
    { 
        /// <summary>
        /// DisplayProperties
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; private set; }

        /// <summary>
        /// TraitCategoryId
        /// </summary>
        public string TraitCategoryId { get; private set; }

        /// <summary>
        /// TraitCategoryHash
        /// </summary>
        public int? TraitCategoryHash { get; private set; }

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
        /// Use DestinyDefinitionsTraitsDestinyTraitDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsTraitsDestinyTraitDefinition()
        {
        }

        private DestinyDefinitionsTraitsDestinyTraitDefinition(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties, string TraitCategoryId, int? TraitCategoryHash, int? Hash, int? Index, bool? Redacted)
        {
            
            this.DisplayProperties = DisplayProperties;
            
            this.TraitCategoryId = TraitCategoryId;
            
            this.TraitCategoryHash = TraitCategoryHash;
            
            this.Hash = Hash;
            
            this.Index = Index;
            
            this.Redacted = Redacted;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsTraitsDestinyTraitDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsTraitsDestinyTraitDefinitionBuilder</returns>
        public static DestinyDefinitionsTraitsDestinyTraitDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsTraitsDestinyTraitDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsTraitsDestinyTraitDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsTraitsDestinyTraitDefinitionBuilder</returns>
        public DestinyDefinitionsTraitsDestinyTraitDefinitionBuilder With()
        {
            return Builder()
                .DisplayProperties(DisplayProperties)
                .TraitCategoryId(TraitCategoryId)
                .TraitCategoryHash(TraitCategoryHash)
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

        public bool Equals(DestinyDefinitionsTraitsDestinyTraitDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsTraitsDestinyTraitDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsTraitsDestinyTraitDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsTraitsDestinyTraitDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsTraitsDestinyTraitDefinition left, DestinyDefinitionsTraitsDestinyTraitDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsTraitsDestinyTraitDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsTraitsDestinyTraitDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsTraitsDestinyTraitDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsTraitsDestinyTraitDefinition left, DestinyDefinitionsTraitsDestinyTraitDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsTraitsDestinyTraitDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsTraitsDestinyTraitDefinitionBuilder
        {
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _DisplayProperties;
            private string _TraitCategoryId;
            private int? _TraitCategoryHash;
            private int? _Hash;
            private int? _Index;
            private bool? _Redacted;

            internal DestinyDefinitionsTraitsDestinyTraitDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsTraitsDestinyTraitDefinition.DisplayProperties property.
            /// </summary>
            /// <param name="value">DisplayProperties</param>
            public DestinyDefinitionsTraitsDestinyTraitDefinitionBuilder DisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _DisplayProperties = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsTraitsDestinyTraitDefinition.TraitCategoryId property.
            /// </summary>
            /// <param name="value">TraitCategoryId</param>
            public DestinyDefinitionsTraitsDestinyTraitDefinitionBuilder TraitCategoryId(string value)
            {
                _TraitCategoryId = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsTraitsDestinyTraitDefinition.TraitCategoryHash property.
            /// </summary>
            /// <param name="value">TraitCategoryHash</param>
            public DestinyDefinitionsTraitsDestinyTraitDefinitionBuilder TraitCategoryHash(int? value)
            {
                _TraitCategoryHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsTraitsDestinyTraitDefinition.Hash property.
            /// </summary>
            /// <param name="value">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</param>
            public DestinyDefinitionsTraitsDestinyTraitDefinitionBuilder Hash(int? value)
            {
                _Hash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsTraitsDestinyTraitDefinition.Index property.
            /// </summary>
            /// <param name="value">The index of the entity as it was found in the investment tables.</param>
            public DestinyDefinitionsTraitsDestinyTraitDefinitionBuilder Index(int? value)
            {
                _Index = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsTraitsDestinyTraitDefinition.Redacted property.
            /// </summary>
            /// <param name="value">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</param>
            public DestinyDefinitionsTraitsDestinyTraitDefinitionBuilder Redacted(bool? value)
            {
                _Redacted = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsTraitsDestinyTraitDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsTraitsDestinyTraitDefinition</returns>
            public DestinyDefinitionsTraitsDestinyTraitDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsTraitsDestinyTraitDefinition(
                    DisplayProperties: _DisplayProperties,
                    TraitCategoryId: _TraitCategoryId,
                    TraitCategoryHash: _TraitCategoryHash,
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