using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// As/if presentation nodes begin to host more entities as children, these lists will be added to. One list property exists per type of entity that can be treated as a child of this presentation node, and each holds the identifier of the entity and any associated information needed to display the UI for that entity (if anything)
    /// </summary>
    public sealed class DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlock:  IEquatable<DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlock>
    { 
        /// <summary>
        /// PresentationNodes
        /// </summary>
        public List<DestinyDefinitionsPresentationDestinyPresentationNodeChildEntry> PresentationNodes { get; private set; }

        /// <summary>
        /// Collectibles
        /// </summary>
        public List<DestinyDefinitionsPresentationDestinyPresentationNodeCollectibleChildEntry> Collectibles { get; private set; }

        /// <summary>
        /// Records
        /// </summary>
        public List<DestinyDefinitionsPresentationDestinyPresentationNodeRecordChildEntry> Records { get; private set; }

        /// <summary>
        /// Metrics
        /// </summary>
        public List<DestinyDefinitionsPresentationDestinyPresentationNodeMetricChildEntry> Metrics { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlock.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlock()
        {
        }

        private DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlock(List<DestinyDefinitionsPresentationDestinyPresentationNodeChildEntry> PresentationNodes, List<DestinyDefinitionsPresentationDestinyPresentationNodeCollectibleChildEntry> Collectibles, List<DestinyDefinitionsPresentationDestinyPresentationNodeRecordChildEntry> Records, List<DestinyDefinitionsPresentationDestinyPresentationNodeMetricChildEntry> Metrics)
        {
            
            this.PresentationNodes = PresentationNodes;
            
            this.Collectibles = Collectibles;
            
            this.Records = Records;
            
            this.Metrics = Metrics;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlock.
        /// </summary>
        /// <returns>DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlockBuilder</returns>
        public static DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlockBuilder Builder()
        {
            return new DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlockBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlockBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlockBuilder</returns>
        public DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlockBuilder With()
        {
            return Builder()
                .PresentationNodes(PresentationNodes)
                .Collectibles(Collectibles)
                .Records(Records)
                .Metrics(Metrics);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlock other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlock.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlock</param>
        /// <param name="right">Compared (DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlock</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlock left, DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlock right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlock.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlock</param>
        /// <param name="right">Compared (DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlock</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlock left, DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlock right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlock.
        /// </summary>
        public sealed class DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlockBuilder
        {
            private List<DestinyDefinitionsPresentationDestinyPresentationNodeChildEntry> _PresentationNodes;
            private List<DestinyDefinitionsPresentationDestinyPresentationNodeCollectibleChildEntry> _Collectibles;
            private List<DestinyDefinitionsPresentationDestinyPresentationNodeRecordChildEntry> _Records;
            private List<DestinyDefinitionsPresentationDestinyPresentationNodeMetricChildEntry> _Metrics;

            internal DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlockBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlock.PresentationNodes property.
            /// </summary>
            /// <param name="value">PresentationNodes</param>
            public DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlockBuilder PresentationNodes(List<DestinyDefinitionsPresentationDestinyPresentationNodeChildEntry> value)
            {
                _PresentationNodes = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlock.Collectibles property.
            /// </summary>
            /// <param name="value">Collectibles</param>
            public DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlockBuilder Collectibles(List<DestinyDefinitionsPresentationDestinyPresentationNodeCollectibleChildEntry> value)
            {
                _Collectibles = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlock.Records property.
            /// </summary>
            /// <param name="value">Records</param>
            public DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlockBuilder Records(List<DestinyDefinitionsPresentationDestinyPresentationNodeRecordChildEntry> value)
            {
                _Records = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlock.Metrics property.
            /// </summary>
            /// <param name="value">Metrics</param>
            public DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlockBuilder Metrics(List<DestinyDefinitionsPresentationDestinyPresentationNodeMetricChildEntry> value)
            {
                _Metrics = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlock.
            /// </summary>
            /// <returns>DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlock</returns>
            public DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlock Build()
            {
                Validate();
                return new DestinyDefinitionsPresentationDestinyPresentationNodeChildrenBlock(
                    PresentationNodes: _PresentationNodes,
                    Collectibles: _Collectibles,
                    Records: _Records,
                    Metrics: _Metrics
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}