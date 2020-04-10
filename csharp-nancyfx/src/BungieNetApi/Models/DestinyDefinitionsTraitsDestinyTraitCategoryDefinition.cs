using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyDefinitionsTraitsDestinyTraitCategoryDefinition
    /// </summary>
    public sealed class DestinyDefinitionsTraitsDestinyTraitCategoryDefinition:  IEquatable<DestinyDefinitionsTraitsDestinyTraitCategoryDefinition>
    { 
        /// <summary>
        /// TraitCategoryId
        /// </summary>
        public string TraitCategoryId { get; private set; }

        /// <summary>
        /// TraitHashes
        /// </summary>
        public List<int?> TraitHashes { get; private set; }

        /// <summary>
        /// TraitIds
        /// </summary>
        public List<string> TraitIds { get; private set; }

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
        /// Use DestinyDefinitionsTraitsDestinyTraitCategoryDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsTraitsDestinyTraitCategoryDefinition()
        {
        }

        private DestinyDefinitionsTraitsDestinyTraitCategoryDefinition(string TraitCategoryId, List<int?> TraitHashes, List<string> TraitIds, int? Hash, int? Index, bool? Redacted)
        {
            
            this.TraitCategoryId = TraitCategoryId;
            
            this.TraitHashes = TraitHashes;
            
            this.TraitIds = TraitIds;
            
            this.Hash = Hash;
            
            this.Index = Index;
            
            this.Redacted = Redacted;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsTraitsDestinyTraitCategoryDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsTraitsDestinyTraitCategoryDefinitionBuilder</returns>
        public static DestinyDefinitionsTraitsDestinyTraitCategoryDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsTraitsDestinyTraitCategoryDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsTraitsDestinyTraitCategoryDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsTraitsDestinyTraitCategoryDefinitionBuilder</returns>
        public DestinyDefinitionsTraitsDestinyTraitCategoryDefinitionBuilder With()
        {
            return Builder()
                .TraitCategoryId(TraitCategoryId)
                .TraitHashes(TraitHashes)
                .TraitIds(TraitIds)
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

        public bool Equals(DestinyDefinitionsTraitsDestinyTraitCategoryDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsTraitsDestinyTraitCategoryDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsTraitsDestinyTraitCategoryDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsTraitsDestinyTraitCategoryDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsTraitsDestinyTraitCategoryDefinition left, DestinyDefinitionsTraitsDestinyTraitCategoryDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsTraitsDestinyTraitCategoryDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsTraitsDestinyTraitCategoryDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsTraitsDestinyTraitCategoryDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsTraitsDestinyTraitCategoryDefinition left, DestinyDefinitionsTraitsDestinyTraitCategoryDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsTraitsDestinyTraitCategoryDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsTraitsDestinyTraitCategoryDefinitionBuilder
        {
            private string _TraitCategoryId;
            private List<int?> _TraitHashes;
            private List<string> _TraitIds;
            private int? _Hash;
            private int? _Index;
            private bool? _Redacted;

            internal DestinyDefinitionsTraitsDestinyTraitCategoryDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsTraitsDestinyTraitCategoryDefinition.TraitCategoryId property.
            /// </summary>
            /// <param name="value">TraitCategoryId</param>
            public DestinyDefinitionsTraitsDestinyTraitCategoryDefinitionBuilder TraitCategoryId(string value)
            {
                _TraitCategoryId = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsTraitsDestinyTraitCategoryDefinition.TraitHashes property.
            /// </summary>
            /// <param name="value">TraitHashes</param>
            public DestinyDefinitionsTraitsDestinyTraitCategoryDefinitionBuilder TraitHashes(List<int?> value)
            {
                _TraitHashes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsTraitsDestinyTraitCategoryDefinition.TraitIds property.
            /// </summary>
            /// <param name="value">TraitIds</param>
            public DestinyDefinitionsTraitsDestinyTraitCategoryDefinitionBuilder TraitIds(List<string> value)
            {
                _TraitIds = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsTraitsDestinyTraitCategoryDefinition.Hash property.
            /// </summary>
            /// <param name="value">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</param>
            public DestinyDefinitionsTraitsDestinyTraitCategoryDefinitionBuilder Hash(int? value)
            {
                _Hash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsTraitsDestinyTraitCategoryDefinition.Index property.
            /// </summary>
            /// <param name="value">The index of the entity as it was found in the investment tables.</param>
            public DestinyDefinitionsTraitsDestinyTraitCategoryDefinitionBuilder Index(int? value)
            {
                _Index = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsTraitsDestinyTraitCategoryDefinition.Redacted property.
            /// </summary>
            /// <param name="value">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</param>
            public DestinyDefinitionsTraitsDestinyTraitCategoryDefinitionBuilder Redacted(bool? value)
            {
                _Redacted = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsTraitsDestinyTraitCategoryDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsTraitsDestinyTraitCategoryDefinition</returns>
            public DestinyDefinitionsTraitsDestinyTraitCategoryDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsTraitsDestinyTraitCategoryDefinition(
                    TraitCategoryId: _TraitCategoryId,
                    TraitHashes: _TraitHashes,
                    TraitIds: _TraitIds,
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