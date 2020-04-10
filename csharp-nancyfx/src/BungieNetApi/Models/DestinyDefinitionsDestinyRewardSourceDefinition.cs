using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// Represents a heuristically-determined \&quot;item source\&quot; according to Bungie.net. These item sources are non-canonical: we apply a combination of special configuration and often-fragile heuristics to attempt to discern whether an item should be part of a given \&quot;source,\&quot; but we have known cases of false positives and negatives due to our imperfect heuristics.  Still, they provide a decent approximation for people trying to figure out how an item can be obtained. DestinyInventoryItemDefinition refers to sources in the sourceDatas.sourceHashes property for all sources we determined the item could spawn from.  An example in Destiny 1 of a Source would be \&quot;Nightfall\&quot;. If an item has the \&quot;Nightfall\&quot; source associated with it, it&#39;s extremely likely that you can earn that item while playing Nightfall, either during play or as an after-completion reward.
    /// </summary>
    public sealed class DestinyDefinitionsDestinyRewardSourceDefinition:  IEquatable<DestinyDefinitionsDestinyRewardSourceDefinition>
    { 
        /// <summary>
        /// DisplayProperties
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; private set; }

        /// <summary>
        /// Sources are grouped into categories: common ways that items are provided. I hope to see this expand in Destiny 2 once we have time to generate accurate reward source data.
        /// </summary>
        public int? Category { get; private set; }

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
        /// Use DestinyDefinitionsDestinyRewardSourceDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDestinyRewardSourceDefinition()
        {
        }

        private DestinyDefinitionsDestinyRewardSourceDefinition(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties, int? Category, int? Hash, int? Index, bool? Redacted)
        {
            
            this.DisplayProperties = DisplayProperties;
            
            this.Category = Category;
            
            this.Hash = Hash;
            
            this.Index = Index;
            
            this.Redacted = Redacted;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDestinyRewardSourceDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyRewardSourceDefinitionBuilder</returns>
        public static DestinyDefinitionsDestinyRewardSourceDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDestinyRewardSourceDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDestinyRewardSourceDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDestinyRewardSourceDefinitionBuilder</returns>
        public DestinyDefinitionsDestinyRewardSourceDefinitionBuilder With()
        {
            return Builder()
                .DisplayProperties(DisplayProperties)
                .Category(Category)
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

        public bool Equals(DestinyDefinitionsDestinyRewardSourceDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDestinyRewardSourceDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyRewardSourceDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyRewardSourceDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDestinyRewardSourceDefinition left, DestinyDefinitionsDestinyRewardSourceDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDestinyRewardSourceDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDestinyRewardSourceDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDestinyRewardSourceDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDestinyRewardSourceDefinition left, DestinyDefinitionsDestinyRewardSourceDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDestinyRewardSourceDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDestinyRewardSourceDefinitionBuilder
        {
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _DisplayProperties;
            private int? _Category;
            private int? _Hash;
            private int? _Index;
            private bool? _Redacted;

            internal DestinyDefinitionsDestinyRewardSourceDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyRewardSourceDefinition.DisplayProperties property.
            /// </summary>
            /// <param name="value">DisplayProperties</param>
            public DestinyDefinitionsDestinyRewardSourceDefinitionBuilder DisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _DisplayProperties = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyRewardSourceDefinition.Category property.
            /// </summary>
            /// <param name="value">Sources are grouped into categories: common ways that items are provided. I hope to see this expand in Destiny 2 once we have time to generate accurate reward source data.</param>
            public DestinyDefinitionsDestinyRewardSourceDefinitionBuilder Category(int? value)
            {
                _Category = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyRewardSourceDefinition.Hash property.
            /// </summary>
            /// <param name="value">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</param>
            public DestinyDefinitionsDestinyRewardSourceDefinitionBuilder Hash(int? value)
            {
                _Hash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyRewardSourceDefinition.Index property.
            /// </summary>
            /// <param name="value">The index of the entity as it was found in the investment tables.</param>
            public DestinyDefinitionsDestinyRewardSourceDefinitionBuilder Index(int? value)
            {
                _Index = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDestinyRewardSourceDefinition.Redacted property.
            /// </summary>
            /// <param name="value">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</param>
            public DestinyDefinitionsDestinyRewardSourceDefinitionBuilder Redacted(bool? value)
            {
                _Redacted = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDestinyRewardSourceDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDestinyRewardSourceDefinition</returns>
            public DestinyDefinitionsDestinyRewardSourceDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDestinyRewardSourceDefinition(
                    DisplayProperties: _DisplayProperties,
                    Category: _Category,
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