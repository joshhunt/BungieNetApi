using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// This is the base class for all presentation system children. Presentation Nodes, Records, Collectibles, and Metrics.
    /// </summary>
    public sealed class DestinyDefinitionsPresentationDestinyPresentationNodeBaseDefinition:  IEquatable<DestinyDefinitionsPresentationDestinyPresentationNodeBaseDefinition>
    { 
        /// <summary>
        /// PresentationNodeType
        /// </summary>
        public int? PresentationNodeType { get; private set; }

        /// <summary>
        /// TraitIds
        /// </summary>
        public List<string> TraitIds { get; private set; }

        /// <summary>
        /// TraitHashes
        /// </summary>
        public List<int?> TraitHashes { get; private set; }

        /// <summary>
        /// A quick reference to presentation nodes that have this node as a child. Presentation nodes can be parented under multiple parents.
        /// </summary>
        public List<int?> ParentNodeHashes { get; private set; }

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
        /// Use DestinyDefinitionsPresentationDestinyPresentationNodeBaseDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsPresentationDestinyPresentationNodeBaseDefinition()
        {
        }

        private DestinyDefinitionsPresentationDestinyPresentationNodeBaseDefinition(int? PresentationNodeType, List<string> TraitIds, List<int?> TraitHashes, List<int?> ParentNodeHashes, int? Hash, int? Index, bool? Redacted)
        {
            
            this.PresentationNodeType = PresentationNodeType;
            
            this.TraitIds = TraitIds;
            
            this.TraitHashes = TraitHashes;
            
            this.ParentNodeHashes = ParentNodeHashes;
            
            this.Hash = Hash;
            
            this.Index = Index;
            
            this.Redacted = Redacted;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsPresentationDestinyPresentationNodeBaseDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsPresentationDestinyPresentationNodeBaseDefinitionBuilder</returns>
        public static DestinyDefinitionsPresentationDestinyPresentationNodeBaseDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsPresentationDestinyPresentationNodeBaseDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsPresentationDestinyPresentationNodeBaseDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsPresentationDestinyPresentationNodeBaseDefinitionBuilder</returns>
        public DestinyDefinitionsPresentationDestinyPresentationNodeBaseDefinitionBuilder With()
        {
            return Builder()
                .PresentationNodeType(PresentationNodeType)
                .TraitIds(TraitIds)
                .TraitHashes(TraitHashes)
                .ParentNodeHashes(ParentNodeHashes)
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

        public bool Equals(DestinyDefinitionsPresentationDestinyPresentationNodeBaseDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsPresentationDestinyPresentationNodeBaseDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsPresentationDestinyPresentationNodeBaseDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsPresentationDestinyPresentationNodeBaseDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsPresentationDestinyPresentationNodeBaseDefinition left, DestinyDefinitionsPresentationDestinyPresentationNodeBaseDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsPresentationDestinyPresentationNodeBaseDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsPresentationDestinyPresentationNodeBaseDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsPresentationDestinyPresentationNodeBaseDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsPresentationDestinyPresentationNodeBaseDefinition left, DestinyDefinitionsPresentationDestinyPresentationNodeBaseDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsPresentationDestinyPresentationNodeBaseDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsPresentationDestinyPresentationNodeBaseDefinitionBuilder
        {
            private int? _PresentationNodeType;
            private List<string> _TraitIds;
            private List<int?> _TraitHashes;
            private List<int?> _ParentNodeHashes;
            private int? _Hash;
            private int? _Index;
            private bool? _Redacted;

            internal DestinyDefinitionsPresentationDestinyPresentationNodeBaseDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsPresentationDestinyPresentationNodeBaseDefinition.PresentationNodeType property.
            /// </summary>
            /// <param name="value">PresentationNodeType</param>
            public DestinyDefinitionsPresentationDestinyPresentationNodeBaseDefinitionBuilder PresentationNodeType(int? value)
            {
                _PresentationNodeType = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsPresentationDestinyPresentationNodeBaseDefinition.TraitIds property.
            /// </summary>
            /// <param name="value">TraitIds</param>
            public DestinyDefinitionsPresentationDestinyPresentationNodeBaseDefinitionBuilder TraitIds(List<string> value)
            {
                _TraitIds = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsPresentationDestinyPresentationNodeBaseDefinition.TraitHashes property.
            /// </summary>
            /// <param name="value">TraitHashes</param>
            public DestinyDefinitionsPresentationDestinyPresentationNodeBaseDefinitionBuilder TraitHashes(List<int?> value)
            {
                _TraitHashes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsPresentationDestinyPresentationNodeBaseDefinition.ParentNodeHashes property.
            /// </summary>
            /// <param name="value">A quick reference to presentation nodes that have this node as a child. Presentation nodes can be parented under multiple parents.</param>
            public DestinyDefinitionsPresentationDestinyPresentationNodeBaseDefinitionBuilder ParentNodeHashes(List<int?> value)
            {
                _ParentNodeHashes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsPresentationDestinyPresentationNodeBaseDefinition.Hash property.
            /// </summary>
            /// <param name="value">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</param>
            public DestinyDefinitionsPresentationDestinyPresentationNodeBaseDefinitionBuilder Hash(int? value)
            {
                _Hash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsPresentationDestinyPresentationNodeBaseDefinition.Index property.
            /// </summary>
            /// <param name="value">The index of the entity as it was found in the investment tables.</param>
            public DestinyDefinitionsPresentationDestinyPresentationNodeBaseDefinitionBuilder Index(int? value)
            {
                _Index = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsPresentationDestinyPresentationNodeBaseDefinition.Redacted property.
            /// </summary>
            /// <param name="value">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</param>
            public DestinyDefinitionsPresentationDestinyPresentationNodeBaseDefinitionBuilder Redacted(bool? value)
            {
                _Redacted = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsPresentationDestinyPresentationNodeBaseDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsPresentationDestinyPresentationNodeBaseDefinition</returns>
            public DestinyDefinitionsPresentationDestinyPresentationNodeBaseDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsPresentationDestinyPresentationNodeBaseDefinition(
                    PresentationNodeType: _PresentationNodeType,
                    TraitIds: _TraitIds,
                    TraitHashes: _TraitHashes,
                    ParentNodeHashes: _ParentNodeHashes,
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