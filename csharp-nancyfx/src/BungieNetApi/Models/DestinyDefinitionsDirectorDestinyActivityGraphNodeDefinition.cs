using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace BungieNetApi._Platform.Models
{
    /// <summary>
    /// This is the position and other data related to nodes in the activity graph that you can click to launch activities. An Activity Graph node will only have one active Activity at a time, which will determine the activity to be launched (and, unless overrideDisplay information is provided, will also determine the tooltip and other UI related to the node)
    /// </summary>
    public sealed class DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinition:  IEquatable<DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinition>
    { 
        /// <summary>
        /// An identifier for the Activity Graph Node, only guaranteed to be unique within its parent Activity Graph.
        /// </summary>
        public int? NodeId { get; private set; }

        /// <summary>
        /// The node *may* have display properties that override the active Activity&#39;s display properties.
        /// </summary>
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition OverrideDisplay { get; private set; }

        /// <summary>
        /// The position on the map for this node.
        /// </summary>
        public DestinyDefinitionsCommonDestinyPositionDefinition Position { get; private set; }

        /// <summary>
        /// The node may have various visual accents placed on it, or styles applied. These are the list of possible styles that the Node can have. The game iterates through each, looking for the first one that passes a check of the required game/character/account state in order to show that style, and then renders the node in that style.
        /// </summary>
        public List<DestinyDefinitionsDirectorDestinyActivityGraphNodeFeaturingStateDefinition> FeaturingStates { get; private set; }

        /// <summary>
        /// The node may have various possible activities that could be active for it, however only one may be active at a time. See the DestinyActivityGraphNodeActivityDefinition for details.
        /// </summary>
        public List<DestinyDefinitionsDirectorDestinyActivityGraphNodeActivityDefinition> Activities { get; private set; }

        /// <summary>
        /// Represents possible states that the graph node can be in. These are combined with some checking that happens in the game client and server to determine which state is actually active at any given time.
        /// </summary>
        public List<DestinyDefinitionsDirectorDestinyActivityGraphNodeStateEntry> States { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinition.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinition()
        {
        }

        private DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinition(int? NodeId, DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition OverrideDisplay, DestinyDefinitionsCommonDestinyPositionDefinition Position, List<DestinyDefinitionsDirectorDestinyActivityGraphNodeFeaturingStateDefinition> FeaturingStates, List<DestinyDefinitionsDirectorDestinyActivityGraphNodeActivityDefinition> Activities, List<DestinyDefinitionsDirectorDestinyActivityGraphNodeStateEntry> States)
        {
            
            this.NodeId = NodeId;
            
            this.OverrideDisplay = OverrideDisplay;
            
            this.Position = Position;
            
            this.FeaturingStates = FeaturingStates;
            
            this.Activities = Activities;
            
            this.States = States;
            
        }

        /// <summary>
        /// Returns builder of DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinition.
        /// </summary>
        /// <returns>DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinitionBuilder</returns>
        public static DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinitionBuilder Builder()
        {
            return new DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinitionBuilder();
        }

        /// <summary>
        /// Returns DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinitionBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinitionBuilder</returns>
        public DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinitionBuilder With()
        {
            return Builder()
                .NodeId(NodeId)
                .OverrideDisplay(OverrideDisplay)
                .Position(Position)
                .FeaturingStates(FeaturingStates)
                .Activities(Activities)
                .States(States);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinition other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinition</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinition left, DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinition.
        /// </summary>
        /// <param name="left">Compared (DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinition</param>
        /// <param name="right">Compared (DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinition</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinition left, DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinition.
        /// </summary>
        public sealed class DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinitionBuilder
        {
            private int? _NodeId;
            private DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition _OverrideDisplay;
            private DestinyDefinitionsCommonDestinyPositionDefinition _Position;
            private List<DestinyDefinitionsDirectorDestinyActivityGraphNodeFeaturingStateDefinition> _FeaturingStates;
            private List<DestinyDefinitionsDirectorDestinyActivityGraphNodeActivityDefinition> _Activities;
            private List<DestinyDefinitionsDirectorDestinyActivityGraphNodeStateEntry> _States;

            internal DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinitionBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinition.NodeId property.
            /// </summary>
            /// <param name="value">An identifier for the Activity Graph Node, only guaranteed to be unique within its parent Activity Graph.</param>
            public DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinitionBuilder NodeId(int? value)
            {
                _NodeId = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinition.OverrideDisplay property.
            /// </summary>
            /// <param name="value">The node *may* have display properties that override the active Activity&#39;s display properties.</param>
            public DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinitionBuilder OverrideDisplay(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition value)
            {
                _OverrideDisplay = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinition.Position property.
            /// </summary>
            /// <param name="value">The position on the map for this node.</param>
            public DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinitionBuilder Position(DestinyDefinitionsCommonDestinyPositionDefinition value)
            {
                _Position = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinition.FeaturingStates property.
            /// </summary>
            /// <param name="value">The node may have various visual accents placed on it, or styles applied. These are the list of possible styles that the Node can have. The game iterates through each, looking for the first one that passes a check of the required game/character/account state in order to show that style, and then renders the node in that style.</param>
            public DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinitionBuilder FeaturingStates(List<DestinyDefinitionsDirectorDestinyActivityGraphNodeFeaturingStateDefinition> value)
            {
                _FeaturingStates = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinition.Activities property.
            /// </summary>
            /// <param name="value">The node may have various possible activities that could be active for it, however only one may be active at a time. See the DestinyActivityGraphNodeActivityDefinition for details.</param>
            public DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinitionBuilder Activities(List<DestinyDefinitionsDirectorDestinyActivityGraphNodeActivityDefinition> value)
            {
                _Activities = value;
                return this;
            }

            /// <summary>
            /// Sets value for DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinition.States property.
            /// </summary>
            /// <param name="value">Represents possible states that the graph node can be in. These are combined with some checking that happens in the game client and server to determine which state is actually active at any given time.</param>
            public DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinitionBuilder States(List<DestinyDefinitionsDirectorDestinyActivityGraphNodeStateEntry> value)
            {
                _States = value;
                return this;
            }


            /// <summary>
            /// Builds instance of DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinition.
            /// </summary>
            /// <returns>DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinition</returns>
            public DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinition Build()
            {
                Validate();
                return new DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinition(
                    NodeId: _NodeId,
                    OverrideDisplay: _OverrideDisplay,
                    Position: _Position,
                    FeaturingStates: _FeaturingStates,
                    Activities: _Activities,
                    States: _States
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}