using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Represents known info about a Destiny Artifact.  We cannot guarantee that artifact definitions will be immutable between seasons - in fact, we&#39;ve been told that they will be replaced between seasons. But this definition is built both to minimize the amount of lookups for related data that have to occur, and is built in hope that, if this plan changes, we will be able to accommodate it more easily.
    /// </summary>
    public sealed class DestinyDefinitionsArtifactsDestinyArtifactDefinition:  IEquatable<DestinyDefinitionsArtifactsDestinyArtifactDefinition>
    { 
        /// <summary>
        /// Any basic display info we know about the Artifact. Currently sourced from a related inventory item, but the source of this data is subject to change.
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; private set; }

        /// <summary>
        /// Any Geometry/3D info we know about the Artifact. Currently sourced from a related inventory item&#39;s gearset information, but the source of this data is subject to change.
        /// </summary>
        public DestinyDefinitionsDestinyItemTranslationBlockDefinition TranslationBlock { get; private set; }

        /// <summary>
        /// Any Tier/Rank data related to this artifact, listed in display order.  Currently sourced from a Vendor, but this source is subject to change.
        /// </summary>
        public List<DestinyDefinitionsArtifactsDestinyArtifactTierDefinition> Tiers { get; private set; }

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
        /// Use DestinyDefinitionsArtifactsDestinyArtifactDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsArtifactsDestinyArtifactDefinition()
        {
        }

        private DestinyDefinitionsArtifactsDestinyArtifactDefinition(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties, DestinyDefinitionsDestinyItemTranslationBlockDefinition TranslationBlock, List<DestinyDefinitionsArtifactsDestinyArtifactTierDefinition> Tiers, int? Hash, int? Index, bool? Redacted)
        {
            
            this.DisplayProperties = DisplayProperties;
            
            this.TranslationBlock = TranslationBlock;
            
            this.Tiers = Tiers;
            
            this.Hash = Hash;
            
            this.Index = Index;
            
            this.Redacted = Redacted;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsArtifactsDestinyArtifactDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsArtifactsDestinyArtifactDefinitionBuilder</returns>
        public static DestinyDefinitionsArtifactsDestinyArtifactDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsArtifactsDestinyArtifactDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsArtifactsDestinyArtifactDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsArtifactsDestinyArtifactDefinitionBuilder</returns>
        public DestinyDefinitionsArtifactsDestinyArtifactDefinitionBuilder With()
        {
            return Builder()
                .DisplayProperties(DisplayProperties)
                .TranslationBlock(TranslationBlock)
                .Tiers(Tiers)
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

        public bool Equals(DestinyDefinitionsArtifactsDestinyArtifactDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsArtifactsDestinyArtifactDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsArtifactsDestinyArtifactDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsArtifactsDestinyArtifactDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsArtifactsDestinyArtifactDefinition left, DestinyDefinitionsArtifactsDestinyArtifactDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsArtifactsDestinyArtifactDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsArtifactsDestinyArtifactDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsArtifactsDestinyArtifactDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsArtifactsDestinyArtifactDefinition left, DestinyDefinitionsArtifactsDestinyArtifactDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsArtifactsDestinyArtifactDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsArtifactsDestinyArtifactDefinitionBuilder
        {
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _DisplayProperties;
            private DestinyDefinitionsDestinyItemTranslationBlockDefinition _TranslationBlock;
            private List<DestinyDefinitionsArtifactsDestinyArtifactTierDefinition> _Tiers;
            private int? _Hash;
            private int? _Index;
            private bool? _Redacted;

            internal DestinyDefinitionsArtifactsDestinyArtifactDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsArtifactsDestinyArtifactDefinition.DisplayProperties property.
            /// </summary>
            /// <param name="value">Any basic display info we know about the Artifact. Currently sourced from a related inventory item, but the source of this data is subject to change.</param>
            public DestinyDefinitionsArtifactsDestinyArtifactDefinitionBuilder DisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _DisplayProperties = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsArtifactsDestinyArtifactDefinition.TranslationBlock property.
            /// </summary>
            /// <param name="value">Any Geometry/3D info we know about the Artifact. Currently sourced from a related inventory item&#39;s gearset information, but the source of this data is subject to change.</param>
            public DestinyDefinitionsArtifactsDestinyArtifactDefinitionBuilder TranslationBlock(DestinyDefinitionsDestinyItemTranslationBlockDefinition value)
            {
                _TranslationBlock = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsArtifactsDestinyArtifactDefinition.Tiers property.
            /// </summary>
            /// <param name="value">Any Tier/Rank data related to this artifact, listed in display order.  Currently sourced from a Vendor, but this source is subject to change.</param>
            public DestinyDefinitionsArtifactsDestinyArtifactDefinitionBuilder Tiers(List<DestinyDefinitionsArtifactsDestinyArtifactTierDefinition> value)
            {
                _Tiers = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsArtifactsDestinyArtifactDefinition.Hash property.
            /// </summary>
            /// <param name="value">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</param>
            public DestinyDefinitionsArtifactsDestinyArtifactDefinitionBuilder Hash(int? value)
            {
                _Hash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsArtifactsDestinyArtifactDefinition.Index property.
            /// </summary>
            /// <param name="value">The index of the entity as it was found in the investment tables.</param>
            public DestinyDefinitionsArtifactsDestinyArtifactDefinitionBuilder Index(int? value)
            {
                _Index = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsArtifactsDestinyArtifactDefinition.Redacted property.
            /// </summary>
            /// <param name="value">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</param>
            public DestinyDefinitionsArtifactsDestinyArtifactDefinitionBuilder Redacted(bool? value)
            {
                _Redacted = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsArtifactsDestinyArtifactDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsArtifactsDestinyArtifactDefinition</returns>
            public DestinyDefinitionsArtifactsDestinyArtifactDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsArtifactsDestinyArtifactDefinition(
                    DisplayProperties: _DisplayProperties,
                    TranslationBlock: _TranslationBlock,
                    Tiers: _Tiers,
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