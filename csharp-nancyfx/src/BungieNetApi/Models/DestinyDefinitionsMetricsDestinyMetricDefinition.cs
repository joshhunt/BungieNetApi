using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// DestinyDefinitionsMetricsDestinyMetricDefinition
    /// </summary>
    public sealed class DestinyDefinitionsMetricsDestinyMetricDefinition:  IEquatable<DestinyDefinitionsMetricsDestinyMetricDefinition>
    { 
        /// <summary>
        /// DisplayProperties
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; private set; }

        /// <summary>
        /// TrackingObjectiveHash
        /// </summary>
        public int? TrackingObjectiveHash { get; private set; }

        /// <summary>
        /// LowerValueIsBetter
        /// </summary>
        public bool? LowerValueIsBetter { get; private set; }

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
        /// Use DestinyDefinitionsMetricsDestinyMetricDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsMetricsDestinyMetricDefinition()
        {
        }

        private DestinyDefinitionsMetricsDestinyMetricDefinition(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties, int? TrackingObjectiveHash, bool? LowerValueIsBetter, int? PresentationNodeType, List<string> TraitIds, List<int?> TraitHashes, List<int?> ParentNodeHashes, int? Hash, int? Index, bool? Redacted)
        {
            
            this.DisplayProperties = DisplayProperties;
            
            this.TrackingObjectiveHash = TrackingObjectiveHash;
            
            this.LowerValueIsBetter = LowerValueIsBetter;
            
            this.PresentationNodeType = PresentationNodeType;
            
            this.TraitIds = TraitIds;
            
            this.TraitHashes = TraitHashes;
            
            this.ParentNodeHashes = ParentNodeHashes;
            
            this.Hash = Hash;
            
            this.Index = Index;
            
            this.Redacted = Redacted;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsMetricsDestinyMetricDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsMetricsDestinyMetricDefinitionBuilder</returns>
        public static DestinyDefinitionsMetricsDestinyMetricDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsMetricsDestinyMetricDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsMetricsDestinyMetricDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsMetricsDestinyMetricDefinitionBuilder</returns>
        public DestinyDefinitionsMetricsDestinyMetricDefinitionBuilder With()
        {
            return Builder()
                .DisplayProperties(DisplayProperties)
                .TrackingObjectiveHash(TrackingObjectiveHash)
                .LowerValueIsBetter(LowerValueIsBetter)
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

        public bool Equals(DestinyDefinitionsMetricsDestinyMetricDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsMetricsDestinyMetricDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsMetricsDestinyMetricDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsMetricsDestinyMetricDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsMetricsDestinyMetricDefinition left, DestinyDefinitionsMetricsDestinyMetricDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsMetricsDestinyMetricDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsMetricsDestinyMetricDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsMetricsDestinyMetricDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsMetricsDestinyMetricDefinition left, DestinyDefinitionsMetricsDestinyMetricDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsMetricsDestinyMetricDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsMetricsDestinyMetricDefinitionBuilder
        {
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _DisplayProperties;
            private int? _TrackingObjectiveHash;
            private bool? _LowerValueIsBetter;
            private int? _PresentationNodeType;
            private List<string> _TraitIds;
            private List<int?> _TraitHashes;
            private List<int?> _ParentNodeHashes;
            private int? _Hash;
            private int? _Index;
            private bool? _Redacted;

            internal DestinyDefinitionsMetricsDestinyMetricDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMetricsDestinyMetricDefinition.DisplayProperties property.
            /// </summary>
            /// <param name="value">DisplayProperties</param>
            public DestinyDefinitionsMetricsDestinyMetricDefinitionBuilder DisplayProperties(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _DisplayProperties = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMetricsDestinyMetricDefinition.TrackingObjectiveHash property.
            /// </summary>
            /// <param name="value">TrackingObjectiveHash</param>
            public DestinyDefinitionsMetricsDestinyMetricDefinitionBuilder TrackingObjectiveHash(int? value)
            {
                _TrackingObjectiveHash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMetricsDestinyMetricDefinition.LowerValueIsBetter property.
            /// </summary>
            /// <param name="value">LowerValueIsBetter</param>
            public DestinyDefinitionsMetricsDestinyMetricDefinitionBuilder LowerValueIsBetter(bool? value)
            {
                _LowerValueIsBetter = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMetricsDestinyMetricDefinition.PresentationNodeType property.
            /// </summary>
            /// <param name="value">PresentationNodeType</param>
            public DestinyDefinitionsMetricsDestinyMetricDefinitionBuilder PresentationNodeType(int? value)
            {
                _PresentationNodeType = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMetricsDestinyMetricDefinition.TraitIds property.
            /// </summary>
            /// <param name="value">TraitIds</param>
            public DestinyDefinitionsMetricsDestinyMetricDefinitionBuilder TraitIds(List<string> value)
            {
                _TraitIds = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMetricsDestinyMetricDefinition.TraitHashes property.
            /// </summary>
            /// <param name="value">TraitHashes</param>
            public DestinyDefinitionsMetricsDestinyMetricDefinitionBuilder TraitHashes(List<int?> value)
            {
                _TraitHashes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMetricsDestinyMetricDefinition.ParentNodeHashes property.
            /// </summary>
            /// <param name="value">A quick reference to presentation nodes that have this node as a child. Presentation nodes can be parented under multiple parents.</param>
            public DestinyDefinitionsMetricsDestinyMetricDefinitionBuilder ParentNodeHashes(List<int?> value)
            {
                _ParentNodeHashes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMetricsDestinyMetricDefinition.Hash property.
            /// </summary>
            /// <param name="value">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</param>
            public DestinyDefinitionsMetricsDestinyMetricDefinitionBuilder Hash(int? value)
            {
                _Hash = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMetricsDestinyMetricDefinition.Index property.
            /// </summary>
            /// <param name="value">The index of the entity as it was found in the investment tables.</param>
            public DestinyDefinitionsMetricsDestinyMetricDefinitionBuilder Index(int? value)
            {
                _Index = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsMetricsDestinyMetricDefinition.Redacted property.
            /// </summary>
            /// <param name="value">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</param>
            public DestinyDefinitionsMetricsDestinyMetricDefinitionBuilder Redacted(bool? value)
            {
                _Redacted = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsMetricsDestinyMetricDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsMetricsDestinyMetricDefinition</returns>
            public DestinyDefinitionsMetricsDestinyMetricDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsMetricsDestinyMetricDefinition(
                    DisplayProperties: _DisplayProperties,
                    TrackingObjectiveHash: _TrackingObjectiveHash,
                    LowerValueIsBetter: _LowerValueIsBetter,
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